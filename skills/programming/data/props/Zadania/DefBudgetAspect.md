# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.DefBudgetAspect`
Nazwa tabeli: `DefBudgetAspects`
Tytuł: Perspektywa realizacji
Opis: Definicja perspektywy realizacji budżetu, np. planowanie, memoriał, płatność. Określa źródło danych, algorytm wyliczania oraz symbol i nazwę etapu służącego do analizy budżetowej.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `BudgetType` (`Soneta.Zadania.Budzetowanie.TypObrotuBudzetu`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorithm | `bool` | bazodanowe |  | Określa czy istnieje algorytm. |
| BudgetType | `Soneta.Zadania.Budzetowanie.TypObrotuBudzetu` (enum) | bazodanowe, tylko-odczyt, selektor | Typ perspektywy realizacji |  |
| Code | `MemoText` | bazodanowe, podlista | Kod | Kod |
| CodeEditorSource | `Compiler.ICodeEditorSource` |  |  |  |
| DataSource | `Soneta.Core.BudgetDataSource` (enum) | bazodanowe |  | Źródło danych. |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Description | `string` | bazodanowe | Opis | Opis definicji etapu realizacji. |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Lock | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje nie będą wyświetlane w liście wyboru. |
| Name | `string` | bazodanowe | Nazwa | Pełna nazwa definicji etapu realizacji. |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji wykorzystywana do wyszukiwania definicji oraz numeracji. |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `BudgetType`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Realizacja` | 0 | `Soneta.Zadania.Budzetowanie.Models.DefBudgetAspectRealization` | Realizacja |
| `Plan` | 1 | `Soneta.Zadania.Budzetowanie.Models.DefBudgetAspectPlanning` | Planowanie |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### BudgetDataSource (`Soneta.Core.BudgetDataSource`)
- `AggregatedAmounts` = 0 — Kwoty zagregowane
- `AnalyticalDescription` = 1 — Opis analityczny

### TypObrotuBudzetu (`Soneta.Zadania.Budzetowanie.TypObrotuBudzetu`)
- `Realizacja` = 0
- `Plan` = 1
