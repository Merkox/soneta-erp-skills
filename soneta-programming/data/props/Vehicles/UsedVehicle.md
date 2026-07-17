# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Models.Database.UsedVehicle`
Nazwa tabeli: `UsedVehicles`
Tytuł: Pojazdy wykorzystane
Opis: Rejestr wykorzystania pojazdów w ramach zadań CRM. Przechowuje dane o okresie użytkowania, dokumentach rozliczających, usługach i stawkach, stanowiąc podstawę do rozliczania kosztów eksploatacji floty.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` |  |  |  |
| CloseDate | `Soneta.Types.Date` | bazodanowe | Data zamknięcia | Data zamknięcia. |
| CloseTime | `Soneta.Types.Time` | bazodanowe | Godzina zamknięcia | Godzina zamknięcia. |
| Description | `string` |  |  |  |
| Document | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument rozliczający. |
| End | `System.DateTime` |  |  |  |
| Ending | `System.DateTime` |  |  |  |
| OpenDate | `Soneta.Types.Date` | bazodanowe | Data otwarcia | Data otwarcia. |
| OpenTime | `Soneta.Types.Time` | bazodanowe | Godzina otwarcia | Godzina otwarcia. |
| Position | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja rozliczająca. |
| Quantity | `double` | bazodanowe | Ilość |  |
| Rate | `Soneta.Types.Currency` | bazodanowe | Stawka |  |
| Resource | `object` |  |  |  |
| ResourceCRM | `Soneta.Zadania.ZasobCRM` | bazodanowe | Zasób CRM | Zasoby CRM powiązane z pojazdami. |
| Service | `Soneta.Towary.Towar` | bazodanowe | Usługa |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| Start | `System.DateTime` |  |  |  |
| Starting | `System.DateTime` |  |  |  |
| Task | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
| TaskState | `Soneta.Zadania.StanZadania` | bazodanowe |  | Stan zadania. |
| Text | `string` |  |  |  |
| Vehicle | `Soneta.Vehicles.Vehicle` | bazodanowe | Pojazd |  |
| Worth | `Soneta.Types.Currency` | bazodanowe | Wartość |  |
