# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.KSU.KsuDefinicjaInfo`
Nazwa tabeli: `ZklKsuDefInfo`
Tytuł: Informacje pozycji KSU
Opis: Zawiera opisowe informacje dla słownika Katalogu szkoleń i uprawnień. Wykorzystywane do tworzenia słownika i profilu szkoleń.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 4
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CelSzkolenia | `string` | bazodanowe | Cel szkolenia |  |
| GrupaKSU | `Soneta.HR.ZKL.Slowniki.KSU.GrupaSzkolenIUprawnien` | tylko-odczyt |  |  |
| GrupyStanowisk | `SubTable<Soneta.HR.ZKL.Slowniki.KSU.KsuGrupaStanowisk>` | podlista |  |  |
| ObszaryFunkcjonalne | `SubTable<Soneta.HR.ZKL.Slowniki.KSU.KsuObszarFunkcjonalny>` | podlista |  |  |
| PozycjaKsuGuid | `System.Guid` | bazodanowe | Identyfikator pozycji KSU |  |
| PozycjaKsuTyp | `Soneta.HR.ZKL.Enums.KsuPozycjaTyp` (enum) | bazodanowe | Typ pozycji KSU |  |
| SzkoleniaPoprzedzajace | `SubTable<Soneta.HR.ZKL.Slowniki.KSU.KsuSzkoleniePoprzedzajace>` | podlista |  |  |
| UprawnieniaPoprzedzajace | `SubTable<Soneta.HR.ZKL.Slowniki.KSU.KsuUprawnieniePoprzedzajace>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KsuPozycjaTyp (`Soneta.HR.ZKL.Enums.KsuPozycjaTyp`)
- `None` = 0 — Brak
- `Szkolenie` = 10 — Szkolenie
- `Uprawnienie` = 20 — Uprawnienie
- `SzkolenieBhp` = 30 — Szkolenie BHP
