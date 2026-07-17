# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.KrajDelegacji`
Nazwa tabeli: `KrajeDelegacji`
Tytuł: Kraje delegacji
Opis: Słownik krajów delegacji służący do konfiguracji stawek diet i limitów noclegowych. Każdy kraj posiada unikalny kod oraz możliwość blokady, co zapobiega tworzeniu nowych delegacji do nieaktualnych kierunków. Stanowi podstawę rozliczeń delegacji krajowych i zagranicznych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRowWithHistory`, `IKrajDelegacji`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Blokada - kraj zablokowany nie może być użyty do tworzenia nowych delegacji |
| CzyPolska | `bool` |  |  |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.Delegacje.StawkaDelegacji>` |  |  |  |
| Kod | `string` | bazodanowe | Kod kraju delegacji | Unikalny kod kraju delegacji. |
| Kraj | `Soneta.Core.KrajTbl` | bazodanowe | Kraj |  |
