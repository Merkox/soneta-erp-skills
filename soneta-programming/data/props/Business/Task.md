# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Task`
Nazwa tabeli: `Tasks`
Tytuł: Zadania
Opis: Instancja zadania (taska) w systemie. Reprezentuje konkretne zadanie przypisane do operatora lub roli, z określonym terminem, postępem i powiązaniem z procesem workflow.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 28
- pola kalkulowane (z klas biznesowych): 49

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowModificationRight | `bool` |  |  |  |
| ChangeOperatorSimpleRight | `bool` |  |  |  |
| Definition | `Soneta.Business.Db.TaskDefinition` | bazodanowe |  |  |
| DefinitionType | `Soneta.Business.Db.DefinitionTypeEnum` | bazodanowe, enum | Tryb edycji | Określa tryb edycji definicji workflow |
| DeleteTaskSimpleRight | `bool` |  |  |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis zadania. |
| End | `System.DateTime` | bazodanowe |  | Data i czas zakończenia zadania. |
| EndDate | `Soneta.Types.Date` |  |  |  |
| EndTime | `Soneta.Types.Time` |  |  |  |
| ExecutionDateAndTime | `string` |  |  |  |
| ExecutionTime | `System.DateTime` | bazodanowe | Data i czas wykonania zadania | Data i czas wykonania zadania |
| Executor | `Soneta.Business.ITaskUser` | iface-ref | Wykonawca | Wykonawca zadania |
| ExecutorId | `int` | bazodanowe | ID wiersza wykonawcy | ID wiersza wykonawcy zadania |
| ExecutorType | `string` | bazodanowe | Typ wiersza wykonawcy | Typ wiersza wykonawcy zadania |
| ExternalErrorHandling | `bool` | bazodanowe | Zewnętrzna obsługa błędów |  |
| HistoryKind | `Soneta.Business.Db.TaskHistoryKind` | bazodanowe, enum | Rodzaj historii procesu | Określa rodzaj historii procesu |
| Icon | `string` |  |  |  |
| Info | `Soneta.Business.MemoText` |  |  |  |
| Interval | `Soneta.Types.Interval` |  |  |  |
| IsActiveProgress | `bool` |  |  |  |
| IsManualAction | `bool` |  |  |  |
| IsNotification | `bool` |  |  |  |
| LinkedObjects | `Soneta.Business.SubTable<Soneta.Business.Db.TaskLinkedObj>` |  |  |  |
| Main | `Soneta.Business.Db.Task` |  |  |  |
| Name | `string` | bazodanowe |  | Krótka nazwa zadania. |
| Node | `Soneta.Business.IElementStrukturyOrganizacyjnej` | bazodanowe, iface-ref |  |  |
| Notification | `System.DateTime` | bazodanowe |  |  |
| NotificationCategory | `Soneta.Business.NotificationCategory` | bazodanowe | Notification Category | Kategoria powiadomienia |
| NotificationDate | `Soneta.Types.Date` |  |  |  |
| NotificationTime | `Soneta.Types.Time` |  |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Operator do którego jest przypisany task. |
| OperatorRoleType | `Soneta.Business.Db.OperatorRoleType` | bazodanowe, enum |  | Określa czy zadanie przypisane jest do operatora czy do roli czy innego obiektu. |
| OtherOperatorTaskSimpleRight | `Soneta.Business.AccessRights` | enum |  |  |
| OverdueTime | `System.DateTime` |  | Data i czas przeterminowania | Zwraca datę i czas przeterminowania zadania (wyliczane na podstawie wyrażenia określonego na definicji zadania, jeżeli wystąpi błąd lub nie określono algorytmu zwracana jest wartość DateTime.MaxValue). |
| Parent | `Soneta.Business.IGuidedRow` | bazodanowe |  |  |
| ParentWFWorkflows | `Soneta.Business.SubTable` |  | Procesy dla wiersza | Zwraca listę procesów workflow powiązanych z wierszem (Parent), dla których zalogowany operator jest opiekunem. |
| Progress | `Soneta.Business.Db.TaskProgress` | bazodanowe, enum |  |  |
| ProgressWithIsActive | `Soneta.Business.Db.TaskProgress` | enum |  | Właściwość zwraca stan zadania uzależnony od metody IsActive kalkulatora zadań. |
| ResponsibleName | `string` |  |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  | Guid roli do której przypisane jest zadanie. |
| RoleName | `string` |  |  |  |
| ScheduleItems | `Soneta.Business.SubTable` |  | Harmonogramy dla zadania | Zwraca listę harmonogramów powiązanych z zadaniem. |
| SourceTaskHistoryRels | `Soneta.Business.SubTable<Soneta.Business.Db.TaskHistoryRel>` |  |  |  |
| Start | `System.DateTime` | bazodanowe |  | Data i czas rozpoczęcia zadania. |
| StartDate | `Soneta.Types.Date` |  |  |  |
| StartTime | `Soneta.Types.Time` |  |  |  |
| Subprocess | `Soneta.Business.IWFWorkflow` | bazodanowe, iface-ref | Podproces | Określa podproces |
| SysNotification | `Soneta.Business.Db.Notifications.SysNotification` | bazodanowe |  | Powiadomienie systemowe powiązane z zadaniem |
| SysNotificationContent | `Soneta.Business.Db.SysNotificationContentHandleEventArgs` |  | Zawartość powiadomienia | Określa zawartość powiadomienia wyliczaną poprzez algorytm |
| TakeOverITaskUser | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref |  | Użytkownik, który przejmuje zadanie |
| TakeOverOperator | `Soneta.Business.App.Operator` | bazodanowe |  | operator, który przejmuje zadanie |
| TargetTaskHistoryRels | `Soneta.Business.SubTable<Soneta.Business.Db.TaskHistoryRel>` |  |  |  |
| TaskCalculator | `Soneta.Business.Db.TaskCalculator` |  |  |  |
| TaskExecutor | `string` |  |  |  |
| TaskNotificationIsNotRead | `bool` |  |  |  |
| TaskStatus | `Soneta.Business.Db.TaskStatus` | enum |  |  |
| TaskUser | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref |  | Określa obiekt który jest właścicielem zadania. |
| TimeAgoFromStartDate | `string` |  |  |  |
| Transition | `Soneta.Business.IWFTransition` | iface-ref |  |  |
| User | `Soneta.Business.ITaskUser` | iface-ref |  |  |
| UserDecision | `(Soneta.Business.IWFTransition Transition, object Variant, Soneta.Business.Context Context)` |  |  |  |
| ValidFrom | `Soneta.Types.Date` | bazodanowe |  | Określa datę od której task staje się ważny |
| ValidationPeriod | `string` |  |  |  |
| WFFirstTask | `Soneta.Business.Db.Task` |  | Pierwsze zadanie | Określa pierwsze zadanie w ramach procesu (tylko dla Workflow) |
| WFHistory | `string` |  |  |  |
| WFPreviousParent | `Soneta.Business.IGuidedRow` |  | Wiersz powiązany z poprzedzającym zadaniem | Określa wiersz powiązany z zadaniem poprzedzającym (tylko dla Workflow) |
| WFPreviousParentsByCurrentTask | `System.Collections.Generic.List<Soneta.Business.Db.Task>` |  | Zadania powiązane z Workflow poprzedzające aktualne zadanie | Określa zadania powiązane z Workflow poprzedzające aktualne zadanie (tylko dla Workflow) |
| WFPreviousParentsByDefinition | `System.Collections.Generic.List<Soneta.Business.IGuidedRow>` |  | Wiersze powiązane z Workflow i definicją zadania | Określa wiersze powiązane z Workflow i określoną definicją zadania (tylko dla Workflow) |
| WFPreviousParentsByType | `System.Collections.Generic.List<Soneta.Business.IGuidedRow>` |  | Wiersze powiązane z Workflow i określonym w definicji zadania typem danych | Określa wiersze powiązane z Workflow i określonym w definicji zadania typem danych (tylko dla Workflow) |
| WFPreviousTask | `Soneta.Business.Db.Task` |  | Zadanie poprzedzające | Określa zadanie poprzedzające (tylko dla Workflow) |
| WFPreviousTransition | `Soneta.Business.IWFTransition` | iface-ref | Tranzycja poprzedzająca | Określa tranzycję poprzedzającą (tylko dla Workflow) |
| WFTaskDefinitionsByCurrentTask | `Soneta.Business.SubTable` |  | Definicje zadań powiązane z definicją Workflow | Określa definicje zadań powiązane z definicją Workflow (tylko dla Workflow) |
| WFTasksByCurrentTaskDefinition | `System.Collections.Generic.List<Soneta.Business.Db.Task>` |  | Zadania powiązane z Workflow i definicją aktualnego zadania | Określa zadania powiązane z Workflow i definicją aktualnego zadania (tylko dla Workflow) |
| WFTransition | `Soneta.Business.IWFTransition` | bazodanowe, iface-ref | Tranzycja | Określa tranzycję dla zadania |
| WFWorkflow | `Soneta.Business.IWFWorkflow` | bazodanowe, iface-ref | Workflow | Określa element wokflow |
| WfHistoryView | `Soneta.Business.View` |  |  |  |
| WizardDefinition | `Soneta.Business.Db.Wizard.WizardDefinition` | bazodanowe |  | Definicja kreatora powiązana z zadaniem |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Executor | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
| Node | `IElementStrukturyOrganizacyjnej` | `ElementStrukturyOrganizacyjnej` |
| Subprocess | `IWFWorkflow` | `WFWorkflow` |
| TakeOverITaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
| TaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
| Transition | `IWFTransition` | `WFTransition` |
| User | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
| WFPreviousTransition | `IWFTransition` | `WFTransition` |
| WFTransition | `IWFTransition` | `WFTransition` |
| WFWorkflow | `IWFWorkflow` | `WFWorkflow` |

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

### OperatorRoleType (`Soneta.Business.Db.OperatorRoleType`)
- `Operator` = 0
- `Role` = 1 — Rola
- `Other` = 2 — Inny obiekt
- `Node` = 3 — Element struktury organizacyjnej

### TaskHistoryKind (`Soneta.Business.Db.TaskHistoryKind`)
- `CalculatedHistory` = 0 — Wyliczana historia zadania
- `TableHistory` = 1 — Historia zadania zapisana w tabeli TaskHistoryRel

### TaskProgress (`Soneta.Business.Db.TaskProgress`)
- `NonActive` = 0 — Nieaktualny
- `Active` = 1 — Aktywny
- `Waiting` = 2 — Oczekujący
- `Realized` = 3 — Zrealizowany
- `Aborted` = 4 — Odrzucony

### TaskStatus (`Soneta.Business.Db.TaskStatus`)
- `NonActive` = 0 — Nieaktywne
- `Aborted` = 1 — Anulowane
- `Realised` = 2 — Zakończone
- `Waiting` = 3 — Oczekujące
- `Expired` = 4 — Przedawnione
- `Current` = 5 — Aktualne
- `Future` = 6 — Przyszłe
