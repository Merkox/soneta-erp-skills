# Pola klas biznesowych z DLL (dane wygenerowane + skaner Roslyn)

Odczyt rzeczywistych pól bazodanowych obiektu biznesowego platformy Soneta — pod budowę kodu,
wyrażeń bindujących form.xml oraz [warunków filtrujących](./rowcondition.md).

## Najpierw sprawdź dane wygenerowane (`data/props/`) — bez skanowania

Pola **wszystkich tabel** programu są już wyeksportowane do plików markdown w
[`../data/props/`](../data/props/). Odczyt pliku jest natychmiastowy — nie uruchamiaj
skanera, jeśli szukasz tabeli, która tam jest. Skaner (dalsza część dokumentu) to
fallback dla tabel spoza wygenerowanego zestawu (świeży dodatek, nowsza kompilacja).

**Jak znaleźć tabelę:**
1. Otwórz [`../data/props/INDEX.md`](../data/props/INDEX.md) i wyszukaj `RowType` (np. `DokumentHandlowy`).
   INDEX grupuje tabele wg modułu (z opisem modułu); kolumny:
   `RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik`.
2. Otwórz plik `data/props/<Moduł>/<RowType>.md` — to dokładnie ten sam markdown,
   który wypisałby skaner na żywo (nagłówek z nazwą tabeli, `Tytuł`/`Opis`, `Guided`, `Historyczna`/`Historia`,
   interfejsami; rozłączne statystyki; tabela `Pole | Typ | Rodzaj | Tytuł | Opis`; sekcje
   `## Relacje interfejsowe` i `## Enumy`).

Dodatkowo [`../data/props/Interfaces.md`](../data/props/Interfaces.md) — lista wszystkich interfejsów
(`[TableInfo(Interfaces=...)]`) z tabelami je implementującymi (relacje interfejsowe w jednym miejscu).

Znaczenie nagłówka, kolumny `Rodzaj`/`Typ` i sekcji relacji interfejsowych — patrz sekcje niżej
(opis jest wspólny dla danych wygenerowanych i wyjścia skanera).

## Regeneracja danych po zmianie programu/wersji

Gdy zmieni się kompilacja (nowa wersja platformy, przebudowany dodatek) i pliki w
`data/props/` są nieaktualne, odbuduj cały zestaw jednym poleceniem:

```bash
dotnet script ~/.claude/skills/soneta-programming/scripts/export-props-all.csx \
    -- <KatalogDll> ~/.claude/skills/soneta-programming/data/props
```

Przykład (macOS/Linux): `-- ~/d/dev/bin/Debug ~/.claude/skills/soneta-programming/data/props`.
Skrypt buduje kompilację Roslyn **raz** i iteruje po wszystkich realnych tabelach
(`*Row` mające parę `*Table` i `*Record`), zapisując plik na tabelę, `INDEX.md` (z kolumną
`Historia`) oraz `Interfaces.md` (interfejs → tabele). Cały program (~1200 tabel) eksportuje
się w kilka sekund — nieporównanie szybciej niż 1200 osobnych wywołań `scan-props.csx`. Logika
skanowania pojedynczej tabeli jest identyczna z `scan-props.csx`, więc wynik jest bit-w-bit taki
sam (zweryfikowane diffem — obie ścieżki dają identyczny markdown).

Po regeneracji sprawdź w `INDEX.md`, czy liczba tabel/modułów odpowiada oczekiwaniu,
i zacommituj zmiany w `data/props/` razem z opisem wersji, z której pochodzą.

## Skaner na żądanie (fallback) — pojedyncza tabela

Uruchom, gdy tabeli nie ma w `data/props/` (np. Twój świeżo skompilowany dodatek) albo
potrzebujesz danych z innego katalogu DLL niż ten, z którego zbudowano zestaw.
Skaner czyta metadane DLL i wypisuje tabelę pól na stdout — użyteczny, ale wolny przy
wielokrotnym użyciu (każde wywołanie czyta wszystkie DLL od nowa).

## Cel

W modelu Soneta klasa `Row` (np. `DokumentHandlowy`) udostępnia właściwości publiczne, które można wykorzystać w 
generowanych kodzie biznesowym, oraz do budowania wyrażeń bindujących form.xml. Natomiast w 
[warunkach filtrujących](./rowcondition.md) można używać TYLKO pól bazodanowych udostępnianych przez to narzędzie.

Używaj tego narzędzia, gdy:
- piszesz kod operujący bezpośrednio na polach rekordu (np. w extenderze, workerze, datapack);
- chcesz zweryfikować rzeczywisty typ pola (np. `decimal?` vs `decimal`) bez czytania wygenerowanego kodu;
- pracujesz na dodatku innej osoby i nie masz dostępu do źródeł, tylko do DLL.
- generujesz warunki filtrujące (serwerowe - LINQ)
- Przygotowujesz formularze form.xml.

## Mechanizm

Skrypt używa **Roslyn** (`Microsoft.CodeAnalysis.CSharp`) i `MetadataReference.CreateFromFile`, co oznacza, że **metadane są czytane bez ładowania IL** do CLR — bezpiecznie, bez ryzyka konfliktów wersji, x86/x64 itp.

Algorytm:
1. Zbierz wszystkie `*.dll` z podanego katalogu i zarejestruj jako `MetadataReference`. Dodatkowo dołącz wszystkie biblioteki runtime'u .NET z listy TPA (`AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")`) — bez tego Roslyn nie rozwiązuje typu `System.ComponentModel.DescriptionAttribute` (i podobnych) i `ConstructorArguments` atrybutów zwraca pustą tablicę, przez co `Tytuł`/`Opis` zostają puste.
2. Zbuduj `CSharpCompilation` z tymi referencjami.
3. Przejdź rekurencyjnie po `IAssemblySymbol.GlobalNamespace` każdej referencji.
4. Znajdź pierwszy typ kończący się na `Module`, który zawiera typ zagnieżdżony o nazwie `{NazwaRekordu}Record`.
5. Odczytaj publiczne pola (`IFieldSymbol`, `DeclaredAccessibility == Public`) i ich typy → oznacz jako **bazodanowe**.
6. Znajdź publiczną klasę najwyższego poziomu o nazwie `{NazwaRekordu}` (klasę biznesową, np. `DokumentHandlowy`) i wczytaj jej publiczne, instancyjne `IPropertySymbol` (wraz z dziedziczonymi). **Pomijane są property infrastrukturalne** — te, których nazwa jest zadeklarowana w bazowych klasach ORM `Row` / `GuidedRow` / `ExportedRow` / `SubRow` (np. `ID`, `Guid`, `State`, `Status`, `Session`, `Table`, `Stamp`, `IsAdded`, `IsModified`, `IsDeleted`, `IsStandard`, `Caption`, `Note`, `Attachments`, `FirstChangeInfo`, `LastChangeInfo`). Nie mają one znaczenia biznesowego. Dodatkowo zawsze pomijane jest property `Module` (zwraca typowany moduł, więc nie występuje w bazowym `Row`). Matching jest po **nazwie** (a nie po `ContainingType`), bo klasy generowane potrafią redeklarować takie property przez `new` ze zawężonym typem zwracanym (np. `Table` → `Towary`) — mimo redeklaracji są nadal pomijane. Wyjątek: jeśli nazwa pokrywa się z bazodanowym polem rekordu (krok 5), wpis zostaje zachowany.
7. Scal listy:
   - property o nazwie unikalnej (brak takiego pola w rekordzie) → oznacz jako **kalkulowane**;
   - property o nazwie pokrywającej się z polem rekordu → zachowaj znacznik **bazodanowe**, ale podmień typ na ten z property (bo property zwykle precyzuje typ, np. zwraca konkretny enum lub `Row` zamiast `Guid`/`int`).
8. Dla każdego wpisu odczytaj `Tytuł` i `Opis` — pierwszy parametr `string` konstruktora atrybutu. Matching nazwy atrybutu jest dopasowywany do `Caption`/`CaptionAttribute` oraz `Description`/`DescriptionAttribute` (np. `System.ComponentModel.DescriptionAttribute` używany w generowanym kodzie Soneta). Kolejność źródeł:
   1. property klasy biznesowej (`{NazwaRekordu}`) — z uwzględnieniem dziedziczenia (atrybut może być na property bazowej klasy, np. `{NazwaRekordu}Row`);
   2. pole rekordu (`{NazwaModulu}+{NazwaRekordu}Record`);
   3. odpowiadający member w typie zagnieżdżonym `{NazwaModulu}+{NazwaRekordu}Row` (fallback — przeszukiwany wraz z klasami bazowymi). To tam Soneta zwykle deklaruje `[Description("...")]` na publicznych property delegujących do pola rekordu.
9. **Rekurencja po subrowach** — jeśli któreś z pól rekordu ma typ kończący się na `Record` (np. `CoreModule.DefinicjaNumeracjiRecord Numeracja`), traktuj je jako subrow:
   - na bazie nazwy typu wylicz nazwę bazową (`DefinicjaNumeracjiRecord` → `DefinicjaNumeracji`);
   - znajdź klasę biznesową (`DefinicjaNumeracji`) oraz typ `*Module+DefinicjaNumeracjiRow` (mogą być w innym module — np. `CoreModule`);
   - powtórz całą procedurę (kroki 5–8) dla tego rekordu, używając prefiksu `Numeracja.` w kluczach wyników (`Numeracja.Pole1`, `Numeracja.Pole2`, …).
   Rekurencja działa dowolnie głęboko (subrow w subrowie). Pętle (rekord zawierający siebie pośrednio) są zabezpieczone przez zbiór odwiedzonych typów.
10. **Metadane tabeli** — dodatkowo do nagłówka trafiają:
    - `Tytuł: …` / `Opis: …` — `[Caption]`/`[Description]` **całej tabeli** (zwykle l.mn., np.
      „Dokumenty handlowe"), czytane z zagnieżdżonej klasy `*Module.*Table` (fallback: `*Row`).
      To opis tabeli jako całości — niezależny od opisów pojedynczych pól w kolumnie `Opis`.
    - `Tabela konfiguracyjna: Tak/Nie` — czytane z `[TableInfo(IsConfig=true)]` na zagnieżdżonej
      klasie `*Module.*Table` (atrybut siedzi tam, nie na top-levelowym typie zwracanym przez
      property `Table` w `*Row`).
    - `Guided: root` — gdy `*Table` dziedziczy z `GuidedTable`/`ExportedTable`.
    - `Guided: child — nadrzędna przez pole \`X\` → \`Y\`` — gdy w rekordzie istnieje pole
      z `[ColumnInfo(GuidedRelation=…)]` wskazujące tabelę nadrzędną w drzewie obiektów.
    - `Implementuje interfejsy: …` — lista interfejsów z `[TableInfo(Interfaces=…)]` tej tabeli.
11. **Relacje interfejsowe** — skrypt buduje globalny indeks `interfejs → lista tabel implementujących`
    (iteracja po wszystkich `*Module.*Table` we wszystkich referencjach). Dla każdego pola, którego
    typ jest interfejsem występującym w tym indeksie (heurystyka: nazwa zaczyna się od `I` + wielka
    litera), kolumna `Rodzaj` dostaje znacznik `iface-ref`, a po głównej tabeli pól wypisywana
    jest sekcja `## Relacje interfejsowe` z listą `Pole | Interfejs | Tabele implementujące`.
    Pozwala to od razu zobaczyć alternatywy, do których pole może wskazywać.
12. **Znacznik `guided-parent`** — pole rekordu z atrybutem `[ColumnInfo(GuidedRelation=…)]`
    dostaje w kolumnie `Rodzaj` dodatkowy tag `guided-parent`, sygnalizując, że to ono trzyma
    referencję do rootu drzewa.
13. **Znacznik `enum` i sekcja `## Enumy`** — dla każdego pola, którego typ jest enumem
    (`TypeKind.Enum`, także pod `Nullable<>`), kolumna `Rodzaj` dostaje tag `enum`. Po tabeli pól
    (i ewentualnej sekcji relacji interfejsowych) wypisywana jest sekcja `## Enumy`: dla każdego
    użytego typu enum — nagłówek `### {Nazwa}` i lista dozwolonych wartości
    `` - `Nazwa` = {wartość całkowita} — Tytuł`` (wartość liczbowa stałej z metadanych, np. dla
    enumów `[Flags]` są to potęgi dwójki; Tytuł z `[Caption]`/`[Description]` stałej, o ile jest).
    Enumy są zbierane z pól faktycznie wypisanych w tabeli (bazodanowych i kalkulowanych),
    deduplikowane i sortowane po pełnej nazwie.
14. Wypisz tabelę markdown na stdout (kolumny: `Pole | Typ | Rodzaj | Tytuł | Opis`).

## Wymagania

- .NET SDK 10
- `dotnet-script`:
  ```bash
  dotnet tool install -g dotnet-script
  ```
  Global tool ląduje w `~/.dotnet/tools`, który bywa **poza PATH** (`which dotnet-script` nie
  znajduje mimo `dotnet tool list -g`). Dodaj go do PATH — macOS/Linux:
  `export PATH="$PATH:$HOME/.dotnet/tools"`; Windows (PowerShell):
  `$env:PATH += ";$env:USERPROFILE\.dotnet\tools"`.

## Uruchomienie

```bash
dotnet script ~/.claude/skills/soneta-programming/scripts/scan-props.csx \
    -- <NazwaRow> <KatalogDll>
```

### Przykład

```bash
dotnet script ~/.claude/skills/soneta-programming/scripts/scan-props.csx \
    -- DokumentHandlowy ./bin/Debug/net10.0
```

### Przykładowe wyjście

```markdown
# Pola i właściwości klasy biznesowej: `Soneta.Handel.DokumentHandlowy`
Nazwa tabeli: `DokHandlowe`
Tytuł: Dokumenty handlowe
Opis: Główna tabela dokumentów handlowych (faktury, paragony, zamówienia, korekty, umowy itp.).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`, `IKontrahentRef`

- pola bazodanowe (zapisywalne): 96
- pola kalkulowane (zapisywalne): 12
- pola tylko-odczyt: 40
- podlisty: 60
- subrowy: 8
- razem: 216

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Brutto | `decimal` | bazodanowe | Brutto | Wartość brutto dokumentu |
| DataDokumentu | `System.DateTime` | bazodanowe | Data dokumentu |  |
| Kontrahent | `Soneta.Kontrahenci.Kontrahent` | bazodanowe, iface-ref | Kontrahent |  |
| Pozycje | `…DokumentHandlowy.PozycjeSubTable` | podlista |  |  |
| Stan | `Soneta.Handel.StanDokumentuHandlowego` (enum) | bazodanowe | Stan | Określa stan dokumentu… |
| SaldoWaluta | `Waluta` | tylko-odczyt | Saldo w walucie |  |
| ...  | ... | ... | ... | ... |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Kontrahent`, `Pracownik`, `Urzad` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanDokumentuHandlowego (`Soneta.Handel.StanDokumentuHandlowego`)
- `Bufor` = 0
- `Zatwierdzony` = 1
- `Zablokowany` = 2
- `Anulowany` = 3
```

Kolumna `Rodzaj` jest kombinacją znaczników rozdzielonych przecinkami:
- `bazodanowe` — pole rekordu (`*Record`); brak znacznika = property kalkulowana klasy biznesowej.
- `tylko-odczyt` — property bez publicznego settera (nie ustawisz jej kodem/importem XML).
- `podlista` — typ kolekcyjny/posiadany: tablica, `Key`, `View`, `SubTable`, dowolny `IEnumerable`
  (poza `string`; wyjątek `Periods`). Elementy dodaje się, nie ustawia wprost.
- `guided-parent` — pole z `[ColumnInfo(GuidedRelation=…)]` trzymające referencję do nadrzędnej
  tabeli w drzewie obiektów guided.
- `iface-ref` — typ pola jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=…)]` innej tabeli;
  konkretne tabele docelowe są wymienione w sekcji `## Relacje interfejsowe` pod tabelą pól
  (globalny wykaz: [`../data/props/Interfaces.md`](../data/props/Interfaces.md)).

Kolumna `Typ` niesie sufiksy:
- `(enum)` — typ jest enumem (także `Nullable<enum>`); dozwolone wartości w sekcji `## Enumy` niżej.
- `(subrow)` — osadzony kontener rekordowy (pole `*Record`, rozwijane rekurencyjnie w polach `X.Y`).

Prefiksy `Soneta.Business.` i `Soneta.Types.` są w typie skracane (`Soneta.Business.Key` → `Key`).
Pola oznaczone `[Obsolete]` są pomijane.

**Statystyki** pod nagłówkiem są rozłączne (każde pole w jednej kategorii; sumują się do `razem`):
`bazodanowe (zapisywalne)`, `kalkulowane (zapisywalne)`, `tylko-odczyt`, `podlisty`, `subrowy`
(priorytet: subrow > podlista > tylko-odczyt > bazodanowe/kalkulowane).

**Historia** (nagłówek + kolumna INDEX): `Historyczna: … w tabeli H` (obiekt wersjonowany,
`IRowWithHistory`) lub `Historia: … tabeli P` (rekord historyczny obiektu P, `IHistory`).

## Kody wyjścia

| Kod | Znaczenie |
|-----|-----------|
| `0` | OK — wypisano tabelę pól |
| `1` | Błąd argumentów / nie istnieje katalog / brak DLL |
| `2` | Nie znaleziono typu `*Module+{NazwaRekordu}Record` w referencjach |

## Ograniczenia

- Skanuje tylko górny poziom katalogu (`SearchOption.TopDirectoryOnly`) — jeśli DLL są rozproszone, skopiuj je do jednego katalogu.
- Zwraca pierwszy znaleziony typ pasujący do wzorca `*Module+{Nazwa}Record` — jeśli dwa moduły mają taki sam zagnieżdżony rekord, dostaniesz tylko jeden (niedeterministycznie wg kolejności assembly).
- Zwraca **publiczne pola** rekordu (`IFieldSymbol`) oraz **publiczne, instancyjne właściwości** klasy biznesowej (`IPropertySymbol`, łącznie z dziedziczonymi), **z pominięciem property infrastrukturalnych** z klas bazowych `Row` / `GuidedRow` / `ExportedRow` / `SubRow` (patrz krok 6). Pola rekordu = źródło prawdy o schemacie DB (rodzaj `bazodanowe`); właściwości spoza rekordu = wyliczane w kodzie (rodzaj `kalkulowane`).
- Jeśli klasa biznesowa o nazwie `{NazwaRekordu}` nie zostanie znaleziona w referencjach, skrypt zwraca tylko listę pól bazodanowych (z odpowiednią adnotacją w nagłówku) i kończy się kodem `0`.
- Pierwsze uruchomienie pobiera pakiet NuGet `Microsoft.CodeAnalysis.CSharp` — wymaga połączenia internetowego (kolejne odpalenia działają offline).

## Powiązania

- Dane wygenerowane: [`../data/props/`](../data/props/) (indeks: [`../data/props/INDEX.md`](../data/props/INDEX.md)) — pierwsze źródło pól tabel.
- Skrypt wsadowej regeneracji: `scripts/export-props-all.csx` — buduje kompilację raz i eksportuje cały `data/props/`.
- [scan-modules.md](scan-modules.md) — inwentaryzacja modułów/tabel; przydatna, by ustalić `RowType`/moduł (ta sama informacja jest też w `INDEX.md`).
- Patrz [datapack-guidedrow.md](datapack-guidedrow.md) — struktury `GuidedRow` / `ExportedRow` i mechanizm Datapack operujący na polach rekordu.
- Patrz skill `soneta-business-xml` — definicja schematu, z którego `BusinessGenerator` produkuje klasę `XxxRecord`.
