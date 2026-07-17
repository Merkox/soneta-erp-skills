# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFDefItem`
Nazwa tabeli: `WFDefItems`
Tytuł: Wzorce definicji zadań
Opis: Wzorzec (szablon) zadania używany w definicjach procesów workflow. Określa typ akcji, elementy startowe i końcowe, powiązania z kreatorami oraz kod algorytmu realizacji. Wzorce mogą być wielokrotnie wykorzystywane w różnych definicjach procesów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWFDefItem`, `IWfPlugInItemReferenceHost`

- pola bazodanowe: 20
- pola kalkulowane (z klas biznesowych): 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActionCode | `string` |  | Kod algorytmu metody Action | Kod algorytmu kalkulatora definicji elementu workflow inicjujący metodę Action na definicji zadania |
| ActionType | `Soneta.Workflow.Enums.ActionTypeEnum` | bazodanowe, enum | Typ akcji | Typ akcji |
| CalcNodeDescriptionEditorCode | `string` |  | Kod algorytmu metody CalcNodeDescription | Kod algorytmu kalkulatora definicji elementu workflow inicjujący metodę CalcNodeDescription na definicji zadania |
| CalcNodeDescriptionViewerCode | `string` |  | Kod algorytmu metody CalcNodeDescription | Kod algorytmu kalkulatora definicji elementu workflow inicjujący metodę CalcNodeDescription na definicji zadania |
| Category | `Soneta.Workflow.Enums.WFDefItemCategory` | enum |  |  |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe | Kod algorytmu | Kod algorytmu kalkulatora definicji elementu workflow |
| DataType | `System.Type` |  |  |  |
| DefinitionType | `Soneta.Business.Db.DefinitionTypeEnum` | bazodanowe, enum | Tryb edycji | Określa tryb edycji definicji workflow |
| DefinitionWizard | `Soneta.Business.Db.Wizard.WizardDefinition` | bazodanowe | Definicja kreatora | Definicja kreatora powiązana z definicją elementu workflow |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis definicji elementu workflow |
| EndType | `Soneta.Workflow.Enums.EndTypeEnum` | bazodanowe, enum | Typ elementu końcowego | Określa typ elementu końcowego definicja elementu workflow |
| FormattedName | `string` | bazodanowe | Nazwa formatowana | Ogólne |
| HasIcon | `bool` |  |  |  |
| Icon | `Soneta.Business.MemoBin` | bazodanowe |  |  |
| Info | `string` |  |  |  |
| IsEnableCode | `string` |  | Kod algorytmu metody IsEnable | Kod algorytmu kalkulatora definicji elementu workflow inicjujący metodę IsEnable na definicji zadania |
| IsPageVisible | `bool` |  |  |  |
| IsSingleInstance | `bool` | bazodanowe | Złączenie | Określa czy kontrolka definiuje zadanie typu złączenie |
| IsStart | `bool` | bazodanowe | Element startowy | Czy definicja zadania jest początkiem procesu workflow |
| IsSubprocess | `bool` | bazodanowe | Podproces | Określa czy definicja zadania jest podprocesem |
| IsVisibleInList | `bool` | bazodanowe | Widoczność na liście | Określa czy definicja zadania typu Widoczny na liście |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji elementu workflow |
| ObjTable | `Soneta.Business.Table` |  |  |  |
| ParentType | `string` | bazodanowe | Typ obiektu elementu workflow | Określa typ obiektu elementu workflow |
| PlugIns | `Soneta.Business.LpSubTable<Soneta.Workflow.Config.WfPlugInItemReference>` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| TaskDefs | `Soneta.Business.SubTable` |  |  |  |
| UseDefaultIcon | `bool` | bazodanowe | Domyślna ikona | Określa czy użyć domyślnej ikony. |
| Wizard | `Soneta.Business.Db.Wizard.WizardDefinition` | bazodanowe | Definicja kreatora inicjującego definicję zadania | Definicja kreatora inicjującego definicję zadania powiązana z definicją elementu workflow |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Soneta.Business.Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### ActionTypeEnum (`Soneta.Workflow.Enums.ActionTypeEnum`)
- `Auto` = 0 — Automatyczna
- `Manual` = 1 — Manualna
- `Any` = 2 — Dowolna

### EndTypeEnum (`Soneta.Workflow.Enums.EndTypeEnum`)
- `WFTransitions` = 0 — Przez warunki (tranzycje)
- `None` = 1 — Nie powoduje wymuszenia zakończenia procesu
- `Workflow` = 2 — Powoduje wymuszenie zakończenia całego procesu

### WFDefItemCategory (`Soneta.Workflow.Enums.WFDefItemCategory`)
- `StartPoint` = 0 — Zadanie początkowe
- `Task` = 1 — Zadanie
- `EndPoint` = 2 — Zadanie końcowe
- `Subprocess` = 3 — Wywołanie podprocesu
- `SingleInstance` = 4 — Zadania ze złączeniem
