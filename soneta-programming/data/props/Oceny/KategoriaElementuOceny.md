# Pola i właściwości klasy biznesowej: `Soneta.Oceny.KategoriaElementuOceny`
Nazwa tabeli: `KatElementowOcen`
Tytuł: Kategorie elementów ocen
Opis: Kategoria grupująca elementy oceny (np. kompetencje miękkie, wiedza techniczna). Umożliwia organizację kryteriów oceniania w logiczne grupy z własną miarą i priorytetem wyświetlania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 10
- podlisty: 4
- subrowy: 1
- razem: 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicje | `SubTable<Soneta.Oceny.DefinicjaElementuOceny>` | podlista |  |  |
| Kategorie | `SubTable<Soneta.Oceny.OcenaKategoriaArkusza>` | podlista |  |  |
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
| Priorytet | `int` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SposobyAgregacji (`Soneta.Oceny.SposobyAgregacji`)
- `Min` = 0
- `Max` = 1
- `Średnia` = 2
- `ŚredniaWGórę` = 3
- `ŚredniaWDół` = 4

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
