# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.AvaliableTransactionState`
Nazwa tabeli: `AvalTranStates`
Tytuł: Dostepne stany
Opis: Definicja dozwolonych przejść między stanami transakcji CRM. Określa, do których stanów docelowych można przejść z danego stanu wyjściowego, wymuszając prawidłowy przebieg procesu sprzedażowego.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.CRM.Config.StanTransakcji` | bazodanowe | Dostępny stan |  |
| Parent | `Soneta.CRM.Config.StanTransakcji` | bazodanowe | Stan wyjściowy |  |
