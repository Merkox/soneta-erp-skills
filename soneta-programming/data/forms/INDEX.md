# Indeks zakładek formularzy (pageform) — dane wygenerowane

Zakładek biznesowych: **5667** · typów danych: **2754** · zakładek systemowych: **12** · bibliotek UI: **31**.

Katalog do szybkiego wyszukania „obiekt → zakładki” bez uruchamiania skanera i bez
dostępu do DLL. **Nie zawiera pól ani sekcji** — pełną zawartość zakładki (pola,
sekcje danych, rozwinięte ścieżki `DataContext`/`EditValue`, `Include`, listy) wypisuje
na żądanie `scan-forms.csx` — patrz [../../references/scan-forms.md](../../references/scan-forms.md).

**Typ danych.** Nazwa zasobu ma postać `…<TYP>.<ZAKŁADKA>.pageform.xml`, więc typ to
segment **przed** nazwą zakładki — albo jawny atrybut `DataType` na `<DataForm>`, gdy jest.
Segment typu jest walidowany względem realnych `RowType`; dla okien konfiguracji
(folder `Config`) typ bierzemy z nazwy zakładki. Zakładek z jawnym `DataType`: **800**.

**Jak używać:** wyszukaj `Typ danych` (np. `Kontrahent`, `DokumentHandlowy`, `DashboardView`).
Po znalezieniu obiektu odczytaj jego pola: `dotnet script scan-forms.csx -- <Typ|Namespace.Typ> <KatalogDll>`.

## Zakładki wg typu danych

| Typ danych | Zakładka (plik) | Nazwa zakładki | Priority | Biblioteka (DLL) | Przestrzeń |
|---|---|---|---|---|---|
| AKC2 | AKC2 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| AKC2E | AKC2E | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| AKC2E_3 | AKC2E_3_1_ | Część B, C, D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| AKC2_3 | AKC2_3_1_ | Część C, D, E | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| AKC2_3 | AKC2_3_2_ | Część F, G | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| AccountPoliciesConfig | AccountPoliciesConfig | Systemowe/Zabezpieczenie konta | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AccountsList | AccountsList | Brakujące rachunki bankowe | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| ActionDashboardWorker | General | Inicjacja | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AddBIDashboardWorker | Params |  | 100 | Soneta.BI.UI.dll | Soneta.BI |
| AddBasicDocumentToMatterWorkerParams | BasicDocuments | Dokumenty podstawowe | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| AddChangeParams | AddChangeParams | Parametry | 100 | Soneta.Core.UI.dll | Soneta.Core |
| AddChildCounters | General | Liczniki | 1 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| AddFeaturesToModelParams | AvailableFeatures | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| AddPivotViewWorker | Params |  | 100 | Soneta.BI.UI.dll | Soneta.BI |
| Addins | Addins | Systemowe/Rozszerzenia (dodatki DLL) | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AdditionRowDesc | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| AdminPanel | Addins | Rozszerzenia (dodatki DLL) | 100 | Soneta.Net.Business.dll | Soneta.Net |
| AdminPanel | Backup | Kopia bezpieczeństwa | 100 | Soneta.Net.Business.dll | Soneta.Net |
| AdminPanel | Convert | Konwersja | 100 | Soneta.Net.Business.dll | Soneta.Net |
| AdminPanel | Create | Nowa baza | 100 | Soneta.Net.Business.dll | Soneta.Net |
| AdminPanel | Database | Narzędzia bazy | 100 | Soneta.Net.Business.dll | Soneta.Net |
| AdminPanel | Drop | Usuń bazę | 100 | Soneta.Net.Business.dll | Soneta.Net |
| AdminPanel | Restore | Odtwarzanie bazy | 100 | Soneta.Net.Business.dll | Soneta.Net |
| AdminPanel | SQL | SQL | 100 | Soneta.Net.Business.dll | Soneta.Net |
| AdminPanel | Password | Aktywowanie panelu | 300 | Soneta.Net.Business.dll | Soneta.Net |
| AdminPanel | Restart | Restart serwisu | 1000 | Soneta.Net.Business.dll | Soneta.Net |
| AdresExt | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| AfterLoginTest | General | After login | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AfterLoginTest2 | General | After login 22222 | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AkordGrupowyHistoria | AkordGrupowy | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AkordGrupowyHistoria | AkordZestawienia | Zestawienia | 3 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AkordHistoria | KalendarzAkordu | Kalendarz | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AkordHistoria | ElementyWynagrodzeniaHist | Elementy wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AkordHistoria | RowHistory | Historia zapisów | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AkordProstyHistoria | AkordProsty | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AkordProstyHistoria | AkordZestawienia | Zestawienia | 3 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AktualizacjaDefinicjiStanowiskaWorker-AktualizacjaDefinicjiStanowiskaParams | AktualizacjaDefinicjiStanowiskaWorkerParams | Zaktualizuj \| definicję stanowiska | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AktualizacjaGrupTowarowychVATWorker-Params | Ogolne | Parametry | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| Aktualnosc | General | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| Aktualnosc | Parameters | Parametry publikacji | 2 | Soneta.Core.UI.dll | Soneta.Core |
| Aktualnosc | Users | Odbiorcy | 3 | Soneta.Core.UI.dll | Soneta.Core |
| AktualnosciViewInfo | General | Aktualności | 100 | Soneta.Core.UI.dll | Soneta.Core |
| AktywnosciOPZ | General | General | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| AlgRatPozyczek | AlgRatPozyczek | Kadry i płace/KZP, ZFM, .../Algorytmy rat pożyczek | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AlgorithmDashboardWorker | General | Kod akcji | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AlgorytmRatyPozyczki | Ogolne | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AlgorytmRatyPozyczki | Edytor | Edytor | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| AliasFieldDefinition | AliasFieldDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| AllReports | AllReports | Raportowanie/Drukarki domyślne | 110 | Soneta.Business.Forms.dll | Soneta.Business |
| AllReports | AllReports | Raportowanie/Drukarki domyślne | 110 | Soneta.Business.UI.dll | Soneta.Business |
| Amortyzacja | AmortyzacjaOgolne | Ogólne (Amortyzacja) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Analyser | Analyser | Systemowe/Analizator konfiguracji | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AnalysisArea | AnalysisAreaOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| AnalysisAreaDefinition | AnalysisAreaDefinitionOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| AnalysisAreaDefs | AnalysisAreaDefs | BI/Obszary | 1170 | Soneta.BI.UI.dll | Soneta.BI |
| AnalysisModeInformation | General |  | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AnkietaAktualnosciWorker | Ogolne | Wybierz | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnkietaArkusz | AnkietaArkuszOgólne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnkietaArkusz | OcenaArkuszCzęściowe | Arkusze częściowe | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnkietaArkusz | OcenaArkuszOgólne2 | Arkusz ankiety | 11 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnkietaOceniający | Ogolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnkietaPozycjaArkusza | Ogólne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnkietaRealizacja | AnkietaRealizacjaOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnkietaRealizacja | OcenaRealizacjaOceniajacy | Ankietowany | 20 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnkietaRealizacja | AnkietaRealizacjaArkusze | Arkusze ankiet | 50 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnkietaRealizacja | Etapy | Etapy | 50 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnkietaRealizacja | AnkietaRealizacjaPodsumowanie | Podsumowanie | 55 | Soneta.CRM.UI.dll | Soneta.CRM |
| AnulujPrzelewWPaczceParams | Ogolne | Ogólne | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| AppToken | General | Ustawienia tokena | 0 | Soneta.Business.UI.dll | Soneta.Business |
| AppToken | Items | Historia | 2 | Soneta.Business.UI.dll | Soneta.Business |
| AppTokens | AppTokens | Systemowe/Uprawnienia/Tokeny aplikacyjne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AppearanceItemDefinition | AppearanceItemDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| AppearanceSetDefinition | AppearanceSetDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| AppearanceSetDefs | AppearanceSetDefs | BI/Prezentacja danych/Zestawy barw | 1170 | Soneta.BI.UI.dll | Soneta.BI |
| ApplicationServerConfig | ApplicationServerConfig | Systemowe/Serwer aplikacji | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ArkuszDefinicjiOceny | Ogólne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| ArticlesRepositoryElemStrOrgParams | Params |  | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ArticlesRepositoryFolder | General | Bibilioteka | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| AspReportGenerator | General | Raport ASPX | 100 | Soneta.Printer.dll | Soneta.Printer |
| AspReportGenerator | Following | Powiązane | 200 | Soneta.Printer.dll | Soneta.Printer |
| AspxAdditionalSettings | General | Ustawienia strony raportu | 100 | Soneta.Printer.dll | Soneta.Printer |
| AssistantConfig | AssistantConfig | Systemowe/Asystent | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AsyncTestDataSource | General | Ogólne | 200 | Soneta.Net.Test.dll | Soneta.Net |
| Attachment | Attachment | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Attachment | Attachment365 | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Attachment | AttachmentLinks | Linki | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Attachment | Signatures | Podpisy | 9999 | Soneta.Business.UI.dll | Soneta.Business |
| Attachment | OcrData | Dane OCR | 10000 | Soneta.Business.UI.dll | Soneta.Business |
| Attachment | OcrDataWithLayout | Dane OCR z regionami | 10001 | Soneta.Business.UI.dll | Soneta.Business |
| Attachment | OcrBusinessMappingOutputs | Wyniki mapowania OCR | 10002 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| AttachmentExtender-SelectFileParams | SelectFileParams | Dodawanie załącznika | 0 | Soneta.Core.UI.dll | Soneta.Core |
| AttachmentFolder | Ogolne | Attachment | 100 | Soneta.Core.UI.dll | Soneta.Core |
| AttachmentMultipleImportParams | Ogolne | Import | 0 | Soneta.Business.UI.dll | Soneta.Business |
| AttachmentsUIConfiguration | AttachmentsUIConfiguration | Systemowe/Załączniki/Konfiguracja UI | 100 | Soneta.Core.UI.dll | Soneta.Core |
| AttributesEditor | General | Atrybuty | 100 | Soneta.Business.UI.dll | Soneta.Business |
| AuthProviders | AuthProviders | CRM/Poczta/Dostawcy Autoryzacji | 2 | Soneta.CRM.UI.dll | Soneta.CRM |
| AutoImportRCP-Params | AutoRCPImport | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| BDocBusEnt | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| BICodes | BICodes | BI/Modele danych/Algorytmy modeli danych | 1140 | Soneta.BI.UI.dll | Soneta.BI |
| BIDashboard | Design | General | 100 | Soneta.BI.UI.dll | Soneta.BI |
| BIDashboard | General | General | 100 | Soneta.BI.UI.dll | Soneta.BI |
| BIDashboards | BIDashboards | BI/Prezentacja danych/Panele BI | 1160 | Soneta.BI.UI.dll | Soneta.BI |
| BIGeneral | BIGeneral | BI/Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| BIParamsPanelDashboardWorker | General | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| BIPivotDashboard | Design | Projektowanie | 100 | Soneta.BI.UI.dll | Soneta.BI |
| BIPivotView | General | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| BIPivotView | Styles | Układy | 2 | Soneta.BI.UI.dll | Soneta.BI |
| BOEwidencja | PKEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| BOT | BOTOgolne | Ogólne (BOT) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| BadanieLekarskie | BadanieLekarskie | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Bank | BankOgolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| Bank | KontrahentDodatkowe | Warunki płatności | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| BankowoscElektroniczna | BankowoscElektroniczna | Ewidencje ŚP/Bankowość elektroniczna/Bankowość elektroniczna | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| BasicDocDefs | BasicDocDefs | DMS/Definicje dokumentów podstawowych | 200 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| BasicDocKind | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| BasicDocKind | BasicDocKind | DMS/Rodzaje dokumentów | 400 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| BasicDocsParams | Params |  | 100 | Soneta.EI.UI.dll | Soneta.EI |
| BasicDocument | DbTuple | Ogólne | 500 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| BasicDocument | MultireferenceField | {Caption} | 510 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| BasicDocumentChangeDocumentTypeWorkerParams | BasicDocuments | Dokumenty podstawowe | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| BasicDocumentDefinition | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| BasicDocumentDefinition | DocState | Status | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| BazyDanychRowProxy | BazaDanych | Ogólne | 10 | Soneta.Business.Licence.dll | Soneta.Business |
| Benefit | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| BetaModeInformation | General | Wersja testowa | 100 | Soneta.Business.UI.dll | Soneta.Business |
| BilansOtwarciaPIT_11 | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| BilansOtwarciaPIT_11 | EG | E (cd), G | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| BilansOtwarciaPIT_29 | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| BilansOtwarciaPIT_29 | EG | E (cd), G | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| BiuroRachunkowe | BiuroRachunkowe | Firma/Biuro rachunkowe | 4 | Soneta.Core.UI.dll | Soneta.Core |
| BladNaliczaniaWynagrodzenia | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| BoKontaSchematyInDBWorkerRow-Params | Params | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| BoKontaSchematyInDBWorkerTable-Params | Params | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| BoRIAOswiata | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| BoRIAWarunkiSzczegolne | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| BoRIAWynagrodzenia | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Branze | Branze | CRM/Ogólne/Branże | 12 | Soneta.CRM.UI.dll | Soneta.CRM |
| BudgetGeneral | BudgetGeneral | Projekty i Budżetowanie/Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| BudgetPeriod | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| BudgetSettlementCorrectionParams | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| BudgetSettlementParams | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| BudgetSettlementRelationParams | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| BudzetProjektu | BudzetProjektuOgolne | Budżet | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| BudzetSzkolen | BudzetSzkolen | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| BudzetowanieProjektow | BudzetowanieProjektow | Ewidencje ŚP/Budżetowanie projektów | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| CIT10Z_1 | CIT10Z_1_1 | Ogólne, A, B, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_1 | CIT10Z_1_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_1 | CIT10Z_1_3 | E, F, G | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_2 | CIT10Z_2_1 | Ogólne, A, B, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_2 | CIT10Z_2_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_2 | CIT10Z_2_3 | E, F, G | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_3 | CIT10Z_3_1 | Ogólne, A, B, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_3 | CIT10Z_3_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_3 | CIT10Z_3_3 | E, F, G | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_4 | CIT10Z_4_1 | Ogólne, A, B, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_4 | CIT10Z_4_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_4 | CIT10Z_4_3 | E, F, G | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_5 | CIT10Z_5_1 | Ogólne, A, B, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_5 | CIT10Z_5_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_5 | CIT10Z_5_3 | E, F, G | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_6 | CIT10Z_6_1 | Ogólne, A, B, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_6 | CIT10Z_6_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_6 | CIT10Z_6_3 | E, F, G | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_7 | CIT10Z_7_1 | Ogólne, A, B, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_7 | CIT10Z_7_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT10Z_7 | CIT10Z_7_3 | E, F, G, H | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2 | CIT2 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2 | CIT2_14_1_ | Część B, C, D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2 | CIT2_15_1_ | Część B, C, D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2 | CIT2_14_2_ | Część D, E, F, G | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2 | CIT2_14_3_ | Część H, I | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2 | CIT2_16_3_ | Część H, I | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2O | CIT2O | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2O | CIT2O_2_1_ | Część B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2O | CIT2O_2_2_ | Część C, D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2O | CIT2O_2_3_ | Część E, F | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2O_1 | CIT2O_1_1_ | Część B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2O_1 | CIT2O_1_2_ | Część C, D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2O_1 | CIT2O_1_3_ | Część E, F | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2O_4 | CIT2O_4_1_ | Część B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2O_4 | CIT2O_4_2_ | Część C, D, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2O_4 | CIT2O_4_3_ | Część E, F, G | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2_17 | CIT2_17_1_ | Część B, C, D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2_17 | CIT2_17_2_ | Część D, E, F, G | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT2_17 | CIT2_17_3_ | Część H, I | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_1 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_1 | Page_BC | B, C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_1 | Page_D | D | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_10 | Page_0 | Ogólne, A | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_10 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_10 | Page_B23 | B2, B3 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_10 | Page_CD | C, D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_10 | Page_E | E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_10 | Page_F | F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_3 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_3 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_3 | Page_C | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_3 | Page_D | D | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_4 | Page_0 | Ogólne, A | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_4 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_4 | Page_B23 | B2, B3 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_4 | Page_CD | C, D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_4 | Page_E | E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_4 | Page_F | F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_5 | Page_0 | Ogólne, A | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_5 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_5 | Page_B23 | B2, B3 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_5 | Page_CD | C, D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_5 | Page_E | E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_5 | Page_F | F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_6 | Page_0 | Ogólne, A | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_6 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_6 | Page_B23 | B2, B3 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_6 | Page_CD | C, D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_6 | Page_E | E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_6 | Page_F | F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_7 | Page_0 | Ogólne, A | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_7 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_7 | Page_B23 | B2, B3 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_7 | Page_CD | C, D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_7 | Page_E | E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_7 | Page_F | F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_8 | Page_0 | Ogólne, A | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_8 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_8 | Page_B23 | B2, B3 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_8 | Page_CD | C, D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_8 | Page_E | E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_8 | Page_F | F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_9 | Page_0 | Ogólne, A | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_9 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_9 | Page_B23 | B2, B3 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_9 | Page_CD | C, D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_9 | Page_E | E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8BR_9 | Page_F | F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_2 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_2 | Page_BC | B.3, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_2 | Page_D1_1 | D.1 cz.1 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_2 | Page_D1_2 | D.1 cz.2 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_2 | Page_D2 | D.2 | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_2 | Page_D3D5_1 | D.3 - D.5.1 | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_2 | Page_D5_2D5_3 | D.5.2, D.5.3 | 7 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_2 | Page_E | E | 8 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_2 | Page_FG | F, G | 9 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_3 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_3 | Page_BC | B.3, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_3 | Page_D1 | D.1 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_3 | Page_D2 | D.2 | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_3 | Page_D3D5_1 | D.3 - D.5.1 | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_3 | Page_D5_2D5_3 | D.5.2, D.5.3 | 7 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_3 | Page_E | E | 9 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_4 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_4 | Page_BC | B.3, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_4 | Page_D1 | D.1 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_4 | Page_D2 | D.2 | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_4 | Page_D3D5_1 | D.3 - D.5.1 | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_4 | Page_D5_2D5_3 | D.5.2, D.5.3 | 7 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8E_4 | Page_E | E | 9 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_10 | CIT8O_10_1 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_10 | CIT8O_10_2 | B.1. | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_10 | CIT8O_10_2A | B.1. (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_10 | CIT8O_10_3 | B.2., B.3. | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_10 | CIT8O_10_4 | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_10 | CIT8O_10_5 | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_11 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_11 | Page_B1_1 | B.1. | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_11 | Page_B1_2 | B.1. (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_11 | Page_B23 | B.2., B.3. | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_11 | Page_CDE | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_11 | Page_F | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_12 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_12 | Page_B1_1 | B.1. | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_12 | Page_B1_2 | B.1. (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_12 | Page_B23 | B.2., B.3. | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_12 | Page_CDE | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_12 | Page_F | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_13 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_13 | Page_B1_1 | B.1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_13 | Page_B1_2 | B.1 (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_13 | Page_B2 | B.2 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_13 | Page_B34 | B.3, B.4 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_13 | Page_CDE | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_13 | Page_F | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_14 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_14 | Page_B1_1 | B.1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_14 | Page_B1_2 | B.1 (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_14 | Page_B2 | B.2 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_14 | Page_B34 | B.3, B.4 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_14 | Page_CDE | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_14 | Page_F | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_15 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_15 | Page_B1_1 | B.1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_15 | Page_B1_2 | B.1 (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_15 | Page_B2 | B.2 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_15 | Page_B34 | B.3, B.4 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_15 | Page_CDE | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_15 | Page_F | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_16 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_16 | Page_B1_1 | B.1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_16 | Page_B1_2 | B.1 (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_16 | Page_B2 | B.2 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_16 | Page_B34 | B.3, B.4 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_16 | Page_CDE | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_16 | Page_F | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_17 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_17 | Page_B1_1 | B.1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_17 | Page_B1_2 | B.1 (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_17 | Page_B2 | B.2 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_17 | Page_B34 | B.3, B.4 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_17 | Page_CDE | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_17 | Page_F | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_18 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_18 | Page_B1_1 | B.1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_18 | Page_B1_2 | B.1 (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_18 | Page_B2 | B.2 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_18 | Page_B34 | B.3, B.4 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_18 | Page_CDE | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_18 | Page_F | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_19 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_19 | Page_B1_1 | B.1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_19 | Page_B1_2 | B.1 (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_19 | Page_B2 | B.2 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_19 | Page_B34 | B.3, B.4 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_19 | Page_CDE | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_19 | Page_F | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_20 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_20 | Page_B1_1 | B.1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_20 | Page_B1_2 | B.1 (c.d) | 25 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_20 | Page_B2 | B.2 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_20 | Page_B34 | B.3, B.4 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_20 | Page_CDE | C, D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_20 | Page_F | F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_8 | CIT8O_8_1_ | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_8 | CIT8O_8_2_ | B.1. | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_8 | CIT8O_8_3_ | B.2., B.3. | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_8 | CIT8O_8_4_ | C, D, E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_8 | CIT8O_8_5_ | F | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_9 | CIT8O_9_1_ | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_9 | CIT8O_9_2_ | B.1. | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_9 | CIT8O_9_3_ | B.2., B.3. | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_9 | CIT8O_9_4_ | C, D, E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8O_9 | CIT8O_9_5_ | F | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_1 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_1 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_1 | Page_B2 | B2 | 21 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_1 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_1 | Page_D | D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_2 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_2 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_2 | Page_B2 | B2 | 21 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_2 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_2 | Page_D | D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_3 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_3 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_3 | Page_B2 | B2 | 21 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_3 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_3 | Page_D | D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_4 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_4 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_4 | Page_B2 | B2 | 21 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_4 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_4 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_4 | Page_EF | E, F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_5 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_5 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_5 | Page_B2 | B2 | 21 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_5 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_5 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_5 | Page_EF | E, F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_6 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_6 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_6 | Page_B2 | B2 | 21 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_6 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_6 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_6 | Page_EF | E, F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_7 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_7 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_7 | Page_B2 | B2 | 21 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_7 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_7 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8SP_7 | Page_EF | E, F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8STA_1_Multi | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8ST_1 | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8ST_1 | Oddzialy | Oddziały | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8ST_1_Multi | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_1 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_1 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_1 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_1 | Page_D | D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_2 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_2 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_2 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_2 | Page_D | D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_3 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_3 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_3 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_3 | Page_D | D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_4 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_4 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_4 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_4 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_4 | Page_EF | E, F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_5 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_5 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_5 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_5 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_5 | Page_EF | E, F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_6 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_6 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_6 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_6 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_6 | Page_EF | E, F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_7 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_7 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_7 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_7 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8S_7 | Page_EF | E, F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_21 | CIT8_21_1_ | Ogólne, A, B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_21 | CIT8_21_2_ | C, D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_21 | CIT8_21_3_ | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_21 | CIT8_21_4_ | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_21 | CIT8_21_5_ | I, J, K, L | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_22 | CIT8_22_1_ | Ogólne, A, B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_22 | CIT8_22_2_ | C, D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_22 | CIT8_22_3_ | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_22 | CIT8_22_4_ | F, G, H, I | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_22 | CIT8_22_5_ | J, K, L | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_23 | CIT8_23_1 | Ogólne, A, B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_23 | CIT8_23_2 | C, D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_23 | CIT8_23_3 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_23 | CIT8_23_4 | F, G, H, I | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_23 | CIT8_23_5 | J, K, L | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_24 | Page_AB | Ogólne, A, B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_24 | Page_CD | C, D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_24 | Page_E | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_24 | Page_FGHI | F, G, H, I | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_24 | Page_JKL | J, K, L | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_25 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_25 | Page_BC | B, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_25 | Page_D | D | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_25 | Page_E | E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_25 | Page_FGHI | F, G, H, I | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_25 | Page_JKL | J, K, L | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_26 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_26 | Page_BC | B, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_26 | Page_D | D | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_26 | Page_E1 | E.1 | 45 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_26 | Page_EF | E.2-E.5, F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_26 | Page_G | G | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_26 | Page_HI | H, I | 70 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_26 | Page_JKL | J, K, L | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_27 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_27 | Page_BC | B, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_27 | Page_D | D | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_27 | Page_E1 | E.1 | 45 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_27 | Page_EF | E.2-E.5, F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_27 | Page_G | G | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_27 | Page_HI | H, I | 70 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_27 | Page_J | J | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_27 | Page_KLM | K, L, M | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_28 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_28 | Page_BC | B, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_28 | Page_D | D | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_28 | Page_E1 | E.1 | 45 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_28 | Page_EF | E.2-E.5, F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_28 | Page_G | G | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_28 | Page_HI | H, I | 70 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_28 | Page_J | J | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_28 | Page_KLM | K, L, M | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_29 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_29 | Page_BC | B, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_29 | Page_D | D | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_29 | Page_E1 | E.1 | 45 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_29 | Page_E2 | E.2-E.5 | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_29 | Page_EF | E.6-E.7, F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_29 | Page_G | G | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_29 | Page_HI | H, I | 70 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_29 | Page_J | J | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_29 | Page_KLM | K, L, M | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_30 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_30 | Page_BC | B, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_30 | Page_D | D | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_30 | Page_E1 | E.1 | 45 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_30 | Page_E2 | E.2-E.5 | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_30 | Page_EF | E.6-E.8, F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_30 | Page_G | G | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_30 | Page_HI | H, I | 70 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_30 | Page_JK | J, K | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_30 | Page_LM | L, M | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_31 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_31 | Page_BC | B, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_31 | Page_D | D | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_31 | Page_E1 | E.1 | 45 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_31 | Page_E2 | E.2-E.5 | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_31 | Page_EF | E.6-E.8, F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_31 | Page_G | G | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_31 | Page_HI | H, I | 70 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_31 | Page_JK | J, K | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_31 | Page_LM | L, M | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_32 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_32 | Page_BC | B, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_32 | Page_D | D | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_32 | Page_E1 | E.1 | 45 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_32 | Page_E2 | E.2-E.5 | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_32 | Page_EF | E.6-E.8, F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_32 | Page_G | G | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_32 | Page_HI | H, I | 70 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_32 | Page_JK | J, K | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_32 | Page_LM | L, M | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_33 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_33 | Page_BC | B, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_33 | Page_D | D | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_33 | Page_E1 | E.1 | 45 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_33 | Page_E2 | E.2-E.5 | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_33 | Page_EF | E.6-E.8, F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_33 | Page_G | G | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_33 | Page_HI | H, I | 70 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_33 | Page_JK | J, K | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_33 | Page_LM | L, M | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_34 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_34 | Page_BC | B, C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_34 | Page_D | D | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_34 | Page_E1 | E.1 | 45 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_34 | Page_E2 | E.2-E.5 | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_34 | Page_EF | E.6-E.8, F | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_34 | Page_G | G | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_34 | Page_HI | H, I | 70 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_34 | Page_JK | J, K | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CIT8_34 | Page_LM | L, M | 80 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITCSR_1 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITCSR_1 | Page_CDE | C, D, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITCSR_2 | Page_A | Ogólne, A | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITCSR_2 | Page_CDE | C, D, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_3 | CITD_3_1 | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_3 | CITD_3_2 | C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_3 | CITD_3_3 | D, E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_4 | CITD_4_1 | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_4 | CITD_4_2 | C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_4 | CITD_4_3 | D, E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_5 | CITD_5_1 | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_5 | CITD_5_2 | C | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_5 | CITD_5_3 | D, E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_6 | CITD_6_1 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_6 | CITD_6_2 | C.1-C.3 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_6 | CITD_6_3 | C.4 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_6 | CITD_6_4 | D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_7 | CITD_7_1 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_7 | CITD_7_2 | C.1-C.3 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_7 | CITD_7_3 | C.4-C.5 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_7 | CITD_7_4 | D, E | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_8 | CITD_8_1 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_8 | CITD_8_2 | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_8 | CITD_8_3 | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITD_8 | CITD_8_4 | E, F | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITEZ_2 | Page_0 | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITEZ_2 | Page_BE | B - E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITEZ_2 | Page_F | F | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITEZ_3 | Page_0 | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITEZ_3 | Page_BD | B - D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITEZ_3 | Page_E | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITF_1 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITF_1 | Page_B | B.1-B.3 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITF_1 | Page_BC | B.4,C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_2 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_2 | Page_BCD | B, C, D | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_2 | Page_EF | E, F | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_2 | Page_G | G | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_3 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_3 | Page_BCD | B, C, D | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_3 | Page_EF | E, F | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_3 | Page_G | G | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_4 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_4 | Page_BCD | B, C, D | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_4 | Page_EF | E, F | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_4 | Page_G | G | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_5 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_5 | Page_BCD | B, C, D | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_5 | Page_EF | E, F | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITIP_5 | Page_G | G | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_1 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_1 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_1 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_1 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_1 | Page_EFG | E, F, G | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_2 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_2 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_2 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_2 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_2 | Page_EFG | E, F, G | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_3 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_3 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_3 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_3 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_3 | Page_EFG | E, F, G | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_4 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_4 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_4 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_4 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITKW_4 | Page_EFG | E, F, G | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_1 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_1 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_1 | Page_B2 | B2 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_1 | Page_B3 | B3 | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_1 | Page_B4 | B4 | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_2 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_2 | Page_B1 | B1 | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_2 | Page_B2 | B2 | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_2 | Page_B3 | B3 | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_2 | Page_B4 | B4 | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_3 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_3 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITMIT_3 | Page_C | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITM_2 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITM_2 | Page_ABC | A, B, C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITM_2 | Page_D | D | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITRB_1 | Page_A | Ogólne, A, B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITRB_1 | Page_CD | C, D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITRB_2 | Page_A | Ogólne, A, B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITRB_2 | Page_CD | C, D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITST | Zalaczniki | Załączniki | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITSTA | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITSTA_Multi | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITST_7 | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITST_7 | Oddzialy | Oddziały | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITST_7_Multi | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITST_8 | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITST_8 | Oddzialy | Oddziały | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITST_8_Multi | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWOT_1 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWOT_1 | Page_B1 | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWOT_1 | Page_C | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_1 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_1 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_1 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_1 | Page_D | D | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_1 | Page_E | E | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_2 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_2 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_2 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_2 | Page_D | D | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_2 | Page_E | E | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_3 | Page_0 | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_3 | Page_B | B | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_3 | Page_C | C | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_3 | Page_D | D | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CITWZ_3 | Page_E | E | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CRMResources | CRMResources | Ogolne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| CRUApiKey | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| CRUContract | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| CUK | CUK_1_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CUK_1 | CUK_1_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CUK_2 | CUK_2_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CelOkresowyPracownika | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CelRezerwacji | General | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| CeleSkladaniaOswiadczen | CeleSkladaniaOswiadczen | Ogólne/Ochrona danych osobowych/Cele przetwarzania | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Cena | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| CenaGrupowa | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| CenaIndywidualna | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| CenaProgowa | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| CenaProgowa-ProgiWorker | Progi | Progi cen | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| CentraKosztow | CentraKosztow | Ogólne/Centra kosztów | 5 | Soneta.Core.UI.dll | Soneta.Core |
| CentralPlanManagementParams | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| CentralaOddzialFirmyCzlonkowie | CentralaOddzialFirmyCzlonkowie | Członkowie/Ustawienia | 100 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CentralaOddzialFirmySzkolenia | CentralaOddzialFirmySzkolenia | Szkolenia/Ustawienia | 51 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CentrumKosztow | CentrumKosztow | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| CenyRabatyProgowe-EdycjaWorker | ProgiCen | Progi cen | 1 | Soneta.Handel.UI.dll | Soneta.Towary |
| CenyRabatyProgowe-EdycjaWorker | ProgiRabatow | Progi rabatów | 1 | Soneta.Handel.UI.dll | Soneta.Towary |
| Cesja | Cesja | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| CfgAKC2 | CfgAKC2 | Ewidencja akcyzy/Deklaracja AKC-2 | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgCitKsOgolne | CfgCitKsOgolne | Księgowość/Deklaracje/CIT-8ST | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgCitOgolne | CfgCitOgolne | Kadry i płace/Deklaracje/CIT-ST | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgDefBadanLek | CfgDefBadanLek | Kadry i płace/Kadry/Definicje badań lekarskich | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefCzynnOb | CfgDefCzynnOb | Kadry i płace/Kalendarze/Definicje czynnosci na obiekcie | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefCzynnSzkod | CfgDefCzynnSzkod | Kadry i płace/Kadry/Definicje czynników szkodliwych i uciążliwych | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefDeklaracji | CfgDefDeklaracji | Ogólne/Definicje deklaracji | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgDefDodatkow | CfgDefDodatkow | Kadry i płace/Płace/Dodatki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefDokCore | CfgDefDokCore | Ewidencja dokumentów/Definicje dokumentów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| CfgDefDokHR | CfgDefDokHR | Kadry i płace/ZZL/Definicje dokumentów | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefDokKadry | CfgDefDokKadry | Kadry i płace/Kadry/Definicje dokumentów | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefDokOgolne | CfgDefDokOgolne | Ogólne/Ochrona danych osobowych/Definicje dokumentów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| CfgDefElemeOcenPrac | CfgDefElemeOcenPrac | Kadry i płace/ZZL/Kryteria ocen | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefElementow | CfgDefElementow | Kadry i płace/Płace/Elementy wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefElementowRozli | CfgDefElementowRozli | Kadry i płace/Płace/Elementy rozliczenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefJezykowObcych | CfgDefJezykowObcych | Kadry i płace/Kadry/Definicje języków obcych | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefNagrodKar | CfgDefNagrodKar | Kadry i płace/Kadry/Definicje nagród i kar | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefPlanListPlac | CfgDefPlanListPlac | Kadry i płace/Płace/Planowane listy płac | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefPlanZasobow | CfgDefPlanZasobow | ZKL/Definicje planowania zasobów | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefPodstawStazu | CfgDefPodstawStazu | Kadry i płace/Kadry/Definicje podstaw stażu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefRozlCzasPracy | CfgDefRozlCzasPracy | Kadry i płace/Kalendarze/Definicje dokumentów rozliczenia czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefStZnJObcych | CfgDefStZnJObcych | Kadry i płace/Kadry/Definicje stopni znajomości języków obcych | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefStanowiskZKL | CfgDefStanowiskZKL | ZKL/Stanowiska/Definicje stanowisk | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefStanowiskZZL | CfgDefStanowiskZZL | Kadry i płace/ZZL/Definicje stanowisk | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefStawekAkcyzy | CfgDefStawekAkcyzy | Ewidencja akcyzy/Definicje stawek akcyzy | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgDefStawekVAT | CfgDefStawekVAT | Ewidencja VAT/Definicje stawek VAT | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgDefSwiadczSocjal | CfgDefSwiadczSocjal | Kadry i płace/Kadry/Definicje świadczeń socjalnych | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefSzkolenBHP | CfgDefSzkolenBHP | Kadry i płace/Kadry/Definicje szkoleń BHP | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefSzkolenBHPSrebrna | CfgDefSzkolenBHPSrebrna | Kadry i płace/Kadry/Definicje szkoleń BHP | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefWydzialow | CfgDefWydzialow | Kadry i płace/Kadry/Kategorie jednostek organizacyjnych | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefinicjeAkordow | CfgDefinicjeAkordow | Kadry i płace/Kadry/Definicje akordów | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefinicjeAlgRCP | CfgDefinicjeAlgRCP | Kadry i płace/Kalendarze/RCP - algorytmy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefinicjeDni | CfgDefinicjeDni | Kadry i płace/Kalendarze/Definicje dni | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefinicjeFunkcji | CfgDefinicjeFunkcji | Kadry i płace/ZZL/Definicje funkcji | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefinicjeGrafikowPracy | CfgDefinicjeGrafikowPracy | Kadry i płace/Kalendarze/Definicje grafików | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefinicjeKregow | CfgDefinicjeKregow | Księgowość/Definicje kręgów | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgDefinicjeNieobecnosci | CfgDefinicjeNieobecnosci | Kadry i płace/Kalendarze/Definicje nieobecności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefinicjeRodzajuPracyZdalnej | CfgDefinicjeRodzajuPracyZdalnej | Kadry i płace/Kalendarze/Praca zdalna | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefinicjeStref | CfgDefinicjeStref | Kadry i płace/Kalendarze/Definicje stref | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefinicjeZdarzenRCP | CfgDefinicjeZdarzenRCP | Kadry i płace/Kalendarze/RCP - definicje zdarzeń | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDefinicjeZestawienCzasu | CfgDefinicjeZestawienCzasu | Kadry i płace/Kalendarze/Definicje zestawień czasu | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgDeklaracjeDochodowe | CfgDeklaracjeDochodowe | Księgowość/Deklaracje/PIT i CIT | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgDeklaracjeDochodoweKPiR | CfgDeklaracjeDochodoweKPiR | KPiR/Deklaracje/PIT i ryczałt | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgDeklaracjeOgolne | CfgDeklaracjeOgolne | Ogólne/Deklaracje | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgDodRodzinny | CfgDodRodzinny | Kadry i płace/Płace/Świadczenia rodzinne (historyczne) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgEDeklaracjeOgolne | CfgEDeklaracjeOgolne | Ogólne/eDeklaracje | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgEtapyRealizacjiSzkolen | CfgEtapyRealizacjiSzkolen | Kadry i płace/Szkolenia/Etapy realizacji szkoleń | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgEwidencjaDokumentow | CfgEwidencjaDokumentow | Ewidencja dokumentów/Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| CfgEwidencjaVATOgolne | CfgEwidencjaVATOgolne | Ewidencja VAT/Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgFormularzPracownika | CfgFormularzPracownika | Kadry i płace/Formularze/Pracownika - pierwsza zakładka | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgFormularzPracownikaDodatkowa | CfgFormularzPracownikaDodatkowa | Kadry i płace/Formularze/Pracownika - dodatkowa zakładka | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgFormularzZaplaty | CfgFormularzZaplaty | Ewidencje ŚP/Formularze/Zapłata - Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| CfgFormularzeOgolnePt | CfgFormularzeOgolnePt | Kadry i płace/Formularze/Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgFormularzeOgolneZl | CfgFormularzeOgolneZl | Kadry i płace/Formularze/Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgFormyOrganizacjiPracy | CfgFormyOrganizacjiPracy | Kadry i płace/Kadry/Formy organizacji pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgFunduszePozyczkowe | CfgFunduszePozyczkowe | Kadry i płace/KZP, ZFM, .../Definicje KZP, ZFM, ... | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgGrupaStanow | CfgGrupaStanow | Kadry i płace/ZZL/Grupy stanowisk | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgGrupyKont | CfgGrupyKont | Księgowość/Grupy kont | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgGrupyZaszeregowania | CfgGrupyZaszeregowania | Kadry i płace/Kadry/Grupy zaszeregowania | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgHistoryczne | CfgHistoryczne | Kadry i płace/Kalendarze/Historyczne | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKRST | CfgKRST | Księga inwentarzowa/KRŚT | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgKalendarze | CfgKalendarze | Kadry i płace/Kalendarze/Kalendarze | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKalendarzeOgolne | CfgKalendarzeOgolne | Kadry i płace/Kalendarze/Czas pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKanalyZglSygnal | CfgKanalyZglSygnal | Ogólne/Sygnaliści/Kanały zgłoszeń | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKatCzynnSzkod | CfgKatCzynnSzkod | Kadry i płace/Kadry/Kategorie czynników szkodliwych i uciążliwych | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKatGrupyStan | CfgKatGrupyStan | Kadry i płace/ZZL/Kategorie grup stanowisk | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKatZglSygnal | CfgKatZglSygnal | Ogólne/Sygnaliści/Kategorie zgłoszeń | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKategorie | CfgKategorie | Księga inwentarzowa/Kategorie | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgKategoriePracownikow | CfgKategoriePracownikow | Kadry i płace/Kadry/Kategorie pracowników | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKategorieSzkolen | CfgKategorieSzkolen | Kadry i płace/Szkolenia/Kategorie szkoleń | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKategorieUprawnien | CfgKategorieUprawnien | Kadry i płace/Szkolenia/Kategorie uprawnień | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKodyWykZawodow | CfgKodyWykZawodow | Kadry i płace/Kadry/Kody wykonywanych zawodów (GUS) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgKrajeDelegacji | CfgKrajeDelegacji | Delegacje/Stawki rozliczeniowe | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgLimityNieobecnosci | CfgLimityNieobecnosci | Kadry i płace/Kalendarze/Limity nieobecności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgLimityNieobecnosciPl | CfgLimityNieobecnosciPl | Kadry i płace/Kalendarze/Limity nieobecności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgListyPlac | CfgListyPlac | Kadry i płace/Płace/Listy płac | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgMiejscaUzytkowania | CfgMiejscaUzytkowania | Księga inwentarzowa/Miejsca użytkowania | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgNfz | CfgNfz | Kadry i płace/Deklaracje/NFZ | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgNieobecnosci | CfgNieobecnosci | Kadry i płace/Płace/Urlop wypoczynkowy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgOgolne | CfgOgolne | Kadry i płace/ZZL/Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgOgolneSygnal | CfgOgolneSygnal | Ogólne/Sygnaliści/Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgOkresyObrachunkowe | CfgOkresyObrachunkowe | Księgowość/Okresy obrachunkowe | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgOkresyObrachunkowe-KPIR | CfgOkresyObrachunkowe-KPIR | KPiR/Okresy obrachunkowe | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgOpisAnalityczny | CfgOpisAnalityczny | Ogólne/Opis analityczny/Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgOpisAnalitycznyKwotaDodatkowa | CfgOpisAnalitycznyKwotaDodatkowa | Ogólne/Opis analityczny/Kwota dodatkowa | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgOpisAnalitycznyRozszerzenie | CfgOpisAnalitycznyRozszerzenie | Ogólne/Opis analityczny/Rozszerzenie | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgPPK | CfgPPK | Kadry i płace/Płace/PPK | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgPPKOgolne | CfgPPKOgolne | Kadry i płace/Deklaracje/PPK | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgPfron | CfgPfron | Kadry i płace/Deklaracje/PFRON | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgPfronHistoryczne | CfgPfronHistoryczne | Kadry i płace/Deklaracje/PFRON - historyczne | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgPfronPelnomocnik | CfgPfronPelnomocnik | Kadry i płace/Deklaracje/PFRON - dane pełnomocnika | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgPfronRozlicz | CfgPfronRozlicz | Kadry i płace/Deklaracje/PFRON - rozliczeniowe | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgPit | CfgPit | Kadry i płace/Deklaracje/PIT | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgPitHistoryczne | CfgPitHistoryczne | Kadry i płace/Deklaracje/PIT - historyczne | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgPitOgolne | CfgPitOgolne | Kadry i płace/Deklaracje/PIT - ogólne | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgPodatki | CfgPodatki | Kadry i płace/Płace/Podatki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgPodatkiInicjacja | CfgPodatkiInicjacja | Kadry i płace/Płace/Podatki inicjacja | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgPodatkiKPiR | CfgPodatkiKPiR | KPiR/Deklaracje/Podatek PIT - progi i ulgi | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgPodatkiKS | CfgPodatkiKS | Księgowość/Deklaracje/Podatek PIT - progi i ulgi | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgPodatkiRSP | CfgPodatkiRSP | Kadry i płace/Płace/Podatki RSP | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgPracaZdalna | CfgPracaZdalna | Kadry i płace/Płace/Praca zdalna | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgPrawaDostepu | CfgPrawaDostepu | Kadry i płace/Płace/Prawa dostępu | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgPrzyczRozwUmow | CfgPrzyczRozwUmow | Kadry i płace/Kadry/Przyczyny rozwiązania umowy o pracę | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgPrzyczZawUmow | CfgPrzyczZawUmow | Kadry i płace/Kadry/Przyczyny zawarcia umowy o pracę | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgRcp | CfgRcp | Kadry i płace/Kalendarze/RCP | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgRcpRegoly | CfgRcpRegoly | Kadry i płace/Kalendarze/RCP - reguły | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgRozliczenieNieobecnosci | CfgRozliczenieNieobecnosci | Kadry i płace/Płace/Nieobecności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgSchematyKsiegowe | CfgSchematyKsiegowe | Księgowość/Schematy księgowe | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgSerieDni | CfgSerieDni | Kadry i płace/Kalendarze/Serie dni | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgSkladkiInne | CfgSkladkiInne | Kadry i płace/Płace/Składki FP, FGŚP i FEP | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgSkladkiZUS | CfgSkladkiZUS | Kadry i płace/Płace/Składki ZUS | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgSkladkiZUSWskazniki | CfgSkladkiZUSWskazniki | Kadry i płace/Płace/Składki ZUS (wskaźniki) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgSlownikiKont | CfgSlownikiKont | Ogólne/Definicje słowników | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgSprawozdawczoscJPK | CfgSprawozdawczoscJPK | Księgowość/Sprawozdawczość JPK | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgSprawozdawczoscJPK-KPIR | CfgSprawozdawczoscJPK-KPIR | KPiR/Sprawozdawczość JPK | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgSrodkiTrwaleOgolne | CfgSrodkiTrwaleOgolne | Księga inwentarzowa/Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgStawkiZaKm | CfgStawkiZaKm | Ewidencja pojazdów/Stawki za km | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgStawkiZaKmPL | CfgStawkiZaKmPL | Kadry i płace/Płace/Stawki za km | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgSwiadczenia | CfgSwiadczenia | Kadry i płace/Płace/Świadczenia inne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgSzkoleniaOgolne | CfgSzkoleniaOgolne | Kadry i płace/Szkolenia/Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgTypyOplatMSR | CfgTypyOplatMSR | Księga inwentarzowa/Typy opłat MSR | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgTytulyDokumentowST | CfgTytulyDokumentowST | Księga inwentarzowa/Tytuły dokumentów | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| CfgUrlopyInne | CfgUrlopyInne | Kadry i płace/Płace/Urlopy inne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgVAT7 | CfgVAT7 | Ewidencja VAT/Deklaracje VAT - podstawowe | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgVAT7_9_BilansOtwarcia | CfgVAT7_9_BilansOtwarcia | Ewidencja VAT/Deklaracje VAT - bilans otwarcia/Sprzedaż, podatek naliczony | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgVAT7_9_BilansOtwarcia2 | CfgVAT7_9_BilansOtwarcia2 | Ewidencja VAT/Deklaracje VAT - bilans otwarcia/Korekty podatku naliczonego | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgVAT7_9_BilansOtwarcia_Hist | CfgVAT7_9_BilansOtwarcia_Hist | Ewidencja VAT/Deklaracje VAT - bilans otwarcia/Sprzedaż, podatek naliczony (historyczne) | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgWskazniki | CfgWskazniki | Kadry i płace/Płace/Wskaźniki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgWydzialy | CfgWydzialy | Kadry i płace/Kadry/Jednostki organizacyjne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgWynagrodzenia | CfgWynagrodzenia | Kadry i płace/Płace/Wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgWynagrodzeniePostojowe | CfgWynagrodzeniePostojowe | Kadry i płace/Płace/Wynagrodzenie postojowe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgWyszukania | CfgWyszukania | Kadry i płace/ZZL/Wyszukania | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgWzoryOcenPrac | CfgWzoryOcenPrac | Kadry i płace/ZZL/Wzory ocen | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZKL | CfgZKL | ZKL/Stanowiska/Konfigurator definicji stanowiska | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZKLOgolne | CfgZKLOgolne | ZKL/Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZaokraglenia | CfgZaokraglenia | Kadry i płace/Płace/Zaokrąglenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZasilekChorobowy | CfgZasilekChorobowy | Kadry i płace/Płace/Zasiłek chorobowy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZasilekInne | CfgZasilekInne | Kadry i płace/Płace/Zasiłki inne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZasilekOgolne | CfgZasilekOgolne | Kadry i płace/Płace/Zasiłki ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZasilekiHistoria | CfgZasilekiHistoria | Kadry i płace/Płace/Zasiłki (historyczne) | 150 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZdrowotneWls | CfgZdrowotneWls | Kadry i płace/Płace/Zdrowotne właścicieli (historyczne) | 160 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZestawyDodatkow | CfgZestawyDodatkow | Kadry i płace/Kadry/Zestawy dodatków | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZklSlowniki | CfgZklSlowniki | ZKL/Definicje słowników | 101 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CfgZus | CfgZus | Kadry i płace/Deklaracje/ZUS | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgZusHistoryczne | CfgZusHistoryczne | Kadry i płace/Deklaracje/ZUS - historyczne | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| CfgZusRozlicz | CfgZusRozlicz | Kadry i płace/Deklaracje/ZUS - rozliczeniowe | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ChangeCrmEmailPasswordParams | ContextQuery | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ChangeEmailPasswordParams | Ogolne | Zmiana hasła do konta e-mail | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ChangeGmailAuth | Ogolne | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ChangeInfo | ChangeInfo | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| ChangeInfo | ChangeInfoData | Dane dodatkowe | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ChangeInfo | ChangeInfoHtml | Wydruk | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ChangeInfo | Pdf | Wydruk | 100 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| ChangeInfoInNestedDatabasesViewList | Grid | General | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ChangeInfos | ChangeInfos | Systemowe/Zmiany rekordów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ChangeInfosConfig | ChangeInfosConfig | Systemowe/Zmiany ustawienia | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ChangeInfosWorker | ChangeInfosWorker | {DataSource} | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ChangeOutlookAuth | Ogolne | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ChangePasswordAuth | Ogolne | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ChangeReservationTermListWorkerParams | ChangeTerm | Zmiana terminu rezerwacji | 10000 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| ChangeTaskHistory | General | Historia procesu | 100 | Soneta.Business.dll | Soneta.Business |
| CheckCodeResult | BusinessCodeCheckResult | Ogólne (roslyn) | 0 | Soneta.Business.UI.dll | Soneta.Business |
| ChoiceLicence | Ogolne | Wybór licencji | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ChooseFolder | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ChosenFeatureItemsParams | Items | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| ChronoOrdDefEn | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ChronoOrdDefEn | ChronoOrdDefEn | DMS/Dostęp do składów | 900 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ChronoOrder | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ChronoOrder | ChronoOrderElem | Dokumenty w składzie | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ChronoOrderElem | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ChronoOrderLoc | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ChronoOrderLoc | ChronoOrderElem | Dokumenty w składzie | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ChronoOrderLoc | ChronoOrder | Składy | 200 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| CityRegion | Obszary | Obszary | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| ClosePreviousProfilParams | ClosePreviousProfil | Zmiana okresu obowiązywania | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CockpitAdjustments | CockpitAdjustments | Kokpity/Indywidualne ustawienia użytkowników | 100 | Soneta.Business.UI.dll | Soneta.Business |
| CockpitAreas | CockpitAreas | Kokpity/Obszary i kategorie | 100 | Soneta.Business.UI.dll | Soneta.Business |
| CockpitDashboard | Design | Design | 100 | Soneta.Business.UI.dll | Soneta.Business |
| CockpitDashboard | General | General | 100 | Soneta.Business.UI.dll | Soneta.Business |
| CockpitDashboard | Organize | Design | 100 | Soneta.Business.UI.dll | Soneta.Business |
| CockpitDashboards | CockpitDashboards | Kokpity/Definicje kokpitów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| CockpitGeneral | CockpitGeneral | Kokpity/Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| CockpitTemplates | CockpitTemplates | Kokpity/Wzorce kafelków | 100 | Soneta.Business.UI.dll | Soneta.Business |
| CodeFile | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| CodeFile | Editor | Edytor | 2 | Soneta.Core.UI.dll | Soneta.Core |
| CodeFiles | CodeFiles | Systemowe/Dodatkowy kod do kompilacji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ColumnDefinition | ColumnDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| Command | General | Folder testowy edytorów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ComparableObjectHost | ComparableObjectHostOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| CompilerConfig | CompilerConfig | Systemowe/Kompilator | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ConditionCreator | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ConfigDodatki | ConfigDodatki | CRM/Ogólne/Ustawienia i dodatki | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ConfigOPZOgolne | ConfigOPZOgolne | Praca hybrydowa/Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ConfigRegManager | General | Zarządzanie rejestrem konfiguracji | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ConfigWypozyczenia | ConfigWypozyczenia | Wypożyczenia/Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ConfigureCrmEmailSignatureWorkerDefaultSignaturesParams | ConfigureCrmEmailSignatureWorkerDefaultSignaturesParamsPage | Parametry | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ContentRecognitionChooseFiles | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ContextBindListDesigner | General | Pola | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ContextInitializerDesigner | General | Inicjacja | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ConversationParams | ExplorerGeneral | Rozpoczęcie dyskusji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ConversationParams | WebGeneral | Rozpoczęcie dyskusji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ConvertSystemRightsWorker-ConvertSystemRightsParams | Ogolne | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| CopyDashboardItemBasedOnSerializationParam | Param1 | Wybór definicji domeny | 1 | Soneta.BI.UI.dll | Soneta.BI |
| CopyDashboardItemBasedOnSerializationParam | Param2 |  | 1 | Soneta.BI.UI.dll | Soneta.BI |
| CopyModelToDataSourceParams | CopyModelToDataSourceParamsOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| CopyModelToDataSourceParams | TableSourcesMap | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| CountryRegion | Obszary | Obszary | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| CreateNextProfilParams | EndDate | Okres profilu | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CreateParams | Ogolne | Wybór licencji | 0 | Soneta.Business.UI.dll | Soneta.Business |
| CreatePivotFromSerializationViewParams | Params |  | 100 | Soneta.BI.UI.dll | Soneta.BI |
| CreatePivotReportParams | Params |  | 100 | Soneta.BI.UI.dll | Soneta.BI |
| CreateSerializationForSourcesParams | CreateSerializationOgolne | Parametry | 100 | Soneta.BI.UI.dll | Soneta.BI |
| CreateSerializationModelParams | Params |  | 100 | Soneta.BI.UI.dll | Soneta.BI |
| CrmDashboard | General | General | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| CrmDashboard | Organize | General | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| CtiSettings | CtiSettings | CRM/CTI/Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| CurrentDayWorker | General | Data | 100 | Soneta.Business.UI.dll | Soneta.Business |
| CustomDiagram | General | Diagram | 100 | Soneta.Business.UI.dll | Soneta.Business |
| CustomRegion | Obszary | Obszary | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| CustomReports | CustomReports | Raportowanie/REPX/Wzorce użytkownika | 508 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| CzasTechn | CzasTechnOgolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Czlonek | CzlonekZwyczajnySkladki | Składki | 100 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Czlonek | CzlonekHist | Historia | 120 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekRodziny | CzlonekRodzinyOgolne | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CzlonekRodziny | CzlonekRodzinyUbezpieczenie | Ubezpieczenie | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CzlonekRodziny | CzlonekRodzinyInne | Inne dane | 3 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CzlonekWspierajacy | CzlonekWspierajacyOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekWspierajacy | CzlonekWspierajacyAdresy | Adresy | 20 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekWspierajacy | CzlonekWspierajacyStatus | Status | 21 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyAdresy | Adresy | 20 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyKwalifikacje | Kwalifikacje | 20 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyStatus | Status | 21 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyDyplKsiegowy | Dyplomowany księgowy | 22 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyEUK | Cetryfkowany EUK | 23 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnySUPKRIP | Cetryfkowany SUPKRIP | 23 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyCertyfikaty | Certyfikaty | 25 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyFunkcje | Funkcje z wyboru | 25 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyOdznaczenia | Odznaczenia | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyZgloszenia | Zgłoszenia | 50 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyZajecia | Zajęcia | 60 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyZajeciaKalend | Kalendarz zajęć | 61 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyOdczyty | Odczyty | 62 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzlonekZwyczajny | CzlonekZwyczajnyKlubyKola | Kluby, koła | 70 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| CzynnikSzkodliwyPracownika | CzynnikSzkodliwyPracownika | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CzynnoscNaObiekcieDoPlanowania | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CzynnoscZadania | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| CzytnikRCP | CzytnikRCP | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DBGroup | DBGroup | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| DBGroupItem | DBGroupItem | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| DBGroups | DBGroups | Systemowe/Praca na wielu bazach/Grupy baz danych | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DBItem | DBItem | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| DBItem | DBItemOgolneMenadzer | Rozliczenia podatkowe | 10 | Soneta.EI.UI.dll | Soneta.EI |
| DBItem | DBItemPodglad | Podatki i ZUS | 11 | Soneta.EI.UI.dll | Soneta.EI |
| DBItem | DBItemPodatkiZus | Podatki i ZUS | 12 | Soneta.EI.UI.dll | Soneta.EI |
| DBItem | DBItemHandel | Handel | 13 | Soneta.EI.UI.dll | Soneta.EI |
| DBItem | DBItemEwidencjaSP | Ewidencja ŚP | 14 | Soneta.EI.UI.dll | Soneta.EI |
| DBItem | DBItemKsiegowosc | Księgowość | 20 | Soneta.EI.UI.dll | Soneta.EI |
| DBItem | DBItemKadryPlace | Kadry i Płace | 30 | Soneta.EI.UI.dll | Soneta.EI |
| DBItem | ElementyPodsumowania | Pulpit Klienta Biura | 35 | Soneta.Business.UI.dll | Soneta.Business |
| DBItem | DBItemZalaczniki | Zasobnik dokumentów | 40 | Soneta.EI.UI.dll | Soneta.EI |
| DBItemPKBROkRoz | DBItemPKBROkRoz |  | 0 | Soneta.EI.UI.dll | Soneta.EI |
| DBItemPkbrOkresRozliczeniowyWorkerParams | Params |  | 100 | Soneta.EI.UI.dll | Soneta.EI |
| DBItems | DBItems | Systemowe/Praca na wielu bazach/Bazy danych | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DBItemsManagerConfig | DBItemsManagerConfig | Systemowe/Praca na wielu bazach/Algorytmy | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DEK_R_v1 | DEKRv1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DEK_R_v1 | BlokC | Blok C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DEK_R_v2 | DEKRv2 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DEK_R_v2 | ObowiWypSklDek | Obowiązek wpłat i składanie deklaracji | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRA | DRA | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRA | DRAKwoty3 | Ubezpieczenia społeczne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRA | DRAKwoty | Rozliczenie | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRA | DRAKwoty2 | Ubezpieczenia pozostałe | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRA | DRAKwoty4 | Formy opodatkowania | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRA | DRARozliczenieZdrowotnej | Roczne rozliczenie składki zdrowotnej | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRA | DRAPodstawy | Deklaracja dochodu | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRA | DRAZalaczniki | Załączniki | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRA | DRAZobowiazania | Zobowiązania | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRA | DRAInformacjeKsiegowe | Informacje księgowe | 61 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DRAII | DRA | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Damage | General | Ogólne | 11 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DamageEvent | General | Ogólne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| DamageEvent | Attachements | Załączniki | 100 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| DaneKontaktowe | DaneKontaktoweOgolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DaneZViesWorkerParams | DaneZVies | Dane z VIES | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| DaneZewn | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| DashBrdItemDefs | DashBrdItemDefs | BI/Prezentacja danych/Definicje wizualizacji | 1150 | Soneta.BI.UI.dll | Soneta.BI |
| DashParamSets | DashParamSets | BI/Prezentacja danych/Zestawy parametrów | 1162 | Soneta.BI.UI.dll | Soneta.BI |
| Dashboard | Informacje | Biuro Rachunkowe | -3 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | DaneFirmy | Dane firmy | -2 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | DaneFirmyPremium | Dane firmy | -2 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | PanelSkrotowKB | Pulpit Klienta Biura Rachunkowego | -2 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | PanelSkrotow | Nowe elementy | -1 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | PanelSkrotowPremium | Nowe elementy | -1 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | ZasobnikDokumentow | Zasobnik dokumentów | -1 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | ContractorInfo | CRM/- Kontrahent | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | Koszyki | Koszyki | 0 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | KoszykiPremium | Koszyki | 0 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | PanelInformacyjny | Panel informacyjny | 0 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | PanelPowitalnyKBR | Panel informacyjny | 0 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | WyborKontrahenta | Wybór kontrahenta | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | DashboardPowitanie | Powitanie | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | MojeZgloszenia | Moje zgłoszenia | 1 | Soneta.Support.UI.dll | Soneta.Support |
| Dashboard | NoweZgloszenie | Nowe zgłoszenie | 1 | Soneta.Support.UI.dll | Soneta.Support |
| Dashboard | TowaryIUslugi | Towary i usługi | 1 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | NoweElementy | Nowe elementy zadania | 2 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | PracownikInfo | Pracownik | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | Zamowienia | Zamówienia | 2 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | Zgloszenia | Zgloszenia | 2 | Soneta.Support.UI.dll | Soneta.Support |
| Dashboard | ListaZadan | Lista zadań | 3 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | MoiKontrahenci | Moi kontrahenci | 3 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | NowaOfertaDostawcy | Nowa oferta | 3 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | NoweZamowienie | Nowe zamówienie | 3 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | Favorites | Ulubione | 4 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | FavoritesPremium | Nawigacja/Ulubione | 4 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | ZestawienieLeadow | Zestawienie leadów | 4 | Soneta.CRM.UI.dll | Soneta.CRM |
| Dashboard | ZestawienieZadan | Zestawienie zadań CRM | 4 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | ZestawienieZadanPremium | Zestawienie zadań CRM | 4 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | Faktury | Faktury | 5 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | TaskListStandard | Powiadomienia | 5 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | ZestawienieTransakcji | Zestawienie transakcji | 5 | Soneta.CRM.UI.dll | Soneta.CRM |
| Dashboard | ZestawienieLeadowWgZrodel | Zestawienie leadów według źródeł | 6 | Soneta.CRM.UI.dll | Soneta.CRM |
| Dashboard | ZestawienieTransakcjiWgZrodel | Zestawienie transakcji według źródeł | 7 | Soneta.CRM.UI.dll | Soneta.CRM |
| Dashboard | ZestawienieLeadowWgPriorytetu | Zestawienie leadów według priorytetu | 8 | Soneta.CRM.UI.dll | Soneta.CRM |
| Dashboard | ZestawienieTransakcjiWgPriorytetu | Zestawienie transakcji według priorytetu | 9 | Soneta.CRM.UI.dll | Soneta.CRM |
| Dashboard | ContactPerson | CRM/- Osoby Kontaktowe | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | KSeFPobrane | KSeF - pobrane pliki | 10 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | OfertyOdDostawcy | Oferty od dostawcy | 10 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | Przelewy | Przelewy | 10 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | TimeRecorder | Rejestracja czasu pracy | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | FakturySprzedazy | Faktury sprzedaży | 11 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | Przyciski | Zestaw skrótów | 11 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | BasicDocuments | Rejestr dokumentów elektronicznych | 12 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | NotificationsFromSlave | Zadania oczekujące | 13 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | RozrachunkiKlientaBR | Rozrachunki z biurem | 14 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | ZamkniecieMiesiaca | Zamknięcie miesiąca | 14 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | LimitUrlopow | Limity | 15 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | Rozliczenia | Rozliczenia | 15 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | ZestawienieTransakcjiWgTemperatury | Zestawienie transakcji według temperatury | 17 | Soneta.CRM.UI.dll | Soneta.CRM |
| Dashboard | ZestawienieLeadowWgTemperatury | Zestawienie leadów według temperatury | 18 | Soneta.CRM.UI.dll | Soneta.CRM |
| Dashboard | ContractorReceivables | CRM/- Należności | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | Oferty | Oferty | 20 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | Zapytania | Zapytania | 20 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | ZestawienieCzasuPracy | Zestawienie czasu pracy | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | StrukturaNaleznosci | Struktura należności | 25 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | StrukturaNaleznosciPremium | Struktura należności | 25 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | StrukturaZobowiazan | Struktura zobowiązań | 25 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | Wnioski | Wnioski | 25 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | CrmEvents | CRM/- Zdarzenia | 30 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | CrmTasks | CRM/- Zadania | 40 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | MojGrafik | Mój grafik | 45 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | MojZespolGrafik | Grafik zespołu | 45 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | ConversationsStandard | Konwersacje | 50 | Soneta.Core.UI.dll | Soneta.Core |
| Dashboard | Leads | CRM/- Leady | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | AktualnosciStandard | Aktualności | 55 | Soneta.Core.UI.dll | Soneta.Core |
| Dashboard | ArticlesRepositoryStandard | Biblioteka | 60 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| Dashboard | Transactions | CRM/- Transakcje | 60 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | Worksite | Rezerwacja stanowiska pracy | 65 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| Dashboard | Shopping | CRM/- Ranking produktów | 70 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | ZadaniaDnia | MojeZadania | 70 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | WnioskiPrzetwarzane | Lista przetwarzanych wniosków | 71 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | PulpityZasobnikDokumentow | Dokumenty | 75 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | ContractorDocuments | CRM/- Dokumenty sprzedaży | 80 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | AddRow | Czynności/Dodawanie | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | Algorithm | Czynności/Algorytm | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | BI | BI | 100 | Soneta.BI.UI.dll | Soneta.BI |
| Dashboard | BIChart | BI/Wykres | 100 | Soneta.BI.UI.dll | Soneta.BI |
| Dashboard | BIIndicator | BI/Wskaźnik | 100 | Soneta.BI.UI.dll | Soneta.BI |
| Dashboard | BIParamsPanel | BI/Panel parametrów | 100 | Soneta.BI.UI.dll | Soneta.BI |
| Dashboard | BIPivot | BIPivot | 100 | Soneta.BI.UI.dll | Soneta.BI |
| Dashboard | BIPivotPremium | BI/Tabela przestawna | 100 | Soneta.BI.UI.dll | Soneta.BI |
| Dashboard | BITable | BI/Tabela | 100 | Soneta.BI.UI.dll | Soneta.BI |
| Dashboard | Comment | Pozostałe/Komentarz | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | ContextBinder | Dane/Łączenie kontekstów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | ContextInitializer | Dane/Filtry | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | Fields | Dane/Zestaw danych | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | Image | Pozostałe/Zdjęcie | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | ListGroup | Pozostałe/Lista kafelków | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | Lookup | Dane/Wybór obiektu | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | Map | Dane/Mapa | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | MultiAction | Czynności/Lista czynności | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | MultiFolder | Nawigacja/Lista folderów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | MultiLookup | Dane/Wybór wielu obiektów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | MultiReport | Czynności/Lista raportów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | NavigateCockpit | Nawigacja/Kokpit | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | Operator | Pozostałe/Informacja o użytkowniku | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | PracownikInfoPremium | Pracownik | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | ProcesWorkflow | Czynności/Uruchom proces workflow | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| Dashboard | RozliczenieFirmy | Firma - rozliczenie miesiąca | 100 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | Scheduler | Pozostałe/Kalendarz | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | SingleAction | Czynności/Uruchom czynność | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | SingleFolder | Nawigacja/Folder | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | SingleOption | Czynności/Opcje programu | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | SingleReport | Czynności/Przygotuj raport | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | Table | Dane/Lista danych | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | LimitUrlopowPremium | Pozostałe/Limity | 101 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | TimeRecorderPremium | Pozostałe/Rejestracja czasu pracy | 101 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | TimeRecorderPulpitPremium | Pozostałe/Rejestracja czasu pracy | 101 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Dashboard | WorksitePremium | Pozostałe/Rezerwacja stanowiska pracy | 101 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| Dashboard | WorksitePulpitPremium | Pozostałe/Rezerwacja stanowiska pracy | 101 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| Dashboard | WnioskiPremium | Wnioski | 102 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | AktualnosciPremium | Pozostałe/Aktualności | 103 | Soneta.Core.UI.dll | Soneta.Core |
| Dashboard | ArticlesRepositoryPremium | Pozostałe/Biblioteka | 103 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| Dashboard | ConversationsPremium | Pozostałe/Konwersacje | 103 | Soneta.Core.UI.dll | Soneta.Core |
| Dashboard | WykresSprzedazy | Wykres obrotów | 203 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Dashboard | TaskListPremium | Pozostałe/Powiadomienia | 1000 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | PulpityZasobnikDokumentowPremium | Dokumenty | 1001 | Soneta.Business.UI.dll | Soneta.Business |
| Dashboard | PulpityRSS | Informacje RSS | 1002 | Soneta.Net.Business.dll | Soneta.Net |
| Dashboard | WnioskiPrzetwarzanePremium | Lista przetwarzanych wniosków | 1002 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Dashboard | DeklaracjeVAT | Deklaracje VAT | 10003 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | PodatekDochodowy | Deklaracje podatku dochodowego | 10004 | Soneta.EI.UI.dll | Soneta.EI |
| Dashboard | Opiekun | Opiekun w biurze | 10005 | Soneta.EI.UI.dll | Soneta.EI |
| DashboardArea | General | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| DashboardItem | DashboardItemOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardItemDefinition | DashboardItemDefinitionDescription | Opis wizualizacji | 1000 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardItemDefinition | DashboardItemDefinitionRelatedViews | Lokalizacja wizualizacji | 1000 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardItemField | DashboardItemFieldOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardItemVisualizationParams | Params |  | 100 | Soneta.BI.Reports.dll | Soneta.BI |
| DashboardLocation | DashboardLocation | BI/Prezentacja danych/Banery BI wizualizacje | 1190 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardManager | DashboardManagerOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardParamSetHost | DashboardParamSetHostOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardParamSetManager | DashboardParamSetManagerOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardView | GeneralBI | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardView | GeneralCockpit | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| DashboardView | GeneralTemplate | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| DashboardView | Adjustments | Indywidualne ustawienia użytkowników | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DashboardView | Design | Projektuj | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DashboardView | Edit | Opcje dodatkowe | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DashboardView | ItemsBI | Wizualizacje | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardView | Tiles | Kafelki | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DashboardView | TilesBI | Kafelki | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardViewLocation | DashboardViewLocationOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardViewLocation | DashboardViewLocationTiles | Kafelki | 2 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardViewLocation | DashboardViewLocationItems | Wizualizacje | 3 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardViewLocation | DashboardViewLocation | BI/Prezentacja danych/Panele BI formularzy | 1161 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardViewParamSet | DashboardViewParamSetOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DashboardViewTile | General | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| DashboardViewTile | Params | Parametry | 1 | Soneta.Business.UI.dll | Soneta.Business |
| DashboardViewTileAddChildrenExtender | General | Pola | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DataModel | AnalysisAreas | Obszary | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelCalculatorWorker | DataModelCalculatorWorkerOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelCondition | StructureCondition | Warunek | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelCondition | StructureExtendCondition | Dodatkowy warunek | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelFields | StructureFields | Pola | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelGroupBy | StructureGroupBy | Grupowania | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelReportParams | StructureReportParams | Parametry | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelSerializationDefinition | Fields | Pola | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelSerializationDefinition | General | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelUpdateListener | DataModelUpdateListener | BI/Modele danych/Aktualizacja praw SQL | 1150 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelWithBusinessField | Ogolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DataModelWithTimeSpanSqlPreviewWorker | SqlPreview | Podgląd Sql | 2 | Soneta.BI.UI.dll | Soneta.BI |
| DataModels | DataModels | BI/Modele danych/Modele danych | 1100 | Soneta.BI.UI.dll | Soneta.BI |
| DataSetCalculatorWorker | DataSetCalculatorWorkerOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DataSetDefinition | DataSetDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DataSetDefinition | DataSetDefinitionCalculate | Kalkulacja | 2 | Soneta.BI.UI.dll | Soneta.BI |
| DataSetDefs | DataSetDefs | BI/Utrwalanie danych/Definicje zestawów danych | 1200 | Soneta.BI.UI.dll | Soneta.BI |
| DataSetGeneratorDefinition | DataSetGeneratorDefinitionOgolne | Ogólne | 2 | Soneta.BI.UI.dll | Soneta.BI |
| DataSources | DataSources | BI/Źródła danych | 1101 | Soneta.BI.UI.dll | Soneta.BI |
| DataSpanItemAppearance | DataSpanItemAppearanceOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DataSpanItemDefinition | DataSpanItemDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DataSpanSetDefinition | DataSpanSetDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| DataSpanSetDefs | DataSpanSetDefs | BI/Prezentacja danych/Zestawy przedziałów danych | 1180 | Soneta.BI.UI.dll | Soneta.BI |
| DbTuple | DbTuple | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| DbTupleDefinition | DbTupleDefinition | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| DbTupleDefinition | Additional | Dodatkowe | 2 | Soneta.Core.UI.dll | Soneta.Core |
| DbTupleDefinition | ProcessStructure | Struktura procesu | 18 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| DbTupleDefinition | EngineEdytor | Algorytm procesu | 19 | Soneta.Core.UI.dll | Soneta.Core |
| DbTupleDefinition | ClassEdytor | Edytor | 20 | Soneta.Core.UI.dll | Soneta.Core |
| DbTupleDefinition | CalcEdytor | Edytor (kalkulator) | 21 | Soneta.Core.UI.dll | Soneta.Core |
| DbTupleDefinition | DefZadan | Definicje zadań | 90 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DbTupleDefinition | DokEwidencjaDbTupleExt | DokEwidencja | 90 | Soneta.Core.UI.dll | Soneta.Core |
| DbTupleDefinition | PracDbTupleExt | Pracownicy | 90 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DbTupleDefinition | Zadania | Zadania | 90 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DbTupleDefinition | Dependent | Definicje dokumentów zależnych | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DbTupleRel | DbTupleRel | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| DefAktKalendarzy | DefAktKalendarzy | Kadry i płace/Kalendarze/Wersjonowanie kalendarzy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefAlgorytmRCP | DefAlgorytmRCP | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefAlgorytmRCP | DefAlgorytmRCPAlgorytm | Algorytm | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefArkuszyOcen | DefArkuszyOcen | CRM/Oceny/Definicje arkuszy ocen | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefArkuszyOcenHR | DefArkuszyOcenHR | Kadry i płace/Oceny/Definicje arkuszy ocen | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefBudget | BudgetPeriods | Okresy budżetowe | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefBudget | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefBudget | PlanVariants | Warianty planów | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefBudgetAspect | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefBudgetAspect | Algorithm | Algorytm | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefBudgetAspects | DefBudgetAspects | Projekty i Budżetowanie/Perspektywy realizacji | 109 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefBudgetCategories | DefBudgetCategories | Projekty i Budżetowanie/Kategorie budżetowe OA | 108 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefBudgetCategory | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefBudgetCategory | Relations | Rozliczane kategorie | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefBudgetCategoryRelation | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefBudgets | DefBudgets | Projekty i Budżetowanie/Definicje budżetów | 102 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefCertyfikatow | DefCertyfikatow | Szkolenia/Definicje certyfikatów | 53 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefDiscussion | General | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| DefDiscussion | AddInsConfig | Konfiguracja rozszerzeń | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DefDiscussion | AddIns | Rozszerzenia | 20 | Soneta.Core.UI.dll | Soneta.Core |
| DefDiscussion | Engine | Edytor | 40 | Soneta.Core.UI.dll | Soneta.Core |
| DefDiscussions | DefDiscussions | Ogólne/Dyskusje/Definicje dyskusji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DefDokDelegacje | DefDokDelegacje | Delegacje/Definicje dokumentów | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefDokHandlowego | DefDokOgolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokHandlowego | DefDokNumeracja | Numeracja | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokHandlowego | DefDokSlownikSerii | Słownik serii | 21 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokHandlowego | DefDokWydruki | Wydruki | 25 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokHandlowego | DefDokWprowadzanie | Nagłówek | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokHandlowego | DefDokFormularz | Pozycje | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokHandlowego | DefDokPozostale | Pozostałe | 50 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokHandlowego | DefDokMagazyny | Magazyn | 60 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| DefDokHandlowego | DefDokRelacje | Relacje | 70 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokHandlowego | DefDokKonfiguracjaOstrzezen | Konfiguracja ostrzeżeń | 80 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokHandlowego | DefDokKSeF | KSeF | 90 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokHandlowych | DefDokHandlowych | Handel/Definicje dokumentów/Wszystkie | 1100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokKasa | DefDokKasa | Ewidencje ŚP/Definicje dokumentów | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DefDokKsiega | DefDokKsiega | Księgowość/Definicje dokumentów | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefDokKsiega-KPIR | DefDokKsiega-KPIR | KPiR/Definicje dokumentów | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefDokNotaOdsetkowa | NotaOdsetkowa | Nota odsetkowa | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DefDokPodrzednego | Ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefDokPreliminarze | DefDokPreliminarze | Ewidencje ŚP/Preliminarz/Definicje dokumentów | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DefDokRozliczeniowego | DefinicjaDokumentuRozliczeniowego | Rozliczeniowy | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DefDokSamochodowka | DefDokSamochodowka | Ewidencja pojazdów/Definicje dokumentów | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefDokSrodkiTrwale | DefDokSrodkiTrwale | Księga inwentarzowa/Definicje dokumentów | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefEksportImport | DefEksportImport | Handel/Definicje dokumentów/Eksport i import | 900 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefElementowOcen | DefElementowOcen | CRM/Oceny/Definicje elementów ocen | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefElementowOcenHR | DefElementowOcenHR | Kadry i płace/Oceny/Definicje elementów ocen | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefElementuOcenyPracownika | DefElementuOcenyPracownika | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefElementuOcenyPracownika | DefElementuOcenyPracownikaWartosci | Słownik | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefEtaRekrutacji | DefEtaRekrutacji | Kadry i płace/ZZL/Definicje etapów rekrutacji | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefEwidencji | DefinicjaEwidencji | Rozszerzenie definicji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DefFleet | DefFleet | Flota/Definicje zdarzeń | 4 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| DefKampania | DefKampaniaOgolne | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefKampanii | DefKampanii | CRM/Definicje dokumentów/Definicje kampanii | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefKampaniiProjektowych | DefKampaniiProjektowych | Projekty i Budżetowanie/Definicje kampanii | 103 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefKategKth | DefKategKthOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefKategoriiKth | DefKategoriiKth | Kontrahenci i urzędy/Kategorie | 1000 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefKompletacja | DefKompletacja | Handel/Definicje dokumentów/Kompletacja | 200 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefKorekty | DefKorekty | Faktury/Korekty | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefKorektyMagazyny | DefKorektyMagazyny | Handel/Definicje dokumentów/Korekty | 300 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefKoresp | DefKorespOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefKoresp | DefKorespStany | Stany korespondencji | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefKoresp | DefKoresp | CRM/Definicje dokumentów/Definicje korespondencji | 70 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefLeada | DefLeadaOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefLeada | DefLeadaStany | Stany | 20 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefLeada | DefLeadaAdditional | Dodatkowe | 30 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefLeada | DefLeadaPriorytety | Priorytety | 30 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefLeada | DefLeadaTemperatury | Temperatury | 35 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefLeada | DefLeadaKalkulatorCode | Kod kalkulatora leada | 40 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefLeada | ProcessStructure | Struktura procesu | 49 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefLeada | EngineEdytor | Algorytm procesu | 50 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefLeadow | DefLeadow | CRM/Definicje dokumentów/Definicje leadów | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefMagazynowe | DefMagazynowe | Handel/Definicje dokumentów/Magazynowe | 400 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefMediaSettle | DefMediaSettle | Nieruchomości/Definicje rozliczeń mediów | 11 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefOdpadyHandel | DefOdpadyHandel | Handel/Definicje dokumentów/Gospodarowanie odpadami | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefOdznaczen | DefOdznaczen | Członkowie/Definicje odznaczeń | 110 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefOpakowania | DefOpakowania | Handel/Definicje dokumentów/Opakowania i kaucje | 500 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefPaczekPrzel | DefPaczekPrzel | Ewidencje ŚP/Paczki przelewów/Definicje paczek przelewów | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DefPlanSprzed | DefPlanSprzed | CRM/Plany sprzedażowe/Definicje planów | 200 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefPlanVersion | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefPlanVersions | DefPlanVersions | Projekty i Budżetowanie/Definicje wersji planów | 105 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefPlanuSprzedazy | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefPlanuSprzedazy | Algorithm | Algorytm planu | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefPodstawyStazu | DefPodstawyStazu | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefPolis | DefPolis | Nieruchomości/Definicje polis | 5 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefPomiarow | DefPomiarow | Nieruchomości/Definicje zdarzeń/Definicje pomiarów | 4 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefPoswOdbioru | DefPoswOdbioru | Kadry i płace/Kadry/Definicje poświadczeń odbioru | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DefPowstaniaObowiazkuAkcyzy | DefPowstaniaObowiazkuAkcyzy | Ewidencja akcyzy/Definicje powstania obowiązku akcyzy | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefPowstaniaObowiazkuVAT | DefPowstaniaObowiazkuVAT | Ewidencja VAT/Definicje powstania obowiązku VAT | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefProjects | DefProjects | Projekty i Budżetowanie/Definicje projektów | 104 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefProjektow | DefProjektow | CRM/Definicje dokumentów/Definicje projektów | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefProjektu | DefProjektuOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefProjektu | DefProjektuEtapyDefProjektu | Etapy definicji projektu | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefProjektu | DefProjektuStany | Stany projektu | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefProjektu | DefProjektuOpcje | Opcje | 25 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefProjektu | ProcessStructure | Struktura procesu | 49 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefProjektu | DefProjektuKalkulatorCode | Kod kalkulatora projektu | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefProjektu | EngineEdytor | Algorytm procesu | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefProjektu | Additional | Dodatkowe | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefPrzesuniecia | DefPrzesuniecia | Handel/Definicje dokumentów/Przesunięcia magazynowe | 600 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRealizacjiPlanow | DefRealizacjiPlanow | CRM/Plany sprzedażowe/Definicje realizacji planów | 210 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefRealizacjiPlanu | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefRealizacjiPlanu | Towary | Towary | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefRealizacjiPlanu | Kontrahenci | Kontrahenci | 30 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefRealizacjiPlanu | Algorithm | Algorytm realizacji | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefRegistrationTime | DefRegistrationTime | Praca hybrydowa/Definicje rejestracji czasu pracy | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefRelacjiCykliczna | DefRelacjiOgolneUproszczona | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiCykliczna | DefRelacjiWywolanie | Wywołanie | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiCykliczna | DefRelacjiZachowanie | Zachowanie | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiCykliczna | DefRelacjiPozycje | Pozycje | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiCyklicznaFakturowanieRezultat | DefRelacjiCyklicznaFakturowanieRezultat | Faktury | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiInwentaryzacja | DefRelacjiZachowanie | Zachowanie | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiKaucji | DefRelacjiOgolneUproszczona | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiKompletacji | DefRelacjiZachowanie | Zachowanie | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiKopiowania | DefRelacjiOgolneZListaPodrzednych | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiKopiowania | DefRelacjiWywolanie | Wywołanie | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiKopiowania | DefRelacjiNaglowek | Nagłówek | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiKopiowania | DefRelacjiPozycje | Pozycje | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiKopiowania | DefRelacjiKorektyAutomatyczne | Korekty automatyczne | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiKorekta | DefRelacjiOgolne | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiKorekta | DefRelacjiZachowanie | Zachowanie | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiProdukcja | DefRelacjiOgolneUproszczona | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiProdukcja | DefRelacjiWywolanie | Wywołanie | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiProdukcja | DefRelacjiNaglowek | Nagłówek | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiProdukcja | DefRelacjiPozycje | Pozycje | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiProdukcja | DefRelacjiKorektyAutomatyczne | Korekty automatyczne | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiPrzesuniecia | DefRelacjiKplMm | Zachowanie | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRelacjiZaliczki | DefRelacjiOgolneUproszczona | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefRent | DefRent | Nieruchomości/Definicje zdarzeń/Definicje najmu | 4 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefRodzajSzkol | Ogolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefRodzajSzkol | DefRodzajSzkol | Szkolenia/Definicje rodzajów szkoleń | 152 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefSekcjiDok | DefSekcjiDok | Kadry i płace/ZZL/Definicje sekcji dokumentów | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefServiceCalc | DefServiceCalc | Nieruchomości/Definicje algorytmów usług | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefSkladki | DefSkladkiOgolne | Ogólne | 100 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefSkladki | DefSkladki | Członkowie/Definicje składek | 101 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefSkladki | DefSkladkiNumeracja | Numeracja | 110 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefSkladki | DefSkladkiAlgorytm | Algorytm | 120 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefSprawWind | DefSprawWind | Ewidencje ŚP/Windykacja/Definicje spraw | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DefSprzedaz | DefSprzedaz | Faktury/Sprzedaż | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefSprzedazMagazyny | DefSprzedazMagazyny | Handel/Definicje dokumentów/Sprzedaż | 700 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefSzkod | DefSzkod | Nieruchomości/Definicje szkód | 5 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefTeczek | DefTeczek | CRM/Definicje dokumentów/Definicje teczek | 90 | Soneta.Core.UI.dll | Soneta.Core |
| DefTeczki | DefTeczkiOgolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DefTeczki | DefTeczkiStany | Stany | 20 | Soneta.Core.UI.dll | Soneta.Core |
| DefTransakcja | DefTransakcjaOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefTransakcja | DefTransakcjaStanyTransakcji | Stany transakcji | 20 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefTransakcja | DefTransakcjaAdditional | Dodatkowe | 30 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefTransakcja | DefTransakcjaPriorytety | Priorytety | 30 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefTransakcja | DefTanasakcjaTemperatury | Temperatury | 35 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefTransakcja | DefTransakcjaKalkulatorCode | Kod kalkulatora transakcji | 40 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefTransakcja | ProcessStructure | Struktura procesu | 49 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefTransakcja | EngineEdytor | Algorytm procesu | 50 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefTransakcji | DefTransakcji | CRM/Definicje dokumentów/Definicje transakcji | 110 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefTrybow | DefTrybow | Szkolenia/Definicje trybów | 54 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefUE | DefUE | Handel/Definicje dokumentów/UE | 800 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefUmowyHandel | DefUmowyHandel | {new DefUmowyExtender.Name()} | 1000 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefVerifierRegistrationTime | DefVerifierRegistrationTime | Praca hybrydowa/Definicje weryfikatorów | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefWerRozCzas | DefWerRozCzas | Kadry i płace/Kalendarze/Definicje weryfikatorów rozliczenia czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefWeryfKalend | DefWeryfKalend | Kadry i płace/Kalendarze/Definicje weryfikatorów kalendarza | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefWydarzen | DefWydarzen | Szkolenia/Definicje wydarzeń | 162 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefWypozyczen | DefWypozyczen | Wypożyczenia/Definicje wypożyczeń | 60 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefWyroznienia | DefWyroznieniaOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefXmlElem | DefXmlElem | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| DefXmlElem | DefXmlElemAlgorytmExport | Algorytm eksportu | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DefXmlElem | DefXmlElemAlgorytmImport | Algorytm importu | 20 | Soneta.Core.UI.dll | Soneta.Core |
| DefXmlElem | DefXmlElemAlgorytmPozostale | Algorytm - pozostałe | 30 | Soneta.Core.UI.dll | Soneta.Core |
| DefXmlElem | DefXmlElemSzablonyPolOpcjonalnych | Szablony pol opcjonalnych | 40 | Soneta.Core.UI.dll | Soneta.Core |
| DefXmlElemKopiujParams | Params | Kopiuj element | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DefXmlFiltr | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| DefXmlNag | DefXmlNag | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| DefXmlNag | Kontrahnet | Kontrahenci | 1010 | Soneta.Core.UI.dll | Soneta.Core |
| DefXmlNagSprawozdanie | Ogolne | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefZadan | DefZadan | CRM/Definicje dokumentów/Definicje zadań | 30 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadanKadry | DefZadanKadry | Kadry i płace/Kadry/Definicje zadań | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadanOPZ | DefZadanOPZ | Praca hybrydowa/Definicje aktywności | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadanProjektowych | DefZadanProjektowych | Projekty i Budżetowanie/Definicje zadań | 106 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | DefZadaniaOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | RelatedDefinitions | Powiązane definicje | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | DefZadaniaStany | Stany | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | DefZadaniaStanyKanban | Stany Kanban | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | DefZadaniaTypy | Typy | 25 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | DefZadaniaPriorytety | Priorytety | 30 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | DefZadaniaOpcje | Opcje | 34 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | ProjektoweOpcje | Opcje | 34 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | DefZadaniaMail | Mail | 40 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | DefZadaniaKalendarzGoogle | Kalendarz Google | 48 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | ProcessStructure | Struktura procesu | 49 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | DefZadaniaKalkulatorCode | Kod kalkulatora zadań | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | EngineEdytor | Algorytm procesu | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | StandardEngine | Algorytm zadania | 51 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | Additional | Dodatkowe | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadania | Uzytkownika | Użytkownika | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZadaniaRelacja | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZakupMagazyny | DefZakupMagazyny | Handel/Definicje dokumentów/Zakupy | 1200 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefZamowienia | DefZamowienia | Handel/Definicje dokumentów/Zamówienia - oferty | 1300 | Soneta.Handel.UI.dll | Soneta.Handel |
| DefZdarzInc | DefZdarzInc | Nieruchomości/Definicje zdarzeń/Definicje zdarzeń incydentalnych | 4 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefZdarzPlan | DefZdarzPlan | Nieruchomości/Definicje zdarzeń/Definicje zdarzeń planowanych | 4 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefZdarzen | DefZdarzen | CRM/Definicje dokumentów/Definicje zdarzeń | 40 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefZgloszen | DefZgloszen | Szkolenia/Definicje zgłoszeń | 52 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefZgloszenia | DefZgloszeniaOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| DefZlecen | DefZlecen | Zlecenia serwisowe/Definicje zleceń serwisowych | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefinicjaAkorduGrupowego | DefinicjaGrupowego | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaAkorduProstego | DefinicjaAkorduProstego | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaAktualizacjiKalendarza | Ogolne | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaAktualizacjiKalendarza | Dodatkowe | Dodatkowe | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaAktualizacjiKalendarza | Edytor | Edytor | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaAktualizacjiKalendarza | EdytorKalk | Edytor (kalkulator) | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaAlgorytmuUslugi | General | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefinicjaAlgorytmuUslugi | Algorithm | Algorytm usługi | 50 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefinicjaAnalityki | DefinicjaAnalitykiOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaAnalityki | DefinicjaSlownikaOgolne | Ogólne - elementy słownika | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaAnalityki | DefinicjaAnalitykiWyjatki | Wyjątki | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaAnkiety | DefinicjaAnkietyOgólne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefinicjaAnkiety | DefinicjaAnkietyOpis | Opis | 20 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefinicjaAnkiety | DefinicjaArkuszaAnkietyPodglad | Podgląd arkusza | 20 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefinicjaAnkiety | DefinicjaAnkietyEdytor | Edytor | 30 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefinicjaAnkiety | DefinicjaAnkietyEdytorKalk | Edytor (kalkulator) | 40 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefinicjaArkuszaOceny | DefinicjaArkuszaOceny | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaArkuszaOceny | Opis | Opis | 20 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaBadaniaLekarskiego | DefinicjaBadaniaLekarskiego | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaCeny | DefinicjaCeny | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Towary |
| DefinicjaCeny | DefinicjaCenyCenniki | Cenniki | 10 | Soneta.Handel.UI.dll | Soneta.Towary |
| DefinicjaCeny | DefinicjaCenyRabaty | Rabaty | 20 | Soneta.Handel.UI.dll | Soneta.Towary |
| DefinicjaCeny | DefinicjaCenyPozostale | Pozostałe | 40 | Soneta.Handel.UI.dll | Soneta.Towary |
| DefinicjaCeny | DefinicjaCenyAlgorytm | Algorytm | 50 | Soneta.Handel.UI.dll | Soneta.Towary |
| DefinicjaCyklu | DefinicjaCykluFormDefinicja | Definicja | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaCyklu | DefinicjaCykluFormPodglad | Symulacja | 20 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaCzynnikowSzkodliwych | DefinicjaCzynnikowSzkodliwych | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaCzynnosciNaObiekcie | DefinicjaCzynnosciNaObiekcie | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaDnia | DefinicjaDnia | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaDnia | DefinicjaDniaKolory | Kolory | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaDnia | DefinicjaDniaNet | Pulpity | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaDokumentu | DefinicjaDokumentu | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaDokumentu | Rozszerzenie | Rozszerzenie | 110 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaElementu | DefinicjaElementu | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuPrawa | Prawa dostępu | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuPro | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuDeklaracje | Deklaracje | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuDeklaracjeCd | Deklaracje (cd) | 3 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuNieobecnosci | Nieobecności | 4 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuNieobecnosciPro | Nieobecności | 4 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuRozliczenie | Rozliczenie | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuGUS | Dane statystyczne | 6 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuDodatkowe | Dodatkowe | 7 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuAlgorytm | Algorytm/Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuStaz | Algorytm/Staż pracy | 11 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuAlgorytmRozliczenieCzasuUmowy | Algorytm/Rozliczenie czasu umowy | 12 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuAlgorytmUmowy | Algorytm/Umowy | 12 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuEdytor | Algorytm/Edytor | 12 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuParametry | Algorytm/Nazwy parametrów | 12 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuPodglad | Algorytm/Podgląd | 13 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementu | DefinicjaElementuHistoria | Historia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementuOceny | Ogólne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaElementuOpisuStanowiska | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementuRozliczenia | DefinicjaElementuRozliczenia | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementuRozliczenia | Edytor | Edytor | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementuRozliczenia | NazwyPodstaw | Nazwy podstaw | 12 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementuRozliczenia | Podglad | Podgląd | 13 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaElementuStrukturyOrganizacyjnej | DefinicjaElementuStrukturyOrganizacyjnej | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaEtapuRekrutacji | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaFunduszuPozyczkowego | DefFunduszuPozyczkowego | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaFunduszuPozyczkowego | DefFunduszuPozyczkowegoRozliczenie | Rozliczenia i żyranci | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaFunduszuPozyczkowego | DefFunduszuWydzialy | Jednostki organizacyjne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaFunkcji | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaFunkcji | Opis | Opis | 90 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaGrafikaPracy | DefinicjaGrafikaPracy | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaGrafikaPracy | DefinicjaGrafikaAlgorytm | Algorytm | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaJezykaObcego | DefinicjaJezykaObcego | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaKregu | DefinicjaKreguOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaLimitu | DefinicjaLimitu | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaListyPlac | DefinicjaListyPlac | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaListyPlac | DefinicjaListyPlacDodatkowe | Dodatkowe | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaListyPlac | DefinicjaListyPlacEdytor | Edytor | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaListyPlac | DefinicjaListyPlacDefElement | Definicje elementów | 3 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaListyPlac | DefinicjaListyPlacSchematPodzialowy | Schemat podziałowy | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaNagrodyKary | DefinicjaNagrodyKary | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaNieobecnosci | DefinicjaNieobecnosci | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaNieobecnosci | DefinicjaNieobecnosciDodatkowe | Dodatkowe | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaNieobecnosci | DefinicjaNieobecnosciZbieg | Zbieg pracy i rodzicielstwa | 25 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaNieobecnosci | DefinicjaNieobecnosciKolory | Kolory | 50 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaOceny | DefinicjaOcenyOgólne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaOceny | DefinicjaOcenyOpis | Opis | 20 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaOceny | DefinicjaOcenyEdytor | Edytor | 30 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaOceny | DefinicjaOcenyEdytorKalk | Edytor (kalkulator) | 40 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaOswiadczenia | DefinicjaOswiadczenia | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaOswiadczenia | DefinicjaOswiadczeniaNet | Pulpity | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaPaczkiPrzelewu | Ogolne | Ogólne | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DefinicjaPlanowanejListyPlac | DefinicjaPlanowanejListyPlac | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaPlanowanejListyPlac | Rozszerzenie | Rozszerzenie | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaPlanowanejListyPlac | DefinicjaRezerwyUrlopowejEdytor | Edytor | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaPlanowaniaZasobow | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaPodzielnikaKosztow | DefinicjaPodzielnikaKosztowAlgorytm | Algorytm | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaPodzielnikaKosztow | DefinicjaPodzielnikaKosztowOgolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaPoswiadczeniaOdbioru | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaPowstaniaObowiazkuVAT | DefinicjaPowstaniaObowiazkuVATOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaRCP | DefinicjaRCPMain | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefinicjaRCP | DefinicjaRCPActionAlgorithm | Algorytm akcji | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefinicjaRCP | DefinicjaRCPAssignedEmployees | Pracownicy | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefinicjaRodzajuPracyZdalnej | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaRozliczeniaCzasuPracy | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaRozliczeniaCzasuPracy | Weryfikatory | Weryfikatory | 150 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaRozliczeniaMediow | General | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefinicjaRozliczeniaMediow | Options | Opcje | 20 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefinicjaRozliczeniaMediow | Algorithm | Algorytm rozliczenia | 50 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| DefinicjaSekcjiDokumentu | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjaSlownika | DefinicjaSlownikaOgolne2 | Ogólne - elementy słownika | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaSlownika | DefinicjaSlownikaOgolne | Ogólne - elementy definicji | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaSlownika | DefinicjaSlownikaAlgorytm | Algorytm | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaSprawyWindykacyjnej | Ogolne | Ogólne | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DefinicjaSprawyWindykacyjnej | Numeracja | Numeracja | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DefinicjaStanowiska | DefinicjaStanowiska | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiska | DefinicjaStanowiskaDodatkowe | Dodatkowe | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiska | DefinicjaStanowiskaGrupyZaszeregowania | Grupy zaszeregowania | 25 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiska | DefinicjaStanowiskaBadaniaLekarskie | Wymagane badania lekarskie | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiska | DefinicjaStanowiskaDefinicjeCzynnikowSzkodliwych | Definicje czynników szkodliwych | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiska | KartyOpisuStanowiska | Karty opisu stanowiska | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiska | OgloszeniaOPrace | Karty opisu stanowiska (ogłoszenia) | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiska | PowiazaneDokumentyDodatkowe | Powiązane dokumenty dodatkowe | 35 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiska | DefinicjaStanowiskaSzkoleniaBHP | Wymagane szkolenia BHP | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiska | DefinicjaStanowiskaUprawnienia | Wymagane uprawnienia | 50 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiska | DefinicjaStanowiskaOpis | Opis | 90 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | DefinicjaStanowiskaElementyWynagrodzenia | Poziom wynagrodzenia | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | DefinicjaStanowiskaHistDodatkowe | Dodatkowe | 300 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | DefinicjaStanowiskaHistWydzialy | Jednostki organizacyjne | 400 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaMiejsceWStrukturze | Ogólne/Opis stanowiska/Miejsce w strukturze | 412 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaRelacjeIWspolpraca | Ogólne/Opis stanowiska/Relacje i współpraca | 414 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaBenefity | Ogólne/Opis stanowiska/Benefity | 416 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaCzynnikiSzkodliweIUciazliwe | Ogólne/Opis stanowiska/Czynniki szkodliwe i uciążliwe | 418 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaWysilek | Ogólne/Opis stanowiska/Wysiłek | 420 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaObszaryOdpowiedzialnosci | Ogólne/Opis stanowiska/Obszary odpowiedzialności | 422 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaCelStanowiska | Ogólne/Opis stanowiska/Cel stanowiska | 424 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaZakresObowiazkow | Ogólne/Opis stanowiska/Zakres obowiązków | 426 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaPracownicza | Ogólne/Opis stanowiska/Zakres odpowiedzialności pracowniczej | 428 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaKierownicza | Ogólne/Opis stanowiska/Zakres odpowiedzialności kierowniczej | 430 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaMaterialna | Ogólne/Opis stanowiska/Zakres odpowiedzialności materialnej | 432 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaZakresUprawnien | Ogólne/Opis stanowiska/Zakres uprawnień | 434 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OpisStanowiskaInne | Ogólne/Opis stanowiska/Inne | 436 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | ProfilZadaniowy | Profil zadań | 451 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | ProfilKwalifikacyjny | Profil kwalifikacji | 452 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | ProfilSzkolenIUprawnien | Profil szkoleń i uprawnień | 453 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | ProfilKompetencjiUniwersalnych | Profil kompetencji uniwersalnych | 454 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | ProfilKompetencjiMerytorycznych | Profil kompetencji merytorycznych | 455 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | Wartosciowanie | Wartościowanie | 460 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | DefinicjaStanowiskaHistGrupyZaszeregowania | Grupy zaszeregowania | 500 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | DefinicjaStanowiskaHistDefinicjeCzynnikowSzkodliwych | Definicje czynników szkodliwych | 600 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | KartyOpisuStanowiska | Karty opisu stanowiska | 700 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | OgloszeniaOPrace | Karty opisu stanowiska (ogłoszenia) | 720 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | DefinicjaStanowiskaHistBadaniaLekarskie | Wymagane badania lekarskie | 800 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | DefinicjaStanowiskaHistSzkoleniaBHP | Wymagane szkolenia BHP | 820 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | DefinicjaStanowiskaHistUprawnienia | Wymagane uprawnienia | 840 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | DefinicjaStanowiskaHistOpis | Opis | 900 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStanowiskaHist | RowHistory | Historia zapisów | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStawkiAkcyzy | DefinicjaStawkiAkcyzy | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaStawkiVat | DefinicjaStawkiVatOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaStopiaZnajomosciJezykaObcego | DefinicjaStopiaZnajomosciJezykaObcego | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStrefy | DefinicjaStrefy | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStrefy | DefinicjaStrefyKolory | Kolory | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaStrefy | DefinicjaStrefyNet | Pulpity | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaSwiadczeniaSocjalnego | DefinicjaSwiadczeniaSocjalnego | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaSzkolenia | DefinicjaSzkolenia | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaSzkolenia | DefinicjaSzkoleniaZKL | ZKL | 15 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaSzkolenia | DefinicjaSzkoleniaZzl | Uprawnienia do uzyskania | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaSzkoleniaBHP | DefinicjaSzkoleniaBHP | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaSzkoleniaBHP | DefinicjaSzkoleniaBHPZKL | ZKL | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaTrasy | DefinicjaTrasyOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DefinicjaUprawnienia | DefinicjaUprawnienia | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaUprawnienia | DefinicjaUprawnieniaZKL | ZKL | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaWerRCP | DefinicjaWerRCPMain | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefinicjaWerRCP | DefinicjaWerRCPVerifierAlgorithm | Algorytm weryfikacji | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DefinicjaWeryfikatoraKalendarza | Ogolne | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaWeryfikatoraKalendarza | Edytor | Edytor | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaWeryfikatoraRozliczeniaCzasuPracy | Ogolne | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaWeryfikatoraRozliczeniaCzasuPracy | Edytor | Edytor | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaWydzialu | DefinicjaWydzialu | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaZdarzeniaRCP | DefinicjaZdarzeniaRCP | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaZestawieniaCzasu | DefinicjaZestawieniaCzasu | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaZestawieniaCzasu | DefinicjaZestawieniaCzasuSource | Algorytm źródła | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaZestawieniaCzasu | DefinicjaZestawieniaCzasuCell | Algorytm komórki | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjaZestawieniaCzasu | DefinicjaZestawieniaCzasuExtender | Algorytm filtrów | 50 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjeElementowOpisuStanowiska | DefinicjeElementowOpisuStanowiska | Kadry i płace/ZZL/Defincje elementów opisu stanowiska | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjeOcen | DefinicjeOcen | CRM/Oceny/Definicje ocen | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| DefinicjeOcenHR | DefinicjeOcenHR | Kadry i płace/Oceny/Definicje ocen | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjeOswiadczen | DefinicjeOswiadczen | Kadry i płace/Kadry/Definicje oświadczeń | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DefinicjePodzielnikowKosztow | DefinicjePodzielnikowKosztow | Podzielniki/Definicje podzielników kosztów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjeZakresow | DefinicjeZakresow | Ogólne/Ochrona danych osobowych/Definicje zakresów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DefinicjeZakresowSerwisowych | DefinicjeZakresowSerwisowych | Ogólne/Ochrona danych osobowych/Definicje zakresów serwisowych | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DefsXmlNag | DefsXmlNag | DMS/OCR/Formaty komunikatów | 1120 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| Deklaracja | Wydzial | Jednostka organizacyjna | 15 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Deklaracja | PITZalacznikORDZU | Załącznik ORD-ZU | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Deklaracja | PITZalacznikiORDZU | Załączniki | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Deklaracja | DeklaracjaPola | Pola (Release) | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Deklaracja | DeklaracjaPolaDebug | Pola | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DeklaracjaEwidencja | DeklaracjaEwidencja | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DeklaracjaResult | Ogolne | Ogólne | 20 | Soneta.EI.UI.dll | Soneta.EI |
| DeklaracjaUczestnikaPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DeklaracjeDBItemWorkerParams | Ogolne | Parametry | 100 | Soneta.EI.UI.dll | Soneta.EI |
| DeklaracjePPKBaseWorker | DeklaracjePPKBaseWorker | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DekretBase | DekretOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DekretBase | DekretKP | Zapis KPiR | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DekretBase | DekretRyczal | Zapis ryczałt | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Delegacja | DelegacjaGeneral | Ogólne | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Delegacja | DelegacjaGeneralNet | Ogólne | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Delegacja | DelegacjaZaliczki | Zaliczki | 20 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Delegacja | DelegacjaPozyskanieWalut | Pozyskanie walut | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Delegacja | DelegacjaNaliczenia | Naliczenia | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Delegacja | DelegacjaPlatnosci | Płatności | 120 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Delegacja-DelegacjaDefDok | Rozszerzenia | Rozszerzenia | 20 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DelegacjaEwidencja | DelegacjaEwidencjaGeneral | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DelegacjeCfgOgolne | DelegacjeCfgOgolne | Delegacje/Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DemoModeInformation | General | Wersja demonstracyjna | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DeveloperDataSource | Timers | Stopery | 2 | Soneta.Net.Business.dll | Soneta.Net |
| DeveloperDataSource | Bundle | MCP | 100 | Soneta.Net.Business.dll | Soneta.Net |
| DeveloperDataSource | Contexts | Konteksty | 100 | Soneta.Net.Business.dll | Soneta.Net |
| DeveloperDataSource | Counters | Liczniki | 100 | Soneta.Net.Business.dll | Soneta.Net |
| DeveloperDataSource | Exceptions | Wyjątki | 100 | Soneta.Net.Business.dll | Soneta.Net |
| DeveloperDataSource | Stat | Statystyka | 100 | Soneta.Net.Business.dll | Soneta.Net |
| DeveloperDataSource | Windows | Okna | 100 | Soneta.Net.Business.dll | Soneta.Net |
| Diagram | General | Diagram | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Dictionary | Dictionary | UI/Tłumaczenie | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DictionaryDataSource | Array | Słownik | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DictionaryDataSource | Single | Słownik | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DictionaryItem | DictionaryElement | Element słownika | 201 | Soneta.Business.UI.dll | Soneta.Business |
| DictionaryItem | SlownikPIM | Słowniki pól i cech | 300 | Soneta.Business.UI.dll | Soneta.Business |
| DictionaryWord | General | Sentencja | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DictionaryWord | Sources | Źródła słowa | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DiscPlugInsSets | DiscPlugInsSets | Ogólne/Dyskusje/Zestawy rozszerzeń do dyskusji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Discussion | DiscussionGeneral | Dyskusja | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionAttachementsSelectFileParams | SelectFileParams | Dodawanie załącznika | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionAttachmentPreview | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionConfiguration | AddInsConfig | Konfiguracja rozszerzeń | 20 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionConfiguration | AddIns | Rozszerzenia | 30 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionMember | ContactPeople | Osoby kontaktowe | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionMember | Employees | Pracownicy | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionMember | Operators | Operatorzy | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionPlugIn | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionPlugIn | Editor | Edytor | 10 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionPlugInRef | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionPlugInsSet | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionPlugInsSet | Editor | Edytor | 2 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionUser | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DiscussionsSelector | Discussions | Dyskusje | 10 | Soneta.Core.dll | Soneta.Core |
| DistrictRegion | Obszary | Obszary | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| DmsCRU | DmsCRU | DMS/Centralny Rejestr Umów | 1000 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| DmsGeneral | DmsGeneral | DMS/Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| DmsState | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| DmsState | DmsState | DMS/Statusy | 800 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| DmsStateDef | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| DmsStateDef | DmsStateDef | DMS/Definicje statusów | 700 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| DocPkg | General | Paczka dokumentów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DocPkgAddAttachmentPKBRParams | Params |  | 100 | Soneta.EI.UI.dll | Soneta.EI |
| DocPkgCfg | Ogolne | Kategoria dokumentu | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DocPkgCfgs | DocPkgCfgs | Ogólne/Paczki dokumentów/Kategorie dokumentów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DocPkgDef | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| DocPkgDef | Parametry | Parametry | 1 | Soneta.Core.UI.dll | Soneta.Core |
| DocPkgDefs | DocPkgDefs | Ogólne/Paczki dokumentów/Definicje paczek dokumentów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DocPkgItem | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DocxDesigner | General | Document editor | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DodHistoria | Dodatek | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DodHistoria | DodatekRozliczenie | Rozliczenie | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DodHistoria | ElementyWynagrodzeniaHist | Elementy wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DodHistoria | RowHistory | Historia zapisów | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DodajAdresatowWorker-Params | DodajAdresatowParam | Parametry | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DodajCertyfikatKSeFParametry | Ogolne | Dodaj certyfikat KSeF | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DodajKryteriaKonfiguratoraZklWorker | Analityczne | Dodaj kryteria analityczne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DodajNagrode | DodajNagrode | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DodajPozycjeGratisoweWorker-WParams | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DodajPrzelewyWorker | DodajPrzelewyWorker | Dodaj | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DodajTowaryDoSchematuGratisuWorker-WParams | Ogolne | Ogólne | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DodajZamiennikWorker-DodajZamiennik | Ogolne | Dodaj zamiennik towaru | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| DodajZmienDodatek | NowyDodatek | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DodanieOpisuPIMParams | Params | Dodawanie opisów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DodatekAutomatyczny | DodatekAutomatyczny | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DodatekRow | LicencjaDodatku | Ogólne | 1 | Soneta.Business.Licence.dll | Soneta.Business |
| DodatkowaKwalifikacjaZawodowa | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DodawanieSlownikowPIMParametry | Ogolne | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Towary |
| DokAktKalWybierzZrodlaCzasWorker | Ogolne | Wybierz | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokAktKalWybierzZrodlaPlanWorker | Ogolne | Wybierz | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokEwidencji | AdditionalDescription | Dodatkowe informacje | 1000 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokEwidencji | ElementDziennikaKsiegowegoDekrety | Opis analityczny i dekrety | 1000 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokEwidencji | ElementDziennikaKsiegowegoOpisAnalityczny | Opis analityczny | 1000 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokEwidencji | PowiazaneDokumenty | Powiązane dokumenty | 1000 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokEwidencji | DaneZewnetrzneDokumentuEwidencji | Dane zewnętrzne | 1001 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokEwidencji | PowiazaneKoszty | Powiązane koszty | 1006 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokEwidencji | Preview | Podgląd | 2000 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokHandlTest | Handl | Dok handl test | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DokHandlTest | Sprz | Dok handl test | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DokKasowyBase | DokKasowy | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DokKasowyBase | DokKasowyDane | Dodatkowe | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DokKasowyBase | RozliczeniaKasowego | Rozliczenia | 2 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| DokumentAktualizacjiKalendarza | PlanowanieCzas | Czas pracy | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentAktualizacjiKalendarza | PlanowanieCzasNet | Czas pracy | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentAktualizacjiKalendarza | PlanowaniePlan | Planowanie | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentAktualizacjiKalendarza | PlanowaniePlanNet | Planowanie | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentAktualizacjiKalendarza | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentAktualizacjiKalendarza | Obiekty | Obiekty | 15 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentAktualizacjiKalendarza | Zestawienia |  | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentCRM | DokumentCRM | Ogolne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DokumentEwidImportKSeFParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentWizard | Szybka transakcja | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentOgolne | Ogólne | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | KBN | Ogólne | 20 | Soneta.Handel.UI.dll | Soneta.KlientBiuraRachunkowego |
| DokumentHandlowy | Ogolne | Ogólne | 20 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| DokumentHandlowy | KontrahentKBN | Dane kontrahenta i odbiorcy | 21 | Soneta.Handel.UI.dll | Soneta.KlientBiuraRachunkowego |
| DokumentHandlowy | DokumentPlatnosci | Płatności | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentZaliczki | Zaliczki | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentZgloszeniaServiceDesk | Zgłoszenia ServiceDesk | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | PUESC | PUESC | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | ParametrySLA | Parametry SLA | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | Platnosci | Płatności | 40 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| DokumentHandlowy | DokumentKontrahent | Kontrahent | 50 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentOpakowania | Opakowania | 50 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | TaxFree | Kontrahent | 50 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | Dodatkowe | Dodatkowe | 100 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| DokumentHandlowy | DodatkoweSumy | Dodatkowe | 100 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| DokumentHandlowy | DokumentDodatkowe | Dodatkowe | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentEParagon | e-paragon | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentEUDR | EUDR | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentUmowaFaktury | Faktury | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentPozycjeGratisowe | Gratisy | 200 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentRelacjeRozliczajaceZaliczke | Relacje zaliczek | 200 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentRelacjeZaliczek | Relacje zaliczek | 200 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentUE | UE | 900 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentMarza | Marża | 1000 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentyPowiazane | Powiązane dokumenty | 1000 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DaneZewnetrzne | Dane zewnętrzne | 1001 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentHandlowyTechnologia | Technologia | 1001 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| DokumentHandlowy | DokumentZasoby | Zasoby | 1010 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | KosztyDodatkowe | Koszty dodatkowe | 1011 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentTransport | Przesyłka | 1015 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | DokumentTransportPulpit | Przesyłka | 1015 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| DokumentHandlowy | WiadomosciPowiazaneDokHandlowego | {New WiadomosciPowiazaneDokHandlowegoExtender.CaptionHtml} | 1020 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| DokumentHandlowy | AdditionalDescription | Dodatkowe informacje | 10000 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | OpisAnalityczny | Opis analityczny | 10000 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowy | OpisAnalitycznyPP | Opis analityczny Pulpit | 10000 | Soneta.Handel.UI.dll | Soneta.PulpitPracownika |
| DokumentHandlowyGeneratorPozycjiWorker-WParams | Ogolne | Ogólne | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowyGrupowaEdycjaProcedurVATParams | Ogolne | Parametry | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowyKoszt | KosztDodatkowy | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowyZmianaPozycjiWorker | DokumentHandlowyZmianaPozycjiWorkerParams | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentHandlowyZmianaZatwierdzonegoWorker-DokumentHandlowyZmianaZatwierdzonegoParams | Ogolne | Parametry | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentImportKSeFParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentKursyParams | Ogolne | Ogólne | 900 | Soneta.Handel.UI.dll | Soneta.Handel |
| DokumentPlanowaniaZasobow | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentPowiazanyDokEwid | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DokumentPowiazanyUL | Ogolne | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentProcedura | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentRMK | DokumentRMKOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentRozliczeniaKontrahenta | DokumentRozliczeniaKontrahenta | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentRozliczeniaKontrahenta | DokumentRozliczeniaKontrahentaDokEwidencji | Ewidencja | 3 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentRozliczeniaKontrahenta | DokumentRozliczeniaKontrahentaElemsRozli | Elementy rozliczenia | 3 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentRozliczeniaPracownika | DokumentRozliczeniaPracownika | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentRozliczeniaPracownika | DokumentRozliczeniaPracownikaNet | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DokumentST | F03 | F-03 (GUS) | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentST-DefDokST | DefDokumentuSrodkiTrwale | Środki trwałe | 101 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentUL | Harmonogram | Harmonogram | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentUL | Korekty | Korekty | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentUL | Ogolne | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentUL | OgolneMSR | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentUL | PowiazaneDokumenty | Powiązane dokumenty | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentUL | Zalaczniki | Załączniki | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentUL-DefDokUL | DefDokumentuLeasing | Środki trwałe | 101 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentULPozycja | Harmonogram | Harmonogram | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentULPozycja | Ogolne | Ogólne | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentULPozycja | OgolneMSR | Ogólne | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DokumentyInstytucjiFinansowejPPK | Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DokumentyPPKEksportParams | ParamsForm |  | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DokumentyPPKImportParams | ParamsForm |  | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DokumentyPracodawcyPPK | Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| DokumentyRozlPra | DokumentyRozlPraElemsRozli | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DolaczJakoZaliczkeWorker | DolaczJakoZaliczke | Dołącz jako zaliczkę | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DomainDefinition | DomainDefinitionOgolne | Właściwości modelu | 10 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionStructure | Struktura modelu | 20 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionTables | Ogólne/Elementy modelu/Tabele | 30 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionExtendTables | Ogólne/Elementy modelu/Dodatkowe tabele | 31 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionJoins | Ogólne/Elementy modelu/Złączenia | 32 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionExtendJoins | Ogólne/Elementy modelu/Dodatkowe złączenia | 33 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionCondition | Ogólne/Elementy modelu/Warunek | 34 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionExtendCondition | Ogólne/Elementy modelu/Dodatkowy warunek | 35 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionFields | Ogólne/Elementy modelu/Pola | 36 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionExtendFields | Ogólne/Elementy modelu/Dodatkowe pola | 37 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionGroupBy | Ogólne/Elementy modelu/Grupowanie | 38 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionExtendGroupBy | Ogólne/Elementy modelu/Dodatkowe grupowanie | 39 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionTimeSpanSet | Ogólne/Elementy modelu/Zestaw przedziałów czasowych | 40 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinition | DomainDefinitionRelationship | Relacje | 50 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinitionAddFields | StructureAddFields | Dodaj pola | 10 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinitionJoins | GeneralJoins | Ogólne | 10 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinitionJoins | StructureJoins | Struktura | 20 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinitionSources | StructureSources | Żródła | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DomainDefinitionSqlPreviewWorker | SqlPreview | Podgląd Sql | 2 | Soneta.BI.UI.dll | Soneta.BI |
| DomainViewErrors | DomainViewErrorsOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| DomyslnyCel | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| DostawaWorker | DostawaWorkerPartie | Partie towaru | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| DostawaWorker | DostawaWorker | Zasoby towaru | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| DostawaWorker | DostawaWorkerKompletacja | Zasoby składników | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DostawaWorker | DostawaWorkerKompletacjaPodglad | Dostawa - kompletacja - podgląd | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DostawaWorker | DostawaWorkerPodglad | Dostawa - podgląd | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DostawcaSzkolen | DostawcaSzkolenOgolne | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DostawcaSzkolen | DostawcaSzkolenOferty | Oferty szkoleń | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DostepDoSystemow | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DotxDocumentEditor | General | Edytor DOTX | 100 | Soneta.Business.Forms.dll | Soneta.Business |
| DotxDocumentEditor | Snippety | Snippety | 100 | Soneta.Business.Forms.dll | Soneta.Business |
| DotxDocumentPreview | General | Podgląd DOTX | 100 | Soneta.Business.Forms.dll | Soneta.Business |
| DotxReportGenerator | General | Dokument DOTX | 100 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| DotxReportTemplateDesigner | General | Projektowanie | 100 | Soneta.Net.Business.dll | Soneta.Net |
| DotxReportTemplateDesigner | Snippets | Snippety | 100 | Soneta.Net.Business.dll | Soneta.Net |
| DotxSimpleElement | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DotxSnippetElement | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DotxSnippetFieldElement | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| DrukarkaFiskalna | StawkiVat | Stawki VAT | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DrukarkaFiskalnaDodatkoweInfo | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| DsSelectPlugInItemsTreeWorker | General | Wybierz rozszerzenia | 100 | Soneta.Core.UI.dll | Soneta.Core |
| DuplicateResult | General | Prawdopodobne duplikaty | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| DxFileNameParams | General | Ogólne | 100 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| DxReportGenerator | General | Raport REPX | 100 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| DxReportTemplateDesigner | General | Projektowanie | 100 | Soneta.Net.Business.dll | Soneta.Net |
| DxReportTemplateDesigner | Data | Dane | 200 | Soneta.Net.Business.dll | Soneta.Net |
| DxReportTemplateDesigner | Snippets | Snippet-y | 201 | Soneta.Net.Business.dll | Soneta.Net |
| DxReportTemplateDesigner | SubReports | Podraporty | 201 | Soneta.Net.Business.dll | Soneta.Net |
| DxReportTemplateDesigner | XML | XML | 301 | Soneta.Net.Business.dll | Soneta.Net |
| DxSnippetFile | General | Ogólne | 100 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| DzialalnoscKod | DzialalnoscKodOgolne | Ogólne | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| DzienAkordu | DzienAkordu | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienGrupowego | DzienGrupowego | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienKalendarza | DzienKalendarza | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienKalendarza | DzienKalendarzaPro | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienKalendarzaAktualizacja | DzienKalendarzaAktualizacja | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienKalendarzaAktualizacja | DzienKalendarzaAktualizacjaKorekty | Wersje | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienKalendarzaAktualizacja | DzienKalendarzaAktualizacjaNet | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienKalendarzaBase | DzienKalendarzaBaseKorekty | Wersje | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienKalendarzaHistoria | DzienKalendarzaHistoria | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienKopiaBase | DzienKalendarzaPro | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPlanu | Net | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPlanu | DzienKalendarza | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPlanu | DzienKalendarzaPro | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPlanuUmowy | Net | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPlanuUmowy | DzienKalendarza | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPlanuUmowy | DzienKalendarzaPro | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracy | DzienPracy | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracy | DzienPracyPro | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracy | Net | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracy | DzienPracyWeWy | WeWy | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracy | RozliczenieNadgodzin | Rozliczenie nadgodzin | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracy | RozliczenieNadgodzinNet | Rozliczenie nadgodzin | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracyAktualizacja | DzienPracyAktualizacja | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracyAktualizacja | DzienPracyNet | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracyHistoria | DzienPracyHistoria | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracyUmowy | DzienPracyUmowy | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracyUmowy | DzienPracyUmowyNet | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienPracyUmowy | DzienPracyUmowyPro | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienSerii | DzienSerii | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienSerii | DzienSeriiPro | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DzienZestawienieExtender | Net | Dzień zestawienie | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| DziennikSuma | DziennikSuma | Podsumowanie | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| DziennikZapisySuma | Ogolne | Podsumowanie | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| EDIConfig | EDIConfig | Handel/EDI | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| EDeklaracja | EDeklaracjaOgolne | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| EDeklaracja | EDeklaracjaDokument | Dokument | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| EDeklaracja | EDeklaracjaDokumentPodpisany | Dokument podpisany | 101 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| EDeklaracja-PodpisNieweryfikowany | PodpisNieweryfikowany | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ETransmisja | ETransmisjaOgolne | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| EditComment | EditComment | Edycja komentarza | 10 | Soneta.Core.UI.dll | Soneta.Core |
| EditData | EditData |  | 10 | Soneta.Support.UI.dll | Soneta.Support |
| EditParams | Start | Zmień nazwe | 10 | Soneta.Support.UI.dll | Soneta.Support |
| Editors | General | Folder testowy edytorów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| EdytujAdresParams | Ogolne | Edytuj adres dostawy | 900 | Soneta.Handel.UI.dll | Soneta.Handel |
| EdytujProceduryOSSWorker-Params | Params | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Egzamin | ZajecieLekcjaOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Egzamin | ZajecieEgzaminKomisja | Komisja egzaminacyjna | 21 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Egzamin | ZajecieEgzaminUczestnicy | Uczestnicy | 22 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Egzamin | ZajecieLekcjaSale | Sale | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| EkoPaliwoStawka | EkoPaliwoStawka | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| EkoRodzajPaliwa | EkoRodzajPaliwa | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| EkoRodzajSilnika | EkoRodzajSilnika | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| EkoRodzajePaliw | EkoRodzajePaliw | Ewidencja pojazdów/Środowisko/Rodzaje paliw | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| EkoRodzajeSilnikow | EkoRodzajeSilnikow | Ewidencja pojazdów/Środowisko/Rodzaje silników | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| EksportEDeklaracjiWorkerParam | Ogolne | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| EksportPaczekPrzelewowParams | Params | Parametry eksportu paczek przelewów | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| EksportParams | Ogolne |  | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| EksportPrzelewowParams | Params | Parametry eksportu przelewów | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ElemDefinicjiSlownika | ElemDefinicjiSlownikaOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElemEwidencjiAkcyzy | ElementEwidencjiAkcyzy | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElemEwidencjiVATSprzedaz | ElementEwidencjiVATSprzedazOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElemEwidencjiVATZakup | ElementEwidencjiVATZakupOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElemEwidencjiVATZakup | VATEwidencjaExtender |  | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElemOpisuAnalitycznego | Budzet | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElemOpisuAnalitycznego | ElemOpisuAnalitycznego | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElemOpisuAnalitycznego | ElemOpisuAnalitycznegoBudzet | Budżet | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElemOpisuAnalitycznego | ElemOpisuAnalitycznegoRozliczenia | Powiązania | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElemRozliczenia | ElementRozliczenia | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| ElemSlownika | ElemSlownikaOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElemSysZewn | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| ElemTeczki | ElemTeczkiOgolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| ElementEmail | ElementEmailOgolne | Ogólne | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| ElementKartyOpisuStanowiska | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ElementPodatkuOdNieruch | Ogolne | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ElementRozliczeniaCzasuPracy | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ElementRozliczeniaPracownika | Net | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ElementRozliczeniaPracownika | Ogolne | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ElementSkaliOcen | Ogólne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| ElementSkaliOcen | Uzasadnienia | Słownik uzasadnień | 10 | Soneta.Core.UI.dll | Soneta.Core |
| ElementStrukturyOrganizacyjnej | ElementStrukturyOrganizacyjnej | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| ElementStrukturyOrganizacyjnej | ElementStrukturyOrganizacyjnejNet | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ElementStrukturyOrganizacyjnej | ElementyPowiazane | Elementy powiązane | 20 | Soneta.Core.UI.dll | Soneta.Core |
| ElementStrukturyOrganizacyjnej | GrupaPracowniczaAdministratorzy | Administratorzy | 20 | Soneta.Core.UI.dll | Soneta.Core |
| ElementStrukturyOrganizacyjnej | GrupaPracowniczaCzlonkowie | Członkowie | 20 | Soneta.Core.UI.dll | Soneta.Core |
| ElementStrukturyOrganizacyjnej | HistoriaPowiazan | Zmiany elementu nadrzędnego | 20 | Soneta.Core.UI.dll | Soneta.Core |
| ElementStrukturyOrganizacyjnejRef | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ElementyParam | ElementStrukturyOrg | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ElementyStrukturyOrganizacyjnejUsunWorker-ElementyUsunParam | ElemUsunParams | Parametry dodawania nowego elementu | 100 | Soneta.Core.UI.dll | Soneta.Core |
| EmailSelector | General | Adresy email | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| EmailsResult | General | Podgląd wiadomości | 100 | Soneta.Business.UI.dll | Soneta.Business |
| EncryptReport | Params | Ogólne | 100 | Soneta.Net.Business.dll | Soneta.Net |
| EnovaDatabaseBase | EnovaDatabaseBaseOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| EnovaFieldDefinition | FieldSourceOgolne | Właściwości pola | 100 | Soneta.BI.UI.dll | Soneta.BI |
| EnovaNET | EnovaNET | Pulpity/Historyczne | 40 | Soneta.Core.UI.dll | Soneta.Core |
| EnovaTableSource | TableSourceOgolne | Właściwości tabeli | 10 | Soneta.BI.UI.dll | Soneta.BI |
| Entitle | EntitleGeneral | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| Entitle | EntitleRoles | Role | 10 | Soneta.Business.UI.dll | Soneta.Business |
| Entitle | EntitleRights | Prawa obiektowe | 20 | Soneta.Business.UI.dll | Soneta.Business |
| Entitle | Operators | Operatorzy | 20 | Soneta.Business.UI.dll | Soneta.Business |
| Entitle | SystemRoles | Powiązane role | 50 | Soneta.Business.UI.dll | Soneta.Business |
| Entitle | Licences | Wymagane licencje | 55 | Soneta.Business.UI.dll | Soneta.Business |
| Entitle | Rights | Prawa | 60 | Soneta.Business.UI.dll | Soneta.Business |
| Entitle | Folders | Foldery | 65 | Soneta.Business.UI.dll | Soneta.Business |
| Entitle | Options | Opcje | 70 | Soneta.Business.UI.dll | Soneta.Business |
| Entitle | Others | Pozostałe | 75 | Soneta.Business.UI.dll | Soneta.Business |
| Entitle | ObjectRightsRights | Prawa do danych | 80 | Soneta.Business.UI.dll | Soneta.Business |
| Entitles | Entitles | Systemowe/Uprawnienia/Uprawnienia | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ErrorItem | ErrorItemOgolne | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| EtapDefProjektu | EtapyDefProjektuOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| EtapDefinicjiWindykacji | Ogolne | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| EtapDelegacji | EtapDelegacjiGeneral | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| EtapDelegacji | EtapDelegacjiKoszty | Koszty | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| EtapProjektu | EtapyProjektuOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| EtapProjektu | EtapyProjektuZadania | Aktywności etapu | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| EtapProjektu | EtapProjektuWykonujacy | Wykonujący | 22 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| EtapRealizacjiSzkolenia | EtapRealizacjiSzkolenia | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| EtapRekrutacji | KryteriaOceny | Kryteria oceny | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| EtapRekrutacji | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| EtapWykonujacy | EtapWykonujacy | Wykonujący etap projektu | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| EwidencjaMiesiecznegoPrzychoduZeSprzedazyParams | ParamsForm |  | 100 | Soneta.Handel.Reports.dll | Soneta.Handel |
| EwidencjaSP | EwidencjaSPSupewidencje | Ewidencje zależne | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| EwidencjaSPOgolne | EwidencjaSPOgolne | Ewidencje ŚP/Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| EwidencjeSP | EwidencjeSP | Ewidencje ŚP/Ewidencje | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| EwidencjeSPOdsetki | EwidencjeSPOdsetki | Ewidencje ŚP/Odsetki | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| EwidencjonowanieZbiorczeWorker-Params | Ogolne | Raport fiskalny dla paragonów | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| ExRataItem | Ogolne | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ExportData | Data | Eksport danych | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ExportDataModelsWithParentsWorker | Export | Modele do eksportu | 1 | Soneta.BI.UI.dll | Soneta.BI |
| ExportDataModelsWithParentsWorker | Selection | Dostępne modele do eksportu | 1 | Soneta.BI.UI.dll | Soneta.BI |
| ExportForm | Form | Eksportuj dane | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ExportImport | ExportImport | Systemowe/Eksport i import | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ExportTableData | Format | Format danych | 10 | Soneta.Net.Business.dll | Soneta.Net |
| ExportTableData | XML | Dane zależne | 30 | Soneta.Net.Business.dll | Soneta.Net |
| ExportTableData | Export | Eksport danych | 1000 | Soneta.Net.Business.dll | Soneta.Net |
| ExportTableDataPNWB | Format | Format danych | 10 | Soneta.Net.Business.dll | Soneta.Net |
| ExportTableDataPNWB | XML | Dane zależne | 30 | Soneta.Net.Business.dll | Soneta.Net |
| ExportTableDataPNWB | Export | Eksport danych | 1000 | Soneta.Net.Business.dll | Soneta.Net |
| ExtDatabases | ExtDatabases | Systemowe/Zewnętrzne bazy danych | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ExternalAccountProvidersConfig | ExternalAccountProvidersConfig | Systemowe/Dostawcy autoryzacji konta | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ExternalBIDatabase | ExternalBIDatabaseOgolne | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ExternalDataSource | ExternalDataSourceOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| FWUEEwidencja | DWUEEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| FWUEEwidencja | PodmiotEwidencjaDane | Dane kontrahenta | 4 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| FWUENabyciaNaleznyEwidencja-FWUENabyciaNaleznyEwidencjaDefDok | DefinicjaVATEwidencja | Rozszerzenie definicji VAT | 101 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| FWUENabyciaNaliczonyEwidencja-FWUENabyciaNaliczonyEwidencjaDefDok | DefinicjaVATEwidencja | Rozszerzenie definicji VAT | 101 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| FakturaImportowaEwidencja | FakturaImportowaEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| FakturaImportowaEwidencja | PodmiotEwidencjaDane | Dane kontrahenta | 4 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| FakturyDefinicjeCen | FakturyDefinicjeCen | Faktury/Definicje cen | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| FakturyJednostki | FakturyJednostki | Faktury/Jednostki | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| FakturyOgolne | FakturyOgolne | Faktury/Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| FeatureBrowser-Params | FeatureBrowserForm | Cecha | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FeatureDefinition | GrupaCennikTowarow | Cennik towarów | 1 | Soneta.Handel.UI.dll | Soneta.Towary |
| FeatureDefinition | GrupaRabatyTowarow | Rabaty towarów | 2 | Soneta.Handel.UI.dll | Soneta.Towary |
| FeatureDefinition | GrupaCenyKontrahentow | Ceny kontrahentów | 3 | Soneta.Handel.UI.dll | Soneta.Towary |
| FeatureDefinition | GrupaRabatyKontrahentow | Rabaty kontrahentów | 4 | Soneta.Handel.UI.dll | Soneta.Towary |
| FeatureDefinition | GrupaCeny | Ceny grup | 5 | Soneta.Handel.UI.dll | Soneta.Towary |
| FeatureDefinition | GrupaRabatow | Rabaty grup | 6 | Soneta.Handel.UI.dll | Soneta.Towary |
| FeatureDefinition | GrupaCenyGrup | Ceny grupy grup | 7 | Soneta.Handel.UI.dll | Soneta.Towary |
| FeatureDefinition | GrupaRabatyGrup | Rabaty grupy grup | 8 | Soneta.Handel.UI.dll | Soneta.Towary |
| FeatureDefinition | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | Group | Grupa | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | FeatureAdvanced | Zaawansowane | 150 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | FeatureDictionary | Słownik | 200 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | FeatureConditions | Warunki | 201 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | FeatureDictionaryList | Elementy słownika | 201 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | FeatureStrConditions | Warunki | 201 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | FeatureAlgorithm | Algorytm | 300 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | FieldsPage | UI/Formularze | 500 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | Lists | UI/Organizator listy | 520 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | Locator | UI/Lokator | 521 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinition | DomainDefinitions | BI/Domeny | 1100 | Soneta.BI.UI.dll | Soneta.BI |
| FeatureDefinition | ReportDefinitions | BI/Raporty | 1101 | Soneta.BI.UI.dll | Soneta.BI |
| FeatureDefinition | IndicatorDefinitions | BI/Wskaźniki | 1102 | Soneta.BI.UI.dll | Soneta.BI |
| FeatureDefinitionModelParams | Params | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| FeatureDefinitions | FeatureDefinitions | Systemowe/Definicje cech | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinitionsAkordy | FeatureDefinitionsAkordy | Kadry i płace/Cechy/Akordy | 10000 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FeatureDefinitionsBanki | FeatureDefinitionsBanki | Kontrahenci i urzędy/Cechy/Banki | 10001 | Soneta.Core.UI.dll | Soneta.Core |
| FeatureDefinitionsDefDokHandlowych | FeatureDefinitionsDefDokHandlowych | {new HandelFeaturesExtender.NameDefinicjeDokumentow()} | 10004 | Soneta.Handel.UI.dll | Soneta.Handel |
| FeatureDefinitionsDefElementow | FeatureDefinitionsDefElementow | Kadry i płace/Cechy/Definicje elementów | 10001 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FeatureDefinitionsDefListPlac | FeatureDefinitionsDefListPlac | Kadry i płace/Cechy/Definicje list płac | 10002 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FeatureDefinitionsDelegacje | FeatureDefinitionsDelegacje | Delegacje/Cechy/Delegacje | 10000 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| FeatureDefinitionsDodatki | FeatureDefinitionsDodatki | Kadry i płace/Cechy/Dodatki | 10003 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FeatureDefinitionsDokEwidencja | FeatureDefinitionsDokEwidencja | Ewidencja dokumentów/Cechy/Dokumenty | 10000 | Soneta.Core.UI.dll | Soneta.Core |
| FeatureDefinitionsDokHandlowe | FeatureDefinitionsDokHandlowe | {new HandelFeaturesExtender.NameDokumenty()} | 10001 | Soneta.Handel.UI.dll | Soneta.Handel |
| FeatureDefinitionsEtapyDelegacji | FeatureDefinitionsEtapyDelegacji | Delegacje/Cechy/Etapy delegacji | 10001 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| FeatureDefinitionsKampanie | FeatureDefinitionsKampanie | CRM/Cechy/Kampanie | 10010 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| FeatureDefinitionsKontrahenci | FeatureDefinitionsKontrahenci | Kontrahenci i urzędy/Cechy/Kontrahenci | 10001 | Soneta.Core.UI.dll | Soneta.Core |
| FeatureDefinitionsKorespondencje | FeatureDefinitionsKorespondencje | CRM/Cechy/Korespondencje | 10060 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| FeatureDefinitionsMagazyny | FeatureDefinitionsMagazyny | Handel/Cechy/Magazyny | 10003 | Soneta.Handel.UI.dll | Soneta.Handel |
| FeatureDefinitionsNieobecnosci | FeatureDefinitionsNieobecnosci | Kadry i płace/Cechy/Nieobecności | 10004 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FeatureDefinitionsOpisAnalityczny | FeatureDefinitionsOpisAnalityczny | Księgowość/Cechy/Opis analityczny | 10000 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| FeatureDefinitionsPlanowanyPrzeglad | FeatureDefinitionsPlanowanyPrzeglad | CRM/Cechy/Planowany przegląd | 10050 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| FeatureDefinitionsPlatnosci | FeatureDefinitionsPlatnosci | Ewidencje ŚP/Cechy/Płatności | 10000 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FeatureDefinitionsPozycjeDokHan | FeatureDefinitionsPozycjeDokHan | {new HandelFeaturesExtender.NamePozycjeDokumentow()} | 10002 | Soneta.Handel.UI.dll | Soneta.Handel |
| FeatureDefinitionsPracownicy | FeatureDefinitionsPracownicy | Kadry i płace/Cechy/Pracownicy | 10005 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FeatureDefinitionsProjekty | FeatureDefinitionsProjekty | CRM/Cechy/Projekty | 10020 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| FeatureDefinitionsPrzelewy | FeatureDefinitionsPrzelewy | Ewidencje ŚP/Cechy/Przelewy | 10001 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FeatureDefinitionsTable | FeatureDefinitionsTable | Ogólne/Cechy/Globalne | 10000 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureDefinitionsTickets | FeatureDefinitionsTickets | Pulpity/Pulpit kontrahenta/ServiceDesk/Cechy/ServiceDesk | 10030 | Soneta.Support.UI.dll | Soneta.Support |
| FeatureDefinitionsTowary | FeatureDefinitionsTowary | {new HandelFeaturesExtender.NameTowary()} | 10000 | Soneta.Handel.UI.dll | Soneta.Handel |
| FeatureDefinitionsUmowy | FeatureDefinitionsUmowy | Kadry i płace/Cechy/Umowy | 10006 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FeatureDefinitionsUrzadzenia | FeatureDefinitionsUrzadzenia | CRM/Cechy/Urządzenia | 10040 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| FeatureDefinitionsUrzadzeniaUz | FeatureDefinitionsUrzadzeniaUz | Handel/Cechy/Urządzenia | 10005 | Soneta.Handel.UI.dll | Soneta.Handel |
| FeatureDefinitionsUrzędyCelne | FeatureDefinitionsUrzędyCelne | Kontrahenci i urzędy/Cechy/Urzędy Celne | 10001 | Soneta.Core.UI.dll | Soneta.Core |
| FeatureDefinitionsUrzędySkarbowe | FeatureDefinitionsUrzędySkarbowe | Kontrahenci i urzędy/Cechy/Urzędy Skarbowe | 10001 | Soneta.Core.UI.dll | Soneta.Core |
| FeatureDefinitionsWydzialy | FeatureDefinitionsWydzialy | Kadry i płace/Cechy/Wydziały | 10007 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FeatureDefinitionsZadania | FeatureDefinitionsZadania | CRM/Cechy/Zadania | 10030 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| FeatureDefinitionsZaplaty | FeatureDefinitionsZaplaty | Ewidencje ŚP/Cechy/Zapłaty | 10002 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FeatureSetDefinition | Algorithm | Algorytm | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureSetDefinition | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureSetDefinitionItem | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureSetDefinitions | FeatureSetDefinitions | UI/Definicje zestawów pól | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureSetRelation | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FeatureTransferDefinition | Ogolne | Ogólne | 20 | Soneta.Business.UI.dll | Soneta.Business |
| FeaturesTablesMigrationWorkerParams | Params |  | 100 | Soneta.Business.dll | Soneta.Business |
| FidoAuthentication | FidoAuthentication | Ogólne | 100 | Soneta.Net.Business.dll | Soneta.Net |
| FidoRegistration | FidoRegistration | Ogólne | 100 | Soneta.Net.Business.dll | Soneta.Net |
| FieldDefinition | FieldDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| FieldDefinition | FieldDefinitionRelationship | Pola nadrzędne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| FieldElementDecorator | Column | Kolumna | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FieldElementDecorator | Condition | Pole filtrujące | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FieldsDashboardWorker | General | Pola | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FieldsDashboardWorker | Xml | Form.Xml | 200 | Soneta.Business.UI.dll | Soneta.Business |
| FileChooserExtender | General | Wybór pliku | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FileStorage | FileStorage | Systemowe/Załączniki/Przechowywanie plików | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FinalizeObfuscationWizard-AnonimizationWizard | InitializationStep | Przeprowadzenie anonimizacji | 10 | Soneta.Core.dll | Soneta.Core |
| FinalizeObfuscationWizard-AnonimizationWizard | ConfirmationStep | Przeprowadzenie anonimizacji | 20 | Soneta.Core.dll | Soneta.Core |
| FinalizeObfuscationWizard-PseudonimizationWizard | InitializationStep | Przeprowadzenie pseudonimizacji | 10 | Soneta.Core.dll | Soneta.Core |
| Fine | General | Ogólne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| FirmaDzialalnosc | FirmaDzialalnosc | Firma/Dane o działalności | 2 | Soneta.Core.UI.dll | Soneta.Core |
| FirmaDzialalnosc2 | FirmaDzialalnosc2 | Firma/Dane o działalności (pozostałe) | 3 | Soneta.Core.UI.dll | Soneta.Core |
| FirmaKluczSprzetowy | FirmaKluczSprzetowy | Firma/Klucz zabezpieczający | 100 | Soneta.Core.UI.dll | Soneta.Core |
| FirmaKontakt | FirmaKontakt | Firma/Kontakt | 5 | Soneta.Core.UI.dll | Soneta.Core |
| FirmaKsiegowosc | FirmaKsiegowosc | Firma/Rodzaj prowadzonej księgowości | 100 | Soneta.Core.UI.dll | Soneta.Core |
| FirmaLokalizacje | FirmaLokalizacje | Firma/Lokalizacje | 6 | Soneta.Core.UI.dll | Soneta.Core |
| FirmaNazwaIAdres | FirmaNazwaIAdres | Firma/Nazwa i adres | 1 | Soneta.Core.UI.dll | Soneta.Core |
| FirmaPodmiotyPowiazane | FirmaPodmiotyPowiazane | Firma/Podmioty powiązane | 10 | Soneta.Core.UI.dll | Soneta.Core |
| FirmaUrzedy | FirmaUrzedy | Firma/Urzędy i KRS | 12 | Soneta.CRM.UI.dll | Soneta.CRM |
| FirstWizard | FirstStep | Krok pierwszy | 1 | Soneta.Business.UI.dll | Soneta.Business |
| FirstWizard | SecondStep | Krok drugi | 2 | Soneta.Business.UI.dll | Soneta.Business |
| FirstWizard | ThirdStep | Krok trzeci | 3 | Soneta.Business.UI.dll | Soneta.Business |
| FiskalizacjaDokumentuWorker-ParametryFiskalizacjiDokumentu | Ogolne | Parametry fiskalizacji | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| FolderAsync | General | Folder asynchroiczny | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderChartTest | General | Test wykresów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderChartTest | View | Test wykresów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderChips | General | Test Chips | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderCircularIndicator | General | Test CircularIndicator | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderComplexHierarchicalTree | General | TreeDiagram | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderDateNavigator | General | Test DateNavigator | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderDesignerData | Folders | Foldery | 900 | Soneta.Net.Business.dll | Soneta.Net |
| FolderDesignerData | Storage | Kontekst konfiguracji | 1000 | Soneta.Net.Business.dll | Soneta.Net |
| FolderDesignerData | Favorites | Startowy i ulubione | 1100 | Soneta.Net.Business.dll | Soneta.Net |
| FolderIndicator | General | Test wskaźników | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderKomunikacjaTest | General | Kontrolka Dyskusji - Komunikacja | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderLargeTreeDiagram | General | LargeTreeDiagram | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderOrganizationalChart | General | TreeDiagram | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderTest | Cards | Test Cards | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderTest | Dashboard | Folder dashboard | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderTest | Editors | Folder testowy edytorów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderTest | General | Folder testowy | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderTest | Grid | Test listy | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderTest | Second | Drugi | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderTest | Third | Trzeci | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderTest | TileRow | Test TileRow | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderTestArgs | General | Args | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderThreadCommentsTest | General | Kontrolka Dyskusji | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderTimelineClock | General | Test Timeline clock | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderView | General | Folder | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FolderView | TableView | Folder listy | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Folders | Folders | UI/Foldery | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FooterSubreports | FooterSubreports | Raportowanie/REPX/Stopki | 507 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| FormDesigner | General | Formularz | 100 | Soneta.Net.Business.dll | Soneta.Net |
| FormDesigner | FieldsPage | Definiowane zakładki | 1001 | Soneta.Business.UI.dll | Soneta.Business |
| FormDesigner | XML | FORM.XML | 99999 | Soneta.Business.UI.dll | Soneta.Business |
| FormDesigner | FieldSets | Zestawy pól | 100000 | Soneta.Business.UI.dll | Soneta.Business |
| FormGenerator | General | Wydruk formularza | 100 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| FormaOrganizacjiPracy | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FormaPlatnosci | FormaPlatnosci | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormaPrawna | Ogolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| FormatWymianyElektronicznej | FormatWymianyElektronicznej | Ogólne | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormatWymianyElektronicznej | ParametryElixirOControl | Elixir-O | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormatWymianyElektronicznej | ParametryFormatXml | XML Definiowalny | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormatWymianyElektronicznej | ParametryISO20022 | ISO 20022 | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormatWymianyElektronicznej | ParametryKreatoraEksportu | Parametry kreatora | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormatWymianyElektronicznej | ParametrySwiftMt100 | Swift MT 100 | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormatWymianyElektronicznej | ParametrySwiftMt103 | Swift MT 103 | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormatWymianyElektronicznej | PolaKreatoraEksportu | Kolumny | 30 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormatWymianyElektronicznej | FormatWymianyElektronicznejParametry | Parametry (XML) | 1000 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormatyWymElektr | FormatyWymElektr | Ewidencje ŚP/Bankowość elektroniczna/Formaty wymiany elektronicznej | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Forms | Forms | UI/Formularze | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FormularzWartosciowania | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FormularzWartosciowania | Wyniki | Wyniki wartościowania | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FormularzWartosciowania | KategoriePracownikow | Kategorie pracowników | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FormyPlatnosci | FormyPlatnosci | Ewidencje ŚP/Definicje płatności | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| FormyPrawne | FormyPrawne | Kontrahenci i urzędy/Formy prawne | 1000 | Soneta.CRM.UI.dll | Soneta.CRM |
| FrameAppTest | Frame | Komunikacja z Frame | 100 | Soneta.Business.UI.dll | Soneta.Business |
| FullTextSearchListing | FullTextSearchListing | Indeksy pełnotekstowe | 100 | Soneta.Business.dll | Soneta.Business |
| FullTextSearchListingWeb | FullTextSearchListingWeb | Indeksy pełnotekstowe | 100 | Soneta.Business.dll | Soneta.Business |
| FundPozyczkowy | FunduszPozyczkowy | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FundPozyczkowy | FunduszPozyczkowyNet | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FundPozyczkowy | FunduszPozyczkowyPozyczki | Pożyczki | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FundPozyczkowy | FunduszPozyczkowyDoplatyWycofania | Dopłaty, wycofania wkładu | 3 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FundPozyczkowy | FunduszPozyczkowyZaplaty | Dodatkowe wpłaty, wypłaty | 4 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| FundPozyczkowy | ElementyWynagrodzeniaExt | Elementy wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GIODOCelPrzetwarzania | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| GIODODefOswiadcz | GIODODefOswiadcz | Ogólne/Ochrona danych osobowych/Definicje oświadczeń | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GIODODefUprawnien | GIODODefUprawnien | Ogólne/Ochrona danych osobowych/Definicje uprawnień | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GIODODefinicjaOswiadczenia | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| GIODODefinicjaOswiadczenia | Wycofywane | Wycofywane lub zastępowane zgody | 20 | Soneta.Core.UI.dll | Soneta.Core |
| GIODODefinicjaUprawnienia | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOKategoriaDanychOsobowych | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOKategoriaOdbiorcow | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOKategoriaOsob | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GIODONaruszenie | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOOgolne | GIODOOgolne | Ogólne/Ochrona danych osobowych/Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOOswiadczenie | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOOswiadczenie | WycofaneZgody | Wycofane zgody | 10 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOOswiadczenie-ZgodyDoWycofania2Worker | WybierzZgody | Wybierz | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOPowierzenieDanych | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOPowierzenieZbioru | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOPozyskanieDanych | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOPozyskanieZbioru | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOPrzetwarzanie | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOUdostepnienieDanych | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOUprawnienie | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOZbiorDanych | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOZbiorDanych | KategorieDanychOsobowych | Kategorie danych osobowych | 20 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOZbiorDanych | Odbiorcy | Odbiorcy | 30 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOZbiorDanych | CzynnosciPrzetwarzania | Czynności | 40 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOZbiorDanych | Naruszenia | Naruszenia ochrony danych osobowych | 50 | Soneta.Core.UI.dll | Soneta.Core |
| GIODOZbiorDanych | Wymiany | Udostępniania, powierzenia | 50 | Soneta.Core.UI.dll | Soneta.Core |
| GanttDiagram | General | GanttDiagram | 100 | Soneta.Business.UI.dll | Soneta.Business |
| General | General | Workflow/Ogólne | 97 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| GeneratorSprawResult | Ogolne | Sprawy | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| GeneratorZamowien | ZamowieniaDokumenty | Dokumenty | 100 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| GeneratorZamowien | ZamowieniaPozycje | Pozycje | 200 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| GeneratorZamowien | ZamowieniaDokumentyZrodlowe | Dokumenty źródłowe | 300 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| GeneratorZamówień-GeneratorZamówieńParams | Ogolne | Generator zamówień | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| GenerowanieDokumentowZmianyMiejscaUzytkowaniaWorker | Generowanie | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| GenerujJPKVATParams | Ogolne | Parametry | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| GenerujJednolityPKDBItemParams | Ogolne | Parametry | 100 | Soneta.EI.UI.dll | Soneta.EI |
| GenerujJednolityPKDBItemVATParams | Ogolne | Parametry | 100 | Soneta.EI.UI.dll | Soneta.EI |
| GenerujJednolityPKParams | Ogolne | Parametry | 100 | Soneta.Core.UI.dll | Soneta.Core |
| GenerujJednolityPKVatParams | Ogolne | Parametry | 100 | Soneta.EI.UI.dll | Soneta.EI |
| GlobalAttachments | GlobalAttachments | Ogólne/Załączniki globalne | 100 | Soneta.Net.Business.dll | Soneta.Net |
| GlobalFeatures | GlobalFeatures | Ogólne/Cechy globalne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| GlobalJobInvokeLogs | GlobalJobInvokeLogs | Workflow/Harmonogram zadań/Historia wywołań | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| GlobalScheduleDefinitions | GlobalScheduleDefinitions | Workflow/Harmonogram zadań/Definicje harmonogramów zadań | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| GlobalScheduleItems | GlobalScheduleItems | Workflow/Harmonogram zadań/Planowane wywołania | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| GlobalTaskDefinitions | GlobalTaskDefinitions | Workflow/Harmonogram zadań/Definicje zadań globalnych | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| GlobalTasks | GlobalTasks | Workflow/Harmonogram zadań/Zadania globalne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| GmailAuthProvider | Ogolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| GrafikDzienProxy | Net | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrafikPracy | GrafikPracy | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrafikPracy | Net | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrafikPracy | GrafikPracyZasoby | Grafik | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrafikPracy | ZasobyNet | Grafik | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrafikWybierzPracownikowNet | Net | Wybierz | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrafikWybierzPracownikowWorker | GrafikWybierzPracownikow | Wybierz | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GroupSelector | Groups | Grupy | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| GroupsDesigner | General | Grupy | 100 | Soneta.Business.UI.dll | Soneta.Business |
| GrupaDostaw | GrupaDostaw | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| GrupaDostaw | GrupaDostawMarza | Marża | 20 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| GrupaDostaw | GrupaDostawObroty | Obroty | 30 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| GrupaKontBudzetujaca | GrupaKontBudzetujacaOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| GrupaKontSynchronizujaca | GrupaKontOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| GrupaMaterial | GrupaMaterialSzkolOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| GrupaStanowisk | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrupaSzkol | GrupaSzkolOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| GrupaSzkol | GrupaSzkolMaterialy | Materiały | 40 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| GrupaSzkol | GrupaSzkolZespoly | Zespoły | 50 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| GrupaSzkol | GrupaSzkolUczestnicy | Uczestnicy | 60 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| GrupaSzkol | GrupaSzkolZajecia | Zajęcia | 70 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| GrupaSzkol | GrupaSzkolZajeciaKalend | Kalendarz zajęć | 71 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| GrupaSzkol | GrupaSzkolCertyfikaty | Certyfikaty | 80 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| GrupaSzkol | GrupaSzkolDokumentyHan | Dokumenty handlowe | 80 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| GrupaSzkolenIUprawnien | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrupaZadan | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrupaZaszeregowania | GrupaZaszeregowania | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrupyPracownicze | Net | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GrupyPracownicze | Ogolne | Grupy pracownicze | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| GuidedRowPreview | Preview | Podgląd | 100 | Soneta.Business.UI.dll | Soneta.Business |
| GusParams | DaneZGusParam | Parametry | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| GustHostDataDiffers | GustHostDataDiffers | Różncia zmian | 31 | Soneta.CRM.UI.dll | Soneta.CRM |
| HTTPLinkInfo | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| HandelDefinicjeCen | HandelDefinicjeCen | Handel/Definicje cen | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| HandelDeklaracjaIntrastat | HandelDeklaracjaIntrastat | Handel/Deklaracja Intrastat | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelDrukarkaFiskalna | HandelDrukarkaFiskalna | Handel/Drukarka fiskalna | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelECommerce | HandelECommerce | Systemy zewnętrzne/e-commerce | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelEwidencjaPrzychoduWgPKD | HandelEwidencjaPrzychoduWgPKD | Handel/Ewidencja przychodu wg PKD | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelFirmyTransportowe | HandelFirmyTransportowe | Systemy zewnętrzne/Spedytorzy | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelFormularzTowaru | HandelFormularzTowaru | Handel/Formularze/Towar - zakładka użytkownika | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| HandelFormularzTowaruNET | HandelFormularzTowaruNET | Handel/Formularze/Towar – zakładka PK | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| HandelJednostki | HandelJednostki | Handel/Jednostki | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| HandelKolektoryDanych | HandelKolektoryDanych | Handel/Kolektory danych | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelMagazyny | HandelMagazyny | Handel/Magazyny | 100 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| HandelOgolne | HandelOgolne | Handel/Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelPlatnosciFaktura | HandelPlatnosciFaktura | Faktury/Płatności | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelPlatnosciHandel | HandelPlatnosciHandel | Handel/Płatności | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelSposobyDostawy | HandelSposobyDostawy | Handel/Sposoby dostawy | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelSprawdzarkaCen | HandelSprawdzarkaCen | Handel/Sprawdzarka cen | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelTerminalePlatnicze | HandelTerminalePlatnicze | Ewidencje ŚP/Terminale płatnicze | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HandelTowary | HandelTowary | Handel/Towary | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| HandelUrzadzenie | HandelUrzadzenie | {new HandelUrzadzenieExtender.Name()} | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| HeaderSubreports | HeaderSubreports | Raportowanie/REPX/Nagłówki | 503 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| HistAktualizacja | Ogolne | Ogólne | 100 | Soneta.Business.dll | Soneta.Business |
| HistAktualizacje | HistAktualizacje | Ogólne/Definicje Aktualizacji | 1 | Soneta.Core.UI.dll | Soneta.Core |
| HistZadania | HistoriaZadaniaOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| HistZadania | HistoriaZadaniaSerwisOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| HistoriaDanychFirmyBase | HistoriaDanychFirmy | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| HistoriaDanychOddzialu | HistoriaDanychOddzialu | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| HistoriaDanychWydzialu | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| HistoriaPodzielnika | PodzielnikKosztow | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| HistoriaPodzielnika | RowHistory | Historia zapisów | 999 | Soneta.Core.UI.dll | Soneta.Core |
| HistoriaZatrudnienia | HistoriaZatrudnienia | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| HistoriaZatrudnienia | HistoriaZatrudnieniaOkresyNiewliczane | Okresy niewliczane do stażu pracy | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| HistoriaZatrudnienia | HistoriaZatrudnieniaOkresyPracyTymczasowej | Okresy pracy tymczasowej | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| HstDanychBiuraRachunkowego | HstDanychBiuraRachunkowego | Firma/Zmiana danych biura rachunkowego | 100 | Soneta.Core.UI.dll | Soneta.Core |
| HstDanychFirmy | HstDanychFirmy | Firma/Zmiana danych firmy | 100 | Soneta.Core.UI.dll | Soneta.Core |
| HybridWorkNotification | Sending | Powiadomienie | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| HybridWorkSchedulerViewInfo | General | Kalendarz PracyHybrydowej | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IAdresyWWWHost | AdresyWWW | Adresy WWW | 100000 | Soneta.Core.UI.dll | Soneta.Core |
| IAlgorithmsContainer | Container | {PageDescription.CaptionHtml} | 1 | Soneta.Business.UI.dll | Soneta.Business |
| IAspekt | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IBasicDocumentContainer | General | Dokument podstawowy - ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| IBasicDocumentContainer | User | Dokument podstawowy - użytkownika | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| IBasicDocumentContainer | Additional | Dokument podstawowy - pozostałe | 110 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| IBazaZrodlaWyplaty | ElementyWynagrodzenia | Elementy wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IBudzetowany | IBudzetowanyOgolne | Budżetowanie/Budżet | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IBudzetowany | General | Budżetowanie/Wersje planów | 110 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IBudzetowany | Planning | Budżetowanie/Planowanie | 120 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IBudzetowany | Implementation | Budżetowanie/Realizacja | 130 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ICRUContractHost | CRU | Centralny Rejestr Umów (CRU) | 1000 | Soneta.Core.UI.dll | Soneta.Core |
| IChronoOrderHost | General | Skład chronologiczny | 1000 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ICodeFileHost | MultiCodeFileEditor | Dodatkowe pliki/{Name} | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ICodeHelp | CalculatorsInfo | Informacje | 999999 | Soneta.Business.UI.dll | Soneta.Business |
| IConfigurationKey | FieldsPage | Zakładki definiowane | 1000 | Soneta.Business.UI.dll | Soneta.Business |
| IDefinedPropertyRow | Uzytkownika | {new IDefinedPropertyRowUzytkownikaExtender.GetTitle()} | 150 | Soneta.Core.UI.dll | Soneta.Core |
| IDefinicjaKomunikatuEDIHost | Komunikaty | EDI | 1000 | Soneta.Core.UI.dll | Soneta.Core |
| IDeklaracjaPlatna | DeklaracjaZobowiazania | Płatności | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IDeklaracjaTekstPrywatnyUI | Tekst | Pole prywatne | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IDependentWfDefinitionParentPage | WfDefinition | Definicja procesu zależnego | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| IDokumentCRM | IDokumentCRMZadaniaPK | Zadania CRM | 1010 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IDokumentCRM | IDokumentCRMZadania | Zadania CRM | 1030 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IDostepnoscHost | KalendarzDostepnosci | Kalendarz/Dostępność | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IDostepnoscHost | RegulyDostepnosci | Kalendarz/Dostępność - reguły | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IDostepnoscHostHist | KalendarzDostepnosci | Kalendarz/Dostępność | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IDostepnoscHostHist | RegulyDostepnosci | Kalendarz/Dostępność - reguły | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IDrukarkaFiskalna | Ogolne | Drukarka fiskalna | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| IDrukarkaFiskalna | Operatorzy | Operatorzy | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| IDrukarkaFiskalna | Stanowiska | Stanowiska | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| IDzienPracy | DzienPracyKorekty | Wersje | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IElementKsiegowalny | Powiazane | Powiązane zapisy | 200 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| IEmailElement | WiadomosciPowiazane | {New WiadomosciPowiazaneExtender.CaptionHtml} | 2000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IEwidencjaAkcyzyEwidencjaPage | EwidencjaAkcyzyEwidencja | Akcyza | 3 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| IFT1 | IFT1_12 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_14 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_15 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_7 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_12Form | D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_14Form | D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_15Form | D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_16Form | D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17Form | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormD | D (Rodzaje przychodów) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormE | E (8 Dochody z żeglugi) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormF | F (10 Dywidendy) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormG | G (11 Odsetki) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormH | H (12 Należności licencyjne) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormI | I (14 Wolne zawody) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormJ | J (16 Wynagr. dyrektorów) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormK | K (17 Działalność artystyczna) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormL | L (18 Emerytury lub renty) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormM | M (21 Inne dochody) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormN | N (99 Przychód z art. 29) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormO | O (99 Przychód z art. 30) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1 | IFT1_17FormP | P (99 Przychód z art. 30a) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_12 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_14 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_15 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17Form | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_7 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_12Form | D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_14Form | D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_15Form | D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_16Form | D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormD | D (Rodzaje przychodów) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormE | E (8 Dochody z żeglugi) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormF | F (10 Dywidendy) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormG | G (11 Odsetki) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormH | H (12 Należności licencyjne) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormI | I (14 Wolne zawody) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormJ | J (16 Wynagr. dyrektorów) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormK | K (17 Działalność artystyczna) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormL | L (18 Emerytury lub renty) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormM | M (21 Inne dochody) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormN | N (99 Przychód z art. 29) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormO | O (99 Przychód z art. 30) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R | IFT1R_17FormP | P (99 Przychód z art. 30a) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R_5 | IFT1R_5 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1R_6 | IFT1R_6 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1_4 | IFT1_4 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1_5 | IFT1_5 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT1_6 | IFT1_6 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_10 | IFT2_10_1 | Ogólne, A, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_10 | IFT2_10_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_10 | IFT2_10_3 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_10 | IFT2_10_4 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_11 | IFT2_11_1 | Ogólne, A, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_11 | IFT2_11_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_11 | IFT2_11_3 | E, F | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_11 | IFT2_11_4 | G, H | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_11 | IFT2_11_5 | I, J | 7 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_11 | IFT2_11_6 | K, L | 9 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_11 | IFT2_11_7 | M, N | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_11 | IFT2_11_8 | O | 13 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_11 | IFT2_11_9 | P | 14 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_11 | IFT2_11_10 | Q, R, S, T | 15 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_12 | IFT2_12_1 | Ogólne, A, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_12 | IFT2_12_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_12 | IFT2_12_3 | E, F | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_12 | IFT2_12_4 | G, H | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_12 | IFT2_12_5 | I, J | 7 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_12 | IFT2_12_6 | K, L | 9 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_12 | IFT2_12_7 | M, N | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_12 | IFT2_12_8 | O, P | 13 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_12 | IFT2_12_9 | Q | 14 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_12 | IFT2_12_10 | R, S, T, U | 15 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_5 | IFT2_5_1 | Ogólne, A, B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_5 | IFT2_5_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_5 | IFT2_5_3 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_5 | IFT2_5_4 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_6 | IFT2_6_1 | Ogólne, A, B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_6 | IFT2_6_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_6 | IFT2_6_3 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_6 | IFT2_6_4 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_7 | IFT2_7_1 | Ogólne, A, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_7 | IFT2_7_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_7 | IFT2_7_3 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_7 | IFT2_7_4 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_8 | IFT2_8_1 | Ogólne, A, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_8 | IFT2_8_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_8 | IFT2_8_3 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_8 | IFT2_8_4 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_9 | IFT2_9_1 | Ogólne, A, C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_9 | IFT2_9_2 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_9 | IFT2_9_3 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFT2_9 | IFT2_9_4 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IFirmaHostUI | FirmaObiektu | Oddział | 999 | Soneta.Core.UI.dll | Soneta.Core |
| IGIODOZgodnyHost | OchronaDanych | Ochrona danych | 999999 | Soneta.Core.dll | Soneta.Core |
| IGrupaKompetencji | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IHistory | HostTuples | Dokumenty dodatkowe | 997 | Soneta.Core.UI.dll | Soneta.Core |
| IHistory | RefTuples | Powiązane dokumenty dodatkowe | 998 | Soneta.Core.UI.dll | Soneta.Core |
| IHistory | DependentWorkflow | Obsługa procesu | 99998 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| IHistory | Discussion | Dyskusja | 999998 | Soneta.Core.UI.dll | Soneta.Core |
| IInformacjaOPrzetwarzaniuWnioskuHost | InformacjaOPrzetwarzaniuWniosku | Informacja o przetwarzaniu wniosku | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IIsoProceduraHost | IsoProceduraHost | ISO | 100 | Soneta.Core.UI.dll | Soneta.Core |
| IKPiRPage | EwidencjaKP | Zapis KPiR | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| IKPiRPage | EwidencjaRyczalt | Ewidencja przychodu | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| IKompetencja | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IKomunikatEDIHost | Komunikat | EDI | 50 | Soneta.Core.UI.dll | Soneta.Core |
| IKomunikatKSeFHost | Komunikat | KSeF | 50 | Soneta.Core.UI.dll | Soneta.Core |
| IKontrahent | KontrahentKontakt | Osoby kontaktowe | 30 | Soneta.CRM.UI.dll | Soneta.CRM |
| IKontrahent | IKontrahentDaneKontaktowe | Dane kontaktowe | 31 | Soneta.CRM.UI.dll | Soneta.CRM |
| IKontrahent | KontrahentUwagi | Uwagi | 40 | Soneta.CRM.UI.dll | Soneta.CRM |
| IKontrahent | IKontrahentLokalizacje | CRM/Lokalizacje | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| IKontrahent | IKontrahentProjekty | CRM/Projekty | 110 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IKontrahent | IKontrahentZadania | CRM/Aktywności | 120 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IKontrahent | IKontrahentUrzadzenia | CRM/Urządzenia | 130 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ILicenceView | General | Licencja | 100 | Soneta.Business.Licence.dll | Soneta.Business |
| IManagedRowDefinion | Kreacja | Zarządzanie | 100 | Soneta.Core.UI.dll | Soneta.Core |
| IManagedRowInfoHost | Metryka | Metryka | 90 | Soneta.Core.UI.dll | Soneta.Core |
| IMfaOperator | MfaOperator | Uwierzytelnianie 2FA | 9999999 | Soneta.Business.UI.dll | Soneta.Business |
| INF_2_v1 | INF2Ogolne_v1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_2_v1 | INF2ObowiazekWyplat_v1 | Składanie informacji za poszczególne miesiące | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D | INFD | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D | INFDZalaczniki | Załączniki | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v1 | INFDP | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v1 | INFDPNiepelnosprawnosc | Stopień niepełnosprawności | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v1 | INFDPZatrudnienie | Zatrudnienie | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v2 | INFDPv2 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v2 | INFDPv2Niepelnosprawnosc | Stopień niepełnosprawności | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v2 | INFDPv2Zatrudnienie | Zatrudnienie | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v4 | INFDPv4 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v4 | INFDPv4Zatrudnienie | Zatrudnienie | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v5 | INFDPv5 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v5 | INFDPv5Niepelnosprawnosc | Stopień niepełnosprawności | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v6_Base | INFDPv6 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_D_P_v6_Base | INFDPv6Niepelnosprawnosc | Stopień niepełnosprawności | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_U_P_v1 | INFUP | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_U_P_v1 | INFUPNiepelnosprawnosc | Stopień niepełnosprawności | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INF_U_P_v1 | INFUPZatrudnienie | Zatrudnienie | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| INotifactionEmail | Ogolne | Ogólne | 1 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IObiektDoPlanowania | Ogolne | Planowanie grafików/Ogólne | 301 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IObiektDoPlanowania | KalendarzObiektuCzas | Planowanie grafików/Kalendarz - czas pracy | 302 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IObiektDoPlanowania | KalendarzObiektuPlan | Planowanie grafików/Kalendarz - plan pracy | 302 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IObiektDoPlanowania | Dokumenty | Planowanie grafików/Dokumenty | 303 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IObiektDoPlanowaniaHist | Ogolne | Planowanie grafików/Ogólne | 301 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IObiektDoPlanowaniaHist | KalendarzObiektuCzas | Planowanie grafików/Kalendarz - czas pracy | 302 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IObiektDoPlanowaniaHist | KalendarzObiektuPlan | Planowanie grafików/Kalendarz - plan pracy | 302 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IObiektDoPlanowaniaHist | Dokumenty | Planowanie grafików/Dokumenty | 303 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IOcrParams | IOcrParams | Parametry OCR | 100 | Soneta.Core.UI.dll | Soneta.Core |
| IOddzialFirmyRow | IOddzialFirmyRow | Oddziałowość | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IOddzialHostUI | OddzialObiektu | Oddział | 999 | Soneta.Core.UI.dll | Soneta.Core |
| IParentZrodlaOpisuAnalitycznego | IParentZrodlaAnalitycznegoOpisy | Opis analityczny | 1100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| IPermissionClient | Permissions | Uprawnienia rekordu | 999999 | Soneta.Business.UI.dll | Soneta.Business |
| IPodmiot | IPodmiotPowiazania | Powiązania | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| IPodmiot | BasicDocs | DMS/Dokumenty podstawowe | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| IPodmiotKasowy | RozrachunkiPodmiotu | Rozrachunki/Rozrachunki | 300 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| IPodmiotKasowy | PrzelewyPodmiotu | Rozrachunki/Przelewy | 310 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| IPodmiotKasowy | RozliczeniowePodmiotu | Rozrachunki/Dokumenty rozliczeniowe | 320 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| IPodmiotKasowy | DokEwidencjiPodmiotu | Dokumenty ewidencji/Dokumenty | 400 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| IPodmiotKasowy | Matryce | Dokumenty ewidencji/Powiązane matryce | 410 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| IPoziom | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IProOperacjaWzorcowa | Materialy | Materiały | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| IProOperacjaWzorcowa | Odpady | Odpady | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| IProOperacjaWzorcowa | Zasoby | Zasoby | 500 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| IProOperacjaWzorcowa | Uslugi | Koszty dodatkowe | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| IProOperacjaWzorcowa | Wyroby | Wyroby | 700 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| IProOperacjaWzorcowa | Kalkulacja | Kalkulacja | 800 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| IPrzecenaPrzychodu | Przecena | Przecena | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| IPrzyczynaNieobecności | PrzyczynaNieobecnosciNieobecnosci | Nieobecności | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IRightsSource | Rights2 | Prawa do danych | 10000 | Soneta.Business.UI.dll | Soneta.Business |
| IRightsSource | SourceRights | Prawa danych | 10000 | Soneta.Business.UI.dll | Soneta.Business |
| IRozliczalny | RozliczalnyWindykacja | Windykacja | 99 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| IRuntimeRow | MultireferenceField | {Caption} | 10 | Soneta.Business.UI.dll | Soneta.Business |
| IRuntimeRowDefinition | RuntimeDefinitionFields | Definicje pól | 10 | Soneta.Business.UI.dll | Soneta.Business |
| IScheduleAutoJob | IScheduleAutoJobScheduleDefs | Automatyczne akcje | 88888 | Soneta.Core.UI.dll | Soneta.Core |
| IScheduleAutoJob | JobInvokeLogHistory | Historia wywołań | 99999 | Soneta.Core.UI.dll | Soneta.Core |
| ITechnologiaProvider | TechnologiaGantt | Wykres Gantta | 1001 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ITechnologiaProvider | TechnologiaSurowce | Surowce | 1002 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ITechnologiaProvider | TechnologiaProdukty | Produkty | 1003 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ITechnologiaProvider | TechnologiaKoszty | Koszty | 1004 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ITechnologiaProvider | ZasobyTechnologiczne | Zasoby | 1005 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ITechnologiaProvider | Osoby | Osoby | 1006 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ITestDrukarkiWorker | WorkerPage | Drukarka | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| IToDoItemHost | General | Do zrobienia | 100 | Soneta.Core.UI.dll | Soneta.Core |
| IUmowaZKalendarzemHistoria | CzasPracy | Kalendarz/Czas pracy | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IUmowaZKalendarzemHistoria | UmowaNieobecnosci | Kalendarz/Nieobecności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IUmowaZKalendarzemHistoria | PlanPracy | Kalendarz/Norma czasu pracy | 1000 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IUmowaZKalendarzemHistoria | DokumentyAktualizacjiKalendarza | Kalendarz/Dokumenty aktualizacji kalendarza | 1500 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IUmowaZKalendarzemHistoria | UmowaWnioskiUrlopowe | Kalendarz/Wnioski o nieobecność | 1600 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IWA | IWA | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IWFFeatureDefs | FeautureDefs | Dodatkowe pola | 9999 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| IWizardReferenceHost | WizardsRef | Powiązane kreatory | 100 | Soneta.Business.UI.dll | Soneta.Business |
| IWniosekNADZP | VAT7WniosekNADZP | Wniosek NAD-ZP | 23 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IWniosekVATZT | VAT7WniosekVATZT | Wniosek VAT-ZT | 22 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IWniosekVATZZ | VAT7WniosekVATZZ | Wniosek VAT-ZZ | 21 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IWypElement | WypElementPodatki | Podatki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IWypElement | WypElementUmowaPodatki | Podatki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IWypElement | WypElementZus | Składki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IWypElement | WypElementZusBudzet | Składki (budżet) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IWypElement | WypElementPPK | PPK | 101 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IWypElement | WypElementZapisObliczen | Zapis obliczeń | 106 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IZgloszenieUczestnikProvider | ZgloszenieUczestnikCertyfikaty | Certyfikaty | 20 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| IZgloszenieUczestnikProvider | ZgloszenieUczestnikPrzeniesienia | Przeniesienia | 20 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| IZgloszenieUczestnikProvider | ZgloszenieUczestnikGrupyModuly | Moduły | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| IZgloszenieUczestnikProvider | ZgloszenieUczestnikHistoriaPlatnika | Historia zmian płatnika | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| IZgloszenieUczestnikProvider | ZgloszenieUczestnikHarmWplaty | Harmonogram wpłat | 90 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| IZgloszenieUczestnikProvider | ZgloszenieUczestnikEgzaminy | Egzaminy | 200 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| IZklSlownik | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IZrodloHarmWplaty | IZrodloHarmWplaty | Harmonogram wpłat | 90 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| IZrodloKartyCharakterystykiPracownika | KartyKompetencjiPracownika | Karty kompetencji | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| IZrodloOpisAnalitycznegoPageBinder | OpisAnalityczny | Opis analityczny | 10000 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| IconNameLookup | General | Ogólne | 100 | Soneta.Business.dll | Soneta.Business |
| IdentyfikacjaPlatnikowOgolne | IdentyfikacjaPlatnikowOgolne | Ewidencje ŚP/Identyfikacja płatników/Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| IdentyfikacjaPlatnikowPodmioty | IdentyfikacjaPlatnikowPodmioty | Ewidencje ŚP/Identyfikacja płatników/Podmioty | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ImportBankowNBPWorkerParams | Params | Import banków | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| ImportBasicDocumentParam | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| ImportDataExtender | General | Import | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ImportDataModelsFromXmlParams | Params | Parametry | 100 | Soneta.BI.UI.dll | Soneta.BI |
| ImportKursowWalutParams | ContextQuery | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ImportKursowWalutParams | ContextQuery | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ImportMultiXmlWorker | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ImportPUE | ImportPUE | Kadry i płace/Kalendarze/Import z PUE | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ImportPUE | ImportPUE | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ImportPUE-Params | PUEImport | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ImportPodpisanychEDeklaracjiWorkerParam | Ogolne | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ImportRCP | ImportRCP | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ImportRCP-Params | RCPImport | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ImportServerDataModel-Params | Ogolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| ImportServerDataModelsParams | Params |  | 100 | Soneta.BI.UI.dll | Soneta.BI |
| ImportTableData | TSV | Dane | 100 | Soneta.Net.Business.dll | Soneta.Net |
| ImportWyciagowBankowych | ImportWyciagowBankowych | Ewidencje ŚP/Bankowość elektroniczna/Import wyciągów bankowych | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ImportWyciagowBankowychParams | Params | Ogólne | 100 | Soneta.EI.UI.dll | Soneta.EI |
| ImportWyciagowBankowychReps | Ogolne | Raporty | 100 | Soneta.EI.UI.dll | Soneta.EI |
| IndicatorDefinition | IndicatorDefinitionOgolne | Właściwości modelu | 1 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorDefinition | IndicatorDefinitionStructure | Struktura modelu | 2 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorDefinition | IndicatorDefinitionCondition | Ogólne/Elementy modelu/Warunek | 3 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorDefinition | IndicatorDefinitionExtendCondition | Ogólne/Elementy modelu/Dodatkowy warunek | 4 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorDefinition | IndicatorDefinitionParams | Ogólne/Elementy modelu/Parametry | 5 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorDefinition | IndicatorDefinitionExtendParams | Ogólne/Elementy modelu/Dodatkowe parametry | 6 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorDefinition | IndicatorDefinitionRelationship | Relacje | 7 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorDefinition | IndicatorDefinitionVisualizations | Wizualizacje | 8 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorDefinitionAddField | StructureAddField | Dodaj pole | 10 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorDefinitionSourceDomain | SourceDomain | Domeny źródłowe | 100 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorHistory | IndicatorHistory | Ogólne | 100 | Soneta.Net.Business.dll | Soneta.Net |
| IndicatorItemDefinition | IndicatorItemDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorItemDefinition | IndicatorItemDefinitionAppearances | Przedziały danych | 10 | Soneta.BI.UI.dll | Soneta.BI |
| IndicatorItemDefinition | IndicatorItemDefinitionAppearancesPreview | Podgląd przedziałów danych | 20 | Soneta.BI.UI.dll | Soneta.BI |
| InfoPozycjiWorker | InfoPozycjiPozycje | Pozycje | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| InfoPozycjiWorker | InfoPozycjiMarza | Marża | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| InfoPozycjiWorker | InfoPozycjiZasoby | Zasoby | 101 | Soneta.Handel.UI.dll | Soneta.Handel |
| InfoPozycjiWorker | InfoPozycjiZamowienia | Zamówienia | 110 | Soneta.Handel.UI.dll | Soneta.Handel |
| InfoPozycjiWorker | InfoPozycjiOferty | Oferty | 111 | Soneta.Handel.UI.dll | Soneta.Handel |
| InformacjeDoRozliczeniaHistoria | RowHistory | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| InformacjeDoRozliczeniaHistoria | InformacjeDoRozliczeniaHistoria | Historia zapisów | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| InstancjaRow | InstancjaRow | Zalogowany operator | 100 | Soneta.Business.Licence.dll | Soneta.Business |
| InstytucjaFinansowaPPK | Ogolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| InstytucjaFinansowaPPK | KontrahentDodatkowe | Warunki płatności | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| InstytucjaFinansowaPPK | Konta | Konta rozrachunkowe | 3 | Soneta.CRM.UI.dll | Soneta.CRM |
| Insurance | General | Ogólne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| Insurance | Damages | Zgłoszone szkody | 20 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| Insurance | Attachements | Załączniki | 100 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| Integrations | Integrations | Systemowe/Integracje | 100 | Soneta.Business.UI.dll | Soneta.Business |
| IntegratorDefinicje | IntegratorDefinicje | Systemowe/Integrator/Definicje komunikatów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| IntegratorFiltry | IntegratorFiltry | Systemowe/Integrator/Filtry | 100 | Soneta.Core.UI.dll | Soneta.Core |
| IntegratorSysZewnImpDef | IntegratorSysZewnImpDef | Systemowe/Integrator/Pobieranie danych | 100 | Soneta.Core.UI.dll | Soneta.Core |
| IntegratorZadaniaSynch | IntegratorZadaniaSynch | Systemowe/Integrator/Zadania synchronizacji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Intrastat | Intrastat | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Intrastat | IntrastatOdbiorca | Zobowiązany i zgłaszający | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Intrastat | IntrastatPozycje | Pozycje | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Intrastat | IntrastatDokumenty | Dokumenty | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Intrastat | IntrastatXML | XML | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IntrastatTowar | IntrastatTowarEdycjaPozycji | Pozycja Intrastat | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IntrastatTowar | IntrastatTowarEdycjaPozycjiUproszczona | Pozycja Intrastat | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IntrastatTowar | IntrastatTowarPozycjeDokumentow | Pozycje dokumentów | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| IntrastatXmlExportParams | Ogolne |  | 100 | Soneta.Deklaracje.dll | Soneta.Deklaracje |
| Inwentaryzacja | InwentaryzacjaOgolne | Ogólne (Inwentaryzacja) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Inwentaryzacja | InwentaryzacjaCzastkowa | Inwentaryzacje cząstkowe | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| InwentaryzacjaCzastkowa | InwentaryzacjaCzastkowaOgolne | Ogólne (Inwentaryzacja cząstkowa) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| IsoProcedura | IsoProcedura | Procedura ISO | 100 | Soneta.Core.UI.dll | Soneta.Core |
| IsoProcedury | IsoProcedury | Ogólne/Procedury ISO | 100 | Soneta.Core.UI.dll | Soneta.Core |
| IŹródłoOceny | PowiazaneAnkiety | Powiązane ankiety | 90 | Soneta.CRM.UI.dll | Soneta.CRM |
| IŹródłoOceny | PowiazaneOceny | Powiązane oceny | 90 | Soneta.Core.UI.dll | Soneta.Core |
| IŹródłoPowiązaniaStrukturyOrganizacyjnej | ElementyStruktury | Struktura organizacyjna | 1000 | Soneta.Core.UI.dll | Soneta.Core |
| JPK | JPK | Ogólne/Jednolity plik kontrolny | 100 | Soneta.Core.UI.dll | Soneta.Core |
| JPKDaneAutoryzujace | Params | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| JPKResult | Ogolne | Ogólne | 20 | Soneta.EI.UI.dll | Soneta.EI |
| JPKV7MDictionary | JPKV7MDictionary | Ewidencja VAT/Procedury VAT | 100 | Soneta.Core.UI.dll | Soneta.Core |
| JednolityPK | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| JednolityPK | Plik | Plik | 30 | Soneta.Core.UI.dll | Soneta.Core |
| JednolityPK | UPO | UPO (Status) | 50 | Soneta.Core.UI.dll | Soneta.Core |
| JednolityPK | DbgAuthInfo | Techniczne/Autoryzacja | 90 | Soneta.Core.UI.dll | Soneta.Core |
| JednolityPK | DbgMetadata | Techniczne/Metadata | 100 | Soneta.Core.UI.dll | Soneta.Core |
| JednolityPK | DbgUploadInfo | Techniczne/InitUpload | 110 | Soneta.Core.UI.dll | Soneta.Core |
| JednolityPK | DbgUploadResponse | Techniczne/InitResponse | 120 | Soneta.Core.UI.dll | Soneta.Core |
| JednolityPK | Wewnetrzne | Wewnętrzne | 1000 | Soneta.Core.UI.dll | Soneta.Core |
| Jednostka | Jednostka | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| JednostkaSprawozdaniaKS | Ogolne | Ogólne | 15 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| JednostkaSprawozdaniaKS | Objasnienia | Objaśnienia | 50 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| JobInvokeLog | JobInvokeLogGeneral | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| JobInvokeLog | JobInvokeLogDetails | Pozycje | 101 | Soneta.Core.UI.dll | Soneta.Core |
| JobInvokeLog | JobInvokeLogInfo | Uwagi | 101 | Soneta.Core.UI.dll | Soneta.Core |
| JobInvokeLogDetail | JobInvokeLogDetailGeneral | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KDokDodatkowego | KDokDodatkowego | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| KDokDodatkowych | KDokDodatkowych | Systemowe/Kategorie dokumentów dodatkowych | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KEDU | KEDU | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| KHEksport-Params | KHEksportForm | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KPiR | KPiR | KPiR/Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KSeFAwaria | Ogolne | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFAwaria | Komunikaty | Komunikaty | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFAwaria | Dokumenty | Dokumenty | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFIdentWewn | Autoryzacje | Autoryzacje | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFIdentWewn | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFPackage | Ogolne | Dokumenty do wysyłki | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFPackageElem | Ogolne | Element paczki wysyłki do KSeF | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFPartList | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFPlik | Podglad | Podgląd | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFPlik | Xml | XML | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFPodmiot3 | KSeFPodmiot3 | Podmiot trzeci KSeF | 100 | Soneta.Handel.UI.dll | Soneta.KlientBiuraRachunkowego |
| KSeFPodmiot3 | KSeFPodmiot3 | Podmiot trzeci KSeF | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFSzablonPolOpcjonalnych | Ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFSzablonPolOpcjonalnych | PolaPodstawowe | Pola podstawowe | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFSzablonPolOpcjonalnych | PolaDodatkowe | Pola dodatkowe | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFSzablonPolOpcjonalnych | Kontrahenci | Kontrahenci | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFSzablonPolOpcjonalnych | Przyklady | Przykłady | 50 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFSzablonPolOpcjonalnychPozycja | Algorytm | Algorytm | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFSzablonPolOpcjonalnychPozycjaPolePodstawoweProxy | Algorytm |  | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFSzablonZalacznika | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonZalacznika | Konfiguracja | Konfiguracja | 20 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonZalacznika | Instrukcja | Instrukcja | 30 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonZalacznika | Przyklady | Przykłady | 40 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonZalacznikaElement | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonZalacznikaElement | DaneTabeli | Dane tabeli | 20 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonZalacznikaElement | KluczMetaDanych | Klucz | 20 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonZalacznikaElement | NaglowekKolumny | Nagłówek kolumny | 20 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonZalacznikaElement | WartoscKluczaMetaDanych | Wartość | 30 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonZalacznikaElement | WartoscWiersza | Wartość | 30 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonZalacznikaElement | PodsumowanieKolumny | Podsumowanie kolumny | 40 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzablonyZalacznika | KSeFSzablonyZalacznika | Ogólne/KSeF/Szablony załącznika | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFSzblPolOp | KSeFSzblPolOp | Ogólne/KSeF/Szablony pól opcjonalnych | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFUPO | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFUPO | Xml | XML | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFUstawAkceptacjeKlientaWorkerParams | Params | Akceptuj do księgowania | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFWybierzKontekstUwierzytelnianiaParams | KSeFWybierzKontekstUwierzytelnianiaParams |  | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFWyslijParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KSeFZapytanieOFa | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFZapytanieOFa | PakietyDanych | Pakiety danych | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KSeFZapytanieOFa | PlikiKSeF | Pliki KSeF | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KadryCovid | KadryCovid | Kadry i płace/Kadry/COVID-19 | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KadryNET | KadryNET | Pulpity/Pulpit HR | 20 | Soneta.Core.UI.dll | Soneta.Core |
| KadryOgolne | KadryOgolne | Kadry i płace/Kadry/Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KadryWeryfikatory | KadryWeryfikatory | Kadry i płace/Kadry/Weryfikatory | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KadryWydruki | KadryWydruki | Kadry i płace/Kadry/Wydruki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KadryZestawienieCzasuPracy | Ogolne | Zestawienie czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Kalendarz | Kalendarz | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Kalendarz | KalendarzNocne | Dodatkowe | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Kalendarz | KalendarzDni | Kalendarz | 21 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Kalendarz | KalendarzHistoryczne | Dane historyczne | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Kalendarz | KalendarzAlgorytm | Algorytm | 101 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Kalendarz | Weryfikatory | Weryfikatory | 150 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KalendarzZasobowFolder | General | Kalendarz zasobów | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KalkulatorWynagrodzenParams | Net | Kalkulator wynagrodzeń | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KalkulatorWynagrodzenParams | KalkulatorWynagrodzenParams | Kalkulator wynagrodzeń | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Kampania | KampaniaUzytkownika | {New KampaniaUzytkownikaExtender.NazwaZakladki} | 1 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Kampania | KampaniaOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Kampania | KampaniaProjekty | Projekty | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KanalZgloszeniaSygnalisty | KanalZgloszeniaSygnalisty | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Kanban | Kanban | CRM/Ogólne/Kanban | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KanbanDiagram | General | KanbanDiagram | 100 | Soneta.Business.UI.dll | Soneta.Business |
| KanbanProjektowy | KanbanProjektowy | Projekty i Budżetowanie/Kanban | 107 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KanbanTicketsView | General | Tablica kanban | 100 | Soneta.Support.UI.dll | Soneta.Support |
| KanbanZadaniaProjektoweView | General | Tablica kanban | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KanbanZadaniaView | General | Tablica kanban | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Kara | Kara | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KartaKompetencjiPracownika | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KartaKompetencjiPracownika | Spider | Prezentacja | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KartaKompetencjiPracownika | Kompetencje | Kompetencje | 11 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KartaOpisuStanowiskaBase | Ogolne2 | Ogólne | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KartaOpisuStanowiskaBase | Ogolne | Poziom kompetencji | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KartaOpisuStanowiskaBase | Opis | Opis | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KartaOpisuStanowiskaBase | Spider | Prezentacja | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KartaPłatnicza | KartaPlatnicza | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KartaRCP | KartaRCP | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KartaRealizacjiCelu | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KartaRealizacjiCelu | Spider | Prezentacja | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Kasa | Kasa | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KatElementowOcen | KatElementowOcen | CRM/Oceny/Kategorie elementów ocen | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| KatElementowOcenHR | KatElementowOcenHR | Kadry i płace/Oceny/Kategorie elementów ocen | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KategoriaCzynnikowSzkodliwych | KategoriaCzynnikowSzkodliwych | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KategoriaElementuOceny | Ogólne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| KategoriaElementuOpisuStanowiska | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KategoriaGrupyStanowisk | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KategoriaPracownika | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KategoriaST | KategoriaOgolne | Ogólne | 99 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KategoriaSzkolenia | KategoriaSzkolenia | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KategoriaUprawnienia | KategoriaUprawnienia | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KategoriaZapotrzebowania | KategoriaOgolne | Ogólne | 99 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KategoriaZgloszeniaSygnalisty | KategoriaZgloszeniaSygnalisty | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KategorieAkt | KategorieAkt | CRM/Ogólne/Kategorie aktywności | 9 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KategorieDanychOsobowych | KategorieDanychOsobowych | Ogólne/Ochrona danych osobowych/Kategorie danych osobowych | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KategorieElementowOpisuStanowiska | KategorieElementowOpisuStanowiska | Kadry i płace/ZZL/Kategorie elementów opisu stanowiska | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KategorieOdbiorcow | KategorieOdbiorcow | Ogólne/Ochrona danych osobowych/Kategorie odbiorców | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KategorieOsob | KategorieOsob | Ogólne/Ochrona danych osobowych/Kategorie osób | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KategoriePracownikow | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KeduEksport-Params | KeduEksportForm | Ogólne | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| KierownikCzasPracy | Ogolne | Czas pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KierownikCzasPracy2 | Ogolne | Czas pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KierownikNetDostepnosc | Ogolne | Dostępność | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KierownikObiektyCzasPracy | Ogolne | Czas pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KierownikObiektyPlanPracy | Ogolne | Planowanie | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KierownikPlanPracy | Ogolne | Norma czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KierownikPlanPracy2 | Ogolne | Norma czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KierunekKsztalceniaSzkolySrednie | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KierunekKsztalceniaSzkolyWyzsze | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KierunekKsztalceniaSzkolyZawodowe | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Kluby | Kluby | Członkowie/Kluby | 140 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| KodBDO | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| KodCN | Ogolne | Ogólne | 0 | Soneta.Handel.UI.dll | Soneta.Towary |
| KodCPV | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| KodSUP | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| KodWykonywanegoZawodu | KodWykonywanegoZawodu | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KolorElementu | KolorElementu | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KolumnaZestKS | KolumnaZestawieniaKSOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KolumnaZestKS | Protections | Dodatkowe | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Kompensata | Kompensata | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KompensataDefDok | Rozszerzenie | Rozszerzenie | 101 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KompensataPozycja | KompensataPozycja | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KompensujRozliczBase | KompensujRozliczBase | Wybierz | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KompetencjaKartyOpisuStanowiska | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KompetencjaPracownika | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KonsolaProdukcyjna | Ogolne | Konsola produkcyjna | 100 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| KontaPocztowe | KontaPocztowe | CRM/Poczta/Konta pocztowe | 8 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktOsoba | KontaktOsobaOgolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktOsoba | KontaktOsobaRozszerzony | Ogólne | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KontaktOsoba | MobileKontakt | Dane kontaktowe | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktOsoba | WizytowkaFirmyOgolne | Wizytówka | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktOsoba | KontaktOsobaZadania | Aktywności | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KontaktOsoba | KontaktOsobaProjekty | Projekty | 12 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KontaktOsoba | KontaktOsobaUwagi | Uwagi | 40 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktOsoba | BasicDocs | DMS/Dokumenty podstawowe | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| KontaktOsoba | KontaktOsobaWeb | Dostęp WWW | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KontaktOsoba | KontaktOsobaKontrahenci | CRM/Kontrahenci powiązani | 1000 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktOsoba | Leady | CRM/Leady | 1000 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktOsoba | Transakcje | CRM/Transakcje | 1001 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktOsoba | WazneDaty | CRM/Ważne daty | 1003 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktOsoba | KontaktOsobaGIODOOswiadczenia | Ochrona danych osobowych/Oświadczenia | 200000 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktOsoba | KontaktOsobaGIODOWymianaDanych | Ochrona danych osobowych/Wymiana danych | 200001 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontaktWazneDaty | Ogolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontoBase | KontoOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KontoBase | KontoDefinicjeAnalityk | Definicja analityki | 1000 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KontoBase-BudzetKontaWorker | BudzetKontaOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KontoPocztowe | KontoPocztowe | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontoPocztowe | KontoPocztowe | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontoPocztowe | KontoPocztowe | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontoPocztowe | KontoPocztoweZaawansowane | Zaawansowane | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontoPocztowe | KontoPocztoweKalkulatorCode | Kod kalkulatora | 40 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | Kontrahent | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | KontrahentRozszerzony | Ogólne | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Kontrahent | PulpitKBR | Ogólne | 0 | Soneta.EI.UI.dll | Soneta.EI |
| Kontrahent | MobileKontakt | Dane kontaktowe | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | KontrahentDodatkowe | Warunki płatności | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | KontrahentDodatkoweKBN | Warunki płatności | 10 | Soneta.Handel.UI.dll | Soneta.KlientBiuraRachunkowego |
| Kontrahent | KontrahentPlatnosciOddzialowe | Warunki płatności-oddziały | 11 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | KontrahentAdresy | Adres do korespondencji | 20 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | KontrahentGus | GUS | 50 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | KontrahentKategorie | Kategorie i branże | 50 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | KontrahentKodyKreskowe | Kody kreskowe | 50 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | EventPlanned | Nieruchomości/Zdarzenia/Planowane | 151 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | EventIncidental | Nieruchomości/Zdarzenia/Incydentalne | 152 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | EventMeasurements | Nieruchomości/Zdarzenia/Pomiary | 153 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | EventRent | Nieruchomości/Zdarzenia/Najem | 154 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | Objects | Nieruchomości/Obiekty | 155 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | EventPolicy | Nieruchomości/Polisy | 156 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | EventDamages | Nieruchomości/Szkody | 157 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | KontrahentCennik | Handel/Cennik indywidualny | 200 | Soneta.Handel.UI.dll | Soneta.Towary |
| Kontrahent | KontrahentCenyGrupowe | Handel/Ceny grupowe | 200 | Soneta.Handel.UI.dll | Soneta.Towary |
| Kontrahent | KontrahentPrzeceny | Handel/Przeceny indywidualne | 201 | Soneta.Handel.UI.dll | Soneta.Towary |
| Kontrahent | KontrahentRabatCena | Handel/Rabat i cena | 201 | Soneta.Handel.UI.dll | Soneta.Towary |
| Kontrahent | KontrahentRabaty | Handel/Rabaty indywidualne | 201 | Soneta.Handel.UI.dll | Soneta.Towary |
| Kontrahent | KontrahentRabatyGrupowe | Handel/Rabaty grupowe | 201 | Soneta.Handel.UI.dll | Soneta.Towary |
| Kontrahent | KontrahentDokumenty | Handel/Dokumenty | 202 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| Kontrahent | KontrahentOpakowaniaBilans | Handel/Opakowania/Bilans | 202 | Soneta.Handel.UI.dll | Soneta.Towary |
| Kontrahent | KontrahentMarza | Handel/Marża | 203 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| Kontrahent | KontrahentZasoby | Handel/Zasoby | 204 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| Kontrahent | Handel | KSeF/Handel | 205 | Soneta.Handel.UI.dll | Soneta.Handel |
| Kontrahent | KontrahentUmowy | Handel/Umowy | 205 | Soneta.Handel.UI.dll | Soneta.Handel |
| Kontrahent | KontrahentKomunikatyEDI | Handel/EDI | 240 | Soneta.Handel.UI.dll | Soneta.Handel |
| Kontrahent | KontrahentOpakowania | Handel/Opakowania/Obroty | 240 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| Kontrahent | KontrahentOpakowaniaUstawienia | Handel/Opakowania/Ustawienia | 241 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| Kontrahent | KontrahentOpiekunowie | CRM/Opiekunowie | 999 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | Leady | CRM/Leady | 1000 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | StatusyVat | Historia statusu VAT | 1000 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | WiadomosciPowiazaneKontrahenta | {New WiadomosciPowiazaneKontrahentaExtender.CaptionHtml} | 1000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Kontrahent | Transakcje | CRM/Transakcje | 1001 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | KontrahentGIODOOswiadczenia | Ochrona danych osobowych/Oświadczenia | 200000 | Soneta.CRM.UI.dll | Soneta.CRM |
| Kontrahent | KontrahentGIODOWymianaDanych | Ochrona danych osobowych/Wymiana danych | 200001 | Soneta.CRM.UI.dll | Soneta.CRM |
| KontrahentDane | Kontakt | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| KontrahentDane | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| KontrahentKomunikatEDI | Ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| Konwersacja | General | General | 10 | Soneta.Core.UI.dll | Soneta.Core |
| KonwersacjeExplorer | General | General | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KonwersacjeWeb | General | General | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KopierSchematowKsiegowychWieleBaz-Params | Params | Parametry | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KopierUstawienCertyfikatowWieleBazParams | Params | Parametry | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KopiowanieDzieleniePozycjiParams | Params | Parametry | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KopiowaniePlanuKontWorker-KopiowaniePlanuKontParams | KopiowaniePlanuKontParams | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KopiujDokumentParams | KBN |  | 100 | Soneta.Handel.UI.dll | Soneta.KlientBiuraRachunkowego |
| KorektaPodatkowMiesiecznie | KorektaPodatkowMiesieczniePodatki | Podatki | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KorektaPodatkowMiesiecznie | KorektaPodatkowMiesieczniePPK | PPK | 4 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KorektaPodatkowMiesiecznie | KorektaPodatkowMiesiecznieSkladkiTyub | {Caption} | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KorektaSkladekPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| KorektaZajeciaKomorniczego-RozliczenieDepozytu | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KorektaZajeciaKomorniczego-UznanieNadpłaty | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KorektaZajeciaKomorniczego-ZwrotNadpłaty | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KorespPrzygotujWiadomosciWorker-Params | KorespPrzygotujWiadomosciParam | Parametry | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KorespUstawStanZdarzenWorker-Params | Ogolne | Ogólne | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KorespWyslijMailaWorker-Params | KorespWyslijMailaParam | Potwierdzenie | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Korespondencja | KorespondencjaOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Korespondencja | KorespondencjaTresc | Treść | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Korespondencja | KorespondencjaZdarzenia | Zdarzenia | 30 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Korespondencja | WiadomosciPowiazaneKorespondencji | CRM/Wiadomości email | 2000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| KosztAutorski | KosztAutorski | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KosztDelegacji | KosztDelegacji | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KosztEP | KosztEPOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KosztRMK | KosztRMKOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KosztRMK | KosztRMKObroty | Obroty | 5 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KosztRMK | KosztRMKPlan | Plan RMK | 199 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KosztRMK | KosztRMKPodzielniki | Podzielniki kosztów | 199 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KosztTechn | KosztTechnOgolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| KosztWytworzenia-KosztWytworzeniaTechnologiiWorker | Zlecenie | Koszt wytworzenia | 100 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Koszyk-ManyQuantitiesParams | Ogolne |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KrajTbl | KrajTbl | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| KrajeTbl | KrajeTbl | Ogólne/Definicje krajów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KreatorDokumentuStrona | KreatorDokumentuStronaPodsumowanie | Podsumowanie | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KryteriumAnalityczne | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KryteriumSyntetyczne | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KsefEksportIWyslijParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KsefEksportParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KsefHandel | KsefHandel | Ogólne/KSeF/Handel | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KsefIdentyfikatoryWewn | KsefIdentyfikatoryWewn | Ogólne/KSeF/Moje identyfikatory wewnętrzne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KsefIdentyfikatoryWewnKontrahentow | KsefIdentyfikatoryWewnKontrahentow | Ogólne/KSeF/Identyfikatory wewnętrzne kontrahentów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KsefImportFromDbDocEwidencjaListParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KsefImportFromDbDocListParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KsefImportFromDbEwidencjaDocPkgItemParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KsefImportFromDbEwidencjaParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KsefImportFromDbHandelDocPkgItemParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KsefImportFromDbHandelParams | ParamsForm |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| KsefKsefInicjujZapytanieOFakturyAsyncWorkerParams | KsefKsefInicjujZapytanieOFakturyAsyncWorkerParams |  | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KsefOgolne | KsefOgolne | Ogólne/KSeF/Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KsefPliki | KsefPliki | Ogólne/KSeF/Pobieranie i pliki KSeF | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KsefWorkflow | KsefWorkflow | Ogólne/KSeF/Workflow | 100 | Soneta.Core.UI.dll | Soneta.Core |
| KsiegowoscBudzetowa | KsiegowoscBudzetowa | Ewidencje ŚP/Księgowość budżetowa | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KsiegowoscOgolne | KsiegowoscOgolne | Księgowość/Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KsiegujZbiorczoWorker-Params | Ogolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| KursWaluty | KursWalutyNotowania | Ogólne | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KursyWalutWorker | Notowania | Notowania | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KursyWalutWorker | HistoriaKursu | Historia kursu | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KursyWalutWorker | KalkulatorWalutowy | Kalkulator walutowy | 30 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| KwalifikacjePracownikaZkl | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| KwotaBudzProj | KwotaBudzProjektuOglolne | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| LT | LTOgolne | Ogólne (LT) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Lead | LeadUzytkownika | {New LeadUzytkownikaExtender.NazwaZakladki} | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| Lead | LeadBasic | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| Lead | LeadOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| Lead | LeadOpisHtml | Opis | 12 | Soneta.CRM.UI.dll | Soneta.CRM |
| Lead | LeadZadania | Aktywności | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Lead | LeadTransakcje | Transakcje | 30 | Soneta.CRM.UI.dll | Soneta.CRM |
| Lead | WiadomosciPowiazaneLead | {New WiadomosciPowiazaneLeadExtender.CaptionHtml} | 1000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| LeadyUtworzTransakcjeParams | LeadyUtworzTransakcjeParamsPage | Ogólne | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| LekcjaSzkol | ZajecieLekcjaOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| LekcjaSzkol | ZajecieLekcjaWykladowcy | Wykładowcy | 20 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| LekcjaSzkol | ZajecieWizytacjaWykladowcy | Wizytatorzy | 21 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| LekcjaSzkol | ZajecieLekcjaSale | Sale | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| LicencjaBRProxy | LicencjaEnova | Licencja | 10 | Soneta.Business.Licence.dll | Soneta.Business |
| LicencjaDemoProxy | LicencjaEnova | Licencja | 10 | Soneta.Business.Licence.dll | Soneta.Business |
| LicencjaRow | LicencjaProgramu | Licencja | 10 | Soneta.Business.Licence.dll | Soneta.Business |
| LicencjeDodatkow | LicencjeDodatkow | Ogólne | 1 | Soneta.Business.Licence.dll | Soneta.Business |
| LicencjeProgramu | LicencjeProgramu | Ogólne | 1 | Soneta.Business.Licence.dll | Soneta.Business |
| LimitKredytowy | LimitKredytowy | Handel/Limit kredytowy | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| LimitNieobecnosci | LimitNieobecnosci | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| LimitNieobecnosciStd | Net | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| LimitUrlopuWypoczynkowego | Net | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| LimitUrlopuWypoczynkowego | LimitUrlopuWypoczynkowego | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| LimityWartosci-EdycjaWorker | LimityIOSS | IOSS | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| LimityWartosci-EdycjaWorker | LimityOdwrotnegoObciazenia | Odwrotne obciążenie | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| LimityWartosci-EdycjaWorker | LimityWartosci | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| ListItemDefinition | ListItemDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| ListItemResult | ListItemResultOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| ListaPlac | ListaPlac | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ListaPlac | ListaPlacISO | Procedura ISO | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ListaPlac | ListaPlacWyplaty | Wypłaty | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ListaPlac | ListaPlacElementy | Elementy | 3 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ListaPlac | ListaPlacPodatki | Podatki | 4 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ListaPlac | ListaPlacSkladki | Składki | 6 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ListaPlac | ListaPlacKUP | Pozostałe | 7 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ListaPlac | ListaPlacPPK | PPK | 7 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ListaPlac | PracownikZaGranica | Pracownik za granicą | 8 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ListaPlacEwidencja | ListaPlacEwidencja | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| LoadDirectoryParams | General | Wczytaj rozwiązanie z katalogu | 100 | Soneta.Business.UI.dll | Soneta.Business |
| LogCache | SystemRoles | Systemowe/Uprawnienia/Role systemowe | 100 | Soneta.Business.UI.dll | Soneta.Business |
| LogFolder | General | Log | 100 | Soneta.Business.UI.dll | Soneta.Business |
| LoginListenerTestDataSource | General | Po zalogowaniu | 200 | Soneta.Net.Test.dll | Soneta.Net |
| Lokalizacja | LokalizacjaOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| Lokalizacja | LokalizacjaUrzadzenia | Urządzenia | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Lokalizacja | LokalizacjaZadania | Zadania | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Lokalizacja | LokalizacjaDokumentyHandlowe | Dokumenty handlowe | 202 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| LokalizacjaInDBWorkerParams | Params | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| LokalizacjaNierHistoria | Ogolne | Ogólne | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| LokalizacjaNierHistoria | RowHistory | Historia zapisów | 999 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| LokalizacjaPracyZdalnej | Ogolne | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| LukaPlacowa | Ogolne | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| LukaPlacowa | LukaPlacowa | Ogólne/Roczna luka płacowa/Roczna luka płacowa | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| LukaPlacowa | LukaPlacowaWynZmienne | Ogólne/Roczna luka płacowa/Skorygowana-wyn.zmienne | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| LukaPlacowa | LukaPlacowaWynStale | Ogólne/Roczna luka płacowa/Skorygowana-wyn. stałe | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| LukaPlacowa | LukaPlacowaGodz | Ogólne/Godzinowa luka płacowa/Godzinowa luka płacowa | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| LukaPlacowa | LukaPlacowaWynZmienneGodz | Ogólne/Godzinowa luka płacowa/Skorygowana-wyn.zmienne | 7 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| LukaPlacowa | LukaPlacowaWynStaleGodz | Ogólne/Godzinowa luka płacowa/Skorygowana-wyn. stałe | 8 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| LukaPlacowa | ZestawieniePracownikow | Zestawienie pracowników | 9 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| MacierzWartosciowania | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| MacierzWartosciowania | Punkty | Punkty | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| MacierzWartosciowania | Mnozniki | Mnożniki | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Magazyn | MagazynOgolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| Magazyn | DefinicjeDokumentow | Definicje Dokumentów | 20 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| MagazynEwidencja | MagazynEwidencja | Ogólne | 0 | Soneta.Handel.UI.dll | Soneta.Handel |
| MagazynEwidencja | PodmiotPlatnosciEwidencja | Dane kontrahenta i płatności | 4 | Soneta.Handel.UI.dll | Soneta.Handel |
| MailConfigCreator | Step_0_Welcome | Witaj | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| MailConfigCreator | Step_10_AuthProvider | Dostawca autoryzacji | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| MailConfigCreator | Step_20_MailAccount | Konto pocztowe | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| MailConfigCreator | Step_21_ImapConfig | Serwer IMAP | 21 | Soneta.CRM.UI.dll | Soneta.CRM |
| MailConfigCreator | Step_22_AdvancedSettings | Zaawansowane | 22 | Soneta.CRM.UI.dll | Soneta.CRM |
| MailConfigCreator | Step_23_AdvancedSync | Synchronizacja | 23 | Soneta.CRM.UI.dll | Soneta.CRM |
| MailConfigCreator | Step_24_AdvancedCode | Algorytm | 24 | Soneta.CRM.UI.dll | Soneta.CRM |
| MailConfigCreator | Step_25_Rights | Prawa dostępu | 25 | Soneta.CRM.UI.dll | Soneta.CRM |
| MailConfigCreator | Step_30_GlobalSettings | Globalne ustawienia poczty | 30 | Soneta.CRM.UI.dll | Soneta.CRM |
| MailZPotwierdzeniemITresciaParams | Ogolne | Ogólne | 100 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ManRowMetricDefs | ManRowMetricDefs | Ogólne/Definicje zapisów w metryce dokumentu | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ManagedRowMetrics | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| ManagedRowMetricsDefinition | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| ManagerHybridOfficeRequirement | Ogolne | Wymagania obecności | 200 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| ManagerKsiegowan-Rezultat | ManagerKsiegowanRezultatOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ManagerZaliczekWorker | ManagerZaliczek | Zaliczki | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| MasterDBConfig | MasterDBConfig | Systemowe/Praca na wielu bazach/Baza główna | 100 | Soneta.Business.UI.dll | Soneta.Business |
| MatrycaBase | OA | Opis analityczny | 2 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| MatrycaHandlowa | General | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| MatrycaHandlowa | Podmioty | Powiązani kontrahenci | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| MatrycaHandlowa | Algorytm | Algorytm | 50 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| MatrycaHandlowaParams | General | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| MatrycaHandlowaParams | OA | Opis analityczny | 2 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| MatrycaHandlowaWypelnijSprzedazWorker-Params | Params | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| MatrycaHandlowaWypelnijTableWorker-Params | Params | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| MatrycaHandlowaWypelnijZakupWorker-Params | Params | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| MatrycaZaplaty | MatrycaZaplaty | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| MatrycaZaplaty | MatrycaZaplatyAlgorytm | Algorytm | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Matter | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| Matter | Additional | Pozostałe | 2 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| Matter | BasicDocuments | Dokumenty podstawowe | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| MatterDefinition | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| MatterDefinition | MatterState | Status | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| MatterDefs | MatterDefs | DMS/Definicje spraw | 500 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| MediaSettlementCreator | BuildingsList | Budynki | 1 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| MediaSettlementCreator | PremisesList | Lokale | 2 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| MediaSettlementCreator | ServicesList | Usługi | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| MediaSettlementCreator | DocsList | Dokumenty | 20 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| MediaSettlementParams | Params |  | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| MergeDuplicatesCreator | Master | Obiekt docelowy | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| MergeDuplicatesCreator | Options | Parametry | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| MergeDuplicatesCreator | References | Powiązania | 20 | Soneta.CRM.UI.dll | Soneta.CRM |
| MetrykaWydzialu | Ogolne | Metryka | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| MfaCredentials | MfaCredentials | Systemowe/Uprawnienia/Klucze uwierzytelniania 2FA | 100 | Soneta.Business.dll | Soneta.Business |
| MfaOperatorCredentials | Ogolne | Klucze uwierzytelniające | 10 | Soneta.Net.Business.dll | Soneta.Net |
| MiejsceUzytkowania | MiejsceUzytkowaniaOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ModelGroupBy | ModelGroupByOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| ModelJoin | ModelJoinOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| ModelJoin | ModelJoinFeature | Cecha | 2 | Soneta.BI.UI.dll | Soneta.BI |
| ModelJoin | ModelJoinStructure | Struktura | 3 | Soneta.BI.UI.dll | Soneta.BI |
| ModelJoin | ModelJoinOriginStructure | Pochodzenie źródła | 4 | Soneta.BI.UI.dll | Soneta.BI |
| ModelOrderBy | ModelOrderByOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| ModelUrz | ModelUrzOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| MojGrafik | Net | Mój grafik | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| MojZespolGrafik | Net | Grafik zespołu | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| MojeAktualnosciViewInfo | General | Aktualności | 100 | Soneta.Core.UI.dll | Soneta.Core |
| MojeAktywnosciOPZ | General | General | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| MojeParams | MojeParams | Import pliku | 100 | Soneta.Business.UI.dll | Soneta.Business |
| MoveFilesWorker-Params | Params |  | 100 | Soneta.Business.UI.dll | Soneta.Business |
| MoveOrganizationInventoryCreator | RealEstatesList | Przemieszczanie jednostki ogranizacyjnej | 1 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| MoveOrganizationInventoryCreator | Assign | Załączniki | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| MsSqlDatabase | General | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| MsSqlDatabase | Advanced | Zaawansowane | 200 | Soneta.Business.UI.dll | Soneta.Business |
| MultiFolderDashboardWorker | General | Pola | 100 | Soneta.Business.UI.dll | Soneta.Business |
| MultiTileDashboardWorker | General | Pola | 100 | Soneta.Business.UI.dll | Soneta.Business |
| MultipleAuthorizationContextsData | General | Wiele kontekstów autoryzacji | 100 | Soneta.Business.UI.dll | Soneta.Business |
| MultipleContractorParams | Params | Wybór podmiotu | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| MultipleMeasurements | List | Ogólne | 1 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| MunicipalityRegion | Obszary | Obszary | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| NadanieUczestnikowiNumeruPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Nagroda | Nagroda | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Naleznosc | Rozliczenia | Rozliczenia | 2 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczanieCesji | NaliczanieCesji | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczanieKompensat | NaliczanieKompensat | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczanieNotOdsetkowych | NaliczanieNotOdsetkowych | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczanieNotWindykacja | NaliczanieNotWindykacja | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczanieNotWindykacjaParams | NaliczanieNotWindykacjaParams |  | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczaniePlanowanychListPlac | NaliczaniePlanowanychListPlac | Naliczanie planowanych wypłat | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| NaliczaniePotwierdzenSalda | NaliczaniePotwierdzenSalda | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczaniePrzelewowCore | NaliczaniePrzelewow | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczaniePrzelewowCore-Params | Params | Przygotuj przelewy | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczaniePrzelewowCore-PulpitKBRNParams | Params | Przygotuj przelewy | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczaniePrzelewowOkresowychCore | General | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| NaliczanieRozliczenAutomat | NaliczanieRozliczen | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczanieRozliczenKS | NaliczanieRozliczenKSOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| NaliczanieRozliczeń | NaliczanieRozliczen | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczanieSeryjne | NaliczanieDeklaracji | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| NaliczanieSeryjneRIAWorker | DeklaracjeRIA | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| NaliczanieSeryjneRMUAWorker | DeklaracjeRMUA | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| NaliczanieWezwanDoZaplaty | NaliczanieWezwanDoZaplaty | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczanieWezwanWindykacjaParams | NaliczanieWezwanWindykacjaParams |  | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczanieWyplat | NaliczanieWyplat | Naliczanie wypłat | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| NaliczanieWyplat | Nienaliczeni | Błędy naliczania | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| NaliczanieZaplat | NaliczanieZaplat | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NaliczenieDelegacji | NaliczenieDelegacji | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| NaprawaRezerwacjiForm-WParams | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| NetTestDataSource | Reports | Raporty | 200 | Soneta.Net.Test.dll | Soneta.Net |
| NewRowDashboardWorker | General | Pola | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Nieobecnosc | Net | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Nieobecnosc | Nieobecnosc | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Nieobecnosc | NieobecnoscKorekty | Korekty | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Nieobecnosc | NieobecnoscUwagi | Uwagi | 500 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Nieobecnosc | NieobecnoscDeklaracjaZ3 | Deklaracje | 100000 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| NieobecnoscPracownika | NieobecnoscKorektyNet | Korekty | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| NieobecnoscPracownika | NieobecnoscZLA | Informacja z PUE | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| NieruchomoscHis | UserForm | {New RealEstateUserFormExtender.NazwaZakladki} | 1 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Building | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Construction | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Counter | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Installation | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Lot | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Parking | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | ParkingSpot | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Premises | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Room | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Storey | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | ReleatedDevices | Obiekty powiązane | 20 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | ReleatedAssets | Powiązane środki trwałe | 30 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | ReleatedDepartments | Powiązane jednostki organizacyjne | 31 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | WorksitesDepartments | Powiązane jednostki organizacyjne | 31 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | EventRent | Najem | 40 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | EventPlanned | Zdarzenia planowane | 41 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | EventIncidental | Zdarzenia incydentalne | 42 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | EventMeasurements | Pomiary | 43 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | EventPolicy | Polisy | 44 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Damages | Zgłoszone szkody | 45 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | History | Historia zmian | 46 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Documents | Dokumenty | 80 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Services | Usługi | 80 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Settlements | Rozliczenia mediów | 85 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Attachements | Załączniki | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Worksites | Stanowiska pracy | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscHis | Diagram | Diagram | 1001 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscRel | General | Ogólne | 1 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NieruchomoscZdarzenie | General | Ogólne | 11 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| NotaKorygujaca | NotaKorygujaca | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NotaOdsetkowa | NotaOdsetkowa | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NotaOdsetkowaAPIWorker | NotaOdsetkowaAPIWorker | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NotaOdsetkowaEwidencja | PlatnyEwidencja | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| NotaOdsetkowaPozycja | NotaOdsetkowaPozycja | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Notice | General | Wiadomość | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Notice | Preview | Podgląd | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Notice | Receipts | Odbiorcy | 1000 | Soneta.Core.UI.dll | Soneta.Core |
| NoticeChannel | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| NoticeChannel | Permissions | Zgody | 100 | Soneta.Core.UI.dll | Soneta.Core |
| NoticeChannels | NoticeChannels | Ogólne/Komunikaty/Kanały | 100 | Soneta.Core.UI.dll | Soneta.Core |
| NoticeReceipt | Details | Powiadomienie | 1 | Soneta.Core.UI.dll | Soneta.Core |
| NoticeReceipt | General | Adresat | 100 | Soneta.Core.UI.dll | Soneta.Core |
| NoticesDeliveryLogicModel | LoginListener | NoticeReceiving | 100 | Soneta.Core.UI.dll | Soneta.Core |
| NotifiCategories | NotifiCategories | Ogólne/Kategorie powiadomień | 100 | Soneta.Core.UI.dll | Soneta.Core |
| NotificationCategory | Ogolne | Ogólne | 100 | Soneta.Business.dll | Soneta.Business |
| NotificationConfig | general | Powiadomienia | 20 | Soneta.Support.UI.dll | Soneta.Support |
| NotificationConfig | team | Powiadomienia | 100000 | Soneta.Support.UI.dll | Soneta.Support |
| NowaRekrutacjaBase | Ogolne | Rekrutacja | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| NowyDodatek | NowyDodatek | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| NowyPodmiotNadrzednyWorker-NowyPodmiotNadrzedny | Ogolne | Dodaj podmiot nadrzędny | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| NowyPodmiotPodrzednyWorker-NowyPodmiotPodrzedny | Ogolne | Dodaj podmiot podrzędny | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| OAuthTest | General | OAuthTest | 100 | Soneta.Business.UI.dll | Soneta.Business |
| OGSchema | OGSchemaGeneral | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OGSchema | TaskDefs | Definicje zadań | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OGSchema | OGSchemaConstructor | Konstruktor | 10 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OGSchema | OGSchemaMappings | Mapowanie właściwości | 10 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OGSchema | OGSchemaInitTargetRowAlgorithm | Algorytm inicjacji obiektu docelowego | 15 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OGSchemas | OGSchemas | Workflow/Schematy generowania obiektów | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OSW | OSW | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| OT | OTOgolne | Ogólne (OT) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ObfuscateDef | Ogolne | Ogólne | 1 | Soneta.Core.dll | Soneta.Core |
| ObfuscateDef | OgolneSTD | Ogólne | 1 | Soneta.Core.dll | Soneta.Core |
| ObfuscateField | Ogolne | Ogólne | 1 | Soneta.Core.dll | Soneta.Core |
| ObfuscatedData | ObfuscatedData | Ogólne | 1 | Soneta.Core.dll | Soneta.Core |
| ObfuscationWizard | ConfirmationStep | Potwierdzenie kopii bazpieczeństwa | 15 | Soneta.Core.dll | Soneta.Core |
| ObfuscationWizard | InitializationStep | Wybór zakresu | 20 | Soneta.Core.dll | Soneta.Core |
| ObfuscationWizard | FinalizationStep | Potwierdzenie operacji | 30 | Soneta.Core.dll | Soneta.Core |
| ObfuscationWizard-AnonimizationWizard | KeySelectionStep | Wprowadź hasło | 10 | Soneta.Core.dll | Soneta.Core |
| Obrot | Marza | Marża | 100 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| ObrotMW | ObrotMW | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ObrotPON | ObrotPONOgolne | Ogólne | 40 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ObrotRMK | ObrotRMKOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ObrotST | ObrotSTOgolne | Ogólne | 40 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ObrotyKontaWorker | KontoObroty | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ObrotyKontaWorker | KontoObrotyMiesiecznie | Miesięcznie | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ObrotySuma | ObrotySuma | Podsumowanie | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ObslugaMaszynIUrzadzen | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ObszarFunkcjonalny | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ObszarOdpowiedzialnosciPracownikaZkl | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ObszarOdpowiedzialnosciStanowiska | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OcenaArkusz | OcenaArkuszCzęściowe | Arkusze częściowe | 10 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaArkusz | OcenaArkuszOgólne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaArkusz | Spider | Prezentacja | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OcenaArkusz | OcenaArkuszOgólne2 | Arkusz oceny | 11 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaArkusz | OcenaArkuszOgólne2Net | Arkusz oceny | 11 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaArkusz | OcenaArkuszEtapy | Etapy | 50 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaKandydatowWorker | OcenaKandydatow | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OcenaOcenWorker | OcenaOcen | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OcenaOceniajacy | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaOceniany | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaPozycjaArkusza | Ogólne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaPracownika | OcenaPracownika | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OcenaPracownikowWorker | OcenaPracownikow | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OcenaRealizacja | OcenaRealizacjaOgolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaRealizacja | OcenaRealizacjaOceniajacy | Oceniający | 20 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaRealizacja | OcenaRealizacjaOceniani | Oceniani | 20 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaRealizacja | Etapy | Etapy | 50 | Soneta.Core.UI.dll | Soneta.Core |
| OcenaRealizacja | OcenaRealizacjaArkusze | Arkusze ocen | 50 | Soneta.Core.UI.dll | Soneta.Core |
| OchronaDanych | OchronaDanych | Firma/Ochrona danych | 100 | Soneta.Core.dll | Soneta.Core |
| OcrBusMappings | OcrBusMappings | DMS/OCR/Formaty mapowania OCR | 1110 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OcrBusinessMapping | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OcrBusinessMapping | OcrBusinessMappingOutputs | Wyniki mapowania OCR | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OcrBusinessMappingElement | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OcrBusinessMappingElement | IsMatchAlgorithm | Algorytm | 20 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OcrBusinessMappingOutput | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OcrMappingTester | Results | Wyniki testowania mapowania | 100 | Soneta.Core.UI.dll | Soneta.Core |
| OcrMappingWorkerParams | OcrMappingWorkerParams | Parametry mapowania OCR | 100 | Soneta.Core.UI.dll | Soneta.Core |
| OcrResultVerifier | Verifier | Weryfikacja procesu OCR | 100 | Soneta.Core.UI.dll | Soneta.Core |
| OcrSettings | OcrSettings | DMS/OCR/Ogólne | 1100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| OcrWorkerParams | OcrWorkerParams | Parametry OCR | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Odczyt | OdczytOgolne | Ogólne | 1 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Odczyt | OdczytCzlonkowie | Członkowie | 2 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| OdczytCzlonek | OdczytCzlonekOgolne | Ogólne | 1 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Oddzial | Oddzial | Ewidencje ŚP/Oddziały | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| OddzialFirmy | OddzialFirmy | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyAdresy | Adres do korespondencji | 2 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyKontakt | Kontakt | 2 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyCITST | Deklaracje/CIT-8ST | 6 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyDeklaracje | Deklaracje/Ogólne | 6 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyDanePFRON | Deklaracje/Dane PFRON | 7 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyDanePPK | Deklaracje/Dane PPK | 7 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyDodatkowe | Dodatkowe | 7 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyDanePelnomocnikaPFRON | Deklaracje/Dane PFRON - pełnomocnik | 8 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyPodmiotyPowiazane | Podmioty powiązane | 10 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmySzkolenia | Szkolenia | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| OddzialFirmy | OddzialFirmySzkoleniaFakturowanie | Szkolenia - fakturowanie | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| OddzialFirmy | OddzialFirmyCzlonkowie | Członkowie | 11 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| OddzialFirmy | DeklaracjeVAT | Deklaracje/Dane VAT | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| OddzialFirmy | HistoriaPowiazan | Historia/Zmiany oddziału nadrzędnego | 100 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | Lokalizacje | Lokalizacje | 100 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyDeklaracjePIT | Deklaracje/Dane PIT | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| OddzialFirmy | OddzialFirmyESP | Ewidencje Środków Pieniężnych | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| OddzialFirmy | OddzialFirmyHistoria | Historia/Zmiany danych oddziału | 100 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyKsiegowosc | Księgowość | 100 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyMagazyny | Magazyny | 100 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| OddzialFirmy | OddzialFirmyMiejscaUzytkowania | Miejsca użytkowania | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| OddzialFirmy | OddzialFirmyPUE | Import z PUE | 100 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialFirmy | OddzialFirmyPlace | Płace | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OddzialFirmy | OddzialFirmyWydzialy | Jednostki organizacyjne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OddzialFirmy | ProdukcjaZaawansowana | Produkcja zaawansowana | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| OddzialFirmyRef | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| OddzialZUS | Ogolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| OddzialyFirmy | OddzialyFirmy | Firma/Oddziały firmy | 9 | Soneta.Core.UI.dll | Soneta.Core |
| OdpisAktualizujacy | OdpisAktualizujacyOgolne | Ogólne (Odpis aktualizujący) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Odpowiedzialnosc | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OfertaPracy | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OfertaPracy | KartyOpisuStanowiska | Karty opisu stanowiska (ogłoszenia) | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OfertaPracy | PoziomWynagrodzen | Poziom wynagrodzeń | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OfertaSzkolenia | OfertaSzkolenia | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OfertaSzkolenia | OfertaSzkoleniaDodatkowe | Rozliczenie i lokalizacja | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OfficePresence | Ogolne | Ogólne | 200 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| OgSchemaParameters | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| Ogolne | Ogolne | Kontrahenci i urzędy/Ogólne | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| OgolneNET | OgolneNET | Pulpity/Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| OkresDoswiadczeniaZawodowego | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OkresInDBWorkerParams | Params | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| OkresInDBWorkerRow-Params | Params | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| OkresMagazynowy | OkresZasoby | Zasoby | 100 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| OkresMagazynowy | OkresMarza | Marża | 101 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| OkresObrachunkowy | OkresObrachunkowyOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| OkresObrachunkowy | Podokresy | Podokresy | 20 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| OkresWykonywaniaPracyTymczasowej | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OperUstawieniaESP | OperUstawieniaESP | Ewidencje ŚP/Ustawienia operatora | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| OperUstawieniaKadrowe | OperUstawieniaKadrowe | Kadry i płace/Ustawienia operatora | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Operacja | OperacjaOgolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Operacja | OperacjaDokumenty | Dokumenty | 11 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Operacja | OperacjaSurowce | Surowce | 11 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Operacja | OperacjaProdukty | Produkty | 12 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Operacja | OperacjaPlanowanie | Planowanie | 13 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Operacja | OperacjaPolProdukty | Półprodukty | 13 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Operacja | OperacjaKoszty | Koszty | 14 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Operacja | OperacjaZasobyTechnologiczne | Zasoby | 15 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Operacja | OperacjaOsoby | Osoby | 16 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Operacja | OperacjaDodatkowe | Dodatkowe | 17 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Operacja | OperacjaTechnologie | Technologie | 1003 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| OperacjaBankowa | OperacjaBankowa | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| OperacjaBankowa | OperacjaBankowaTekst | Tekst operacji | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Operator | OperatorGeneral | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| Operator | Operator | Operator | 1 | Soneta.Business.UI.dll | Soneta.Business |
| Operator | OperatorSystemowe | Systemowe | 2 | Soneta.Business.UI.dll | Soneta.Business |
| Operator | OperatorWeb | Dostęp WWW | 25 | Soneta.Core.UI.dll | Soneta.Core |
| Operator | OperatorConfig | Wsparcie | 99 | Soneta.Support.UI.dll | Soneta.Support |
| Operator | HandelUstawieniaOperatora | Handel/Ustawienia operatora | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| Operator | HandelUstawieniaOperatora | Handel | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| Operator | OperKontrahentFiltr | Filtrowanie | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Operator | OperUstawieniaCRM | CRM | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Operator | OperUstawieniaESP | Ewidencje ŚP | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Operator | OperUstawieniaEwidDok | Ew. dokumentów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Operator | OperUstawieniaKadrowe | Kadry i płace | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Operator | ProdukcjaZaawansowana | Produkcja zaawansowana | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| Operator | CtiAccount | Konto Cti | 200 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Operator | OperatorDBItems | Bazy danych | 1000 | Soneta.Business.UI.dll | Soneta.Business |
| Operator | UserGroups | Grupy użytkowników | 999999 | Soneta.Business.UI.dll | Soneta.Business |
| OperatorInDBWorker-Params | Ogolne | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| OperatorSprzedazy | General | Ogólne | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| OperatorSprzedazy | OperatorSprzedazy | CRM/Ogólne/Zespół sprzedażowy | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| OperatorToTeam | OperatorToTeam | Pulpity/Pulpit kontrahenta/ServiceDesk/Operatorzy | 110 | Soneta.Support.UI.dll | Soneta.Support |
| OperatorToTeamData | OperatorToTeamData |  | 10 | Soneta.Support.UI.dll | Soneta.Support |
| Operators | Operators | Systemowe/Uprawnienia/Operatorzy | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Opiekun | OpiekunOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| OpisAnalitycznySuma | OpisAnalitycznySuma | Podsumowanie | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| OpisPIM | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| OpisPIM | Relacje | Relacje | 1 | Soneta.Core.UI.dll | Soneta.Core |
| OptimaExportParams | Params | Ogólne | 100 | Soneta.EI.UI.dll | Soneta.EI |
| OptimaImportParams | Params | Ogólne | 100 | Soneta.EI.UI.dll | Soneta.EI |
| OptionPageLookup | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| OracleDatabase | General | Ogólne | 1 | Soneta.Oracle.dll | Soneta.Business |
| OracleDatabase | Advanced | Zaawansowane | 200 | Soneta.Oracle.dll | Soneta.Business |
| OsobaKontrahent | OsobaKontrahentOgolne | Ogólne | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| OsobaKontrahent | OsobaKontrahentZadania | Aktywności | 101 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| OsobaKontrahent | OsobaKontrahentProjekty | Projekty | 102 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| OswiadczeniePracownika | OswiadczeniePracownika | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OswiadczenieZusOpieka | OswiadczenieZusOpieka | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| OtherSubreports | OtherSubreports | Raportowanie/REPX/Podraporty | 504 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| OutlookAuthProvider | Ogolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| PFRONCentrala | PFRONKonta | Konta dla wpłat | 3 | Soneta.CRM.UI.dll | Soneta.CRM |
| PIT11_11 | PIT11_11 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_11 | PIT11_11Dod | Dodatkowe | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_15_Base | PIT11_15 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_15_Base | PIT11_15Dod | Dodatkowe | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_17_Base | PIT11_17 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_17_Base | PIT11_17Dod | Dodatkowe | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_18_Base | PIT11_18 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_18_Base | PIT11_18Dod | Dodatkowe | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_20_Base | PIT11_18 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_20_Base | PIT11_18Dod | Dodatkowe | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_22_Base | PIT11_22 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_22_Base | PIT11_22Dod | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_22_Base | PIT11_22Form1 | E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_22_Base | PIT11_22Form2 | F, G | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_24_Base | PIT11_24 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_24_Base | PIT11_24Dod | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_24_Base | PIT11_24Form1 | E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_24_Base | PIT11_24Form2 | F, G, H, I | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_25 | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_25 | PIT11_25Form1 | E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_25_Base | PIT11_25Dod | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_25_Base | PIT11_25Form2 | F, G, H, I | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_26 | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_26 | PIT11_25Form1 | E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_27 | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_27 | Dod | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_27 | Form1 | E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_27 | Form2 | F, G, H, I | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_28 | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_28 | Dod1 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_28 | Form1 | E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_28 | Form2 | F, G, H, I | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_29 | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_29 | Dod1 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_29 | Form1 | E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT11_29 | Form2 | F, G, H, I | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_11 | PIT40_11 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_11 | PIT40_11Obliczenia | Obliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_11 | PIT40_11Dodatkowe | Dodatkowe | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_12 | PIT40_12 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_12 | PIT40_12Obliczenia | Obliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_12 | PIT40_12Dodatkowe | Dodatkowe | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_13 | PIT40_13 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_13 | PIT40_13Obliczenia | Obliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_13 | PIT40_13Dodatkowe | Dodatkowe | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_14 | PIT40_14 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_14 | PIT40_14Obliczenia | Obliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_14 | PIT40_14Dodatkowe | Dodatkowe | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_15 | PIT40_15 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_15 | PIT40_15Obliczenia | Obliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_15 | PIT40_15Dodatkowe | Dodatkowe | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_16 | PIT40_16 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_16 | PIT40_16Obliczenia | Obliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_16 | PIT40_16Dodatkowe | Dodatkowe | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_17 | PIT40_17 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_17 | PIT40_17Obliczenia | Obliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_17 | PIT40_17Dodatkowe | Dodatkowe | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_19 | PIT40_19 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_19 | PIT40_19Obliczenia | Obliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_19 | PIT40_19Dodatkowe | Dodatkowe | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_20 | PIT40_20 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_20 | PIT40_20Obliczenia | Obliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_20 | PIT40_20Dodatkowe | Dodatkowe | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_21_Base | PIT40_21 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_21_Base | PIT40_21Obliczenia | Obliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_21_Base | PIT40_21Dodatkowe | C, D, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_21_Base | PIT40_21Form1 | F, G | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT40_21_Base | PIT40_21Form2 | H.1, H.2, H.3, I | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_1 | PIT4R_1Obliczenie | Obliczenie należnego podatku | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_10_Base | PIT4R_Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_10_Base | PIT4R_Obliczenie | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_10_Base | PIT4R_Form1 | C (1-7) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_10_Base | PIT4R_Form2 | C (8-13) | 35 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_11 | PIT4R_Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_12 | PIT4R_Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_13 | PIT4R_Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_13 | PIT4R_Obliczenie | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_13 | PIT4R_Form1 | C (1-7) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_13 | PIT4R_Form2 | C (8-12) | 35 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_13 | PIT4R_Form3 | D, E | 35 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_13 | PIT4R_Miesieczna | D, E | 35 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_4 | PIT4R_4Obliczenie | Obliczenie należnego podatku | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_7_Base | PIT4ROgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_7_Base | PIT4R_7Obliczenie | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_7_Base | PIT4R_7Form1 | C (1-5) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_7_Base | PIT4R_7Form2 | C (6-11) | 35 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_8_Base | PIT4ROgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_8_Base | PIT4R_8Obliczenie | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_8_Base | PIT4R_8Form1 | C (1-7) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_8_Base | PIT4R_8Form2 | C (8-13) | 35 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_9_Base | PIT4R_Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_9_Base | PIT4R_Obliczenie | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_9_Base | PIT4R_Form1 | C (1-7) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_9_Base | PIT4R_Form2 | C (8-13) | 35 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_Base | PIT4ROgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_Base | PIT4RObliczenie | Obliczenie należnego podatku | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_Base | PIT4R_5Obliczenie | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_Base | PIT4R_5Form1 | C (1-6) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4R_Base | PIT4R_5Form2 | C (7-13) | 35 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4_14 | PIT4_14 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT4_14_15_Base | PIT4 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5L_1_1_ | Część C, D, F, G.1, G.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5_14_1_ | Część C, D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5L_1_2_ | Część G.3, G.4, G.5 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5_14_10_ | Część E.1 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5L_1_3_ | Część H.1, H.2 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5_14_2_ | Część E.2, E.3, F, G, H | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5L_1_4_ | Część H.3, H.4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5_14_3_ | Część I, J.1, J.2 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5_14_4_ | Część J.3, J.4, J.5 | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5_14_5_ | Część K.1, K.2 | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5_14_6_ | Część K.3, K.4 | 7 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5_14_7_ | Część L.1 | 8 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5_14_8_ | Część L.2 | 9 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5 | PIT5_14_9_ | Część M.1, M.2, N.1, N.2, O | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5L_2022 | 1 | Dochody lub straty i podatek | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5L_2022 | 2 | Zaliczki PIT | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5L_2022 | 3 | Działalności gospodarcze | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5L_2022_2 | 1 | Dochody lub straty i podatek | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5L_2022_2 | 2 | Zaliczki PIT | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5L_2022_2 | 3 | Działalności gospodarcze | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5L_4 | BlokH | Część H | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5L_4 | BlokI | Część I | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_12_13 | PIT5_12_1_ | Część C, D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_12_13 | PIT5_12_9_ | Część E.1 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_12_13 | PIT5_12_2_ | Część E.2, E.3, F, G, H | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_12_13 | PIT5_12_3_ | Część I, J.1, J.2 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_12_13 | PIT5_12_4_ | Część J.3, J.4, J.5 | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_12_13 | PIT5_12_5_ | Część K | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_12_13 | PIT5_12_6_ | Część L.1 | 7 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_12_13 | PIT5_12_7_ | Część L.2 | 8 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_12_13 | PIT5_12_8_ | Część M.1, M.2, N.1, N.2, O | 9 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_16 | K | Część K | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022 | 1 | Dochody lub straty | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022 | 2 | Odliczenia od dochodu i zwolnienia | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022 | 3 | Podatek | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022 | 4 | Zaliczki PIT | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022 | 5 | Działalności gospodarcze | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022 | 6 | Działalności gospodarcze - SSE | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022 | 7 | Działalności gospodarcze - SSE2 | 7 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022 | 8 | Najem | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022_2 | 1 | Dochody lub straty | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022_2 | 2 | Odliczenia od dochodu i zwolnienia | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022_2 | 3 | Podatek | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022_2 | 4 | Zaliczki PIT | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022_2 | 5 | Działalności gospodarcze | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022_2 | 6 | Działalności gospodarcze - SSE | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022_2 | 7 | Działalności gospodarcze - SSE2 | 7 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT5_2022_2 | 8 | Najem | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_10 | PIT8AR_BaseOgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_11 | PIT8AR_BaseOgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_12 | PIT8AR_BaseOgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_12 | PIT8AR_BaseObliczenie2 | C (19-36) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_12 | PIT8AR_BaseForm5 | C (30-36) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_13 | PIT8AR_BaseOgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_13 | PIT8AR_BaseObliczenie1 | C (1-20) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_13 | PIT8AR_BaseObliczenie2 | C (21-38) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_13 | PIT8AR_BaseForm1 | C (1-7) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_13 | PIT8AR_BaseObliczenie3 | D, E, F | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_13 | PIT8AR_BaseForm2 | C (8-17) | 31 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_13 | PIT8AR_BaseForm3 | C (18-24) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_13 | PIT8AR_BaseForm4 | C (25-31) | 33 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_13 | PIT8AR_BaseForm5 | C (32-38) | 34 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_13 | PIT8AR_BaseForm6 | D, E, F | 35 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_14 | PIT8AR_BaseOgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_14 | PIT8AR_BaseObliczenie1 | C (1-20) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_14 | PIT8AR_BaseObliczenie2 | C (21-38) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_14 | PIT8AR_BaseForm1 | C (1-7) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_14 | PIT8AR_BaseObliczenie3 | D, E, F | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_14 | PIT8AR_BaseForm2 | C (8-17) | 31 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_14 | PIT8AR_BaseForm3 | C (18-24) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_14 | PIT8AR_BaseForm4 | C (25-31) | 33 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_14 | PIT8AR_BaseForm5 | C (32-38) | 34 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_14 | PIT8AR_BaseForm6 | D, E, F | 35 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_1Base | PIT8AROgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_1Base | PIT8ARObliczenie | Wykaz należnego podatku | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_2Base | PIT8AR_BaseOgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_2Base | PIT8AR_BaseObliczenie1 | C (1-15) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_2Base | PIT8AR_BaseObliczenie2 | C (16-29) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_2Base | PIT8AR_BaseForm1 | C (1-8) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_2Base | PIT8AR_BaseForm2 | C (9-15) | 31 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_2Base | PIT8AR_BaseForm3 | C (16-22) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_2Base | PIT8AR_BaseForm4 | C (23-29) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_3 | PIT8AR_3Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_3 | PIT8AR_3Obliczenie | Wykaz należnego podatku | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_4 | PIT8AR_4Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_4 | PIT8AR_4Obliczenie | Wykaz należnego podatku | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_8Base | PIT8AR_BaseOgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_8Base | PIT8AR_BaseObliczenie1 | C (1-15) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_8Base | PIT8AR_BaseObliczenie2 | C (16-29) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_8Base | PIT8AR_BaseForm1 | C (1-8) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_8Base | PIT8AR_BaseForm2 | C (9-15) | 31 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_8Base | PIT8AR_BaseForm3 | C (16-22) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_8Base | PIT8AR_BaseForm4 | C (23-29) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_9Base | PIT8AR_BaseOgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_9Base | PIT8AR_BaseObliczenie1 | C (1-18) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_9Base | PIT8AR_BaseObliczenie2 | C (19-36) | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_9Base | PIT8AR_BaseForm1 | C (1-8) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_9Base | PIT8AR_BaseForm2 | C (9-15) | 31 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_9Base | PIT8AR_BaseForm3 | C (16-22) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_9Base | PIT8AR_BaseForm4 | C (23-29) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_9Base | PIT8AR_BaseForm5 | C (30-35) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_Base | PIT8AR_BaseOgolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_Base | PIT8AR_BaseObliczenie | C | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_Base | PIT8AR_BaseForm1 | C (1-7) | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_Base | PIT8AR_BaseForm2 | C (8-12) | 31 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8AR_Base | PIT8AR_BaseForm3 | C (13-17) | 32 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8A_10 | PIT8A_10 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8A_10 | PIT8AZalaczniki | Załączniki | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8A_11_12_Base | PIT8A_11 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8B | PIT11_8B_12 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8B | PIT11_8B_12Dod | Dodatkowe | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8B_10 | PIT8B | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8B_10 | PIT8BDodatkowe | Dodatkowe | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_10_Dod | C, F | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_12_Dod | C, F | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_13_Dod | C, F | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_9_Dod | C, F | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_Dod | C, H, I | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_10_Form | D, E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_11_Form | D, E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_12_Form | D, E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_13_Form | D, E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_9_Form | D, E | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C | PIT8C_Form | D, E, F, G | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C_3 | PIT8C_3_ | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C_3 | PIT8C_3_Dod | Dodatkowe | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C_4 | PIT8C_4_ | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C_4 | PIT8C_4_Dod | Dodatkowe | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C_5 | PIT8C_5_ | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C_5 | PIT8C_5_Dod | Dodatkowe | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C_6 | PIT8C_6_ | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8C_6 | PIT8C_6_Dod | Dodatkowe | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PIT8S | PIT8S | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR | PITR | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR | PITRForm | D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR_11_Base | PITR_11 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR_13_Base | PITR_13 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR_14 | PITR_14 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR_15 | PITR_15 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR_19 | PITR_19 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR_20 | PITR_20 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR_21 | PITR_21 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR_22 | PITR_22 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR_22 | Form_C | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITR_22 | Form_D | D | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt | PITRyczalt | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt | PITRyczalt_1_ | Przychody i odliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt | PITRyczalt_2_ | Podatek i odliczenia | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt | PITRyczalt_3_ | Zaliczka podatku | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt2022 | PITRyczalt | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt2022 | PITRyczalt_1_ | Przychody i odliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt2022 | PITRyczalt_2_ | Podatek i odliczenia | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt2022 | PITRyczalt_3_ | Zaliczka podatku | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt2022_2 | PITRyczalt | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt2022_2 | PITRyczalt_1_ | Przychody i odliczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt2022_2 | PITRyczalt_2_ | Podatek i odliczenia | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PITRyczalt2022_2 | PITRyczalt_3_ | Zaliczka podatku | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PKD | PKD | Kontrahenci i urzędy/PKD i SIC | 1000 | Soneta.CRM.UI.dll | Soneta.CRM |
| PKEwidencja | PKEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PKZPOgolne | PKZPOgolne | Kadry i płace/KZP, ZFM, .../Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PUEDokumentEZLA | PUEDokumentEZLA | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PUEDokumentEZLA | PUEDokumentEZLAZapisDzialan | Zapis działań | 99 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PUEEksport-Params | PUEEksportForm | Ogólne | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PaczkaPrzelewow | Ogolne | Ogólne | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PanelAwarie | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelDokumentacja | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelDostawy | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelFiltrOperacji | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelFunkcje | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelLogowanie | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelMaterialy | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelOdpady | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelRaportowanie | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelRealizacje | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelRejestracja | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelUslugi | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelWyroby | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelZalaczniki | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PanelZasoby | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ParamentryRozliczenVAT | ParamentryRozliczenVAT | Ewidencja VAT/Parametry rozliczeń | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Parameters | General | Zmień parametry zadań | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ParametrRozlicz | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| ParametryWydrukuDokumentu | Ogolne | Parametry wydruku | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| ParametryWydrukuDokumentuZKodamiKreskowymi | Ogolne | Parametry wydruku | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| ParametryZatwierdzeniaAdv | AdvZatwierdzaczPays | Zapłaty | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| ParametryZatwierdzeniaAdv | AdvZatwierdzaczSummary | Płatności i zaliczki | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| ParametryZatwierdzeniaAdv | LogiTerminala | Logi z terminala | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| Params | Ogolne | Logowanie do bazy | 0 | Soneta.Net.Business.dll | Soneta.Net |
| Params | Params | Parametry | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Params | General | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Params | General | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Params | General | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Params | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Params | Params |  | 100 | Soneta.BI.UI.dll | Soneta.BI |
| Params | Params |  | 100 | Soneta.Business.Forms.dll | Soneta.Business |
| Params | Params |  | 100 | Soneta.Business.dll | Soneta.Business |
| Params | Params |  | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Params | Params | Parametry | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| Params | Params | Parametry | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| Params | Params | Parametry | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| Params | Params |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| Params | Params |  | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ParamsO | Params |  | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ParamsW | Params | Parametry | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PasswordAuthProvider | Ogolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| PivotGridSettings | General | Ustawienia tabeli przestawnej | 0 | Soneta.Business.UI.dll | Soneta.Business |
| PivotGridStyleNameParams | Params | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| PivotItemDefinition | PivotItemDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| PivotItemDefinition | PivotItemDefinitionPivotViews | Raporty przestawne | 700 | Soneta.BI.UI.dll | Soneta.BI |
| PivotItemResult | PivotItemResultOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| PivotViews | PivotViews | BI/Prezentacja danych/Raporty przestawne | 1160 | Soneta.BI.UI.dll | Soneta.BI |
| PlaceOgolne | PlaceOgolne | Kadry i płace/Płace/Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PlanSprzedazowy | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PlanSprzedazowy | Options | Opcje | 200 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PlanVariant | DefPlanVersions | Definicje wersji planów | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PlanVariant | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PlanVariantRel | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PlanVersionCopyParams | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PlanVersionImportParams | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PlanVersionSplitParams | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PlanowanaListaPlac | PlanowanaListaPlac | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PlanowanaListaPlacEwidencja | PlanowanaListaPlacEwidencja | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PlanowanaNieobecnosc | Net | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PlanowanaNieobecnosc | PlanowanaNieobecnosc | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PlanowanaWyplata | PlanowanaWyplata | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PlanowanieOperacjiWorker | General | Planowanie | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| PlanowanieZasobowZKL | Ogolne | ZKL/Plan ZKL | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PlanowanyElementWyplaty | PlanowanyElementWyplaty | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PlanowanyPrzeglad | PlanowanyPrzegladOgolne | Ogolne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PlanowanyPrzeglad | PlanowanyPrzegladOgolnePK | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Platnosc | Ogolne | Ogólne | 0 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Platnosc | Platnosc | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Platnosc | Ksiega | Dodatkowe | 1 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Platnosc | PlatnoscKsiega | Dodatkowe | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Platnosc | Rozliczenia | Rozliczenia | 2 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Platnosc | ZleDlugi | Złe długi | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Platnosci | Platnosci | Ewidencja dokumentów/Płatności | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PlatnyDokRozlicz | DokRozliczZobowiazania | Zobowiązania i należności | 2 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PobraneLicencje2 | WybierzModuly | Ogólne | 10 | Soneta.Business.Licence.dll | Soneta.Business |
| PobraneLicencje2 | ZalogowaniOperatorzy | Zalogowani operatorzy | 10 | Soneta.Business.Licence.dll | Soneta.Business |
| PodatekOdNieruchomosci | PONOgolne | Ogólne (Podatek od nieruchomości) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PodepnijOpisWorker | PodepnijOpisWorker | Wybierz | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PodgladZastosowaniaFiltra | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| PodmiotEwidencjaDaneZGusBirWorker-Params | DaneZGusParam | Parametry | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| PodmiotPowiazany | PodmiotPowiazanyOgolne | Ogólne | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| PodmiotTransakcja | PodmiotTransakcjaOgolne | Ogólne | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| PodmiotZadanie | PodmiotZadanieOgolne | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PodokresObrachunkowy | Ogolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PodpisOperatora | PodpisOgolne | Ogólne | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| PodsumowaniePlatnosciWorker | SumujPlatnosci | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PodsumowanieRozrachunkiIdxWorker | SumujRozrachunkiIdx | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PodsumowanieWorker | SumujKasowe | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PodsumowanieWyplat | PodsumowanieWyplat | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieWyplatNet | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieWyplatPodatki | Podatki | 6 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieWyplatPodatkiNet | Podatki | 6 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieWyplatSkladki | Składki | 8 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieWyplatSkladkiNet | Składki | 8 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieWyplatPPK | PPK | 9 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieWyplatPPKNet | PPK | 9 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieWyplatSkladkiTyub | {Caption} | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieWyplatSkladkiTyubNet | {Caption} | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieKUP | Pozostałe | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PodsumowanieKUPNet | Pozostałe | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PodsumowanieWyplat | PracownikZaGranica | Pracownik za granicą | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PokazZapisyPowiazaneWorker | Zapisy | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PolaczInstFinansowePPKWorker-Params | PolaczInstFinansowePPKParams | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| PolaczKontrahentowWorker-Params | PolaczKontrahentowParams | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| Policy | General | Ogólne | 11 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| Policy | Damages | Powiązane szkody | 31 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| PostalCodeRegion | Obszary | Obszary | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| PoswiadczenieOdbioru | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| PotwierdzenieSalda | PotwierdzenieSalda | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PotwierdzenieSaldaPozycja | PotwierdzenieSaldaPozycja | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PowiadomieniaKadryNet | Ogolne | Start | 1001 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PowiazZasobNadrzednyParams | Ogolne |  | 20 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| PowiazaneBazy | PowiazaneBazy | Ogólne | 1 | Soneta.Business.Licence.dll | Soneta.Business |
| PowiazanieStrukturyOrganizacyjnejPowiazWorker-RezultatWorkera | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| PowiązanieStrukturyOrganizacyjnej | PowiazanieStrukturyOrganizacyjnej | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| PozGrupyKont | PozycjaGrupyKontBudzetujacejOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozGrupyKont | PozycjaGrupyKontOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PoziomRozwojuKompetencjiMerytorycznych | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PoziomRozwojuKompetencjiUniwersalnych | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PoziomUmiejetnosci | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PoziomWyksztalcenia | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaAktualizacjiCzasu | PozycjaAktualizacjiCzasu | Czas pracy | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaAktualizacjiCzasuDzienResult | PozycjaAktualizacjiCzasuDzienResult | Dzień | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaAktualizacjiCzasuDzienResult | PozycjaAktualizacjiCzasuDzienResultNet | Dzień | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaAktualizacjiCzasuDzienResult | PoprzednieWersje | Wersje | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaAktualizacjiKalendarza | PozycjaAktualizacjiKalendarzaPlanPracy | Norma czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaAktualizacjiKalendarzaDzienResult | PozycjaAktualizacjiKalendarzaDzienResult | Dzień | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaAktualizacjiKalendarzaDzienResult | PozycjaAktualizacjiKalendarzaDzienResultNet | Dzień | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaAktualizacjiKalendarzaDzienResult | PoprzednieWersje | Wersje | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaBudzProj | PozycjaBudzProjektuOglolne | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaBudzProj | PozycjaBudzProjektuPlan | Plan | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaBudzProj | PozycjaBudzProjektuRealizacja | Realizacja | 200 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaBudzProj | PozycjaBudzProjektuNadrzednaRealizacja | Realizacja z podrzędnych | 210 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaBudzProj | PerspectiveFirst | Perspektywa P1 | 220 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaBudzProj | PerspectiveSecond | Perspektywa P2 | 230 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaBudzProj | PerspectiveFifth | Perspektywa P5 | 240 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaBudzProj | PerspectiveFourth | Perspektywa P4 | 240 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaBudzProj | PerspectiveThird | Perspektywa P3 | 240 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaBudzProj | PozycjaBudzProjektuOpis | Opis | 300 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaBudzProj | PozycjaBudzProjektuUprawnienia | Uprawnienia | 900 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PozycjaDefKregu | PozycjaDefKreguOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaDefinicjiArkuszaAnkiety | Ogólne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| PozycjaDokHandlowego | Ogolne | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| PozycjaDokHandlowego | PozycjaOgolne | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaOgolneKBN | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.KlientBiuraRachunkowego |
| PozycjaDokHandlowego | PozycjaKSeFKBN | KSeF | 2 | Soneta.Handel.UI.dll | Soneta.KlientBiuraRachunkowego |
| PozycjaDokHandlowego | PozycjaUE | UE | 4 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaKompletacjaRozchod | Kompletacja/Rozchód | 31 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaKompletacjaPrzychod | Kompletacja/Przychód | 32 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaEUDR | EUDR | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaKSeF | KSeF | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaMarza | Marża | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaUmowaCykliczna | Umowa | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaUmowaDostawy | Odczyt | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaZasoby | Zasoby | 101 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaZasobyPartie | Partie i zasoby | 101 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjDokHandlowegoZgloszeniaPozDH | Zgłoszenia na szkolenia | 1000 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| PozycjaDokHandlowego | PozycjaRelacje | Relacje | 1000 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaTimeTracks | Powiązane czasy realizacji | 1000 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | PozycjaCenaRabatInfo | Informacja o cenie | 1100 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowego | ProdukcjaZaawansowana | Produkcja zaawansowana | 1200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PozycjaDokHandlowegoLimit | ServiceDesk | ServiceDesk | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDokHandlowegoWyborDefinicjiCenyWorkerParams | Ogolne | Wybór ceny | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaDoswiadczeniaProfiluGrupaNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaDoswiadczeniaProfiluGrupaPozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaDoswiadczeniaProfiluObszarNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaDoswiadczeniaProfiluObszarPozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaInwentaryzacji | PozycjaInwentaryzacjiOgolne | Ogólne | 40 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaInwentaryzacjiCzastkowej | PozycjaSpisuOgolne | Ogólne | 40 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaJezykowObcychProfiluNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaJezykowObcychProfiluPozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaKwalifikacjiZawodowychProfiluNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaKwalifikacjiZawodowychProfiluPozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaMaszynIUrzadzenProfiluNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaMaszynIUrzadzenProfiluPozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaPaczkiPrzelewow | Przelew | Ogólne | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PozycjaPaczkiPrzelewow | Przelew2 | Przelew | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PozycjaPaczkiPrzelewow | PrzelewSwift | Dane dodatkowe | 30 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PozycjaPaczkiPrzelewow | PozycjaPaczkiPrzelewow PowodAnulowania | Powód anulowania | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PozycjaPaczkiPrzelewow | PrzelewZobowiazania | Zobowiązania i wpłaty | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PozycjaProfiluKKMNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaProfiluKKMPozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaProfiluKKUNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaProfiluKKUPozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaProfiluZadaniowego | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaPrzelewu | PozycjaPrzelewu | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PozycjaRelacjiHandlowej | PozycjaRelacji | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| PozycjaSchematuKsiegowego | PozycjaSchematuKsiegowegoPodstawowy | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaSchematuKsiegowego | PozycjaSchematuKsiegowegoZaawansowane | Zaawansowane | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaSchematuKsiegowego | PozycjaSchematuKsiegowegoWeryfikacja | Weryfikacja | 300 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaSchematuKsiegowego-ItemsCollection | ItemsCollectionOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaSprawozdaniaDodatkoweObjasnienia | Ogolne | Ogólne | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaSprawozdaniaPodatekDochodowy | Ogolne | Ogólne | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaSprawozdaniaPodatekDochodowyUz | Ogolne | Ogólne | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaSprawozdaniaZasadyRachunkowosci | Ogolne | Ogólne | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaSprawozdaniaZestawienieInformacji | Ogolne | Ogólne | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaSprawozdaniaZestawienieLokat | Ogolne | Ogólne | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaSystemowITProfiluNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaSystemowITProfiluPozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaSzkolenIUprawnienProfilu | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaTechn | PozycjaTechnOgolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| PozycjaTechn | PozycjaTechnDokumenty | Dokumenty | 1004 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| PozycjaTerminarzaInw | PozycjaTerminarzaInwOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaWyksztalceniaProfiluSrednieNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaWyksztalceniaProfiluSredniePozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaWyksztalceniaProfiluWyzszeNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaWyksztalceniaProfiluWyzszePozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaWyksztalceniaProfiluZasadniczeZawodoweNiezbedne | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaWyksztalceniaProfiluZasadniczeZawodowePozadane | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaWyszukania | PozycjaWyszukania | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PozycjaZamowienia | Tile | Tile | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| PozycjaZestKS | PozycjaZestawieniaKSOgolne | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaZestKS | Protections | Dodatkowe | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PozycjaZestKS | Expression | Wyrażenie [DBG] | 999 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Pozyczka | PozyczkaFPz | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Pozyczka | PozyczkaFPzNet | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Pozyczka | PozyczkaFPzWarunki | Warunki spłaty | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Pozyczka | PozyczkaFPzWarunkiNet | Warunki spłaty | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Pozyczka | PozyczkaFPzZyranci | Żyranci | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Pozyczka | PozyczkaFPzZyranciNet | Żyranci | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Pozyczka | ElementyWynagrodzeniaExt | Elementy wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Pozyczka | RozliczenieWynagrodzenia | Rozliczenia wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUzytkownika | Kadry/Użytkownika | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | MobileKontakt | Dane kontaktowe | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracPlaceElementy | Płace/Elementy | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikOgolne | Kadry/Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikOgolne2 | Kadry/Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PulpitKBOgolne | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracPlaceWyplaty | Płace/Wypłaty | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PulpitKBAdresy | Adresy | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | KartotekaCentralna | Kadry - pozostałe/Kartoteka centralna | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | KartyOpisuStanowiska | ZZL/Karty opisu stanowiska | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PoswiadczeniaOdbioru | Oświadczenia i wnioski/Poświadczenia odbioru | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikBadaniaLekarskie | Kadry - pozostałe/Badania lekarskie | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikGUS | Kadry - pozostałe/Dane statystyczne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikHistoryczne | Kadry - historyczne/Dane historyczne | 11 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikOpis | ZZL/Aktualny opis | 12 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikOswiadczenia | Oświadczenia i wnioski/Oświadczenia | 12 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDeklaracjePIT | Deklaracje/Podatkowe (PIT) | 15 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PracHistoria | EtatOgolne | Etat/Ogólne | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | KartyKompetencjiPracownika | ZZL/Karty kompetencji | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikTeczkaPracownicza | Elektroniczna dokumentacja pracownicza/Akta osobowe | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPozostaleDokumenty | Elektroniczna dokumentacja pracownicza/Pozostała dokumentacja | 21 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDokumentyTechniczne | Elektroniczna dokumentacja pracownicza/Dokumenty techniczne | 22 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikCzasPracy | Kalendarz/Czas pracy | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | CeleOkresowePracownika | ZZL/Cele okresowe pracownika | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | DefinicjeCzynnikowSzkodliwych | Kadry - pozostałe/Czynniki szkodliwe i uciążliwe | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUmowy | Umowy/Umowy | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUmowyZewnetrzne | Umowy zewnętrzne/Umowy zewnętrzne | 41 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | Wysilek | Kadry - pozostałe/Wysiłek | 41 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | KartyRealizacjiCelu | ZZL/Karty realizacji celu | 50 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikFunduszZP | KZP, ZFM, .../KZP, ZFM, ... | 60 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWyplaty | Płace/Wypłaty (wszystkie) | 70 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikRekrutacja | ZZL/Rekrutacja | 80 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | SkladkaNaPPK | PPK/Ogólne | 80 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDeklaracjePPK | PPK/Dokumenty PPK | 81 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PracHistoria | ElementyWynagrodzeniaEtat | Etat/Rozliczenia czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | EtatCovid19 | Etat/Ustawa COVID-19 | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | EtatDodatki | Etat/Dodatki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | EtatInne | Etat/Inne dane | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | EtatRozwUmowy | Etat/Rozwiązanie umowy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | EtatUbezpieczenia | Etat/Ubezpieczenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | EtatUmowaOPrace | Etat/Umowa o pracę | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | EtatWyrejestrowanie | Etat/Wyrejestrowanie | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | OdpisNaOPP | Płace/Odpis na OPP | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracHistoriaPracaZdalna | Kalendarz/Praca zdalna | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikAdresy | Kadry/Adresy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikAkordy | Etat/Akordy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikArkuszeOcenOceniajacy | Oceny/Arkusze ocen - oceniający | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikArkuszeOcenOceniany | Oceny/Arkusze ocen - oceniany | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikCzasPracyKopia | BI/Czas pracy (kopia) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDaneKontaktowe | Kadry/Dane kontaktowe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDeklaracjePFRON | Deklaracje/PFRON | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PracHistoria | PracownikDeklaracjeZUSRozl | Deklaracje/Rozliczeniowe ZUS | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PracHistoria | PracownikDeklaracjeZUSZg | Deklaracje/Zgłoszeniowe ZUS | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PracHistoria | PracownikDodatkoweKwalifikacje | Kadry - pozostałe/Dodatkowe kwalifikacje zawodowe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDokumentyAktualizacjiKalendarza | Kalendarz/Dokumenty aktualizacji kalendarza | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikGIODOOswiadczenia | Ochrona danych osobowych/Oświadczenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikGIODOUprawnienia | Ochrona danych osobowych/Uprawnienia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikGIODOWymianaDanych | Ochrona danych osobowych/Wymiana danych | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikHistOpisu | ZZL/Historia zmian opisu | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikHistZatr | Kadry/Historia zatrudnienia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikInne | Kadry/Dokumenty | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikKariera | ZZL/Ścieżka kariery | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikKartyRCP | Kadry - pozostałe/Karty RCP | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikKosztyAutorskie | Płace/Koszty autorskie | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikLimity | Kalendarz/Limity nieobecności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikLokalizacjePracyZdalnej | Kadry/Lokalizacje pracy zdalnej | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikMultiDodatkowy | Kadry/Wieloetatowość | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikMultiGlowny | Kadry/Wieloetatowość | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNagrodyKary | Kadry - pozostałe/Nagrody i kary | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNieobecBO | Kalendarz/Bilans otwarcia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNieobecRozlicz | Kalendarz/Podstawy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNieobecUrlopBO | Kalendarz/Bilans otwarcia (urlopy) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNieobecnosci | Kalendarz/Nieobecności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNieobecnosciERP7 | Deklaracje/ERP-7 Bilans otwarcia/Bilans otwarcia ERP-7 (nieobecności) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNiepelnosprawnosci | Kadry - historyczne/Schorzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikOceny | ZZL/Oceny | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikOsobaWspl | Kadry/Osoba współpracująca | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPFRON | Kadry/Informacje PFRON | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPit | Kadry/Dane podatkowe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPlanPracy | Kalendarz/Norma czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPlanPracyKopia | BI/Norma czasu pracy (kopia) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPlanowaneNieobecnosci | Kalendarz/Planowane nieobecności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPodatkiBO | Kadry/Dane podatkowe - bilans otwarcia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPodstawyWypoczynkowego | Kalendarz/Podstawy naliczania urlopu wypoczynkowego | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPodstawyZwolnienZUS | Kalendarz/Podstawy naliczania zwolnień ZUS | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPodzielniki | Kadry - pozostałe/Podzielniki kosztów | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPozyczki | KZP, ZFM, .../Pożyczki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPracaZdalna | Kadry/Praca hybrydowa | 100 | Soneta.Core.UI.dll | Soneta.Core |
| PracHistoria | PracownikPrawa | Kadry/Prawa dostępu | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikPrzelewy | Rozrachunki/Przelewy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikRachunki | Kadry/Rachunki bankowe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikRachunki2 | Kadry/Rachunki bankowe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikRodzina | Kadry/Rodzina | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikRozliczeniaCzasuPracy | Kalendarz/Rozliczenia czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikRozliczeniowe | Rozrachunki/Dokumenty rozliczeniowe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikRozrachunki | Rozrachunki/Rozrachunki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikSkladkiFP | Kadry/Podst. składek FP i FGŚP | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikSkladkiZUS | Kadry/Podst. składek ZUS | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikStatystyki | Kalendarz/Statystyka | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikStrukturaOrganizacyjna | Kadry - pozostałe/Struktura organizacyjna | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikSwiadczenia | Kadry - pozostałe/Świadczenia socjalne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikSzkoleniaBHP | Kadry - pozostałe/Szkolenia BHP | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikSzkoleniaBHPZKL | Kadry - pozostałe/Szkolenia i uprawnienia/Szkolenia BHP | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUbezpieczenie | Kadry/Dane ubezpieczeniowe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUbezpieczeniePozostale | Kadry/Dane ubezpieczeniowe pozostałe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUkonczoneSzkolenia | Kadry - pozostałe/Ukończone szkolenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUlgaInnowacyjna | Deklaracje/Ulga innowacyjna (PIT) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUprawnienia | Kadry - pozostałe/Uprawnienia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUwagi | Kadry/Uwagi | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWarunkiPlatnosci | Rozrachunki/Warunki płatności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWeb | Kadry/Dostęp WWW | 100 | Soneta.Core.UI.dll | Soneta.Core |
| PracHistoria | PracownikWlasciciel | Kadry/Właściciel | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWlascicielPagePIT5 | Kadry/Właściciel - podatek PIT | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWlascicielPrzychody | Kadry/Właściciel - przychody | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWnioskiOSzkolenia | Oświadczenia i wnioski/Wnioski o szkolenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWnioskiUrlopowe | Oświadczenia i wnioski/Wnioski o urlopy, delegacje | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWojsko | Kadry/Służba wojskowa | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWyksztalcenie | Kadry/Wykształcenie | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWymagania | Etat/Wymagania | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWynagrodzeniaERP7 | Deklaracje/ERP-7 Bilans otwarcia/Bilans otwarcia ERP-7 (wynagrodzenia) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWypadki | Kadry - pozostałe/Wypadki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikZUS | Kadry/Informacje ZUS | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikZUSOpieka | Oświadczenia i wnioski/Oświadczenia do zasiłku opiekuńczego | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikZadania | Dokumenty i wnioski/Zadania | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PracHistoria | PracownikZajeciaKomornicze | Płace/Zajęcia wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikZaliczki | Płace/Zaliczki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikZaniechPodat | Kadry - historyczne/Zaniechania podatkowe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikZasInnyPlatnik | Płace/Zasiłki (inny płatnik) | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikZbiegPracyIRodzicielstwa | Kalendarz/Zbiegi pracy i rodzicielstwa | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikZestawienia | Kalendarz/Zestawienia czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikZnajomoscJezykowObcych | Kadry - pozostałe/Znajomość języków obcych | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | KadryDokumentyDodatkowe | Oświadczenia i wnioski/Inne kadrowe | 101 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PlaceDokumentyDodatkowe | Oświadczenia i wnioski/Inne płacowe | 101 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUkonczoneSzkoleniaZKL | Kadry - pozostałe/Szkolenia i uprawnienia/Ukończone szkolenia | 102 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikUprawnieniaZKL | Kadry - pozostałe/Szkolenia i uprawnienia/Uprawnienia | 102 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracPlaceStorna | Płace/Elementy stornowane | 110 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikWyksztalcenieZKL | Kadry - pozostałe/Kwalifikacje/Wykształcenie | 110 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikZnajomoscJezykowObcychZKL | Kadry - pozostałe/Kwalifikacje/Znajomość języków obcych | 110 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikObslugaMaszynZKL | Kadry - pozostałe/Kwalifikacje/Obsługa maszyn i urządzeń | 111 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikSystemyITJezykiProgramowaniaZKL | Kadry - pozostałe/Kwalifikacje/Systemy IT i języki programowania | 112 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDodatkoweKwalifikacjeZKL | Kadry - pozostałe/Kwalifikacje/Dodatkowe kwalifikacje zawodowe | 113 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracPlaceRozliczenia | Płace/Rozliczenia pracownika | 120 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDeklaracjeRMUA | Deklaracje/Informacje IMIR | 200 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PracHistoria | PracownikDeklaracjeZ3 | Deklaracje/Z-3, Z-3a | 200 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PracHistoria | PracownikDeklaracjePITBO | Deklaracje/Bilans otwarcia deklaracji PIT | 290 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDeklaracjeRIABOOswiata | Deklaracje/Bilans otwarcia deklaracji RIA/Okresy wykonywania pracy nauczycieskiej | 295 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDeklaracjeRIABOWarSzczeg | Deklaracje/Bilans otwarcia deklaracji RIA/Okresy pracy w szczególnych warunkach lub w szczególnym charakterze | 295 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDeklaracjeRIABOWynagr | Deklaracje/Bilans otwarcia deklaracji RIA/Wynagrodzenia | 295 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDeklaracjePIT40 | Deklaracje/Historyczne | 300 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikDokEwidencji | Dokumenty ewidencji/Dokumenty | 400 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikMatryce | Dokumenty ewidencji/Powiązane matryce | 410 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikObslugaMaszyn | Kadry - pozostałe/Obsługa maszyn i urządzeń | 500 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikSystemyITJezykiProgramowania | Kadry - pozostałe/Systemy IT i języki programowania | 510 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | HostTuples | Dokumenty dodatkowe | 997 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikArchiwum | Pracownik w archiwum | 998 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | RefTuples | Powiązane dokumenty dodatkowe | 998 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | EtatRGA | Etat/Dane historyczne | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | RowHistory | Historia zapisów | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNetOgolne | Ogólne | 1001 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNetAdresy | Adresy | 1002 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNetRodzina | Rodzina | 1005 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNetHistoriaZatrudnienia | Historia zatrudnienia | 1006 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNetWyksztalcenie | Wykształcenie | 1007 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | PracownikNetUwagi | Uwagi | 1009 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracHistoria | WiadomosciPowiazanePracownika | {New WiadomosciPowiazanePracownikaExtender.CaptionHtml} | 2000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PracHistoria | PracownikObszaryOdpowiedzialnosci | Kadry - pozostałe/Obszary odpowiedzialności | 5000 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Pracownik-ZapiszTeczkeDoPlikuWorker-Params | SaveFolderParams | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Pracownik-ZmienOpisWorker-Params | Params | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikDaneKadrowe | Adresy | Adresy | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikDaneKadrowe | DanePodatkowe | Dane podatkowe | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikDaneKadrowe | HistoriaZatrudnienia | Historia zatrudnienia | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikDaneKadrowe | Ogolne | Ogólne | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikDaneKadrowe | RachunkiBankowe | Rachunki bankowe | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikDaneKadrowe | Rodzina | Rodzina | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikDaneKadrowe | SkladkaNaPPK | Skladki na PPK | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikDaneKadrowe | StatystykaStazuPracy | Statystyka stażu pracy | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikDaneKadrowe | Umowy | Umowy | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikDaneKadrowe | Wyksztalcenie | Wykształcenie | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikHRProxy | Ogolne | Kartoteki pracowników | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikKartotekaCentralnaManagerWorker | Ogolne | Wybierz | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikLuki | Ogolne | Ogólne | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| PracownikNetCzasPracy | Ogolne | Czas pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikNetCzasPracy | Ogolne2 | Czas pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikNetCzasPracy2 | Ogolne | Czas pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikNetCzasPracy2 | Ogolne2 | Czas pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikNetDostepnosc | Ogolne | Dostępność | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikNetPlanPracy | Ogolne | Norma czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikNetPlanPracy | Ogolne2 | Norma czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikNetPlanPracy2 | Ogolne | Norma czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikNetPlanPracy2 | Ogolne2 | Norma czasu pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikNetZestawienieCzasuPracy | Ogolne | Zestawienie czasu pracy | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikObiektyCzasPracy | Ogolne | Czas pracy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikObiektyPlanPracy | Ogolne | Planowanie | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikPozostałeDokumentyExtender | PozostaleDokumenty | Pozostała dokumentacja | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PracownikTeczkaPracowniczaExtender | TeczkaPracownicza | Akta osobowe | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Preliminarz | PreliminarzOgolne | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Preliminarz | Preliminarz | Ewidencje ŚP/Preliminarz/Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PreliminarzDokument | PreliminarzDok | Ogólne | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PreliminarzDokumentDefDok | Rozszerzenie | Rozszerzenie | 101 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PreliminarzFeatures | PreliminarzFeatures | Ewidencje ŚP/Preliminarz/Algorytmy cech | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PreliminarzPozycja | PreliminarzPozOgolne | Ogólne | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PreliminarzPozycja | PreliminarzPozRozliczenia | Rozliczenia | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PreviewPage | Ogolne | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| PreviewPages | PreviewPages | Workflow/Okna podglądu | 98 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| PriorytetLeada | PriorytetyLeadaOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| PriorytetTransakcja | PriorytetyTransakcjiOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| PriorytetZadania | PriorytetyZadaniaOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ProAwaria | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProCzasPracy | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProDefinicjaMeldunku | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProDefinicjaMeldunku | Dokumenty | Dokumenty | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProDefinicjaMeldunku | Parametry | Parametry | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProDefinicjaOperacji | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProDostawaMaterialuMeldunku | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProFantomMaterialu | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProFantomWyrobu | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProKalkulacjeMType | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProKalkulacjeOZType | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProKompetencja | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProKompetencja | Zasoby | Zasoby | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMaterialMeldunku | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMaterialMeldunku | Dostawy | Dostawy | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMaterialMeldunkuWybierzDostaweWorker | Zasoby | Zasoby | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMaterialOperacjiTechnologii | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMaterialOperacjiTechnologii | Relacje | Relacje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMaterialOperacjiTechnologii | Opcje | Opcje | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMaterialOperacjiZlecenia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMaterialOperacjiZlecenia | Relacje | Relacje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMaterialOperacjiZlecenia | Zapotrzebowania | Zapotrzebowania | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMeldunek | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMeldunek | Materialy | Materiały | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMeldunek | Odpady | Odpady | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMeldunek | Zasoby | Zasoby | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMeldunek | Uslugi | Koszty dodatkowe | 500 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMeldunek | Wyroby | Wyroby | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMeldunek | Kalkulacja | Kalkulacja | 700 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMeldunek | CzasyPracy | Czasy pracy | 800 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMeldunek | Dokumenty | Dokumenty | 900 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProMeldunek | OpisyPIM | Opisy PIM | 1000 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProNumeracjaMeldunku | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProNumeracjaTechnologii | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProNumeracjaWyrobuMeldunku | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProNumeracjaZlecenia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOdpadMeldunku | Ogolne | Odpady | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOdpadOperacjiTechnologii | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOdpadOperacjiTechnologii | Opcje | Opcje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOdpadOperacjiZlecenia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaTechnologii | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaTechnologii | Operacje | Operacje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaTechnologii | Opcje | Opcje | 900 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaTechnologiiBilansMaterialowWorker | Ogolne | Parametry bilansu materiałowego operacji | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaTechnologiiPoprzedzajaca | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Operacje | Operacje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Materialy | Materiały | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Odpady | Odpady | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Zasoby | Zasoby | 500 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Uslugi | Koszty dodatkowe | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Wyroby | Wyroby | 700 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Kalkulacja | Kalkulacja | 800 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | CzasyPracy | Czasy pracy | 900 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Meldunki | Meldunki | 1000 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Zamowienia | Zamówienia | 1100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZlecenia | Dokumenty | Dokumenty | 1200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZleceniaBilansMaterialowWorker | Materialy | Bilans materiałowy operacji | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOperacjaZleceniaPoprzedzajaca | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOpisPIMParams | lookup | Nowy opis PIM | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOsoba | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProOsoba | Filtry | Filtry | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProPlanPracy | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProPlanyPracy | Scheduler | Harmonogram planów pracy | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProPozycjaZamowienia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProPozycjaZestawieniaMaterialow | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProRelacjaMaterialWyrobOperacjiTechnologii | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProRelacjaMaterialWyrobOperacjiZlecenia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProRelacjaZasobUrzadzenie | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProRozliczenieMaterialu | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProRozliczenieWyrobu | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProStawka | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProTechnologia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProTechnologia | Operacje | Operacje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProTechnologia | Gantt | Gantt | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProTechnologia | Struktura | Struktura | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProTechnologia | Kalkulacja | Kalkulacja | 500 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProTechnologia | OpisyPIM | Opisy PIM | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProTechnologiaBilansMaterialow | Ogolne | {GetCaptionHtml()} | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProTechnologiaBilansMaterialowWorker | Ogolne | Parametry bilansu materiałowego technologii | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProTechnologiaStrukturaMaterialowWorker | Materialy | Struktura materiałowa | 900 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProTowar | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUslugaMeldunku | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUslugaOperacjiTechnologii | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUslugaOperacjiTechnologii | Opcje | Opcje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUslugaOperacjiZlecenia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUzytkownikPaneluMeldunkowego | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUzytkownikPaneluMeldunkowego | WebUser | Dostęp www | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUzytkownikPaneluMeldunkowego | Rejestracja | Rejestracja | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUzytkownikPaneluMeldunkowego | Raportowanie | Raportowanie | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUzytkownikPaneluMeldunkowego | Realizacja | Realizacja | 500 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUzytkownikPaneluMeldunkowego | Dokumentacja | Dokumentacja | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProUzytkownikPaneluMeldunkowego | Operacje | Operacje | 700 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWariantowoscZasobu | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWariantowoscZasobuOperacjiTechnologii | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWariantowoscZasobuOperacjiZlecenia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWydzial | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWydzial | Numeracja | Numeracja | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWydzial | Magazyny | Magazyny | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWydzial | Dokumenty | Dokumenty | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWydzial | Parametry | Parametry | 500 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWyrobMeldunku | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWyrobOperacjiTechnologii | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWyrobOperacjiTechnologii | Parametry | Parametry | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWyrobOperacjiTechnologii | Relacje | Relacje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWyrobOperacjiZlecenia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWyrobOperacjiZlecenia | Relacje | Relacje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWyrobOperacjiZlecenia | Zamowienia | Zamówienia | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProWyrobOperacjiZlecenia | Parametry | Parametry | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasob | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasob | Kompetencje | Właściwości | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasob | Wariantowosci | Wariantowości | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasob | Urzadzenia | Urządzenia | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasobMeldunku | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasobMeldunku | CzasyPracy | Czasy pracy | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasobOperacjiTechnologii | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasobOperacjiTechnologii | Kompetencje | Właściwości | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasobOperacjiZlecenia | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasobOperacjiZlecenia | Kompetencje | Właściwości | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasobOperacjiZlecenia | PlanyPracy | Plany pracy | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZasobOperacjiZlecenia | CzasyPracy | Czasy pracy | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZestawienieMaterialow | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZestawienieMaterialow | Materialy | Materiały | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZleceniaGantt | Tile | Tile | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | Ogolne | Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | Operacje | Operacje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | Gantt | Gantt | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | Kalkulacja | Kalkulacja | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | CzasyPracy | Czasy pracy | 500 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | Meldunki | Meldunki | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | Zlecenia | Zlecenia | 700 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | Struktura | Struktura | 800 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | Zamowienia | Zamówienia | 900 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | Dokumenty | Dokumenty | 1000 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenie | OpisyPIM | Opisy PIM | 1100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProZlecenieBilansMaterialowWorker | Materialy | Bilans materiałowy zlecenia | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProceduraSME | Ogolne | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| ProceduraSME | ProceduraSME | Ewidencja VAT/Procedura SME | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ProceduraSME | RowHistory | Historia zapisów | 999 | Soneta.Core.UI.dll | Soneta.Core |
| ProceduraVAT | AlgorytmEwidencji | Algorytm ewidencji | 10 | Soneta.Core.UI.dll | Soneta.Core |
| ProceduraVAT | AlgorytmHandlowy | Algorytm handlowy | 10 | Soneta.Core.UI.dll | Soneta.Core |
| ProceduraVAT | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| ProdAwaria | ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdKompetencja | ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdMeldunekBraku | ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdOsoba | ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdOsobaWzorcowa | ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdPozSlownika | ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdProdukt | ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdSlownik | ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdZasob | ProdZasob | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdZasob | ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdZasob | urzadzenia | ZasobyCRM | 20 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdZasobAnalizaObciazeniaWorker | Ogolne | Analiza | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdZasobWzorcowy | ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Product | General | Ogólne | 10 | Soneta.Support.UI.dll | Soneta.Support |
| Product | GeneralClient | Ogólne | 10 | Soneta.Support.UI.dll | Soneta.Support |
| Product | Versions | Wersje | 10 | Soneta.Support.UI.dll | Soneta.Support |
| Product | VersionsClient | Wersje | 10 | Soneta.Support.UI.dll | Soneta.Support |
| ProductionGanttScheduler | General |  | 100 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Products | Products | Pulpity/Pulpit kontrahenta/ServiceDesk/Konfiguracja produktów oraz ich wersji | 110 | Soneta.Support.UI.dll | Soneta.Support |
| Produkcja | Produkcja | Produkcja/Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdukcjaKalkulacja | ProdukcjaKalkulacja | Produkcja/Kalkulacja | 100 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| ProdukcjaProKody | ProdukcjaProKody | Produkcja zaawansowana/Kody | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProdukcjaProKonfiguracjaOperatora | ProdukcjaProKonfiguracjaOperatora | Produkcja zaawansowana/Ustawienia operatora | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProdukcjaProOgolne | ProdukcjaProOgolne | Produkcja zaawansowana/Ogólne | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProdukcjaProUzytkownicy | ProdukcjaProUzytkownicy | Produkcja zaawansowana/Użytkownicy panelu | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| ProfilKompetencjiMerytorycznych | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilKompetencjiMerytorycznych | Kompetencje | Kompetencje | 41 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilKompetencjiUniwersalnych | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilKompetencjiUniwersalnych | Kompetencje | Kompetencje | 41 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilKwalifikacyjny | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilKwalifikacyjny | Wyksztalcenie | Wykształcenie | 41 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilKwalifikacyjny | Doswiadczenie | Doświadczenie zawodowe | 42 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilKwalifikacyjny | DodatkoweKwalifikacje | Dodatkowe kwalifikacje | 43 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilKwalifikacyjny | JezykiObce | Języki obce | 44 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilKwalifikacyjny | MaszynyIUrzadzenia | Obsługa maszyn i urządzeń | 45 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilKwalifikacyjny | SystemyIT | Systemy IT i języki programowania | 46 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilSzkolenIUprawnien | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilSzkolenIUprawnien | SzkoleniaIUprawnienia | Szkolenia i uprawnienia | 41 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilZadaniowy | Ogolne | Ogólne | 40 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ProfilZadaniowy | Zadania | Zadania | 41 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Projekt | ProjektUzytkownika | {New ProjektUzytkownikaExtender.NazwaZakladki} | 1 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektDodatkowe | Dodatkowe | 15 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektRealizacja | Realizacja | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektLeady | Leady | 22 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektWykonujacy | Wykonujący | 22 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektTransakcje | Transakcje | 23 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektZadania | Aktywności projektu | 24 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | TransakcjeDokumenty | Dokumenty z transakcji | 24 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektNieruchomosci | Nieruchomości | 25 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektZadaniaKalendarz | Kalendarz | 25 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektEtapy | Etapy projektu | 30 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjectCRMDocumentsExtender | Dokumenty | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | DemandPositions | Usługi | 65 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektDokumenty | Dokumenty z zadań | 70 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektDokumentyBudzetu | Budżetowanie/Dokumenty budżetu | 140 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | WiadomosciPowiazaneProjektu | {New WiadomosciPowiazaneProjektuExtender.CaptionHtml} | 1000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Projekt | ProjektZasoby | Zasoby | 2000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ProjektWykonujacy | ProjektWykonujacy | Wykonujący projektu | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| PrzecenaKopiowanieWorker-PrzecenaKopiowanieParams | Params |  | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| PrzecenaKwotowaWorker-PrzecenaKwotowaParams | Params |  | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| PrzecenaOkresowa | Ogolne | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| PrzecenaOkresowa | Ogolne | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| PrzecenaOkresowa | PrzecenaOkresowa | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Towary |
| PrzecenaOkresowaCeny | SchematyGratisow | Schematy gratisów | 2 | Soneta.Handel.UI.dll | Soneta.Towary |
| PrzecenaOkresowaRabatu | RabatOkresowy | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Towary |
| PrzecenaProcentowaWorker-PrzecenaProcentowaParams | Params |  | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| PrzecenaWorker-PrzecenaParams | Params |  | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| PrzedmiotItems | BilansZajec | Bilans zajęć | 100 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| PrzedmiotOp | Ogolne | Przedmiot opodatkowania | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PrzedmiotSzkol | PrzedmiotSzkolOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Przejazd | PrzejazdOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PrzelewBase | Przelew | Ogólne | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PrzelewBase | Przelew2 | Przelew | 20 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PrzelewBase | PrzelewZobowiazania | Zobowiązania i wpłaty | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PrzelewWalutowy | PrzelewSwift | Dane dodatkowe | 30 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Przelewy | Przelewy | Ewidencje ŚP/Przelewy | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Przelewy-PodsumowaniePrzelewyWorker | SumujPrzelewy | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| PrzeliczProceduryVATWorker-PrzeliczProceduryVATParams | Ogolne | Parametry | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| Przeszacowanie | PrzeszacowanieOgolne | Ogólne (Przeszacowanie) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Przeszeregowania | Przeszeregowania | Kadry i płace/Kadry/Przeszeregowania | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Przeszeregowanie | Przeszeregowanie | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Przeszeregowanie | PrzeszeregowanieElementy | Elementy | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PrzetwarzanieZgloszeniaSygnalisty | Ogolne | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PrzyczynaRozwUmowy | PrzyczynaRozwUmowyOgolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PrzyczynaZawUmowy | PrzyczynaZawUmowyOgolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| PrzygotujPlatnoscRataLeasingowaWorker | Ogolne | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| PublikacjaRozliczenPodatkowychWorkerParams | Params |  | 1 | Soneta.Business.UI.dll | Soneta.Business |
| PulpitKB | PulpitKB | Pulpity/Pulpit KBR | 20 | Soneta.Core.UI.dll | Soneta.Core |
| PulpitKBEksportPrzelewowParams | Params |  | 100 | Soneta.EI.UI.dll | Soneta.EI |
| PulpitKBR | RozliczeniaPodatkowe | Rozliczenia podatkowe | 100 | Soneta.EI.UI.dll | Soneta.EI |
| PulpitKBR | Rozrachunki | Rozrachunki z biurem | 100 | Soneta.EI.UI.dll | Soneta.EI |
| PulpitKBRDodajDokumentyZbiorczoWorkerParams | Params |  | 100 | Soneta.EI.UI.dll | Soneta.EI |
| PulpitKBRKonfiguracjaWorker | Ogolne | Konfiguracja | 100 | Soneta.EI.UI.dll | Soneta.EI |
| PulpitKontrahenta | PulpitKontrahenta | Pulpity/Pulpit kontrahenta/Podstawowe | 30 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Pulpity | ZasobnikDokumentow | Zasobnik dokumentów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| QueryItemHost | QueryItemHostOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| RCAII | RCA | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RCA_O | RCAZal | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RCA_O | RCAZalDodatkowe | Pozostałe | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RCA_O | RCARoczneRozSklZdrowotnej | Roczne rozliczenie składki zdrowotnej | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RCA_O | RCAZalFormyOpodatkowania | Formy opodatkowania | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RCPWeryfikator | RCPWeryfikator | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RCPWeryfikator | RCPWeryfikatorNet | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RCPWeryfikatorWorker | RCPWeryfikatorWorker | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RCPWeryfikatorWorker | RCPWeryfikatorWorkerNet | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RIA | RIA | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA | RIAZalacznikiV | Załączniki V | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA | RIAZalacznikiVI | Załączniki VI | 51 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA | RIAZalacznikiVII | Załączniki VII | 52 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA | RIAZalacznikiVIII | Załączniki VIII | 53 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA | RIAZalacznikiIX | Załączniki IX | 54 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA | RIAZalacznikiX | Załączniki X | 55 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA | RIAZalacznikiXI | Załączniki XI | 56 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA_IX | RIA_IX | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA_V | RIA_V | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA_VI | RIA_VI | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA_VII | RIA_VII | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA_VIII | RIA_VIII | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA_X | RIA_X | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RIA_XI | RIA_XI | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RMKEwidencja | RMKEwidencjaOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RMKOgolne | RMKOgolne | Księgowość/RMK | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RMKOgolne-KPIR | RMKOgolne-KPIR | KPiR/RMK | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RMUA | RMUA | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RPA_O | RPA | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RPA_O | RPAPracownik | III (B, C, D, E) | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RPA_O | RPANauczyciel | III (F, G) | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RSA_O | RSAZal | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RTFEditor | RTFEditor | UI/Edytor RTF | 100 | Soneta.Business.UI.dll | Soneta.Business |
| RUD | RUD | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RUD_O | RUD_O | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RZA_O | RZAZal | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RachunekBankowyFirmy | RachunekFirmy | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RachunekBankowyFirmy | RachunkiRozliczeniowe | Rachunki rozliczeniowe | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RachunekBankowyFirmyBase | EwidencjaSPElixir | Przelewy elektroniczne | 40 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RachunekBankowyFirmyBase | EwidencjaImportCode | Kod użytkownika | 60 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RachunekBankowyKontrahenta | PulpitKBR | Ogólne | 0 | Soneta.EI.UI.dll | Soneta.EI |
| RachunekBankowyKontrahenta | RachunekKontrahenta | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| RachunekBankowyKontrahenta | HistoriaWeryfikacji | Historia weryfikacji | 3 | Soneta.CRM.UI.dll | Soneta.CRM |
| RachunekBankowyPracownika | RachunekPracownika | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RachunekBankowyPracownika | RachunekPracownika2 | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RaportESP | Ogolne | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RaportESP | RaportESPZaplaty | Wpłaty i wypłaty | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RaportESP | RaportESPOperacjeBankowe | Operacje bankowe | 2 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RaportESPDefDok | Rozszerzenie | Rozszerzenie | 110 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RaportESPEwidencja | RaportESPEwidencja | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RaportOkresowyParams | RaportOkresowyParamsPage |  | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| RaportRozliczeniaKaucjiObslugaPozycjaParams | RaportRozliczeniaKaucjiObslugaPozycjaParams |  | 100 | Soneta.Handel.Reports.dll | Soneta.Handel |
| RaportRozliczeniaKaucjiRelacjaKaucjiParams | RaportRozliczeniaKaucjiRelacjaKaucjiParams |  | 100 | Soneta.Handel.Reports.dll | Soneta.Handel |
| RataLeasingST | Ogolne | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RataLeasingowa | RataLeasingowaOgolne | Ogólne (Rata leasingowa) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RataPozyczki | RataPozyczkiFPz | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ReadOnlyDataSource | First | ReadOnly test | 200 | Soneta.Net.Test.dll | Soneta.Net |
| RealEstateTask | General | Ogólne | 11 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| RealEstateTask | Objects | Obiekty | 12 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| RealEstateTask | RelatedTasks | Zdarzenia powiązane | 30 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| RealEstateTask | Documents | Dokumenty | 50 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| RealEstateTask | Attachement | Załączniki | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| RealizacjaCelu | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RealizacjaPlanu | General | PivotGrid test | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| RealizacjaSzkolenia | RealizacjaSzkolenia | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RealizacjaSzkolenia | RealizacjaSzkoleniaZzl | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RealizacjaSzkolenia | RealizacjaSzkoleniaDodatkoweZzl | Kontakt, lokalizajca i rozliczenie | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RealizacjaSzkolenia | RealizacjaSzkoleniaUwagi | Uwagi | 35 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RecordPermission | General | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| Region | Ogolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| Regiony | Regiony | CRM/Ogólne/Regiony | 110 | Soneta.CRM.UI.dll | Soneta.CRM |
| Register | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| Registers | Registers | DMS/Rejestry dokumentów podstawowych | 300 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| RegistrationTimeParams | RegistrationTimeParams | REJESTRACJA CZASU PRACY | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| RegulaDostepnosci | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RegulaDostepnosci | Wyjatki | Wyjątki | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RejVatImportParams | Params | Ogólne | 100 | Soneta.EI.UI.dll | Soneta.EI |
| RejestrUDZ | RejestrUDZOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RejestracjaUczestnikaPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Rekrutacja | Rekrutacja | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Rekrutacja | RekrutacjaUwagi | Uwagi | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Rekrutacja | RekrutacjaOpis | Aktualny opis | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RekrutacjaAplikacja | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RekrutacjaWakat | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RekrutacjaWakat | KartyOpisuStanowiska | Karty opisu stanowiska (ogłoszenia) | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RekrutacjaWakat | OfertyPracy | Ogłoszenia o pracę | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RelacjaOpisAnal | RelacjaOpisAnalOgolne | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RelacjaOpisPIM | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| RelacjaPodmiotu | Ogolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| RelacjaZewn | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| RelacjeHandloweWorker-DokumentyParams | Ogolne | Dokumenty | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| RelacjeHandloweWorker-DokumentyZaliczkoweParams | Ogolne | Dokumenty zaliczkowe | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| RelacjeHandloweWorker-MagazynParams | Ogolne | Magazyny | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| RelacjeHandloweWorker-PozycjeParams | Ogolne | Pozycje | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| RelacjeHandloweWorker-PozycjeTechnologiiProduktyParams | Produkty | Produkty | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| RelacjeHandloweWorker-PozycjeTechnologiiSurowceParams | Surowce | Surowce | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| RelacjeHandloweWorker-SumyVatParams | Ogolne | Sumy VAT | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| RelacjeOpisAnal | CfgOpisAnalitycznyRelacje | Księgowość/Powiązania OA z zapisami | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RentSchedulerViewInfo | General | Kalendarz najmu | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| RenumeratorDekretow-RenumeratorDekretowParam | Ogolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RenumerujRaportyWorker-RenumerujRaportyParam | Ogolne | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ReportDefinition | ReportDefinitionOgolne | Właściwości modelu | 1 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionStructure | Struktura modelu | 2 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionCondition | Ogólne/Elementy modelu/Warunek | 3 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionExtendCondition | Ogólne/Elementy modelu/Dodatkowy warunek | 4 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionFields | Ogólne/Elementy modelu/Pola | 5 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionExtendFields | Ogólne/Elementy modelu/Dodatkowe pola | 6 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionParams | Ogólne/Elementy modelu/Parametry | 7 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionExtendParams | Ogólne/Elementy modelu/Dodatkowe parametry | 8 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionGroupBy | Ogólne/Elementy modelu/Grupowanie | 9 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionExtendGroupBy | Ogólne/Elementy modelu/Dodatkowe grupowanie | 10 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionOrderBy | Ogólne/Elementy modelu/Sortowanie | 11 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionExtendOrderBy | Ogólne/Elementy modelu/Dodatkowe sortowanie | 12 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionRelationship | Relacje | 13 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinition | ReportDefinitionVisualizations | Wizualizacje | 14 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinitionAddFields | StructureAddFields | Dodaj pola | 10 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinitionOrderBy | StuctureOrderBy | Sortowanie | 100 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDefinitionSourceDomain | SourceDomain | Domeny źródłowe | 100 | Soneta.BI.UI.dll | Soneta.BI |
| ReportDocumentsWorkerParamsDokEwidencji | General | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ReportDocumentsWorkerParamsDokHandlowy | General | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| ReportFileNameCreator | General | Wzór nazwy pliku | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ReportGenerator | XML | XML | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ReportParam | ReportParamOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| ReportParamCode | ReportParamCodeAlgorithm | Algorytm | 2 | Soneta.BI.UI.dll | Soneta.BI |
| ReportParameters | General |  | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ReportPasswordCreator | General | Wzór hasła | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ReportsDesignerData | General | Raporty | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ReportsGeneral | ReportsGeneral | Raportowanie/Ogólne | 100 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| Reservation | UserForm | {New ReservationUserFormExtender.NazwaZakladki} | 1 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| Reservation | General | Ogólne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| Reservation | Fines | Mandaty | 20 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| Reservation | Documents | Dokumenty | 80 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| Reservation | Attachements | Załączniki | 100 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| ReservationDef | General | Ogólne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| ReservationDef | States | Stany | 20 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| ReservationDefs | ReservationDefs | Flota/Definicje rezerwacji | 80 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| ReservationState | General | Ogólne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| Result | NaliczDokumentyRMK | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Result | NaliczanieAmortyzacji | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RezerwacjaStanowiskaPracy | General | Ogólne | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| RezerwacjaSurowca | RezerwacjaSurowca | Rezerwacja surowca | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Rezerwator | Rezerwacje | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| RightsList | RightsList | Systemowe/Uprawnienia/Lista praw | 400 | Soneta.Business.UI.dll | Soneta.Business |
| RightsSchema | RightsSchema | Systemowe/Debug/Schemat praw | 100 | Soneta.Business.UI.dll | Soneta.Business |
| RightsStructure | RightsStructure | Systemowe/Debug/Struktura praw | 100 | Soneta.Business.UI.dll | Soneta.Business |
| RightsSystem | RightsSystem | Systemowe/Uprawnienia/System praw | 401 | Soneta.Business.UI.dll | Soneta.Business |
| RodzajDokumentuKseF | Ogolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| RodzajDokumentuKseF | Kontrahenci | Powiązani kontrahenci | 20 | Soneta.Core.UI.dll | Soneta.Core |
| RodzajDokumentuKseF | ImportCode | Algorytm | 60 | Soneta.Core.UI.dll | Soneta.Core |
| RodzajPO | RodzajPO | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RodzajST | RodzajST | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RodzajSzkol | RodzajSzkolOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RodzajSzkol | RodzajSzkolOpis | Opisy | 20 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RodzajSzkol | RodzajSzkolPrzedmioty | Przedmioty | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RodzajSzkol | RodzajSzkolPrzedmiotyModule | Przedmioty modułowe | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RodzajSzkol | RodzajSzkolCertyfikaty | Certyfikaty | 40 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RodzajSzkol | RodzajSzkolUprawnienia | Uprawnienia | 45 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RodzajSzkol | RodzajSzkolGrupySzkol | Grupy szkoleniowe | 50 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RodzajSzkol | RodzajSzkolGrupySzkolUcz | Grupy uczestników | 51 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RodzajSzkol | RodzajSzkolModuly | Moduły | 80 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RodzajSzkolPrzedmiot | RodzajSzkolPrzedmiotSzkolOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| RodzajZrodla | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| RodzajeKontaktow | RodzajeKontaktow | Ogólne/Rodzaje kontaktów | 9 | Soneta.Core.UI.dll | Soneta.Core |
| RodzajeLokalizacji | RodzajeLokalizacji | Ogólne/Rodzaje lokalizacji | 9 | Soneta.CRM.UI.dll | Soneta.CRM |
| RodzajeZrodel | RodzajeZrodel | Ogólne/Rodzaje źródeł | 5 | Soneta.Core.UI.dll | Soneta.Core |
| Role | Role | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| Role | RoleRights | Prawa | 10 | Soneta.Business.UI.dll | Soneta.Business |
| Role | RoleEntitles | Uprawnienia | 20 | Soneta.Business.UI.dll | Soneta.Business |
| RoleCategory | Opis | Ogólne | 20 | Soneta.Business.UI.dll | Soneta.Business |
| RoleIdentContext | RightsContext | Uprawnienia kontekstowe | 15 | Soneta.Business.UI.dll | Soneta.Business |
| RoleOpiekuna | RoleOpiekuna | CRM/Ogólne/Role opiekunów | 12 | Soneta.CRM.UI.dll | Soneta.CRM |
| Roles | Roles | Systemowe/Uprawnienia/Role | 100 | Soneta.Business.UI.dll | Soneta.Business |
| RoomDiagramReservationCreator | General | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| RozliczBase | RozliczWorker | Wybierz | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RozliczWgPrzelewowBase | RozliczWgPrzelewowWorker | Rozlicz wg przelewów | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RozliczanieUmowZewnetrznych | RozliczanieUmowZewnetrznych | Rozliczenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RozliczeniaKasoweVATAkcyzyEwidencja | RozliczeniaKasoweVATEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RozliczenieCzasuPracy | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RozliczenieCzasuPracyZaDzien | Rozliczenie | Rozliczenie nadgodzin | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RozliczenieCzasuPracyZaDzien | Net |  | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RozliczenieCzasuPracyZaOkres | Rozliczenie | Rozliczenie nadgodzin | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RozliczenieCzasuPracyZaOkres | Net | Rozliczenie nadgodzin | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RozliczenieDelegacji | RozliczenieDelegacji | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RozliczenieEP | RozliczenieEPOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RozliczenieEP | RozliczenieEPWgPojazdu | Wg pojazdu | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RozliczenieEPEwidencja | RozliczenieEPEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RozliczenieEwidencja | PlatnyEwidencja | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RozliczenieKS | RozliczenieKS | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RozliczenieKsiegoweWorker | RozliczenieKsiegowe | Zapisy | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RozliczenieKsiegoweWorker-Rezultat | Rezultat | Zapisy | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RozliczenieNadplatPPK | Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RozliczenieOA | Ogolne | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RozliczenieSP | Rozliczenie | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RozliczenieSP | RozliczenieRK | Różnice kursowe | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RozliczenieSP | OpisAnalityczny | Opis analityczny | 10000 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RozliczenieSkladekPPK | Ogolne | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| RozliczenieWynagrodzenia | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| RozliczenieZaliczki | RozliczenieZaliczki | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RozliczenieZlecen | Ogolne | Rozliczenie zleceń | 100 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Rozliczeniowe | Rozliczeniowe | Ewidencje ŚP/Dokumenty rozliczeniowe | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RozniceKursoweEwidencja | RozniceKursoweEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RozniceKursoweKPiREwidencja | RozniceKursoweKPiREwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| RozniceKursoweMWEwidencja | RozniceKursoweMWEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Rozrachunki | Rozrachunki | Ewidencje ŚP/Rozrachunki | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| RuntimeFieldDefinition | RuntimeFieldDefinition | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| RuntimeFieldDefinition | EnumValues | Lista wartości | 4 | Soneta.Business.UI.dll | Soneta.Business |
| RuntimeProject | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| RuntimeProject | References | Zależności | 100 | Soneta.Business.UI.dll | Soneta.Business |
| RuntimeProjectReference | General | Zależność projektu | 100 | Soneta.Business.UI.dll | Soneta.Business |
| RuntimeRowRelation | General | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| RuntimeSolution | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| RuntimeSolutions | RuntimeSolutions | Systemowe/Rozwiązania | 100 | Soneta.Business.UI.dll | Soneta.Business |
| RxDesigner | General | Report designer | 100 | Soneta.Business.UI.dll | Soneta.Business |
| SADEwidencja | ZakupEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SADEwidencja | SADEwidencja | Kwoty SAD'u | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SADEwidencja | Zobowiazania | Dane kontrahenta i płatności | 4 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SLACalendar | SLACalendar | Kalendarz | 10 | Soneta.Support.UI.dll | Soneta.Support |
| SLACalendars | SLACalendars | Pulpity/Pulpit kontrahenta/ServiceDesk/Kalendarze | 120 | Soneta.Support.UI.dll | Soneta.Support |
| SLADocument | SLADocument | Parametry SLA | 10 | Soneta.Support.UI.dll | Soneta.Support |
| SODEksport-Params | SODEksportForm | Ogólne | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| SalaSzkol | SalaSzkolOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| SalaSzkol | SalaSzkolHarmonogram | Harmonogram | 20 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| SalaSzkol | SalaSzkolHarmonogramKalend | Kalendarz zajęć | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| SalePlanCopyWorker-SalePlanCopyParams | SalePlanCopyParams | Ogólne | 1 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| SalePlans | General | Plany sprzedażowe | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| SalesPlansCreator | General | Kreator | 1 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| SamochodowkaOgolne | SamochodowkaOgolne | Ewidencja pojazdów/Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SaveStorageResult | General | Zapisz | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ScannerParams | ScannerParamsPage | Parametry zapisu załączników | 100 | Soneta.Business.UI.dll | Soneta.Business |
| ScheduleDefinition | ScheduleDefinitionGeneral | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| SchedulerDataSource | Monthly | Miesięczny | 100 | Soneta.Net.Test.dll | Soneta.Net |
| SchedulerReservations | General | Kalendarz | 60 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| SchedulerWypozyczen | General | Kalendarz wypożyczeń | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| SchedulerZlecen | Ogolne | Kalendarz zleceń | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| SchemOpakowan | SchematOpakowan | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Towary |
| SchemOpakowan | SchemOpakowanTowary | Towary | 3 | Soneta.Handel.UI.dll | Soneta.Towary |
| SchemOpakowan | SchematGratisowPrzeceny | Przeceny | 4 | Soneta.Handel.UI.dll | Soneta.Towary |
| SchematKsiegowy | SchematKsiegowyPodstawowy | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematKsiegowy | SchematKsiegowyZaawansowane | Zaawansowane | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematKsiegowy | Compiler | Kompilator | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematKsiegowy | SchematKsiegowyWeryfikacja | Weryfikacja | 300 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematKsiegowy-ItemsCollection | ItemsCollectionOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematPodz | SchematPodzOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematPodz | SchematPodzKalk | Kalkulator schematu | 20 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematPodzElem | SchematPodzElemOgolne | Ogólne | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematPodzElem | SchematPodzElemPodzielnikKalkProp | Właściwości kalkulatora podzielnika | 20 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematPodzElem | SchematPodzElemPodzielnikKalkCode | Kod kalkulatora podzielnika | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematPodzElem | SchematPodzElemKluczKalkProp | Właściwości kalkulatora dla klucza | 40 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematPodzElem | SchematPodzElemKluczKalkCode | Kod kalkulatora dla klucza | 50 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematPodzElem | SchematPodzElemFeatures | Uzupełnianie cech | 60 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematTowar | SchematTowar | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Towary |
| SchematyPodz | SchematyPodz | Podzielniki/Schematy podziałowe | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SchematyPodzDeklaracje | SchematyPodzDeklaracje | Podzielniki/Schematy podziałowe dla deklaracji | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Schorzenie | Schorzenie | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Scianka | General | Ścianka | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| SecondTestObject | General | Drugi testowy | 100 | Soneta.Business.UI.dll | Soneta.Business |
| SecondWizard | FirstStep | DRUGI - Krok pierwszy | 1 | Soneta.Business.UI.dll | Soneta.Business |
| SelectFolderDataSource | General | Ogólne | 100 | Soneta.Business.UI.dll | Soneta.Business |
| SelectPlugInItemsTreeWorker | General | Wybierz wtyczki | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| SelectPlugInsWorker | General | Wybierz wtyczki | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| SelectQueryItemType | SelectQueryItemTypeOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SelectRowsCommand | Ogolne | Wybierz | 100 | Soneta.Core.UI.dll | Soneta.Core |
| SelectWizardParams | General |  | 100 | Soneta.Business.UI.dll | Soneta.Business |
| SendToAnalyzeWizard | InitializationStep | Potwierdzenie przekazania | 10 | Soneta.Core.dll | Soneta.Core |
| SendToAnalyzeWizard | FinalizationStep | Definicje zakresów serwisowych | 20 | Soneta.Core.dll | Soneta.Core |
| SendToObfuscationWizard | InitializationStep | Potwierdzenie przekazania | 10 | Soneta.Core.dll | Soneta.Core |
| SeriaDni | SeriaDni | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| SeriaDni | SeriaDniNet | Pulpity | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| SerialFilterSets | SerialFilterSets | BI/Utrwalanie danych/Zestawy filtrów utrwalania list | 1231 | Soneta.BI.UI.dll | Soneta.BI |
| SerialModelDefs | SerialModelDefs | BI/Utrwalanie danych/Definicje utrwalania modeli | 1220 | Soneta.BI.UI.dll | Soneta.BI |
| SerialViewDefs | SerialViewDefs | BI/Utrwalanie danych/Definicje utrwalania list | 1230 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationDefinition | SerializationDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationFromDashboardItemParam | Param1 | Metoda tworzenia danych | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationFromDashboardItemParam | Param1b | Parametry | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationFromDashboardItemParam | Param2 | Infrastruktura utrwalania | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationFromDashboardItemParam | Param3 | Definicje modeli danych | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationFromDashboardItemParam | Param4 | Definicja wizualizacji | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationFromDashboardItemParam | Param5 | Podsumowanie | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationFromDataModelParam | Param1 | Parametry | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationFromDataModelParam | Param2 | Infrastruktura utrwalania | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationFromDataModelParam | Param3 | Definicja tabeli | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationFromDataModelParam | Param4 | Podsumowanie | 1 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewCreatorParams | Params | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewDefinition | SerializationViewDefinitionOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewDefinition | SerializationViewDefinitionRanges | Zakresy utrwalania | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewDefinition | SerializationViewDefinitionTable | Definicja tabeli | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewFilter | SerializationViewFilterOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewFilterSet | SerializationViewFilterSetOgolne | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewFilterSetParams | Params | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewManager | SerializationViewDefinitions | Definicje utrwalania listy | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewManager | SerializationViewFilterSets | Zestawy filtrów listy | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewParams | Params | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewParamsWithSet | Params | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializationViewUpdateParams | Params | Ogólne | 100 | Soneta.BI.UI.dll | Soneta.BI |
| SerializeDefs | SerializeDefs | BI/Utrwalanie danych/Definicje utrwalania | 1210 | Soneta.BI.UI.dll | Soneta.BI |
| SerializeWFDefinitionWorker-WorkerParams | Eksport | Zapisz definicję procesu do pliku | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| SerwisBankowy | SerwisBankowy | Ogólne | 10 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| SerwisBankowy | Parametry | Parametry | 201 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| SettingsSubreports | SettingsSubreports | Raportowanie/REPX/Konfiguracja | 401 | Soneta.Business.Forms.dll | Soneta.Business |
| SimpleWizardDefinedCreatorParams | DefinicjaZakladkiUzytkownika | Zakładka użytkownika | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| SimpleWizardListCreatorParams | DefinicjaListy | Zakładka z listą obiektów | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| SkalaOcen | Ogólne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| SkalaOcen | Opis | Opis | 20 | Soneta.Core.UI.dll | Soneta.Core |
| SkaleOcen | SkaleOcen | CRM/Oceny/Skale ocen | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| SkaleOcenHR | SkaleOcenHR | Kadry i płace/Oceny/Skale ocen | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| SkanerKodow | Ogolne | Skaner kodów | 10 | Soneta.Core.UI.dll | Soneta.Core |
| SkanerKodow | Operatorzy | Operatorzy | 20 | Soneta.Core.UI.dll | Soneta.Core |
| SkaneryKodow | SkaneryKodow | Systemowe/Skanery kodów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Skladka | SkladkaOgolne | Ogólne | 100 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Skladka | SkladkaPlatnosci | Płatności | 100 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| SkladkaEwidencja | Ogolne | Ogólne | 0 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| SkladkiPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| SkladnikiProduktuWorker-SkladnikiProduktu | Ogolne | Składniki produktu | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| SlownikElem | PrzelewUS | Symbol formularza przelewu do US | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| SlownikPIM | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| SmsConfig | SmsConfig | Systemowe/Bramka SMS | 100 | Soneta.Core.UI.dll | Soneta.Core |
| SmsParamBase | SmsParams | Wyślij sms | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| SmsRecipientSelector | General | Odbiorcy SMS | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| SnippetDotxFileParams | General | Utwórz ze standardowego | 0 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| SnippetFile | General | Ogólne | 100 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| SnippetFileParams | General | Utwórz ze standardowego | 0 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| Snippets | Snippets | Raportowanie/Snippet-y | 506 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| SplitElementParams | General | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SposobZaplaty | SposobZaplaty | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| SposobyZaplaty | SposobyZaplaty | Ewidencje ŚP/Sposoby zapłaty | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| SprawaWindykacyjna | Ogolne | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| SprawaWindykacyjna | Historia | Historia | 50 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| SprawaWindykacyjna | WiadomosciPowiazaneWindykacji | CRM/Wiadomości email | 2000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| SprawdzZnacznikiJPKWorker | BledneKonta | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Sprawozdania | Sprawozdania | Księgowość/Sprawozdania finansowe | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprawozdanieKS | Ogolne | Ogólne | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprawozdanieKS | JednostkiSprawozdania | Jednostki powiązane | 15 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprawozdanieKS | Wprowadzenie | Wprowadzenie | 20 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprawozdanieKS | Zasady | Zasady rachunkowości | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprawozdanieKS | Wyniki | Wyniki zestawień | 40 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprawozdanieKS | Objasnienia | Objaśnienia | 50 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprawozdanieKS | Xml | e-Sprawozdanie | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprawozdanieKS | Signatures | e-Podpisy | 110 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprzedazEwidencja | HandlowyBudzetEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprzedazEwidencja | PulpitKBR | Dokument sprzedaży | 0 | Soneta.EI.UI.dll | Soneta.EI |
| SprzedazEwidencja | SprzedazEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprzedazEwidencja | Naleznosci | Dane kontrahenta i płatności | 4 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprzedazEwidencja-SprzedazEwidencjaDefDok | DefinicjaVATEwidencja | Rozszerzenie definicji VAT | 101 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprzedazZbiorczaEwidencja | SprzedazEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprzedazZbiorczaEwidencja | SprzedazZbiorczaEwidencjaDokumenty | Dokumenty | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SprzedazZbiorczaEwidencja | SprzedazZbiorczaEwidencjaPlatnosci | Płatności | 4 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SqlDatabase | TeleKey | TeleKlucz | 100 | Soneta.Business.UI.dll | Soneta.Business |
| SqlDatabase | Batch | Operacje wsadowe | 1000 | Soneta.Business.UI.dll | Soneta.Business |
| SrodekTrwalyBaseHistoria | SrodekTrwalyOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyAmortyzacja | Amortyzacja | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalySezonowosc | Sezonowość | 20 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyPlanAmortyzacji | Plan amortyzacji | 30 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyWyjatkiPlanuAmortyzacji | Wyjątki planu amortyzacji | 31 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyJPKInfo | JPK info | 35 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyDokumenty | Dokumenty | 40 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyObroty | Obroty | 40 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyLeasingOgolne | Leasing - ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyLeasingOgolneMSR | Leasing - ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyLeasingHarmonogram | Leasing - harmonogram | 105 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyTerminarz | Terminarz, wycena, kody kreskowe | 110 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyPodzielniki | Podzielniki kosztów | 199 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyBO | BO | 200 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyPodatekOdNieruchomosci | Podatek od nieruchomości | 210 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyZarzadzanieNieruchomosciami | Powiązania | 220 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | SrodekTrwalyPrawaDanych | Prawa danych | 300 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyBaseHistoria | RowHistory | Historia zapisów | 999 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodekTrwalyLeasingHarmonogramExtender-Params | Ogolne | Wybierz plik | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SrodkiTrwaleEwidencja | SrodkiTrwaleEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| StanKoresp | StanKorespOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| StanLeada | StanLeadaOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| StanMagazynuInfo | StanMagazynuInfo | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| StanNieruchomosci | Ogolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| StanPlanu | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| StanProjektu | StanyProjektuOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| StanTransakcji | StanTransakcjiOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| StanWindykacji | Algorytm | Algorytm | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| StanWindykacji | StanWindykacji | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| StanZadania | StanyZadaniaOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| StanowiskaZDrukarka | Stanowiska | Stanowiska | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| StanowiskaZTerminalem | Stanowiska | Stanowiska | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| StanowiskoPracy | General | Ogólne | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| StanowiskoPracy | ReleatedAssets | Elementy wyposażenia | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| StanyMagazynoweWiekowanieKrotkieWgTowMagParams | Params | Stany Magazynowe Wiekowanie Krotkie Wg Tow Mag | 100 | Soneta.Handel.Reports.dll | Soneta.Handel |
| StanyMagazynoweWiekowanieKrotkieWgTowParams | Params | Stany Magazynowe Wiekowanie Krotkie Wg Tow | 100 | Soneta.Handel.Reports.dll | Soneta.Handel |
| StanyMagazynoweWiekowanieWgTowMagParams | Params | Stany MagazynoweWiekowanie Wg Tow Mag | 100 | Soneta.Handel.Reports.dll | Soneta.Handel |
| StanyMagazynoweWiekowanieWgTowParams | Params | Stany Magazynowe Wiekowanie Wg Tow | 100 | Soneta.Handel.Reports.dll | Soneta.Handel |
| StanyPlanow | StanyPlanow | CRM/Plany sprzedażowe/Stany planów | 200 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| StanyWindykacji | StanyWindykacji | Ewidencje ŚP/Windykacja/Definicje etapów | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| StartDiscussionParams | General | Rozpoczęcie dyskusji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| StartFolder | General | Start | 100 | Soneta.Business.UI.dll | Soneta.Business |
| StawkaDelegacji | CfgStawkaDelegacji | Ogólne | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| Step1 | Ogolne | Krok ogólne | 5 | Soneta.Business.Forms.dll | Soneta.Business |
| Step1 | Ogolne2 | Pierwszy widoczny | 100 | Soneta.Business.Forms.dll | Soneta.Business |
| Step2 | Ogolne |  | 10 | Soneta.Business.Forms.dll | Soneta.Business |
| Step2 | Ogolne2 |  | 20 | Soneta.Business.Forms.dll | Soneta.Business |
| StopienOdpowiedzialnosci | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| StopwatchWindow | ZadanieHost | Zadania Pracy Hybrydowej | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| StorageFiles | General | Pliki konfiguracyjne | 10 | Soneta.Business.UI.dll | Soneta.Business |
| StorageFiles | StorageFiles | Systemowe/Pliki | 100 | Soneta.Business.UI.dll | Soneta.Business |
| StorageFilesList | General | Zapis pliku do bazy | 10 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| StornoElementu | StornoElementu | Storno | 110 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| StrefaDnia | StrefaDnia | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| StrefaKalendarza | StrefaDnia | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| StrefaPracy | StrefaDniaPracy | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| StrefaZestawienia | StrefaZestawienia | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Structure | General | General | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| StrukturaFirmy | StrukturaFirmy | Firma/Struktura firmy | 100 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturaFirmyDiagram | StrukturaFirmyDiagram | Firma/Struktura firmy - diagram | 100 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturaFirmyZKL | StrukturaFirmyZKL | ZKL/Schemat organizacyjny | 101 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturaFirmyZKLSystem | Schemat | ZKL/Schemat organizacyjny | 101 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturaHR | Ogolne | Kartoteki pracowników | 10000 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| StrukturaOrganizacyjna | StrukturaOrganizacyjna | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturaOrganizacyjna | StrukturaOrganizacyjnaDefinicjeElementow | Definicje elementów | 20 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturaOrganizacyjna | StrukturaOrganizacyjnaElementy | Elementy | 30 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturaOrganizacyjna | StrukturaOrganizacyjnaAlgorytm | Algorytm | 100 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturaOrganizacyjna | ElementCode | Konfiguracja elementów/Algorytm | 200 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturaOrganizacyjna | ElementConfig | Konfiguracja elementów/Użytkownika | 200 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturyFolder | Diagram | Diagram Folder | 100 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturyFolder | Ogolne | Struktury | 100 | Soneta.Core.UI.dll | Soneta.Core |
| StrukturyOrg | StrukturyOrg | Ogólne/Struktury organizacyjne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Stylesheets | Stylesheets | Raportowanie/REPX/Arkusze stylów | 500 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| SubTileListDesigner | General |  | 100 | Soneta.Business.UI.dll | Soneta.Business |
| SubreportItem | General | Podraport | 100 | Soneta.Business.UI.DxReports.dll | Soneta.Business |
| SubstituteDef | General | Ogólne | 0 | Soneta.Core.UI.dll | Soneta.Core |
| SubstituteDefs | SubstituteDefs | Ogólne/Definicje zastępstw | 2000 | Soneta.Core.UI.dll | Soneta.Core |
| SubstituteUser | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| SupportGeneral | SupportGeneral | Pulpity/Pulpit kontrahenta/ServiceDesk/Ogólne | 9 | Soneta.Support.UI.dll | Soneta.Support |
| SwiadczSocjalne | SwiadczenieSocjalne | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| SysNotification | General | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| SysNotification | References | Powiązane procesy | 10 | Soneta.Business.UI.dll | Soneta.Business |
| SysNotification | SysNotification | Powiadomienia | 100 | Soneta.Business.UI.dll | Soneta.Business |
| SysNotificationMessageDetails | Ogolne | Ogólne | 1 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| SysNotificationRef | General | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| SysNotifications | SysNotifications | Workflow/Powiadomienia | 100 | Soneta.Business.UI.dll | Soneta.Business |
| SysZewToken | SysZewToken | Autoryzacja | 100 | Soneta.Core.UI.dll | Soneta.Core |
| SysZewnImpDef | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| SysZewnInDBWorkerParams | Params | Ogólne | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| SystemBDOParams | Params | Parametry | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemITJezykProgramowania | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| SystemRole | General | Ogólne | 10 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRole | Licences | Wymagane licencje | 20 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRole | Rights | Prawa | 30 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRole | Folders | Foldery | 40 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRole | Options | Opcje | 50 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRole | Others | Pozostałe | 60 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRole | ObjectRightsRights | Prawa do danych | 80 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRole | Entitles | Uprawnienia operatorów | 90 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRole | RoleText | Rola | 98 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRole | EffectiveRoleText | Rola efektywna | 99 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRole | CatRolRelations | Kategorie roli | 100 | Soneta.Business.UI.dll | Soneta.Business |
| SystemRoles | SystemRoles | Systemowe/Uprawnienia/Role systemowe | 100 | Soneta.Business.UI.dll | Soneta.Business |
| SystemSettings | SystemSettings | Systemowe/Ustawienia | 100 | SonetaExplorer.dll | SonetaExplorer.Config |
| SystemZewn | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| SystemZewn | Tokeny | Autoryzacje | 10 | Soneta.Core.UI.dll | Soneta.Core |
| SystemZewn | SystemZewnDokumenty | Dokumenty | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewn | SystemZewnDostawa | Dostawa i płatności | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewn | SystemZewnMagazyny | Magazyny | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewn | DefinicjeDokumentowStan | Definicje synchronizacji stanu magazynowego | 70 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewn | PobieranieDanych | Pobieranie danych | 80 | Soneta.Core.UI.dll | Soneta.Core |
| SystemZewn | UdostepnianieDanych | Udostępnianie danych | 90 | Soneta.Core.UI.dll | Soneta.Core |
| SystemZewn | BDOKontrahenci | Kontrahenci | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewn | BDOLokalizacje | Lokalizacje | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewn | ZadaniaSynchronizacji | Zadania synchronizacji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| SystemZewnESklep | ESklepTowary | Towary | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnESklep | ESklepCechyTowaru | Cechy towaru | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnPlatformaIntegracyjna | PlatformaIntegracyjnaTowary | Towary | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnPlatformaIntegracyjna | PlatformaIntegracyjnaCeny | Ceny | 15 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnPlatformaIntegracyjna | PlatformaIntegracyjnaGrupyCenowe | Grupy cenowe i katalogi | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnPlatformaIntegracyjna | PlatformaIntegracyjnaCechyTowaru | Cechy towaru | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnPlatformaIntegracyjna | PlatformaIntegracyjnaCechyDokumentow | Cechy dokumentów | 40 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnPlatformaIntegracyjna | PlatformaIntegracyjnaESklepy | e-Sklepy | 50 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnPlatformaIntegracyjna | PlatformaIntegracyjnaSpedytorzy | Spedytorzy | 60 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnSerwisAukcyjny | SerwisAukcyjnyKategorie | Towary | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnSerwisAukcyjny | SerwisAukcyjnyDokumenty | Dokumenty | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnSerwisAukcyjny | SerwisAukcyjnyDostawa | Dostawa | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnSpedytor | SpedytorUslugiDodatkowe | Paczki i usługi | 200 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnWMS | WMSTowary | Towary | 50 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnWMS | WMSKontrahenci | Kontrahenci | 55 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| SystemZewnWMS | WMSDokumenty | Dokumenty | 60 | Soneta.Handel.UI.dll | Soneta.Handel |
| SystemZewnWMS | DefinicjeDokumentow | Definicje dokumentów | 70 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| SystemZewnWMS | WMSMagazyny | Magazyny | 80 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| SystemoweSystemyZewn | SystemoweSystemyZewn | Systemy zewnętrzne/Wszystkie | 100 | Soneta.Core.UI.dll | Soneta.Core |
| SystemyPUESC | SystemyPUESC | Systemy zewnętrzne/PUESC | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| SzablonEmail | Ogolne | Ogólne | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| SzablonPIM | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| SzablonSlownikaPIM | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| SzablonSms | Ogolne | Ogólne | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| SzkOsobyPodpisy | SzkOsobyPodpisy | Szkolenia/Osoby podpisujące | 55 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| SzkolenieBHP | SzkolenieBHP | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| TabelaKursowa | TabelaKursowaOgolne | Ogólne | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| TabelaKursowa | TabelaNotowanie | Notowania | 2 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| TabelaKursowa | TabelaKursowaKalkulator | Kalkulator walutowy | 99 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| TabeleKursowe | TabeleKursowe | Ewidencje ŚP/Tabele kursowe | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| TableDefinition | TableDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| TableDefinition | TableDefinitionRelationship | Relacje | 1000 | Soneta.BI.UI.dll | Soneta.BI |
| TableDefinition | TableDefinitionVisualizations | Wizualizacje | 1100 | Soneta.BI.UI.dll | Soneta.BI |
| TableDesigner | Fields | Kolumny | 1 | Soneta.Business.UI.dll | Soneta.Business |
| TableDesigner | Groups | Grupy | 50 | Soneta.Business.UI.dll | Soneta.Business |
| TableDesigner | Appearances | Kolory | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TableDesigner | Conditions | Warunki filtrowania | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TableDesigner | Filters | Filtry | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TableDesigner | Locator | Lokator | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TableDesigner | OrderBy | Kolejność | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TableDesigner | Preview | Podgląd | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TableDesigner | Settings | Ustawienia | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TableDesigner | Storage | Kontekst konfiguracji | 1000 | Soneta.Business.UI.dll | Soneta.Business |
| TableDesigner | XML | FORM.XML | 1000 | Soneta.Business.UI.dll | Soneta.Business |
| Task | TaskGeneral | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| Task | FlowErrors | Błędy przetwarzania | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinition | ExtendGeneral | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinition | ProcessStructure | Struktura procesu | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinition | TaskDefinitionGeneral | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionSettings | Ustawienia | 1 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionWorkflowSettings | Element definicji procesu | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinition | TaskDefinitionTimeSettings | Ustawienia czasów | 2 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionRealised | Realizacja | 8 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionIsEnable | Generowanie | 10 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionActive | Aktywność | 20 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionAction | Akcja | 40 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionOtherMethods | Inne metody | 50 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionGetParentAlgorithmForAutoAction | Algorytm wyboru wiersza | 51 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionTriggers | Wyzwalanie zadań | 55 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionEmail | Definicja poczty | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionEmailContentHTML | Treść HTML | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionStart | Start | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionSysNotifications | Workflow/Powiadomienia | 99996 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinition | TaskDefinitionWFTransitions | Workflow/Definicje elementów tranzycji | 99996 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinition | TaskDefinitionGetParentAlgorithm | Workflow/Algorytm wyboru wiersza | 99997 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinition | TaskDefinitionInitTaskPropertiesAlgorithm | Workflow/Algorytm inicjacji zadania | 99997 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinition | TaskDefinitionGetManagingRowAlgorithm | Workflow/Algorytm wyboru wiersza zarządzającego | 99998 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinition | TaskDefinitionGetTaskUsers | Workflow/Algorytm wyboru operatorów | 99998 | Soneta.Business.UI.dll | Soneta.Business |
| TaskDefinition | TaskDefinitionAllowAttachmentSigningAlgorithm | Workflow/Algorytm pozwól podpisać załącznik ReadOnly | 99999 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinition | TaskDefinitionRecipientsList | Workflow/Lista odbiorców | 99999 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinitionParameters | General | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskDefinitions | TaskDefinitions | Systemowe/Definicje zadań | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TaskHistoryInProcess | General | Historia procesu | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TaskHistoryRel | TaskHistory | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| TaskInvokeLogHistoryWorker | List | Historia wywołań | 100 | Soneta.Core.UI.dll | Soneta.Core |
| TaskQueryContextManager | General |  | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskTrigger | Advanced | Ogólne | -1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskTrigger | ProcessStructure | Struktura procesu | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TaskTrigger | TaskTriggersGeneral | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| TaxFreeExportParams | Params | Eksport | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| Team | Team | Operatorzy zespołu | 10 | Soneta.Support.UI.dll | Soneta.Support |
| Teams | Team | Pulpity/Pulpit kontrahenta/ServiceDesk/Zespoly | 111 | Soneta.Support.UI.dll | Soneta.Support |
| TechInspection | General | Ogólne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| Technologia | Technologia | Koszt wytworzenia | 100 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Technologia | Technologia | Technologia | 100 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| Technologia | TechnologiaOgolne | Technologia | 1000 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| Technologia | TechnologiaDokumenty | Dokumenty | 1005 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| TechnologiaBilansSurowcowWorker-TechnologiaBilansSurowcowParams | Ogolne | Parametry | 100 | Soneta.Handel.UI.dll | Soneta.Handel |
| TechnologiaBilansSurowcowWorker-TechnologiaBilansSurowcowRezultat | Surowce | Surowce | 1002 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| TechnologiaMigracjaWorker | Operacje | Operacje | 200 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| TechnologiaMigracjaWorker | Materialy | Materiały | 300 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| TechnologiaMigracjaWorker | Zasoby | Zasoby | 400 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| TechnologiaMigracjaWorker | Uslugi | Usługi | 500 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| TechnologiaMigracjaWorker | Wyroby | Wyroby | 600 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| TechnologiaMigracjaWorker | Polprodukty | Półprodukty | 700 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| Teczka | TeczkaUzytkownika | {New TeczkaUzytkownikaExtender.NazwaZakladki} | 1 | Soneta.Core.UI.dll | Soneta.Core |
| Teczka | TeczkaElementy | Elementy | 10 | Soneta.Core.UI.dll | Soneta.Core |
| Teczka | TeczkaOgolne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| Teczka | TeczkaPrawa | Prawa | 20 | Soneta.Core.UI.dll | Soneta.Core |
| TeczkiPracownicze | TeczkiPracownicze | Kadry i płace/Kadry/Teczki pracownicze | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| TemperaturaLeada | Ogolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| TemperaturaTransakcji | Ogolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| TerminGwarancji | TerminGwarancji | Ogólne | 10 | Soneta.Business.Licence.dll | Soneta.Business |
| TerminalPlatniczy | Ogolne | Terminal płatniczy | 10 | Soneta.Handel.UI.dll | Soneta.Handel |
| TerminalPlatniczy | Operatorzy | Operatorzy | 20 | Soneta.Handel.UI.dll | Soneta.Handel |
| TerminalPlatniczy | Stanowiska | Stanowiska | 30 | Soneta.Handel.UI.dll | Soneta.Handel |
| TestDataSource | Editor | Edytory | 100 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | First | Pierwsza strona | 100 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | GridGroupTowary |  | 100 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | ChartBar | Chart bar | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | ContainerGroupGrid | Strona grid | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | ContainerLabelGrid | Strona grid | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | Grid | Strona grid | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | GridGroup |  | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | GridGroupSum |  | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | GridGroupSumDelayed |  | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | GridGroupSumNewLine |  | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | GridSelection | Strona grid | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | GridSum | Strona grid | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | GridWithEditor | Strona grid | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | GroupGrid | Strona grid | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | LabelGrid | Strona grid | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | Pivot | Strona pivot | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | PivotAgg | Aggregate pivot | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | PivotAppearance | Strona pivot appearance | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | PivotDate | Pivot by date | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | PivotEip | Strona pivot | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | PivotFixed | Fixed pivot | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | PropertiesMoreTree | Drzewo wielu właściwości | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | PropertiesMoreTreeFocused | Drzewo wielu właściwości | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestDataSource | PropertiesTree | Drzewo właściwości | 200 | Soneta.Net.Test.dll | Soneta.Net |
| TestObject | General | Obiekt testowy | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TestPivotGridWorker | TestPivotGrid | PivotGrid test | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TestPivotWorker | TestPivot | No to test | 100 | Soneta.Business.UI.dll | Soneta.Business |
| TestPivotWorker | TestPivotInc | Layout test | 100 | Soneta.Business.UI.dll | Soneta.Business |
| Testowy | Pierwsza |  | 100 | Soneta.Business.Test.dll | Soneta.Business |
| Testowy | Trzecia | Folder testowy | 100 | Soneta.Business.Test.dll | Soneta.Business |
| Testowy | Druga |  | 200 | Soneta.Business.Test.dll | Soneta.Business |
| TestujSchematWorker | Ogólne | Testuj schemat | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ThreadCategories | ThreadCategories | Ogólne/Kategorie komunikacji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ThreadCategory | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Ticket | Attachments | Załączniki | 10 | Soneta.Support.UI.dll | Soneta.Support |
| Ticket | HistoricalState | Historia zadania | 10 | Soneta.Support.UI.dll | Soneta.Support |
| Ticket | MainPage | Ogólne | 10 | Soneta.Support.UI.dll | Soneta.Support |
| Ticket | TimeTrack | Czas realizacji | 20 | Soneta.Support.UI.dll | Soneta.Support |
| Ticket | TicketFollowers | Obserwujący | 30 | Soneta.Support.UI.dll | Soneta.Support |
| TicketDefinition | General | Ogólne | 1 | Soneta.Support.UI.dll | Soneta.Support |
| TicketDefinition | EmailNotification | Email notifikacje | 10 | Soneta.Support.UI.dll | Soneta.Support |
| TicketDefinition | TicketState | Stany zgłoszenia | 10 | Soneta.Support.UI.dll | Soneta.Support |
| TicketDefinition | TicketPriority | Priorytety zgłoszenia | 30 | Soneta.Support.UI.dll | Soneta.Support |
| TicketDefinition | XmlFormOperator | Formularz Operatora | 40 | Soneta.Support.UI.dll | Soneta.Support |
| TicketDefinition | XmlFormClient | Formularz Klienta | 50 | Soneta.Support.UI.dll | Soneta.Support |
| TicketTypes | TicketDefinitions | Pulpity/Pulpit kontrahenta/ServiceDesk/Definicje ServiceDesk | 111 | Soneta.Support.UI.dll | Soneta.Support |
| TimeRecorderParams | TimeRecorderParams | Rejestracja czasu pracy | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TimeSpanDefinition | TimeSpanDefinitionOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| TimeSpanDefs | TimeSpanDefs | BI/Modele danych/Definicje przedziałów czasowych | 1120 | Soneta.BI.UI.dll | Soneta.BI |
| TimeSpanItem | TimeSpanItemOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| TimeSpanSet | TimeSpanSetOgolne | Ogólne | 1 | Soneta.BI.UI.dll | Soneta.BI |
| TimeSpanSets | TimeSpanSets | BI/Modele danych/Definicje zestawów przedziałów czasowych | 1130 | Soneta.BI.UI.dll | Soneta.BI |
| TimeTrack | TimeTrackOgolne | Edycja czasu pracy | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TimeTrack | TimeTrackNestedDbResources | Zasoby z podrzędnych baz | 12 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TimeTrack | TimeTrackResources | Powiązane zasoby | 12 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TotpAuthentication | TotpAuthentication | Ogólne | 100 | Soneta.Net.Business.dll | Soneta.Net |
| TotpRegistration | TotpRegistration | Ogólne | 100 | Soneta.Net.Business.dll | Soneta.Net |
| Towar | TowarUzytkownika | Użytkownika | 1 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | Ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Towar | Towar | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarBezCen | Ogólne (bez cen) | 10 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarKBN | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.KlientBiuraRachunkowego |
| Towar | TowarDodatkowe | Dodatkowe | 20 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPIMOgolne | PIM/E-commerce | 20 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPIMPowiazania | PIM/Synchronizacja | 25 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPIMSlowniki | PIM/Słowniki pól i cech | 26 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarJednostki | Jednostki i opakowania | 30 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarKody | Kody | 30 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPIMOpisy | PIM/Opisy | 30 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPIMZalaczniki | PIM/Załączniki | 30 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarCennikKontrahentow | Cennik/Kontrahentów | 40 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarZamowienia | Zamówienia | 40 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarWarianty | Warianty | 41 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarZamienniki | Zamienniki | 41 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarCennikGrupowy | Cennik/Grupowy | 50 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarRabatyKontrahentow | Cennik/Rabaty kontrahentów | 90 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPrzeceny | Cennik/Przeceny towaru | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarRabatyGrupowe | Cennik/Rabaty grupowe | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarRabatyOkresowe | Cennik/Rabaty okresowe | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarSkladnikKompletu | Składnik kompletu | 900 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | ProdukcjaZaawansowana | Produkcja zaawansowana | 990 | Soneta.ProdukcjaPro.UI.dll | Soneta.ProdukcjaPro |
| Towar | TowarKompletacja | Kompletacja | 990 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarReceptura | Kompletacja | 990 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarProdukcja | Produkcja | 991 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarZasoby | Magazyn/Zasoby | 1000 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarMarza | Magazyn/Marża | 1010 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarObroty | Magazyn/Obroty | 1020 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarGrupyDostaw | Magazyn/Partie | 1030 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarOpakowaniaBilansOgolny | Magazyn/Bilans obrotów | 1100 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarOpakowaniaBilansKontrahentow | Magazyn/Bilans dla kontrahentów | 1101 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPozycjeMagazynowe | Pozycje/Magazynowe | 2000 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPozycjeHandlowe | Pozycje/Handlowe | 2010 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPozycjeZamowien | Pozycje/Zamówień | 2020 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPozycjeOfert | Pozycje/Ofert | 2030 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPozycjeZlecenProd | Pozycje/Zleceń produkcyjnych | 2060 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarPozycjePozostale | Pozycje/Pozostałe | 2070 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar | TowarUzytkownikaNet | Użytkownika | 999999 | Soneta.Handel.UI.dll | Soneta.PulpitKontrahenta |
| Towar-PrzeliczCeneWorker-PrzeliczCeneWorkerParam | Params |  | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| Towar-PrzeliczCenyWorker-PrzeliczCenyParams | Params |  | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| TowarRealizacji | General | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TrainingGanttDiagram | General | GanttDiagram | 100 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Transakcja | TransakcjaUzytkownika | {New TransakcjaUzytkownikaExtender.NazwaZakladki} | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| Transakcja | TransakcjaBasic | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| Transakcja | TransakcjaOgolne | Ogólne | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| Transakcja | TransakcjaOpisHtml | Opis | 12 | Soneta.CRM.UI.dll | Soneta.CRM |
| Transakcja | TransakcjaDokumenty | Dokumenty | 40 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| Transakcja | TransakcjaZadania | Aktywności | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Transakcja | PodmiotyPowiazane | Podmioty powiązane | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| Transakcja | WiadomosciPowiazaneTransakcja | {New WiadomosciPowiazaneTransakcjaExtender.CaptionHtml} | 1000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TransferPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| TransitionsForTasksWorkerParams | General |  | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| TrescOswiadczenia | TrescOswiadczenia | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| TuplesDefinitions | TuplesDefinitions | Systemowe/Definicje dokumentów dodatkowych | 100 | Soneta.Core.UI.dll | Soneta.Core |
| TuplesListResult | Ogolne | Przygotowane dokumenty | 100 | Soneta.Core.UI.dll | Soneta.Core |
| TypBudowli | Ogolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypBudynku | TypBudynkuOgolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypDzialki | Ogolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypIdenPodPrzel | Ogolne | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| TypInstalacji | Ogolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypKondygnacji | Ogolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypLicznika | TypLicznikaOgolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypLokalu | Ogolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypMiejscaPostojowego | Ogolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypNieruchomosc | Stany | Stany | 20 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypNieruchomosc | Algorithm | Algorytm | 50 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypOplatyLeasing | Ogolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| TypOplatyMSR | TypOplatyMSROgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| TypParkingu | Ogolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypPomieszczenia | Ogolne | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypPotwierdzenia | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| TypUrzadzenia | TypUrzadzeniaOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TypZadania | TypyZadanOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TypyDzialalnosci | TypyDzialalnosci | Członkowie/Typy działalności | 120 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| TypyLicznikow | TypyLicznikow | Nieruchomości/Typy liczników | 80 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypyObiektow | TypyObiektow | Nieruchomości/Typy obiektów | 80 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypyParkingow | TypyParkingow | Flota/Typy parkingów | 80 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| TypyUrzadzenDefDok | TypyUrzadzenDefDok | CRM/Definicje dokumentów/Rodzaje urządzeń | 1000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TypyUrzadzenWypoz | TypyUrzadzenWypoz | Wypożyczenia/Rodzaje urządzeń | 80 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TypyUrzadzenZlecSerw | TypyUrzadzenZlecSerw | Zlecenia serwisowe/Rodzaje urządzeń | 80 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| TytulDokumentuST | TytulDokumentuSTOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| TytulZawodowyStopienNaukowy | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| TytulyZawodowe | TytulyZawodowe | Członkowie/Tytuły zawodowe | 130 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UIConfig | UIConfig | UI/Ustawienia interfejsu | 100 | Soneta.Business.UI.dll | Soneta.Business |
| UIExtension | Definicja | Ogólne | 2 | Soneta.Core.UI.dll | Soneta.Core |
| UIExtension | DefinicjaDodatkowegoNaglowka | Definicja | 2 | Soneta.Core.UI.dll | Soneta.Core |
| UIExtensionsData | NaglowkiStopki | Nagłówki i stopki | 2 | Soneta.Core.UI.dll | Soneta.Core |
| UIWinForms | UIWinForms | UI/Wersja okienkowa | 100 | Soneta.Business.UI.dll | Soneta.Business |
| UczFunkcja | UczFunkcjaOgolne | Funkcje z wyboru | 25 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikBase | UczestnikBaseDaneKnt | Dane kontaktowe | 15 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikBase | UczestnikBaseUwagi | Uwagi | 40 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikBase | UczestnikBaseZadania | Aktywności | 50 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikBase | UczestnikBaseGIODOOswiadczenia | Ochrona danych osobowych/Oświadczenia | 200000 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikBase | UczestnikBaseGIODOWymianaDanych | Ochrona danych osobowych/Wymiana danych | 200001 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikHist | CzlonekHistOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikSzkolenia | UczestnikSzkoleniaOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikSzkolenia | UczestnikSzkoleniaKwalifikacje | Kwalifikacje | 22 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikSzkolenia | UczestnikSzkoleniaCertyfikaty | Certyfikaty | 25 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikSzkolenia | UczestnikSzkoleniaOdznaczenia | Odznaczenia | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikSzkolenia | UczestnikSzkoleniaZgloszenia | Zgłoszenia | 50 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikSzkolenia | UczestnikSzkoleniaZajecia | Zajęcia | 60 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UczestnikSzkolenia | UczestnikSzkoleniaZajeciaKalend | Kalendarz zajęć | 61 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UkonczonaSzkola | UkonczonaSzkola | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UkonczonaSzkola | UkonczonaSzkolaOkresyNiewliczane | Okresy niewliczane do stażu pracy | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UkonczoneSzkolenie | UkonczoneSzkolenie | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaAPTHistoria | UmowaAPT | Ogólne | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaAPTHistoria | UmowaAPTNet | Ogólne | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaAPTHistoria | UmowaAPTInformacjeDoRozliczenia | Informacje do rozliczenia | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaAPTHistoria | UmowaAPTInformacjeDoRozliczeniaNet | Informacje do rozliczenia | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaAPTHistoria | UmowaAPTElementyRozliczone | Elementy rozliczone | 300 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaAPTHistoria | UmowaPodzielniki | Podzielniki kosztów | 400 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaAPTHistoria | RowHistory | Historia zapisów | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaB2BHistoria | UmowaB2B | Ogólne | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaB2BHistoria | UmowaB2BNet | Ogólne | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaB2BHistoria | UmowaB2BInformacjeDoRozliczenia | Informacje do rozliczenia | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaB2BHistoria | UmowaB2BInformacjeDoRozliczeniaNet | Informacje do rozliczenia | 200 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaB2BHistoria | UmowaB2BElementyRozliczone | Elementy rozliczone | 300 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaB2BHistoria | UmowaPodzielniki | Podzielniki kosztów | 400 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaB2BHistoria | RowHistory | Historia zapisów | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | Net | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | UmowaPlaceElementy | Elementy | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | UmowaPlaceWyplaty | Wypłaty | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | ZestawieniaPracyNet | Zestawienia realizacji | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | UmowaOgolne | Ogólne | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | UmowaZestawieniaPracy | Zestawienia realizacji | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | UmowaUbezpieczenie | Ubezpieczenie | 8 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | UmowaWyrejestrowanie | Wyrejestrowanie | 9 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | UmowaDodatki | Dodatki | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | UmowaVat | VAT | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | UmowaDodatkowe | Dodatkowe | 11 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | ElementyWynagrodzeniaHist | Elementy wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | RozliczenieWynagrodzenia | Rozliczenia wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | UmowaDeklaracje | Deklaracje | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| UmowaHistoria | UmowaPodzielniki | Podzielniki kosztów | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaHistoria | RowHistory | Historia zapisów | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaLeasingu | HarmonogramZbiorczy | Harmonogram zbiorczy | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| UmowaZewnetrznaHistoria | UmowaZestawieniaPracy | Zestawienia realizacji | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UmowaZewnetrznaHistoria | ZestawieniaPracyNet | Zestawienia realizacji | 5 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UniOAuth2Test | General | OAuthTest | 100 | Soneta.Business.UI.dll | Soneta.Business |
| UnifiedRegister | UnifiedRegisterClasses | Klasy wykazów akt | 200 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| UnifiedRegister | UnifiedRegister | DMS/Definicje wykazów akt | 600 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| UnifiedRegisterClass | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| UpdateBIConfigParams | Params |  | 100 | Soneta.BI.UI.dll | Soneta.BI |
| UpdateData | Ogolne | Aktualizacja danych | 10 | Soneta.Net.Business.dll | Soneta.Net |
| UpdateDocumentParamsDokHandlowy | UpdateDocumentParamsDokHandlowy | Parametry | 100 | Soneta.Core.UI.dll | Soneta.Core |
| UpdateDokumentEwidencjiParams | UpdateDokumentEwidencjiParams | Parametry | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| UprawnieniePracownika | UprawnieniePracownika | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UprawnieniePracownika | UprawnieniePracownikaZzl | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| UrzadCelny | UrzadCelny | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| UrzadCelny | UrzadCelnyKonta | Konta podatkowe | 3 | Soneta.CRM.UI.dll | Soneta.CRM |
| UrzadCelny | KontrahentDodatkowe | Warunki płatności | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| UrzadSkarbowy | UrzadSkarbowy | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| UrzadSkarbowy | UrzadSkarbowyKonta | Konta podatkowe | 3 | Soneta.CRM.UI.dll | Soneta.CRM |
| UrzadSkarbowy | KontrahentDodatkowe | Warunki płatności | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| UrzadSkarbowyCentrala | UrzadSkarbowyKonta | Konta podatkowe | 3 | Soneta.CRM.UI.dll | Soneta.CRM |
| Urzadzenie | UrzadzenieUzytkownika | {New UrzadzenieUzytkownikaExtender.NazwaZakladki} | 1 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieOgolnePK | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieInne | Inne | 15 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieInnePK | Inne | 15 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieSerwis | Serwis | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieSerwisPK | Serwis | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieZleceniaSerwisowe | Zlecenia serwisowe | 30 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieZleceniaSerwisowePK | Zlecenia serwisowe | 30 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieKodyKreskowe | Kody kreskowe | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzeniePlanowanePrzeglady | Planowane przeglądy | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzeniePlanowanePrzegladyPK | Planowane przeglądy | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieWypozyczenia | Wypożyczenia | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieWypozyczeniaPK | Wypożyczenia | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Urzadzenie | UrzadzenieKalendarz | Kalendarz | 60 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| UrzadzenieKopiujUrzadzenieWorker-Params | KopiujUrzadzenieParams |  | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| UrzadzenieUz | UrzadzenieOgolne | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| UrzadzenieUz | UrzadzeniePozycje | Pozycje dokumentów | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| UrzadzenieUzyte | UrzadzenieUzyte | Ogolne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| UrzadzenieUzyte | UrzadzenieUzytePK | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| UsedVehicle | General | Ogolne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| UserDashboard | General | General | 100 | Soneta.Business.UI.dll | Soneta.Business |
| UserDashboard | Organize | General | 100 | Soneta.Business.UI.dll | Soneta.Business |
| UserDashboards | UserDashboards | Pulpity/Pulpity użytkowników | 100 | Soneta.Business.UI.dll | Soneta.Business |
| UserGroup | General | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| UserGroup | Members | Członkowie | 2 | Soneta.Business.UI.dll | Soneta.Business |
| UserGroupMember | General | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| UserGroups | UserGroups | Systemowe/Uprawnienia/Grupy operatorów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| UserPasswordChanging | Ogolne | Zmiana hasła | 10 | Soneta.Business.dll | Soneta.Business |
| UserPasswordResetting | Ogolne | Ustawienie hasła | 10 | Soneta.Business.dll | Soneta.Business |
| UserProfileChanging | Ogolne | Profil użytkownika | 10 | Soneta.Business.dll | Soneta.Business |
| UsersSelector | General | Ogólne | 5 | Soneta.Core.UI.dll | Soneta.Core |
| UsersSelector | Operators | Operatorzy | 10 | Soneta.Core.UI.dll | Soneta.Core |
| UsersSelector | Employees | Pracownicy | 20 | Soneta.Core.UI.dll | Soneta.Core |
| UsersSelector | Groups | Grupy | 30 | Soneta.Core.UI.dll | Soneta.Core |
| UsersSelector | ContactPeoples | Osoby kontaktowe kontrahenta | 40 | Soneta.Core.UI.dll | Soneta.Core |
| UsersSelector | BusinessCards | Wizytówki | 50 | Soneta.Core.UI.dll | Soneta.Core |
| UsersSelector | Contractors | Kontrahenci | 60 | Soneta.Core.UI.dll | Soneta.Core |
| UslDodPrzesyl | Ogolne | Ogólne | 1 | Soneta.Handel.UI.dll | Soneta.Handel |
| UslugaNieruch | General | Ogólne | 10 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| UstawKategorieAllegroParams | Ogolne | Ustaw kategorię Allegro | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| UstawieniaOperatora | UstawieniaOperatora | Ewidencja dokumentów/Ustawienia operatora | 100 | Soneta.Core.UI.dll | Soneta.Core |
| UstawieniaOperatoraFiltry | UstawieniaOperatoraFiltry | Filtrowanie | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| UtworzDokumentResult | Ogolne | Ogólne | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| UtworzPlatnoscZZapisuBase-Helper | General | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| UtworzTransakcjeParams | UtworzTransakcjeParamsPage | Ogólne | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| UtworzZapotrzebowanieParams | Ogolne | Utwórz zapotrzebowanie | 100 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| UzgodnijDobePracowniczaResult | UzgodnijDobePracowniczaResult | Uzgodnij dobę pracowniczą | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| VAT27_1 | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT27_1 | C | Część C | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT27_1 | D | Część D | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT27_1 | E | Część E | 8 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT27_2 | Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT27_2 | C | Część C | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT27_2 | D | Część D | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT27_2 | E | Część E | 8 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7 | DeklaracjaZbiorczaVAT | Deklaracje cząstkowe | 200 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_10 | VAT7_10_1_ | Ogólne, C | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_10 | VAT7_10_2_ | C, D.1, D.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_10 | VAT7_10_3_ | D.3, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_10 | VAT7_10_4_ | F, G, H, Informacje księgowe | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_11 | VAT7_11_1_ | Ogólne, C | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_11 | VAT7_11_2_ | C, D.1, D.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_11 | VAT7_11_3_ | D.3, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_11 | VAT7_11_4_ | F, G, H, Informacje księgowe | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_12 | VAT7_12_1_ | Ogólne, C | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_12 | VAT7_12_2_ | C, D.1, D.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_12 | VAT7_12_3_ | D.3, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_12 | VAT7_12_4_ | F, G, H, Informacje księgowe | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_13 | VAT7_13_1_ | Ogólne, C | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_13 | VAT7_13_2_ | C, D.1, D.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_13 | VAT7_13_3_ | D.3, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_13 | VAT7_13_4_ | F, G, H, Informacje księgowe | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_14 | VAT7_14_1_ | Ogólne, C | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_14 | VAT7_14_2_ | C, D.1, D.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_14 | VAT7_14_3_ | D.3, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_14 | VAT7_14_4_ | F, G, H, Informacje księgowe | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_15 | VAT7_15_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_15 | VAT7_15_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_15 | VAT7_15_3 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_15 | VAT7_15_4 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_15 | VAT7_15_5 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_15 | VAT7_15_6 | Informacje księgowe | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_16 | VAT7_16_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_16 | VAT7_16_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_16 | VAT7_16_3 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_16 | VAT7_16_4 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_16 | VAT7_16_5 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_16 | VAT7_16_6 | Informacje księgowe | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_17 | VAT7_17_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_17 | VAT7_17_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_17 | VAT7_17_3 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_17 | VAT7_17_4 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_17 | VAT7_17_5 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_17 | VAT7_17_6 | Informacje księgowe | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_17_InfoParams | Params | Params | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_18 | VAT7_18_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_18 | VAT7_18_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_18 | VAT7_18_3 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_18 | VAT7_18_4 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_18 | VAT7_18_5 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_18 | VAT7_18_6 | Informacje księgowe | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_19 | VAT7_19_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_19 | VAT7_19_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_19 | VAT7_19_3 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_19 | VAT7_19_4 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_19 | VAT7_19_5 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_19 | VAT7_19_6 | Informacje księgowe | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_20 | VAT7_20_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_20 | VAT7_20_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_20 | VAT7_20_3 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_20 | VAT7_20_4 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_20 | VAT7_20_5 | F, G, H | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_20 | VAT7_20_6 | Informacje księgowe | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_21 | VAT7_21_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_21 | VAT7_21_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_21 | VAT7_21_3 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_21 | VAT7_21_4 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_21 | VAT7_21_5 | F | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_21 | VAT7_21_6 | Informacje księgowe | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_21_InfoParams | Params | Params | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_22 | VAT7_22_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_22 | VAT7_22_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_22 | VAT7_22_3 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_22 | VAT7_22_4 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_22 | VAT7_22_5 | F | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_22 | VAT7_22_6 | Informacje księgowe | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_22 | VAT7_22_7 | Parametry rozliczeń | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_22-ParametrRozliczen | Ogolne | Parametr rozliczeń | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_23 | VAT7_23_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_23 | VAT7_23_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_23 | VAT7_23_3 | D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_23 | VAT7_23_4 | E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_23 | VAT7_23_5 | F | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_23 | VAT7_23_6 | Informacje księgowe | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_23 | VAT7_23_7 | Parametry rozliczeń | 6 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_23-ParametrRozliczen_23 | Ogolne | Parametr rozliczeń | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_7 | VAT7 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_7 | VAT7Dane | Dane wejściowe | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_8 | VAT7_8_1_ | Ogólne, C.1 | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_8 | VAT7_8_2_ | C.2, C.3, D.1, D.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_8 | VAT7_8_3_ | D.3, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_8 | VAT7_8_4_ | F, G, H, Informacje księgowe | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_9 | VAT7_9_1_ | Ogólne, C | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_9 | VAT7_9_2_ | C, D.1, D.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_9 | VAT7_9_3_ | D.3, E | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT7_9 | VAT7_9_4_ | F, G, H, Informacje księgowe | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT8_11 | Page_A | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT8_11 | Page_C | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT8_11 | Page_DE | D, E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT8_12 | Page_A | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT8_12 | Page_C | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT8_12 | Page_DE | D, E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_10 | VAT9M_10_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_10 | VAT9M_10_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_10 | VAT9M_10_3 | D, E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_10_InfoParams | Params | Params | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_11 | VAT9M_11_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_11 | VAT9M_11_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_11 | VAT9M_11_3 | D, E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_11_InfoParams | Params | Params | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_8 | VAT9M_8_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_8 | VAT9M_8_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_8 | VAT9M_8_3 | D, E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_8_InfoParams | Params | Params | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_9 | VAT9M_9_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_9 | VAT9M_9_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_9 | VAT9M_9_3 | D, E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VAT9M_9_InfoParams | Params | Params | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATEwidencja | EwidencjaVATEwidencja | VAT | 2 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| VATEwidencja | EwidencjaVATDodatkowe | Dodatkowe-VAT | 3 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| VATMarzaEwidencja | WyplataUmowyEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| VATMarzaEwidencja | PodmiotEwidencjaDane | Dane kontrahenta | 4 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| VATUEA_1 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_1 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_1 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_1 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_2 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_2 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_2 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_2 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_3 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_3 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_3 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_3 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_4 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_4 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_4 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_4 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_5 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_5 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_5 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEA_5 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_1 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_1 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_1 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_1 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_2 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_2 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_2 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_2 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_3 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_3 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_3 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_3 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_4 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_4 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_4 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_4 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_5 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_5 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_5 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEB_5 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEBase | VATUE | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_1 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_1 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_1 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_1 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_2 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_2 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_2 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_2 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_4 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_4 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_4 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_4 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_5 | VATUEAB_1_1_ | Część B/1 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_5 | VATUEAB_1_2_ | Część B/2 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_5 | VATUEAB_1_3_ | Część B/3 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEC_5 | VATUEAB_1_4_ | Część B/4 | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_1 | VATUE_1_CKorekta_ | Korekta część C | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_1 | VATUE_1_DKorekta_ | Korekta część D | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_2 | VATUE_2_CKorekta_ | Korekta część C | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_2 | VATUE_2_DKorekta_ | Korekta część D | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_2 | VATUE_2_EKorekta_ | Korekta część E | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_3 | VATUE_3_CKorekta_ | Korekta część C | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_3 | VATUE_3_DKorekta_ | Korekta część D | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_3 | VATUE_3_EKorekta_ | Korekta część E | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_4 | VATUE_4_CKorekta_ | Korekta część C | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_4 | VATUE_4_DKorekta_ | Korekta część D | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_4 | VATUE_4_EKorekta_ | Korekta część E | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_5 | VATUE_5_CKorekta_ | Korekta część C | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_5 | VATUE_5_DKorekta_ | Korekta część D | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_5 | VATUE_5_EKorekta_ | Korekta część E | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUEK_5 | VATUE_5_FKorekta_ | Korekta część F | 5 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUES | VATUES | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUES_1 | VATUES_1 | Część F | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_1 | VATUE_1_1_ | Część C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_1 | VATUE_1_2_ | Część D, E, F | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_2 | VATUE_2_1_ | Część C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_2 | VATUE_2_2_ | Część D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_2 | VATUE_2_3_ | Część E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_2 | VATUE_2_4_ | Część F, G | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_3 | VATUE_3_1_ | Część C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_3 | VATUE_3_2_ | Część D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_3 | VATUE_3_3_ | Część E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_3 | VATUE_3_4_ | Część F, G | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_4 | VATUE_4_1_ | Część C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_4 | VATUE_4_2_ | Część D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_4 | VATUE_4_3_ | Część E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_4 | VATUE_4_4_ | Część F, G | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_5 | VATUE_5_1_ | Część C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_5 | VATUE_5_2_ | Część D | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_5 | VATUE_5_3_ | Część E | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_5 | VATUE_5_4_ | Część G | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATUE_5_ZestawienieParams | Params | Params | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VATZD_1 | VATZD_1_1_ | Część B | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VCFImportWorker-Params | VCFImportParams | Import wizytówek | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| VIIDO_1 | 1_Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIIDO_1 | 2_C2 | C.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIIDO_1 | 3_C3 | C.3 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIIDO_1 | 4_C4 | C.4, C.5 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIIDO_2 | 1_Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIIDO_2 | 2_C2 | C.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIIDO_2 | 3_C3 | C.3 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIIDO_2 | 4_C4 | C.4, C.5 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIUDO_1 | 1_Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIUDO_1 | 2_C2 | C.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIUDO_1 | 3_C3 | C.3, C.4 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIUDO_1 | 4_C5 | C.5 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIUDO_1 | 5_C6 | C.6, C.7 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIUDO_2 | 1_Ogolne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIUDO_2 | 2_C2 | C.2 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIUDO_2 | 3_C3 | C.3, C.4 | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIUDO_2 | 4_C5 | C.5 | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| VIUDO_2 | 5_C6 | C.6, C.7 | 3 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ValidationInfo | General | Błąd walidacji | 100 | Soneta.Core.UI.dll | Soneta.Core |
| VehicleHis | PojazdOgolne | Ogólne | 0 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | UserForm | {New VehicleUserFormExtender.NazwaZakladki} | 1 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | General | Ogólne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Reservations | Rezerwacje | 20 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Fleet | Zdarzenia | 30 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Inspections | Badania techniczne | 40 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Readings | Odczyty licznika | 50 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Insurances | Ubezpieczenia | 60 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Damages | Zgłoszone szkody | 70 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Fines | Mandaty | 80 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Assets | Powiązane Środki trwałe | 90 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | PojazdPaliwa | Paliwa | 95 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Services | Usługi | 100 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Calendar | Kalendarz | 110 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Documents | Dokumenty | 120 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | Attachements | Załączniki | 130 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleHis | History | Historia zmian | 140 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleReading | General | Ogólne | 40 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleService | General | Ogólne | 1 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleState | General | Ogólne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleTask | General | Ogólne | 11 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleTask | Vehicles | Pojazdy | 12 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleTask | RelatedTasks | Zdarzenia powiązane | 30 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleTask | Documents | Dokumenty | 50 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleType | VehicleTypeGeneral | Ogólne | 10 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleType | States | Stany | 20 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VehicleType | VehicleType | Flota/Typy pojazdów | 80 | Soneta.Vehicles.UI.dll | Soneta.Vehicles |
| VisualizationParams | Params |  | 100 | Soneta.BI.Reports.dll | Soneta.BI |
| VoivodeshipRegion | Obszary | Obszary | 10 | Soneta.CRM.UI.dll | Soneta.CRM |
| WFDefItem | WFDefItemGeneral | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefItem | WFDefItemIcon | Ikona grafu | 2 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefItem | WFDefItemActionAlgorithm | Algorytmy/Metoda Action | 20 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefItem | WFDefItemIsEnableAlgorithm | Algorytmy/Metoda IsEnable | 21 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefItem | WFDefItemCalcNodeDescriptionAlgorithmEditor | Algorytmy/Opis węzła (edycja procesu) | 22 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefItem | WFDefItemCalcNodeDescriptionAlgorithmViewer | Algorytmy/Opis węzła (podgląd procesu) | 23 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefItemExtend | General | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefItemExtend | ProcessStructure | Struktura procesu | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefItems | WFDefItems | Workflow/Definicje/Wzorce definicji zadań | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefItemsExtend | WFDefItemsExtend | Workflow/Definicje jednozakładkowe/Wzorce definicji zadań | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinition | Subprocesses | Procesy powiązane | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinition | WFDefinitionGeneral | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinition | WFDefinitionProcess | Edytor procesu | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinition | TaskDefs | Definicje zadań | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinition | WFProcessRoles | Role procesowe | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinitionCopyWorker-WFDefinitionCopyWorkerParams | WFDefinitionCopyWorkerParams | Parametry kopiowania/nowej wersji definicji procesu | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinitionExportWorker-ExportParams | ExportParams | Parametry eksportu | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinitionExtend | WFDefinitionGeneral | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinitionExtend | ProcessStructure | Struktura procesu | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinitionExtend | Engine | Algorytm procesu | 200 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinitionExtend | DataCode | Algorytm danych dla procesu | 300 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFDefinitions | WFDefinitions | Workflow/Definicje procesów | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFItemDescription | General | Komentarz | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFProcessRole | General | Rola procesowa | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFProcessRole | WFProcessRoleRecipientsList | Lista odbiorców | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFProcessRoleExtend | Advaned | Rola procesowa | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFProcessRoleExtend | ProcessStructure | Struktura procesu | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFRecipient | WFRecipientGeneral | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransition | IsRealizedCode | Algorytmy/Weryfikacja przejścia | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransition | WFTransitionGeneral | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransition | IsReadOnlyCode | Algorytmy/Aktywność | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransition | IsVisibleCode | Algorytmy/Widoczność | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionDefinition | IsRealizedCode | Algorytmy/Weryfikacja przejścia | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionDefinition | WFTransitionDefinitionGeneral | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionDefinition | IsReadOnlyCode | Algorytmy/Aktywność | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionDefinition | IsVisibleCode | Algorytmy/Widoczność | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionDefinition | WFTransitionDefinitionWFTrasitions | Elementy tranzycji | 2 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionDefinitionExtend | General | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionDefinitionExtend | ProcessStructure | Struktura procesu | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionDefs | WFTransitionDefs | Workflow/Definicje/Wzorce tranzycji | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionDefsExtend | WFTransitionDefsExtend | Workflow/Definicje jednozakładkowe/Wzorce tranzycji | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionExtend | Advanced | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFTransitionExtend | ProcessStructure | Struktura procesu | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFWorkflow | WFWorkflowGeneral | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFWorkflow | WFWorkflowTasks | Zadania | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFWorkflow | TasksInProcess | Zadania w procesie | 900001 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WFWorkflowExtend | RuntimeData | Runtime data (debug) | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WN_D | WNDZalaczniki | Załączniki | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| WN_D_v1 | WND | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| WN_D_v2 | WNDv2 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| WN_D_v3 | WNDv3 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| WN_D_v3 | WNDv3Oswiadczenia | Oświadczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| WN_D_v4_Base | WNDv4 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| WN_D_v4_Base | WNDv4Oswiadczenia | Dane pełnomocnika i oświadczenia | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| WN_U | WNUZalaczniki | Załączniki | 2 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| WN_U_v1 | WNUv1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Waluta | WalutaOgolne | Ogólne | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Waluta | WalutaNotowanie | Notowania | 2 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Waluty | Waluty | Ewidencje ŚP/Waluty | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WariantyTowaruParams | Ogolne | Wybór wariantu towaru | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| WebOperatorNewPasswordParams | NewPasswordForm | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| WebUserPasswordChanging | Ogolne | Zmiana hasła | 10 | Soneta.Business.dll | Soneta.Business |
| WebUserProfileChanging | Ogolne | Profil użytkownika | 10 | Soneta.Business.dll | Soneta.Business |
| WejscieWyjscieI | Net | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WejscieWyjscieI | WejscieWyjscieI | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WersjaPlanu | KwotyPlanow | Kwoty planów | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| WersjaPlanuCentral | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| WersjaPlanuCentral | VersionsRelated | Wersje powiązane | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| WersjaPlanuLocal | General | Ogólne | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| WersjaPlanuLocal | Planning | Planowanie | 120 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| WersjeTestowe | WersjeTestowe | Kadry i płace/Wersje testowe | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Weryfikatory | Weryfikatory | Kadry i płace/Kalendarze/Weryfikatory | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WezwanieDoZaplaty | WezwanieDoZaplaty | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WezwanieDoZaplatyPozycja | WezwanieDoZaplatyPozycja | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WfPlugIn | Ogolne | Ogólne | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfPlugIn | Editor | Edytor | 2 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfPlugInItem | Editor | Edytor | 10 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfPlugInItemReference | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfPlugInReference | General | Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfPlugIns | WfPlugIns | Workflow/Definicje jednozakładkowe/Wtyczki definicji procesów | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfProcessRolePlugIn | Ogolne | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfSysNotificationExtend | General | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfSysNotificationExtend | ProcessStructure | Struktura procesu | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfSysNotificationPlugIn | Ogolne | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfTaskFlowError | Ogolne | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfTaskPlugIn | Ogolne | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfTaskSource | General | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfTaskSource | ProcessStructure | Struktura procesu | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfTaskSourcePlugIn | Ogolne | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfTaskTriggerPlugIn | Ogolne | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WfTransitionPlugIn | Ogolne | Ogólne | 0 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WiadomoscEmail | ElementyPowiazane | Elementy powiązane | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| WiadomoscEmail | WiadomoscPrawa | Prawa | 20 | Soneta.CRM.UI.dll | Soneta.CRM |
| WiadomoscOdebrana | WiadomoscOdebranaOgolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| WiadomoscRobocza | WiadomoscRoboczaOgolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| WiadomoscRobocza | WiadomoscRoboczaAttachments | Załączniki do wysyłki | 1 | Soneta.CRM.UI.dll | Soneta.CRM |
| WiadomoscWyslana | WiadomoscWyslanaOgolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| WiazanieZasobowParams | Ogolne | Zamówienia | 20 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| Wieloddzialowosc | Wieloddzialowosc | Ogólne/Wielooddziałowość | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Windykacja | Windykacja | Ogólne | 99 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WindykacjaNotOdsetkowych | WindykacjaNotOdsetkowych | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WindykacjaOgolne | WindykacjaOgolne | Ewidencje ŚP/Windykacja/Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WindykacjaUstawStan | WindykacjaUstawStan | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WindykacjaUsunStan | WindykacjaUsunStan | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WindykacjaWezwanDoZaplaty | WindykacjaWezwanDoZaplaty | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Wizard1Data | General | Pierwszy krok | 10 | Soneta.Business.UI.dll | Soneta.Business |
| Wizard1Data | Second | Drugi krok | 11 | Soneta.Business.UI.dll | Soneta.Business |
| Wizard2Data | General | Drugi wizard | 10 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardDefinitionGeneral | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardStepDefinitions | Kroki kreatora | 50 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardDefinitionEngine | Algorytm kreatora | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardDefinitionEngineConfig | Parametry algorytmu kreatora | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardDefinitionGetRow | Algorytmy/Wybór wiersza | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardReference | Powiązania | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardDefinitionAlgorithm | Algorytmy/Wybór kroków | 101 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardDefinitionIsEnable | Algorytmy/Przetwarzanie | 102 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardDefinitionBeforeSaveAndFinish | Algorytmy/Przed zapisaniem i zakończeniem | 103 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardDefinitionAfterSaveAndFinish | Algorytmy/Po zapisaniu i zakończeniu | 104 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinition | WizardDefinitionForceUnloockParent | Algorytmy/Odblokowanie do edycji | 105 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinitionProxy | StepPage | {Caption} | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinitionProxy | WizardPage | {Caption} | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinitions_General | WizardDefinitions_General | Ogólne/Definicje kreatorów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardDefinitions_Workflow | WizardDefinitions_Workflow | Workflow/Definicje kreatorów | 98 | Soneta.Business.UI.dll | Soneta.Business |
| WizardReference | General | Ogólne | 1 | Soneta.Business.UI.dll | Soneta.Business |
| WizardReference | Editor | Edytor | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardStepDefinition | WizardStepDefinitionGeneral | Ogólne | 0 | Soneta.Business.UI.dll | Soneta.Business |
| WizardStepDefinition | WizardStepDefinitionAccepted | Algorytmy/Akceptacja | 50 | Soneta.Business.UI.dll | Soneta.Business |
| WizardStepDefinition | WizardStepDefinitionIsVisible | Algorytmy/Widoczność | 51 | Soneta.Business.UI.dll | Soneta.Business |
| WizardStepDefinition | WizardStepDefinitionGetRow | Algorytmy/Wybór wiersza | 52 | Soneta.Business.UI.dll | Soneta.Business |
| WizardStepDefinition | WizardStepDefinitionIsReadOnlyStep | Algorytmy/Tylko do odczytu | 53 | Soneta.Business.UI.dll | Soneta.Business |
| WizardStepDefinition | WizardStepDefinitionList | Zakładka z listą obiektów | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardStepDefinition | WizardStepDefinitionPage | Standardowa zakładka | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardStepDefinition | WizardStepDefinitionReport | Zakładka wydruku | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardStepDefinition | WizardStepDefinitionRichEdit | Zakładka z opisem | 100 | Soneta.Business.UI.dll | Soneta.Business |
| WizardWorker | Main | Wizard test | 3 | Soneta.Business.UI.dll | Soneta.Business |
| WizytowkaFirmyPrzeksztalcWorker-WizytowkaFirmyPrzeksztalcWorkerParams | Ogolne | Ogólne | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| WklejRozliczeniaZaplatyWorker-ParamClass | Params | Parametry | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WlaczNotyOdsetkoweDlaPlatnosci-Params | Params | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WniosekOSzkolenie | WniosekOSzkolenie | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WniosekOSzkolenie | WniosekOSzkolenieDodatkowe | Rozliczenie i uprawnienia | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WniosekOSzkolenie | WniosekOSzkolenieDodatkoweZzl | Rozliczenie | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WniosekOSzkolenie | WniosekOSzkolenieUprawnieniaZzl | Uzyskane uprawnienia | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WniosekOSzkolenie | WniosekOSzkolenieUwagi | Uwagi | 35 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WniosekOSzkolenie | ElementyOceny | Ocena | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WniosekPracyZdalnej | WniosekPracyZdalnej | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WniosekPracyZdalnej | WniosekPracyZdalnejNet | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WniosekUrlopowy | Net | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WniosekUrlopowy | WniosekUrlopowy | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Worker_110400_KonwersjaWindykacji-Params | Params | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WorkflowExportWorker-WorkflowExportWorkerParams | WorkflowExportWorkerParams | Eksport pełnej konfiguracji | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WorkflowImportWorker-WorkflowImportWorkerParams | WorkflowImportWorkerParams | Import pełnej konfiguracji | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WorkflowPanel | General | Panel Workflow | 1 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WorkflowPanelMobile | General | Uruchom proces | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WorkflowSchedulerGeneral | WorkflowSchedulerGeneral | Workflow/Harmonogram zadań/Ogólne | 100 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| WorksiteFormParams | Html | Rezerwacja stanowiska pracy | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| WorksiteFormParams | WinForm | Rezerwacja stanowiska pracy | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| Worksites | General | General | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| Worksites | Worksites | Praca hybrydowa/Rezerwacja stanowisk pracy | 100 | Soneta.RealEstate.UI.dll | Soneta.RealEstate |
| Wplata | PrzelewyIRozliczenia | Rozliczenia i Przelewy | 2 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WprowadzKodWorker-NowyKodParams | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| WybierzAnkietowanychWorker | Ogolne | Wybierz | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| WybierzDeklaracjeDoZbiorczejPITWorker | Ogolne | Dodaj lub usuń deklaracje | 100 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| WybierzDokumentyNotyWorker | WybierzDokumentyNotyWorker | Wybierz | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WybierzDokumentySprawyWorker | Ogolne | Wybierz | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WybierzDokumentyWorker | WybierzDokumentyWorker | Wybierz | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WybierzKompetencje2Worker | WybierzKompetencje | Wybierz | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzKompetencjeKKMNiezbedneParams | WybierzKompetencje | Wybierz kompetencje | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzKompetencjeKKMPozadaneParams | WybierzKompetencje | Wybierz kompetencje | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzKompetencjeKKUNiezbedneParams | WybierzKompetencje | Wybierz kompetencje | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzKompetencjeKKUPozadaneParams | WybierzKompetencje | Wybierz kompetencje | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzKompetencjeKOSWorker | WybierzKompetencje | Wybierz | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzKompetencjeWorker | WybierzKompetencje | Wybierz | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzLicencje | WybierzLicencje | Ogólne | 1 | Soneta.Business.Licence.dll | Soneta.Business |
| WybierzOdpowiedzialnosciPracownikaParams | WybierzOdpowiedzialnosci | Wybierz odpowiedzialności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzOdpowiedzialnosciStanowiskaParams | WybierzOdpowiedzialnosci | Wybierz odpowiedzialności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzOpisKOSWorker | WybierzKompetencje | Wybierz | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzSzkoleniaIUprawnieniaNiezbedneParams | WybierzSzkoleniaIUprawnienia | Wybierz szkolenia i uprawnienia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzSzkoleniaIUprawnieniaPozadaneParams | WybierzSzkoleniaIUprawnienia | Wybierz szkolenia i uprawnienia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzWnioskiOSzkolenieWorker | WybierzWnioskiOSzkolenie | Wybierz | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzZadaniaParams | WybierzZadania | Wybierz zadania | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WybierzZaliczkiWorker | WybierzZaliczkiWorker | Wybierz | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| WyborCech | Ogolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| WyborTechnologiiWorker | Ogolne | Wybór technologii | 10 | Soneta.Handel.UI.dll | Soneta.Produkcja |
| WyciagBankowyWorker | NaliczanieZaplatZaPzl | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Wydzial | Wydzial | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wydzial | WydzialGUS | Dodatkowe | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wydzial | WydzialBlokady | Blokady | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wydzial | WydzialZgody | Zgody | 25 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wydzial | Metryka | Historia/Metryka | 50 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wydzial | ZmianyDanych | Historia/Zmiany danych identyfikacyjnych | 99 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wydzial | HistoriaPowiazan | Historia/Zmiany jednostki nadrzędnej | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WydzialRef | Ogolne | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WydziałDefinicjiStanowiska | WydziałDefinicjiStanowiska | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyjatekRegulyDostepnosci | Ogolne | Wyjątek reguły dostępności | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WykladowcaSzkol | WykladowcaSzkolOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| WykladowcaSzkol | WykladowcaSzkolHarmonogram | Harmonogram | 20 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| WykladowcaSzkol | WykladowcaSzkolHarmonogramKalend | Kalendarz zajęć | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| WymaganieProxy | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WymianaDanychEksportParams | Ogolne |  | 100 | Soneta.Core.UI.dll | Soneta.Core |
| WynajemSzkol | ZajecieWynajemOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Wynik | General | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| WynikZestKS | General | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| WynikZestKS | Params | Parametry | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| WynikiWartosciowaniaInfo | Wyniki | Wyniki wartościowania | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WypElement | WypElement | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WypElement | WypElementSkladniki | Składniki | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WypElement | WypElementKUP | Pozostałe | 103 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WypElement | PracownikZaGranica | Pracownik za granicą | 104 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WypElement | WypElementStorno | Storno | 110 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wypadek | Wypadek | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wypadek | WypadekZus | ZUS | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplacZaliczkeWorker | WyplacZaliczke | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wyplata | Rozliczenia | Rozliczenia | 2 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Wyplata | WyplataElementy | Elementy | 2 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wyplata | WyplataZobowiazania | Zobowiązania | 4 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wyplata | PPK | PPK | 9 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wyplata | WyplataSkladkiTyub | {Caption} | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wyplata | KUP | Pozostałe | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wyplata | PracownikZaGranica | Pracownik za granicą | 30 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wyplata | WyplataZapisObliczen | Zapis obliczeń | 99 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataEtat | WyplataEtat | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataEtat | WyplataEtatNet | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataEtat | WyplataEtatPodatki | Podatki | 6 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataEtat | WyplataSkladki | Składki | 8 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataInne | WyplataInne | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataInne | WyplataInneNet | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataInne | WyplataInnePodatki | Podatki | 6 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataUmowa | WyplataUmowa | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataUmowa | WyplataUmowaNet | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataUmowa | WyplataUmowaPodatki | Podatki | 6 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataUmowa | WyplataSkladki | Składki | 8 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WyplataUmowyEwidencja | WyplataUmowyEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| WyplataUmowyEwidencja | Zobowiazania | Dane kontrahenta i płatności | 4 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| WyposazenieHistoria | WyposazenieOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| WyposazenieHistoria | WyposazenieTerminarz | Terminarz, wycena, kody kreskowe | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| WyposazenieHistoria | WyposazeniePrawaDanych | Prawa danych | 300 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| WyposazenieHistoria | RowHistory | Historia zapisów | 999 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| WyposazenieStanowiska | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WypłataTransferowaPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| WypłataŚrodkówPrzezUczestnikaPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Wyroznienie | WyroznienieOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Wysilek | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Wyszukanie | Wyszukanie | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| WzorOcenyPracownika | WzorOcenyPracownika | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| XmlStorageFile | General | Edytor XML | 10 | Soneta.Business.UI.dll | Soneta.Business |
| Z3 | Z3 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3 | Z3Pracownik | Dane o pracowniku | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3 | Z3WyplaconeSwiadczenia | Wypłacone świadczenia | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3 | Z3WynagrodzeniaMiesieczne | Składniki wynagrodzenia - okresy miesięczne | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3 | Z3WynagrodzeniaPozostale | Składniki wynagrodzenia - pozostałe okresy | 40 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3 | Z3Uwagi | Uwagi | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3 | Z3XmlDoEksportu | XML do eksportu | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3ExportToXmlParams | Z3Export | Ogólne | 100 | Soneta.Deklaracje.dll | Soneta.Deklaracje |
| Z3a | Z3a | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3a | Z3aPracownik | Dane o ubezpieczonym | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3a | Z3aWyplaconeSwiadczenia | Wypłacone świadczenia | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3a | Z3aPrzychod | Przychód stanowiący podstawę wymiaru składek | 30 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3a | Z3aUwagi | Uwagi | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Z3a | Z3aXmlDoEksportu | XML do eksportu | 60 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZAW_NR_1 | ZAW_NR_1_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZAW_NR_1 | ZAW_NR_1_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZAW_NR_1 | ZAW_NR_1_3 | D, E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZAW_NR_2 | ZAW_NR_2_1 | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZAW_NR_2 | ZAW_NR_2_2 | C | 1 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZAW_NR_2 | ZAW_NR_2_3 | D, E | 4 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZAW_NR_Worker | Rezultat | Rezultat | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZCNA | ZCNA | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZCNA_O | ZCNA_O | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZCNA_O | ZCNA_OAdres | Adres zamieszkania | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZCZA | ZCZA | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZIUA | ZIUA | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZKLWartosciowanieKonfigurator | ZKLWartosciowanieKonfigurator | ZKL/Konfigurator wartościowania | 101 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZSWA | ZSWA | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZSWA | ZSWAZalaczniki | Załączniki | 50 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZSWA_O | ZSWA_O | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZSWA_O | ZSWA_OOkresy | Dane o pracy | 20 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZUA | ZUA | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZUS | Ogolne | Ogólne | 0 | Soneta.CRM.UI.dll | Soneta.CRM |
| ZUSCentrala | ZUSKonta | Konta dla składek | 3 | Soneta.CRM.UI.dll | Soneta.CRM |
| ZUSCentrala | Historyczne | Historyczne | 4 | Soneta.CRM.UI.dll | Soneta.CRM |
| ZWUA | ZWUA | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZZA | ZZA | Ogólne | 10 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZadaniaDniaWindow | ogolne | Zadania Pracy Hybrydowej | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadaniaProjektoweScheduler | General | Kalendarz projektowy | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadaniaRelacja | ogolne | Ogólne | 1 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadaniaSchedulerViewInfo | General | Kalendarz CRM | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadaniaWgOperatViewInfo | General | Kalendarz wg operatorów | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadaniaZmienStanWorker-ZmienStanParams | Ogolne | Ogólne | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | Net | Ogólne | 0 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Zadanie | ZadanieOgolnePK | Ogólne | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadaniaPodstawoweZadania | Podstawowe | 5 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadaniePodstawoweOpisHtml | Podstawowe | 5 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | GeneralHtml | Ogólne | 9 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | GeneralWinForm | Ogólne | 9 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOgolneOpisHtml | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOgolneRozszerzony | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOgolneRozszerzonyOpisHtml | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieSerwisOgolne | Zlecenie | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieSerwisOgolneOpisHtml | Zlecenie | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieWypozyczenieOgolne | Wypożyczenie | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieWypozyczenieOgolneOpisHtml | Wypożyczenie | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZdarzenieOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZdarzenieOgolneOpisHtml | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZdarzenieZapytanieOfertoweOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOPZOgolne | Ogólne | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOPZOgolne | Ogólne | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOPZOgolneInHtml | Ogólne | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOPZOgolneInWinForm | Ogólne | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOPZOgolneNet | Ogólne | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOPZPodrzedne | {SubordinateName} | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieUzytkownika | {New ZadanieUzytkownikaExtender.NazwaZakladki} | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | WypozyczenieExtUrzadzenia | Urządzenia | 12 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOpisHtml | Opis | 12 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOpisHtmlPK | Opis | 12 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieSerwisUrzadzenia | Urządzenia | 12 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOPZTimeTrack | Czas realizacji | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOPZTimeTrackNet | Czas realizacji | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieRealizacja | Dodatkowe | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZalacznikiZadaniaPK | Załączniki | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadaniaPowiazanePK | Aktywności powiązane | 30 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadaniePowiazane | Aktywności powiązane | 30 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | Wytyczna | {new ZadanieOPZExtender.GetNazwaZakladkiWytyczna()} | 40 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | WytycznaNet | {new ZadanieOPZExtender.GetNazwaZakladkiWytyczna()} | 40 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieGrupowe | Uczestnicy | 40 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZalacznikiZadanPowiazanychPK | Załączniki zadań powiązanych | 40 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | AreaPaths | Obszary | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | Wizja | {new ZadanieOPZExtender.GetNazwaZakladkiWizja()} | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | WizjaNet | {new ZadanieOPZExtender.GetNazwaZakladkiWizja()} | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieDokumenty | Dokumenty | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieSerwisDokumenty | Dokumenty | 50 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieDokHanPozycje | Pozycje | 60 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieZlecenieUslugi | Usługi | 65 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieHistoria | Historia zadania | 70 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieZasoby | Pracownicy i zasoby | 70 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieZlecenieCzesci | Części | 70 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | PodmiotyPowiazane | Podmioty powiązane | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOPZZalaczniki | Załączniki | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | ZadanieOPZZalacznikiNet | Załączniki | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zadanie | WiadomosciPowiazaneZadania | {New WiadomosciPowiazaneZadaniaExtender.CaptionHtml} | 1000 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadanieGrupujace | Ogolne | Ogólne | 5 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadanieGrupujace | Dodatkowe | Dodatkowe | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadanieGrupujace | Powiazane | Zadania powiązane | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadanieProjektowe | Ogolne | Ogólne | 5 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadanieProjektowe | Dodatkowe | Dodatkowe | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadanieProjektowe | Powiazane | Zadania powiązane | 20 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadanieSynchronizujWorker-SyncParams | SyncGeneral | Ogólne | 0 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadanieUtworzZadaniaCykliczneWorkerParams | KopiowanieCyklicznych | Kopiowanie zadań | 100 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZadanieZewnSynch | Ogolne | Ogólne | 1 | Soneta.Core.UI.dll | Soneta.Core |
| ZadanieZkl | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZajeciaWynagrodzenia | ZajeciaWynagrodzenia | Kadry i płace/Płace/Zajęcia wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZajecieKomorniczeHistoria | ZajecieKomorniczeHistoria | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZajecieKomorniczeHistoria | Korekty | Zwroty i uznania nadpłaty | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZajecieKomorniczeHistoria | ZajecieKomorniczeHistoriaUwagi | Uwagi | 20 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZajecieKomorniczeHistoria | ElementyWynagrodzeniaHist | Elementy wynagrodzenia | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZajecieKomorniczeHistoria | RowHistory | Historia zapisów | 999 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZakonczDodatek | ZakonczDodatek | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZakończenieZatrudnieniaUczestnikaPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZakresWartości | Ogólne | Ogólne | 10 | Soneta.Core.UI.dll | Soneta.Core |
| ZakresyWartosci | ZakresyWartosci | CRM/Oceny/Zakresy wartości | 100 | Soneta.CRM.UI.dll | Soneta.CRM |
| ZakresyWartosciHR | ZakresyWartosciHR | Kadry i płace/Oceny/Zakresy wartości | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZakupEwidencja | HandlowyBudzetEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZakupEwidencja | PulpitKBR | Dokument kosztu | 0 | Soneta.EI.UI.dll | Soneta.EI |
| ZakupEwidencja | ZakupEwidencja | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZakupEwidencja | Zobowiazania | Dane kontrahenta i płatności | 4 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZakupEwidencja-GenerujNaleznyFromTableWorker | General | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZakupEwidencja-ZakupEwidencjaDefDok | DefinicjaVATEwidencja | Rozszerzenie definicji VAT | 101 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZalacznikZUS | ZalacznikZUS | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| Zaliczka | Zaliczka | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZalogowaniOperatorzy | ZalogowaniOperatorzy | Ogólne | 1 | Soneta.Business.Licence.dll | Soneta.Business |
| ZamiennikTowaru | Ogolne | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| ZamiennikiTowaruWorker | Ogolne | {new ZamiennikiTowaruWorkerExtender.Caption} | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| ZamiennikiTowaruWorker-MultiParams | Ogolne | Wybór zamienników towaru | 100 | Soneta.Handel.UI.dll | Soneta.Towary |
| ZamowienieProste | ZamowienieProsteOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZaniechaniePodatkowe | ZaniechaniePodatkowe | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZapisKsiegowy | ZapisKsiegowyOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZapisKsiegowy | ZapisKsiegowyOpisy | Opisy analityczne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZapisKsiegowy | ZapisKsiegowyRozliczenie | Rozliczenie | 10 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZaplacDokumentyBaseWorker-Result | Result | Ogólne | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Zaplata | Zaplata | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Zaplata | ZaplataDane | Dodatkowe | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Zaplata | ZaplataKsiega | Magazyn walut | 4 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ZarejestrujBaseWorker | ZarejestrujPracownikow | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZasilekInnyPlatnik | Ogolne | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Zasob | Zasob | Ogólne | 100 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| Zasob | ZasobPodrzedne | Zasoby podrzędne | 100 | Soneta.Handel.UI.dll | Soneta.Magazyny |
| ZasobCRM | ZasobCRM | Ogolne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZasobMW | ZasobMW | Ogólne | 0 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ZatwierdzaczKasowegoParams | Params | Płatności | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ZatwierdzaczKasowegoParams | ParamsEx | Płatności | 1 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ZatwierdzaczKasowegoParams | LogiTerminala | Logi z terminala | 40 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ZatwierdzanieDokumentow | ZatwierdzanieDokumentow | Ewidencje ŚP/Zatwierdzanie dokumentów | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ZbiegPracyIRodzicielstwa | ZbiegPracyIRodzicielstwa | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZbiorczaPIT | Ogólne | Ogólne | 0 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZdarzenieExt | GeneralHtmlForm | Ogólne | 8 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZdarzenieExt | GeneralWinForm | Ogólne | 8 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZdarzenieExt | ZdarzenieUzytkownika | {New ZadanieUzytkownikaExtender.NazwaZakladki} | 11 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| Zespol | ZespolOgolne | Ogólne | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZespolSzkol | ZespolSzkolOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ZespolSzkol | ZespolSzkolZajecia | Zajęcia | 20 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ZespolSzkol | ZespolSzkolZajeciaKalend | Kalendarz zajęć | 21 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ZespolSzkol | ZespolSzkolUczestnicy | Uczestnicy | 30 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ZespolyOPZ | ZespolyOPZ | Praca hybrydowa/Zespoły | 10 | Soneta.Zadania.UI.dll | Soneta.Zadania |
| ZestawDodatkow | ZestawDodatkow | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZestawPodzielnikowKosztow | ZestawPodzielnikowKosztowOgolne | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ZestawST | ZestawSTOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZestawienieAkordu | ZestawienieAkordu | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZestawienieGrupowego | ZestawienieGrupowego | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZestawienieKS | ZestawienieKSOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZestawienieKS | ZestawienieKSKolumny | Kolumny | 1 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZestawienieKS | ZestawienieKSWyniki | Wyniki | 2 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZestawienieKS | Protections | Dodatkowe | 90 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZestawieniePracy | ZestawieniePracy | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZestawieniePracy | ZestawieniePracyPro | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZestawienieUmowy | Net | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZestawienieUmowy | ZestawienieUmowy | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZestawienieUmowyZewnetrznej | ZestawienieUmowyZewnetrznej | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZestawienieUmowyZewnetrznej | ZestawienieUmowyZewnetrznejNet | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZestawyPodzielnikowKosztow | ZestawyPodzielnikowKosztow | Podzielniki/Zestawy podzielników kosztów | 100 | Soneta.Core.UI.dll | Soneta.Core |
| Zgloszenie | ZgloszenieNieZbiorczeOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Zgloszenie | ZgloszenieZbiorczeOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| Zgloszenie | ZgloszenieDokumentyHan | Dokumenty handlowe | 60 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ZgloszenieSygnalisty | NET | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZgloszenieSygnalisty | Ogolne | Ogólne | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZgloszenieSygnalisty | Realizacja | Realizacja | 1 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZgloszenieUczGrupa | ZgloszenieUczGrupaOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ZgloszenieUczestnik | ZgloszenieUczestnikOgolne | Ogólne | 10 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ZgloszenieUczestnik | ZgloszenieUczestnikPozycjeDokHan | Pozycje handlowe | 50 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ZgloszenieUczestnik | ZgloszenieUczestnikDokumentyHan | Dokumenty handlowe | 60 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ZgloszenieUczestnik | Oceny | Warunki certyfikacji | 65 | Soneta.CzlonkowieSzkolenia.UI.dll | Soneta.CzlonkowieSzkolenia |
| ZgodaNaEdycje | ZgodaNaEdycje | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZklBazaOsob | General | Baza osób | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZleDlugiDokument | Ogolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZleDlugiKorekta | Ogolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZleDlugiRozliczenie | Ogolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaCentrumKosztow | ZmianaCentrumKosztowOgolne | Ogólne (Zmiana centrum kosztów) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaDanychIdentyfikacyjnychUczestnikaPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZmianaDanychKontaktowychUczestnikaPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZmianaDodatku | ZmianaDodatku | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZmianaKategorii | ZmianaKategoriiOgolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaKonfiguracjiVat2014Worker-WParams | Ogolne | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaMiejscaUzytkowania | ZmianaMiejscaUzytkowaniaOgolne | Ogólne (Zmiana miejsca użytkowania) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaOsobyOdpowiedzialnej | ZmianaOsobyOdpowiedzialnejOgolne | Ogólne (Zmiana osoby odpowiedzialnej) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaParametrowAmortyzacji | ZmianaParametrowAmortyzacjiOgolne | Ogólne (Zmiana parametrów amortyzacji) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaParametrowPodatku | ZmianaParametrowPodatkuOgolne | Ogólne (Zmiana parametrów podatku) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaPodzielnikaKosztow | ZmianaPodzielnikaKosztowOgolne | Ogólne (Zmiana podzielnika kosztów) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaStawekVATTowarówParams | Ogolne | Zmiana stawek VAT | 0 | Soneta.Handel.UI.dll | Soneta.Towary |
| ZmianaStawki | ZmianaStawki | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZmianaWartosci | ZmianaWartosciOgolne | Ogólne (Zmiana wartości) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaWartosciDodatkuWorker | ZmianaWartosciDodatkuWorker | Zmiana wartości dodatku ... | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZmianaWartosciDok | ZmianaWartosciDokOgolne | Ogólne (Zmiana wartości i ilości) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaWartosciRezydualnej | ZmianaWartosciRezydualnejOgolne | Ogólne (Zmiana wartości rezydualnej) | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmianaWkladuFunduszuPozyczkowego | ZmianaWkladuFunduszuPozyczkowego | Ogólne | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| ZmienDozwoloneOkresyWorker | ZmienDozwoloneOkresy | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmienDozwoloneOkresyWorkerParams | Params |  | 1 | Soneta.EI.UI.dll | Soneta.EI |
| ZmienParametryPrzesylkiParams | Ogolne | Zmień parametry | 900 | Soneta.Handel.UI.dll | Soneta.Handel |
| ZmienParametryRozliczenVATWorker | ZmienParametryRozliczenVAT | Ogólne | 100 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZmienTerminPlatnosciZbiorczoIdx-Params | Params |  | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ZmienTerminPlatnosciZbiorczoPla-Params | Params |  | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ZmienVATNaPlatnosciachParams | Params | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZnacznikKonta | Ogolne | Ogólne | 0 | Soneta.Ksiega.UI.dll | Soneta.Ksiega |
| ZnajomoscJezykaObcego | ZnajomoscJezykaObcego | Ogólne | 100 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |
| Zobowiazanie | PrzelewyIRozliczenia | Rozliczenia i Przelewy | 2 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| Zobowiazanie | PlatnosciEwidencjiExtender |  | 100 | Soneta.Kasa.UI.dll | Soneta.Kasa |
| ZrodlaFinansowania | ZrodlaFinansowania | Ogólne/Źródła finansowania | 5 | Soneta.Core.UI.dll | Soneta.Core |
| ZrodloFinansowania | General | Ogólne | 100 | Soneta.Core.UI.dll | Soneta.Core |
| ZroldlaKontaktu | ZroldlaKontaktu | CRM/Ogólne/Źródła kontaktu | 11 | Soneta.CRM.UI.dll | Soneta.CRM |
| ZwrotNadplatyPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZwrotŚrodkówPPK | Ogolne | Ogólne | 11 | Soneta.Deklaracje.UI.dll | Soneta.Deklaracje |
| ZyrantPozyczki | Ogolne | Żyranci | 10 | Soneta.KadryPlace.UI.dll | Soneta.KadryPlace |

## Zakładki systemowe (typy ogólne)

Zakładki przypięte do typów bazowych/interfejsów ogólnych (`Row`, `GuidedRow`,
`ExportedRow`, `IRow`, `IGuidedRow`, `object`). Platforma dokłada je do **wielu obiektów**
przez dziedziczenie/interfejs — **nie są specyficzne dla obiektu** i nie wnoszą informacji
biznesowej (Załączniki, Notatki, Dyskusja, Panel BI, „Dodatkowe (cechy)”…). `scan-forms`
dla konkretnego obiektu ich nie raportuje — pełną definicję odczytasz podając typ ogólny,
np. `dotnet script scan-forms.csx -- Row <KatalogDll>`.

| Typ ogólny | Zakładka (plik) | Nazwa zakładki | Priority | Biblioteka (DLL) | Przestrzeń |
|---|---|---|---|---|---|
| IGuidedRow | HostTuples | Dokumenty dodatkowe | 997 | Soneta.Core.UI.dll | Soneta.Core |
| IGuidedRow | RefTuples | Powiązane dokumenty dodatkowe | 998 | Soneta.Core.UI.dll | Soneta.Core |
| IGuidedRow | DependentWorkflow | Obsługa procesu | 99998 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| IGuidedRow | Discussion | Dyskusja | 999998 | Soneta.Core.UI.dll | Soneta.Core |
| IRow | DefineFirst | Użytkownika | -5000 | Soneta.Business.UI.dll | Soneta.Business |
| IRow | Define | Dodatkowe (cechy) | 5000 | Soneta.Business.UI.dll | Soneta.Business |
| Row | AttachmentPage | Asystent/Załączniki | 9997 | Soneta.Net.Business.dll | Soneta.Net |
| Row | NotePage | Asystent/Notatki | 9998 | Soneta.Net.Business.dll | Soneta.Net |
| Row | FormDashboard | Panel BI | 9999 | Soneta.BI.UI.dll | Soneta.BI |
| Row | NotificationsNetPage | Asystent/Powiadomienia | 9999 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| Row | TeczkaPage | Asystent/Teczki | 9999 | Soneta.CRM.UI.dll | Soneta.CRM |
| Row | ExplorerObjectPage | Wszystkie | 999999 | Soneta.Business.UI.dll | Soneta.Business |

## Liczba zakładek wg biblioteki

| Biblioteka (DLL) | Zakładek |
|---|---|
| Soneta.Deklaracje.UI.dll | 1303 |
| Soneta.KadryPlace.UI.dll | 1010 |
| Soneta.Handel.UI.dll | 455 |
| Soneta.Core.UI.dll | 405 |
| Soneta.Business.UI.dll | 362 |
| Soneta.Zadania.UI.dll | 354 |
| Soneta.Ksiega.UI.dll | 347 |
| Soneta.CRM.UI.dll | 198 |
| Soneta.BI.UI.dll | 197 |
| Soneta.Kasa.UI.dll | 186 |
| Soneta.ProdukcjaPro.UI.dll | 173 |
| Soneta.Workflow.UI.dll | 169 |
| Soneta.CzlonkowieSzkolenia.UI.dll | 124 |
| Soneta.RealEstate.UI.dll | 94 |
| Soneta.EI.UI.dll | 49 |
| Soneta.Net.Business.dll | 48 |
| Soneta.Vehicles.UI.dll | 46 |
| Soneta.Support.UI.dll | 35 |
| Soneta.Net.Test.dll | 30 |
| Soneta.Business.UI.DxReports.dll | 18 |
| Soneta.Core.dll | 17 |
| Soneta.Business.Licence.dll | 15 |
| Soneta.Business.dll | 14 |
| Soneta.Business.Forms.dll | 10 |
| Soneta.Handel.Reports.dll | 7 |
| Soneta.Business.Test.dll | 3 |
| Soneta.Printer.dll | 3 |
| Soneta.BI.Reports.dll | 2 |
| Soneta.Deklaracje.dll | 2 |
| Soneta.Oracle.dll | 2 |
| SonetaExplorer.dll | 1 |
