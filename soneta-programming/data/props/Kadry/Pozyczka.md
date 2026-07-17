# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Pozyczka`
Nazwa tabeli: `Pozyczki`
Tytuł: Pożyczki
Opis: Pożyczka udzielona pracownikowi z funduszu pożyczkowego. Zawiera datę udzielenia, kwotę, warunki spłaty (ilość rat, kwota raty, oprocentowanie, algorytm), element płacowy wypłaty i spłaty oraz stan spłat.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`, `IRozliczenieWynagrodzeniaHost`, `IBilansOtwarcia`

- pola bazodanowe: 23
- pola kalkulowane (z klas biznesowych): 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AlgorytmRaty | `Soneta.Kadry.AlgorytmRatyPożyczki` | bazodanowe |  |  |
| BilansOtwarcia | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data udzielenia pożyczki |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| ElementRaty | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| Fundusz | `Soneta.Kadry.FundPozyczkowy` | bazodanowe |  |  |
| IloscRat | `int` | bazodanowe |  |  |
| IndywidualnyRachunekBankowy | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| IsVisibleWłączBO | `bool` |  |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  | Kwota udzielonej pożyczki |
| KwotaRaty | `Soneta.Types.Currency` | bazodanowe |  |  |
| OdsetkiZaOdroczenie | `bool` | bazodanowe |  |  |
| OstatniaRata | `Soneta.Kadry.RataPozyczki` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` |  |  |  |
| Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Raty | `Soneta.Business.SubTable<Soneta.Kadry.RataPozyczki>` |  |  |  |
| RazemElementy | `Soneta.Business.ListWithView` |  |  |  |
| Realizacja | `Soneta.Place.WypElementPożyczka` |  |  |  |
| RozliczeniaWynagrodzenia | `Soneta.Business.LpSubTable<Soneta.Place.RozliczenieWynagrodzenia>` |  |  |  |
| RozliczenieWynagrodzenia | `Soneta.Place.RozliczenieWynagrodzenia` |  |  |  |
| Splacona | `bool` | bazodanowe |  |  |
| SplataRoznicy | `Soneta.Kadry.SplataRoznicyZ` | bazodanowe, enum |  |  |
| SplatyOd | `Soneta.Types.YearMonth` | bazodanowe |  |  |
| Sposob | `Soneta.Kadry.SposóbSpłatyOdsetek` | bazodanowe, enum |  |  |
| Spłaty | `Soneta.Business.ListWithView` |  |  |  |
| Stan | `Soneta.Kadry.StanSpłat` | bazodanowe, enum |  |  |
| Typ | `Soneta.Kadry.TypOprocentowania` | bazodanowe, enum |  |  |
| Wypłacona | `bool` |  |  |  |
| Zyrant1 | `Soneta.Core.Osoba` | bazodanowe |  |  |
| Zyrant1.Adres | `string` | bazodanowe |  |  |
| Zyrant1.Osoba | `string` | bazodanowe |  |  |
| Zyrant1.Telefon | `string` | bazodanowe |  |  |
| Zyrant2 | `Soneta.Core.Osoba` | bazodanowe |  |  |
| Żyranci | `Soneta.Business.LpSubTable<Soneta.Kadry.ŻyrantPożyczki>` |  |  |  |
| Żyrant1 | `Soneta.Kadry.Pracownik` |  |  |  |
| Żyrant2 | `Soneta.Kadry.Pracownik` |  |  |  |
| Żyrant3 | `Soneta.Kadry.Pracownik` |  |  |  |
| ŻyrantPożyczki1 | `Soneta.Kadry.ŻyrantPożyczki` |  |  |  |
| ŻyrantPożyczki2 | `Soneta.Kadry.ŻyrantPożyczki` |  |  |  |
| ŻyrantPożyczki3 | `Soneta.Kadry.ŻyrantPożyczki` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SplataRoznicyZ (`Soneta.Kadry.SplataRoznicyZ`)
- `OstatniąRatą` = 0
- `PierwsząRatą` = 1

### SposóbSpłatyOdsetek (`Soneta.Kadry.SposóbSpłatyOdsetek`)
- `NieDotyczy` = 0
- `ZKażdąRatą` = 1 — Z każdą ratą
- `ZPierwsząRatą` = 2 — Z pierwszą ratą
- `ZOstatniąRatą` = 3 — Z ostatnią ratą

### StanSpłat (`Soneta.Kadry.StanSpłat`)
- `NieSpłacona` = 0
- `Częściowo` = 1
- `Całkowicie` = 2

### TypOprocentowania (`Soneta.Kadry.TypOprocentowania`)
- `Nieprocentowane` = 0 — Nieoprocentowane
- `RatyStale` = 1 — Raty stałe
- `RatyZmienne` = 2
- `ZPierwsząRatą` = 3 — Z pierwszą ratą
- `ZOstatniąRatą` = 4 — Z ostatnią ratą
- `ProcentOdKwoty` = 5
- `ProcentOdKwotyRocznie` = 6
- `WgAlgorytmu` = 10
