#r "nuget: Microsoft.CodeAnalysis.CSharp, 4.11.0"

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

// Wsadowy eksport pól WSZYSTKICH tabel do plików markdown w folderze danych skilla.
// Kompilacja Roslyn i globalne indeksy budowane są RAZ, potem iteracja po tabelach —
// dzięki temu eksport całego programu jest wielokrotnie szybszy niż 1000+ wywołań
// scan-props.csx (każde z nich czytałoby wszystkie DLL od nowa).
//
// Logika skanowania pojedynczej tabeli jest identyczna jak w scan-props.csx.
// Wynik per tabela = ten sam markdown, który wypisałby scan-props.csx na stdout.

if (Args.Count < 1)
{
    Console.Error.WriteLine("Użycie: dotnet script export-props-all.csx -- <KatalogDll> [<KatalogWyjściowy>]");
    Console.Error.WriteLine("Przykład: dotnet script export-props-all.csx -- ~/d/dev/bin/Debug ../data/props");
    return 1;
}

var dllDir = Path.GetFullPath(Args[0]);
var outDir = Args.Count >= 2
    ? Path.GetFullPath(Args[1])
    : Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Path.GetFullPath(GetScriptPath())) ?? ".", "..", "data", "props"));

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

Console.Error.WriteLine($"# Buduję kompilację z {dllPaths.Count} DLL…");

var refs = new List<MetadataReference>();
var addedPaths = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
foreach (var p in dllPaths)
{
    try { refs.Add(MetadataReference.CreateFromFile(p)); addedPaths.Add(Path.GetFileName(p)); }
    catch (Exception ex) { Console.Error.WriteLine($"# Pominięto {Path.GetFileName(p)}: {ex.Message}"); }
}

var tpa = (AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") as string ?? "")
    .Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries);
foreach (var path in tpa)
{
    var name = Path.GetFileName(path);
    if (addedPaths.Contains(name)) continue;
    try { refs.Add(MetadataReference.CreateFromFile(path)); addedPaths.Add(name); }
    catch { /* pomiń */ }
}

var compilation = CSharpCompilation.Create("ExportProps")
    .WithOptions(new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary))
    .AddReferences(refs);

// ── Globalne indeksy budowane RAZ ─────────────────────────────────────────────
var topLevelClasses = new Dictionary<string, INamedTypeSymbol>(StringComparer.Ordinal);
var modules = new List<INamedTypeSymbol>();

Console.Error.WriteLine("# Indeksuję typy…");
foreach (var asmRef in compilation.References)
{
    if (compilation.GetAssemblyOrModuleSymbol(asmRef) is not IAssemblySymbol asm) continue;
    foreach (var type in EnumerateAllTypes(asm.GlobalNamespace))
    {
        if (type.ContainingType == null
            && type.TypeKind == TypeKind.Class
            && type.DeclaredAccessibility == Accessibility.Public)
        {
            topLevelClasses.TryAdd(type.Name, type);
            if (type.Name.EndsWith("Module") && InheritsFromModule(type))
                modules.Add(type);
        }
    }
}
modules = modules.OrderBy(m => m.ToDisplayString(), StringComparer.Ordinal).ToList();

// Indeks interfejs → lista tabel implementujących (relacje interfejsowe).
var interfaceImpls = new SortedDictionary<string, List<string>>(StringComparer.Ordinal);
foreach (var top in modules)
{
    foreach (var t in top.GetTypeMembers())
    {
        if (!t.Name.EndsWith("Table")) continue;
        foreach (var iface in GetTableInterfaces(t))
        {
            if (!interfaceImpls.TryGetValue(iface, out var list))
                interfaceImpls[iface] = list = new List<string>();
            interfaceImpls[iface].Add(t.Name.Substring(0, t.Name.Length - "Table".Length));
        }
    }
}
// Deterministyczna kolejność tabel implementujących (stabilne diffy przy regeneracji).
foreach (var list in interfaceImpls.Values)
    list.Sort(StringComparer.Ordinal);

// ── Iteracja po realnych tabelach każdego modułu ──────────────────────────────
Directory.CreateDirectory(outDir);

// INDEX + zliczniki
var indexRows = new List<(string Module, string RowType, string TableType, string Konfig, string Guided, string Caption, string Interfaces, string RelPath)>();
var moduleMeta = new Dictionary<string, (string Caption, string Description)>(StringComparer.Ordinal);
int filesWritten = 0, modulesWithTables = 0;

foreach (var module in modules)
{
    var tableClasses = module.GetTypeMembers()
        .Where(t => t.TypeKind == TypeKind.Class && t.Name.EndsWith("Table"))
        .Select(t => t.Name).ToHashSet(StringComparer.Ordinal);

    var rowClasses = module.GetTypeMembers()
        .Where(t => t.TypeKind == TypeKind.Class && t.Name.EndsWith("Row"))
        .Where(t => tableClasses.Contains(t.Name.Substring(0, t.Name.Length - "Row".Length) + "Table"))
        .OrderBy(t => t.Name, StringComparer.Ordinal)
        .ToList();

    if (rowClasses.Count == 0) continue;
    modulesWithTables++;

    var moduleShort = module.Name.EndsWith("Module")
        ? module.Name.Substring(0, module.Name.Length - "Module".Length)
        : module.Name;
    var moduleDir = Path.Combine(outDir, moduleShort);
    Directory.CreateDirectory(moduleDir);

    // Tytuł/Opis modułu — atrybuty [Caption]/[Description] na klasie *Module (do INDEX-u).
    moduleMeta[moduleShort] = (
        GetAttributeFirstString(module, "CaptionAttribute"),
        GetAttributeFirstString(module, "DescriptionAttribute"));

    foreach (var row in rowClasses)
    {
        var recordBaseName = row.Name.Substring(0, row.Name.Length - "Row".Length);
        var record = module.GetTypeMembers(recordBaseName + "Record").FirstOrDefault();
        if (record == null) continue; // brak *Record → nie realna tabela danych

        var (md, konfig, guided, tableType, caption, interfaces) = BuildRecordMarkdown(
            recordBaseName, module, record, topLevelClasses, interfaceImpls);

        var filePath = Path.Combine(moduleDir, recordBaseName + ".md");
        File.WriteAllText(filePath, md);
        filesWritten++;

        var rel = moduleShort + "/" + recordBaseName + ".md";
        indexRows.Add((moduleShort, recordBaseName, tableType, konfig, guided, caption, interfaces, rel));
    }
}

// ── INDEX.md ──────────────────────────────────────────────────────────────────
var idx = new StringBuilder();
idx.AppendLine("# Indeks pól tabel biznesowych (dane wygenerowane z DLL)");
idx.AppendLine();
idx.AppendLine("Pliki w tym katalogu zostały wygenerowane wsadowo przez");
idx.AppendLine("`scripts/export-props-all.csx` (ta sama logika co `scan-props.csx`).");
idx.AppendLine("Każdy plik `<Moduł>/<RowType>.md` zawiera pełną tabelę pól jednej tabeli.");
idx.AppendLine("Ten INDEX to zarazem pełna inwentaryzacja modułów i tabel (moduł z `Opis`; tabela:");
idx.AppendLine("`RowType | Tytuł | Tabela | Konfig | Guided | Interfaces | Plik`).");
idx.AppendLine("Instrukcja odczytu i regeneracji: [../references/scan-props.md](../../references/scan-props.md).");
idx.AppendLine();
idx.AppendLine($"- Modułów z tabelami: {modulesWithTables}");
idx.AppendLine($"- Tabel (plików): {filesWritten}");
idx.AppendLine();
idx.AppendLine("Aby znaleźć tabelę: wyszukaj `RowType` w tabeli poniżej i otwórz plik z kolumny `Plik`.");
idx.AppendLine();

foreach (var grp in indexRows.GroupBy(r => r.Module).OrderBy(g => g.Key, StringComparer.Ordinal))
{
    idx.AppendLine($"## {grp.Key}");
    idx.AppendLine();
    if (moduleMeta.TryGetValue(grp.Key, out var meta))
    {
        if (!string.IsNullOrEmpty(meta.Caption)) idx.AppendLine($"- Tytuł: {InlineText(meta.Caption)}");
        if (!string.IsNullOrEmpty(meta.Description)) idx.AppendLine($"- Opis: {InlineText(meta.Description)}");
        if (!string.IsNullOrEmpty(meta.Caption) || !string.IsNullOrEmpty(meta.Description)) idx.AppendLine();
    }
    idx.AppendLine("| RowType | Tytuł | Tabela | Konfig | Guided | Interfaces | Plik |");
    idx.AppendLine("|---------|-------|--------|--------|--------|------------|------|");
    foreach (var r in grp.OrderBy(r => r.RowType, StringComparer.Ordinal))
        idx.AppendLine($"| {r.RowType} | {EscapeCell(r.Caption)} | `{r.TableType}` | {r.Konfig} | {EscapeCell(r.Guided)} | {EscapeCell(r.Interfaces)} | [{r.RelPath}]({r.RelPath}) |");
    idx.AppendLine();
}

File.WriteAllText(Path.Combine(outDir, "INDEX.md"), idx.ToString());

Console.Error.WriteLine($"# Gotowe: zapisano {filesWritten} plików w {modulesWithTables} modułach → {outDir}");
Console.WriteLine($"OK: {filesWritten} tabel, {modulesWithTables} modułów → {outDir}");
return 0;

// ══════════════════════════════════════════════════════════════════════════════
// Budowa markdown pojedynczej tabeli — logika identyczna jak scan-props.csx.
// Zwraca (markdown, konfig, guided, tableType) — trzy ostatnie do INDEX-u.
static (string Md, string Konfig, string Guided, string TableType, string Caption, string Interfaces) BuildRecordMarkdown(
    string recordBaseName,
    INamedTypeSymbol enclosing,
    INamedTypeSymbol foundRecord,
    Dictionary<string, INamedTypeSymbol> topLevelClasses,
    SortedDictionary<string, List<string>> interfaceImpls)
{
    var sb = new StringBuilder();

    INamedTypeSymbol mainBusinessClass = null;
    topLevelClasses.TryGetValue(recordBaseName, out mainBusinessClass);

    string tableTypeName = null;
    bool isConfigTable = false;
    var rowClass = enclosing.GetTypeMembers(recordBaseName + "Row").FirstOrDefault();
    if (rowClass != null)
    {
        for (var t = rowClass; t != null && t.SpecialType != SpecialType.System_Object; t = t.BaseType)
        {
            var tableProp = t.GetMembers("Table").OfType<IPropertySymbol>().FirstOrDefault();
            if (tableProp != null) { tableTypeName = tableProp.Type.Name; break; }
        }
    }
    var nestedTableCls = enclosing.GetTypeMembers(recordBaseName + "Table").FirstOrDefault();
    if (nestedTableCls != null) isConfigTable = IsConfigTable(nestedTableCls);

    // Tytuł/Opis tabeli — atrybuty [Caption]/[Description] na klasie *Table (fallback: *Row).
    var tableCaption = GetAttributeFirstString(nestedTableCls, "CaptionAttribute");
    if (string.IsNullOrEmpty(tableCaption)) tableCaption = GetAttributeFirstString(rowClass, "CaptionAttribute");
    var tableDescription = GetAttributeFirstString(nestedTableCls, "DescriptionAttribute");
    if (string.IsNullOrEmpty(tableDescription)) tableDescription = GetAttributeFirstString(rowClass, "DescriptionAttribute");

    var isGuidedRoot = nestedTableCls != null && InheritsFromGuidedOrExportedTable(nestedTableCls);
    string guidedParentField = null, guidedParentType = null;
    if (!isGuidedRoot) (guidedParentField, guidedParentType) = FindGuidedParent(foundRecord, rowClass);

    var merged = new SortedDictionary<string, (string Type, ITypeSymbol Sym, bool IsDb, string Caption, string Description)>(StringComparer.Ordinal);
    var visited = new HashSet<INamedTypeSymbol>(SymbolEqualityComparer.Default);
    ScanRecord(foundRecord, "", visited, merged, topLevelClasses);

    if (mainBusinessClass != null)
        sb.AppendLine($"# Pola i właściwości klasy biznesowej: `{mainBusinessClass.ToDisplayString()}`");
    else
    {
        sb.AppendLine($"# Pola i właściwości `{enclosing.ToDisplayString()}+{recordBaseName}Record`");
        sb.AppendLine();
        sb.AppendLine($"Nie znaleziono klasy biznesowej `{recordBaseName}` — pokazano tylko pola bazodanowe.");
    }

    string guidedText = "";
    var thisInterfaces = nestedTableCls != null ? GetTableInterfaces(nestedTableCls).ToList() : new List<string>();
    if (!string.IsNullOrEmpty(tableTypeName))
    {
        sb.AppendLine($"Nazwa tabeli: `{tableTypeName}`");
        if (!string.IsNullOrEmpty(tableCaption)) sb.AppendLine($"Tytuł: {InlineText(tableCaption)}");
        if (!string.IsNullOrEmpty(tableDescription)) sb.AppendLine($"Opis: {InlineText(tableDescription)}");
        sb.AppendLine($"Tabela konfiguracyjna: {(isConfigTable ? "Tak" : "Nie")}");
        if (isGuidedRoot) { sb.AppendLine("Guided: root"); guidedText = "root"; }
        else if (guidedParentField != null)
        {
            sb.AppendLine($"Guided: child — nadrzędna przez pole `{guidedParentField}` → `{guidedParentType}`");
            guidedText = $"child: {guidedParentField}→{guidedParentType}";
        }
        if (thisInterfaces.Count > 0)
            sb.AppendLine($"Implementuje interfejsy: {string.Join(", ", thisInterfaces.Select(i => "`" + i + "`"))}");
    }

    sb.AppendLine();
    var dbCount = merged.Values.Count(v => v.IsDb);
    sb.AppendLine($"- pola bazodanowe: {dbCount}");
    sb.AppendLine($"- pola kalkulowane (z klas biznesowych): {merged.Count - dbCount}");
    sb.AppendLine();
    sb.AppendLine("| Pole | Typ | Rodzaj | Tytuł | Opis |");
    sb.AppendLine("|------|-----|--------|-------|------|");

    var interfaceFields = new List<(string Field, string IfaceShort, List<string> Impls)>();
    var enumsUsed = new SortedDictionary<string, INamedTypeSymbol>(StringComparer.Ordinal);
    foreach (var kv in merged)
    {
        var rodzaj = kv.Value.IsDb ? "bazodanowe" : "";
        if (guidedParentField != null && kv.Key == guidedParentField)
            rodzaj = string.IsNullOrEmpty(rodzaj) ? "guided-parent" : rodzaj + ", guided-parent";
        var shortType = ShortTypeName(kv.Value.Type);
        if (shortType.StartsWith("I") && shortType.Length > 1 && char.IsUpper(shortType[1])
            && interfaceImpls.TryGetValue(shortType, out var impls))
        {
            rodzaj = string.IsNullOrEmpty(rodzaj) ? "iface-ref" : rodzaj + ", iface-ref";
            interfaceFields.Add((kv.Key, shortType, impls));
        }
        var en = AsEnum(kv.Value.Sym);
        if (en != null)
        {
            rodzaj = string.IsNullOrEmpty(rodzaj) ? "enum" : rodzaj + ", enum";
            enumsUsed[en.ToDisplayString()] = en;
        }
        sb.AppendLine($"| {kv.Key} | `{kv.Value.Type}` | {rodzaj} | {EscapeCell(kv.Value.Caption)} | {EscapeCell(kv.Value.Description)} |");
    }

    if (interfaceFields.Count > 0)
    {
        sb.AppendLine();
        sb.AppendLine("## Relacje interfejsowe");
        sb.AppendLine();
        sb.AppendLine("Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.");
        sb.AppendLine("Pole może wskazywać na rekord dowolnej z poniższych tabel.");
        sb.AppendLine();
        sb.AppendLine("| Pole | Interfejs | Tabele implementujące |");
        sb.AppendLine("|------|-----------|------------------------|");
        foreach (var f in interfaceFields)
            sb.AppendLine($"| {f.Field} | `{f.IfaceShort}` | {string.Join(", ", f.Impls.Select(i => "`" + i + "`"))} |");
    }

    if (enumsUsed.Count > 0)
    {
        sb.AppendLine();
        sb.AppendLine("## Enumy");
        sb.AppendLine();
        sb.AppendLine("Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).");
        foreach (var en in enumsUsed.Values)
        {
            sb.AppendLine();
            sb.AppendLine($"### {en.Name} (`{en.ToDisplayString()}`)");
            foreach (var (name, value, caption) in GetEnumMembers(en))
                sb.AppendLine(string.IsNullOrEmpty(caption) ? $"- `{name}` = {value}" : $"- `{name}` = {value} — {EscapeCell(caption)}");
        }
    }

    return (sb.ToString(), isConfigTable ? "konfig" : "", guidedText, tableTypeName ?? "",
        tableCaption ?? "", string.Join(", ", thisInterfaces));
}

static string ShortTypeName(string fullName)
{
    if (string.IsNullOrEmpty(fullName)) return "";
    var lt = fullName.IndexOf('<');
    if (lt >= 0) fullName = fullName.Substring(0, lt);
    var dot = fullName.LastIndexOf('.');
    return dot >= 0 ? fullName.Substring(dot + 1) : fullName;
}

static void ScanRecord(
    INamedTypeSymbol record,
    string prefix,
    HashSet<INamedTypeSymbol> visited,
    SortedDictionary<string, (string Type, ITypeSymbol Sym, bool IsDb, string Caption, string Description)> merged,
    Dictionary<string, INamedTypeSymbol> topLevelClasses)
{
    if (record == null) return;
    if (!visited.Add(record)) return;

    var fields = record.GetMembers()
        .OfType<IFieldSymbol>()
        .Where(f => f.DeclaredAccessibility == Accessibility.Public)
        .ToList();

    var encMod = record.ContainingType;
    var baseName = record.Name.EndsWith("Record")
        ? record.Name.Substring(0, record.Name.Length - "Record".Length)
        : record.Name;

    INamedTypeSymbol bizCls = null;
    topLevelClasses.TryGetValue(baseName, out bizCls);
    var rowFallback = encMod?.GetTypeMembers(baseName + "Row").FirstOrDefault();

    foreach (var f in fields)
    {
        var key = prefix + f.Name;
        merged[key] = (
            f.Type.ToDisplayString(),
            f.Type,
            true,
            GetAttributeFirstString(f, "CaptionAttribute"),
            GetAttributeFirstString(f, "DescriptionAttribute"));
    }

    if (bizCls != null)
    {
        var infrastructureNames = CollectInfrastructurePropertyNames(bizCls);
        var seen = new HashSet<string>(StringComparer.Ordinal);
        foreach (var p in EnumerateInheritedProperties(bizCls))
        {
            if (p.DeclaredAccessibility != Accessibility.Public || p.IsStatic || p.IsIndexer || p.GetMethod == null)
                continue;
            if (!seen.Add(p.Name)) continue;
            if (infrastructureNames.Contains(p.Name) && !merged.ContainsKey(prefix + p.Name)) continue;
            var key = prefix + p.Name;
            var typeStr = p.Type.ToDisplayString();
            var caption = GetAttributeFirstString(p, "CaptionAttribute");
            var description = GetAttributeFirstString(p, "DescriptionAttribute");
            if (merged.TryGetValue(key, out var existing))
            {
                merged[key] = (
                    typeStr,
                    p.Type,
                    existing.IsDb,
                    !string.IsNullOrEmpty(caption) ? caption : existing.Caption,
                    !string.IsNullOrEmpty(description) ? description : existing.Description);
            }
            else merged[key] = (typeStr, p.Type, false, caption, description);
        }
    }

    if (rowFallback != null)
    {
        var prefixLen = prefix.Length;
        foreach (var key in merged.Keys.ToList())
        {
            if (!key.StartsWith(prefix, StringComparison.Ordinal)) continue;
            var local = key.Substring(prefixLen);
            if (local.Length == 0 || local.Contains('.')) continue;
            var entry = merged[key];
            if (!string.IsNullOrEmpty(entry.Caption) && !string.IsNullOrEmpty(entry.Description)) continue;
            var member = FindMemberInherited(rowFallback, local);
            if (member == null) continue;
            var caption = !string.IsNullOrEmpty(entry.Caption)
                ? entry.Caption : GetAttributeFirstString(member, "CaptionAttribute");
            var description = !string.IsNullOrEmpty(entry.Description)
                ? entry.Description : GetAttributeFirstString(member, "DescriptionAttribute");
            merged[key] = (entry.Type, entry.Sym, entry.IsDb, caption, description);
        }
    }

    foreach (var f in fields)
    {
        if (f.Type is INamedTypeSymbol nested && nested.TypeKind == TypeKind.Class && nested.Name.EndsWith("Record"))
            ScanRecord(nested, prefix + f.Name + ".", visited, merged, topLevelClasses);
    }
}

static IEnumerable<INamedTypeSymbol> EnumerateAllTypes(INamespaceSymbol ns)
{
    foreach (var t in ns.GetTypeMembers()) yield return t;
    foreach (var sub in ns.GetNamespaceMembers())
        foreach (var t in EnumerateAllTypes(sub)) yield return t;
}

static bool InheritsFromModule(INamedTypeSymbol type)
{
    for (var t = type.BaseType; t != null && t.SpecialType != SpecialType.System_Object; t = t.BaseType)
    {
        if (t.Name == "Module" && t.ContainingNamespace?.ToDisplayString() == "Soneta.Business")
            return true;
    }
    return false;
}

static readonly string[] InfrastructureBaseClasses = { "Row", "GuidedRow", "ExportedRow", "SubRow" };
static readonly string[] AlwaysInfrastructureNames = { "Module" };

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
        foreach (var p in t.GetMembers().OfType<IPropertySymbol>())
            yield return p;
}

static bool InheritsFromGuidedOrExportedTable(INamedTypeSymbol type)
{
    for (var t = type.BaseType; t != null && t.SpecialType != SpecialType.System_Object; t = t.BaseType)
        if (t.Name == "GuidedTable" || t.Name == "ExportedTable") return true;
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

static IEnumerable<string> GetTableInterfaces(INamedTypeSymbol tableCls)
{
    if (tableCls == null) yield break;
    foreach (var a in tableCls.GetAttributes())
    {
        if (a.AttributeClass?.Name != "TableInfoAttribute" && a.AttributeClass?.Name != "TableInfo") continue;
        foreach (var na in a.NamedArguments)
        {
            if (na.Key != "Interfaces" || na.Value.Kind != TypedConstantKind.Array) continue;
            foreach (var el in na.Value.Values)
                if (el.Value is string s && !string.IsNullOrEmpty(s)) yield return s;
        }
    }
}

static bool IsConfigTable(INamedTypeSymbol tableCls)
{
    if (tableCls == null) return false;
    foreach (var a in tableCls.GetAttributes())
    {
        if (a.AttributeClass?.Name != "TableInfoAttribute" && a.AttributeClass?.Name != "TableInfo") continue;
        foreach (var na in a.NamedArguments)
            if (na.Key == "IsConfig" && na.Value.Value is bool b) return b;
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
            && !string.Equals(n, longName, StringComparison.Ordinal)) continue;
        foreach (var arg in a.ConstructorArguments)
            if (arg.Kind == TypedConstantKind.Primitive && arg.Value is string s) return s;
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

// Ścieżka bieżącego skryptu — dotnet-script udostępnia zmienną globalną, ale bezpieczniej
// wyliczyć fallback względem katalogu roboczego, gdy nie jest dostępna.
static string GetScriptPath()
{
    // dotnet-script wykonuje skrypt z katalogu skryptu jako cwd, więc "." wystarcza.
    return Directory.GetCurrentDirectory();
}
