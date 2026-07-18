# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.AvaliableLeadState`
Nazwa tabeli: `AvalLeadStates`
Tytuł: Dostepne stany
Opis: Definicja dozwolonych przejść między stanami leada CRM. Określa, do których stanów docelowych można przejść z danego stanu wyjściowego, wymuszając prawidłowy przebieg procesu kwalifikacji leadów.
Tabela konfiguracyjna: Tak

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.CRM.Config.StanLeada` | bazodanowe | Dostępny stan |  |
| Parent | `Soneta.CRM.Config.StanLeada` | bazodanowe, tylko-odczyt | Stan wyjściowy |  |
