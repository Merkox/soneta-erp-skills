# Pola i właściwości klasy biznesowej: `Soneta.Kalend.Nieobecnosc`
Nazwa tabeli: `Nieobecnosci`
Tytuł: Nieobecności
Opis: Rejestracja nieobecności pracownika. Przechowuje okres, definicję nieobecności, normę czasu pracy, dane zwolnienia ZUS (e-ZLA), urlopy wypoczynkowe/okolicznościowe/macierzyńskie/wychowawcze oraz informacje o rozliczeniu i korekcie.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IZrodloNieobecnosci`, `IBazaZrodlaWyplaty`, `IBilansOtwarcia`, `IZrodloDeklaracji`

- pola bazodanowe: 45
- pola kalkulowane (z klas biznesowych): 44

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BackColor | `int` |  | Kolor tła |  |
| BilansOtwarcia | `bool` | bazodanowe |  |  |
| BlokadaOkresu | `bool` |  |  |  |
| Czas | `Soneta.Types.Time` |  |  |  |
| CzescUrlopu | `int` | bazodanowe |  |  |
| CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe |  |  |
| Deklaracje | `Soneta.Business.SubTable` |  |  |  |
| Dni | `int` |  |  |  |
| DoGodziny | `Soneta.Types.Time` |  |  |  |
| EfektywnyOkres | `Soneta.Types.Periods` |  |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| ElementyAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypElement>` |  |  |  |
| ForeColor | `int` |  | Kolor czcionki |  |
| IlośćDni | `int` |  |  |  |
| Indeksy | `Soneta.Business.SubTable<Soneta.Kalend.NieobecnośćIdx>` |  |  |  |
| Info | `string` |  |  |  |
| InfoText | `string` |  |  |  |
| IsRozliczalna | `bool` |  |  |  |
| IsRozliczona | `bool` |  |  |  |
| IsStorno | `bool` |  |  |  |
| IsVisibleWłączBO | `bool` |  |  |  |
| KategoriaZUS | `string` |  |  |  |
| Korygowana | `bool` | bazodanowe |  |  |
| KorygowanyOkres | `Soneta.Types.FromTo` |  |  |  |
| Macierzynski | `Soneta.Kalend.UrlopMacierzyński` | bazodanowe |  |  |
| Macierzynski.CzescUrlopu | `int` |  |  |  |
| Macierzynski.CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` |  |  |  |
| Macierzynski.Limit | `int` |  |  |  |
| Macierzynski.Nieobecnosc | `Soneta.Kalend.INieobecnoscLubZbieg` |  |  |  |
| Macierzynski.PonownieUstalPodstawe | `bool` |  |  |  |
| Macierzynski.ProcentZasiłku | `Soneta.Types.Percent` |  |  |  |
| Macierzynski.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` | bazodanowe, enum |  |  |
| Macierzynski.ZawieszenieSkladkiFP | `bool` |  |  |  |
| Nieobecnosci | `Soneta.Business.FromToSubTable<Soneta.Kalend.Nieobecnosc>` |  |  |  |
| Norma | `Soneta.Types.Time` | bazodanowe |  |  |
| NormaNie | `Soneta.Types.Time` | bazodanowe |  |  |
| OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| Okolicznosciowy | `Soneta.Kalend.UrlopOkolicznościowy` | bazodanowe |  |  |
| Okolicznosciowy.Limit | `int` |  |  |  |
| Okolicznosciowy.Przyczyna | `Soneta.Kalend.PrzyczynaUrlopuOkolicznościowego` | bazodanowe, enum |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresSwiadczenie | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PierwotnaDefinicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe |  |  |
| Pomniejszenia | `Soneta.Business.SubTable<Soneta.Place.WypSkladnik>` |  |  |  |
| PomniejszeniaAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypSkladnik>` |  |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` |  |  |  |
| RezygnacjaSwiadczenie | `bool` | bazodanowe |  |  |
| Rozliczenia | `Soneta.Business.SubTable` |  |  |  |
| RozliczenieData | `Soneta.Types.Date` | bazodanowe |  |  |
| RozliczenieWDniu | `bool` | bazodanowe |  |  |
| RozliczonyOkres | `Soneta.Types.FromTo` |  |  |  |
| TypDni | `Soneta.Kalend.TypyDni` | enum |  |  |
| TypZrodla | `Soneta.Kalend.TypŹródłaNieobecności` | bazodanowe, enum |  |  |
| Urlop | `Soneta.Kalend.UrlopWypoczynkowy` | bazodanowe |  |  |
| Urlop.PodstawaDo | `Soneta.Types.Date` | bazodanowe |  |  |
| Urlop.Przyczyna | `Soneta.Kalend.PrzyczynaUrlopu` | bazodanowe, enum |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Wychowawczy | `Soneta.Kalend.UrlopWychowawczy` | bazodanowe |  |  |
| Wychowawczy.CzescUrlopu | `int` |  |  |  |
| Wychowawczy.CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` |  |  |  |
| Wychowawczy.Nieobecnosc | `Soneta.Kalend.INieobecnoscLubZbieg` |  |  |  |
| Wychowawczy.ZawieszenieSkladkiFP | `bool` |  |  |  |
| ZLA | `Soneta.Kalend.ZLA` | bazodanowe |  |  |
| ZLA.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| ZLA.Wersja | `Soneta.Kalend.WersjaZLA` | bazodanowe, enum |  |  |
| ZLA.Zrodlo | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ZawieszenieSkladkiFP | `bool` | bazodanowe |  |  |
| Zrodlo | `Soneta.Kalend.IZrodloNieobecnosci` | bazodanowe, iface-ref |  |  |
| Zwolnienie | `Soneta.Kalend.ZwolnienieZUS` | bazodanowe |  |  |
| Zwolnienie.BezOkresuWyczekiwania | `bool` | bazodanowe |  |  |
| Zwolnienie.BezPomniejszaniaZasiłkuOd | `Soneta.Types.Date` |  |  |  |
| Zwolnienie.IsPrzyczyna | `bool` |  |  |  |
| Zwolnienie.IsZLA | `bool` |  |  |  |
| Zwolnienie.KodChoroby | `string` | bazodanowe |  |  |
| Zwolnienie.KontynuacjaOZ | `bool` |  |  |  |
| Zwolnienie.KontynuacjaOkrZas | `Soneta.Kalend.KontynuacjaOkrZas` | bazodanowe, enum |  |  |
| Zwolnienie.Kwarantanna | `Soneta.Kalend.ZwolnienieKwarantanna` | bazodanowe, enum |  |  |
| Zwolnienie.LeczenieSzpitalne | `bool` | bazodanowe |  |  |
| Zwolnienie.Numer | `string` | bazodanowe |  |  |
| Zwolnienie.PierwszyBezplatny | `bool` | bazodanowe |  |  |
| Zwolnienie.PomniejszajZasilek | `bool` | bazodanowe |  |  |
| Zwolnienie.PonownieUstalPodstawe | `bool` | bazodanowe |  |  |
| Zwolnienie.PrzedluzeniaData | `Soneta.Types.Date` | bazodanowe |  |  |
| Zwolnienie.PrzedluzenieOkrZas | `bool` | bazodanowe |  |  |
| Zwolnienie.Przyczyna | `Soneta.Kalend.PrzyczynaZwolnienia` | bazodanowe, enum |  |  |
| Zwolnienie.ZwolnienieDostarczone | `Soneta.Types.Date` | bazodanowe |  |  |
| Zwolnienie.ZwolnienieWystawione | `Soneta.Types.Date` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IZrodloNieobecnosci` | `Nieobecnosc`, `Pracownik`, `Umowa`, `UmowaZewnetrzna` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KontynuacjaOkrZas (`Soneta.Kalend.KontynuacjaOkrZas`)
- `Warunkowo` = 0
- `Tak` = 1
- `Nie` = 2

### PrzyczynaUrlopu (`Soneta.Kalend.PrzyczynaUrlopu`)
- `NieDotyczy` = 0
- `Planowy` = 1
- `NaŻądanie` = 2

### PrzyczynaUrlopuOkolicznościowego (`Soneta.Kalend.PrzyczynaUrlopuOkolicznościowego`)
- `InnaPrzyczyna` = 0 — Inna przyczyna
- `ŚlubLubNarodzinyDziecka` = 1 — 2 dni - ślub pracownika lub narodziny dziecka
- `ŚmierćIPogrzebŻonyMężaDzieckaMatkiOjcaOjczymaMacochy` = 2 — 2 dni - śmierć i pogrzeb: żony, męża, dziecka, matki, ojca, ojczyma, macochy
- `ŚlubDziecka` = 3 — 1 dzień - ślub dziecka
- `ŚmierćIPogrzebSiostryBrataTeściowejTeściaBabciDziadka` = 4 — 1 dzień - śmierć i pogrzeb: siostry, brata, teściowej, teścia, babci, dziadka
- `ŚmierćInnejOsoby` = 5 — 1 dzień - śmierć innej osoby pozostającej na utrzymaniu albo pod opieką pracownika

### PrzyczynaZwolnienia (`Soneta.Kalend.PrzyczynaZwolnienia`)
- `NieDotyczy` = 0
- `ZwolnienieLekarskie` = 1
- `ZwolnienieLekarskieBezOkresuWyczekiwania` = 2
- `WypadekPrzyPracyLubChorobaZawodowa` = 3 — Wypadek przy pracy lub choroba zawodowa (100%)
- `WypadekWDrodzeDoZPracy` = 4 — Wypadek w drodze do lub z pracy (100%)
- `NiezdolnośćDoPracyWOkresieCiąży` = 5 — Niezdolność do pracy w okresie ciąży (100%)
- `NadużycieAlkoholu` = 6 — Niezdolność do pracy spowodowana nadużyciem alkoholu
- `UdziałWBójceLubWPobiciu` = 7 — Udział w bójce lub w pobiciu (przestępstwo, wykroczenie)
- `LeczenieSzpitalne` = 8
- `ZwolnienieSpowodowaneGruźlicą` = 9
- `PobranieKomórekTkanekNarządów` = 10 — Badanie lub pobranie komórek, tkanek, narządów (100%)
- `ChorobaZakaźna` = 11 — Niezdolność do pracy spowodowaną chorobą zakaźną, której okres wylęgania jest dłuższy niż 14 dni, lub inną chorobą, której objawy chorobowe ujawniają się po okresie dłuższym niż 14 dni od początku choroby
- `KwarantannaPracownikaMedycznegoKoronawirus` = 12 — Kwarantanna lub izolacja pracownika medycznego/służby państwowe - koronawirus (100%)
- `KwarantannaPracownikaKoronawirus` = 13 — Kwarantanna lub izolacja pracownika - koronawirus (100%)
- `OpiekaSprawowanaNadDziećmi` = 100 — Opieka sprawowana nad zdrowym dzieckiem w wieku do lat 8
- `OpiekaSprawowanaNadInnymiCzłonkamiRodziny` = 101 — Opieka sprawowana nad innym chorym członkiem rodziny
- `OpiekaSprawowanaNadDziećmiDoLat14` = 102 — Opieka sprawowana nad chorym dzieckiem w wieku do lat 14
- `OpiekaSprawowanaNadNoworodkiemDo8TygodniaŻycia` = 103 — Opieka sprawowana nad noworodkiem do 8 tygodnia życia
- `OpiekaSprawowanaNadDzieckiemNiepełnospDoLat18` = 104 — Opieka sprawowana nad dzieckiem niepełnosprawnym w wieku od 8/14 lat do ukończenia 18 lat
- `ZamknięciePlacówkiOpiekuńczejKoronawirus` = 105 — Zamknięcie placówki opiekuńczej
- `ZamknięciePlacówkiDorosłejOsobyKoronawirus` = 106 — Zamknięcie placówki dorosłej osoby niepełnosprawnej
- `UrlopRehabilitacyjny` = 200
- `UrlopRehabilitacyjnyCiąża` = 201 — Urlop rehabilitacyjny w okresie ciąży (100%)
- `UrlopRehabilitacyjnyWypadek` = 202 — Urlop rehabilitacyjny z powodu wypadku w drodze do lub z pracy (hist.)
- `UrlopRehabilitacyjnyWypadekPrzyPracy` = 203 — Urlop rehabilitacyjny z powodu wypadku przy pracy lub choroby zawodowej (100%)

### RozliczenieUrlopuMacierzyńskiego (`Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego`)
- `NieDotyczy` = 0
- `UrlopMacierzyński100` = 1 — Urlop macierzyński (100%)
- `UrlopMacierzyński80` = 2 — Urlop macierzyński (80%)
- `UrlopMacierzyński0` = 3 — Urlop macierzyński (bez zasiłku)
- `UrlopMacierzyński815` = 4 — Urlop macierzyński (81,50%)
- `UrlopRodzicielski80` = 10 — Urlop rodzicielski (80%)
- `UrlopRodzicielski60` = 11 — Urlop rodzicielski (60%)
- `UrlopRodzicielski100` = 12 — Urlop rodzicielski (100%)
- `UrlopRodzicielski0` = 13 — Urlop rodzicielski (bez zasiłku)
- `UrlopRodzicielski815` = 14 — Urlop rodzicielski (81,50%)
- `UrlopRodzicielski70` = 15 — Urlop rodzicielski (70%)
- `UrlopRodzicielski70do9tyg` = 16 — Urlop rodzicielski (70% do 9 tygodni)
- `UrlopRodzicielski70ZaZyciem` = 17 — Urlop rodzicielski (70% ustawa "Za życiem")
- `UrlopRodzicielski815ZaZyciem` = 18 — Urlop rodzicielski (81,5% ustawa "Za życiem")

### TypyDni (`Soneta.Kalend.TypyDni`)
- `Pracy` = 0 — Pracy
- `Kalendarzowe` = 1

### TypŹródłaNieobecności (`Soneta.Kalend.TypŹródłaNieobecności`)
- `Pracownik` = 1
- `Nieobecność` = 2
- `Umowa` = 3
- `UmowaZewnetrzna` = 4

### WersjaZLA (`Soneta.Kalend.WersjaZLA`)
- `Brak` = 0 — Brak
- `CSVv1` = 1 — CSV v1
- `PUEService` = 100 — PUE

### ZwolnienieKwarantanna (`Soneta.Kalend.ZwolnienieKwarantanna`)
- `NieDotyczy` = 0 — Nie dotyczy
- `KwarantannaSanepid` = 1 — Kwarantanna - sanepid
- `KwarantannaPrzekroczenieGranicy` = 2 — Kwarantanna - przekroczenie granicy
- `Kwarantanna` = 3 — Kwarantanna
- `IzolacjaDomowa` = 4 — Izolacja domowa
