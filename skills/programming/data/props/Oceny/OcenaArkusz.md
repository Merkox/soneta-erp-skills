# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaArkusz`
Nazwa tabeli: `OcenyArkusze`
Tytuł: Arkusze oceny
Opis: Arkusz oceny wypełniany przez oceniającego dla konkretnego ocenianego w ramach realizacji oceny. Przechowuje typ, etap, wartość zagregowaną i punktację, łącząc definicję arkusza z uczestnikami procesu oceniania.
Tabela konfiguracyjna: Nie
Guided: root
Selektor: pole `TypOceny` (`Soneta.Oceny.TypOceny`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Częściowe | `System.Collections.Generic.IEnumerable<Soneta.Oceny.OcenaArkusz>` | podlista |  |  |
| DefinicjaArkusza | `Soneta.Oceny.DefinicjaArkuszaOceny` | bazodanowe |  |  |
| Etap | `Soneta.Oceny.EtapyArkuszaOceny` (enum) | bazodanowe, tylko-odczyt |  |  |
| Kategorie | `SubTable<Soneta.Oceny.OcenaKategoriaArkusza>` | podlista |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| NazwaKontrahenta | `string` | bazodanowe | Nazwa kontrahenta |  |
| Ocena | `Soneta.Oceny.OcenaRealizacja` | bazodanowe, tylko-odczyt |  |  |
| Oceniajacy | `Soneta.Oceny.OcenaOceniający` | bazodanowe |  |  |
| OceniajacyRef | `Soneta.Oceny.IOceniający` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Oceniany | `Soneta.Oceny.OcenaOceniany` | bazodanowe |  |  |
| OcenianyRef | `Soneta.Oceny.IOceniany` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Oczekujący | `bool` | tylko-odczyt |  |  |
| Podstawa | `decimal` | tylko-odczyt |  |  |
| Pozycje | `LpSubTable<Soneta.Oceny.OcenaPozycjaArkusza>` | podlista |  |  |
| Przygotowywany | `bool` | tylko-odczyt |  |  |
| Punktacja | `decimal` | bazodanowe | Punktacja |  |
| RazemElementyOceny | `View` | podlista |  |  |
| TylkoElementyOceny | `View` | podlista |  |  |
| TylkoKompetencje | `View` | podlista |  |  |
| TylkoZachowania | `View` | podlista |  |  |
| TylkoZadania | `View` | podlista |  |  |
| Typ | `Soneta.Oceny.TypArkuszaOceny` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Wartosc | `Percent` | bazodanowe, tylko-odczyt |  |  |
| WartoscWgKategorii | `bool` | bazodanowe, tylko-odczyt |  |  |
| WartoscWgWagi | `Percent` | bazodanowe, tylko-odczyt |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `TypOceny`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Ocena` | 1 | `Soneta.Oceny.OcenaArkusz` |  |
| `Ankieta` | 2 | `Soneta.Ankiety.AnkietaArkusz` | Arkusz ankiety |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| OceniajacyRef | `IOceniający` | `KontaktOsoba`, `Pracownik`, `WykladowcaSzkol` |
| OcenianyRef | `IOceniany` | `GrupaSzkol`, `OcenaPowiaz`, `Pracownik`, `RealizacjaSzkolenia`, `UczestnikBase` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### EtapyArkuszaOceny (`Soneta.Oceny.EtapyArkuszaOceny`)
- `Przygotowywany` = 1
- `Wypełniany` = 2
- `Niezaakceptowany` = 3
- `DoAkceptacji` = 4
- `Wypełniony` = 5
- `Zatwierdzony` = 10
- `Anulowany` = 11
- `Oczekujący` = 12

### TypArkuszaOceny (`Soneta.Oceny.TypArkuszaOceny`)
- `Jednokrotny` = 1
- `Częściowy` = 2
- `Zbiorczy` = 3

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
