# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DashboardView`
Nazwa tabeli: `DashbrdViews`
Tytuł: Panele
Opis: Definicja panelu (pulpitu) wyświetlanego w folderze programu. Konfiguruje nazwę, obszar, typ widoku, edytowalność, dostępność na interfejsie i indywidualizację per operator.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Area | `Soneta.Business.Db.DashboardArea` |  |  |  |
| DashboardAdjustments | `Soneta.Business.ViewInfo` |  |  |  |
| DashboardArea | `Soneta.Business.Db.DashboardArea` | bazodanowe | Obszar | Obszar i kategoria funkcjonalna. |
| Description | `string` | bazodanowe | Opis | Opisuje zawartość i zastosowanie. |
| Destiny | `Soneta.Business.Db.DashboardViewDestiny` | bazodanowe, enum | Przeznaczenie |  |
| Editable | `bool` | bazodanowe | Edytowalny | Wskazuje możliwość edycji danych na pulpicie. |
| IconName | `string` | bazodanowe | Ikona | Nazwa ikony wyświetlanej w folderze. |
| IndividualGuid | `System.Guid` | bazodanowe | Identyfikator operatora | Unikalny identyfikator indywidualnego panelu operatora. |
| IsAccessed | `bool` |  |  |  |
| IsGeneralPageReadOnly | `bool` |  |  |  |
| IsIndividual | `bool` |  |  |  |
| IsStashWarningVisible | `bool` |  |  |  |
| LayoutMode | `Soneta.Business.Db.DashboardViewLayoutMode` | bazodanowe, enum | Interface | Widoczność na interfejsie użytkownika |
| Locked | `bool` | bazodanowe | Zablokowany | Określa, czy widok pulpitu jest aktualnie zablokowany. |
| Name | `string` | bazodanowe | Nazwa | Nazwa pulpitu wyświetlana w drzewie folderów. |
| Order | `int` | bazodanowe | Kolejność | Kolejność wyświetlnia pulpitu |
| Path | `string` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| StashLocked | `bool` | bazodanowe | Schowek zablokowany | Określa, czy schowek pulpitu jest aktualnie zablokowany. |
| StorageContextId | `string` | bazodanowe | Identyfikator kontekstu | Unikalny identyfikator kontekstu. |
| Tiles | `Soneta.Business.SubTable<Soneta.Business.Db.DashboardViewTile>` |  |  |  |
| ViewType | `Soneta.Business.Db.DashboardViewType` | bazodanowe, enum | Type | Typu pulpitu określający jego wykorzystanie. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DashboardViewDestiny (`Soneta.Business.Db.DashboardViewDestiny`)
- `Operator` = 0 — Dla operatorów
- `WebUser` = 1 — Dla pulpitów

### DashboardViewLayoutMode (`Soneta.Business.Db.DashboardViewLayoutMode`)
- `Browser` = 0 — Przeglądarka
- `Mobile` = 1 — Mobilny

### DashboardViewType (`Soneta.Business.Db.DashboardViewType`)
- `Cockpit` = 1 — Kokpit
- `BI` = 2 — Panel BI
- `User` = 3 — Pulpit użytkownika
- `Template` = 4 — Wzorzec kokpitu
- `BIForm` = 5 — Panel BI formularza
