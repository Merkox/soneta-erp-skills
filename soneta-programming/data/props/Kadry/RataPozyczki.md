# Pola i właściwości klasy biznesowej: `Soneta.Kadry.RataPozyczki`
Nazwa tabeli: `RatyPozyczek`
Tytuł: Raty pożyczek
Opis: Element szczegółowy pożyczki (Pozyczka). Pojedyncza rata pożyczki pracowniczej z kwotą kapitału i odsetek, datą płatności, elementem płacowym, stanem spłaty oraz ewentualnym żyrantem lub innym spłacającym.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywneElementy | `System.Collections.Generic.IEnumerable<Soneta.Place.WypElement>` |  |  |  |
| BilansOtwarcia | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| Kapital | `Soneta.Types.Currency` | bazodanowe |  |  |
| Miesiąc | `Soneta.Types.YearMonth` |  |  |  |
| Odsetki | `Soneta.Types.Currency` | bazodanowe |  |  |
| Pozostaje | `Soneta.Types.Currency` |  |  |  |
| PozostajeKapitał | `Soneta.Types.Currency` |  |  |  |
| PozostajeOdsetki | `Soneta.Types.Currency` |  |  |  |
| Pozyczka | `Soneta.Kadry.Pozyczka` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` |  |  |  |
| Razem | `Soneta.Types.Currency` |  |  |  |
| RazemKapitał | `Soneta.Types.Currency` |  |  |  |
| RazemOdsetki | `Soneta.Types.Currency` |  |  |  |
| RazemSpłaty | `Soneta.Types.Currency` |  |  |  |
| Splacajacy | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| SpłacającyInfo | `Soneta.Kadry.Pracownik` |  |  |  |
| Spłaty | `Soneta.Business.View` |  |  |  |
| Stan | `Soneta.Kadry.StanSpłat` | bazodanowe, enum |  |  |
| Wartosc | `Soneta.Types.Currency` |  |  |  |
| Zyrant | `Soneta.Kadry.Pracownik` | bazodanowe | Żyrant |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanSpłat (`Soneta.Kadry.StanSpłat`)
- `NieSpłacona` = 0
- `Częściowo` = 1
- `Całkowicie` = 2
