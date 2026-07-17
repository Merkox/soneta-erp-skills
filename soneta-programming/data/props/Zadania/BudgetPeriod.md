# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.BudgetPeriod`
Nazwa tabeli: `BudgetPeriods`
Tytuł: Okresy budżetowe
Opis: Element szczegółowy definicji budżetu (DefBudget). Wyznacza ramy czasowe budżetowania — okres obowiązywania oraz dozwolone zakresy planowania i rejestrowania realizacji.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowedPlanningPeriod | `Soneta.Types.FromTo` | bazodanowe |  | Dozwolony okres planowania. |
| AllowedRealizationPeriod | `Soneta.Types.FromTo` | bazodanowe |  | Dozwolony okres rejestrowania realizacji. |
| DefBudget | `Soneta.Zadania.Budzetowanie.DefBudget` | bazodanowe |  | Definicja budżetu, z którą powiązany jest okres budżetowy |
| Description | `string` | bazodanowe |  |  |
| IsExtendedBudgeting | `bool` |  |  |  |
| IsPlanningPeriodWarningActive | `bool` |  |  |  |
| Period | `Soneta.Types.FromTo` | bazodanowe |  | Otwarcie i zamkniecie okresu budżetowego. |
| Symbol | `string` | bazodanowe |  | Symbol okresu budżetowego. |
