# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ElementRozliczeniaCzasuPracy`
Nazwa tabeli: `ElRozlCzasPracy`
Tytuł: Elementy wniosków/zleceń rozliczenia czasu pracy
Opis: Element szczegółowy rozliczenia czasu pracy (RozliczenieCzasuPracy). Pojedyncza pozycja wniosku lub zlecenia rozliczenia nadgodzin, określająca datę, strefę, godzinę rozpoczęcia i czas trwania pracy do rozliczenia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| CzasDostępny | `Soneta.Types.Time` |  |  |  |
| CzasPozostały | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Dokument | `Soneta.Kalend.RozliczenieCzasuPracy` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa elementu na dokumencie. |
| OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Rodzaj | `Soneta.Kalend.TypRozliczenia` | enum |  |  |
| StrefyPracy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaPracy>` |  |  |  |
| StrefyPracyHistorie | `Soneta.Business.SubTable<Soneta.Kalend.StrefaPracyHistoria>` |  |  |  |
| StrefyRCP | `Soneta.Business.SubTable<Soneta.Kalend.StrefaRCP>` |  |  |  |
| Zrealizowane | `Soneta.Types.Time` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypRozliczenia (`Soneta.Kalend.TypRozliczenia`)
- `NieDotyczy` = 0
- `WBieżącymMiesiącu` = 1 — W bieżącym miesiącu
- `WKolejnychMiesiącach` = 2 — W kolejnych miesiącach
- `ZPoprzednichMiesięcy` = 3 — Z poprzednich miesięcy
- `WypłataNadgodzin` = 4
