# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PracHistoria2`
Nazwa tabeli: `PracHistorie2`
Tytuł: Historia pracownika (pozostałe)
Opis: Element szczegółowy historii pracownika (PracHistoria). Rozszerzenie danych historycznych o dokument tożsamości, dane kontaktowe, osobę do powiadomienia, dane wojskowe, obywatelstwo, stan rodzinny, wykształcenie, PFRON, ZUS, bilanse otwarcia PIT5 oraz dane oświatowe.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `PracHistoria`

- pola bazodanowe (zapisywalne): 120
- pola kalkulowane (zapisywalne): 11
- pola tylko-odczyt: 14
- podlisty: 16
- subrowy: 18
- razem: 179

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DodSwiadczeniaZUS | `Soneta.Kadry.DodatkoweŚwiadczeniaZUS` (subrow) | bazodanowe |  |  |
| DodSwiadczeniaZUS.Numer | `string` | bazodanowe |  |  |
| DodSwiadczeniaZUS.OddzialZUS | `Soneta.CRM.OddziałZUS` | bazodanowe |  |  |
| DodSwiadczeniaZUS.Okres | `FromTo` | bazodanowe, podlista |  |  |
| DodSwiadczeniaZUS.Rodzaj | `Soneta.Kadry.RodzajeDodatkowychŚwiadczeńZUS` (enum) | bazodanowe |  |  |
| DodSwiadczeniaZUS.WgOddzialZUS | `Key` | podlista |  |  |
| Dokument | `Soneta.Kadry.DokumentOsoby` (subrow) | bazodanowe |  |  |
| Dokument.DataWaznosci | `Date` | bazodanowe |  |  |
| Dokument.DataWydania | `Date` | bazodanowe |  |  |
| Dokument.Rodzaj | `Soneta.Kadry.KodRodzajuDokumentu` (enum) | bazodanowe |  |  |
| Dokument.SeriaNumer | `string` | bazodanowe |  |  |
| Dokument.WydanyPrzez | `string` | bazodanowe |  |  |
| EmeryturaMundurowa | `Soneta.Kadry.EmeryturaMundurowa` (subrow) | bazodanowe |  |  |
| EmeryturaMundurowa.Data | `Date` | bazodanowe | Data przyznania |  |
| EmeryturaMundurowa.Numer | `string` | bazodanowe |  |  |
| EmeryturaMundurowa.WydanyPrzez | `string` | bazodanowe |  |  |
| FunkcjaPelna | `string` | bazodanowe |  |  |
| Host | `Soneta.Kadry.PracHistoria` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| InneDane | `Soneta.Kadry.InneDaneHistoryczne` (subrow) | bazodanowe |  |  |
| InneDane.KierownikDzialu | `Soneta.Kadry.Wydzial` | bazodanowe |  |  |
| InneDane.KorespondencjaNazwaFirmy | `string` | bazodanowe |  | Nazwa firmy, na którą kierowana jest korespondencja |
| InneDane.WgKierownikDzialu | `Key` | podlista |  |  |
| InneDane.WgZastepca | `Key` | podlista |  |  |
| InneDane.Zastepca | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Kontakt | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| ObnizenieEtatu | `Soneta.Kadry.ObniżenieWymiaruEtatu` (subrow) | bazodanowe |  |  |
| ObnizenieEtatu.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe, tylko-odczyt |  |  |
| ObnizenieEtatu.Etat | `Soneta.Kadry.Etat` | tylko-odczyt |  |  |
| ObnizenieEtatu.Info | `Soneta.Kadry.ObniżenieWymiaruEtatuInfo` (enum) | bazodanowe, tylko-odczyt |  |  |
| ObnizenieEtatu.Kalendarz | `Soneta.Kalend.KalendarzBase` | bazodanowe, tylko-odczyt |  |  |
| ObnizenieEtatu.RodzajStawki | `Soneta.Kadry.RodzajStawkiZaszeregowania` (enum) | bazodanowe, tylko-odczyt |  |  |
| ObnizenieEtatu.Stawka | `Currency` | bazodanowe, tylko-odczyt |  |  |
| ObnizenieEtatu.TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` (enum) | bazodanowe, tylko-odczyt |  |  |
| ObnizenieEtatu.WgElement | `Key` | podlista |  |  |
| ObnizenieEtatu.WgKalendarz | `Key` | podlista |  |  |
| ObnizenieEtatu.WskaznikKrotnosc | `double` | bazodanowe, tylko-odczyt |  |  |
| ObnizenieEtatu.WskaznikNazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| ObnizenieEtatu.Wymiar | `Fraction` | bazodanowe, tylko-odczyt |  |  |
| Obywatelstwo | `Soneta.Kadry.Obywatelstwo` (subrow) | bazodanowe |  |  |
| Obywatelstwo.DataZmiany | `Date` | bazodanowe |  |  |
| Obywatelstwo.KartaPobytu | `Soneta.Kadry.KartaPobytu` (subrow) | bazodanowe |  |  |
| Obywatelstwo.KartaPobytu.DataWaznosci | `Date` | bazodanowe |  |  |
| Obywatelstwo.KartaPobytu.DataWydania | `Date` | bazodanowe |  |  |
| Obywatelstwo.KartaPobytu.Rodzaj | `Soneta.Kadry.RodzajKartyPobytu` (enum) | bazodanowe |  |  |
| Obywatelstwo.KartaPobytu.SeriaNumer | `string` | bazodanowe |  |  |
| Obywatelstwo.KartaPobytu.WydanyPrzez | `string` | bazodanowe |  |  |
| Obywatelstwo.KodKraju | `string` | bazodanowe |  | Kod kraju obywatelstwa |
| Obywatelstwo.KodKrajuDokumentu | `string` | bazodanowe |  | Kod kraju |
| Obywatelstwo.KrajDokumentu | `string` | bazodanowe |  | Kraj |
| Obywatelstwo.Nazwa | `string` | bazodanowe |  |  |
| Obywatelstwo.NumerPodatnika | `string` | bazodanowe |  |  |
| Obywatelstwo.ObywatelstwoPolskie | `bool` | tylko-odczyt |  |  |
| Obywatelstwo.OgraniczonyObowiazekPodatkowy | `bool` | bazodanowe |  |  |
| Obywatelstwo.PodstZdrowCudzoziemca | `Soneta.Kadry.PodstZdrowCudzoziemca` (enum) | bazodanowe |  |  |
| Obywatelstwo.PodstawaPrawnaZmiany | `string` | bazodanowe |  |  |
| Obywatelstwo.RodzajNumeruPodatnika | `Soneta.Kadry.KodRodzajNumeruPodatnika` (enum) | bazodanowe |  |  |
| Obywatelstwo.ZdrowCudzoziemcaDo | `Date` | bazodanowe |  |  |
| Obywatelstwo.ZdrowCudzoziemcaUwagi | `string` | bazodanowe |  |  |
| Oswiata | `Soneta.Kadry.PracownikOświaty` (subrow) | bazodanowe |  |  |
| Oswiata.KartaNauczycielaWymiar | `Fraction` | bazodanowe |  |  |
| Oswiata.Nauczyciel | `bool` |  |  |  |
| Oswiata.NauczycielKartaNauczyciela | `bool` | bazodanowe |  |  |
| Oswiata.Rodzaj | `Soneta.Kadry.RodzajPracownikaOświaty` (enum) | bazodanowe | Rodzaj pracownika oświaty |  |
| Oswiata.Wymiar | `Fraction` | bazodanowe |  |  |
| Oswiata.WymiarEx | `Fraction` |  |  |  |
| PFRON | `Soneta.Kadry.DanePFRON` (subrow) | bazodanowe |  |  |
| PFRON.DataDostarczenia | `Date` | bazodanowe |  | Data dostarczenia orzeczenia o stopniu niepełnosprawności |
| PFRON.DataOrzeczenia | `Date` | bazodanowe |  | Data orzeczenia o stopniu niepełnosprawności |
| PFRON.DataWniosku | `Date` | bazodanowe |  |  |
| PFRON.DataZaswiadczenia | `Date` | bazodanowe |  |  |
| PFRON.DataZgloszeniaDoEwidencji | `Date` | bazodanowe |  | Data zgłoszenia pracownika do ewidencji zatrudnionych osób niepełnosprawnych PFRON. |
| PFRON.DodatkoweDofinansowanieSOD | `bool` | bazodanowe |  |  |
| PFRON.DzialalnoscNieGospodarcza | `bool` | bazodanowe |  | Pracownik jest zatrudniony u pracodawcy prowadzącego działalność gospodarczą, lecz wykonuje pracę związaną z wyodrębnioną działalnością niebędącą działalnością gospodarczą. |
| PFRON.EfektZachety | `bool` | bazodanowe |  | Pracownik zatrudniony w warunkach efektu zachęty. |
| PFRON.Koszty2007 | `decimal` | bazodanowe |  |  |
| PFRON.MiejsceZamieszkania | `Soneta.Kadry.MiejsceZamieszkania` (enum) | bazodanowe |  |  |
| PFRON.NaliczajUrlopDodatkowy | `bool` | bazodanowe |  |  |
| PFRON.NaliczajUrlopDodatkowyOd | `Date` | bazodanowe |  |  |
| PFRON.NieuprawnionyDoDofinansowaniaWypGot | `bool` | bazodanowe |  | Pracownik nieuprawniony do dofinansowania - wypłata gotówkowa wynagrodzenia. |
| PFRON.ObnizonyLimitDofinansowania | `bool` | bazodanowe |  |  |
| PFRON.Okres | `FromTo` | bazodanowe, podlista |  |  |
| PFRON.OkresEpd | `FromTo` | podlista |  |  |
| PFRON.OkresExt | `FromTo` | podlista |  |  |
| PFRON.OkresExtOld | `FromTo` | podlista |  |  |
| PFRON.OrganWydajacyOrzeczenie | `Soneta.Kadry.OrganWydajacyOrzeczenie` (enum) | bazodanowe |  | Organ wydający orzeczenie o stopniu niepełnosprawności |
| PFRON.PomocPubliczna | `Soneta.Kadry.StanowiPomocPubliczną` (enum) | bazodanowe |  | Dofinansowanie stanowi pomoc publiczną |
| PFRON.PoziomWyksztalcenia | `Soneta.Kadry.PoziomWykształcenia` (enum) | bazodanowe |  |  |
| PFRON.PracownikZwolniony | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| PFRON.SchorzeniaSOD | `System.Collections.Generic.IEnumerable<Soneta.Kadry.SzczególneSchorzeniaSOD>` | podlista |  |  |
| PFRON.StanowiskoZwolnione | `bool` | bazodanowe |  | Stanowisko pracy, na którym został zatrudniony pracownik zostało zwolnione w wyniku zdarzeń określonych w art. 26b ust. 4 pkt 1-4 lub ust. 5 pkt 1-2 ustawy. |
| PFRON.Stopien | `Soneta.Kadry.StNiepełnosprawności` (enum) | bazodanowe |  |  |
| PFRON.StopienPFRON | `Soneta.Kadry.KodStNiepelnosprawnosciPFRON` (enum) | bazodanowe |  |  |
| PFRON.SzczegolneSchorzeniePFRON | `bool` | tylko-odczyt |  |  |
| PFRON.TypSchorzenia | `Soneta.Kadry.SzczegolneSchorzenia` (enum) | bazodanowe |  |  |
| PFRON.TypSchorzenia2SOD | `Soneta.Kadry.SzczególneSchorzeniaSOD` (enum) | bazodanowe |  |  |
| PFRON.TypSchorzenia3SOD | `Soneta.Kadry.SzczególneSchorzeniaSOD` (enum) | bazodanowe |  |  |
| PFRON.TypSchorzenia4SOD | `Soneta.Kadry.SzczególneSchorzeniaSOD` (enum) | bazodanowe |  |  |
| PFRON.TypSchorzeniaSOD | `Soneta.Kadry.SzczególneSchorzeniaSOD` (enum) | bazodanowe |  |  |
| PFRON.WgPracownikZwolniony | `Key` | podlista |  |  |
| PFRON.WiekEmerytalnyOd | `Date` | bazodanowe |  |  |
| PFRON.WymiarUPodstawowego | `Fraction` | bazodanowe |  |  |
| PFRON.WzrostNettoZatrudnienia | `bool` | bazodanowe |  | Zatrudnienie pracownika spowodowało u pracodawcy wykonującego działalność gospodarczą wzrost netto zatrudnienia ogółem i zatrudnienia pracowników niepełnosprawnych. |
| PFRON.ZgodaNaPrzekazanieDanych | `bool` | bazodanowe |  |  |
| PIT40 | `Soneta.Kadry.DaneDodatkowePIT40` (subrow) | bazodanowe |  |  |
| PIT40.KosztyIndywidualne | `bool` | bazodanowe |  |  |
| PIT40.KosztyKwota | `decimal` | bazodanowe |  |  |
| PIT40.Naliczaj | `bool` | bazodanowe |  |  |
| PIT40.ZwrotSwiadczen | `decimal` | bazodanowe | Zwrot świadczeń |  |
| PIT5BO | `Soneta.Kadry.BilansOtwarciaPIT5` (subrow) | bazodanowe |  |  |
| PIT5BO.Koszty | `decimal` | bazodanowe |  |  |
| PIT5BO.Miesiac | `YearMonth` | bazodanowe |  |  |
| PIT5BO.Ograniczenia | `decimal` | bazodanowe |  |  |
| PIT5BO.Przychod | `decimal` | bazodanowe |  |  |
| PIT5BO.Reklama | `decimal` | bazodanowe |  |  |
| PIT5BO.ReklamaLimit | `decimal` | bazodanowe |  |  |
| PIT5BO.Spoleczne | `decimal` | bazodanowe |  |  |
| PIT5BO.ZaliczkaFis | `decimal` | bazodanowe |  |  |
| PIT5BO.Zdrowotne | `decimal` | bazodanowe |  |  |
| PIT5Inne | `Soneta.Kadry.PIT5DochodyInneBazy` (subrow) | bazodanowe |  |  |
| PIT5Inne.Baza2 | `string` | bazodanowe |  | Nazwa drugiej bazy z dochodami |
| PIT5Inne.Baza2UI | `Soneta.Core.DatabaseLookupItem` |  |  |  |
| PIT5Inne.Baza3 | `string` | bazodanowe |  | Nazwa trzeciej bazy z dochodami |
| PIT5Inne.Baza3UI | `Soneta.Core.DatabaseLookupItem` |  |  |  |
| PIT5Inne.Baza4 | `string` | bazodanowe |  | Nazwa czwartej bazy z dochodami |
| PIT5Inne.Baza4UI | `Soneta.Core.DatabaseLookupItem` |  |  |  |
| PIT5Inne.Baza5 | `string` | bazodanowe |  | Nazwa piątej bazy z dochodami |
| PIT5Inne.Baza5UI | `Soneta.Core.DatabaseLookupItem` |  |  |  |
| PIT5Inne.Baza6 | `string` | bazodanowe |  | Nazwa szóstej bazy z dochodami |
| PIT5Inne.Baza6UI | `Soneta.Core.DatabaseLookupItem` |  |  |  |
| PIT5Inne.Baza7 | `string` | bazodanowe |  | Nazwa siódmej bazy z dochodami |
| PIT5Inne.Baza7UI | `Soneta.Core.DatabaseLookupItem` |  |  |  |
| PIT5Inne.Baza8 | `string` | bazodanowe |  | Nazwa ósmej bazy z dochodami |
| PIT5Inne.Baza8UI | `Soneta.Core.DatabaseLookupItem` |  |  |  |
| PIT5Inne.PodstSkladZdrowBaza | `string` | bazodanowe |  | Podstawa składki zdrowotnej pobierana z innej bazy danych |
| PIT5Inne.PodstSkladZdrowBazaUI | `Soneta.Core.DatabaseLookupItem` |  |  |  |
| PIT5Inne.Udzialy2 | `Fraction` | bazodanowe |  | Udziały w drugiej bazie z dochodami |
| PIT5Inne.Udzialy3 | `Fraction` | bazodanowe |  | Udziały w trzeciej bazie z dochodami |
| PIT5Inne.Udzialy4 | `Fraction` | bazodanowe |  | Udziały w czwartej bazie z dochodami |
| PIT5Inne.Udzialy5 | `Fraction` | bazodanowe |  | Udziały w piątej bazie z dochodami |
| PIT5Inne.Udzialy6 | `Fraction` | bazodanowe |  | Udziały w szóstej bazie z dochodami |
| PIT5Inne.Udzialy7 | `Fraction` | bazodanowe |  | Udziały w siódmej bazie z dochodami |
| PIT5Inne.Udzialy8 | `Fraction` | bazodanowe |  | Udziały w ósmej bazie z dochodami |
| Powiadomic | `Soneta.Core.Osoba` (subrow) | bazodanowe |  |  |
| Powiadomic.Adres | `string` | bazodanowe |  |  |
| Powiadomic.Osoba | `string` | bazodanowe |  |  |
| Powiadomic.Telefon | `string` | bazodanowe |  |  |
| StanRodzinny | `Soneta.Kadry.StanRodzinny` (subrow) | bazodanowe |  |  |
| StanRodzinny.DataSlubu | `Date` | bazodanowe |  |  |
| StanRodzinny.NrAktuMalzenstwa | `string` | bazodanowe |  |  |
| StanRodzinny.StanCywilny | `Soneta.Kadry.StanCywilnyPłeć` (enum) | bazodanowe |  |  |
| StanRodzinny.USCMiasto | `string` | bazodanowe |  |  |
| StanowiskoPelne | `string` | bazodanowe |  |  |
| Wojsko | `Soneta.Kadry.Wojsko` (subrow) | bazodanowe |  |  |
| Wojsko.KategoriaZdrowia | `Soneta.Kadry.KategoriaZdrowia` (enum) | bazodanowe |  |  |
| Wojsko.NrKsiazeczki | `string` | bazodanowe |  |  |
| Wojsko.NrSpecjalnosci | `string` | bazodanowe |  |  |
| Wojsko.Podlega | `bool` | tylko-odczyt |  |  |
| Wojsko.PrzydzialMobilizacyjny | `string` | bazodanowe |  |  |
| Wojsko.Stopien | `string` | bazodanowe |  |  |
| Wojsko.Stosunek | `Soneta.Kadry.KodStosDoSluzbyWojskowej` (enum) | bazodanowe |  |  |
| Wojsko.WKU | `string` | bazodanowe |  |  |
| Wyksztalcenie | `Soneta.Kadry.Wyksztalcenie` (subrow) | bazodanowe |  |  |
| Wyksztalcenie.Kod | `Soneta.Kadry.KodWyksztalcenia` (enum) | bazodanowe |  |  |
| Wyksztalcenie.StopienNaukowy | `string` | bazodanowe |  |  |
| Wyksztalcenie.SymbolSystemuCzasuPracyGUS | `Soneta.Kadry.SymbolSystemuCzasuPracy` (enum) | bazodanowe |  |  |
| Wyksztalcenie.TytulNaukowy | `string` | bazodanowe |  |  |
| ZUS | `Soneta.Kadry.DaneZUS` (subrow) | bazodanowe |  |  |
| ZUS.DataWniosku | `Date` | bazodanowe |  |  |
| ZUS.DataZaswiadczenia | `Date` | bazodanowe |  |  |
| ZUS.Okres | `FromTo` | bazodanowe, podlista |  |  |
| ZUS.OkresEpd | `FromTo` | podlista |  |  |
| ZUS.OkresExt | `FromTo` | podlista |  |  |
| ZUS.OkresExtOld | `FromTo` | podlista |  |  |
| ZUS.Orzeczenie | `Soneta.Kadry.StNiezdolnościDoPracy` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KategoriaZdrowia (`Soneta.Kadry.KategoriaZdrowia`)
- `ND` = 1 — Nie dotyczy
- `A` = 2 — Kategoria A
- `B` = 3 — Kategoria B
- `D` = 4 — Kategoria D
- `E` = 5 — Kategoria E

### KodRodzajNumeruPodatnika (`Soneta.Kadry.KodRodzajNumeruPodatnika`)
- `Nieokreślony` = 0
- `NumerIdentyfikacyjnyTIN` = 1 — Numer identyfikacyjny TIN
- `NumerUbezpieczeniowy` = 2
- `Paszport` = 3
- `UrzędowyDokumentStwierdzającyTożsamość` = 4
- `InnyRodzajIdentyfikacjiPodatkowej` = 8
- `InnyDokumentPotwierdzającyTożsamość` = 9

### KodRodzajuDokumentu (`Soneta.Kadry.KodRodzajuDokumentu`)
- `Niezdefiniowany` = 0
- `DowodOsobisty` = 1 — Dowód osobisty
- `Paszport` = 2 — 2 - paszport

### KodStNiepelnosprawnosciPFRON (`Soneta.Kadry.KodStNiepelnosprawnosciPFRON`)
- `Brak` = 0
- `Lekki` = 1
- `Umiarkowany` = 2
- `Znaczny` = 3
- `OsobaDo16Roku` = 4 — Osoba niepełnosprawna do 16 roku życia
- `OsobaBezStopnia` = 5 — Osoba niepełnosprawna bez orzeczonego stopnia niepełnosprawności

### KodStosDoSluzbyWojskowej (`Soneta.Kadry.KodStosDoSluzbyWojskowej`)
- `NieDotyczy` = 1 — Nie dotyczy
- `NiePodlega` = 2
- `Przedpoborowy` = 3
- `Poborowy` = 4
- `Rezerwa` = 5
- `Inne` = 6

### KodWyksztalcenia (`Soneta.Kadry.KodWyksztalcenia`)
- `NieDotyczy` = 0
- `NiepelnePodstawowe` = 11 — Niepełne podstawowe
- `Podstawowe` = 12
- `Gimnazjalne` = 13
- `ZasadniczeZawodowe` = 20
- `SrednieZawodowe` = 31 — Średnie zawodowe
- `SrednieOgolnoksztalcace` = 32 — Średnie ogólnokształcące
- `Policealne` = 40
- `Licencjat` = 49 — Wyższe z tytułem inżyniera, licencjata, dyplomowanego ekonomisty lub równorzędnym
- `Wyzsze` = 50 — Wyższe z tytułem magistra, lekarza lub równorzędnym
- `WyższeZeStopiemNaukowym` = 51 — Wyższe ze stopniem naukowym co najmniej doktora

### MiejsceZamieszkania (`Soneta.Kadry.MiejsceZamieszkania`)
- `Miasto` = 1
- `Wieś` = 2

### ObniżenieWymiaruEtatuInfo (`Soneta.Kadry.ObniżenieWymiaruEtatuInfo`)
- `Brak` = 0
- `TypStawki` = 1
- `Wymiar` = 2
- `Stawka` = 4
- `Wskaźnik` = 8
- `Kalendarz` = 256
- `Zaszeregowanie` = 15
- `ZaszeregowanieIKalendarz` = 271

### OrganWydajacyOrzeczenie (`Soneta.Kadry.OrganWydajacyOrzeczenie`)
- `NieDotyczy` = 0
- `PowiatowyZespolDoSprawOrzekaniaONiepelnosprawnosci` = 1 — Powiatowy Zespół do Spraw Orzekania o Niepełnosprawności
- `MiejskiZespolDoSprawOrzekaniaONiepelnosprawnosci` = 2 — Miejski Zespół do Spraw Orzekania o Niepełnosprawności
- `WojewodzkiZespolDoSprawOrzekaniaONiepelnosprawnosci` = 3 — Wojewódzki Zespół do Spraw Orzekania o Niepełnosprawności

### PodstZdrowCudzoziemca (`Soneta.Kadry.PodstZdrowCudzoziemca`)
- `Brak` = 0
- `KartaStalegoPobytu` = 1 — Karta stałego pobytu
- `KartaCzasowegoPobytu` = 2
- `ZielonaKarta` = 3 — Wiza z prawem do pracy
- `InnePrzepisy` = 4
- `UmowaMiedzynarodowa` = 5 — Umowa międzynarodowa

### PoziomWykształcenia (`Soneta.Kadry.PoziomWykształcenia`)
- `BezWykształcenia` = 0
- `Podstawowe` = 1 — Wykształcenie podstawowe
- `Gimnazjalne` = 2 — Wykształcenie gimnazjalne
- `ZasadniczeZawodoweLubŚrednie` = 3 — Wykształcenie zasadnicze zawodowe lub średnie (ponadpodstawowe lub ponadgimnazjalne)
- `Kolegialne` = 4 — Wykształcenie kolegialne
- `WyższeZawodowe` = 5 — Wykształcenie wyższe zawodowe z tytułem inżyniera, licencjata lub równorzędnym
- `WyższeMagisterskie` = 6 — Wykształcenie wyższe magisterskie z tytułem magistra, lekarza lub równorzędnym
- `Doktorat` = 8 — Posiadanie stopnia naukowego doktora
- `Habilitacja` = 9 — Posiadanie stopnia naukowego doktora habilitowanego

### RodzajKartyPobytu (`Soneta.Kadry.RodzajKartyPobytu`)
- `Brak` = 0
- `KartaStałegoPobytu` = 1
- `KartaCzasowegoPobytu` = 2
- `KartaRezydentaUe` = 3 — Karta rezydenta UE

### RodzajPracownikaOświaty (`Soneta.Kadry.RodzajPracownikaOświaty`)
- `NieDotyczy` = 0
- `Nauczyciel` = 1

### RodzajStawkiZaszeregowania (`Soneta.Kadry.RodzajStawkiZaszeregowania`)
- `Godzinowa` = 0 — Za godzinę
- `Miesieczna` = 1 — Miesięcznie
- `DochodDeklarowany` = 2 — Dochód deklarowany

### RodzajeDodatkowychŚwiadczeńZUS (`Soneta.Kadry.RodzajeDodatkowychŚwiadczeńZUS`)
- `Brak` = 0 — Brak
- `RentaSocjalna` = 1
- `ŚwiadczeniePrzedemerytalne` = 2
- `ZasiłekPrzedemerytalny` = 3

### StNiepełnosprawności (`Soneta.Kadry.StNiepełnosprawności`)
- `Brak` = 0
- `Lekki` = 1
- `Umiarkowany` = 2
- `Znaczny` = 3

### StNiezdolnościDoPracy (`Soneta.Kadry.StNiezdolnościDoPracy`)
- `Brak` = 0
- `CzęściowaNiezdolnośćDoPracy` = 1
- `CałkowitaNiezdolnośćDoPracy` = 2
- `NiezdolnośćDoSamodzielnejEgzystencji` = 3
- `OsobaBezStopnia` = 5 — Osoba niepełnosprawna w okresie bez orzeczonego stopnia niezdolności do pracy

### StanCywilnyPłeć (`Soneta.Kadry.StanCywilnyPłeć`)
- `nieokreślony` = 0
- `wolny` = 1
- `wolna` = 2
- `kawaler` = 3
- `panna` = 4
- `rozwiedziony` = 5
- `rozwiedziona` = 6
- `żonaty` = 7
- `mężatka` = 8
- `wdowiec` = 9
- `wdowa` = 10

### StanowiPomocPubliczną (`Soneta.Kadry.StanowiPomocPubliczną`)
- `WgKonfiguracji` = 0 — Wg konfiguracji

### SymbolSystemuCzasuPracy (`Soneta.Kadry.SymbolSystemuCzasuPracy`)
- `Podstawowy` = 10 — 10 – podstawowy
- `Rownowazny12` = 21 — 21 – równoważny – wersja podstawowa (w wymiarze do 12 godz.)
- `Rownowazny16` = 22 — 22 – równoważny – wersja szczególna (w wymiarze do 16 godz.)
- `Rownowazny24` = 23 — 23 – równoważny – wersja szczególna (w wymiarze do 24 godz.)
- `Przerywany` = 30 — 30 – przerywany
- `Zadaniowy` = 40 — 40 – zadaniowy
- `SkroconyTydzien` = 50 — 50 – praca w skróconym tygodniu pracy
- `RuchCiagly` = 60 — 60 – praca w ruchu ciągłym

### SzczegolneSchorzenia (`Soneta.Kadry.SzczegolneSchorzenia`)
- `NieDotyczy` = 0
- `ChorobaPsychiczna` = 1 — Przewlekła choroba psychiczna
- `UpośledzenieUmysłowe` = 2
- `Epilepsja` = 3
- `Niewidomy` = 4 — Znaczne upośledzenie widzenia (ślepota) oraz niedowidzenie
- `ChorobaParkinsona` = 5
- `StwardnienieRozsiane` = 6
- `ParaplegiaTetraplegiaHemiplegia` = 7 — Paraplegia, tetraplegia, hemiplegia
- `GłuchotaIGłuchoniemota` = 8
- `NosicielstwoWirusaHIVOrazChorobaAIDS` = 9 — Nosicielstwo wirusa HIV oraz choroba AIDS
- `Miastemia` = 10
- `PóźnePowikłaniaCukrzycowe` = 11
- `Ogolne` = 12 — Ogólne

### SzczególneSchorzeniaSOD (`Soneta.Kadry.SzczególneSchorzeniaSOD`)
- `Niezdefiniowany` = 0
- `UpośledzeniaUmysłowe` = 1 — 01-U - upośledzenie umysłowe
- `ChorobyPsychiczne` = 2 — 02-P - choroby psychiczne
- `ZaburzeniaGłosuMowyIChorobySłuchu` = 3 — 03-L - zaburzenia głosu, mowy i choroby słuchu
- `ChorobyNarząduWzroku` = 4 — 04-O - choroby narządu wzroku
- `UpośledzenieNarząduRuchu` = 5 — 05-R - upośledzenie narządu ruchu
- `Epilepsja` = 6 — 06-E - epilepsja
- `ChorobyUkładuOddechowegoIKrążenia` = 7 — 07-S - choroby układu oddechowego i krążenia
- `ChorobyUkładuPokarmowego` = 8 — 08-T - choroby układu pokarmowego
- `ChorobyUkładuMoczowoPłciowego` = 9 — 09-M - choroby układu moczowo-płciowego
- `ChorobyNeurologiczne` = 10 — 10-N - choroby neurologiczne
- `InneSchorzenia` = 11 — 11-I - inne, w tym schorzenia: endokrynologiczne, metaboliczne, zaburzenia enzymatyczne, choroby zakaźne i odzwierzęce, zeszpecenia, choroby układu krwiotwórczego
- `CałościoweZaburzeniaRozwojowe` = 12 — 12-C - całościowe zaburzenia rozwojowe

### TypStawkiZaszeregowania (`Soneta.Kadry.TypStawkiZaszeregowania`)
- `Dowolna` = 0 — Dowolna
- `Minimalna` = 1
- `ZZakresu` = 2
- `WgWskaźnika` = 3
- `Nieokreślona` = 10
