# Pola i właściwości klasy biznesowej: `Soneta.Zadania.StanProjektu`
Nazwa tabeli: `StanyProjektu`
Tytuł: Stany realizacji projektu CRM
Opis: Element szczegółowy definicji projektu (DefProjektu). Definiuje możliwy stan realizacji projektu CRM (np. otwarty, w toku, zakończony) wraz z flagą aktywności.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy projekt w tym stanie jest aktywny (otwarty). |
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany dokumentów nie będą wyświetlane w liście wyboru. |
| Definicja | `Soneta.Zadania.DefProjektu` | bazodanowe |  | Definicja projektu, do której jest przypisany ten stan |
| Ident | `int` | bazodanowe | Identyfikator | Identyfikator stanu na definicji projektu. Wykorzystywany w relacji do projektu. |
| Kod | `string` |  |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu realizacji w ramach projektu. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa stanu realizacji projektu |
| Stany | `Soneta.Business.SubTable<Soneta.Zadania.AvaliableProjectState>` |  |  |  |
