# Pola i właściwości klasy biznesowej: `Soneta.Core.OddzialFirmy`
Nazwa tabeli: `OddzialyFirmy`
Tytuł: Oddziały firmy
Opis: Kartoteka oddziałów firmy (centrala, filie, oddziały). Zawiera dane identyfikacyjne (symbol, identyfikator, nazwa), strukturę hierarchiczną (oddział nadrzędny), adresy, dane kontaktowe, numery licencji, okresy księgowe i VAT oraz flagi przeznaczenia (dokumentowy, księgowy, firmowy, CRM).
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IElementSlownika`, `IRightsSource`, `IAdresHost`, `IOddzialFirmy`, `IElementStrukturyFirmy`, `IDaneKontaktoweHost`, `IAdresyWWWHost`

- pola bazodanowe: 85
- pola kalkulowane (z klas biznesowych): 61

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| AdresDoKorespondencji | `Soneta.Core.Adres` |  |  |  |
| AdresZleceniodawcyPrzelewu | `Soneta.Core.Adres` |  |  |  |
| AdresyWWW | `Soneta.Business.SubTable<Soneta.Core.AdresWWW>` |  |  |  |
| BDO | `string` |  |  |  |
| BasicDocuments | `Soneta.Business.SubTable` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| CRM | `bool` | bazodanowe |  |  |
| Centrala | `bool` |  |  |  |
| CzSz | `bool` | bazodanowe |  |  |
| Deklaracje | `Soneta.Core.DeklaracjeOddziału` | bazodanowe |  |  |
| Deklaracje.CIT | `Soneta.Core.NaliczanieDeklaracjiOddziału` | bazodanowe, enum |  |  |
| Deklaracje.CITST | `Soneta.Core.UwzględniajNaDeklaracji` | bazodanowe, enum |  |  |
| Deklaracje.CITSTA | `Soneta.Core.UwzględniajNaDeklaracji` | bazodanowe, enum |  |  |
| Deklaracje.DanePFRON | `Soneta.Core.DanePFRONOddziału` | bazodanowe |  |  |
| Deklaracje.DanePFRON.AdresPełnomocnika | `Soneta.Core.Adres` |  |  |  |
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
| Deklaracje.DanePFRON.StatusZPChrOkres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Deklaracje.DanePFRON.WgNrRachunku | `Soneta.Business.Key` |  |  |  |
| Deklaracje.DanePFRON.WielkoscPracodawcy | `string` | bazodanowe |  |  |
| Deklaracje.DanePFRON.ZakladAktywnosciZawodowej | `bool` | bazodanowe | Zakład aktywności zawodowej |  |
| Deklaracje.DanePPK | `Soneta.Core.DanePPKOddziału` | bazodanowe |  |  |
| Deklaracje.DanePPK.NaliczajZeroweRaporty | `bool` | bazodanowe | Naliczaj zerowe raporty |  |
| Deklaracje.DanePPK.NumerUmowy | `string` | bazodanowe | Numer umowy |  |
| Deklaracje.DanePPK.PodlegaOd | `Soneta.Types.YearMonth` |  |  |  |
| Deklaracje.DanePPK.PodlegaOdData | `Soneta.Types.Date` | bazodanowe | Podlega od |  |
| Deklaracje.DanePPK.SkladkiOd | `Soneta.Types.Date` | bazodanowe | Składki od |  |
| Deklaracje.DanePPK.Upowaznieni | `string` | bazodanowe | Upoważnieni |  |
| Deklaracje.DataRozpDzialalnosci | `Soneta.Types.Date` | bazodanowe |  |  |
| Deklaracje.Email | `string` | bazodanowe | Adres email |  |
| Deklaracje.EuVAT | `string` | bazodanowe | EU VAT |  |
| Deklaracje.Imie | `string` | bazodanowe | Imię osoby odpowiedzialnej |  |
| Deklaracje.InstytucjaFinansowaPPK | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Deklaracje.KRS | `string` | bazodanowe |  |  |
| Deklaracje.KodGminy | `string` | bazodanowe |  |  |
| Deklaracje.KontrahentPomocniczyCentrala | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref |  | Kontrahent pomocniczy służący do rozliczeń zobowiązań podatkowych centrali w oddziale |
| Deklaracje.KontrahentPomocniczyOddzial | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref |  | Kontrahent pomocniczy służący do rozliczeń zobowiązań podatkowych oddziału w centrali |
| Deklaracje.LukaPlacowa | `Soneta.Core.NaliczanieDeklaracjiOddziału` | bazodanowe, enum |  |  |
| Deklaracje.NIP | `string` | bazodanowe |  |  |
| Deklaracje.Nazwisko | `string` | bazodanowe | Nazwisko osoby odpowiedzialnej |  |
| Deklaracje.NumerRachunkuUS | `Soneta.Core.NumerRachunkuUS` | bazodanowe |  |  |
| Deklaracje.NumerRachunkuUS.CS | `string` |  |  |  |
| Deklaracje.NumerRachunkuUS.Kierunek | `string` |  |  |  |
| Deklaracje.NumerRachunkuUS.Kraj | `string` |  |  |  |
| Deklaracje.NumerRachunkuUS.Numer | `string` |  |  |  |
| Deklaracje.NumerRachunkuUS.Rachunek | `Soneta.Core.IRachunekBankowyPodmiotu` | bazodanowe |  |  |
| Deklaracje.NumerRachunkuUS.SWIFT | `string` |  |  |  |
| Deklaracje.NumerRachunkuUS.WgRachunek | `Soneta.Business.Key` |  |  |  |
| Deklaracje.NumerRachunkuUSVAT | `Soneta.Core.NumerRachunkuUS` | bazodanowe |  |  |
| Deklaracje.NumerRachunkuZUS | `Soneta.Core.NumerRachunkuZUS` | bazodanowe |  |  |
| Deklaracje.NumerRachunkuZUS.CS | `string` |  |  |  |
| Deklaracje.NumerRachunkuZUS.Kierunek | `string` |  |  |  |
| Deklaracje.NumerRachunkuZUS.Kraj | `string` |  |  |  |
| Deklaracje.NumerRachunkuZUS.Numer | `string` |  |  |  |
| Deklaracje.NumerRachunkuZUS.Rachunek | `Soneta.Core.IRachunekBankowyPodmiotu` | bazodanowe |  |  |
| Deklaracje.NumerRachunkuZUS.SWIFT | `string` |  |  |  |
| Deklaracje.NumerRachunkuZUS.WgRachunek | `Soneta.Business.Key` |  |  |  |
| Deklaracje.PFRON | `Soneta.Core.NaliczanieDeklaracjiOddziału` | bazodanowe, enum |  |  |
| Deklaracje.PIT | `Soneta.Core.NaliczanieDeklaracjiOddziału` | bazodanowe, enum |  |  |
| Deklaracje.PKD | `string` | bazodanowe |  |  |
| Deklaracje.PKD2 | `string` | bazodanowe |  |  |
| Deklaracje.PPK | `Soneta.Core.NaliczanieDeklaracjiOddziału` | bazodanowe, enum |  |  |
| Deklaracje.PierwszyUrzadSkarbowy | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Deklaracje.PierwszyUrzadSkarbowyOsobyPrawne | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Deklaracje.REGON | `string` | bazodanowe |  |  |
| Deklaracje.RachunekBankowyPPK | `Soneta.Core.IRachunekBankowyPodmiotu` | bazodanowe |  |  |
| Deklaracje.Seria | `string` | bazodanowe |  |  |
| Deklaracje.Telefon | `string` | bazodanowe | Telefon osoby odpowiedzialnej |  |
| Deklaracje.UrzadSkarbowy | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Deklaracje.UrzadSkarbowyPodatek | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Deklaracje.VAT | `Soneta.Core.NaliczanieDeklaracjiOddziału` | bazodanowe, enum |  |  |
| Deklaracje.VATUE | `bool` | bazodanowe |  |  |
| Deklaracje.WgInstytucjaFinansowaPPK | `Soneta.Business.Key` |  |  |  |
| Deklaracje.WgKontrahentPomocniczyCentrala | `Soneta.Business.Key` |  |  |  |
| Deklaracje.WgKontrahentPomocniczyOddzial | `Soneta.Business.Key` |  |  |  |
| Deklaracje.WgPierwszyUrzadSkarbowy | `Soneta.Business.Key` |  |  |  |
| Deklaracje.WgPierwszyUrzadSkarbowyOsobyPrawne | `Soneta.Business.Key` |  |  |  |
| Deklaracje.WgRachunekBankowyPPK | `Soneta.Business.Key` |  |  |  |
| Deklaracje.WgUrzadSkarbowy | `Soneta.Business.Key` |  |  |  |
| Deklaracje.WgUrzadSkarbowyPodatek | `Soneta.Business.Key` |  |  |  |
| Deklaracje.ZUS | `Soneta.Core.NaliczanieDeklaracjiOddziału` | bazodanowe, enum |  |  |
| DeklaracjeElementuStruktury | `Soneta.Business.SubTable` |  |  |  |
| Dokumentowy | `bool` | bazodanowe |  |  |
| DokumentyAktualizacjiElementuStruktury | `Soneta.Business.SubTable` |  |  |  |
| DomyslnyAdres | `Soneta.Core.AdresExt` |  |  |  |
| DomyślnyAdresWWW | `string` |  |  |  |
| EORI | `string` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Firma | `Soneta.Core.OddzialFirmy` |  | Firma |  |
| Firmowy | `bool` | bazodanowe |  |  |
| HistoriaPodleglosci | `Soneta.Business.HistorySubTable<Soneta.Core.OddzialFirmyRef>` |  |  |  |
| HistoriaZmian | `Soneta.Business.SubTable<Soneta.Core.HistoriaDanychOddziału>` |  |  |  |
| Identyfikacje | `Soneta.Business.SubTable` |  |  |  |
| Identyfikator | `string` | bazodanowe |  |  |
| IsAdresZleceniodawcyPrzelewu | `bool` |  |  |  |
| Kod | `string` |  |  |  |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `Soneta.Business.SubTable<Soneta.Core.DaneKontaktowe>` |  |  |  |
| Ksiegowy | `bool` | bazodanowe |  |  |
| LokalizacjeNadawcze | `Soneta.Business.SubTable` |  |  |  |
| Magazyny | `Soneta.Business.SubTable` |  |  |  |
| Matters | `Soneta.Business.SubTable` |  |  |  |
| Metryka | `Soneta.Business.SubTable<Soneta.Core.MetrykaOddziałuFirmy>` |  |  |  |
| Nadrzedny | `Soneta.Core.OddzialFirmy` | bazodanowe |  | Oddział nadrzędny |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` |  |  |  |
| NazwaSkrocona | `string` | bazodanowe |  |  |
| NumerLicencji | `string` | bazodanowe | Numer licencji oddziału | Numer licencji z której mają być pobierane informacje do wydruków. |
| ObjectRight | `Soneta.Business.AccessRights` | enum |  |  |
| OcenyElementuStruktury | `Soneta.Business.SubTable` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresKsiegowy | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresRozliczenKs | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresVAT | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PKD | `string` |  |  |  |
| Pododdzialy | `Soneta.Business.SubTable<Soneta.Core.OddzialFirmy>` |  |  |  |
| PododdzialyWgAktualnosci | `Soneta.Business.SubTable<Soneta.Core.OddzialFirmyRef>` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| PrzelewZlecAdres | `string` | bazodanowe |  |  |
| PrzelewZlecNazwa | `string` | bazodanowe |  |  |
| Root | `bool` |  |  |  |
| Slownikowy | `bool` | bazodanowe |  |  |
| StatusLicencji | `string` |  |  |  |
| SufiksNazwy | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` |  |  |  |
| WszystkiePododdzialy | `System.Collections.Generic.List<Soneta.Core.OddzialFirmy>` |  |  |  |
| WydzialyProdukcyjne | `Soneta.Business.SubTable` |  |  |  |

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

### AccessRights (`Soneta.Business.AccessRights`)
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
