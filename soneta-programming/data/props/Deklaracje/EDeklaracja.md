# Pola i właściwości klasy biznesowej: `Soneta.Deklaracje.EDeklaracja`
Nazwa tabeli: `EDeklaracje`
Tytuł: eDeklaracja
Opis: Elektroniczna wersja deklaracji przeznaczona do transmisji do urzędu skarbowego. Przechowuje dokument XML, podpis elektroniczny, status wysyłki oraz urzędowe potwierdzenie odbioru (UPO). Śledzi cykl życia eDeklaracji od utworzenia przez podpisanie do potwierdzenia odbioru.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Deklaracja | `Soneta.Deklaracje.IEDeklaracjaHost` | bazodanowe |  | Deklaracja przeznaczona do transmisji |
| Dokument | `Soneta.Business.MemoText` | bazodanowe |  | Dokument eDeklaracji |
| DokumentPodpisany | `Soneta.Business.MemoBin` | bazodanowe |  | Podpisany dokument eDeklaracji |
| DokumentPodpisanyStr | `Soneta.Business.MemoText` |  |  | Tekstowa prezentacja podpisanego dokumentu |
| ETransmisje | `Soneta.Business.SubTable<Soneta.Deklaracje.ETransmisja>` |  |  |  |
| FormatPodpisu | `Soneta.Deklaracje.FormatEPodpisu` | bazodanowe, enum |  |  |
| NazwaPodmiotuPrzyjmujacego | `string` |  |  |  |
| OkresDeklaracji | `Soneta.Types.FromTo` | bazodanowe |  | Okres deklaracji |
| Potwierdzenie | `Soneta.Business.MemoText` | bazodanowe |  | Urzędowe potwierdzenie odbioru |
| StatusEDeklaracji | `Soneta.Deklaracje.StatusEDeklaracji` | bazodanowe, enum | Status | Status eDeklaracji |
| TypDeklaracji | `Soneta.Deklaracje.TypDeklaracji` | bazodanowe, enum |  | Typ deklaracji |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FormatEPodpisu (`Soneta.Deklaracje.FormatEPodpisu`)
- `Brak` = 0
- `XAdES` = 1 — XAdES
- `PKCS7` = 2 — PKCS#7
- `Nieweryfikowany` = 3 — Nieweryfikowany

### StatusEDeklaracji (`Soneta.Deklaracje.StatusEDeklaracji`)
- `Brak` = 0
- `DoPodpisania` = 1 — Do podpisania
- `DoWysłania` = 2 — Do wysłania
- `DoPotwierdzeniaOdbioru` = 3 — Do potwierdzenia odbioru
- `Potwierdzona` = 4 — Potwierdzona
- `Błędna` = 99 — Błędna
- `Anulowana` = 100 — Anulowana
- `DodanaDoZbiorczej` = 200 — Dodana do zbiorczej

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
