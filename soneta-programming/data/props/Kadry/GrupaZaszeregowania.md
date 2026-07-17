# Pola i właściwości klasy biznesowej: `Soneta.Kadry.GrupaZaszeregowania`
Nazwa tabeli: `GrupyZaszer`
Tytuł: Grupy zaszeregowania
Opis: Słownik grup zaszeregowania pracowników określający typ stawki, zakres wynagrodzenia (od-do) i powiązanie z elementem płacowym. Służy do klasyfikacji stanowisk pod kątem poziomu wynagrodzenia zasadniczego.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` | bazodanowe, enum |  |  |
| UwzgledniajWymiar | `bool` | bazodanowe |  |  |
| ZakresDo | `Soneta.Types.Currency` | bazodanowe |  |  |
| ZakresOd | `Soneta.Types.Currency` | bazodanowe |  |  |
| ZakresOstrzezenie | `bool` | bazodanowe |  |  |
| Zaszeregowanie | `Soneta.Kadry.Zaszeregowanie` | bazodanowe |  |  |
| Zaszeregowanie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Zaszeregowanie.Godzinowe | `bool` |  |  |  |
| Zaszeregowanie.Miesięczne | `bool` |  |  |  |
| Zaszeregowanie.RodzajStawki | `Soneta.Kadry.RodzajStawkiZaszeregowania` | bazodanowe, enum |  |  |
| Zaszeregowanie.Stawka | `Soneta.Types.Currency` | bazodanowe |  |  |
| Zaszeregowanie.TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` | enum |  |  |
| Zaszeregowanie.WgElement | `Soneta.Business.Key` |  |  |  |
| Zaszeregowanie.WskaznikKrotnosc | `double` | bazodanowe |  |  |
| Zaszeregowanie.WskaznikNazwa | `string` | bazodanowe |  |  |
| Zaszeregowanie.Wymiar | `Soneta.Types.Fraction` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajStawkiZaszeregowania (`Soneta.Kadry.RodzajStawkiZaszeregowania`)
- `Godzinowa` = 0 — Za godzinę
- `Miesieczna` = 1 — Miesięcznie
- `DochodDeklarowany` = 2 — Dochód deklarowany

### TypStawkiZaszeregowania (`Soneta.Kadry.TypStawkiZaszeregowania`)
- `Dowolna` = 0 — Dowolna
- `Minimalna` = 1
- `ZZakresu` = 2
- `WgWskaźnika` = 3
- `Nieokreślona` = 10
