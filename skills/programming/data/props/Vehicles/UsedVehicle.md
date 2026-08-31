# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Models.Database.UsedVehicle`
Nazwa tabeli: `UsedVehicles`
Tytuł: Pojazdy wykorzystane
Opis: Rejestr wykorzystania pojazdów w ramach zadań CRM. Przechowuje dane o okresie użytkowania, dokumentach rozliczających, usługach i stawkach, stanowiąc podstawę do rozliczania kosztów eksploatacji floty.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` | tylko-odczyt |  |  |
| CloseDate | `Date` | bazodanowe | Data zamknięcia | Data zamknięcia. |
| CloseTime | `Time` | bazodanowe | Godzina zamknięcia | Godzina zamknięcia. |
| Description | `string` | tylko-odczyt |  |  |
| Document | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument rozliczający. |
| End | `System.DateTime` | tylko-odczyt |  |  |
| Ending | `System.DateTime` |  |  |  |
| OpenDate | `Date` | bazodanowe | Data otwarcia | Data otwarcia. |
| OpenTime | `Time` | bazodanowe | Godzina otwarcia | Godzina otwarcia. |
| Position | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja rozliczająca. |
| Quantity | `double` | bazodanowe | Ilość |  |
| Rate | `Currency` | bazodanowe | Stawka |  |
| Resource | `object` | tylko-odczyt |  |  |
| ResourceCRM | `Soneta.Zadania.ZasobCRM` | bazodanowe | Zasób CRM | Zasoby CRM powiązane z pojazdami. |
| Service | `Soneta.Towary.Towar` | bazodanowe | Usługa |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| Start | `System.DateTime` | tylko-odczyt |  |  |
| Starting | `System.DateTime` |  |  |  |
| Task | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
| TaskState | `Soneta.Zadania.StanZadania` | bazodanowe |  | Stan zadania. |
| Text | `string` |  |  |  |
| Vehicle | `Soneta.Vehicles.Vehicle` | bazodanowe | Pojazd |  |
| Worth | `Currency` | bazodanowe | Wartość |  |
