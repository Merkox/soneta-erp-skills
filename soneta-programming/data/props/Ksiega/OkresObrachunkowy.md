# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.OkresObrachunkowy`
Nazwa tabeli: `OkresyObrach`
Tytuł: Okresy obrachunkowe
Opis: Okres obrachunkowy definiuje ramy czasowe prowadzenia księgowości w firmie. Określa daty otwarcia i zamknięcia okresu, dozwolone przedziały księgowania oraz parametry podatkowe JPK. Umożliwia kontrolę terminów księgowania i rozliczeń księgowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnaNumeracjaPozabilansowa | `bool` | bazodanowe |  | Włącz odrębną numeracje dekretów oraz zapisów księgowych dla kont pozabilansowych  |
| DataZamkniecia | `Soneta.Types.Date` | bazodanowe |  | Data zamknięcia zapisów |
| DozwolonyOkres | `Soneta.Types.FromTo` | bazodanowe |  | Dozwolony okres księgowania |
| DozwolonyOkresRozliczenKs | `Soneta.Types.FromTo` | bazodanowe |  | Dozwolony okres rozliczeń księgowych |
| Kod | `string` |  |  |  |
| Nazwa | `string` |  |  |  |
| Nieaktywny | `bool` | bazodanowe | Nieaktywne schematy | Włącz na nieużywanych okresach, aby przyspieszyć predekretację |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Otwarcie i zamkniecie okresu obrachunkowego. |
| OkresPodatkowyJPK | `Soneta.Types.FromTo` | bazodanowe |  | Okres podatkowy JPK |
| Opis | `string` | bazodanowe |  |  |
| Podokresy | `Soneta.Business.SubTable<Soneta.Ksiega.PodokresObrachunkowy>` |  |  |  |
| ReakcjaKsiegowa | `Soneta.Types.VerifierType` | bazodanowe, enum |  | Reakcja na podatkowe przekroczenie dozwolonego okresu księgowania |
| ReakcjaPodatkowa | `Soneta.Types.VerifierType` | bazodanowe, enum |  | Reakcja na księgowe przekroczenie dozwolonego okresu księgowania |
| ReakcjaRozliczenKs | `Soneta.Types.VerifierType` | bazodanowe, enum |  | Reakcja na przekroczenie dozwolonego okresu rozliczeń księgowych |
| SchematyKsiegowe | `Soneta.Business.SubTable<Soneta.Ksiega.SchematKsiegowy>` |  |  |  |
| SchematyKsiegoweDoWywolania | `Soneta.Business.SubTable<Soneta.Ksiega.SchematKsiegowy>` |  |  |  |
| SprawozdaniaKS | `Soneta.Business.SubTable<Soneta.Ksiega.SprawozdanieKS>` |  |  |  |
| Symbol | `string` | bazodanowe |  | Symbol okresu obrachunkowego. |
| Typ | `Soneta.Ksiega.TypOkresuObrachunkowego` | bazodanowe, enum |  | Typ okresu obrachunkowego |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOkresuObrachunkowego (`Soneta.Ksiega.TypOkresuObrachunkowego`)
- `KS` = 0 — Księga Handlowa
- `KPiR` = 1 — Księga Podatkowa
- `Ryczałt` = 2 — Ewidencja Ryczałtowa

### VerifierType (`Soneta.Types.VerifierType`)
- `Error` = 0 — Błąd
- `Warning` = 1 — Ostrzeżenie
- `Information` = 2 — Informacja
