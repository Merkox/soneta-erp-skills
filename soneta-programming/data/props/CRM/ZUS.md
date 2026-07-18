# Pola i właściwości klasy biznesowej: `Soneta.CRM.ZUS`
Nazwa tabeli: `ZUSY`
Tytuł: Urzędy
Opis: Słownik urzędów (ZUS, skarbowych i innych) wykorzystywanych w rozliczeniach publicznoprawnych. Przechowuje dane identyfikacyjne, typ urzędu oraz formę płatności, umożliwiając generowanie przelewów do właściwych instytucji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPodmiot`, `IPodmiotKasowy`, `IAdresHost`, `IElementSlownika`
Selektor: pole `Typ` (`Soneta.CRM.TypUrzędu`) — wiele typów w jednej tabeli, podtypów: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| BasicDocuments | `SubTable` | podlista |  |  |
| DeklaracjePodmiotu | `SubTable` | podlista |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| DokumentyPreliminarza | `SubTable<Soneta.Kasa.PreliminarzDokument>` | podlista |  |  |
| DokumentyRozliczeniowe | `SubTable<Soneta.Kasa.DokRozliczBase>` | podlista |  |  |
| DomyslnyRachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` | tylko-odczyt |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| EuVAT | `string` | tylko-odczyt |  |  |
| Identyfikacje | `SubTable<Soneta.Kasa.IdentyfikacjaPlatnika>` | podlista |  |  |
| Kod | `string` | bazodanowe |  |  |
| LimitKredytu | `Currency` | tylko-odczyt |  |  |
| LimitNieograniczony | `bool` | tylko-odczyt |  |  |
| MatrycePodmiotu | `SubTable` | podlista |  |  |
| NIP | `string` | tylko-odczyt |  |  |
| Nadrzedny | `Soneta.Core.IPodmiotInternal` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` | tylko-odczyt |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
| Platnik | `Soneta.Kasa.IPodmiotKasowy` | tylko-odczyt, iface-ref |  |  |
| Platnosci | `SubTable<Soneta.Kasa.Platnosc>` | podlista |  |  |
| PodmiotPowiazany | `bool` | tylko-odczyt |  |  |
| Podrzedni | `SubTable<Soneta.CRM.RelacjaPodmiotu>` | podlista |  |  |
| Pojazdy | `SubTable` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Przelewy | `SubTable<Soneta.Kasa.PrzelewBase>` | podlista |  |  |
| PrzeterminowanieNieograniczone | `bool` | tylko-odczyt |  |  |
| Rabat | `Percent` | tylko-odczyt |  |  |
| Rachunki | `SubTable<Soneta.Kasa.RachunekBankowyPodmiotu>` | podlista |  |  |
| RachunkiWirtualne | `SubTable<Soneta.Kasa.RachunekWirtualny>` | podlista |  |  |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` (enum) | tylko-odczyt |  |  |
| Rozrachunki | `SubTable<Soneta.Kasa.RozrachunekIdx>` | podlista |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  |  |
| Sprawy | `SubTable<Soneta.Windykacja.SprawaWindykacyjna>` | podlista |  |  |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` (enum) | tylko-odczyt |  |  |
| Termin | `int` | tylko-odczyt |  |  |
| TerminPlanowany | `int` | tylko-odczyt |  |  |
| Typ | `Soneta.CRM.TypUrzędu` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| TypLimituKredytowego | `Soneta.CRM.TypLimituKredytowego` (enum) | tylko-odczyt |  |  |
| TypPrzeterminowania | `Soneta.CRM.TypLimituKredytowego` (enum) | tylko-odczyt |  |  |
| Zaplaty | `SubTable<Soneta.Kasa.Zaplata>` | podlista |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `ZUS` | 1 | `Soneta.CRM.ZUSCentrala` | Centrala ZUS |
| `PFRON` | 2 | `Soneta.CRM.PFRONCentrala` | Centrala PFRON |
| `US` | 3 | `Soneta.CRM.UrzadSkarbowyCentrala` | Centrala urząd skarbowy |
| `GUS` | 4 | `Soneta.CRM.GusCentrala` | Centrala gus |

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

### TypUrzędu (`Soneta.CRM.TypUrzędu`)
- `ZUS` = 1
- `PFRON` = 2
- `US` = 3
- `GUS` = 4

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
