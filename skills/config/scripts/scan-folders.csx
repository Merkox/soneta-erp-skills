#r "nuget: Microsoft.CodeAnalysis.CSharp, 4.11.0"

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

// Argumenty pozycyjne + flagi.
//  1. <KatalogDll>            — katalog z bibliotekami dodatku (wymagany)
//  2. [<PrefiksSciezki>]      — opcjonalny filtr: pokaż tylko foldery, których FullPath
//                              zaczyna się od tego prefiksu (np. "Handel" albo "CRM/Poczta").
// Flaga --flat wypisuje płaską listę zamiast drzewa.
var positional = Args.Where(a => !a.StartsWith("--", StringComparison.Ordinal)).ToList();
var flat = Args.Any(a => a == "--flat");

if (positional.Count < 1)
{
    Console.Error.WriteLine("Użycie: dotnet script scan-folders.csx -- <KatalogDll> [<PrefiksSciezki>] [--flat]");
    Console.Error.WriteLine("Przykład: dotnet script scan-folders.csx -- ./bin/Debug/net10.0");
    Console.Error.WriteLine("Przykład: dotnet script scan-folders.csx -- ./bin/Debug/net10.0 Handel");
    Console.Error.WriteLine("Przykład: dotnet script scan-folders.csx -- ./bin/Debug/net10.0 \"Pulpit kontrahenta\" --flat");
    return 1;
}

var dllDir = Path.GetFullPath(positional[0]);
var pathFilter = positional.Count >= 2 ? positional[1].Replace('\\', '/') : null;
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

var tpa = (AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") as string ?? "")
    .Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries);
foreach (var path in tpa)
{
    var name = Path.GetFileName(path);
    if (addedPaths.Contains(name)) continue;
    try { refs.Add(MetadataReference.CreateFromFile(path)); addedPaths.Add(name); }
    catch { /* pomiń */ }
}

var compilation = CSharpCompilation.Create("ScanFolders")
    .WithOptions(new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary))
    .AddReferences(refs);

// Zbierz wszystkie rejestracje FolderView z atrybutów assembly (statyczne foldery programu).
var registrations = new List<FolderRegistration>();
foreach (var asmRef in compilation.References)
{
    if (compilation.GetAssemblyOrModuleSymbol(asmRef) is not IAssemblySymbol asm) continue;
    foreach (var a in asm.GetAttributes())
    {
        var ac = a.AttributeClass;
        if (ac == null) continue;
        if (!IsFolderViewAttribute(ac)) continue;

        // Pierwszy argument konstruktora typu string = FullPath (ścieżka menu).
        string fullPath = null;
        foreach (var arg in a.ConstructorArguments)
        {
            if (arg.Kind == TypedConstantKind.Primitive && arg.Value is string s)
            {
                fullPath = s;
                break;
            }
        }
        if (fullPath == null) continue;
        fullPath = fullPath.Replace('\\', '/');

        var reg = new FolderRegistration
        {
            FullPath = fullPath,
            Assembly = asm.Name,
            AttributeType = ac.Name,
        };

        foreach (var na in a.NamedArguments)
        {
            switch (na.Key)
            {
                case "Description":
                    if (na.Value.Value is string desc) reg.Description = desc;
                    break;
                case "ViewInfoType":
                    reg.ViewInfoType = (na.Value.Value as INamedTypeSymbol)?.ToDisplayString();
                    break;
                case "ObjectType":
                    reg.ObjectType = (na.Value.Value as INamedTypeSymbol)?.ToDisplayString();
                    break;
                case "ViewType":
                    reg.ViewType = (na.Value.Value as INamedTypeSymbol)?.ToDisplayString();
                    break;
                case "TableName":
                    if (na.Value.Value is string tn) reg.TableName = tn;
                    break;
                case "IconName":
                    if (na.Value.Value is string icon) reg.IconName = icon;
                    break;
                case "Priority":
                    if (na.Value.Value is int prio) reg.Priority = prio;
                    break;
            }
        }

        registrations.Add(reg);
    }
}

// Zbuduj drzewo folderów. Węzeł identyfikowany pełną ścieżką; brakujące węzły pośrednie
// (rodzice bez własnej deklaracji atrybutu) tworzone są jako niejawne foldery menu.
var nodes = new Dictionary<string, FolderNode>(StringComparer.Ordinal);

FolderNode GetOrCreate(string path)
{
    if (nodes.TryGetValue(path, out var n)) return n;
    int i = path.LastIndexOf('/');
    var name = i < 0 ? path : path.Substring(i + 1);
    if (string.IsNullOrEmpty(name)) name = "(folder domyślny)";
    n = new FolderNode { FullPath = path, Name = name };
    nodes[path] = n;
    if (i >= 0)
    {
        var parent = GetOrCreate(path.Substring(0, i));
        parent.Children.Add(n);
    }
    return n;
}

foreach (var reg in registrations)
{
    var node = GetOrCreate(reg.FullPath);
    node.Registrations.Add(reg);
}

// Klasyfikacja i wybór reprezentatywnej rejestracji (pierwszej niosącej opis/typ).
foreach (var node in nodes.Values)
{
    var main = node.Registrations.FirstOrDefault(r => r.ObjectType != null)
        ?? node.Registrations.FirstOrDefault(r => r.ViewInfoType != null)
        ?? node.Registrations.FirstOrDefault(r => r.ViewType != null || r.TableName != null)
        ?? node.Registrations.FirstOrDefault(r => !string.IsNullOrEmpty(r.Description))
        ?? node.Registrations.FirstOrDefault();
    node.Main = main;
    node.Kind = Classify(main);
    // Description bierzemy z reprezentatywnej deklaracji, a gdy jej brak — z dowolnej
    // deklaracji tego węzła, która opis niesie (różne warianty licencyjne bywają opisane osobno).
    node.Description = !string.IsNullOrEmpty(main?.Description)
        ? main.Description
        : node.Registrations.Select(r => r.Description).FirstOrDefault(d => !string.IsNullOrEmpty(d));
}

// Filtr po prefiksie ścieżki — ograniczamy zbiór korzeni do węzłów pasujących do prefiksu.
IEnumerable<FolderNode> roots = nodes.Values
    .Where(n => !n.FullPath.Contains('/'))
    .OrderBy(n => n.FullPath, StringComparer.OrdinalIgnoreCase);

if (pathFilter != null)
{
    // Znajdź węzeł(y) dokładnie odpowiadające prefiksowi albo jego dzieci.
    var matched = nodes.Values
        .Where(n => n.FullPath == pathFilter
                    || n.FullPath.StartsWith(pathFilter + "/", StringComparison.Ordinal))
        .ToList();
    if (matched.Count == 0)
    {
        Console.Error.WriteLine($"# Brak folderów pasujących do prefiksu `{pathFilter}`.");
        return 1;
    }
    // Korzeniem wydruku jest najkrótsza pasująca ścieżka.
    roots = matched
        .Where(n => n.FullPath == pathFilter
                    || !matched.Any(m => n.FullPath.StartsWith(m.FullPath + "/", StringComparison.Ordinal)
                                         && m.FullPath.Length < n.FullPath.Length))
        .OrderBy(n => n.FullPath, StringComparer.OrdinalIgnoreCase);
}

var sb = new StringBuilder();
sb.AppendLine("# Foldery statyczne (Soneta)");
sb.AppendLine();
sb.AppendLine($"Znaleziono deklaracji `FolderView`: {registrations.Count}");
sb.AppendLine($"Węzłów w drzewie: {nodes.Count}");
if (pathFilter != null) sb.AppendLine($"Filtr ścieżki: `{pathFilter}`");
sb.AppendLine();
sb.AppendLine("Legenda typów: `[LISTA]` folder z widokiem (ViewInfoType/ViewType/TableName) · `[FORMULARZ]` folder z formularzem obiektu (ObjectType) · `[MENU]` folder grupujący inne foldery");
sb.AppendLine();

int total = 0;
if (flat)
{
    var all = (pathFilter != null
            ? nodes.Values.Where(n => n.FullPath == pathFilter || n.FullPath.StartsWith(pathFilter + "/", StringComparison.Ordinal))
            : nodes.Values)
        .OrderBy(n => n.FullPath, StringComparer.OrdinalIgnoreCase);
    foreach (var n in all)
    {
        sb.AppendLine(FormatFlat(n));
        total++;
    }
}
else
{
    foreach (var root in roots)
    {
        total += WriteTree(sb, root, 0);
    }
}

sb.AppendLine();
sb.AppendLine($"_Łącznie folderów: {total}_");
Console.WriteLine(sb.ToString());
return 0;

int WriteTree(StringBuilder sb, FolderNode node, int depth)
{
    var indent = new string(' ', depth * 2);
    sb.Append($"{indent}- `[{TypeLabel(node.Kind)}]` **{node.Name}**");

    var meta = new List<string>();
    var m = node.Main;
    if (m != null)
    {
        if (m.ViewInfoType != null) meta.Add($"ViewInfo: `{Short(m.ViewInfoType)}`");
        if (m.ObjectType != null) meta.Add($"Object: `{Short(m.ObjectType)}`");
        if (m.ViewType != null) meta.Add($"View: `{Short(m.ViewType)}`");
        if (m.TableName != null) meta.Add($"Table: `{m.TableName}`");
    }
    if (node.Registrations.Count > 1) meta.Add($"deklaracji: {node.Registrations.Count}");
    if (meta.Count > 0) sb.Append($" — {string.Join(", ", meta)}");
    sb.AppendLine();

    if (!string.IsNullOrEmpty(node.Description))
        sb.AppendLine($"{indent}  <br>_{node.Description}_");

    int count = 1;
    foreach (var child in node.Children.OrderBy(c => c.Name, StringComparer.OrdinalIgnoreCase))
        count += WriteTree(sb, child, depth + 1);
    return count;
}

string FormatFlat(FolderNode node)
{
    var m = node.Main;
    var extra = new List<string>();
    if (m?.ViewInfoType != null) extra.Add($"ViewInfo=`{Short(m.ViewInfoType)}`");
    if (m?.ObjectType != null) extra.Add($"Object=`{Short(m.ObjectType)}`");
    if (m?.ViewType != null) extra.Add($"View=`{Short(m.ViewType)}`");
    if (m?.TableName != null) extra.Add($"Table=`{m.TableName}`");
    var tail = extra.Count > 0 ? "  (" + string.Join(", ", extra) + ")" : "";
    var desc = !string.IsNullOrEmpty(node.Description) ? " — " + node.Description : "";
    return $"- `[{TypeLabel(node.Kind)}]` `{node.FullPath}`{tail}{desc}";
}

// Klasyfikacja zgodna z FolderViewAttribute.IsMenuFolder (menu ⟺ brak View/ViewInfo/Object):
//  - ObjectType   → formularz (zakładka obiektu, widok inny niż lista);
//  - ViewInfoType / ViewType / TableName → folder z widokiem (najczęściej lista).
//    W praktyce typ ViewInfo bywa przekazywany też przez ViewType, więc traktujemy to wspólnie;
//  - pozostałe → folder menu grupujący inne foldery.
static string Classify(FolderRegistration r)
{
    if (r == null) return "menu";
    if (r.ObjectType != null) return "form";
    if (r.ViewInfoType != null || r.ViewType != null || r.TableName != null) return "list";
    return "menu";
}

// Tekstowy skrót rodzaju folderu (zamiast ikony) — czytelny w każdym edytorze i łatwy do grepowania.
static string TypeLabel(string kind) => kind switch
{
    "list" => "LISTA",
    "form" => "FORMULARZ",
    _ => "MENU",
};

static string Short(string fullTypeName)
{
    if (string.IsNullOrEmpty(fullTypeName)) return fullTypeName;
    int i = fullTypeName.LastIndexOf('.');
    return i < 0 ? fullTypeName : fullTypeName.Substring(i + 1);
}

// Atrybut jest FolderView, gdy sam nazywa się FolderViewAttribute albo dziedziczy z niego
// (np. HandelFolderViewAttribute, BIFolderViewAttribute). Sprawdzamy łańcuch BaseType.
static bool IsFolderViewAttribute(INamedTypeSymbol attrClass)
{
    for (var t = attrClass; t != null && t.SpecialType != SpecialType.System_Object; t = t.BaseType)
    {
        if (t.Name == "FolderViewAttribute"
            && (t.ContainingNamespace?.ToDisplayString() ?? "").StartsWith("Soneta", StringComparison.Ordinal))
            return true;
    }
    return false;
}

class FolderRegistration
{
    public string FullPath;
    public string Description;
    public string ViewInfoType;
    public string ObjectType;
    public string ViewType;
    public string TableName;
    public string IconName;
    public int? Priority;
    public string Assembly;
    public string AttributeType;
}

class FolderNode
{
    public string FullPath;
    public string Name;
    public string Kind;
    public string Description;
    public FolderRegistration Main;
    public List<FolderRegistration> Registrations = new();
    public List<FolderNode> Children = new();
}
