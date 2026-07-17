# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaFunduszuPozyczkowego`
Nazwa tabeli: `DefFundPozycz`
Tytuł: Definicje funduszy pożyczkowych
Opis: Definicja funduszu pożyczkowego pracowniczego. Określa zasady oprocentowania, elementy płacowe (wpisowe, składka, wycofanie wkładu), warunki spłaty, wymagania dotyczące żyrantów oraz powiązania z centrum kosztów i rachunkami bankowymi.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IZakresDefinicji`

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| CentrumKosztow | `Soneta.Core.CentrumKosztow` | bazodanowe |  |  |
| DefinicjeElementow | `Soneta.Business.SubTable<Soneta.Place.DefinicjaElementu>` |  |  |  |
| JendostkaOrganizacyjna | `Soneta.Kadry.Wydzial` |  |  |  |
| Kod | `string` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Oprocentowanie | `Soneta.Kadry.OprocentowaniePozyczki` | bazodanowe |  |  |
| Oprocentowanie.Ilosc | `int` | bazodanowe |  |  |
| Oprocentowanie.OdsetkiZaOdroczenie | `bool` | bazodanowe |  |  |
| Oprocentowanie.Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Oprocentowanie.Sposob | `Soneta.Kadry.SposóbSpłatyOdsetek` | bazodanowe, enum |  |  |
| Oprocentowanie.Typ | `Soneta.Kadry.TypOprocentowania` | bazodanowe, enum |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieWplatWyplat` | bazodanowe |  |  |
| Rozliczenie.DefinicjaWplaty | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu wpłaty gotówkowej do funduszu |
| Rozliczenie.DefinicjaWylaty | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu wypłaty gotówkowej z funduszu |
| Rozliczenie.Kasa | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  | Kasa, w oparciu o którą realizowane są rozliczenia gotówkowe z funduszu |
| Rozliczenie.Konto | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  | Kasa, w oparciu o którą realizowane są rozliczenia gotówkowe z funduszu |
| Rozliczenie.OrganizacjaZarzadzajaca | `Soneta.CRM.Kontrahent` | bazodanowe |  | Kontrahenci funduszy pożyszkowych |
| Rozliczenie.WgDefinicjaWplaty | `Soneta.Business.Key` |  |  |  |
| Rozliczenie.WgDefinicjaWylaty | `Soneta.Business.Key` |  |  |  |
| Rozliczenie.WgKasa | `Soneta.Business.Key` |  |  |  |
| Rozliczenie.WgKonto | `Soneta.Business.Key` |  |  |  |
| Rozliczenie.WgOrganizacjaZarzadzajaca | `Soneta.Business.Key` |  |  |  |
| Skladka | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| SplataRoznicy | `Soneta.Kadry.SplataRoznicyZ` | bazodanowe, enum |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Wpisowe | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| WycofanieWkladu | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Wydziały | `Soneta.Business.SubTable<Soneta.Kadry.WydziałDefFundPozy>` |  |  |  |
| Zyranci | `Soneta.Kadry.RodzajeŻyrantów` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeŻyrantów (`Soneta.Kadry.RodzajeŻyrantów`)
- `TylkoCzłonekFunduszu` = 0 — Tylko członek funduszu
- `KażdyPracownik` = 1

### SplataRoznicyZ (`Soneta.Kadry.SplataRoznicyZ`)
- `OstatniąRatą` = 0
- `PierwsząRatą` = 1

### SposóbSpłatyOdsetek (`Soneta.Kadry.SposóbSpłatyOdsetek`)
- `NieDotyczy` = 0
- `ZKażdąRatą` = 1 — Z każdą ratą
- `ZPierwsząRatą` = 2 — Z pierwszą ratą
- `ZOstatniąRatą` = 3 — Z ostatnią ratą

### TypOprocentowania (`Soneta.Kadry.TypOprocentowania`)
- `Nieprocentowane` = 0 — Nieoprocentowane
- `RatyStale` = 1 — Raty stałe
- `RatyZmienne` = 2
- `ZPierwsząRatą` = 3 — Z pierwszą ratą
- `ZOstatniąRatą` = 4 — Z ostatnią ratą
- `ProcentOdKwoty` = 5
- `ProcentOdKwotyRocznie` = 6
- `WgAlgorytmu` = 10
