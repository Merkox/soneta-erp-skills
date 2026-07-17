# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.Config.StanNieruchomosci`
Nazwa tabeli: `StanyNieruchom`
Tytuł: Stany nieruchomości
Opis: Element szczegółowy typu nieruchomości (TypNieruchomosc). Definiuje możliwe stany, w jakich może znajdować się nieruchomość danego typu, np. wolna, wynajęta, w remoncie. Umożliwia śledzenie cyklu życia obiektu oraz blokowanie nieaktualnych stanów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy nieruchomośś w tym stanie jest aktywne. |
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany nieruchomości nie będą wyświetlane w liście wyboru. |
| Ident | `int` | bazodanowe | Identyfikator | Identyfikator stanu na definicji nieruchomości. Wykorzystywany w relacji do nieruchomości. |
| Kod | `string` |  |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu w ramach nieruchomości. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa stanu realizacji nieruchomości |
| TypNieruchomosc | `Soneta.RealEstate.Models.Database.Config.TypNieruchomosc` | bazodanowe |  | Definicja nieruchomości, do którego jest przypisany ten stan |
