# Pola i właściwości klasy biznesowej: `Soneta.Business.HistAktualizacja`
Nazwa tabeli: `HistAktualizacje`
Tytuł: AktualizacjaHists
Opis: Rejestr wykonanych aktualizacji bazy danych. Przechowuje powód i opis aktualizacji dla celów śledzenia historii zmian struktury danych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| HistHost | `Db.HistHost` (enum) | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Powod | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### HistHost (`Db.HistHost`)
- `PracHistorie` = 1 — Pracownicy
- `UmowaHistorie` = 2 — Umowy
- `NieruchomosciHis` = 3 — Nieruchomości
- `VehicleHis` = 4 — Pojazdy
- `DefinicjaStanowiskaHist` = 5 — Definicje stanowiska
