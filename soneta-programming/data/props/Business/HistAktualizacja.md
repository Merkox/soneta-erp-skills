# Pola i właściwości klasy biznesowej: `Soneta.Business.HistAktualizacja`
Nazwa tabeli: `HistAktualizacje`
Tytuł: AktualizacjaHists
Opis: Rejestr wykonanych aktualizacji bazy danych. Przechowuje powód i opis aktualizacji dla celów śledzenia historii zmian struktury danych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| HistHost | `Soneta.Business.Db.HistHost` | bazodanowe, enum |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Powod | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### HistHost (`Soneta.Business.Db.HistHost`)
- `PracHistorie` = 1 — Pracownicy
- `UmowaHistorie` = 2 — Umowy
- `NieruchomosciHis` = 3 — Nieruchomości
- `VehicleHis` = 4 — Pojazdy
- `DefinicjaStanowiskaHist` = 5 — Definicje stanowiska
