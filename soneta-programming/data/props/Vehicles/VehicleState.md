# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Models.Database.Config.VehicleState`
Nazwa tabeli: `VehicleStates`
Tytuł: Stany pojazdów
Opis: Element szczegółowy typu pojazdu (VehicleType). Definiuje możliwe stany, w jakich może znajdować się pojazd danego typu, np. dostępny, w naprawie, zarezerwowany. Umożliwia kontrolę cyklu życia pojazdu oraz blokowanie nieaktualnych stanów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` | bazodanowe | Aktywny | Wskazuje, czy pojazd w tym stanie jest aktywny. |
| Blocked | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany pojazdów nie będą wyświetlane w liście wyboru. |
| Ident | `int` | bazodanowe | Identyfikator | Identyfikator stanu na typie pojazdu. Wykorzystywany w relacji do pojazdu. |
| Kod | `string` |  |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu w ramach pojazdu. |
| Name | `string` | bazodanowe | Nazwa | Nazwa stanu pojazdu |
| Nazwa | `string` |  |  |  |
| VehicleType | `Soneta.Vehicles.Models.Database.Config.VehicleType` | bazodanowe |  | Typ pojazdu, do którego jest przypisany ten stan |
