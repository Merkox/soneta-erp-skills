# Pola i właściwości klasy biznesowej: `Soneta.Business.Runtime.RuntimeFieldDefinition`
Nazwa tabeli: `RuntimeFieldDefs`
Tytuł: Definicje pól dynamicznych
Opis: Definicja pola dynamicznego (runtime) na zdarzeniu lub innym obiekcie. Określa nazwę, typ danych, indeksowanie i parametry walidacji pola tworzonego przez użytkownika.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 14
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 18
- podlisty: 2
- subrowy: 0
- razem: 36

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AddRuntimeEnum | `bool` | bazodanowe |  |  |
| Algorytm | `string` | tylko-odczyt |  |  |
| ConstructorBase | `string` | tylko-odczyt |  |  |
| ConstructorCode | `string` | tylko-odczyt |  |  |
| ConstructorParams | `string` | tylko-odczyt |  |  |
| DbTypeName | `string` | tylko-odczyt |  |  |
| Definition | `Runtime.IRuntimeRowDefinition` | bazodanowe, tylko-odczyt, iface-ref | Definicja | Definicja zdarzenia |
| EnumName | `string` |  |  |  |
| EnumValues | `SubTable<Runtime.RuntimeEnum>` | podlista |  |  |
| FieldType | `Runtime.RuntimeFieldType` (enum) | bazodanowe | Typ | Typ pola |
| FldCaption | `string` | bazodanowe | Etykieta | Domyślna etykieta |
| FldDescription | `string` | bazodanowe | Opis | Opis pola |
| FldMaxLen | `int` | bazodanowe |  |  |
| FldReadOnly | `Runtime.RuntimeRowReadOnly` (enum) | bazodanowe |  |  |
| FldRequired | `Runtime.RuntimeRowRequired` (enum) | bazodanowe |  |  |
| FldSetOnlyNull | `bool` | bazodanowe |  |  |
| IdentifierName | `string` | tylko-odczyt |  |  |
| IdentifierNameWithAtPrefix | `string` | tylko-odczyt |  |  |
| IsFieldIndexed | `bool` | bazodanowe | Pole indeksowane | Określa czy pole jest indeksowane |
| IsMultiReferenceVisibleInDashboard | `bool` | bazodanowe | Widoczna w pulpitach | Określa czy zakładka z wieloreferncją jest widoczna w pulpitach |
| IsMultireferenceAsArray | `bool` | bazodanowe | Typu tablicowego | Pole typu multireferencyjnego pokazywane, jako tablica |
| IsRelacjaPodstawowa | `bool` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa pola w definicji |
| MultireferenceTypeName | `string` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa pola |
| OnAddedInit | `string` | tylko-odczyt |  |  |
| OnAddedVerifiers | `string` | tylko-odczyt |  |  |
| PropertyType | `System.Type` | tylko-odczyt |  |  |
| ReferenceTable | `Table` | podlista |  | Tabela danych, do obiektów której odnosi się wartość cechy referencyjnej. |
| ReferenceTableItem | `Db.TableContext.TableItem` |  |  | Tabela danych, do obiektów której odnosi się wartość cechy referencyjnej. |
| TempFields | `string` | tylko-odczyt |  |  |
| Type | `Runtime.RuntimeRowType` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypeInformation | `string` | bazodanowe, tylko-odczyt | Informacja | Informacja dodatkowa dla typu pola |
| TypeName | `string` | tylko-odczyt |  |  |
| UpdateManagedState | `bool` | bazodanowe |  |  |
| VerifierCode | `string` | tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definition | `IRuntimeRowDefinition` | `DbTupleDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RuntimeFieldType (`Runtime.RuntimeFieldType`)
- `Int` = 0 — Liczba całkowita
- `Bool` = 1 — Warunek
- `String` = 2 — Tekst
- `Decimal` = 3 — Kwota
- `Double` = 4 — Liczba rzeczywista
- `Date` = 5 — Data
- `Time` = 6 — Czas
- `FromTo` = 7 — Okres dat
- `Fraction` = 8 — Ułamek
- `Currency` = 9 — Kwota z walutą
- `Percent` = 10 — Procent
- `DoubleCy` = 11 — Liczba z walutą
- `YearMonth` = 12 — Miesiąc w roku
- `Reference` = 13 — Referencja
- `MultiReference` = 14 — Referencja wielokrotna
- `MemoText` = 15 — Tekst wielolinijkowy

### RuntimeRowReadOnly (`Runtime.RuntimeRowReadOnly`)
- `False` = 0 — Nie
- `True` = 1 — Zawsze
- `Restricted` = 2 — Ograniczone

### RuntimeRowRequired (`Runtime.RuntimeRowRequired`)
- `False` = 0 — Niewymagane
- `True` = 1 — Zawsze
- `OnSave` = 2 — Podczas zapisu

### RuntimeRowType (`Runtime.RuntimeRowType`)
- `Standard` = 1 — Domyślna
- `DbTuple` = 2 — Zdarzenie
