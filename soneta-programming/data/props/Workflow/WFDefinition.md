# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFDefinition`
Nazwa tabeli: `WFDefs`
Tytuł: Definicja procesów
Opis: Główna tabela konfiguracyjna modułu Workflow przechowująca definicje procesów biznesowych. Określa strukturę procesu, jego numerację, wersjonowanie oraz tryb edycji diagramu. Na podstawie definicji tworzone są konkretne instancje procesów (WFWorkflow).
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IWFDefinition`, `ICodeFileHost`, `IWfPlugInReferenceHost`, `ISysNotificationReference`, `IWizardReferenceHost`

- pola bazodanowe: 32
- pola kalkulowane (z klas biznesowych): 26

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfigClass | `string` | bazodanowe | Klasa do zapisu konfiguracji | Klasa z definicją obiektu przechowującego statyczną konfigrację. |
| DataCode | `Soneta.Business.MemoText` | bazodanowe |  |  |
| DbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja zarządcy | Definicja rekordu zarządzającego procesem. |
| DbTupleInterface | `string` | bazodanowe | Definicja interfejsu zarządcy | Interfejs rekordu zarządzającego procesem. |
| DefinitionType | `Soneta.Business.Db.DefinitionTypeEnum` | bazodanowe, enum | Tryb edycji | Określa tryb edycji definicji workflow |
| DependentEngine | `bool` | bazodanowe | Jednozakładkowy zależny |  |
| DependentStandard | `bool` |  |  |  |
| Description | `string` | bazodanowe | Opis | Opis definicji |
| EditType | `Soneta.Workflow.Enums.EditTypeEnum` | bazodanowe, enum | Typ definicji | Określa typ definicji workflow |
| EditTypeExt | `Soneta.Workflow.Enums.EditTypeEnum` | enum |  |  |
| EditorMode | `string` |  |  |  |
| EngineClassName | `string` |  |  |  |
| EngineCode | `Soneta.Business.MemoText` | bazodanowe |  |  |
| EngineCodeEditorSource | `Soneta.Business.Compiler.ICodeEditorSource` |  | Kod algorytmu metody Engine | Kod engine |
| FeautureDefs | `Soneta.Business.SubTable` |  |  |  |
| Files | `Soneta.Business.SubTable<Soneta.Core.CodeFile>` |  |  |  |
| FirstParentType | `string` |  |  |  |
| FirstParentTypeModuleName | `string` |  |  |  |
| HideTaskNameInTransitionComboBox | `bool` |  | Ukryj nazwę zadania docelowego dla tranzycji | Określa czy w sekcjach z wyborem tranzycji w procesie będzie ukryta nazwa kolejnego zadania |
| Host | `Soneta.Business.IWFDefinitionHost` | bazodanowe, iface-ref |  |  |
| InterfaceMode | `Soneta.Business.Db.TaskInterfaceModeEnum` | bazodanowe, enum | Tryb wyboru ścieżki | Tryb wybór ścieżki w procesie |
| IsDeployed | `bool` | bazodanowe | Tryb wdrożenia | Określa tryb modelowania/wdrożenia |
| IsDiagramEditedInHtml | `bool` | bazodanowe | Diagram edytowany w HTML | Określa czy diagram jest edytowany w wersji HTML |
| ItemDescriptionRels | `Soneta.Business.SubTable<Soneta.Workflow.Config.WFItemDescriptionRel>` |  |  |  |
| ItemDescriptions | `Soneta.Business.SubTable<Soneta.Workflow.Config.WFItemDescription>` |  |  |  |
| Locked | `bool` | bazodanowe | Definicja zablokowana | Określa czy definicja jest zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji |
| Namespace | `string` |  |  |  |
| NotificationCategory | `Soneta.Business.NotificationCategory` | bazodanowe | Notification Category | Kategoria powiadomienia |
| Numerator | `Soneta.Core.DefinicjaNumeracji` | bazodanowe | Numeracja | Określa sposób numerowania definicji |
| Numerator.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numerator.PodczasZapisu | `bool` |  |  |  |
| Numerator.Separator | `string` | bazodanowe |  |  |
| Numerator.Wzor | `string` | bazodanowe |  |  |
| PlugIns | `Soneta.Business.SubTable<Soneta.Workflow.Config.WfPlugInReference>` |  |  |  |
| PrevVersionGuid | `System.Guid` | bazodanowe | Guid wersji definicji procesu | Określa Guid wersji definicji procesu (do jakiego szablonu należy) |
| ProcessRoles | `Soneta.Business.LpSubTable<Soneta.Workflow.Config.WFProcessRole>` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SerializedDiagram | `Soneta.Business.MemoText` | bazodanowe | Serializowane dane diagramu | Określa serializowane dane diagramu |
| SingleWorkflowInstance | `bool` | bazodanowe | Pojedyncza instancja procesu | Określa czy definicja workflow pozwala na wiele instancji procesu |
| StartTaskDefinitionTableName | `string` |  |  |  |
| StartTaskWizardDefinition | `Soneta.Business.Db.Wizard.WizardDefinition` |  |  |  |
| StartTaskWizardStepsTableNames | `System.Collections.Generic.IEnumerable<string>` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji |
| TaskDefs | `Soneta.Business.SubTable<Soneta.Business.Db.TaskDefinition>` |  | Powiązane definicje zadań | Zwraca listę definicji zadań powiązanych z definicją procesu Workflow |
| TaskNameInTransitionVisibility | `Soneta.Business.Db.TaskNameVisibility` | bazodanowe, enum | Widoczność nazwy zadania docelowego dla tranzycji | Określa czy w sekcjach z wyborem tranzycji w procesie będzie widoczna nazwa kolejnego zadania |
| Transitions | `Soneta.Business.SubTable<Soneta.Workflow.Config.WFTransition>` |  |  |  |
| Version | `Soneta.Workflow.Config.WFDefVersion` | bazodanowe | Wersja definicji procesu | Określa wersję definicji procesu |
| Version.IsEmpty | `bool` |  |  |  |
| Version.Major | `int` | bazodanowe | Wersja główna | Określa wersję główną |
| Version.Minor | `int` | bazodanowe | Wersja mała | Określa wersję małą |
| VersionAsString | `string` |  |  |  |
| WFWorkflows | `Soneta.Business.SubTable<Soneta.Workflow.WFWorkflow>` |  |  |  |
| WizardsRef | `Soneta.Business.LpSubTable<Soneta.Business.Db.Wizard.WizardReference>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IWFDefinitionHost` | `DefKoresp`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Soneta.Business.Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### TaskInterfaceModeEnum (`Soneta.Business.Db.TaskInterfaceModeEnum`)
- `Default` = 0 — Domyślny
- `SelectMode` = 1 — Lista
- `WizardMode` = 2 — Przyciski (Zapisz i zamknij)
- `WizardModeSave` = 3 — Przyciski (Zapisz)

### TaskNameVisibility (`Soneta.Business.Db.TaskNameVisibility`)
- `None` = 0
- `ConversionShow` = 1 — Pokazuj - Wartość ustawiana TYLKO podczas konwersji procesu
- `ClientShow` = 2 — Pokazuj - Wartość ustawiana TYLKO przez klienta z interfejsu
- `ConversionHide` = 3 — Ukryj - Wartość ustawiana TYLKO podczas konwersji procesu
- `ClientHide` = 4 — Ukryj - Wartość ustawiana TYLKO przez klienta z interfejsu

### EditTypeEnum (`Soneta.Workflow.Enums.EditTypeEnum`)
- `Simple` = 0 — Uproszczony
- `Extended` = 1 — Rozszerzony
- `Advanced` = 2 — Zaawansowany
- `DependentOn` = 3 — Zależny
- `AdvancedEngine` = 4 — Zaawansowany jednozakładkowy
