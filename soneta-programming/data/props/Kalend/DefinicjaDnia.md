# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaDnia`
Nazwa tabeli: `DefinicjeDni`
Tytuł: Definicje dni
Opis: Konfigurowalna definicja dnia roboczego. Określa typ dnia (roboczy, wolny, świąteczny), normę czasu pracy, tolerancję wejścia oraz rozliczanie nadgodzin w dni świąteczno-wolne.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IŹródłoKoloruElementu`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BackColor | `int` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| ForeColor | `int` |  |  |  |
| Kod | `string` | bazodanowe |  |  |
| Kolory | `Soneta.Business.SubTable<Soneta.Kalend.KolorElementu>` |  |  |  |
| NadgodzinySW | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Net | `Soneta.Kalend.DefinicjaDniaNet` | bazodanowe |  |  |
| Net.WidocznaWNet | `bool` | bazodanowe |  | Czy definicja jest dostępna z poziomu pulpitów |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaDnia>` |  |  |  |
| TolerancjaWe | `Soneta.Types.Time` | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypDnia` | bazodanowe, enum |  |  |
| WejścieDo | `Soneta.Types.Time` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypDnia (`Soneta.Kalend.TypDnia`)
- `Pracy` = 0 — Pracy
- `Wolny` = 1
- `Świąteczny` = 2
