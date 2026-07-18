# Pola i właściwości klasy biznesowej: `Soneta.Kadry.WniosekUrlopowy`
Nazwa tabeli: `WnioskiUrlopowe`
Tytuł: Wnioski o urlopy, delegacje
Opis: Wniosek pracownika o urlop lub delegację zawierający okres, definicję nieobecności, stan akceptacji, kierownika i zastępcę. Obsługuje różne typy wniosków: urlop wypoczynkowy, okolicznościowy, delegacja krajowa i zagraniczna z planowaną zaliczką.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentAktualizacjiKalendarza`

- pola bazodanowe (zapisywalne): 24
- pola kalkulowane (zapisywalne): 7
- pola tylko-odczyt: 10
- podlisty: 19
- subrowy: 8
- razem: 68

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaOkresu | `bool` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe |  |  |
| DataDecyzji | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe, tylko-odczyt |  |  |
| Delegacja | `Soneta.Kadry.WniosekODelegację` (subrow) | bazodanowe |  |  |
| Delegacja.Cel | `MemoText` | bazodanowe, podlista |  | Cel delegacji. |
| Delegacja.DataRozpoczeciaPlanowana | `DateShortTime` | bazodanowe |  | Planowany czas rozpoczęcia delegacji. |
| Delegacja.DataRozpoczeciaPlanowanaDate | `Date` |  |  |  |
| Delegacja.DataRozpoczeciaPlanowanaTime | `Time` |  |  |  |
| Delegacja.DataZakonczeniaPlanowana | `DateShortTime` | bazodanowe |  | Planowany czas zakończenia delegacji. |
| Delegacja.DataZakonczeniaPlanowanaDate | `Date` |  |  |  |
| Delegacja.DataZakonczeniaPlanowanaTime | `Time` |  |  |  |
| Delegacja.Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu PWS |
| Delegacja.IsDelegacja | `bool` | tylko-odczyt |  |  |
| Delegacja.KrajDocelowy | `Soneta.Kadry.IKrajDelegacji` | bazodanowe, iface-ref |  | Kraj docelowy delegacji. |
| Delegacja.SrodekTransportu | `string` | bazodanowe |  | Domyślny środek transportu. |
| Delegacja.WgDefinicja | `Key` | podlista |  |  |
| Delegacja.WgKrajDocelowy | `Key` | podlista |  |  |
| Delegacja.WnioskowanaZaliczka | `Currency` | bazodanowe |  | Wnioskowana wysokość zaliczki |
| DelegacjePWS | `SubTable` | podlista |  |  |
| DniKalendarzaHistorie | `SubTable<Soneta.Kalend.DzienKalendarzaHistoria>` | podlista |  |  |
| DniPracyHistorie | `SubTable<Soneta.Kalend.DzienPracyHistoria>` | podlista |  |  |
| DoGodziny | `Time` |  |  |  |
| IlośćDni | `int` |  |  |  |
| Kierownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Nieobecności | `View` | podlista |  |  |
| Norma | `Time` | bazodanowe |  |  |
| NormaNie | `Soneta.Kalend.CzasDni` | tylko-odczyt |  |  |
| OdGodziny | `Time` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | tylko-odczyt |  |  |
| PrzyczynaUrlopu | `Soneta.Kalend.PrzyczynaUrlopu` (enum) |  |  |  |
| Stan | `Soneta.Kadry.StanWnioskuUrlopowego` (enum) | bazodanowe |  |  |
| TypDni | `Soneta.Kalend.TypyDni` (enum) | tylko-odczyt |  |  |
| UrlopMacierzynski | `Soneta.Kadry.WniosekOUrlopMacierzyński` (subrow) | bazodanowe |  |  |
| UrlopMacierzynski.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| UrlopMacierzynski.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` (enum) | bazodanowe |  |  |
| UrlopMacierzynski.Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| UrlopMacierzynski.WgDziecko | `Key` | podlista |  |  |
| UrlopMacierzyńskiUzupełniający | `Soneta.Kadry.WniosekOUrlopMacierzyńskiUzupełniający` (subrow) | bazodanowe |  |  |
| UrlopMacierzyńskiUzupełniający.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| UrlopMacierzyńskiUzupełniający.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` (enum) | bazodanowe |  |  |
| UrlopMacierzyńskiUzupełniający.Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| UrlopMacierzyńskiUzupełniający.WgDziecko | `Key` | podlista |  |  |
| UrlopOjcowski | `Soneta.Kadry.WniosekOUrlopOjcowski` (subrow) | bazodanowe |  |  |
| UrlopOjcowski.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| UrlopOjcowski.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` (enum) | bazodanowe |  |  |
| UrlopOjcowski.Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| UrlopOjcowski.WgDziecko | `Key` | podlista |  |  |
| UrlopOkolicznosciowy | `Soneta.Kadry.WniosekOUrlopOkolicznościowy` (subrow) | bazodanowe |  |  |
| UrlopOkolicznosciowy.PrzyczynaUrlopu | `Soneta.Kalend.PrzyczynaUrlopuOkolicznościowego` (enum) | bazodanowe |  |  |
| UrlopRodzicielski | `Soneta.Kadry.WniosekOUrlopRodzicielski` (subrow) | bazodanowe |  |  |
| UrlopRodzicielski.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| UrlopRodzicielski.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` (enum) | bazodanowe |  |  |
| UrlopRodzicielski.Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| UrlopRodzicielski.WgDziecko | `Key` | podlista |  |  |
| UrlopWychowawczy | `Soneta.Kadry.WniosekOUrlopWychowawczy` (subrow) | bazodanowe |  |  |
| UrlopWychowawczy.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| UrlopWychowawczy.Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| UrlopWychowawczy.WgDziecko | `Key` | podlista |  |  |
| UrlopWypoczynkowy | `Soneta.Kadry.WniosekOUrlopWypoczynkowy` (subrow) | bazodanowe |  |  |
| UrlopWypoczynkowy.PrzyczynaUrlopu | `Soneta.Kalend.PrzyczynaUrlopu` (enum) | bazodanowe |  |  |
| Zastepca | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Zrodlo | `Soneta.Kalend.IZrodloWnioskuONieobecnosc` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| ZrodloPlanu | `Soneta.Kalend.IZrodloPlanu` | tylko-odczyt, iface-ref |  |  |
| ZrodloPlanuNumer | `string` | tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Delegacja.KrajDocelowy | `IKrajDelegacji` | `KrajDelegacji` |
| Zrodlo | `IZrodloWnioskuONieobecnosc` | `Pracownik`, `Umowa`, `UmowaZewnetrzna` |
| ZrodloPlanu | `IZrodloPlanu` | `Pracownik`, `Umowa`, `UmowaZewnetrzna` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanWnioskuUrlopowego (`Soneta.Kadry.StanWnioskuUrlopowego`)
- `Oczekujący` = 1
- `Anulowany` = 2
- `Zaakceptowany` = 3
- `Odrzucony` = 4
- `Korygowana` = 5

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
