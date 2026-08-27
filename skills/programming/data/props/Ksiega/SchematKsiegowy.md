# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.SchematKsiegowy`
Nazwa tabeli: `SchematyKsiegowe`
Tytuł: Schematy księgowe
Opis: Schemat księgowy służy do automatycznej predekretacji dokumentów ewidencji na zapisy księgowe. Definiuje reguły rozksięgowania dla konkretnego typu dokumentu w danym okresie obrachunkowym, z możliwością przypisania do firmy i definicji dokumentu. Może być edytowany w trybie wizualnym lub jako kod.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `TypEwidencji` (`Soneta.Core.TypDokumentu`) — wiele typów w jednej tabeli, podtypów: 27

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AlgorytmBinder | `Compiler.ICodeEditorSource` |  |  | Kod weryfikacji schematu |
| Blokada | `bool` | bazodanowe |  | Blokuje schemat - nie jest używany podczas predekretacji |
| ClassName | `string` | tylko-odczyt |  |  |
| Data | `MemoText` | podlista |  | Data - tryb zaawansowany |
| DataP | `Soneta.Ksiega.DataSchematu` (enum) |  |  | Data - tryb podstawowy |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu ewidencji |
| DekretZamkniecia | `bool` |  |  | Dekret zamknięcia |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| DokumentType | `System.Type` | tylko-odczyt |  |  |
| ElementyWarunkuSchematu | `Soneta.Ksiega.SchematKsiegowy.ElementyWarunkuSchematuCollection` | podlista |  |  |
| EwidencjaType | `System.Type` | tylko-odczyt |  |  |
| Firma | `Soneta.Core.OddzialFirmy` | bazodanowe | Firma | Przypisanie schematu do firmy |
| GrupowanieZapisow | `bool` |  |  | Grupowanie zapisów na dekrecie |
| Kod | `MemoText` | podlista |  | Kod |
| KodWeryfikacji | `MemoText` | podlista |  |  |
| KolejnoscZapisówWgLpPozycji | `bool` |  |  | Kolejność zapisów wg lp. pozycji |
| KwotaOperacjiGospodarczej | `MemoText` | podlista |  | Kwota operacji gospodarczej - tryb zaawansowany |
| KwotaOperacjiGospodarczejP | `Soneta.Core.KwotaOperacjiGospodarczej` (enum) |  |  | Kwota operacji gospodarczej |
| Nazwa | `string` | bazodanowe |  |  |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe, tylko-odczyt |  | Okres obrachunkowy schematu |
| OkresWywolania | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe |  | Okres obrachunkowy schematu do wywołania |
| Opis | `MemoText` | podlista |  | Opis - tryb zaawansowany |
| OpisP1 | `string` |  |  | Opis1 - tryb podstawowy |
| OpisP2 | `Soneta.Ksiega.OpisSchematu` (enum) |  |  | Opis2 - tryb podstawowy |
| OpisP3 | `Soneta.Ksiega.OpisSchematu` (enum) |  |  | Opis3 - tryb podstawowy |
| Pozycje | `LpSubTable<Soneta.Ksiega.PozycjaSchematuKsiegowego>` | podlista |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SchematBaseType | `System.Type` | tylko-odczyt |  |  |
| SchematBaseTypeName | `string` | tylko-odczyt |  |  |
| TrybEdycji | `Soneta.Ksiega.TrybEdycjiSchematu` (enum) | bazodanowe |  | Tryb edycji schematu |
| TypDziennikaSchematu | `Soneta.Ksiega.TypDziennikaSchematuKsiegowego` (enum) |  |  |  |
| TypEwidencji | `Soneta.Core.TypDokumentu` (enum) | bazodanowe, tylko-odczyt, selektor |  | Typ dokumentu ewidencji schematu |
| UsunPusty | `bool` |  |  | Usuwanie pustych dekretów |
| Warunek | `MemoText` | podlista |  | Warunek - tryb zaawansowany |
| WeryfikowacSchemat | `bool` |  |  |  |
| WyjatkiKontP | `string` |  |  | Wyjątki kont |
| text | `MemoText` | bazodanowe, podlista |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `TypEwidencji`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `WyciągBankowyEwidencja` | 120 | `Soneta.Ksiega.SchematWyciagowBankowych` | Schemat ewidencji wyciągów bankowych |
| `RaportKasowyEwidencja` | 121 | `Soneta.Ksiega.SchematRaportowKasowych` | Schemat ewidencji raportów kasowych |
| `RozliczenieEwidencja` | 122 | `Soneta.Ksiega.SchematRozliczen` | Schemat ewidencji rozliczeń |
| `NotaOdsetkowaEwidencja` | 123 | `Soneta.Ksiega.SchematNotOdsetkowych` | Schemat ewidencji not odsetkowych |
| `DelegacjaPWSEwidencja` | 124 | `Soneta.Ksiega.SchematDelegacji` | Schemat ewidencji delegacji (PWS) |
| `ListaPlacEwidencja` | 503 | `Soneta.Ksiega.SchematListyPlac` | Schemat ewidencji listy płac |
| `WyplataUmowyEwidencja` | 504 | `Soneta.Ksiega.SchematWyplatyUmowy` | Schemat ewidencji wypłaty umowy |
| `PlanowanaListaPłacEwidencja` | 521 | `Soneta.Ksiega.SchematPlanowanejListyPlac` | Schemat ewidencji planowanej listy płac |
| `PKEwidencja` | 804 | `Soneta.Ksiega.SchematPK` | Schemat ewidencji PK |
| `RóżniceKursoweEwidencja` | 805 | `Soneta.Ksiega.SchematRoznicKursowych` | Schemat ewidencji różnic kursowych |
| `BOEwidencja` | 806 | `Soneta.Ksiega.SchematBO` | Schemat ewidencji BO |
| `RóżniceKursoweMWEwidencja` | 807 | `Soneta.Ksiega.SchematRoznicKursowychMW` | Schemat ewidencji różnic kursowych MW |
| `DeklaracjaRozliczeniowa` | 1099 | `Soneta.Ksiega.SchematDeklaracjiRozliczeniowych` | Schemat deklaracji rozliczeniowych |
| `MagazynEwidencja` | 1101 | `Soneta.Ksiega.SchematDokumentowMagazynowych` | Schemat ewidencji dokumentów magazynowych |
| `SprzedażEwidencja` | 1201 | `Soneta.Ksiega.SchematSprzedazy` | Schemat ewidencji sprzedaży |
| `ZakupEwidencja` | 1202 | `Soneta.Ksiega.SchematZakupu` | Schemat ewidencji zakupu |
| `RozliczenieKasoweVATEwidencja` | 1203 | `Soneta.Ksiega.SchematRozliczeniaKasowegoVAT` | Schemat ewid. rozliczenia kasowego VAT |
| `SprzedażZbiorczaEwidencja` | 1205 | `Soneta.Ksiega.SchematSprzedazyZbiorczej` | Schemat ewidencji sprzedaży zbiorczej |
| `FWUENabyciaNaliczonyEwidencja` | 1206 | `Soneta.Ksiega.SchematFWUENNL` | Schemat ewid. dokumentów wew. nabycia UE VAT naliczony |
| `FWUENabyciaNależnyEwidencja` | 1207 | `Soneta.Ksiega.SchematFWUENNZ` | Schemat ewid. dokumentów wew. nabycia UE VAT należny |
| `VATMarżaEwidencja` | 1210 | `Soneta.Ksiega.SchematVATMarza` | Schemat ewidencji VAT marża |
| `ŚrodkiTrwałeEwidencja` | 1306 | `Soneta.Ksiega.SchematSrodkowTrwalych` | Schemat ewidencji środków trwałych |
| `FakturaImportowa` | 1401 | `Soneta.Ksiega.SchematFakturImportowych` | Schemat ewidencji faktur importowych |
| `SAD` | 1402 | `Soneta.Ksiega.SchematSAD` | Schemat ewidencji SAD |
| `SkladkaEwidencja` | 1660 | `Soneta.CzlonkowieSzkolenia.SchematSkladki` | Schemat ewidencji składek |
| `RozliczenieEPEwidencja` | 1702 | `Soneta.Ksiega.SchematRozliczenEP` | Schemat ewidencji rozliczeń EP |
| `RMKEwidencja` | 1802 | `Soneta.Ksiega.SchematRMK` | Schemat ewidencji RMK |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KwotaOperacjiGospodarczej (`Soneta.Core.KwotaOperacjiGospodarczej`)
- `SumaZapisow` = 0 — Suma zapisów
- `Brak` = 1
- `Domyslnie` = 2 — Domyślnie
- `WartoscDokumentu` = 3 — Wartość dokumentu

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

### DataSchematu (`Soneta.Ksiega.DataSchematu`)
- `Domyślna` = 0 — Domyślna
- `Bieżąca` = 1
- `Wpływu` = 101
- `Dokumentu` = 102
- `Operacji` = 103
- `Ewidencji` = 104
- `OkresListyPłac` = 701
- `DataWypłaty` = 702
- `DataListyPłac` = 703
- `TerminPłatnościZUSFirmy` = 704 — Termin płatności ZUS firmy
- `Zaewidencjonowania` = 1201
- `TerminPłatności` = 1202
- `RozliczeniaVAT` = 1203 — Rozliczenia VAT

### OpisSchematu (`Soneta.Ksiega.OpisSchematu`)
- `Brak` = 0 — Brak
- `OpisDekretu` = 1
- `KodPodmiotu` = 2
- `NumerDokumentu` = 100
- `NumerDodatkowy` = 101
- `OpisDokumentu` = 102
- `OpisOpisuAnalitycznego` = 103
- `NumerDokumentuOperacji` = 301
- `OpisOperacji` = 302
- `NumerDokumentuPłatności` = 303
- `OpisPłatności` = 304
- `ZapłataZa` = 305
- `KodPodmiotuOperacji` = 306
- `KodPodmiotuOperacjiOpisu` = 307
- `SymbolStawki` = 1201
- `NumerInwentarzowy` = 1301
- `NazwaŚrodkaTrwałego` = 1302
- `RokMiesiącUmorzenia` = 1303

### TrybEdycjiSchematu (`Soneta.Ksiega.TrybEdycjiSchematu`)
- `Uproszczony` = 0 — Uproszczony
- `Podstawowy` = 1
- `Zaawansowany` = 2
- `Kod` = 3

### TypDziennikaSchematuKsiegowego (`Soneta.Ksiega.TypDziennikaSchematuKsiegowego`)
- `Domyslny` = 0 — Domyślny
- `Dekret` = 1
- `BO` = 2
