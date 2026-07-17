# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Models.Database.Config.ReservationState`
Nazwa tabeli: `ReservStates`
Tytuł: Stany rezerwacji
Opis: Element szczegółowy definicji rezerwacji (ReservationDef). Definiuje możliwe stany procesu rezerwacji pojazdu, np. nowa, zatwierdzona, w trakcie, zakończona. Określa typ aktywności stanu oraz umożliwia blokowanie nieaktualnych stanów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` |  |  |  |
| Blocked | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany rezerwacji nie będą wyświetlane w liście wyboru. |
| Cancel | `bool` |  |  |  |
| Definition | `Soneta.Vehicles.Models.Database.Config.ReservationDef` | bazodanowe |  | Definicja rezerwacji, do którego jest przypisany ten stan |
| Ident | `int` | bazodanowe | Identyfikator | Identyfikator stanu na definicji rezerwacji. Wykorzystywany w relacji do rezerwacji. |
| Kod | `string` |  |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu w ramach rezerwacji. |
| Name | `string` | bazodanowe | Nazwa | Nazwa stanu rezerwacji |
| Nazwa | `string` |  |  |  |
| StateType | `Soneta.Vehicles.Enums.ReservationStateType` | bazodanowe, enum | Stan Aktywności | Wskazuje rodzaj stanu. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ReservationStateType (`Soneta.Vehicles.Enums.ReservationStateType`)
- `New` = 1 — Nowa
- `Active` = 2 — Aktywna
- `Finish` = 3 — Zakończona
- `Cancel` = 4 — Anulowana
