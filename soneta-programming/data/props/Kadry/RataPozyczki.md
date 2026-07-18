# Pola i właściwości klasy biznesowej: `Soneta.Kadry.RataPozyczki`
Nazwa tabeli: `RatyPozyczek`
Tytuł: Raty pożyczek
Opis: Element szczegółowy pożyczki (Pozyczka). Pojedyncza rata pożyczki pracowniczej z kwotą kapitału i odsetek, datą płatności, elementem płacowym, stanem spłaty oraz ewentualnym żyrantem lub innym spłacającym.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 12
- podlisty: 3
- subrowy: 0
- razem: 23

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywneElementy | `System.Collections.Generic.IEnumerable<Soneta.Place.WypElement>` | podlista |  |  |
| BilansOtwarcia | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| Kapital | `Currency` | bazodanowe |  |  |
| Miesiąc | `YearMonth` |  |  |  |
| Odsetki | `Currency` | bazodanowe |  |  |
| Pozostaje | `Currency` | tylko-odczyt |  |  |
| PozostajeKapitał | `Currency` | tylko-odczyt |  |  |
| PozostajeOdsetki | `Currency` | tylko-odczyt |  |  |
| Pozyczka | `Soneta.Kadry.Pozyczka` | bazodanowe, tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | tylko-odczyt |  |  |
| Razem | `Currency` | tylko-odczyt |  |  |
| RazemKapitał | `Currency` | tylko-odczyt |  |  |
| RazemOdsetki | `Currency` | tylko-odczyt |  |  |
| RazemSpłaty | `Currency` | tylko-odczyt |  |  |
| Splacajacy | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| SpłacającyInfo | `Soneta.Kadry.Pracownik` | tylko-odczyt |  |  |
| Spłaty | `View` | podlista |  |  |
| Stan | `Soneta.Kadry.StanSpłat` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wartosc | `Currency` | tylko-odczyt |  |  |
| Zyrant | `Soneta.Kadry.Pracownik` | bazodanowe | Żyrant |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanSpłat (`Soneta.Kadry.StanSpłat`)
- `NieSpłacona` = 0
- `Częściowo` = 1
- `Całkowicie` = 2
