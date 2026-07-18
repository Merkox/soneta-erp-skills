# Pola i właściwości klasy biznesowej: `Soneta.Zadania.ZasobCRM`
Nazwa tabeli: `ZasobyCRM`
Tytuł: Zasoby powiązane z zadaniem
Opis: Element szczegółowy zadania (Zadanie). Przypisuje zasób (np. urządzenie, salę) do zadania CRM z opcjonalną rezerwacją terminową, umożliwiając zarządzanie dostępnością zasobów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zadanie` → `Zadanie`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` | tylko-odczyt | Całodzienne |  |
| CzasDo | `Time` | bazodanowe | Godzina zakończenia rezerwacji | Godzina zakończenia rezerwacji. |
| CzasOd | `Time` | bazodanowe | Godzina rozpoczęcia rezerwacji | Godzina rozpoczęcia rezerwacji. |
| DataDo | `Date` | bazodanowe | Data zakończenia rezerwacji | Data zakończenia rezerwacji. |
| DataOd | `Date` | bazodanowe | Data rozpoczÄ™cia rezerwacji | Data rozpoczÄ™cia rezerwacji. |
| Description | `string` | tylko-odczyt |  |  |
| End | `System.DateTime` |  |  |  |
| KodZasobu | `string` | tylko-odczyt |  |  |
| NazwaZasobu | `string` | tylko-odczyt | Nazwa |  |
| NieruchomosciUzyte | `SubTable` | podlista |  |  |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe |  | Projekt, do którego jest przypisany zasób |
| Resource | `object` | tylko-odczyt |  |  |
| Rezerwowany | `bool` | bazodanowe | Rezerwowany | Wskazuje, czy zasÃ³b ma byÄ‡ rezerwowany. |
| SchedulerInterval | `Interval` |  |  |  |
| SchedulerResource | `Soneta.Core.IZasobCRM` | iface-ref |  |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| Start | `System.DateTime` |  |  |  |
| Text | `string` |  |  |  |
| TypZasobu | `string` | tylko-odczyt |  |  |
| UrzadzeniaUzyte | `SubTable<Soneta.Zadania.UrzadzenieUzyte>` | podlista |  |  |
| UsedVehicles | `SubTable` | podlista |  |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe, guided-parent |  | Zadanie, do którego jest przypisany zasób |
| Zasob | `Soneta.Core.IZasobCRM` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| SchedulerResource | `IZasobCRM` | `Nieruchomosc`, `Pojazd`, `Pracownik`, `SrodekTrwalyBase`, `Urzadzenie`, `Wyposazenie` |
| Zasob | `IZasobCRM` | `Nieruchomosc`, `Pojazd`, `Pracownik`, `SrodekTrwalyBase`, `Urzadzenie`, `Wyposazenie` |
