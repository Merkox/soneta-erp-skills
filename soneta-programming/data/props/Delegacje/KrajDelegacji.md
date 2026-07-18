# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.KrajDelegacji`
Nazwa tabeli: `KrajeDelegacji`
Tytuł: Kraje delegacji
Opis: Słownik krajów delegacji służący do konfiguracji stawek diet i limitów noclegowych. Każdy kraj posiada unikalny kod oraz możliwość blokady, co zapobiega tworzeniu nowych delegacji do nieaktualnych kierunków. Stanowi podstawę rozliczeń delegacji krajowych i zagranicznych.
Tabela konfiguracyjna: Tak
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `StawkaDelegacji`
Implementuje interfejsy: `IRowWithHistory`, `IKrajDelegacji`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Blokada - kraj zablokowany nie może być użyty do tworzenia nowych delegacji |
| CzyPolska | `bool` | tylko-odczyt |  |  |
| Historia | `HistorySubTable<Soneta.Delegacje.StawkaDelegacji>` | podlista |  |  |
| Kod | `string` | bazodanowe | Kod kraju delegacji | Unikalny kod kraju delegacji. |
| Kraj | `Soneta.Core.KrajTbl` | bazodanowe | Kraj |  |
