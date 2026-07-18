#r "nuget: Microsoft.CodeAnalysis.CSharp, 4.11.0"

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

if (Args.Count < 2)
{
    Console.Error.WriteLine("Użycie: dotnet script scan-props.csx -- <NazwaRekordu> <KatalogDll>");
    Console.Error.WriteLine("Przykład: dotnet script scan-props.csx -- DokumentHandlowy ./bin/Debug/net10.0");
    return 1;
}

var recordBaseName = Args[0];
var dllDir = Path.GetFullPath(Args[1]);
var nestedTypeName = recordBaseName + "Record";

if (!Directory.Exists(dllDir))
{
    Console.Error.WriteLine($"Katalog nie istnieje: {dllDir}");
    return 1;
}

var dllPaths = Directory.EnumerateFiles(dllDir, "*.dll", SearchOption.TopDirectoryOnly).ToList();
if (dllPaths.Count == 0)
{
    Console.Error.WriteLine($"Brak plików *.dll w katalogu: {dllDir}");
    return 1;
}

var refs = new List<MetadataReference>();
var addedPaths = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
foreach (var p in dllPaths)
{
    try
    {
        refs.Add(MetadataReference.CreateFromFile(p));
        addedPaths.Add(Path.GetFileName(p));
    }
    catch (Exception ex) { Console.Error.WriteLine($"# Pominięto {Path.GetFileName(p)}: {ex.Message}"); }
}

// Dodaj referencje do bibliotek runtime'u .NET (TPA — Trusted Platform Assemblies),
// żeby Roslyn potrafił rozwiązać atrybuty typu System.ComponentModel.DescriptionAttribute
// i zdekodować ich argumenty konstruktora.
var tpa = (AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") as string ?? "")
    .Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries);
foreach (var path in tpa)
{
    var name = Path.GetFileName(path);
    if (addedPaths.Contains(name)) continue;
    try
    {
        refs.Add(MetadataReference.CreateFromFile(path));
        addedPaths.Add(name);
    }
    catch { /* pomiń */ }
}

var compilation = CSharpCompilation.Create("Scan")
    .WithOptions(new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary))
    .AddReferences(refs);

INamedTypeSymbol foundRecord = null;
INamedTypeSymbol enclosing = null;

// Indeks publicznych klas najwyższego poziomu po nazwie (do wyszukiwania
// klas biznesowych — głównej oraz dla subrowów).
var topLevelClasses = new Dictionary<string, INamedTypeSymbol>(StringComparer.Ordinal);

foreach (var asmRef in compilation.References)
{
    if (compilation.GetAssemblyOrModuleSymbol(asmRef) is not IAssemblySymbol asm) continue;
    foreach (var type in EnumerateAllTypes(asm.GlobalNamespace))
    {
        if (foundRecord == null && type.Name.EndsWith("Module"))
        {
            var nested = type.GetTypeMembers(nestedTypeName).FirstOrDefault();
            if (nested != null)
            {
                foundRecord = nested;
                enclosing = type;
            }
        }
        if (type.ContainingType == null
            && type.TypeKind == TypeKind.Class
            && type.DeclaredAccessibility == Accessibility.Public)
        {
            topLevelClasses.TryAdd(type.Name, type);
        }
    }
}

if (foundRecord == null)
{
    Console.Error.WriteLine($"Nie znaleziono typu *Module+{nestedTypeName} w {dllDir}");
    return 2;
}

INamedTypeSymbol mainBusinessClass = null;
topLevelClasses.TryGetValue(recordBaseName, out mainBusinessClass);

// Nazwa tabeli wyciągana z typu zwracanego przez property `Table` w klasie XxxxRow.
string tableTypeName = null;
bool isConfigTable = false;
var rowClass = enclosing?.GetTypeMembers(recordBaseName + "Row").FirstOrDefault();
if (rowClass != null)
{
    for (var t = rowClass; t != null && t.SpecialType != SpecialType.System_Object; t = t.BaseType)
    {
        var tableProp = t.GetMembers("Table").OfType<IPropertySymbol>().FirstOrDefault();
        if (tableProp != null)
        {
            tableTypeName = tableProp.Type.Name;
            break;
        }
    }
}
// Atrybut [TableInfo(IsConfig=true)] siedzi na klasie zagnieżdżonej XxxxModule.XxxxTable
// (nie na top-level typie tabeli zwracanym przez property `Table` w *Row).
var nestedTableCls = enclosing?.GetTypeMembers(recordBaseName + "Table").FirstOrDefault();
if (nestedTableCls != null)
    isConfigTable = IsConfigTable(nestedTableCls);

// Tytuł/Opis tabeli — atrybuty [Caption]/[Description] na klasie *Table (fallback: *Row).
// Opisują całą tabelę (zwykle l.mn., np. „Dokumenty handlowe"), niezależnie od opisów pól.
var tableCaption = GetAttributeFirstString(nestedTableCls, "CaptionAttribute");
if (string.IsNullOrEmpty(tableCaption)) tableCaption = GetAttributeFirstString(rowClass, "CaptionAttribute");
var tableDescription = GetAttributeFirstString(nestedTableCls, "DescriptionAttribute");
if (string.IsNullOrEmpty(tableDescription)) tableDescription = GetAttributeFirstString(rowClass, "DescriptionAttribute");

// Wyznacz status guided: root (dziedziczy po GuidedTable/ExportedTable) lub child→ParentRow
// (pole rekordu z [ColumnInfo(GuidedRelation=...)]). Pole zapamiętujemy też w guidedParentField,
// żeby oznaczyć je później w tabeli pól.
var isGuidedRoot = nestedTableCls != null && InheritsFromGuidedOrExportedTable(nestedTableCls);
string guidedParentField = null;
string guidedParentType = null;
if (!isGuidedRoot)
    (guidedParentField, guidedParentType) = FindGuidedParent(foundRecord, rowClass);

// Klucz: nazwa pola z notacją kropkową dla subrowów; Wartość: (typ, symbol typu, czyBazodanowe,
// czyTylkoOdczyt, tytuł, opis). Symbol typu (Sym) niesie informację potrzebną do rozpoznania
// enuma (TypeKind.Enum, także pod Nullable<>). ReadOnly = property biznesowa bez publicznego settera.
var merged = new SortedDictionary<string, (string Type, ITypeSymbol Sym, bool IsDb, bool ReadOnly, bool IsSubRow, string Caption, string Description)>(StringComparer.Ordinal);

var visited = new HashSet<INamedTypeSymbol>(SymbolEqualityComparer.Default);
ScanRecord(foundRecord, "", visited, merged, topLevelClasses);

if (mainBusinessClass != null)
{
    Console.WriteLine($"# Pola i właściwości klasy biznesowej: `{mainBusinessClass.ToDisplayString()}`");
}
else
{
    Console.WriteLine($"# Pola i właściwości `{enclosing.ToDisplayString()}+{nestedTypeName}`");
    Console.WriteLine();
    Console.WriteLine($"Nie znaleziono klasy biznesowej `{recordBaseName}` — pokazano tylko pola bazodanowe.");
}
if (!string.IsNullOrEmpty(tableTypeName))
{
    Console.WriteLine($"Nazwa tabeli: `{tableTypeName}`");
    if (!string.IsNullOrEmpty(tableCaption)) Console.WriteLine($"Tytuł: {InlineText(tableCaption)}");
    if (!string.IsNullOrEmpty(tableDescription)) Console.WriteLine($"Opis: {InlineText(tableDescription)}");
    Console.WriteLine($"Tabela konfiguracyjna: {(isConfigTable ? "Tak" : "Nie")}");
    if (isGuidedRoot)
        Console.WriteLine("Guided: root");
    else if (guidedParentField != null)
        Console.WriteLine($"Guided: child — nadrzędna przez pole `{guidedParentField}` → `{guidedParentType}`");
    // Wersjonowanie historią: tabela historyczna (IRowWithHistory) trzyma wersje w tabeli-historii,
    // tabela-historia (IHistory) to pojedynczy zapis historyczny obiektu nadrzędnego (guided-parent).
    if (mainBusinessClass != null)
    {
        if (mainBusinessClass.AllInterfaces.Any(i => i.Name == "IRowWithHistory"))
        {
            var histType = FindHistoryType(mainBusinessClass);
            Console.WriteLine(histType != null
                ? $"Historyczna: Tak — wersje (historia) w tabeli `{histType}`"
                : "Historyczna: Tak");
        }
        if (mainBusinessClass.AllInterfaces.Any(i => i.Name == "IHistory"))
            Console.WriteLine(guidedParentType != null
                ? $"Historia: Tak — zapis historyczny tabeli `{guidedParentType}`"
                : "Historia: Tak");
    }
    var thisInterfaces = nestedTableCls != null ? GetTableInterfaces(nestedTableCls).ToList() : new System.Collections.Generic.List<string>();
    if (thisInterfaces.Count > 0)
        Console.WriteLine($"Implementuje interfejsy: {string.Join(", ", thisInterfaces.Select(i => "`" + i + "`"))}");
}

// Indeks interfejs → lista tabel implementujących, na potrzeby pokazania alternatyw
// dla pól o typie interfejsowym (relacje interfejsowe Soneta). Klasy *Table są zagnieżdżone
// w *Module — iterujemy po top-level *Module i pobieramy ich nested types.
var interfaceImpls = new SortedDictionary<string, System.Collections.Generic.List<string>>(StringComparer.Ordinal);
foreach (var asmRef in compilation.References)
{
    if (compilation.GetAssemblyOrModuleSymbol(asmRef) is not IAssemblySymbol asm) continue;
    foreach (var top in EnumerateAllTypes(asm.GlobalNamespace))
    {
        if (top.ContainingType != null || !top.Name.EndsWith("Module")) continue;
        foreach (var t in top.GetTypeMembers())
        {
            if (!t.Name.EndsWith("Table")) continue;
            foreach (var iface in GetTableInterfaces(t))
            {
                if (!interfaceImpls.TryGetValue(iface, out var list))
                    interfaceImpls[iface] = list = new System.Collections.Generic.List<string>();
                var rowName = t.Name.Substring(0, t.Name.Length - "Table".Length);
                list.Add(rowName);
            }
        }
    }
}
// Deterministyczna kolejność tabel implementujących (spójna z export-props-all.csx).
foreach (var list in interfaceImpls.Values)
    list.Sort(StringComparer.Ordinal);
Console.WriteLine();
// Rozłączny rozkład wg roli (każde pole w dokładnie jednej kategorii; sumują się do całości).
// Priorytet: subrow > podlista > tylko-odczyt > bazodanowe/kalkulowane (zapisywalne).
int subRowCount = 0, subListCount = 0, readOnlyCount = 0, dbCount = 0, calcCount = 0;
foreach (var v in merged.Values)
{
    if (v.IsSubRow) subRowCount++;
    else if (IsSubListType(v.Sym)) subListCount++;
    else if (v.ReadOnly) readOnlyCount++;
    else if (v.IsDb) dbCount++;
    else calcCount++;
}
Console.WriteLine($"- pola bazodanowe (zapisywalne): {dbCount}");
Console.WriteLine($"- pola kalkulowane (zapisywalne): {calcCount}");
Console.WriteLine($"- pola tylko-odczyt: {readOnlyCount}");
Console.WriteLine($"- podlisty: {subListCount}");
Console.WriteLine($"- subrowy: {subRowCount}");
Console.WriteLine($"- razem: {merged.Count}");
Console.WriteLine();
Console.WriteLine("| Pole | Typ | Rodzaj | Tytuł | Opis |");
Console.WriteLine("|------|-----|--------|-------|------|");
var interfaceFields = new System.Collections.Generic.List<(string Field, string IfaceShort, System.Collections.Generic.List<string> Impls)>();
// Enumy użyte w polach tej tabeli (klucz = pełna nazwa, wartość = symbol) — do sekcji `## Enumy`.
var enumsUsed = new SortedDictionary<string, INamedTypeSymbol>(StringComparer.Ordinal);
foreach (var kv in merged)
{
    var isSubRow = kv.Value.IsSubRow;
    var isSubList = !isSubRow && IsSubListType(kv.Value.Sym);
    var tags = new System.Collections.Generic.List<string>();
    if (kv.Value.IsDb) tags.Add("bazodanowe");
    // Znacznik roli, gdy pola nie ustawia się wprost: subrow → `(subrow)` w typie; kolekcja/
    // podlista → `podlista`; pozostałe get-only → `tylko-odczyt`.
    if (isSubList) tags.Add("podlista");
    else if (kv.Value.ReadOnly && !isSubRow) tags.Add("tylko-odczyt");
    if (guidedParentField != null && kv.Key == guidedParentField) tags.Add("guided-parent");
    var shortType = ShortTypeName(kv.Value.Type);
    if (shortType.StartsWith("I") && shortType.Length > 1 && char.IsUpper(shortType[1])
        && interfaceImpls.TryGetValue(shortType, out var impls))
    {
        tags.Add("iface-ref");
        interfaceFields.Add((kv.Key, shortType, impls));
    }
    // Enum/subrow: sygnalizowane w kolumnie `Typ` (sufiks „(enum)"/„(subrow)"), nie w `Rodzaj`.
    var en = AsEnum(kv.Value.Sym);
    if (en != null) enumsUsed[en.ToDisplayString()] = en;
    var typeSuffix = en != null ? " (enum)" : (isSubRow ? " (subrow)" : "");
    var typeCol = "`" + PrettyType(kv.Value.Type) + "`" + typeSuffix;
    Console.WriteLine($"| {kv.Key} | {typeCol} | {string.Join(", ", tags)} | {EscapeCell(kv.Value.Caption)} | {EscapeCell(kv.Value.Description)} |");
}

if (interfaceFields.Count > 0)
{
    Console.WriteLine();
    Console.WriteLine("## Relacje interfejsowe");
    Console.WriteLine();
    Console.WriteLine("Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.");
    Console.WriteLine("Pole może wskazywać na rekord dowolnej z poniższych tabel.");
    Console.WriteLine();
    Console.WriteLine("| Pole | Interfejs | Tabele implementujące |");
    Console.WriteLine("|------|-----------|------------------------|");
    foreach (var f in interfaceFields)
    {
        Console.WriteLine($"| {f.Field} | `{f.IfaceShort}` | {string.Join(", ", f.Impls.Select(i => "`" + i + "`"))} |");
    }
}

if (enumsUsed.Count > 0)
{
    Console.WriteLine();
    Console.WriteLine("## Enumy");
    Console.WriteLine();
    Console.WriteLine("Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).");
    foreach (var en in enumsUsed.Values)
    {
        Console.WriteLine();
        Console.WriteLine($"### {en.Name} (`{PrettyType(en.ToDisplayString())}`)");
        foreach (var (name, value, caption) in GetEnumMembers(en))
            Console.WriteLine(string.IsNullOrEmpty(caption) ? $"- `{name}` = {value}" : $"- `{name}` = {value} — {EscapeCell(caption)}");
    }
}
return 0;

static string ShortTypeName(string fullName)
{
    if (string.IsNullOrEmpty(fullName)) return "";
    var lt = fullName.IndexOf('<');
    if (lt >= 0) fullName = fullName.Substring(0, lt);
    var dot = fullName.LastIndexOf('.');
    return dot >= 0 ? fullName.Substring(dot + 1) : fullName;
}

// Skraca zbędne prefiksy przestrzeni nazw w wyświetlanym typie (także w argumentach generycznych):
// `Soneta.Business.` i `Soneta.Types.` → puste (np. `Soneta.Business.Key` → `Key`, `Soneta.Types.DoubleCy` → `DoubleCy`).
static string PrettyType(string t) =>
    string.IsNullOrEmpty(t) ? t : t.Replace("Soneta.Business.", "").Replace("Soneta.Types.", "");

// Dla tabeli historycznej (IRowWithHistory) — nazwa typu rekordu historii: pierwsze property
// (także indekser), którego typ jest klasą implementującą `IHistory` (np. `Pracownik` → `PracHistoria`).
static string FindHistoryType(INamedTypeSymbol bizCls)
{
    if (bizCls == null) return null;
    foreach (var p in EnumerateInheritedProperties(bizCls))
    {
        if (p.DeclaredAccessibility != Accessibility.Public) continue;
        if (p.Type is INamedTypeSymbol pt && pt.TypeKind == TypeKind.Class
            && pt.AllInterfaces.Any(i => i.Name == "IHistory"))
            return pt.Name;
    }
    return null;
}

// Pole/property oznaczone [Obsolete] — pomijamy w wyniku (przestarzałe, nie używać).
static bool IsObsolete(ISymbol s) =>
    s.GetAttributes().Any(a => a.AttributeClass?.Name is "ObsoleteAttribute" or "Obsolete");

// Property jest tylko-do-odczytu, gdy nie ma settera albo setter nie jest publiczny
// (z perspektywy kodu/importu XML nie da się jej ustawić).
static bool IsReadOnlyProp(IPropertySymbol p) =>
    p.SetMethod == null || p.SetMethod.DeclaredAccessibility != Accessibility.Public;

// „Podlista" — typ kolekcyjny/posiadany: tablica, `Key`, `View`, `SubTable` oraz dowolny typ
// implementujący `IEnumerable` (List<T>, kolekcje) — poza `string`. Takie pola oznaczamy
// `podlista` zamiast `tylko-odczyt` (nie ustawia się ich wprost — dodaje się elementy).
static bool IsSubListType(ITypeSymbol type)
{
    if (type is IArrayTypeSymbol) return true;
    if (type is not INamedTypeSymbol n) return false;
    if (n.SpecialType == SpecialType.System_String) return false;
    // Wyjątki — typy „wartościowe" mimo IEnumerable (nie są podlistą, ustawia się je wprost).
    if (n.Name is "Periods") return false;
    if (n.Name is "Key" or "View") return true;
    return n.AllInterfaces.Any(i => i.Name == "IEnumerable");
}

static void ScanRecord(
    INamedTypeSymbol record,
    string prefix,
    HashSet<INamedTypeSymbol> visited,
    SortedDictionary<string, (string Type, ITypeSymbol Sym, bool IsDb, bool ReadOnly, bool IsSubRow, string Caption, string Description)> merged,
    Dictionary<string, INamedTypeSymbol> topLevelClasses)
{
    if (record == null) return;
    if (!visited.Add(record)) return;

    var fields = record.GetMembers()
        .OfType<IFieldSymbol>()
        .Where(f => f.DeclaredAccessibility == Accessibility.Public && !IsObsolete(f))
        .ToList();

    var encMod = record.ContainingType;
    var baseName = record.Name.EndsWith("Record")
        ? record.Name.Substring(0, record.Name.Length - "Record".Length)
        : record.Name;

    INamedTypeSymbol bizCls = null;
    topLevelClasses.TryGetValue(baseName, out bizCls);
    var rowFallback = encMod?.GetTypeMembers(baseName + "Row").FirstOrDefault();

    // 1. Pola rekordu → bazodanowe (zapisywalne — read-only rozstrzyga property biznesowa w kroku 2).
    // Subrow = pole rekordowe typu `*Record` (osadzony kontener, po którym rekurujemy w kroku 4);
    // to NIE to samo co `Key`/`SubTable` (choć te też bywają read-only).
    foreach (var f in fields)
    {
        var key = prefix + f.Name;
        var isSub = f.Type is INamedTypeSymbol nt && nt.TypeKind == TypeKind.Class && nt.Name.EndsWith("Record");
        merged[key] = (
            f.Type.ToDisplayString(),
            f.Type,
            true,
            false,
            isSub,
            GetAttributeFirstString(f, "CaptionAttribute"),
            GetAttributeFirstString(f, "DescriptionAttribute"));
    }

    // 2. Właściwości klasy biznesowej (z dziedziczeniem) → kalkulowane lub nadpisanie pola bazodanowego.
    if (bizCls != null)
    {
        // Nazwy property infrastrukturalnych — zdefiniowanych w bazowych klasach ORM
        // Row / GuidedRow / ExportedRow (np. ID, Guid, State, Session, Table, Module, Stamp).
        // Łapiemy je po NAZWIE, bo klasy generowane potrafią je redeklarować (`new`) ze
        // zawężonym typem zwracanym (np. Table→Towary, Module→TowaryModule) — wtedy ich
        // ContainingType wskazuje na klasę pochodną, nie na Row.
        var infrastructureNames = CollectInfrastructurePropertyNames(bizCls);
        var seen = new HashSet<string>(StringComparer.Ordinal);
        foreach (var p in EnumerateInheritedProperties(bizCls))
        {
            if (p.DeclaredAccessibility != Accessibility.Public || p.IsStatic || p.IsIndexer || p.GetMethod == null)
                continue;
            // Property z [Obsolete] pomijamy; jeśli nadpisywała pole rekordowe (krok 1) — usuwamy je.
            if (IsObsolete(p)) { merged.Remove(prefix + p.Name); seen.Add(p.Name); continue; }
            if (!seen.Add(p.Name)) continue;
            // Pomijamy property infrastrukturalne, o ile nie pokrywają się z bazodanowym polem
            // rekordu (krok 1) — te zostają nietknięte.
            if (infrastructureNames.Contains(p.Name) && !merged.ContainsKey(prefix + p.Name)) continue;
            var key = prefix + p.Name;
            var typeStr = p.Type.ToDisplayString();
            var caption = GetAttributeFirstString(p, "CaptionAttribute");
            var description = GetAttributeFirstString(p, "DescriptionAttribute");
            var readOnly = IsReadOnlyProp(p);
            if (merged.TryGetValue(key, out var existing))
            {
                merged[key] = (
                    typeStr,
                    p.Type,
                    existing.IsDb,
                    readOnly,
                    existing.IsSubRow,
                    !string.IsNullOrEmpty(caption) ? caption : existing.Caption,
                    !string.IsNullOrEmpty(description) ? description : existing.Description);
            }
            else
            {
                merged[key] = (typeStr, p.Type, false, readOnly, false, caption, description);
            }
        }
    }

    // 3. Fallback — atrybuty Caption/Description z typu zagnieżdżonego *Row (wraz z dziedziczeniem).
    if (rowFallback != null)
    {
        var prefixLen = prefix.Length;
        foreach (var key in merged.Keys.ToList())
        {
            if (!key.StartsWith(prefix, StringComparison.Ordinal)) continue;
            var local = key.Substring(prefixLen);
            if (local.Length == 0 || local.Contains('.')) continue;
            var entry = merged[key];
            if (!string.IsNullOrEmpty(entry.Caption) && !string.IsNullOrEmpty(entry.Description))
                continue;
            var member = FindMemberInherited(rowFallback, local);
            if (member == null) continue;
            var caption = !string.IsNullOrEmpty(entry.Caption)
                ? entry.Caption
                : GetAttributeFirstString(member, "CaptionAttribute");
            var description = !string.IsNullOrEmpty(entry.Description)
                ? entry.Description
                : GetAttributeFirstString(member, "DescriptionAttribute");
            merged[key] = (entry.Type, entry.Sym, entry.IsDb, entry.ReadOnly, entry.IsSubRow, caption, description);
        }
    }

    // 4. Rekurencja po polach typu subrow (typ kończący się na "Record").
    foreach (var f in fields)
    {
        if (f.Type is INamedTypeSymbol nested && nested.TypeKind == TypeKind.Class && nested.Name.EndsWith("Record"))
        {
            ScanRecord(nested, prefix + f.Name + ".", visited, merged, topLevelClasses);
        }
    }
}

static IEnumerable<INamedTypeSymbol> EnumerateAllTypes(INamespaceSymbol ns)
{
    foreach (var t in ns.GetTypeMembers()) yield return t;
    foreach (var sub in ns.GetNamespaceMembers())
        foreach (var t in EnumerateAllTypes(sub)) yield return t;
}

// Property zadeklarowane w bazowych klasach ORM Row / GuidedRow / ExportedRow / SubRow są
// infrastrukturalne (ID, Guid, State, Session, Table, Module, Stamp, IsAdded, Prefix, Root,
// Parent, ...) i nie mają znaczenia biznesowego — pomijamy je w wyniku. SubRow to baza
// obiektów podrzędnych (subrowów), np. `Wymiary`, `ProduktInfo`.
static readonly string[] InfrastructureBaseClasses = { "Row", "GuidedRow", "ExportedRow", "SubRow" };

// Property zawsze pomijane po nazwie, niezależnie od klasy deklarującej — infrastrukturalne,
// ale zadeklarowane w klasach generowanych (np. `Module` zwraca typowany moduł, więc nie ma go
// w bazowym Row).
static readonly string[] AlwaysInfrastructureNames = { "Module" };

// Zbiera nazwy publicznych property zadeklarowanych w klasach bazowych Row / GuidedRow /
// ExportedRow / SubRow występujących w łańcuchu dziedziczenia danej klasy biznesowej.
static HashSet<string> CollectInfrastructurePropertyNames(INamedTypeSymbol type)
{
    var names = new HashSet<string>(StringComparer.Ordinal);
    foreach (var n in AlwaysInfrastructureNames) names.Add(n);
    for (var t = type; t != null && t.SpecialType != SpecialType.System_Object; t = t.BaseType)
    {
        if (Array.IndexOf(InfrastructureBaseClasses, t.Name) < 0) continue;
        foreach (var p in t.GetMembers().OfType<IPropertySymbol>())
        {
            if (p.DeclaredAccessibility == Accessibility.Public && !p.IsStatic && !p.IsIndexer)
                names.Add(p.Name);
        }
    }
    return names;
}

static IEnumerable<IPropertySymbol> EnumerateInheritedProperties(INamedTypeSymbol type)
{
    for (var t = type; t != null && t.SpecialType != SpecialType.System_Object; t = t.BaseType)
    {
        foreach (var p in t.GetMembers().OfType<IPropertySymbol>())
            yield return p;
    }
}

static bool InheritsFromGuidedOrExportedTable(INamedTypeSymbol type)
{
    for (var t = type.BaseType; t != null && t.SpecialType != SpecialType.System_Object; t = t.BaseType)
    {
        if (t.Name == "GuidedTable" || t.Name == "ExportedTable") return true;
    }
    return false;
}

static (string field, string parentType) FindGuidedParent(INamedTypeSymbol recordCls, INamedTypeSymbol rowCls)
{
    if (recordCls == null) return (null, null);
    foreach (var f in recordCls.GetMembers().OfType<IFieldSymbol>())
    {
        foreach (var a in f.GetAttributes())
        {
            var an = a.AttributeClass?.Name;
            if (an != "ColumnInfoAttribute" && an != "ColumnInfo") continue;
            var hasGuided = a.NamedArguments.Any(na => na.Key == "GuidedRelation"
                && na.Value.Kind == TypedConstantKind.Enum
                && na.Value.Value is int v && v != 0);
            if (!hasGuided) continue;
            var propType = "?";
            if (rowCls != null)
            {
                for (var rc = rowCls; rc != null && rc.SpecialType != SpecialType.System_Object; rc = rc.BaseType)
                {
                    var p = rc.GetMembers(f.Name).OfType<IPropertySymbol>().FirstOrDefault();
                    if (p != null) { propType = p.Type.Name; break; }
                }
            }
            return (f.Name, propType);
        }
    }
    return (null, null);
}

static System.Collections.Generic.IEnumerable<string> GetTableInterfaces(INamedTypeSymbol tableCls)
{
    if (tableCls == null) yield break;
    foreach (var a in tableCls.GetAttributes())
    {
        if (a.AttributeClass?.Name != "TableInfoAttribute" && a.AttributeClass?.Name != "TableInfo")
            continue;
        foreach (var na in a.NamedArguments)
        {
            if (na.Key != "Interfaces" || na.Value.Kind != TypedConstantKind.Array) continue;
            foreach (var el in na.Value.Values)
            {
                if (el.Value is string s && !string.IsNullOrEmpty(s)) yield return s;
            }
        }
    }
}

static bool IsConfigTable(INamedTypeSymbol tableCls)
{
    if (tableCls == null) return false;
    foreach (var a in tableCls.GetAttributes())
    {
        if (a.AttributeClass?.Name != "TableInfoAttribute" && a.AttributeClass?.Name != "TableInfo")
            continue;
        foreach (var na in a.NamedArguments)
        {
            if (na.Key == "IsConfig" && na.Value.Value is bool b)
                return b;
        }
    }
    return false;
}

static string GetAttributeFirstString(ISymbol symbol, string attributeTypeName)
{
    if (symbol == null) return "";
    var shortName = attributeTypeName.EndsWith("Attribute")
        ? attributeTypeName.Substring(0, attributeTypeName.Length - "Attribute".Length)
        : attributeTypeName;
    var longName = shortName + "Attribute";
    foreach (var a in symbol.GetAttributes())
    {
        if (a.AttributeClass == null) continue;
        var n = a.AttributeClass.Name;
        if (!string.Equals(n, shortName, StringComparison.Ordinal)
            && !string.Equals(n, longName, StringComparison.Ordinal))
            continue;
        foreach (var arg in a.ConstructorArguments)
        {
            if (arg.Kind == TypedConstantKind.Primitive && arg.Value is string s)
                return s;
        }
    }
    return "";
}

static ISymbol FindMemberInherited(INamedTypeSymbol type, string name)
{
    for (var t = type; t != null && t.SpecialType != SpecialType.System_Object; t = t.BaseType)
    {
        var m = t.GetMembers(name).FirstOrDefault();
        if (m != null) return m;
    }
    return null;
}

static string EscapeCell(string s)
{
    if (string.IsNullOrEmpty(s)) return "";
    return s.Replace("\\", "\\\\").Replace("|", "\\|").Replace("\r", " ").Replace("\n", " ");
}

// Tekst do linii nagłówka (nie do komórki tabeli) — spłaszcza znaki nowej linii, bez escapowania `|`.
static string InlineText(string s)
{
    if (string.IsNullOrEmpty(s)) return "";
    return s.Replace("\r", " ").Replace("\n", " ").Trim();
}

// Zwraca symbol enuma, jeśli typ jest enumem lub Nullable<enum>; w innym wypadku null.
static INamedTypeSymbol AsEnum(ITypeSymbol type)
{
    if (type is not INamedTypeSymbol n) return null;
    if (n.TypeKind == TypeKind.Enum) return n;
    if (n.OriginalDefinition?.SpecialType == SpecialType.System_Nullable_T
        && n.TypeArguments.FirstOrDefault() is INamedTypeSymbol inner && inner.TypeKind == TypeKind.Enum)
        return inner;
    return null;
}

// Wartości enuma w kolejności deklaracji: (nazwa stałej, wartość całkowita, Tytuł z [Caption]/[Description]).
static IEnumerable<(string Name, string Value, string Caption)> GetEnumMembers(INamedTypeSymbol en)
{
    foreach (var m in en.GetMembers().OfType<IFieldSymbol>())
    {
        if (!m.HasConstantValue) continue;
        var cap = GetAttributeFirstString(m, "CaptionAttribute");
        if (string.IsNullOrEmpty(cap)) cap = GetAttributeFirstString(m, "DescriptionAttribute");
        var val = Convert.ToString(m.ConstantValue, System.Globalization.CultureInfo.InvariantCulture) ?? "";
        yield return (m.Name, val, cap);
    }
}
