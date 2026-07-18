# Zakładki, sekcje i pola formularzy z DLL (skaner zasobów osadzonych)

Odczyt rzeczywistej struktury formularzy platformy Soneta — **zakładek**, **sekcji danych**
(grup) i **pól w kolejności wprowadzania** — wprost z bibliotek DLL, bez dostępu do źródeł.
Służy do budowania kodu wprowadzającego dane oraz do przygotowania [importu XML](../../soneta-config/SKILL.md)
w trybie `business="true"`, gdzie **kolejność pól i przynależność do sekcji** ma znaczenie.

## Po co to

Kolejność, w jakiej operator wypełnia pola na formularzu, pośrednio odzwierciedla kolejność
wykonywanego kodu (settery, `Accessor`, przeliczenia, walidacje). Ta sama kolejność jest
potrzebna, gdy dane wprowadza się:
- **kodem** (ustawianie właściwości rekordu w poprawnej sekwencji — patrz [context.md](context.md), [safe-code.md](safe-code.md)),
- **importem XML `business="true"`** — logika biznesowa reaguje na kolejność ustawień jak przy
  ręcznym wprowadzaniu (patrz artykuł import/eksport w `/soneta-config`).

Grupy (`Group`) i zakładki (`Page`) wyznaczają **sekcje danych** do uzupełnienia — skaner
pokazuje je w kolumnie `Sekcja`, dzięki czemu widać, które pola tworzą logiczną całość.

## Mechanizm — inny niż `scan-props`

`scan-props`/`scan-modules` czytają **metadane zarządzane** (typy, atrybuty) przez Roslyn.
Definicje formularzy nie są typami — to **zasoby osadzone** (`ManifestResource`) w bibliotece
UI. Dlatego skaner używa `System.Reflection.PortableExecutable` + `System.Reflection.Metadata`:
czyta tablicę zasobów i wyciąga bajty pliku formularza **bez ładowania IL** (ta sama zasada
„tylko odczyt", co w pozostałych skanerach).

Algorytm:
1. Przejdź wszystkie `*.dll` w katalogu; z każdej odczytaj zasoby kończące się na
   `.pageform.xml` / `.form.xml` / `.viewform.xml` / `.gridform.xml` / `.lookupform.xml`.
   Zasób osadzony ma format: 4-bajtowa długość + dane; bajty to XML z **BOM-em** (`EF BB BF`) —
   trzeba go obciąć przed parsowaniem.
2. Zbuduj indeks `nazwa-pliku → zasób` (do rozwiązywania `Include` — także **między bibliotekami**,
   np. `AdresH.form.xml` z biblioteki Core dołączane w formularzu z innej biblioteki).
3. Wybierz zakładki: pliki `*.pageform.xml` dopasowane **po nazwie pliku** (prefiks) **lub po
   atrybucie `DataType`** z `<DataForm>` (patrz niżej — „Wybór zakładek"). Posortuj po `Priority`
   (rosnąco), potem po nazwie pliku.
4. Dla każdej zakładki przejdź drzewo UI w **kolejności dokumentu**, akumulując dwie ścieżki:
   - **kontekst danych** — z atrybutów `DataContext` (rozwijanie ścieżek pól, patrz niżej),
   - **sekcję** — z tytułów `Group` (`CaptionHtml`); zagnieżdżone grupy → ścieżka `A / B`.
5. Dla elementów z `EditValue` (`Field`, `Data`, `Html`, `Markdown`, `Axis`) wypisz wiersz:
   `Sekcja | Ścieżka pola | Etykieta | Uwagi`. Elementy **listowe** (`Grid`, `Scheduler`, `Gantt`,
   `Pivot`, `Chart`…) wypisz jako wiersz listy i zejdź w kolumny z kontekstem **elementu
   kolekcji** (marker `[]`) — patrz sekcja „Listy".
6. `Include` z atrybutem `Source` będącym nazwą pliku → wczytaj dołączany fragment, złóż jego
   kontekst z `DataContext`/`Suffix` z elementu `Include` i rekurencyjnie rozwiń jego pola.
   Cykle są zabezpieczone (zbiór odwiedzonych `zasób|kontekst`).

## Rozwijanie ścieżek pól (DataContext + EditValue)

Pełna ścieżka pola = złożenie łańcucha `DataContext` z wartością `EditValue`. Szczegóły
składni bindowania opisuje skill [`/soneta-form-xml`](../../soneta-form-xml/SKILL.md).

| Sytuacja | Efekt w ścieżce |
|---|---|
| `Page DataContext="{DataSource}"` | korzeń = otwarty obiekt (ścieżka pusta) |
| `Group DataContext="{Adres}"` + `Field EditValue="{Ulica}"` | `Adres.Ulica` |
| zagnieżdżony `EditValue="{AdresRozszerzony.Dzielnica}"` | `Adres.AdresRozszerzony.Dzielnica` |
| `Include Source="AdresH.form.xml" DataContext="{Adres}"` | pola fragmentu rebazowane na `Adres.*` |
| `EditValue="{new Ext.X}"`, `{A+B.C}`, `{...()}`, `Workers.`, `Features.` | wartość **z kodu** — nie sklejana w ścieżkę, opisana w `Uwagi` |

Znacznik `?` wewnętrznie oznacza kontekst pochodzący z kodu (extender, ViewInfo) — takich
gałęzi nie da się rozwinąć do ścieżki pola bazodanowego; skaner sygnalizuje to w `Uwagi`.

Wartości z kodu skaner opisuje konkretnie (kolumna `Uwagi`):

| Wzorzec `EditValue`/`DataContext` | Znaczenie |
|---|---|
| `{new FooExtender.Bar}` | **extender** `FooExtender` (mechanizm podobny do workera) — wartość/kolekcja z kodu |
| `{Workers.Foo.Bar}` | **worker** — nazwa klasy bywa z sufiksem `Worker` (np. `Foo` → `FooWorker`) |
| `{Features.NazwaCechy}` | **cecha obiektu** zdefiniowana w konfiguracji (`FeatureDefinition`) — patrz [features.md](features.md) |
| `{ObiektViewInfo+TypParams.Pole}` | nawigacja przez `ViewInfo` (operator `+`) — patrz [viewinfo.md](viewinfo.md) |

Strony kodu: extendery/workery — [worker-extender.md](worker-extender.md); cechy — [features.md](features.md).

### Listy — `Grid`, `Scheduler`, `Gantt`, `Pivot`, `Chart`…

Elementy listowe (`Grid`, `TreeList`, `Scheduler`, `Gantt`, `GanttDiagram`, `KanbanDiagram`,
`Pivot`, `Chart`, `Diagram`, `TreeDiagram`) mają `EditValue` zwracające **kolekcję**. Pola
wewnątrz (kolumny) odnoszą się już do **elementu tej kolekcji** — innego obiektu niż kontekst
rodzica. Skaner:

- wypisuje sam element listy jednym wierszem z notą `lista (Grid) — kolumny odnoszą się do
  elementu kolekcji \`X\``,
- kolumnom nadaje kontekst elementu kolekcji z markerem **`[]`**, więc ich ścieżki to
  `X[].Pole` (np. `Ceny[].Netto`, `Ceny[].Definicja.Priorytet`, `PrzelicznikiTowaru[].Bazowa`).

Gdy kolekcja pochodzi z kodu (`{new Ext.Ceny}`, `{Workers…}`, `{Metoda()}`), element jest
nierozwiązywalny do pola bazodanowego — kolumny są opisane jako będące „pod kontekstem z kodu",
a kolekcja pokazana z jej wyrażeniem. Do budowy danych/importu XML dla takiej listy sięgnij po
typ elementu kolekcji narzędziem [scan-props.md](scan-props.md) (property zwracającej kolekcję).

## Wybór zakładek — po nazwie pliku i po `DataType`

Platforma składa okno wielozakładkowe w runtime; **nie ma atrybutu assembly wiążącego
pojedynczy `pageform` z typem** (`FolderView` dotyczy tylko list/folderów). Skaner łączy więc
dwa tryby dopasowania (suma) do podanego argumentu:

**(a) po nazwie pliku** — pierwszy człon nazwy pliku `pageform` niesie typ okna. Może to być:
- nazwa **klasy** (`Kontrahent` → zakładki kontrahenta),
- nazwa **interfejsu** (relacje interfejsowe — wspólne zakładki wielu tabel),
- nazwa **klasy dziedziczącej** (selektory),
- **`Config.`** — okno konfiguracji (ustawienia modułów).

Prefiks bywa szerszy/krótszy niż nazwa typu — okno `DokumentHandlowy` składają pliki
`Dokument*` (`DokumentOgolne`, `DokumentPlatnosci`, `DokumentKontrahent`, `DokumentUE`…), więc
podaje się prefiks `Dokument` (dobierany domenowo — może objąć też inne typy `Dokument*`).
Warunek: nazwa bazowa pliku równa argumentowi **albo** zaczyna się od niego, po czym następuje
wielka litera (dzięki temu `Kontrahent` nie łapie listy `Dokumenty`, a `Dokument` —
`DokumentyPowiazane`).

**(b) po `DataType`** — gdy `<DataForm>` ma atrybut `DataType="Namespace.Typ,Assembly"`, typ
jest **jawny** (nazwa pliku bywa niejednoznaczna: formularze parametrów workerów, konfiguracji,
selektory). Dla argumentu prostego skaner dopasowuje po **nazwie prostej** typu
(`Soneta.Business.Db.DashboardView` → `DashboardView`), więc łapie też zakładki o nazwach plików
niepowiązanych z typem (`GeneralBI.pageform.xml`, `GeneralCockpit.pageform.xml`).

W nagłówku każdej zakładki skaner pokazuje `dopasowano po: nazwa | DataType | nazwa+DataType`
oraz `typ danych (DataType)`, jeśli jest — łatwo zweryfikować przynależność zakładki do typu.

### Zawężanie po namespace — ta sama nazwa w wielu modułach

Jeśli argument zawiera **kropkę**, jest traktowany jako **nazwa kwalifikowana namespace**
(`Kasa.Wyplata`, `Soneta.Kasa.Wyplata`). To rozstrzyga niejednoznaczność, gdy ta sama nazwa
prosta istnieje w wielu przestrzeniach — np. `Wyplata` jest w `Soneta.Kasa` **i** w
`Soneta.KadryPlace`. Zawężanie działa dwutorowo:
- dopasowanie **po `DataType`** — pełna nazwa typu równa argumentowi lub kończąca się na
  `.{argument}` (przyrostek namespace),
- dopasowanie **po nazwie pliku** — dodatkowo wymaga, by **nazwa zasobu** zawierała człon
  namespace (nazwa zasobu zaczyna się od domyślnej przestrzeni assembly modułu, np.
  `Soneta.KadryPlace.UI…`), bo sama nazwa pliku namespace nie niesie.

Gdy argument jest **prosty**, a trafienia pochodzą z wielu przestrzeni, skaner wypisuje
**ostrzeżenie** z listą przestrzeni i podpowiedzią kwalifikacji (np. `Soneta.KadryPlace.Wyplata`).

## Uruchomienie

```bash
dotnet script ~/.claude/skills/soneta-programming/scripts/scan-forms.csx \
    -- <PrefiksNazwyFormularza> <KatalogDll>
```

### Przykłady

```bash
# Wszystkie zakładki kontrahenta
dotnet script .../scan-forms.csx -- Kontrahent ~/d/dev/bin/debug

# Okno dokumentu handlowego (pliki Dokument*)
dotnet script .../scan-forms.csx -- Dokument ~/d/dev/bin/debug

# Nazwa w wielu modułach — zawężenie po namespace (Wyplata jest w Kasa i KadryPlace)
dotnet script .../scan-forms.csx -- KadryPlace.Wyplata ~/d/dev/bin/debug
```

### Przykładowe wyjście

```markdown
# Formularz obiektu `Kontrahent` — zakładki i pola

Dopasowano 33 zakładek (pageform) po prefiksie nazwy pliku. Kolejność pól = kolejność
w dokumencie (kolejność wprowadzania przez operatora).

## Zakładka: Ogólne

- plik: `Kontrahent.pageform.xml` (DLL `Soneta.CRM.UI.dll`), Priority=0
- prawo: `Page:KontrahentPage`

| # | Sekcja | Ścieżka pola | Etykieta | Uwagi |
|---|--------|--------------|----------|-------|
| 1 | Dane identyfikacyjne | Kod | Kod |  |
| 2 | Dane identyfikacyjne | EuVAT | EU VAT/NIP |  |
| 14 | Adres | Adres.Ulica | Ulica |  |
| 31 | Adres | Adres.AdresRozszerzony.Dzielnica | Dzielnica |  |
| 44 | Kontakt |  |  | lista/grid; wartość z kodu/bindu: {New …Ext.Kontakty} |
```

## Kody wyjścia

| Kod | Znaczenie |
|-----|-----------|
| `0` | OK — wypisano zakładki, sekcje i pola |
| `1` | Błąd argumentów / nie istnieje katalog |
| `2` | Nie znaleziono zakładek `*.pageform.xml` o podanym prefiksie/`DataType` |

## Ograniczenia

- **Grupowanie okna** to konwencja runtime — dopasowanie po nazwie pliku jest heurystyką, którą
  dobiera użytkownik (szeroki prefiks może objąć zakładki kilku typów `Prefiks*`). Dopasowanie
  po `DataType` jest jednoznaczne, ale obejmuje tylko formularze, które ten atrybut ustawiają.
- **Namespace przy nazwie z kropką** opiera się na przestrzeni ZASOBU (domyślny namespace
  assembly modułu) i na `DataType` — gdy oba są nietypowe (formularz w nietypowej przestrzeni),
  zawężenie może pominąć plik; wtedy użyj argumentu prostego i przejrzyj ostrzeżenie o przestrzeniach.
- Skanuje tylko górny poziom katalogu (`SearchOption.TopDirectoryOnly`).
- Gałęzi zależnych od `Visibility`/`Contexts` (licencje, cechy, extendery) skaner **nie
  wartościuje** — wypisuje wszystkie pola i przenosi warunek do `Uwagi`. Faktyczna widoczność
  zależy od danych i licencji w czasie działania.
- Kolumny list (`Grid`/`Scheduler`/…) odnoszą się do **elementu kolekcji**, nie do rodzica —
  patrz sekcja „Listy" niżej. Marker `[]` w ścieżce oznacza element kolekcji.
- Pierwsze uruchomienie pobiera pakiety potrzebne `dotnet-script` — wymaga internetu.

## Powiązania

- [`/soneta-form-xml`](../../soneta-form-xml/SKILL.md) — składnia `Page`/`Group`/`Field`/`Include`,
  `DataContext`, `EditValue`; strona źródłowa tego, co skaner odczytuje.
- [scan-props.md](scan-props.md) — pola bazodanowe i kalkulowane tabeli (typy, tytuły) do
  których prowadzą ścieżki pól z formularza.
- [`/soneta-config`](../../soneta-config/SKILL.md) — import/eksport XML; sekcje i kolejność pól
  są istotne przy `business="true"`.
- [context.md](context.md), [safe-code.md](safe-code.md) — budowanie danych kodem w poprawnej sekwencji.
- Narzędzie `scan-folders` (`/soneta-config`) — statyczne foldery menu (listy, formularze).
