# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFTransition`
Nazwa tabeli: `WFTransitions`
Tytuł: Tranzycje
Opis: Konkretna tranzycja (przejście) w definicji procesu workflow łącząca zadanie źródłowe z docelowym. Zawiera warunki przejścia, algorytmy Check/Action, opcjonalny schemat generatora obiektów oraz konfigurację wielowariantowości i szybkiego dostępu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWFTransition`, `IWfPlugInItemReferenceHost`

- pola bazodanowe (zapisywalne): 16
- pola kalkulowane (zapisywalne): 11
- pola tylko-odczyt: 6
- podlisty: 5
- subrowy: 2
- razem: 40

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActionCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Algorytm metody Action | Określa algorytm metody Action |
| CheckCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Algorytm metody Check | Określa algorytm metody Check |
| CheckCode.Code | `MemoText` | bazodanowe, podlista |  |  |
| CheckCode.CodeUiRoslyn | `Compiler.ICodeEditorSource` |  |  |  |
| ClassName | `string` | tylko-odczyt |  |  |
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt | Tryb edycji | Określa tryb edycji definicji workflow |
| FileName | `string` | bazodanowe | Nazwa pliku | Nazwa pliku tranzycji |
| ForeColor | `string` | bazodanowe | Kolor |  |
| FromPoint | `System.Drawing.PointF` |  |  |  |
| Icon | `string` | bazodanowe | Ikona |  |
| IncompatibleWithSerialOperations | `bool` | bazodanowe | Niezgodna z operacjami seryjnymi | Niezgodna z operacjami seryjnymi |
| Info | `string` | tylko-odczyt |  |  |
| IsAdvanced | `bool` | tylko-odczyt | Czy definicja zaawansowana | Określa czy powiązana definicja workflow (dla Source lub Target) jest typu zaawansowanego |
| IsDefaultTransition | `bool` | bazodanowe | Domyślna tranzycja | Określa czy tranzycja jest domyślna |
| IsPageVisible | `bool` | tylko-odczyt |  |  |
| IsReadOnlyCode | `string` |  | Kod algorytmu metody IsReadOnly | Kod algorytmu kalkulatora realizacji zadania |
| IsRealizedCode | `string` |  | Kod algorytmu metody IsRealized | Kod algorytmu kalkulatora realizacji zadania |
| IsRealizedExpressionParent | `string` |  | Wyrażenie używane do budowy metody IsRealized | Wyrażenie używane do budowy metody IsRealized (dla task.Parent) |
| IsRealizedExpressionTask | `string` |  | Wyrażenie używane do budowy metody IsRealized | Wyrażenie używane do budowy metody IsRealized (dla zadania) |
| IsRealizedExpressionTransition | `string` |  | Wyrażenie używane do budowy metody IsRealized | Wyrażenie używane do budowy metody IsRealized (dla tranzycji) |
| IsUserDecision | `bool` | bazodanowe | Decyzja użytownika | Określa czy dalsze kroki zależne są od decycji użytkownika |
| IsVisibleCode | `string` |  | Kod algorytmu metody IsVisible | Kod algorytmu kalkulatora realizacji zadania |
| LP | `int` | bazodanowe | LP | Numer tranzycji |
| LinePoints | `System.Drawing.PointF[]` | podlista |  |  |
| Location | `System.Drawing.PointF` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa tranzycji |
| OGSchema | `Soneta.Workflow.Config.OGSchema` | bazodanowe | Definicja schematu generatora | Określa definicję schematu generatora obiektów |
| OperatorType | `Soneta.Workflow.Config.WFTransition.OperatorEnum` (enum) |  | Wyrażenie używane do budowy metody IsRealized | Typ operatora logicznego łączącego warunki |
| PlugIns | `LpSubTable<Soneta.Workflow.Config.WfPlugInItemReference>` | podlista |  |  |
| QuickAccess | `string` | bazodanowe | Szybki dostęp | Opis przycisku szybkiego dostepu |
| Source | `Db.TaskDefinition` | bazodanowe | Definicja zadania (źródłowa) | Definicja zadania powiązana z tranzycją (źródłowa) |
| SourceCode | `string` | tylko-odczyt |  |  |
| Statement | `MemoText` | bazodanowe, podlista | Kod algorytmu | Kod algorytmu kalkulatora realizacji zadania |
| Target | `Db.TaskDefinition` | bazodanowe | Definicja zadania (docelowa) | Definicja zadania powiązana z tranzycją (docelowa) |
| Tasks | `SubTable` | podlista |  |  |
| ToPoint | `System.Drawing.PointF` |  |  |  |
| VariantTypeName | `string` | bazodanowe | Typ tranzycji wielowariantowej | Typ tranzycji wielowariantowej |
| WFTransitionDefinition | `Soneta.Workflow.Config.WFTransitionDefinition` | bazodanowe | Opcjonalna definicja elementu tranzycji | Definicja elementu tranzycji powiązana z elementem tranzycji |
| WeakTransition | `bool` | bazodanowe | Tranzycja nie kończąca zadania | Tranzycja nie kończąca zadania |
| WfDefinition | `IWFDefinition` | bazodanowe, iface-ref | Definicja procesu | Określa definicję procesu |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WfDefinition | `IWFDefinition` | `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### OperatorEnum (`Soneta.Workflow.Config.WFTransition.OperatorEnum`)
- `Or` = 0
- `And` = 1
