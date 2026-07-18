# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.PriorytetTransakcja`
Nazwa tabeli: `PriorytetyTran`
Tytuł: Priorytety transakcji
Opis: Element szczegółowy definicji transakcji CRM (PriorytetTransakcja). Definiuje poziomy ważności transakcji (np. niski, średni, wysoki) w ramach definicji, umożliwiając priorytetyzację działań sprzedażowych.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany nie będą wyświetlane w liście wyboru. |
| Definicja | `Soneta.CRM.Config.DefTransakcja` | bazodanowe, tylko-odczyt |  | Definicja transakcji, do której jest przypisany jest priorytet |
| Kod | `string` | tylko-odczyt |  |  |
| Kolor | `string` | bazodanowe | Kolor | Kolor dla priorytetu |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa priorytetu w ramach transakcji. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa priorytetu transakcji |
