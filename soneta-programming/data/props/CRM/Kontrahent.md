# Pola i właściwości klasy biznesowej: `Soneta.CRM.Kontrahent`
Nazwa tabeli: `Kontrahenci`
Tytuł: Kontrahent
Opis: Główna kartoteka kontrahentów systemu CRM. Przechowuje pełne dane identyfikacyjne (NIP, REGON, PESEL, KRS), adresowe, handlowe (rabaty, limity kredytowe, waluty) oraz parametry rozliczeń, stanowiąc centralny punkt odniesienia dla dokumentów handlowych, kasowych i windykacyjnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPodmiot`, `IKontrahent`, `IPodmiotKasowy`, `IElementSlownika`, `IAdresHost`, `IKodowany`, `IAdresyWWWHost`, `IDaneKontaktoweHost`, `IEmailElement`, `IDBItemClient`, `IRegonHost`, `ITowaryUlubioneHost`, `IGIODOZgodnyHost`, `IGIODOWymianaDanychHost`, `IGIODOOświadczenieHost`

- pola bazodanowe (zapisywalne): 66
- pola kalkulowane (zapisywalne): 5
- pola tylko-odczyt: 32
- podlisty: 62
- subrowy: 3
- razem: 168

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresDoKorespondencji | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresyWWW | `SubTable<Soneta.Core.AdresWWW>` | podlista |  |  |
| AktStatusVATData | `System.DateTime?` | tylko-odczyt | Data aktualizacji statusu |  |
| AktStatusVATDataMF | `System.DateTime?` | tylko-odczyt | Data aktualizacji statusu w bazie MF |  |
| AktStatusVATDataVIES | `System.DateTime?` | tylko-odczyt | Data aktualizacji statusu w bazie VIES |  |
| AktualizacjaPrzyImporcie | `bool` | bazodanowe |  | Zezwala na aktualizację danych podczas importów |
| AktualnyStatusVAT | `Soneta.CRM.StatusNumeruVAT` (enum) | tylko-odczyt | Aktualny status VAT |  |
| AktualnyStatusVATMF | `Soneta.CRM.StatusNumeruVAT` (enum) | tylko-odczyt | Aktualny status VAT MF |  |
| AktualnyStatusVATVies | `Soneta.CRM.StatusNumeruVAT` (enum) | tylko-odczyt | Aktualny status VAT VIES |  |
| BaseEuVAT | `string` | tylko-odczyt |  |  |
| BaseNIP | `string` | tylko-odczyt |  |  |
| BasicDocuments | `SubTable` | podlista |  |  |
| BazaDanych | `Soneta.Core.DatabaseLookupItem` | bazodanowe |  | Baza danych podmiotu powiązanego |
| Blokada | `bool` | bazodanowe |  | Określa, czy dany kontrahent ma być widoczny na listach. |
| BlokadaSprzedazy | `bool` | bazodanowe |  | Blokada uniemożliwiająca wystawienie dokumentu o kierunku 'Rozchód'. |
| Branze | `SubTable<Soneta.CRM.BranzaKth>` | podlista |  |  |
| ButtonCaption | `string` | tylko-odczyt |  |  |
| CenaOdbiorcy | `bool` | bazodanowe |  | Umożliwia stosowanie cen odbiorcy. |
| CenaTowaru | `Row` | bazodanowe |  | Indywidyalna cena wszystkich towarów do wykorzystania mechanizmach wyliczania ceny. |
| Ceny | `SubTable` | podlista |  |  |
| CenyGrupowe | `SubTable` | podlista |  |  |
| DBItems | `SubTable<Db.DBItem>` | podlista |  |  |
| DataZakonczeniaDzialalnosci | `Date` | bazodanowe |  |  |
| DefinicjaSprawyWindykacyjnej | `Soneta.Windykacja.DefinicjaSprawyWindykacyjnej` | bazodanowe |  | Domyślna definicja sprawy windykacyjnej |
| DeklaracjePodmiotu | `SubTable` | podlista |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| DokumentyHandlowe | `SubTable` | podlista |  |  |
| DokumentyHandloweOdbiorcy | `SubTable` | podlista |  |  |
| DokumentyPreliminarza | `SubTable<Soneta.Kasa.PreliminarzDokument>` | podlista |  |  |
| DokumentyRozliczeniowe | `SubTable<Soneta.Kasa.DokRozliczBase>` | podlista |  |  |
| DomyslnyRachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` | tylko-odczyt |  |  |
| DomyslnySzablonPolOpcjonalnychKSeF | `Soneta.Core.KSeFSzablonPolOpcjonalnych` | bazodanowe |  | Domyślny szablon pól opcjonalnych KSeF |
| DomyślnyAdresWWW | `string` | tylko-odczyt |  |  |
| DuplicateGroupCaption | `string` | tylko-odczyt |  |  |
| DzialalnosciKontrahenta | `View` | podlista |  |  |
| DzialnoscPrzewazajacaKontrahenta | `View` | podlista |  |  |
| EFaktura | `Soneta.Core.EFaktura` (enum) | bazodanowe | e-Faktura | Rodzaj e-faktury przypiasnej do kontrahenta. |
| EFakturaOkres | `FromTo` | bazodanowe, podlista | Okres zgody | Okres zgody na wysyłke e-dokumentów. |
| EMAIL | `string` |  |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| FormaPrawna | `Soneta.CRM.FormaPrawna` | bazodanowe | Forma prawna | Forma prawna podmiotu |
| FormatDaty | `Soneta.Core.UpdateOcrDateFormat` (enum) | bazodanowe |  | Format daty do stosowania dla algorytmu aktualizacji OCR |
| GIODOOświadczenia | `SubTable<Soneta.Core.GIODOOświadczenie>` | podlista |  |  |
| GIODOUdostępnienia | `SubTable<Soneta.Core.GIODOWymianaDanych>` | podlista |  |  |
| GrupaVAT | `Soneta.Core.IHistoriaGrupyVAT` | tylko-odczyt | Grupa VAT |  |
| Identyfikacje | `SubTable<Soneta.Kasa.IdentyfikacjaPlatnika>` | podlista |  |  |
| IloscDniDlaRabatu | `int` | bazodanowe |  | Domyślna ilość dni dla rabatu. |
| IsAllowed | `bool` | tylko-odczyt |  |  |
| JestIncydentalny | `bool` | tylko-odczyt |  | Sprawdza, czy kontrahent jest systemowym kontrahentem incydentalnym. |
| KRS | `string` | bazodanowe |  |  |
| KSeFSposobObslugiWysylkiCeny | `Soneta.Core.SposobObslugiWysylkiCenyDoKSeF` (enum) | bazodanowe | Wysyłanie ceny do KSeF | Sposób obsługi wysyłki ceny do KSeF. |
| Kategorie | `SubTable<Soneta.CRM.KategoriaKth>` | podlista |  |  |
| Kod | `string` | bazodanowe |  |  |
| KodKraju | `string` | tylko-odczyt |  | Kod kraju kontrahenta wyliczony na podstawie NIP/EuVAT. |
| Kod_Kraju | `string` | tylko-odczyt |  | Kod kraju kontrahenta pobierany z bazy. |
| KodyKreskowe | `SubTable<Soneta.Core.KodKreskowy>` | podlista |  |  |
| Komunikat | `string` | bazodanowe |  | Komunikat o kontrahencie. |
| KomunikatCRM | `string` | bazodanowe |  | Komunikat o kontrahencie. |
| KomunikatKS | `string` | bazodanowe |  | Komunikat o kontrahencie. |
| KomunikatyEDI | `SubTable` | podlista |  |  |
| Kontakt | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `SubTable<Soneta.Core.DaneKontaktowe>` | podlista |  |  |
| KontrahenciPodrzedni | `ListWithView` | podlista |  |  |
| KontrolaAktywna | `bool` | tylko-odczyt |  |  |
| KontrolaDni | `int` | bazodanowe |  |  |
| KontrolaKwota | `Currency` | bazodanowe |  |  |
| KorespondencjaNazwaFirmy | `string` | bazodanowe |  | Nazwa firmy, na którą kierowana jest korespondencja |
| KorespondencjaOpis | `MemoText` | bazodanowe, podlista |  | Opis dla adresu do korespondencji |
| Leady | `SubTable<Soneta.CRM.Lead>` | podlista |  |  |
| LimitKredytu | `Currency` | bazodanowe |  |  |
| LimitNieograniczony | `bool` | tylko-odczyt |  |  |
| Lokalizacje | `SubTable<Soneta.CRM.Lokalizacja>` | podlista |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| MatrycePodmiotu | `SubTable` | podlista |  |  |
| NIP | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
| NieWindykowac | `bool` | bazodanowe |  | Wyłącza nowe należności kontrahenta z procesu windykacji |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Odział firmy | Oddział firmy |
| OddzialInfo | `Soneta.CRM.KontrahentOddzialInfoSubTable` | podlista |  |  |
| OdsKarne | `Soneta.Kasa.OdsetkiKarne` (subrow) | bazodanowe |  |  |
| OdsKarne.CzyNaliczacWyn | `bool` | tylko-odczyt |  |  |
| OdsKarne.Indywidualne | `bool` | bazodanowe | Ustawienia domyślne | Odsetki karne naliczane będą wg ustawien globalnych w konfiguracji. |
| OdsKarne.OdsIndHist | `MemoText` | bazodanowe, podlista |  | Pole do przechowywania historii odsetek indywidualnych. |
| OdsKarne.OdsIndywidualne | `HistoryValuePercent` | tylko-odczyt | Odsetki indywidualne |  |
| OdsKarne.OdsKwotHist | `MemoText` | bazodanowe, podlista |  | Pole do przechowywania historii kwot odsetek kwotowych. |
| OdsKarne.OdsKwotowe | `HistoryValueCurrency` | tylko-odczyt | Odsetki indywidualne |  |
| OdsKarne.RozpoczecieDni | `int` | bazodanowe | Dni rozpoczęcia | Ilość dni od daty wystawienia dokumentu do rozpoczęcia naliczania odsetek w metodzie indywidualnej. |
| OdsKarne.RozpoczecieTyp | `Soneta.Kasa.OdsetkiRozpoczecie` (enum) | bazodanowe | Typ rozpoczęcia | Determinująca sposób wyznaczenia początku naliczania odsetek. |
| OdsKarne.SposobLiczenia | `Soneta.Kasa.OdsetkiKwotoweSposobLiczenia` (enum) | bazodanowe | Sposób liczenia | Sposób liczenia odsetek kwotowych. |
| OdsKarne.Stopa | `Soneta.Kasa.OdsetkiStopa` (enum) | bazodanowe | Stopa odsetkowa | Stopa determinujaca wysokość naliczanych odsetek karnych. |
| OdsKarne.Zwloka | `int` | bazodanowe | Dopuszczalna zwłoka | Dopuszczalne przekroczenie terminu płatności, które nie powoduje naliczania odsetek. |
| OdsKarne.ZwlokaWyn | `int` | tylko-odczyt |  |  |
| Opiekunowie | `SubTable<Soneta.CRM.Opiekun>` | podlista |  |  |
| Osoba | `Soneta.Core.Osoba` (subrow) | bazodanowe |  |  |
| Osoba.Adres | `string` | bazodanowe |  |  |
| Osoba.Osoba | `string` | bazodanowe |  |  |
| Osoba.Telefon | `string` | bazodanowe |  |  |
| Osoby | `SubTable<Soneta.CRM.KontaktOsoba>` | podlista |  |  |
| OsobyKontaktowe | `SubTable<Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent>` | podlista |  |  |
| OsobyZOsobyKontrahent | `View` | podlista |  |  |
| PESEL | `string` | bazodanowe | PESEL |  |
| Platnik | `Soneta.Kasa.IPodmiotKasowy` | tylko-odczyt, iface-ref |  |  |
| Platnosci | `SubTable<Soneta.Kasa.Platnosc>` | podlista |  |  |
| PodatnikVAT | `bool` | bazodanowe |  |  |
| PodmiotNadrzedny | `Soneta.Core.IPodmiot` | tylko-odczyt, iface-ref |  |  |
| PodmiotPowiazany | `bool` | tylko-odczyt |  |  |
| PodmiotyZastąpione | `System.Collections.Generic.List<Soneta.CRM.Kontrahent>` | podlista |  |  |
| Podrzedni | `SubTable<Soneta.CRM.RelacjaPodmiotu>` | podlista |  |  |
| Pojazdy | `SubTable` | podlista |  |  |
| PotwierdzeniaGIODO | `SubTable<Soneta.Core.GIODOZgodny>` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| PozwalajNaZmianePlatnosciKaucji | `bool` | bazodanowe |  | Dozwolona zmiana rodzaju płatności na dokumencie kaucji z poziomu dokumentu sprzedaży. |
| Projekty | `SubTable` | podlista |  |  |
| PrzecenyKontrahenta | `View` | podlista |  |  |
| Przelewy | `SubTable<Soneta.Kasa.PrzelewBase>` | podlista |  |  |
| PrzeterminowanieNieograniczone | `bool` | tylko-odczyt |  |  |
| REGON | `string` | bazodanowe | Regon | Rejestr Gospodarki Narodowej |
| Rabat | `Percent` | bazodanowe |  | Rabat przepisywany do dokumentu handlowego po wyborze kontrahenta na tym dokumencie. |
| RabatTowaru | `Percent` | bazodanowe |  | Indywidyalny rabat wszystkich towarów do wykorzystania mechanizmach rabatowania cen. |
| Rachunki | `SubTable<Soneta.Kasa.RachunekBankowyPodmiotu>` | podlista |  |  |
| RachunkiWirtualne | `SubTable<Soneta.Kasa.RachunekWirtualny>` | podlista |  |  |
| Region | `Soneta.CRM.Region` | bazodanowe |  |  |
| RodzajDokumentuKaucji | `Soneta.CRM.RodzajDokumentuKaucji` (enum) | bazodanowe |  | Rodzaj dokumentu kaucji. |
| RodzajPlatnosciKaucji | `Soneta.CRM.RodzajPlatnosciKaucji` (enum) | bazodanowe |  | Rodzaj płatności na dokumentach kaucji. |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` (enum) | bazodanowe | Rodzaj VAT dla sprzedaży | Rodzaj VAT dla sprzedaży |
| RodzajPodmiotuZakup | `Soneta.Core.RodzajPodmiotu` (enum) | bazodanowe | Rodzaj VAT dla zakupu | Rodzaj VAT dla zakupu |
| RodzajRabatuZaTerminPlatnosci | `Soneta.CRM.RodzajRabatuZaTerminPlatnosci` (enum) | bazodanowe |  | Rodzaj rabatu za wcześniejszy termin płatności. |
| RodzajePodmiotu | `SubTable<Soneta.Core.RodzajPodmiot>` | podlista |  |  |
| Rozrachunki | `SubTable<Soneta.Kasa.RozrachunekIdx>` | podlista |  |  |
| Samofakturowanie | `Soneta.CRM.Samofakturowanie` (enum) | bazodanowe | Samofakturowanie |  |
| SamofakturowanieOkres | `FromTo` | bazodanowe, podlista | Okres umowy |  |
| Segment | `string` | tylko-odczyt |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  |  |
| Sprawy | `SubTable<Soneta.Windykacja.SprawaWindykacyjna>` | podlista |  |  |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` (enum) | bazodanowe |  |  |
| StatusyVAT | `SubTable<Soneta.CRM.StatusVAT>` | podlista |  |  |
| Termin | `int` | bazodanowe |  |  |
| TerminPlanowany | `int` | bazodanowe |  | Ilość dni po terminie |
| TerminRozliczeniaKaucji | `int` | bazodanowe |  | Termin (ilość dni) rozliczenia dokumentu kaucji. |
| Towary | `SubTable` | podlista |  |  |
| TowaryUlubione | `SubTable` | podlista |  |  |
| Transakcje | `SubTable<Soneta.CRM.Transakcja>` | podlista |  |  |
| TransakcjeKontrahenta | `SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` | podlista |  |  |
| TrybRabatuZaTerminPlatnosci | `Soneta.CRM.TrybRabatuZaTerminPlatnosci` (enum) | bazodanowe |  | Tryb działania rabatu za wcześniejszy termin płatności. |
| TypLimituKredytowego | `Soneta.CRM.TypLimituKredytowego` (enum) | bazodanowe | Typ limitu kredytowego | Określa typ limitu kredytowego, kwota lub wartość nieograniczona. |
| TypPrzeterminowania | `Soneta.CRM.TypLimituKredytowego` (enum) | bazodanowe | Typ przeterminowania limitu kredytowego | Określa typ przeterminowania limitu kredytowego, kwota lub wartość nieograniczona. |
| Urzadzenia | `SubTable` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| VATLiczonyOd | `Soneta.CRM.VatKontahentaLiczonyOd` (enum) | bazodanowe |  |  |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  | Domyślna waluta kontrahenta. |
| WartoscRabatuZaKazdyDzien | `Percent` | bazodanowe |  | Wartość % rabatu za każdy dzień. |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| WyjatkiDlaPO | `Soneta.CRM.WyjątkiDlaPO` (enum) | bazodanowe |  | Wyjątki dla przecen okresowych. |
| Zadania | `SubTable` | podlista |  |  |
| ZadaniaKontrahenta | `SubTable` | podlista |  |  |
| Zamiennik | `Soneta.CRM.Kontrahent` |  |  |  |
| Zaplaty | `SubTable<Soneta.Kasa.Zaplata>` | podlista |  |  |
| Zdarzenia | `SubTable<Soneta.CRM.DokumentZdarzenia>` | podlista |  |  |
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
