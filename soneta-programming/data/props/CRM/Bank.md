# Pola i właściwości klasy biznesowej: `Soneta.CRM.Bank`
Nazwa tabeli: `Banki`
Tytuł: Banki
Opis: Słownik banków wykorzystywanych w systemie. Przechowuje dane identyfikacyjne, adresowe i rozliczeniowe banków, umożliwiając ich wybór jako podmiotów na dokumentach kasowych, przelewach oraz rachunkach bankowych kontrahentów.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPodmiot`, `IKontrahent`, `IPodmiotKasowy`, `IElementSlownika`, `IAdresHost`, `IAdresyWWWHost`, `IDaneKontaktoweHost`, `IEmailElement`

- pola bazodanowe: 30
- pola kalkulowane (z klas biznesowych): 63

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| AdresyWWW | `Soneta.Business.SubTable<Soneta.Core.AdresWWW>` |  |  |  |
| AktualizacjaPrzyImporcie | `bool` |  |  |  |
| BaseEuVAT | `string` |  |  |  |
| BaseNIP | `string` |  |  |  |
| BasicDocuments | `Soneta.Business.SubTable` |  |  |  |
| Blokada | `bool` | bazodanowe |  | Określa, czy dany bank ma być widoczny na listach. |
| BlokadaSprzedaży | `bool` |  |  |  |
| DeklaracjePodmiotu | `Soneta.Business.SubTable` |  |  |  |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Core.DokEwidencji>` |  |  |  |
| DokumentyPreliminarza | `Soneta.Business.SubTable<Soneta.Kasa.PreliminarzDokument>` |  |  |  |
| DokumentyRozliczeniowe | `Soneta.Business.SubTable<Soneta.Kasa.DokRozliczBase>` |  |  |  |
| DomyslnyRachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` |  |  |  |
| DomyślnyAdresWWW | `string` |  |  |  |
| EFaktura | `Soneta.Core.EFaktura` | enum |  |  |
| EMAIL | `string` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| Identyfikacje | `Soneta.Business.SubTable<Soneta.Kasa.IdentyfikacjaPlatnika>` |  |  |  |
| Kierunek | `string` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `Soneta.Business.SubTable<Soneta.Core.DaneKontaktowe>` |  |  |  |
| KontrolaDni | `int` |  |  |  |
| KontrolaKwota | `Soneta.Types.Currency` |  |  |  |
| Leady | `Soneta.Business.SubTable<Soneta.CRM.Lead>` |  |  |  |
| LimitKredytu | `Soneta.Types.Currency` | bazodanowe |  |  |
| LimitNieograniczony | `bool` |  |  |  |
| Lokalizacje | `Soneta.Business.SubTable<Soneta.CRM.Lokalizacja>` |  |  |  |
| MailTo | `string` |  |  |  |
| MatrycePodmiotu | `Soneta.Business.SubTable` |  |  |  |
| NIP | `string` | bazodanowe |  |  |
| Nadrzedny | `Soneta.Core.IPodmiotInternal` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` |  |  |  |
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
| Osoba | `Soneta.Core.Osoba` | bazodanowe |  |  |
| Osoba.Adres | `string` | bazodanowe |  |  |
| Osoba.Osoba | `string` | bazodanowe |  |  |
| Osoba.Telefon | `string` | bazodanowe |  |  |
| Osoby | `Soneta.Business.SubTable<Soneta.CRM.KontaktOsoba>` |  |  |  |
| OsobyKontaktowe | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent>` |  |  |  |
| OsobyZOsobyKontrahent | `Soneta.Business.View` |  |  |  |
| Platnik | `Soneta.Kasa.IPodmiotKasowy` | iface-ref |  |  |
| Platnosci | `Soneta.Business.SubTable<Soneta.Kasa.Platnosc>` |  |  |  |
| PodmiotPowiazany | `bool` |  |  |  |
| Podrzedni | `Soneta.Business.SubTable<Soneta.CRM.RelacjaPodmiotu>` |  |  |  |
| Pojazdy | `Soneta.Business.SubTable` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| Projekty | `Soneta.Business.SubTable` |  |  |  |
| Przelewy | `Soneta.Business.SubTable<Soneta.Kasa.PrzelewBase>` |  |  |  |
| PrzeterminowanieNieograniczone | `bool` |  |  |  |
| Rabat | `Soneta.Types.Percent` | bazodanowe |  |  |
| Rachunki | `Soneta.Business.SubTable<Soneta.Kasa.RachunekBankowyPodmiotu>` |  |  |  |
| RachunkiWirtualne | `Soneta.Business.SubTable<Soneta.Kasa.RachunekWirtualny>` |  |  |  |
| RodzajePodmiotu | `Soneta.Business.SubTable<Soneta.Core.RodzajPodmiot>` |  |  |  |
| Rozrachunki | `Soneta.Business.SubTable<Soneta.Kasa.RozrachunekIdx>` |  |  |  |
| SWIFT | `string` | bazodanowe |  |  |
| Segment | `string` |  |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  |  |
| Sprawy | `Soneta.Business.SubTable<Soneta.Windykacja.SprawaWindykacyjna>` |  |  |  |
| Termin | `int` | bazodanowe |  |  |
| TerminPlanowany | `int` |  |  |  |
| Transakcje | `Soneta.Business.SubTable<Soneta.CRM.Transakcja>` |  |  |  |
| TransakcjeKontrahenta | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` |  |  |  |
| TypLimituKredytowego | `Soneta.CRM.TypLimituKredytowego` | enum |  |  |
| TypPrzeterminowania | `Soneta.CRM.TypLimituKredytowego` | enum |  |  |
| Urzadzenia | `Soneta.Business.SubTable` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Waluta | `Soneta.Waluty.Waluta` |  |  |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| Zadania | `Soneta.Business.SubTable` |  |  |  |
| ZadaniaKontrahenta | `Soneta.Business.SubTable` |  |  |  |
| Zaplaty | `Soneta.Business.SubTable<Soneta.Kasa.Zaplata>` |  |  |  |
| Zdarzenia | `Soneta.Business.SubTable<Soneta.CRM.DokumentZdarzenia>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Platnik | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

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
