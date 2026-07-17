# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.TaskDefinition`
Nazwa tabeli: `TaskDefs`
Tytuł: Definicje zadań
Opis: Definicja zadania lub elementu procesu workflow. Określa typ, algorytm, operatora, powiązania z kreatorami, powiadomienia i parametry procesu biznesowego.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWizardReferenceHost`, `IWfPlugInItemReferenceHost`, `IWorkflowItemDescriptionHost`, `IWFRecipientHost`, `ISysNotificationHost`, `IPreviewPageHost`, `ISysNotificationReference`

- pola bazodanowe: 64
- pola kalkulowane (z klas biznesowych): 77

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Action | `string` |  | Wykonywana akcja | Domyślna akcja wykonywana na obiekcie nadrzędnym. |
| ActionRunAt | `Soneta.Business.Db.ActionRunAt` | bazodanowe, enum |  |  |
| ActionType | `Soneta.Business.Db.ActionType` | bazodanowe, enum |  |  |
| ActiveCondition | `string` |  | Warunek aktywności | Dodatkowy warunek aktywności zadania, może nie być związany bezpośrednio z obiektem nadrzędnym. |
| ActiveExpression | `string` |  |  |  |
| ActiveTask | `bool` |  |  |  |
| AdditionalWizardsRef | `Soneta.Business.SubTable<Soneta.Business.Db.Wizard.WizardReference>` |  |  |  |
| Algorithm | `bool` | bazodanowe |  |  |
| AllowAttachmentSigningCode | `string` |  | Możliwość podpisywania załączników | Kod metody określającej czy załączniki można podpisywać pomimo braku braw do załącznika. |
| AllowModification | `bool` | bazodanowe |  |  |
| AnyTable | `bool` |  |  |  |
| BusinessType | `Soneta.Business.BusinessTypeItem` |  | Typ szczegółowy |  |
| BusinessTypeName | `string` | bazodanowe | Typ biznesowy dokumentu | Typ biznesowy dokumentu. |
| CalcNodeDescriptionEditorCode | `string` |  | Opis węzła | Kod metody wyliczającej opis węzła grafu (edycja procesu). |
| CalcNodeDescriptionViewerCode | `string` |  | Opis węzła | Kod metody wyliczającej opis węzła grafu (podgląd procesu). |
| ClassName | `string` |  |  | Nazwa klasy w generowanym kodzie algorytmu. |
| Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| DataType | `System.Type` |  |  |  |
| DefinitionType | `Soneta.Business.Db.DefinitionTypeEnum` | bazodanowe, enum | Tryb edycji | Określa tryb edycji definicji workflow |
| DeleteOnRealized | `Soneta.Business.Db.DeleteOnRealized` | bazodanowe, enum |  | Określa zachowanie taska przy realizacji. |
| Description | `string` | bazodanowe | Opis |  |
| DescriptionExpression | `string` |  |  |  |
| EmailContent | `string` |  | Treść poczty | Treść wysyłanej poczty. |
| EmailContentHTML | `string` |  | Treść poczty HTML | Treść wysyłanej poczty w HTML. |
| EmailSubject | `string` |  | Tytuł poczty | Tytuł wysyłanej poczty. {0} reprezentuje tekstowy opis danych źródłowych. |
| EmailTo | `string` |  | Odbioca poczty | Adres odbiorcy lub właściwość obiektu biznesowego zawierająca adres odbiorcy poczty. |
| EnableCondition | `string` |  | Warunek utworzenia | Warunek, dla którego jest dodawane nowe zadanie lub modyfikowane istniejące. |
| EnableExpression | `string` |  |  |  |
| EndDateExpression | `string` |  |  |  |
| EndPoint | `bool` |  |  |  |
| EndType | `Soneta.Business.Db.TaskEndTypeEnum` | bazodanowe, enum | Typ elementu końcowego | Określa typ elementu końcowego definicji elementu workflow |
| ErrorHandlerGuid | `System.Guid` | bazodanowe | Proces obsługi błędów |  |
| ExceptionInfo | `string` |  |  |  |
| ExternalErrorHandling | `bool` | bazodanowe | Zewnętrzna obsługa błędów |  |
| FeautureDefs | `Soneta.Business.SubTable` |  |  |  |
| ForeColor | `string` | bazodanowe | Kolor |  |
| FormatedName | `string` | bazodanowe |  | Ogólne |
| GetManagingRowCode | `string` |  | Wybór wiersza zarządzajacego | Kod metody wyboru wiersza zarządzającego dla procesu. |
| GetParentCode | `string` |  | Wybór wiersza | Kod metody wyboru wiersza dla zadania. |
| GetParentExpression | `string` |  | Wybór wiersza | Wyrażenie budujące metodę wyboru wiersza dla zadania. |
| GetSysNotificationsCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Kod metody GetSysNotifications | Określa algorytm metody GetSysNotifications |
| GetSysNotificationsCode.Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| GetSysNotificationsCode.CodeUi | `string` |  |  |  |
| GetSysNotificationsCode.CodeUiRoslyn | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| GetTaskUsers | `string` |  | Wybór operatorów | Wybór operatorów dla zadania Multi |
| HasScheduleAutoJob | `bool` |  |  |  |
| HasSourceWFTransitions | `bool` |  |  |  |
| HasTargetWFTransitions | `bool` |  |  |  |
| Icon | `string` | bazodanowe | Ikona |  |
| IconItem | `Soneta.Business.IconLookupTools.IconItem` |  | Ikona |  |
| Identifier | `string` |  |  |  |
| InWorkflowUse | `bool` | bazodanowe |  | Określa czy definicja jest widoczna tylko jako kontrolka w toolbox definicji workflow. |
| IncompatibleWithSerialOperations | `bool` | bazodanowe | Niezgodna z operacjami seryjnymi | Niezgodna z operacjami seryjnymi |
| Info | `string` |  |  |  |
| InitParent | `bool` | bazodanowe | Inicjacja zadania wierszem generatora | Określa czy inicjować zadanie wierszem utworzonym przez generator obiektów |
| InitTaskPropertiesCode | `string` |  | Inicjacja zadania | Kod metody inicjującej właściwości zadania. |
| InterfaceMode | `Soneta.Business.Db.TaskInterfaceModeEnum` | bazodanowe, enum | Tryb wyboru ścieżki | Tryb wybór ścieżki w procesie |
| IsAlgorithm | `bool` |  |  | Informuje,czy dla danej definicji jest algorytm przetwarzania zadań. |
| IsEmptyDescription | `bool` |  |  |  |
| IsEndTypeNone | `bool` |  |  |  |
| IsEndTypeWorkflow | `bool` |  |  |  |
| IsManualAction | `bool` |  |  |  |
| IsNotification | `bool` | bazodanowe |  |  |
| IsPageVisible | `bool` |  |  |  |
| IsSingleInstance | `bool` | bazodanowe | Złączenie | Określa czy definicja jest typu złączenie |
| IsStandardDef | `bool` |  |  |  |
| IsStart | `bool` | bazodanowe | Element startowy | Czy definicja zadania jest początkiem procesu workflow |
| IsVisibleInScheduler | `bool` | bazodanowe |  | Określa czy zadanie jest widoczne na liście |
| Locked | `bool` | bazodanowe | Zablokowany |  |
| MakeParentReadOnlyFor | `Soneta.Business.Db.MakeParentReadOnlyFor` | enum |  |  |
| MakeParentReadOnlyForOthers | `bool` | bazodanowe |  |  |
| MakeParentReadonly | `bool` | bazodanowe | Tylko do odczytu | Czy obiekt powiązany z definicją (Parent dla zadania) ma być blokowany do edycji poza Workflow |
| MultiTask | `bool` | bazodanowe |  |  |
| MultiTaskType | `Soneta.Business.Db.MultiTaskType` | bazodanowe, enum |  | Określa typ wywołania procedury w przypadku zadań typu MultiTask |
| Name | `string` | bazodanowe |  | Ogólne |
| NameExpression | `string` |  |  |  |
| NeutralName | `string` |  |  |  |
| Node | `Soneta.Business.IElementStrukturyOrganizacyjnej` | bazodanowe, iface-ref |  |  |
| NotificationCategory | `Soneta.Business.NotificationCategory` | bazodanowe | Notification Category | Kategoria powiadomienia |
| NotificationExpression | `string` |  |  |  |
| NotificationTime | `Soneta.Types.Time` | bazodanowe |  |  |
| NotificationTimeString | `string` |  |  |  |
| NotificationType | `Soneta.Business.Db.NotificationType` | bazodanowe, enum |  |  |
| OGSchema | `Soneta.Business.IOGSchema` | bazodanowe, iface-ref | Definicja schematu generatora | Określa definicję schematu generatora obiektów |
| ObjTable | `Soneta.Business.Table` |  |  |  |
| OpenFormType | `string` |  |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
| OperatorExpression | `string` |  |  |  |
| OperatorType | `Soneta.Business.Db.TaskOperatorType` | bazodanowe, enum |  |  |
| OrgStructure | `Soneta.Business.IStrukturaOrganizacyjna` | bazodanowe, iface-ref |  |  |
| OtherMethods | `string` |  | Inne metody | Inne metody. |
| OverdueHandling | `bool` | bazodanowe | Obsługa eskalacji | Określa obsługiwana jest eskalacja |
| OverdueServiceType | `Soneta.Business.Db.TaskDefinition` | bazodanowe | Sposób obsługi eskalacji | Określa sposób obsługi eskalacji |
| OverdueTimeExpression | `string` |  | Data i czas eskalacji | Data i czas eskalacji przeterminowania. |
| ParentType | `System.Type` |  |  |  |
| ProcessManagementVisibilityType | `Soneta.Business.Db.ProcessManagementVisibilityType` | bazodanowe, enum | Typ widoczności elementów UI obsługi procesu | Określa typ widoczności elementów UI obsługi procesu |
| ProcessRole | `Soneta.Business.IWFProcessRole` | bazodanowe | Rola procesowa | Określa rolę procesową |
| RealisedCondition | `string` |  | Warunek zrealizowania | Warunek przestawienia w stan zrealizowany. |
| RealisedExpression | `string` |  |  |  |
| RecalculateAfterEditing | `bool` | bazodanowe | Przelicz po zmianie |  |
| RoleGuid | `System.Guid` | bazodanowe |  |  |
| RoleName | `string` |  |  |  |
| RowTypeFullName | `string` |  |  |  |
| RunWorkerType | `string` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| ScheduleDefs | `Soneta.Business.SubTable` |  |  |  |
| ShowInListMenu | `bool` | bazodanowe | Pokaż w menu listy |  |
| ShowInListToolbar | `bool` | bazodanowe | Pokaż w nagłówku listy |  |
| ShowInMenu | `bool` |  |  |  |
| ShowInToolbar | `bool` | bazodanowe | Pokaż w nagłówku |  |
| SonetaExplorer | `bool` | bazodanowe |  | Określa czy kompilacja kodu definicji zadania może być wykonana tylko w SonetaExplorer |
| SonetaExplorerLegacy | `bool` |  |  |  |
| SourceWFTransitions | `Soneta.Business.SubTable` |  |  |  |
| StartDateExpression | `string` |  |  |  |
| StartExpression | `string` |  | Data rozpoczęcia | Data rozpoczęcia zadania (kod do wpisania z podpowiedzią property typu date). |
| StartPointType | `Soneta.Business.Db.TaskStartPointTypeEnum` | bazodanowe, enum | Typ elementu startowego | Określa typ elementu startowego definicji elementu workflow |
| SubprocessDef | `Soneta.Business.IWFDefinition` | bazodanowe, iface-ref | Definicja podprocesu | Określa definicję podprocesu |
| SysNotifications | `Soneta.Business.SubTable<Soneta.Business.Db.Notifications.SysNotification>` |  |  |  |
| TableName | `string` | bazodanowe | Klasa | Klasa obiektu nadrzędanego. |
| TargetWFTransitions | `Soneta.Business.SubTable` |  |  |  |
| TaskCalculatorType | `System.Type` |  |  |  |
| TaskDefType | `Soneta.Business.ITaskDefRowType` | bazodanowe | Typ | Typ dla row dla dbtuple |
| TaskTriggers | `Soneta.Business.SubTable<Soneta.Business.Db.TaskTrigger>` |  |  |  |
| TransitionPath | `string` |  |  |  |
| TypeFullName | `string` |  |  |  |
| ValidFromExpression | `string` |  |  |  |
| VariantTypeName | `string` | bazodanowe | Typ zadania wielowariantowego | Typ zadania wielowariantowego |
| VerifierCheckType | `Soneta.Business.Db.VerifierCheckType` | bazodanowe, enum | Sposób weryfikacji zadań | Określa sposób weryfikacji zadań procesów zależnych |
| WFDefItem | `Soneta.Business.IWFDefItem` | bazodanowe, iface-ref | Definicja elementu workflow | Określa definicję elementu wokflow |
| WFDefinition | `Soneta.Business.IWFDefinition` | bazodanowe, iface-ref | Definicja workflow | Określa definicję wokflow |
| WFTransitions | `Soneta.Business.View` |  |  |  |
| WizardDefinition | `Soneta.Business.Db.Wizard.WizardDefinition` | bazodanowe |  | Definicja kreatora powiązana z definicją zadania |
| WizardInstruction | `Soneta.Business.MemoText` | bazodanowe | Instrukcja dla definicji kreatora | Określa instrukcję dla definicji kreatora |
| WizardMode | `bool` |  |  |  |
| WizardsRef | `Soneta.Business.LpSubTable<Soneta.Business.Db.Wizard.WizardReference>` |  |  |  |
| WorkflowToolsService | `Soneta.Business.IWorkflowToolsService` |  |  |  |
| XML | `Soneta.Business.MemoText` | bazodanowe | XML opisujący rozmiar i położenie węzła | XML opisujący rozmiar i położenie węzła |

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

### ActionRunAt (`Soneta.Business.Db.ActionRunAt`)
- `Auto` = 0 — Automatyczna
- `InMenu` = 1 — W menu
- `Default` = 2 — Domyślna dla zadania

### ActionType (`Soneta.Business.Db.ActionType`)
- `None` = 0 — Brak
- `RunWorker` = 1 — Uruchom worker
- `OpenObjectForm` = 2 — Otwórz formularz
- `ThrowException` = 3 — Zgłoś wyjątek
- `Email` = 4 — Wysyłka email

### DefinitionTypeEnum (`Soneta.Business.Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### DeleteOnRealized (`Soneta.Business.Db.DeleteOnRealized`)
- `BeforeValidDate` = 0 — Przed datą ważności
- `Never` = 1 — Nigdy
- `Always` = 2 — Zawsze

### MakeParentReadOnlyFor (`Soneta.Business.Db.MakeParentReadOnlyFor`)
- `None` = 0 — Dla nikogo
- `AnyExceptOwner` = 1 — Dla wszystkich poza właścicielem
- `Any` = 2 — Dla wszystkich

### MultiTaskType (`Soneta.Business.Db.MultiTaskType`)
- `NoMultiTask` = 0 — Nie
- `ByGetTaskUsers` = 1 — Wg użytkowników
- `ByGetSysNotifications` = 2 — Wg powiadomień

### NotificationType (`Soneta.Business.Db.NotificationType`)
- `None` = 0 — Brak
- `BeforeStart` = 1 — Przed rozpoczęciem
- `BeforeEnd` = 2 — Przed zakończeniem
- `Expression` = 3 — Wyrażenie

### ProcessManagementVisibilityType (`Soneta.Business.Db.ProcessManagementVisibilityType`)
- `ShowBoth` = 0 — Wyświetlaj / Wyświetlaj
- `ShowPanelHidePage` = 1 — Wyświetlaj / Nie wyświetlaj
- `HidePanelShowPage` = 2 — Nie wyświetlaj / Wyświetlaj
- `HideBoth` = 3 — Nie wyświetlaj / Nie wyświetlaj

### TaskEndTypeEnum (`Soneta.Business.Db.TaskEndTypeEnum`)
- `WFTransitions` = 0 — Przez warunki (tranzycje)
- `None` = 1 — Nie powoduje wymuszenia zakończenia procesu
- `Workflow` = 2 — Powoduje wymuszenie zakończenia całego procesu

### TaskInterfaceModeEnum (`Soneta.Business.Db.TaskInterfaceModeEnum`)
- `Default` = 0 — Domyślny
- `SelectMode` = 1 — Lista
- `WizardMode` = 2 — Przyciski (Zapisz i zamknij)
- `WizardModeSave` = 3 — Przyciski (Zapisz)

### TaskOperatorType (`Soneta.Business.Db.TaskOperatorType`)
- `Current` = 0 — Aktualny
- `Manual` = 1 — Wybrany
- `Created` = 2 — Tworzący dokument
- `Modified` = 3 — Modyfikujący dokument
- `Expression` = 4 — Wyrażenie określające operatora
- `Role` = 5 — Rola

### TaskStartPointTypeEnum (`Soneta.Business.Db.TaskStartPointTypeEnum`)
- `NoStartPoint` = 0 — Zadanie inne niż początkowe
- `Automatic` = 1 — Zadanie uruchamiane automatycznie
- `InWorkflowPanel` = 2 — Zadanie uruchamiane w panelu workflow
- `InDocumentMenu` = 4 — Zadanie uruchamiane w menu
- `Subprocess` = 8 — Zadanie początkowe podprocesu

### VerifierCheckType (`Soneta.Business.Db.VerifierCheckType`)
- `NotRequired` = -1 — Nie wymagaj
- `Warning` = 0 — Ostrzegaj
- `Required` = 1 — Wymagaj
