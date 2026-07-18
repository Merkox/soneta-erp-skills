# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.Config.StanNieruchomosci`
Nazwa tabeli: `StanyNieruchom`
Tytuł: Stany nieruchomości
Opis: Element szczegółowy typu nieruchomości (TypNieruchomosc). Definiuje możliwe stany, w jakich może znajdować się nieruchomość danego typu, np. wolna, wynajęta, w remoncie. Umożliwia śledzenie cyklu życia obiektu oraz blokowanie nieaktualnych stanów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy nieruchomośś w tym stanie jest aktywne. |
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany nieruchomości nie będą wyświetlane w liście wyboru. |
| Ident | `int` | bazodanowe, tylko-odczyt | Identyfikator | Identyfikator stanu na definicji nieruchomości. Wykorzystywany w relacji do nieruchomości. |
| Kod | `string` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu w ramach nieruchomości. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa stanu realizacji nieruchomości |
| TypNieruchomosc | `Soneta.RealEstate.Models.Database.Config.TypNieruchomosc` | bazodanowe, tylko-odczyt |  | Definicja nieruchomości, do którego jest przypisany ten stan |
