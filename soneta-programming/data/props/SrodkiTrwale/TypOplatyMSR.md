# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.TypOplatyMSR`
Nazwa tabeli: `TypyOplatMSR`
Tytuł: Typy opłaty MSR
Opis: Tabela konfiguracyjna przechowująca typy opłat stosowane w ewidencji środków trwałych według standardów MSR. Każdy typ posiada unikalny symbol, nazwę oraz flagę blokady uniemożliwiającą użycie w nowych dokumentach.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Typ zablokowany |
| Nazwa | `string` | bazodanowe |  | Nazwa typu |
| Standardowa | `bool` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol |  |
