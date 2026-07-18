# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienKalendarzaAktualizacja`
Nazwa tabeli: `DniKalendAkt`
Opis: Element szczegółowy pozycji aktualizacji kalendarza (PozycjaAktualizacjiKalendarza). Aktualizowany dzień planu pracy na dokumencie aktualizacji kalendarza, zawierający typ dnia, definicję dnia i normę czasu pracy.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaAktualizacjiKalendarza`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 6
- podlisty: 1
- subrowy: 1
- razem: 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Definicja | `Soneta.Kalend.DefinicjaDnia` | bazodanowe |  |  |
| OdGodziny | `Time` | tylko-odczyt | Od |  |
| Pozycja | `Soneta.Kalend.PozycjaAktualizacjiKalendarza` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| RuchomyCzasPracy | `bool` | tylko-odczyt |  |  |
| Strefy | `SubTable<Soneta.Kalend.StrefaKalendarzaAktualizacja>` | podlista |  |  |
| TolerancjaWe | `Time` | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypKalendarza` (enum) | bazodanowe, tylko-odczyt |  |  |
| WejścieDo | `Time` |  |  |  |

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
