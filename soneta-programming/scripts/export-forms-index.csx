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
            var dtFull = df?.Attribute("DataType")?.Value ?? "";
            var page = df?.Descendants().FirstOrDefault(e => e.Name.LocalName == "Page");
            var cap = InlineText(page?.Attribute("CaptionHtml")?.Value ?? page?.Attribute("Caption")?.Value ?? "");
            rows.Add(new Rec(BaseName(name), cap, prio, SimpleTypeName(dtFull), dllName, NsHint(name)));
            inThis++;
        }
        if (inThis > 0) { perDll[dllName] = inThis; dllWithForms++; }
    }
    catch (Exception ex) { Console.Error.WriteLine($"# Pominięto {Path.GetFileName(dll)}: {ex.Message}"); }
}

if (rows.Count == 0) { Console.Error.WriteLine($"Brak zasobów *.pageform.xml w {dllDir}"); return 2; }

// Sortowanie: nazwa bazowa (grupuje „Kontrahent*", „Wyplata*"), potem Priority, DLL.
rows.Sort((a, b) => {
    int c = string.Compare(a.Base, b.Base, StringComparison.Ordinal);
    if (c != 0) return c;
    c = a.Priority.CompareTo(b.Priority);
    if (c != 0) return c;
    return string.Compare(a.Dll, b.Dll, StringComparison.Ordinal);
});

var distinctBase = rows.Select(r => r.Base).Distinct().Count();
var sb = new StringBuilder();
sb.AppendLine("# Indeks zakładek formularzy (pageform) — dane wygenerowane");
sb.AppendLine();
sb.AppendLine($"Zakładek (pageform): **{rows.Count}** · nazw bazowych: **{distinctBase}** · bibliotek UI: **{dllWithForms}**.");
sb.AppendLine();
sb.AppendLine("Katalog do szybkiego wyszukania „obiekt → zakładki” bez uruchamiania skanera i bez");
sb.AppendLine("dostępu do DLL. **Nie zawiera pól ani sekcji** — pełną zawartość zakładki (pola,");
sb.AppendLine("sekcje danych, rozwinięte ścieżki `DataContext`/`EditValue`, `Include`, listy) wypisuje");
sb.AppendLine("na żądanie `scan-forms.csx` — patrz [../../references/scan-forms.md](../../references/scan-forms.md).");
sb.AppendLine();
sb.AppendLine("**Jak używać:** wyszukaj `Nazwa bazowa` po prefiksie obiektu (np. `Kontrahent`, `Wyplata`).");
sb.AppendLine("Okno składane jest z wielu plików o wspólnym prefiksie; kolumna `DataType` wiąże typ");
sb.AppendLine("jawnie (rozstrzyga niejednoznaczność, gdy ta sama nazwa jest w wielu modułach/przestrzeniach).");
sb.AppendLine("Po znalezieniu obiektu odczytaj jego pola: `dotnet script scan-forms.csx -- <prefiks|Namespace.Typ> <KatalogDll>`.");
sb.AppendLine();
sb.AppendLine("## Zakładki wg nazwy bazowej");
sb.AppendLine();
sb.AppendLine("| Nazwa bazowa | Zakładka | Priority | DataType | Biblioteka (DLL) | Przestrzeń |");
sb.AppendLine("|---|---|---|---|---|---|");
foreach (var r in rows)
    sb.AppendLine($"| {Esc(r.Base)} | {Esc(r.Caption)} | {r.Priority} | {Esc(r.DataType)} | {Esc(r.Dll)} | {Esc(r.NsHint)} |");
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
Console.WriteLine($"- zakładek: {rows.Count}, nazw bazowych: {distinctBase}, bibliotek: {dllWithForms}");
return 0;

// --- pomocnicze ---
static string BaseName(string resName)
{
    var parts = resName.Split('.');
    var fn = parts.Length >= 3 ? string.Join('.', parts[^3..]) : resName; // „Base.pageform.xml"
    var dot = fn.IndexOf('.');
    return dot > 0 ? fn.Substring(0, dot) : fn;
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

record struct Rec(string Base, string Caption, int Priority, string DataType, string Dll, string NsHint);
