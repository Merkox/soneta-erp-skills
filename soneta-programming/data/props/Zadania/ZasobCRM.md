# Pola i właściwości klasy biznesowej: `Soneta.Zadania.ZasobCRM`
Nazwa tabeli: `ZasobyCRM`
Tytuł: Zasoby powiązane z zadaniem
Opis: Element szczegółowy zadania (Zadanie). Przypisuje zasób (np. urządzenie, salę) do zadania CRM z opcjonalną rezerwacją terminową, umożliwiając zarządzanie dostępnością zasobów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zadanie` → `Zadanie`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` |  | Całodzienne |  |
| CzasDo | `Soneta.Types.Time` | bazodanowe | Godzina zakończenia rezerwacji | Godzina zakończenia rezerwacji. |
| CzasOd | `Soneta.Types.Time` | bazodanowe | Godzina rozpoczęcia rezerwacji | Godzina rozpoczęcia rezerwacji. |
| DataDo | `Soneta.Types.Date` | bazodanowe | Data zakończenia rezerwacji | Data zakończenia rezerwacji. |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data rozpoczÄ™cia rezerwacji | Data rozpoczÄ™cia rezerwacji. |
| Description | `string` |  |  |  |
| End | `System.DateTime` |  |  |  |
| KodZasobu | `string` |  |  |  |
| NazwaZasobu | `string` |  | Nazwa |  |
| NieruchomosciUzyte | `Soneta.Business.SubTable` |  |  |  |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe |  | Projekt, do którego jest przypisany zasób |
| Resource | `object` |  |  |  |
| Rezerwowany | `bool` | bazodanowe | Rezerwowany | Wskazuje, czy zasÃ³b ma byÄ‡ rezerwowany. |
| SchedulerInterval | `Soneta.Types.Interval` |  |  |  |
| SchedulerResource | `Soneta.Core.IZasobCRM` | iface-ref |  |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| Start | `System.DateTime` |  |  |  |
| Text | `string` |  |  |  |
| TypZasobu | `string` |  |  |  |
| UrzadzeniaUzyte | `Soneta.Business.SubTable<Soneta.Zadania.UrzadzenieUzyte>` |  |  |  |
| UsedVehicles | `Soneta.Business.SubTable` |  |  |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe, guided-parent |  | Zadanie, do którego jest przypisany zasób |
| Zasob | `Soneta.Core.IZasobCRM` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| SchedulerResource | `IZasobCRM` | `Nieruchomosc`, `Pojazd`, `Pracownik`, `SrodekTrwalyBase`, `Urzadzenie`, `Wyposazenie` |
| Zasob | `IZasobCRM` | `Nieruchomosc`, `Pojazd`, `Pracownik`, `SrodekTrwalyBase`, `Urzadzenie`, `Wyposazenie` |
