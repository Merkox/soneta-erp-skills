# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.OkresObrachunkowy`
Nazwa tabeli: `OkresyObrach`
Tytuł: Okresy obrachunkowe
Opis: Okres obrachunkowy definiuje ramy czasowe prowadzenia księgowości w firmie. Określa daty otwarcia i zamknięcia okresu, dozwolone przedziały księgowania oraz parametry podatkowe JPK. Umożliwia kontrolę terminów księgowania i rozliczeń księgowych.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Typ` (`Soneta.Ksiega.TypOkresuObrachunkowego`) — wiele typów w jednej tabeli, podtypów: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnaNumeracjaPozabilansowa | `bool` | bazodanowe |  | Włącz odrębną numeracje dekretów oraz zapisów księgowych dla kont pozabilansowych  |
| DataZamkniecia | `Date` | bazodanowe, tylko-odczyt |  | Data zamknięcia zapisów |
| DozwolonyOkres | `FromTo` | bazodanowe, podlista |  | Dozwolony okres księgowania |
| DozwolonyOkresRozliczenKs | `FromTo` | bazodanowe, podlista |  | Dozwolony okres rozliczeń księgowych |
| Kod | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Nieaktywny | `bool` | bazodanowe | Nieaktywne schematy | Włącz na nieużywanych okresach, aby przyspieszyć predekretację |
| Okres | `FromTo` | bazodanowe, podlista |  | Otwarcie i zamkniecie okresu obrachunkowego. |
| OkresPodatkowyJPK | `FromTo` | bazodanowe, podlista |  | Okres podatkowy JPK |
| Opis | `string` | bazodanowe |  |  |
| Podokresy | `SubTable<Soneta.Ksiega.PodokresObrachunkowy>` | podlista |  |  |
| ReakcjaKsiegowa | `VerifierType` (enum) | bazodanowe |  | Reakcja na podatkowe przekroczenie dozwolonego okresu księgowania |
| ReakcjaPodatkowa | `VerifierType` (enum) | bazodanowe |  | Reakcja na księgowe przekroczenie dozwolonego okresu księgowania |
| ReakcjaRozliczenKs | `VerifierType` (enum) | bazodanowe |  | Reakcja na przekroczenie dozwolonego okresu rozliczeń księgowych |
| SchematyKsiegowe | `SubTable<Soneta.Ksiega.SchematKsiegowy>` | podlista |  |  |
| SchematyKsiegoweDoWywolania | `SubTable<Soneta.Ksiega.SchematKsiegowy>` | podlista |  |  |
| SprawozdaniaKS | `SubTable<Soneta.Ksiega.SprawozdanieKS>` | podlista |  |  |
| Symbol | `string` | bazodanowe |  | Symbol okresu obrachunkowego. |
| Typ | `Soneta.Ksiega.TypOkresuObrachunkowego` (enum) | bazodanowe, tylko-odczyt, selektor |  | Typ okresu obrachunkowego |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `KS` | 0 | `Soneta.Ksiega.OkresObrachunkowyKS` |  |
| `KPiR` | 1 | `Soneta.Ksiega.OkresObrachunkowyKPiR` |  |
| `Ryczałt` | 2 | `Soneta.Ksiega.OkresObrachunkowyRyczałt` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOkresuObrachunkowego (`Soneta.Ksiega.TypOkresuObrachunkowego`)
- `KS` = 0 — Księga Handlowa
- `KPiR` = 1 — Księga Podatkowa
- `Ryczałt` = 2 — Ewidencja Ryczałtowa

### VerifierType (`VerifierType`)
- `Error` = 0 — Błąd
- `Warning` = 1 — Ostrzeżenie
- `Information` = 2 — Informacja
