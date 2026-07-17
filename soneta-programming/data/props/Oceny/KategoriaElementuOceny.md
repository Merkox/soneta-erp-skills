# Pola i właściwości klasy biznesowej: `Soneta.Oceny.KategoriaElementuOceny`
Nazwa tabeli: `KatElementowOcen`
Tytuł: Kategorie elementów ocen
Opis: Kategoria grupująca elementy oceny (np. kompetencje miękkie, wiedza techniczna). Umożliwia organizację kryteriów oceniania w logiczne grupy z własną miarą i priorytetem wyświetlania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicje | `Soneta.Business.SubTable<Soneta.Oceny.DefinicjaElementuOceny>` |  |  |  |
| Kategorie | `Soneta.Business.SubTable<Soneta.Oceny.OcenaKategoriaArkusza>` |  |  |  |
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
| Priorytet | `int` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |

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
