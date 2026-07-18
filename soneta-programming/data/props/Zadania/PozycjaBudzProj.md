# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.PozycjaBudzProj`
Nazwa tabeli: `PozycjeBudzProj`
Tytuł: Pozycje budżetu projektu
Opis: Pozycja budżetu projektu tworząca hierarchiczną strukturę kosztów i przychodów. Zawiera symbol, konto analityczne, jednostkę rozliczeniową oraz flagę rozliczania ilości.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudgetItemKindFromContext | `Soneta.Zadania.Budzetowanie.RodzajPozycjiBudzetuFiltr` (enum) |  |  |  |
| BudzetProjektu | `Soneta.Zadania.Budzetowanie.BudzetProjektu` | bazodanowe |  | Budzet projektu, z którym powiązana jest pozycja |
| ElementyOpisuAnalitycznego | `SubTable<Soneta.Ksiega.ElemOpisuAnalitycznego>` | podlista |  |  |
| ElementyOpisuAnalitycznegoWszystkie | `View` | podlista |  |  |
| HasEntriesInAnalysisSource | `bool` | tylko-odczyt |  |  |
| HasRight | `bool` | tylko-odczyt |  |  |
| IsPlanned | `bool` | tylko-odczyt |  |  |
| IsReadOnlyJednostka | `bool` | tylko-odczyt |  |  |
| Jednostka | `Soneta.Towary.Jednostka` | bazodanowe |  | Jednostka ilości planowanych i realizacji pozycji budżetowej. |
| JestPlanowanaWGore | `bool` | tylko-odczyt |  |  |
| JestRoot | `bool` | tylko-odczyt |  |  |
| KwotyBudzProj | `SubTable<Soneta.Zadania.Budzetowanie.KwotaBudzProj>` | podlista |  |  |
| KwotyBudzProj2 | `System.Collections.IEnumerable` | tylko-odczyt |  |  |
| KwotyBudzProjektuPlan | `View` | podlista |  |  |
| KwotyBudzProjektuPlanKoszt | `View` | podlista |  |  |
| KwotyBudzProjektuPlanPrzychod | `View` | podlista |  |  |
| Nadrzedna | `Soneta.Zadania.Budzetowanie.PozycjaBudzProj` | bazodanowe | Pozycja nadrzędna | Określa nadrzędną pozycję budżetu projektu. |
| NadrzednaSymbol | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa pozycji. |
| ObjectRight | `AccessRights` (enum) | tylko-odczyt |  |  |
| ObrotyPozycji | `SubTable<Soneta.Zadania.Budzetowanie.BudzetObrot>` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Opis pozycji. |
| Path | `string` |  | Ścieżka |  |
| Planowana | `bool` | bazodanowe |  |  |
| PlanowanaWGore | `Soneta.Zadania.Budzetowanie.PozycjaBudzProj` | tylko-odczyt |  |  |
| Podrzedne | `SubTable<Soneta.Zadania.Budzetowanie.PozycjaBudzProj>` | podlista |  |  |
| PodrzedneWszystkie | `View` | podlista |  |  |
| QuantityUnitSymbol | `string` | tylko-odczyt |  |  |
| RodzajPozycjiBudzetu | `Soneta.Zadania.Budzetowanie.RodzajPozycjiBudzetu` (enum) | bazodanowe | Rodzaj pozycji budzetu | Określa rodzaj pozycji budzetu. |
| RozliczanieIlosci | `bool` | bazodanowe | Rozliczanie ilości | Określa, czy na pozycji należy rozliczać ilości |
| SaKorekty | `bool` | tylko-odczyt |  |  |
| SaKwoty | `bool` | tylko-odczyt |  |  |
| SaKwotyPlan | `bool` | tylko-odczyt |  |  |
| SaKwotyPlanKoszt | `bool` | tylko-odczyt |  |  |
| SaKwotyPlanPrzychod | `bool` | tylko-odczyt |  |  |
| SaOpisy | `bool` | tylko-odczyt |  |  |
| SaPodrzedne | `bool` | tylko-odczyt |  |  |
| SaZapisy | `bool` | tylko-odczyt |  |  |
| Sciezka | `string` | bazodanowe, tylko-odczyt |  |  |
| Segment | `string` | tylko-odczyt |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol pozycji. |
| SymbolKonta | `string` | bazodanowe | Symbol konta | Domyślny symbol konta dla opisu analitycznego. |
| Uprawnienia | `SubTable<Soneta.Zadania.Budzetowanie.BudzetUprawnienie>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessRights (`AccessRights`)
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
