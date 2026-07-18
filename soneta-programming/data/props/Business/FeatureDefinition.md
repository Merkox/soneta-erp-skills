# Pola i właściwości klasy biznesowej: `Soneta.Business.FeatureDefinition`
Nazwa tabeli: `FeatureDefs`
Tytuł: Definicje cechy
Opis: Definiuje cechy (pola użytkownika) przypisywane do obiektów biznesowych. Określa typ, algorytm wyliczania, walidację i sposób prezentacji cechy na formularzach.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 25
- pola kalkulowane (zapisywalne): 4
- pola tylko-odczyt: 16
- podlisty: 5
- subrowy: 1
- razem: 51

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorithm | `FeatureAlgorithm` (enum) | bazodanowe | Algorytm | Rodzaj algorytmu wyliczenia cechy |
| AllowNegative | `bool` | bazodanowe | Dopuszczaj wartości ujemne | Dopuszcza ujemne wartości cechy |
| BISerialization | `bool` | bazodanowe | Utrwalanie BI | Cecha utrwalana mechanizmem BI |
| Category | `string` | bazodanowe | Kategoria | Kategoria cechy grupująca wartości na formularzu |
| Code | `MemoText` | bazodanowe, podlista |  | Algorytm (C#) odczytu i wyliczenia cechy |
| Description | `string` | bazodanowe | Opis | Opis objaśniający zastosowanie cechy |
| Dictionary | `string` | bazodanowe | Nazwa słownika | Nazwa słownika wartości do wyboru |
| DictionaryKey | `string` | tylko-odczyt |  | Klucz nazwy słownika wartości |
| DictionaryList | `SubTable<Db.DictionaryItem>` | podlista |  | Lista będąca słownikiem wartości do wybory dla tej cechy. |
| ExtendedLookup | `bool` | bazodanowe | Rozszerzona lista | Dla wartości cechy typu lista pozawala na wyświetlanie rozbudowanego okna wyboru wartości |
| FeatureTableInfo | `App.TableInfo` | tylko-odczyt |  |  |
| FeatureType | `System.Type` | tylko-odczyt |  |  |
| Group | `bool` | bazodanowe | Grupa | Cecha wykorzystywana do grupowania wartości w drzewie po lewej strony listy |
| History | `bool` | bazodanowe | Historyczna | Wskazuje na historyczność wartości cechy |
| HistoryFeatureType | `System.Type` | tylko-odczyt |  |  |
| Index | `int` | tylko-odczyt |  |  |
| Info | `string` | bazodanowe |  | Pole tymczasowe. Nie używać. |
| InitValue | `object` |  |  | Wartość inicjująca cechę podczas dodawania nowego zapisu. |
| InitValueStr | `string` | bazodanowe |  |  |
| IsArray | `bool` | tylko-odczyt | Wielowartościowa | Określa, czy cecha jest typu wielowartościowego (napis lub hierarchiczna). |
| IsDictionary | `bool` |  | Jest słownik | Określa, czy dla danej cechy ma być wyświetlany słownik. |
| IsInitValue | `bool` |  |  | Określa czy inicjować nowy zapis podczas dodawania nowego zapisu. |
| IsNameIdentifier | `bool` | tylko-odczyt |  | Określa czy nazwa cechy składa się z samych liter. |
| IsTree | `bool` | tylko-odczyt | Hierarchiczna | Określa, czy cecha jest typu hierarchicznego (jedno lub wielo-wartościowa). |
| IsVisibleAllowNegative | `bool` | tylko-odczyt |  |  |
| MethodName | `string` | tylko-odczyt |  | Nazwa metody lub właściwości w generowanym kodzie algorytmu. |
| MethodNameBase | `string` | tylko-odczyt |  | Bazowa nazwa metody lub właściwości w generowanym kodzie algorytmu. |
| Name | `string` | bazodanowe | Nazwa | Nazwa cechy |
| ParamOfArgs | `System.Reflection.ParameterInfo[]` | podlista |  |  |
| Precision | `int` | bazodanowe |  | Prezycja przechowywania liczb zmiennoprzecinkowych |
| ReadOnlyMode | `FeatureReadOnlyMode` (enum) | bazodanowe | Tylko odczyt | Określa warunki edycji cechy z formularza lub listy. |
| ReferenceTable | `Table` | podlista |  | Tabela danych, do obiektów której odnosi się wartość cechy referencyjnej. |
| ReferenceTableInfo | `App.TableInfo` | tylko-odczyt |  | Informacja o tabeli danych, do obiektów której odnosi się wartość cechy referencyjnej. |
| ReferenceTableItem | `Db.TableContext.TableItem` |  |  | Tabela danych, do obiektów której odnosi się wartość cechy referencyjnej. |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| StoredInDB | `bool` | tylko-odczyt | W bazie danych | Określa czy cecha jest przechowywana w bazie danych. Zależy od właściwości Algorithm. |
| StrictDictionary | `bool` | bazodanowe | Tylko słownik | Cecha może przyjmować wartości tylko ze slownika |
| TableName | `string` | bazodanowe, tylko-odczyt | Klasa | Klasa obiektu nadrzędanego |
| TextLength | `int` | bazodanowe |  | Maksymalny rozmiar wprowadzanego tekstu |
| TypeDescription | `string` | tylko-odczyt | Opis działania | Dodatkowa inforamcja opisująca działanie cechy tego typu. |
| TypeInformation | `string` | bazodanowe |  |  |
| TypeNumber | `FeatureTypeNumber` (enum) | bazodanowe | Typ | Typ wartości przechowywanej przez cechę |
| ValueFilter | `string` | bazodanowe |  | Wyrażenie filtrujące poprawne wartości dla cechy. Filtrowanie wartości obiektowych. |
| ValueFrom | `string` | bazodanowe |  | Minimalna akceptowalna wartość. Wartość pusta oznacza brak ograniczeń |
| ValueRequiredMode | `FeatureRequiredModes` (enum) | bazodanowe | Wartość wymagana | Wymagane jest wprowadzenie wartości tej cechy |
| ValueTo | `string` | bazodanowe |  | Maksymalna akceptowalna wartość. Wartość pusta oznacza brak ograniczeń |
| WithArguments | `bool` | tylko-odczyt | Z argumentami | Określa czy do wywołania cechy potrzebne są dodatkowe argumenty. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FeatureAlgorithm (`FeatureAlgorithm`)
- `DB` = 0 — Przychowywana w bazie danych
- `DBSet` = 1 — Przechowywana w bazie danych z algorytmem ustawiania
- `Get` = 2 — Wartość wyliczana algorytmem
- `GetSet` = 3 — Do odczytu i zapisu przez algorytm
- `GetArgs` = 4 — Wartość wyliczana algorytmem z parametrami
- `GetSetArgs` = 5 — Do odczytu i zapisu przez algorytm z parametrami

### FeatureReadOnlyMode (`FeatureReadOnlyMode`)
- `Standard` = 0 — Edycja z zapisem
- `ReadOnly` = 1 — Tylko do odczytu
- `SpecialEdit` = 2 — Zawsze edytuj
- `SpecialEditWithReadOnly` = 4 — Zawsze edytuj z algorytmów

### FeatureRequiredModes (`FeatureRequiredModes`)
- `NonRequired` = 0 — Niewymagana
- `VisibleRequired` = 1 — Wymagana widoczna
- `Required` = 2 — Wymagana zawsze

### FeatureTypeNumber (`FeatureTypeNumber`)
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
- `Array` = 14 — Wielowartościowa
- `Tree` = 15 — Hierarchiczna
- `ArrayOfTrees` = 16 — Wielohierarchiczna
- `TimeSec` = 17 — Czas z dokładnością do sekundy
- `Amount` = 18 — Ilość
