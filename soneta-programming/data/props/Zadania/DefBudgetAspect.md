# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.DefBudgetAspect`
Nazwa tabeli: `DefBudgetAspects`
Tytuł: Perspektywa realizacji
Opis: Definicja perspektywy realizacji budżetu, np. planowanie, memoriał, płatność. Określa źródło danych, algorytm wyliczania oraz symbol i nazwę etapu służącego do analizy budżetowej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorithm | `bool` | bazodanowe |  | Określa czy istnieje algorytm. |
| BudgetType | `Soneta.Zadania.Budzetowanie.TypObrotuBudzetu` | bazodanowe, enum | Typ perspektywy realizacji |  |
| Code | `Soneta.Business.MemoText` | bazodanowe | Kod | Kod |
| CodeEditorSource | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| DataSource | `Soneta.Core.BudgetDataSource` | bazodanowe, enum |  | Źródło danych. |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Description | `string` | bazodanowe | Opis | Opis definicji etapu realizacji. |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Lock | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje nie będą wyświetlane w liście wyboru. |
| Name | `string` | bazodanowe | Nazwa | Pełna nazwa definicji etapu realizacji. |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji wykorzystywana do wyszukiwania definicji oraz numeracji. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### BudgetDataSource (`Soneta.Core.BudgetDataSource`)
- `AggregatedAmounts` = 0 — Kwoty zagregowane
- `AnalyticalDescription` = 1 — Opis analityczny

### TypObrotuBudzetu (`Soneta.Zadania.Budzetowanie.TypObrotuBudzetu`)
- `Realizacja` = 0
- `Plan` = 1
