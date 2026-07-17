# Pola i właściwości klasy biznesowej: `Soneta.Przeszeregowania.Przeszeregowanie`
Nazwa tabeli: `Przeszeregowania`
Tytuł: Przeszeregowania pracowników
Opis: Dokument zbiorczego przeszeregowania pracowników na określoną datę. Umożliwia masową zmianę warunków zatrudnienia i wynagrodzeń, z kontrolą stanu realizacji i możliwością zarządzania przez proces wnioskowy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataWykonania | `Soneta.Types.Date` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Przeszeregowania.ElementPrzeszeregowania>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Pracownicy | `System.Collections.Generic.ICollection<Soneta.Kadry.Pracownik>` |  |  |  |
| Realizacja | `Soneta.Przeszeregowania.RealizacjaPrzeszeregowania` | bazodanowe, enum |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ZarzadzaneWnioskiem | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RealizacjaPrzeszeregowania (`Soneta.Przeszeregowania.RealizacjaPrzeszeregowania`)
- `Planowane` = 1
- `Zrealizowane` = 2
- `Anulowane` = 3
