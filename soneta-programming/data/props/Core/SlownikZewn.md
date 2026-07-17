# Pola i właściwości klasy biznesowej: `Soneta.Core.SlownikZewn`
Nazwa tabeli: `SlownikiZewn`
Tytuł: Słownik zewnętrzny
Opis: Słownik zewnętrzny mapujący obiekty z systemów zewnętrznych na elementy wewnętrzne. Zawiera rodzaj, wskazanie na obiekt zewnętrzny, nazwę, dodatkowe parametry oraz hierarchię elementów nadrzędnych i podrzędnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nadrzedny | `Soneta.Core.SlownikZewn` | bazodanowe |  | Nadrzędny słownik zewnętrzny |
| Nazwa | `string` | bazodanowe |  | Nazwa słownika zewnętrznego |
| Parametry | `string` | bazodanowe |  | Dodatkowe parametry |
| Podrzedne | `Soneta.Business.SubTable<Soneta.Core.SlownikZewn>` |  |  |  |
| Rodzaj | `string` | bazodanowe |  | Rodzaj słownika zewnętrznego |
| ZapisZewn | `string` | bazodanowe | Obiekt z systemu zewnętrznego | Wskazanie na obiekt z systemu zewnętrzenego |
