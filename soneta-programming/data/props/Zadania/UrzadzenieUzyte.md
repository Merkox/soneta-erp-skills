# Pola i właściwości klasy biznesowej: `Soneta.Zadania.UrzadzenieUzyte`
Nazwa tabeli: `UrzadzeniaUzyte`
Tytuł: Urządzenia wykorzystane
Opis: Rejestracja użycia urządzenia w ramach zlecenia serwisowego lub wypożyczenia. Przechowuje stan zadania, datę zamknięcia oraz powiązanie z dokumentem rozliczeniowym i zasobem CRM.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` |  |  |  |
| CzasZamkniecia | `Soneta.Types.Time` | bazodanowe | Godzina zamknięcia | Godzina zamknięcia. |
| DataZamkniecia | `Soneta.Types.Date` | bazodanowe | Data zamknięcia | Data zamknięcia. |
| Description | `string` |  |  |  |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument rozliczający. |
| End | `System.DateTime` |  |  |  |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja rozliczająca. |
| Resource | `object` |  |  |  |
| Rozliczone | `bool` |  |  |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| StanZadania | `Soneta.Zadania.StanZadania` | bazodanowe |  | Stan projektu. |
| Start | `System.DateTime` |  |  |  |
| Text | `string` |  |  |  |
| Urzadzenie | `Soneta.Zadania.Urzadzenie` | bazodanowe |  |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
| Zakonczenie | `System.DateTime` |  |  |  |
| ZasobCRM | `Soneta.Zadania.ZasobCRM` | bazodanowe | Zasób CRM | Zasoby CRM powiązane z urządzeniami. |
