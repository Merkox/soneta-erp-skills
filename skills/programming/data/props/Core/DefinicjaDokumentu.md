# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaDokumentu`
Nazwa tabeli: `DefDokumentow`
Tytuł: Definicje dokumentów
Opis: Definicja typu dokumentu ewidencji (np. faktura, nota, paragon). Określa symbol, typ, sposób numeracji, powiązanie z procedurą VAT i ISO, schemat podziałowy opisu analitycznego oraz konfigurację dla modułu CRM i pulpitu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IDefinicjaKomunikatuEDIHost`, `IDefinicjaDokumentuOA`
Selektor: pole `Typ` (`Soneta.Core.TypDokumentu`) — wiele typów w jednej tabeli, podtypów: 179

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| DlaPulpituKB | `bool` | bazodanowe |  |  |
| DodatkowyNaglowekDefinicja | `MemoText` | bazodanowe, podlista |  |  |
| Domyslna | `bool` | bazodanowe |  |  |
| DomyślnaNumeracja | `string` | tylko-odczyt |  |  |
| KonfiguracjaOpisuAnalitycznego | `Soneta.Core.KonfiguracjaOpisuAnalitycznego` | tylko-odczyt |  |  |
| MozliwaNumeracjaZeZrodla | `bool` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NumerDokumentuZeZrodla | `bool` | bazodanowe |  |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| NumeracjaAutomatyczna | `bool` | tylko-odczyt |  |  |
| ProceduraISO | `Soneta.Core.IsoProcedura` | bazodanowe |  | Procedura ISO, która zostanie wykorzystana do numeracji dokumentów danego typu |
| RodzajeKomunikatow | `LpSubTable<Soneta.Core.RodzajKomunikatuHost>` | podlista |  |  |
| Rozszerzenie | `MemoText` | bazodanowe, podlista |  |  |
| SchematPodzialowy | `Soneta.Core.ISchematPodziałowy` | bazodanowe, iface-ref |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Typ | `Soneta.Core.TypDokumentu` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| TypDokumentu | `System.Type` | tylko-odczyt |  |  |
| TypDokumentuVAT | `Soneta.Core.ProceduraVAT` | bazodanowe | Typ dokumentu VAT (JPK) | Procedura VAT określająca typ dokumentu |
| ZawszePrzeliczajOpisAnalityczny | `bool` | bazodanowe |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `RaportESP` | 101 | `Soneta.Kasa.RaportESP.RaportESPDefDok` |  |
| `Wpłata` | 102 | `Soneta.Kasa.DokumentWplata.DokumentWplataDefDok` |  |
| `Wypłata` | 103 | `Soneta.Kasa.DokumentWyplata.DokumentWyplataDefDok` |  |
| `Przelew` | 104 | `Soneta.Kasa.PrzelewBase.PrzelewBaseDefDok` |  |
| `PaczkaPrzelewow` | 105 | `Soneta.Kasa.PaczkaPrzelewow.PaczkaPrzelewowDefDok` |  |
| `PotwierdzenieSalda` | 111 | `Soneta.Kasa.PotwierdzenieSalda.PotwierdzenieSaldaDefDok` |  |
| `WezwanieDoZaplaty` | 112 | `Soneta.Kasa.WezwanieDoZaplaty.WezwanieDoZaplatyDefDok` |  |
| `NotaOdsetkowa` | 113 | `Soneta.Kasa.DefDokNotaOdsetkowa` |  |
| `Kompensata` | 114 | `Soneta.Kasa.Kompensata.KompensataDefDok` |  |
| `RozliczenieZaliczki` | 115 | `Soneta.Kasa.RozliczenieZaliczki.RozliczenieZaliczkiDefDok` |  |
| `RozliczenieDelegacji` | 116 | `Soneta.Kasa.RozliczenieDelegacji.RozliczenieDelegacjiDefDok` |  |
| `Cesja` | 117 | `Soneta.Kasa.Cesja.CesjaDefDok` |  |
| `NotaKorygujaca` | 118 | `Soneta.Kasa.NotaKorygujaca.NotaKorygujacaDefDok` |  |
| `NotaKorygujacaOtrzymana` | 119 | `Soneta.Kasa.NotaKorygujacaOtrzymana.NotaKorygujacaOtrzymanaDefDok` |  |
| `WyciągBankowyEwidencja` | 120 | `Soneta.Kasa.WyciagBankowyEwidencja.WyciagBankowyEwidencjaDefDok` |  |
| `RaportKasowyEwidencja` | 121 | `Soneta.Kasa.RaportKasowyEwidencja.RaportKasowyEwidencjaDefDok` |  |
| `RozliczenieEwidencja` | 122 | `Soneta.Kasa.RozliczenieEwidencja.RozliczenieEwidencjaDefDok` |  |
| `NotaOdsetkowaEwidencja` | 123 | `Soneta.Kasa.NotaOdsetkowaEwidencja.NotaOdsetkowaEwidencjaDefDok` |  |
| `DelegacjaPWSEwidencja` | 124 | `Soneta.Delegacje.DelegacjaEwidencja.DelegacjaEwidencjaDefDok` |  |
| `Preliminarz` | 125 | `Soneta.Kasa.PreliminarzDokument.PreliminarzDokumentDefDok` |  |
| `GIODOPozyskanieDanych` | 203 | `Soneta.Core.GIODOPozyskanieDanych_DefDok` | Pozyskanie danych osobowych |
| `GIODOPowierzenieDanych` | 204 | `Soneta.Core.GIODOPowierzenieDanych_DefDok` | Powierzenie danych osobowych |
| `GIODOPrzetwarzanie` | 205 | `Soneta.Core.DefinicjaDokumentu` |  |
| `GIODOUdostępnienieDanych` | 206 | `Soneta.Core.GIODOUdostępnienieDanych_DefDok` | Powierzenie danych osobowych |
| `VAT7` | 207 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `VAT_UE` | 208 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `VAT_UEA` | 209 | `Soneta.Core.DefinicjaDokumentu` |  |
| `VAT_UEB` | 210 | `Soneta.Core.DefinicjaDokumentu` |  |
| `VAT_UEK` | 211 | `Soneta.Core.DefinicjaDokumentu` |  |
| `VAT_UEK_Pozycja` | 212 | `Soneta.Core.DefinicjaDokumentu` |  |
| `VAT_UEC` | 213 | `Soneta.Core.DefinicjaDokumentu` |  |
| `VAT_ZD` | 214 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `VAT27` | 215 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `GIODONaruszenie` | 216 | `Soneta.Core.DefinicjaDokumentu` |  |
| `VAT9M` | 217 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `VAT_UES` | 218 | `Soneta.Core.DefinicjaDokumentu` |  |
| `VIIDO` | 219 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `VIIDO_Pozycja` | 220 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `VIUDO` | 221 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `VIUDO_Pozycja` | 222 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `VAT8` | 223 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `VAT7ParametryRozliczen` | 224 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `Umowa` | 301 | `Soneta.Kadry.Umowa.DefDokUmowa` |  |
| `OfertaPracy` | 302 | `Soneta.HR2.OfertaPracy.OfertaPracyDefDok` |  |
| `Wypadek` | 303 | `Soneta.Kadry.Wypadek.DefDokWypadek` |  |
| `UmowaZewnetrzna` | 304 | `Soneta.Kadry.UmowaZewnetrzna.DefDokUmowaZewnetrzna` |  |
| `ZgloszenieSygnalisty` | 305 | `Soneta.Kadry.ZgloszenieSygnalisty.DefDokZgloszenieSygnalisty` |  |
| `Wyplata` | 502 | `Soneta.Core.DefinicjaDokumentu` |  |
| `ListaPlacEwidencja` | 503 | `Soneta.Place.ListaPlacEwidencja.ListaPlacEwidencjaDefDok` |  |
| `WyplataUmowyEwidencja` | 504 | `Soneta.EwidencjaVat.WyplataUmowyEwidencja.WyplataUmowyEwidencjaDefDok` |  |
| `PlanowanaListaPłacEwidencja` | 521 | `Soneta.Place.PlanowanaListaPłacEwidencja.PlanowanaListaPłacEwidencjaDefDok` |  |
| `Dekret` | 801 | `Soneta.Ksiega.Dekret.DekretDefDok` |  |
| `BO` | 802 | `Soneta.Ksiega.BO.BODefDok` |  |
| `ZapisKsiegowy` | 803 | `Soneta.Core.DefinicjaDokumentu` |  |
| `PKEwidencja` | 804 | `Soneta.Ksiega.PKEwidencja.PKEwidencjaDefDok` |  |
| `RóżniceKursoweEwidencja` | 805 | `Soneta.Ksiega.RozniceKursoweEwidencja.RozniceKursoweEwidencjaDefDok` |  |
| `BOEwidencja` | 806 | `Soneta.Ksiega.BOEwidencja.BOEwidencjaDefDok` |  |
| `RóżniceKursoweMWEwidencja` | 807 | `Soneta.Ksiega.RozniceKursoweMWEwidencja.RozniceKursoweMWEwidencjaDefDok` |  |
| `RozniceKursoweKPiREwidencja` | 808 | `Soneta.Ksiega.RozniceKursoweKPiREwidencja.RozniceKursoweKPiREwidencjaDefDok` |  |
| `DokumentZleDlugi` | 809 | `Soneta.Ksiega.ZleDlugiDokument.ZleDlugiDokumentDefDok` |  |
| `KEDU` | 1001 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `ZgloszenieZUS` | 1002 | `Soneta.Core.DefinicjaDokumentu` |  |
| `ZalacznikZUS` | 1003 | `Soneta.Core.DefinicjaDokumentu` |  |
| `ZUSDRA` | 1004 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT4` | 1005 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT11` | 1006 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT40` | 1007 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT8A` | 1008 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT8B` | 1009 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT8C` | 1010 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `IFT1` | 1011 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CIT2` | 1012 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CIT2O` | 1013 | `Soneta.Core.DefinicjaDokumentu` |  |
| `PIT5` | 1014 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `AKC2` | 1015 | `Soneta.Core.DefinicjaDokumentu` |  |
| `AKC2E` | 1016 | `Soneta.Core.DefinicjaDokumentu` |  |
| `ZUSIWA` | 1017 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT5L` | 1018 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `WND` | 1019 | `Soneta.Core.DefinicjaDokumentu` |  |
| `PFRON` | 1020 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `IFT1R` | 1021 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PITR` | 1022 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CIT8` | 1023 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CIT8O` | 1024 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT8S` | 1025 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT11Z` | 1026 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT40Z` | 1027 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PIT8CZ` | 1028 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PITRZ` | 1029 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITST` | 1030 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITSTA` | 1031 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITZAL` | 1032 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITD` | 1033 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `IFT2` | 1034 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CIT10Z` | 1035 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CIT8BR` | 1036 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITMIT` | 1037 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CIT8S` | 1038 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CIT8SP` | 1039 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PITRyczałt` | 1040 | `Soneta.Core.DefinicjaDokumentu` |  |
| `CITIP` | 1041 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITWZ` | 1042 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITKW` | 1043 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITF` | 1044 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITM` | 1045 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `WNU` | 1050 | `Soneta.Core.DefinicjaDokumentu` |  |
| `ZSWA` | 1060 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `ZUSRMUA` | 1070 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `OSW` | 1080 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `ZUSRIA` | 1090 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `DeklaracjaRozliczeniowa` | 1099 | `Soneta.Deklaracje.DeklaracjaEwidencja.DeklaracjaEwidencjaDefDok` |  |
| `CIT8E` | 1100 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `MagazynEwidencja` | 1101 | `Soneta.Handel.MagazynEwidencja.MagazynEwidencjaDefDok` |  |
| `CITEZ` | 1110 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITRB` | 1150 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITWOT` | 1160 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `SprzedażEwidencja` | 1201 | `Soneta.EwidencjaVat.SprzedazEwidencja.SprzedazEwidencjaDefDok` |  |
| `ZakupEwidencja` | 1202 | `Soneta.EwidencjaVat.ZakupEwidencja.ZakupEwidencjaDefDok` |  |
| `RozliczenieKasoweVATEwidencja` | 1203 | `Soneta.EwidencjaVat.RozliczeniaKasoweVATEwidencja.RozliczeniaKasoweVATEwidencjaDefDok` |  |
| `RozliczenieKasoweAkcyzyEwidencja` | 1204 | `Soneta.EwidencjaVat.RozliczeniaKasoweAkcyzyEwidencja.RozliczeniaKasoweAkcyzyEwidencjaDefDok` |  |
| `SprzedażZbiorczaEwidencja` | 1205 | `Soneta.EwidencjaVat.SprzedazZbiorczaEwidencja.SprzedazZbiorczaEwidencjaDefDok` |  |
| `FWUENabyciaNaliczonyEwidencja` | 1206 | `Soneta.EwidencjaVat.FWUENabyciaNaliczonyEwidencja.FWUENabyciaNaliczonyEwidencjaDefDok` |  |
| `FWUENabyciaNależnyEwidencja` | 1207 | `Soneta.EwidencjaVat.FWUENabyciaNależnyEwidencja.FWUENabyciaNależnyEwidencjaDefDok` |  |
| `VATMarżaEwidencja` | 1210 | `Soneta.EwidencjaVat.VATMarzaEwidencja.VATMarzaEwidencjaDefDok` |  |
| `OT` | 1301 | `Soneta.SrodkiTrwale.OT.OTDefDok` |  |
| `LT` | 1302 | `Soneta.SrodkiTrwale.LT.LTDefDok` |  |
| `Amortyzacja` | 1303 | `Soneta.SrodkiTrwale.Amortyzacja.AmortyzacjaDefDok` |  |
| `Przeszacowanie` | 1304 | `Soneta.SrodkiTrwale.Przeszacowanie.PrzeszacowanieDefDok` |  |
| `ZmianaWartości` | 1305 | `Soneta.SrodkiTrwale.ZmianaWartosci.ZmianaWartosciDefDok` |  |
| `ŚrodkiTrwałeEwidencja` | 1306 | `Soneta.SrodkiTrwale.SrodkiTrwaleEwidencja.SrodkiTrwaleEwidencjaDefDok` |  |
| `BOT` | 1308 | `Soneta.SrodkiTrwale.BOT.BOTDefDok` |  |
| `ZmianaMiejscaUżytkowania` | 1310 | `Soneta.SrodkiTrwale.ZmianaMiejscaUzytkowania.ZmianaMiejscaUzytkowaniaDefDok` |  |
| `ZmianaOsobyOdpowiedzialnej` | 1311 | `Soneta.SrodkiTrwale.ZmianaOsobyOdpowiedzialnej.ZmianaOsobyOdpowiedzialnejDefDok` |  |
| `ZmianaParametrówAmortyzacji` | 1312 | `Soneta.SrodkiTrwale.ZmianaParametrowAmortyzacji.ZmianaParametrowAmortyzacjiDefDok` |  |
| `ZmianaCentrumKosztów` | 1313 | `Soneta.SrodkiTrwale.ZmianaCentrumKosztow.ZmianaCentrumKosztowDefDok` |  |
| `Inwentaryzacja` | 1314 | `Soneta.SrodkiTrwale.Inwentaryzacja.InwentaryzacjaDefDok` |  |
| `ZmianaWartościRezydualnej` | 1315 | `Soneta.SrodkiTrwale.ZmianaWartosciRezydualnej.ZmianaWartosciRezydualnejDefDok` |  |
| `OdpisAktualizujący` | 1317 | `Soneta.SrodkiTrwale.OdpisAktualizujacy.OdpisAktualizujacyDefDok` |  |
| `ZmianaWartosciDok` | 1318 | `Soneta.SrodkiTrwale.ZmianaWartosciDok.ZmianaWartosciDokDefDok` |  |
| `PodatekOdNieruchomosci` | 1319 | `Soneta.SrodkiTrwale.PodatekOdNieruchomosci.PONDefDok` |  |
| `ZmianaParametrowPodatku` | 1320 | `Soneta.SrodkiTrwale.ZmianaParametrowPodatku.ZmianaParametrowPodatkuDefDok` |  |
| `ZmianaKategorii` | 1321 | `Soneta.SrodkiTrwale.ZmianaKategorii.ZmianaKategoriiDefDok` |  |
| `InwentaryzacjaCzastkowa` | 1322 | `Soneta.SrodkiTrwale.InwentaryzacjaCzastkowa.InwentaryzacjaCzastkowaDefDok` |  |
| `ZmianaPodzielnikaKosztow` | 1323 | `Soneta.SrodkiTrwale.ZmianaPodzielnikaKosztow.ZmianaPodzielnikaKosztowDefDok` |  |
| `Leasing` | 1324 | `Soneta.SrodkiTrwale.UmowaLeasingu.UmowaLeasinguDefDok` |  |
| `ZmianaParametrowLeasingu` | 1325 | `Soneta.SrodkiTrwale.ZmianaParametrowLeasingu.ZmianaParametrowLeasinguDefDok` |  |
| `RataLeasingowa` | 1326 | `Soneta.SrodkiTrwale.RataLeasingowa.RataLeasingowaDefDok` |  |
| `FakturaImportowa` | 1401 | `Soneta.Import.FakturaImportowaEwidencja.FakturaImportowaEwidencjaDefDok` |  |
| `SAD` | 1402 | `Soneta.Import.SADEwidencja.SADEwidencjaDefDok` |  |
| `IntrastatPrzywóz` | 1501 | `Soneta.Core.DefinicjaDokumentu` |  |
| `IntrastatWywóz` | 1502 | `Soneta.Core.DefinicjaDokumentu` |  |
| `IntrastatTowar` | 1503 | `Soneta.Core.DefinicjaDokumentu` |  |
| `ZdarzenieCRM` | 1601 | `Soneta.CRM.DokumentZdarzenia.DokumentZdarzeniaDefDok` |  |
| `SkladkaEwidencja` | 1660 | `Soneta.CzlonkowieSzkolenia.SkladkaEwidencja.SkladkaEwidencjaDefDok` |  |
| `RozliczenieEP` | 1701 | `Soneta.Samochodowka.RozliczenieEP.RozliczenieEPDefDok` |  |
| `RozliczenieEPEwidencja` | 1702 | `Soneta.Samochodowka.RozliczenieEPEwidencja.RozliczenieEPEwidencjaDefDok` |  |
| `DokumentRMK` | 1801 | `Soneta.RMK.DokumentRMK.DokumentRMKDefDok` |  |
| `RMKEwidencja` | 1802 | `Soneta.RMK.RMKEwidencja.RMKEwidencjaDefDok` |  |
| `Delegacja` | 1900 | `Soneta.Delegacje.Delegacja.DelegacjaDefDok` |  |
| `DocPkg` | 2003 | `Soneta.Core.DocPkg.DocPkgDefDok` |  |
| `PPK_DokumentyPracodawcy` | 2300 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PPK_DokumentyInstytucjiFinansowej` | 2301 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PPK_RozliczenieSkładek` | 2302 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PPK_RozliczenieNadpłat` | 2303 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PPK_DokumentPracodawcy` | 2310 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `PPK_DokumentInstytucjiFinansowej` | 2320 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `ZAW_NR` | 2400 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `DokumentRozliczeniaKontrahenta` | 2500 | `Soneta.Place.DokumentRozliczeniaKontrahenta.DefDokRozlKontrahenta` |  |
| `DokumentRozliczeniaPracownika` | 2501 | `Soneta.Place.DokumentRozliczeniaPracownika.DefDokRozlPracownika` |  |
| `CUK` | 2600 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `CITCSR` | 2700 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `WniosekOZwrotNienależnieOpłaconychSkładek` | 2800 | `Soneta.Kadry.WniosekZwrotOplSkl.DefDokWniosekOZwrotNienależnieOpłaconychSkładek` |  |
| `ZUS_Z3` | 2900 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `ZUS_Z3a` | 2910 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `ZUSDRAII` | 3000 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `ZUSRCAII` | 3010 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `DEKR` | 3020 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `INF2` | 3030 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |
| `LukaPlacowa` | 3040 | `Soneta.Deklaracje.Deklaracja.DefDeklaracji` |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| SchematPodzialowy | `ISchematPodziałowy` | `SchematPodz` |

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
