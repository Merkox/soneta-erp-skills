# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ElementRozliczeniaCzasuPracy`
Nazwa tabeli: `ElRozlCzasPracy`
Tytuł: Elementy wniosków/zleceń rozliczenia czasu pracy
Opis: Element szczegółowy rozliczenia czasu pracy (RozliczenieCzasuPracy). Pojedyncza pozycja wniosku lub zlecenia rozliczenia nadgodzin, określająca datę, strefę, godzinę rozpoczęcia i czas trwania pracy do rozliczenia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 3
- subrowy: 0
- razem: 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | bazodanowe |  |  |
| CzasDostępny | `Time` | tylko-odczyt |  |  |
| CzasPozostały | `Time` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Dokument | `Soneta.Kalend.RozliczenieCzasuPracy` | bazodanowe, tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa elementu na dokumencie. |
| OdGodziny | `Time` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Rodzaj | `Soneta.Kalend.TypRozliczenia` (enum) | tylko-odczyt |  |  |
| StrefyPracy | `SubTable<Soneta.Kalend.StrefaPracy>` | podlista |  |  |
| StrefyPracyHistorie | `SubTable<Soneta.Kalend.StrefaPracyHistoria>` | podlista |  |  |
| StrefyRCP | `SubTable<Soneta.Kalend.StrefaRCP>` | podlista |  |  |
| Zrealizowane | `Time` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypRozliczenia (`Soneta.Kalend.TypRozliczenia`)
- `NieDotyczy` = 0
- `WBieżącymMiesiącu` = 1 — W bieżącym miesiącu
- `WKolejnychMiesiącach` = 2 — W kolejnych miesiącach
- `ZPoprzednichMiesięcy` = 3 — Z poprzednich miesięcy
- `WypłataNadgodzin` = 4
