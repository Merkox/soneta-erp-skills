# Pola i właściwości klasy biznesowej: `Soneta.PracaZdalna.Models.Database.RelChangeInfo`
Nazwa tabeli: `RelChangeInfos`
Tytuł: Relacje historii zmian
Opis: Powiązanie wpisów historii zmian (ChangeInfo) z rejestracją czasu pracy (TimeTrack). Umożliwia śledzenie, które zmiany w systemie zostały zarejestrowane w ramach sesji pracy.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ChangeInfoId | `int` | bazodanowe | Id ChangeInfo | Identyfikator tabeli ChangeInfo. |
| DatabaseGuid | `System.Guid` | bazodanowe | Guid bazy wpisu | Guid bazy danych z której pochodzi wpis. |
| RelationType | `Soneta.PracaZdalna.Enums.ChangeInfoRelationType` (enum) | bazodanowe, tylko-odczyt |  |  |
| TimeTrack | `Soneta.Core.TimeTrack` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ChangeInfoRelationType (`Soneta.PracaZdalna.Enums.ChangeInfoRelationType`)
- `Local` = 1 — Wpis lokalny
- `Remote` = 2 — Wpis zdalny
