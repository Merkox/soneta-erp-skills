# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.PrzedmiotOp`
Nazwa tabeli: `PrzedmiotyOp`
Tytuł: Przedmiot opodatkowania
Opis: Element szczegółowy historii lokalizacji nieruchomości (LokalizacjaNierHistoria). Definiuje przedmiot opodatkowania podatkiem od nieruchomości z określeniem rodzaju, stawki, algorytmu naliczania oraz typu nieruchomości.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Historia` → `LokalizacjaNierHistoria`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.SrodkiTrwale.TypAlgorytmuStawki` | bazodanowe, enum |  | Typ algorytmu stawki opodatkowania |
| Historia | `Soneta.SrodkiTrwale.LokalizacjaNierHistoria` | bazodanowe, guided-parent |  |  |
| Lokalizacja | `Soneta.SrodkiTrwale.LokalizacjaNier` | bazodanowe |  | Lokalizacja |
| Lp | `int` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  | Opis |
| RodzajPrzedmiotuOpodatkowania | `Soneta.SrodkiTrwale.RodzajPO` | bazodanowe |  | Przedmiot Opodatkowania |
| Stawka | `decimal` | bazodanowe |  | Stawka opodatkowania |
| Systemowe | `bool` | bazodanowe |  | Domyślny przedmiot opatkowania |
| Typ | `Soneta.SrodkiTrwale.TypNieruchomosci` | bazodanowe, enum |  | Nieruchomość |

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
