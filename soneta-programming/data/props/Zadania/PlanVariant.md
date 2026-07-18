# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.PlanVariant`
Nazwa tabeli: `PlanVariants`
Tytuł: Warianty planów
Opis: Element szczegółowy definicji budżetu (DefBudget). Reprezentuje wariant planowania budżetu (np. optymistyczny, pesymistyczny) z przypisanymi definicjami wersji planów.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefBudget` → `DefBudget`
Selektor: pole `PlanVariantKind` (`Soneta.Zadania.Budzetowanie.PlanVariantKind`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefBudget | `Soneta.Zadania.Budzetowanie.DefBudget` | bazodanowe, tylko-odczyt, guided-parent |  | Definicja budżetu, z którą powiązany jest wariant planów |
| Locked | `bool` | bazodanowe | Zablokowany | Określa zablokowanie wariantu planów.  |
| Name | `string` | bazodanowe |  | Nazwa wariantu planów. |
| PlanVariantKind | `Soneta.Zadania.Budzetowanie.PlanVariantKind` (enum) | bazodanowe, tylko-odczyt, selektor | Rodzaj planu | Rodzaj planu. |
| PlanVariantRelations | `SubTable<Soneta.Zadania.Budzetowanie.PlanVariantRel>` | podlista |  |  |
| Symbol | `string` | bazodanowe |  | Symbol wariantu planów. |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `PlanVariantKind`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Basic` | 0 | `Soneta.Zadania.Budzetowanie.Models.PlanVariantBasic` |  |
| `Alternative` | 1 | `Soneta.Zadania.Budzetowanie.Models.PlanVariantAlternative` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PlanVariantKind (`Soneta.Zadania.Budzetowanie.PlanVariantKind`)
- `Basic` = 0 — Podstawowy
- `Alternative` = 1 — Alternatywny
