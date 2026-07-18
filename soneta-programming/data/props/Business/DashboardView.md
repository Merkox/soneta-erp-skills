# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DashboardView`
Nazwa tabeli: `DashbrdViews`
Tytuł: Panele
Opis: Definicja panelu (pulpitu) wyświetlanego w folderze programu. Konfiguruje nazwę, obszar, typ widoku, edytowalność, dostępność na interfejsie i indywidualizację per operator.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 15
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 7
- podlisty: 2
- subrowy: 1
- razem: 26

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Area | `Db.DashboardArea` |  |  |  |
| DashboardAdjustments | `ViewInfo` | tylko-odczyt |  |  |
| DashboardArea | `Db.DashboardArea` | bazodanowe | Obszar | Obszar i kategoria funkcjonalna. |
| Description | `string` | bazodanowe | Opis | Opisuje zawartość i zastosowanie. |
| Destiny | `Db.DashboardViewDestiny` (enum) | bazodanowe | Przeznaczenie |  |
| Editable | `bool` | bazodanowe | Edytowalny | Wskazuje możliwość edycji danych na pulpicie. |
| IconName | `string` | bazodanowe | Ikona | Nazwa ikony wyświetlanej w folderze. |
| IndividualGuid | `System.Guid` | bazodanowe | Identyfikator operatora | Unikalny identyfikator indywidualnego panelu operatora. |
| IsAccessed | `bool` | tylko-odczyt |  |  |
| IsGeneralPageReadOnly | `bool` | tylko-odczyt |  |  |
| IsIndividual | `bool` | tylko-odczyt |  |  |
| IsStashWarningVisible | `bool` | tylko-odczyt |  |  |
| LayoutMode | `Db.DashboardViewLayoutMode` (enum) | bazodanowe | Interface | Widoczność na interfejsie użytkownika |
| Locked | `bool` | bazodanowe | Zablokowany | Określa, czy widok pulpitu jest aktualnie zablokowany. |
| Name | `string` | bazodanowe | Nazwa | Nazwa pulpitu wyświetlana w drzewie folderów. |
| Order | `int` | bazodanowe | Kolejność | Kolejność wyświetlnia pulpitu |
| Path | `string` | tylko-odczyt |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| StashLocked | `bool` | bazodanowe | Schowek zablokowany | Określa, czy schowek pulpitu jest aktualnie zablokowany. |
| StorageContextId | `string` | bazodanowe | Identyfikator kontekstu | Unikalny identyfikator kontekstu. |
| Tiles | `SubTable<Db.DashboardViewTile>` | podlista |  |  |
| ViewType | `Db.DashboardViewType` (enum) | bazodanowe, tylko-odczyt | Type | Typu pulpitu określający jego wykorzystanie. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DashboardViewDestiny (`Db.DashboardViewDestiny`)
- `Operator` = 0 — Dla operatorów
- `WebUser` = 1 — Dla pulpitów

### DashboardViewLayoutMode (`Db.DashboardViewLayoutMode`)
- `Browser` = 0 — Przeglądarka
- `Mobile` = 1 — Mobilny

### DashboardViewType (`Db.DashboardViewType`)
- `Cockpit` = 1 — Kokpit
- `BI` = 2 — Panel BI
- `User` = 3 — Pulpit użytkownika
- `Template` = 4 — Wzorzec kokpitu
- `BIForm` = 5 — Panel BI formularza
