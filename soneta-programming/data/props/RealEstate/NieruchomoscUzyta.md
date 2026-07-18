# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruchomoscUzyta`
Nazwa tabeli: `NieruchomUzyte`
Tytuł: Nieruchomości wykorzystane
Opis: Rejestr wykorzystania nieruchomości w ramach zadań CRM, np. wynajem pomieszczeń czy rezerwacje. Przechowuje dane o okresie użytkowania, powierzchni wynajmowanej, stawkach oraz powiązanych dokumentach handlowych rozliczających użycie obiektu.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` | tylko-odczyt |  |  |
| CzasOtwarcia | `Time` | bazodanowe | Godzina otwarcia | Godzina otwarcia. |
| CzasZamkniecia | `Time` | bazodanowe | Godzina zamknięcia | Godzina zamknięcia. |
| DataOtwarcia | `Date` | bazodanowe | Data otwarcia | Data otwarcia. |
| DataZamkniecia | `Date` | bazodanowe | Data zamknięcia | Data zamknięcia. |
| Description | `string` | tylko-odczyt |  |  |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument rozliczający. |
| End | `System.DateTime` | tylko-odczyt |  |  |
| Ilosc | `double` | bazodanowe | Ilość |  |
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe |  |  |
| PowierzchniaDostepna | `double` | tylko-odczyt |  |  |
| PowierzchniaWynajmowana | `double` | bazodanowe | Powierzchnia wynajmowana |  |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja rozliczająca. |
| Price | `Currency` | tylko-odczyt |  |  |
| Resource | `object` | tylko-odczyt |  |  |
| Rozliczone | `bool` | tylko-odczyt |  |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| SettlementType | `Soneta.RealEstate.Enums.SettlementType` (enum) | tylko-odczyt |  |  |
| SettlementUnit | `Soneta.Towary.Jednostka` | tylko-odczyt |  |  |
| StanZadania | `Soneta.Zadania.StanZadania` | bazodanowe |  | Stan projektu. |
| Start | `System.DateTime` | tylko-odczyt |  |  |
| Stawka | `Currency` | bazodanowe | Stawka |  |
| Text | `string` |  |  |  |
| Usluga | `Soneta.Towary.Towar` | bazodanowe | Usługa |  |
| Wartosc | `Currency` | bazodanowe | Wartość |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
| Zakonczenie | `System.DateTime` |  |  |  |
| ZasobCRM | `Soneta.Zadania.ZasobCRM` | bazodanowe | Zasób CRM | Zasoby CRM powiązane z nieruchomościami. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SettlementType (`Soneta.RealEstate.Enums.SettlementType`)
- `None` = 0 — Brak
- `Unknown` = 1 — Nieznane
- `Hourly` = 2 — Godzinowe
- `Daily` = 3 — Dzienne
- `Monthly` = 4 — Miesięczne
