# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.TypOplatyMSR`
Nazwa tabeli: `TypyOplatMSR`
Tytuł: Typy opłaty MSR
Opis: Tabela konfiguracyjna przechowująca typy opłat stosowane w ewidencji środków trwałych według standardów MSR. Każdy typ posiada unikalny symbol, nazwę oraz flagę blokady uniemożliwiającą użycie w nowych dokumentach.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Typ zablokowany |
| Nazwa | `string` | bazodanowe |  | Nazwa typu |
| Standardowa | `bool` | tylko-odczyt |  |  |
| Symbol | `string` | bazodanowe | Symbol |  |
