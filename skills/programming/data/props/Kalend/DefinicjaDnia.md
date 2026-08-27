# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaDnia`
Nazwa tabeli: `DefinicjeDni`
Tytuł: Definicje dni
Opis: Konfigurowalna definicja dnia roboczego. Określa typ dnia (roboczy, wolny, świąteczny), normę czasu pracy, tolerancję wejścia oraz rozliczanie nadgodzin w dni świąteczno-wolne.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IŹródłoKoloruElementu`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BackColor | `int` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| ForeColor | `int` |  |  |  |
| Kod | `string` | bazodanowe |  |  |
| Kolory | `SubTable<Soneta.Kalend.KolorElementu>` | podlista |  |  |
| NadgodzinySW | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Net | `Soneta.Kalend.DefinicjaDniaNet` (subrow) | bazodanowe |  |  |
| Net.WidocznaWNet | `bool` | bazodanowe |  | Czy definicja jest dostępna z poziomu pulpitów |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| Strefy | `SubTable<Soneta.Kalend.StrefaDnia>` | podlista |  |  |
| TolerancjaWe | `Time` | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypDnia` (enum) | bazodanowe |  |  |
| WejścieDo | `Time` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypDnia (`Soneta.Kalend.TypDnia`)
- `Pracy` = 0 — Pracy
- `Wolny` = 1
- `Świąteczny` = 2
