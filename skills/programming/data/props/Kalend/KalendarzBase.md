# Pola i właściwości klasy biznesowej: `Soneta.Kalend.KalendarzBase`
Nazwa tabeli: `Kalendarze`
Opis: Kalendarz pracy określający normy czasu pracy, zasady rozliczania nadgodzin, godziny nocne oraz powiązanie z domyślną definicją dnia. Może być kalendarzem ogólnym lub indywidualnym kalendarzem pracownika bądź umowy.
Tabela konfiguracyjna: Nie
Guided: root
Selektor: pole `Typ` (`Soneta.Kalend.TypKalendarza`) — wiele typów w jednej tabeli, podtypów: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `MemoText` | bazodanowe, podlista |  |  |
| BezWeryfikacjiRegul | `bool` | bazodanowe |  |  |
| BladBraku | `bool` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaDnia | `Soneta.Kalend.DefinicjaDnia` | bazodanowe |  |  |
| Dni | `DateSubTable<Soneta.Kalend.DzienKalendarzaBase>` | podlista |  |  |
| Nadgodziny | `Soneta.Kalend.Nadgodziny` (subrow) | bazodanowe |  |  |
| Nadgodziny.AlgorytmDobowa | `Soneta.Kalend.AlgorytmNorma` (enum) | bazodanowe |  |  |
| Nadgodziny.AlgorytmTygodniowa | `Soneta.Kalend.AlgorytmNorma` (enum) | bazodanowe |  |  |
| Nadgodziny.Bilansowanie | `Soneta.Kalend.BilansowanieNadgodzin` (enum) | bazodanowe |  |  |
| Nadgodziny.BilansowanieMiesiecznie | `bool` | bazodanowe |  |  |
| Nadgodziny.DlaKazdejUmowy | `Soneta.Place.DlaKażdejUmowy` (enum) | bazodanowe |  |  |
| Nadgodziny.DoboweMiesiecznie | `bool` | bazodanowe |  |  |
| Nadgodziny.Nadgodz50 | `Time` | bazodanowe |  |  |
| Nadgodziny.NieujemneBilansowanieOkresowe | `bool` | bazodanowe |  |  |
| Nadgodziny.OdDnia | `Date` | bazodanowe |  |  |
| Nadgodziny.Okres | `int` | bazodanowe |  |  |
| Nadgodziny.PodstawaWgNormyKP | `bool` | bazodanowe |  |  |
| Nadgodziny.PriorytetOkresowych | `bool` | bazodanowe |  |  |
| Nadgodziny.Przesuniecie | `int` | bazodanowe |  |  |
| Nadgodziny.Rocznie | `bool` | bazodanowe |  |  |
| Nadgodziny.Rozliczaj | `bool` | bazodanowe |  |  |
| Nadgodziny.Rozliczanie | `Soneta.Kalend.RozliczanieNadgodzin` (enum) | bazodanowe |  |  |
| Nadgodziny.RozliczanieDobowych | `Soneta.Kalend.RozliczanieDobowych` (enum) | bazodanowe |  |  |
| Nadgodziny.SwiateczneMiesiecznie | `bool` | bazodanowe |  |  |
| Nadgodziny.TypOkresu | `Soneta.Kalend.TypOkresuNadgodzin` (enum) | bazodanowe |  |  |
| Nadgodziny.WartoscDobowa | `Time` | bazodanowe |  |  |
| Nadgodziny.WartoscDobowaTygodniowa | `Time` | bazodanowe |  |  |
| Nadgodziny.WartoscTygodniowa | `Time` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Net | `Soneta.Kalend.DefinicjaSeriiNet` (subrow) | bazodanowe |  |  |
| Net.WidocznaWNet | `bool` | bazodanowe |  | Czy definicja jest dostępna z poziomu pulpitów |
| Nocne | `Soneta.Kalend.Nocne` (subrow) | bazodanowe |  |  |
| Nocne.Do | `Time` | bazodanowe |  |  |
| Nocne.DoUI | `Time` |  |  |  |
| Nocne.Limit | `Time` | bazodanowe |  |  |
| Nocne.Od | `Time` | bazodanowe |  |  |
| Nocne.Rozliczaj | `bool` | bazodanowe |  |  |
| Nocne.Standardowe | `bool` |  |  |  |
| NormaDobowa | `Time` | bazodanowe |  | Dobowa norma czasu pracy dla limitu urlopu wypoczynkowego |
| PierwszyPrzepracowany | `Soneta.Kalend.RodzajePierwszyPrzepracowany` (enum) | bazodanowe |  | Sposób wyliczania pierwszego przepracowanego miesiaca dla urlopu w pierwszym roku zatrudnienia |
| PoczatekDobyPracNiSW | `Time` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| RownowaznyCzasPracy | `bool` | bazodanowe |  |  |
| RuchomyCzasPracy | `bool` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Typ | `Soneta.Kalend.TypKalendarza` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Umowa | `Soneta.Kalend.IUmowaZKalendarzem` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| UwzglWymiarEtatu | `bool` | bazodanowe |  |  |
| WersjonowanieCzas | `bool` | bazodanowe |  |  |
| WersjonowaniePlan | `bool` | bazodanowe |  |  |
| WeryfikacjaRegul | `Soneta.Kalend.WeryfikacjaRegulCzasuPracy` (enum) | bazodanowe |  |  |
| Weryfikatory | `SubTable<Soneta.Kalend.WeryfikatorKalendarza>` | podlista |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Kalendarz` | 1 | `Soneta.Kalend.Kalendarz` | Kalendarz |
| `KalendarzPracownika` | 2 | `Soneta.Kalend.KalendarzPracownika` |  |
| `SeriaDni` | 3 | `Soneta.Kalend.SeriaDni` | Seria dni |
| `KalendarzUmowy` | 4 | `Soneta.Kalend.KalendarzUmowy` |  |
| `KalendarzPlanuKopia` | 10 | `Soneta.Kalend.KalendarzPlanuKopia` |  |
| `KalendarzPracyKopia` | 11 | `Soneta.Kalend.KalendarzPracyKopia` |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Umowa | `IUmowaZKalendarzem` | `Umowa`, `UmowaZewnetrzna` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AlgorytmNorma (`Soneta.Kalend.AlgorytmNorma`)
- `Brak` = 0 — Brak
- `Kalendarz` = 1
- `Konfiguracja` = 2
- `RównoważnyCzasPracy` = 3

### BilansowanieNadgodzin (`Soneta.Kalend.BilansowanieNadgodzin`)
- `Brak` = 0
- `_50` = 1
- `_50_100` = 2
- `_50_SW` = 3
- `_50_100_SW` = 4
- `_50_SW_100` = 5
- `_100` = 6
- `_100_50` = 7
- `_100_SW` = 8
- `_100_50_SW` = 9
- `_100_SW_50` = 10
- `_SW` = 11
- `_SW_50` = 12
- `_SW_100` = 13
- `_SW_50_100` = 14
- `_SW_100_50` = 15

### RodzajePierwszyPrzepracowany (`Soneta.Kalend.RodzajePierwszyPrzepracowany`)
- `LiczOdDatyZatrudnienia` = 0
- `UwzględniajŚwiąteczne` = 1 — Uwzględniaj dni świąteczne poprzedzające datę zatrudnienia
- `UwzględniajŚwiąteczneIWolne` = 2 — Uwzględniaj dni świąteczne i wolne poprzedzające datę zatrudnienia

### RozliczanieDobowych (`Soneta.Kalend.RozliczanieDobowych`)
- `WgCzasu` = 0 — czasu
- `WgStref` = 1 — stref

### RozliczanieNadgodzin (`Soneta.Kalend.RozliczanieNadgodzin`)
- `Brak` = 0
- `Zawsze50` = 1
- `DoLimitu50` = 2
- `Zawsze100` = 3

### TypKalendarza (`Soneta.Kalend.TypKalendarza`)
- `Kalendarz` = 1
- `KalendarzPracownika` = 2
- `SeriaDni` = 3
- `KalendarzUmowy` = 4
- `KalendarzAktualizacjiPracownika` = 5
- `KalendarzAktualizacjiUmowy` = 6
- `KalendarzPlanuKopia` = 10
- `KalendarzPracyKopia` = 11

### TypOkresuNadgodzin (`Soneta.Kalend.TypOkresuNadgodzin`)
- `Miesięczny` = 0
- `Tygodniowy` = 1
- `WgDefinicjiElementu` = 2

### WeryfikacjaRegulCzasuPracy (`Soneta.Kalend.WeryfikacjaRegulCzasuPracy`)
- `Tak` = 0 — Tak
- `Nie` = 1 — Nie
- `Covid19` = 2 — COVID-19

### DlaKażdejUmowy (`Soneta.Place.DlaKażdejUmowy`)
- `Nie` = 0
- `Tak` = 1
- `Domyślnie` = 2
