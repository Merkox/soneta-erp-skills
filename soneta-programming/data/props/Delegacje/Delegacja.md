# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.Delegacja`
Nazwa tabeli: `Delegacje`
Tytuł: Delegacje PWS
Opis: Dokument polecenia wyjazdu służbowego (PWS). Rejestruje delegację pracownika, zawierając dane o celu, trasie, datach, środku transportu oraz rozliczeniu kosztów podróży. Obsługuje pełen cykl delegacji od wystawienia przez rozliczenie diet i zaliczek po generowanie płatności.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IZrodloOpisuAnalitycznego`

- pola bazodanowe: 28
- pola kalkulowane (z klas biznesowych): 29

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BuforOpisuAnalitycznego | `bool` | bazodanowe |  | Bufor opisu analitycznego |
| Cel | `Soneta.Business.MemoText` | bazodanowe |  | Cel delegacji. |
| Data | `Soneta.Types.Date` |  |  |  |
| DataKursu | `Soneta.Types.Date` | bazodanowe |  | Data kursu do tabeli kursowej. |
| DataNum | `Soneta.Types.Date` |  |  |  |
| DataOgloszeniaKursu | `Soneta.Types.Date` |  |  |  |
| DataRozliczenia | `Soneta.Types.Date` | bazodanowe |  | Data rozliczenia delegacji. |
| DataRozpoczeciaPlanowana | `Soneta.Types.DateShortTime` | bazodanowe |  | Planowany czas rozpoczęcia delegacji. |
| DataRozpoczeciaPlanowanaDate | `Soneta.Types.Date` |  |  |  |
| DataRozpoczeciaPlanowanaTime | `Soneta.Types.Time` |  |  |  |
| DataRozpoczeciaWgEtapow | `Soneta.Types.DateShortTime` | bazodanowe |  | Data rozpoczecia delegacji (pierwszego etapu). |
| DataWystawienia | `Soneta.Types.Date` | bazodanowe |  | Data wystawienia dokumentu delegacji PWS |
| DataZakonczeniaPlanowana | `Soneta.Types.DateShortTime` | bazodanowe |  | Planowany czas zakończenia delegacji. |
| DataZakonczeniaPlanowanaDate | `Soneta.Types.Date` |  |  |  |
| DataZakonczeniaPlanowanaTime | `Soneta.Types.Time` |  |  |  |
| DataZakonczeniaWgEtapow | `Soneta.Types.DateShortTime` | bazodanowe |  | Data zakonczenia delegacji (ostatniego etapu). |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu |
| Delegowany | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  | Podmiot, dla rozliczenia którego wystawiono dokument PWS. |
| Delegowany_Kod | `string` |  |  |  |
| Etapy | `Soneta.Business.SubTable<Soneta.Delegacje.EtapDelegacji>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| Extension | `Soneta.Business.MemoText` | bazodanowe |  | Rozszerzenie dla pól wirtualnych |
| IsWebUser | `bool` |  |  |  |
| JestCiagla | `bool` | bazodanowe |  | Czy system ma pilnować aby początek kolejnego etapu pokrywał się z końcem poprzedniego. |
| KonsolidujPlatnosci | `bool` | bazodanowe |  | Włącza konsolidację płatności wyrażonych w tej samej walucie. |
| KrajDocelowy | `Soneta.Delegacje.KrajDelegacji` | bazodanowe |  | Kraj docelowy etapu delegacji. |
| KurierDyplomatyczny | `bool` | bazodanowe |  | Delegacja kuriera dyplomatycznego - dieta zwiększona o 25%. |
| Naliczenia | `Soneta.Business.SubTable<Soneta.Delegacje.NaliczenieDelegacji>` |  |  |  |
| NtfPrzepisywanieWniosku | `bool` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  | Numer dokumentu delegacji PWS |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerProceduryISO | `string` | bazodanowe |  | Numer procedury ISO |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  | Oddział firmy |
| Opis | `string` |  |  |  |
| OpisAnalityczny | `Soneta.Business.SubTable` |  |  |  |
| OpisAnalitycznyBufor | `bool` |  |  |  |
| PageVisible | `bool` |  |  |  |
| Platnosci | `Soneta.Business.SubTable` |  |  |  |
| Podmiot | `Soneta.Core.IPodmiot` | iface-ref |  |  |
| Seria | `string` | bazodanowe |  | Seria dokumentu delegacji |
| SrodekTransportu | `string` | bazodanowe |  | Domyślny środek transportu. |
| StanDokumentuPozwalaNaBuforowanieOA | `bool` |  |  |  |
| StanDokumentuPozwalaNaZatwierdzenieOA | `bool` |  |  |  |
| StatusDelegacji | `Soneta.Delegacje.StatusDelegacji` | bazodanowe, enum |  | Status delegacji. |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  | Tabela kursowa do rozliczenia delegacji. |
| Typ | `Soneta.Core.TypDokumentu` | enum |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  | Uwagi do delegacji |
| WidokAktywny | `bool` |  |  |  |
| Wielooddzialowosc | `bool` |  |  |  |
| Wniosek | `Soneta.Kadry.WniosekUrlopowy` | bazodanowe |  | Źródłowy wniosek urlopowy |
| ZakupyWalut | `Soneta.Business.LpSubTable<Soneta.Delegacje.ZakupWalutDoDelegacji>` |  |  |  |
| Zaliczki | `Soneta.Business.LpSubTable<Soneta.Delegacje.ZaliczkaDelegacji>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Delegowany | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| Podmiot | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypDokumentu (`Soneta.Core.TypDokumentu`)
- `Niezdefiniowany` = 0
- `RaportESP` = 101 — Raport EŚP
- `Wpłata` = 102
- `Wypłata` = 103
- `Przelew` = 104
- `PaczkaPrzelewow` = 105
- `PotwierdzenieSalda` = 111
- `WezwanieDoZaplaty` = 112
- `NotaOdsetkowa` = 113
- `Kompensata` = 114
- `RozliczenieZaliczki` = 115
- `RozliczenieDelegacji` = 116
- `Cesja` = 117
- `NotaKorygujaca` = 118 — Nota korygująca
- `NotaKorygujacaOtrzymana` = 119 — Nota korygująca otrzymana
- `WyciągBankowyEwidencja` = 120
- `RaportKasowyEwidencja` = 121
- `RozliczenieEwidencja` = 122
- `NotaOdsetkowaEwidencja` = 123
- `DelegacjaPWSEwidencja` = 124 — Delegacja PWS ewidencja
- `Preliminarz` = 125 — Dokument Preliminarza
- `GIODOOświadczenie` = 201
- `GIODOUprawnienie` = 202
- `GIODOPozyskanieDanych` = 203 — Pozyskanie danych osobowych
- `GIODOPowierzenieDanych` = 204 — Powierzenie danych osobowych
- `GIODOPrzetwarzanie` = 205
- `GIODOUdostępnienieDanych` = 206 — Udostępnienie danych osobowych
- `GIODONaruszenie` = 216 — Naruszenie ochrony danych osobowych
- `Dekret` = 801
- `BO` = 802
- `ZapisKsiegowy` = 803
- `PKEwidencja` = 804
- `RóżniceKursoweEwidencja` = 805
- `BOEwidencja` = 806
- `RóżniceKursoweMWEwidencja` = 807 — Różnice kursowe MW ewidencja
- `RozniceKursoweKPiREwidencja` = 808 — Różnice kursowe KPiR ewidencja
- `DokumentZleDlugi` = 809
- `VAT7` = 207
- `VAT_UE` = 208
- `VAT_UEA` = 209
- `VAT_UEB` = 210
- `VAT_UEK` = 211
- `VAT_UEK_Pozycja` = 212
- `VAT_UEC` = 213
- `VAT_ZD` = 214
- `VAT27` = 215
- `VAT9M` = 217
- `VAT_UES` = 218
- `VIIDO` = 219
- `VIIDO_Pozycja` = 220
- `VIUDO` = 221
- `VIUDO_Pozycja` = 222
- `VAT8` = 223
- `VAT7ParametryRozliczen` = 224
- `Umowa` = 301
- `OfertaPracy` = 302
- `Wypadek` = 303
- `UmowaZewnetrzna` = 304
- `ZgloszenieSygnalisty` = 305
- `Sprawa` = 321
- `RozliczenieCzasuPracy` = 401
- `ListaPlac` = 501
- `Wyplata` = 502
- `ListaPlacEwidencja` = 503
- `WyplataUmowyEwidencja` = 504
- `DokumentAktualizacjiKalendarza` = 505
- `PlanowanaListaPłac` = 520
- `PlanowanaListaPłacEwidencja` = 521
- `KEDU` = 1001
- `ZgloszenieZUS` = 1002
- `ZalacznikZUS` = 1003
- `ZUSDRA` = 1004
- `PIT4` = 1005
- `PIT11` = 1006
- `PIT40` = 1007
- `PIT8A` = 1008
- `PIT8B` = 1009
- `PIT8C` = 1010
- `IFT1` = 1011
- `CIT2` = 1012
- `CIT2O` = 1013
- `PIT5` = 1014
- `AKC2` = 1015
- `AKC2E` = 1016
- `ZUSIWA` = 1017
- `PIT5L` = 1018
- `WND` = 1019
- `PFRON` = 1020
- `IFT1R` = 1021
- `PITR` = 1022
- `CIT8` = 1023
- `CIT8O` = 1024
- `PIT8S` = 1025
- `PIT11Z` = 1026
- `PIT40Z` = 1027
- `PIT8CZ` = 1028
- `PITRZ` = 1029
- `CITST` = 1030
- `CITSTA` = 1031
- `CITZAL` = 1032
- `CITD` = 1033
- `IFT2` = 1034
- `CIT10Z` = 1035
- `CIT8BR` = 1036
- `CITMIT` = 1037
- `CIT8S` = 1038
- `CIT8SP` = 1039
- `PITRyczałt` = 1040
- `CITIP` = 1041
- `CITWZ` = 1042
- `CITKW` = 1043
- `CITF` = 1044
- `CITM` = 1045
- `WNU` = 1050
- `ZSWA` = 1060
- `ZUSRMUA` = 1070
- `OSW` = 1080
- `ZUSRIA` = 1090
- `CIT8E` = 1100
- `CITEZ` = 1110
- `CITCSR` = 2700
- `CITRB` = 1150
- `CITWOT` = 1160
- `ZUSDRAII` = 3000
- `ZUSRCAII` = 3010
- `DEKR` = 3020
- `INF2` = 3030
- `LukaPlacowa` = 3040
- `DeklaracjaRozliczeniowa` = 1099
- `MagazynEwidencja` = 1101
- `SprzedażEwidencja` = 1201
- `ZakupEwidencja` = 1202
- `RozliczenieKasoweVATEwidencja` = 1203 — Rozliczenie kasowe VAT ewidencja
- `RozliczenieKasoweAkcyzyEwidencja` = 1204 — Rozliczenie kasowe akcyzy ewidencja
- `SprzedażZbiorczaEwidencja` = 1205
- `FWUENabyciaNaliczonyEwidencja` = 1206 — DW nabycia naliczony ewidencja
- `FWUENabyciaNależnyEwidencja` = 1207 — DW nabycia należny ewidencja
- `VATMarżaEwidencja` = 1210
- `OT` = 1301
- `LT` = 1302
- `Amortyzacja` = 1303
- `Przeszacowanie` = 1304
- `ZmianaWartości` = 1305
- `ŚrodkiTrwałeEwidencja` = 1306
- `ŚrodkiTrwałe` = 1307
- `BOT` = 1308
- `Wyposażenie` = 1309
- `ZmianaMiejscaUżytkowania` = 1310
- `ZmianaOsobyOdpowiedzialnej` = 1311
- `ZmianaParametrówAmortyzacji` = 1312
- `ZmianaCentrumKosztów` = 1313
- `Inwentaryzacja` = 1314
- `ZmianaWartościRezydualnej` = 1315
- `OdpisAktualizujący` = 1317
- `ZmianaWartosciDok` = 1318 — Zmiana wartości i ilości
- `PodatekOdNieruchomosci` = 1319 — Podatek od nieruchomości
- `ZmianaParametrowPodatku` = 1320
- `ZmianaKategorii` = 1321
- `InwentaryzacjaCzastkowa` = 1322 — Inwentaryzacja cząstkowa
- `ZmianaPodzielnikaKosztow` = 1323 — Zmiana podzielnika kosztów
- `Leasing` = 1324 — Leasing
- `ZmianaParametrowLeasingu` = 1325 — Zmiana parametrów leasingu
- `RataLeasingowa` = 1326 — Rata leasingowa
- `FakturaImportowa` = 1401
- `SAD` = 1402
- `IntrastatPrzywóz` = 1501
- `IntrastatWywóz` = 1502
- `IntrastatTowar` = 1503
- `ZdarzenieCRM` = 1601 — Zdarzenie CRM
- `ZadanieCRM` = 1602 — Zadanie CRM
- `ProjektCRM` = 1603 — Projekt CRM
- `KampaniaCRM` = 1604 — Kampania CRM
- `Korespondencja` = 1605 — Korespondencja
- `Budget` = 1606 — Budżet
- `Wyroznienie` = 1651
- `Zgloszenie` = 1652
- `SkladkaEwidencja` = 1660 — Składka ewidencja
- `RozliczenieEP` = 1701 — Rozliczenie EP
- `RozliczenieEPEwidencja` = 1702 — Rozliczenie EP Ewidencja
- `Rezerwacja` = 1751
- `DokumentRMK` = 1801
- `RMKEwidencja` = 1802 — RMK ewidencja
- `Delegacja` = 1900
- `Workflow` = 2000
- `BasicDocument` = 2001
- `Matter` = 2002
- `DocPkg` = 2003
- `ChronoOrderElem` = 2004
- `DbTuple` = 2100
- `SprawaWindykacyjna` = 2200 — Sprawa windykacyjna
- `PPK_DokumentyPracodawcy` = 2300 — PPK - Dokumenty pracodawcy
- `PPK_DokumentyInstytucjiFinansowej` = 2301 — PPK - Dokumenty instytucji finansowej
- `PPK_RozliczenieSkładek` = 2302 — PPK - Rozliczenie składek
- `PPK_RozliczenieNadpłat` = 2303 — PPK - Rozliczenie nadpłat
- `PPK_DokumentPracodawcy` = 2310
- `PPK_RejestracjaUczestnika` = 2311 — PPK - Rejestracja uczestnika
- `PPK_Składka` = 2312 — PPK - Składka
- `PPK_KorektaSkładki` = 2313 — PPK - Korekta składki
- `PPK_DeklaracjaUczestnika` = 2314 — PPK - Deklaracja uczestnika
- `PPK_ZmianaDanychKontaktu` = 2315 — PPK - Zmiana danych kontaktu elektronicznego uczestnika
- `PPK_ZmianaDanychIdentyfikacyjnych` = 2316 — PPK - Zmiana danych identyfikacyjnych uczestnika
- `PPK_ZwolnienieUczestnika` = 2317 — PPK - Zwolnienie pracownika (zleceniobiorcy) –  uczestnika
- `PPK_DokumentInstytucjiFinansowej` = 2320
- `PPK_WypłataŚrodków` = 2321 — PPK - Wypłata środków przez uczestnika
- `PPK_ZwrotNadpłaty` = 2322 — PPK - Zwrot środków w wyniku rozliczenia korekty lub rezygnacji z dokonywania wpłat
- `PPK_WypłataTransferowa` = 2323 — PPK - Wypłata transferowa
- `PPK_NadanieUczestnikowiNumeruEwidencji` = 2324 — PPK - Nadanie uczestnikowi numeru ewidencji PPK
- `PPK_ZwrotŚrodków` = 2325 — PPK - Zwrot (art. 12.6, art. 19.6.)
- `ZAW_NR` = 2400 — ZAW-NR
- `CUK` = 2600 — CUK
- `DokumentRozliczeniaKontrahenta` = 2500
- `DokumentRozliczeniaPracownika` = 2501
- `Discussion` = 2750 — Dyskusja
- `DiscussionRequirements` = 2751 — Wymagania dyskusji
- `WniosekOZwrotNienależnieOpłaconychSkładek` = 2800
- `ZUS_Z3` = 2900 — ZUS-Z3
- `ZUS_Z3a` = 2910 — ZUS-Z3a

### StatusDelegacji (`Soneta.Delegacje.StatusDelegacji`)
- `Zlecona` = 0
- `Naliczona` = 1
- `Rozliczona` = 2
- `Zatwierdzona` = 3
- `Zarejestrowana` = 4
- `Anulowana` = 5
