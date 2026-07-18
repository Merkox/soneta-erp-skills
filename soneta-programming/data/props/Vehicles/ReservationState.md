# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Models.Database.Config.ReservationState`
Nazwa tabeli: `ReservStates`
Tytuł: Stany rezerwacji
Opis: Element szczegółowy definicji rezerwacji (ReservationDef). Definiuje możliwe stany procesu rezerwacji pojazdu, np. nowa, zatwierdzona, w trakcie, zakończona. Określa typ aktywności stanu oraz umożliwia blokowanie nieaktualnych stanów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 0
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` | tylko-odczyt |  |  |
| Blocked | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany rezerwacji nie będą wyświetlane w liście wyboru. |
| Cancel | `bool` | tylko-odczyt |  |  |
| Definition | `Soneta.Vehicles.Models.Database.Config.ReservationDef` | bazodanowe, tylko-odczyt |  | Definicja rezerwacji, do którego jest przypisany ten stan |
| Ident | `int` | bazodanowe, tylko-odczyt | Identyfikator | Identyfikator stanu na definicji rezerwacji. Wykorzystywany w relacji do rezerwacji. |
| Kod | `string` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu w ramach rezerwacji. |
| Name | `string` | bazodanowe | Nazwa | Nazwa stanu rezerwacji |
| Nazwa | `string` | tylko-odczyt |  |  |
| StateType | `Soneta.Vehicles.Enums.ReservationStateType` (enum) | bazodanowe | Stan Aktywności | Wskazuje rodzaj stanu. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ReservationStateType (`Soneta.Vehicles.Enums.ReservationStateType`)
- `New` = 1 — Nowa
- `Active` = 2 — Aktywna
- `Finish` = 3 — Zakończona
- `Cancel` = 4 — Anulowana
