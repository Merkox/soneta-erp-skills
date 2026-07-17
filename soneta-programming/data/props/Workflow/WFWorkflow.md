# Pola i właściwości klasy biznesowej: `Soneta.Workflow.WFWorkflow`
Nazwa tabeli: `WFWorkflows`
Tytuł: Procesy
Opis: Instancja uruchomionego procesu workflow utworzona na podstawie definicji (WFDefinition). Przechowuje stan procesu, daty rozpoczęcia i zakończenia, operatora inicjującego oraz opcjonalny wiersz zarządzający. Stanowi kontener dla zadań realizowanych w ramach obiegu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IWFWorkflow`, `IWFFeatureDefs`, `IDokument`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActiveTasks | `System.Collections.Generic.IEnumerable<Soneta.Business.Db.Task>` |  |  |  |
| AllTasks | `Soneta.Business.SubTable<Soneta.Business.Db.Task>` |  |  |  |
| AsString | `string` |  |  |  |
| ConfigXml | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` |  |  |  |
| DateFrom | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia procesu |
| DateTimeFrom | `System.DateTime` |  | Data i czas rozpoczęcia | Data i czas rozpoczęcia procesu |
| DateTimeTo | `System.DateTime` |  | Data i czas zakończenia | Data i czas zakończenia procesu |
| DateTo | `Soneta.Types.Date` | bazodanowe | Data zakończenia | Data zakończenia procesu |
| DefinitionType | `Soneta.Business.Db.DefinitionTypeEnum` | bazodanowe, enum | Tryb edycji | Określa tryb edycji definicji workflow |
| IDokumentNumerPelny | `string` |  | Numer pełny |  |
| IsClosed | `bool` | bazodanowe | Status procesu | Status procesu (zamknięty lub aktywny) |
| LiveTasks | `System.Collections.Generic.IEnumerable<Soneta.Business.Db.Task>` |  |  |  |
| ManagingRow | `Soneta.Business.IManagingRow` | bazodanowe | Wiersz zarządzający | Wiersz zarządzający w procesie |
| Name | `string` | bazodanowe | Nazwa | Nazwa elementu workflow |
| NotificationCategory | `Soneta.Business.NotificationCategory` |  |  |  |
| Number | `Soneta.Core.NumerDokumentu` | bazodanowe | Numer | Numer elementu workflow |
| Number.Numer | `int` | bazodanowe |  |  |
| Number.NumerPelny | `string` |  |  |  |
| Number.Pelny | `string` | bazodanowe | Numer pełny |  |
| Number.Symbol | `string` | bazodanowe |  |  |
| Number.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Number.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe | Operator inicjujący | Operator powiązany z elementem workflow |
| OtherOperatorOperatorSimpleRight | `Soneta.Business.AccessRights` | enum |  |  |
| SimpleRightAccessOnList | `Soneta.Business.AccessRights` | enum |  |  |
| Tasks | `Soneta.Business.View` |  |  |  |
| TimeFrom | `Soneta.Types.TimeSec` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia procesu |
| TimeTo | `Soneta.Types.TimeSec` | bazodanowe | Godzina zakończenia | Godzina zakończenia procesu |
| WorkflowDefinition | `Soneta.Workflow.Config.WFDefinition` | bazodanowe | Definicja workflow | Definicja workflow powiązana z elementem workflow |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessRights (`Soneta.Business.AccessRights`)
- `Denied` = 0 — Zakaz dostępu
- `ReadOnly` = 1 — Tylko odczyt
- `Granted` = 2 — Pełne prawo
- `NoInit` = 3 — Niezainicjowane

### DefinitionTypeEnum (`Soneta.Business.Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak
