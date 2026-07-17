# Pola i właściwości klasy biznesowej: `Soneta.Handel.PozycjaDokHandlowegoLimit`
Nazwa tabeli: `PozDoHandLimity`
Tytuł: Pozycja Handlowa Limity
Opis: Definicja limitu ilościowego dla pozycji dokumentu handlowego (umowy cyklicznej). Określa nazwę limitu, wartość progową oraz definicję ceny.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaCeny | `Soneta.Towary.DefinicjaCeny` | bazodanowe | Definicja ceny |  |
| HostName | `string` |  |  |  |
| Hosts | `Soneta.Business.SubTable<Soneta.Handel.PozycjaDokHandlowegoLimitHost>` |  |  |  |
| Limit | `Soneta.Towary.Quantity` | bazodanowe | Limit |  |
| Nazwa | `string` | bazodanowe | Nazwa |  |
