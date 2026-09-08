# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.TaskDefinition`
Nazwa tabeli: `TaskDefs`
Tytuł: Definicje zadań
Opis: Definicja zadania lub elementu procesu workflow. Określa typ, algorytm, operatora, powiązania z kreatorami, powiadomienia i parametry procesu biznesowego.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWizardReferenceHost`, `IWfPlugInItemReferenceHost`, `IWorkflowItemDescriptionHost`, `IWFRecipientHost`, `ISysNotificationHost`, `IPreviewPageHost`, `ISysNotificationReference`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Action | `string` |  | Wykonywana akcja | Domyślna akcja wykonywana na obiekcie nadrzędnym. |
| ActionRunAt | `Db.ActionRunAt` (enum) | bazodanowe |  |  |
| ActionType | `Db.ActionType` (enum) | bazodanowe |  |  |
| ActiveCondition | `string` |  | Warunek aktywności | Dodatkowy warunek aktywności zadania, może nie być związany bezpośrednio z obiektem nadrzędnym. |
| ActiveExpression | `string` |  |  |  |
| ActiveTask | `bool` | tylko-odczyt |  |  |
| AdditionalWizardsRef | `SubTable<Db.Wizard.WizardReference>` | podlista |  |  |
| Algorithm | `bool` | bazodanowe |  |  |
| AllowAttachmentSigningCode | `string` |  | Możliwość podpisywania załączników | Kod metody określającej czy załączniki można podpisywać pomimo braku braw do załącznika. |
| AllowModification | `bool` | bazodanowe |  |  |
| AnyTable | `bool` | tylko-odczyt |  |  |
| BusinessType | `BusinessTypeItem` |  | Typ szczegółowy |  |
| BusinessTypeName | `string` | bazodanowe, tylko-odczyt | Typ biznesowy dokumentu | Typ biznesowy dokumentu. |
| CalcNodeDescriptionEditorCode | `string` | tylko-odczyt | Opis węzła | Kod metody wyliczającej opis węzła grafu (edycja procesu). |
| CalcNodeDescriptionViewerCode | `string` | tylko-odczyt | Opis węzła | Kod metody wyliczającej opis węzła grafu (podgląd procesu). |
| ClassName | `string` | tylko-odczyt |  | Nazwa klasy w generowanym kodzie algorytmu. |
| Code | `MemoText` | bazodanowe, podlista |  |  |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt | Tryb edycji | Określa tryb edycji definicji workflow |
| DeleteOnRealized | `Db.DeleteOnRealized` (enum) | bazodanowe |  | Określa zachowanie taska przy realizacji. |
| Description | `string` | bazodanowe | Opis |  |
| DescriptionExpression | `string` |  |  |  |
| EmailContent | `string` |  | Treść poczty | Treść wysyłanej poczty. |
| EmailContentHTML | `string` |  | Treść poczty HTML | Treść wysyłanej poczty w HTML. |
| EmailSubject | `string` |  | Tytuł poczty | Tytuł wysyłanej poczty. {0} reprezentuje tekstowy opis danych źródłowych. |
| EmailTo | `string` |  | Odbioca poczty | Adres odbiorcy lub właściwość obiektu biznesowego zawierająca adres odbiorcy poczty. |
| EnableCondition | `string` |  | Warunek utworzenia | Warunek, dla którego jest dodawane nowe zadanie lub modyfikowane istniejące. |
| EnableExpression | `string` |  |  |  |
| EndDateExpression | `string` |  |  |  |
| EndPoint | `bool` | tylko-odczyt |  |  |
| EndType | `Db.TaskEndTypeEnum` (enum) | bazodanowe | Typ elementu końcowego | Określa typ elementu końcowego definicji elementu workflow |
| ErrorHandlerGuid | `System.Guid` | bazodanowe | Proces obsługi błędów |  |
| ExceptionInfo | `string` |  |  |  |
| ExternalErrorHandling | `bool` | bazodanowe | Zewnętrzna obsługa błędów |  |
| FeautureDefs | `SubTable` | podlista |  |  |
| ForeColor | `string` | bazodanowe | Kolor |  |
| FormatedName | `string` | bazodanowe |  | Ogólne |
| GetManagingRowCode | `string` |  | Wybór wiersza zarządzajacego | Kod metody wyboru wiersza zarządzającego dla procesu. |
| GetParentCode | `string` |  | Wybór wiersza | Kod metody wyboru wiersza dla zadania. |
| GetParentExpression | `string` |  | Wybór wiersza | Wyrażenie budujące metodę wyboru wiersza dla zadania. |
| GetSysNotificationsCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Kod metody GetSysNotifications | Określa algorytm metody GetSysNotifications |
| GetSysNotificationsCode.Code | `MemoText` | bazodanowe, podlista |  |  |
| GetSysNotificationsCode.CodeUiRoslyn | `Compiler.ICodeEditorSource` |  |  |  |
| GetTaskUsers | `string` |  | Wybór operatorów | Wybór operatorów dla zadania Multi |
| HasScheduleAutoJob | `bool` | tylko-odczyt |  |  |
| HasSourceWFTransitions | `bool` | tylko-odczyt |  |  |
| HasTargetWFTransitions | `bool` | tylko-odczyt |  |  |
| Icon | `string` | bazodanowe | Ikona |  |
| IconItem | `IconLookupTools.IconItem` |  | Ikona |  |
| Identifier | `string` | tylko-odczyt |  |  |
| InWorkflowUse | `bool` | bazodanowe |  | Określa czy definicja jest widoczna tylko jako kontrolka w toolbox definicji workflow. |
| IncompatibleWithSerialOperations | `bool` | bazodanowe | Niezgodna z operacjami seryjnymi | Niezgodna z operacjami seryjnymi |
| Info | `string` | tylko-odczyt |  |  |
| InitParent | `bool` | bazodanowe | Inicjacja zadania wierszem generatora | Określa czy inicjować zadanie wierszem utworzonym przez generator obiektów |
| InitTaskPropertiesCode | `string` |  | Inicjacja zadania | Kod metody inicjującej właściwości zadania. |
| InterfaceMode | `Db.TaskInterfaceModeEnum` (enum) | bazodanowe | Tryb wyboru ścieżki | Tryb wybór ścieżki w procesie |
| IsAlgorithm | `bool` | tylko-odczyt |  | Informuje,czy dla danej definicji jest algorytm przetwarzania zadań. |
| IsEmptyDescription | `bool` | tylko-odczyt |  |  |
| IsEndTypeNone | `bool` | tylko-odczyt |  |  |
| IsEndTypeWorkflow | `bool` | tylko-odczyt |  |  |
| IsManualAction | `bool` | tylko-odczyt |  |  |
| IsNotification | `bool` | bazodanowe |  |  |
| IsPageVisible | `bool` | tylko-odczyt |  |  |
| IsSingleInstance | `bool` | bazodanowe | Złączenie | Określa czy definicja jest typu złączenie |
| IsStandardDef | `bool` | tylko-odczyt |  |  |
| IsStart | `bool` | bazodanowe | Element startowy | Czy definicja zadania jest początkiem procesu workflow |
| IsVisibleInScheduler | `bool` | bazodanowe |  | Określa czy zadanie jest widoczne na liście |
| Locked | `bool` | bazodanowe | Zablokowany |  |
| MakeParentReadOnlyFor | `Db.MakeParentReadOnlyFor` (enum) |  |  |  |
| MakeParentReadOnlyForOthers | `bool` | bazodanowe |  |  |
| MultiTaskType | `Db.MultiTaskType` (enum) | bazodanowe |  | Określa typ wywołania procedury w przypadku zadań typu MultiTask |
| Name | `string` | bazodanowe |  | Ogólne |
| NameExpression | `string` |  |  |  |
| NeutralName | `string` | tylko-odczyt |  |  |
| Node | `IElementStrukturyOrganizacyjnej` | bazodanowe, iface-ref |  |  |
| NotificationCategory | `NotificationCategory` | bazodanowe | Notification Category | Kategoria powiadomienia |
| NotificationExpression | `string` |  |  |  |
| NotificationTime | `Time` | bazodanowe |  |  |
| NotificationTimeString | `string` |  |  |  |
| NotificationType | `Db.NotificationType` (enum) | bazodanowe |  |  |
| OGSchema | `IOGSchema` | bazodanowe, iface-ref | Definicja schematu generatora | Określa definicję schematu generatora obiektów |
| ObjTable | `Table` | podlista |  |  |
| OpenFormType | `string` |  |  |  |
| Operator | `App.Operator` | bazodanowe |  |  |
| OperatorExpression | `string` |  |  |  |
| OperatorType | `Db.TaskOperatorType` (enum) | bazodanowe |  |  |
| OrgStructure | `IStrukturaOrganizacyjna` | bazodanowe, iface-ref |  |  |
| OtherMethods | `string` |  | Inne metody | Inne metody. |
| OverdueHandling | `bool` | bazodanowe | Obsługa eskalacji | Określa obsługiwana jest eskalacja |
| OverdueServiceType | `Db.TaskDefinition` | bazodanowe | Sposób obsługi eskalacji | Określa sposób obsługi eskalacji |
| OverdueTimeExpression | `string` |  | Data i czas eskalacji | Data i czas eskalacji przeterminowania. |
| ParentType | `System.Type` | tylko-odczyt |  |  |
| ProcessManagementVisibilityType | `Db.ProcessManagementVisibilityType` (enum) | bazodanowe | Typ widoczności elementów UI obsługi procesu | Określa typ widoczności elementów UI obsługi procesu |
| ProcessRole | `IWFProcessRole` | bazodanowe | Rola procesowa | Określa rolę procesową |
| RealisedCondition | `string` |  | Warunek zrealizowania | Warunek przestawienia w stan zrealizowany. |
| RealisedExpression | `string` |  |  |  |
| RecalculateAfterEditing | `bool` | bazodanowe | Przelicz po zmianie |  |
| RoleGuid | `System.Guid` | bazodanowe |  |  |
| RoleName | `string` |  |  |  |
| RowTypeFullName | `string` | tylko-odczyt |  |  |
| RunWorkerType | `string` |  |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| ScheduleDefs | `SubTable` | podlista |  |  |
| ShowInListMenu | `bool` | bazodanowe | Pokaż w menu listy |  |
| ShowInListToolbar | `bool` | bazodanowe | Pokaż w nagłówku listy |  |
| ShowInMenu | `bool` | tylko-odczyt |  |  |
| ShowInToolbar | `bool` | bazodanowe | Pokaż w nagłówku |  |
| SonetaExplorerLegacy | `bool` | tylko-odczyt |  |  |
| SourceWFTransitions | `SubTable` | podlista |  |  |
| StartDateExpression | `string` |  |  |  |
| StartExpression | `string` |  | Data rozpoczęcia | Data rozpoczęcia zadania (kod do wpisania z podpowiedzią property typu date). |
| StartPointType | `Db.TaskStartPointTypeEnum` (enum) | bazodanowe | Typ elementu startowego | Określa typ elementu startowego definicji elementu workflow |
| SubprocessDef | `IWFDefinition` | bazodanowe, iface-ref | Definicja podprocesu | Określa definicję podprocesu |
| SysNotifications | `SubTable<Db.Notifications.SysNotification>` | podlista |  |  |
| TableName | `string` | bazodanowe, tylko-odczyt | Klasa | Klasa obiektu nadrzędanego. |
| TargetWFTransitions | `SubTable` | podlista |  |  |
| TaskCalculatorType | `System.Type` | tylko-odczyt |  |  |
| TaskDefType | `ITaskDefRowType` | bazodanowe | Typ | Typ dla row dla dbtuple |
| TaskTriggers | `SubTable<Db.TaskTrigger>` | podlista |  |  |
| TransitionPath | `string` | tylko-odczyt |  |  |
| TypeFullName | `string` | tylko-odczyt |  |  |
| ValidFromExpression | `string` |  |  |  |
| VariantTypeName | `string` | bazodanowe | Typ zadania wielowariantowego | Typ zadania wielowariantowego |
| VerifierCheckType | `Db.VerifierCheckType` (enum) | bazodanowe | Sposób weryfikacji zadań | Określa sposób weryfikacji zadań procesów zależnych |
| WFDefItem | `IWFDefItem` | bazodanowe, iface-ref | Definicja elementu workflow | Określa definicję elementu wokflow |
| WFDefinition | `IWFDefinition` | bazodanowe, iface-ref | Definicja workflow | Określa definicję wokflow |
| WFTransitions | `View` | podlista |  |  |
| WizardInstruction | `MemoText` | bazodanowe, podlista | Instrukcja dla definicji kreatora | Określa instrukcję dla definicji kreatora |
| WizardMode | `bool` | tylko-odczyt |  |  |
| WizardsRef | `LpSubTable<Db.Wizard.WizardReference>` | podlista |  |  |
| WorkflowToolsService | `IWorkflowToolsService` | tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Node | `IElementStrukturyOrganizacyjnej` | `ElementStrukturyOrganizacyjnej` |
| OGSchema | `IOGSchema` | `OGSchema` |
| OrgStructure | `IStrukturaOrganizacyjna` | `StrukturaOrganizacyjna` |
| SubprocessDef | `IWFDefinition` | `WFDefinition` |
| WFDefItem | `IWFDefItem` | `WFDefItem` |
| WFDefinition | `IWFDefinition` | `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ActionRunAt (`Db.ActionRunAt`)
- `Auto` = 0 — Automatyczna
- `InMenu` = 1 — W menu
- `Default` = 2 — Domyślna dla zadania

### ActionType (`Db.ActionType`)
- `None` = 0 — Brak
- `RunWorker` = 1 — Uruchom worker
- `OpenObjectForm` = 2 — Otwórz formularz
- `ThrowException` = 3 — Zgłoś wyjątek
- `Email` = 4 — Wysyłka email
- `PromptAI` = 5 — Prompt AI (definicja tworzona z promptu AI; jedyny rodzaj akcji definicji Standard, dla którego `ShowInListMenu`/`ShowInListToolbar` są zapisywalne — patrz [WORKFLOW02](../../references/domeny/workflow/WORKFLOW02-wezly.md))

### DefinitionTypeEnum (`Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### DeleteOnRealized (`Db.DeleteOnRealized`)
- `BeforeValidDate` = 0 — Przed datą ważności
- `Never` = 1 — Nigdy
- `Always` = 2 — Zawsze

### MakeParentReadOnlyFor (`Db.MakeParentReadOnlyFor`)
- `None` = 0 — Dla nikogo
- `AnyExceptOwner` = 1 — Dla wszystkich poza właścicielem
- `Any` = 2 — Dla wszystkich

### MultiTaskType (`Db.MultiTaskType`)
- `NoMultiTask` = 0 — Nie
- `ByGetTaskUsers` = 1 — Wg użytkowników
- `ByGetSysNotifications` = 2 — Wg powiadomień

### NotificationType (`Db.NotificationType`)
- `None` = 0 — Brak
- `BeforeStart` = 1 — Przed rozpoczęciem
- `BeforeEnd` = 2 — Przed zakończeniem
- `Expression` = 3 — Wyrażenie

### ProcessManagementVisibilityType (`Db.ProcessManagementVisibilityType`)
- `ShowBoth` = 0 — Wyświetlaj / Wyświetlaj
- `ShowPanelHidePage` = 1 — Wyświetlaj / Nie wyświetlaj
- `HidePanelShowPage` = 2 — Nie wyświetlaj / Wyświetlaj
- `HideBoth` = 3 — Nie wyświetlaj / Nie wyświetlaj

### TaskEndTypeEnum (`Db.TaskEndTypeEnum`)
- `WFTransitions` = 0 — Przez warunki (tranzycje)
- `None` = 1 — Nie powoduje wymuszenia zakończenia procesu
- `Workflow` = 2 — Powoduje wymuszenie zakończenia całego procesu

### TaskInterfaceModeEnum (`Db.TaskInterfaceModeEnum`)
- `Default` = 0 — Domyślny
- `SelectMode` = 1 — Lista
- `WizardMode` = 2 — Przyciski (Zapisz i zamknij)
- `WizardModeSave` = 3 — Przyciski (Zapisz)

### TaskOperatorType (`Db.TaskOperatorType`)
- `Current` = 0 — Aktualny
- `Manual` = 1 — Wybrany
- `Created` = 2 — Tworzący dokument
- `Modified` = 3 — Modyfikujący dokument
- `Expression` = 4 — Wyrażenie określające operatora
- `Role` = 5 — Rola

### TaskStartPointTypeEnum (`Db.TaskStartPointTypeEnum`)
- `NoStartPoint` = 0 — Zadanie inne niż początkowe
- `Automatic` = 1 — Zadanie uruchamiane automatycznie
- `InWorkflowPanel` = 2 — Zadanie uruchamiane w panelu workflow
- `InDocumentMenu` = 4 — Zadanie uruchamiane w menu
- `Subprocess` = 8 — Zadanie początkowe podprocesu

### VerifierCheckType (`Db.VerifierCheckType`)
- `NotRequired` = -1 — Nie wymagaj
- `Warning` = 0 — Ostrzegaj
- `Required` = 1 — Wymagaj
