# Pola i właściwości klasy biznesowej: `Soneta.Oceny.DefinicjaElementuOceny`
Nazwa tabeli: `DefElementowOcen`
Tytuł: Definicje elementów ocen
Opis: Definicja pojedynczego kryterium oceny (kompetencji, zachowania, zadania). Określa nazwę, kategorię, miarę oceniania i rodzaj elementu, stanowiąc budulec arkuszy oceny pracowniczej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 12
- podlisty: 4
- subrowy: 2
- razem: 29

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
| Rodzaj | `Soneta.Oceny.RodzajeElementuOceny` (enum) | bazodanowe, tylko-odczyt |  |  |
| RodzajZrodla | `string` | bazodanowe |  |  |

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
