# Pola i właściwości klasy biznesowej: `Soneta.Przeszeregowania.Przeszeregowanie`
Nazwa tabeli: `Przeszeregowania`
Tytuł: Przeszeregowania pracowników
Opis: Dokument zbiorczego przeszeregowania pracowników na określoną datę. Umożliwia masową zmianę warunków zatrudnienia i wynagrodzeń, z kontrolą stanu realizacji i możliwością zarządzania przez proces wnioskowy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 3
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| DataWykonania | `Date` | bazodanowe, tylko-odczyt |  |  |
| Elementy | `SubTable<Soneta.Przeszeregowania.ElementPrzeszeregowania>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Pracownicy | `System.Collections.Generic.ICollection<Soneta.Kadry.Pracownik>` | podlista |  |  |
| Realizacja | `Soneta.Przeszeregowania.RealizacjaPrzeszeregowania` (enum) | bazodanowe |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| ZarzadzaneWnioskiem | `bool` | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RealizacjaPrzeszeregowania (`Soneta.Przeszeregowania.RealizacjaPrzeszeregowania`)
- `Planowane` = 1
- `Zrealizowane` = 2
- `Anulowane` = 3
