# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Pozyczka`
Nazwa tabeli: `Pozyczki`
Tytuł: Pożyczki
Opis: Pożyczka udzielona pracownikowi z funduszu pożyczkowego. Zawiera datę udzielenia, kwotę, warunki spłaty (ilość rat, kwota raty, oprocentowanie, algorytm), element płacowy wypłaty i spłaty oraz stan spłat.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`, `IRozliczenieWynagrodzeniaHost`, `IBilansOtwarcia`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AlgorytmRaty | `Soneta.Kadry.AlgorytmRatyPożyczki` | bazodanowe |  |  |
| BilansOtwarcia | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  | Data udzielenia pożyczki |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| ElementRaty | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| Fundusz | `Soneta.Kadry.FundPozyczkowy` | bazodanowe, tylko-odczyt |  |  |
| IloscRat | `int` | bazodanowe |  |  |
| IndywidualnyRachunekBankowy | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| IsVisibleWłączBO | `bool` | tylko-odczyt |  |  |
| Kwota | `Currency` | bazodanowe |  | Kwota udzielonej pożyczki |
| KwotaRaty | `Currency` | bazodanowe |  |  |
| OdsetkiZaOdroczenie | `bool` | bazodanowe |  |  |
| OstatniaRata | `Soneta.Kadry.RataPozyczki` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | tylko-odczyt |  |  |
| Procent | `Percent` | bazodanowe |  |  |
| Raty | `SubTable<Soneta.Kadry.RataPozyczki>` | podlista |  |  |
| RazemElementy | `ListWithView` | podlista |  |  |
| Realizacja | `Soneta.Place.WypElementPożyczka` | tylko-odczyt |  |  |
| RozliczeniaWynagrodzenia | `LpSubTable<Soneta.Place.RozliczenieWynagrodzenia>` | podlista |  |  |
| RozliczenieWynagrodzenia | `Soneta.Place.RozliczenieWynagrodzenia` | tylko-odczyt |  |  |
| Splacona | `bool` | bazodanowe, tylko-odczyt |  |  |
| SplataRoznicy | `Soneta.Kadry.SplataRoznicyZ` (enum) | bazodanowe |  |  |
| SplatyOd | `YearMonth` | bazodanowe |  |  |
| Sposob | `Soneta.Kadry.SposóbSpłatyOdsetek` (enum) | bazodanowe |  |  |
| Spłaty | `ListWithView` | podlista |  |  |
| Stan | `Soneta.Kadry.StanSpłat` (enum) | bazodanowe, tylko-odczyt |  |  |
| Typ | `Soneta.Kadry.TypOprocentowania` (enum) | bazodanowe |  |  |
| Wypłacona | `bool` | tylko-odczyt |  |  |
| Zyrant1 | `Soneta.Core.Osoba` (subrow) | bazodanowe |  |  |
| Zyrant1.Adres | `string` | bazodanowe |  |  |
| Zyrant1.Osoba | `string` | bazodanowe |  |  |
| Zyrant1.Telefon | `string` | bazodanowe |  |  |
| Zyrant2 | `Soneta.Core.Osoba` (subrow) | bazodanowe |  |  |
| Żyranci | `LpSubTable<Soneta.Kadry.ŻyrantPożyczki>` | podlista |  |  |
| Żyrant2 | `Soneta.Kadry.Pracownik` | tylko-odczyt |  |  |
| Żyrant3 | `Soneta.Kadry.Pracownik` | tylko-odczyt |  |  |
| ŻyrantPożyczki1 | `Soneta.Kadry.ŻyrantPożyczki` | tylko-odczyt |  |  |
| ŻyrantPożyczki2 | `Soneta.Kadry.ŻyrantPożyczki` | tylko-odczyt |  |  |
| ŻyrantPożyczki3 | `Soneta.Kadry.ŻyrantPożyczki` | tylko-odczyt |  |  |

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
