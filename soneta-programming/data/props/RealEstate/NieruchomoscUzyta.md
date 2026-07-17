# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruchomoscUzyta`
Nazwa tabeli: `NieruchomUzyte`
Tytuł: Nieruchomości wykorzystane
Opis: Rejestr wykorzystania nieruchomości w ramach zadań CRM, np. wynajem pomieszczeń czy rezerwacje. Przechowuje dane o okresie użytkowania, powierzchni wynajmowanej, stawkach oraz powiązanych dokumentach handlowych rozliczających użycie obiektu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` |  |  |  |
| CzasOtwarcia | `Soneta.Types.Time` | bazodanowe | Godzina otwarcia | Godzina otwarcia. |
| CzasZamkniecia | `Soneta.Types.Time` | bazodanowe | Godzina zamknięcia | Godzina zamknięcia. |
| DataOtwarcia | `Soneta.Types.Date` | bazodanowe | Data otwarcia | Data otwarcia. |
| DataZamkniecia | `Soneta.Types.Date` | bazodanowe | Data zamknięcia | Data zamknięcia. |
| Description | `string` |  |  |  |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument rozliczający. |
| End | `System.DateTime` |  |  |  |
| Ilosc | `double` | bazodanowe | Ilość |  |
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe |  |  |
| PowierzchniaDostepna | `double` |  |  |  |
| PowierzchniaWynajmowana | `double` | bazodanowe | Powierzchnia wynajmowana |  |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja rozliczająca. |
| Price | `Soneta.Types.Currency` |  |  |  |
| Resource | `object` |  |  |  |
| Rozliczone | `bool` |  |  |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| SettlementType | `Soneta.RealEstate.Enums.SettlementType` | enum |  |  |
| SettlementUnit | `Soneta.Towary.Jednostka` |  |  |  |
| StanZadania | `Soneta.Zadania.StanZadania` | bazodanowe |  | Stan projektu. |
| Start | `System.DateTime` |  |  |  |
| Stawka | `Soneta.Types.Currency` | bazodanowe | Stawka |  |
| Text | `string` |  |  |  |
| Usluga | `Soneta.Towary.Towar` | bazodanowe | Usługa |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość |  |
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
