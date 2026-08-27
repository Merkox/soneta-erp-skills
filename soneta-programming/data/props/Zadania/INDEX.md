# Moduł `Zadania` — tabele biznesowe

- Opis: Moduł zarządzania zadaniami i projektami. Zawiera definicje zadań, harmonogramy, przypisania, śledzenie czasu pracy (TimeTrack) oraz rozliczanie realizacji.
- Tabel: **61**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| AvaliableCorrespondenceState | Dostepne stany korespondencji | `AvalCorreStates` | konfig |  |  |  |  | [AvaliableCorrespondenceState.md](AvaliableCorrespondenceState.md) |
| AvaliableProjectState | Dostepne stany projektów | `AvalProjStates` | konfig |  |  |  |  | [AvaliableProjectState.md](AvaliableProjectState.md) |
| AvaliableState | Dostepne stany | `AvaliableStates` | konfig |  |  |  |  | [AvaliableState.md](AvaliableState.md) |
| BudgetPeriod | Okresy budżetowe | `BudgetPeriods` | konfig | root |  |  |  | [BudgetPeriod.md](BudgetPeriod.md) |
| BudzetObrot | Plany i realizacje na pozycjach budżetu. | `BudzetObroty` |  | child: Pozycja→PozycjaBudzProj |  |  |  | [BudzetObrot.md](BudzetObrot.md) |
| BudzetProjektu | Budzety projektu | `BudzetyProjektu` |  | root |  |  |  | [BudzetProjektu.md](BudzetProjektu.md) |
| BudzetUprawnienie | Uprawnienia budżetów | `BudzetUprawn` |  |  |  |  |  | [BudzetUprawnienie.md](BudzetUprawnienie.md) |
| CtiAccount |  | `CtiAccounts` |  | root |  |  |  | [CtiAccount.md](CtiAccount.md) |
| CtiCallTransferLog |  | `CallTransferLogs` |  | root |  |  |  | [CtiCallTransferLog.md](CtiCallTransferLog.md) |
| DefBudget | Definicje budżetów | `DefBudgets` | konfig | root |  |  |  | [DefBudget.md](DefBudget.md) |
| DefBudgetAspect | Perspektywa realizacji | `DefBudgetAspects` | konfig | root |  |  | TypObrotuBudzetu (2) | [DefBudgetAspect.md](DefBudgetAspect.md) |
| DefBudgetCategory | Kategoria budżetu | `DefBudgetCateg` | konfig | root |  |  | TypObrotuBudzetu (2) | [DefBudgetCategory.md](DefBudgetCategory.md) |
| DefBudgetCategoryRelation | Relacje kategorii budżetu | `DefBudgetCatRel` | konfig | root |  |  |  | [DefBudgetCategoryRelation.md](DefBudgetCategoryRelation.md) |
| DefKampania | Definicje kampanii CRM | `DefKampanii` | konfig | root |  | IRightsSource |  | [DefKampania.md](DefKampania.md) |
| DefKoresp | Definicje korespondencji | `DefsKoresp` | konfig | root |  | IRightsSource, IWFDefinitionHost |  | [DefKoresp.md](DefKoresp.md) |
| DefPlanVersion | Definicje planów wersji | `DefPlanVersions` | konfig | root |  |  | PlanVersionType (2) | [DefPlanVersion.md](DefPlanVersion.md) |
| DefPlanuSprzedazy | Definicje planów sprzedażowych | `DefPlanSprzed` | konfig | root |  | IRightsSource |  | [DefPlanuSprzedazy.md](DefPlanuSprzedazy.md) |
| DefProjektu | Definicje projektów CRM | `DefProjektow` | konfig | root |  | IRightsSource, ISysNotificationHost, IWizardReferenceHost, IWfPlugInReferenceHost, IWFDefinitionHost |  | [DefProjektu.md](DefProjektu.md) |
| DefRealizacjiPlanu | Definicje realizacji planów sprzedażowych | `DefRealPlanow` | konfig | root |  |  |  | [DefRealizacjiPlanu.md](DefRealizacjiPlanu.md) |
| DefZadanDbTupleDefinitionExt | Rozszerzenia definicji krotek dla tabeli Definicje Zadania | `DefZadanTDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition |  |  |  | [DefZadanDbTupleDefinitionExt.md](DefZadanDbTupleDefinitionExt.md) |
| DefZadania | Definicje zadań CRM | `DefZadan` | konfig | root |  | IRightsSource, IManagedRowDefinion, ISysNotificationHost, IWizardReferenceHost, IWfPlugInReferenceHost, IWFDefinitionHost, IPreviewPageHost |  | [DefZadania.md](DefZadania.md) |
| DefZadaniaRelacja | Relacje definicji zadań | `DefZadanRelacje` | konfig | root |  |  |  | [DefZadaniaRelacja.md](DefZadaniaRelacja.md) |
| DokumentCRM | Dokumenty powiązane | `DokumentyCRM` |  | child: Host→IDocumentHostCRM |  |  |  | [DokumentCRM.md](DokumentCRM.md) |
| EtapDefProjektu | Etapy definicji projektu CRM | `EtapyDefProjektu` | konfig | child: Definicja→DefProjektu |  |  |  | [EtapDefProjektu.md](EtapDefProjektu.md) |
| EtapProjektu | Etapy projektu CRM | `EtapyProjektu` |  | child: Projekt→Projekt |  |  |  | [EtapProjektu.md](EtapProjektu.md) |
| EtapWykonujacy | Operatorzy przypisani do etapów projektów | `EtapyWykonujacy` |  |  |  |  |  | [EtapWykonujacy.md](EtapWykonujacy.md) |
| EventDetail | Szczegóły zdarzeń | `EventDetails` |  | root |  |  |  | [EventDetail.md](EventDetail.md) |
| EventParticipant |  | `EventPartic` |  |  |  |  |  | [EventParticipant.md](EventParticipant.md) |
| GoogleCalendar | Kalendarze Google | `GoogleCalendars` |  | root |  |  |  | [GoogleCalendar.md](GoogleCalendar.md) |
| HistZadania | Historia zadań | `HistZadan` |  | child: Zadanie→Zadanie |  |  |  | [HistZadania.md](HistZadania.md) |
| Kampania | Kampanie CRM | `Kampanie` |  | root |  |  |  | [Kampania.md](Kampania.md) |
| KategoriaAkt | Kategoria aktywności | `KategorieAkt` | konfig | root |  |  |  | [KategoriaAkt.md](KategoriaAkt.md) |
| KontrahentRealizacji |  | `KntRealizacji` | konfig |  |  |  |  | [KontrahentRealizacji.md](KontrahentRealizacji.md) |
| Korespondencja | Tabela korespondencji | `Korespondencje` |  | root |  | IEmailElement |  | [Korespondencja.md](Korespondencja.md) |
| KwotaBudzProj | Kwoty budzetu projektu | `KwotyBudzProj` |  | root |  |  |  | [KwotaBudzProj.md](KwotaBudzProj.md) |
| ModelUrz | Model urządzeń | `ModeleUrz` |  | root |  |  |  | [ModelUrz.md](ModelUrz.md) |
| PlanSprzedazowy | Plany sprzedażowe | `PlanySprzedazowe` |  | root |  |  |  | [PlanSprzedazowy.md](PlanSprzedazowy.md) |
| PlanVariant | Warianty planów | `PlanVariants` | konfig | child: DefBudget→DefBudget |  |  | PlanVariantKind (2) | [PlanVariant.md](PlanVariant.md) |
| PlanVariantRel | Definicje wersji planów dla Wariantu planów | `PlanVariantsRel` | konfig | root |  |  |  | [PlanVariantRel.md](PlanVariantRel.md) |
| PlanowanyPrzeglad | Planowany przegląd urządzenia | `PlanPrzeglady` |  | root |  |  |  | [PlanowanyPrzeglad.md](PlanowanyPrzeglad.md) |
| PodmiotZadanie | Podmioty powiązane z zadaniami. | `PodmiotyZadania` |  | child: Zadanie→Zadanie |  |  |  | [PodmiotZadanie.md](PodmiotZadanie.md) |
| PozycjaBudzProj | Pozycje budżetu projektu | `PozycjeBudzProj` |  | root |  |  |  | [PozycjaBudzProj.md](PozycjaBudzProj.md) |
| PriorytetZadania | Priorytety zadań CRM | `PriorytetyZadan` | konfig | root |  |  |  | [PriorytetZadania.md](PriorytetZadania.md) |
| Projekt | Projekty CRM | `Projekty` |  | root |  | IBudzetowany, IEmailElement, IElementSlownika, IProjekt, IDocumentHostCRM |  | [Projekt.md](Projekt.md) |
| ProjektWykonujacy | Wykonujący projekty | `ProjektyWyk` |  |  |  |  |  | [ProjektWykonujacy.md](ProjektWykonujacy.md) |
| RecordEvent |  | `RecordEvents` |  | root |  |  |  | [RecordEvent.md](RecordEvent.md) |
| StanKoresp | Stany korespondencji | `StanyKoresp` | konfig | root |  |  |  | [StanKoresp.md](StanKoresp.md) |
| StanPlanu | Stany planów sprzedażowych | `StanyPlanu` | konfig | root |  |  |  | [StanPlanu.md](StanPlanu.md) |
| StanProjektu | Stany realizacji projektu CRM | `StanyProjektu` | konfig | root |  |  |  | [StanProjektu.md](StanProjektu.md) |
| StanZadania | Stany realizacji zadań CRM | `StanyZadania` | konfig | root |  |  |  | [StanZadania.md](StanZadania.md) |
| TowarRealizacji |  | `TowaryRealizacji` | konfig |  |  |  |  | [TowarRealizacji.md](TowarRealizacji.md) |
| TypUrzadzenia | Typy urządzeń | `TypyUrzadzen` | konfig | root |  | IRightsSource |  | [TypUrzadzenia.md](TypUrzadzenia.md) |
| TypZadania | Typy zadan | `TypyZadan` | konfig | child: Definicja→DefZadania |  |  |  | [TypZadania.md](TypZadania.md) |
| Urzadzenie | Urządzenia | `Urzadzenia` |  | root |  | IKodowany, IZasobCRM, IElementSlownika, IDocumentHostCRM |  | [Urzadzenie.md](Urzadzenie.md) |
| UrzadzenieUzyte | Urządzenia wykorzystane | `UrzadzeniaUzyte` |  |  |  |  |  | [UrzadzenieUzyte.md](UrzadzenieUzyte.md) |
| WersjaPlanu | Wersje planu dla budżetu projektu | `WersjePlanu` |  | root |  | IDokument | PlanVersionManagement (2) | [WersjaPlanu.md](WersjaPlanu.md) |
| ZadaniaDbTupleDefinitionExt | Rozszerzenia definicji krotek dla tabeli Zadania | `ZadaniaTDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition |  |  |  | [ZadaniaDbTupleDefinitionExt.md](ZadaniaDbTupleDefinitionExt.md) |
| Zadanie | Zadania i zdarzenia CRM | `Zadania` |  | root |  | ITimeTrack, IElementSlownika, IEmailElement, IDocumentHostCRM, IManagedRowInfoHost, IToDoItemHost | RodzajZadania (14) | [Zadanie.md](Zadanie.md) |
| ZadanieDnia |  | `ZadaniaDnia` |  | root |  |  |  | [ZadanieDnia.md](ZadanieDnia.md) |
| ZasobCRM | Zasoby powiązane z zadaniem | `ZasobyCRM` |  | child: Zadanie→Zadanie |  |  |  | [ZasobCRM.md](ZasobCRM.md) |
| Zespol | Role które są widoczne w aktywnościach OPZ jako zespoły | `Zespoly` | konfig | root |  |  |  | [Zespol.md](Zespol.md) |

