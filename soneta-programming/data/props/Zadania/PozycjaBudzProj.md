# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.PozycjaBudzProj`
Nazwa tabeli: `PozycjeBudzProj`
Tytuł: Pozycje budżetu projektu
Opis: Pozycja budżetu projektu tworząca hierarchiczną strukturę kosztów i przychodów. Zawiera symbol, konto analityczne, jednostkę rozliczeniową oraz flagę rozliczania ilości.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 32

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudgetItemKindFromContext | `Soneta.Zadania.Budzetowanie.RodzajPozycjiBudzetuFiltr` | enum |  |  |
| BudzetProjektu | `Soneta.Zadania.Budzetowanie.BudzetProjektu` | bazodanowe |  | Budzet projektu, z którym powiązana jest pozycja |
| ElementyOpisuAnalitycznego | `Soneta.Business.SubTable<Soneta.Ksiega.ElemOpisuAnalitycznego>` |  |  |  |
| ElementyOpisuAnalitycznegoWszystkie | `Soneta.Business.View` |  |  |  |
| HasEntriesInAnalysisSource | `bool` |  |  |  |
| HasRight | `bool` |  |  |  |
| IsPlanned | `bool` |  |  |  |
| IsReadOnlyJednostka | `bool` |  |  |  |
| Jednostka | `Soneta.Towary.Jednostka` | bazodanowe |  | Jednostka ilości planowanych i realizacji pozycji budżetowej. |
| JestPlanowanaWGore | `bool` |  |  |  |
| JestRoot | `bool` |  |  |  |
| KwotyBudzProj | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.KwotaBudzProj>` |  |  |  |
| KwotyBudzProj2 | `System.Collections.IEnumerable` |  |  |  |
| KwotyBudzProjektuPlan | `Soneta.Business.View` |  |  |  |
| KwotyBudzProjektuPlanKoszt | `Soneta.Business.View` |  |  |  |
| KwotyBudzProjektuPlanPrzychod | `Soneta.Business.View` |  |  |  |
| Nadrzedna | `Soneta.Zadania.Budzetowanie.PozycjaBudzProj` | bazodanowe | Pozycja nadrzędna | Określa nadrzędną pozycję budżetu projektu. |
| NadrzednaSymbol | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa pozycji. |
| ObjectRight | `Soneta.Business.AccessRights` | enum |  |  |
| ObrotyPozycji | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.BudzetObrot>` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis pozycji. |
| Path | `string` |  | Ścieżka |  |
| Planowana | `bool` | bazodanowe |  |  |
| PlanowanaWGore | `Soneta.Zadania.Budzetowanie.PozycjaBudzProj` |  |  |  |
| Podrzedne | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.PozycjaBudzProj>` |  |  |  |
| PodrzedneWszystkie | `Soneta.Business.View` |  |  |  |
| QuantityUnitSymbol | `string` |  |  |  |
| RodzajPozycjiBudzetu | `Soneta.Zadania.Budzetowanie.RodzajPozycjiBudzetu` | bazodanowe, enum | Rodzaj pozycji budzetu | Określa rodzaj pozycji budzetu. |
| RozliczanieIlosci | `bool` | bazodanowe | Rozliczanie ilości | Określa, czy na pozycji należy rozliczać ilości |
| SaKorekty | `bool` |  |  |  |
| SaKwoty | `bool` |  |  |  |
| SaKwotyPlan | `bool` |  |  |  |
| SaKwotyPlanKoszt | `bool` |  |  |  |
| SaKwotyPlanPrzychod | `bool` |  |  |  |
| SaOpisy | `bool` |  |  |  |
| SaPodrzedne | `bool` |  |  |  |
| SaZapisy | `bool` |  |  |  |
| Sciezka | `string` | bazodanowe |  |  |
| Segment | `string` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol pozycji. |
| SymbolKonta | `string` | bazodanowe | Symbol konta | Domyślny symbol konta dla opisu analitycznego. |
| Uprawnienia | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.BudzetUprawnienie>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessRights (`Soneta.Business.AccessRights`)
- `Denied` = 0 — Zakaz dostępu
- `ReadOnly` = 1 — Tylko odczyt
- `Granted` = 2 — Pełne prawo
- `NoInit` = 3 — Niezainicjowane

### RodzajPozycjiBudzetu (`Soneta.Zadania.Budzetowanie.RodzajPozycjiBudzetu`)
- `Przychod` = 0 — Przychód
- `Koszt` = 1
- `Zbiorcze` = 2
- `ZbiorczeKoszt` = 3 — Zbiorcze kosztowe
- `ZbiorczePrzychod` = 4 — Zbiorcze przychodowe

### RodzajPozycjiBudzetuFiltr (`Soneta.Zadania.Budzetowanie.RodzajPozycjiBudzetuFiltr`)
- `Wszystkie` = 0
- `Przychod` = 1 — Przychód
- `Koszt` = 2
- `Zbiorcze` = 3
- `ZbiorczeKoszt` = 4 — Zbiorcze kosztowe
- `ZbiorczePrzychod` = 5 — Zbiorcze przychodowe
