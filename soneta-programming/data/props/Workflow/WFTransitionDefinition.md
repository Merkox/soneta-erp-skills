# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFTransitionDefinition`
Nazwa tabeli: `WFTransitionDefs`
Tytuł: Wzorce tranzycji
Opis: Wzorzec (szablon) tranzycji definiujący reguły przejścia między krokami procesu workflow. Zawiera algorytmy walidacji (Check) i akcji (Action), flagę decyzji użytkownika oraz domyślność tranzycji. Wzorce mogą być współdzielone między różnymi definicjami procesów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWfPlugInItemReferenceHost`

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActionCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Algorytm metody Action | Określa algorytm metody Action |
| CheckCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Algorytm metody Check | Określa algorytm metody Check |
| CheckCode.Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| CheckCode.CodeUi | `string` |  |  |  |
| CheckCode.CodeUiRoslyn | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| ClassName | `string` |  |  |  |
| DataType | `System.Type` |  |  |  |
| DefinitionType | `Soneta.Business.Db.DefinitionTypeEnum` | bazodanowe, enum | Tryb edycji | Określa tryb edycji definicji workflow |
| FormattedName | `string` | bazodanowe | Nazwa formatowana | Ogólne |
| Info | `string` |  |  |  |
| IsDefaultTransition | `bool` | bazodanowe | Domyślna tranzycja | Określa czy tranzycja jest domyślna |
| IsPageVisible | `bool` |  |  |  |
| IsReadOnlyCode | `string` |  | Kod algorytmu metody IsReadOnly | Kod algorytmu kalkulatora realizacji zadania |
| IsRealizedCode | `string` |  | Kod algorytmu metody IsRealized | Kod algorytmu kalkulatora realizacji zadania |
| IsSingleInstance | `bool` | bazodanowe | Złączenie | Określa czy definicja tranzycji jest powiązana ze złączeniem |
| IsSubprocess | `bool` | bazodanowe | Podproces | Określa czy definicja tranzycji jest powiązana z podprocesem |
| IsUserDecision | `bool` | bazodanowe | Decyzja użytownika | Określa czy dalsze kroki zależne są od decycji użytkownika |
| IsVisibleCode | `string` |  | Kod algorytmu metody IsVisible | Kod algorytmu kalkulatora realizacji zadania |
| Name | `string` | bazodanowe | Nazwa | Nazwa tranzycji |
| ParentType | `string` | bazodanowe | Typ obiektu definicji elementu tranzycji | Określa typ obiektu definicji elementu tranzycji |
| PlugIns | `Soneta.Business.LpSubTable<Soneta.Workflow.Config.WfPlugInItemReference>` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SourceCode | `string` |  |  |  |
| SourceTask | `Soneta.Workflow.Enums.WFDefItemCategory` | enum | Zadanie źródłowe |  |
| Statement | `Soneta.Business.MemoText` | bazodanowe | Kod algorytmu | Kod algorytmu kalkulatora realizacji zadania |
| WFTransitions | `Soneta.Business.SubTable<Soneta.Workflow.Config.WFTransition>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Soneta.Business.Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### WFDefItemCategory (`Soneta.Workflow.Enums.WFDefItemCategory`)
- `StartPoint` = 0 — Zadanie początkowe
- `Task` = 1 — Zadanie
- `EndPoint` = 2 — Zadanie końcowe
- `Subprocess` = 3 — Wywołanie podprocesu
- `SingleInstance` = 4 — Zadania ze złączeniem
