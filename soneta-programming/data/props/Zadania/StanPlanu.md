# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Models.SalesPlans.StanPlanu`
Nazwa tabeli: `StanyPlanu`
Tytuł: Stany planów sprzedażowych
Opis: Element definiujący stany realizacji planów sprzedażowych. Umożliwia śledzenie stanu realizacji oraz jego atrybuty, takie jak aktywność, blokada czy projektowanie.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy plan w tym stanie jest aktywny (otwarty). |
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany nie będą wyświetlane w liście wyboru. |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu planu sprzedażowego. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa stanu realizacji zadania |
| Projektowany | `bool` | bazodanowe | Projektowany |  |
