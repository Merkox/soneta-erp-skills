# Pola i właściwości klasy biznesowej: `Soneta.Oceny.DefinicjaElementuOceny`
Nazwa tabeli: `DefElementowOcen`
Tytuł: Definicje elementów ocen
Opis: Definicja pojedynczego kryterium oceny (kompetencji, zachowania, zadania). Określa nazwę, kategorię, miarę oceniania i rodzaj elementu, stanowiąc budulec arkuszy oceny pracowniczej.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Rodzaj` (`Soneta.Oceny.RodzajeElementuOceny`) — wiele typów w jednej tabeli, podtypów: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kategoria | `Soneta.Oceny.KategoriaElementuOceny` | bazodanowe |  |  |
| Miara | `Soneta.Oceny.MiaraElementuOceny` (subrow) | bazodanowe |  |  |
| Miara.IsWgSkali | `bool` | tylko-odczyt |  |  |
| Miara.IsWgWartosci | `bool` | tylko-odczyt |  |  |
| Miara.IsWgWartosci0 | `bool` | tylko-odczyt |  |  |
| Miara.IsWgWartosci2 | `bool` | tylko-odczyt |  |  |
| Miara.IsWgWykonania | `bool` | tylko-odczyt |  |  |
| Miara.IsWgWykonania0 | `bool` | tylko-odczyt |  |  |
| Miara.IsWgWykonania2 | `bool` | tylko-odczyt |  |  |
| Miara.Kryterium | `Soneta.Oceny.IKryteriumOceny` | tylko-odczyt |  |  |
| Miara.Skala | `Soneta.Oceny.SkalaOcen` | bazodanowe |  |  |
| Miara.SposobAgregacji | `Soneta.Oceny.SposobyAgregacji` (enum) | bazodanowe | Sposób agregacji |  |
| Miara.WgSkala | `Key` | podlista |  |  |
| Miara.WgZakres | `Key` | podlista |  |  |
| Miara.Zakres | `Soneta.Oceny.ZakresWartości` | bazodanowe |  |  |
| Miara.Zdefiniowana | `bool` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaUI | `string` |  | Nazwa |  |
| NazwaWyswietlana | `string` | bazodanowe, tylko-odczyt | Nazwa wyświetlana |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisJendaLinia | `string` | tylko-odczyt |  |  |
| PozycjaDokumentu | `Soneta.Oceny.PozycjaDokumentuInfo` (subrow) | bazodanowe |  |  |
| PozycjaDokumentu.Sekcja | `Soneta.Oceny.DefinicjaSekcjiDokumentu` | bazodanowe |  |  |
| PozycjaDokumentu.WgSekcja | `Key` | podlista |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| PrzeznaczonyDla | `Soneta.Oceny.TableRef` |  |  |  |
| Rodzaj | `Soneta.Oceny.RodzajeElementuOceny` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| RodzajZrodla | `string` | bazodanowe |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Kompetencja` | 1 | `Soneta.HR.Oceny.ElementOcenyKompetencja` | Kompetencja twarda (kwalifikacje) |
| `Zachowanie` | 2 | `Soneta.HR.Oceny.ElementOcenyZachowanie` | Kompetencja miękka (zachowanie) |
| `Zadanie` | 3 | `Soneta.HR.Oceny.ElementOcenyZadanie` | Cel okresowy |
| `ElementOceny` | 10 | `Soneta.Oceny.ElementOceny` | Element oceny |
| `ElementAnkiety` | 11 | `Soneta.Ankiety.ElementAnkiety` | Element ankiety |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeElementuOceny (`Soneta.Oceny.RodzajeElementuOceny`)
- `Razem` = 0
- `Kompetencja` = 1
- `Zachowanie` = 2
- `Zadanie` = 3
- `ElementOceny` = 10
- `ElementAnkiety` = 11

### SposobyAgregacji (`Soneta.Oceny.SposobyAgregacji`)
- `Min` = 0
- `Max` = 1
- `Średnia` = 2
- `ŚredniaWGórę` = 3
- `ŚredniaWDół` = 4
