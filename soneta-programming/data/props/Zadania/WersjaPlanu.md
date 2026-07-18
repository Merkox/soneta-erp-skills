# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.WersjaPlanu`
Nazwa tabeli: `WersjePlanu`
Tytuł: Wersje planu dla budżetu projektu
Opis: Konkretna wersja planu budżetowego projektu. Przechowuje numer, daty obowiązywania, status zatwierdzenia, okres planowania oraz powiązanie z wariantem planu i wersją centralną.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

- pola bazodanowe (zapisywalne): 10
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 15
- podlisty: 5
- subrowy: 1
- razem: 32

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudzetProjektu | `Soneta.Zadania.Budzetowanie.BudzetProjektu` | bazodanowe |  | Budzet projektu. |
| Data | `Date` | bazodanowe | Data | Data dokumentu - wersji planu. |
| DataOd | `Date` | bazodanowe | Data obowiązywania | Data obowiązywania - rozpoczęcie. |
| DefBudgetLinked | `Soneta.Zadania.Budzetowanie.DefBudget` | tylko-odczyt |  |  |
| Definicja | `Soneta.Zadania.Budzetowanie.DefPlanVersion` | bazodanowe, tylko-odczyt | Definicja wersji planu. |  |
| DefinicjaBudzetu | `Soneta.Zadania.Budzetowanie.DefBudget` | bazodanowe | Definicja budżetu | Definicja budżetu, do której przypisana jest Centralna wersja planu |
| Domyslna | `bool` | bazodanowe, tylko-odczyt | Domyślna | Określa, że jest to domyślna wersja planu. |
| IsCentralVersionSupport | `bool` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa wersji planu | Krótka nazwa wersji planu. |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe | Numer wersji planu | Numer wersji planu. |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerWersjiCentralnej | `string` | tylko-odczyt |  |  |
| OkresBudzetowy | `Soneta.Zadania.Budzetowanie.BudgetPeriod` | bazodanowe | Okres budżetowy | Okres budżetowy przypisany do wersji planu. |
| OkresPlanowania | `FromTo` | bazodanowe, podlista | Okres planowania | Określa, na jaki okres można nanosić zapisy planowane na danej wersji planów. |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis wersji planu. |
| PlanVariantSymbol | `string` | tylko-odczyt |  |  |
| PlanVersionManagement | `Soneta.Zadania.Budzetowanie.PlanVersionManagement` (enum) | bazodanowe, tylko-odczyt | Rodzaj zarządzania wersją planu | Określa, czy dana wersja planów jest lokalna czy centralna. |
| PlanVersionSourceService | `Soneta.Zadania.Budzetowanie.Services.PlanVersionSourceStrategyService` | tylko-odczyt |  |  |
| PlanVersionStatus | `Soneta.Core.PlanVersionStatus` (enum) | tylko-odczyt |  |  |
| PlanVersionType | `Soneta.Core.PlanVersionType` (enum) | tylko-odczyt |  |  |
| StatusWersji | `Soneta.Core.PlanVersionStatus` (enum) | bazodanowe | Status wersji planu. |  |
| SymbolBudzetu | `string` | tylko-odczyt |  |  |
| SymbolOkresuBudzetowego | `string` | tylko-odczyt |  |  |
| ValidityDate | `Date` | tylko-odczyt |  |  |
| WariantPlanu | `Soneta.Zadania.Budzetowanie.PlanVariant` | bazodanowe, tylko-odczyt | Wariant wersji planu. |  |
| WersjaCentralna | `Soneta.Zadania.Budzetowanie.WersjaPlanu` | bazodanowe | Wersja Centralna | Centralna wersja planu, do której przypisana jest lokalna wersja planu. |
| WersjePowiazane | `SubTable<Soneta.Zadania.Budzetowanie.WersjaPlanu>` | podlista |  |  |

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
