# Pola i właściwości klasy biznesowej: `Soneta.Core.IsoProcedura`
Nazwa tabeli: `IsoProcedury`
Tytuł: Procedury ISO
Opis: Słownik procedur ISO używanych do numeracji dokumentów. Każda procedura posiada nazwę, opis i flagę blokady. Powiązana z definicjami dokumentów, dla których określa sposób numeracji wg standardów ISO.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Procedura zablokowana |
| Nazwa | `string` | bazodanowe | Nazwa procedury | Nazwa procedury |
| NumeryWgOddzialow | `Soneta.Business.SubTable<Soneta.Core.IsoNumerProcedury>` |  |  |  |
| Opis | `string` | bazodanowe | Opis procedury | Opis procedury |
