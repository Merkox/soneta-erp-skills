# Pola i właściwości klasy biznesowej: `Soneta.CRM.InstytucjaFinansowaPPK`
Nazwa tabeli: `InstFinansowePPK`
Tytuł: Instytucje finansowe PPK
Opis: Słownik instytucji finansowych obsługujących Pracownicze Plany Kapitałowe. Przechowuje dane identyfikacyjne (NIP, REGON, KRS), adresowe i kontaktowe instytucji, umożliwiając obsługę wpłat i rozliczeń PPK.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPodmiot`, `IKontrahent`, `IPodmiotKasowy`, `IAdresHost`, `IElementSlownika`, `IAdresyWWWHost`, `IDaneKontaktoweHost`, `IEmailElement`

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 48

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| AdresDoKorespondencji | `Soneta.Core.Adres` |  |  |  |
| AdresyWWW | `Soneta.Business.SubTable<Soneta.Core.AdresWWW>` |  |  |  |
| BasicDocuments | `Soneta.Business.SubTable` |  |  |  |
| Blokada | `bool` | bazodanowe |  | Określa, czy dany urząd ma być widoczny na listach. |
| DeklaracjePodmiotu | `Soneta.Business.SubTable` |  |  |  |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Core.DokEwidencji>` |  |  |  |
| DokumentyPreliminarza | `Soneta.Business.SubTable<Soneta.Kasa.PreliminarzDokument>` |  |  |  |
| DokumentyRozliczeniowe | `Soneta.Business.SubTable<Soneta.Kasa.DokRozliczBase>` |  |  |  |
| DomyslnyRachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` |  |  |  |
| DomyślnyAdresWWW | `string` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| Identyfikacje | `Soneta.Business.SubTable<Soneta.Kasa.IdentyfikacjaPlatnika>` |  |  |  |
| KRS | `string` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `Soneta.Business.SubTable<Soneta.Core.DaneKontaktowe>` |  |  |  |
| Leady | `Soneta.Business.SubTable<Soneta.CRM.Lead>` |  |  |  |
| Lokalizacje | `Soneta.Business.SubTable<Soneta.CRM.Lokalizacja>` |  |  |  |
| MailTo | `string` |  |  |  |
| MatrycePodmiotu | `Soneta.Business.SubTable` |  |  |  |
| NIP | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` |  |  |  |
| Osoba | `Soneta.Core.Osoba` | bazodanowe |  |  |
| Osoba.Adres | `string` | bazodanowe |  |  |
| Osoba.Osoba | `string` | bazodanowe |  |  |
| Osoba.Telefon | `string` | bazodanowe |  |  |
| Osoby | `Soneta.Business.SubTable<Soneta.CRM.KontaktOsoba>` |  |  |  |
| OsobyKontaktowe | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent>` |  |  |  |
| PPK | `Soneta.Kasa.NumerRachunku` |  |  |  |
| Platnosci | `Soneta.Business.SubTable<Soneta.Kasa.Platnosc>` |  |  |  |
| PodmiotPowiazany | `bool` |  |  |  |
| PodmiotyZastąpione | `System.Collections.Generic.List<Soneta.CRM.InstytucjaFinansowaPPK>` |  |  |  |
| Podrzedni | `Soneta.Business.SubTable<Soneta.CRM.RelacjaPodmiotu>` |  |  |  |
| Pojazdy | `Soneta.Business.SubTable` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| Projekty | `Soneta.Business.SubTable` |  |  |  |
| Przelewy | `Soneta.Business.SubTable<Soneta.Kasa.PrzelewBase>` |  |  |  |
| REGON | `string` | bazodanowe | Regon | Rejestr Gospodarki Narodowej |
| Rabat | `Soneta.Types.Percent` |  |  |  |
| Rachunki | `Soneta.Business.SubTable<Soneta.Kasa.RachunekBankowyPodmiotu>` |  |  |  |
| RachunkiWirtualne | `Soneta.Business.SubTable<Soneta.Kasa.RachunekWirtualny>` |  |  |  |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` | enum |  |  |
| RodzajePodmiotu | `Soneta.Business.SubTable<Soneta.Core.RodzajPodmiot>` |  |  |  |
| Rozrachunki | `Soneta.Business.SubTable<Soneta.Kasa.RozrachunekIdx>` |  |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  |  |
| Sprawy | `Soneta.Business.SubTable<Soneta.Windykacja.SprawaWindykacyjna>` |  |  |  |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` | enum |  |  |
| Transakcje | `Soneta.Business.SubTable<Soneta.CRM.Transakcja>` |  |  |  |
| TransakcjeKontrahenta | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` |  |  |  |
| Urzadzenia | `Soneta.Business.SubTable` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| Zadania | `Soneta.Business.SubTable` |  |  |  |
| ZadaniaKontrahenta | `Soneta.Business.SubTable` |  |  |  |
| Zamiennik | `Soneta.CRM.InstytucjaFinansowaPPK` |  |  |  |
| Zaplaty | `Soneta.Business.SubTable<Soneta.Kasa.Zaplata>` |  |  |  |
| Zdarzenia | `Soneta.Business.SubTable<Soneta.CRM.DokumentZdarzenia>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajPodmiotu (`Soneta.Core.RodzajPodmiotu`)
- `Krajowy` = 0
- `Eksportowy` = 1
- `EksportowyPodróżny` = 2
- `Unijny` = 3
- `UnijnyTrójstronny` = 4
- `BezVAT` = 5 — Bez VAT

### StatusPodmiotu (`Soneta.Core.StatusPodmiotu`)
- `PodmiotGospodarczy` = 0
- `Finalny` = 1
