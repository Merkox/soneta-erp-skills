# Pola i właściwości klasy biznesowej: `Soneta.Web.Business.App.WebReport`
Nazwa tabeli: `WebReports`
Opis: Definicja raportu dostępnego w aplikacji webowej enova365. Określa nazwę, opis, moduł docelowy, ścieżkę do pliku raportu na serwerze oraz status aktywności. Raporty są przypisywane do modułów i udostępniane użytkownikom zgodnie z rolami uprawnień.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` | bazodanowe | Aktywny | Stan raportu włączony/wyłączony z użycia. |
| Description | `string` | bazodanowe | Opis | Opis raportu. |
| Name | `string` | bazodanowe | Nazwa | Nazwa raportu. |
| ReportModule | `Soneta.Web.Business.Utils.ReportsModules` (enum) | bazodanowe | Moduł | Dla jakiego modułu przeznaczony jest raport. |
| Roles | `SubTable<Soneta.Web.Business.App.WebReportRole>` | podlista |  |  |
| VirtualPath | `string` | bazodanowe | Ścieżka wirtualna | Ścieżka wirtualna na serwerze IIS dla pliku z definicją raportu. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ReportsModules (`Soneta.Web.Business.Utils.ReportsModules`)
- `NotSet` = -1 — Wszystkie
- `KadryPłace` = 1 — Kadry Płace
- `CRM` = 2 — CRM
- `Zamówienia` = 3 — Zamówienia
