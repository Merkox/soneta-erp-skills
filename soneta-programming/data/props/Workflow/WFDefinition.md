# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFDefinition`
Nazwa tabeli: `WFDefs`
Tytuł: Definicja procesów
Opis: Główna tabela konfiguracyjna modułu Workflow przechowująca definicje procesów biznesowych. Określa strukturę procesu, jego numerację, wersjonowanie oraz tryb edycji diagramu. Na podstawie definicji tworzone są konkretne instancje procesów (WFWorkflow).
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IWFDefinition`, `ICodeFileHost`, `IWfPlugInReferenceHost`, `ISysNotificationReference`, `IWizardReferenceHost`
Selektor: pole `DefinitionType` (`Db.DefinitionTypeEnum`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfigClass | `string` | bazodanowe | Klasa do zapisu konfiguracji | Klasa z definicją obiektu przechowującego statyczną konfigrację. |
| DataCode | `MemoText` | bazodanowe, podlista |  |  |
| DbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja zarządcy | Definicja rekordu zarządzającego procesem. |
| DbTupleInterface | `string` | bazodanowe | Definicja interfejsu zarządcy | Interfejs rekordu zarządzającego procesem. |
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt, selektor | Tryb edycji | Określa tryb edycji definicji workflow |
| DependentEngine | `bool` | bazodanowe | Jednozakładkowy zależny |  |
| DependentStandard | `bool` |  |  |  |
| Description | `string` | bazodanowe | Opis | Opis definicji |
| EditType | `Soneta.Workflow.Enums.EditTypeEnum` (enum) | bazodanowe | Typ definicji | Określa typ definicji workflow |
| EditTypeExt | `Soneta.Workflow.Enums.EditTypeEnum` (enum) |  |  |  |
| EditorMode | `string` | tylko-odczyt |  |  |
| EngineClassName | `string` | tylko-odczyt |  |  |
| EngineCode | `MemoText` | bazodanowe, podlista |  |  |
| EngineCodeEditorSource | `Compiler.ICodeEditorSource` |  | Kod algorytmu metody Engine | Kod engine |
| FeautureDefs | `SubTable` | podlista |  |  |
| Files | `SubTable<Soneta.Core.CodeFile>` | podlista |  |  |
| FirstParentType | `string` |  |  |  |
| FirstParentTypeModuleName | `string` | tylko-odczyt |  |  |
| HideTaskNameInTransitionComboBox | `bool` |  | Ukryj nazwę zadania docelowego dla tranzycji | Określa czy w sekcjach z wyborem tranzycji w procesie będzie ukryta nazwa kolejnego zadania |
| Host | `IWFDefinitionHost` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| InterfaceMode | `Db.TaskInterfaceModeEnum` (enum) | bazodanowe | Tryb wyboru ścieżki | Tryb wybór ścieżki w procesie |
| IsDeployed | `bool` | bazodanowe | Tryb wdrożenia | Określa tryb modelowania/wdrożenia |
| IsDiagramEditedInHtml | `bool` | bazodanowe | Diagram edytowany w HTML | Określa czy diagram jest edytowany w wersji HTML |
| ItemDescriptionRels | `SubTable<Soneta.Workflow.Config.WFItemDescriptionRel>` | podlista |  |  |
| ItemDescriptions | `SubTable<Soneta.Workflow.Config.WFItemDescription>` | podlista |  |  |
| Locked | `bool` | bazodanowe | Definicja zablokowana | Określa czy definicja jest zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji |
| Namespace | `string` | tylko-odczyt |  |  |
| NotificationCategory | `NotificationCategory` | bazodanowe | Notification Category | Kategoria powiadomienia |
| Numerator | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe | Numeracja | Określa sposób numerowania definicji |
| Numerator.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numerator.PodczasZapisu | `bool` |  |  |  |
| Numerator.Separator | `string` | bazodanowe |  |  |
| Numerator.Wzor | `string` | bazodanowe |  |  |
| PlugIns | `SubTable<Soneta.Workflow.Config.WfPlugInReference>` | podlista |  |  |
| PrevVersionGuid | `System.Guid` | bazodanowe, tylko-odczyt | Guid wersji definicji procesu | Określa Guid wersji definicji procesu (do jakiego szablonu należy) |
| ProcessRoles | `LpSubTable<Soneta.Workflow.Config.WFProcessRole>` | podlista |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SerializedDiagram | `MemoText` | bazodanowe, podlista | Serializowane dane diagramu | Określa serializowane dane diagramu |
| SingleWorkflowInstance | `bool` | bazodanowe | Pojedyncza instancja procesu | Określa czy definicja workflow pozwala na wiele instancji procesu |
| StartTaskDefinitionTableName | `string` | tylko-odczyt |  |  |
| StartTaskWizardDefinition | `Db.Wizard.WizardDefinition` | tylko-odczyt |  |  |
| StartTaskWizardStepsTableNames | `System.Collections.Generic.IEnumerable<string>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji |
| TaskDefs | `SubTable<Db.TaskDefinition>` | podlista | Powiązane definicje zadań | Zwraca listę definicji zadań powiązanych z definicją procesu Workflow |
| TaskNameInTransitionVisibility | `Db.TaskNameVisibility` (enum) | bazodanowe | Widoczność nazwy zadania docelowego dla tranzycji | Określa czy w sekcjach z wyborem tranzycji w procesie będzie widoczna nazwa kolejnego zadania |
| Transitions | `SubTable<Soneta.Workflow.Config.WFTransition>` | podlista |  |  |
| Version | `Soneta.Workflow.Config.WFDefVersion` (subrow) | bazodanowe | Wersja definicji procesu | Określa wersję definicji procesu |
| Version.IsEmpty | `bool` | tylko-odczyt |  |  |
| Version.Major | `int` | bazodanowe, tylko-odczyt | Wersja główna | Określa wersję główną |
| Version.Minor | `int` | bazodanowe, tylko-odczyt | Wersja mała | Określa wersję małą |
| VersionAsString | `string` | tylko-odczyt |  |  |
| WFWorkflows | `SubTable<Soneta.Workflow.WFWorkflow>` | podlista |  |  |
| WizardsRef | `LpSubTable<Db.Wizard.WizardReference>` | podlista |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `DefinitionType`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Standard` | 0 | `Soneta.Workflow.Config.WFDefinition` |  |
| `Engine` | 1 | `Soneta.Workflow.Config.WFDefinitionExtend` | Definicja procesu (jednozakładkowego) |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IWFDefinitionHost` | `DefKoresp`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### TaskInterfaceModeEnum (`Db.TaskInterfaceModeEnum`)
- `Default` = 0 — Domyślny
- `SelectMode` = 1 — Lista
- `WizardMode` = 2 — Przyciski (Zapisz i zamknij)
- `WizardModeSave` = 3 — Przyciski (Zapisz)

### TaskNameVisibility (`Db.TaskNameVisibility`)
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
