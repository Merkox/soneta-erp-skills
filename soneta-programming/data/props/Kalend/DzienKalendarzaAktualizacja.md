# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienKalendarzaAktualizacja`
Nazwa tabeli: `DniKalendAkt`
Opis: Element szczegółowy pozycji aktualizacji kalendarza (PozycjaAktualizacjiKalendarza). Aktualizowany dzień planu pracy na dokumencie aktualizacji kalendarza, zawierający typ dnia, definicję dnia i normę czasu pracy.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaAktualizacjiKalendarza`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaDnia` | bazodanowe |  |  |
| OdGodziny | `Soneta.Types.Time` |  | Od |  |
| Pozycja | `Soneta.Kalend.PozycjaAktualizacjiKalendarza` | bazodanowe, guided-parent |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| RuchomyCzasPracy | `bool` |  |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaKalendarzaAktualizacja>` |  |  |  |
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
