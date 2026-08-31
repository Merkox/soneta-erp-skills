# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFTransitionDefinition`
Nazwa tabeli: `WFTransitionDefs`
Tytuł: Wzorce tranzycji
Opis: Wzorzec (szablon) tranzycji definiujący reguły przejścia między krokami procesu workflow. Zawiera algorytmy walidacji (Check) i akcji (Action), flagę decyzji użytkownika oraz domyślność tranzycji. Wzorce mogą być współdzielone między różnymi definicjami procesów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWfPlugInItemReferenceHost`
Selektor: pole `DefinitionType` (`Db.DefinitionTypeEnum`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActionCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Algorytm metody Action | Określa algorytm metody Action |
| CheckCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Algorytm metody Check | Określa algorytm metody Check |
| CheckCode.Code | `MemoText` | bazodanowe, podlista |  |  |
| CheckCode.CodeUiRoslyn | `Compiler.ICodeEditorSource` |  |  |  |
| ClassName | `string` | tylko-odczyt |  |  |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt, selektor | Tryb edycji | Określa tryb edycji definicji workflow |
| FormattedName | `string` | bazodanowe | Nazwa formatowana | Ogólne |
| Info | `string` | tylko-odczyt |  |  |
| IsDefaultTransition | `bool` | bazodanowe | Domyślna tranzycja | Określa czy tranzycja jest domyślna |
| IsPageVisible | `bool` | tylko-odczyt |  |  |
| IsReadOnlyCode | `string` |  | Kod algorytmu metody IsReadOnly | Kod algorytmu kalkulatora realizacji zadania |
| IsRealizedCode | `string` |  | Kod algorytmu metody IsRealized | Kod algorytmu kalkulatora realizacji zadania |
| IsSingleInstance | `bool` | bazodanowe, tylko-odczyt | Złączenie | Określa czy definicja tranzycji jest powiązana ze złączeniem |
| IsSubprocess | `bool` | bazodanowe | Podproces | Określa czy definicja tranzycji jest powiązana z podprocesem |
| IsUserDecision | `bool` | bazodanowe | Decyzja użytownika | Określa czy dalsze kroki zależne są od decycji użytkownika |
| IsVisibleCode | `string` |  | Kod algorytmu metody IsVisible | Kod algorytmu kalkulatora realizacji zadania |
| Name | `string` | bazodanowe | Nazwa | Nazwa tranzycji |
| ParentType | `string` | bazodanowe | Typ obiektu definicji elementu tranzycji | Określa typ obiektu definicji elementu tranzycji |
| PlugIns | `LpSubTable<Soneta.Workflow.Config.WfPlugInItemReference>` | podlista |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SourceCode | `string` | tylko-odczyt |  |  |
| SourceTask | `Soneta.Workflow.Enums.WFDefItemCategory` (enum) |  | Zadanie źródłowe |  |
| Statement | `MemoText` | bazodanowe, podlista | Kod algorytmu | Kod algorytmu kalkulatora realizacji zadania |
| WFTransitions | `SubTable<Soneta.Workflow.Config.WFTransition>` | podlista |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `DefinitionType`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Standard` | 0 | `Soneta.Workflow.Config.WFTransitionDefinition` |  |
| `Engine` | 1 | `Soneta.Workflow.Config.WFTransitionDefinitionExtend` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### WFDefItemCategory (`Soneta.Workflow.Enums.WFDefItemCategory`)
- `StartPoint` = 0 — Zadanie początkowe
- `Task` = 1 — Zadanie
- `EndPoint` = 2 — Zadanie końcowe
- `Subprocess` = 3 — Wywołanie podprocesu
- `SingleInstance` = 4 — Zadania ze złączeniem
