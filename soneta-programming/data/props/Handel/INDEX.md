# Moduł `Handel` — tabele biznesowe

- Opis: Moduł handlowy obsługujący dokumenty sprzedaży, zakupu, zamówień i innych operacji handlowych. Zawiera definicje dokumentów, relacje między dokumentami, pozycje dokumentów, sumy VAT, rozliczenia oraz mechanizmy fiskalizacji i EDI.
- Tabel: **38**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| DaneBDO | Dane dokumentów BDO | `DaneDokBDO` |  |  |  |  |  | [DaneBDO.md](DaneBDO.md) |
| DaneEParagonu | Dane e-paragonów. | `DaneEParagony` |  |  |  |  |  | [DaneEParagonu.md](DaneEParagonu.md) |
| DaneEUDR | Dane pozycji dokumentów EUDR | `DanePozEUDR` |  |  |  |  |  | [DaneEUDR.md](DaneEUDR.md) |
| DaneTaxFree | Dane dokumentów Tax Free | `DaneDokTaxFree` |  |  |  |  |  | [DaneTaxFree.md](DaneTaxFree.md) |
| DefDokHandlowego | Definicje dokumentów handlowych | `DefDokHandlowych` | konfig | root |  | IRightsSource, IDefinicjaKomunikatuEDIHost, IWarningHost, IDefinicjaDokumentuOA |  | [DefDokHandlowego.md](DefDokHandlowego.md) |
| DefDokPodrzednego |  | `DefDokPodrzedne` | konfig | child: Definicja→DefRelacjiHandlowej |  |  |  | [DefDokPodrzednego.md](DefDokPodrzednego.md) |
| DefRelacjiHandlowej | Definicje relacji handlowych | `DefRelHandlowych` | konfig | root |  |  | TypRelacjiHandlowej (12) | [DefRelacjiHandlowej.md](DefRelacjiHandlowej.md) |
| DefUrzadzeniaUz | Definicje urządzeń użytkowanych | `DefUrzadzenUz` | konfig | root |  |  |  | [DefUrzadzeniaUz.md](DefUrzadzeniaUz.md) |
| DokumentHandlowy | Dokumenty handlowe | `DokHandlowe` |  | root |  | IDokumentPlatny, IDokumentKsiegowalny, IDokumentKasowy, IDaneKontrahentaHost, IDokumentCRM, IKodowany, IExportImportXmlHost, IElementSlownika, IKomunikatEDIHost, IEmailElement, IProceduraVATHost, IZrodloOpisuAnalitycznego |  | [DokumentHandlowy.md](DokumentHandlowy.md) |
| DokumentHandlowyKoszt | Koszty dodatkowe | `DokHandloweKoszt` |  |  |  |  |  | [DokumentHandlowyKoszt.md](DokumentHandlowyKoszt.md) |
| DrukarkaFiskalna | Lista drukarek fiskalnych | `DrukarkiFiskalne` | konfig | root |  |  |  | [DrukarkaFiskalna.md](DrukarkaFiskalna.md) |
| DrukarkaFiskalnaStanowisko | Lista drukarek przypisanych do stanowiska | `DrukFiskStan` | konfig |  |  |  |  | [DrukarkaFiskalnaStanowisko.md](DrukarkaFiskalnaStanowisko.md) |
| ElemRozliczenia | Elementy rozliczenia pozycji | `ElemyRozliczenia` |  | child: Pozycja→PozycjaDokHandlowego |  |  |  | [ElemRozliczenia.md](ElemRozliczenia.md) |
| KSeFPozycjaDokHan | Dane KSeF przypisane do pozycji dokumentu handlowego | `KSeFPozDokHan` |  | child: Pozycja→PozycjaDokHandlowego |  |  |  | [KSeFPozycjaDokHan.md](KSeFPozycjaDokHan.md) |
| KontrahentKomunikatEDI | Komunikaty EDI dla kontrahenta | `KontrahKonEDI` |  |  |  |  |  | [KontrahentKomunikatEDI.md](KontrahentKomunikatEDI.md) |
| LimitWartosci | Limity wartości dokumentu. | `LimityWartosci` |  | child: Definicja→DefDokHandlowego |  |  | LimitWartosciTyp (3) | [LimitWartosci.md](LimitWartosci.md) |
| MagDefDokRight | Przypisanie definicji dokumentu do magazynu | `MagDefDokRights` | konfig | child: Magazyn→Magazyn |  |  |  | [MagDefDokRight.md](MagDefDokRight.md) |
| OkresZawieszenia | Okresy zawieszenia | `OkresyZawiesz` |  | child: Dokument→DokumentHandlowy |  |  |  | [OkresZawieszenia.md](OkresZawieszenia.md) |
| Paczka |  | `Paczki` |  |  |  |  |  | [Paczka.md](Paczka.md) |
| PaczkaWzorcowa |  | `PaczkiWzorcowe` |  | root |  |  |  | [PaczkaWzorcowa.md](PaczkaWzorcowa.md) |
| PozHanTimeTrack | TimeTrack pozycji dokumentu handlowego | `PozHanTimeTracks` |  |  |  |  |  | [PozHanTimeTrack.md](PozHanTimeTrack.md) |
| PozycjaDokHanCenaInfo | Informacja o cenie pozycji dokumentu handlowego | `PozHanCenaInfo` |  | child: Pozycja→PozycjaDokHandlowego |  |  |  | [PozycjaDokHanCenaInfo.md](PozycjaDokHanCenaInfo.md) |
| PozycjaDokHanRabatInfo | Informacja o cenie pozycji dokumentu handlowego | `PozHanRabatInfo` |  | child: Pozycja→PozycjaDokHandlowego |  |  |  | [PozycjaDokHanRabatInfo.md](PozycjaDokHanRabatInfo.md) |
| PozycjaDokHandlowego | Pozycje dokumentów | `PozycjeDokHan` |  | child: Dokument→DokumentHandlowy |  | IZrodloOpisuAnalitycznego |  | [PozycjaDokHandlowego.md](PozycjaDokHandlowego.md) |
| PozycjaDokHandlowegoLimit | Pozycja Handlowa Limity | `PozDoHandLimity` |  | root |  |  |  | [PozycjaDokHandlowegoLimit.md](PozycjaDokHandlowegoLimit.md) |
| PozycjaDokHandlowegoLimitHost | Pozycja Handlowa Limit Hosts | `PozDoHaLiHosts` |  | child: Host→ILimitHost |  |  |  | [PozycjaDokHandlowegoLimitHost.md](PozycjaDokHandlowegoLimitHost.md) |
| PozycjaRelacjiHandlowej | Pozycja relacji handlowej | `PozRelHandlowej` |  | child: Relacja→RelacjaHandlowa |  |  |  | [PozycjaRelacjiHandlowej.md](PozycjaRelacjiHandlowej.md) |
| ProgRabatowy |  | `ProgiRabatowe` |  |  |  |  |  | [ProgRabatowy.md](ProgRabatowy.md) |
| PrzesylkaDokRel | Relacje przesyłek | `PrzesylkiDokRel` |  |  |  |  |  | [PrzesylkaDokRel.md](PrzesylkaDokRel.md) |
| PrzesylkaSpedyt | Przesyłki spedytora | `PrzesylkiSpedyt` |  | root |  |  |  | [PrzesylkaSpedyt.md](PrzesylkaSpedyt.md) |
| PulpitHost | Obiekty wykorzystywane w pulpitach | `PulpityHost` |  |  |  |  |  | [PulpitHost.md](PulpitHost.md) |
| RelacjaGrupyDostaw | Relacje do partii | `RelacjeGrupDostw` |  |  |  |  |  | [RelacjaGrupyDostaw.md](RelacjaGrupyDostaw.md) |
| RelacjaHandlowa |  | `RelacjeHandlowe` |  | root |  |  | TypRelacjiHandlowej (17) | [RelacjaHandlowa.md](RelacjaHandlowa.md) |
| RelacjaInnaPlat |  | `RelacjeInnaPlat` |  |  |  |  |  | [RelacjaInnaPlat.md](RelacjaInnaPlat.md) |
| RelacjaZaliczki |  | `RelacjeZaliczek` |  |  |  |  |  | [RelacjaZaliczki.md](RelacjaZaliczki.md) |
| SumaVAT | Sumy VAT | `SumyVAT` |  | child: Dokument→DokumentHandlowy |  |  |  | [SumaVAT.md](SumaVAT.md) |
| UrzadzenieUz | Urządzenia użytkowane | `UrzadzeniaUz` |  | root |  |  |  | [UrzadzenieUz.md](UrzadzenieUz.md) |
| UslDodPrzesyl | Usługi dodatkowe przesyłki | `UslDodPrzesylek` |  |  |  |  |  | [UslDodPrzesyl.md](UslDodPrzesyl.md) |

