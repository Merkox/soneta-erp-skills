# Pola i właściwości klasy biznesowej: `Soneta.HR2.KartaOpisuStanowiskaBase`
Nazwa tabeli: `KartyOpStanowisk`
Tytuł: Karty opisu stanowisk
Opis: Dokument karty opisu stanowiska (KOS) tworzony na podstawie definicji stanowiska lub innego źródła. Zbiera w jednym miejscu kompetencje, obowiązki i wymagania dotyczące stanowiska na określony dzień.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 5
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.HR2.ElementKartyOpisuStanowiska>` | podlista |  |  |
| Kompetencje | `SubTable<Soneta.HR2.KompetencjaKartyOpisuStanowiska>` | podlista |  |  |
| RazemElementyOceny | `View` | podlista |  |  |
| TylkoKompetencje | `View` | podlista |  |  |
| TylkoZachowania | `View` | podlista |  |  |
| Typ | `Soneta.HR2.TypyKartOpisuStanowiska` (enum) | bazodanowe, tylko-odczyt |  |  |
| Zrodlo | `Soneta.Kadry.IŹródłoKartyOpisuStanowiska` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IŹródłoKartyOpisuStanowiska` | `DefinicjaStanowiska`, `OfertaPracy`, `Pracownik`, `RekrutacjaWakat` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypyKartOpisuStanowiska (`Soneta.HR2.TypyKartOpisuStanowiska`)
- `KartaOpisuStanowiska` = 1
- `OgłoszenieOPracę` = 2
