# Moduł `CRM` — tabele biznesowe

- Opis: Moduł zarządzania relacjami z klientami (CRM). Obsługuje ewidencję kontrahentów, osób kontaktowych, banków, urzędów oraz lokalizacji wraz z ich danymi adresowymi i kontaktowymi. Zawiera mechanizmy transakcji i leadów sprzedażowych, zdarzenia CRM, obsługę poczty elektronicznej, szablony korespondencji oraz zarządzanie opiekunami i kategoriami kontrahentów.
- Tabel: **56**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| AuthAzureConfig | Konfiguracja Aplikacji AAD | `AuthAzureConfigs` | konfig | root |  |  |  | [AuthAzureConfig.md](AuthAzureConfig.md) |
| AuthProvider | Dostawcy autoryzacji | `AuthProviders` | konfig | root |  |  | AuthProviderType (3) | [AuthProvider.md](AuthProvider.md) |
| AuthToken | Tokeny Autoryzacji | `AuthTokens` |  |  |  |  |  | [AuthToken.md](AuthToken.md) |
| AvaliableLeadState | Dostepne stany | `AvalLeadStates` | konfig |  |  |  |  | [AvaliableLeadState.md](AvaliableLeadState.md) |
| AvaliableTransactionState | Dostepne stany | `AvalTranStates` | konfig |  |  |  |  | [AvaliableTransactionState.md](AvaliableTransactionState.md) |
| Bank | Banki | `Banki` |  | root |  | IPodmiot, IKontrahent, IPodmiotKasowy, IElementSlownika, IAdresHost, IAdresyWWWHost, IDaneKontaktoweHost, IEmailElement |  | [Bank.md](Bank.md) |
| Branza | Branże | `Branze` | konfig | root |  |  |  | [Branza.md](Branza.md) |
| BranzaKth | Branże kontrahentów | `BranzeKth` |  | child: Kontrahent→Kontrahent |  |  |  | [BranzaKth.md](BranzaKth.md) |
| DefKategKth | Definicje kategorii kontrahentów | `DefKategoriiKth` | konfig | root |  | IRightsSource |  | [DefKategKth.md](DefKategKth.md) |
| DefLeada | Definicje leadów CRM | `DefLeadow` | konfig | root |  | IRightsSource, ISysNotificationHost, IWizardReferenceHost, IWfPlugInReferenceHost, IWFDefinitionHost |  | [DefLeada.md](DefLeada.md) |
| DefTransakcja | Definicje transakcji CRM | `DefTransakcji` | konfig | root |  | IRightsSource, ISysNotificationHost, IWizardReferenceHost, IWfPlugInReferenceHost, IWFDefinitionHost |  | [DefTransakcja.md](DefTransakcja.md) |
| DokumentZdarzenia | Zdarzenia | `DokumentyZdarzen` |  | root |  | IDokument |  | [DokumentZdarzenia.md](DokumentZdarzenia.md) |
| DzialalnoscKod | Wykaz kodów PDK z opisem działalności | `DzialalnoscKody` |  |  |  |  |  | [DzialalnoscKod.md](DzialalnoscKod.md) |
| ElementEmail | Elementy powiązane | `ElementyEmail` |  |  |  |  |  | [ElementEmail.md](ElementEmail.md) |
| EmailConfirmation | Potwierdzenie wiadomości | `EmailConfs` |  |  |  |  |  | [EmailConfirmation.md](EmailConfirmation.md) |
| FolderPocztowy | Folder pocztowy skrzynki | `FolderyPocztowe` |  |  |  |  |  | [FolderPocztowy.md](FolderPocztowy.md) |
| FormaPrawna | Formy prawne | `FormyPrawne` | konfig | root |  |  |  | [FormaPrawna.md](FormaPrawna.md) |
| InstytucjaFinansowaPPK | Instytucje finansowe PPK | `InstFinansowePPK` |  | root |  | IPodmiot, IKontrahent, IPodmiotKasowy, IAdresHost, IElementSlownika, IAdresyWWWHost, IDaneKontaktoweHost, IEmailElement |  | [InstytucjaFinansowaPPK.md](InstytucjaFinansowaPPK.md) |
| KategoriaKth | Tabela powiązań kategorii z kontrahentami | `KategorieKth` |  | child: Kontrahent→Kontrahent |  |  |  | [KategoriaKth.md](KategoriaKth.md) |
| KontaktOsoba | Osoby | `KontaktyOsoby` |  | root |  | IAdresHost, IKodowany, IWebOperator, IDaneKontaktoweHost, ITowaryUlubioneHost, IGIODOZgodnyHost, IGIODOWymianaDanychHost, IGIODOOświadczenieHost, IGIODOUprawnienieHost, IOceniający, IOdpowiedzialnyZaOcenę, IEmailElement, IŹródłoPowiązaniaStrukturyOrganizacyjnej, ITaskUser |  | [KontaktOsoba.md](KontaktOsoba.md) |
| KontaktWazneDaty | Ważna data | `KntktyWazneDaty` |  | root |  |  |  | [KontaktWazneDaty.md](KontaktWazneDaty.md) |
| KontoPocztowe | Konta pocztowe | `KontaPocztowe` |  | root |  | IRightsSource | AuthProviderType (3) | [KontoPocztowe.md](KontoPocztowe.md) |
| Kontrahent | Kontrahent | `Kontrahenci` |  | root |  | IPodmiot, IKontrahent, IPodmiotKasowy, IElementSlownika, IAdresHost, IKodowany, IAdresyWWWHost, IDaneKontaktoweHost, IEmailElement, IDBItemClient, IRegonHost, ITowaryUlubioneHost, IGIODOZgodnyHost, IGIODOWymianaDanychHost, IGIODOOświadczenieHost |  | [Kontrahent.md](Kontrahent.md) |
| KontrahentOddzialInfo | Oddział kontrahenta | `KontrahOddzial` |  |  |  |  |  | [KontrahentOddzialInfo.md](KontrahentOddzialInfo.md) |
| KthDzialalnKod | Wykaz działalności kontrahentów | `KthDzialalnKody` |  |  |  |  |  | [KthDzialalnKod.md](KthDzialalnKod.md) |
| Lead |  | `Leady` |  | root |  | IEmailElement, IElementSlownika |  | [Lead.md](Lead.md) |
| Lokalizacja | Lokalizacje | `Lokalizacje` |  | root |  | IDaneKontaktoweHost, IEmailElement, IAdresHost |  | [Lokalizacja.md](Lokalizacja.md) |
| OddziałZUS | Oddziały ZUS | `OddzialyZUS` |  | root |  | IAdresHost |  | [OddziałZUS.md](OddziałZUS.md) |
| OperatorSprzedazy | Operatorzy do planów | `OperatSprzedazy` |  |  |  |  |  | [OperatorSprzedazy.md](OperatorSprzedazy.md) |
| Opiekun | Opiekunowie kontrahentów | `Opiekunowie` |  | root |  |  |  | [Opiekun.md](Opiekun.md) |
| OsobaKontrahent | Kontrahent powiązany z osobą kontaktową. | `OsobyKontrahenci` |  | root |  |  |  | [OsobaKontrahent.md](OsobaKontrahent.md) |
| PodmiotPowiazany | Podmiot powiązany | `PodmiotyPow` |  |  |  |  |  | [PodmiotPowiazany.md](PodmiotPowiazany.md) |
| PodmiotTransakcja | Podmioty powiązane z transakcjami. | `PodmiotyTran` |  | child: Transakcja→Transakcja |  |  |  | [PodmiotTransakcja.md](PodmiotTransakcja.md) |
| PodpisOperatora | Podpisy operatorów | `PodpisyOper` | konfig | root |  |  |  | [PodpisOperatora.md](PodpisOperatora.md) |
| PozycjaZdarzenia | Obsługa zdarzenia | `PozycjeZdarzen` |  | child: Dokument→DokumentZdarzenia |  |  |  | [PozycjaZdarzenia.md](PozycjaZdarzenia.md) |
| PriorytetLeada | Priorytety leadów | `PriorytetyLeadow` | konfig | root |  |  |  | [PriorytetLeada.md](PriorytetLeada.md) |
| PriorytetTransakcja | Priorytety transakcji | `PriorytetyTran` | konfig | root |  |  |  | [PriorytetTransakcja.md](PriorytetTransakcja.md) |
| Region | Regiony sprzedażowe | `Regiony` | konfig | root |  | IRightsSource | RegionTypeEnum (7) | [Region.md](Region.md) |
| RegionObszar | Obszary regionów sprzedażowych | `RegionObszary` | konfig | root |  |  |  | [RegionObszar.md](RegionObszar.md) |
| RelacjaPodmiotu | Relacje podmiotów | `RelacjePodmiotow` |  |  |  |  |  | [RelacjaPodmiotu.md](RelacjaPodmiotu.md) |
| RodzajLokalizacji | Rodzaje lokalizacji | `RodzajeLok` |  |  |  |  |  | [RodzajLokalizacji.md](RodzajLokalizacji.md) |
| RolaOpiekun | Role opiekunów kontrahentów | `RoleOpiekun` | konfig | root |  |  |  | [RolaOpiekun.md](RolaOpiekun.md) |
| StanLeada | Stany leadów | `StanyLeada` | konfig | root |  |  |  | [StanLeada.md](StanLeada.md) |
| StanTransakcji | Stany transakcji | `StanyTransakcji` | konfig | root |  |  |  | [StanTransakcji.md](StanTransakcji.md) |
| StatusVAT | Statusy VAT | `StatusyVAT` |  |  |  |  |  | [StatusVAT.md](StatusVAT.md) |
| SzablonEmail | Szablony Email | `SzablonyEmail` |  | root |  | ITemplate |  | [SzablonEmail.md](SzablonEmail.md) |
| SzablonSms | Szablony SMS | `SzablonySms` | konfig | root |  | ITemplate |  | [SzablonSms.md](SzablonSms.md) |
| TemperaturaLeada | Temperatury leadów | `TempLeadow` | konfig | root |  |  |  | [TemperaturaLeada.md](TemperaturaLeada.md) |
| TemperaturaTransakcji | Temperatury transakcji | `TempTran` | konfig | root |  |  |  | [TemperaturaTransakcji.md](TemperaturaTransakcji.md) |
| Transakcja | Transakcja | `Transakcje` |  | root |  | IEmailElement, IElementSlownika |  | [Transakcja.md](Transakcja.md) |
| UrzadCelny | Urzędy celne | `UrzedyCelne` |  | root |  | IPodmiot, IKontrahent, IPodmiotKasowy, IAdresHost, IElementSlownika, IAdresyWWWHost, IDaneKontaktoweHost, IEmailElement |  | [UrzadCelny.md](UrzadCelny.md) |
| UrzadSkarbowy | Urzędy skarbowe | `UrzedySkarbowe` |  | root |  | IPodmiot, IKontrahent, IPodmiotKasowy, IAdresHost, IElementSlownika, IAdresyWWWHost, IDaneKontaktoweHost, IEmailElement |  | [UrzadSkarbowy.md](UrzadSkarbowy.md) |
| WiadomoscEmail | Wiadomości email | `WiadomosciEmail` |  | root |  | IPermissionClient | TypWiadomości (4) | [WiadomoscEmail.md](WiadomoscEmail.md) |
| WizytowkaFirmy | Wizytówki firm | `WizytowkiFirm` |  | root |  | IAdresHost, IRegonHost, IDaneKontaktoweHost, IEmailElement |  | [WizytowkaFirmy.md](WizytowkaFirmy.md) |
| ZUS | Urzędy | `ZUSY` |  | root |  | IPodmiot, IPodmiotKasowy, IAdresHost, IElementSlownika | TypUrzędu (4) | [ZUS.md](ZUS.md) |
| ZrodloKontaktu | Źródła kontaktu | `ZrodlaKontaktu` | konfig | root |  |  |  | [ZrodloKontaktu.md](ZrodloKontaktu.md) |

