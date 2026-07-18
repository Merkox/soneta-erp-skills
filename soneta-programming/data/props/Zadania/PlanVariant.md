# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.PlanVariant`
Nazwa tabeli: `PlanVariants`
Tytuł: Warianty planów
Opis: Element szczegółowy definicji budżetu (DefBudget). Reprezentuje wariant planowania budżetu (np. optymistyczny, pesymistyczny) z przypisanymi definicjami wersji planów.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefBudget` → `DefBudget`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefBudget | `Soneta.Zadania.Budzetowanie.DefBudget` | bazodanowe, tylko-odczyt, guided-parent |  | Definicja budżetu, z którą powiązany jest wariant planów |
| Locked | `bool` | bazodanowe | Zablokowany | Określa zablokowanie wariantu planów.  |
| Name | `string` | bazodanowe |  | Nazwa wariantu planów. |
| PlanVariantKind | `Soneta.Zadania.Budzetowanie.PlanVariantKind` (enum) | bazodanowe, tylko-odczyt | Rodzaj planu | Rodzaj planu. |
| PlanVariantRelations | `SubTable<Soneta.Zadania.Budzetowanie.PlanVariantRel>` | podlista |  |  |
| Symbol | `string` | bazodanowe |  | Symbol wariantu planów. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PlanVariantKind (`Soneta.Zadania.Budzetowanie.PlanVariantKind`)
- `Basic` = 0 — Podstawowy
- `Alternative` = 1 — Alternatywny
