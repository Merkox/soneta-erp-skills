// scan-forms.csx — odczyt zakładek i pól formularzy Soneta z zasobów osadzonych w DLL.
// Czyta zasoby *.pageform.xml (+ dołączane *.form.xml) bez ładowania IL — samą tablicą
// ManifestResource przez System.Reflection.Metadata. Rozwija ścieżki pól przez łańcuch
// DataContext/EditValue i rozwiązuje <Include> (także między bibliotekami). Wynik: pola
// w kolejności dokumentu (= kolejność wprowadzania przez operatora) na zakładkę.

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
    Console.Error.WriteLine("Użycie: dotnet script scan-forms.csx -- <PrefiksNazwyFormularza> <KatalogDll>");
    Console.Error.WriteLine("Przykład: dotnet script scan-forms.csx -- Kontrahent ./bin/Debug/net10.0");
    Console.Error.WriteLine("Prefiks = początek nazwy pliku pageform (bywa szerszy niż nazwa typu:");
    Console.Error.WriteLine("okno DokumentHandlowy składają pliki `Dokument*`, więc podaj `Dokument`).");
    return 1;
}

var rootType = Args[0];
var dllDir = Path.GetFullPath(Args[1]);
if (!Directory.Exists(dllDir)) { Console.Error.WriteLine($"Katalog nie istnieje: {dllDir}"); return 1; }

// --- 1. Indeks wszystkich zasobów-formularzy we wszystkich DLL katalogu. ---
// Klucz pomocniczy: nazwa pliku = ostatnie dwa segmenty (Base.pageform.xml) + samo Base.
var allForms = new List<FormRes>();
foreach (var dll in Directory.EnumerateFiles(dllDir, "*.dll", SearchOption.TopDirectoryOnly))
{
    try
    {
        using var fs = File.OpenRead(dll);
        using var pe = new PEReader(fs);
        if (!pe.HasMetadata) continue;
        var mr = pe.GetMetadataReader();
        var resDir = pe.PEHeaders.CorHeader?.ResourcesDirectory;
        if (resDir == null || resDir.Value.Size == 0) continue;
        var section = pe.PEHeaders.SectionHeaders.First(s =>
            s.VirtualAddress <= resDir.Value.RelativeVirtualAddress &&
            resDir.Value.RelativeVirtualAddress < s.VirtualAddress + s.VirtualSize);
        int baseFileOffset = section.PointerToRawData + (resDir.Value.RelativeVirtualAddress - section.VirtualAddress);

        foreach (var h in mr.ManifestResources)
        {
            var res = mr.GetManifestResource(h);
            if (!res.Implementation.IsNil) continue; // tylko zasoby w tym pliku
            var name = mr.GetString(res.Name);
            var lower = name.ToLowerInvariant();
            if (!(lower.EndsWith(".pageform.xml") || lower.EndsWith(".form.xml") ||
                  lower.EndsWith(".viewform.xml") || lower.EndsWith(".gridform.xml") ||
                  lower.EndsWith(".lookupform.xml"))) continue;
            allForms.Add(new FormRes {
                Dll = Path.GetFileName(dll), Name = name, FileOffset = baseFileOffset + (int)res.Offset,
                DllPath = dll
            });
        }
    }
    catch (Exception ex) { Console.Error.WriteLine($"# Pominięto {Path.GetFileName(dll)}: {ex.Message}"); }
}

// Nazwa pliku formularza = człon po ostatnim segmencie namespace, tzn. „X.pageform.xml".
// Bazę (X) i pełną nazwę pliku indeksujemy do dopasowania po prefiksie typu oraz do Include.
string FileName(string resName)
{
    // „A.B.C.Base.pageform.xml" -> „Base.pageform.xml"
    var parts = resName.Split('.');
    if (parts.Length < 3) return resName;
    // dwa ostatnie to „form"/„pageform"+"xml" — bierzemy 3 ostatnie segmenty jako nazwę pliku
    return string.Join('.', parts[^3..]);
}
// Foldery/segmenty, które NIE są typem danych — gdy trafią na pozycję typu (segment przed
// nazwą zakładki), typ bierzemy z nazwy zakładki (np. okno konfiguracji `Config.<Typ>…`).
var GenericFolders = new HashSet<string>(StringComparer.Ordinal)
{ "Config", "UI", "Forms", "Form", "PageForm", "PageForms", "Lookups", "Lookup", "LookupForm", "Res", "Dialogs", "Dialog" };

// Typy ogólne (bazowe/interfejsy) — zakładki przypięte do nich to zakładki systemowe (Załączniki,
// Notatki, Dyskusja…) dokładane do wielu obiektów; nie raportujemy ich przy skanie konkretnego
// obiektu (chyba że argument to sam typ ogólny). Pełną definicję da `scan-forms -- Row …`.
var GeneralInterfaces = new HashSet<string>(StringComparer.Ordinal)
{ "Row", "GuidedRow", "ExportedRow", "IRow", "IGuidedRow", "object", "Object" };
bool argIsSystem = GeneralInterfaces.Contains(rootType) || GeneralInterfaces.Contains(rootType.Contains('.') ? rootType.Substring(rootType.LastIndexOf('.') + 1) : rootType);

// Reguła dopasowania nazwy: równość albo prefiks zakończony wielką literą (żeby `Kontrahent`
// nie łapał `Kontrahentowy`, a `Dokument` łapał `DokumentHandlowy`).
static bool MatchName(string value, string arg) =>
    value.Equals(arg, StringComparison.Ordinal) ||
    (value.StartsWith(arg, StringComparison.Ordinal) && value.Length > arg.Length && char.IsUpper(value[arg.Length]));

// Indeks do Include: nazwa pliku (lower) -> zasób.
var byFileName = new Dictionary<string, FormRes>(StringComparer.OrdinalIgnoreCase);
foreach (var f in allForms) byFileName[FileName(f.Name)] = f;

// --- 2. Wybór zakładek typu. Dwa tryby dopasowania (suma):
//   (a) BASE nazwy pliku == prefiks lub zaczyna się od prefiksu + wielka litera;
//   (b) atrybut DataType na <DataForm> — z uwzględnieniem namespace, gdy argument go zawiera.
// Argument może być: nazwą prostą (`Wyplata`) albo kwalifikowaną namespace (`Kasa.Wyplata`,
// `Soneta.Kasa.Wyplata`). Nazwa prosta = ostatni człon (do prefiksu nazwy pliku). Namespace
// rozstrzyga niejednoznaczność, gdy ta sama nazwa prosta jest w wielu przestrzeniach
// (np. `Wyplata` w `Soneta.Kasa` i `Soneta.KadryPlace`).
bool qualified = rootType.Contains('.');
var simpleArg = qualified ? rootType.Substring(rootType.LastIndexOf('.') + 1) : rootType;
var nsPart = qualified ? rootType.Substring(0, rootType.LastIndexOf('.')) : ""; // np. „Kasa" / „Soneta.Kasa"

var parsed = new List<(FormRes Res, XDocument Doc, int Priority, string Caption)>();
var nsHints = new SortedSet<string>(StringComparer.Ordinal); // przestrzenie zasobów trafień (do ostrzeżenia)
foreach (var p in allForms.Where(f => f.Name.ToLowerInvariant().EndsWith(".pageform.xml")))
{
    // Nazwa zasobu ma postać „…<TYP>.<ZAKŁADKA>.pageform.xml": typ = segment PRZED nazwą
    // zakładki (dla folderów generycznych jak `Config` typ jest w nazwie zakładki). Dopasowujemy
    // po typie z nazwy oraz — zapasowo, by nie gubić — po samej nazwie zakładki.
    var parts = p.Name.Split('.');
    var tabFile = parts.Length >= 3 ? parts[^3] : p.Name;
    var typeSeg = parts.Length >= 4 ? parts[^4] : "";
    var typeFromName = (typeSeg.Length == 0 || GenericFolders.Contains(typeSeg)) ? tabFile : typeSeg;
    bool nameSimple = MatchName(typeFromName, simpleArg) || MatchName(tabFile, simpleArg);
    // Nazwa pliku nie niesie namespace — przy nazwie kwalifikowanej zawężamy po przestrzeni
    // ZASOBU (nazwa zasobu zaczyna się od domyślnego namespace assembly, np. `Soneta.Kasa.UI…`).
    bool byName = nameSimple && (!qualified || p.Name.IndexOf(nsPart, StringComparison.OrdinalIgnoreCase) >= 0);

    var doc = LoadXml(p);
    if (doc == null) continue;
    var df = doc.Root;
    var dataType = df?.Attribute("DataType")?.Value;
    var typeFull = string.IsNullOrEmpty(dataType) ? "" : dataType.Split(',')[0].Trim().Replace('+', '.');
    bool byType = typeFull.Length > 0 && (qualified
        ? (string.Equals(typeFull, rootType, StringComparison.Ordinal) || typeFull.EndsWith("." + rootType, StringComparison.Ordinal))
        : string.Equals(SimpleTypeName(dataType), rootType, StringComparison.Ordinal));
    if (!byName && !byType) continue;

    // Zakładka systemowa (typ ogólny: Row/GuidedRow/IRow/…) — pomijamy przy skanie konkretnego
    // obiektu; raportujemy tylko, gdy argument to sam typ ogólny (patrz INDEX, sekcja systemowa).
    var effType = !string.IsNullOrEmpty(typeFull) ? SimpleTypeName(dataType) : typeFromName;
    if (!argIsSystem && GeneralInterfaces.Contains(effType)) continue;

    nsHints.Add(NsHint(p.Name)); // dwa pierwsze człony nazwy zasobu = domyślny namespace modułu

    int prio = int.TryParse(df?.Attribute("Priority")?.Value, out var pr) ? pr : 100;
    var page = df?.Descendants().FirstOrDefault(e => e.Name.LocalName == "Page");
    var cap = page?.Attribute("CaptionHtml")?.Value ?? page?.Attribute("Caption")?.Value ?? tabFile;
    parsed.Add((p, doc, prio, cap));
}

if (parsed.Count == 0)
{
    Console.Error.WriteLine($"Nie znaleziono zakładek (*.pageform.xml) o nazwie/DataType `{rootType}` w {dllDir}");
    return 2;
}
parsed = parsed.OrderBy(x => x.Priority).ThenBy(x => FileName(x.Res.Name), StringComparer.Ordinal).ToList();

Console.WriteLine($"# Formularze dla `{rootType}` — zakładki, sekcje i pola");
Console.WriteLine();
Console.WriteLine($"Dopasowano {parsed.Count} zakładek (pageform) po typie danych lub `DataType`. " +
                  "Typ z nazwy zasobu `…<TYP>.<ZAKŁADKA>.pageform.xml` = segment przed nazwą zakładki " +
                  "(dla folderu `Config` — z nazwy zakładki); jawnie wiąże atrybut `DataType` na `<DataForm>`. " +
                  "Kolejność pól = kolejność w dokumencie (kolejność wprowadzania przez operatora).");
Console.WriteLine();

// Ostrzeżenie o niejednoznaczności namespace: trafienia z wielu przestrzeni (modułów).
// Oparte na przestrzeni ZASOBU — działa też, gdy formularze wiążą się nazwą pliku (bez DataType).
if (!qualified && nsHints.Count > 1)
{
    Console.WriteLine($"> **Uwaga:** dopasowania pochodzą z wielu przestrzeni: " +
                      string.Join(", ", nsHints.Select(n => "`" + n + "`")) +
                      $". Jeśli to różne typy o tej samej nazwie, zawęź argumentem kwalifikowanym " +
                      $"(np. `{nsHints.First().Replace(".UI", "")}.{rootType}`).");
    Console.WriteLine();
}

foreach (var (res, doc, prio, cap) in parsed)
{
    Console.WriteLine($"## Zakładka: {InlineText(cap)}");
    Console.WriteLine();
    Console.WriteLine($"- plik: `{FileName(res.Name)}` (DLL `{res.Dll}`), Priority={prio}");
    var dataType = doc.Root?.Attribute("DataType")?.Value;
    if (!string.IsNullOrEmpty(dataType)) Console.WriteLine($"- typ danych (DataType): `{dataType}`");
    var rights = doc.Root?.Attribute("RightName")?.Value;
    if (!string.IsNullOrEmpty(rights)) Console.WriteLine($"- prawo: `{rights}`");
    // Wymagane licencje — atrybut `Contexts` na <DataForm>; bez prefiksu `License.`/`Licence.`
    // (np. „HAN | FA", „HAN_Złoty or HAN_Platynowy").
    var contexts = doc.Root?.Attribute("Contexts")?.Value;
    if (!string.IsNullOrEmpty(contexts))
        Console.WriteLine($"- licencje: `{InlineText(contexts).Replace("License.", "").Replace("Licence.", "")}`");
    Console.WriteLine();
    Console.WriteLine("| # | Sekcja | Ścieżka pola | Etykieta | Uwagi |");
    Console.WriteLine("|---|--------|--------------|----------|-------|");

    var rows = new List<Row>();
    var visited = new HashSet<string>();
    foreach (var el in doc.Root.Elements())
        Walk(el, "", "", "", null, null, null, rows, visited, byFileName);

    int i = 1;
    foreach (var r in rows)
        Console.WriteLine($"| {i++} | {EscapeCell(r.Section)} | {EscapeCell(r.Path)} | {EscapeCell(r.Caption)} | {EscapeCell(r.Note)} |");
    Console.WriteLine();
}
return 0;

// --- Rekurencyjny przechód po drzewie UI, z akumulacją kontekstu (ścieżki DataContext)
// oraz sekcji (ścieżki tytułów Group). ---
void Walk(XElement el, string ctx, string section, string suffix,
          string listOuterCtx, string listLabel, string filterLabel,
          List<Row> rows, HashSet<string> visited,
          Dictionary<string, FormRes> index)
{
    var ln = el.Name.LocalName;

    // Pasek filtra listy (`Class="DataBar"`) — jego pola filtrują listę i dotyczą kontekstu
    // NADRZĘDNEGO (host listy / ViewInfo `Context`), nie elementu kolekcji. Przełącz kontekst
    // na zewnętrzny i oznacz poddrzewo jako filtr danej listy (listLabel).
    if (listOuterCtx != null && HasClass(el, "DataBar"))
    {
        ctx = listOuterCtx;
        filterLabel = listLabel;
    }

    // Aktualizacja kontekstu z DataContext elementu (dotyczy jego potomków).
    var childCtx = ctx;
    var dc = el.Attribute("DataContext")?.Value;
    if (!string.IsNullOrEmpty(dc))
        childCtx = CombineContext(ctx, dc);

    // Sekcja danych = tytuł Group / listy (zagnieżdżone → ścieżka „A / B").
    var childSection = section;
    if (ln == "Group" || IsListElement(ln))
    {
        var gcap = InlineText(el.Attribute("CaptionHtml")?.Value ?? el.Attribute("Caption")?.Value ?? "");
        if (!string.IsNullOrEmpty(gcap))
            childSection = string.IsNullOrEmpty(section) ? gcap : section + " / " + gcap;
    }

    // Include — rozwiń dołączony fragment.
    if (ln == "Include")
    {
        var src = el.Attribute("Source")?.Value ?? "";
        var incDc = el.Attribute("DataContext")?.Value;
        var incCtx = string.IsNullOrEmpty(incDc) ? ctx : CombineContext(ctx, incDc);
        var incSuffix = suffix + (el.Attribute("Suffix")?.Value ?? "");
        if (src.StartsWith("{"))
        {
            rows.Add(new Row(section, incCtx, "", $"Include dynamiczny (z kodu): {src}"));
            return;
        }
        if (index.TryGetValue(src, out var incRes))
        {
            var key = incRes.Name + "|" + incCtx;
            if (visited.Add(key))
            {
                var incDoc = LoadXml(incRes);
                if (incDoc != null)
                    foreach (var c in incDoc.Root.Elements())
                        Walk(c, incCtx, section, incSuffix, listOuterCtx, listLabel, filterLabel, rows, visited, index);
            }
            else rows.Add(new Row(section, incCtx, "", $"Include (cykl pominięty): {src}"));
        }
        else rows.Add(new Row(section, incCtx, "", $"Include — nie znaleziono zasobu `{src}` w katalogu"));
        return;
    }

    // Element z EditValue: pole edycyjne albo lista (Grid/Scheduler/Gantt/…).
    var ev = el.Attribute("EditValue")?.Value;
    bool isList = IsListElement(ln);
    bool isField = ln == "Field" || ln == "Data" || ln == "Html" || ln == "Markdown" || ln == "Chips" || ln == "Axis";
    if (!string.IsNullOrEmpty(ev) && (isField || isList))
    {
        var path = ResolvePath(childCtx, ev);
        var cap = el.Attribute("CaptionHtml")?.Value ?? el.Attribute("Caption")?.Value ?? "";
        var noteParts = new List<string>();
        if (!string.IsNullOrEmpty(suffix)) noteParts.Add($"Suffix={suffix}");
        if (isList) noteParts.Add($"lista ({ln})");
        else if (!isField) noteParts.Add(ln.ToLowerInvariant());
        if (!string.IsNullOrEmpty(filterLabel)) noteParts.Add($"filtr listy: `{filterLabel}`");
        rows.Add(new Row(section, path, InlineText(cap), string.Join("; ", noteParts)));

        if (isList)
        {
            // Kolumny listy odnoszą się do ELEMENTU kolekcji zwracanej przez EditValue listy,
            // nie do kontekstu rodzica. Kontekst kolumn = ścieżka kolekcji z granicą `:`.
            // Host listy (childCtx) = kontekst nadrzędny, a `path` = etykieta listy dla filtrów.
            var itemCtx = ListItemContext(childCtx, ev);
            foreach (var c in el.Elements())
                Walk(c, itemCtx, childSection, suffix, childCtx, path, null, rows, visited, index);
            return;
        }
    }

    // Zejście w potomków (kontenery layoutu: Page/Group/Stack/Row/Flow/Bar/Dashboard...).
    foreach (var c in el.Elements())
        Walk(c, childCtx, childSection, suffix, listOuterCtx, listLabel, filterLabel, rows, visited, index);
}

// Czy element ma daną klasę stylu (`Class` = lista wartości rozdzielonych spacją).
static bool HasClass(XElement el, string cls)
{
    var c = el.Attribute("Class")?.Value;
    if (string.IsNullOrEmpty(c)) return false;
    foreach (var part in c.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        if (part.Equals(cls, StringComparison.Ordinal)) return true;
    return false;
}

// Elementy listowe/kolekcyjne — ich EditValue zwraca kolekcję, a dzieci to kolumny elementu.
static bool IsListElement(string ln) => ln is
    "Grid" or "TreeList" or "Scheduler" or "Gantt" or "GanttDiagram" or
    "KanbanDiagram" or "Pivot" or "Chart" or "Diagram" or "TreeDiagram";

// Granica kolekcji (element listy) w kontekście — znacznik wewnętrzny renderowany jako „:".
// Oddziela część ścieżki wczytującą listę od pól na elemencie listy (np. `Ceny:Definicja`).
const string CollMark = "\u0001";

// Dołącza segment do kontekstu: po granicy kolekcji wstawia „:", w innym wypadku „.".
// UWAGA: porównania ordinalne — kulturowe traktują U+0001 jako znak ignorowany (EndsWith≡"").
static string Join(string prefix, string seg)
{
    if (string.IsNullOrEmpty(prefix)) return seg;
    if (prefix.EndsWith(CollMark, StringComparison.Ordinal)) return prefix.Substring(0, prefix.Length - 1) + ":" + seg;
    return prefix + "." + seg;
}

// Renderuje kontekst do postaci ścieżki: wiszącą granicę kolekcji zamienia na „:"
// (sygnalizując element listy, gdy pole rozwiązuje kod/worker bez jawnego pola).
static string Disp(string ctx)
{
    if (ctx.EndsWith(CollMark, StringComparison.Ordinal)) return ctx.Substring(0, ctx.Length - 1) + ":";
    return ctx;
}

// `{new X}` / `{New X}` w DataContext lub EditValue = nowy korzeń kontekstu (obiekt z kodu,
// np. extender) — zastępuje kontekst rodzica zamiast się do niego doklejać.
static bool IsNewRoot(string v) => v.StartsWith("new ", StringComparison.OrdinalIgnoreCase);

// Kontekst elementu kolekcji (wiersza listy) na podstawie EditValue listy — z granicą kolekcji.
static string ListItemContext(string ctx, string evRaw)
{
    var v = Unwrap(evRaw);
    var coll = IsNewRoot(v) ? v : Join(ctx, v);
    return coll + CollMark;
}

// Łączy kontekst rodzica z wartością DataContext elementu.
// {DataSource} = reset do korzenia. {new X} = nowy korzeń. Pozostałe = nawigacja po ścieżce.
static string CombineContext(string parent, string dcRaw)
{
    var v = Unwrap(dcRaw);
    if (v == "DataSource" || v == "") return "";     // korzeń = otwarty obiekt
    if (IsNewRoot(v)) return v;                        // extender = nowy korzeń
    return Join(parent, v);
}

// Zwraca pełną ścieżkę pola względem otwartego obiektu (DataSource). Wyrażenia dostępowe
// (`Workers.…`, `Features.…`, `+`, `()`) zostają wprost w ścieżce — bez opisowych not.
static string ResolvePath(string ctx, string evRaw)
{
    var v = Unwrap(evRaw);
    if (IsNewRoot(v)) return Disp(v);                 // wartość z extendera = pełne wyrażenie
    return Disp(Join(ctx, v));
}

static string Unwrap(string s)
{
    if (string.IsNullOrEmpty(s)) return "";
    s = s.Trim();
    if (s.StartsWith("{") && s.EndsWith("}")) s = s.Substring(1, s.Length - 2).Trim();
    return s;
}

// Z „Namespace.Typ,Assembly" lub „Namespace.Outer+Params,Assembly" wyciąga nazwę prostą typu
// (po ostatniej `.` i po ewentualnym `+` typu zagnieżdżonego, przed przecinkiem assembly).
// Przestrzeń zasobu = dwa pierwsze człony nazwy zasobu (domyślny namespace assembly modułu),
// np. „Soneta.KadryPlace.UI.HR.WyplataEtat.pageform.xml" → „Soneta.KadryPlace".
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

// --- Odczyt bajtów zasobu i parsowanie XML (obcięcie BOM). ---
XDocument LoadXml(FormRes f)
{
    try
    {
        using var fs = File.OpenRead(f.DllPath);
        fs.Position = f.FileOffset;
        Span<byte> lenBuf = stackalloc byte[4];
        fs.ReadExactly(lenBuf);
        int len = BitConverter.ToInt32(lenBuf);
        var data = new byte[len];
        fs.ReadExactly(data);
        var text = new UTF8Encoding(false).GetString(data).TrimStart('﻿', ' ', '\r', '\n', '\t');
        return XDocument.Parse(text);
    }
    catch (Exception ex) { Console.Error.WriteLine($"# Błąd odczytu {f.Name}: {ex.Message}"); return null; }
}

static string EscapeCell(string s) =>
    string.IsNullOrEmpty(s) ? "" : s.Replace("\\", "\\\\").Replace("|", "\\|").Replace("\r", " ").Replace("\n", " ");
static string InlineText(string s) =>
    string.IsNullOrEmpty(s) ? "" : s.Replace("\r", " ").Replace("\n", " ").Trim();

class FormRes { public string Dll; public string Name; public string DllPath; public int FileOffset; }
record struct Row(string Section, string Path, string Caption, string Note);
