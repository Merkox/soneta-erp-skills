# Pola i właściwości klasy biznesowej: `Soneta.CRM.UrzadCelny`
Nazwa tabeli: `UrzedyCelne`
Tytuł: Urzędy celne
Opis: Słownik urzędów celnych wykorzystywanych w obrocie zagranicznym. Przechowuje dane identyfikacyjne, adresowe i handlowe urzędów celnych, w tym kod izby celnej, umożliwiając obsługę formalności celnych i rozliczeń.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPodmiot`, `IKontrahent`, `IPodmiotKasowy`, `IAdresHost`, `IElementSlownika`, `IAdresyWWWHost`, `IDaneKontaktoweHost`, `IEmailElement`

- pola bazodanowe (zapisywalne): 23
- pola kalkulowane (zapisywalne): 4
- pola tylko-odczyt: 26
- podlisty: 37
- subrowy: 3
- razem: 93

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AKC | `Soneta.Kasa.NumerRachunku` | tylko-odczyt |  |  |
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresyWWW | `SubTable<Soneta.Core.AdresWWW>` | podlista |  |  |
| AktualizacjaPrzyImporcie | `bool` | tylko-odczyt |  |  |
| BaseEuVAT | `string` | tylko-odczyt |  |  |
| BaseNIP | `string` | tylko-odczyt |  |  |
| BasicDocuments | `SubTable` | podlista |  |  |
| Blokada | `bool` | bazodanowe |  | Określa, czy dany urząd ma być widoczny na listach. |
| BlokadaSprzedaży | `bool` | tylko-odczyt |  |  |
| DeklaracjePodmiotu | `SubTable` | podlista |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| DokumentyPreliminarza | `SubTable<Soneta.Kasa.PreliminarzDokument>` | podlista |  |  |
| DokumentyRozliczeniowe | `SubTable<Soneta.Kasa.DokRozliczBase>` | podlista |  |  |
| DomyslnyRachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` | tylko-odczyt |  |  |
| DomyślnyAdresWWW | `string` | tylko-odczyt |  |  |
| EFaktura | `Soneta.Core.EFaktura` (enum) | tylko-odczyt |  |  |
| EMAIL | `string` |  |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| Identyfikacje | `SubTable<Soneta.Kasa.IdentyfikacjaPlatnika>` | podlista |  |  |
| IzbaCelna | `Soneta.CRM.KodyIzbCelnych` (enum) |  |  |  |
| Kod | `string` | bazodanowe |  |  |
| KodIzbyCelnej | `string` | bazodanowe |  |  |
| Kontakt | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `SubTable<Soneta.Core.DaneKontaktowe>` | podlista |  |  |
| KontrolaDni | `int` | tylko-odczyt |  |  |
| KontrolaKwota | `Currency` | tylko-odczyt |  |  |
| Leady | `SubTable<Soneta.CRM.Lead>` | podlista |  |  |
| LimitKredytu | `Currency` | bazodanowe |  |  |
| LimitNieograniczony | `bool` | tylko-odczyt |  |  |
| Lokalizacje | `SubTable<Soneta.CRM.Lokalizacja>` | podlista |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| MatrycePodmiotu | `SubTable` | podlista |  |  |
| NIP | `string` | bazodanowe |  |  |
| Nadrzedny | `Soneta.Core.IPodmiotInternal` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
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
| Osoba | `Soneta.Core.Osoba` (subrow) | bazodanowe |  |  |
| Osoba.Adres | `string` | bazodanowe |  |  |
| Osoba.Osoba | `string` | bazodanowe |  |  |
| Osoba.Telefon | `string` | bazodanowe |  |  |
| Osoby | `SubTable<Soneta.CRM.KontaktOsoba>` | podlista |  |  |
| OsobyKontaktowe | `SubTable<Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent>` | podlista |  |  |
| OsobyZOsobyKontrahent | `View` | podlista |  |  |
| Platnik | `Soneta.Kasa.IPodmiotKasowy` | tylko-odczyt, iface-ref |  |  |
| Platnosci | `SubTable<Soneta.Kasa.Platnosc>` | podlista |  |  |
| PodmiotPowiazany | `bool` | tylko-odczyt |  |  |
| Podrzedni | `SubTable<Soneta.CRM.RelacjaPodmiotu>` | podlista |  |  |
| Pojazdy | `SubTable` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Projekty | `SubTable` | podlista |  |  |
| Przelewy | `SubTable<Soneta.Kasa.PrzelewBase>` | podlista |  |  |
| PrzeterminowanieNieograniczone | `bool` | tylko-odczyt |  |  |
| Rabat | `Percent` | bazodanowe |  |  |
| Rachunki | `SubTable<Soneta.Kasa.RachunekBankowyPodmiotu>` | podlista |  |  |
| RachunkiWirtualne | `SubTable<Soneta.Kasa.RachunekWirtualny>` | podlista |  |  |
| RodzajePodmiotu | `SubTable<Soneta.Core.RodzajPodmiot>` | podlista |  |  |
| Rozrachunki | `SubTable<Soneta.Kasa.RozrachunekIdx>` | podlista |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  |  |
| Sprawy | `SubTable<Soneta.Windykacja.SprawaWindykacyjna>` | podlista |  |  |
| Termin | `int` | bazodanowe |  |  |
| TerminPlanowany | `int` | tylko-odczyt |  |  |
| Transakcje | `SubTable<Soneta.CRM.Transakcja>` | podlista |  |  |
| TransakcjeKontrahenta | `SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` | podlista |  |  |
| TypLimituKredytowego | `Soneta.CRM.TypLimituKredytowego` (enum) | tylko-odczyt |  |  |
| TypPrzeterminowania | `Soneta.CRM.TypLimituKredytowego` (enum) | tylko-odczyt |  |  |
| Urzadzenia | `SubTable` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| Waluta | `Soneta.Waluty.Waluta` | tylko-odczyt |  |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Zadania | `SubTable` | podlista |  |  |
| ZadaniaKontrahenta | `SubTable` | podlista |  |  |
| Zaplaty | `SubTable<Soneta.Kasa.Zaplata>` | podlista |  |  |
| Zdarzenia | `SubTable<Soneta.CRM.DokumentZdarzenia>` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Platnik | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KodyIzbCelnych (`Soneta.CRM.KodyIzbCelnych`)
- `BiałaPodlaska` = 300000 — Izba Celna w Białej Podlaskiej
- `Białystok` = 310000 — Izba Celna w Białymstoku
- `Gdyna` = 320000 — Izba Celna w Gdyni
- `Katowice` = 330000 — Izba Celna w Katowicach
- `Kielca` = 340000 — Izba Celna w Kielcach
- `Kraków` = 350000 — Izba Celna w Krakowie
- `Łódź` = 360000 — Izba Celna w Łodzi
- `Olsztyn` = 370000 — Izba Celna w Olsztynie
- `Opole` = 380000 — Izba Celna w Opolu
- `Poznań` = 390000 — Izba Celna w Poznaniu
- `Przemyśl` = 400000 — Izba Celna w Przemyślu
- `Rzepin` = 410000 — Izba Celna w Rzepinie
- `Szczecin` = 420000 — Izba Celna w Szczecinie
- `Toruń` = 430000 — Izba Celna w Toruniu
- `Warszawa` = 440000 — Izba Celna w Warszawie
- `Wrocław` = 450000 — Izba Celna we Wrocławiu

### TypLimituKredytowego (`Soneta.CRM.TypLimituKredytowego`)
- `Kwota` = 0 — Kwota
- `Nieograniczony` = 1

### EFaktura (`Soneta.Core.EFaktura`)
- `Brak` = 0
- `Invooclip` = 1 — invooclip
- `GreenMail24` = 2 — GreenMail24
- `Email` = 3 — e-mail

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
