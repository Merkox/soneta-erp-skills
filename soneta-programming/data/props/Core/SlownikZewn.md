# Pola i właściwości klasy biznesowej: `Soneta.Core.SlownikZewn`
Nazwa tabeli: `SlownikiZewn`
Tytuł: Słownik zewnętrzny
Opis: Słownik zewnętrzny mapujący obiekty z systemów zewnętrznych na elementy wewnętrzne. Zawiera rodzaj, wskazanie na obiekt zewnętrzny, nazwę, dodatkowe parametry oraz hierarchię elementów nadrzędnych i podrzędnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nadrzedny | `Soneta.Core.SlownikZewn` | bazodanowe |  | Nadrzędny słownik zewnętrzny |
| Nazwa | `string` | bazodanowe |  | Nazwa słownika zewnętrznego |
| Parametry | `string` | bazodanowe |  | Dodatkowe parametry |
| Podrzedne | `SubTable<Soneta.Core.SlownikZewn>` | podlista |  |  |
| Rodzaj | `string` | bazodanowe |  | Rodzaj słownika zewnętrznego |
| ZapisZewn | `string` | bazodanowe | Obiekt z systemu zewnętrznego | Wskazanie na obiekt z systemu zewnętrzenego |
