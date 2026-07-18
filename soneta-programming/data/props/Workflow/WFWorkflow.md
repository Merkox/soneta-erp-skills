# Pola i właściwości klasy biznesowej: `Soneta.Workflow.WFWorkflow`
Nazwa tabeli: `WFWorkflows`
Tytuł: Procesy
Opis: Instancja uruchomionego procesu workflow utworzona na podstawie definicji (WFDefinition). Przechowuje stan procesu, daty rozpoczęcia i zakończenia, operatora inicjującego oraz opcjonalny wiersz zarządzający. Stanowi kontener dla zadań realizowanych w ramach obiegu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IWFWorkflow`, `IWFFeatureDefs`, `IDokument`
Selektor: pole `DefinitionType` (`Db.DefinitionTypeEnum`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActiveTasks | `System.Collections.Generic.IEnumerable<Db.Task>` | podlista |  |  |
| AllTasks | `SubTable<Db.Task>` | podlista |  |  |
| AsString | `string` | tylko-odczyt |  |  |
| ConfigXml | `MemoText` | bazodanowe, podlista |  |  |
| Data | `Date` | tylko-odczyt |  |  |
| DateFrom | `Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia procesu |
| DateTimeFrom | `System.DateTime` | tylko-odczyt | Data i czas rozpoczęcia | Data i czas rozpoczęcia procesu |
| DateTimeTo | `System.DateTime` | tylko-odczyt | Data i czas zakończenia | Data i czas zakończenia procesu |
| DateTo | `Date` | bazodanowe | Data zakończenia | Data zakończenia procesu |
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt, selektor | Tryb edycji | Określa tryb edycji definicji workflow |
| IDokumentNumerPelny | `string` | tylko-odczyt | Numer pełny |  |
| IsClosed | `bool` | bazodanowe | Status procesu | Status procesu (zamknięty lub aktywny) |
| LiveTasks | `System.Collections.Generic.IEnumerable<Db.Task>` | podlista |  |  |
| ManagingRow | `IManagingRow` | bazodanowe, tylko-odczyt | Wiersz zarządzający | Wiersz zarządzający w procesie |
| Name | `string` | bazodanowe | Nazwa | Nazwa elementu workflow |
| NotificationCategory | `NotificationCategory` | tylko-odczyt |  |  |
| Number | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe | Numer | Numer elementu workflow |
| Number.Numer | `int` | bazodanowe |  |  |
| Number.NumerPelny | `string` |  |  |  |
| Number.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Number.Symbol | `string` | bazodanowe |  |  |
| Number.WgNumeruDokumentu | `Key` | podlista |  |  |
| Number.WgSymboluDokumentu | `Key` | podlista |  |  |
| Operator | `App.Operator` | bazodanowe | Operator inicjujący | Operator powiązany z elementem workflow |
| OtherOperatorOperatorSimpleRight | `AccessRights` (enum) | tylko-odczyt |  |  |
| SimpleRightAccessOnList | `AccessRights` (enum) | tylko-odczyt |  |  |
| Tasks | `View` | podlista |  |  |
| TimeFrom | `TimeSec` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia procesu |
| TimeTo | `TimeSec` | bazodanowe | Godzina zakończenia | Godzina zakończenia procesu |
| WorkflowDefinition | `Soneta.Workflow.Config.WFDefinition` | bazodanowe, tylko-odczyt | Definicja workflow | Definicja workflow powiązana z elementem workflow |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `DefinitionType`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Standard` | 0 | `Soneta.Workflow.WFWorkflow` |  |
| `Engine` | 1 | `Soneta.Workflow.WFWorkflowExtend` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessRights (`AccessRights`)
- `Denied` = 0 — Zakaz dostępu
- `ReadOnly` = 1 — Tylko odczyt
- `Granted` = 2 — Pełne prawo
- `NoInit` = 3 — Niezainicjowane

### DefinitionTypeEnum (`Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak
