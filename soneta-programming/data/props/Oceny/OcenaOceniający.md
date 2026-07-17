# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaOceniający`
Nazwa tabeli: `OcenyOceniajacy`
Tytuł: Oceniający
Opis: Element szczegółowy realizacji oceny (OcenaOceniający). Rejestruje osobę przeprowadzającą ocenę w ramach danej realizacji, z możliwością anulowania, umożliwiając zarządzanie listą oceniających.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Ocena` → `OcenaRealizacja`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe |  |  |
| Arkusze | `Soneta.Business.SubTable<Soneta.Oceny.OcenaArkusz>` |  |  |  |
| Nazwa | `string` |  |  |  |
| Ocena | `Soneta.Oceny.OcenaRealizacja` | bazodanowe, guided-parent |  |  |
| Oceniajacy | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |

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
