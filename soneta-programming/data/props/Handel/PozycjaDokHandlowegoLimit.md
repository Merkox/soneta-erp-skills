# Pola i właściwości klasy biznesowej: `Soneta.Handel.PozycjaDokHandlowegoLimit`
Nazwa tabeli: `PozDoHandLimity`
Tytuł: Pozycja Handlowa Limity
Opis: Definicja limitu ilościowego dla pozycji dokumentu handlowego (umowy cyklicznej). Określa nazwę limitu, wartość progową oraz definicję ceny.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaCeny | `Soneta.Towary.DefinicjaCeny` | bazodanowe | Definicja ceny |  |
| HostName | `string` | tylko-odczyt |  |  |
| Hosts | `SubTable<Soneta.Handel.PozycjaDokHandlowegoLimitHost>` | podlista |  |  |
| Limit | `Soneta.Towary.Quantity` | bazodanowe | Limit |  |
| Nazwa | `string` | bazodanowe | Nazwa |  |
