# Pola i właściwości klasy biznesowej: `Soneta.Deklaracje.Deklaracja`
Nazwa tabeli: `Deklaracje`
Opis: Deklaracja podatkowa lub sprawozdawcza generowana w systemie. Przechowuje dane dokumentu rozliczeniowego — typ, okres, numer, status poprawności oraz powiązania z podmiotem i definicją dokumentu. Obsługuje hierarchię subdeklaracji i integrację z księgowością.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDeklaracja`, `IDokumentPlatny`, `IDokumentKsiegowalny`, `IBazaZrodlaWyplaty`, `IEmailElement`, `IZrodloOpisuAnalitycznego`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 4
- pola tylko-odczyt: 23
- podlisty: 15
- subrowy: 1
- razem: 51

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnaEDeklaracja | `Soneta.Deklaracje.EDeklaracja` | tylko-odczyt |  |  |
| Anulowany | `bool` | tylko-odczyt |  |  |
| Bloki | `Soneta.Deklaracje.Deklaracja.BlokiIdx` | podlista |  |  |
| Bufor | `bool` | bazodanowe |  |  |
| BuforOpisuAnalitycznego | `bool` | bazodanowe |  | Bufor opisu analitycznego |
| Data | `Date` | bazodanowe |  |  |
| DataRozliczenia | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Deklaracja | `Soneta.Deklaracje.Deklaracja` | bazodanowe, tylko-odczyt |  |  |
| DeklaracjaKorygowana | `Soneta.Deklaracje.Deklaracja` | tylko-odczyt |  |  |
| DeklaracjaKorygująca | `Soneta.Deklaracje.Deklaracja` | tylko-odczyt |  |  |
| Deklaracje | `SubTable<Soneta.Deklaracje.Deklaracja>` | podlista |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| EDeklaracje | `SubTable<Soneta.Deklaracje.EDeklaracja>` | podlista |  |  |
| ElementStrukturyFirmy | `Soneta.Core.IElementStrukturyFirmy` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| ElementStrukturyFirmyType | `System.Type` | tylko-odczyt |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaPola | `string` | tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Oddział | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| OkresNaliczania | `FromTo` | podlista |  |  |
| OkresWażności | `FromTo` | podlista |  |  |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| Ostrzeżenie | `bool` | tylko-odczyt |  |  |
| PlanSplat | `bool` | tylko-odczyt |  |  |
| Platnosci | `SubTable<Soneta.Kasa.Platnosc>` | podlista |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Pola | `MemoText` | bazodanowe, podlista |  |  |
| Poprawna | `bool` | bazodanowe, tylko-odczyt |  |  |
| Poprzednia | `Soneta.Deklaracje.Deklaracja` | tylko-odczyt |  |  |
| PozycjeEwidencji | `SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` | podlista |  |  |
| PrivateData | `MemoText` | bazodanowe, podlista |  |  |
| Rok | `int` |  | Za rok |  |
| RokMiesiac | `YearMonth` |  | Za miesiąc |  |
| Symbol | `string` | tylko-odczyt |  |  |
| Tekst | `string` | tylko-odczyt |  |  |
| TekstPrywatny | `string` | tylko-odczyt |  |  |
| Typ | `Soneta.Deklaracje.TypDeklaracji` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wariant | `int` | tylko-odczyt |  |  |
| Wersja | `Soneta.Deklaracje.WersjaDeklaracji` (enum) | bazodanowe, tylko-odczyt |  |  |
| WiadomosciPowiazane | `SubTable` | podlista |  |  |
| Zatwierdzona | `bool` |  |  |  |
| Zrodlo | `Soneta.Kadry.IZrodloDeklaracji` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ElementStrukturyFirmy | `IElementStrukturyFirmy` | `OddzialFirmy`, `Wydzial` |
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| Zrodlo | `IZrodloDeklaracji` | `CzlonekRodziny`, `Nieobecnosc`, `Umowa` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypDeklaracji (`Soneta.Deklaracje.TypDeklaracji`)
- `Wszystkie` = 0
- `PIT4` = 1000 — PIT-4R
- `PIT11` = 1100 — PIT-11
- `PIT40` = 1200 — PIT-40
- `PIT8A` = 1300 — PIT-8AR
- `PIT8B` = 1400 — PIT-8B
- `PIT8C` = 1500 — PIT-8C
- `IFT1` = 1600 — IFT-1
- `PIT5` = 1700 — PIT-5
- `PIT5L` = 1800 — PIT-5L
- `IFT1R` = 2000 — IFT-1R
- `PITR` = 2100 — PIT-R
- `PIT8S` = 2200 — PIT-8S
- `PITRyczałt` = 1900 — Ryczałt
- `ZUS_KEDU` = 3000
- `ZUS_RUD` = 2800 — ZUS RUD
- `ZUS_RUD_O` = 2900
- `ZUS_ZU` = 3100 — ZUS ZUA
- `ZUS_ZIU` = 3200 — ZUS ZIUA
- `ZUS_ZCN` = 3300 — ZUS ZCNA
- `ZUS_ZCN_O` = 3400
- `ZUS_ZCZ` = 3500 — ZUS ZCZA
- `ZUS_ZCZ_O` = 3600
- `ZUS_ZWU` = 3700 — ZUS ZWUA
- `ZUS_ZZ` = 3800 — ZUS ZZA
- `ZUS_IW` = 3900 — ZUS IWA
- `ZUS_DR` = 4100
- `ZUS_RC` = 4200
- `ZUS_RC_O` = 4300
- `ZUS_RN` = 4400
- `ZUS_RN_O` = 4500
- `ZUS_RZ` = 4600
- `ZUS_RZ_O` = 4700
- `ZUS_RS` = 4800
- `ZUS_RS_O` = 4900
- `ZUS_RG` = 5000
- `ZUS_RG_O` = 5100
- `ZUS_ZSW` = 5200
- `ZUS_ZSW_O` = 5300
- `ZUS_RMUA` = 5400 — ZUS IMIR
- `ZUS_OSW` = 5500
- `ZUS_RIA` = 5600 — ZUS RIA
- `ZUS_RPA` = 5700 — ZUS RPA
- `ZUS_RPA_O` = 5800
- `ZUS_DRII` = 5900 — ZUS DRA II
- `ZUS_RCAII` = 6000 — ZUS RCA II
- `ZUS_RIA_V` = 20000 — ZUS RIA V
- `ZUS_RIA_VI` = 20100 — ZUS RIA VI
- `ZUS_RIA_VII` = 20200 — ZUS RIA VII
- `ZUS_RIA_VIII` = 20300 — ZUS RIA VIII
- `ZUS_RIA_IX` = 20400 — ZUS RIA IX
- `ZUS_RIA_X` = 20500 — ZUS RIA X
- `ZUS_RIA_XI` = 20600 — ZUS RIA XI
- `PFRON_WN_D` = 6100 — Wn-D
- `PFRON_INF_D` = 6200 — INF-D
- `PFRON_INF_D_P` = 6300 — INF-D-P
- `PFRON_WN_U` = 6400 — Wn-U
- `PFRON_INF_U_P` = 6500 — INF-U-P
- `PFRON_INF_U_G` = 6600 — INF-U-G
- `PFRON_INF_U_A` = 6700 — INF-U-A
- `PFRON_DEK_R` = 6800 — DEK-R
- `PFRON_INF_2` = 6900 — INF-2
- `IntrastatPrzywóz` = 7100
- `IntrastatWywóz` = 7200
- `IntrastatTowar` = 7300
- `VATUE` = 7400
- `VATUEA` = 7500
- `VATUEB` = 7600
- `VATUEK` = 7700
- `VATUEC` = 7800
- `VATUES` = 7900
- `VAT7` = 8100 — VAT-7
- `CIT2` = 8200
- `CIT2O` = 8300
- `AKC2` = 8400
- `AKC2E` = 8500
- `CIT8` = 8600 — CIT-8
- `CIT8O` = 8700 — CIT-8/O
- `VATZD` = 8800
- `CITD` = 8900
- `PIT11Z` = 9000
- `PIT40Z` = 9100
- `PIT8CZ` = 9200
- `PITRZ` = 9300
- `CITST` = 10000
- `CITSTM` = 10100
- `CITSTA` = 10200
- `CITSTAM` = 10300
- `IFT2` = 10400
- `CIT10Z` = 10500
- `VAT27` = 10600 — VAT-27
- `VIIDO` = 11400 — VII-DO
- `VIIDO_Pozycja` = 11500
- `VIUDO` = 11600 — VIU-DO
- `VIUDO_Pozycja` = 11700
- `VAT8` = 11900 — VAT-8
- `VAT9M` = 12000 — VAT-9M
- `ZAW_NR` = 13000 — ZAW-NR
- `CUK` = 14000 — CUK
- `CIT8E` = 15000 — CIT-8E
- `CITRB` = 16000 — CIT-RB
- `CITCSR` = 17000 — CIT-CSR
- `VAT7_ParametryRozliczen` = 18000 — VAT-7 Parametry rozliczeń
- `CITF` = 19000 — CIT-F
- `CITM` = 19100 — CIT-M
- `CITWOT` = 19200 — CIT-WOT
- `PPK_DokumentyPracodawcy` = 25000 — PPK - Dokumenty pracodawcy
- `PPK_DokumentyInstytucjiFinansowej` = 25100 — PPK - Dokumenty instytucji finansowej
- `PPK_RozliczenieSkładek` = 25200 — PPK - Rozliczenie składek
- `PPK_RejestracjaUczestnika` = 25300 — PPK - Rejestracja uczestnika
- `PPK_Składki` = 25400 — PPK - Składka
- `PPK_KorektaSkładek` = 25500 — PPK - Korekta składki
- `PPK_DeklaracjaUczestnika` = 25600 — PPK - Deklaracja uczestnika
- `PPK_ZmianaDanychKontaktu` = 25700 — PPK - Zmiana danych kontaktu elektronicznego uczestnika
- `PPK_ZmianaDanychIdentyfikacyjnych` = 25800 — PPK - Zmiana danych identyfikacyjnych uczestnika
- `PPK_ZakończenieZatrudnienia` = 25900 — PPK - Zakończenie zatrudnienia uczestnika
- `PPK_Transfer` = 26600 — PPK - Transfer
- `PPK_WypłataŚrodków` = 26000 — PPK - Wypłata środków przez uczestnika
- `PPK_ZwrotNadpłaty` = 26100 — PPK - Zwrot środków w wyniku rozliczenia korekty lub rezygnacji z dokonywania wpłat
- `PPK_WypłataTransferowa` = 26200 — PPK - Wypłata transferowa
- `PPK_NadanieUczestnikowiNumeruEwidencji` = 26300 — PPK - Nadanie uczestnikowi numeru ewidencji PPK
- `PPK_ZwrotŚrodków` = 26400 — PPK - Zwrot (art. 12.6, art. 19.6.)
- `PPK_RozliczenieNadpłat` = 26500 — PPK - Rozliczenie nadpłat
- `ZUS_Z3` = 21000 — ZUS Z-3
- `ZUS_Z3a` = 21100 — ZUS Z-3a
- `Luka_Placowa` = 22000 — Luka płacowa

### WersjaDeklaracji (`Soneta.Deklaracje.WersjaDeklaracji`)
- `PIT4_14` = 1014 — PIT-4 (14)
- `PIT4_15` = 1015 — PIT-4 (15)
- `PIT4_16` = 1016 — PIT-4 (16)
- `PIT4_17` = 1017 — PIT-4 (17)
- `PIT4R_1` = 1021 — PIT-4R (1)
- `PIT4R_2` = 1022 — PIT-4R (2)
- `PIT4R_3` = 1023 — PIT-4R (3)
- `PIT4R_4` = 1024 — PIT-4R (4)
- `PIT4R_5` = 1025 — PIT-4R (5)
- `PIT4R_6` = 1026 — PIT-4R (6)
- `PIT4R_7` = 1027 — PIT-4R (7)
- `PIT4R_8` = 1028 — PIT-4R (8)
- `PIT4R_9` = 1029 — PIT-4R (9)
- `PIT4R_10` = 1030 — PIT-4R (10)
- `PIT4R_11` = 1031 — PIT-4R (11)
- `PIT4R_12` = 1032 — PIT-4R (12)
- `PIT4R_13` = 1033 — PIT-4R (13)
- `PIT11_11` = 1111 — PIT-11 (11)
- `PIT11_12` = 1112 — PIT-11 (12)
- `PIT11_14` = 1114 — PIT-11 (14)
- `PIT11_15` = 1115 — PIT-11 (15)
- `PIT11_16` = 1116 — PIT-11 (16)
- `PIT11_17` = 1117 — PIT-11 (17)
- `PIT11_18` = 1118 — PIT-11 (18)
- `PIT11_19` = 1119 — PIT-11 (19)
- `PIT11_20` = 1120 — PIT-11 (20)
- `PIT11_21` = 1121 — PIT-11 (21)
- `PIT11_22` = 1122 — PIT-11 (22)
- `PIT11_23` = 1123 — PIT-11 (23)
- `PIT11_24` = 1124 — PIT-11 (24)
- `PIT11_25` = 1125 — PIT-11 (25)
- `PIT11_26` = 1126 — PIT-11 (26)
- `PIT11_27` = 1127 — PIT-11 (27)
- `PIT11_28` = 1128 — PIT-11 (28)
- `PIT11_29` = 1129 — PIT-11 (29)
- `PIT40_11` = 1211 — PIT-40 (11)
- `PIT40_12` = 1212 — PIT-40 (12)
- `PIT40_13` = 1213 — PIT-40 (13)
- `PIT40_14` = 1214 — PIT-40 (14)
- `PIT40_15` = 1215 — PIT-40 (15)
- `PIT40_16` = 1216 — PIT-40 (16)
- `PIT40_17` = 1217 — PIT-40 (17)
- `PIT40_19` = 1219 — PIT-40 (19)
- `PIT40_20` = 1220 — PIT-40 (20)
- `PIT40_21` = 1221 — PIT-40 (21)
- `PIT40_22` = 1222 — PIT-40 (22)
- `PIT8A_10` = 1310 — PIT-8A (10)
- `PIT8A_11` = 1311 — PIT-8A (11)
- `PIT8A_12` = 1312 — PIT-8A (12)
- `PIT8A_13` = 1313 — PIT-8A (13)
- `PIT8AR_1` = 1321 — PIT-8AR (1)
- `PIT8AR_2` = 1322 — PIT-8AR (2)
- `PIT8AR_3` = 1323 — PIT-8AR (3)
- `PIT8AR_4` = 1324 — PIT-8AR (4)
- `PIT8AR_5` = 1325 — PIT-8AR (5)
- `PIT8AR_6` = 1326 — PIT-8AR (6)
- `PIT8AR_7` = 1327 — PIT-8AR (7)
- `PIT8AR_8` = 1328 — PIT-8AR (8)
- `PIT8AR_9` = 1329 — PIT-8AR (9)
- `PIT8AR_10` = 1330 — PIT-8AR (10)
- `PIT8AR_11` = 1331 — PIT-8AR (11)
- `PIT8AR_12` = 1332 — PIT-8AR (12)
- `PIT8AR_13` = 1333 — PIT-8AR (13)
- `PIT8AR_14` = 1334 — PIT-8AR (14)
- `PIT8B_10` = 1410 — PIT-8B (10)
- `PIT8B_12` = 1412 — PIT-8B (12)
- `PIT8B_14` = 1414 — PIT-8B (14)
- `PIT8C_3` = 1503 — PIT-8C (3)
- `PIT8C_4` = 1504 — PIT-8C (4)
- `PIT8C_5` = 1505 — PIT-8C (5)
- `PIT8C_6` = 1506 — PIT-8C (6)
- `PIT8C_7` = 1507 — PIT-8C (7)
- `PIT8C_8` = 1508 — PIT-8C (8)
- `PIT8C_9` = 1509 — PIT-8C (9)
- `PIT8C_10` = 1510 — PIT-8C (10)
- `PIT8C_11` = 1511 — PIT-8C (11)
- `PIT8C_12` = 1512 — PIT-8C (12)
- `PIT8C_13` = 1513 — PIT-8C (13)
- `IFT1_4` = 1604 — IFT-1 (4)
- `IFT1_5` = 1605 — IFT-1 (5)
- `IFT1_6` = 1606 — IFT-1 (6)
- `IFT1_7` = 1607 — IFT-1 (7)
- `IFT1_8` = 1608 — IFT-1 (8)
- `IFT1_9` = 1609 — IFT-1 (9)
- `IFT1_10` = 1610 — IFT-1 (10)
- `IFT1_11` = 1611 — IFT-1 (11)
- `IFT1_12` = 1612 — IFT-1 (12)
- `IFT1_13` = 1613 — IFT-1 (13)
- `IFT1_14` = 1614 — IFT-1 (14)
- `IFT1_15` = 1615 — IFT-1 (15)
- `IFT1_16` = 1616 — IFT-1 (16)
- `IFT1_17` = 1617 — IFT-1 (17)
- `IFT1_18` = 1618 — IFT-1 (18)
- `PIT5_12` = 1712 — PIT-5 (12)
- `PIT5_13` = 1713 — PIT-5 (13)
- `PIT5_14` = 1714 — PIT-5 (14)
- `PIT5_15` = 1715 — PIT-5 (15)
- `PIT5_16` = 1716 — PIT-5 (16)
- `PIT5_2022` = 1722 — Zaliczka PIT skala (do 31.05.2022)
- `PIT5_2022_2` = 1723 — Zaliczka PIT skala
- `PIT5L_1` = 1801 — PIT-5L (1)
- `PIT5L_2` = 1802 — PIT-5L (2)
- `PIT5L_3` = 1803 — PIT-5L (3)
- `PIT5L_4` = 1804 — PIT-5L (4)
- `PIT5L_2022` = 1822 — Zaliczka PIT liniowo (do 31.05.2022)
- `PIT5L_2022_2` = 1823 — Zaliczka PIT liniowo
- `PITRyczałt_1` = 1901 — Ryczałt do 2021
- `PITRyczałt_2` = 1902 — Ryczałt do 30.06.2022
- `PITRyczałt_2022_2` = 1903 — Ryczałt
- `IFT1R_5` = 2005 — IFT-1R (5)
- `IFT1R_6` = 2006 — IFT-1R (6)
- `IFT1R_7` = 2007 — IFT-1R (7)
- `IFT1R_8` = 2008 — IFT-1R (8)
- `IFT1R_9` = 2009 — IFT-1R (9)
- `IFT1R_10` = 2010 — IFT-1R (10)
- `IFT1R_11` = 2011 — IFT-1R (11)
- `IFT1R_12` = 2012 — IFT-1R (12)
- `IFT1R_13` = 2013 — IFT-1R (13)
- `IFT1R_14` = 2014 — IFT-1R (14)
- `IFT1R_15` = 2015 — IFT-1R (15)
- `IFT1R_16` = 2016 — IFT-1R (16)
- `IFT1R_17` = 2017 — IFT-1R (17)
- `IFT1R_18` = 2018 — IFT-1R (18)
- `PITR_11` = 2111 — PIT-R (11)
- `PITR_12` = 2112 — PIT-R (12)
- `PITR_13` = 2113 — PIT-R (13)
- `PITR_14` = 2114 — PIT-R (14)
- `PITR_15` = 2115 — PIT-R (15)
- `PITR_16` = 2116 — PIT-R (16)
- `PITR_17` = 2117 — PIT-R (17)
- `PITR_18` = 2118 — PIT-R (18)
- `PITR_19` = 2119 — PIT-R (19)
- `PITR_20` = 2120 — PIT-R (20)
- `PITR_21` = 2121 — PIT-R (21)
- `PITR_22` = 2122 — PIT-R (22)
- `PIT8S_3` = 2203 — PIT-8S (3)
- `ZUS_KEDU` = 3001
- `ZUS_RUD` = 2801 — ZUS RUD
- `ZUS_RUD_O` = 2901 — ZUS RUD
- `ZUS_ZUA` = 3101 — ZUS ZUA
- `ZUS_ZIUA` = 3201 — ZUS ZIUA
- `ZUS_ZCNA` = 3301 — ZUS ZCNA
- `ZUS_ZCNA_O` = 3401 — ZUS ZCNA
- `ZUS_ZCZA` = 3501 — ZUS ZCZA
- `ZUS_ZCZA_O` = 3601 — ZUS ZCZA
- `ZUS_ZWUA` = 3701 — ZUS ZWUA
- `ZUS_ZZA` = 3801 — ZUS ZZA
- `ZUS_IWA` = 3901 — ZUS IWA
- `ZUS_DRA` = 4101 — ZUS DRA
- `ZUS_RCA` = 4201 — ZUS RCA
- `ZUS_RCA_O` = 4301 — ZUS RCA
- `ZUS_RNA` = 4401 — ZUS RNA
- `ZUS_RNA_O` = 4501 — ZUS RNA
- `ZUS_RZA` = 4601 — ZUS RZA
- `ZUS_RZA_O` = 4701 — ZUS RZA
- `ZUS_RSA` = 4801 — ZUS RSA
- `ZUS_RSA_O` = 4901 — ZUS RSA
- `ZUS_RGA` = 5001 — ZUS RGA
- `ZUS_RGA_O` = 5101 — ZUS RGA
- `ZUS_ZSWA` = 5201 — ZUS ZSWA
- `ZUS_ZSWA_O` = 5301 — ZUS ZSWA
- `ZUS_RMUA` = 5401 — ZUS IMIR
- `ZUS_OSW` = 5501 — ZUS OSW
- `ZUS_RIA` = 5601 — ZUS RIA
- `ZUS_RPA` = 5701 — ZUS RPA
- `ZUS_RPA_O` = 5801 — ZUS RPA
- `ZUS_DRII` = 5901 — ZUS DRA II
- `ZUS_RCAII` = 6001 — ZUS RCA II
- `ZUS_RIA_V` = 20001 — ZUS RIA V
- `ZUS_RIA_VI` = 20101 — ZUS RIA VI
- `ZUS_RIA_VII` = 20201 — ZUS RIA VII
- `ZUS_RIA_VIII` = 20301 — ZUS RIA VIII
- `ZUS_RIA_IX` = 20401 — ZUS RIA IX
- `ZUS_RIA_X` = 20501 — ZUS RIA X
- `ZUS_RIA_XI` = 20601 — ZUS RIA XI
- `PFRON_WN_D_v1` = 6101 — Wn-D
- `PFRON_WN_D_v2` = 6102
- `PFRON_WN_D_v3` = 6103
- `PFRON_WN_D_v4` = 6104
- `PFRON_WN_D_v5` = 6105
- `PFRON_WN_D_v6` = 6106
- `PFRON_INF_D` = 6201 — INF-D
- `PFRON_INF_D_P_v1` = 6301 — INF-D-P
- `PFRON_INF_D_P_v2` = 6302
- `PFRON_INF_D_P_v3` = 6303
- `PFRON_INF_D_P_v4` = 6304
- `PFRON_INF_D_P_v5` = 6305
- `PFRON_INF_D_P_v6` = 6306
- `PFRON_INF_D_P_v7` = 6307
- `PFRON_INF_D_P_v8` = 6308
- `PFRON_WN_U_v1` = 6401 — Wn-U
- `PFRON_INF_U_P_v1` = 6501 — INF-U
- `PFRON_INF_2_v1` = 6901 — INF-2
- `PFRON_DEK_R_v1` = 6801 — Wn-D
- `PFRON_DEK_R_v2` = 6802
- `IntrastatPrzywóz` = 7101
- `IntrastatWywóz` = 7201
- `IntrastatTowar` = 7301
- `VATUE_1` = 7401 — VAT-UE(1)
- `VATUE_2` = 7402 — VAT-UE(2)
- `VATUE_3` = 7403 — VAT-UE(3)
- `VATUE_4` = 7404 — VAT-UE(4)
- `VATUE_5` = 7405 — VAT-UE(5)
- `VATUEA_1` = 7501 — VAT-UE/A(1)
- `VATUEA_2` = 7502 — VAT-UE/A(2)
- `VATUEA_3` = 7503 — VAT-UE/A(3)
- `VATUEA_4` = 7504 — VAT-UE/A(4)
- `VATUEA_5` = 7505 — VAT-UE/A(5)
- `VATUEB_1` = 7601 — VAT-UE/B(1)
- `VATUEB_2` = 7602 — VAT-UE/B(2)
- `VATUEB_3` = 7603 — VAT-UE/B(3)
- `VATUEB_4` = 7604 — VAT-UE/B(4)
- `VATUEB_5` = 7605 — VAT-UE/B(5)
- `VATUEK_1` = 7701 — VAT-UEK(1)
- `VATUEK_2` = 7702 — VAT-UEK(2)
- `VATUEK_3` = 7703 — VAT-UEK(3)
- `VATUEK_4` = 7704 — VAT-UEK(4)
- `VATUEK_5` = 7705 — VAT-UEK(5)
- `VATUEC_1` = 7801 — VAT-UE/C(1)
- `VATUEC_2` = 7802 — VAT-UE/C(2)
- `VATUEC_4` = 7804 — VAT-UE/C(4)
- `VATUEC_5` = 7805 — VAT-UE/C(5)
- `VATUES_1` = 7901 — VAT-UE/S(1)
- `VAT7_7` = 8107 — VAT-7(7)
- `VAT7_8` = 8108 — VAT-7(8)
- `VAT7_9` = 8109 — VAT-7(9)
- `VAT7_10` = 8110 — VAT-7(10)
- `VAT7_11` = 8111 — VAT-7(11)
- `VAT7_12` = 8112 — VAT-7(12)
- `VAT7_13` = 8113 — VAT-7(13)
- `VAT7_14` = 8114 — VAT-7(14)
- `VAT7_15` = 8115 — VAT-7(15)
- `VAT7_16` = 8116 — VAT-7(16)
- `VAT7_17` = 8117 — VAT-7(17)
- `VAT7_18` = 8118 — VAT-7(18)
- `VAT7_19` = 8119 — VAT-7(19)
- `VAT7_20` = 8120 — VAT-7(20)
- `VAT7_21` = 8121 — VAT-7(21)
- `VAT7_22` = 8122 — VAT-7(22)
- `VAT7_23` = 8123 — VAT-7(23)
- `CIT2_14` = 8214 — CIT-2(14)
- `CIT2_15` = 8215 — CIT-2(15)
- `CIT2_16` = 8216 — CIT-2(16)
- `CIT2_17` = 8217 — CIT-2(17)
- `CIT2O_1` = 8301 — CIT-2/O(1)
- `CIT2O_2` = 8302 — CIT-2/O(2)
- `CIT2O_3` = 8303 — CIT-2/O(3)
- `CIT2O_4` = 8304 — CIT-2/O(4)
- `AKC2_3` = 8403
- `AKC2_4` = 8404
- `AKC2E_3` = 8503
- `CIT8_21` = 8621 — CIT-8(21)
- `CIT8_22` = 8622 — CIT-8(22)
- `CIT8_23` = 8623 — CIT-8(23)
- `CIT8_24` = 8624 — CIT-8(24)
- `CIT8_25` = 8625 — CIT-8(25)
- `CIT8_26` = 8626 — CIT-8(26)
- `CIT8_27` = 8627 — CIT-8(27)
- `CIT8_28` = 8628 — CIT-8(28)
- `CIT8_29` = 8629 — CIT-8(29)
- `CIT8_30` = 8630 — CIT-8(30)
- `CIT8_31` = 8631 — CIT-8(31)
- `CIT8_32` = 8632 — CIT-8(32)
- `CIT8_33` = 8633 — CIT-8(33)
- `CIT8_34` = 8634 — CIT-8(34)
- `CIT8O_8` = 8708 — CIT-8/O(8)
- `CIT8O_9` = 8709 — CIT-8/O(9)
- `CIT8O_10` = 8710 — CIT-8/O(10)
- `CIT8O_11` = 8711 — CIT-8/O(11)
- `CIT8O_12` = 8712 — CIT-8/O(12)
- `CIT8O_13` = 8713 — CIT-8/O(13)
- `CIT8O_14` = 8714 — CIT-8/O(14)
- `CIT8O_15` = 8715 — CIT-8/O(15)
- `CIT8O_16` = 8716 — CIT-8/O(16)
- `CIT8O_17` = 8717 — CIT-8/O(17)
- `CIT8O_18` = 8718 — CIT-8/O(18)
- `CIT8O_19` = 8719 — CIT-8/O(19)
- `CIT8O_20` = 8720 — CIT-8/O(20)
- `VATZD_1` = 8801 — VAT-ZD(1)
- `CITD_3` = 8903 — CIT-D(3)
- `CITD_4` = 8904 — CIT-D(4)
- `CITD_5` = 8905 — CIT-D(5)
- `CITD_6` = 8906 — CIT-D(6)
- `CITD_7` = 8907 — CIT-D(7)
- `CITD_8` = 8908 — CIT-D(8)
- `PIT11Z_20` = 9020 — PIT-11Z (20)
- `PIT11Z_21` = 9021 — PIT-11Z (21)
- `PIT11Z_22` = 9022 — PIT-11Z (22)
- `PIT11Z_23` = 9023 — PIT-11Z (23)
- `PIT11Z_24` = 9024 — PIT-11Z (24)
- `PIT11Z_25` = 9025 — PIT-11Z (25)
- `PIT11Z_26` = 9026 — PIT-11Z (26)
- `PIT11Z_27` = 9027 — PIT-11Z (27)
- `PIT11Z_28` = 9028 — PIT-11Z (28)
- `PIT11Z_29` = 9029 — PIT-11Z (29)
- `PIT40Z_20` = 9120 — PIT-40Z (20)
- `PIT40Z_21` = 9121 — PIT-40Z (21)
- `PIT40Z_22` = 9122 — PIT-40Z (22)
- `PIT8CZ_7` = 9207 — PIT-8CZ (7)
- `PIT8CZ_8` = 9208 — PIT-8CZ (8)
- `PIT8CZ_9` = 9209 — PIT-8CZ (9)
- `PIT8CZ_10` = 9210 — PIT-8CZ (10)
- `PIT8CZ_11` = 9211 — PIT-8CZ (11)
- `PIT8CZ_12` = 9212 — PIT-8CZ (12)
- `PIT8CZ_13` = 9213 — PIT-8CZ (13)
- `PITRZ_17` = 9317 — PIT-RZ (17)
- `PITRZ_18` = 9318 — PIT-RZ (18)
- `PITRZ_19` = 9319 — PIT-RZ (19)
- `PITRZ_20` = 9320 — PIT-RZ (20)
- `PITRZ_21` = 9321 — PIT-RZ (21)
- `PITRZ_22` = 9322 — PIT-RZ (22)
- `CITST_7` = 10007 — CIT-ST(7)
- `CITST_8` = 10008 — CIT-ST(8)
- `CIT8ST_1` = 10009 — CIT-8ST(1)
- `CITST_7_M` = 10107 — CIT-ST(7)
- `CITST_8_M` = 10108 — CIT-ST(8)
- `CIT8ST_1_M` = 10109 — CIT-8ST(1)
- `CITSTA_5` = 10205 — CIT-STA(5)
- `CIT8STA_1` = 10206 — CIT-8STA(1)
- `CITSTA_5_M` = 10305 — CIT-STA(5)
- `CIT8STA_1_M` = 10306 — CIT-8STA(1)
- `IFT2_5` = 10405 — IFT-2(5)
- `IFT2_6` = 10406 — IFT-2(6)
- `IFT2_7` = 10407 — IFT-2(7)
- `IFT2_8` = 10408 — IFT-2(8)
- `IFT2_9` = 10409 — IFT-2(9)
- `IFT2_10` = 10410 — IFT-2(10)
- `IFT2_11` = 10411 — IFT-2(11)
- `IFT2_12` = 10412 — IFT-2(12)
- `CIT10Z_1` = 10501 — CIT-10Z(1)
- `CIT10Z_2` = 10502 — CIT-10Z(2)
- `CIT10Z_3` = 10503 — CIT-10Z(3)
- `CIT10Z_4` = 10504 — CIT-10Z(4)
- `CIT10Z_5` = 10505 — CIT-10Z(5)
- `CIT10Z_6` = 10506 — CIT-10Z(6)
- `CIT10Z_7` = 10507 — CIT-10Z(7)
- `VAT27_1` = 10601 — VAT-27(1)
- `VAT27_2` = 10602 — VAT-27(2)
- `CIT8BR_1` = 10701 — CIT-8/BR(1)
- `CIT8BR_3` = 10703 — CIT-8/BR(3)
- `CIT8BR_4` = 10704 — CIT-8/BR(4)
- `CIT8BR_5` = 10705 — CIT-8/BR(5)
- `CIT8BR_6` = 10706 — CIT-8/BR(6)
- `CIT8BR_7` = 10707 — CIT-8/BR(7)
- `CIT8BR_8` = 10708 — CIT-8/BR(8)
- `CIT8BR_9` = 10709 — CIT-8/BR(9)
- `CIT8BR_10` = 10710 — CIT-8/BR(10)
- `CITMIT_1` = 10801 — CIT/MIT(1)
- `CITMIT_2` = 10802 — CIT/MIT(2)
- `CITMIT_3` = 10803 — CIT/MIT(3)
- `CIT8S_1` = 10901 — CIT/8S(1)
- `CIT8S_2` = 10902 — CIT/8S(2)
- `CIT8S_3` = 10903 — CIT/8S(3)
- `CIT8S_4` = 10904 — CIT/8S(4)
- `CIT8S_5` = 10905 — CIT/8S(5)
- `CIT8S_6` = 10906 — CIT/8S(6)
- `CIT8S_7` = 10907 — CIT/8S(7)
- `CIT8SP_1` = 11001 — CIT/8SP(1)
- `CIT8SP_2` = 11002 — CIT/8SP(2)
- `CIT8SP_3` = 11003 — CIT/8SP(3)
- `CIT8SP_4` = 11004 — CIT/8SP(4)
- `CIT8SP_5` = 11005 — CIT/8SP(5)
- `CIT8SP_6` = 11006 — CIT/8SP(6)
- `CIT8SP_7` = 11007 — CIT/8SP(7)
- `CITIP_2` = 11102 — CIT/IP(2)
- `CITIP_3` = 11103 — CIT/IP(3)
- `CITIP_4` = 11104 — CIT/IP(4)
- `CITIP_5` = 11105 — CIT/IP(5)
- `CITWZ_1` = 11201 — CIT/WZ(1)
- `CITWZ_2` = 11202 — CIT/WZ(2)
- `CITWZ_3` = 11203 — CIT/WZ(3)
- `CITKW_1` = 11301 — CIT/KW(1)
- `CITKW_2` = 11302 — CIT/KW(2)
- `CITKW_3` = 11303 — CIT/KW(3)
- `CITKW_4` = 11304 — CIT/KW(4)
- `CITWOT_1` = 19000 — CIT-WOT(1)
- `CIT8E_2` = 15002 — CIT-8E(2)
- `CIT8E_3` = 15003 — CIT-8E(3)
- `CIT8E_4` = 15004 — CIT-8E(4)
- `CITEZ_2` = 15102 — CIT/EZ(2)
- `CITEZ_3` = 15103 — CIT/EZ(3)
- `CITCSR_1` = 17001 — CIT-CSR(1)
- `CITCSR_2` = 17002 — CIT-CSR(2)
- `CITRB_1` = 16001 — CIT-RB(1)
- `CITRB_2` = 16002 — CIT-RB(2)
- `CITF_1` = 19001 — CIT-F(1)
- `CITM_2` = 19102 — CIT-M(2)
- `PPK_DokumentyPracodawcy_1` = 25001 — PPK - Dokumenty pracodawcy
- `PPK_DokumentyInstytucjiFinansowej_1` = 25101 — PPK - Dokumenty instytucji finansowej
- `PPK_RozliczenieSkładek_1` = 25201 — PPK - Rozliczenie składek
- `PPK_RozliczenieNadpłat_1` = 26501 — PPK - Rozliczenie nadpłat
- `PPK_RejestracjaUczestnika_1` = 25301 — PPK - Rejestracja uczestnika
- `PPK_Składki_1` = 25401 — PPK - Składka
- `PPK_KorektaSkładek_1` = 25501 — PPK - Korekta składki
- `PPK_DeklaracjaUczestnika_1` = 25601 — PPK - Deklaracja uczestnika
- `PPK_ZmianaDanychKontaktu_1` = 25701 — PPK - Zmiana danych kontaktu elektronicznego uczestnika
- `PPK_ZmianaDanychIdentyfikacyjnych_1` = 25801 — PPK - Zmiana danych identyfikacyjnych uczestnika
- `PPK_ZakończenieZatrudnienia_1` = 25901 — PPK - Zakończenie zatrudnienia uczestnika
- `PPK_Transfer_1` = 26601 — PPK - Transfer
- `PPK_WypłataŚrodków_1` = 26001 — PPK - Wypłata środków przez uczestnika
- `PPK_ZwrotNadpłaty_1` = 26101 — PPK - Zwrot środków w wyniku rozliczenia korekty lub rezygnacji z dokonywania wpłat
- `PPK_WypłataTransferowa_1` = 26201 — PPK - Wypłata transferowa
- `PPK_NadanieUczestnikowiNumeruEwidencji_1` = 26301 — PPK - Nadanie uczestnikowi numeru ewidencji PPK
- `PPK_ZwrotŚrodków_1` = 26401 — PPK - Zwrot (art. 12.6, art. 19.6.)
- `VAT8_11` = 11911 — VAT-8(11)
- `VAT8_12` = 11912 — VAT-8(12)
- `VAT9M_8` = 12001 — VAT-9M(8)
- `VAT9M_9` = 12002 — VAT-9M(9)
- `VAT9M_10` = 12003 — VAT-9M(10)
- `VAT9M_11` = 12004 — VAT-9M(11)
- `ZAW_NR_1` = 13001 — ZAW-NR(1)
- `ZAW_NR_2` = 13002 — ZAW-NR(2)
- `CUK_1` = 14001 — CUK-1 (1)
- `CUK_2` = 14002 — CUK-1 (2)
- `VIIDO_1` = 11401 — VIIDO(1)
- `VIIDO_1_Pozycja` = 11501
- `VIIDO_2` = 11402 — VIIDO(2)
- `VIIDO_2_Pozycja` = 11502
- `VIUDO_1` = 11601 — VIUDO(1)
- `VIUDO_1_Pozycja` = 11701
- `VIUDO_2` = 11602 — VIUDO(2)
- `VIUDO_2_Pozycja` = 11702
- `VAT7_ParametryRozliczen` = 18001
- `VAT7_23_ParametryRozliczen` = 18002
- `ZUS_Z3` = 21000 — ZUS Z3
- `ZUS_Z3a` = 21100 — ZUS Z3a
- `Luka_placowa_v1` = 22000 — Luka płacowa
- `Luka_placowa_Poziom_v1` = 22001
- `Luka_placowa_Pracownik_v1` = 22002
