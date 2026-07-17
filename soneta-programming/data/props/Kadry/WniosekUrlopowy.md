# Pola i właściwości klasy biznesowej: `Soneta.Kadry.WniosekUrlopowy`
Nazwa tabeli: `WnioskiUrlopowe`
Tytuł: Wnioski o urlopy, delegacje
Opis: Wniosek pracownika o urlop lub delegację zawierający okres, definicję nieobecności, stan akceptacji, kierownika i zastępcę. Obsługuje różne typy wniosków: urlop wypoczynkowy, okolicznościowy, delegacja krajowa i zagraniczna z planowaną zaliczką.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentAktualizacjiKalendarza`

- pola bazodanowe: 42
- pola kalkulowane (z klas biznesowych): 27

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaOkresu | `bool` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataDecyzji | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe |  |  |
| Delegacja | `Soneta.Kadry.WniosekODelegację` | bazodanowe |  |  |
| Delegacja.Cel | `Soneta.Business.MemoText` | bazodanowe |  | Cel delegacji. |
| Delegacja.DataRozpoczeciaPlanowana | `Soneta.Types.DateShortTime` | bazodanowe |  | Planowany czas rozpoczęcia delegacji. |
| Delegacja.DataRozpoczeciaPlanowanaDate | `Soneta.Types.Date` |  |  |  |
| Delegacja.DataRozpoczeciaPlanowanaTime | `Soneta.Types.Time` |  |  |  |
| Delegacja.DataZakonczeniaPlanowana | `Soneta.Types.DateShortTime` | bazodanowe |  | Planowany czas zakończenia delegacji. |
| Delegacja.DataZakonczeniaPlanowanaDate | `Soneta.Types.Date` |  |  |  |
| Delegacja.DataZakonczeniaPlanowanaTime | `Soneta.Types.Time` |  |  |  |
| Delegacja.Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu PWS |
| Delegacja.IsDelegacja | `bool` |  |  |  |
| Delegacja.KrajDocelowy | `Soneta.Kadry.IKrajDelegacji` | bazodanowe, iface-ref |  | Kraj docelowy delegacji. |
| Delegacja.SrodekTransportu | `string` | bazodanowe |  | Domyślny środek transportu. |
| Delegacja.WgDefinicja | `Soneta.Business.Key` |  |  |  |
| Delegacja.WgKrajDocelowy | `Soneta.Business.Key` |  |  |  |
| Delegacja.WnioskowanaZaliczka | `Soneta.Types.Currency` | bazodanowe |  | Wnioskowana wysokość zaliczki |
| DelegacjePWS | `Soneta.Business.SubTable` |  |  |  |
| DniKalendarzaHistorie | `Soneta.Business.SubTable<Soneta.Kalend.DzienKalendarzaHistoria>` |  |  |  |
| DniPracyHistorie | `Soneta.Business.SubTable<Soneta.Kalend.DzienPracyHistoria>` |  |  |  |
| DoGodziny | `Soneta.Types.Time` |  |  |  |
| IlośćDni | `int` |  |  |  |
| Kierownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Nieobecności | `Soneta.Business.View` |  |  |  |
| Nieobecność | `Soneta.Kalend.Nieobecnosc` |  |  |  |
| Norma | `Soneta.Types.Time` | bazodanowe |  |  |
| NormaNie | `Soneta.Kalend.CzasDni` |  |  |  |
| OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` |  |  |  |
| PrzyczynaUrlopu | `Soneta.Kalend.PrzyczynaUrlopu` | enum |  |  |
| Stan | `Soneta.Kadry.StanWnioskuUrlopowego` | bazodanowe, enum |  |  |
| TypDni | `Soneta.Kalend.TypyDni` | enum |  |  |
| UrlopMacierzynski | `Soneta.Kadry.WniosekOUrlopMacierzyński` | bazodanowe |  |  |
| UrlopMacierzynski.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| UrlopMacierzynski.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` | bazodanowe, enum |  |  |
| UrlopMacierzynski.Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| UrlopMacierzynski.WgDziecko | `Soneta.Business.Key` |  |  |  |
| UrlopMacierzyńskiUzupełniający | `Soneta.Kadry.WniosekOUrlopMacierzyńskiUzupełniający` | bazodanowe |  |  |
| UrlopMacierzyńskiUzupełniający.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| UrlopMacierzyńskiUzupełniający.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` | bazodanowe, enum |  |  |
| UrlopMacierzyńskiUzupełniający.Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| UrlopMacierzyńskiUzupełniający.WgDziecko | `Soneta.Business.Key` |  |  |  |
| UrlopOjcowski | `Soneta.Kadry.WniosekOUrlopOjcowski` | bazodanowe |  |  |
| UrlopOjcowski.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| UrlopOjcowski.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` | bazodanowe, enum |  |  |
| UrlopOjcowski.Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| UrlopOjcowski.WgDziecko | `Soneta.Business.Key` |  |  |  |
| UrlopOkolicznosciowy | `Soneta.Kadry.WniosekOUrlopOkolicznościowy` | bazodanowe |  |  |
| UrlopOkolicznosciowy.PrzyczynaUrlopu | `Soneta.Kalend.PrzyczynaUrlopuOkolicznościowego` | bazodanowe, enum |  |  |
| UrlopRodzicielski | `Soneta.Kadry.WniosekOUrlopRodzicielski` | bazodanowe |  |  |
| UrlopRodzicielski.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| UrlopRodzicielski.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` | bazodanowe, enum |  |  |
| UrlopRodzicielski.Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| UrlopRodzicielski.WgDziecko | `Soneta.Business.Key` |  |  |  |
| UrlopWychowawczy | `Soneta.Kadry.WniosekOUrlopWychowawczy` | bazodanowe |  |  |
| UrlopWychowawczy.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| UrlopWychowawczy.Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| UrlopWychowawczy.WgDziecko | `Soneta.Business.Key` |  |  |  |
| UrlopWypoczynkowy | `Soneta.Kadry.WniosekOUrlopWypoczynkowy` | bazodanowe |  |  |
| UrlopWypoczynkowy.PrzyczynaUrlopu | `Soneta.Kalend.PrzyczynaUrlopu` | bazodanowe, enum |  |  |
| Zastepca | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Zrodlo | `Soneta.Kalend.IZrodloWnioskuONieobecnosc` | bazodanowe, iface-ref |  |  |
| ZrodloPlanu | `Soneta.Kalend.IZrodloPlanu` | iface-ref |  |  |
| ZrodloPlanuNumer | `string` |  |  |  |

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
