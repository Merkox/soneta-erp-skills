# Pola i właściwości klasy biznesowej: `Soneta.Business.Runtime.RuntimeFieldDefinition`
Nazwa tabeli: `RuntimeFieldDefs`
Tytuł: Definicje pól dynamicznych
Opis: Definicja pola dynamicznego (runtime) na zdarzeniu lub innym obiekcie. Określa nazwę, typ danych, indeksowanie i parametry walidacji pola tworzonego przez użytkownika.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AddRuntimeEnum | `bool` | bazodanowe |  |  |
| Algorytm | `string` |  |  |  |
| ConstructorBase | `string` |  |  |  |
| ConstructorCode | `string` |  |  |  |
| ConstructorParams | `string` |  |  |  |
| DbTypeName | `string` |  |  |  |
| Definition | `Soneta.Business.Runtime.IRuntimeRowDefinition` | bazodanowe, iface-ref | Definicja | Definicja zdarzenia |
| EnumName | `string` |  |  |  |
| EnumValues | `Soneta.Business.SubTable<Soneta.Business.Runtime.RuntimeEnum>` |  |  |  |
| FieldType | `Soneta.Business.Runtime.RuntimeFieldType` | bazodanowe, enum | Typ | Typ pola |
| FldCaption | `string` | bazodanowe | Etykieta | Domyślna etykieta |
| FldDescription | `string` | bazodanowe | Opis | Opis pola |
| FldMaxLen | `int` | bazodanowe |  |  |
| FldReadOnly | `Soneta.Business.Runtime.RuntimeRowReadOnly` | bazodanowe, enum |  |  |
| FldRequired | `Soneta.Business.Runtime.RuntimeRowRequired` | bazodanowe, enum |  |  |
| FldSetOnlyNull | `bool` | bazodanowe |  |  |
| IdentifierName | `string` |  |  |  |
| IdentifierNameWithAtPrefix | `string` |  |  |  |
| IsFieldIndexed | `bool` | bazodanowe | Pole indeksowane | Określa czy pole jest indeksowane |
| IsMultiReferenceVisibleInDashboard | `bool` | bazodanowe | Widoczna w pulpitach | Określa czy zakładka z wieloreferncją jest widoczna w pulpitach |
| IsMultireferenceAsArray | `bool` | bazodanowe | Typu tablicowego | Pole typu multireferencyjnego pokazywane, jako tablica |
| IsRelacjaPodstawowa | `bool` |  |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa pola w definicji |
| MultireferenceTypeName | `string` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa pola |
| OnAddedInit | `string` |  |  |  |
| OnAddedVerifiers | `string` |  |  |  |
| PropertyType | `System.Type` |  |  |  |
| ReferenceTable | `Soneta.Business.Table` |  |  | Tabela danych, do obiektów której odnosi się wartość cechy referencyjnej. |
| ReferenceTableItem | `Soneta.Business.Db.TableContext.TableItem` |  |  | Tabela danych, do obiektów której odnosi się wartość cechy referencyjnej. |
| TempFields | `string` |  |  |  |
| Type | `Soneta.Business.Runtime.RuntimeRowType` | bazodanowe, enum |  |  |
| TypeInformation | `string` | bazodanowe | Informacja | Informacja dodatkowa dla typu pola |
| TypeName | `string` |  |  |  |
| UpdateManagedState | `bool` | bazodanowe |  |  |
| VerifierCode | `string` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definition | `IRuntimeRowDefinition` | `DbTupleDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RuntimeFieldType (`Soneta.Business.Runtime.RuntimeFieldType`)
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

### RuntimeRowReadOnly (`Soneta.Business.Runtime.RuntimeRowReadOnly`)
- `False` = 0 — Nie
- `True` = 1 — Zawsze
- `Restricted` = 2 — Ograniczone

### RuntimeRowRequired (`Soneta.Business.Runtime.RuntimeRowRequired`)
- `False` = 0 — Niewymagane
- `True` = 1 — Zawsze
- `OnSave` = 2 — Podczas zapisu

### RuntimeRowType (`Soneta.Business.Runtime.RuntimeRowType`)
- `Standard` = 1 — Domyślna
- `DbTuple` = 2 — Zdarzenie
