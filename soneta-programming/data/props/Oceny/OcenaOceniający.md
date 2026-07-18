# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaOceniający`
Nazwa tabeli: `OcenyOceniajacy`
Tytuł: Oceniający
Opis: Element szczegółowy realizacji oceny (OcenaOceniający). Rejestruje osobę przeprowadzającą ocenę w ramach danej realizacji, z możliwością anulowania, umożliwiając zarządzanie listą oceniających.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Ocena` → `OcenaRealizacja`
Selektor: pole `TypOceny` (`Soneta.Oceny.TypOceny`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe, tylko-odczyt |  |  |
| Arkusze | `SubTable<Soneta.Oceny.OcenaArkusz>` | podlista |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Ocena | `Soneta.Oceny.OcenaRealizacja` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Oceniajacy | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `TypOceny`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Ocena` | 1 | `Soneta.Oceny.OcenaOceniający` |  |
| `Ankieta` | 2 | `Soneta.Ankiety.AnkietaOceniający` | Ankietowany |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Oceniajacy | `IOceniający` | `KontaktOsoba`, `Pracownik`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
