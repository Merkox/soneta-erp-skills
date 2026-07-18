# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienKalendarzaBase`
Nazwa tabeli: `DniKalendarza`
Opis: Element szczegółowy kalendarza (KalendarzBase). Pojedynczy dzień w kalendarzu pracy, definiujący typ dnia, przypisaną definicję dnia roboczego, normę czasu pracy oraz tolerancję wejścia dla danej daty.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Kalendarz` → `KalendarzBase`
Selektor: pole `Typ` (`Soneta.Kalend.TypKalendarza`) — wiele typów w jednej tabeli, podtypów: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Definicja | `Soneta.Kalend.DefinicjaDnia` | bazodanowe |  |  |
| Kalendarz | `Soneta.Kalend.KalendarzBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| OdGodziny | `Time` | tylko-odczyt | Od |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| RuchomyCzasPracy | `bool` | tylko-odczyt |  |  |
| Strefy | `SubTable<Soneta.Kalend.StrefaKalendarza>` | podlista |  |  |
| TolerancjaWe | `Time` | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypKalendarza` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| WejścieDo | `Time` |  |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Kalendarz` | 1 | `Soneta.Kalend.DzienKalendarza` | Dzień kalendarza |
| `KalendarzPracownika` | 2 | `Soneta.Kalend.DzienPlanu` | Wyjątek w kalendarzu |
| `SeriaDni` | 3 | `Soneta.Kalend.DzienSerii` | Dzień serii |
| `KalendarzUmowy` | 4 | `Soneta.Kalend.DzienPlanuUmowy` | Wyjątek w kalendarzu |
| `KalendarzPlanuKopia` | 10 | `Soneta.Kalend.DzienPlanuKopia` | Kopia planu pracy |
| `KalendarzPracyKopia` | 11 | `Soneta.Kalend.DzienPracyKopia` | Kopia dnia pracy |

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
