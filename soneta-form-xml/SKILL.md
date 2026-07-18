---
name: soneta-form-xml
description: "Specjalistyczna wiedza o WŁASNOŚCIOWYM formacie plików form.xml platformy Soneta (enova365) — bez tego skilla Claude generuje błędne XML z nieistniejącymi elementami. ZAWSZE używaj tego skilla gdy użytkownik: (1) prosi o utworzenie lub modyfikację pliku pageform.xml, viewform.xml, form.xml, lookupform.xml lub gridform.xml dla platformy Soneta (enova365); (2) pyta o elementy DataForm, Page, Group, Grid, Field, Row, Stack, Flow, Command, Include, Appearance, GroupBy w Soneta; (3) pyta o składnię EditValue, DataContext, Visibility, RowCondition, Renderable, CaptionHtml, Footer, Class lub układ UI formularzy Soneta; (4) pokazuje istniejący plik form.xml/pageform.xml/viewform.xml i pyta o jego strukturę lub chce go rozszerzyć; (5) pyta o warunkową widoczność, formatowanie warunkowe (Appearance), bindowanie danych lub wzorce UI w Soneta/enova365."
---

# Soneta Form XML - Formularze UI

## Lokalizacja plików — biblioteka `.UI`

Wszystkie definicje interfejsu użytkownika (`pageform.xml`, `viewform.xml`, `gridform.xml`,
`lookupform.xml`, `form.xml`, a także ViewInfo i extendery UI) umieszcza się w **bibliotece UI**
odpowiadającej modułowi biznesowemu — o nazwie modułu z sufiksem **`.UI`**:

| Moduł biznesowy | Biblioteka UI |
|---|---|
| `Soneta.Handel` | `Soneta.Handel.UI` |
| `Soneta.Business` | `Soneta.Business.UI` |
| `Soneta.CRM` | `Soneta.CRM.UI` |

Cel: **rozdzielenie logiki biznesowej od prezentacji**. Moduł biznesowy nie ma (i nie może mieć)
referencji do warstwy UI ani do innych modułów biznesowych; biblioteka `.UI` **może** referować
wiele modułów biznesowych, dzięki czemu formularz sięga po typy z różnych obszarów. Dlatego
formularze obiektów z `Soneta.X` zapisuj w projekcie `Soneta.X.UI`, nie obok klas biznesowych.

## Typy plików formularzy

| Typ pliku | Wzorzec nazwy | Przeznaczenie |
|-----------|---------------|---------------|
| **pageform.xml** | `{DataType}.{PageName}.pageform.xml` | Zakładka formularza edycji obiektu |
| **viewform.xml** | `{NazwaWidoku}.viewform.xml` | Widok listy zarejestrowanej jako folder (listy główne) |
| **gridform.xml** | `{IdentyfikatorListy}.gridform.xml` | Indywidualne ustawienia listy na formularzu |
| **lookupform.xml** | `{NazwaPodpowiedzi}.lookupform.xml` | Lista wyboru (lookup) |
| **form.xml** | `{Nazwa}.form.xml` | Współdzielony fragment UI (include) |

**Przykłady pageform.xml:** `Towar.Ogolne.pageform.xml`, `Kontrahent.Adresy.pageform.xml`

## Struktura dokumentu

Każdy plik formularza zaczyna się od deklaracji XML i elementu `DataForm`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<DataForm xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
          xmlns:xsd="http://www.w3.org/2001/XMLSchema"
          xmlns="http://www.enova.pl/schema/form.xsd"
          xsi:schemaLocation="http://www.enova.pl/schema/ https://www.enova.pl/schema/form.xsd">
  <!-- zawartość -->
</DataForm>
```

### Atrybuty DataForm

| Atrybut | Opis |
|---------|------|
| `Priority` | Kolejność zakładek (domyślnie 100, niższa = wcześniej) |
| `RightName` | Opcjonalny. Nazwa uprawnienia do zakładki |
| `Contexts` | Warunki licencyjne, np. `"Licence.HAN \| Licence.FA"` |
| `ViewType` | Typ widoku: `None`, `Dialog`, `Form`, `Folder` |
| `Mode` | Tryb: `None`, `Form`, `Folder`, `Wizard`, `Modal`, `Popup`, `Frame` |
| `DataType` | Opcjonalny. Pełna nazwa typu gdy nie wynika z nazwy pliku |

## Wspólne atrybuty elementów

| Atrybut | Opis |
|---------|------|
| `Name` | Identyfikator elementu (dostępny w kodzie C#) |
| `Class` | Klasy stylów (lista wartości oddzielonych spacją) |
| `DataContext` | Zmienia kontekst danych dla elementu i elementów podrzędnych |
| `Visibility` | Warunek widoczności (bindowalne): `true`/`false`/`{wyrażenie}` |
| `Renderable` | Czy element ma być dostępny — liczone **raz** przy logowaniu |
| `Width` | Szerokość w znakach lub px; `"*"` = wypełnij |
| `Height` | Wysokość w wierszach lub px; `"*"` = wypełnij |

### Atrybut CaptionHtml

- Tekst etykiety (w formacie HTML)
- Wyrażenia bindowane: `{Właściwość}` → wartość automatycznie kodowana do HTML
- Wyrażenia HTML: `{WłaściwośćHtml}` → sufiks `Html` wyłącza kodowanie
- Podwójne klamry dla literałów: `{{` → `{`
- Alternatywa: `CaptionMarkdown` dla Markdown

**Specjalne przypadki w `Field`:**
- Brak atrybutu → automatyczna etykieta wyliczana na podstawie danych
- `CaptionHtml=" "` (spacja) → pusta etykieta (miejsce zachowane)
- `CaptionHtml=""` (pusty) → brak etykiety i miejsca

## Elementy kontenerowe

### Page - Zakładka

```xml
<Page CaptionHtml="Ogólne" DataContext="{DataSource}">
  <!-- zawartość zakładki -->
</Page>
```

| Atrybut | Opis |
|---------|------|
| `CaptionHtml` | Tytuł; może zawierać `/` do grupowania (np. `"Dokumenty/Faktury"`) |
| `DataContext` | Źródło danych; `{DataSource}` = obiekt edytowany |
| `Visibility` | Wyrażenie warunkowe widoczności (bindowalne) |
| `Renderable` | Liczone raz przy logowaniu — dla warunków licencji/środowiska |
| `Key` | Skrót klawiaturowy |

### Group - Grupa pól

```xml
<Group CaptionHtml="Dane podstawowe" LabelWidth="20">
  <Field CaptionHtml="Kod" Width="20" EditValue="{Kod}" />
  <Field CaptionHtml="Nazwa" Width="*" EditValue="{Nazwa}" />
</Group>
```

`LabelWidth` ustawia szerokość etykiet dla wszystkich pól w grupie.

### Stack, Row, Flow - Układ elementów

```xml
<!-- Stack: układ pionowy (elementy jeden pod drugim) -->
<Stack LabelWidth="15">
  <Field CaptionHtml="Pole 1" EditValue="{Pole1}" />
</Stack>

<!-- Row: układ poziomy -->
<Row>
  <Field CaptionHtml="Kod" Width="20" EditValue="{Kod}" />
  <Gap Width="*" />  <!-- przesuwa kolejne elementy do prawej -->
  <Field CaptionHtml="Status" Width="15" EditValue="{Status}" />
</Row>

<!-- Flow: elementy od lewej do prawej z zawijaniem -->
<Flow Align="true">
  <Field CaptionHtml="Data od" Width="15" EditValue="{DataOd}" />
  <Field CaptionHtml="Data do" Width="15" EditValue="{DataDo}" />
</Flow>
```

> **⚠️ Układ dwukolumnowy — NIE używaj `<Row>` z zagnieżdżonymi `<Stack>`!** Potwierdzone
> wizualnie (zrzut ekranu z żywej aplikacji): `<Row>` zawierający `<Stack>` z polami `Width="*"`
> renderuje „kolumny" **jedna na drugiej** — etykiety i pola się nakładają. **Poprawny wzorzec:**
> pola `<Field>` **wprost** w `<Row>`, o **stałych** szerokościach, po jednym `<Row>` na każdy
> wiersz layoutu:
>
> ```xml
> <!-- ŹLE: kolumny nakładają się na siebie -->
> <Row>
>   <Stack><Field CaptionHtml="Kod"  Width="*" EditValue="{Kod}" /></Stack>
>   <Stack><Field CaptionHtml="Data" Width="*" EditValue="{Data}" /></Stack>
> </Row>
>
> <!-- DOBRZE: Field wprost w Row, stałe szerokości, jeden Row = jeden wiersz -->
> <Row>
>   <Field CaptionHtml="Kod"    Width="20" EditValue="{Kod}" />
>   <Field CaptionHtml="Data"   Width="14" EditValue="{Data}" />
> </Row>
> <Row>
>   <Field CaptionHtml="Nazwa"  Width="40" EditValue="{Nazwa}" />
>   <Field CaptionHtml="Status" Width="15" EditValue="{Status}" />
> </Row>
> ```
>
> Po zbudowaniu układu wielokolumnowego **zawsze zweryfikuj go wizualnie** zrzutem ekranu
> (sekcja „Wizualna weryfikacja formularza (buscall)").

### Zasada budowania zakładki

```xml
<Page CaptionHtml="Ogólne" DataContext="{DataSource}">
  <Group CaptionHtml="Dane podstawowe">
    <!-- pola pionowo -->
    <Field CaptionHtml="Kod" Width="20" EditValue="{Kod}" />
    <!-- lub wielokolumnowo — Field WPROST w Row, stałe szerokości (patrz ostrzeżenie wyżej): -->
    <Row>
      <Field CaptionHtml="Data" Width="14" EditValue="{Data}" />
      <Field CaptionHtml="Status" Width="15" EditValue="{Status}" />
    </Row>
  </Group>
  <Group CaptionHtml="Pozycje">
    <Grid Width="*" Height="*" EditValue="{Pozycje}" IsToolbarVisible="true">
      <Field CaptionHtml="Nazwa" Width="30" EditValue="{Nazwa}" />
    </Grid>
  </Group>
</Page>
```

> **Szerokość kolumn w `Grid`.** `Width="*"` (wypełnij) działa wyłącznie na **kontenerach**
> (`Grid`, `Group`, `Stack`) oraz na samodzielnym polu w układzie formularza. **Kolumny listy**
> — czyli `Field` będący bezpośrednim dzieckiem `Grid` — muszą mieć **stałą** szerokość w
> znakach (np. `Width="30"`). `*` na kolumnie nie ma sensu i daje nieprawidłowy układ, bo
> szerokości kolumn są zarządzane przez siatkę. Sam `Grid` ma natomiast zwykle `Width="*"
> Height="*"`, żeby wypełnić zakładkę.

## Elementy pól i kontrolek

### Field - Pole edycyjne

Jest generowany **dynamicznie** — typ właściwości decyduje o kontrolce (int → liczba, bool → checkbox, typ Sonety → lookup).

```xml
<Field CaptionHtml="Nazwa pola" Width="20" EditValue="{Właściwość}"
       Important="true" IsReadOnly="{Warunek}" />
```

| Atrybut | Opis |
|---------|------|
| `EditValue` | **Wymagany**. Binding do właściwości: `{Właściwość}` lub `{new Ext.Właściwość}` |
| `CaptionHtml` | Etykieta pola |
| `Width` | Szerokość pola (`*` = wypełnij) |
| `Height` | Wysokość (dla pól wieloliniowych) |
| `Important` | `true` — pole oznaczone jako ważne (wyróżnione w widoku) |
| `IsReadOnly` | Warunek tylko do odczytu (bindowalne) — **zwykle zbędny**, patrz niżej |
| `Format` | Formatowanie w standardzie .NET: `N2`, `d`, `C` |
| `Footer` | Agregacja w stopce listy: `Sum`, `Count`, `Average`, `Min`, `Max` |
| `CheckedValue` | Wartość dla RadioButton |
| `Class` | Klasy stylów |

**Kiedy NIE dodawać `IsReadOnly`.** Tryb tylko-do-odczytu jest wyliczany automatycznie — nie
dokładaj `IsReadOnly="true"`, gdy pole i tak ma być nieedytowalne z jednego z poniższych powodów:
- **property bez settera** (tylko `get`) — np. pole `readonly`/selektor z definicji danych lub
  property kalkulowana — jest read-only z definicji (definicję pól tabeli opisuje skill
  **`/soneta-business-xml`**, table-reference.md);
- **prawa do obiektu biznesowego** — brak prawa zapisu blokuje edycję automatycznie;
- **metoda `IsReadOnlyX()`** obok property `X` w klasie biznesowej — zwraca warunek, czy edytor ma
  być zablokowany (to preferowany sposób sterowania read-only, bo logika zostaje przy danych).

`IsReadOnly` na `Field` stosuj **tylko** gdy chcesz **nadpisać** ten standardowy mechanizm
(np. zablokować w UI property, która ma setter i nie jest objęta `IsReadOnlyX()`).

**RadioButton** — pola z tym samym `EditValue` i różnymi `CheckedValue`:
```xml
<Field Width="15" CaptionHtml="Towar" EditValue="{Typ}" CheckedValue="Towar" />
<Field Width="15" CaptionHtml="Usługa" EditValue="{Typ}" CheckedValue="Usługa" />
```

**Pole wieloliniowe (memo).** Wieloliniowy edytor tekstu to zwykły `Field` z `Height="N"`
(liczba wierszy) i `Width="*"`. Aby zrobić panel podglądu tylko-do-odczytu (np. tekst
zbudowany w kodzie), dodaj `IsReadOnly="true"` albo zwiąż go z property bez settera — nie
potrzeba `Class` ani specjalnego edytora:
```xml
<Field CaptionHtml="Podgląd" Width="*" Height="8" IsReadOnly="true" EditValue="{TekstPodgladu}" />
```

### Label, Gap, Command, Include

```xml
<Label CaptionHtml="Tekst informacyjny" Width="30" />
<Gap Width="*" />   <!-- wypełniacz; pusty na końcu wiersza nic nie zmienia -->

<Command CaptionHtml="Zapisz" MethodName="Zapisz"
         DataContext="{new MojExtender}" Visibility="{IsVisible}"
         CommandStyle="Important" Key="F5" />

<!-- Dołączenie pliku form.xml -->
<Include Source="Adres.form.xml" DataContext="{Adres}" />
<!-- Dynamiczny element z kodu C# -->
<Include Source="{DynamicznyFormularz}" />
```

`Command` wywołuje metodę (`MethodName`) lub otwiera obiekt (`OpenMethodName`) z kontekstu —
zwykle z extendera/workera. Co taka akcja zwraca (action result: zamknięcie okna, otwarcie
formularza, komunikat) opisuje skill **`/soneta-programming`** (action-result.md, worker-extender.md).

## Kolekcje i listy

### Grid / List - Tabela danych

```xml
<Grid Width="*" Height="*"
      EditValue="{Pozycje}"
      IsToolbarVisible="true"
      IsFilterRowVisible="false"
      EditInPlace="true"
      NewInPlace="true"
      OrderBy="Data desc"
      SumType="All"
      FilterPanelWidth="136"
      SelectedValue="{WybranePozycje}"
      FocusedValue="{AktualnaPozycja}">
  <Field CaptionHtml="Kod" Width="15" EditValue="{Kod}" />
  <Field CaptionHtml="Ilość" Width="10" EditValue="{Ilosc}" Footer="Sum" />
  <GroupBy EditValue="{Kategoria}" IsDescending="false" />
  <UserFilter Value="Status='Aktywny'" />
  <Data Name="nazwaParametru" Value="wartość" />
</Grid>
```

| Atrybut | Default | Opis |
|---------|---------|------|
| `EditValue` | — | Źródło danych kolekcji |
| `IsToolbarVisible` | `false` | Pasek narzędzi |
| `IsFilterRowVisible` | `false` | Wiersz filtrujący |
| `EditInPlace` | `false` | Edycja bezpośrednio w komórkach |
| `NewInPlace` | `false` | Dodawanie przez kliknięcie pustego wiersza |
| `OrderBy` | — | Domyślne sortowanie: `"Kolumna desc"` |
| `FilterPanelWidth` | — | Szerokość panelu filtrów |
| `SumType` | `None` | `None`, `Selected`, `All`, `Groups`, `GroupsNewLine` |
| `IsSmartOpen` | — | Kolumna ze strzałką do otwarcia formularza |
| `VisibleFeatures` | — | Lista widocznych cech: `"Asortyment,Producent"` |
| `SelectedValue` | — | Binding do zaznaczonych wierszy (tablica) |
| `FocusedValue` | — | Binding do aktywnego wiersza |

**Przyciski:** `NewButton`, `EditButton`, `RemoveButton`, `SearchButton` — wartości `Auto`, `None`, `Visible`.

### Lista sterowana kodem — `EditValue` wskazujące `ViewInfo`

`Grid` można zasilić nie tylko prostą kolekcją (`{Pozycje}`), ale też property zwracającą
`ViewInfo` (`EditValue="{MojaListaView}"`). Wtedy zawartość listy, filtr, sortowanie i blokady
(dodawanie/edycja/usuwanie) buduje kod w handlerze tworzącym widok. To standard dla list z
nietrywialnym filtrowaniem — zwłaszcza diagnostycznych/konfiguracyjnych — osadzonych na
formularzu lub w oknie:

```xml
<Grid Width="*" Height="*" EditValue="{MojaListaView}" IsToolbarVisible="true" OrderBy="Data desc">
  <Field CaptionHtml="Data" Width="14" EditValue="{Data}" />
  <Field CaptionHtml="Opis" Width="60" EditValue="{Opis}" />
</Grid>
```

Stronę logiki (jak zbudować `ViewInfo` jako property/folder i filtrować widok) opisuje skill
**`/soneta-programming`** (viewinfo.md, rowcondition.md).

### Multi-select — `SelectedValue` i reaktywne pole pochodne

`SelectedValue="{Zaznaczone}"` wiąże **wiele** zaznaczonych wierszy z property typu tablica
wierszy (np. `Faktura[]`) w obiekcie kontekstu. `FocusedValue` to inny scenariusz — **jeden**
aktywny wiersz.

Jeśli pod listą ma się pojawić wartość zbudowana z zaznaczenia (połączony tekst, suma, dowolny
algorytm), zwiąż zależne pole z property **tylko-do-odczytu**, która liczy wynik z tej tablicy.
Property `SelectedValue`/`FocusedValue` może być **zwykłą auto-property** — sama zmiana
zaznaczenia/fokusu wymusza przeliczenie pól zależnych, więc **nie** trzeba w jej setterze ręcznie
odświeżać UI:

```xml
<Grid Width="*" Height="*" EditValue="{FakturyView}" SelectedValue="{Zaznaczone}" IsToolbarVisible="true" />
<Field CaptionHtml="Suma zaznaczonych" Width="*" IsReadOnly="true" EditValue="{SumaZaznaczonych}" />
```

### Pasek filtra listy — `Flow Class="DataBar"` wewnątrz `Grid`

Pola filtrujące listę umieszcza się zwykle w `Flow Class="DataBar"` **wewnątrz** `<Grid>`,
obok kolumn `Field`. Mimo zagnieżdżenia w XML taki `Flow` działa na poziomie bindowania
**samego gridu** (nie schodzi do kontekstu wiersza), a `Class="DataBar"` renderuje go jako
pasek parametrów listy. Dzięki temu filtr jest **zarządzany przez organizator listy** i tworzy
z listą jeden spójny element (zamiast luźnego `Flow` postawionego nad gridem).

**Etykiety pól filtrujących umieszczaj na górze, nad polem** (`Class="LabelTop"`) — niezależnie od
typu formularza (nawet gdy poza filtrem obowiązuje domyślny `LabelLeft`; o pozycji etykiet ogólnie
patrz sekcja „Pozycja etykiety względem pola").

Są **dwa sposoby** wskazania, skąd filtr czyta/zapisuje wartości:

**1. Filtry w obiekcie kontekstu (dominujący wzorzec w programie).** `DataContext="{Context}"`,
a pola bindują się do właściwości klasy parametrów (`Params : ContextBase`) trzymanej w
kontekście — przez `{NazwaParams.Pole}`:
```xml
<Grid Width="*" Height="*" EditValue="{ObrotyView}" IsToolbarVisible="true">
  <Field CaptionHtml="Towar" Width="17" EditValue="{Towar}" />
  <Field CaptionHtml="Marża" Width="11" EditValue="{Marża}" Footer="Sum" />
  <Flow Class="DataBar" DataContext="{Context}" Align="true">
    <Field CaptionHtml="Okres" Width="22" EditValue="{ObrotyParams.OkresCzasu}" />
  </Flow>
</Grid>
```

**2. Filtry na obiekcie głównym (dozwolony, choć w programie rzadki).** Gdy property filtrów
leżą wprost na obiekcie sterującym oknem (`{DataSource}`), **nie ustawiaj `DataContext`** na
`Flow` — odziedziczy on kontekst strony i bindy rozwiążą się względem obiektu głównego:
```xml
<Grid Width="*" Height="*" EditValue="{WpisyView}" IsToolbarVisible="true">
  <Field CaptionHtml="Data"    Width="14" EditValue="{Data}" />
  <Field CaptionHtml="Request" Width="80" EditValue="{Opis}" />
  <Flow Class="DataBar" Align="true">
    <Field CaptionHtml="Operator" Width="25" EditValue="{Operator}" />  <!-- property obiektu głównego -->
    <Field CaptionHtml="Okres"    Width="22" EditValue="{Okres}" />
  </Flow>
</Grid>
```

Stronę C# (klasę parametrów `Params : ContextBase` vs property na obiekcie głównym z
`[Accessor(AutoChange = true)]`) opisuje skill **`/soneta-programming`** (contextbase.md, context.md).

## Bindowanie danych

### Powiązanie typu z formularzem

1. **Przez nazwę pliku** — pierwszy człon nazwy pliku wyznacza typ okna. Może to być:
   - **klasa** — `Towar.Ogolne.pageform.xml` → kontekst klasy `Towar`;
   - **interfejs** — wspólna zakładka wielu tabel implementujących dany interfejs (relacje
     interfejsowe, np. `IKontrahent...`);
   - **klasa dziedzicząca (selektor)** — zakładka dla wariantu/podtypu obiektu;
   - **`Config.`** — okno konfiguracji (ustawienia modułów), np. `Config.DefDokHandlowych...`.
2. **Przez atrybut DataType** — `<DataForm DataType="Soneta.Handel.Towar,Soneta.Handel">`;
   wiąże typ **jawnie**, gdy nazwa pliku jest niejednoznaczna (formularze parametrów workerów,
   konfiguracji, selektory) lub gdy typ jest w innej przestrzeni nazw.
3. **Przez rejestrację FolderViewAttribute** — dla viewform.xml

> Odczyt rzeczywistego powiązania (który człon/`DataType`, także zawężanie po namespace, gdy ta
> sama nazwa jest w wielu modułach) z zasobów DLL realizuje skaner **`scan-forms`**
> (`/soneta-programming`, references/scan-forms.md).

### Wiele zakładek jednego okna — auto-składanie po nazwie pliku

Okno wielozakładkowe **nie** wymaga rejestracji zakładek w kodzie. Wystarczy dodać kolejny
plik `{Typ}.{NazwaZakładki}.pageform.xml` — system zbiera **wszystkie** pliki o tym samym
prefiksie typu i składa je w jedno okno (każdy plik = jedna `Page`). Aby dorzucić zakładkę do
istniejącego okna (np. okna narzędziowego/konfiguracyjnego sterowanego klasą `Foo`), dodaj
plik `Foo.Moja.pageform.xml` z `<Page CaptionHtml="Moja" DataContext="{DataSource}">` — pojawi
się automatycznie. `CaptionHtml` bez `/` → samodzielna zakładka; z `/` → hierarchia.

> **Osadzanie zasobu.** Pliki `*.pageform.xml` / `*.form.xml` / `*.viewform.xml` są dołączane
> do biblioteki jako zasób przez konwencję budowania projektu — zwykle **nie** trzeba dodawać
> ich ręcznie do pliku projektu. Po dodaniu pliku wystarczy zbudować projekt i zakładka jest
> dostępna. (Jeśli wyjątkowo nie zostanie znaleziona, dopiero wtedy rozważ jawne dołączenie
> zasobu w konfiguracji projektu.)

> **Zakładki i grupy = sekcje danych.** `Page` i `Group` wyznaczają logiczne **sekcje danych**
> do uzupełnienia, a kolejność pól odzwierciedla kolejność wprowadzania (i pośrednio wykonywanego
> kodu). Ma to znaczenie przy budowaniu danych **kodem** oraz przy **imporcie XML `business="true"`**
> (patrz skill `/soneta-config`). Gdy masz tylko skompilowane DLL (bez źródeł formularzy), zakładki,
> sekcje i rozwinięte ścieżki pól (łańcuch `DataContext`+`EditValue`, dołączane `Include`)
> odczytasz z zasobów osadzonych skanerem **`scan-forms`** ze skilla `/soneta-programming`
> (references/scan-forms.md).

### Zmiana kontekstu danych

- `DataContext="{Adres}"` — zmienia kontekst **aktualnego elementu i podrzędnych**
- `EditValue="{Pozycje}"` na **elemencie listowym** — zmienia kontekst **tylko podrzędnych**:
  pola/kolumny wewnątrz odnoszą się już do **elementu kolekcji** zwróconej przez to `EditValue`
  (inny obiekt niż kontekst rodzica), nie do bieżącego `DataSource`. Dotyczy to **wszystkich
  elementów listowych**, nie tylko `Grid`: `Grid`, `TreeList`, `Scheduler`, `Gantt`,
  `GanttDiagram`, `KanbanDiagram`, `Pivot`, `Chart`, `Diagram`, `TreeDiagram`. Np. w
  `<Grid EditValue="{Pozycje}">` kolumna `<Field EditValue="{Cena}">` to `Pozycje` → element →
  `Cena`. Pełne ścieżki pól z rozwiniętym kontekstem (marker `[]` dla elementu kolekcji)
  wypisuje skaner **`scan-forms`** (`/soneta-programming`, references/scan-forms.md).

**`{DataSource}` to obiekt sterujący oknem.** Zwykle jest to edytowany `Row`, ale równie dobrze
może być klasa sterująca oknem narzędziowym/diagnostycznym. Wtedy pola (także filtry w pasku
`Flow`) bindują się wprost do jej publicznych property przez dziedziczony `DataContext` strony,
bez osobnego obiektu kontekstu:
```xml
<Page CaptionHtml="..." DataContext="{DataSource}">
  <Flow Align="true">
    <Field CaptionHtml="Operator" Width="25" EditValue="{Operator}" />  <!-- property obiektu sterującego -->
    <Field CaptionHtml="Okres"    Width="22" EditValue="{Okres}" />
  </Flow>
  ...
</Page>
```

### Składnia wyrażeń `{...}`

| Składnia | Opis |
|----------|------|
| `{Właściwość}` | Publiczna właściwość w kontekście |
| `{Obiekt.Właściwość}` | Właściwość zagnieżdżona |
| `{Obiekt+SubObiekt.Właściwość}` | Operator `+` — nawigacja przez powiązany obiekt ViewInfo |
| `{Workers.NazwaWorkera.Pole}` | Właściwość workera |
| `{new NazwaExtender.Pole}` | Właściwość extendera |
| `{Features.NazwaCechy}` | Cechy powiązane z Row |
| `{Context.TypDanych.Pole}` | Wartość z kontekstu UI (`Soneta.Business.Context`) |
| `{Licence.HAN}` | Warunek licencji (używany w `Renderable`) |
| `{.}` | Aktualna wartość w kontekście elementu |

- Czym są **workery i extendery** (`{Workers.Alias.Pole}`, `{new Extender.Pole}`) — obiekty
  doczepiane do Row z dodatkowymi property — opisuje skill **`/soneta-programming`**
  (worker-extender.md).
- Mechanizm **cech** (`{Features.NazwaCechy}`, `VisibleFeatures` na `Grid`) opisuje skill
  **`/soneta-programming`** (features.md).
- Klasę parametrów stojącą za `{Context...}` (`Params : ContextBase`) opisuje skill
  **`/soneta-programming`** (contextbase.md, context.md).

### Wyrażenia warunkowe (RowCondition)

```xml
Visibility="{?State=Added}"             <!-- równość -->
Visibility="{?!State=Added}"            <!-- negacja -->
Visibility="{?Typ=Towar or Typ=Usługa}" <!-- OR -->
Visibility="{?Aktywny and Widoczny}"    <!-- AND -->
```

> **Dwie strony tego samego pojęcia.** RowCondition w form.xml to tekstowe wyrażenie `{?...}`
> rozwiązywane po stronie UI; jego odpowiednikiem w kodzie biznesowym jest serwerowy warunek
> `Expression<Predicate<TRow>>`. Stronę kodu opisuje skill **`/soneta-programming`**
> (rowcondition.md) — tam te same warunki buduje się i komponuje w C#.

## Atrybut Class — najważniejsze wartości

**Style etykiet:** `BoldLabel`, `CenterLabel`, `RightLabel`, `WarningLabel`, `InfoLabel`, `NoColonLabel`

**Style czcionek:** `BoldFont`, `LargeFont`, `GreenFont`, `RedFont`

**Typy edytorów:** `PasswordEdit`, `RichEdit`, `ImageEdit`, `HyperlinkEdit`, `EmailEdit`, `PhoneEdit`, `ColorEdit`, `ProgressEdit`, `RatingEdit`, `FileEdit`

**Zachowania kontenerów:** `Collapsable`, `Expandable`, `Expanded`, `Scrollable`, `FirstResponder`

**Przyciski:** `MainCommand`, `SplitCommand`, `CommandNoText`, `CommandIcoText`

**Wyrównanie:** `LeftAlign`, `RightAlign`, `TextRight`

**Pozycjonowanie:** `GroupItem` — element na poziomie nagłówka Group (zwykle po prawej)

> Pełna lista Class: [references/ELEMENTS.md](references/ELEMENTS.md)

## Appearance - Warunkowe formatowanie

```xml
<Field EditValue="{Saldo}">
  <Appearance Condition="{?Saldo&lt;0}" ForeColor="Red" FontBold="true" />
  <Appearance Condition="{?Saldo&gt;1000}" BackColor="LightGreen" />
</Field>
```

Składnia `Condition` może używać nawiasów kwadratowych gdy nazwa pola zawiera spacje lub operator porównania wymaga jawnego typu:
```xml
<Appearance Condition="{?[Typ] = 'usługa'}" ForeColor="#800080" />
```

Warunek `Appearance.Condition` to ta sama składnia co RowCondition w `Visibility` — jego
odpowiednikiem po stronie kodu jest `Expression<Predicate<TRow>>`; patrz skill
**`/soneta-programming`** (rowcondition.md).

## Przykład: pageform.xml

Plik: `MojObiekt.Ogolne.pageform.xml`

```xml
<?xml version="1.0" encoding="utf-8"?>
<DataForm xmlns="http://www.enova.pl/schema/form.xsd"
          xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
          xmlns:xsd="http://www.w3.org/2001/XMLSchema"
          xsi:schemaLocation="http://www.enova.pl/schema/ https://www.enova.pl/schema/form.xsd"
          Priority="10">
  <Page CaptionHtml="Ogólne" DataContext="{DataSource}">
    <Group CaptionHtml="Dane podstawowe">
      <Field CaptionHtml="Kod" Width="20" EditValue="{Kod}" />
      <Field CaptionHtml="Nazwa" Width="*" EditValue="{Nazwa}" />
    </Group>
    <Group CaptionHtml="Pozycje">
      <Grid Width="*" Height="*" EditValue="{Pozycje}" IsToolbarVisible="true">
        <Field CaptionHtml="Lp" Width="5" EditValue="{Lp}" />
        <Field CaptionHtml="Wartość" Width="15" EditValue="{Wartosc}" Footer="Sum" />
      </Grid>
    </Group>
  </Page>
</DataForm>
```

## Przykład: viewform.xml z FilterPanel

Widok listy z panelem filtrów powyżej grida. `<Flow>` jako `FilterPanel` to standardowy wzorzec.

```xml
<?xml version="1.0" encoding="utf-8"?>
<DataForm xmlns="http://www.enova.pl/schema/form.xsd"
          xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
          xmlns:xsd="http://www.w3.org/2001/XMLSchema"
          xsi:schemaLocation="http://www.enova.pl/schema/ https://www.enova.pl/schema/form.xsd">
  <Flow Name="FilterPanel">
    <Field CaptionHtml="Status" Width="15" EditValue="{ViewInfo+Params.Status}" Important="true" />
    <Field CaptionHtml="Typ" Width="12" EditValue="{ViewInfo+Params.Typ}" Important="true" />
    <Field CaptionHtml="Data od" Width="14" EditValue="{ViewInfo+Params.DataOd}" />
  </Flow>
  <Grid Name="List" OrderBy="Nazwa" FilterPanelWidth="136"
        IsToolbarVisible="true" IsFilterRowVisible="false">
    <Appearance Condition="{?[Status] = 'nieaktywny'}" ForeColor="#808080" />
    <Field CaptionHtml="Kod" Width="20" EditValue="{Kod}" />
    <Field CaptionHtml="Nazwa" Width="30" EditValue="{Nazwa}" />
    <Field CaptionHtml="Status" Width="15" EditValue="{Status}" />
    <UserFilter Value="Status='Aktywny'" />
  </Grid>
</DataForm>
```

**Uwaga:** Pliki `viewform.xml` zawierają Grid bezpośrednio w `DataForm` (bez `Page`). Atrybuty `ViewType` i `Mode` na `DataForm` są opcjonalne — dodaj je tylko gdy rejestrujesz widok przez `FolderViewAttribute`.

## Współdzielony fragment (form.xml)

```xml
<?xml version="1.0" encoding="utf-8"?>
<DataForm xmlns="http://www.enova.pl/schema/form.xsd"
          xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
          xmlns:xsd="http://www.w3.org/2001/XMLSchema"
          xsi:schemaLocation="http://www.enova.pl/schema/ https://www.enova.pl/schema/form.xsd">
  <Stack>
    <Row>
      <Field CaptionHtml="Ulica" Width="40" EditValue="{Ulica}" />
      <Field CaptionHtml="Nr domu" Width="10" EditValue="{NrDomu}" />
    </Row>
    <Row>
      <Field CaptionHtml="Kod pocztowy" Width="12" EditValue="{KodPocztowy}" />
      <Field CaptionHtml="Miasto" Width="30" EditValue="{Miasto}" />
    </Row>
  </Stack>
</DataForm>
```

Dołączanie: `<Include Source="Adres.form.xml" DataContext="{Adres}" />`

## Zasady projektowania okien (UX)

### Etykiety i opisy — formularze konfiguracyjne vs operacyjne

Długość etykiet (`CaptionHtml`) i obecność opisów dobieraj do **częstotliwości użycia** formularza:

- **Formularze konfiguracyjne** (definicje, ustawienia, parametry — odwiedzane **rzadko**): etykiety
  i pola opisowe powinny być **wyczerpujące i samotłumaczące**. Użytkownik wracający na taki formularz
  po tygodniach/miesiącach musi bez wahania zrozumieć, do czego służy każde pole — nie może polegać na
  pamięci. Preferuj pełne, jednoznaczne etykiety; tam, gdzie sens nie jest oczywisty, dodaj tekst
  pomocniczy/opis (np. rozbudowany `CaptionHtml`, etykieta wprowadzająca `Label`, opis w grupie).
  Priorytetem jest **zrozumiałość**, nie gęstość.

- **Formularze operacyjne** (dokumenty, kartoteki używane **codziennie**): etykiety powinny być
  **krótkie i zwięzłe**. Tu najważniejsza jest **przestrzeń na dane** — czytelność wprowadzanych
  wartości i to, by na ekranie mieściło się ich dużo (mniej przewijania i przełączania między
  zakładkami). Użytkownik zna te pola z codziennej pracy, więc rozwlekłe etykiety tylko zabierają
  miejsce. Priorytetem jest **zwięzłość i gęstość danych**.

### Pozycja etykiety względem pola — `LabelLeft` vs `LabelTop`

Na zakładkach formularzy obiektów **generalną zasadą jest umieszczanie etykiety po lewej stronie** pola
edycyjnego (`Class="LabelLeft"`). Jest to wartość **domyślna** dla formularzy — jeśli nie ustawisz nic
innego, obowiązuje układ z etykietą po lewej.

Wyjątki, w których etykieta trafia **na górę, nad pole edycyjne** (`Class="LabelTop"`):

- **Formularze aplikacji pulpitowej** uruchamianej dla operatorów pulpitowych — tu `LabelTop` jest
  wartością **domyślną**: etykiety umieszczamy nad polami edycyjnymi.
- **Pola filtrujące listy** (pasek parametrów `Flow Class="DataBar"`) — patrz sekcja
  „Pasek filtra listy".

### Wizualna weryfikacja formularza (buscall)

Po zdefiniowaniu lub zmianie `form.xml` (i przebudowaniu projektu `.UI`) **zweryfikuj wygląd wizualnie**
na żywej aplikacji — nie polegaj wyłącznie na poprawności XML. Otwórz formularz zdalnie i zrób zrzut
ekranu narzędziem `buscall` (`call navigate_to_folder`/`open_form` → `call take_screenshot`), a następnie
**obejrzyj PNG** i oceń estetykę i czytelność układu:

- **Odstępy etykieta–pole** nie są zbyt duże — łatwo dopasować etykietę do jej pola.
- **Etykiety są czytelne i w całości widoczne** — jest wystarczająco miejsca na tekst etykiety
  (nie jest ucięty ani zawinięty w nieczytelny sposób).
- **Pola są wyrównane** — ułożone równo jedno pod drugim, kolumny się zgadzają, całość wygląda schludnie.

Pełna procedura sterowania aplikacją i robienia zrzutów (konfiguracja bazy, uruchamianie, `take_screenshot`):
narzędzie `buscall` — dokument `buscall-live-testing.md` (weryfikacja na żywej aplikacji) w skillu
`/soneta-programming`; składnia metod w `buscall.md` skilla `/soneta-tools`.

## Referencje

- Pełna specyfikacja elementów: [references/ELEMENTS.md](references/ELEMENTS.md)
- Schemat XSD: [references/Form.xsd](references/Form.xsd)
- Przykład pageform.xml: [assets/MojObiekt.Ogolne.pageform.xml](assets/MojObiekt.Ogolne.pageform.xml)
- Przykład pageform.xml (warunki handlowe): [assets/Kontrahent.WarunkiHandlowe.pageform.xml](assets/Kontrahent.WarunkiHandlowe.pageform.xml)
- Przykład form.xml (adres): [assets/Adres.form.xml](assets/Adres.form.xml)

## Powiązane skille — gdzie szukać strony kodu

Form.xml opisuje **prezentację**; logikę i dane opisują skille obok. Mapa pojęcie → artykuł:

| Pojęcie w form.xml | Strona kodu / danych |
|---|---|
| `Visibility="{?...}"`, `Appearance.Condition` | skill `/soneta-programming` — rowcondition.md (`Expression<Predicate<TRow>>`) |
| `Grid EditValue="{...View}"` (ViewInfo) | skill `/soneta-programming` — viewinfo.md |
| `Flow Class="DataBar"`, `{XParams.Pole}` | skill `/soneta-programming` — contextbase.md, context.md |
| `{Features.NazwaCechy}`, `VisibleFeatures` | skill `/soneta-programming` — features.md |
| `{Workers.Alias.Pole}`, `{new Extender.Pole}` | skill `/soneta-programming` — worker-extender.md |
| `Command MethodName`/`OpenMethodName` | skill `/soneta-programming` — action-result.md, worker-extender.md |
| pole `readonly`/selektor, definicja pól | skill `/soneta-business-xml` — table-reference.md |
| wizualna weryfikacja wyglądu formularza na żywo (zrzut ekranu) | skill `/soneta-programming` — `buscall-live-testing.md` (składnia `buscall` w `/soneta-tools`) |
