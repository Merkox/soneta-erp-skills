# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.Evaluation`
Nazwa tabeli: `Evaluations`
Tytuł: Ocena
Opis: Rejestr ocen wystawianych przez klientów lub operatorów w ramach obsługi zgłoszeń serwisowych. Przechowuje ocenę liczbową, uwagi tekstowe, datę wystawienia oraz autora, umożliwiając pomiar jakości obsługi.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Author | `IOwner` | bazodanowe | Autor |  |
| Created | `System.DateTime` | bazodanowe | Data dodania |  |
| Grade | `int` | bazodanowe |  |  |
| Host | `Soneta.Core.IOwnerHost` | bazodanowe | Host |  |
| Remarks | `MemoText` | bazodanowe, podlista |  |  |
