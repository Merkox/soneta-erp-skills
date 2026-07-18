# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaOceniany`
Nazwa tabeli: `OcenyOceniani`
Tytuł: Oceniani
Opis: Element szczegółowy realizacji oceny (OcenaOceniany). Rejestruje osobę podlegającą ocenie w ramach danej realizacji, z możliwością anulowania, umożliwiając zarządzanie listą ocenianych pracowników.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Ocena` → `OcenaRealizacja`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe, tylko-odczyt |  |  |
| Arkusze | `SubTable<Soneta.Oceny.OcenaArkusz>` | podlista |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Ocena | `Soneta.Oceny.OcenaRealizacja` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Oceniany | `Soneta.Oceny.IOceniany` | bazodanowe, iface-ref |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Oceniany | `IOceniany` | `GrupaSzkol`, `OcenaPowiaz`, `Pracownik`, `RealizacjaSzkolenia`, `UczestnikBase` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
