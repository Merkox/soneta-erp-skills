# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.KSU.KsuDefinicjaInfo`
Nazwa tabeli: `ZklKsuDefInfo`
Tytuł: Informacje pozycji KSU
Opis: Zawiera opisowe informacje dla słownika Katalogu szkoleń i uprawnień. Wykorzystywane do tworzenia słownika i profilu szkoleń.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CelSzkolenia | `string` | bazodanowe | Cel szkolenia |  |
| GrupaKSU | `Soneta.HR.ZKL.Slowniki.KSU.GrupaSzkolenIUprawnien` |  |  |  |
| GrupyStanowisk | `Soneta.Business.SubTable<Soneta.HR.ZKL.Slowniki.KSU.KsuGrupaStanowisk>` |  |  |  |
| ObszaryFunkcjonalne | `Soneta.Business.SubTable<Soneta.HR.ZKL.Slowniki.KSU.KsuObszarFunkcjonalny>` |  |  |  |
| PozycjaKsuGuid | `System.Guid` | bazodanowe | Identyfikator pozycji KSU |  |
| PozycjaKsuTyp | `Soneta.HR.ZKL.Enums.KsuPozycjaTyp` | bazodanowe, enum | Typ pozycji KSU |  |
| SzkoleniaPoprzedzajace | `Soneta.Business.SubTable<Soneta.HR.ZKL.Slowniki.KSU.KsuSzkoleniePoprzedzajace>` |  |  |  |
| UprawnieniaPoprzedzajace | `Soneta.Business.SubTable<Soneta.HR.ZKL.Slowniki.KSU.KsuUprawnieniePoprzedzajace>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KsuPozycjaTyp (`Soneta.HR.ZKL.Enums.KsuPozycjaTyp`)
- `None` = 0 — Brak
- `Szkolenie` = 10 — Szkolenie
- `Uprawnienie` = 20 — Uprawnienie
- `SzkolenieBhp` = 30 — Szkolenie BHP
