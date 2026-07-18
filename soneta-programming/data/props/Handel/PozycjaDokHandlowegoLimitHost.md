# Pola i właściwości klasy biznesowej: `Soneta.Handel.PozycjaDokHandlowegoLimitHost`
Nazwa tabeli: `PozDoHaLiHosts`
Tytuł: Pozycja Handlowa Limit Hosts
Opis: Powiązanie hosta (obiektu obsługującego) z limitem pozycji dokumentu handlowego. Umożliwia przypisanie wielu hostów do jednego limitu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `ILimitHost`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Handel.ILimitHost` | bazodanowe, guided-parent | Host |  |
| PozycjaDokHandlowegoLimit | `Soneta.Handel.PozycjaDokHandlowegoLimit` | bazodanowe | Pozycja Handlowa Limit |  |
