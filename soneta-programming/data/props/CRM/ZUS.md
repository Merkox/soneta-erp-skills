# Pola i właściwości klasy biznesowej: `Soneta.CRM.ZUS`
Nazwa tabeli: `ZUSY`
Tytuł: Urzędy
Opis: Słownik urzędów (ZUS, skarbowych i innych) wykorzystywanych w rozliczeniach publicznoprawnych. Przechowuje dane identyfikacyjne, typ urzędu oraz formę płatności, umożliwiając generowanie przelewów do właściwych instytucji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPodmiot`, `IPodmiotKasowy`, `IAdresHost`, `IElementSlownika`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 37

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| BasicDocuments | `Soneta.Business.SubTable` |  |  |  |
| DeklaracjePodmiotu | `Soneta.Business.SubTable` |  |  |  |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Core.DokEwidencji>` |  |  |  |
| DokumentyPreliminarza | `Soneta.Business.SubTable<Soneta.Kasa.PreliminarzDokument>` |  |  |  |
| DokumentyRozliczeniowe | `Soneta.Business.SubTable<Soneta.Kasa.DokRozliczBase>` |  |  |  |
| DomyslnyRachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| EuVAT | `string` |  |  |  |
| Identyfikacje | `Soneta.Business.SubTable<Soneta.Kasa.IdentyfikacjaPlatnika>` |  |  |  |
| Kod | `string` | bazodanowe |  |  |
| LimitKredytu | `Soneta.Types.Currency` |  |  |  |
| LimitNieograniczony | `bool` |  |  |  |
| MatrycePodmiotu | `Soneta.Business.SubTable` |  |  |  |
| NIP | `string` |  |  |  |
| Nadrzedny | `Soneta.Core.IPodmiotInternal` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` |  |  |  |
| Platnik | `Soneta.Kasa.IPodmiotKasowy` | iface-ref |  |  |
| Platnosci | `Soneta.Business.SubTable<Soneta.Kasa.Platnosc>` |  |  |  |
| PodmiotPowiazany | `bool` |  |  |  |
| Podrzedni | `Soneta.Business.SubTable<Soneta.CRM.RelacjaPodmiotu>` |  |  |  |
| Pojazdy | `Soneta.Business.SubTable` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| Przelewy | `Soneta.Business.SubTable<Soneta.Kasa.PrzelewBase>` |  |  |  |
| PrzeterminowanieNieograniczone | `bool` |  |  |  |
| Rabat | `Soneta.Types.Percent` |  |  |  |
| Rachunki | `Soneta.Business.SubTable<Soneta.Kasa.RachunekBankowyPodmiotu>` |  |  |  |
| RachunkiWirtualne | `Soneta.Business.SubTable<Soneta.Kasa.RachunekWirtualny>` |  |  |  |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` | enum |  |  |
| Rozrachunki | `Soneta.Business.SubTable<Soneta.Kasa.RozrachunekIdx>` |  |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  |  |
| Sprawy | `Soneta.Business.SubTable<Soneta.Windykacja.SprawaWindykacyjna>` |  |  |  |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` | enum |  |  |
| Termin | `int` |  |  |  |
| TerminPlanowany | `int` |  |  |  |
| Typ | `Soneta.CRM.TypUrzędu` | bazodanowe, enum |  |  |
| TypLimituKredytowego | `Soneta.CRM.TypLimituKredytowego` | enum |  |  |
| TypPrzeterminowania | `Soneta.CRM.TypLimituKredytowego` | enum |  |  |
| Zaplaty | `Soneta.Business.SubTable<Soneta.Kasa.Zaplata>` |  |  |  |

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
