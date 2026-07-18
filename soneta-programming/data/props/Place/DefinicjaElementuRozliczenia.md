# Pola i właściwości klasy biznesowej: `Soneta.Place.DefinicjaElementuRozliczenia`
Nazwa tabeli: `DefElementowRozl`
Opis: Definicja składnika rozliczenia dla umów zewnętrznych (np. zlecenia z kontrahentami). Określa algorytm naliczania, typ rozliczenia i parametry obliczeniowe dla pozycji dokumentu rozliczenia.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Czas | `Time` | bazodanowe |  |  |
| Edytor | `Soneta.Place.EdytorAlgorytmuRozliczenia` (subrow) | bazodanowe |  |  |
| Edytor.Potrącenie | `bool` |  |  |  |
| GenerujZerowy | `bool` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| Kreator | `Soneta.Place.KreatorAlgorytmuRozliczenia` (subrow) | bazodanowe |  |  |
| Kreator.Cecha | `string` |  |  |  |
| Kreator.Czas | `Soneta.Place.CzasDefElementu` (subrow) | bazodanowe |  |  |
| Kreator.Czas.Czas | `Time` |  |  |  |
| Kreator.Czas.Strefa | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Kreator.Czas.Typ | `Soneta.Place.TypCzasuPracy` (enum) | bazodanowe |  |  |
| Kreator.Czas.WgStrefa | `Key` | podlista |  |  |
| Kreator.Podstawa | `Currency` | bazodanowe |  |  |
| Kreator.PodstawaNazwa | `string` | bazodanowe |  |  |
| Kreator.PodstawaTyp | `Soneta.Place.TypPodstawyRozliczenia` (enum) | bazodanowe |  |  |
| Kreator.PodstawaZa | `Soneta.Place.PodstawaAlgorytmuZa` (enum) | bazodanowe |  |  |
| Kreator.Potrącenie | `bool` |  |  |  |
| Kreator.PrzeliczNa1h | `Soneta.Place.SposobyPrzeliczeniaNa1h` (enum) | bazodanowe |  |  |
| Kreator.SposobProporcjonalnosci | `Soneta.Place.SposobyProporcjonalności` (enum) | bazodanowe |  |  |
| Kreator.Wskaźnik | `string` |  |  |  |
| Kreator.Wspolczynnik | `Soneta.Place.WspolczynnikDefElementu` (subrow) | bazodanowe |  |  |
| Kreator.Wspolczynnik.NazwaWskaznika | `string` | bazodanowe |  |  |
| Kreator.Wspolczynnik.PodstawaStazu | `Soneta.Kadry.DefPodstawyStazu` | bazodanowe |  |  |
| Kreator.Wspolczynnik.PracaNaDzien | `Soneta.Place.TypPracyNaDzień` (enum) | bazodanowe |  |  |
| Kreator.Wspolczynnik.PracaWFirmie | `bool` | bazodanowe |  |  |
| Kreator.Wspolczynnik.Procent | `Percent` |  |  |  |
| Kreator.Wspolczynnik.Progi | `SubTable` | podlista |  |  |
| Kreator.Wspolczynnik.Typ | `Soneta.Place.TypWspolczynnikaAlgorytmu` (enum) | bazodanowe |  |  |
| Kreator.Wspolczynnik.Ulamek | `Fraction` |  |  |  |
| Kreator.Wspolczynnik.WgPodstawaStazu | `Key` | podlista |  |  |
| Kreator.Wspolczynnik.WgStażuPracy | `bool` | tylko-odczyt |  |  |
| Kreator.Wspolczynnik.Wskaznik | `bool` | bazodanowe |  |  |
| Kreator.Wspolczynnik.Wspolczynnik | `decimal` |  |  |  |
| Kreator.Wynagrodzenia | `Soneta.Place.KreatorAlgorytmuRozliczenia.TypWynagrodzenia` (enum) |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Podstawy | `Soneta.Place.PodstawyAlgorytmuRozliczenia` (subrow) | bazodanowe |  |  |
| Podstawy.Czas | `string` | bazodanowe |  |  |
| Podstawy.Dni | `string` | bazodanowe |  |  |
| Podstawy.ElCzas | `string` | bazodanowe |  |  |
| Podstawy.ElDni | `string` | bazodanowe |  |  |
| Podstawy.ElIlosc | `string` | bazodanowe |  |  |
| Podstawy.ElPodstawa | `string` | bazodanowe |  |  |
| Podstawy.ElPodstawa2 | `string` | bazodanowe |  |  |
| Podstawy.ElPodstawa3 | `string` | bazodanowe |  |  |
| Podstawy.ElProcent | `string` | bazodanowe |  |  |
| Podstawy.ElUlamek | `string` | bazodanowe |  |  |
| Podstawy.ElWspolczynnik | `string` | bazodanowe |  |  |
| Podstawy.Ilosc | `string` | bazodanowe |  |  |
| Podstawy.Podstawa | `string` | bazodanowe |  |  |
| Podstawy.Procent | `string` | bazodanowe |  |  |
| Podstawy.Ulamek | `string` | bazodanowe |  |  |
| Podstawy.Wspolczynnik | `string` | bazodanowe |  |  |
| Potracenie | `bool` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Tekst | `MemoText` | bazodanowe, podlista |  |  |
| Typ | `Soneta.Place.TypAlgorytmuRozliczenia` (enum) | bazodanowe |  |  |
| Ulamek | `Fraction` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypWynagrodzenia (`Soneta.Place.KreatorAlgorytmuRozliczenia.TypWynagrodzenia`)
- `PrzeciętneMiesięczne` = 1
- `MinimalnyDochódDeklarowany` = 2
- `Najniższe` = 3
- `NajniższeUczniaIRoku` = 4
- `NajniższeUczniaIIRoku` = 5
- `NajniższeUczniaIIIRoku` = 6
- `MinimalnaPodstawaZdrowotnego` = 7
- `NajniższeMłodocianyPrzyuczany` = 8

### PodstawaAlgorytmuZa (`Soneta.Place.PodstawaAlgorytmuZa`)
- `NieZależyOdCzasu` = 0 — Nie zależy od czasu
- `Godzinę` = 1
- `Miesięcznie` = 2

### SposobyProporcjonalności (`Soneta.Place.SposobyProporcjonalności`)
- `NiePomniejszany` = 0 — Nie
- `Proporcjonalnie` = 1 — Prop.
- `JednaTrzydzista` = 2 — 1/30
- `DniKalendarzowe` = 3 — Kalend.

### SposobyPrzeliczeniaNa1h (`Soneta.Place.SposobyPrzeliczeniaNa1h`)
- `NiePrzeliczaj` = 0
- `WgPlanu` = 1
- `WgArt130KP` = 2 — Wg normy kodeksowej (art. 130 K.P.)
- `WgPlanuArt130KP` = 3 — Wg planu z uwzględnieniem art. 130 K.P.

### TypAlgorytmuRozliczenia (`Soneta.Place.TypAlgorytmuRozliczenia`)
- `KreatorAlgorytmu` = 1
- `EdytorAlgorytmu` = 2

### TypCzasuPracy (`Soneta.Place.TypCzasuPracy`)
- `NieUwzględniaj` = 0
- `WpisanyCzasPracy` = 1
- `NominalnyCzasPracy` = 2
- `RzeczywistyCzasPracy` = 3
- `CzasPracyWNocy` = 4
- `CzasPracyWNiedzieleIŚwięta` = 5
- `CzasPracyWDniDodatkowoWolneOdPracy` = 6
- `CzasPracyWNiedzieleIŚwiętaOrazDniWolneOdPracy` = 7
- `LiczbaNadgodzin50` = 8
- `LiczbaNadgodzin100` = 9
- `LiczbaNadgodzinŚwięta` = 10
- `LiczbaNadgodzin100Święta` = 11 — Liczba nadgodzin 100 święta
- `LiczbaNadgodzinRazem` = 12
- `WgWybranejStrefy` = 13
- `CzasPracyWNormie` = 14
- `LiczbaNadgodzin50Okres` = 15 — Liczba nadgodzin 50 (za okres)
- `LiczbaNadgodzin100Okres` = 16 — Liczba nadgodzin 100 (za okres)
- `LiczbaNadgodzinŚwiętaOkres` = 17 — Liczba nadgodzin święta (za okres)
- `LiczbaNadgodzin100ŚwiętaOkres` = 18 — Liczba nadgodzin 100 święta (za okres)
- `LiczbaNadgodzinRazemOkres` = 19 — Liczba nadgodzin razem (za okres)
- `LiczbaNadgodzin100TylkoDoba` = 20 — Liczba nadgodzin 100 dobowe
- `LiczbaNadgodzin100TylkoOkres` = 21 — Liczba nadgodzin 100 okresowe
- `LiczbaNadgodzin100TylkoDobaOkres` = 22 — Liczba nadgodzin 100 dobowe (za okres)
- `LiczbaNadgodzin100TylkoOkresOkres` = 23 — Liczba nadgodzin 100 okresowe (za okres)
- `RzeczywistyCzasPracyUmowa` = 24 — Rzeczywisty czas pracy (umowa)

### TypPodstawyRozliczenia (`Soneta.Place.TypPodstawyRozliczenia`)
- `Kwota` = 1
- `Cecha` = 2
- `Wskaźnik` = 3
- `KodMetody` = 4
- `Wynagrodzenia` = 10

### TypPracyNaDzień (`Soneta.Place.TypPracyNaDzień`)
- `OstatniDzieńOkresu` = 0 — Ostatni dzień okresu
- `PierwszyDzieńOkresu` = 1
- `OstatniDzieńPoprzedniegoOkresu` = 2

### TypWspolczynnikaAlgorytmu (`Soneta.Place.TypWspolczynnikaAlgorytmu`)
- `BezWspółczynnika` = 0
- `ZależnyOdStażuPracy` = 1
- `Ułamek` = 2
- `Procent` = 3
- `Współczynnik` = 4
- `ZależnyOdStażuPracyZwyczajowego` = 5 — Zależny od stażu pracy (liczonego zwyczajowo)
