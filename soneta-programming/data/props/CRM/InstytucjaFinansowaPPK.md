# Pola i właściwości klasy biznesowej: `Soneta.CRM.InstytucjaFinansowaPPK`
Nazwa tabeli: `InstFinansowePPK`
Tytuł: Instytucje finansowe PPK
Opis: Słownik instytucji finansowych obsługujących Pracownicze Plany Kapitałowe. Przechowuje dane identyfikacyjne (NIP, REGON, KRS), adresowe i kontaktowe instytucji, umożliwiając obsługę wpłat i rozliczeń PPK.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPodmiot`, `IKontrahent`, `IPodmiotKasowy`, `IAdresHost`, `IElementSlownika`, `IAdresyWWWHost`, `IDaneKontaktoweHost`, `IEmailElement`

- pola bazodanowe (zapisywalne): 15
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 11
- podlisty: 35
- subrowy: 2
- razem: 66

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresDoKorespondencji | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresyWWW | `SubTable<Soneta.Core.AdresWWW>` | podlista |  |  |
| BasicDocuments | `SubTable` | podlista |  |  |
| Blokada | `bool` | bazodanowe |  | Określa, czy dany urząd ma być widoczny na listach. |
| DeklaracjePodmiotu | `SubTable` | podlista |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| DokumentyPreliminarza | `SubTable<Soneta.Kasa.PreliminarzDokument>` | podlista |  |  |
| DokumentyRozliczeniowe | `SubTable<Soneta.Kasa.DokRozliczBase>` | podlista |  |  |
| DomyslnyRachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` | tylko-odczyt |  |  |
| DomyślnyAdresWWW | `string` | tylko-odczyt |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| Identyfikacje | `SubTable<Soneta.Kasa.IdentyfikacjaPlatnika>` | podlista |  |  |
| KRS | `string` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| Kontakt | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `SubTable<Soneta.Core.DaneKontaktowe>` | podlista |  |  |
| Leady | `SubTable<Soneta.CRM.Lead>` | podlista |  |  |
| Lokalizacje | `SubTable<Soneta.CRM.Lokalizacja>` | podlista |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| MatrycePodmiotu | `SubTable` | podlista |  |  |
| NIP | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
| Osoba | `Soneta.Core.Osoba` (subrow) | bazodanowe |  |  |
| Osoba.Adres | `string` | bazodanowe |  |  |
| Osoba.Osoba | `string` | bazodanowe |  |  |
| Osoba.Telefon | `string` | bazodanowe |  |  |
| Osoby | `SubTable<Soneta.CRM.KontaktOsoba>` | podlista |  |  |
| OsobyKontaktowe | `SubTable<Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent>` | podlista |  |  |
| PPK | `Soneta.Kasa.NumerRachunku` | tylko-odczyt |  |  |
| Platnosci | `SubTable<Soneta.Kasa.Platnosc>` | podlista |  |  |
| PodmiotPowiazany | `bool` | tylko-odczyt |  |  |
| PodmiotyZastąpione | `System.Collections.Generic.List<Soneta.CRM.InstytucjaFinansowaPPK>` | podlista |  |  |
| Podrzedni | `SubTable<Soneta.CRM.RelacjaPodmiotu>` | podlista |  |  |
| Pojazdy | `SubTable` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Projekty | `SubTable` | podlista |  |  |
| Przelewy | `SubTable<Soneta.Kasa.PrzelewBase>` | podlista |  |  |
| REGON | `string` | bazodanowe | Regon | Rejestr Gospodarki Narodowej |
| Rabat | `Percent` | tylko-odczyt |  |  |
| Rachunki | `SubTable<Soneta.Kasa.RachunekBankowyPodmiotu>` | podlista |  |  |
| RachunkiWirtualne | `SubTable<Soneta.Kasa.RachunekWirtualny>` | podlista |  |  |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` (enum) | tylko-odczyt |  |  |
| RodzajePodmiotu | `SubTable<Soneta.Core.RodzajPodmiot>` | podlista |  |  |
| Rozrachunki | `SubTable<Soneta.Kasa.RozrachunekIdx>` | podlista |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  |  |
| Sprawy | `SubTable<Soneta.Windykacja.SprawaWindykacyjna>` | podlista |  |  |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` (enum) | tylko-odczyt |  |  |
| Transakcje | `SubTable<Soneta.CRM.Transakcja>` | podlista |  |  |
| TransakcjeKontrahenta | `SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` | podlista |  |  |
| Urzadzenia | `SubTable` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Zadania | `SubTable` | podlista |  |  |
| ZadaniaKontrahenta | `SubTable` | podlista |  |  |
| Zamiennik | `Soneta.CRM.InstytucjaFinansowaPPK` |  |  |  |
| Zaplaty | `SubTable<Soneta.Kasa.Zaplata>` | podlista |  |  |
| Zdarzenia | `SubTable<Soneta.CRM.DokumentZdarzenia>` | podlista |  |  |

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
