# Pola i właściwości klasy biznesowej: `Soneta.Kadry.GrupaZaszeregowania`
Nazwa tabeli: `GrupyZaszer`
Tytuł: Grupy zaszeregowania
Opis: Słownik grup zaszeregowania pracowników określający typ stawki, zakres wynagrodzenia (od-do) i powiązanie z elementem płacowym. Służy do klasyfikacji stanowisk pod kątem poziomu wynagrodzenia zasadniczego.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 1
- razem: 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` (enum) | bazodanowe |  |  |
| UwzgledniajWymiar | `bool` | bazodanowe |  |  |
| ZakresDo | `Currency` | bazodanowe |  |  |
| ZakresOd | `Currency` | bazodanowe |  |  |
| ZakresOstrzezenie | `bool` | bazodanowe |  |  |
| Zaszeregowanie | `Soneta.Kadry.Zaszeregowanie` (subrow) | bazodanowe |  |  |
| Zaszeregowanie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Zaszeregowanie.Godzinowe | `bool` | tylko-odczyt |  |  |
| Zaszeregowanie.Miesięczne | `bool` | tylko-odczyt |  |  |
| Zaszeregowanie.RodzajStawki | `Soneta.Kadry.RodzajStawkiZaszeregowania` (enum) | bazodanowe |  |  |
| Zaszeregowanie.Stawka | `Currency` | bazodanowe |  |  |
| Zaszeregowanie.TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` (enum) |  |  |  |
| Zaszeregowanie.WgElement | `Key` | podlista |  |  |
| Zaszeregowanie.WskaznikKrotnosc | `double` | bazodanowe |  |  |
| Zaszeregowanie.WskaznikNazwa | `string` | bazodanowe |  |  |
| Zaszeregowanie.Wymiar | `Fraction` | bazodanowe |  |  |

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
