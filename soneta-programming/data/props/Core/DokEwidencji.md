# Pola i właściwości klasy biznesowej: `Soneta.Core.DokEwidencji`
Nazwa tabeli: `DokEwidencja`
Tytuł: Dokument ewidencji
Opis: Główna tabela dokumentów ewidencji (faktur, not, korekt itp.). Zawiera dane dokumentu: numer, daty (wpływu, operacji, ewidencji), podmiot, wartość, stan, serię, oddział firmy, powiązanie z KSeF oraz informacje o księgowaniu (KPiR, ryczałt, MPP).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentPlatny`, `IDaneKontrahentaHost`, `IRaportEwidencjiSP`, `IDokumentCRM`, `IKomunikatEDIHost`, `IEmailElement`, `IProceduraVATHost`, `IDigitalizedDocument`
Selektor: pole `Typ` (`Soneta.Core.TypDokumentu`) — wiele typów w jednej tabeli, podtypów: 29

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | tylko-odczyt |  |  |
| BuforK | `bool` | bazodanowe |  | Bufor kontrolingowy |
| CzyZalacznik | `string` | tylko-odczyt |  |  |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` | tylko-odczyt |  |  |
| DataDekretu | `Date` | tylko-odczyt | Domyślna data dekretu |  |
| DataDokumentu | `Date` | bazodanowe |  |  |
| DataEwidencji | `Date` | bazodanowe |  | Data dodatkowa |
| DataKsiegowania | `Date` | tylko-odczyt | Data księgowania |  |
| DataOperacji | `Date` | bazodanowe |  |  |
| DataWplywu | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Dekrety | `SubTable` | podlista |  |  |
| Description | `string` | tylko-odczyt |  |  |
| Dokument | `Soneta.Core.IDokumentKsiegowalny` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| DokumentMPP | `bool` | bazodanowe, tylko-odczyt | Dokument MPP |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| EwidencjaSP | `IRow` | bazodanowe, tylko-odczyt |  |  |
| EwidencjaZbiorcza | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt |  | Ewidencja zbiorcza |
| EwidencjeEwidencjiZbiorczej | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| Firma | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt | Firma |  |
| IdentyfikatorReferencji | `System.Guid` | bazodanowe |  |  |
| ImportExportXmls | `System.Collections.Generic.IEnumerable<Soneta.Core.ImportExportXml>` | podlista |  |  |
| KSeFKomunikat | `Soneta.Core.KSeFKomunikat` | bazodanowe | Komunikat KSeF | Komunikat KSeF |
| KSeFPlik | `Soneta.Core.KSeFPlik` | tylko-odczyt |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| KolKPiR | `int` | bazodanowe |  | Numer kolumny KPiR w ewidencjach VAT |
| KolRyczalt | `int` | bazodanowe |  | Numer kolumny ryczałtu w ewidencjach VAT |
| KonfiguracjaElementuOpisuAnalitycznego | `Soneta.Core.KonfiguracjaElementuOpisuAnalitycznego` | tylko-odczyt |  |  |
| Koszty | `Soneta.Core.IKosztyCalculator` | tylko-odczyt |  |  |
| KosztyEP | `SubTable` | podlista |  |  |
| KwotySad | `SubTable` | podlista |  |  |
| MetodaKasowaPIT | `bool` | bazodanowe |  | Metoda kasowa PIT |
| NKUP | `Percent` | bazodanowe |  | Część niebędąca kosztem uzyskania przychodu |
| Nadrzedny | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt |  | Nadrzędny dokument ewidencji |
| NadrzednyTypRelacji | `Soneta.Core.TypRelacjiDokumentuEwidencji` (enum) | bazodanowe, tylko-odczyt |  | Typ relacji do nadrzędnego dokumentu ewidencji |
| NagEwidencjiVATAkcyzy | `SubTable` | podlista |  |  |
| NaglowkiRozliczaniaVAT | `SubTable` | podlista |  |  |
| NieKsiegowac | `bool` | bazodanowe, tylko-odczyt | Nie podlega księgowaniu | Nie podlega księgowaniu |
| NrDokumentuK | `string` | bazodanowe |  | Nr dokumentu korygowanego |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerDodatkowy | `string` | bazodanowe |  |  |
| NumerDokumentu | `string` | bazodanowe |  |  |
| NumerProceduryISO | `string` | bazodanowe, tylko-odczyt |  | numer procedury ISO wg ktorej powstał ten dokument |
| ObrotyMW | `SubTable` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| Platnosci | `SubTable` | podlista |  |  |
| PodlegaKsiegowaniu | `bool` | tylko-odczyt | Podlega księgowaniu |  |
| Podmiot | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref |  |  |
| Podrzedne | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| PowiazaneDokEwid | `SubTable<Soneta.Core.DokumentPowiazanyDokEwid>` | podlista |  |  |
| Pozycje | `LpSubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` | podlista |  |  |
| ProceduryVAT | `SubTable<Soneta.Core.RelProceduraVAT>` | podlista |  |  |
| PrzyczynaKorekty | `string` | bazodanowe | Przyczyna korekty | Przyczyna korekty |
| Rozliczenia | `SubTable` | podlista |  |  |
| RozliczeniaRK | `SubTable` | podlista |  |  |
| Seria | `string` | bazodanowe |  |  |
| Stan | `Soneta.Core.StanEwidencji` (enum) | bazodanowe |  |  |
| StanPrzetworzenia | `Soneta.Core.EwidencjaDokumentow.StanPrzetworzenia` (enum) | bazodanowe | Stan przetworzenia dokumentu | Stan przetworzenia dokumentu |
| SymbolNumeruZrodla | `string` | bazodanowe, tylko-odczyt | Symbol numeru źródła | Symbol użyty podczas numeracji z dokumentu źródłowego |
| SymbolNumeruZrodla2 | `string` | tylko-odczyt | Symbol numeru źródła |  |
| SymbolOkresuWgDatyDokumentu | `string` | tylko-odczyt |  |  |
| SymbolOkresuWgDatyEwidencji | `string` | tylko-odczyt |  |  |
| SymbolOkresuWgDatyWplywu | `string` | tylko-odczyt |  |  |
| Szablon | `bool` | bazodanowe |  | Szablon dokumentu |
| TryForceAttachmentPreview | `bool` |  |  |  |
| Typ | `Soneta.Core.TypDokumentu` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| TypDokumentuJPK | `Soneta.Core.ProceduraVAT` |  | Typ dokumentu VAT |  |
| TypReferencji | `Soneta.Core.TypReferencji` (enum) | bazodanowe |  |  |
| Wartosc | `Currency` | bazodanowe |  |  |
| WartoscNetto | `Currency` | tylko-odczyt |  |  |
| WartosciRMK | `SubTable` | podlista |  |  |
| WiadomosciPowiazane | `SubTable` | podlista |  |  |
| Wielofirmowosc | `bool` | tylko-odczyt |  |  |
| Wielooddzialowosc | `bool` | tylko-odczyt |  |  |
| WymagalnoscKwotyVAT | `Soneta.Core.WymagalnoscKwotyVAT` (enum) | bazodanowe, tylko-odczyt |  |  |
| ZadaniaCRM | `SubTable` | podlista |  |  |
| Zaplaty | `SubTable` | podlista |  |  |
| Zbiorczy | `bool` | tylko-odczyt |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `WyciągBankowyEwidencja` | 120 | `Soneta.Kasa.WyciagBankowyEwidencja` | Wyciąg bankowy |
| `RaportKasowyEwidencja` | 121 | `Soneta.Kasa.RaportKasowyEwidencja` | Raport kasowy |
| `RozliczenieEwidencja` | 122 | `Soneta.Kasa.RozliczenieEwidencja` | Rozliczenie dokumentów |
| `NotaOdsetkowaEwidencja` | 123 | `Soneta.Kasa.NotaOdsetkowaEwidencja` | Nota odsetkowa |
| `DelegacjaPWSEwidencja` | 124 | `Soneta.Delegacje.DelegacjaEwidencja` | Delegacja PWS ewidencja |
| `ListaPlacEwidencja` | 503 | `Soneta.Place.ListaPlacEwidencja` | Lista płac |
| `WyplataUmowyEwidencja` | 504 | `Soneta.EwidencjaVat.WyplataUmowyEwidencja` |  |
| `PlanowanaListaPłacEwidencja` | 521 | `Soneta.Place.PlanowanaListaPłacEwidencja` | Planowana lista płac |
| `PKEwidencja` | 804 | `Soneta.Ksiega.PKEwidencja` | Polecenie księgowania |
| `RóżniceKursoweEwidencja` | 805 | `Soneta.Ksiega.RozniceKursoweEwidencja` | Rożnice kursowe |
| `BOEwidencja` | 806 | `Soneta.Ksiega.BOEwidencja` | Bilans otwarcia |
| `RóżniceKursoweMWEwidencja` | 807 | `Soneta.Ksiega.RozniceKursoweMWEwidencja` | Rożnice kursowe MW |
| `RozniceKursoweKPiREwidencja` | 808 | `Soneta.Ksiega.RozniceKursoweKPiREwidencja` | Różnice kursowe KPiR |
| `DeklaracjaRozliczeniowa` | 1099 | `Soneta.Deklaracje.DeklaracjaEwidencja` | Deklaracja |
| `MagazynEwidencja` | 1101 | `Soneta.Handel.MagazynEwidencja` | Magazyn ewidencja |
| `SprzedażEwidencja` | 1201 | `Soneta.EwidencjaVat.SprzedazEwidencja` | Sprzedaż |
| `ZakupEwidencja` | 1202 | `Soneta.EwidencjaVat.ZakupEwidencja` | Zakup |
| `RozliczenieKasoweVATEwidencja` | 1203 | `Soneta.EwidencjaVat.RozliczeniaKasoweVATEwidencja` | Rozliczenia kasowe VAT |
| `RozliczenieKasoweAkcyzyEwidencja` | 1204 | `Soneta.EwidencjaVat.RozliczeniaKasoweAkcyzyEwidencja` | Rozliczenia kasowe akcyzy |
| `SprzedażZbiorczaEwidencja` | 1205 | `Soneta.EwidencjaVat.SprzedazZbiorczaEwidencja` | Sprzedaż zbiorcza |
| `FWUENabyciaNaliczonyEwidencja` | 1206 | `Soneta.EwidencjaVat.FWUENabyciaNaliczonyEwidencja` | Dokument wewnętrzny nabycia VAT naliczony |
| `FWUENabyciaNależnyEwidencja` | 1207 | `Soneta.EwidencjaVat.FWUENabyciaNależnyEwidencja` | Dokument wewnętrzny nabycia VAT należny |
| `VATMarżaEwidencja` | 1210 | `Soneta.EwidencjaVat.VATMarzaEwidencja` | VAT marża |
| `ŚrodkiTrwałeEwidencja` | 1306 | `Soneta.SrodkiTrwale.SrodkiTrwaleEwidencja` | Środki trwałe |
| `FakturaImportowa` | 1401 | `Soneta.Import.FakturaImportowaEwidencja` | Faktura importowa |
| `SAD` | 1402 | `Soneta.Import.SADEwidencja` | SAD |
| `SkladkaEwidencja` | 1660 | `Soneta.CzlonkowieSzkolenia.SkladkaEwidencja` | Składka ewidencja |
| `RozliczenieEPEwidencja` | 1702 | `Soneta.Samochodowka.RozliczenieEPEwidencja` |  |
| `RMKEwidencja` | 1802 | `Soneta.RMK.RMKEwidencja` |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dokument | `IDokumentKsiegowalny` | `Deklaracja`, `DokRozliczBase`, `DokumentHandlowy`, `DokumentRMK`, `DokumentST`, `ListaPlac`, `PlanowanaListaPłac`, `RaportESP`, `RozliczenieEP`, `Skladka`, `Wyplata` |
| Podmiot | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanPrzetworzenia (`Soneta.Core.EwidencjaDokumentow.StanPrzetworzenia`)
- `Nieprzetwarzany` = 0
- `DoPrzetworzenia` = 1
- `Analizowany` = 2
- `Rozpoznany` = 3
- `Przetworzony` = 4

### StanEwidencji (`Soneta.Core.StanEwidencji`)
- `Niezweryfikowany` = -1
- `Bufor` = 0 — Bufor
- `Wprowadzony` = 1
- `Predekretowany` = 2
- `Zaksięgowany` = 3

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

### TypReferencji (`Soneta.Core.TypReferencji`)
- `Brak` = 0
- `ListaPlacEwidencja` = 1

### TypRelacjiDokumentuEwidencji (`Soneta.Core.TypRelacjiDokumentuEwidencji`)
- `Brak` = 0
- `Korekta` = 1
- `VATMarza` = 2 — VAT marża
- `DWNabyciaNalezny` = 3 — DW nabycia należny
- `DWNabyciaNaliczony` = 4 — DW nabycia naliczony

### WymagalnoscKwotyVAT (`Soneta.Core.WymagalnoscKwotyVAT`)
- `Brak` = 0
- `WgPozycjiMPP` = 16 — Wg pozycji MPP dokumentu
- `VATCalkowity` = 32 — Całkowita kwota VAT dokumentu
