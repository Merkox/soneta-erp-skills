// export-forms-index.csx — wsadowy katalog zakładek (pageform) ze wszystkich DLL do jednego
// pliku data/forms/INDEX.md. Jeden przebieg po zasobach osadzonych (System.Reflection.Metadata),
// bez ładowania IL. Indeks służy do szybkiego wyszukania „obiekt → zakładki" (przenośnie, bez
// DLL); pełne pola/sekcje danej zakładki wypisuje na żądanie scan-forms.csx.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;

if (Args.Count < 2)
{
    Console.Error.WriteLine("Użycie: dotnet script export-forms-index.csx -- <KatalogDll> <KatalogData>");
    Console.Error.WriteLine("Przykład: -- ~/d/dev/bin/debug ~/.claude/skills/soneta-programming/data/forms");
    return 1;
}

var dllDir = Path.GetFullPath(Args[0]);
var outDir = Path.GetFullPath(Args[1]);
if (!Directory.Exists(dllDir)) { Console.Error.WriteLine($"Katalog nie istnieje: {dllDir}"); return 1; }
Directory.CreateDirectory(outDir);

// Zbiór realnych RowType z sąsiedniego data/props/INDEX.md (jeśli jest) — do walidacji typu
// wyliczanego z nazwy pliku. Bez tego pliku walidacja jest pomijana (fallback strukturalny).
var rowTypes = LoadRowTypes(Path.Combine(outDir, "..", "props", "INDEX.md"));
if (rowTypes.Count > 0) Console.Error.WriteLine($"# Walidacja typu wg {rowTypes.Count} RowType z data/props/INDEX.md");

var rows = new List<Rec>();
var perDll = new SortedDictionary<string, int>(StringComparer.Ordinal);
int dllWithForms = 0;

foreach (var dll in Directory.EnumerateFiles(dllDir, "*.dll", SearchOption.TopDirectoryOnly))
{
    try
    {
        using var fs = File.OpenRead(dll);
        using var pe = new PEReader(fs);
        if (!pe.HasMetadata) continue;
        var mr = pe.GetMetadataReader();
        var rd = pe.PEHeaders.CorHeader?.ResourcesDirectory;
        if (rd == null || rd.Value.Size == 0) continue;
        var sec = pe.PEHeaders.SectionHeaders.First(s =>
            s.VirtualAddress <= rd.Value.RelativeVirtualAddress &&
            rd.Value.RelativeVirtualAddress < s.VirtualAddress + s.VirtualSize);
        int baseOff = sec.PointerToRawData + (rd.Value.RelativeVirtualAddress - sec.VirtualAddress);
        var dllName = Path.GetFileName(dll);
        int inThis = 0;

        foreach (var h in mr.ManifestResources)
        {
            var res = mr.GetManifestResource(h);
            if (!res.Implementation.IsNil) continue;
            var name = mr.GetString(res.Name);
            if (!name.ToLowerInvariant().EndsWith(".pageform.xml")) continue;

            var doc = LoadXml(fs, baseOff + (int)res.Offset);
            if (doc == null) continue;
            var df = doc.Root;
            int prio = int.TryParse(df?.Attribute("Priority")?.Value, out var pr) ? pr : 100;
            var dtSimple = SimpleTypeName(df?.Attribute("DataType")?.Value ?? "");
            var page = df?.Descendants().FirstOrDefault(e => e.Name.LocalName == "Page");
            var cap = InlineText(page?.Attribute("CaptionHtml")?.Value ?? page?.Attribute("Caption")?.Value ?? "");

            // Nazwa zasobu: „…<TYP>.<ZAKŁADKA>.pageform.xml". Typ = segment PRZED nazwą zakładki.
            var p = name.Split('.');
            var tabFile = p.Length >= 3 ? p[^3] : name;   // <ZAKŁADKA> (plik zakładki)
            var typeSeg = p.Length >= 4 ? p[^4] : "";      // <TYP> (segment typu)
            var (type, src) = DeriveType(dtSimple, typeSeg, tabFile, rowTypes);

            rows.Add(new Rec(type, src, tabFile, cap, prio, dllName, NsHint(name)));
            inThis++;
        }
        if (inThis > 0) { perDll[dllName] = inThis; dllWithForms++; }
    }
    catch (Exception ex) { Console.Error.WriteLine($"# Pominięto {Path.GetFileName(dll)}: {ex.Message}"); }
}

if (rows.Count == 0) { Console.Error.WriteLine($"Brak zasobów *.pageform.xml w {dllDir}"); return 2; }

// Sortowanie: typ danych → Priority (kolejność zakładek w oknie) → zakładka (plik) → DLL.
rows.Sort((a, b) => {
    int c = string.Compare(a.Type, b.Type, StringComparison.Ordinal);
    if (c != 0) return c;
    c = a.Priority.CompareTo(b.Priority);
    if (c != 0) return c;
    c = string.Compare(a.TabFile, b.TabFile, StringComparison.Ordinal);
    if (c != 0) return c;
    return string.Compare(a.Dll, b.Dll, StringComparison.Ordinal);
});

// Typy ogólne (bazowe/interfejsy systemowe) — zakładki przypięte do nich (Załączniki, Notatki,
// Dyskusja, Panel BI, „Dodatkowe (cechy)"…) dokładają się do WIELU obiektów i nie wnoszą
// informacji biznesowej. Wydzielamy je z głównej listy do osobnej sekcji „systemowej".
var GeneralInterfaces = new HashSet<string>(StringComparer.Ordinal)
{ "Row", "GuidedRow", "ExportedRow", "IRow", "IGuidedRow", "object", "Object" };
var bizRows = rows.Where(r => !GeneralInterfaces.Contains(r.Type)).ToList();
var sysRows = rows.Where(r => GeneralInterfaces.Contains(r.Type)).ToList();

var distinctType = bizRows.Select(r => r.Type).Distinct().Count();
var byDataType = rows.Count(r => r.Src == "DataType");
var sb = new StringBuilder();
sb.AppendLine("# Indeks zakładek formularzy (pageform) — dane wygenerowane");
sb.AppendLine();
sb.AppendLine($"Zakładek biznesowych: **{bizRows.Count}** · typów danych: **{distinctType}** · zakładek systemowych: **{sysRows.Count}** · bibliotek UI: **{dllWithForms}**.");
sb.AppendLine();
sb.AppendLine("Katalog do szybkiego wyszukania „obiekt → zakładki” bez uruchamiania skanera i bez");
sb.AppendLine("dostępu do DLL. **Nie zawiera pól ani sekcji** — pełną zawartość zakładki (pola,");
sb.AppendLine("sekcje danych, rozwinięte ścieżki `DataContext`/`EditValue`, `Include`, listy) wypisuje");
sb.AppendLine("na żądanie `scan-forms.csx` — patrz [../../references/scan-forms.md](../../references/scan-forms.md).");
sb.AppendLine();
sb.AppendLine("**Typ danych.** Nazwa zasobu ma postać `…<TYP>.<ZAKŁADKA>.pageform.xml`, więc typ to");
sb.AppendLine("segment **przed** nazwą zakładki — albo jawny atrybut `DataType` na `<DataForm>`, gdy jest.");
sb.AppendLine("Segment typu jest walidowany względem realnych `RowType`; dla okien konfiguracji");
sb.AppendLine($"(folder `Config`) typ bierzemy z nazwy zakładki. Zakładek z jawnym `DataType`: **{byDataType}**.");
sb.AppendLine();
sb.AppendLine("**Jak używać:** wyszukaj `Typ danych` (np. `Kontrahent`, `DokumentHandlowy`, `DashboardView`).");
sb.AppendLine("Po znalezieniu obiektu odczytaj jego pola: `dotnet script scan-forms.csx -- <Typ|Namespace.Typ> <KatalogDll>`.");
sb.AppendLine();
sb.AppendLine("## Zakładki wg typu danych");
sb.AppendLine();
sb.AppendLine("| Typ danych | Zakładka (plik) | Nazwa zakładki | Priority | Biblioteka (DLL) | Przestrzeń |");
sb.AppendLine("|---|---|---|---|---|---|");
foreach (var r in bizRows)
    sb.AppendLine($"| {Esc(r.Type)} | {Esc(r.TabFile)} | {Esc(r.Caption)} | {r.Priority} | {Esc(r.Dll)} | {Esc(r.NsHint)} |");
sb.AppendLine();
sb.AppendLine("## Zakładki systemowe (typy ogólne)");
sb.AppendLine();
sb.AppendLine("Zakładki przypięte do typów bazowych/interfejsów ogólnych (`Row`, `GuidedRow`,");
sb.AppendLine("`ExportedRow`, `IRow`, `IGuidedRow`, `object`). Platforma dokłada je do **wielu obiektów**");
sb.AppendLine("przez dziedziczenie/interfejs — **nie są specyficzne dla obiektu** i nie wnoszą informacji");
sb.AppendLine("biznesowej (Załączniki, Notatki, Dyskusja, Panel BI, „Dodatkowe (cechy)”…). `scan-forms`");
sb.AppendLine("dla konkretnego obiektu ich nie raportuje — pełną definicję odczytasz podając typ ogólny,");
sb.AppendLine("np. `dotnet script scan-forms.csx -- Row <KatalogDll>`.");
sb.AppendLine();
sb.AppendLine("| Typ ogólny | Zakładka (plik) | Nazwa zakładki | Priority | Biblioteka (DLL) | Przestrzeń |");
sb.AppendLine("|---|---|---|---|---|---|");
foreach (var r in sysRows)
    sb.AppendLine($"| {Esc(r.Type)} | {Esc(r.TabFile)} | {Esc(r.Caption)} | {r.Priority} | {Esc(r.Dll)} | {Esc(r.NsHint)} |");
sb.AppendLine();
sb.AppendLine("## Liczba zakładek wg biblioteki");
sb.AppendLine();
sb.AppendLine("| Biblioteka (DLL) | Zakładek |");
sb.AppendLine("|---|---|");
foreach (var kv in perDll.OrderByDescending(k => k.Value))
    sb.AppendLine($"| {Esc(kv.Key)} | {kv.Value} |");

var outPath = Path.Combine(outDir, "INDEX.md");
File.WriteAllText(outPath, sb.ToString(), new UTF8Encoding(false));
Console.WriteLine($"Zapisano {outPath}");
Console.WriteLine($"- zakładek: {rows.Count}, typów: {distinctType}, po DataType: {byDataType}, bibliotek: {dllWithForms}");
return 0;

// --- pomocnicze ---

// Foldery/segmenty, które NIE są typem danych — gdy trafią na pozycję typu, typ bierzemy
// z nazwy zakładki (np. okno konfiguracji `Config.<TypKonfig>.pageform.xml`).
static readonly HashSet<string> GenericFolders = new(StringComparer.Ordinal)
{ "Config", "UI", "Forms", "Form", "PageForm", "PageForms", "Lookups", "Lookup", "LookupForm", "Res", "Dialogs", "Dialog" };

// Wyznacza (Typ, Źródło). Priorytet: DataType > segment typu ∈ RowType > zakładka ∈ RowType >
// (segment typu, o ile nie jest folderem — wtedy zakładka).
static (string Type, string Src) DeriveType(string dtSimple, string typeSeg, string tabFile, HashSet<string> rowTypes)
{
    if (!string.IsNullOrEmpty(dtSimple)) return (dtSimple, "DataType");
    if (rowTypes.Count > 0)
    {
        if (rowTypes.Contains(typeSeg)) return (typeSeg, "nazwa");
        if (rowTypes.Contains(tabFile)) return (tabFile, "nazwa");
    }
    if (GenericFolders.Contains(typeSeg) || string.IsNullOrEmpty(typeSeg)) return (tabFile, "nazwa");
    return (typeSeg, "nazwa");
}

static HashSet<string> LoadRowTypes(string indexPath)
{
    var set = new HashSet<string>(StringComparer.Ordinal);
    try
    {
        if (!File.Exists(indexPath)) return set;
        foreach (var line in File.ReadLines(indexPath))
        {
            if (!line.StartsWith("| ")) continue;
            var cols = line.Split('|');
            if (cols.Length < 3) continue;
            var rt = cols[1].Trim();
            if (rt.Length > 0 && rt != "RowType" && !rt.StartsWith("-")) set.Add(rt);
        }
    }
    catch { }
    return set;
}

static string NsHint(string resName)
{
    var parts = resName.Split('.');
    return parts.Length >= 2 ? parts[0] + "." + parts[1] : resName;
}
static string SimpleTypeName(string dataType)
{
    if (string.IsNullOrEmpty(dataType)) return "";
    var full = dataType.Split(',')[0].Trim();
    var plus = full.LastIndexOf('+');
    if (plus >= 0) return full.Substring(plus + 1);
    var dot = full.LastIndexOf('.');
    return dot >= 0 ? full.Substring(dot + 1) : full;
}
static XDocument LoadXml(FileStream fs, int fileOffset)
{
    try
    {
        fs.Position = fileOffset;
        Span<byte> lenBuf = stackalloc byte[4];
        fs.ReadExactly(lenBuf);
        int len = BitConverter.ToInt32(lenBuf);
        var data = new byte[len];
        fs.ReadExactly(data);
        var text = new UTF8Encoding(false).GetString(data).TrimStart('﻿', ' ', '\r', '\n', '\t');
        return XDocument.Parse(text);
    }
    catch { return null; }
}
static string Esc(string s) =>
    string.IsNullOrEmpty(s) ? "" : s.Replace("\\", "\\\\").Replace("|", "\\|").Replace("\r", " ").Replace("\n", " ");
static string InlineText(string s) =>
    string.IsNullOrEmpty(s) ? "" : s.Replace("\r", " ").Replace("\n", " ").Trim();

record struct Rec(string Type, string Src, string TabFile, string Caption, int Priority, string Dll, string NsHint);
