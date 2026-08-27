# Moduł `Kasa` — tabele biznesowe

- Opis: Moduł gospodarki kasowo-bankowej obsługujący ewidencję środków pieniężnych w kasach i na rachunkach bankowych. Realizuje pełny obieg dokumentów płatniczych — od rejestracji płatności i zapłat, przez przelewy i raporty kasowe, po rozliczenia i rozrachunki z kontrahentami. Wspiera magazyn walut, preliminarz płatności, bankowość elektroniczną oraz mechanizm podzielonej płatności (MPP).
- Tabel: **32**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| DefinicjaPaczkiPrzelewu | Definicje paczek przelewów | `DefPaczekPrze` | konfig | root |  |  |  | [DefinicjaPaczkiPrzelewu.md](DefinicjaPaczkiPrzelewu.md) |
| DodatkoweDanePrzelewu | Dodatkowe dane przelewów | `DodDanePrzelewow` |  | child: Przelew→PrzelewBase |  |  |  | [DodatkoweDanePrzelewu.md](DodatkoweDanePrzelewu.md) |
| DokKasowyBase | Dokumenty kasowe | `DokumentyKasowe` |  | root |  | IDokumentKasowy, IDokumentCRM | KierunekPlatnosci (2) | [DokKasowyBase.md](DokKasowyBase.md) |
| DokRozliczBase | Dokumenty rozliczeniowe | `DokRozliczeniowe` |  | root |  | IDokumentKsiegowalny, IDokumentPlatny, IDokumentCRM, IEmailElement | TypDokumentu (9) | [DokRozliczBase.md](DokRozliczBase.md) |
| EwidencjaSP | Ewidencje ŚP | `EwidencjeSP` | konfig | root |  | IElementSlownika, IRightsSource | TypEwidencjiSP (3) | [EwidencjaSP.md](EwidencjaSP.md) |
| FormaPlatnosci | Definicje płatności | `FormyPlatnosci` | konfig | root |  |  |  | [FormaPlatnosci.md](FormaPlatnosci.md) |
| FormatWymianyElektronicznej | Rachunki bankowe | `FormatyWymElektr` | konfig | root |  |  | TypFormatuWymianyElektronicznej (1) | [FormatWymianyElektronicznej.md](FormatWymianyElektronicznej.md) |
| HistoriaStatusuBL | Historia statusów Biała lista | `StatusBLHist` |  |  |  |  |  | [HistoriaStatusuBL.md](HistoriaStatusuBL.md) |
| IdentyfikacjaPlatnika | Identyfikacje płatników | `IdentPlatnikow` |  |  |  |  |  | [IdentyfikacjaPlatnika.md](IdentyfikacjaPlatnika.md) |
| ObrotMW | Obroty | `ObrotyMW` |  |  |  |  |  | [ObrotMW.md](ObrotMW.md) |
| OkresMW | Okresy magazynu walut | `OkresyMW` | konfig | root |  |  |  | [OkresMW.md](OkresMW.md) |
| OperacjaBankowa | Operacje bankowe | `OperacjeBankowe` |  | child: WyciagBankowy→RaportESP |  |  |  | [OperacjaBankowa.md](OperacjaBankowa.md) |
| PaczkaPrzelewow | Paczki przelewów | `PaczkiPrzelewow` |  | root |  | IDokument |  | [PaczkaPrzelewow.md](PaczkaPrzelewow.md) |
| ParametrySerwisuBankowego | Parametry serwisów bankowych | `ParametrySeBnk` | konfig |  |  |  |  | [ParametrySerwisuBankowego.md](ParametrySerwisuBankowego.md) |
| Platnosc | Płatności | `Platnosci` |  | root |  | IRozliczalny, IElementKsiegowalny, IZrodloOpisuAnalitycznego | KierunekPlatnosci (2) | [Platnosc.md](Platnosc.md) |
| PozycjaDokRozlicz | Pozycja dokumentu rozliczeniowego | `PozDokRozlicz` |  | child: Dokument→DokRozliczBase |  |  | TypDokumentu (4) | [PozycjaDokRozlicz.md](PozycjaDokRozlicz.md) |
| PozycjaPaczkiPrzelewow | Pozycje paczek przelewów | `PozPaczPrz` |  | child: Paczka→PaczkaPrzelewow |  |  |  | [PozycjaPaczkiPrzelewow.md](PozycjaPaczkiPrzelewow.md) |
| PozycjaPrzelewu | Pozycje przelewów | `PozycjePrzelewow` |  | child: Przelew→PrzelewBase |  |  |  | [PozycjaPrzelewu.md](PozycjaPrzelewu.md) |
| PreliminarzDokument | Dokumenty preliminarza | `PreliminarzDok` |  | root |  | IDokumentPreliminarza, IZrodloOpisuAnalitycznego |  | [PreliminarzDokument.md](PreliminarzDokument.md) |
| PreliminarzPozycja | Pozycje preliminarza | `PreliminarzPoz` |  | child: Dokument→IDokumentPreliminarza |  |  |  | [PreliminarzPozycja.md](PreliminarzPozycja.md) |
| PrzelewBase | Przelewy | `Przelewy` |  | root |  | IAdresHost | TypPrzelewu (4) | [PrzelewBase.md](PrzelewBase.md) |
| RachunekBankowyPodmiotu | Rachunki bankowe | `RachBankPodmiot` |  | root |  | IAdresHost | TypRachunkuBankowego (19) | [RachunekBankowyPodmiotu.md](RachunekBankowyPodmiotu.md) |
| RachunekWirtualny | Rachunki wirtualne | `RachWirtualne` |  |  |  |  |  | [RachunekWirtualny.md](RachunekWirtualny.md) |
| RaportESP | Raport ESP | `RaportyESP` |  | root |  | IDokumentKsiegowalny, IRaportEwidencjiSP |  | [RaportESP.md](RaportESP.md) |
| RozliczenieSP | Rozliczenia | `RozliczeniaSP` |  | root |  | IRozliczenie |  | [RozliczenieSP.md](RozliczenieSP.md) |
| RozrachunekIdx | Rozrachunki | `RozrachunkiIdx` |  |  |  |  |  | [RozrachunekIdx.md](RozrachunekIdx.md) |
| SerwisBankowy | Serwis bankowy | `SerwisyBankowe` | konfig | root |  |  |  | [SerwisBankowy.md](SerwisBankowy.md) |
| SposobZaplaty | Sposoby zapłaty | `SposobyZaplaty` | konfig | root |  |  |  | [SposobZaplaty.md](SposobZaplaty.md) |
| SubEwidencjaSP | Subewidencje | `SubEwidencjeSP` | konfig |  |  |  |  | [SubEwidencjaSP.md](SubEwidencjaSP.md) |
| TypIdenPodPrzel | Typy identyfikatorów podmiotu przelewu | `TypyIdenPodPrzel` | konfig | root |  |  |  | [TypIdenPodPrzel.md](TypIdenPodPrzel.md) |
| Zaplata | Wpłaty i wypłaty | `Zaplaty` |  | root |  | IRozliczalny, IElementKsiegowalny, IZrodloOpisuAnalitycznego, IDaneKontrahentaHost, IDokumentCRM | KierunekPlatnosci (2) | [Zaplata.md](Zaplata.md) |
| ZasobMW | Zasoby | `ZasobyMW` |  |  |  |  |  | [ZasobMW.md](ZasobMW.md) |

