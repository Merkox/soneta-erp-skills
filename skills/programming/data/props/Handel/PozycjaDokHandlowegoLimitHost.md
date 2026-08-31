# Pola i właściwości klasy biznesowej: `Soneta.Handel.PozycjaDokHandlowegoLimitHost`
Nazwa tabeli: `PozDoHaLiHosts`
Tytuł: Pozycja Handlowa Limit Hosts
Opis: Powiązanie hosta (obiektu obsługującego) z limitem pozycji dokumentu handlowego. Umożliwia przypisanie wielu hostów do jednego limitu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `ILimitHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Handel.ILimitHost` | bazodanowe, guided-parent | Host |  |
| PozycjaDokHandlowegoLimit | `Soneta.Handel.PozycjaDokHandlowegoLimit` | bazodanowe | Pozycja Handlowa Limit |  |
