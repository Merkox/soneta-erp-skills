# Pola i właściwości klasy biznesowej: `Soneta.Zadania.UrzadzenieUzyte`
Nazwa tabeli: `UrzadzeniaUzyte`
Tytuł: Urządzenia wykorzystane
Opis: Rejestracja użycia urządzenia w ramach zlecenia serwisowego lub wypożyczenia. Przechowuje stan zadania, datę zamknięcia oraz powiązanie z dokumentem rozliczeniowym i zasobem CRM.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` | tylko-odczyt |  |  |
| CzasZamkniecia | `Time` | bazodanowe | Godzina zamknięcia | Godzina zamknięcia. |
| DataZamkniecia | `Date` | bazodanowe | Data zamknięcia | Data zamknięcia. |
| Description | `string` | tylko-odczyt |  |  |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument rozliczający. |
| End | `System.DateTime` | tylko-odczyt |  |  |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja rozliczająca. |
| Resource | `object` | tylko-odczyt |  |  |
| Rozliczone | `bool` | tylko-odczyt |  |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| StanZadania | `Soneta.Zadania.StanZadania` | bazodanowe |  | Stan projektu. |
| Start | `System.DateTime` | tylko-odczyt |  |  |
| Text | `string` |  |  |  |
| Urzadzenie | `Soneta.Zadania.Urzadzenie` | bazodanowe |  |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
| Zakonczenie | `System.DateTime` |  |  |  |
| ZasobCRM | `Soneta.Zadania.ZasobCRM` | bazodanowe | Zasób CRM | Zasoby CRM powiązane z urządzeniami. |
