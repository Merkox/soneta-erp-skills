# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.DefBudgetCategory`
Nazwa tabeli: `DefBudgetCateg`
Tytuł: Kategoria budżetu
Opis: Kategoria klasyfikacji pozycji budżetowych (np. memoriałowa, płatność, zapłata). Określa typ korekty, sposób rozliczania oraz dozwolone wartości kwot i ilości opisów analitycznych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 4
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 0
- razem: 22

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `bool` |  |  |  |
| AllowedValueOfElement | `Soneta.Core.AllowedValueOfElement` (enum) | bazodanowe | Dozwolone wartości | Dozwolone kwoty i ilości opisów analitycznych. |
| AmountKind | `Soneta.Core.CategoryAmountKind` (enum) | bazodanowe | Rodzaj kwoty | Rodzaj kwoty kategorii budżetowej. |
| AvailableSettlementKind | `Soneta.Core.SettlementOAKind` (enum) | bazodanowe | Dostępny rodzaj rozliczenia | Dostępny rodzaj rozliczenia. |
| BudgetType | `Soneta.Zadania.Budzetowanie.TypObrotuBudzetu` (enum) | bazodanowe, tylko-odczyt | Typ kategorii budżetu | Typ kategorii budżetu |
| CategoryDefinitionRelationships | `System.Collections.Generic.IEnumerable<Soneta.Core.IBudgetCategoryDefinition>` | podlista |  |  |
| CorrectionType | `Soneta.Core.CorrectionType` (enum) | bazodanowe | Typ korekty | Typ korekty |
| DefBudgetCateg | `SubTable<Soneta.Zadania.Budzetowanie.DefBudgetCategoryRelation>` | podlista |  |  |
| Description | `string` | bazodanowe | Opis | Opis definicji kategorii budżetu. |
| Domyslna | `bool` |  |  |  |
| IsPlanned | `bool` | tylko-odczyt |  |  |
| IsReadOnlyCategories | `bool` | tylko-odczyt |  |  |
| Lock | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje nie będą wyświetlane w liście wyboru. |
| MemorialCategory | `bool` | bazodanowe | Kategoria memoriałowa | Kategoria memoriałowa. |
| MemorialLevel | `Soneta.Core.MemorialLevel` (enum) | bazodanowe | Poziom memoriału | Poziom dla kategorii memoriałowej. |
| MethodBillingCategory | `Soneta.Core.MethodBillingCategory` (enum) | bazodanowe | Sposób rozliczania poprzedniej kategorii | Sposób rozliczania poprzedniej kategorii. |
| Name | `string` | bazodanowe | Nazwa | Pełna nazwa definicji kategorii budżetu. |
| Nazwa | `string` |  |  |  |
| PaymentCategory | `bool` | bazodanowe | Kategoria zapłata | Kategoria zapłata. |
| SettlementCategory | `bool` | bazodanowe | Kategoria płatność | Kategoria płatność. |
| SettlementKind | `Soneta.Core.SettlementKind` (enum) |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji wykorzystywana do wyszukiwania definicji oraz numeracji. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AllowedValueOfElement (`Soneta.Core.AllowedValueOfElement`)
- `Any` = 0 — Dowolne
- `Positive` = 1 — Dodatnie
- `Negative` = 2 — Ujemne

### CategoryAmountKind (`Soneta.Core.CategoryAmountKind`)
- `ByItemKind` = 0 — Wg rodzaju pozycji
- `Cost` = 1 — Koszt
- `Income` = 2 — Przychód

### CorrectionType (`Soneta.Core.CorrectionType`)
- `None` = 0 — Nie - kategoria nie jest korektą
- `CorrectionWithRestrictions` = 1 — Korekta z zachowaniem obostrzeń korygowanej kategorii
- `CorrectionWithoutRestrictions` = 2 — Korekta bez obostrzeń
- `CorrectionWithRestrictionsAndSettlement` = 3 — Korekta z zachowaniem obostrzeń korygowanej kategorii i korektą rozliczenia

### MemorialLevel (`Soneta.Core.MemorialLevel`)
- `Forecast` = 10 — 010 Prognoza
- `Reservation` = 20 — 020 Rezerwacja
- `Commitment` = 110 — 110 Zaangażowanie
- `Orders` = 120 — 120 Zamówienia
- `Execution` = 130 — 130 Wykonanie

### MethodBillingCategory (`Soneta.Core.MethodBillingCategory`)
- `NotRequired` = 0 — Niewymagane
- `RequiredMaxSettlement` = 1 — Wymagane w kwocie/ilości nieprzekraczającej kwoty/ilości rozliczenia
- `Required` = 2 — Wymagane bez kontroli kwoty/ilości
- `RequiredEqualSettlement` = 3 — Wymagane w kwocie/ilości zgodnej z kwotą/ilością rozliczenia

### SettlementKind (`Soneta.Core.SettlementKind`)
- `Relation` = 0 — Powiązanie
- `Memorial` = 1 — Memoriałowa
- `Settlement` = 2 — Płatność
- `Payment` = 4 — Zapłata
- `MemorialSettlement` = 3 — Memoriałowo-Płatność
- `MemorialPayment` = 5 — Memoriałowo-Zapłata
- `SettlementPayment` = 6 — Płatność-Zapłata
- `All` = 7 — Wszystkie

### SettlementOAKind (`Soneta.Core.SettlementOAKind`)
- `None` = 0 — Brak
- `Relation` = 1 — Powiązanie
- `Main` = 2 — Główne
- `Additional` = 4 — Dodatkowe
- `MainWithAdditional` = 6 — Główne i Dodatkowe

### TypObrotuBudzetu (`Soneta.Zadania.Budzetowanie.TypObrotuBudzetu`)
- `Realizacja` = 0
- `Plan` = 1
