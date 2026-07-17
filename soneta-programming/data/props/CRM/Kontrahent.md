# Pola i właściwości klasy biznesowej: `Soneta.CRM.Kontrahent`
Nazwa tabeli: `Kontrahenci`
Tytuł: Kontrahent
Opis: Główna kartoteka kontrahentów systemu CRM. Przechowuje pełne dane identyfikacyjne (NIP, REGON, PESEL, KRS), adresowe, handlowe (rabaty, limity kredytowe, waluty) oraz parametry rozliczeń, stanowiąc centralny punkt odniesienia dla dokumentów handlowych, kasowych i windykacyjnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPodmiot`, `IKontrahent`, `IPodmiotKasowy`, `IElementSlownika`, `IAdresHost`, `IKodowany`, `IAdresyWWWHost`, `IDaneKontaktoweHost`, `IEmailElement`, `IDBItemClient`, `IRegonHost`, `ITowaryUlubioneHost`, `IGIODOZgodnyHost`, `IGIODOWymianaDanychHost`, `IGIODOOświadczenieHost`

- pola bazodanowe: 75
- pola kalkulowane (z klas biznesowych): 93

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| AdresDoKorespondencji | `Soneta.Core.Adres` |  |  |  |
| AdresyWWW | `Soneta.Business.SubTable<Soneta.Core.AdresWWW>` |  |  |  |
| AktStatusVATData | `System.DateTime?` |  | Data aktualizacji statusu |  |
| AktStatusVATDataMF | `System.DateTime?` |  | Data aktualizacji statusu w bazie MF |  |
| AktStatusVATDataVIES | `System.DateTime?` |  | Data aktualizacji statusu w bazie VIES |  |
| AktualizacjaPrzyImporcie | `bool` | bazodanowe |  | Zezwala na aktualizację danych podczas importów |
| AktualnyStatusVAT | `Soneta.CRM.StatusNumeruVAT` | enum | Aktualny status VAT |  |
| AktualnyStatusVATMF | `Soneta.CRM.StatusNumeruVAT` | enum | Aktualny status VAT MF |  |
| AktualnyStatusVATVies | `Soneta.CRM.StatusNumeruVAT` | enum | Aktualny status VAT VIES |  |
| BaseEuVAT | `string` |  |  |  |
| BaseNIP | `string` |  |  |  |
| BasicDocuments | `Soneta.Business.SubTable` |  |  |  |
| BazaDanych | `Soneta.Core.DatabaseLookupItem` | bazodanowe |  | Baza danych podmiotu powiązanego |
| Blokada | `bool` | bazodanowe |  | Określa, czy dany kontrahent ma być widoczny na listach. |
| BlokadaSprzedazy | `bool` | bazodanowe |  | Blokada uniemożliwiająca wystawienie dokumentu o kierunku 'Rozchód'. |
| Branze | `Soneta.Business.SubTable<Soneta.CRM.BranzaKth>` |  |  |  |
| ButtonCaption | `string` |  |  |  |
| CenaOdbiorcy | `bool` | bazodanowe |  | Umożliwia stosowanie cen odbiorcy. |
| CenaTowaru | `Soneta.Business.Row` | bazodanowe |  | Indywidyalna cena wszystkich towarów do wykorzystania mechanizmach wyliczania ceny. |
| Ceny | `Soneta.Business.SubTable` |  |  |  |
| CenyGrupowe | `Soneta.Business.SubTable` |  |  |  |
| DBItems | `Soneta.Business.SubTable<Soneta.Business.Db.DBItem>` |  |  |  |
| DataZakonczeniaDzialalnosci | `Soneta.Types.Date` | bazodanowe |  |  |
| DefinicjaSprawyWindykacyjnej | `Soneta.Windykacja.DefinicjaSprawyWindykacyjnej` | bazodanowe |  | Domyślna definicja sprawy windykacyjnej |
| DeklaracjePodmiotu | `Soneta.Business.SubTable` |  |  |  |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Core.DokEwidencji>` |  |  |  |
| DokumentyHandlowe | `Soneta.Business.SubTable` |  |  |  |
| DokumentyHandloweOdbiorcy | `Soneta.Business.SubTable` |  |  |  |
| DokumentyPreliminarza | `Soneta.Business.SubTable<Soneta.Kasa.PreliminarzDokument>` |  |  |  |
| DokumentyRozliczeniowe | `Soneta.Business.SubTable<Soneta.Kasa.DokRozliczBase>` |  |  |  |
| DomyslnyRachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` |  |  |  |
| DomyslnySzablonPolOpcjonalnychKSeF | `Soneta.Core.KSeFSzablonPolOpcjonalnych` | bazodanowe |  | Domyślny szablon pól opcjonalnych KSeF |
| DomyślnyAdresWWW | `string` |  |  |  |
| DuplicateGroupCaption | `string` |  |  |  |
| DzialalnosciKontrahenta | `Soneta.Business.View` |  |  |  |
| DzialnoscPrzewazajacaKontrahenta | `Soneta.Business.View` |  |  |  |
| EFaktura | `Soneta.Core.EFaktura` | bazodanowe, enum | e-Faktura | Rodzaj e-faktury przypiasnej do kontrahenta. |
| EFakturaOkres | `Soneta.Types.FromTo` | bazodanowe | Okres zgody | Okres zgody na wysyłke e-dokumentów. |
| EMAIL | `string` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| FormaPrawna | `Soneta.CRM.FormaPrawna` | bazodanowe | Forma prawna | Forma prawna podmiotu |
| FormatDaty | `Soneta.Core.UpdateOcrDateFormat` | bazodanowe, enum |  | Format daty do stosowania dla algorytmu aktualizacji OCR |
| GIODOOświadczenia | `Soneta.Business.SubTable<Soneta.Core.GIODOOświadczenie>` |  |  |  |
| GIODOUdostępnienia | `Soneta.Business.SubTable<Soneta.Core.GIODOWymianaDanych>` |  |  |  |
| GrupaVAT | `Soneta.Core.IHistoriaGrupyVAT` |  | Grupa VAT |  |
| Identyfikacje | `Soneta.Business.SubTable<Soneta.Kasa.IdentyfikacjaPlatnika>` |  |  |  |
| IloscDniDlaRabatu | `int` | bazodanowe |  | Domyślna ilość dni dla rabatu. |
| IsAllowed | `bool` |  |  |  |
| JestIncydentalny | `bool` |  |  | Sprawdza, czy kontrahent jest systemowym kontrahentem incydentalnym. |
| KRS | `string` | bazodanowe |  |  |
| KSeFSposobObslugiWysylkiCeny | `Soneta.Core.SposobObslugiWysylkiCenyDoKSeF` | bazodanowe, enum | Wysyłanie ceny do KSeF | Sposób obsługi wysyłki ceny do KSeF. |
| Kategorie | `Soneta.Business.SubTable<Soneta.CRM.KategoriaKth>` |  |  |  |
| Kod | `string` | bazodanowe |  |  |
| KodKraju | `string` |  |  | Kod kraju kontrahenta wyliczony na podstawie NIP/EuVAT. |
| Kod_Kraju | `string` |  |  | Kod kraju kontrahenta pobierany z bazy. |
| KodyKreskowe | `Soneta.Business.SubTable<Soneta.Core.KodKreskowy>` |  |  |  |
| Komunikat | `string` | bazodanowe |  | Komunikat o kontrahencie. |
| KomunikatCRM | `string` | bazodanowe |  | Komunikat o kontrahencie. |
| KomunikatKS | `string` | bazodanowe |  | Komunikat o kontrahencie. |
| KomunikatyEDI | `Soneta.Business.SubTable` |  |  |  |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `Soneta.Business.SubTable<Soneta.Core.DaneKontaktowe>` |  |  |  |
| KontrahenciPodrzedni | `Soneta.Business.ListWithView` |  |  |  |
| KontrolaAktywna | `bool` |  |  |  |
| KontrolaDni | `int` | bazodanowe |  |  |
| KontrolaKwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| KorespondencjaNazwaFirmy | `string` | bazodanowe |  | Nazwa firmy, na którą kierowana jest korespondencja |
| KorespondencjaOpis | `Soneta.Business.MemoText` | bazodanowe |  | Opis dla adresu do korespondencji |
| Leady | `Soneta.Business.SubTable<Soneta.CRM.Lead>` |  |  |  |
| LimitKredytu | `Soneta.Types.Currency` | bazodanowe |  |  |
| LimitNieograniczony | `bool` |  |  |  |
| Lokalizacje | `Soneta.Business.SubTable<Soneta.CRM.Lokalizacja>` |  |  |  |
| MailTo | `string` |  |  |  |
| MatrycePodmiotu | `Soneta.Business.SubTable` |  |  |  |
| NIP | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` |  |  |  |
| NieWindykowac | `bool` | bazodanowe |  | Wyłącza nowe należności kontrahenta z procesu windykacji |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Odział firmy | Oddział firmy |
| OddzialInfo | `Soneta.CRM.KontrahentOddzialInfoSubTable` |  |  |  |
| OdsKarne | `Soneta.Kasa.OdsetkiKarne` | bazodanowe |  |  |
| OdsKarne.CzyNaliczacWyn | `bool` |  |  |  |
| OdsKarne.Indywidualne | `bool` | bazodanowe | Ustawienia domyślne | Odsetki karne naliczane będą wg ustawien globalnych w konfiguracji. |
| OdsKarne.OdsIndHist | `Soneta.Business.MemoText` | bazodanowe |  | Pole do przechowywania historii odsetek indywidualnych. |
| OdsKarne.OdsIndywidualne | `Soneta.Business.HistoryValuePercent` |  | Odsetki indywidualne |  |
| OdsKarne.OdsKwotHist | `Soneta.Business.MemoText` | bazodanowe |  | Pole do przechowywania historii kwot odsetek kwotowych. |
| OdsKarne.OdsKwotowe | `Soneta.Business.HistoryValueCurrency` |  | Odsetki indywidualne |  |
| OdsKarne.RozpoczecieDni | `int` | bazodanowe | Dni rozpoczęcia | Ilość dni od daty wystawienia dokumentu do rozpoczęcia naliczania odsetek w metodzie indywidualnej. |
| OdsKarne.RozpoczecieTyp | `Soneta.Kasa.OdsetkiRozpoczecie` | bazodanowe, enum | Typ rozpoczęcia | Determinująca sposób wyznaczenia początku naliczania odsetek. |
| OdsKarne.SposobLiczenia | `Soneta.Kasa.OdsetkiKwotoweSposobLiczenia` | bazodanowe, enum | Sposób liczenia | Sposób liczenia odsetek kwotowych. |
| OdsKarne.Stopa | `Soneta.Kasa.OdsetkiStopa` | bazodanowe, enum | Stopa odsetkowa | Stopa determinujaca wysokość naliczanych odsetek karnych. |
| OdsKarne.Zwloka | `int` | bazodanowe | Dopuszczalna zwłoka | Dopuszczalne przekroczenie terminu płatności, które nie powoduje naliczania odsetek. |
| OdsKarne.ZwlokaWyn | `int` |  |  |  |
| Opiekunowie | `Soneta.Business.SubTable<Soneta.CRM.Opiekun>` |  |  |  |
| Osoba | `Soneta.Core.Osoba` | bazodanowe |  |  |
| Osoba.Adres | `string` | bazodanowe |  |  |
| Osoba.Osoba | `string` | bazodanowe |  |  |
| Osoba.Telefon | `string` | bazodanowe |  |  |
| Osoby | `Soneta.Business.SubTable<Soneta.CRM.KontaktOsoba>` |  |  |  |
| OsobyKontaktowe | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent>` |  |  |  |
| OsobyZOsobyKontrahent | `Soneta.Business.View` |  |  |  |
| PESEL | `string` | bazodanowe | PESEL |  |
| Platnik | `Soneta.Kasa.IPodmiotKasowy` | iface-ref |  |  |
| Platnosci | `Soneta.Business.SubTable<Soneta.Kasa.Platnosc>` |  |  |  |
| PodatnikVAT | `bool` | bazodanowe |  |  |
| PodmiotNadrzedny | `Soneta.Core.IPodmiot` | iface-ref |  |  |
| PodmiotPowiazany | `bool` |  |  |  |
| PodmiotyZastąpione | `System.Collections.Generic.List<Soneta.CRM.Kontrahent>` |  |  |  |
| Podrzedni | `Soneta.Business.SubTable<Soneta.CRM.RelacjaPodmiotu>` |  |  |  |
| Pojazdy | `Soneta.Business.SubTable` |  |  |  |
| PotwierdzeniaGIODO | `Soneta.Business.SubTable<Soneta.Core.GIODOZgodny>` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| PozwalajNaZmianePlatnosciKaucji | `bool` | bazodanowe |  | Dozwolona zmiana rodzaju płatności na dokumencie kaucji z poziomu dokumentu sprzedaży. |
| Projekty | `Soneta.Business.SubTable` |  |  |  |
| PrzecenyKontrahenta | `Soneta.Business.View` |  |  |  |
| Przelewy | `Soneta.Business.SubTable<Soneta.Kasa.PrzelewBase>` |  |  |  |
| PrzeterminowanieNieograniczone | `bool` |  |  |  |
| REGON | `string` | bazodanowe | Regon | Rejestr Gospodarki Narodowej |
| Rabat | `Soneta.Types.Percent` | bazodanowe |  | Rabat przepisywany do dokumentu handlowego po wyborze kontrahenta na tym dokumencie. |
| RabatTowaru | `Soneta.Types.Percent` | bazodanowe |  | Indywidyalny rabat wszystkich towarów do wykorzystania mechanizmach rabatowania cen. |
| Rachunki | `Soneta.Business.SubTable<Soneta.Kasa.RachunekBankowyPodmiotu>` |  |  |  |
| RachunkiWirtualne | `Soneta.Business.SubTable<Soneta.Kasa.RachunekWirtualny>` |  |  |  |
| Region | `Soneta.CRM.Region` | bazodanowe |  |  |
| RodzajDokumentuKaucji | `Soneta.CRM.RodzajDokumentuKaucji` | bazodanowe, enum |  | Rodzaj dokumentu kaucji. |
| RodzajPlatnosciKaucji | `Soneta.CRM.RodzajPlatnosciKaucji` | bazodanowe, enum |  | Rodzaj płatności na dokumentach kaucji. |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` | bazodanowe, enum | Rodzaj VAT dla sprzedaży | Rodzaj VAT dla sprzedaży |
| RodzajPodmiotuZakup | `Soneta.Core.RodzajPodmiotu` | bazodanowe, enum | Rodzaj VAT dla zakupu | Rodzaj VAT dla zakupu |
| RodzajRabatuZaTerminPlatnosci | `Soneta.CRM.RodzajRabatuZaTerminPlatnosci` | bazodanowe, enum |  | Rodzaj rabatu za wcześniejszy termin płatności. |
| RodzajePodmiotu | `Soneta.Business.SubTable<Soneta.Core.RodzajPodmiot>` |  |  |  |
| Rozrachunki | `Soneta.Business.SubTable<Soneta.Kasa.RozrachunekIdx>` |  |  |  |
| Samofakturowanie | `Soneta.CRM.Samofakturowanie` | bazodanowe, enum | Samofakturowanie |  |
| SamofakturowanieOkres | `Soneta.Types.FromTo` | bazodanowe | Okres umowy |  |
| Segment | `string` |  |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  |  |
| Sprawy | `Soneta.Business.SubTable<Soneta.Windykacja.SprawaWindykacyjna>` |  |  |  |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` | bazodanowe, enum |  |  |
| StatusyVAT | `Soneta.Business.SubTable<Soneta.CRM.StatusVAT>` |  |  |  |
| Termin | `int` | bazodanowe |  |  |
| TerminPlanowany | `int` | bazodanowe |  | Ilość dni po terminie |
| TerminRozliczeniaKaucji | `int` | bazodanowe |  | Termin (ilość dni) rozliczenia dokumentu kaucji. |
| Towary | `Soneta.Business.SubTable` |  |  |  |
| TowaryUlubione | `Soneta.Business.SubTable` |  |  |  |
| Transakcje | `Soneta.Business.SubTable<Soneta.CRM.Transakcja>` |  |  |  |
| TransakcjeKontrahenta | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` |  |  |  |
| TrybRabatuZaTerminPlatnosci | `Soneta.CRM.TrybRabatuZaTerminPlatnosci` | bazodanowe, enum |  | Tryb działania rabatu za wcześniejszy termin płatności. |
| TypLimituKredytowego | `Soneta.CRM.TypLimituKredytowego` | bazodanowe, enum | Typ limitu kredytowego | Określa typ limitu kredytowego, kwota lub wartość nieograniczona. |
| TypPrzeterminowania | `Soneta.CRM.TypLimituKredytowego` | bazodanowe, enum | Typ przeterminowania limitu kredytowego | Określa typ przeterminowania limitu kredytowego, kwota lub wartość nieograniczona. |
| Urzadzenia | `Soneta.Business.SubTable` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| VATLiczonyOd | `Soneta.CRM.VatKontahentaLiczonyOd` | bazodanowe, enum |  |  |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  | Domyślna waluta kontrahenta. |
| WartoscRabatuZaKazdyDzien | `Soneta.Types.Percent` | bazodanowe |  | Wartość % rabatu za każdy dzień. |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| WyjatkiDlaPO | `Soneta.CRM.WyjątkiDlaPO` | bazodanowe, enum |  | Wyjątki dla przecen okresowych. |
| Zadania | `Soneta.Business.SubTable` |  |  |  |
| ZadaniaKontrahenta | `Soneta.Business.SubTable` |  |  |  |
| Zamiennik | `Soneta.CRM.Kontrahent` |  |  |  |
| Zaplaty | `Soneta.Business.SubTable<Soneta.Kasa.Zaplata>` |  |  |  |
| Zdarzenia | `Soneta.Business.SubTable<Soneta.CRM.DokumentZdarzenia>` |  |  |  |
| ZgodnoscGIODOPotwierdzona | `bool` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Platnik | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| PodmiotNadrzedny | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajDokumentuKaucji (`Soneta.CRM.RodzajDokumentuKaucji`)
- `Docelowy` = 0
- `DocelowyWew` = 1 — Docelowy wew.

### RodzajPlatnosciKaucji (`Soneta.CRM.RodzajPlatnosciKaucji`)
- `Naliczaj` = 0 — Naliczaj dla wszystkich
- `NieNaliczaj` = 1 — Nie naliczaj dla wszystkich
- `NaliczajDlaOpakowan` = 2 — Naliczaj dla opakowań
- `NaliczajDlaSystemuKaucyjnego` = 3 — Naliczaj dla systemu kaucyjnego

### RodzajRabatuZaTerminPlatnosci (`Soneta.CRM.RodzajRabatuZaTerminPlatnosci`)
- `Brak` = 0
- `Dokument` = 1 — Udzielany na dokumencie
- `Wydruk` = 2 — Prezentowany na wydruku (skonto)

### Samofakturowanie (`Soneta.CRM.Samofakturowanie`)
- `Brak` = 0
- `Sprzedawca` = 1
- `Nabywca` = 2

### StatusNumeruVAT (`Soneta.CRM.StatusNumeruVAT`)
- `Brak` = 0 — Brak informacji
- `AktywnyVIES` = 1 — Aktywny w bazie VIES
- `NieaktywnyVIES` = 2 — Nieaktywny w bazie VIES
- `CzynnyMF` = 3 — Czynny (MF)
- `NiezarejestrowanyMF` = 4 — Niezarejestrowany (MF)
- `ZwolnionyMF` = 5 — Zwolniony (MF)
- `BrakMF` = 6 — Brak w wykazie (MF)
- `Weryfikacja` = 7 — Wymaga weryfikacji

### TrybRabatuZaTerminPlatnosci (`Soneta.CRM.TrybRabatuZaTerminPlatnosci`)
- `Brak` = 0
- `Podstawowy` = 1
- `Progresywny` = 2
- `Progowy` = 3

### TypLimituKredytowego (`Soneta.CRM.TypLimituKredytowego`)
- `Kwota` = 0 — Kwota
- `Nieograniczony` = 1

### VatKontahentaLiczonyOd (`Soneta.CRM.VatKontahentaLiczonyOd`)
- `OdNetto` = 1
- `OdBrutto` = 2

### WyjątkiDlaPO (`Soneta.CRM.WyjątkiDlaPO`)
- `Brak` = 0 — Brak
- `WszystkieTowary` = 1
- `TowaryZCenamiIndywidualnymi` = 2

### EFaktura (`Soneta.Core.EFaktura`)
- `Brak` = 0
- `Invooclip` = 1 — invooclip
- `GreenMail24` = 2 — GreenMail24
- `Email` = 3 — e-mail

### RodzajPodmiotu (`Soneta.Core.RodzajPodmiotu`)
- `Krajowy` = 0
- `Eksportowy` = 1
- `EksportowyPodróżny` = 2
- `Unijny` = 3
- `UnijnyTrójstronny` = 4
- `BezVAT` = 5 — Bez VAT

### SposobObslugiWysylkiCenyDoKSeF (`Soneta.Core.SposobObslugiWysylkiCenyDoKSeF`)
- `CenaPoRabacie` = 0
- `CenaIRabat` = 1

### StatusPodmiotu (`Soneta.Core.StatusPodmiotu`)
- `PodmiotGospodarczy` = 0
- `Finalny` = 1

### UpdateOcrDateFormat (`Soneta.Core.UpdateOcrDateFormat`)
- `None` = 0 — Brak
- `DDMMYYYY` = 1 — DD-MM-YYYY
- `MMDDYYYY` = 2 — MM-DD-YYYY
- `YYYYMMDD` = 3 — YYYY-MM-DD

### OdsetkiKwotoweSposobLiczenia (`Soneta.Kasa.OdsetkiKwotoweSposobLiczenia`)
- `ZaOkresPrzeterminowania` = 0 — Za okres przeterminowania
- `Dzienny` = 10 — Dzienny

### OdsetkiRozpoczecie (`Soneta.Kasa.OdsetkiRozpoczecie`)
- `NieNaliczaj` = 0 — Nie naliczaj
- `NieStandardowe` = 1 — Niestandardowe
- `WgTerminuPlatnosci` = 2 — Wg terminu płatności
- `Standardowe` = 3 — Standardowe

### OdsetkiStopa (`Soneta.Kasa.OdsetkiStopa`)
- `Ustawowe` = 0 — Ustawowe
- `Indywidualne` = 1 — Indywidualne
- `Maksymalne` = 2 — Maksymalne
- `UstawoweIndywidualne` = 3 — Ustawowe + Indywidualne
- `UstawowePodatkowe` = 4 — Ustawowe + Podatkowe
- `Wskazane` = 5 — Wskazane
- `Handlowe` = 6 — Handlowe
- `UstawoweHandlowe` = 7 — Ustawowe + Handlowe
- `ZaOpoznienie` = 8 — Za opóźnienie
- `Podatkowe` = 9 — Podatkowe
- `HandloweMedyczne` = 10 — Handlowe medyczne
- `UstawoweHandloweMedyczne` = 11 — Ustawowe + Handlowe medyczne
