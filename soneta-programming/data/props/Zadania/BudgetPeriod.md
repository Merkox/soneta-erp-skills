# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.BudgetPeriod`
Nazwa tabeli: `BudgetPeriods`
Tytuł: Okresy budżetowe
Opis: Element szczegółowy definicji budżetu (DefBudget). Wyznacza ramy czasowe budżetowania — okres obowiązywania oraz dozwolone zakresy planowania i rejestrowania realizacji.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowedPlanningPeriod | `FromTo` | bazodanowe, podlista |  | Dozwolony okres planowania. |
| AllowedRealizationPeriod | `FromTo` | bazodanowe, podlista |  | Dozwolony okres rejestrowania realizacji. |
| DefBudget | `Soneta.Zadania.Budzetowanie.DefBudget` | bazodanowe, tylko-odczyt |  | Definicja budżetu, z którą powiązany jest okres budżetowy |
| Description | `string` | bazodanowe |  |  |
| IsExtendedBudgeting | `bool` | tylko-odczyt |  |  |
| IsPlanningPeriodWarningActive | `bool` | tylko-odczyt |  |  |
| Period | `FromTo` | bazodanowe, podlista |  | Otwarcie i zamkniecie okresu budżetowego. |
| Symbol | `string` | bazodanowe |  | Symbol okresu budżetowego. |
