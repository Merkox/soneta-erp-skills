# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.WersjaPlanu`
Nazwa tabeli: `WersjePlanu`
Tytuł: Wersje planu dla budżetu projektu
Opis: Konkretna wersja planu budżetowego projektu. Przechowuje numer, daty obowiązywania, status zatwierdzenia, okres planowania oraz powiązanie z wariantem planu i wersją centralną.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudzetProjektu | `Soneta.Zadania.Budzetowanie.BudzetProjektu` | bazodanowe |  | Budzet projektu. |
| Data | `Soneta.Types.Date` | bazodanowe | Data | Data dokumentu - wersji planu. |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data obowiązywania | Data obowiązywania - rozpoczęcie. |
| DefBudgetLinked | `Soneta.Zadania.Budzetowanie.DefBudget` |  |  |  |
| Definicja | `Soneta.Zadania.Budzetowanie.DefPlanVersion` | bazodanowe | Definicja wersji planu. |  |
| DefinicjaBudzetu | `Soneta.Zadania.Budzetowanie.DefBudget` | bazodanowe | Definicja budżetu | Definicja budżetu, do której przypisana jest Centralna wersja planu |
| Domyslna | `bool` | bazodanowe | Domyślna | Określa, że jest to domyślna wersja planu. |
| IsCentralVersionSupport | `bool` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa wersji planu | Krótka nazwa wersji planu. |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe | Numer wersji planu | Numer wersji planu. |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerWersjiCentralnej | `string` |  |  |  |
| OkresBudzetowy | `Soneta.Zadania.Budzetowanie.BudgetPeriod` | bazodanowe | Okres budżetowy | Okres budżetowy przypisany do wersji planu. |
| OkresPlanowania | `Soneta.Types.FromTo` | bazodanowe | Okres planowania | Określa, na jaki okres można nanosić zapisy planowane na danej wersji planów. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis wersji planu. |
| PlanVariantSymbol | `string` |  |  |  |
| PlanVersionManagement | `Soneta.Zadania.Budzetowanie.PlanVersionManagement` | bazodanowe, enum | Rodzaj zarządzania wersją planu | Określa, czy dana wersja planów jest lokalna czy centralna. |
| PlanVersionSourceService | `Soneta.Zadania.Budzetowanie.Services.PlanVersionSourceStrategyService` |  |  |  |
| PlanVersionStatus | `Soneta.Core.PlanVersionStatus` | enum |  |  |
| PlanVersionType | `Soneta.Core.PlanVersionType` | enum |  |  |
| StatusWersji | `Soneta.Core.PlanVersionStatus` | bazodanowe, enum | Status wersji planu. |  |
| SymbolBudzetu | `string` |  |  |  |
| SymbolOkresuBudzetowego | `string` |  |  |  |
| ValidityDate | `Soneta.Types.Date` |  |  |  |
| WariantPlanu | `Soneta.Zadania.Budzetowanie.PlanVariant` | bazodanowe | Wariant wersji planu. |  |
| WersjaCentralna | `Soneta.Zadania.Budzetowanie.WersjaPlanu` | bazodanowe | Wersja Centralna | Centralna wersja planu, do której przypisana jest lokalna wersja planu. |
| WersjePowiazane | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.WersjaPlanu>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PlanVersionStatus (`Soneta.Core.PlanVersionStatus`)
- `InProgress` = 0 — W przygotowaniu
- `Introduced` = 1 — Wprowadzona
- `Approved` = 2 — Zatwierdzona
- `Rejected` = 3 — Odrzucona

### PlanVersionType (`Soneta.Core.PlanVersionType`)
- `Basic` = 0 — Plan
- `Corrective` = 1 — Korekta planu

### PlanVersionManagement (`Soneta.Zadania.Budzetowanie.PlanVersionManagement`)
- `Local` = 0 — Wersja lokalna
- `Central` = 1 — Wersja centralna
