# Pola i właściwości klasy biznesowej: `Soneta.Towary.SchemOpakowan`
Nazwa tabeli: `SchemyOpakowan`
Tytuł: Schematy opakowań/gratisów
Opis: Definicja schematu opakowań zwrotnych (kaucyjnych)/gratisów stosowanego w obrocie towarowym. Schemat określa kod, nazwę i zestaw elementów opakowań/gratisów przypisywanych do towarów, umożliwiając automatyczne generowanie pozycji opakowaniowych/gratisowych na dokumentach handlowych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 10
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 5
- podlisty: 4
- subrowy: 0
- razem: 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Elementy | `LpSubTable<Soneta.Towary.ElemOpakowan>` | podlista |  |  |
| Kod | `string` | bazodanowe |  | Symbol, skrócona nazwa schematu. |
| LacznaIlosc | `int` | bazodanowe | Łączna ilość gratisów | Łączna ilość gratisów. |
| LacznaWartosc | `Currency` | bazodanowe | Łączna wartość | Łączna wartość towarów/dokumentu. |
| Nazwa | `string` | bazodanowe |  | Nazwa schematu. |
| Obowiazuje | `Soneta.Towary.SchemGratisowObowiazuje` (enum) | bazodanowe | Obowiązuje | Obowiązuje. |
| ObowiazujeOpis | `string` | tylko-odczyt |  |  |
| ObslugaNaDokumentach | `Soneta.Towary.SchematOpakObslugaNaDokumentach` (enum) | tylko-odczyt | Obsługa na dokumentach |  |
| ObslugaNaDokumentachOpis | `string` | tylko-odczyt |  |  |
| Przecena | `bool` | bazodanowe | Dostępny na przecenie | Dostępny na przecenie. |
| Przeceny | `View` | podlista |  |  |
| PrzecenyDlaSchematu | `SubTable<Soneta.Towary.PrzecenaOkresowaTowaruSchematGratisow>` | podlista |  |  |
| RodzajCeny | `Soneta.Towary.PoleZCenaDlaGratisow` (enum) | bazodanowe | Rodzaj ceny | Rodzaj ceny. |
| RodzajSchemGratisow | `Soneta.Towary.RodzajSchemGratisow` (enum) | bazodanowe | Rodzaj schematu gratisów | Rodzaj schematu gratisów. |
| RodzajSchemGratisowOpis | `string` | tylko-odczyt |  |  |
| SchematyTowary | `SubTable<Soneta.Towary.SchematTowar>` | podlista |  |  |
| Typ | `Soneta.Towary.TypSchematu` (enum) | bazodanowe |  | Typ schematu. |
| Zablokowany | `bool` | tylko-odczyt |  |  |
| ZbiorczaIlosc | `int` | bazodanowe | Zbiorcza ilość | Zbiorcza ilość. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PoleZCenaDlaGratisow (`Soneta.Towary.PoleZCenaDlaGratisow`)
- `Cena` = 0
- `CenaPoRabacie` = 1

### RodzajSchemGratisow (`Soneta.Towary.RodzajSchemGratisow`)
- `Brak` = 0
- `Pojedynczy` = 1 — Pojedynczy
- `Mnogi` = 2 — Mnogi
- `Calosciowy` = 3 — Całościowy

### SchemGratisowObowiazuje (`Soneta.Towary.SchemGratisowObowiazuje`)
- `Brak` = 0
- `Pojedynczo` = 1 — Pojedynczo
- `Mnogo` = 2 — Mnogo
- `WCalosci` = 3 — W całości
- `OdLacznejWartosciTowarow` = 4 — Od łącznej wartości towarów
- `OdLacznejWartosciDokumentu` = 5 — Od łącznej wartości dokumentu

### SchematOpakObslugaNaDokumentach (`Soneta.Towary.SchematOpakObslugaNaDokumentach`)
- `Pozycja` = 0 — Za pomocą pozycji
- `RelacjaKaucji` = 1 — Za pomocą relacji kaucji
- `Razem` = 99

### TypSchematu (`Soneta.Towary.TypSchematu`)
- `Opakowan` = 0
- `Gratisow` = 1
