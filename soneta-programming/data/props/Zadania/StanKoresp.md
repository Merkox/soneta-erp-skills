# Pola i właściwości klasy biznesowej: `Soneta.Zadania.StanKoresp`
Nazwa tabeli: `StanyKoresp`
Tytuł: Stany korespondencji
Opis: Element szczegółowy definicji korespondencji (DefKoresp). Definiuje możliwy stan korespondencji (np. nowa, wysłana, zakończona) wraz z flagą aktywności.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 1
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy korespondencja w tym stanie jest aktywna (otwarta). |
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany korespondencji nie będą wyświetlane w liście wyboru. |
| Definicja | `Soneta.Zadania.DefKoresp` | bazodanowe, tylko-odczyt |  | Definicja korespondencji, do której jest przypisany ten stan |
| Ident | `int` | bazodanowe, tylko-odczyt | Identyfikator | Identyfikator stanu na definicji korespondencji. Wykorzystywany w relacji do korespondencji. |
| Kod | `string` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu realizacji w ramach projektu. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa stanu korespondencji |
| Stany | `SubTable<Soneta.Zadania.AvaliableCorrespondenceState>` | podlista |  |  |
