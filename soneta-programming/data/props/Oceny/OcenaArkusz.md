# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaArkusz`
Nazwa tabeli: `OcenyArkusze`
Tytuł: Arkusze oceny
Opis: Arkusz oceny wypełniany przez oceniającego dla konkretnego ocenianego w ramach realizacji oceny. Przechowuje typ, etap, wartość zagregowaną i punktację, łącząc definicję arkusza z uczestnikami procesu oceniania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Częściowe | `System.Collections.Generic.IEnumerable<Soneta.Oceny.OcenaArkusz>` |  |  |  |
| DefinicjaArkusza | `Soneta.Oceny.DefinicjaArkuszaOceny` | bazodanowe |  |  |
| Etap | `Soneta.Oceny.EtapyArkuszaOceny` | bazodanowe, enum |  |  |
| Kategorie | `Soneta.Business.SubTable<Soneta.Oceny.OcenaKategoriaArkusza>` |  |  |  |
| Nazwa | `string` |  |  |  |
| NazwaKontrahenta | `string` | bazodanowe | Nazwa kontrahenta |  |
| Ocena | `Soneta.Oceny.OcenaRealizacja` | bazodanowe |  |  |
| Oceniajacy | `Soneta.Oceny.OcenaOceniający` | bazodanowe |  |  |
| OceniajacyRef | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| Oceniany | `Soneta.Oceny.OcenaOceniany` | bazodanowe |  |  |
| OcenianyRef | `Soneta.Oceny.IOceniany` | bazodanowe, iface-ref |  |  |
| Oczekujący | `bool` |  |  |  |
| Podstawa | `decimal` |  |  |  |
| Pozycje | `Soneta.Business.LpSubTable<Soneta.Oceny.OcenaPozycjaArkusza>` |  |  |  |
| Przygotowywany | `bool` |  |  |  |
| Punktacja | `decimal` | bazodanowe | Punktacja |  |
| RazemElementyOceny | `Soneta.Business.View` |  |  |  |
| TylkoElementyOceny | `Soneta.Business.View` |  |  |  |
| TylkoKompetencje | `Soneta.Business.View` |  |  |  |
| TylkoZachowania | `Soneta.Business.View` |  |  |  |
| TylkoZadania | `Soneta.Business.View` |  |  |  |
| Typ | `Soneta.Oceny.TypArkuszaOceny` | bazodanowe, enum |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |
| Wartosc | `Soneta.Types.Percent` | bazodanowe |  |  |
| WartoscWgKategorii | `bool` | bazodanowe |  |  |
| WartoscWgWagi | `Soneta.Types.Percent` | bazodanowe |  |  |

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
