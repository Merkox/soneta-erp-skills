# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Task`
Nazwa tabeli: `Tasks`
Tytuł: Zadania
Opis: Instancja zadania (taska) w systemie. Reprezentuje konkretne zadanie przypisane do operatora lub roli, z określonym terminem, postępem i powiązaniem z procesem workflow.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowModificationRight | `bool` | tylko-odczyt |  |  |
| ChangeOperatorSimpleRight | `bool` | tylko-odczyt |  |  |
| Definition | `Db.TaskDefinition` | bazodanowe, tylko-odczyt |  |  |
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt | Tryb edycji | Określa tryb edycji definicji workflow |
| DeleteTaskSimpleRight | `bool` | tylko-odczyt |  |  |
| Description | `MemoText` | bazodanowe, podlista | Opis | Opis zadania. |
| End | `System.DateTime` | bazodanowe |  | Data i czas zakończenia zadania. |
| EndDate | `Date` |  |  |  |
| EndTime | `Time` |  |  |  |
| ExecutionDateAndTime | `string` | tylko-odczyt |  |  |
| ExecutionTime | `System.DateTime` | bazodanowe, tylko-odczyt | Data i czas wykonania zadania | Data i czas wykonania zadania |
| Executor | `ITaskUser` | tylko-odczyt, iface-ref | Wykonawca | Wykonawca zadania |
| ExecutorId | `int` | bazodanowe | ID wiersza wykonawcy | ID wiersza wykonawcy zadania |
| ExecutorType | `string` | bazodanowe | Typ wiersza wykonawcy | Typ wiersza wykonawcy zadania |
| ExternalErrorHandling | `bool` | bazodanowe, tylko-odczyt | Zewnętrzna obsługa błędów |  |
| HistoryKind | `Db.TaskHistoryKind` (enum) | bazodanowe, tylko-odczyt | Rodzaj historii procesu | Określa rodzaj historii procesu |
| Icon | `string` | tylko-odczyt |  |  |
| Info | `MemoText` | podlista |  |  |
| Interval | `Interval` |  |  |  |
| IsActiveProgress | `bool` | tylko-odczyt |  |  |
| IsManualAction | `bool` | tylko-odczyt |  |  |
| IsNotification | `bool` |  |  |  |
| LinkedObjects | `SubTable<Db.TaskLinkedObj>` | podlista |  |  |
| Main | `Db.Task` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe |  | Krótka nazwa zadania. |
| Node | `IElementStrukturyOrganizacyjnej` | bazodanowe, iface-ref |  |  |
| Notification | `System.DateTime` | bazodanowe |  |  |
| NotificationCategory | `NotificationCategory` | bazodanowe | Notification Category | Kategoria powiadomienia |
| NotificationDate | `Date` |  |  |  |
| NotificationTime | `Time` |  |  |  |
| Operator | `App.Operator` | bazodanowe |  | Operator do którego jest przypisany task. |
| OperatorRoleType | `Db.OperatorRoleType` (enum) | bazodanowe |  | Określa czy zadanie przypisane jest do operatora czy do roli czy innego obiektu. |
| OtherOperatorTaskSimpleRight | `AccessRights` (enum) | tylko-odczyt |  |  |
| OverdueTime | `System.DateTime` | tylko-odczyt | Data i czas przeterminowania | Zwraca datę i czas przeterminowania zadania (wyliczane na podstawie wyrażenia określonego na definicji zadania, jeżeli wystąpi błąd lub nie określono algorytmu zwracana jest wartość DateTime.MaxValue). |
| Parent | `IGuidedRow` | bazodanowe, tylko-odczyt |  |  |
| ParentWFWorkflows | `SubTable` | podlista | Procesy dla wiersza | Zwraca listę procesów workflow powiązanych z wierszem (Parent), dla których zalogowany operator jest opiekunem. |
| Progress | `Db.TaskProgress` (enum) | bazodanowe |  |  |
| ProgressWithIsActive | `Db.TaskProgress` (enum) | tylko-odczyt |  | Właściwość zwraca stan zadania uzależnony od metody IsActive kalkulatora zadań. |
| ResponsibleName | `string` | tylko-odczyt |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  | Guid roli do której przypisane jest zadanie. |
| RoleName | `string` |  |  |  |
| ScheduleItems | `SubTable` | podlista | Harmonogramy dla zadania | Zwraca listę harmonogramów powiązanych z zadaniem. |
| SourceTaskHistoryRels | `SubTable<Db.TaskHistoryRel>` | podlista |  |  |
| Start | `System.DateTime` | bazodanowe |  | Data i czas rozpoczęcia zadania. |
| StartDate | `Date` |  |  |  |
| StartTime | `Time` |  |  |  |
| Subprocess | `IWFWorkflow` | bazodanowe, iface-ref | Podproces | Określa podproces |
| SysNotification | `Db.Notifications.SysNotification` | bazodanowe, tylko-odczyt |  | Powiadomienie systemowe powiązane z zadaniem |
| SysNotificationContent | `Db.SysNotificationContentHandleEventArgs` | tylko-odczyt | Zawartość powiadomienia | Określa zawartość powiadomienia wyliczaną poprzez algorytm |
| TakeOverITaskUser | `ITaskUser` | bazodanowe, iface-ref |  | Użytkownik, który przejmuje zadanie |
| TargetTaskHistoryRels | `SubTable<Db.TaskHistoryRel>` | podlista |  |  |
| TaskCalculator | `Db.TaskCalculator` | tylko-odczyt |  |  |
| TaskExecutor | `string` | tylko-odczyt |  |  |
| TaskNotificationIsNotRead | `bool` | tylko-odczyt |  |  |
| TaskStatus | `Db.TaskStatus` (enum) | tylko-odczyt |  |  |
| TaskUser | `ITaskUser` | bazodanowe, iface-ref |  | Określa obiekt który jest właścicielem zadania. |
| TimeAgoFromStartDate | `string` | tylko-odczyt |  |  |
| Transition | `IWFTransition` | tylko-odczyt, iface-ref |  |  |
| UserDecision | `(IWFTransition Transition, object Variant, Context Context)` |  |  |  |
| ValidFrom | `Date` | bazodanowe |  | Określa datę od której task staje się ważny |
| ValidationPeriod | `string` | tylko-odczyt |  |  |
| WFFirstTask | `Db.Task` | tylko-odczyt | Pierwsze zadanie | Określa pierwsze zadanie w ramach procesu (tylko dla Workflow) |
| WFPreviousParent | `IGuidedRow` | tylko-odczyt | Wiersz powiązany z poprzedzającym zadaniem | Określa wiersz powiązany z zadaniem poprzedzającym (tylko dla Workflow) |
| WFPreviousParentsByCurrentTask | `System.Collections.Generic.List<Db.Task>` | podlista | Zadania powiązane z Workflow poprzedzające aktualne zadanie | Określa zadania powiązane z Workflow poprzedzające aktualne zadanie (tylko dla Workflow) |
| WFPreviousParentsByDefinition | `System.Collections.Generic.List<IGuidedRow>` | podlista | Wiersze powiązane z Workflow i definicją zadania | Określa wiersze powiązane z Workflow i określoną definicją zadania (tylko dla Workflow) |
| WFPreviousParentsByType | `System.Collections.Generic.List<IGuidedRow>` | podlista | Wiersze powiązane z Workflow i określonym w definicji zadania typem danych | Określa wiersze powiązane z Workflow i określonym w definicji zadania typem danych (tylko dla Workflow) |
| WFPreviousTask | `Db.Task` | tylko-odczyt | Zadanie poprzedzające | Określa zadanie poprzedzające (tylko dla Workflow) |
| WFPreviousTransition | `IWFTransition` | tylko-odczyt, iface-ref | Tranzycja poprzedzająca | Określa tranzycję poprzedzającą (tylko dla Workflow) |
| WFTaskDefinitionsByCurrentTask | `SubTable` | podlista | Definicje zadań powiązane z definicją Workflow | Określa definicje zadań powiązane z definicją Workflow (tylko dla Workflow) |
| WFTasksByCurrentTaskDefinition | `System.Collections.Generic.List<Db.Task>` | podlista | Zadania powiązane z Workflow i definicją aktualnego zadania | Określa zadania powiązane z Workflow i definicją aktualnego zadania (tylko dla Workflow) |
| WFTransition | `IWFTransition` | bazodanowe, iface-ref | Tranzycja | Określa tranzycję dla zadania |
| WFWorkflow | `IWFWorkflow` | bazodanowe, tylko-odczyt, iface-ref | Workflow | Określa element wokflow |
| WfHistoryView | `View` | podlista |  |  |

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
| WFPreviousTransition | `IWFTransition` | `WFTransition` |
| WFTransition | `IWFTransition` | `WFTransition` |
| WFWorkflow | `IWFWorkflow` | `WFWorkflow` |

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

### OperatorRoleType (`Db.OperatorRoleType`)
- `Operator` = 0
- `Role` = 1 — Rola
- `Other` = 2 — Inny obiekt
- `Node` = 3 — Element struktury organizacyjnej

### TaskHistoryKind (`Db.TaskHistoryKind`)
- `CalculatedHistory` = 0 — Wyliczana historia zadania
- `TableHistory` = 1 — Historia zadania zapisana w tabeli TaskHistoryRel

### TaskProgress (`Db.TaskProgress`)
- `NonActive` = 0 — Nieaktualny
- `Active` = 1 — Aktywny
- `Waiting` = 2 — Oczekujący
- `Realized` = 3 — Zrealizowany
- `Aborted` = 4 — Odrzucony

### TaskStatus (`Db.TaskStatus`)
- `NonActive` = 0 — Nieaktywne
- `Aborted` = 1 — Anulowane
- `Realised` = 2 — Zakończone
- `Waiting` = 3 — Oczekujące
- `Expired` = 4 — Przedawnione
- `Current` = 5 — Aktualne
- `Future` = 6 — Przyszłe
