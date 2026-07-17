# Pola i właściwości klasy biznesowej: `Soneta.Kalend.KalendarzBase`
Nazwa tabeli: `Kalendarze`
Opis: Kalendarz pracy określający normy czasu pracy, zasady rozliczania nadgodzin, godziny nocne oraz powiązanie z domyślną definicją dnia. Może być kalendarzem ogólnym lub indywidualnym kalendarzem pracownika bądź umowy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 52
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Business.MemoText` | bazodanowe |  |  |
| BezWeryfikacjiRegul | `bool` | bazodanowe |  |  |
| BladBraku | `bool` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaDnia | `Soneta.Kalend.DefinicjaDnia` | bazodanowe |  |  |
| Dni | `Soneta.Business.DateSubTable<Soneta.Kalend.DzienKalendarzaBase>` |  |  |  |
| Nadgodziny | `Soneta.Kalend.Nadgodziny` | bazodanowe |  |  |
| Nadgodziny.AlgorytmDobowa | `Soneta.Kalend.AlgorytmNorma` | bazodanowe, enum |  |  |
| Nadgodziny.AlgorytmTygodniowa | `Soneta.Kalend.AlgorytmNorma` | bazodanowe, enum |  |  |
| Nadgodziny.Bilansowanie | `Soneta.Kalend.BilansowanieNadgodzin` | bazodanowe, enum |  |  |
| Nadgodziny.BilansowanieMiesiecznie | `bool` | bazodanowe |  |  |
| Nadgodziny.DlaKazdejUmowy | `Soneta.Place.DlaKażdejUmowy` | bazodanowe, enum |  |  |
| Nadgodziny.DoboweMiesiecznie | `bool` | bazodanowe |  |  |
| Nadgodziny.Nadgodz50 | `Soneta.Types.Time` | bazodanowe |  |  |
| Nadgodziny.NieujemneBilansowanieOkresowe | `bool` | bazodanowe |  |  |
| Nadgodziny.OdDnia | `Soneta.Types.Date` | bazodanowe |  |  |
| Nadgodziny.Okres | `int` | bazodanowe |  |  |
| Nadgodziny.PodstawaWgNormyKP | `bool` | bazodanowe |  |  |
| Nadgodziny.PriorytetOkresowych | `bool` | bazodanowe |  |  |
| Nadgodziny.Przesuniecie | `int` | bazodanowe |  |  |
| Nadgodziny.Rocznie | `bool` | bazodanowe |  |  |
| Nadgodziny.Rozliczaj | `bool` | bazodanowe |  |  |
| Nadgodziny.Rozliczanie | `Soneta.Kalend.RozliczanieNadgodzin` | bazodanowe, enum |  |  |
| Nadgodziny.RozliczanieDobowych | `Soneta.Kalend.RozliczanieDobowych` | bazodanowe, enum |  |  |
| Nadgodziny.SwiateczneMiesiecznie | `bool` | bazodanowe |  |  |
| Nadgodziny.TypOkresu | `Soneta.Kalend.TypOkresuNadgodzin` | bazodanowe, enum |  |  |
| Nadgodziny.WartoscDobowa | `Soneta.Types.Time` | bazodanowe |  |  |
| Nadgodziny.WartoscDobowaTygodniowa | `Soneta.Types.Time` | bazodanowe |  |  |
| Nadgodziny.WartoscTygodniowa | `Soneta.Types.Time` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Net | `Soneta.Kalend.DefinicjaSeriiNet` | bazodanowe |  |  |
| Net.WidocznaWNet | `bool` | bazodanowe |  | Czy definicja jest dostępna z poziomu pulpitów |
| Nocne | `Soneta.Kalend.Nocne` | bazodanowe |  |  |
| Nocne.Do | `Soneta.Types.Time` | bazodanowe |  |  |
| Nocne.DoUI | `Soneta.Types.Time` |  |  |  |
| Nocne.Limit | `Soneta.Types.Time` | bazodanowe |  |  |
| Nocne.Od | `Soneta.Types.Time` | bazodanowe |  |  |
| Nocne.Rozliczaj | `bool` | bazodanowe |  |  |
| Nocne.Standardowe | `bool` |  |  |  |
| NormaDobowa | `Soneta.Types.Time` | bazodanowe |  | Dobowa norma czasu pracy dla limitu urlopu wypoczynkowego |
| PierwszyPrzepracowany | `Soneta.Kalend.RodzajePierwszyPrzepracowany` | bazodanowe, enum |  | Sposób wyliczania pierwszego przepracowanego miesiaca dla urlopu w pierwszym roku zatrudnienia |
| PoczatekDobyPracNiSW | `Soneta.Types.Time` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| RownowaznyCzasPracy | `bool` | bazodanowe |  |  |
| RuchomyCzasPracy | `bool` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Typ | `Soneta.Kalend.TypKalendarza` | bazodanowe, enum |  |  |
| Umowa | `Soneta.Kalend.IUmowaZKalendarzem` | bazodanowe, iface-ref |  |  |
| UwzglWymiarEtatu | `bool` | bazodanowe |  |  |
| WersjonowanieCzas | `bool` | bazodanowe |  |  |
| WersjonowaniePlan | `bool` | bazodanowe |  |  |
| WeryfikacjaRegul | `Soneta.Kalend.WeryfikacjaRegulCzasuPracy` | bazodanowe, enum |  |  |
| Weryfikatory | `Soneta.Business.SubTable<Soneta.Kalend.WeryfikatorKalendarza>` |  |  |  |

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
