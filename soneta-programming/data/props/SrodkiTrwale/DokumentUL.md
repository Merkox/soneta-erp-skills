# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.DokumentUL`
Nazwa tabeli: `DokumentyUL`
Tytuł: Dokumenty UL
Opis: Dokumenty umów leasingowych powiązanych ze środkami trwałymi. Przechowują warunki umowy, harmonogram rat, dane kontrahenta i finansującego oraz parametry walutowe. Obsługują pełen cykl życia umowy leasingu od zawarcia do zakończenia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

- pola bazodanowe (zapisywalne): 39
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 11
- podlisty: 7
- subrowy: 1
- razem: 60

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzyMSR | `bool` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe |  | Data ewidencji |
| DataDo | `Date` | bazodanowe | Data zakończenia | Data do |
| DataOd | `Date` | bazodanowe |  | Data od |
| DataWaluty | `Date` | bazodanowe |  |  |
| DataZakonczenia | `Date` | bazodanowe | Data zakończenia | Data zakończenia umowy |
| DataZawarcia | `Date` | bazodanowe |  | Data zawarcia |
| Definicja | `Soneta.SrodkiTrwale.DokumentUL.DefDokUL` | bazodanowe |  | Definicja dokumentu |
| DzienSplatyRaty | `Soneta.SrodkiTrwale.DzienSplatyRaty` (enum) | bazodanowe |  | Dzień spłaty raty |
| Finansujacy | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  | Finansujący |
| Firma | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| GenerujPlatnosci | `bool` | bazodanowe |  | Generowanie płatności dla rat |
| IloscRat | `int` | bazodanowe |  | Ilość rat |
| Kontrahent | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  | Kontrahent |
| Korekta | `bool` | tylko-odczyt |  |  |
| Kurs | `double` | bazodanowe |  |  |
| MetodaPodzialu | `Soneta.SrodkiTrwale.MetodaPodzialuRaty` (enum) | bazodanowe |  | Metoda podziału raty |
| MetodaWyceny | `Soneta.SrodkiTrwale.MetodyWyceny` (enum) | bazodanowe |  |  |
| NadrzedneRelacje | `SubTable<Soneta.SrodkiTrwale.DokumentUL>` | podlista |  |  |
| Nadrzedny | `Soneta.SrodkiTrwale.DokumentUL` | bazodanowe | Dokument nadrzędny | Nadrzędny dokument. |
| NaliczenieRat | `Soneta.SrodkiTrwale.NaliczenieRat` (enum) | bazodanowe |  | Naliczenie |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  | Numer dokumentu |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerObcy | `string` | bazodanowe |  | Numer obcy |
| NumerUmowyPierwotnej | `Soneta.SrodkiTrwale.DokumentUL` | tylko-odczyt | Numer umowy pierwotnej |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  | Oddział firmy |
| OdliczeniaVAT | `bool` | tylko-odczyt |  |  |
| OkresRozliczen | `Soneta.SrodkiTrwale.OkresRozliczenL` (enum) | bazodanowe |  | Okres rozliczeń |
| Opis | `string` | bazodanowe |  | Opis |
| PodrzedneRelacje | `SubTable<Soneta.SrodkiTrwale.DokumentUL>` | podlista |  |  |
| PodrzedneWithRights | `System.Collections.Generic.IEnumerable<Soneta.SrodkiTrwale.DokumentUL>` | podlista |  |  |
| Podrzedny | `Soneta.SrodkiTrwale.DokumentUL` | bazodanowe | Dokument podrzędny | Podrzędny dokument. |
| PowiazaneDok | `SubTable<Soneta.SrodkiTrwale.DokumentPowiazanyUL>` | podlista |  |  |
| PowodZakonczenia | `string` | bazodanowe | Powód zakończenia | Powód zakończenia umowy |
| Pozycje | `SubTable<Soneta.SrodkiTrwale.SrodekTrwalyLeasing>` | podlista |  |  |
| PrzedmiotUmowy | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | tylko-odczyt |  |  |
| RodzajLeasingu | `Soneta.SrodkiTrwale.RodzajLeasingu` (enum) | bazodanowe |  | Rodzaj leasingu |
| Srodek | `Soneta.SrodkiTrwale.SrodekTrwalyBase` |  |  |  |
| Stan | `Soneta.SrodkiTrwale.StatusUmowy` (enum) | bazodanowe |  | Status umowy |
| StopaDyskontowa | `Percent` | bazodanowe |  | Stopa dyskontowa |
| StopaMetoda | `Soneta.SrodkiTrwale.StopaMetoda` (enum) | bazodanowe |  |  |
| StopaOpis | `string` | bazodanowe |  |  |
| StopaProcentowa | `Soneta.SrodkiTrwale.StopaProcentowa` (enum) | bazodanowe |  |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  |  |
| TerminPierwszejRaty | `Date` | bazodanowe |  | Termin pierwszej raty |
| TerminWykupu | `Date` | bazodanowe |  | Termin wykupu |
| Typ | `Soneta.Core.TypDokumentu` (enum) | bazodanowe, tylko-odczyt |  | Typ dokumentu |
| Tytul | `Soneta.SrodkiTrwale.TytulDokumentuST` | bazodanowe | Tytuł dokumentu | Tytuł dokumentu środków trwałych |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  |  |
| Wielooddzialowosc | `bool` | tylko-odczyt |  |  |
| WskazanyDzienSplaty | `int` | bazodanowe |  | Wskazany dzień spłaty raty |
| WspolczynnikDyskonta | `double` | tylko-odczyt |  |  |
| WspolczynnikDyskontaStr | `string` | tylko-odczyt |  |  |
| Zakonczona | `bool` | bazodanowe | Zakończona | Zakończenie umowy |
| ZaplaconeDo | `Date` | bazodanowe |  | Uwzględniaj jako zapłacone do |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Finansujacy | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| Kontrahent | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

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

### DzienSplatyRaty (`Soneta.SrodkiTrwale.DzienSplatyRaty`)
- `Pierwszy` = 0 — Pierwszy dzień miesiąca
- `Ostatni` = 10 — Ostatni dzień miesiąca
- `Wskazany` = 20 — Wskazany dzień miesiąca

### MetodaPodzialuRaty (`Soneta.SrodkiTrwale.MetodaPodzialuRaty`)
- `Wszystkie` = -1
- `Liniowa` = 0 — Liniowa
- `DegresywnaPelna` = 10 — Degresywna pełna
- `DegresywnaPrzyblizona` = 20 — Degresywna przybliżona

### MetodyWyceny (`Soneta.SrodkiTrwale.MetodyWyceny`)
- `Poczatkowa` = 0 — Początkowa
- `PoDacieWyceny` = 1 — Po dacie wyceny

### NaliczenieRat (`Soneta.SrodkiTrwale.NaliczenieRat`)
- `OsobnaPozycja` = 0 — Opłata wstępna jako osobna pozycja
- `WPierwszejRacie` = 10 — Opłata wstępna w pierwszej racie
- `PierwszaRata` = 20 — Opłata wstępna jako pierwsza rata

### OkresRozliczenL (`Soneta.SrodkiTrwale.OkresRozliczenL`)
- `Miesieczny` = 0 — Miesięczny
- `Kwartalny` = 10 — Kwartalny

### RodzajLeasingu (`Soneta.SrodkiTrwale.RodzajLeasingu`)
- `Wszystkie` = -1
- `LeasingFinansowy` = 0 — Leasing finansowy
- `LeasingOperacyjny` = 10 — Leasing operacyjny
- `LeasingFinansowyMSR` = 20 — Leasing finansowy (MSR)

### StatusUmowy (`Soneta.SrodkiTrwale.StatusUmowy`)
- `Wszystkie` = -10
- `Wpisany` = 0
- `Aktywny` = 10
- `Zakonczony` = 20 — Zakończony

### StopaMetoda (`Soneta.SrodkiTrwale.StopaMetoda`)
- `StopaMiesieczna` = 0 — Stopa miesięczna
- `KapitalizacjaMiesieczna` = 1 — Kapitalizacja miesięczna
- `RegulaBankowa` = 2 — Reguła bankowa

### StopaProcentowa (`Soneta.SrodkiTrwale.StopaProcentowa`)
- `StopaProcentowaLeasingu` = 0 — Stopa procentowa leasingu
- `KrancowaStopaProcentowaJednostki` = 1 — Krańcowa stopa procentowa jednostki
