# Moduł `Kalend` — tabele biznesowe

- Opis: Moduł zarządzania czasem pracy. Zawiera kalendarze, definicje dni, strefy czasowe, harmonogramy pracy, reguły rozliczania czasu pracy oraz ewidencję obecności.
- Tabel: **75**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| CzynnoscNaObiekcieDoPlanowania | Czynności dla obiektu do planowania | `CzynnObDoPlan` |  | root |  |  |  | [CzynnoscNaObiekcieDoPlanowania.md](CzynnoscNaObiekcieDoPlanowania.md) |
| CzytnikRCP | Czytniki RCP | `CzytnikiRCP` | konfig | root |  |  |  | [CzytnikRCP.md](CzytnikRCP.md) |
| DefAlgorytmRCP | Definicje algorytmów RCP | `DefAlgorytmyRCP` | konfig | root |  |  |  | [DefAlgorytmRCP.md](DefAlgorytmRCP.md) |
| DefinicjaAktualizacjiKalendarza | Definicje dokumentów aktualizacji kalendarzy | `DefAktKalendarzy` | konfig | root |  | IRightsSource | RodzajAktualizacjiKalendarza (2) | [DefinicjaAktualizacjiKalendarza.md](DefinicjaAktualizacjiKalendarza.md) |
| DefinicjaCzynnosciNaObiekcie | Definicje czynności na obiektach do planowania | `DefCzynnOb` | konfig | root |  |  |  | [DefinicjaCzynnosciNaObiekcie.md](DefinicjaCzynnosciNaObiekcie.md) |
| DefinicjaDnia | Definicje dni | `DefinicjeDni` | konfig | root |  | IŹródłoKoloruElementu |  | [DefinicjaDnia.md](DefinicjaDnia.md) |
| DefinicjaGrafikaPracy | Definicje grafików | `DefGrafikowPracy` | konfig | root |  |  |  | [DefinicjaGrafikaPracy.md](DefinicjaGrafikaPracy.md) |
| DefinicjaLimitu | Definicje limitów | `DefinicjeLimitow` | konfig | root |  |  |  | [DefinicjaLimitu.md](DefinicjaLimitu.md) |
| DefinicjaNieobecnosci | Definicje nieobecności | `DefNieobecnosci` | konfig | root |  | IŹródłoKoloruElementu |  | [DefinicjaNieobecnosci.md](DefinicjaNieobecnosci.md) |
| DefinicjaRodzajuPracyZdalnej | Definicje rodzaju pracy zdalnej | `DefRodzPracZdal` | konfig | root |  |  |  | [DefinicjaRodzajuPracyZdalnej.md](DefinicjaRodzajuPracyZdalnej.md) |
| DefinicjaRozliczeniaCzasuPracy | Definicje dokumentów rozliczenia czasu pracy | `DefRozlCzasPracy` | konfig | root |  |  |  | [DefinicjaRozliczeniaCzasuPracy.md](DefinicjaRozliczeniaCzasuPracy.md) |
| DefinicjaStrefy | Definicje stref | `DefinicjeStref` | konfig | root |  | IŹródłoKoloruElementu |  | [DefinicjaStrefy.md](DefinicjaStrefy.md) |
| DefinicjaWeryfikatoraKalendarza | Definicje weryfikatorów dla kalendarzy | `DefWeryfKalend` | konfig | root |  |  | RodzajWeryfikacjiKalendarza (11) | [DefinicjaWeryfikatoraKalendarza.md](DefinicjaWeryfikatoraKalendarza.md) |
| DefinicjaWeryfikatoraRozliczeniaCzasuPracy | Definicje weryfikatorów dla dokumentów rozliczenia czasu pracy | `DefWerRozCzas` | konfig | root |  |  |  | [DefinicjaWeryfikatoraRozliczeniaCzasuPracy.md](DefinicjaWeryfikatoraRozliczeniaCzasuPracy.md) |
| DefinicjaZdarzeniaRCP | Definicje zdarzeń RCP | `DefZdarzenRCP` |  | root |  |  |  | [DefinicjaZdarzeniaRCP.md](DefinicjaZdarzeniaRCP.md) |
| DefinicjaZestawieniaCzasu | Definicje zestawień czasu | `DefZestawCzasu` | konfig | root |  | IRightsSource |  | [DefinicjaZestawieniaCzasu.md](DefinicjaZestawieniaCzasu.md) |
| DokumentAktualizacjiKalendarza | Dokumenty aktualizacji kalendarzy | `DokAktKalendarzy` |  | root |  | IŹródłoPowiązaniaStrukturyOrganizacyjnej, IDokumentAktualizacjiKalendarza, IDokument | RodzajAktualizacjiKalendarza (2) | [DokumentAktualizacjiKalendarza.md](DokumentAktualizacjiKalendarza.md) |
| DzienAkorduBase | Dni akordów | `DniAkordow` |  | child: Akord→Akord |  |  | TypAkordu (2) | [DzienAkorduBase.md](DzienAkorduBase.md) |
| DzienKalendarzaAktualizacja |  | `DniKalendAkt` |  | child: Pozycja→PozycjaAktualizacjiKalendarza |  |  | TypKalendarza (2) | [DzienKalendarzaAktualizacja.md](DzienKalendarzaAktualizacja.md) |
| DzienKalendarzaBase |  | `DniKalendarza` |  | child: Kalendarz→KalendarzBase |  |  | TypKalendarza (6) | [DzienKalendarzaBase.md](DzienKalendarzaBase.md) |
| DzienKalendarzaHistoria |  | `DniKalendHist` |  | child: DokumentAktualizacji→IDokumentAktualizacjiKalendarza |  |  |  | [DzienKalendarzaHistoria.md](DzienKalendarzaHistoria.md) |
| DzienPracy | Dni pracy | `DniPracy` |  | child: Pracownik→Pracownik |  |  |  | [DzienPracy.md](DzienPracy.md) |
| DzienPracyAktualizacja | Aktualizacje dni pracy | `DniPracyAkt` |  | child: Pozycja→PozycjaAktualizacjiCzasu |  |  |  | [DzienPracyAktualizacja.md](DzienPracyAktualizacja.md) |
| DzienPracyHistoria | Historia dni pracy | `DniPracyHist` |  | child: DokumentAktualizacji→IDokumentAktualizacjiKalendarza |  |  |  | [DzienPracyHistoria.md](DzienPracyHistoria.md) |
| DzienPracyUmowy | Dni pracy umowy | `DniPracyUmowy` |  | child: Umowa→IUmowaZKalendarzem |  |  |  | [DzienPracyUmowy.md](DzienPracyUmowy.md) |
| DzienRCP | Dni RCP | `DniRCP` |  | child: Pracownik→Pracownik |  |  |  | [DzienRCP.md](DzienRCP.md) |
| ElementRozliczeniaCzasuPracy | Elementy wniosków/zleceń rozliczenia czasu pracy | `ElRozlCzasPracy` |  | root |  |  |  | [ElementRozliczeniaCzasuPracy.md](ElementRozliczeniaCzasuPracy.md) |
| GrafikPracownika | Grafiki pracowników | `GrafPracownikow` |  |  |  |  |  | [GrafikPracownika.md](GrafikPracownika.md) |
| GrafikPracy | Grafiki planu pracy | `GrafikiPracy` |  | root |  |  |  | [GrafikPracy.md](GrafikPracy.md) |
| KalendarzBase |  | `Kalendarze` |  | root |  |  | TypKalendarza (6) | [KalendarzBase.md](KalendarzBase.md) |
| KodZdarzeniaRCP | Kody zdarzeń RCP | `KodyZdarzenRCP` | konfig | child: CzytnikRCP→CzytnikRCP |  |  |  | [KodZdarzeniaRCP.md](KodZdarzeniaRCP.md) |
| KolorElementu | Kolory elementów | `KoloryElementow` | konfig | child: Zrodlo→IŹródłoKoloruElementu |  |  |  | [KolorElementu.md](KolorElementu.md) |
| LimitNieobecnosci | Limity nieobecności | `LimNieobecnosci` |  | child: Pracownik→Pracownik |  |  | TypLimituNieobecności (2) | [LimitNieobecnosci.md](LimitNieobecnosci.md) |
| Nieobecnosc | Nieobecności | `Nieobecnosci` |  | root |  | IZrodloNieobecnosci, IBazaZrodlaWyplaty, IBilansOtwarcia, IZrodloDeklaracji | TypŹródłaNieobecności (4) | [Nieobecnosc.md](Nieobecnosc.md) |
| NieobecnośćIdx |  | `NieobecnosciIdx` |  |  |  |  |  | [NieobecnośćIdx.md](NieobecnośćIdx.md) |
| ObiektAktualizacjiKalendarza | Powiązania obiektu oraz dokumentu aktualizacji kalendarza | `ObAktKalend` |  |  |  |  |  | [ObiektAktualizacjiKalendarza.md](ObiektAktualizacjiKalendarza.md) |
| ObiektDoPlanowania | Obiekty do planowania | `ObiektyDoPlan` |  | root |  |  |  | [ObiektDoPlanowania.md](ObiektDoPlanowania.md) |
| ObrotRN | Obroty | `ObrotyRN` |  | child: StrefaNadgodziny→StrefaPracy |  |  |  | [ObrotRN.md](ObrotRN.md) |
| PUEDokumentEZLA | Dokument ZLA importowany z PUE | `PUEDokEZLA` |  | child: Raport→PUERaportNieobecnosci |  | IDokumentAktualizacjiKalendarza |  | [PUEDokumentEZLA.md](PUEDokumentEZLA.md) |
| PUERaportNieobecnosci | Raport nieobecności importowany z PUE | `PUERptNb` |  | root |  |  |  | [PUERaportNieobecnosci.md](PUERaportNieobecnosci.md) |
| PlanowanaNieobecność | Planowane nieobecności | `PlanNieobecnosci` |  | root |  |  |  | [PlanowanaNieobecność.md](PlanowanaNieobecność.md) |
| PozycjaAktualizacjiCzasu | Źródła kalendarza na dokumentach aktualizacji kalendarzy | `PozAktCzasu` |  |  |  |  |  | [PozycjaAktualizacjiCzasu.md](PozycjaAktualizacjiCzasu.md) |
| PozycjaAktualizacjiKalendarza | Źródła kalendarza na dokumentach aktualizacji kalendarzy | `PozAktKalend` |  |  |  |  |  | [PozycjaAktualizacjiKalendarza.md](PozycjaAktualizacjiKalendarza.md) |
| PozycjaObiektuAktualizacjiCzasu | Powiązania obiektu oraz pozycji aktualizacji czasu | `PozObAktCzas` |  |  |  |  |  | [PozycjaObiektuAktualizacjiCzasu.md](PozycjaObiektuAktualizacjiCzasu.md) |
| PozycjaObiektuAktualizacjiKalendarza | Powiązania obiektu oraz pozycji aktualizacji kalendarza | `PozObAktKalend` |  |  |  |  |  | [PozycjaObiektuAktualizacjiKalendarza.md](PozycjaObiektuAktualizacjiKalendarza.md) |
| RegulaDostepnosci | Reguły dostępności | `RegulyDostep` |  | root |  |  |  | [RegulaDostepnosci.md](RegulaDostepnosci.md) |
| RozliczenieCzasuPracy | Rozliczenia czasu pracy | `RozlCzasPracy` |  | root |  | IManagedRowInfoHost, IDokument, IDokumentAktualizacjiKalendarza |  | [RozliczenieCzasuPracy.md](RozliczenieCzasuPracy.md) |
| StrefaDnia | Strefy dni | `StrefyDni` | konfig | child: Dzien→DefinicjaDnia |  |  |  | [StrefaDnia.md](StrefaDnia.md) |
| StrefaKalendarza | Strefy dni | `StrefyKalandarza` |  | child: Dzien→DzienKalendarzaBase |  |  |  | [StrefaKalendarza.md](StrefaKalendarza.md) |
| StrefaKalendarzaAktualizacja | Aktualizacje strefy dna | `StrefyKalendAkt` |  | child: Dzien→DzienKalendarzaAktualizacja |  |  |  | [StrefaKalendarzaAktualizacja.md](StrefaKalendarzaAktualizacja.md) |
| StrefaKalendarzaHistoria | Historie strefy dnia | `StrefyKalendHist` |  | child: Dzien→DzienKalendarzaHistoria |  |  |  | [StrefaKalendarzaHistoria.md](StrefaKalendarzaHistoria.md) |
| StrefaPracy | Strefy dni | `StrefyPracy` |  | child: Dzien→DzienPracy |  | IRozliczenieNadgodzinHost |  | [StrefaPracy.md](StrefaPracy.md) |
| StrefaPracyAktualizacja | Aktualizacje strefy dnia pracy | `StrefyPracyAkt` |  | child: Dzien→DzienPracyAktualizacja |  |  |  | [StrefaPracyAktualizacja.md](StrefaPracyAktualizacja.md) |
| StrefaPracyHistoria | Historie strefy dnia pracy | `StrefyPracyHist` |  | child: Dzien→DzienPracyHistoria |  | IRozliczenieNadgodzinHost |  | [StrefaPracyHistoria.md](StrefaPracyHistoria.md) |
| StrefaPracyUmowy | Strefy dni umowy | `StrefyPracyUmowy` |  | child: Dzien→DzienPracyUmowy |  | IRozliczenieNadgodzinHost |  | [StrefaPracyUmowy.md](StrefaPracyUmowy.md) |
| StrefaRCP | Strefy RCP | `StrefyRCP` |  | child: Dzien→DzienRCP |  |  |  | [StrefaRCP.md](StrefaRCP.md) |
| StrefaZestawienia | Strefy zestawień | `StrefyZestawien` |  | child: Zestawienie→ZestawieniePracy |  | IRozliczenieNadgodzinHost |  | [StrefaZestawienia.md](StrefaZestawienia.md) |
| StrefaZestawieniaUmowy | Strefy zestawień umów | `StrefyZestawUmow` |  | child: Zestawienie→ZestawienieUmowy |  |  |  | [StrefaZestawieniaUmowy.md](StrefaZestawieniaUmowy.md) |
| StrefaZestawieniaUmowyZewnetrznej | Strefy zestawień umów zewnętrznych | `StrefyZestUmZw` |  | child: Zestawienie→ZestawienieUmowyZewnetrznej |  |  |  | [StrefaZestawieniaUmowyZewnetrznej.md](StrefaZestawieniaUmowyZewnetrznej.md) |
| WejscieWyjscie | Wejścia/Wyjścia | `WejsciaWyjscia` |  | child: Dzien→DzienPracy |  |  |  | [WejscieWyjscie.md](WejscieWyjscie.md) |
| WejscieWyjscieI | Dane z RCP | `WejsciaWyjsciaI` |  | child: Pracownik→Pracownik |  |  |  | [WejscieWyjscieI.md](WejscieWyjscieI.md) |
| WejscieWyjscieO | Oryginalne dane z RCP | `WejsciaWyjsciaO` |  | child: Pracownik→Pracownik |  |  |  | [WejscieWyjscieO.md](WejscieWyjscieO.md) |
| WeryfikatorKalendarza | Weryfikatory dla kalendarzy | `WeryfKalend` |  | root |  |  |  | [WeryfikatorKalendarza.md](WeryfikatorKalendarza.md) |
| WeryfikatorRozliczeniaCzasuPracy | Weryfikatory dla dokumentów rozliczenia czasu pracy | `WerRozCzas` |  | root |  |  |  | [WeryfikatorRozliczeniaCzasuPracy.md](WeryfikatorRozliczeniaCzasuPracy.md) |
| WniosekPracyZdalnej | Wnioski o pracę zdalną | `WnioskiPracZdal` |  | root |  | IDokumentAktualizacjiKalendarza |  | [WniosekPracyZdalnej.md](WniosekPracyZdalnej.md) |
| WyjatekRegulyDostepnosci | Wyjątki od reguły dostępności | `WyjatkiRegDost` |  | child: Regula→RegulaDostepnosci |  |  |  | [WyjatekRegulyDostepnosci.md](WyjatekRegulyDostepnosci.md) |
| ZasobRN | Zasoby | `ZasobyRN` |  | child: Strefa→StrefaPracy |  |  |  | [ZasobRN.md](ZasobRN.md) |
| ZbiegPracyIRodzicielstwa | Zbiegi pracy i rodzicielstwa | `ZbiegiPracyIRodz` |  | root |  | IBazaZrodlaWyplaty |  | [ZbiegPracyIRodzicielstwa.md](ZbiegPracyIRodzicielstwa.md) |
| ZestDietPakietMobil | Zestawienia diet pakiet mobilności | `ZestDietPaMob` |  | child: Host→IZestawienieDietPakietMobilHost |  |  |  | [ZestDietPakietMobil.md](ZestDietPakietMobil.md) |
| ZestawienieAkorduBase | Zestawienia akordów | `ZestawAkordow` |  | child: Akord→Akord |  |  | TypAkordu (2) | [ZestawienieAkorduBase.md](ZestawienieAkorduBase.md) |
| ZestawienieAktualizacjiKalendarza | Zestawienia dokumentów aktualizacji kalendarzy | `ZestAktKalend` | konfig | child: DefinicjaDokumentu→DefinicjaAktualizacjiKalendarza |  |  |  | [ZestawienieAktualizacjiKalendarza.md](ZestawienieAktualizacjiKalendarza.md) |
| ZestawienieDietZagr | Zestawienia diet pracowników za granicą | `ZestawDietZagr` |  | child: Host→IZestawienieDietZagrHost |  |  |  | [ZestawienieDietZagr.md](ZestawienieDietZagr.md) |
| ZestawieniePracy | Zestawienia czasu pracy | `ZestawieniaPracy` |  | child: Pracownik→Pracownik |  |  |  | [ZestawieniePracy.md](ZestawieniePracy.md) |
| ZestawienieUmowy | Zestawienia umów | `ZestawieniaUmow` |  | child: Umowa→Umowa |  |  |  | [ZestawienieUmowy.md](ZestawienieUmowy.md) |
| ZestawienieUmowyZewnetrznej | Zestawienia umów zewnętrznych | `ZestawieniaUmZew` |  | child: Umowa→UmowaZewnetrzna |  |  |  | [ZestawienieUmowyZewnetrznej.md](ZestawienieUmowyZewnetrznej.md) |

