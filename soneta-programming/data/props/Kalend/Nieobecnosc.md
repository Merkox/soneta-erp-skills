# Pola i właściwości klasy biznesowej: `Soneta.Kalend.Nieobecnosc`
Nazwa tabeli: `Nieobecnosci`
Tytuł: Nieobecności
Opis: Rejestracja nieobecności pracownika. Przechowuje okres, definicję nieobecności, normę czasu pracy, dane zwolnienia ZUS (e-ZLA), urlopy wypoczynkowe/okolicznościowe/macierzyńskie/wychowawcze oraz informacje o rozliczeniu i korekcie.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IZrodloNieobecnosci`, `IBazaZrodlaWyplaty`, `IBilansOtwarcia`, `IZrodloDeklaracji`

- pola bazodanowe (zapisywalne): 31
- pola kalkulowane (zapisywalne): 8
- pola tylko-odczyt: 29
- podlisty: 14
- subrowy: 6
- razem: 88

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BackColor | `int` | tylko-odczyt | Kolor tła |  |
| BilansOtwarcia | `bool` | bazodanowe |  |  |
| BlokadaOkresu | `bool` | tylko-odczyt |  |  |
| Czas | `Time` | tylko-odczyt |  |  |
| CzescUrlopu | `int` | bazodanowe |  |  |
| CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe |  |  |
| Deklaracje | `SubTable` | podlista |  |  |
| Dni | `int` | tylko-odczyt |  |  |
| DoGodziny | `Time` |  |  |  |
| EfektywnyOkres | `Periods` | tylko-odczyt |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| ElementyAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypElement>` | podlista |  |  |
| ForeColor | `int` | tylko-odczyt | Kolor czcionki |  |
| IlośćDni | `int` |  |  |  |
| Indeksy | `SubTable<Soneta.Kalend.NieobecnośćIdx>` | podlista |  |  |
| Info | `string` | tylko-odczyt |  |  |
| InfoText | `string` | tylko-odczyt |  |  |
| IsRozliczalna | `bool` | tylko-odczyt |  |  |
| IsRozliczona | `bool` | tylko-odczyt |  |  |
| IsStorno | `bool` | tylko-odczyt |  |  |
| IsVisibleWłączBO | `bool` | tylko-odczyt |  |  |
| KategoriaZUS | `string` | tylko-odczyt |  |  |
| Korygowana | `bool` | bazodanowe, tylko-odczyt |  |  |
| KorygowanyOkres | `FromTo` | podlista |  |  |
| Macierzynski | `Soneta.Kalend.UrlopMacierzyński` (subrow) | bazodanowe |  |  |
| Macierzynski.CzescUrlopu | `int` |  |  |  |
| Macierzynski.CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` |  |  |  |
| Macierzynski.Limit | `int` | tylko-odczyt |  |  |
| Macierzynski.Nieobecnosc | `Soneta.Kalend.INieobecnoscLubZbieg` | tylko-odczyt |  |  |
| Macierzynski.PonownieUstalPodstawe | `bool` | tylko-odczyt |  |  |
| Macierzynski.ProcentZasiłku | `Percent` | tylko-odczyt |  |  |
| Macierzynski.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` (enum) | bazodanowe |  |  |
| Macierzynski.ZawieszenieSkladkiFP | `bool` |  |  |  |
| Nieobecnosci | `FromToSubTable<Soneta.Kalend.Nieobecnosc>` | podlista |  |  |
| Norma | `Time` | bazodanowe |  |  |
| NormaNie | `Time` | bazodanowe |  |  |
| OdGodziny | `Time` | bazodanowe |  |  |
| Okolicznosciowy | `Soneta.Kalend.UrlopOkolicznościowy` (subrow) | bazodanowe |  |  |
| Okolicznosciowy.Limit | `int` | tylko-odczyt |  |  |
| Okolicznosciowy.Przyczyna | `Soneta.Kalend.PrzyczynaUrlopuOkolicznościowego` (enum) | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| OkresSwiadczenie | `FromTo` | bazodanowe, podlista |  |  |
| PierwotnaDefinicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe |  |  |
| Pomniejszenia | `SubTable<Soneta.Place.WypSkladnik>` | podlista |  |  |
| PomniejszeniaAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypSkladnik>` | podlista |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | tylko-odczyt |  |  |
| RezygnacjaSwiadczenie | `bool` | bazodanowe |  |  |
| Rozliczenia | `SubTable` | podlista |  |  |
| RozliczenieData | `Date` | bazodanowe |  |  |
| RozliczenieWDniu | `bool` | bazodanowe |  |  |
| RozliczonyOkres | `FromTo` | podlista |  |  |
| TypDni | `Soneta.Kalend.TypyDni` (enum) | tylko-odczyt |  |  |
| TypZrodla | `Soneta.Kalend.TypŹródłaNieobecności` (enum) | bazodanowe, tylko-odczyt |  |  |
| Urlop | `Soneta.Kalend.UrlopWypoczynkowy` (subrow) | bazodanowe |  |  |
| Urlop.PodstawaDo | `Date` | bazodanowe |  |  |
| Urlop.Przyczyna | `Soneta.Kalend.PrzyczynaUrlopu` (enum) | bazodanowe |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| Wychowawczy | `Soneta.Kalend.UrlopWychowawczy` (subrow) | bazodanowe |  |  |
| Wychowawczy.CzescUrlopu | `int` |  |  |  |
| Wychowawczy.CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` |  |  |  |
| Wychowawczy.Nieobecnosc | `Soneta.Kalend.INieobecnoscLubZbieg` | tylko-odczyt |  |  |
| Wychowawczy.ZawieszenieSkladkiFP | `bool` |  |  |  |
| ZLA | `Soneta.Kalend.ZLA` (subrow) | bazodanowe |  |  |
| ZLA.Data | `Date` | bazodanowe |  |  |
| ZLA.Wersja | `Soneta.Kalend.WersjaZLA` (enum) | bazodanowe |  |  |
| ZLA.Zrodlo | `MemoText` | bazodanowe, podlista |  |  |
| ZawieszenieSkladkiFP | `bool` | bazodanowe |  |  |
| Zrodlo | `Soneta.Kalend.IZrodloNieobecnosci` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Zwolnienie | `Soneta.Kalend.ZwolnienieZUS` (subrow) | bazodanowe |  |  |
| Zwolnienie.BezOkresuWyczekiwania | `bool` | bazodanowe |  |  |
| Zwolnienie.BezPomniejszaniaZasiłkuOd | `Date` | tylko-odczyt |  |  |
| Zwolnienie.IsPrzyczyna | `bool` | tylko-odczyt |  |  |
| Zwolnienie.IsZLA | `bool` | tylko-odczyt |  |  |
| Zwolnienie.KodChoroby | `string` | bazodanowe |  |  |
| Zwolnienie.KontynuacjaOkrZas | `Soneta.Kalend.KontynuacjaOkrZas` (enum) | bazodanowe |  |  |
| Zwolnienie.Kwarantanna | `Soneta.Kalend.ZwolnienieKwarantanna` (enum) | bazodanowe |  |  |
| Zwolnienie.LeczenieSzpitalne | `bool` | bazodanowe |  |  |
| Zwolnienie.Numer | `string` | bazodanowe |  |  |
| Zwolnienie.PierwszyBezplatny | `bool` | bazodanowe |  |  |
| Zwolnienie.PomniejszajZasilek | `bool` | bazodanowe |  |  |
| Zwolnienie.PonownieUstalPodstawe | `bool` | bazodanowe, tylko-odczyt |  |  |
| Zwolnienie.PrzedluzeniaData | `Date` | bazodanowe |  |  |
| Zwolnienie.PrzedluzenieOkrZas | `bool` | bazodanowe |  |  |
| Zwolnienie.Przyczyna | `Soneta.Kalend.PrzyczynaZwolnienia` (enum) | bazodanowe |  |  |
| Zwolnienie.ZwolnienieDostarczone | `Date` | bazodanowe |  |  |
| Zwolnienie.ZwolnienieWystawione | `Date` | bazodanowe |  |  |

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
