# Pola i właściwości klasy biznesowej: `Soneta.Oceny.DefinicjaElementuOceny`
Nazwa tabeli: `DefElementowOcen`
Tytuł: Definicje elementów ocen
Opis: Definicja pojedynczego kryterium oceny (kompetencji, zachowania, zadania). Określa nazwę, kategorię, miarę oceniania i rodzaj elementu, stanowiąc budulec arkuszy oceny pracowniczej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kategoria | `Soneta.Oceny.KategoriaElementuOceny` | bazodanowe |  |  |
| Miara | `Soneta.Oceny.MiaraElementuOceny` | bazodanowe |  |  |
| Miara.IsWgSkali | `bool` |  |  |  |
| Miara.IsWgWartosci | `bool` |  |  |  |
| Miara.IsWgWartosci0 | `bool` |  |  |  |
| Miara.IsWgWartosci2 | `bool` |  |  |  |
| Miara.IsWgWykonania | `bool` |  |  |  |
| Miara.IsWgWykonania0 | `bool` |  |  |  |
| Miara.IsWgWykonania2 | `bool` |  |  |  |
| Miara.Kryterium | `Soneta.Oceny.IKryteriumOceny` |  |  |  |
| Miara.Skala | `Soneta.Oceny.SkalaOcen` | bazodanowe |  |  |
| Miara.SposobAgregacji | `Soneta.Oceny.SposobyAgregacji` | bazodanowe, enum | Sposób agregacji |  |
| Miara.WgSkala | `Soneta.Business.Key` |  |  |  |
| Miara.WgZakres | `Soneta.Business.Key` |  |  |  |
| Miara.Zakres | `Soneta.Oceny.ZakresWartości` | bazodanowe |  |  |
| Miara.Zdefiniowana | `bool` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaUI | `string` |  | Nazwa |  |
| NazwaWyswietlana | `string` | bazodanowe | Nazwa wyświetlana |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisJendaLinia | `string` |  |  |  |
| PozycjaDokumentu | `Soneta.Oceny.PozycjaDokumentuInfo` | bazodanowe |  |  |
| PozycjaDokumentu.Sekcja | `Soneta.Oceny.DefinicjaSekcjiDokumentu` | bazodanowe |  |  |
| PozycjaDokumentu.WgSekcja | `Soneta.Business.Key` |  |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| PrzeznaczonyDla | `Soneta.Oceny.TableRef` |  |  |  |
| Rodzaj | `Soneta.Oceny.RodzajeElementuOceny` | bazodanowe, enum |  |  |
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
