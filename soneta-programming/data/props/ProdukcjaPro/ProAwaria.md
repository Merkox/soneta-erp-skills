# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProAwaria`
Nazwa tabeli: `ProAwarie`
Tytuł: Awarie produkcyjne
Opis: Rejestr awarii i przestojów zasobów produkcyjnych. Dokumentuje zdarzenia awaryjne z przypisaniem do zasobu, osoby zgłaszającej i czasu trwania, umożliwiając analizę przyczyn przestojów i planowanie konserwacji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasPracy | `Soneta.ProdukcjaPro.ProCzasPracy` | bazodanowe | Czas pracy | Czas pracy awarii. |
| CzasPrzekazania | `Soneta.Types.TimeSec` |  | Czas przekazania | Czas przekazania awarii. |
| CzasUtworzenia | `Soneta.Types.TimeSec` |  | Czas utworzenia | Czas utworzenia awarii. |
| CzasZamkniecia | `Soneta.Types.TimeSec` |  | Czas zamknięcia | Czas zamknięcia awarii. |
| DataPrzekazania | `Soneta.Types.Date` |  | Data przekazania | Data przekazania awarii. |
| DataUtworzenia | `Soneta.Types.Date` |  | Data utworzenia | Data utworzenia awarii. |
| DataZamkniecia | `Soneta.Types.Date` |  | Data zamknięcia | Data zamknięcia awarii. |
| Kod | `string` | bazodanowe |  | Kod awarii. |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Operator awarii. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis awarii. |
| Osoba | `Soneta.ProdukcjaPro.ProOsoba` | bazodanowe |  | Osoba awarii. |
| Priorytet | `int` | bazodanowe |  | Priorytet awarii. |
| Przekazanie | `System.DateTime` | bazodanowe |  | Data i czas przekazania awarii. |
| Stan | `Soneta.ProdukcjaPro.ProStanAwarii` | bazodanowe, enum |  | Stan awarii. |
| Utworzenie | `System.DateTime` | bazodanowe |  | Data i czas utworzenia awarii. |
| Uzytkownik | `Soneta.ProdukcjaPro.ProUzytkownikPaneluMeldunkowego` | bazodanowe | Użytkownik | Użytkownik panelu meldunkowego awarii. |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  | Zadanie dla awarii. |
| Zamkniecie | `System.DateTime` | bazodanowe | Zamknięcie | Data i czas zamknięcia awarii. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Zasób | Zasób awarii. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProStanAwarii (`Soneta.ProdukcjaPro.ProStanAwarii`)
- `None` = 0
- `Otwarta` = 1
- `Przekazana` = 2
- `Zamknieta` = 4 — Zamknięta
- `All` = 7 — Wszystkie
