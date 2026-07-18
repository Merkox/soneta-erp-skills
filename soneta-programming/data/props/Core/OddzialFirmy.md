# Pola i właściwości klasy biznesowej: `Soneta.Core.OddzialFirmy`
Nazwa tabeli: `OddzialyFirmy`
Tytuł: Oddziały firmy
Opis: Kartoteka oddziałów firmy (centrala, filie, oddziały). Zawiera dane identyfikacyjne (symbol, identyfikator, nazwa), strukturę hierarchiczną (oddział nadrzędny), adresy, dane kontaktowe, numery licencji, okresy księgowe i VAT oraz flagi przeznaczenia (dokumentowy, księgowy, firmowy, CRM).
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IElementSlownika`, `IRightsSource`, `IAdresHost`, `IOddzialFirmy`, `IElementStrukturyFirmy`, `IDaneKontaktoweHost`, `IAdresyWWWHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresDoKorespondencji | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresZleceniodawcyPrzelewu | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresyWWW | `SubTable<Soneta.Core.AdresWWW>` | podlista |  |  |
| BDO | `string` | tylko-odczyt |  |  |
| BasicDocuments | `SubTable` | podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| CRM | `bool` | bazodanowe |  |  |
| Centrala | `bool` | tylko-odczyt |  |  |
| CzSz | `bool` | bazodanowe |  |  |
| Deklaracje | `Soneta.Core.DeklaracjeOddziału` (subrow) | bazodanowe |  |  |
| Deklaracje.CIT | `Soneta.Core.NaliczanieDeklaracjiOddziału` (enum) | bazodanowe |  |  |
| Deklaracje.CITST | `Soneta.Core.UwzględniajNaDeklaracji` (enum) | bazodanowe |  |  |
| Deklaracje.CITSTA | `Soneta.Core.UwzględniajNaDeklaracji` (enum) | bazodanowe |  |  |
| Deklaracje.DanePFRON | `Soneta.Core.DanePFRONOddziału` (subrow) | bazodanowe |  |  |
| Deklaracje.DanePFRON.AdresPełnomocnika | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| Deklaracje.DanePFRON.DzialalnoscGospodarcza | `bool` | bazodanowe |  |  |
| Deklaracje.DanePFRON.EmailPFRON | `string` | bazodanowe | Adres email PFRON |  |
| Deklaracje.DanePFRON.EmailPelnomocnika | `string` | bazodanowe | Adres email pełnomocnika |  |
| Deklaracje.DanePFRON.FormaPrawna | `string` | bazodanowe |  |  |
| Deklaracje.DanePFRON.FormaPrawna2 | `string` | bazodanowe |  |  |
| Deklaracje.DanePFRON.FormaWlasnosci | `string` | bazodanowe |  |  |
| Deklaracje.DanePFRON.KodAdresuPrzedsiebiorcy | `string` | bazodanowe |  |  |
| Deklaracje.DanePFRON.NazwaPelnomocnika | `string` | bazodanowe | Nazwa pełnomocnika |  |
| Deklaracje.DanePFRON.NrRachunku | `Soneta.Core.IEwidencjaSP` | bazodanowe |  |  |
| Deklaracje.DanePFRON.PFRON | `string` | bazodanowe |  |  |
| Deklaracje.DanePFRON.PKD | `string` | bazodanowe |  |  |
| Deklaracje.DanePFRON.StanowiPomocPubliczna | `bool` | bazodanowe |  |  |
| Deklaracje.DanePFRON.StatusZPChr | `bool` | bazodanowe |  |  |
| Deklaracje.DanePFRON.StatusZPChrOkres | `FromTo` | bazodanowe, podlista |  |  |
| Deklaracje.DanePFRON.WgNrRachunku | `Key` | podlista |  |  |
| Deklaracje.DanePFRON.WielkoscPracodawcy | `string` | bazodanowe |  |  |
| Deklaracje.DanePFRON.ZakladAktywnosciZawodowej | `bool` | bazodanowe | Zakład aktywności zawodowej |  |
| Deklaracje.DanePPK | `Soneta.Core.DanePPKOddziału` (subrow) | bazodanowe |  |  |
| Deklaracje.DanePPK.NaliczajZeroweRaporty | `bool` | bazodanowe | Naliczaj zerowe raporty |  |
| Deklaracje.DanePPK.NumerUmowy | `string` | bazodanowe | Numer umowy |  |
| Deklaracje.DanePPK.PodlegaOd | `YearMonth` |  |  |  |
| Deklaracje.DanePPK.PodlegaOdData | `Date` | bazodanowe, tylko-odczyt | Podlega od |  |
| Deklaracje.DanePPK.SkladkiOd | `Date` | bazodanowe | Składki od |  |
| Deklaracje.DanePPK.Upowaznieni | `string` | bazodanowe | Upoważnieni |  |
| Deklaracje.DataRozpDzialalnosci | `Date` | bazodanowe |  |  |
| Deklaracje.Email | `string` | bazodanowe | Adres email |  |
| Deklaracje.EuVAT | `string` | bazodanowe | EU VAT |  |
| Deklaracje.Imie | `string` | bazodanowe | Imię osoby odpowiedzialnej |  |
| Deklaracje.InstytucjaFinansowaPPK | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Deklaracje.KRS | `string` | bazodanowe |  |  |
| Deklaracje.KodGminy | `string` | bazodanowe |  |  |
| Deklaracje.KontrahentPomocniczyCentrala | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref |  | Kontrahent pomocniczy służący do rozliczeń zobowiązań podatkowych centrali w oddziale |
| Deklaracje.KontrahentPomocniczyOddzial | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref |  | Kontrahent pomocniczy służący do rozliczeń zobowiązań podatkowych oddziału w centrali |
| Deklaracje.LukaPlacowa | `Soneta.Core.NaliczanieDeklaracjiOddziału` (enum) | bazodanowe |  |  |
| Deklaracje.NIP | `string` | bazodanowe |  |  |
| Deklaracje.Nazwisko | `string` | bazodanowe | Nazwisko osoby odpowiedzialnej |  |
| Deklaracje.NumerRachunkuUS | `Soneta.Core.NumerRachunkuUS` (subrow) | bazodanowe |  |  |
| Deklaracje.NumerRachunkuUS.CS | `string` |  |  |  |
| Deklaracje.NumerRachunkuUS.Kierunek | `string` |  |  |  |
| Deklaracje.NumerRachunkuUS.Kraj | `string` |  |  |  |
| Deklaracje.NumerRachunkuUS.Numer | `string` |  |  |  |
| Deklaracje.NumerRachunkuUS.Rachunek | `Soneta.Core.IRachunekBankowyPodmiotu` | bazodanowe |  |  |
| Deklaracje.NumerRachunkuUS.SWIFT | `string` |  |  |  |
| Deklaracje.NumerRachunkuUS.WgRachunek | `Key` | podlista |  |  |
| Deklaracje.NumerRachunkuUSVAT | `Soneta.Core.NumerRachunkuUS` (subrow) | bazodanowe |  |  |
| Deklaracje.NumerRachunkuZUS | `Soneta.Core.NumerRachunkuZUS` (subrow) | bazodanowe |  |  |
| Deklaracje.NumerRachunkuZUS.CS | `string` |  |  |  |
| Deklaracje.NumerRachunkuZUS.Kierunek | `string` |  |  |  |
| Deklaracje.NumerRachunkuZUS.Kraj | `string` |  |  |  |
| Deklaracje.NumerRachunkuZUS.Numer | `string` |  |  |  |
| Deklaracje.NumerRachunkuZUS.Rachunek | `Soneta.Core.IRachunekBankowyPodmiotu` | bazodanowe |  |  |
| Deklaracje.NumerRachunkuZUS.SWIFT | `string` |  |  |  |
| Deklaracje.NumerRachunkuZUS.WgRachunek | `Key` | podlista |  |  |
| Deklaracje.PFRON | `Soneta.Core.NaliczanieDeklaracjiOddziału` (enum) | bazodanowe |  |  |
| Deklaracje.PIT | `Soneta.Core.NaliczanieDeklaracjiOddziału` (enum) | bazodanowe |  |  |
| Deklaracje.PKD | `string` | bazodanowe |  |  |
| Deklaracje.PKD2 | `string` | bazodanowe |  |  |
| Deklaracje.PPK | `Soneta.Core.NaliczanieDeklaracjiOddziału` (enum) | bazodanowe |  |  |
| Deklaracje.PierwszyUrzadSkarbowy | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Deklaracje.PierwszyUrzadSkarbowyOsobyPrawne | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Deklaracje.REGON | `string` | bazodanowe |  |  |
| Deklaracje.RachunekBankowyPPK | `Soneta.Core.IRachunekBankowyPodmiotu` | bazodanowe |  |  |
| Deklaracje.Seria | `string` | bazodanowe |  |  |
| Deklaracje.Telefon | `string` | bazodanowe | Telefon osoby odpowiedzialnej |  |
| Deklaracje.UrzadSkarbowy | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Deklaracje.UrzadSkarbowyPodatek | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Deklaracje.VAT | `Soneta.Core.NaliczanieDeklaracjiOddziału` (enum) | bazodanowe |  |  |
| Deklaracje.VATUE | `bool` | bazodanowe |  |  |
| Deklaracje.WgInstytucjaFinansowaPPK | `Key` | podlista |  |  |
| Deklaracje.WgKontrahentPomocniczyCentrala | `Key` | podlista |  |  |
| Deklaracje.WgKontrahentPomocniczyOddzial | `Key` | podlista |  |  |
| Deklaracje.WgPierwszyUrzadSkarbowy | `Key` | podlista |  |  |
| Deklaracje.WgPierwszyUrzadSkarbowyOsobyPrawne | `Key` | podlista |  |  |
| Deklaracje.WgRachunekBankowyPPK | `Key` | podlista |  |  |
| Deklaracje.WgUrzadSkarbowy | `Key` | podlista |  |  |
| Deklaracje.WgUrzadSkarbowyPodatek | `Key` | podlista |  |  |
| Deklaracje.ZUS | `Soneta.Core.NaliczanieDeklaracjiOddziału` (enum) | bazodanowe |  |  |
| DeklaracjeElementuStruktury | `SubTable` | podlista |  |  |
| Dokumentowy | `bool` | bazodanowe |  |  |
| DokumentyAktualizacjiElementuStruktury | `SubTable` | podlista |  |  |
| DomyslnyAdres | `Soneta.Core.AdresExt` | tylko-odczyt |  |  |
| DomyślnyAdresWWW | `string` | tylko-odczyt |  |  |
| EORI | `string` | tylko-odczyt |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Firma | `Soneta.Core.OddzialFirmy` | tylko-odczyt | Firma |  |
| Firmowy | `bool` | bazodanowe |  |  |
| HistoriaPodleglosci | `HistorySubTable<Soneta.Core.OddzialFirmyRef>` | podlista |  |  |
| HistoriaZmian | `SubTable<Soneta.Core.HistoriaDanychOddziału>` | podlista |  |  |
| Identyfikacje | `SubTable` | podlista |  |  |
| Identyfikator | `string` | bazodanowe |  |  |
| IsAdresZleceniodawcyPrzelewu | `bool` |  |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| Kontakt | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `SubTable<Soneta.Core.DaneKontaktowe>` | podlista |  |  |
| Ksiegowy | `bool` | bazodanowe |  |  |
| LokalizacjeNadawcze | `SubTable` | podlista |  |  |
| Magazyny | `SubTable` | podlista |  |  |
| Matters | `SubTable` | podlista |  |  |
| Metryka | `SubTable<Soneta.Core.MetrykaOddziałuFirmy>` | podlista |  |  |
| Nadrzedny | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt |  | Oddział nadrzędny |
| Nazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
| NazwaSkrocona | `string` | bazodanowe |  |  |
| NumerLicencji | `string` | bazodanowe | Numer licencji oddziału | Numer licencji z której mają być pobierane informacje do wydruków. |
| ObjectRight | `AccessRights` (enum) | tylko-odczyt |  |  |
| OcenyElementuStruktury | `SubTable` | podlista |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| OkresKsiegowy | `FromTo` | bazodanowe, podlista |  |  |
| OkresRozliczenKs | `FromTo` | bazodanowe, podlista |  |  |
| OkresVAT | `FromTo` | bazodanowe, podlista |  |  |
| PKD | `string` | tylko-odczyt |  |  |
| Pododdzialy | `SubTable<Soneta.Core.OddzialFirmy>` | podlista |  |  |
| PododdzialyWgAktualnosci | `SubTable<Soneta.Core.OddzialFirmyRef>` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| PrzelewZlecAdres | `string` | bazodanowe |  |  |
| PrzelewZlecNazwa | `string` | bazodanowe |  |  |
| Root | `bool` | tylko-odczyt |  |  |
| Slownikowy | `bool` | bazodanowe |  |  |
| StatusLicencji | `string` | tylko-odczyt |  |  |
| SufiksNazwy | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Termin | `Date` | tylko-odczyt |  |  |
| WszystkiePododdzialy | `System.Collections.Generic.List<Soneta.Core.OddzialFirmy>` | podlista |  |  |
| WydzialyProdukcyjne | `SubTable` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Deklaracje.InstytucjaFinansowaPPK | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
| Deklaracje.KontrahentPomocniczyCentrala | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| Deklaracje.KontrahentPomocniczyOddzial | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| Deklaracje.PierwszyUrzadSkarbowy | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
| Deklaracje.PierwszyUrzadSkarbowyOsobyPrawne | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
| Deklaracje.UrzadSkarbowy | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
| Deklaracje.UrzadSkarbowyPodatek | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessRights (`AccessRights`)
- `Denied` = 0 — Zakaz dostępu
- `ReadOnly` = 1 — Tylko odczyt
- `Granted` = 2 — Pełne prawo
- `NoInit` = 3 — Niezainicjowane

### NaliczanieDeklaracjiOddziału (`Soneta.Core.NaliczanieDeklaracjiOddziału`)
- `NieNaliczaj` = 0 — Nie naliczaj
- `TylkoDoSprawdzenia` = 1
- `Naliczaj` = 2
- `NaliczajCzastkowa` = 3 — Naliczaj cząstkową
- `NaliczajDlaGrupy` = 4

### UwzględniajNaDeklaracji (`Soneta.Core.UwzględniajNaDeklaracji`)
- `NieUwzględniaj` = 0
- `Uwzględniaj` = 2
