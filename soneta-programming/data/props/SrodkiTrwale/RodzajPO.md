# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.RodzajPO`
Nazwa tabeli: `RodzajePO`
Tytuł: Rodzaje przedmiotów opodatkowania
Opis: Słownik rodzajów przedmiotów opodatkowania podatkiem od nieruchomości (grunty, budynki, budowle). Definiuje typy nieruchomości wraz z nazwami, co pozwala klasyfikować nieruchomości przy naliczaniu podatku.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.SrodkiTrwale.TypAlgorytmuStawki` (enum) | bazodanowe | Typ algorytmu stawki | Typ algortymu stawki |
| NazwaPrzedmiotuOpodatkowania | `string` | bazodanowe | Nazwa przedmiotu opodatkowania | Nazwa przedmiotu opodatkowania |
| Systemowe | `bool` | bazodanowe |  | Systemowy |
| Typ | `Soneta.SrodkiTrwale.TypNieruchomosci` (enum) | bazodanowe |  | Typ podatku opodatkowania |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAlgorytmuStawki (`Soneta.SrodkiTrwale.TypAlgorytmuStawki`)
- `Kwotowy` = 0
- `Procentowy` = 1

### TypNieruchomosci (`Soneta.SrodkiTrwale.TypNieruchomosci`)
- `Grunt` = 0
- `Budynek` = 1
- `Budowla` = 2
- `Brak` = 3
