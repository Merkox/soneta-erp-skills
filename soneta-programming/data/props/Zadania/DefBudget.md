# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.DefBudget`
Nazwa tabeli: `DefBudgets`
Tytuł: Definicje budżetów
Opis: Szablon budżetu projektu określający źródła danych planowania i realizacji, sposób rozliczania, typ okresu oraz zarządzanie wersjami planów. Stanowi bazę konfiguracyjną dla tworzenia budżetów projektów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 2
- podlisty: 3
- subrowy: 0
- razem: 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `bool` |  |  |  |
| AnyBudgetsLinked | `bool` | tylko-odczyt |  |  |
| BillingMethod | `Soneta.Core.SposobRozliczania` (enum) | bazodanowe | Sposób rozliczania |  |
| BudgetParametersUnlocked | `bool` | bazodanowe | Możliwa modyfikacja parametrów budżetu |  |
| BudgetPeriods | `SubTable<Soneta.Zadania.Budzetowanie.BudgetPeriod>` | podlista |  |  |
| CentralVersionSupport | `bool` | bazodanowe | Obsługa centralnych wersji planów | Określa, czy wersje planów budżetów mogą być zarządzane centralnie. |
| Domyslna | `bool` |  |  |  |
| IsExtendedBudgeting | `bool` | tylko-odczyt |  |  |
| ItemPermissions | `bool` | bazodanowe | Uprawnienia do pozycji |  |
| ListLayoutsDistinguisher | `string` | bazodanowe | Wyróżnik układów list | Generuje unikalną nazwę listy na podstawie zadanych elementów składowych |
| Locked | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje budżetów nie będą wyświetlane w liście wyboru. |
| Name | `string` | bazodanowe | Nazwa | Pełna nazwa definicji budżetów. |
| Nazwa | `string` |  |  |  |
| OngoingSaves | `bool` | bazodanowe | Zapis pozycji budżetu na bieżąco | Jeśli możliwe, sesja zostanie zapisana najszybciej jak to możliwe. |
| PeriodType | `Soneta.Core.TypOkresu` (enum) | bazodanowe | Typ okresu budżetu |  |
| PlanVariants | `SubTable<Soneta.Zadania.Budzetowanie.PlanVariant>` | podlista |  |  |
| PlanningDataSource | `Soneta.Core.BudgetDataSource` (enum) | bazodanowe | Źródło danych dla planowania budżetu |  |
| ProjectBudgets | `SubTable<Soneta.Zadania.Budzetowanie.BudzetProjektu>` | podlista |  |  |
| RealizationDataSource | `Soneta.Core.BudgetDataSource` (enum) | bazodanowe | Źródło danych dla realizacji budżetu |  |
| SettlementVariant | `Soneta.Core.SettlementVariant` (enum) | bazodanowe | Wariant rozliczania | Wariant rozliczania. |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji budżetów. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### BudgetDataSource (`Soneta.Core.BudgetDataSource`)
- `AggregatedAmounts` = 0 — Kwoty zagregowane
- `AnalyticalDescription` = 1 — Opis analityczny

### SettlementVariant (`Soneta.Core.SettlementVariant`)
- `NoVerification` = 0 — Bez weryfikacji
- `InPeriodOrStage` = 1 — W okresie/etapie
- `CumulativeToPeriodOrStage` = 2 — Narastająco do okresu/etapu (od początku okresu do danego miesiąca/etapu)
- `InBudgetPeriod` = 3 — W całym okresie budżetowym (od początku do końca okresu budżetowego)

### SposobRozliczania (`Soneta.Core.SposobRozliczania`)
- `Narastająco` = 0 — Narastająco
- `DlaEtapów` = 1 — Dla etapów
- `DlaOkresów` = 2 — Dla okresów

### TypOkresu (`Soneta.Core.TypOkresu`)
- `Miesięczny` = 0 — Miesięczny
- `Kwartalny` = 1
- `Półroczny` = 2
- `Roczny` = 3
