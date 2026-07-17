# Pola i właściwości klasy biznesowej: `Soneta.HR2.KartaOpisuStanowiskaBase`
Nazwa tabeli: `KartyOpStanowisk`
Tytuł: Karty opisu stanowisk
Opis: Dokument karty opisu stanowiska (KOS) tworzony na podstawie definicji stanowiska lub innego źródła. Zbiera w jednym miejscu kompetencje, obowiązki i wymagania dotyczące stanowiska na określony dzień.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.HR2.ElementKartyOpisuStanowiska>` |  |  |  |
| Kompetencje | `Soneta.Business.SubTable<Soneta.HR2.KompetencjaKartyOpisuStanowiska>` |  |  |  |
| RazemElementyOceny | `Soneta.Business.View` |  |  |  |
| TylkoKompetencje | `Soneta.Business.View` |  |  |  |
| TylkoZachowania | `Soneta.Business.View` |  |  |  |
| Typ | `Soneta.HR2.TypyKartOpisuStanowiska` | bazodanowe, enum |  |  |
| Zrodlo | `Soneta.Kadry.IŹródłoKartyOpisuStanowiska` | bazodanowe, iface-ref |  |  |

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
