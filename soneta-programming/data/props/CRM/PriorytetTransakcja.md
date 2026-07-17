# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.PriorytetTransakcja`
Nazwa tabeli: `PriorytetyTran`
Tytuł: Priorytety transakcji
Opis: Element szczegółowy definicji transakcji CRM (PriorytetTransakcja). Definiuje poziomy ważności transakcji (np. niski, średni, wysoki) w ramach definicji, umożliwiając priorytetyzację działań sprzedażowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany nie będą wyświetlane w liście wyboru. |
| Definicja | `Soneta.CRM.Config.DefTransakcja` | bazodanowe |  | Definicja transakcji, do której jest przypisany jest priorytet |
| Kod | `string` |  |  |  |
| Kolor | `string` | bazodanowe | Kolor | Kolor dla priorytetu |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa priorytetu w ramach transakcji. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa priorytetu transakcji |
