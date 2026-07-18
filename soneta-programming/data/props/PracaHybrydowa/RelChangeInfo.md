# Pola i właściwości klasy biznesowej: `Soneta.PracaZdalna.Models.Database.RelChangeInfo`
Nazwa tabeli: `RelChangeInfos`
Tytuł: Relacje historii zmian
Opis: Powiązanie wpisów historii zmian (ChangeInfo) z rejestracją czasu pracy (TimeTrack). Umożliwia śledzenie, które zmiany w systemie zostały zarejestrowane w ramach sesji pracy.
Tabela konfiguracyjna: Nie
Selektor: pole `RelationType` (`Soneta.PracaZdalna.Enums.ChangeInfoRelationType`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ChangeInfoId | `int` | bazodanowe | Id ChangeInfo | Identyfikator tabeli ChangeInfo. |
| DatabaseGuid | `System.Guid` | bazodanowe | Guid bazy wpisu | Guid bazy danych z której pochodzi wpis. |
| RelationType | `Soneta.PracaZdalna.Enums.ChangeInfoRelationType` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| TimeTrack | `Soneta.Core.TimeTrack` | bazodanowe |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `RelationType`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Local` | 1 | `Soneta.PracaZdalna.Models.Database.RelChangeInfo` |  |
| `Remote` | 2 | `Soneta.PracaZdalna.Models.Database.RelChangeInfo` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ChangeInfoRelationType (`Soneta.PracaZdalna.Enums.ChangeInfoRelationType`)
- `Local` = 1 — Wpis lokalny
- `Remote` = 2 — Wpis zdalny
