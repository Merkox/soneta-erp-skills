# Moduł `SrodkiTrwale` — tabele biznesowe

- Opis: Moduł obsługujący środki trwałe i wartości niematerialne. Zawiera kartotekę środków trwałych, dokumenty OT/LT/MT, amortyzację, inwentaryzację oraz plan amortyzacji.
- Tabel: **27**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| DokumentPowiazanyUL | Dokumenty powiązane UL | `DokumentyPowiazaneUL` |  |  |  |  |  | [DokumentPowiazanyUL.md](DokumentPowiazanyUL.md) |
| DokumentST | Dokumenty ŚT | `DokumentyST` |  | root |  | IDokumentKsiegowalny | TypDokumentu (20) | [DokumentST.md](DokumentST.md) |
| DokumentUL | Dokumenty UL | `DokumentyUL` |  | root |  | IDokument | TypDokumentu (2) | [DokumentUL.md](DokumentUL.md) |
| ElemPlanuAmortyzacji | Plan amortyzacji | `PlanAmortyzacji` |  | child: Srodek→SrodekTrwalyBase |  |  |  | [ElemPlanuAmortyzacji.md](ElemPlanuAmortyzacji.md) |
| ElementPodatkuOdNieruch | Elementy podatku od nieruchomości | `ElemPodOdNieruch` |  | child: Historia→SrodekTrwalyBaseHistoria |  |  |  | [ElementPodatkuOdNieruch.md](ElementPodatkuOdNieruch.md) |
| KategoriaST | Kategorie środka trwałego | `KategorieST` | konfig | root |  | IRightsSource |  | [KategoriaST.md](KategoriaST.md) |
| KategoriaZapotrzebowania | Kategorie zapotrzebowania | `KategorieZap` | konfig | root |  | IRightsSource |  | [KategoriaZapotrzebowania.md](KategoriaZapotrzebowania.md) |
| LokalizacjaNier | Lokalizacja nieruchomości | `LokalizacjeNier` |  | root | historyczna → LokalizacjaNierHistoria |  |  | [LokalizacjaNier.md](LokalizacjaNier.md) |
| LokalizacjaNierHistoria | Historia lokalizacji nieruchomości | `LokalizacjeNierH` |  | child: Lokalizacja→LokalizacjaNier | historia → LokalizacjaNier |  |  | [LokalizacjaNierHistoria.md](LokalizacjaNierHistoria.md) |
| MiejsceUzytkowania | Miejsca użytkowania | `MiejscaUzytk` | konfig | root |  | IRightsSource |  | [MiejsceUzytkowania.md](MiejsceUzytkowania.md) |
| ObrotST | Obroty środków trwałych | `ObrotyST` |  | child: Dokument→DokumentST |  | IZrodloOpisuAnalitycznego | TypObrotuST (17) | [ObrotST.md](ObrotST.md) |
| ParametrOdpisu | Parametry odpisów | `ParametryOdpisow` |  | child: Amortyzacja→ObrotST |  |  |  | [ParametrOdpisu.md](ParametrOdpisu.md) |
| PozycjaTerminarzaInw | Terminarz inwentarza | `TerminarzInw` |  |  |  |  |  | [PozycjaTerminarzaInw.md](PozycjaTerminarzaInw.md) |
| ProporcjaAmortyzacji | Proporcja amortyzacji | `ProporcjeAmortyzacji` |  | child: Srodek→SrodekTrwalyBase |  |  |  | [ProporcjaAmortyzacji.md](ProporcjaAmortyzacji.md) |
| PrzedmiotOp | Przedmiot opodatkowania | `PrzedmiotyOp` |  | child: Historia→LokalizacjaNierHistoria |  |  |  | [PrzedmiotOp.md](PrzedmiotOp.md) |
| RataLeasingST | Rata | `RatyLeasingST` |  | child: Srodek→SrodekTrwalyBase |  |  |  | [RataLeasingST.md](RataLeasingST.md) |
| RodzajPO | Rodzaje przedmiotów opodatkowania | `RodzajePO` |  | root |  |  |  | [RodzajPO.md](RodzajPO.md) |
| RodzajST | Klasyfikacja Rodzajowa Środków Trwałych | `KRST` | konfig | root |  |  | TypSrodkaTrwalego (2) | [RodzajST.md](RodzajST.md) |
| SrodekTrwalyBase | Ewidencja środków trwałych oraz wartości niematerialnych i prawnych | `SrodkiTrwale` |  | root | historyczna → SrodekTrwalyBaseHistoria | IInwentarz, IElementSlownika, IZasobCRM, IKodowany, IZrodloPodzielnikaKosztow | TypSrodkaTrwalego (3) | [SrodekTrwalyBase.md](SrodekTrwalyBase.md) |
| SrodekTrwalyBaseHistoria | Ewidencja środków trwałych oraz wartości niematerialnych i prawnych - historia | `SrodkiTrwaleHist` |  | child: Srodek→SrodekTrwalyBase | historia → SrodekTrwalyBase |  | TypSrodkaTrwalego (3) | [SrodekTrwalyBaseHistoria.md](SrodekTrwalyBaseHistoria.md) |
| SrodekTrwalyLeasing | Leasing | `SrodkiTrwaleLeas` |  | child: Srodek→SrodekTrwalyBase |  |  |  | [SrodekTrwalyLeasing.md](SrodekTrwalyLeasing.md) |
| TypOplatyLeasing | Typ opłaty | `TypyOplLeasingi` |  | child: Leasing→SrodekTrwalyLeasing |  |  |  | [TypOplatyLeasing.md](TypOplatyLeasing.md) |
| TypOplatyMSR | Typy opłaty MSR | `TypyOplatMSR` | konfig | root |  |  |  | [TypOplatyMSR.md](TypOplatyMSR.md) |
| TytulDokumentuST | Tytuły dokumentów | `TytulyDokST` | konfig | root |  |  |  | [TytulDokumentuST.md](TytulDokumentuST.md) |
| Wyposazenie | Ewidencja wyposażenia | `EwidWyposazenia` |  | root | historyczna → WyposazenieHistoria | IInwentarz, IKodowany, IZasobCRM |  | [Wyposazenie.md](Wyposazenie.md) |
| WyposazenieHistoria | Ewidencja wyposażenia - historia | `EwidWyposazeniaH` |  | child: Wyposazenie→Wyposazenie | historia → Wyposazenie |  |  | [WyposazenieHistoria.md](WyposazenieHistoria.md) |
| ZestawST | Zestawy środków trwałych | `ZestawyST` |  | root |  |  |  | [ZestawST.md](ZestawST.md) |

