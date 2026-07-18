# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.DefBudgetCategoryRelation`
Nazwa tabeli: `DefBudgetCatRel`
Tytuł: Relacje kategorii budżetu
Opis: Element szczegółowy kategorii budżetu (DefBudgetCategory). Definiuje powiązania między kategoriami budżetowymi, np. następstwo memoriału i płatności.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudgetCategory | `Soneta.Zadania.Budzetowanie.DefBudgetCategory` | bazodanowe, tylko-odczyt | Definicja kategorii budżetu |  |
| BudgetCategoryRelation | `Soneta.Zadania.Budzetowanie.DefBudgetCategory` | bazodanowe | Relacja do definicji kategorii budżetu |  |
