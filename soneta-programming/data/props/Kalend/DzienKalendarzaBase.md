# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienKalendarzaBase`
Nazwa tabeli: `DniKalendarza`
Opis: Element szczegółowy kalendarza (KalendarzBase). Pojedynczy dzień w kalendarzu pracy, definiujący typ dnia, przypisaną definicję dnia roboczego, normę czasu pracy oraz tolerancję wejścia dla danej daty.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Kalendarz` → `KalendarzBase`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaDnia` | bazodanowe |  |  |
| Kalendarz | `Soneta.Kalend.KalendarzBase` | bazodanowe, guided-parent |  |  |
| OdGodziny | `Soneta.Types.Time` |  | Od |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| RuchomyCzasPracy | `bool` |  |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaKalendarza>` |  |  |  |
| TolerancjaWe | `Soneta.Types.Time` | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypKalendarza` | bazodanowe, enum |  |  |
| WejścieDo | `Soneta.Types.Time` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypKalendarza (`Soneta.Kalend.TypKalendarza`)
- `Kalendarz` = 1
- `KalendarzPracownika` = 2
- `SeriaDni` = 3
- `KalendarzUmowy` = 4
- `KalendarzAktualizacjiPracownika` = 5
- `KalendarzAktualizacjiUmowy` = 6
- `KalendarzPlanuKopia` = 10
- `KalendarzPracyKopia` = 11
