# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.DefBudgetCategoryRelation`
Nazwa tabeli: `DefBudgetCatRel`
Tytuł: Relacje kategorii budżetu
Opis: Element szczegółowy kategorii budżetu (DefBudgetCategory). Definiuje powiązania między kategoriami budżetowymi, np. następstwo memoriału i płatności.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudgetCategory | `Soneta.Zadania.Budzetowanie.DefBudgetCategory` | bazodanowe | Definicja kategorii budżetu |  |
| BudgetCategoryRelation | `Soneta.Zadania.Budzetowanie.DefBudgetCategory` | bazodanowe | Relacja do definicji kategorii budżetu |  |
