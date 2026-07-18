# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.AvaliableTransactionState`
Nazwa tabeli: `AvalTranStates`
Tytuł: Dostepne stany
Opis: Definicja dozwolonych przejść między stanami transakcji CRM. Określa, do których stanów docelowych można przejść z danego stanu wyjściowego, wymuszając prawidłowy przebieg procesu sprzedażowego.
Tabela konfiguracyjna: Tak

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.CRM.Config.StanTransakcji` | bazodanowe | Dostępny stan |  |
| Parent | `Soneta.CRM.Config.StanTransakcji` | bazodanowe, tylko-odczyt | Stan wyjściowy |  |
