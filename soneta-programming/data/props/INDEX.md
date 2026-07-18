# Indeks pól tabel biznesowych (dane wygenerowane z DLL)

Pliki w tym katalogu zostały wygenerowane wsadowo przez
`scripts/export-props-all.csx` (ta sama logika co `scan-props.csx`).
Każdy plik `<Moduł>/<RowType>.md` zawiera pełną tabelę pól jednej tabeli.
Ten INDEX to zarazem pełna inwentaryzacja modułów i tabel (moduł z `Opis`; tabela:
`RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik`).
Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Lista interfejsów i tabel je implementujących:
[Interfaces.md](Interfaces.md). Instrukcja odczytu i regeneracji: [../references/scan-props.md](../../references/scan-props.md).

- Modułów z tabelami: 37
- Tabel (plików): 1188

Aby znaleźć tabelę: wyszukaj `RowType` w tabeli poniżej i otwórz plik z kolumny `Plik`.

## BI

- Opis: Moduł Business Intelligence. Zawiera definicje kostek analitycznych, miar, wymiarów, raportów oraz mechanizmy agregacji i wizualizacji danych biznesowych.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| AnalysisArea | Obszary | `AnalysisAreas` | konfig | root |  |  | [BI/AnalysisArea.md](BI/AnalysisArea.md) |
| AnalysisAreaAppearance | Wyglądy obszarów | `AnalysisAreaApps` | konfig | child: AreaDefinition→AnalysisAreaDefinition |  |  | [BI/AnalysisAreaAppearance.md](BI/AnalysisAreaAppearance.md) |
| AnalysisAreaDefinition | Definicje obszarów | `AnalysisAreaDefs` | konfig | root |  |  | [BI/AnalysisAreaDefinition.md](BI/AnalysisAreaDefinition.md) |
| AppearanceItemDefinition | Definicje barw | `AppItemDefs` | konfig | child: Definition→AppearanceSetDefinition |  |  | [BI/AppearanceItemDefinition.md](BI/AppearanceItemDefinition.md) |
| AppearanceSetDefinition | Zestawy barw | `AppSetDefs` | konfig | root |  |  | [BI/AppearanceSetDefinition.md](BI/AppearanceSetDefinition.md) |
| BICode | Algorytmy BI | `BICodes` | konfig | root |  |  | [BI/BICode.md](BI/BICode.md) |
| ChartParam | Parametry wykresów | `ChartParams` | konfig | root |  |  | [BI/ChartParam.md](BI/ChartParam.md) |
| ColumnDefinition | Definicja kolumn danych biznesowych | `ColumnDefs` | konfig | root |  |  | [BI/ColumnDefinition.md](BI/ColumnDefinition.md) |
| DashboardItemDefinition | Definicje elementów wizualizacji | `DashBrdItemDefs` | konfig | root |  |  | [BI/DashboardItemDefinition.md](BI/DashboardItemDefinition.md) |
| DashboardItemField | Pola elementu wizualizacji | `DashBrdItemFlds` | konfig | root |  |  | [BI/DashboardItemField.md](BI/DashboardItemField.md) |
| DashboardItemFieldAppearance | Wyglądy pól elementów wizualizacji | `DashBrdItemFApps` | konfig | child: DashboardItem→DashboardItemDefinition |  |  | [BI/DashboardItemFieldAppearance.md](BI/DashboardItemFieldAppearance.md) |
| DashboardItemLocation | Lokalizacje wizualizacji | `DashItemLocs` | konfig | root |  |  | [BI/DashboardItemLocation.md](BI/DashboardItemLocation.md) |
| DashboardItemParam | Parametry elementów wizualizacji | `DashItemParams` | konfig | child: ItemDefinition→DashboardItemDefinition |  |  | [BI/DashboardItemParam.md](BI/DashboardItemParam.md) |
| DashboardViewLocation | Lokalizacje paneli BI formularzy | `DashbrdViewLocs` | konfig | root |  |  | [BI/DashboardViewLocation.md](BI/DashboardViewLocation.md) |
| DashboardViewParam | Parametry paneli BI | `DashViewParams` | konfig |  |  |  | [BI/DashboardViewParam.md](BI/DashboardViewParam.md) |
| DashboardViewParamSet | Zestawy parametrów paneli BI | `DashParamSets` | konfig |  |  |  | [BI/DashboardViewParamSet.md](BI/DashboardViewParamSet.md) |
| DataModel | Modele danych | `DataModels` | konfig | root |  | IRightsSource, IAreaHost | [BI/DataModel.md](BI/DataModel.md) |
| DataModelSerializationDefinition | Definicja serializatora modeli danych | `SerialModelDefs` | konfig | root |  |  | [BI/DataModelSerializationDefinition.md](BI/DataModelSerializationDefinition.md) |
| DataSetDefinition | Definicja danych biznesowych | `DataSetDefs` | konfig | root |  |  | [BI/DataSetDefinition.md](BI/DataSetDefinition.md) |
| DataSetGeneratorDefinition | Definicja generatora danych biznesowych | `DataSetGenDefs` | konfig | root |  |  | [BI/DataSetGeneratorDefinition.md](BI/DataSetGeneratorDefinition.md) |
| DataSource | Źródła danych | `DataSources` | konfig | root |  |  | [BI/DataSource.md](BI/DataSource.md) |
| DataSourceDatabase | Zewnętrzne źródła danych | `DataSourceDbs` | konfig | root |  |  | [BI/DataSourceDatabase.md](BI/DataSourceDatabase.md) |
| DataSpanItemAppearance | Wyglądy przedziałów danych | `DataSpanItemApps` | konfig | child: DashboardItem→DashboardItemDefinition |  |  | [BI/DataSpanItemAppearance.md](BI/DataSpanItemAppearance.md) |
| DataSpanItemDefinition | Definicje elementów przedziałów danych | `DataSpanItemDefs` | konfig | child: DataSpanSet→DataSpanSetDefinition |  |  | [BI/DataSpanItemDefinition.md](BI/DataSpanItemDefinition.md) |
| DataSpanSetDefinition | Zestawy przedziałów danych | `DataSpanSetDefs` | konfig | root |  |  | [BI/DataSpanSetDefinition.md](BI/DataSpanSetDefinition.md) |
| FieldDefinition | Definicje pól | `FieldDefs` | konfig | root |  |  | [BI/FieldDefinition.md](BI/FieldDefinition.md) |
| ModelGroupBy | Grupowania modelu | `ModelGroupBys` | konfig | root |  |  | [BI/ModelGroupBy.md](BI/ModelGroupBy.md) |
| ModelJoin | Złączenia modelu | `ModelJoins` | konfig | root |  |  | [BI/ModelJoin.md](BI/ModelJoin.md) |
| ModelOrderBy | Sortowania modelu | `ModelOrderBys` | konfig | root |  |  | [BI/ModelOrderBy.md](BI/ModelOrderBy.md) |
| ModelTable | Tabele modelu | `ModelTables` | konfig | root |  |  | [BI/ModelTable.md](BI/ModelTable.md) |
| ReportParam | Parametry raportu | `ReportParams` | konfig | root |  |  | [BI/ReportParam.md](BI/ReportParam.md) |
| SerializationDefinition | Definicja serializatora danych biznesowych | `SerializeDefs` | konfig | root |  |  | [BI/SerializationDefinition.md](BI/SerializationDefinition.md) |
| SerializationParam | Parametry utrwalania danych biznesowych | `SerializeParams` | konfig | root |  |  | [BI/SerializationParam.md](BI/SerializationParam.md) |
| SerializationViewDefinition | Definicje utrwalania list | `SerialViewDefs` | konfig | root |  |  | [BI/SerializationViewDefinition.md](BI/SerializationViewDefinition.md) |
| SerializationViewFilterSet | Zestawy filtrów dla utrwalania list | `SerialFilterSets` | konfig | root |  |  | [BI/SerializationViewFilterSet.md](BI/SerializationViewFilterSet.md) |
| SerializationViewRange | Zakresy utrwalania list | `SerialViewRanges` | konfig | root |  |  | [BI/SerializationViewRange.md](BI/SerializationViewRange.md) |
| TimeSpanDefinition | Definicje przedziałów czasowych | `TimeSpanDefs` | konfig | root |  |  | [BI/TimeSpanDefinition.md](BI/TimeSpanDefinition.md) |
| TimeSpanItem | Elementy zestawu przedziałów czasowych | `TimeSpanItems` | konfig | root |  |  | [BI/TimeSpanItem.md](BI/TimeSpanItem.md) |
| TimeSpanSet | Zestawy przedziałów czasowych | `TimeSpanSets` | konfig | root |  |  | [BI/TimeSpanSet.md](BI/TimeSpanSet.md) |

## Business

- Opis: Moduł systemowy zawierający podstawowe definicje typów danych, struktur tabel oraz obiektów bazodanowych platformy enova365. Definiuje typy proste (string, int, decimal, date itp.), konfigurację systemu, uprawnienia, powiadomienia i mechanizmy wersjonowania.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| AppToken | Tokeny aplikacyjne | `AppTokens` | konfig | root |  |  | [Business/AppToken.md](Business/AppToken.md) |
| AppTokenItem | Instancje tokena aplikacyjnego | `AppTokenItems` | konfig | root |  |  | [Business/AppTokenItem.md](Business/AppTokenItem.md) |
| AppTokenRight | Uprawnienia tokena aplikacyjnego | `AppTokenRights` | konfig | root |  |  | [Business/AppTokenRight.md](Business/AppTokenRight.md) |
| Attachment | Załączniki | `Attachments` |  |  |  | IPermissionClient | [Business/Attachment.md](Business/Attachment.md) |
| AttachmentFile | Dane binarne załączników | `AttachmentFiles` |  |  |  |  | [Business/AttachmentFile.md](Business/AttachmentFile.md) |
| CatRolRelation | Rola powiązana z kategorią. | `CatRolRelations` |  |  |  |  | [Business/CatRolRelation.md](Business/CatRolRelation.md) |
| CfgAttribute | Dane konfiguracji | `CfgAttributes` | konfig | child: Node→CfgNode |  |  | [Business/CfgAttribute.md](Business/CfgAttribute.md) |
| CfgNode | Konfiguracja | `CfgNodes` | konfig | root |  |  | [Business/CfgNode.md](Business/CfgNode.md) |
| ChangeInfo | Historia zmian | `ChangeInfos` |  |  |  |  | [Business/ChangeInfo.md](Business/ChangeInfo.md) |
| CredentialKey | Klucze Mfa | `CredentialKeys` |  | root |  |  | [Business/CredentialKey.md](Business/CredentialKey.md) |
| DBGroup | Grupy baz danych | `DBGroups` | konfig | root |  |  | [Business/DBGroup.md](Business/DBGroup.md) |
| DBGroupItem | Pozycje grupy bazy danych | `DBGroupItems` | konfig |  |  |  | [Business/DBGroupItem.md](Business/DBGroupItem.md) |
| DBItem | Bazy danych | `DBItems` | konfig | root |  | IRightsSource | [Business/DBItem.md](Business/DBItem.md) |
| DashboardArea | Obszary | `DashbrdAreas` | konfig | root |  |  | [Business/DashboardArea.md](Business/DashboardArea.md) |
| DashboardView | Panele | `DashbrdViews` | konfig | root |  | IRightsSource | [Business/DashboardView.md](Business/DashboardView.md) |
| DashboardViewAdjustment | Modyfikacje kafelków | `DashbrdViewAdjs` | konfig | child: Tile→DashboardViewTile |  |  | [Business/DashboardViewAdjustment.md](Business/DashboardViewAdjustment.md) |
| DashboardViewTile | Kafelki pulpitów | `DashbrdViewTiles` | konfig | child: Dashboard→DashboardView |  |  | [Business/DashboardViewTile.md](Business/DashboardViewTile.md) |
| DictionaryItem | Słownik | `Dictionary` |  | root |  |  | [Business/DictionaryItem.md](Business/DictionaryItem.md) |
| Entitle | Uprawnienia | `Entitles` | konfig | root |  | IEntitle | [Business/Entitle.md](Business/Entitle.md) |
| EntitleRef | Referencje uprawnień | `EntitleRefs` |  | child: Entitle→Entitle |  |  | [Business/EntitleRef.md](Business/EntitleRef.md) |
| EntitleRole | Role uprawnienia | `EntitleRoles` |  | child: Entitle→Entitle |  |  | [Business/EntitleRole.md](Business/EntitleRole.md) |
| ExternalDatabase | Zewnętrzne bazy danych | `ExtDatabases` | konfig | root |  | IRightsSource | [Business/ExternalDatabase.md](Business/ExternalDatabase.md) |
| FeatureDefinition | Definicje cechy | `FeatureDefs` | konfig | root |  |  | [Business/FeatureDefinition.md](Business/FeatureDefinition.md) |
| FeatureSetDefinition | Definicje zestawu pól | `FSDefs` | konfig | root |  |  | [Business/FeatureSetDefinition.md](Business/FeatureSetDefinition.md) |
| FeatureSetDefinitionItem | Pola danych zestawów pól | `FSDefItems` | konfig | root |  |  | [Business/FeatureSetDefinitionItem.md](Business/FeatureSetDefinitionItem.md) |
| FeatureSetRelation | Powiązania obiektów z definicjami zestawów pól | `FSRels` |  | child: FeatureSetDefinition→FeatureSetDefinition |  |  | [Business/FeatureSetRelation.md](Business/FeatureSetRelation.md) |
| FeatureTransferDefinition | Definicje transferu cechy | `FeatureTrDefs` | konfig | root |  |  | [Business/FeatureTransferDefinition.md](Business/FeatureTransferDefinition.md) |
| GuidMap |  | `GuidMaps` |  |  |  |  | [Business/GuidMap.md](Business/GuidMap.md) |
| HistAktualizacja | AktualizacjaHists | `HistAktualizacje` | konfig | root |  |  | [Business/HistAktualizacja.md](Business/HistAktualizacja.md) |
| LockInfo | Edytowane zapisy | `LockInfos` |  |  |  |  | [Business/LockInfo.md](Business/LockInfo.md) |
| NotifRead | Powiadomienia odczytane | `NotifsRead` |  |  |  |  | [Business/NotifRead.md](Business/NotifRead.md) |
| NotificationCategory | NotificationCategory | `NotifiCategories` | konfig | root |  |  | [Business/NotificationCategory.md](Business/NotificationCategory.md) |
| Operator | Operator | `Operators` | konfig | root |  | IŹródłoPowiązaniaStrukturyOrganizacyjnej, ITaskUser, IAuthorised, INoticeRecipient, IMfaOperator | [Business/Operator.md](Business/Operator.md) |
| OperatorEntitle | Uprawnienia operatora | `OperatorEntitles` | konfig | child: Operator→Operator |  |  | [Business/OperatorEntitle.md](Business/OperatorEntitle.md) |
| OperatorEx | Dodatkowe ustawienia operatora | `OperatorsEx` |  | child: Operator→Operator |  |  | [Business/OperatorEx.md](Business/OperatorEx.md) |
| PivotView | Raporty przestawne | `PivotViews` | konfig | root |  | IRightsSource | [Business/PivotView.md](Business/PivotView.md) |
| PivotViewDefaultStyle | Domyślne układy tabel przestawnych | `PivotDftStyles` | konfig | child: PivotView→PivotView |  |  | [Business/PivotViewDefaultStyle.md](Business/PivotViewDefaultStyle.md) |
| PivotViewStyle | Układy tabel przestawnych | `PivotViewStyles` | konfig | root |  |  | [Business/PivotViewStyle.md](Business/PivotViewStyle.md) |
| RecordPermission | Prawa rekordów | `RecordPerms` |  |  |  |  | [Business/RecordPermission.md](Business/RecordPermission.md) |
| RemoteFile | Informacje o plikach zdalnych | `RemoteFiles` |  |  |  |  | [Business/RemoteFile.md](Business/RemoteFile.md) |
| Right | Prawo dostępu | `Rights` |  | child: Entitle→IEntitle |  |  | [Business/Right.md](Business/Right.md) |
| RoleCategory | Kategorie roli | `RolesCategory` | konfig | root |  |  | [Business/RoleCategory.md](Business/RoleCategory.md) |
| RozlDBWlascPIT | Rozliczenia podatkowe bazy danych - PIT Właściciela | `RozlDBWlascPITy` |  |  |  |  | [Business/RozlDBWlascPIT.md](Business/RozlDBWlascPIT.md) |
| RozlDBWlascRycz | Rozliczenia podatkowe bazy danych - Ryczałt Właściciela | `RozlDBWlascRyczy` |  |  |  |  | [Business/RozlDBWlascRycz.md](Business/RozlDBWlascRycz.md) |
| RozlDBWlascZUS | Rozliczenia podatkowe bazy danych - ZUS Właściciela | `RozlDBWlascZUSy` |  |  |  |  | [Business/RozlDBWlascZUS.md](Business/RozlDBWlascZUS.md) |
| RozliczenieDB | Rozliczenia podatkowe bazy danych | `RozliczeniaDB` |  |  |  |  | [Business/RozliczenieDB.md](Business/RozliczenieDB.md) |
| RuntimeEnum | Enumy dla runtime | `RuntimeEnums` |  | child: Definition→RuntimeFieldDefinition |  |  | [Business/RuntimeEnum.md](Business/RuntimeEnum.md) |
| RuntimeFieldDefinition | Definicje pól dynamicznych | `RuntimeFieldDefs` | konfig | root |  |  | [Business/RuntimeFieldDefinition.md](Business/RuntimeFieldDefinition.md) |
| RuntimeProject | Projekty | `RuntimeProjects` | konfig | root |  |  | [Business/RuntimeProject.md](Business/RuntimeProject.md) |
| RuntimeProjectReference | Zależności projektów | `RuntimeProjRef` | konfig | child: RuntimeProject→RuntimeProject |  |  | [Business/RuntimeProjectReference.md](Business/RuntimeProjectReference.md) |
| RuntimeRowRelation | Relacje wierszy runtime | `RuntimeRowRels` |  |  |  |  | [Business/RuntimeRowRelation.md](Business/RuntimeRowRelation.md) |
| RuntimeSolution | Rozwiązania | `RuntimeSolutions` | konfig | root |  |  | [Business/RuntimeSolution.md](Business/RuntimeSolution.md) |
| SingleUseToken | Tokeny jednorazowe | `SingleUseTokens` |  | root |  |  | [Business/SingleUseToken.md](Business/SingleUseToken.md) |
| SysNotification | Powiadomienia | `SysNotifications` | konfig | root |  | IWfPlugInItemReferenceHost, IWFRecipientHost | [Business/SysNotification.md](Business/SysNotification.md) |
| SysNotificationRef | Referencje do powiadomień | `SysNotRefs` |  | child: Notification→SysNotification |  |  | [Business/SysNotificationRef.md](Business/SysNotificationRef.md) |
| SystemFile | Systemowe pliki dodatkowe | `SystemFiles` | konfig | root |  |  | [Business/SystemFile.md](Business/SystemFile.md) |
| SystemInfo | Informacja systemowa | `SystemInfos` |  |  |  |  | [Business/SystemInfo.md](Business/SystemInfo.md) |
| SystemRole | Role systemowe | `SystemRoles` | konfig | root |  | IEntitle | [Business/SystemRole.md](Business/SystemRole.md) |
| SystemRoleRef | Referencje roli | `SystemRoleRefs` |  | child: Role→SystemRole |  |  | [Business/SystemRoleRef.md](Business/SystemRoleRef.md) |
| Task | Zadania | `Tasks` |  | root |  |  | [Business/Task.md](Business/Task.md) |
| TaskDefinition | Definicje zadań | `TaskDefs` | konfig | root |  | IWizardReferenceHost, IWfPlugInItemReferenceHost, IWorkflowItemDescriptionHost, IWFRecipientHost, ISysNotificationHost, IPreviewPageHost, ISysNotificationReference | [Business/TaskDefinition.md](Business/TaskDefinition.md) |
| TaskHistoryRel | Historie zadań | `TaskHistoryRels` |  |  |  |  | [Business/TaskHistoryRel.md](Business/TaskHistoryRel.md) |
| TaskLinkedObj | Kolekcja obiektów do których task będzie podpięty. | `TaskLinkedObjs` |  |  |  |  | [Business/TaskLinkedObj.md](Business/TaskLinkedObj.md) |
| TaskTrigger | Kolekcja klas mających wpływ na przetworzenie taska | `TaskTriggers` | konfig | child: TaskDefinition→TaskDefinition |  | IWfPlugInItemReferenceHost | [Business/TaskTrigger.md](Business/TaskTrigger.md) |
| UserGroup | Grupy użytkowników | `UserGroups` | konfig | root |  | IAuthorised | [Business/UserGroup.md](Business/UserGroup.md) |
| UserGroupMember | Członkowie grupy użytkowników | `UserGroupMembers` | konfig | child: UserGroup→UserGroup |  |  | [Business/UserGroupMember.md](Business/UserGroupMember.md) |
| WizardDefinition | Definicje kreatorów | `WizardDefs` | konfig | root |  |  | [Business/WizardDefinition.md](Business/WizardDefinition.md) |
| WizardReference | Powiązania kreatorów | `WizardReferences` | konfig | child: Host→IWizardReferenceHost |  |  | [Business/WizardReference.md](Business/WizardReference.md) |
| WizardStepDefinition | Definicje kroków kreatorów | `WizardStepDefs` | konfig | root |  |  | [Business/WizardStepDefinition.md](Business/WizardStepDefinition.md) |

## CRM

- Opis: Moduł zarządzania relacjami z klientami (CRM). Obsługuje ewidencję kontrahentów, osób kontaktowych, banków, urzędów oraz lokalizacji wraz z ich danymi adresowymi i kontaktowymi. Zawiera mechanizmy transakcji i leadów sprzedażowych, zdarzenia CRM, obsługę poczty elektronicznej, szablony korespondencji oraz zarządzanie opiekunami i kategoriami kontrahentów.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| AuthAzureConfig | Konfiguracja Aplikacji AAD | `AuthAzureConfigs` | konfig | root |  |  | [CRM/AuthAzureConfig.md](CRM/AuthAzureConfig.md) |
| AuthProvider | Dostawcy autoryzacji | `AuthProviders` | konfig | root |  |  | [CRM/AuthProvider.md](CRM/AuthProvider.md) |
| AuthToken | Tokeny Autoryzacji | `AuthTokens` |  |  |  |  | [CRM/AuthToken.md](CRM/AuthToken.md) |
| AvaliableLeadState | Dostepne stany | `AvalLeadStates` | konfig |  |  |  | [CRM/AvaliableLeadState.md](CRM/AvaliableLeadState.md) |
| AvaliableTransactionState | Dostepne stany | `AvalTranStates` | konfig |  |  |  | [CRM/AvaliableTransactionState.md](CRM/AvaliableTransactionState.md) |
| Bank | Banki | `Banki` |  | root |  | IPodmiot, IKontrahent, IPodmiotKasowy, IElementSlownika, IAdresHost, IAdresyWWWHost, IDaneKontaktoweHost, IEmailElement | [CRM/Bank.md](CRM/Bank.md) |
| Branza | Branże | `Branze` | konfig | root |  |  | [CRM/Branza.md](CRM/Branza.md) |
| BranzaKth | Branże kontrahentów | `BranzeKth` |  | child: Kontrahent→Kontrahent |  |  | [CRM/BranzaKth.md](CRM/BranzaKth.md) |
| DefKategKth | Definicje kategorii kontrahentów | `DefKategoriiKth` | konfig | root |  | IRightsSource | [CRM/DefKategKth.md](CRM/DefKategKth.md) |
| DefLeada | Definicje leadów CRM | `DefLeadow` | konfig | root |  | IRightsSource, ISysNotificationHost, IWizardReferenceHost, IWfPlugInReferenceHost, IWFDefinitionHost | [CRM/DefLeada.md](CRM/DefLeada.md) |
| DefTransakcja | Definicje transakcji CRM | `DefTransakcji` | konfig | root |  | IRightsSource, ISysNotificationHost, IWizardReferenceHost, IWfPlugInReferenceHost, IWFDefinitionHost | [CRM/DefTransakcja.md](CRM/DefTransakcja.md) |
| DokumentZdarzenia | Zdarzenia | `DokumentyZdarzen` |  | root |  | IDokument | [CRM/DokumentZdarzenia.md](CRM/DokumentZdarzenia.md) |
| DzialalnoscKod | Wykaz kodów PDK z opisem działalności | `DzialalnoscKody` |  |  |  |  | [CRM/DzialalnoscKod.md](CRM/DzialalnoscKod.md) |
| ElementEmail | Elementy powiązane | `ElementyEmail` |  |  |  |  | [CRM/ElementEmail.md](CRM/ElementEmail.md) |
| EmailConfirmation | Potwierdzenie wiadomości | `EmailConfs` |  |  |  |  | [CRM/EmailConfirmation.md](CRM/EmailConfirmation.md) |
| FolderPocztowy | Folder pocztowy skrzynki | `FolderyPocztowe` |  |  |  |  | [CRM/FolderPocztowy.md](CRM/FolderPocztowy.md) |
| FormaPrawna | Formy prawne | `FormyPrawne` | konfig | root |  |  | [CRM/FormaPrawna.md](CRM/FormaPrawna.md) |
| InstytucjaFinansowaPPK | Instytucje finansowe PPK | `InstFinansowePPK` |  | root |  | IPodmiot, IKontrahent, IPodmiotKasowy, IAdresHost, IElementSlownika, IAdresyWWWHost, IDaneKontaktoweHost, IEmailElement | [CRM/InstytucjaFinansowaPPK.md](CRM/InstytucjaFinansowaPPK.md) |
| KategoriaKth | Tabela powiązań kategorii z kontrahentami | `KategorieKth` |  | child: Kontrahent→Kontrahent |  |  | [CRM/KategoriaKth.md](CRM/KategoriaKth.md) |
| KontaktOsoba | Osoby | `KontaktyOsoby` |  | root |  | IAdresHost, IKodowany, IWebOperator, IDaneKontaktoweHost, ITowaryUlubioneHost, IGIODOZgodnyHost, IGIODOWymianaDanychHost, IGIODOOświadczenieHost, IGIODOUprawnienieHost, IOceniający, IOdpowiedzialnyZaOcenę, IEmailElement, IŹródłoPowiązaniaStrukturyOrganizacyjnej, ITaskUser | [CRM/KontaktOsoba.md](CRM/KontaktOsoba.md) |
| KontaktWazneDaty | Ważna data | `KntktyWazneDaty` |  | root |  |  | [CRM/KontaktWazneDaty.md](CRM/KontaktWazneDaty.md) |
| KontoPocztowe | Konta pocztowe | `KontaPocztowe` |  | root |  | IRightsSource | [CRM/KontoPocztowe.md](CRM/KontoPocztowe.md) |
| Kontrahent | Kontrahent | `Kontrahenci` |  | root |  | IPodmiot, IKontrahent, IPodmiotKasowy, IElementSlownika, IAdresHost, IKodowany, IAdresyWWWHost, IDaneKontaktoweHost, IEmailElement, IDBItemClient, IRegonHost, ITowaryUlubioneHost, IGIODOZgodnyHost, IGIODOWymianaDanychHost, IGIODOOświadczenieHost | [CRM/Kontrahent.md](CRM/Kontrahent.md) |
| KontrahentOddzialInfo | Oddział kontrahenta | `KontrahOddzial` |  |  |  |  | [CRM/KontrahentOddzialInfo.md](CRM/KontrahentOddzialInfo.md) |
| KthDzialalnKod | Wykaz działalności kontrahentów | `KthDzialalnKody` |  |  |  |  | [CRM/KthDzialalnKod.md](CRM/KthDzialalnKod.md) |
| Lead |  | `Leady` |  | root |  | IEmailElement, IElementSlownika | [CRM/Lead.md](CRM/Lead.md) |
| Lokalizacja | Lokalizacje | `Lokalizacje` |  | root |  | IDaneKontaktoweHost, IEmailElement, IAdresHost | [CRM/Lokalizacja.md](CRM/Lokalizacja.md) |
| OddziałZUS | Oddziały ZUS | `OddzialyZUS` |  | root |  | IAdresHost | [CRM/OddziałZUS.md](CRM/OddziałZUS.md) |
| OperatorSprzedazy | Operatorzy do planów | `OperatSprzedazy` |  |  |  |  | [CRM/OperatorSprzedazy.md](CRM/OperatorSprzedazy.md) |
| Opiekun | Opiekunowie kontrahentów | `Opiekunowie` |  | root |  |  | [CRM/Opiekun.md](CRM/Opiekun.md) |
| OsobaKontrahent | Kontrahent powiązany z osobą kontaktową. | `OsobyKontrahenci` |  | root |  |  | [CRM/OsobaKontrahent.md](CRM/OsobaKontrahent.md) |
| PodmiotPowiazany | Podmiot powiązany | `PodmiotyPow` |  |  |  |  | [CRM/PodmiotPowiazany.md](CRM/PodmiotPowiazany.md) |
| PodmiotTransakcja | Podmioty powiązane z transakcjami. | `PodmiotyTran` |  | child: Transakcja→Transakcja |  |  | [CRM/PodmiotTransakcja.md](CRM/PodmiotTransakcja.md) |
| PodpisOperatora | Podpisy operatorów | `PodpisyOper` | konfig | root |  |  | [CRM/PodpisOperatora.md](CRM/PodpisOperatora.md) |
| PozycjaZdarzenia | Obsługa zdarzenia | `PozycjeZdarzen` |  | child: Dokument→DokumentZdarzenia |  |  | [CRM/PozycjaZdarzenia.md](CRM/PozycjaZdarzenia.md) |
| PriorytetLeada | Priorytety leadów | `PriorytetyLeadow` | konfig | root |  |  | [CRM/PriorytetLeada.md](CRM/PriorytetLeada.md) |
| PriorytetTransakcja | Priorytety transakcji | `PriorytetyTran` | konfig | root |  |  | [CRM/PriorytetTransakcja.md](CRM/PriorytetTransakcja.md) |
| Region | Regiony sprzedażowe | `Regiony` | konfig | root |  | IRightsSource | [CRM/Region.md](CRM/Region.md) |
| RegionObszar | Obszary regionów sprzedażowych | `RegionObszary` | konfig | root |  |  | [CRM/RegionObszar.md](CRM/RegionObszar.md) |
| RelacjaPodmiotu | Relacje podmiotów | `RelacjePodmiotow` |  |  |  |  | [CRM/RelacjaPodmiotu.md](CRM/RelacjaPodmiotu.md) |
| RodzajLokalizacji | Rodzaje lokalizacji | `RodzajeLok` |  |  |  |  | [CRM/RodzajLokalizacji.md](CRM/RodzajLokalizacji.md) |
| RolaOpiekun | Role opiekunów kontrahentów | `RoleOpiekun` | konfig | root |  |  | [CRM/RolaOpiekun.md](CRM/RolaOpiekun.md) |
| StanLeada | Stany leadów | `StanyLeada` | konfig | root |  |  | [CRM/StanLeada.md](CRM/StanLeada.md) |
| StanTransakcji | Stany transakcji | `StanyTransakcji` | konfig | root |  |  | [CRM/StanTransakcji.md](CRM/StanTransakcji.md) |
| StatusVAT | Statusy VAT | `StatusyVAT` |  |  |  |  | [CRM/StatusVAT.md](CRM/StatusVAT.md) |
| SzablonEmail | Szablony Email | `SzablonyEmail` |  | root |  | ITemplate | [CRM/SzablonEmail.md](CRM/SzablonEmail.md) |
| SzablonSms | Szablony SMS | `SzablonySms` | konfig | root |  | ITemplate | [CRM/SzablonSms.md](CRM/SzablonSms.md) |
| TemperaturaLeada | Temperatury leadów | `TempLeadow` | konfig | root |  |  | [CRM/TemperaturaLeada.md](CRM/TemperaturaLeada.md) |
| TemperaturaTransakcji | Temperatury transakcji | `TempTran` | konfig | root |  |  | [CRM/TemperaturaTransakcji.md](CRM/TemperaturaTransakcji.md) |
| Transakcja | Transakcja | `Transakcje` |  | root |  | IEmailElement, IElementSlownika | [CRM/Transakcja.md](CRM/Transakcja.md) |
| UrzadCelny | Urzędy celne | `UrzedyCelne` |  | root |  | IPodmiot, IKontrahent, IPodmiotKasowy, IAdresHost, IElementSlownika, IAdresyWWWHost, IDaneKontaktoweHost, IEmailElement | [CRM/UrzadCelny.md](CRM/UrzadCelny.md) |
| UrzadSkarbowy | Urzędy skarbowe | `UrzedySkarbowe` |  | root |  | IPodmiot, IKontrahent, IPodmiotKasowy, IAdresHost, IElementSlownika, IAdresyWWWHost, IDaneKontaktoweHost, IEmailElement | [CRM/UrzadSkarbowy.md](CRM/UrzadSkarbowy.md) |
| WiadomoscEmail | Wiadomości email | `WiadomosciEmail` |  | root |  | IPermissionClient | [CRM/WiadomoscEmail.md](CRM/WiadomoscEmail.md) |
| WizytowkaFirmy | Wizytówki firm | `WizytowkiFirm` |  | root |  | IAdresHost, IRegonHost, IDaneKontaktoweHost, IEmailElement | [CRM/WizytowkaFirmy.md](CRM/WizytowkaFirmy.md) |
| ZUS | Urzędy | `ZUSY` |  | root |  | IPodmiot, IPodmiotKasowy, IAdresHost, IElementSlownika | [CRM/ZUS.md](CRM/ZUS.md) |
| ZrodloKontaktu | Źródła kontaktu | `ZrodlaKontaktu` | konfig | root |  |  | [CRM/ZrodloKontaktu.md](CRM/ZrodloKontaktu.md) |

## Core

- Opis: Moduł podstawowy platformy enova365 zawierający wspólne obiekty biznesowe. Obejmuje kontrahentów, adresy, lokalizacje, banki, słowniki, szablony, definicje dokumentów, powiadomienia, załączniki oraz mechanizmy konfiguracji systemu.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| AdditionRowDesc | Dodatkowe informacje | `AdditionRowDescs` |  | root |  |  | [Core/AdditionRowDesc.md](Core/AdditionRowDesc.md) |
| AdresExt | Adres | `Adresy` |  | child: Host→IAdresHost |  |  | [Core/AdresExt.md](Core/AdresExt.md) |
| AdresRozszerzonyExt | Adresy rozszerzone | `AdresyRozszerzon` |  | child: Host→AdresExt |  |  | [Core/AdresRozszerzonyExt.md](Core/AdresRozszerzonyExt.md) |
| AdresWWW | Adresy WWW | `AdresyWWW` |  | child: Zapis→IAdresyWWWHost |  |  | [Core/AdresWWW.md](Core/AdresWWW.md) |
| Aktualnosc | Aktualności | `Aktualnosci` |  | root |  |  | [Core/Aktualnosc.md](Core/Aktualnosc.md) |
| CRUApiKey | Klucz API CRU | `CRUApiKeys` |  | root |  |  | [Core/CRUApiKey.md](Core/CRUApiKey.md) |
| CRUContract | Dokument CRU | `CRUContracts` |  | root |  |  | [Core/CRUContract.md](Core/CRUContract.md) |
| CelKontaktu | Cele kontaktów | `CeleKontaktow` |  |  |  |  | [Core/CelKontaktu.md](Core/CelKontaktu.md) |
| CentrumKosztow |  | `CentraKosztow` | konfig | root |  | IElementSlownika | [Core/CentrumKosztow.md](Core/CentrumKosztow.md) |
| CodeFile | Dodatkowy kod do kompilacji | `CodeFiles` | konfig | root |  |  | [Core/CodeFile.md](Core/CodeFile.md) |
| Comment | Komentarze | `Comments` |  | root |  | IDiscussionItem | [Core/Comment.md](Core/Comment.md) |
| DaneKontaktowe | Dane kontaktowe | `DaneKnt` |  | child: Host→IDaneKontaktoweHost |  |  | [Core/DaneKontaktowe.md](Core/DaneKontaktowe.md) |
| DaneKontrahenta |  | `DaneKontrahentow` |  | child: Host→IDaneKontrahentaHost |  | IDaneKontaktoweHost | [Core/DaneKontrahenta.md](Core/DaneKontrahenta.md) |
| DaneZewn | Dane z systemów zewnętrznych | `DaneZ` |  |  |  |  | [Core/DaneZewn.md](Core/DaneZewn.md) |
| DbTuple | Dokumenty dodatkowe | `Tuples` |  | root |  | IŹródłoPowiązaniaStrukturyOrganizacyjnej, IDokument, IManagedRowInfoHost, IPoświadczenieOdbioruHost | [Core/DbTuple.md](Core/DbTuple.md) |
| DbTupleDefinition | Definicje dokumentów dodatkowych | `TuplesDefs` | konfig | root |  | IRuntimeRowDefinition, IRightsSource, IManagedRowDefinion, IWizardReferenceHost, ICodeFileHost, ISysNotificationHost, IWfPlugInReferenceHost, IPreviewPageHost | [Core/DbTupleDefinition.md](Core/DbTupleDefinition.md) |
| DbTupleRel | Relacje dokumentów dodatkowych | `TuplesRelations` |  | child: DbTuple→DbTuple |  |  | [Core/DbTupleRel.md](Core/DbTupleRel.md) |
| DefDiscussion | Definicje dyskusji | `DefDiscussions` | konfig | root |  | IDiscussionPlugInHost, IRightsSource | [Core/DefDiscussion.md](Core/DefDiscussion.md) |
| DefTeczki | Definicje teczek | `DefsTeczek` | konfig | root |  | IRightsSource | [Core/DefTeczki.md](Core/DefTeczki.md) |
| DefXmlElem | Elementy definicji XML | `DefsXmlElem` | konfig | root |  |  | [Core/DefXmlElem.md](Core/DefXmlElem.md) |
| DefXmlFiltr | Filtry dla komunikatów. | `DefXmlFiltry` |  |  |  |  | [Core/DefXmlFiltr.md](Core/DefXmlFiltr.md) |
| DefXmlNag | Definicje XML | `DefsXmlNag` | konfig | root |  |  | [Core/DefXmlNag.md](Core/DefXmlNag.md) |
| DefinicjaDokumentu | Definicje dokumentów | `DefDokumentow` | konfig | root |  | IRightsSource, IDefinicjaKomunikatuEDIHost, IDefinicjaDokumentuOA | [Core/DefinicjaDokumentu.md](Core/DefinicjaDokumentu.md) |
| DefinicjaDokumentuOA | Dokument elementu opisu analitycznego | `DefDokumentowOA` | konfig | root |  |  | [Core/DefinicjaDokumentuOA.md](Core/DefinicjaDokumentuOA.md) |
| DefinicjaElementuStrukturyOrganizacyjnej | Definicje elementów struktur organizacyjnych | `DefElStrukturOrg` | konfig | root |  |  | [Core/DefinicjaElementuStrukturyOrganizacyjnej.md](Core/DefinicjaElementuStrukturyOrganizacyjnej.md) |
| DefinicjaPodzielnikaKosztow | Definicje podzielników kosztów | `DefPodzKosztow` | konfig | root |  |  | [Core/DefinicjaPodzielnikaKosztow.md](Core/DefinicjaPodzielnikaKosztow.md) |
| DefinicjaPoświadczeniaOdbioru | Definicje poświadczeń odbioru | `DefPoswOdbioru` | konfig | root |  |  | [Core/DefinicjaPoświadczeniaOdbioru.md](Core/DefinicjaPoświadczeniaOdbioru.md) |
| DefinicjaStawkiAkcyzy | Definicje stawek akcyzy | `DefStawekAkcyzy` | konfig | root |  |  | [Core/DefinicjaStawkiAkcyzy.md](Core/DefinicjaStawkiAkcyzy.md) |
| DefinicjaStawkiVat | Definicje stawek VAT | `DefStawekVat` | konfig | root |  |  | [Core/DefinicjaStawkiVat.md](Core/DefinicjaStawkiVat.md) |
| Discussion | Dyskusje | `Discussions` |  | root |  | IDiscussionItem, IDiscussionPlugInHost | [Core/Discussion.md](Core/Discussion.md) |
| DiscussionPlugIn | Rozszerzenia do dyskusji | `DiscPlugIns` | konfig | root |  |  | [Core/DiscussionPlugIn.md](Core/DiscussionPlugIn.md) |
| DiscussionPlugInRef | Powiązania rozszerzeń | `DiscPlugInRefs` |  | child: Definition→IDiscussionPlugInHost |  |  | [Core/DiscussionPlugInRef.md](Core/DiscussionPlugInRef.md) |
| DiscussionPlugInsSet | Zestawy rozszerzeń do dyskusji | `DiscPlugInsSets` | konfig | root |  | ICodeFileHost | [Core/DiscussionPlugInsSet.md](Core/DiscussionPlugInsSet.md) |
| DiscussionReaction |  | `DiscusReactions` |  |  |  |  | [Core/DiscussionReaction.md](Core/DiscussionReaction.md) |
| DiscussionReadStatus |  | `DisReadStatuses` |  |  |  |  | [Core/DiscussionReadStatus.md](Core/DiscussionReadStatus.md) |
| DiscussionRel | Relacje dyskusji | `DiscussionRels` |  | root |  |  | [Core/DiscussionRel.md](Core/DiscussionRel.md) |
| DiscussionTopic | Tematy dyskusji | `DiscussionTopics` |  | root |  | IDiscussionItem, ICommentDataHost | [Core/DiscussionTopic.md](Core/DiscussionTopic.md) |
| DiscussionUpdate | Aktualizacja dyskusji | `DiscussUpdates` |  | root |  | IDiscussionItem | [Core/DiscussionUpdate.md](Core/DiscussionUpdate.md) |
| DiscussionUser | Użytkownicy dyskusji | `DiscussionUsers` |  | root |  |  | [Core/DiscussionUser.md](Core/DiscussionUser.md) |
| DocEwidencjaDbTupleDefExt | Rozszerzenia definicji tupli dla tabeli DokEwidencja | `DEDbTupleDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition |  |  | [Core/DocEwidencjaDbTupleDefExt.md](Core/DocEwidencjaDbTupleDefExt.md) |
| DocPkg | Paczki dokumentów | `DocPkgs` |  | root |  | IDokument | [Core/DocPkg.md](Core/DocPkg.md) |
| DocPkgCfg | Kategoria elementu paczki dokumentów | `DocPkgCfgs` | konfig | root |  |  | [Core/DocPkgCfg.md](Core/DocPkgCfg.md) |
| DocPkgDef | Definicje paczek dokumentów | `DocPkgDefs` | konfig | root |  |  | [Core/DocPkgDef.md](Core/DocPkgDef.md) |
| DocPkgItem | Pozycje paczki dokumentów | `DocPkgItems` |  | root |  |  | [Core/DocPkgItem.md](Core/DocPkgItem.md) |
| DocPkgItemProp |  | `DocPkgItemProps` |  | root |  |  | [Core/DocPkgItemProp.md](Core/DocPkgItemProp.md) |
| DokEwidencji | Dokument ewidencji | `DokEwidencja` |  | root |  | IDokumentPlatny, IDaneKontrahentaHost, IRaportEwidencjiSP, IDokumentCRM, IKomunikatEDIHost, IEmailElement, IProceduraVATHost, IDigitalizedDocument | [Core/DokEwidencji.md](Core/DokEwidencji.md) |
| DokumentPowiazanyDokEwid | Dokumenty powiązane DokEwid | `DokumentyPowiazaneDokEwid` |  |  |  |  | [Core/DokumentPowiazanyDokEwid.md](Core/DokumentPowiazanyDokEwid.md) |
| DomyslnyCel | Domyślne cele rodzajów kontaktu | `DomyslneCele` | konfig | root |  |  | [Core/DomyslnyCel.md](Core/DomyslnyCel.md) |
| ElemSysWartosc | Wartości ElemSysZewn | `ElemSysWartosci` |  |  |  |  | [Core/ElemSysWartosc.md](Core/ElemSysWartosc.md) |
| ElemSysZewn | Elementy systemu zewnętrznego | `ElementySysZewn` |  |  |  |  | [Core/ElemSysZewn.md](Core/ElemSysZewn.md) |
| ElemSysZewnRelacje | Relacje elementu zewnętrznego | `ElemSysZewnRel` |  |  |  |  | [Core/ElemSysZewnRelacje.md](Core/ElemSysZewnRelacje.md) |
| ElemTeczki | Elementy teczek | `ElemTeczek` |  | child: Teczka→Teczka |  |  | [Core/ElemTeczki.md](Core/ElemTeczki.md) |
| ElementPodzielnika | Elementy podzielników | `ElemPodzielnikow` |  | child: Historia→HistoriaPodzielnika |  |  | [Core/ElementPodzielnika.md](Core/ElementPodzielnika.md) |
| ElementStrukturyOrganizacyjnej | Elementy struktur organizacyjnych | `ElementyStrOrg` |  | root |  | IPermissionClient, IElementStrukturyOrganizacyjnej | [Core/ElementStrukturyOrganizacyjnej.md](Core/ElementStrukturyOrganizacyjnej.md) |
| ElementStrukturyOrganizacyjnejRef | Zmiany elementów nadrzędnych | `ElementyStOrgRef` |  | child: Element→ElementStrukturyOrganizacyjnej |  |  | [Core/ElementStrukturyOrganizacyjnejRef.md](Core/ElementStrukturyOrganizacyjnejRef.md) |
| GIODOCelPrzetwarzania | Cele przetwarzania | `GIODOCelePrzetw` | konfig | root |  |  | [Core/GIODOCelPrzetwarzania.md](Core/GIODOCelPrzetwarzania.md) |
| GIODODefinicjaOświadczenia | Definicje oświadczeń | `GIODODefOswiadcz` | konfig | root |  | IRightsSource | [Core/GIODODefinicjaOświadczenia.md](Core/GIODODefinicjaOświadczenia.md) |
| GIODODefinicjaUprawnienia | Definicje uprawnień | `GIODODefUprawn` | konfig | root |  | IRightsSource | [Core/GIODODefinicjaUprawnienia.md](Core/GIODODefinicjaUprawnienia.md) |
| GIODOKategoriaDanychOsobowych | Kategorie danych osobowych | `GIODOKategDnOsob` | konfig | root |  |  | [Core/GIODOKategoriaDanychOsobowych.md](Core/GIODOKategoriaDanychOsobowych.md) |
| GIODOKategoriaOdbiorcow | Kategorie odbiorców | `GIODOKategOdb` | konfig | root |  |  | [Core/GIODOKategoriaOdbiorcow.md](Core/GIODOKategoriaOdbiorcow.md) |
| GIODOKategoriaOsob | Kategorie osób | `GIODOKategOsob` | konfig | root |  |  | [Core/GIODOKategoriaOsob.md](Core/GIODOKategoriaOsob.md) |
| GIODONaruszenie | Naruszenia ochrony danych osobowych | `GIODONaruszenia` |  |  |  | IDokument | [Core/GIODONaruszenie.md](Core/GIODONaruszenie.md) |
| GIODOOświadczenie | Oświadczenia | `GIODOOswiadcz` |  | root |  |  | [Core/GIODOOświadczenie.md](Core/GIODOOświadczenie.md) |
| GIODOPrzetwarzanie | Czynności przetwarzania | `GIODOPrzetwarz` |  | root |  |  | [Core/GIODOPrzetwarzanie.md](Core/GIODOPrzetwarzanie.md) |
| GIODOUprawnienie | Uprawnienia | `GIODOUprawnienia` |  | root |  |  | [Core/GIODOUprawnienie.md](Core/GIODOUprawnienie.md) |
| GIODOWycofanieOświadczenia |  | `GIODOWycofOsw` | konfig | child: Definicja→GIODODefinicjaOświadczenia |  |  | [Core/GIODOWycofanieOświadczenia.md](Core/GIODOWycofanieOświadczenia.md) |
| GIODOWymianaDanych |  | `GIODOWymDanych` |  | root |  |  | [Core/GIODOWymianaDanych.md](Core/GIODOWymianaDanych.md) |
| GIODOZbiorDanych | Zbiory danych | `GIODOZbiory` |  | root |  |  | [Core/GIODOZbiorDanych.md](Core/GIODOZbiorDanych.md) |
| GIODOZbiorKategoria | GIODO przetwarzania - kategoria | `GIODOZbioryKateg` |  |  |  |  | [Core/GIODOZbiorKategoria.md](Core/GIODOZbiorKategoria.md) |
| GIODOZgodny |  | `GIODOZgodne` |  | child: Host→IGIODOZgodnyHost |  |  | [Core/GIODOZgodny.md](Core/GIODOZgodny.md) |
| HTTPLinkInfo |  | `HTTPLinkInfos` |  | root |  |  | [Core/HTTPLinkInfo.md](Core/HTTPLinkInfo.md) |
| HistoriaDanychFirmyBase | Historia danych firmy | `HstDanychFirmy` | konfig | root |  |  | [Core/HistoriaDanychFirmyBase.md](Core/HistoriaDanychFirmyBase.md) |
| HistoriaDanychOddziału | Historia danych oddziałów firmy | `HstDanychOddzial` | konfig | root |  |  | [Core/HistoriaDanychOddziału.md](Core/HistoriaDanychOddziału.md) |
| HistoriaPodzielnika | Podzielniki kosztów | `HistPodzielnikow` |  | child: Podzielnik→PodzielnikKosztow | historia → PodzielnikKosztow |  | [Core/HistoriaPodzielnika.md](Core/HistoriaPodzielnika.md) |
| ImportExportXml | Importy, eksporty XML | `ImpExpXml` |  |  |  |  | [Core/ImportExportXml.md](Core/ImportExportXml.md) |
| IsoNumerProcedury | Numery procedur ISO | `IsoNumeryProc` | konfig | child: Procedura→IsoProcedura |  |  | [Core/IsoNumerProcedury.md](Core/IsoNumerProcedury.md) |
| IsoProcedura | Procedury ISO | `IsoProcedury` | konfig | root |  |  | [Core/IsoProcedura.md](Core/IsoProcedura.md) |
| JednolityPK | Jednolity PK | `JednolitePK` |  | root |  |  | [Core/JednolityPK.md](Core/JednolityPK.md) |
| JednolityPKRel | Jednolity PK relacja | `JednolitePKRels` |  |  |  |  | [Core/JednolityPKRel.md](Core/JednolityPKRel.md) |
| JobInvokeLog | Logi prac | `JobInvokeLogs` |  |  |  |  | [Core/JobInvokeLog.md](Core/JobInvokeLog.md) |
| JobInvokeLogDetail | Szczegółowe logi prac | `JobInvokeLogDets` |  |  |  |  | [Core/JobInvokeLogDetail.md](Core/JobInvokeLogDetail.md) |
| KDokDodatkowego | Kategorie dokumentów dodatkowych | `KDokDodatkowych` | konfig | root |  |  | [Core/KDokDodatkowego.md](Core/KDokDodatkowego.md) |
| KSeFAwaria | Awarie i przerwy w działaniu KSeF | `KSeFAwarie` |  | root |  |  | [Core/KSeFAwaria.md](Core/KSeFAwaria.md) |
| KSeFAwariaKomunikatLatarni | Komunikaty z latarnika KSeF | `KSeFAwarieKomLat` |  |  |  |  | [Core/KSeFAwariaKomunikatLatarni.md](Core/KSeFAwariaKomunikatLatarni.md) |
| KSeFIdentWewn | Identyfikatory wewnętrzne KSeF | `KSeFIdentyWewn` | konfig | root |  |  | [Core/KSeFIdentWewn.md](Core/KSeFIdentWewn.md) |
| KSeFIdentWewnRola | Role identyfikatorów wewnętrznych KSeF | `KSeFIdentWewnRole` | konfig |  |  |  | [Core/KSeFIdentWewnRola.md](Core/KSeFIdentWewnRola.md) |
| KSeFIdentWewnSprzedazMagazyn | Przypisane magazyny dla sprzedaży dla identyfikatora wewnętrznego KSeF | `KSeFIdentWewnSpMg` | konfig |  |  |  | [Core/KSeFIdentWewnSprzedazMagazyn.md](Core/KSeFIdentWewnSprzedazMagazyn.md) |
| KSeFIdentWewnSprzedazOddzial | Przypisane oddziały dla sprzedaży dla identyfikatora wewnętrznego KSeF | `KSeFIdentWewnSpOd` | konfig |  |  |  | [Core/KSeFIdentWewnSprzedazOddzial.md](Core/KSeFIdentWewnSprzedazOddzial.md) |
| KSeFIdentWewnSprzedazOperator | Przypisani operatorzy dla sprzedaży dla identyfikatora wewnętrznego KSeF | `KSeFIdentWewnSpOp` | konfig |  |  |  | [Core/KSeFIdentWewnSprzedazOperator.md](Core/KSeFIdentWewnSprzedazOperator.md) |
| KSeFKomunikat | Komunikaty KSeF | `KSeFKomunikaty` |  | root |  |  | [Core/KSeFKomunikat.md](Core/KSeFKomunikat.md) |
| KSeFPackage | Paczki dokumentów wysyłanych do KSeF | `KSeFPackages` |  | root |  |  | [Core/KSeFPackage.md](Core/KSeFPackage.md) |
| KSeFPackageElem | Elementy paczek wysyłanych do KSeF | `KSeFPackageElems` |  |  |  |  | [Core/KSeFPackageElem.md](Core/KSeFPackageElem.md) |
| KSeFPartList | KSeFZapytaniaOFaktury | `KSeFPartLists` |  |  |  |  | [Core/KSeFPartList.md](Core/KSeFPartList.md) |
| KSeFPlik | Pliki KSeF | `KSeFPliki` |  | root |  |  | [Core/KSeFPlik.md](Core/KSeFPlik.md) |
| KSeFPodmiot3 | Dane podmiotów trzecich komunikatu KSeF | `KSeFPodmioty3` |  |  |  | IDaneKontrahentaHost | [Core/KSeFPodmiot3.md](Core/KSeFPodmiot3.md) |
| KSeFSzablonPolOpcjonalnych | Szablony pól opcjonalnych KSeF | `KSeFSzblPolOp` | konfig | root |  |  | [Core/KSeFSzablonPolOpcjonalnych.md](Core/KSeFSzablonPolOpcjonalnych.md) |
| KSeFSzablonPolOpcjonalnychDefXmlNagStatus | Status aktywności szablonu dla definicji eksportu XML | `KSeFSzblPolOpDef` | konfig | root |  |  | [Core/KSeFSzablonPolOpcjonalnychDefXmlNagStatus.md](Core/KSeFSzablonPolOpcjonalnychDefXmlNagStatus.md) |
| KSeFSzablonPolOpcjonalnychPozycja | Pozycja szablonu pól opcjonalnych KSeF | `KSeFSzblPolOpPoz` | konfig | root |  |  | [Core/KSeFSzablonPolOpcjonalnychPozycja.md](Core/KSeFSzablonPolOpcjonalnychPozycja.md) |
| KSeFSzablonZalacznika | Szablon zalączników KSeF | `KSeFSzblZal` | konfig | root |  |  | [Core/KSeFSzablonZalacznika.md](Core/KSeFSzablonZalacznika.md) |
| KSeFSzablonZalacznikaDefXmlNagRelation | Status aktywności szablonu dla definicji eksportu XML | `KSeFSzblZalDefs` | konfig | root |  |  | [Core/KSeFSzablonZalacznikaDefXmlNagRelation.md](Core/KSeFSzablonZalacznikaDefXmlNagRelation.md) |
| KSeFSzablonZalacznikaElement | Element szablonu załącznika KSeF | `KSeFSzblZalElem` | konfig | root |  |  | [Core/KSeFSzablonZalacznikaElement.md](Core/KSeFSzablonZalacznikaElement.md) |
| KSeFTokenIdentWewnRel | Powiązanie tokenu systemu zewnętrznego z identyfikatorem wewnętrznym KSeF | `KSeFTokIdWewRels` |  |  |  |  | [Core/KSeFTokenIdentWewnRel.md](Core/KSeFTokenIdentWewnRel.md) |
| KSeFUPO | KSeF UPO | `KSeFUPOs` |  | root |  |  | [Core/KSeFUPO.md](Core/KSeFUPO.md) |
| KSeFZapytanieOFa | Zapytania o faktury KSeF | `KSeFZapytaniaOFa` |  | root |  |  | [Core/KSeFZapytanieOFa.md](Core/KSeFZapytanieOFa.md) |
| KodKreskowy | Kody keskowe | `KodyKreskowe` |  | child: Zapis→IKodowany |  |  | [Core/KodKreskowy.md](Core/KodKreskowy.md) |
| KodPocztowy | Tabela z kodami pocztowymi oraz odpowiadającymi im miejscowościami | `KodyPocztowe` |  |  |  |  | [Core/KodPocztowy.md](Core/KodPocztowy.md) |
| KodPocztowyAU | Tabela z kodami pocztowymi oraz odpowiadającymi im województwami | `KodyPocztoweAU` |  |  |  |  | [Core/KodPocztowyAU.md](Core/KodPocztowyAU.md) |
| KomunikatAPI | KomunikatyAPI | `KomunikatyAPI` |  |  |  |  | [Core/KomunikatAPI.md](Core/KomunikatAPI.md) |
| Konwersacja |  | `Konwersacje` |  | root |  |  | [Core/Konwersacja.md](Core/Konwersacja.md) |
| KrajSME | Kraje SME | `KrajeSME` | konfig | root | historyczna → ProceduraSME |  | [Core/KrajSME.md](Core/KrajSME.md) |
| KrajTbl | Kraje | `KrajeTbl` | konfig | root |  |  | [Core/KrajTbl.md](Core/KrajTbl.md) |
| Licznik |  | `Liczniki` |  |  |  |  | [Core/Licznik.md](Core/Licznik.md) |
| ManagedRowCreator | Kreatory wierszy | `ManagedRowCrts` | konfig | child: Definicja→IManagedRowDefinion |  |  | [Core/ManagedRowCreator.md](Core/ManagedRowCreator.md) |
| ManagedRowInfo | Informacja o przetwarzaniu przez proces | `ManagedRowsInfo` |  | child: ManagedRow→IManagedRowInfoHost |  |  | [Core/ManagedRowInfo.md](Core/ManagedRowInfo.md) |
| ManagedRowMetrics | Metryki dokumentów | `ManRowsMetrics` |  | child: ManagedRowInfo→ManagedRowInfo |  |  | [Core/ManagedRowMetrics.md](Core/ManagedRowMetrics.md) |
| ManagedRowMetricsDefinition | Definicje zapisów w metryce dokumentu | `ManRowMetricDefs` | konfig | root |  |  | [Core/ManagedRowMetricsDefinition.md](Core/ManagedRowMetricsDefinition.md) |
| MetrykaOddziałuFirmy | Przyczyny zmiany danych oddziałów firmy | `MetrykiOddzFirmy` | konfig | child: Oddzial→OddzialFirmy |  |  | [Core/MetrykaOddziałuFirmy.md](Core/MetrykaOddziałuFirmy.md) |
| Notice | Komunikaty | `Notices` |  | root |  |  | [Core/Notice.md](Core/Notice.md) |
| NoticeChannel | Kanały komunikatów | `NoticeChannels` |  | root |  | IRightsSource | [Core/NoticeChannel.md](Core/NoticeChannel.md) |
| NoticePermission | Zgody na odbiór powiadomienia | `NoticePerms` |  |  |  |  | [Core/NoticePermission.md](Core/NoticePermission.md) |
| NoticeReceipt | Potwierdzenia odbioru | `NoticeReceipts` |  | root |  |  | [Core/NoticeReceipt.md](Core/NoticeReceipt.md) |
| ObfuscateDef | Definicje zakresów zaciemniania | `ObfuscateDefs` | konfig | root |  | IRightsSource | [Core/ObfuscateDef.md](Core/ObfuscateDef.md) |
| ObfuscateField | Elementy zakresów zaciemniania | `ObfuscateFields` | konfig | child: ObfuscateDef→ObfuscateDef |  |  | [Core/ObfuscateField.md](Core/ObfuscateField.md) |
| ObfuscatedData | Zaciemnione dane | `ObfuscatedDatas` |  | root |  |  | [Core/ObfuscatedData.md](Core/ObfuscatedData.md) |
| OddzialFirmy | Oddziały firmy | `OddzialyFirmy` | konfig | root |  | IElementSlownika, IRightsSource, IAdresHost, IOddzialFirmy, IElementStrukturyFirmy, IDaneKontaktoweHost, IAdresyWWWHost | [Core/OddzialFirmy.md](Core/OddzialFirmy.md) |
| OddzialFirmyRef | Zmiany oddziałów nadrzędnych | `OddzialyFirmyRef` | konfig | child: Oddzial→OddzialFirmy |  | IMetrykaOddziałuFirmyHost | [Core/OddzialFirmyRef.md](Core/OddzialFirmyRef.md) |
| OpisPIM | Opisy PIM | `OpisyPIM` |  |  |  |  | [Core/OpisPIM.md](Core/OpisPIM.md) |
| ParametrRozlicz | Parametry rozliczeń | `ParametryRozlicz` | konfig |  |  |  | [Core/ParametrRozlicz.md](Core/ParametrRozlicz.md) |
| PodzielnikKosztow | Podzielniki kosztów | `PodzielKosztow` |  | child: Zrodlo→IZrodloPodzielnikaKosztow | historyczna → HistoriaPodzielnika |  | [Core/PodzielnikKosztow.md](Core/PodzielnikKosztow.md) |
| PowiązanieStrukturyOrganizacyjnej | Powiązania elementyów struktur organizacyjnych | `PowiazaniaStrOrg` |  | child: Zrodlo→IŹródłoPowiązaniaStrukturyOrganizacyjnej |  |  | [Core/PowiązanieStrukturyOrganizacyjnej.md](Core/PowiązanieStrukturyOrganizacyjnej.md) |
| PozycjaEwidencjiZbiorczej | Pozycje ewidencji zbiorczych | `PozEwidZbiorczej` |  | child: Ewidencja→DokEwidencji |  |  | [Core/PozycjaEwidencjiZbiorczej.md](Core/PozycjaEwidencjiZbiorczej.md) |
| PoświadczenieOdbioru | Poświadczenia odbioru | `PoswiadczOdbioru` |  | child: Dokument→IPoświadczenieOdbioruHost |  |  | [Core/PoświadczenieOdbioru.md](Core/PoświadczenieOdbioru.md) |
| ProceduraSME | Procedury SME | `ProcedurySME` | konfig | child: Kraj→KrajSME | historia → KrajSME |  | [Core/ProceduraSME.md](Core/ProceduraSME.md) |
| ProceduraVAT | Słownik procedur VAT | `ProceduryVAT` | konfig | root |  |  | [Core/ProceduraVAT.md](Core/ProceduraVAT.md) |
| RecordSequence | Kolejność rekordów | `RecordSequences` |  |  |  |  | [Core/RecordSequence.md](Core/RecordSequence.md) |
| RelProceduraVAT | Powiązania procedur VAT z dokumentami | `RelProceduryVAT` |  | root |  |  | [Core/RelProceduraVAT.md](Core/RelProceduraVAT.md) |
| RelacjaDanychZewn | Relacje danych z systemów zewnętrznych | `RelacjeDanychZ` |  |  |  |  | [Core/RelacjaDanychZewn.md](Core/RelacjaDanychZewn.md) |
| RelacjaOpisPIM |  | `RelacjeOpisowPIM` |  |  |  |  | [Core/RelacjaOpisPIM.md](Core/RelacjaOpisPIM.md) |
| RelacjaZewn | Powiązania obiektów programu z obiektami z systemów zewnętrznych | `RelacjeZewn` |  |  |  |  | [Core/RelacjaZewn.md](Core/RelacjaZewn.md) |
| RodzajDokumentuKseF | Słownik rodzajów dokumentów | `RodzajeDokKseF` |  | root |  | IRightsSource | [Core/RodzajDokumentuKseF.md](Core/RodzajDokumentuKseF.md) |
| RodzajKomunikatuHost | Rodzaje komunikatów | `RodzajeKomHost` |  |  |  |  | [Core/RodzajKomunikatuHost.md](Core/RodzajKomunikatuHost.md) |
| RodzajKontaktu | Rodzaj kontaktu | `RodzajeKontaktow` | konfig | root |  |  | [Core/RodzajKontaktu.md](Core/RodzajKontaktu.md) |
| RodzajPodmiot | Podmioty rodzaju dokumentu KSeF | `RodzajePodmioty` |  | root |  |  | [Core/RodzajPodmiot.md](Core/RodzajPodmiot.md) |
| RodzajZrodla | Rodzaje źródeł finansowania | `RodzajeZrodel` | konfig | root |  | IElementSlownika | [Core/RodzajZrodla.md](Core/RodzajZrodla.md) |
| ScheduleDefinition | Definicje harmonogramów | `ScheduleDefs` | konfig | root |  |  | [Core/ScheduleDefinition.md](Core/ScheduleDefinition.md) |
| ScheduleItem | Elementy harmonogramów | `ScheduleItems` |  |  |  |  | [Core/ScheduleItem.md](Core/ScheduleItem.md) |
| SkanerKodow | Skaner kodów | `SkaneryKodow` |  | root |  |  | [Core/SkanerKodow.md](Core/SkanerKodow.md) |
| SlownikElem | Słownik | `Slowniki` | konfig | root |  |  | [Core/SlownikElem.md](Core/SlownikElem.md) |
| SlownikPIM |  | `SlownikiPIM` |  |  |  |  | [Core/SlownikPIM.md](Core/SlownikPIM.md) |
| SlownikZewn | Słownik zewnętrzny | `SlownikiZewn` | konfig | root |  |  | [Core/SlownikZewn.md](Core/SlownikZewn.md) |
| SlownikZewnRel | SlownikiZewnRel | `SlownikiZewnRel` |  |  |  |  | [Core/SlownikZewnRel.md](Core/SlownikZewnRel.md) |
| StanTeczki | Stany teczek | `StanyTeczek` | konfig | child: Definicja→DefTeczki |  |  | [Core/StanTeczki.md](Core/StanTeczki.md) |
| StrukturaOrganizacyjna | Struktury organizacyjne | `StrukturyOrg` | konfig | root |  | IRightsSource, IStrukturaOrganizacyjna | [Core/StrukturaOrganizacyjna.md](Core/StrukturaOrganizacyjna.md) |
| Subscription | Subskrypcje | `Subscriptions` |  |  |  |  | [Core/Subscription.md](Core/Subscription.md) |
| SubstituteDef | Definicje zastępstw | `SubstituteDefs` | konfig | root |  | IRightsSource | [Core/SubstituteDef.md](Core/SubstituteDef.md) |
| SubstituteUser | Zastępstwa | `SubstituteUsers` |  | root |  |  | [Core/SubstituteUser.md](Core/SubstituteUser.md) |
| SysZewToken | Autoryzacje systemów zewnętrznych | `SysZewTokeny` | konfig | root |  | IRightsSource | [Core/SysZewToken.md](Core/SysZewToken.md) |
| SysZewnImpDef | Elementy definicji pobierania danych | `SysZewnImpDefs` |  |  |  |  | [Core/SysZewnImpDef.md](Core/SysZewnImpDef.md) |
| SysZewnStatus |  | `SysZewnStatusy` |  |  |  |  | [Core/SysZewnStatus.md](Core/SysZewnStatus.md) |
| SysZewnUsDodatkowa | Lista usług dodatkowych | `SysZewnUsDod` |  |  |  |  | [Core/SysZewnUsDodatkowa.md](Core/SysZewnUsDodatkowa.md) |
| SystemZewn | Lista systemów zewnętrznych | `SystemyZewn` | konfig | root |  |  | [Core/SystemZewn.md](Core/SystemZewn.md) |
| SystemZewnDefXmlNag | Powiązanie systemu zewnętrznego z defnicją XML | `SysZewnDefXmls` | konfig |  |  |  | [Core/SystemZewnDefXmlNag.md](Core/SystemZewnDefXmlNag.md) |
| SzablonPIM | Szablony PIM | `SzablonyPIM` | konfig | root |  |  | [Core/SzablonPIM.md](Core/SzablonPIM.md) |
| SzablonSlownikaPIM | Szablony słowników PIM | `SzablonySlowPIM` | konfig |  |  |  | [Core/SzablonSlownikaPIM.md](Core/SzablonSlownikaPIM.md) |
| Teczka | Teczki | `Teczki` |  | root |  | IPermissionClient | [Core/Teczka.md](Core/Teczka.md) |
| TerminalPlatStanowisko | Lista terminali płatniczych przypisanych do stanowiska | `TerminalPlatStan` | konfig |  |  |  | [Core/TerminalPlatStanowisko.md](Core/TerminalPlatStanowisko.md) |
| TerminalPlatniczy | Lista terminali płatniczych | `TerminalePlat` | konfig | root |  |  | [Core/TerminalPlatniczy.md](Core/TerminalPlatniczy.md) |
| ThreadCategory | Kategoria komunikacji | `ThreadCategories` | konfig |  |  |  | [Core/ThreadCategory.md](Core/ThreadCategory.md) |
| TimeTrack | Rejestracja pracy hybrydowej | `TimeTracks` |  | root |  |  | [Core/TimeTrack.md](Core/TimeTrack.md) |
| ToDoItem | Elementy do wykonania | `ToDoItems` |  |  |  |  | [Core/ToDoItem.md](Core/ToDoItem.md) |
| UIExtension | Definicje XML nagłówków lub stopek dokumentów | `UIExtensions` |  | root |  |  | [Core/UIExtension.md](Core/UIExtension.md) |
| WarningDef | Definicje warningów | `WarningDefs` | konfig | root |  |  | [Core/WarningDef.md](Core/WarningDef.md) |
| WarningDefRel | Relacje definicji warningów | `WarningDefRels` | konfig | root |  |  | [Core/WarningDefRel.md](Core/WarningDefRel.md) |
| ZadanieZewnSynch | Zadania do synchronizacji | `ZadaniaZewnSynch` |  |  |  |  | [Core/ZadanieZewnSynch.md](Core/ZadanieZewnSynch.md) |
| ZestawPodzielnikowKosztow | Zestawy podzielników kosztów | `ZestPodzKosztow` | konfig | root |  | IZrodloPodzielnikaKosztow | [Core/ZestawPodzielnikowKosztow.md](Core/ZestawPodzielnikowKosztow.md) |
| ZrodloFinansowania | Źródła finansowania | `ZrodlaFinansow` | konfig | root |  | IElementSlownika | [Core/ZrodloFinansowania.md](Core/ZrodloFinansowania.md) |

## CzlonkowieSzkolenia

- Opis: Moduł zarządzania członkami i szkoleniami organizacji. Zawiera kartotekę członków, kursy szkoleniowe, zapisy, certyfikaty oraz harmonogramy szkoleń.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| DefRodzajSzkol | Definicje rodzajów szkoleń | `DefRodzajeSzkol` | konfig | root |  |  | [CzlonkowieSzkolenia/DefRodzajSzkol.md](CzlonkowieSzkolenia/DefRodzajSzkol.md) |
| DefSkladki | Definicje składek | `DefSkladek` | konfig | root |  | IRightsSource | [CzlonkowieSzkolenia/DefSkladki.md](CzlonkowieSzkolenia/DefSkladki.md) |
| DefWyroznienia | Definicje wyróżnień | `DefWyroznien` | konfig | root |  |  | [CzlonkowieSzkolenia/DefWyroznienia.md](CzlonkowieSzkolenia/DefWyroznienia.md) |
| DefZgloszenia | Definicje zgłoszeń | `DefZgloszen` | konfig | root |  | IRightsSource | [CzlonkowieSzkolenia/DefZgloszenia.md](CzlonkowieSzkolenia/DefZgloszenia.md) |
| GrupaMaterial | Materiały | `GrupyMaterialy` |  |  |  |  | [CzlonkowieSzkolenia/GrupaMaterial.md](CzlonkowieSzkolenia/GrupaMaterial.md) |
| GrupaSzkol | Grupy szkoleniowe | `GrupySzkol` |  | root |  | IElementSlownika, IZrodloHarmWplaty, IEmailElement, IOceniany, IŹródłoOceny | [CzlonkowieSzkolenia/GrupaSzkol.md](CzlonkowieSzkolenia/GrupaSzkol.md) |
| HarmonogramWplat | Harmonogramy wpłat | `HarmWplat` |  |  |  |  | [CzlonkowieSzkolenia/HarmonogramWplat.md](CzlonkowieSzkolenia/HarmonogramWplat.md) |
| Klub |  | `Kluby` | konfig | root |  |  | [CzlonkowieSzkolenia/Klub.md](CzlonkowieSzkolenia/Klub.md) |
| KlubUcz | Kluby/koła uczestników | `KlubyUcz` |  | child: UczestnikBase→UczestnikBase |  |  | [CzlonkowieSzkolenia/KlubUcz.md](CzlonkowieSzkolenia/KlubUcz.md) |
| KlubUczHist | Przynależność do klubów | `KlubyUczHist` |  |  |  |  | [CzlonkowieSzkolenia/KlubUczHist.md](CzlonkowieSzkolenia/KlubUczHist.md) |
| ModulSzkol | Moduły szkoleniowe. | `ModulySzkol` |  |  |  |  | [CzlonkowieSzkolenia/ModulSzkol.md](CzlonkowieSzkolenia/ModulSzkol.md) |
| Odczyt |  | `Odczyty` |  | root |  |  | [CzlonkowieSzkolenia/Odczyt.md](CzlonkowieSzkolenia/Odczyt.md) |
| OdczytCzlonek | Odczyty członków | `OdczytyCzlonkow` |  |  |  |  | [CzlonkowieSzkolenia/OdczytCzlonek.md](CzlonkowieSzkolenia/OdczytCzlonek.md) |
| PrzedmiotSzkol | Przedmioty | `PrzedmiotySzkol` |  | root |  |  | [CzlonkowieSzkolenia/PrzedmiotSzkol.md](CzlonkowieSzkolenia/PrzedmiotSzkol.md) |
| RejestrUDZ | Rejestr ustawicznego doskonalenia zawodowego | `RejestryUDZ` |  | root |  |  | [CzlonkowieSzkolenia/RejestrUDZ.md](CzlonkowieSzkolenia/RejestrUDZ.md) |
| RodzajSzkol | Rodzaje szkoleń | `RodzajeSzkol` |  | root |  | IElementSlownika | [CzlonkowieSzkolenia/RodzajSzkol.md](CzlonkowieSzkolenia/RodzajSzkol.md) |
| RodzajSzkolPrzedmiot | Przedmioty | `RdzSzPrzedmioty` |  |  |  |  | [CzlonkowieSzkolenia/RodzajSzkolPrzedmiot.md](CzlonkowieSzkolenia/RodzajSzkolPrzedmiot.md) |
| RodzajSzkolUprawnienie | Uprawnienie wydawane w ramach szkolenia. | `RdzSzkUpraw` |  | root |  |  | [CzlonkowieSzkolenia/RodzajSzkolUprawnienie.md](CzlonkowieSzkolenia/RodzajSzkolUprawnienie.md) |
| RodzajSzkolWyroznienie | Wyrożnienia wydawane w ramach szkolenia. | `RdzSzkWyroz` |  |  |  |  | [CzlonkowieSzkolenia/RodzajSzkolWyroznienie.md](CzlonkowieSzkolenia/RodzajSzkolWyroznienie.md) |
| SalaSzkol | Sale szkoleniowe | `SaleSzkol` |  | root |  |  | [CzlonkowieSzkolenia/SalaSzkol.md](CzlonkowieSzkolenia/SalaSzkol.md) |
| Skladka | Składki | `Skladki` |  | root |  | IDokumentPlatny, IDokumentKsiegowalny | [CzlonkowieSzkolenia/Skladka.md](CzlonkowieSzkolenia/Skladka.md) |
| SzkOsobaPodpis | Osoba podpisująca | `SzkOsobyPodpisy` | konfig | root |  |  | [CzlonkowieSzkolenia/SzkOsobaPodpis.md](CzlonkowieSzkolenia/SzkOsobaPodpis.md) |
| TrybZajec | Tryby zajęć | `TrybyZajec` | konfig |  |  |  | [CzlonkowieSzkolenia/TrybZajec.md](CzlonkowieSzkolenia/TrybZajec.md) |
| TypDzialalUcz | Typy działalności uczestników | `TypyDzialalUcz` |  | child: UczestnikBase→UczestnikBase |  |  | [CzlonkowieSzkolenia/TypDzialalUcz.md](CzlonkowieSzkolenia/TypDzialalUcz.md) |
| TypDzialalnosci | Typy działalności | `TypyDzialalnosci` | konfig | root |  |  | [CzlonkowieSzkolenia/TypDzialalnosci.md](CzlonkowieSzkolenia/TypDzialalnosci.md) |
| TytulZawodUcz | Tytuły zawodowe uczestników | `TytulyZawodUcz` |  | child: UczestnikBase→UczestnikBase |  |  | [CzlonkowieSzkolenia/TytulZawodUcz.md](CzlonkowieSzkolenia/TytulZawodUcz.md) |
| UczFunkcja | Funkcje z wyboru | `UczFunkcje` |  | root |  |  | [CzlonkowieSzkolenia/UczFunkcja.md](CzlonkowieSzkolenia/UczFunkcja.md) |
| UczTytulZawod | Tytuły zawodowe | `UczTytulyZawod` | konfig | root |  |  | [CzlonkowieSzkolenia/UczTytulZawod.md](CzlonkowieSzkolenia/UczTytulZawod.md) |
| UczestnikBase | Uczestnicy, członkowie | `Uczestnicy` |  | root |  | IPeselHost, INipHost, IPlecHost, IGIODOZgodnyHost, IGIODOWymianaDanychHost, IGIODOOświadczenieHost, IEmailElement, IOceniany | [CzlonkowieSzkolenia/UczestnikBase.md](CzlonkowieSzkolenia/UczestnikBase.md) |
| UczestnikHist | Historia uczestników, członków | `UczestnicyHist` |  |  |  |  | [CzlonkowieSzkolenia/UczestnikHist.md](CzlonkowieSzkolenia/UczestnikHist.md) |
| UprawnienieZgloszenia | Uprawnienie zgłoszenia | `UprawZglosz` |  |  |  |  | [CzlonkowieSzkolenia/UprawnienieZgloszenia.md](CzlonkowieSzkolenia/UprawnienieZgloszenia.md) |
| WykladowcaSzkol | Wykładowcy | `WykladowcySzkol` |  | root |  | IOceniający, ITaskUser | [CzlonkowieSzkolenia/WykladowcaSzkol.md](CzlonkowieSzkolenia/WykladowcaSzkol.md) |
| Wyroznienie | Certyfikaty, odznaczenia | `Wyroznienia` |  | root |  |  | [CzlonkowieSzkolenia/Wyroznienie.md](CzlonkowieSzkolenia/Wyroznienie.md) |
| ZajecieSala |  | `ZajeciaSale` |  |  |  |  | [CzlonkowieSzkolenia/ZajecieSala.md](CzlonkowieSzkolenia/ZajecieSala.md) |
| ZajecieSzkolBase | Zajęcia | `ZajeciaSzkol` |  | root |  | IŹródłoOceny | [CzlonkowieSzkolenia/ZajecieSzkolBase.md](CzlonkowieSzkolenia/ZajecieSzkolBase.md) |
| ZajecieUczestnik | Zgłoszenia na zajęcia | `ZajeciaUcz` |  |  |  |  | [CzlonkowieSzkolenia/ZajecieUczestnik.md](CzlonkowieSzkolenia/ZajecieUczestnik.md) |
| ZajecieWykladowca | Wykładowcy | `ZajeciaWykl` |  |  |  |  | [CzlonkowieSzkolenia/ZajecieWykladowca.md](CzlonkowieSzkolenia/ZajecieWykladowca.md) |
| ZespolSzkol | Zespoły | `ZespolySzkol` |  |  |  |  | [CzlonkowieSzkolenia/ZespolSzkol.md](CzlonkowieSzkolenia/ZespolSzkol.md) |
| Zgloszenie | Zgłoszenia | `Zgloszenia` |  | root |  |  | [CzlonkowieSzkolenia/Zgloszenie.md](CzlonkowieSzkolenia/Zgloszenie.md) |
| ZgloszeniePlatnik | Płatnicy | `ZgloszeniaPlat` |  |  |  |  | [CzlonkowieSzkolenia/ZgloszeniePlatnik.md](CzlonkowieSzkolenia/ZgloszeniePlatnik.md) |
| ZgloszeniePozDok |  | `ZgloszeniaPozDok` |  |  |  |  | [CzlonkowieSzkolenia/ZgloszeniePozDok.md](CzlonkowieSzkolenia/ZgloszeniePozDok.md) |
| ZgloszenieUczGrupa | Zgłoszenia na grupę. | `ZgloszeniaUczGrp` |  |  |  |  | [CzlonkowieSzkolenia/ZgloszenieUczGrupa.md](CzlonkowieSzkolenia/ZgloszenieUczGrupa.md) |
| ZgloszenieUczestnik | Uczestnicy | `ZgloszeniaUczest` |  |  |  | IZrodloHarmWplaty, IEmailElement | [CzlonkowieSzkolenia/ZgloszenieUczestnik.md](CzlonkowieSzkolenia/ZgloszenieUczestnik.md) |

## Deklaracje

- Opis: Moduł obsługujący deklaracje podatkowe i sprawozdawcze. Zawiera szablony deklaracji, formularze XML, mechanizmy generowania i wysyłki deklaracji do urzędów.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| Deklaracja |  | `Deklaracje` |  | root |  | IDeklaracja, IDokumentPlatny, IDokumentKsiegowalny, IBazaZrodlaWyplaty, IEmailElement, IZrodloOpisuAnalitycznego | [Deklaracje/Deklaracja.md](Deklaracje/Deklaracja.md) |
| EDeklaracja | eDeklaracja | `EDeklaracje` |  |  |  |  | [Deklaracje/EDeklaracja.md](Deklaracje/EDeklaracja.md) |
| ETransmisja | eTransmisja | `ETransmisje` |  |  |  |  | [Deklaracje/ETransmisja.md](Deklaracje/ETransmisja.md) |

## Delegacje

- Opis: Moduł obsługujący delegacje służbowe. Zawiera definicje delegacji, etapy podróży, diety, koszty przejazdów, noclegi oraz rozliczenia delegacji pracowników.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| Delegacja | Delegacje PWS | `Delegacje` |  | root |  | IZrodloOpisuAnalitycznego | [Delegacje/Delegacja.md](Delegacje/Delegacja.md) |
| EtapDelegacji | Etapy delegacji | `EtapyDelegacji` |  | child: Delegacja→Delegacja |  |  | [Delegacje/EtapDelegacji.md](Delegacje/EtapDelegacji.md) |
| KosztDelegacji | Koszty etapu delegacji | `KosztyDelegacji` |  | root |  |  | [Delegacje/KosztDelegacji.md](Delegacje/KosztDelegacji.md) |
| KrajDelegacji | Kraje delegacji | `KrajeDelegacji` | konfig | root | historyczna → StawkaDelegacji | IRowWithHistory, IKrajDelegacji | [Delegacje/KrajDelegacji.md](Delegacje/KrajDelegacji.md) |
| KwotaNaliczeniaDelegacji | Kwoty naliczenia delegacji | `KwotaNalDeleg` |  | child: Naliczenie→NaliczenieDelegacji |  |  | [Delegacje/KwotaNaliczeniaDelegacji.md](Delegacje/KwotaNaliczeniaDelegacji.md) |
| NaliczenieDelegacji | Naliczenia pośrednie delegacji | `NalDelegacji` |  | child: Delegacja→Delegacja |  |  | [Delegacje/NaliczenieDelegacji.md](Delegacje/NaliczenieDelegacji.md) |
| StawkaDelegacji | Stawki delegacji | `StawkiDelegacji` | konfig | child: Kraj→KrajDelegacji | historia → KrajDelegacji |  | [Delegacje/StawkaDelegacji.md](Delegacje/StawkaDelegacji.md) |
| ZakupWalutDoDelegacji | Pozyskanie | `ZakupyWalutDeleg` |  | child: Delegacja→Delegacja |  |  | [Delegacje/ZakupWalutDoDelegacji.md](Delegacje/ZakupWalutDoDelegacji.md) |
| ZaliczkaDelegacji | Zaliczki do delegacji | `ZaliczkiDeleg` |  | child: Delegacja→Delegacja |  |  | [Delegacje/ZaliczkaDelegacji.md](Delegacje/ZaliczkaDelegacji.md) |

## Dms

- Opis: Moduł zarządzania dokumentami (DMS). Zawiera rejestry dokumentów, kategorie, statusy, obiegi oraz mechanizmy archiwizacji i wersjonowania dokumentów.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| BDocBusEnt | Podmioty związane z dokumentem | `BDocBusEnts` |  |  |  |  | [Dms/BDocBusEnt.md](Dms/BDocBusEnt.md) |
| BasicDocKind | Rodzaje dokumentów podstawowych | `BasicDocKinds` |  | root |  |  | [Dms/BasicDocKind.md](Dms/BasicDocKind.md) |
| BasicDocument | Dokumenty podstawowe | `BasicDocs` |  | root |  | IPermissionClient, IEmailElement, IDaneKontrahentaHost, IDokument, IChronoOrderHost, IDmsArchInfoHost | [Dms/BasicDocument.md](Dms/BasicDocument.md) |
| BasicDocumentDefinition | Definicje dokumentów podstawowych | `BasicDocDefs` | konfig | root |  | IRightsSource, IChronoOrderHostDefinition | [Dms/BasicDocumentDefinition.md](Dms/BasicDocumentDefinition.md) |
| ChronoOrdDefEn | Dostępność składu chronologicznego | `ChronoOrdDefEns` | konfig | root |  |  | [Dms/ChronoOrdDefEn.md](Dms/ChronoOrdDefEn.md) |
| ChronoOrder | Składy chronologiczne | `ChronoOrders` |  | root |  | IDefinicjaDokumentu, IPermissionClient | [Dms/ChronoOrder.md](Dms/ChronoOrder.md) |
| ChronoOrderElem | Elementy składu chronologicznego | `ChronoOrderElems` |  | root |  | IDokument, IDmsArchInfoHost | [Dms/ChronoOrderElem.md](Dms/ChronoOrderElem.md) |
| ChronoOrderLoc | Lokalizacje składów | `ChronoOrderLocs` |  | root |  | IPermissionClient | [Dms/ChronoOrderLoc.md](Dms/ChronoOrderLoc.md) |
| DmsArchInfo | Informacje o archiwum dokumentów | `DmsArchInfos` |  |  |  |  | [Dms/DmsArchInfo.md](Dms/DmsArchInfo.md) |
| DmsState | Status DMS | `DmsStates` | konfig | root |  |  | [Dms/DmsState.md](Dms/DmsState.md) |
| DmsStateDef | Definicje statusów DMS | `DmsStateDefs` | konfig | root |  |  | [Dms/DmsStateDef.md](Dms/DmsStateDef.md) |
| Matter | Sprawy | `Matters` |  | root |  | IPermissionClient, IEmailAttachmentsHolder, IEmailElement, IDokument, IDmsArchInfoHost | [Dms/Matter.md](Dms/Matter.md) |
| MatterDefinition | Definicje spraw | `MatterDefs` | konfig | root |  | IRightsSource | [Dms/MatterDefinition.md](Dms/MatterDefinition.md) |
| OcrBusinessMapping | Formaty mapowania OCR | `OcrBusMappings` | konfig | root |  |  | [Dms/OcrBusinessMapping.md](Dms/OcrBusinessMapping.md) |
| OcrBusinessMappingElement | Pozycje formatu mapowania OCR | `OcrBusMapElems` | konfig | root |  |  | [Dms/OcrBusinessMappingElement.md](Dms/OcrBusinessMappingElement.md) |
| OcrBusinessMappingOutput | Wyniki mapowania OCR | `OcrBusMapOutputs` |  |  |  |  | [Dms/OcrBusinessMappingOutput.md](Dms/OcrBusinessMappingOutput.md) |
| Register | Rejestry dokumentów podstawowych | `Registers` | konfig | root |  |  | [Dms/Register.md](Dms/Register.md) |
| UnifiedRegister | Wykazy akt | `UnifiedRgs` | konfig | root |  |  | [Dms/UnifiedRegister.md](Dms/UnifiedRegister.md) |
| UnifiedRegisterClass | Klasy wykazów akt | `UnifiedRgClasses` | konfig | root |  |  | [Dms/UnifiedRegisterClass.md](Dms/UnifiedRegisterClass.md) |

## EwidencjaVat

- Opis: Moduł ewidencji VAT. Zawiera rejestry VAT zakupu i sprzedaży, deklaracje VAT, pliki JPK oraz mechanizmy kontroli i raportowania podatku VAT.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| DefinicjaPowstaniaObowiazkuVAT | Definicje powstania obowiązku VAT | `DefinicjePOVAT` | konfig | root |  |  | [EwidencjaVat/DefinicjaPowstaniaObowiazkuVAT.md](EwidencjaVat/DefinicjaPowstaniaObowiazkuVAT.md) |
| ElemEwidencjiVATAkcyzy | Elementy ewidencji VAT | `EleEwidencjiVATT` |  | child: Naglowek→NagEwidencjiVATAkcyzy |  | IZrodloOpisuAnalitycznego | [EwidencjaVat/ElemEwidencjiVATAkcyzy.md](EwidencjaVat/ElemEwidencjiVATAkcyzy.md) |
| ElemRozliczeniaVATAkcyzy | Elementy rozliczen VAT | `EleRozliczenVATT` |  | child: Naglowek→NagRozliczeniaVATAkcyzy |  |  | [EwidencjaVat/ElemRozliczeniaVATAkcyzy.md](EwidencjaVat/ElemRozliczeniaVATAkcyzy.md) |
| NagEwidencjiVATAkcyzy | Nagłóweki ewidencji VAT | `NagEwidencjiVATT` |  | child: Ewidencja→DokEwidencji |  |  | [EwidencjaVat/NagEwidencjiVATAkcyzy.md](EwidencjaVat/NagEwidencjiVATAkcyzy.md) |
| NagRozliczeniaVATAkcyzy | Nagłówki rozliczeń VAT | `NagRozliczenVATT` |  | child: Naglowek→NagEwidencjiVATAkcyzy |  |  | [EwidencjaVat/NagRozliczeniaVATAkcyzy.md](EwidencjaVat/NagRozliczeniaVATAkcyzy.md) |

## HR

- Opis: Moduł zarządzania zasobami ludzkimi (HR). Zawiera strukturę organizacyjną, stanowiska, kompetencje, oceny pracownicze, szkolenia, rekrutację oraz planowanie kariery.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| AspektKompetencjiMerytorycznej | Aspekty kompetencji merytorycznych | `ZklAspKmpMery` | konfig | root |  |  | [HR/AspektKompetencjiMerytorycznej.md](HR/AspektKompetencjiMerytorycznej.md) |
| AspektKompetencjiUniwersalnej | Aspekty kompetencji uniwersalnych | `ZklAspKmpUniw` | konfig | root |  |  | [HR/AspektKompetencjiUniwersalnej.md](HR/AspektKompetencjiUniwersalnej.md) |
| AspektPoziomKompetencjiMerytorycznej |  | `ZklAspPozMery` | konfig |  |  |  | [HR/AspektPoziomKompetencjiMerytorycznej.md](HR/AspektPoziomKompetencjiMerytorycznej.md) |
| AspektPoziomKompetencjiUniwersalnej |  | `ZklAspPozUniw` | konfig |  |  |  | [HR/AspektPoziomKompetencjiUniwersalnej.md](HR/AspektPoziomKompetencjiUniwersalnej.md) |
| BadaniaLekarskieDefinicjiStanowiska | Badania lekarskie defincji stanowisk | `BadLekDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  | [HR/BadaniaLekarskieDefinicjiStanowiska.md](HR/BadaniaLekarskieDefinicjiStanowiska.md) |
| Benefit | Benefity | `ZklBenefity` | konfig | root |  | IZklPozycjaSlownika | [HR/Benefit.md](HR/Benefit.md) |
| BudżetSzkoleń | Budżety szkoleń | `BudzetySzkolen` |  | root |  |  | [HR/BudżetSzkoleń.md](HR/BudżetSzkoleń.md) |
| CzynnikSzkodliwyDefinicjiStanowiska | Czynniki szkodliwe defincji stanowisk | `CzynSzkodDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  | [HR/CzynnikSzkodliwyDefinicjiStanowiska.md](HR/CzynnikSzkodliwyDefinicjiStanowiska.md) |
| CzynnoscZadania | Czynności zadań | `ZklCzynnZadan` | konfig | root |  |  | [HR/CzynnoscZadania.md](HR/CzynnoscZadania.md) |
| DefElementuOcenyPracownika | Definicje kryteriów ocen | `DefElemOcenPrac` | konfig | root |  |  | [HR/DefElementuOcenyPracownika.md](HR/DefElementuOcenyPracownika.md) |
| DefinicjaEtapuRekrutacji | Etapy rekrutacji | `DefEtaRekrutacji` | konfig | root |  |  | [HR/DefinicjaEtapuRekrutacji.md](HR/DefinicjaEtapuRekrutacji.md) |
| DefinicjaFunkcji | Definicje funkcji | `DefinicjeFunkcji` | konfig | root |  |  | [HR/DefinicjaFunkcji.md](HR/DefinicjaFunkcji.md) |
| DefinicjaPlanowaniaZasobow | Definicje planowania zasobów | `DefPlanZasob` | konfig | root |  |  | [HR/DefinicjaPlanowaniaZasobow.md](HR/DefinicjaPlanowaniaZasobow.md) |
| DefinicjaStanowiska | Definicje stanowisk | `DefStanowisk` | konfig | root | historyczna → DefinicjaStanowiskaHist | IŹródłoKartyOpisuStanowiska | [HR/DefinicjaStanowiska.md](HR/DefinicjaStanowiska.md) |
| DefinicjaStanowiskaHist | Definicje stanowisk historia | `DefStanowiskHist` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska | historia → DefinicjaStanowiska |  | [HR/DefinicjaStanowiskaHist.md](HR/DefinicjaStanowiskaHist.md) |
| DefinicjaStanowiskaHistZkl | Dane ZKL historii definicji stanowisk | `ZklDefStanHist` | konfig | child: DefinicjaStanowiskaHist→DefinicjaStanowiskaHist |  |  | [HR/DefinicjaStanowiskaHistZkl.md](HR/DefinicjaStanowiskaHistZkl.md) |
| DefinicjaSzkolenia | Definicje szkoleń | `DefinicjeSzkolen` |  | root |  | IZklPozycjaSlownika, IPozycjaKonfiguratora | [HR/DefinicjaSzkolenia.md](HR/DefinicjaSzkolenia.md) |
| DefinicjaUprawnienia | Definicje uprawnień | `DefUprawnien` |  | root |  | IManagedRowDefinion, IZklPozycjaSlownika, IPozycjaKonfiguratora | [HR/DefinicjaUprawnienia.md](HR/DefinicjaUprawnienia.md) |
| DodatkowaKwalifikacjaZawodowa | Dodatkowe kwalifikacje zawodowe | `ZklDodKwalZwd` | konfig | root |  | IZklPozycjaSlownika | [HR/DodatkowaKwalifikacjaZawodowa.md](HR/DodatkowaKwalifikacjaZawodowa.md) |
| DokumentDefinicjiStanowiska | Dokumenty defincji stanowisk | `DokumentyDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  | [HR/DokumentDefinicjiStanowiska.md](HR/DokumentDefinicjiStanowiska.md) |
| DokumentPlanowaniaZasobow | Dokumenty planowania zasobów | `DokPlanZasob` |  | root |  |  | [HR/DokumentPlanowaniaZasobow.md](HR/DokumentPlanowaniaZasobow.md) |
| DokumentProcedura | Dokumenty i procedury | `ZklDokProc` | konfig | root |  | IZklPozycjaSlownika | [HR/DokumentProcedura.md](HR/DokumentProcedura.md) |
| DostawcaSzkoleń | Dostawcy szkoleń | `DostawcySzkolen` |  | root |  |  | [HR/DostawcaSzkoleń.md](HR/DostawcaSzkoleń.md) |
| DostepDoSystemow | Dostępy do systemów | `ZklDostSys` | konfig | root |  | IZklPozycjaSlownika | [HR/DostepDoSystemow.md](HR/DostepDoSystemow.md) |
| ElementOcenyPracownika | Kryteria | `ElementyOcenPrac` |  | child: Ocena→IOcenaPracownika |  |  | [HR/ElementOcenyPracownika.md](HR/ElementOcenyPracownika.md) |
| ElementWzoruOcenyPracownika | Kryteria | `ElemWzorowOcPrac` | konfig | child: Wzor→WzorOcenyPracownika |  |  | [HR/ElementWzoruOcenyPracownika.md](HR/ElementWzoruOcenyPracownika.md) |
| EtapRealizacjiSzkolenia | Etapy realizacji szkoleń | `EtapRealizSzkol` | konfig | root |  |  | [HR/EtapRealizacjiSzkolenia.md](HR/EtapRealizacjiSzkolenia.md) |
| EtapRekrutacji | Etapy rekrutacji | `EtapyRekrutacji` |  | root |  | IOcenaPracownika | [HR/EtapRekrutacji.md](HR/EtapRekrutacji.md) |
| FormularzWartosciowania | Formularze wartościowania | `ZklFormularzWart` |  |  |  |  | [HR/FormularzWartosciowania.md](HR/FormularzWartosciowania.md) |
| GrupaKompetencjiMerytorycznych | Katalog kompetencji merytorycznych | `ZklKtgKmpMery` | konfig | root |  | IZklPozycjaSlownika | [HR/GrupaKompetencjiMerytorycznych.md](HR/GrupaKompetencjiMerytorycznych.md) |
| GrupaKompetencjiUniwersalnych | Katalog kompetencji uniwersalnych | `ZklKtgKmpUniw` | konfig | root |  | IZklPozycjaSlownika | [HR/GrupaKompetencjiUniwersalnych.md](HR/GrupaKompetencjiUniwersalnych.md) |
| GrupaStanowisk | Grupy stanowisk | `GrupaStanow` | konfig | root |  | IZklPozycjaSlownika | [HR/GrupaStanowisk.md](HR/GrupaStanowisk.md) |
| GrupaSzkolenIUprawnien | Grupy szkoleń i uprawnień | `ZklGrSzkolUpr` | konfig | root |  | IZklPozycjaSlownika | [HR/GrupaSzkolenIUprawnien.md](HR/GrupaSzkolenIUprawnien.md) |
| GrupaZadan | Katalog zadań | `ZklKtgZadan` | konfig | root |  | IZklPozycjaSlownika | [HR/GrupaZadan.md](HR/GrupaZadan.md) |
| GrupaZaszeregowaniaDefinicjiStanowiska | Grupy zaszeregowania defincji stanowisk | `GrupZasDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  | [HR/GrupaZaszeregowaniaDefinicjiStanowiska.md](HR/GrupaZaszeregowaniaDefinicjiStanowiska.md) |
| KategoriaGrupyStanowisk | Kategorie grup stanowisk | `KatGrupyStan` | konfig | root |  | IZklPozycjaSlownika | [HR/KategoriaGrupyStanowisk.md](HR/KategoriaGrupyStanowisk.md) |
| KategoriaPracownika | Kategorie pracowników | `KatPrac` | konfig | root |  |  | [HR/KategoriaPracownika.md](HR/KategoriaPracownika.md) |
| KategoriaSzkolenia | Kategorie szkoleń | `KategorieSzkolen` | konfig | root |  |  | [HR/KategoriaSzkolenia.md](HR/KategoriaSzkolenia.md) |
| KategoriaUprawnienia | Kategorie uprawnień | `KatUprawnien` | konfig | root |  |  | [HR/KategoriaUprawnienia.md](HR/KategoriaUprawnienia.md) |
| KategoriePracownikow | Kategorie pracowników | `ZklKatPrac` | konfig | root |  | IZklPozycjaSlownika | [HR/KategoriePracownikow.md](HR/KategoriePracownikow.md) |
| KierunekKsztalceniaSzkolySrednie | Kierunki kształcenia szkoły średnie | `ZklKierKszSre` | konfig | root |  | IZklPozycjaSlownika | [HR/KierunekKsztalceniaSzkolySrednie.md](HR/KierunekKsztalceniaSzkolySrednie.md) |
| KierunekKsztalceniaSzkolyWyzsze | Kierunki kształcenia szkoły wyższe | `ZklKierKszWyz` | konfig | root |  | IZklPozycjaSlownika | [HR/KierunekKsztalceniaSzkolyWyzsze.md](HR/KierunekKsztalceniaSzkolyWyzsze.md) |
| KierunekKsztalceniaSzkolyZawodowe | Kierunki kształcenia szkoły zawodowe | `ZklKierKszZwd` | konfig | root |  | IZklPozycjaSlownika | [HR/KierunekKsztalceniaSzkolyZawodowe.md](HR/KierunekKsztalceniaSzkolyZawodowe.md) |
| KompetencjaMerytoryczna | Kompetencje merytoryczne | `ZklKmpMery` | konfig | root |  | IZklPozycjaSlownika, IPozycjaKonfiguratora | [HR/KompetencjaMerytoryczna.md](HR/KompetencjaMerytoryczna.md) |
| KompetencjaUniwersalna | Kompetencje uniwersalne | `ZklKmpUniw` | konfig | root |  | IZklPozycjaSlownika, IPozycjaKonfiguratora | [HR/KompetencjaUniwersalna.md](HR/KompetencjaUniwersalna.md) |
| KryteriumAnalityczne | Kryteria analityczne | `ZklKrytAnality` | konfig | root |  |  | [HR/KryteriumAnalityczne.md](HR/KryteriumAnalityczne.md) |
| KryteriumSyntetyczne | Kryteria syntetyczne | `ZklKrytSynt` | konfig | root |  |  | [HR/KryteriumSyntetyczne.md](HR/KryteriumSyntetyczne.md) |
| KsuDefinicjaInfo | Informacje pozycji KSU | `ZklKsuDefInfo` | konfig | root |  |  | [HR/KsuDefinicjaInfo.md](HR/KsuDefinicjaInfo.md) |
| KsuGrupaStanowisk | Powiązania informacji KSU z grupami stanowisk | `ZklKsuGrStan` | konfig | root |  |  | [HR/KsuGrupaStanowisk.md](HR/KsuGrupaStanowisk.md) |
| KsuObszarFunkcjonalny | Powiązania informacji KSU z obszarami funkcjonalnymi | `ZklKsuObszFun` | konfig | root |  |  | [HR/KsuObszarFunkcjonalny.md](HR/KsuObszarFunkcjonalny.md) |
| KsuSzkoleniePoprzedzajace | Powiązania informacji KSU ze szkoleniami poprzedzającymi | `ZklKsuSzkPop` | konfig | root |  |  | [HR/KsuSzkoleniePoprzedzajace.md](HR/KsuSzkoleniePoprzedzajace.md) |
| KsuUprawnieniePoprzedzajace | Powiązania informacji KSU z uprawnieniami poprzedzającymi | `ZklKsuUprPop` | konfig | root |  |  | [HR/KsuUprawnieniePoprzedzajace.md](HR/KsuUprawnieniePoprzedzajace.md) |
| KwalifikacjePracownikaZkl | Kwalifikacje pracownika | `ZKLKwalPrac` |  | child: Pracownik→Pracownik |  |  | [HR/KwalifikacjePracownikaZkl.md](HR/KwalifikacjePracownikaZkl.md) |
| MacierzWartosciowania | Macierze kryteriów wartościowania | `ZklWrtMacierz` |  |  |  |  | [HR/MacierzWartosciowania.md](HR/MacierzWartosciowania.md) |
| MnoznikMacierzyWartosciowania | Mnożniki macierzy kryteriów wartościowania | `ZklWrtMxMnozniki` |  |  |  |  | [HR/MnoznikMacierzyWartosciowania.md](HR/MnoznikMacierzyWartosciowania.md) |
| ObslugaMaszynIUrzadzen | Obsługa maszyn i urządzeń | `ZklObsMaszUrz` | konfig | root |  | IZklPozycjaSlownika | [HR/ObslugaMaszynIUrzadzen.md](HR/ObslugaMaszynIUrzadzen.md) |
| ObszarFunkcjonalny | Obszary funkcjonalne | `ZklObszrFunk` | konfig | root |  | IZklPozycjaSlownika | [HR/ObszarFunkcjonalny.md](HR/ObszarFunkcjonalny.md) |
| ObszarOdpowiedzialnosciPracownikaZkl | Obszary odpowiedzialności pracownika | `ZklObszOdpPrac` |  | child: Pracownik→Pracownik |  |  | [HR/ObszarOdpowiedzialnosciPracownikaZkl.md](HR/ObszarOdpowiedzialnosciPracownikaZkl.md) |
| ObszarOdpowiedzialnosciStanowiska | Obszary odpowiedzialności stanowiska | `ZklObszOdp` | konfig | child: Stanowisko→DefinicjaStanowiska |  |  | [HR/ObszarOdpowiedzialnosciStanowiska.md](HR/ObszarOdpowiedzialnosciStanowiska.md) |
| OcenaPracownika | Oceny pracowników | `OcenyPracownikow` |  | root |  | IOcenaPracownika | [HR/OcenaPracownika.md](HR/OcenaPracownika.md) |
| Odpowiedzialnosc | Katalog odpowiedzialności | `ZklKtgOdp` | konfig | root |  | IZklPozycjaSlownika, IPozycjaKonfiguratora | [HR/Odpowiedzialnosc.md](HR/Odpowiedzialnosc.md) |
| OfertaSzkolenia | Oferty szkoleń | `OfertySzkolen` |  | root |  | IAdresHost | [HR/OfertaSzkolenia.md](HR/OfertaSzkolenia.md) |
| OkresDoswiadczeniaZawodowego | Okresy doświadczenia zawodowego | `ZklOkrDosZwd` | konfig | root |  | IZklPozycjaSlownika | [HR/OkresDoswiadczeniaZawodowego.md](HR/OkresDoswiadczeniaZawodowego.md) |
| PowiazanieDefStanSlownikiZkl | Powiązania stanowisk z pozycjami słowników ZKL | `PowDefStZklSlw` | konfig | root |  |  | [HR/PowiazanieDefStanSlownikiZkl.md](HR/PowiazanieDefStanSlownikiZkl.md) |
| PowiazanieDefinicjiStanowisk | Powiązania definicji stanowisk | `PowDefStan` | konfig | root |  |  | [HR/PowiazanieDefinicjiStanowisk.md](HR/PowiazanieDefinicjiStanowisk.md) |
| PoziomRozwojuKompetencjiMerytorycznych | Poziomy rozwoju kompetencji merytorycznych | `ZklPozRozKomMer` | konfig | root |  | IZklPozycjaSlownika | [HR/PoziomRozwojuKompetencjiMerytorycznych.md](HR/PoziomRozwojuKompetencjiMerytorycznych.md) |
| PoziomRozwojuKompetencjiUniwersalnych | Poziomy rozwoju kompetencji uniwersalnych | `ZklPozRozKomUni` | konfig | root |  | IZklPozycjaSlownika | [HR/PoziomRozwojuKompetencjiUniwersalnych.md](HR/PoziomRozwojuKompetencjiUniwersalnych.md) |
| PoziomUmiejetnosci | Poziomy umiejętności | `ZklPozUmiejet` | konfig | root |  | IZklPozycjaSlownika | [HR/PoziomUmiejetnosci.md](HR/PoziomUmiejetnosci.md) |
| PoziomWyksztalcenia | Poziomy wykształcenia | `ZklPozWykszt` | konfig | root |  | IZklPozycjaSlownika | [HR/PoziomWyksztalcenia.md](HR/PoziomWyksztalcenia.md) |
| PozycjaDokumentuPlanowaniaZasobow | Pozycje dokumentów planowania zasobów | `PozDokPlanZasob` |  | child: Dokument→DokumentPlanowaniaZasobow |  |  | [HR/PozycjaDokumentuPlanowaniaZasobow.md](HR/PozycjaDokumentuPlanowaniaZasobow.md) |
| PozycjaDoswiadczeniaProfiluGrupa | Pozycje doświadczenia w grupie stanowisk profilu | `ZklPozKwalDosGr` | konfig | root |  |  | [HR/PozycjaDoswiadczeniaProfiluGrupa.md](HR/PozycjaDoswiadczeniaProfiluGrupa.md) |
| PozycjaDoswiadczeniaProfiluObszar | Pozycje doświadczenia w obszarze funkcjonalnym profilu | `ZklPozKwalDosOb` | konfig | root |  |  | [HR/PozycjaDoswiadczeniaProfiluObszar.md](HR/PozycjaDoswiadczeniaProfiluObszar.md) |
| PozycjaJezykaProfiluTypPotwier | Typy potwierdzeń języka obcego | `ZklPozKwalJezTP` | konfig | root |  |  | [HR/PozycjaJezykaProfiluTypPotwier.md](HR/PozycjaJezykaProfiluTypPotwier.md) |
| PozycjaJezykowObcychProfilu | Pozycje języków obcych profilu | `ZklPozKwalJezyki` | konfig | root |  |  | [HR/PozycjaJezykowObcychProfilu.md](HR/PozycjaJezykowObcychProfilu.md) |
| PozycjaKwalifikacjiProfiluTypPotwier | Typy potwierdzeń kwalifikacji | `ZklPozKwalKwalTP` | konfig | root |  |  | [HR/PozycjaKwalifikacjiProfiluTypPotwier.md](HR/PozycjaKwalifikacjiProfiluTypPotwier.md) |
| PozycjaKwalifikacjiZawodowychProfilu | Pozycje kwalifikacji zawodowych profilu | `ZklPozKwalKwal` | konfig | root |  |  | [HR/PozycjaKwalifikacjiZawodowychProfilu.md](HR/PozycjaKwalifikacjiZawodowychProfilu.md) |
| PozycjaMaszynIUrzadzenProfilu | Pozycje maszyn i urządzeń profilu | `ZklPozKwalMaszyn` | konfig | root |  |  | [HR/PozycjaMaszynIUrzadzenProfilu.md](HR/PozycjaMaszynIUrzadzenProfilu.md) |
| PozycjaMaszynyProfiluTypPotwier | Typy potwierdzeń maszyny | `ZklPozKwalMszTP` | konfig | root |  |  | [HR/PozycjaMaszynyProfiluTypPotwier.md](HR/PozycjaMaszynyProfiluTypPotwier.md) |
| PozycjaProfiluKompetencjiMerytorycznych | Pozycje profilu kompetencji merytorycznych | `ZklPozProfilKKM` | konfig | root |  |  | [HR/PozycjaProfiluKompetencjiMerytorycznych.md](HR/PozycjaProfiluKompetencjiMerytorycznych.md) |
| PozycjaProfiluKompetencjiUniwersalnych | Pozycje profilu kompetencji uniwersalnych | `ZklPozProfilKKU` | konfig | root |  |  | [HR/PozycjaProfiluKompetencjiUniwersalnych.md](HR/PozycjaProfiluKompetencjiUniwersalnych.md) |
| PozycjaProfiluZadaniowego | Pozycje profilu zadaniowego | `ZklPozProfilZdn` | konfig | root |  |  | [HR/PozycjaProfiluZadaniowego.md](HR/PozycjaProfiluZadaniowego.md) |
| PozycjaSystemowITProfilu | Pozycje systemów IT profilu | `ZklPozKwalIT` | konfig | root |  |  | [HR/PozycjaSystemowITProfilu.md](HR/PozycjaSystemowITProfilu.md) |
| PozycjaSystemuITProfiluTypPotwier | Typy potwierdzeń systemu IT | `ZklPozKwalITTP` | konfig | root |  |  | [HR/PozycjaSystemuITProfiluTypPotwier.md](HR/PozycjaSystemuITProfiluTypPotwier.md) |
| PozycjaSzkolenIUprawnienProfilu | Pozycje szkoleń i uprawnień profilu | `ZklPozSzkUpr` | konfig | root |  |  | [HR/PozycjaSzkolenIUprawnienProfilu.md](HR/PozycjaSzkolenIUprawnienProfilu.md) |
| PozycjaWyksztalceniaProfilu | Pozycje wykształcenia profilu | `ZklPozKwalWykszt` | konfig | root |  |  | [HR/PozycjaWyksztalceniaProfilu.md](HR/PozycjaWyksztalceniaProfilu.md) |
| PozycjaWyszukania | Kryteria | `PozycjeWyszukan` |  | child: Wyszukanie→Wyszukanie |  |  | [HR/PozycjaWyszukania.md](HR/PozycjaWyszukania.md) |
| ProfilKompetencjiMerytorycznych | Profile kompetencji merytorycznych | `ZklProfilKKM` | konfig | root |  |  | [HR/ProfilKompetencjiMerytorycznych.md](HR/ProfilKompetencjiMerytorycznych.md) |
| ProfilKompetencjiUniwersalnych | Profile kompetencji uniwersalnych | `ZklProfilKKU` | konfig | root |  |  | [HR/ProfilKompetencjiUniwersalnych.md](HR/ProfilKompetencjiUniwersalnych.md) |
| ProfilKwalifikacyjny | Profile kwalifikacji | `ZklProfilKwal` | konfig | root |  |  | [HR/ProfilKwalifikacyjny.md](HR/ProfilKwalifikacyjny.md) |
| ProfilSzkolenIUprawnien | Profile szkoleń i uprawnień | `ZklProfilSzkUpr` | konfig | root |  |  | [HR/ProfilSzkolenIUprawnien.md](HR/ProfilSzkolenIUprawnien.md) |
| ProfilZadaniowy | Profile zadań | `ZklProfilZdn` | konfig | root |  |  | [HR/ProfilZadaniowy.md](HR/ProfilZadaniowy.md) |
| PunktyMacierzyWartosciowania | Punkty macierzy kryteriów wartościowania | `ZklWrtMxPunkty` |  |  |  |  | [HR/PunktyMacierzyWartosciowania.md](HR/PunktyMacierzyWartosciowania.md) |
| RealizacjaSzkolenia | Szkolenia | `RealizSzkolen` |  | root |  | IAdresHost, IOceniany, IŹródłoOceny | [HR/RealizacjaSzkolenia.md](HR/RealizacjaSzkolenia.md) |
| Rekrutacja |  | `Rekrutacje` |  | root |  | IŹródłoKartyCharakterystykiPracownika | [HR/Rekrutacja.md](HR/Rekrutacja.md) |
| StopienOdpowiedzialnosci | Stopnie odpowiedzialności | `ZklStopOdp` | konfig | root |  | IZklPozycjaSlownika | [HR/StopienOdpowiedzialnosci.md](HR/StopienOdpowiedzialnosci.md) |
| SystemITJezykProgramowania | Systemy IT i języki programowania | `ZklSystITProg` | konfig | root |  | IZklPozycjaSlownika | [HR/SystemITJezykProgramowania.md](HR/SystemITJezykProgramowania.md) |
| SzkolenieBHPDefinicjiStanowiska | Szkolenia BHP defincji stanowisk | `SzkolBHPDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  | [HR/SzkolenieBHPDefinicjiStanowiska.md](HR/SzkolenieBHPDefinicjiStanowiska.md) |
| TypPotwierdzenia | Typy potwierdzeń | `ZklTypPotwier` | konfig | root |  | IZklPozycjaSlownika | [HR/TypPotwierdzenia.md](HR/TypPotwierdzenia.md) |
| TytulZawodowyStopienNaukowy | Tytuły zawodowe i stopnie naukowe | `ZklTytZwdStNauk` | konfig | root |  | IZklPozycjaSlownika | [HR/TytulZawodowyStopienNaukowy.md](HR/TytulZawodowyStopienNaukowy.md) |
| UkończoneSzkolenie | Ukończone szkolenia | `UkonczSzkolenia` |  | root |  | IOcenaPracownika | [HR/UkończoneSzkolenie.md](HR/UkończoneSzkolenie.md) |
| UprawnienieDefinicjiStanowiska | Uprawnienia defincji stanowisk | `UprawnDefStan` |  | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  | [HR/UprawnienieDefinicjiStanowiska.md](HR/UprawnienieDefinicjiStanowiska.md) |
| UprawnienieDefinicjiSzkolenia | Uprawnienia | `UprawnDefSzkol` |  | child: DefinicjaSzkolenia→DefinicjaSzkolenia |  |  | [HR/UprawnienieDefinicjiSzkolenia.md](HR/UprawnienieDefinicjiSzkolenia.md) |
| UprawnieniePracownika | Uprawnienia | `UprawnieniaPrac` |  | root |  |  | [HR/UprawnieniePracownika.md](HR/UprawnieniePracownika.md) |
| WartosciowanieStanowiska | Wartościowania stanowisk | `ZklWartStanow` |  |  |  |  | [HR/WartosciowanieStanowiska.md](HR/WartosciowanieStanowiska.md) |
| WartośćElementuOcenyPracownika | Wartości elementu oceny | `WartElemOcenPrac` | konfig | child: Definicja→DefElementuOcenyPracownika |  |  | [HR/WartośćElementuOcenyPracownika.md](HR/WartośćElementuOcenyPracownika.md) |
| WniosekOSzkolenie | Wnioski o szkolenia | `WnioskiOSzkol` |  | root |  | IŹródłoUzyskaniaUprawnienia, IOcenaPracownika, IBazaZrodlaWyplaty | [HR/WniosekOSzkolenie.md](HR/WniosekOSzkolenie.md) |
| WspolpracaWewnetrznaJednostkiDefStan | Współpraca wewnętrzna definicji stanowisk z jednostkami organizacyjnymi | `WspWeJnDefSt` | konfig | root |  |  | [HR/WspolpracaWewnetrznaJednostkiDefStan.md](HR/WspolpracaWewnetrznaJednostkiDefStan.md) |
| WydziałDefinicjiStanowiska | Jednostki organizacyjne defincji stanowisk | `WydzialyDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  | [HR/WydziałDefinicjiStanowiska.md](HR/WydziałDefinicjiStanowiska.md) |
| WynikPozycjiWartosciowania | Wyniki pozycji wartościowania | `ZklWynikPozWart` |  |  |  |  | [HR/WynikPozycjiWartosciowania.md](HR/WynikPozycjiWartosciowania.md) |
| WyposazenieStanowiska | Wyposażenie stanowiska | `ZklWypStanow` | konfig | root |  | IZklPozycjaSlownika | [HR/WyposazenieStanowiska.md](HR/WyposazenieStanowiska.md) |
| Wysilek | Wysiłek | `ZklWysilek` | konfig | root |  | IZklPozycjaSlownika | [HR/Wysilek.md](HR/Wysilek.md) |
| Wyszukanie | Wyszukania | `Wyszukania` |  | root |  |  | [HR/Wyszukanie.md](HR/Wyszukanie.md) |
| WzorOcenyPracownika | Wzory ocen | `WzoryOcenPrac` | konfig | root |  |  | [HR/WzorOcenyPracownika.md](HR/WzorOcenyPracownika.md) |
| ZadanieZkl | Zadania | `ZklZadania` | konfig | root |  | IZklPozycjaSlownika | [HR/ZadanieZkl.md](HR/ZadanieZkl.md) |

## HR2

- Opis: Rozszerzenie modułu HR o dodatkowe funkcjonalności. Zawiera zaawansowane mechanizmy zarządzania kompetencjami, celami, ocenami okresowymi i rozwojem pracowników.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| CelOkresowyPracownika | Cele okresowe | `CeleOkresowePrac` |  | root |  |  | [HR2/CelOkresowyPracownika.md](HR2/CelOkresowyPracownika.md) |
| DefinicjaElementuOpisuStanowiska | Definicje elementów opisu stanowisk | `DefElOpisuStanow` | konfig | root |  |  | [HR2/DefinicjaElementuOpisuStanowiska.md](HR2/DefinicjaElementuOpisuStanowiska.md) |
| ElementKartyOpisuStanowiska | Elementy KOS | `ElementyKOS` |  | child: Karta→KartaOpisuStanowiskaBase |  |  | [HR2/ElementKartyOpisuStanowiska.md](HR2/ElementKartyOpisuStanowiska.md) |
| ElementWynagDod | Elementy wynagrodzenia | `ElementyWynagDod` | konfig | child: Stanowisko→DefinicjaStanowiskaHist |  |  | [HR2/ElementWynagDod.md](HR2/ElementWynagDod.md) |
| KartaKompetencjiPracownika | Karty kompetencji | `KartyKompPrac` |  | root |  |  | [HR2/KartaKompetencjiPracownika.md](HR2/KartaKompetencjiPracownika.md) |
| KartaOpisuStanowiskaBase | Karty opisu stanowisk | `KartyOpStanowisk` |  | root |  |  | [HR2/KartaOpisuStanowiskaBase.md](HR2/KartaOpisuStanowiskaBase.md) |
| KartaRealizacjiCelu | Karty realizacji celu | `KartyReazCelPrac` |  | root |  |  | [HR2/KartaRealizacjiCelu.md](HR2/KartaRealizacjiCelu.md) |
| KategoriaElementuOpisuStanowiska | Kategorie elementów opisu stanowisk | `KatElOpisuStanow` | konfig | root |  |  | [HR2/KategoriaElementuOpisuStanowiska.md](HR2/KategoriaElementuOpisuStanowiska.md) |
| KompetencjaKartyOpisuStanowiska | Kompetencje KOS | `KompetencjeKOS` |  | child: Karta→KartaOpisuStanowiskaBase |  |  | [HR2/KompetencjaKartyOpisuStanowiska.md](HR2/KompetencjaKartyOpisuStanowiska.md) |
| KompetencjaPracownika | Kompetencje | `KompetencjePrac` |  | child: Karta→KartaKompetencjiPracownika |  |  | [HR2/KompetencjaPracownika.md](HR2/KompetencjaPracownika.md) |
| OfertaPracy | Ogłoszenia o pracę | `OfertyPracy` |  |  |  | IŹródłoRekrutacji, IŹródłoKartyOpisuStanowiska | [HR2/OfertaPracy.md](HR2/OfertaPracy.md) |
| RealizacjaCelu | Realizacje celu pracowników | `RealizacjeCelPrc` |  | child: Karta→KartaRealizacjiCelu |  |  | [HR2/RealizacjaCelu.md](HR2/RealizacjaCelu.md) |
| RekrutacjaAplikacja | Aplikacje | `RekrutAplikacje` |  | root |  | IŹródłoRekrutacji | [HR2/RekrutacjaAplikacja.md](HR2/RekrutacjaAplikacja.md) |
| RekrutacjaWakat | Wakaty | `RekrutWakaty` |  | root |  | IŹródłoRekrutacji, IŹródłoKartyOpisuStanowiska | [HR2/RekrutacjaWakat.md](HR2/RekrutacjaWakat.md) |

## Handel

- Opis: Moduł handlowy obsługujący dokumenty sprzedaży, zakupu, zamówień i innych operacji handlowych. Zawiera definicje dokumentów, relacje między dokumentami, pozycje dokumentów, sumy VAT, rozliczenia oraz mechanizmy fiskalizacji i EDI.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| DaneBDO | Dane dokumentów BDO | `DaneDokBDO` |  |  |  |  | [Handel/DaneBDO.md](Handel/DaneBDO.md) |
| DaneEParagonu | Dane e-paragonów. | `DaneEParagony` |  |  |  |  | [Handel/DaneEParagonu.md](Handel/DaneEParagonu.md) |
| DaneEUDR | Dane pozycji dokumentów EUDR | `DanePozEUDR` |  |  |  |  | [Handel/DaneEUDR.md](Handel/DaneEUDR.md) |
| DaneTaxFree | Dane dokumentów Tax Free | `DaneDokTaxFree` |  |  |  |  | [Handel/DaneTaxFree.md](Handel/DaneTaxFree.md) |
| DefDokHandlowego | Definicje dokumentów handlowych | `DefDokHandlowych` | konfig | root |  | IRightsSource, IDefinicjaKomunikatuEDIHost, IWarningHost, IDefinicjaDokumentuOA | [Handel/DefDokHandlowego.md](Handel/DefDokHandlowego.md) |
| DefDokPodrzednego |  | `DefDokPodrzedne` | konfig | child: Definicja→DefRelacjiHandlowej |  |  | [Handel/DefDokPodrzednego.md](Handel/DefDokPodrzednego.md) |
| DefRelacjiHandlowej | Definicje relacji handlowych | `DefRelHandlowych` | konfig | root |  |  | [Handel/DefRelacjiHandlowej.md](Handel/DefRelacjiHandlowej.md) |
| DefUrzadzeniaUz | Definicje urządzeń użytkowanych | `DefUrzadzenUz` | konfig | root |  |  | [Handel/DefUrzadzeniaUz.md](Handel/DefUrzadzeniaUz.md) |
| DokumentHandlowy | Dokumenty handlowe | `DokHandlowe` |  | root |  | IDokumentPlatny, IDokumentKsiegowalny, IDokumentKasowy, IDaneKontrahentaHost, IDokumentCRM, IKodowany, IExportImportXmlHost, IElementSlownika, IKomunikatEDIHost, IEmailElement, IProceduraVATHost, IZrodloOpisuAnalitycznego | [Handel/DokumentHandlowy.md](Handel/DokumentHandlowy.md) |
| DokumentHandlowyKoszt | Koszty dodatkowe | `DokHandloweKoszt` |  |  |  |  | [Handel/DokumentHandlowyKoszt.md](Handel/DokumentHandlowyKoszt.md) |
| DrukarkaFiskalna | Lista drukarek fiskalnych | `DrukarkiFiskalne` | konfig | root |  |  | [Handel/DrukarkaFiskalna.md](Handel/DrukarkaFiskalna.md) |
| DrukarkaFiskalnaStanowisko | Lista drukarek przypisanych do stanowiska | `DrukFiskStan` | konfig |  |  |  | [Handel/DrukarkaFiskalnaStanowisko.md](Handel/DrukarkaFiskalnaStanowisko.md) |
| ElemRozliczenia | Elementy rozliczenia pozycji | `ElemyRozliczenia` |  | child: Pozycja→PozycjaDokHandlowego |  |  | [Handel/ElemRozliczenia.md](Handel/ElemRozliczenia.md) |
| KSeFPozycjaDokHan | Dane KSeF przypisane do pozycji dokumentu handlowego | `KSeFPozDokHan` |  | child: Pozycja→PozycjaDokHandlowego |  |  | [Handel/KSeFPozycjaDokHan.md](Handel/KSeFPozycjaDokHan.md) |
| KontrahentKomunikatEDI | Komunikaty EDI dla kontrahenta | `KontrahKonEDI` |  |  |  |  | [Handel/KontrahentKomunikatEDI.md](Handel/KontrahentKomunikatEDI.md) |
| LimitWartosci | Limity wartości dokumentu. | `LimityWartosci` |  | child: Definicja→DefDokHandlowego |  |  | [Handel/LimitWartosci.md](Handel/LimitWartosci.md) |
| MagDefDokRight | Przypisanie definicji dokumentu do magazynu | `MagDefDokRights` | konfig | child: Magazyn→Magazyn |  |  | [Handel/MagDefDokRight.md](Handel/MagDefDokRight.md) |
| OkresZawieszenia | Okresy zawieszenia | `OkresyZawiesz` |  | child: Dokument→DokumentHandlowy |  |  | [Handel/OkresZawieszenia.md](Handel/OkresZawieszenia.md) |
| Paczka |  | `Paczki` |  |  |  |  | [Handel/Paczka.md](Handel/Paczka.md) |
| PaczkaWzorcowa |  | `PaczkiWzorcowe` |  | root |  |  | [Handel/PaczkaWzorcowa.md](Handel/PaczkaWzorcowa.md) |
| PozHanTimeTrack | TimeTrack pozycji dokumentu handlowego | `PozHanTimeTracks` |  |  |  |  | [Handel/PozHanTimeTrack.md](Handel/PozHanTimeTrack.md) |
| PozycjaDokHanCenaInfo | Informacja o cenie pozycji dokumentu handlowego | `PozHanCenaInfo` |  | child: Pozycja→PozycjaDokHandlowego |  |  | [Handel/PozycjaDokHanCenaInfo.md](Handel/PozycjaDokHanCenaInfo.md) |
| PozycjaDokHanRabatInfo | Informacja o cenie pozycji dokumentu handlowego | `PozHanRabatInfo` |  | child: Pozycja→PozycjaDokHandlowego |  |  | [Handel/PozycjaDokHanRabatInfo.md](Handel/PozycjaDokHanRabatInfo.md) |
| PozycjaDokHandlowego | Pozycje dokumentów | `PozycjeDokHan` |  | child: Dokument→DokumentHandlowy |  | IZrodloOpisuAnalitycznego | [Handel/PozycjaDokHandlowego.md](Handel/PozycjaDokHandlowego.md) |
| PozycjaDokHandlowegoLimit | Pozycja Handlowa Limity | `PozDoHandLimity` |  | root |  |  | [Handel/PozycjaDokHandlowegoLimit.md](Handel/PozycjaDokHandlowegoLimit.md) |
| PozycjaDokHandlowegoLimitHost | Pozycja Handlowa Limit Hosts | `PozDoHaLiHosts` |  | child: Host→ILimitHost |  |  | [Handel/PozycjaDokHandlowegoLimitHost.md](Handel/PozycjaDokHandlowegoLimitHost.md) |
| PozycjaRelacjiHandlowej | Pozycja relacji handlowej | `PozRelHandlowej` |  | child: Relacja→RelacjaHandlowa |  |  | [Handel/PozycjaRelacjiHandlowej.md](Handel/PozycjaRelacjiHandlowej.md) |
| ProgRabatowy |  | `ProgiRabatowe` |  |  |  |  | [Handel/ProgRabatowy.md](Handel/ProgRabatowy.md) |
| PrzesylkaDokRel | Relacje przesyłek | `PrzesylkiDokRel` |  |  |  |  | [Handel/PrzesylkaDokRel.md](Handel/PrzesylkaDokRel.md) |
| PrzesylkaSpedyt | Przesyłki spedytora | `PrzesylkiSpedyt` |  | root |  |  | [Handel/PrzesylkaSpedyt.md](Handel/PrzesylkaSpedyt.md) |
| PulpitHost | Obiekty wykorzystywane w pulpitach | `PulpityHost` |  |  |  |  | [Handel/PulpitHost.md](Handel/PulpitHost.md) |
| RelacjaGrupyDostaw | Relacje do partii | `RelacjeGrupDostw` |  |  |  |  | [Handel/RelacjaGrupyDostaw.md](Handel/RelacjaGrupyDostaw.md) |
| RelacjaHandlowa |  | `RelacjeHandlowe` |  | root |  |  | [Handel/RelacjaHandlowa.md](Handel/RelacjaHandlowa.md) |
| RelacjaInnaPlat |  | `RelacjeInnaPlat` |  |  |  |  | [Handel/RelacjaInnaPlat.md](Handel/RelacjaInnaPlat.md) |
| RelacjaZaliczki |  | `RelacjeZaliczek` |  |  |  |  | [Handel/RelacjaZaliczki.md](Handel/RelacjaZaliczki.md) |
| SumaVAT | Sumy VAT | `SumyVAT` |  | child: Dokument→DokumentHandlowy |  |  | [Handel/SumaVAT.md](Handel/SumaVAT.md) |
| UrzadzenieUz | Urządzenia użytkowane | `UrzadzeniaUz` |  | root |  |  | [Handel/UrzadzenieUz.md](Handel/UrzadzenieUz.md) |
| UslDodPrzesyl | Usługi dodatkowe przesyłki | `UslDodPrzesylek` |  |  |  |  | [Handel/UslDodPrzesyl.md](Handel/UslDodPrzesyl.md) |

## Import

- Opis: Moduł importu danych do księgowości. Zawiera definicje importu dokumentów z zewnętrznych systemów finansowo-księgowych.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| KwotySad | Kwoty SAD | `KwotySadow` |  | child: Ewidencja→DokEwidencji |  |  | [Import/KwotySad.md](Import/KwotySad.md) |

## Kadry

- Opis: Moduł kadrowy obsługujący dane pracowników. Zawiera kartoteki pracowników, umowy o pracę, historię zatrudnienia, nieobecności, badania lekarskie, szkolenia BHP oraz dane ubezpieczeniowe.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| Akord |  | `Akordy` |  | root | historyczna → AkordHistoria | IBazaZrodlaWyplaty | [Kadry/Akord.md](Kadry/Akord.md) |
| AkordHistoria | Historia akordu | `AkordHistorie` |  | child: Akord→Akord | historia → Akord | IAkord | [Kadry/AkordHistoria.md](Kadry/AkordHistoria.md) |
| AlgorytmRatyPożyczki | Algorytmy rat pożyczek | `AlgRatPozyczek` | konfig | root |  |  | [Kadry/AlgorytmRatyPożyczki.md](Kadry/AlgorytmRatyPożyczki.md) |
| BadanieLekarskie | Badania lekarskie | `BadaniaLekarskie` |  | root |  | IManagedRowInfoHost | [Kadry/BadanieLekarskie.md](Kadry/BadanieLekarskie.md) |
| BlokadaPracownika | Blokady pracowników | `BlokadyPrac` |  |  |  |  | [Kadry/BlokadaPracownika.md](Kadry/BlokadaPracownika.md) |
| BoRIAOświata | Okresy wykonywania pracy nauczycieskiej | `BosRIAOswiata` |  | root |  |  | [Kadry/BoRIAOświata.md](Kadry/BoRIAOświata.md) |
| BoRIAWarunkiSzczególne | Okresy pracy w szczególnych warunkach lub w szczególnym charakterze | `BosRIAWarSzczeg` |  | root |  |  | [Kadry/BoRIAWarunkiSzczególne.md](Kadry/BoRIAWarunkiSzczególne.md) |
| BoRIAWynagrodzenia | Bilansy otwarcia RIA - wynagrodzenia | `BosRIAWynagrodz` |  | root |  |  | [Kadry/BoRIAWynagrodzenia.md](Kadry/BoRIAWynagrodzenia.md) |
| CzlonekRodziny | Członek rodziny | `Rodzina` |  | root |  | IZrodloDeklaracji, IAdresHost, IPowiązanieDodatku | [Kadry/CzlonekRodziny.md](Kadry/CzlonekRodziny.md) |
| CzynnikSzkodliwyPracownika | Czynniki szkodliwe pracownika | `CzynnSzkodPrac` |  | root |  |  | [Kadry/CzynnikSzkodliwyPracownika.md](Kadry/CzynnikSzkodliwyPracownika.md) |
| DefPodstawyStazu | Def. podstaw stażu pracy | `DefPodstawStazu` | konfig | root |  |  | [Kadry/DefPodstawyStazu.md](Kadry/DefPodstawyStazu.md) |
| DefinicjaAkordu | Definicje akordów | `DefinicjeAkordow` | konfig | root |  | IAkord | [Kadry/DefinicjaAkordu.md](Kadry/DefinicjaAkordu.md) |
| DefinicjaBadaniaLekarskiego | Definicje badań lekarskich | `DefBadanLek` | konfig | root |  | IManagedRowDefinion | [Kadry/DefinicjaBadaniaLekarskiego.md](Kadry/DefinicjaBadaniaLekarskiego.md) |
| DefinicjaCzynnikowSzkodliwych | Definicje czynników szkodliwych | `DefCzynnSzkod` | konfig | root |  | IZklPozycjaSlownika | [Kadry/DefinicjaCzynnikowSzkodliwych.md](Kadry/DefinicjaCzynnikowSzkodliwych.md) |
| DefinicjaFunduszuPozyczkowego | Definicje funduszy pożyczkowych | `DefFundPozycz` | konfig | root |  | IRightsSource, IZakresDefinicji | [Kadry/DefinicjaFunduszuPozyczkowego.md](Kadry/DefinicjaFunduszuPozyczkowego.md) |
| DefinicjaJęzykaObcego | Definicje języków obcych | `DefJezykowObcych` | konfig | root |  | IZklPozycjaSlownika | [Kadry/DefinicjaJęzykaObcego.md](Kadry/DefinicjaJęzykaObcego.md) |
| DefinicjaNagrodyKary | Definicje nagród lub kar | `DefNagrodKar` | konfig | root |  |  | [Kadry/DefinicjaNagrodyKary.md](Kadry/DefinicjaNagrodyKary.md) |
| DefinicjaOświadczenia | Definicje oświadczeń | `DefOswiadczen` | konfig | root |  |  | [Kadry/DefinicjaOświadczenia.md](Kadry/DefinicjaOświadczenia.md) |
| DefinicjaStopiaZnajomościJęzykaObcego | Definicje stopni znajomości języków obcych | `DefStZnJObcych` | konfig | root |  | IZklPozycjaSlownika | [Kadry/DefinicjaStopiaZnajomościJęzykaObcego.md](Kadry/DefinicjaStopiaZnajomościJęzykaObcego.md) |
| DefinicjaSzkoleniaBHP | Definicje szkoleń BHP | `DefSzkolenBHP` | konfig | root |  | IManagedRowDefinion, IZklPozycjaSlownika, IPozycjaKonfiguratora | [Kadry/DefinicjaSzkoleniaBHP.md](Kadry/DefinicjaSzkoleniaBHP.md) |
| DefinicjaWydziału | Kategorie jednostek organizacyjnych | `DefWydzialow` | konfig | root |  |  | [Kadry/DefinicjaWydziału.md](Kadry/DefinicjaWydziału.md) |
| DefinicjaŚwiadczeniaSocjalnego | Definicje świadczeń socjalnych | `DefSwiadczSocjal` | konfig | root |  |  | [Kadry/DefinicjaŚwiadczeniaSocjalnego.md](Kadry/DefinicjaŚwiadczeniaSocjalnego.md) |
| DodHistoria | Historie dodatków | `DodHistorie` |  | child: Dodatek→Dodatek | historia → Dodatek |  | [Kadry/DodHistoria.md](Kadry/DodHistoria.md) |
| Dodatek |  | `Dodatki` |  | root | historyczna → DodHistoria | IBazaZrodlaWyplaty | [Kadry/Dodatek.md](Kadry/Dodatek.md) |
| ElementZestawuDodatków | Elementy zestawów | `ElementyZestDod` | konfig | child: Zestaw→ZestawDodatków |  |  | [Kadry/ElementZestawuDodatków.md](Kadry/ElementZestawuDodatków.md) |
| FormaOrganizacjiPracy | Formy organizacji pracy | `FormyOrgPracy` | konfig | root |  |  | [Kadry/FormaOrganizacjiPracy.md](Kadry/FormaOrganizacjiPracy.md) |
| FundPozyczkowy | Fundusze pożyczkowe | `FundPozyczkowe` |  | root |  | IBazaZrodlaWyplaty, IPowiązanieWypłaty | [Kadry/FundPozyczkowy.md](Kadry/FundPozyczkowy.md) |
| GrupaZaszeregowania | Grupy zaszeregowania | `GrupyZaszer` | konfig | root |  |  | [Kadry/GrupaZaszeregowania.md](Kadry/GrupaZaszeregowania.md) |
| HistoriaDanychWydziału | Historia danych jednostek organizacyjnych | `HstDanychWydzial` | konfig | child: Wydzial→Wydzial |  | IMetrykaWydziałuHost | [Kadry/HistoriaDanychWydziału.md](Kadry/HistoriaDanychWydziału.md) |
| HistoriaZatrudnieniaBase | Historia zatrudnienia | `HistZatrudnien` |  | root |  | IManagedRowInfoHost | [Kadry/HistoriaZatrudnieniaBase.md](Kadry/HistoriaZatrudnieniaBase.md) |
| InformacjaDoRozliczenia |  | `InformacjeDoRozl` |  | root | historyczna → InformacjeDoRozliczeniaHistoria |  | [Kadry/InformacjaDoRozliczenia.md](Kadry/InformacjaDoRozliczenia.md) |
| InformacjeDoRozliczeniaHistoria | Historie elementów rozliczenia | `InfoDoRozliHist` |  | child: InformacjaDoRozliczenia→InformacjaDoRozliczenia | historia → InformacjaDoRozliczenia |  | [Kadry/InformacjeDoRozliczeniaHistoria.md](Kadry/InformacjeDoRozliczeniaHistoria.md) |
| InnyDochod | Inne dochody | `InneDochody` |  | child: Pracownik→Pracownik |  |  | [Kadry/InnyDochod.md](Kadry/InnyDochod.md) |
| KanalZgloszeniaSygnalisty | Kanały zgłoszeń sygnalisty | `KanalyZglSygnal` | konfig | root |  |  | [Kadry/KanalZgloszeniaSygnalisty.md](Kadry/KanalZgloszeniaSygnalisty.md) |
| KartaRCP | Karty RCP | `KartyRCP` |  | root |  |  | [Kadry/KartaRCP.md](Kadry/KartaRCP.md) |
| KategoriaCzynnikowSzkodliwych | Kategorie czynników szkodliwych | `KatCzynnSzkod` | konfig | root |  | IZklPozycjaSlownika | [Kadry/KategoriaCzynnikowSzkodliwych.md](Kadry/KategoriaCzynnikowSzkodliwych.md) |
| KategoriaZgloszeniaSygnalisty | Kategorie zgłoszeń sygnalisty | `KatZglSygnal` | konfig | root |  |  | [Kadry/KategoriaZgloszeniaSygnalisty.md](Kadry/KategoriaZgloszeniaSygnalisty.md) |
| KodPracyWSzególnychWarunkachCharakterze | Kody pracy w szczególnych warunkach lub o szczególnym charakterze | `KodyPracySzWaCha` | konfig | root |  |  | [Kadry/KodPracyWSzególnychWarunkachCharakterze.md](Kadry/KodPracyWSzególnychWarunkachCharakterze.md) |
| KodWykonywanegoZawodu | Kody GUS zawodów | `KodyWykZawodow` | konfig | root |  |  | [Kadry/KodWykonywanegoZawodu.md](Kadry/KodWykonywanegoZawodu.md) |
| KorektaZajęciaKomorniczego | Korekty zajęć komorniczych | `KorektyZajKomor` |  | root |  | IBazaZrodlaWyplaty | [Kadry/KorektaZajęciaKomorniczego.md](Kadry/KorektaZajęciaKomorniczego.md) |
| LokalizacjaPracyZdalnej | Lokalizacja pracy zdalnej | `LokPracZdalnej` |  | root |  |  | [Kadry/LokalizacjaPracyZdalnej.md](Kadry/LokalizacjaPracyZdalnej.md) |
| MetrykaWydziału | Wpisy do metryki jednostek organizacyjnych | `MetrykiWydzialow` | konfig | child: Wydzial→Wydzial |  |  | [Kadry/MetrykaWydziału.md](Kadry/MetrykaWydziału.md) |
| NagrodaKara |  | `NagrodyKary` |  | root |  | IBazaZrodlaWyplaty, IPowiązanieWypłaty | [Kadry/NagrodaKara.md](Kadry/NagrodaKara.md) |
| OkresNiewliczany | Okresy niewliczane do stażu pracy | `OkrNiewliczane` |  | child: Zatrudnienie→HistoriaZatrudnieniaBase |  |  | [Kadry/OkresNiewliczany.md](Kadry/OkresNiewliczany.md) |
| OkresWakacjiSkladki | Wakacje składkowe | `OkresyWakacjiSkladki` |  | child: Pracownik→Pracownik |  |  | [Kadry/OkresWakacjiSkladki.md](Kadry/OkresWakacjiSkladki.md) |
| OkresWykonywaniaPracyTymczasowej | Okresy wykonywania pracy tymczasowej | `OkresyPracyTymcz` |  | child: Zatrudnienie→HistoriaZatrudnieniaBase |  |  | [Kadry/OkresWykonywaniaPracyTymczasowej.md](Kadry/OkresWykonywaniaPracyTymczasowej.md) |
| OświadczeniePracownika | Oświadczenia pracowników | `OswiadczeniaPrac` |  | root |  |  | [Kadry/OświadczeniePracownika.md](Kadry/OświadczeniePracownika.md) |
| PodstawaStazu | Podstawy stażu pracy | `PodstawyStazow` |  | root |  |  | [Kadry/PodstawaStazu.md](Kadry/PodstawaStazu.md) |
| Pozyczka | Pożyczki | `Pozyczki` |  | root |  | IBazaZrodlaWyplaty, IPowiązanieWypłaty, IRozliczenieWynagrodzeniaHost, IBilansOtwarcia | [Kadry/Pozyczka.md](Kadry/Pozyczka.md) |
| PracDbTupleDefinitionExt | Rozszerzenia definicji krotek dla tabeli Pracownicy | `PracTupleDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition |  |  | [Kadry/PracDbTupleDefinitionExt.md](Kadry/PracDbTupleDefinitionExt.md) |
| PracHistoria | Historia pracownika | `PracHistorie` |  | child: Pracownik→Pracownik | historia → Pracownik | IAdresHost, IDaneKontaktoweHost | [Kadry/PracHistoria.md](Kadry/PracHistoria.md) |
| PracHistoria2 | Historia pracownika (pozostałe) | `PracHistorie2` |  | child: Host→PracHistoria |  |  | [Kadry/PracHistoria2.md](Kadry/PracHistoria2.md) |
| Pracownik | Pracownicy | `Pracownicy` |  | root | historyczna → PracHistoria | IZrodloNieobecnosci, IZrodloWnioskuONieobecnosc, IBazaZrodlaWyplaty, IPodmiot, IPodmiotKasowy, IKontrahent, IZrodloPodzielnikaKosztow, IElementSlownika, IZasobCRM, ITaskUser, IŹródłoPowiązaniaStrukturyOrganizacyjnej, IWebOperator, IGIODOZgodnyHost, IOceniany, IOceniający, IOdpowiedzialnyZaOcenę, IŹródłoKartyOpisuStanowiska, IGIODOWymianaDanychHost, IGIODOOświadczenieHost, IGIODOUprawnienieHost, IEmailElement, IRozliczenieWynagrodzeniaHost, IZestawienieDietZagrHost, IZestawienieDietPakietMobilHost, IAdresHost, IZrodloPlanu, IDostepnoscHost | [Kadry/Pracownik.md](Kadry/Pracownik.md) |
| PracownikWArchiwum | Pracownicy w archiwum | `PracWArchiwum` |  | child: Pracownik→Pracownik |  |  | [Kadry/PracownikWArchiwum.md](Kadry/PracownikWArchiwum.md) |
| ProgAkordu | Progi akordów | `ProgiAkordow` |  | child: Akord→IAkord |  |  | [Kadry/ProgAkordu.md](Kadry/ProgAkordu.md) |
| ProgPodatkowy |  | `ProgiPodatkowe` |  | child: Historia→PracHistoria |  |  | [Kadry/ProgPodatkowy.md](Kadry/ProgPodatkowy.md) |
| PrzetwarzanieZgloszeniaSygnalisty | Przetwarzanie naruszeń | `PrzetwarzZglSyg` |  | root |  |  | [Kadry/PrzetwarzanieZgloszeniaSygnalisty.md](Kadry/PrzetwarzanieZgloszeniaSygnalisty.md) |
| PrzychodRyczalt | Przychody dla zryczałtowanych form opodatkowania | `PrzychodyRyczalt` |  | child: Pracownik→Pracownik |  |  | [Kadry/PrzychodRyczalt.md](Kadry/PrzychodRyczalt.md) |
| PrzychodZDzialnosci | Przychody oraz dochody dla form opodatkowania | `PrzychodyZDzial` |  | child: Pracownik→Pracownik |  |  | [Kadry/PrzychodZDzialnosci.md](Kadry/PrzychodZDzialnosci.md) |
| PrzyczynaRozwUmowy | Przyczyna rozwiązania umów o pracę | `PrzyczRozwUmow` | konfig | root |  |  | [Kadry/PrzyczynaRozwUmowy.md](Kadry/PrzyczynaRozwUmowy.md) |
| PrzyczynaZawUmowy | Przyczyna zawarcia umów o pracę | `PrzyczZawUmow` | konfig | root |  |  | [Kadry/PrzyczynaZawUmowy.md](Kadry/PrzyczynaZawUmowy.md) |
| RataPozyczki | Raty pożyczek | `RatyPozyczek` |  | root |  | IBazaZrodlaWyplaty | [Kadry/RataPozyczki.md](Kadry/RataPozyczki.md) |
| RelacjaWykonPrac | Powiązanie Wykonujący Pracownik | `RelacjeWykonPrac` |  | child: Pracownik→Pracownik |  |  | [Kadry/RelacjaWykonPrac.md](Kadry/RelacjaWykonPrac.md) |
| Schorzenie |  | `Schorzenia` |  | root |  |  | [Kadry/Schorzenie.md](Kadry/Schorzenie.md) |
| SwiadczSocjalne | Świadczenia socjalne | `SwiadczeniaSoc` |  | root |  | IBazaZrodlaWyplaty, IPowiązanieWypłaty | [Kadry/SwiadczSocjalne.md](Kadry/SwiadczSocjalne.md) |
| SzkolenieBHP | Szkolenia BHP | `SzkoleniaBHP` |  | root |  |  | [Kadry/SzkolenieBHP.md](Kadry/SzkolenieBHP.md) |
| TreśćOświadczenia | Treści oświadczeń | `TresciOswiadczen` | konfig | child: Definicja→DefinicjaOświadczenia |  |  | [Kadry/TreśćOświadczenia.md](Kadry/TreśćOświadczenia.md) |
| TytulUbezpieczenia4 | Tytuły ubezpieczenia | `TytulyUbezpiecz4` | konfig | root |  |  | [Kadry/TytulUbezpieczenia4.md](Kadry/TytulUbezpieczenia4.md) |
| UlgaInnowacyjna | Ulga innowacyjna | `UlgiInnowacyjne` |  | child: Pracownik→Pracownik |  |  | [Kadry/UlgaInnowacyjna.md](Kadry/UlgaInnowacyjna.md) |
| Umowa | Umowy | `Umowy` |  | root | historyczna → UmowaHistoria | IBazaZrodlaWyplaty, IPowiązanieWypłaty, IZrodloDeklaracji, IZrodloPodzielnikaKosztow, IPowiązanieDodatku, IRozliczenieWynagrodzeniaHost, IZestawienieDietZagrHost, IZestawienieDietPakietMobilHost, IUmowaZKalendarzem, IBilansOtwarcia, IKwotaSplacanaBO, IZrodloPlanu, IDostepnoscHost, IZrodloNieobecnosci, IZrodloWnioskuONieobecnosc | [Kadry/Umowa.md](Kadry/Umowa.md) |
| UmowaHistoria | Umowy | `UmowaHistorie` |  | child: Umowa→Umowa | historia → Umowa |  | [Kadry/UmowaHistoria.md](Kadry/UmowaHistoria.md) |
| UmowaZewnetrzna | Umowy zewnętrzne | `UmowyZewnetrzne` |  | root | historyczna → UmowaZewnetrznaHistoria | IZrodloPodzielnikaKosztow, IUmowaZKalendarzem, IZrodloPlanu, IDostepnoscHost, IZrodloNieobecnosci, IZrodloWnioskuONieobecnosc | [Kadry/UmowaZewnetrzna.md](Kadry/UmowaZewnetrzna.md) |
| UmowaZewnetrznaHistoria | UmowyZewnetrzne | `UmowyZewnHist` |  | child: Umowa→UmowaZewnetrzna | historia → UmowaZewnetrzna |  | [Kadry/UmowaZewnetrznaHistoria.md](Kadry/UmowaZewnetrznaHistoria.md) |
| WniosekUrlopowy | Wnioski o urlopy, delegacje | `WnioskiUrlopowe` |  | root |  | IDokumentAktualizacjiKalendarza | [Kadry/WniosekUrlopowy.md](Kadry/WniosekUrlopowy.md) |
| WniosekZwrotOplSkl | Wniosek o zwrot nienależnie opłaconych składek | `WniosZwrotOplSkl` |  | root |  | IDokument | [Kadry/WniosekZwrotOplSkl.md](Kadry/WniosekZwrotOplSkl.md) |
| Wydzial | Jednostki organizacyjne | `Wydzialy` | konfig | root |  | IRightsSource, IElementStrukturyFirmy, IElementSlownika | [Kadry/Wydzial.md](Kadry/Wydzial.md) |
| WydzialRef | Zmiana jednostek nadrzędnych | `WydzialyRef` | konfig | child: Wydzial→Wydzial |  | IMetrykaWydziałuHost | [Kadry/WydzialRef.md](Kadry/WydzialRef.md) |
| WydziałDefFundPozy | Jednostki organizacyjne definicji funduszu pożyczkowego | `WydDefFundPozy` | konfig | child: DefinicjaFunduszuPozyczkowego→DefinicjaFunduszuPozyczkowego |  |  | [Kadry/WydziałDefFundPozy.md](Kadry/WydziałDefFundPozy.md) |
| Wypadek | Karty wypadków | `Wypadki` |  | root |  |  | [Kadry/Wypadek.md](Kadry/Wypadek.md) |
| ZajęcieKomornicze | Zajęcia wynagrodzeń | `ZajKomornicze` |  | root | historyczna → ZajęcieKomorniczeHistoria | IBazaZrodlaWyplaty | [Kadry/ZajęcieKomornicze.md](Kadry/ZajęcieKomornicze.md) |
| ZajęcieKomorniczeHistoria | Zajęcia wynagrodzeń | `ZajKomorniczeHis` |  | child: Zajecie→ZajęcieKomornicze | historia → ZajęcieKomornicze |  | [Kadry/ZajęcieKomorniczeHistoria.md](Kadry/ZajęcieKomorniczeHistoria.md) |
| ZbiegUbezpieczenia | Zbiegi ubezpieczeń | `ZbiegiUbezpiecz` |  | child: Pracownik→Pracownik |  |  | [Kadry/ZbiegUbezpieczenia.md](Kadry/ZbiegUbezpieczenia.md) |
| ZestawDodatków | Zestawy dodatków | `ZestawyDodatkow` | konfig | root |  |  | [Kadry/ZestawDodatków.md](Kadry/ZestawDodatków.md) |
| ZgloszenieSygnalisty | Naruszenie | `ZgloszSygnalisty` |  | root |  | IDokument | [Kadry/ZgloszenieSygnalisty.md](Kadry/ZgloszenieSygnalisty.md) |
| ZgodaNaEdycję | Zgody na edycję danych | `ZgodyNaEdycje` |  | root |  |  | [Kadry/ZgodaNaEdycję.md](Kadry/ZgodaNaEdycję.md) |
| ZmianaWkładuFunduszuPozyczkowego | Zmiany wkładów do funduszy pożyczkowych | `ZmianaWklFundPoz` |  | root |  | IBazaZrodlaWyplaty | [Kadry/ZmianaWkładuFunduszuPozyczkowego.md](Kadry/ZmianaWkładuFunduszuPozyczkowego.md) |
| ZnajomośćJęzykaObcego | Znajomość języków obcych | `ZnJezykowObcych` |  | child: Pracownik→Pracownik |  |  | [Kadry/ZnajomośćJęzykaObcego.md](Kadry/ZnajomośćJęzykaObcego.md) |
| ŻyrantPożyczki | Żyranci | `ZyranciPozyczek` |  | child: Pozyczka→Pozyczka |  |  | [Kadry/ŻyrantPożyczki.md](Kadry/ŻyrantPożyczki.md) |

## Kalend

- Opis: Moduł zarządzania czasem pracy. Zawiera kalendarze, definicje dni, strefy czasowe, harmonogramy pracy, reguły rozliczania czasu pracy oraz ewidencję obecności.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| CzynnoscNaObiekcieDoPlanowania | Czynności dla obiektu do planowania | `CzynnObDoPlan` |  | root |  |  | [Kalend/CzynnoscNaObiekcieDoPlanowania.md](Kalend/CzynnoscNaObiekcieDoPlanowania.md) |
| CzytnikRCP | Czytniki RCP | `CzytnikiRCP` | konfig | root |  |  | [Kalend/CzytnikRCP.md](Kalend/CzytnikRCP.md) |
| DefAlgorytmRCP | Definicje algorytmów RCP | `DefAlgorytmyRCP` | konfig | root |  |  | [Kalend/DefAlgorytmRCP.md](Kalend/DefAlgorytmRCP.md) |
| DefinicjaAktualizacjiKalendarza | Definicje dokumentów aktualizacji kalendarzy | `DefAktKalendarzy` | konfig | root |  | IRightsSource | [Kalend/DefinicjaAktualizacjiKalendarza.md](Kalend/DefinicjaAktualizacjiKalendarza.md) |
| DefinicjaCzynnosciNaObiekcie | Definicje czynności na obiektach do planowania | `DefCzynnOb` | konfig | root |  |  | [Kalend/DefinicjaCzynnosciNaObiekcie.md](Kalend/DefinicjaCzynnosciNaObiekcie.md) |
| DefinicjaDnia | Definicje dni | `DefinicjeDni` | konfig | root |  | IŹródłoKoloruElementu | [Kalend/DefinicjaDnia.md](Kalend/DefinicjaDnia.md) |
| DefinicjaGrafikaPracy | Definicje grafików | `DefGrafikowPracy` | konfig | root |  |  | [Kalend/DefinicjaGrafikaPracy.md](Kalend/DefinicjaGrafikaPracy.md) |
| DefinicjaLimitu | Definicje limitów | `DefinicjeLimitow` | konfig | root |  |  | [Kalend/DefinicjaLimitu.md](Kalend/DefinicjaLimitu.md) |
| DefinicjaNieobecnosci | Definicje nieobecności | `DefNieobecnosci` | konfig | root |  | IŹródłoKoloruElementu | [Kalend/DefinicjaNieobecnosci.md](Kalend/DefinicjaNieobecnosci.md) |
| DefinicjaRodzajuPracyZdalnej | Definicje rodzaju pracy zdalnej | `DefRodzPracZdal` | konfig | root |  |  | [Kalend/DefinicjaRodzajuPracyZdalnej.md](Kalend/DefinicjaRodzajuPracyZdalnej.md) |
| DefinicjaRozliczeniaCzasuPracy | Definicje dokumentów rozliczenia czasu pracy | `DefRozlCzasPracy` | konfig | root |  |  | [Kalend/DefinicjaRozliczeniaCzasuPracy.md](Kalend/DefinicjaRozliczeniaCzasuPracy.md) |
| DefinicjaStrefy | Definicje stref | `DefinicjeStref` | konfig | root |  | IŹródłoKoloruElementu | [Kalend/DefinicjaStrefy.md](Kalend/DefinicjaStrefy.md) |
| DefinicjaWeryfikatoraKalendarza | Definicje weryfikatorów dla kalendarzy | `DefWeryfKalend` | konfig | root |  |  | [Kalend/DefinicjaWeryfikatoraKalendarza.md](Kalend/DefinicjaWeryfikatoraKalendarza.md) |
| DefinicjaWeryfikatoraRozliczeniaCzasuPracy | Definicje weryfikatorów dla dokumentów rozliczenia czasu pracy | `DefWerRozCzas` | konfig | root |  |  | [Kalend/DefinicjaWeryfikatoraRozliczeniaCzasuPracy.md](Kalend/DefinicjaWeryfikatoraRozliczeniaCzasuPracy.md) |
| DefinicjaZdarzeniaRCP | Definicje zdarzeń RCP | `DefZdarzenRCP` |  | root |  |  | [Kalend/DefinicjaZdarzeniaRCP.md](Kalend/DefinicjaZdarzeniaRCP.md) |
| DefinicjaZestawieniaCzasu | Definicje zestawień czasu | `DefZestawCzasu` | konfig | root |  | IRightsSource | [Kalend/DefinicjaZestawieniaCzasu.md](Kalend/DefinicjaZestawieniaCzasu.md) |
| DokumentAktualizacjiKalendarza | Dokumenty aktualizacji kalendarzy | `DokAktKalendarzy` |  | root |  | IŹródłoPowiązaniaStrukturyOrganizacyjnej, IDokumentAktualizacjiKalendarza, IDokument | [Kalend/DokumentAktualizacjiKalendarza.md](Kalend/DokumentAktualizacjiKalendarza.md) |
| DzienAkorduBase | Dni akordów | `DniAkordow` |  | child: Akord→Akord |  |  | [Kalend/DzienAkorduBase.md](Kalend/DzienAkorduBase.md) |
| DzienKalendarzaAktualizacja |  | `DniKalendAkt` |  | child: Pozycja→PozycjaAktualizacjiKalendarza |  |  | [Kalend/DzienKalendarzaAktualizacja.md](Kalend/DzienKalendarzaAktualizacja.md) |
| DzienKalendarzaBase |  | `DniKalendarza` |  | child: Kalendarz→KalendarzBase |  |  | [Kalend/DzienKalendarzaBase.md](Kalend/DzienKalendarzaBase.md) |
| DzienKalendarzaHistoria |  | `DniKalendHist` |  | child: DokumentAktualizacji→IDokumentAktualizacjiKalendarza |  |  | [Kalend/DzienKalendarzaHistoria.md](Kalend/DzienKalendarzaHistoria.md) |
| DzienPracy | Dni pracy | `DniPracy` |  | child: Pracownik→Pracownik |  |  | [Kalend/DzienPracy.md](Kalend/DzienPracy.md) |
| DzienPracyAktualizacja | Aktualizacje dni pracy | `DniPracyAkt` |  | child: Pozycja→PozycjaAktualizacjiCzasu |  |  | [Kalend/DzienPracyAktualizacja.md](Kalend/DzienPracyAktualizacja.md) |
| DzienPracyHistoria | Historia dni pracy | `DniPracyHist` |  | child: DokumentAktualizacji→IDokumentAktualizacjiKalendarza |  |  | [Kalend/DzienPracyHistoria.md](Kalend/DzienPracyHistoria.md) |
| DzienPracyUmowy | Dni pracy umowy | `DniPracyUmowy` |  | child: Umowa→IUmowaZKalendarzem |  |  | [Kalend/DzienPracyUmowy.md](Kalend/DzienPracyUmowy.md) |
| DzienRCP | Dni RCP | `DniRCP` |  | child: Pracownik→Pracownik |  |  | [Kalend/DzienRCP.md](Kalend/DzienRCP.md) |
| ElementRozliczeniaCzasuPracy | Elementy wniosków/zleceń rozliczenia czasu pracy | `ElRozlCzasPracy` |  | root |  |  | [Kalend/ElementRozliczeniaCzasuPracy.md](Kalend/ElementRozliczeniaCzasuPracy.md) |
| GrafikPracownika | Grafiki pracowników | `GrafPracownikow` |  |  |  |  | [Kalend/GrafikPracownika.md](Kalend/GrafikPracownika.md) |
| GrafikPracy | Grafiki planu pracy | `GrafikiPracy` |  | root |  |  | [Kalend/GrafikPracy.md](Kalend/GrafikPracy.md) |
| KalendarzBase |  | `Kalendarze` |  | root |  |  | [Kalend/KalendarzBase.md](Kalend/KalendarzBase.md) |
| KodZdarzeniaRCP | Kody zdarzeń RCP | `KodyZdarzenRCP` | konfig | child: CzytnikRCP→CzytnikRCP |  |  | [Kalend/KodZdarzeniaRCP.md](Kalend/KodZdarzeniaRCP.md) |
| KolorElementu | Kolory elementów | `KoloryElementow` | konfig | child: Zrodlo→IŹródłoKoloruElementu |  |  | [Kalend/KolorElementu.md](Kalend/KolorElementu.md) |
| LimitNieobecnosci | Limity nieobecności | `LimNieobecnosci` |  | child: Pracownik→Pracownik |  |  | [Kalend/LimitNieobecnosci.md](Kalend/LimitNieobecnosci.md) |
| Nieobecnosc | Nieobecności | `Nieobecnosci` |  | root |  | IZrodloNieobecnosci, IBazaZrodlaWyplaty, IBilansOtwarcia, IZrodloDeklaracji | [Kalend/Nieobecnosc.md](Kalend/Nieobecnosc.md) |
| NieobecnośćIdx |  | `NieobecnosciIdx` |  |  |  |  | [Kalend/NieobecnośćIdx.md](Kalend/NieobecnośćIdx.md) |
| ObiektAktualizacjiKalendarza | Powiązania obiektu oraz dokumentu aktualizacji kalendarza | `ObAktKalend` |  |  |  |  | [Kalend/ObiektAktualizacjiKalendarza.md](Kalend/ObiektAktualizacjiKalendarza.md) |
| ObiektDoPlanowania | Obiekty do planowania | `ObiektyDoPlan` |  | root |  |  | [Kalend/ObiektDoPlanowania.md](Kalend/ObiektDoPlanowania.md) |
| ObrotRN | Obroty | `ObrotyRN` |  | child: StrefaNadgodziny→StrefaPracy |  |  | [Kalend/ObrotRN.md](Kalend/ObrotRN.md) |
| PUEDokumentEZLA | Dokument ZLA importowany z PUE | `PUEDokEZLA` |  | child: Raport→PUERaportNieobecnosci |  | IDokumentAktualizacjiKalendarza | [Kalend/PUEDokumentEZLA.md](Kalend/PUEDokumentEZLA.md) |
| PUERaportNieobecnosci | Raport nieobecności importowany z PUE | `PUERptNb` |  | root |  |  | [Kalend/PUERaportNieobecnosci.md](Kalend/PUERaportNieobecnosci.md) |
| PlanowanaNieobecność | Planowane nieobecności | `PlanNieobecnosci` |  | root |  |  | [Kalend/PlanowanaNieobecność.md](Kalend/PlanowanaNieobecność.md) |
| PozycjaAktualizacjiCzasu | Źródła kalendarza na dokumentach aktualizacji kalendarzy | `PozAktCzasu` |  |  |  |  | [Kalend/PozycjaAktualizacjiCzasu.md](Kalend/PozycjaAktualizacjiCzasu.md) |
| PozycjaAktualizacjiKalendarza | Źródła kalendarza na dokumentach aktualizacji kalendarzy | `PozAktKalend` |  |  |  |  | [Kalend/PozycjaAktualizacjiKalendarza.md](Kalend/PozycjaAktualizacjiKalendarza.md) |
| PozycjaObiektuAktualizacjiCzasu | Powiązania obiektu oraz pozycji aktualizacji czasu | `PozObAktCzas` |  |  |  |  | [Kalend/PozycjaObiektuAktualizacjiCzasu.md](Kalend/PozycjaObiektuAktualizacjiCzasu.md) |
| PozycjaObiektuAktualizacjiKalendarza | Powiązania obiektu oraz pozycji aktualizacji kalendarza | `PozObAktKalend` |  |  |  |  | [Kalend/PozycjaObiektuAktualizacjiKalendarza.md](Kalend/PozycjaObiektuAktualizacjiKalendarza.md) |
| RegulaDostepnosci | Reguły dostępności | `RegulyDostep` |  | root |  |  | [Kalend/RegulaDostepnosci.md](Kalend/RegulaDostepnosci.md) |
| RozliczenieCzasuPracy | Rozliczenia czasu pracy | `RozlCzasPracy` |  | root |  | IManagedRowInfoHost, IDokument, IDokumentAktualizacjiKalendarza | [Kalend/RozliczenieCzasuPracy.md](Kalend/RozliczenieCzasuPracy.md) |
| StrefaDnia | Strefy dni | `StrefyDni` | konfig | child: Dzien→DefinicjaDnia |  |  | [Kalend/StrefaDnia.md](Kalend/StrefaDnia.md) |
| StrefaKalendarza | Strefy dni | `StrefyKalandarza` |  | child: Dzien→DzienKalendarzaBase |  |  | [Kalend/StrefaKalendarza.md](Kalend/StrefaKalendarza.md) |
| StrefaKalendarzaAktualizacja | Aktualizacje strefy dna | `StrefyKalendAkt` |  | child: Dzien→DzienKalendarzaAktualizacja |  |  | [Kalend/StrefaKalendarzaAktualizacja.md](Kalend/StrefaKalendarzaAktualizacja.md) |
| StrefaKalendarzaHistoria | Historie strefy dnia | `StrefyKalendHist` |  | child: Dzien→DzienKalendarzaHistoria |  |  | [Kalend/StrefaKalendarzaHistoria.md](Kalend/StrefaKalendarzaHistoria.md) |
| StrefaPracy | Strefy dni | `StrefyPracy` |  | child: Dzien→DzienPracy |  | IRozliczenieNadgodzinHost | [Kalend/StrefaPracy.md](Kalend/StrefaPracy.md) |
| StrefaPracyAktualizacja | Aktualizacje strefy dnia pracy | `StrefyPracyAkt` |  | child: Dzien→DzienPracyAktualizacja |  |  | [Kalend/StrefaPracyAktualizacja.md](Kalend/StrefaPracyAktualizacja.md) |
| StrefaPracyHistoria | Historie strefy dnia pracy | `StrefyPracyHist` |  | child: Dzien→DzienPracyHistoria |  | IRozliczenieNadgodzinHost | [Kalend/StrefaPracyHistoria.md](Kalend/StrefaPracyHistoria.md) |
| StrefaPracyUmowy | Strefy dni umowy | `StrefyPracyUmowy` |  | child: Dzien→DzienPracyUmowy |  | IRozliczenieNadgodzinHost | [Kalend/StrefaPracyUmowy.md](Kalend/StrefaPracyUmowy.md) |
| StrefaRCP | Strefy RCP | `StrefyRCP` |  | child: Dzien→DzienRCP |  |  | [Kalend/StrefaRCP.md](Kalend/StrefaRCP.md) |
| StrefaZestawienia | Strefy zestawień | `StrefyZestawien` |  | child: Zestawienie→ZestawieniePracy |  | IRozliczenieNadgodzinHost | [Kalend/StrefaZestawienia.md](Kalend/StrefaZestawienia.md) |
| StrefaZestawieniaUmowy | Strefy zestawień umów | `StrefyZestawUmow` |  | child: Zestawienie→ZestawienieUmowy |  |  | [Kalend/StrefaZestawieniaUmowy.md](Kalend/StrefaZestawieniaUmowy.md) |
| StrefaZestawieniaUmowyZewnetrznej | Strefy zestawień umów zewnętrznych | `StrefyZestUmZw` |  | child: Zestawienie→ZestawienieUmowyZewnetrznej |  |  | [Kalend/StrefaZestawieniaUmowyZewnetrznej.md](Kalend/StrefaZestawieniaUmowyZewnetrznej.md) |
| WejscieWyjscie | Wejścia/Wyjścia | `WejsciaWyjscia` |  | child: Dzien→DzienPracy |  |  | [Kalend/WejscieWyjscie.md](Kalend/WejscieWyjscie.md) |
| WejscieWyjscieI | Dane z RCP | `WejsciaWyjsciaI` |  | child: Pracownik→Pracownik |  |  | [Kalend/WejscieWyjscieI.md](Kalend/WejscieWyjscieI.md) |
| WejscieWyjscieO | Oryginalne dane z RCP | `WejsciaWyjsciaO` |  | child: Pracownik→Pracownik |  |  | [Kalend/WejscieWyjscieO.md](Kalend/WejscieWyjscieO.md) |
| WeryfikatorKalendarza | Weryfikatory dla kalendarzy | `WeryfKalend` |  | root |  |  | [Kalend/WeryfikatorKalendarza.md](Kalend/WeryfikatorKalendarza.md) |
| WeryfikatorRozliczeniaCzasuPracy | Weryfikatory dla dokumentów rozliczenia czasu pracy | `WerRozCzas` |  | root |  |  | [Kalend/WeryfikatorRozliczeniaCzasuPracy.md](Kalend/WeryfikatorRozliczeniaCzasuPracy.md) |
| WniosekPracyZdalnej | Wnioski o pracę zdalną | `WnioskiPracZdal` |  | root |  | IDokumentAktualizacjiKalendarza | [Kalend/WniosekPracyZdalnej.md](Kalend/WniosekPracyZdalnej.md) |
| WyjatekRegulyDostepnosci | Wyjątki od reguły dostępności | `WyjatkiRegDost` |  | child: Regula→RegulaDostepnosci |  |  | [Kalend/WyjatekRegulyDostepnosci.md](Kalend/WyjatekRegulyDostepnosci.md) |
| ZasobRN | Zasoby | `ZasobyRN` |  | child: Strefa→StrefaPracy |  |  | [Kalend/ZasobRN.md](Kalend/ZasobRN.md) |
| ZbiegPracyIRodzicielstwa | Zbiegi pracy i rodzicielstwa | `ZbiegiPracyIRodz` |  | root |  | IBazaZrodlaWyplaty | [Kalend/ZbiegPracyIRodzicielstwa.md](Kalend/ZbiegPracyIRodzicielstwa.md) |
| ZestDietPakietMobil | Zestawienia diet pakiet mobilności | `ZestDietPaMob` |  | child: Host→IZestawienieDietPakietMobilHost |  |  | [Kalend/ZestDietPakietMobil.md](Kalend/ZestDietPakietMobil.md) |
| ZestawienieAkorduBase | Zestawienia akordów | `ZestawAkordow` |  | child: Akord→Akord |  |  | [Kalend/ZestawienieAkorduBase.md](Kalend/ZestawienieAkorduBase.md) |
| ZestawienieAktualizacjiKalendarza | Zestawienia dokumentów aktualizacji kalendarzy | `ZestAktKalend` | konfig | child: DefinicjaDokumentu→DefinicjaAktualizacjiKalendarza |  |  | [Kalend/ZestawienieAktualizacjiKalendarza.md](Kalend/ZestawienieAktualizacjiKalendarza.md) |
| ZestawienieDietZagr | Zestawienia diet pracowników za granicą | `ZestawDietZagr` |  | child: Host→IZestawienieDietZagrHost |  |  | [Kalend/ZestawienieDietZagr.md](Kalend/ZestawienieDietZagr.md) |
| ZestawieniePracy | Zestawienia czasu pracy | `ZestawieniaPracy` |  | child: Pracownik→Pracownik |  |  | [Kalend/ZestawieniePracy.md](Kalend/ZestawieniePracy.md) |
| ZestawienieUmowy | Zestawienia umów | `ZestawieniaUmow` |  | child: Umowa→Umowa |  |  | [Kalend/ZestawienieUmowy.md](Kalend/ZestawienieUmowy.md) |
| ZestawienieUmowyZewnetrznej | Zestawienia umów zewnętrznych | `ZestawieniaUmZew` |  | child: Umowa→UmowaZewnetrzna |  |  | [Kalend/ZestawienieUmowyZewnetrznej.md](Kalend/ZestawienieUmowyZewnetrznej.md) |

## Kasa

- Opis: Moduł gospodarki kasowo-bankowej obsługujący ewidencję środków pieniężnych w kasach i na rachunkach bankowych. Realizuje pełny obieg dokumentów płatniczych — od rejestracji płatności i zapłat, przez przelewy i raporty kasowe, po rozliczenia i rozrachunki z kontrahentami. Wspiera magazyn walut, preliminarz płatności, bankowość elektroniczną oraz mechanizm podzielonej płatności (MPP).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| DefinicjaPaczkiPrzelewu | Definicje paczek przelewów | `DefPaczekPrze` | konfig | root |  |  | [Kasa/DefinicjaPaczkiPrzelewu.md](Kasa/DefinicjaPaczkiPrzelewu.md) |
| DodatkoweDanePrzelewu | Dodatkowe dane przelewów | `DodDanePrzelewow` |  | child: Przelew→PrzelewBase |  |  | [Kasa/DodatkoweDanePrzelewu.md](Kasa/DodatkoweDanePrzelewu.md) |
| DokKasowyBase | Dokumenty kasowe | `DokumentyKasowe` |  | root |  | IDokumentKasowy, IDokumentCRM | [Kasa/DokKasowyBase.md](Kasa/DokKasowyBase.md) |
| DokRozliczBase | Dokumenty rozliczeniowe | `DokRozliczeniowe` |  | root |  | IDokumentKsiegowalny, IDokumentPlatny, IDokumentCRM, IEmailElement | [Kasa/DokRozliczBase.md](Kasa/DokRozliczBase.md) |
| EwidencjaSP | Ewidencje ŚP | `EwidencjeSP` | konfig | root |  | IElementSlownika, IRightsSource | [Kasa/EwidencjaSP.md](Kasa/EwidencjaSP.md) |
| FormaPlatnosci | Definicje płatności | `FormyPlatnosci` | konfig | root |  |  | [Kasa/FormaPlatnosci.md](Kasa/FormaPlatnosci.md) |
| FormatWymianyElektronicznej | Rachunki bankowe | `FormatyWymElektr` | konfig | root |  |  | [Kasa/FormatWymianyElektronicznej.md](Kasa/FormatWymianyElektronicznej.md) |
| HistoriaStatusuBL | Historia statusów Biała lista | `StatusBLHist` |  |  |  |  | [Kasa/HistoriaStatusuBL.md](Kasa/HistoriaStatusuBL.md) |
| IdentyfikacjaPlatnika | Identyfikacje płatników | `IdentPlatnikow` |  |  |  |  | [Kasa/IdentyfikacjaPlatnika.md](Kasa/IdentyfikacjaPlatnika.md) |
| ObrotMW | Obroty | `ObrotyMW` |  |  |  |  | [Kasa/ObrotMW.md](Kasa/ObrotMW.md) |
| OkresMW | Okresy magazynu walut | `OkresyMW` | konfig | root |  |  | [Kasa/OkresMW.md](Kasa/OkresMW.md) |
| OperacjaBankowa | Operacje bankowe | `OperacjeBankowe` |  | child: WyciagBankowy→RaportESP |  |  | [Kasa/OperacjaBankowa.md](Kasa/OperacjaBankowa.md) |
| PaczkaPrzelewow | Paczki przelewów | `PaczkiPrzelewow` |  | root |  | IDokument | [Kasa/PaczkaPrzelewow.md](Kasa/PaczkaPrzelewow.md) |
| ParametrySerwisuBankowego | Parametry serwisów bankowych | `ParametrySeBnk` | konfig |  |  |  | [Kasa/ParametrySerwisuBankowego.md](Kasa/ParametrySerwisuBankowego.md) |
| Platnosc | Płatności | `Platnosci` |  | root |  | IRozliczalny, IElementKsiegowalny, IZrodloOpisuAnalitycznego | [Kasa/Platnosc.md](Kasa/Platnosc.md) |
| PozycjaDokRozlicz | Pozycja dokumentu rozliczeniowego | `PozDokRozlicz` |  | child: Dokument→DokRozliczBase |  |  | [Kasa/PozycjaDokRozlicz.md](Kasa/PozycjaDokRozlicz.md) |
| PozycjaPaczkiPrzelewow | Pozycje paczek przelewów | `PozPaczPrz` |  | child: Paczka→PaczkaPrzelewow |  |  | [Kasa/PozycjaPaczkiPrzelewow.md](Kasa/PozycjaPaczkiPrzelewow.md) |
| PozycjaPrzelewu | Pozycje przelewów | `PozycjePrzelewow` |  | child: Przelew→PrzelewBase |  |  | [Kasa/PozycjaPrzelewu.md](Kasa/PozycjaPrzelewu.md) |
| PreliminarzDokument | Dokumenty preliminarza | `PreliminarzDok` |  | root |  | IDokumentPreliminarza, IZrodloOpisuAnalitycznego | [Kasa/PreliminarzDokument.md](Kasa/PreliminarzDokument.md) |
| PreliminarzPozycja | Pozycje preliminarza | `PreliminarzPoz` |  | child: Dokument→IDokumentPreliminarza |  |  | [Kasa/PreliminarzPozycja.md](Kasa/PreliminarzPozycja.md) |
| PrzelewBase | Przelewy | `Przelewy` |  | root |  | IAdresHost | [Kasa/PrzelewBase.md](Kasa/PrzelewBase.md) |
| RachunekBankowyPodmiotu | Rachunki bankowe | `RachBankPodmiot` |  | root |  | IAdresHost | [Kasa/RachunekBankowyPodmiotu.md](Kasa/RachunekBankowyPodmiotu.md) |
| RachunekWirtualny | Rachunki wirtualne | `RachWirtualne` |  |  |  |  | [Kasa/RachunekWirtualny.md](Kasa/RachunekWirtualny.md) |
| RaportESP | Raport ESP | `RaportyESP` |  | root |  | IDokumentKsiegowalny, IRaportEwidencjiSP | [Kasa/RaportESP.md](Kasa/RaportESP.md) |
| RozliczenieSP | Rozliczenia | `RozliczeniaSP` |  | root |  | IRozliczenie | [Kasa/RozliczenieSP.md](Kasa/RozliczenieSP.md) |
| RozrachunekIdx | Rozrachunki | `RozrachunkiIdx` |  |  |  |  | [Kasa/RozrachunekIdx.md](Kasa/RozrachunekIdx.md) |
| SerwisBankowy | Serwis bankowy | `SerwisyBankowe` | konfig | root |  |  | [Kasa/SerwisBankowy.md](Kasa/SerwisBankowy.md) |
| SposobZaplaty | Sposoby zapłaty | `SposobyZaplaty` | konfig | root |  |  | [Kasa/SposobZaplaty.md](Kasa/SposobZaplaty.md) |
| SubEwidencjaSP | Subewidencje | `SubEwidencjeSP` | konfig |  |  |  | [Kasa/SubEwidencjaSP.md](Kasa/SubEwidencjaSP.md) |
| TypIdenPodPrzel | Typy identyfikatorów podmiotu przelewu | `TypyIdenPodPrzel` | konfig | root |  |  | [Kasa/TypIdenPodPrzel.md](Kasa/TypIdenPodPrzel.md) |
| Zaplata | Wpłaty i wypłaty | `Zaplaty` |  | root |  | IRozliczalny, IElementKsiegowalny, IZrodloOpisuAnalitycznego, IDaneKontrahentaHost, IDokumentCRM | [Kasa/Zaplata.md](Kasa/Zaplata.md) |
| ZasobMW | Zasoby | `ZasobyMW` |  |  |  |  | [Kasa/ZasobMW.md](Kasa/ZasobMW.md) |

## Ksiega

- Opis: Moduł księgowości obsługujący pełną rachunkowość firmy: plan kont, zapisy księgowe, dekrety, dzienniki i okresy obrachunkowe. Zapewnia mechanizmy predekretacji za pomocą schematów księgowych, rozliczenia księgowe, opisy analityczne z podzielnikami kosztów, zestawienia księgowe oraz sprawozdania finansowe (bilans, RZiS, rachunek przepływów). Obsługuje również KPiR, kręgi kosztów, słowniki analityczne, matryce dokumentów i rozliczenia złych długów.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| DBIPKBRHist | Historia zmian statusów okresów rozliczeniowych PKBR | `DBIPKBRHists` | konfig | child: DBItemPKBROkRoz→DBItemPKBROkRoz |  |  | [Ksiega/DBIPKBRHist.md](Ksiega/DBIPKBRHist.md) |
| DBItemPKBROkRoz | Status okresów rozliczeniowych PKBR | `DBItemPKBROkRozs` | konfig | root |  |  | [Ksiega/DBItemPKBROkRoz.md](Ksiega/DBItemPKBROkRoz.md) |
| DefinicjaAnalityki | Definicje analityk | `DefAnalityk` |  | child: Konto→KontoBase |  |  | [Ksiega/DefinicjaAnalityki.md](Ksiega/DefinicjaAnalityki.md) |
| DefinicjaKregu | Definicje kręgów | `DefinicjeKregow` | konfig | root |  |  | [Ksiega/DefinicjaKregu.md](Ksiega/DefinicjaKregu.md) |
| DefinicjaSlownika | Definicje słowników | `DefSlownikow` | konfig | root |  | IRightsSource | [Ksiega/DefinicjaSlownika.md](Ksiega/DefinicjaSlownika.md) |
| DekretBase | Dziennik księgowy | `Dziennik` |  | root |  |  | [Ksiega/DekretBase.md](Ksiega/DekretBase.md) |
| ElemDefinicjiSlownika | Elementy definicji słowników | `ElemDefSlownikow` | konfig | child: Definicja→DefinicjaSlownika |  |  | [Ksiega/ElemDefinicjiSlownika.md](Ksiega/ElemDefinicjiSlownika.md) |
| ElemOpisuAnalZapRel | Opis analityczny relacje | `OpisAnalZapRel` |  | child: ZapisKsiegowy→ZapisKsiegowy |  |  | [Ksiega/ElemOpisuAnalZapRel.md](Ksiega/ElemOpisuAnalZapRel.md) |
| ElemOpisuAnalitycznego | Opis analityczny | `OpisAnalityczny` |  | child: Ewidencja→DokEwidencji |  |  | [Ksiega/ElemOpisuAnalitycznego.md](Ksiega/ElemOpisuAnalitycznego.md) |
| ElemSlownika | Elementy słowników | `ElemSlownikow` |  | root |  | IElementSlownika | [Ksiega/ElemSlownika.md](Ksiega/ElemSlownika.md) |
| GrupaKont | Grupy kont | `GrupyKont` | konfig | root |  |  | [Ksiega/GrupaKont.md](Ksiega/GrupaKont.md) |
| JednostkaSprawozdaniaKS | Jednostki sprawozdania | `JednostkiSprawKS` |  | child: Sprawozdanie→SprawozdanieKS |  | IPozycjaSprawozdaniaRoot, IAdresHost | [Ksiega/JednostkaSprawozdaniaKS.md](Ksiega/JednostkaSprawozdaniaKS.md) |
| KolumnaWynikuZestKS | Kolumny wyników zestawień księgowych | `KolumnyWynZestKS` |  | child: Wynik→WynikZestKS |  |  | [Ksiega/KolumnaWynikuZestKS.md](Ksiega/KolumnaWynikuZestKS.md) |
| KolumnaZestKS | Kolumny zestawień księgowych | `KolumnyZestKS` | konfig | child: Zestawienie→ZestawienieKS |  |  | [Ksiega/KolumnaZestKS.md](Ksiega/KolumnaZestKS.md) |
| KomorkaWynikuZestKS | Komórki wyników zestawień księgowych | `KomorkiWynZestKS` |  | child: Wynik→WynikZestKS |  |  | [Ksiega/KomorkaWynikuZestKS.md](Ksiega/KomorkaWynikuZestKS.md) |
| KontoBase | Konto | `Konta` |  | root |  |  | [Ksiega/KontoBase.md](Ksiega/KontoBase.md) |
| MatrycaBase | Matryce dokumentów i zapłat | `Matryce` | konfig | root |  |  | [Ksiega/MatrycaBase.md](Ksiega/MatrycaBase.md) |
| MatrycaPodmiot | MatrycePodmioty | `MatrycePodmioty` |  |  |  |  | [Ksiega/MatrycaPodmiot.md](Ksiega/MatrycaPodmiot.md) |
| ObrotKsiegowyBase | Obrót księgowy | `ObrotyKsiegowe` |  |  |  |  | [Ksiega/ObrotKsiegowyBase.md](Ksiega/ObrotKsiegowyBase.md) |
| OkresObrachunkowy | Okresy obrachunkowe | `OkresyObrach` | konfig | root |  |  | [Ksiega/OkresObrachunkowy.md](Ksiega/OkresObrachunkowy.md) |
| PodokresObrachunkowy | Podokresy obrachunkowe | `PodokresyObrach` | konfig | child: OkresKs→OkresObrachunkowy |  |  | [Ksiega/PodokresObrachunkowy.md](Ksiega/PodokresObrachunkowy.md) |
| PowiazanieKontaBase | Powiązania kont | `PowiazaniaKont` |  | child: Konto→KontoBase |  |  | [Ksiega/PowiazanieKontaBase.md](Ksiega/PowiazanieKontaBase.md) |
| PozGrupyKont | Pozycje grup kont | `PozGrupyKontT` | konfig | child: Grupa→GrupaKont |  |  | [Ksiega/PozGrupyKont.md](Ksiega/PozGrupyKont.md) |
| PozycjaDefKregu | Definicje definicji kręgów | `PozycjeDefKregow` | konfig | child: Definicja→DefinicjaKregu |  |  | [Ksiega/PozycjaDefKregu.md](Ksiega/PozycjaDefKregu.md) |
| PozycjaSchematuKsiegowego | Pozycje schematów księgowych | `PozSchemKsiegT` | konfig | child: Schemat→SchematKsiegowy |  |  | [Ksiega/PozycjaSchematuKsiegowego.md](Ksiega/PozycjaSchematuKsiegowego.md) |
| PozycjaSprawozdaniaKS | Pozycje sprawozdań księgowych | `PozycjeSprawKS` |  | child: RootPoz→IPozycjaSprawozdaniaRoot |  | IPozycjaSprawozdaniaRoot | [Ksiega/PozycjaSprawozdaniaKS.md](Ksiega/PozycjaSprawozdaniaKS.md) |
| PozycjaWynikuZestKS | Pozycje wyników zestawień księgowych | `PozycjeWynZestKS` |  | child: Wynik→WynikZestKS |  |  | [Ksiega/PozycjaWynikuZestKS.md](Ksiega/PozycjaWynikuZestKS.md) |
| PozycjaZestKS | Pozycje zestawień księgowych | `PozycjeZestKS` | konfig | child: Zestawienie→ZestawienieKS |  | IPozycjaZestawieniaRoot | [Ksiega/PozycjaZestKS.md](Ksiega/PozycjaZestKS.md) |
| RelacjaOpisAnal | Relacje opisu analitycznego | `RelacjeOpisAnal` | konfig | root |  |  | [Ksiega/RelacjaOpisAnal.md](Ksiega/RelacjaOpisAnal.md) |
| RozliczenieKS | Rozliczenia księgowe | `RozliczeniaKS` |  |  |  | IRozliczenie, IElementKsiegowalny | [Ksiega/RozliczenieKS.md](Ksiega/RozliczenieKS.md) |
| RozliczenieOA | Rozliczenie opisu analitycznego | `RozliczeniaOA` |  |  |  |  | [Ksiega/RozliczenieOA.md](Ksiega/RozliczenieOA.md) |
| SchematKsiegowy | Schematy księgowe | `SchematyKsiegowe` | konfig | root |  |  | [Ksiega/SchematKsiegowy.md](Ksiega/SchematKsiegowy.md) |
| SchematPodz | Schemat podziałowy | `SchematyPodz` | konfig | root |  | ISchematPodziałowy | [Ksiega/SchematPodz.md](Ksiega/SchematPodz.md) |
| SchematPodzElem | Element schematu podziałowego | `SchematPodzElems` | konfig | root |  |  | [Ksiega/SchematPodzElem.md](Ksiega/SchematPodzElem.md) |
| SprawozdanieKS | Sprawozdania księgowe | `SprawozdaniaKS` |  | root |  | IPozycjaSprawozdaniaRoot | [Ksiega/SprawozdanieKS.md](Ksiega/SprawozdanieKS.md) |
| WynikZestKS | Wyniki zestawień księgowych | `WynikiZestKS` |  | root |  |  | [Ksiega/WynikZestKS.md](Ksiega/WynikZestKS.md) |
| ZapisKsiegowy | Zapisy księgowe | `ZapisyKsiegowe` |  | child: Dekret→DekretBase |  | IElementKsiegowalny | [Ksiega/ZapisKsiegowy.md](Ksiega/ZapisKsiegowy.md) |
| ZestawienieKS | Zestawienia księgowe | `ZestawieniaKS` | konfig | root |  | IPozycjaZestawieniaRoot | [Ksiega/ZestawienieKS.md](Ksiega/ZestawienieKS.md) |
| ZleDlugiDokument | Dokumenty ZD | `ZDDokumenty` |  | root |  | IDokument | [Ksiega/ZleDlugiDokument.md](Ksiega/ZleDlugiDokument.md) |
| ZleDlugiPozycja | Pozycje ZD | `ZDPozycje` |  | child: Dokument→ZleDlugiDokument |  |  | [Ksiega/ZleDlugiPozycja.md](Ksiega/ZleDlugiPozycja.md) |
| ZleDlugiPozycjaKorekty | Korekty cząstkowe ZD | `ZDPozycjeKorekty` |  | child: Korekta→ZleDlugiPozycja |  |  | [Ksiega/ZleDlugiPozycjaKorekty.md](Ksiega/ZleDlugiPozycjaKorekty.md) |
| ZnacznikKonta | Znaczniki kont | `ZnacznikiKont` | konfig | root |  |  | [Ksiega/ZnacznikKonta.md](Ksiega/ZnacznikKonta.md) |

## Magazyny

- Opis: Moduł gospodarki magazynowej obsługujący ewidencję stanów, obrotów i zasobów magazynowych. Definiuje magazyny, okresy magazynowe, partie towarów (grupy dostaw) oraz mechanizmy wyceny rozchodu (FIFO, LIFO, wg cechy).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| GrupaDostaw | Partie | `GrupyDostaw` |  |  |  | IKodowany | [Magazyny/GrupaDostaw.md](Magazyny/GrupaDostaw.md) |
| Magazyn |  | `Magazyny` | konfig | root |  | IRightsSource, IElementSlownika | [Magazyny/Magazyn.md](Magazyny/Magazyn.md) |
| Obrot | Obrót | `Obroty` |  |  |  |  | [Magazyny/Obrot.md](Magazyny/Obrot.md) |
| OkresMagazynowy | Okresy magazynowe | `OkresyMag` | konfig | root |  |  | [Magazyny/OkresMagazynowy.md](Magazyny/OkresMagazynowy.md) |
| Zasob | Zasób | `Zasoby` |  |  |  |  | [Magazyny/Zasob.md](Magazyny/Zasob.md) |

## ManagementTools

- Opis: Moduł narzędzi zarządzania platformy enova365. Zawiera rejestr konfiguracji systemu umożliwiający przechowywanie i wersjonowanie ustawień w formacie JSON.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| ConfigRegistry | Rejestr konfiguracji | `ConfigRegistries` |  |  |  |  | [ManagementTools/ConfigRegistry.md](ManagementTools/ConfigRegistry.md) |

## Oceny

- Opis: Moduł ocen pracowniczych. Zawiera definicje arkuszy ocen, kryteria oceniania, skale oraz mechanizmy przeprowadzania i raportowania ocen okresowych.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| ArkuszDefinicjiOceny | Arkusze definicji oceny | `ArkuszeDefOcen` | konfig | child: DefinicjaOceny→DefinicjaOceny |  |  | [Oceny/ArkuszDefinicjiOceny.md](Oceny/ArkuszDefinicjiOceny.md) |
| ArkuszOdpowiedz |  | `ArkuszeOdp` |  |  |  |  | [Oceny/ArkuszOdpowiedz.md](Oceny/ArkuszOdpowiedz.md) |
| DefinicjaArkuszaOceny | Definicje arkuszy ocen | `DefArkuszyOcen` | konfig | root |  |  | [Oceny/DefinicjaArkuszaOceny.md](Oceny/DefinicjaArkuszaOceny.md) |
| DefinicjaElementuOceny | Definicje elementów ocen | `DefElementowOcen` | konfig | root |  |  | [Oceny/DefinicjaElementuOceny.md](Oceny/DefinicjaElementuOceny.md) |
| DefinicjaOceny | Definicje ocen | `DefinicjeOcen` | konfig | root |  |  | [Oceny/DefinicjaOceny.md](Oceny/DefinicjaOceny.md) |
| DefinicjaSekcjiDokumentu | Definicja sekcji dokumentów | `DefSekcjiDok` | konfig | root |  |  | [Oceny/DefinicjaSekcjiDokumentu.md](Oceny/DefinicjaSekcjiDokumentu.md) |
| ElementSkaliOcen | Elementy skal ocen | `ElementySkalOcen` | konfig | root |  |  | [Oceny/ElementSkaliOcen.md](Oceny/ElementSkaliOcen.md) |
| KategoriaElementuOceny | Kategorie elementów ocen | `KatElementowOcen` | konfig | root |  |  | [Oceny/KategoriaElementuOceny.md](Oceny/KategoriaElementuOceny.md) |
| OcenaArkusz | Arkusze oceny | `OcenyArkusze` |  | root |  |  | [Oceny/OcenaArkusz.md](Oceny/OcenaArkusz.md) |
| OcenaKategoriaArkusza | Kategorie arkusza oceny | `OcenyKatArkuszy` |  | child: Arkusz→OcenaArkusz |  |  | [Oceny/OcenaKategoriaArkusza.md](Oceny/OcenaKategoriaArkusza.md) |
| OcenaOceniający | Oceniający | `OcenyOceniajacy` |  | child: Ocena→OcenaRealizacja |  |  | [Oceny/OcenaOceniający.md](Oceny/OcenaOceniający.md) |
| OcenaOceniany | Oceniani | `OcenyOceniani` |  | child: Ocena→OcenaRealizacja |  |  | [Oceny/OcenaOceniany.md](Oceny/OcenaOceniany.md) |
| OcenaPowiaz | Powiązanie z ankietą | `OcenyPowiaz` |  | root |  | IOceniany, IŹródłoOceny | [Oceny/OcenaPowiaz.md](Oceny/OcenaPowiaz.md) |
| OcenaPozycjaArkusza | Pozycje arkuszy ocen | `OcenyPozArkuszy` |  | root |  |  | [Oceny/OcenaPozycjaArkusza.md](Oceny/OcenaPozycjaArkusza.md) |
| OcenaRealizacja | Oceny | `OcenyRealizacje` |  | root |  | IŹródłoPowiązaniaStrukturyOrganizacyjnej | [Oceny/OcenaRealizacja.md](Oceny/OcenaRealizacja.md) |
| PozycjaDefinicjiArkuszaOceny | Pozycje definicji arkusza oceny | `PozDefArkuszOcen` | konfig | child: DefinicjaArkusza→DefinicjaArkuszaOceny |  |  | [Oceny/PozycjaDefinicjiArkuszaOceny.md](Oceny/PozycjaDefinicjiArkuszaOceny.md) |
| SkalaOcen | Skale ocen | `SkaleOcen` | konfig | root |  |  | [Oceny/SkalaOcen.md](Oceny/SkalaOcen.md) |
| UzasadnienieOceny | Uzasadnienia oceny | `OcenyUzas` | konfig | root |  |  | [Oceny/UzasadnienieOceny.md](Oceny/UzasadnienieOceny.md) |
| ZakresWartości | Zakresy wartości | `ZakresyWartosci` | konfig | root |  |  | [Oceny/ZakresWartości.md](Oceny/ZakresWartości.md) |

## Place

- Opis: Moduł płacowy obsługujący naliczanie wynagrodzeń. Zawiera listy płac, składniki wynagrodzenia, elementy wypłat, potrącenia, zasiłki, deklaracje PIT oraz rozliczenia z ZUS i US.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| BilansOtwarciaPIT | Bilansy otwarcia PIT | `BilansyOtwPIT` |  | root |  |  | [Place/BilansOtwarciaPIT.md](Place/BilansOtwarciaPIT.md) |
| DefinicjaElementu | Definicje elementów wynagrodzenia | `DefElementow` | konfig | root |  |  | [Place/DefinicjaElementu.md](Place/DefinicjaElementu.md) |
| DefinicjaElementuRozliczenia |  | `DefElementowRozl` | konfig | root |  |  | [Place/DefinicjaElementuRozliczenia.md](Place/DefinicjaElementuRozliczenia.md) |
| DefinicjaListyPlac | Definicje list płac | `DefListPlac` | konfig | root |  | IRightsSource, IDefinicjaDokumentuOA | [Place/DefinicjaListyPlac.md](Place/DefinicjaListyPlac.md) |
| DefinicjaPlanowanejListyPłac | Definicje planowanych list płac | `DefPlanListPlac` | konfig | root |  | IDefinicjaDokumentuOA, IRightsSource | [Place/DefinicjaPlanowanejListyPłac.md](Place/DefinicjaPlanowanejListyPłac.md) |
| DodatekAutomatyczny | Dodatki automatyczne | `DodAutomatyczne` |  | root |  | IBazaZrodlaWyplaty | [Place/DodatekAutomatyczny.md](Place/DodatekAutomatyczny.md) |
| DokumentRozliczeniaKontrahenta | Dokumenty rozliczenia kontrahenta | `DokumentyRozlKon` |  | root |  |  | [Place/DokumentRozliczeniaKontrahenta.md](Place/DokumentRozliczeniaKontrahenta.md) |
| DokumentRozliczeniaPracownika | Rozliczenia pracownika | `DokumentyRozlPra` |  | root |  |  | [Place/DokumentRozliczeniaPracownika.md](Place/DokumentRozliczeniaPracownika.md) |
| ElementBilansuOtwarciaPIT | Elementy bilansów otwarcia PIT | `ElementyBOPIT` |  | child: Dokument→BilansOtwarciaPIT |  |  | [Place/ElementBilansuOtwarciaPIT.md](Place/ElementBilansuOtwarciaPIT.md) |
| ElementRozliczeniaPracownika | Elementy rozliczenia | `ElementyRozlPrac` |  | root |  |  | [Place/ElementRozliczeniaPracownika.md](Place/ElementRozliczeniaPracownika.md) |
| KodRSA | Kody na deklaracji RSA | `KodyRSA` | konfig | root |  |  | [Place/KodRSA.md](Place/KodRSA.md) |
| KosztAutorski | Koszty autorskie | `KosztyAutorskie` |  | root |  |  | [Place/KosztAutorski.md](Place/KosztAutorski.md) |
| ListaPlac | Listy płac | `ListyPlac` |  | root |  | IDokumentKsiegowalny | [Place/ListaPlac.md](Place/ListaPlac.md) |
| NieobecnoscERP7 |  | `NieobecnosciERP7` |  |  |  |  | [Place/NieobecnoscERP7.md](Place/NieobecnoscERP7.md) |
| OdbiorcaElementu |  | `OdbElementow` |  | child: Definicja→DefinicjaElementu |  |  | [Place/OdbiorcaElementu.md](Place/OdbiorcaElementu.md) |
| OświadczenieZusOpieka | Oświadczenia do zasiłku opiekuńczego | `OswiadZusOpieka` |  | root |  |  | [Place/OświadczenieZusOpieka.md](Place/OświadczenieZusOpieka.md) |
| PlanowanaListaPłac | Planowane listy płac | `PlanListyPlac` |  | root |  | IDokumentKsiegowalny | [Place/PlanowanaListaPłac.md](Place/PlanowanaListaPłac.md) |
| PlanowanaWypłata | Planowane wypłaty | `PlanowaneWyplaty` |  | child: ListaPlac→PlanowanaListaPłac |  | IZrodloOpisuAnalitycznego | [Place/PlanowanaWypłata.md](Place/PlanowanaWypłata.md) |
| PlanowanyElementWypłaty | Planowane elementy | `PlanElementyWyp` |  | child: Wyplata→PlanowanaWypłata |  |  | [Place/PlanowanyElementWypłaty.md](Place/PlanowanyElementWypłaty.md) |
| PodstawaNieobecnosci |  | `PodstawyNieobec` |  | child: Pracownik→Pracownik |  |  | [Place/PodstawaNieobecnosci.md](Place/PodstawaNieobecnosci.md) |
| PodstawaNieobecnosciOkresowa |  | `PodstawyNieobOkr` |  | child: Pracownik→Pracownik |  |  | [Place/PodstawaNieobecnosciOkresowa.md](Place/PodstawaNieobecnosciOkresowa.md) |
| PozycjaPIT | Pozycje na deklaracjach PIT | `PozycjePIT` | konfig | root |  |  | [Place/PozycjaPIT.md](Place/PozycjaPIT.md) |
| ProgStazuPracy |  | `ProgiStazuPracy` | konfig | child: Definicja→DefinicjaElementu |  |  | [Place/ProgStazuPracy.md](Place/ProgStazuPracy.md) |
| RozliczenieDokKontrahenta | Dokumenty ewidencji rozliczeń kontrahentów | `RozliDokKontr` |  | child: Dokument→DokumentRozliczeniaKontrahenta |  |  | [Place/RozliczenieDokKontrahenta.md](Place/RozliczenieDokKontrahenta.md) |
| RozliczenieWynagrodzenia | Rozliczenia wynagrodzenia | `RozliczWynagrodz` |  | child: Host→IRozliczenieWynagrodzeniaHost |  |  | [Place/RozliczenieWynagrodzenia.md](Place/RozliczenieWynagrodzenia.md) |
| StornoElementu | Storna elementów | `StornaElementow` |  | child: Stornowany→WypElement |  |  | [Place/StornoElementu.md](Place/StornoElementu.md) |
| WynagrodzenieERP7 |  | `WynagrodzeERP7` |  |  |  |  | [Place/WynagrodzenieERP7.md](Place/WynagrodzenieERP7.md) |
| WypElement | Elementy wypłaty | `WypElementy` |  | root |  |  | [Place/WypElement.md](Place/WypElement.md) |
| WypSkladnik | Składniki wypłaty | `WypSkladniki` |  | child: Element→WypElement |  |  | [Place/WypSkladnik.md](Place/WypSkladnik.md) |
| Wyplata | Wypłaty | `Wyplaty` |  | root |  | IDokumentPlatny, IDokumentKsiegowalny, IZrodloOpisuAnalitycznego | [Place/Wyplata.md](Place/Wyplata.md) |
| Zaliczka |  | `Zaliczki` |  | root |  | IBazaZrodlaWyplaty, IPowiązanieWypłaty | [Place/Zaliczka.md](Place/Zaliczka.md) |
| ZaniechaniePodatkowe | Zaniechania podatkowe | `ZaniechPodatkowe` |  | root |  |  | [Place/ZaniechaniePodatkowe.md](Place/ZaniechaniePodatkowe.md) |
| ZasiłekInnyPłatnik | Zasiłki (inny płatnik) | `ZasInnyPlatnik` |  | root |  |  | [Place/ZasiłekInnyPłatnik.md](Place/ZasiłekInnyPłatnik.md) |

## PracaHybrydowa

- Opis: Moduł obsługujący pracę zdalną i hybrydową. Zawiera definicje miejsc pracy, harmonogramy pracy zdalnej oraz ewidencję obecności w biurze i poza nim.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| AreaPath | Obszary w systemie | `AreaPaths` |  | root |  |  | [PracaHybrydowa/AreaPath.md](PracaHybrydowa/AreaPath.md) |
| AreaPathTaskRel | Relacje zadań do obszarów | `AreaTaskRel` |  |  |  |  | [PracaHybrydowa/AreaPathTaskRel.md](PracaHybrydowa/AreaPathTaskRel.md) |
| DefinicjaRCP | Definicje rejestracji czasu pracy | `DefinicjeRCP` | konfig | root |  |  | [PracaHybrydowa/DefinicjaRCP.md](PracaHybrydowa/DefinicjaRCP.md) |
| DefinicjaWerRCP | Definicje weryfikatorow rejestracji czasu pracy | `DefinicjeWerRCP` | konfig | root |  |  | [PracaHybrydowa/DefinicjaWerRCP.md](PracaHybrydowa/DefinicjaWerRCP.md) |
| RelChangeInfo | Relacje historii zmian | `RelChangeInfos` |  |  |  |  | [PracaHybrydowa/RelChangeInfo.md](PracaHybrydowa/RelChangeInfo.md) |
| ZadaniaRelacja | Relacje Zadań pracy hybrydowej | `ZadRelacje` |  |  |  |  | [PracaHybrydowa/ZadaniaRelacja.md](PracaHybrydowa/ZadaniaRelacja.md) |

## Produkcja

- Opis: Moduł produkcyjny obsługujący planowanie i realizację procesów wytwórczych. Definiuje technologie produkcyjne z operacjami, pozycjami surowcowymi i produktowymi, czasami operacji oraz zasobami (maszynami, osobami). Wspiera rejestrację przebiegu produkcji, kalkulację kosztów wytworzenia, rezerwację surowców, raportowanie braków i awarii oraz rozliczenie akordowe.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| CzasTechn | Czasy operacji | `CzasyTechn` |  | root |  |  | [Produkcja/CzasTechn.md](Produkcja/CzasTechn.md) |
| KosztTechn | Koszty technologii | `KosztyTechn` |  | root |  |  | [Produkcja/KosztTechn.md](Produkcja/KosztTechn.md) |
| Operacja | Operacja produkcyjna | `Operacje` |  | root |  | IKosztTechnHost, IProdHistoriaZapis, IZasobTechHost, IKodowany | [Produkcja/Operacja.md](Produkcja/Operacja.md) |
| OperacjaPoprzedzajaca | Operacje poprzedzające, od których zależy możliwość wykonanania operacji | `OperacjePoprzed` |  |  |  |  | [Produkcja/OperacjaPoprzedzajaca.md](Produkcja/OperacjaPoprzedzajaca.md) |
| PozycjaTechn | Pozycje technologii | `PozycjeTechn` |  | root |  |  | [Produkcja/PozycjaTechn.md](Produkcja/PozycjaTechn.md) |
| ProdAwaria | Awarie produkcyjne | `ProdAwarie` |  | root |  |  | [Produkcja/ProdAwaria.md](Produkcja/ProdAwaria.md) |
| ProdHistoria | Rejestracja czasu operacji | `ProdHistorie` |  |  |  |  | [Produkcja/ProdHistoria.md](Produkcja/ProdHistoria.md) |
| ProdKompetencja | Słownik kompetencji osob produkcyjnych | `ProdKompetencje` |  |  |  |  | [Produkcja/ProdKompetencja.md](Produkcja/ProdKompetencja.md) |
| ProdMeldunekBraku | Meldunki braków | `ProdMeldBrakow` |  | root |  |  | [Produkcja/ProdMeldunekBraku.md](Produkcja/ProdMeldunekBraku.md) |
| ProdOsoba | Osoby wykonujące operacje produkcyjne | `ProdOsobyR` |  | root |  | IProdOsoba, IProdZasob | [Produkcja/ProdOsoba.md](Produkcja/ProdOsoba.md) |
| ProdOsobaKompetencja | Powiązanie osoby produkcyjnej z kompetancjami | `ProdOsobaKom` |  |  |  |  | [Produkcja/ProdOsobaKompetencja.md](Produkcja/ProdOsobaKompetencja.md) |
| ProdOsobaWzorcowa | Wzorce osób wykonujących operacje produkcyjne | `ProdOsobyWz` |  |  |  | IProdOsoba, IProdZasob | [Produkcja/ProdOsobaWzorcowa.md](Produkcja/ProdOsobaWzorcowa.md) |
| ProdPozSlownika | Pozycje słowników | `ProdPozSlownikow` | konfig | child: Slownik→ProdSlownik |  |  | [Produkcja/ProdPozSlownika.md](Produkcja/ProdPozSlownika.md) |
| ProdProdukt | Parametry towarów | `ProdProdukty` | konfig | root |  |  | [Produkcja/ProdProdukt.md](Produkcja/ProdProdukt.md) |
| ProdSlownik | Słowniki | `ProdSlowniki` | konfig | root |  |  | [Produkcja/ProdSlownik.md](Produkcja/ProdSlownik.md) |
| ProdZasob | Produkcyjne zasoby rzeczywiste | `ProdZasobyR` |  | root |  | IProdZasob | [Produkcja/ProdZasob.md](Produkcja/ProdZasob.md) |
| ProdZasobRelacja | Relacje zasobów produkcyjnych | `ProdZasobyRel` |  |  |  |  | [Produkcja/ProdZasobRelacja.md](Produkcja/ProdZasobRelacja.md) |
| ProdZasobWzorcowy | Produkcyjne zasoby wzorcowe | `ProdZasobyW` |  |  |  | IProdZasob | [Produkcja/ProdZasobWzorcowy.md](Produkcja/ProdZasobWzorcowy.md) |
| RelacjaProdZasobCRM | Relacje zasobow produkcujnych z zasobami CRM | `RelProdZasobCRM` |  |  |  |  | [Produkcja/RelacjaProdZasobCRM.md](Produkcja/RelacjaProdZasobCRM.md) |
| RezerwacjaSurowca | Rezerwacje surowca | `RezerwacjeSur` |  |  |  |  | [Produkcja/RezerwacjaSurowca.md](Produkcja/RezerwacjaSurowca.md) |
| Technologia | Technologie produkcyjne | `Technologie` |  | root |  | IKosztTechnHost, IZasobTechHost | [Produkcja/Technologia.md](Produkcja/Technologia.md) |
| WzorcowyCzasOper | Wzorcowe czasy operacji | `WzorcoweCzasOper` | konfig |  |  |  | [Produkcja/WzorcowyCzasOper.md](Produkcja/WzorcowyCzasOper.md) |
| ZasobTechn | Zasoby wzorcowe lub rzeczywiste przypisane do obiektów produkcyjnych | `ZasobyTechn` |  |  |  |  | [Produkcja/ZasobTechn.md](Produkcja/ZasobTechn.md) |

## ProdukcjaPro

- Opis: Zaawansowany moduł produkcji. Zawiera zlecenia produkcyjne, operacje technologiczne, harmonogramowanie, kontrolę jakości, marszruty oraz szczegółowe rozliczanie kosztów produkcji.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| ProAwaria | Awarie produkcyjne | `ProAwarie` |  | root |  |  | [ProdukcjaPro/ProAwaria.md](ProdukcjaPro/ProAwaria.md) |
| ProCzasPracy | Czasy pracy | `ProCzasyPracy` |  | child: ZasobOperacjiZlecenia→ProZasobOperacjiZlecenia |  |  | [ProdukcjaPro/ProCzasPracy.md](ProdukcjaPro/ProCzasPracy.md) |
| ProDefinicjaMeldunku | Definicje meldunku produkcyjnego | `ProDMeldunkow` |  | root |  |  | [ProdukcjaPro/ProDefinicjaMeldunku.md](ProdukcjaPro/ProDefinicjaMeldunku.md) |
| ProDefinicjaOperacji | Definicje operacji produkcyjnych | `ProDOperacji` |  | root |  |  | [ProdukcjaPro/ProDefinicjaOperacji.md](ProdukcjaPro/ProDefinicjaOperacji.md) |
| ProDostawaMaterialuMeldunku | Dostawy materiałów meldunków | `ProDostawyMM` |  | child: MaterialMeldunku→ProMaterialMeldunku |  |  | [ProdukcjaPro/ProDostawaMaterialuMeldunku.md](ProdukcjaPro/ProDostawaMaterialuMeldunku.md) |
| ProFantomMaterialu | Fantomy materiałów | `ProFanMaterialow` |  | child: RozliczenieMaterialu→ProRozliczenieMaterialu |  |  | [ProdukcjaPro/ProFantomMaterialu.md](ProdukcjaPro/ProFantomMaterialu.md) |
| ProFantomWyrobu | Fantomy wyrobów | `ProFanWyrobow` |  | child: RozliczenieWyrobu→ProRozliczenieWyrobu |  |  | [ProdukcjaPro/ProFantomWyrobu.md](ProdukcjaPro/ProFantomWyrobu.md) |
| ProKalkulacjaMeldunku | Kalkulacje meldunku | `ProKalkulacjeM` |  | child: Meldunek→ProMeldunek |  |  | [ProdukcjaPro/ProKalkulacjaMeldunku.md](ProdukcjaPro/ProKalkulacjaMeldunku.md) |
| ProKalkulacjaOperacjiTechnologii | Kalkulacje operacji technologii | `ProKalkulacjeOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  | [ProdukcjaPro/ProKalkulacjaOperacjiTechnologii.md](ProdukcjaPro/ProKalkulacjaOperacjiTechnologii.md) |
| ProKalkulacjaOperacjiZlecenia | Kalkulacje operacji zleceń | `ProKalkulacjeOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProKalkulacjaOperacjiZlecenia.md](ProdukcjaPro/ProKalkulacjaOperacjiZlecenia.md) |
| ProKompetencja | Właściwości produkcyjne | `ProKompetencje` |  | root |  |  | [ProdukcjaPro/ProKompetencja.md](ProdukcjaPro/ProKompetencja.md) |
| ProMaterialMeldunku | Materiały meldunków | `ProMaterialyM` |  | child: Meldunek→ProMeldunek |  |  | [ProdukcjaPro/ProMaterialMeldunku.md](ProdukcjaPro/ProMaterialMeldunku.md) |
| ProMaterialOperacjiTechnologii | Materiały operacji technologii | `ProMaterialyOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  | [ProdukcjaPro/ProMaterialOperacjiTechnologii.md](ProdukcjaPro/ProMaterialOperacjiTechnologii.md) |
| ProMaterialOperacjiZlecenia | Materiały operacji zleceń | `ProMaterialyOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProMaterialOperacjiZlecenia.md](ProdukcjaPro/ProMaterialOperacjiZlecenia.md) |
| ProMeldunek | Meldunki produkcyjne | `ProMeldunki` |  | root |  |  | [ProdukcjaPro/ProMeldunek.md](ProdukcjaPro/ProMeldunek.md) |
| ProNumeracjaMeldunku | Numeracje meldunków | `ProNumeracjeMeld` | konfig | child: Wydzial→ProWydzial |  |  | [ProdukcjaPro/ProNumeracjaMeldunku.md](ProdukcjaPro/ProNumeracjaMeldunku.md) |
| ProNumeracjaTechnologii | Numeracje technologii | `ProNumeracjeTech` | konfig | child: Wydzial→ProWydzial |  |  | [ProdukcjaPro/ProNumeracjaTechnologii.md](ProdukcjaPro/ProNumeracjaTechnologii.md) |
| ProNumeracjaWyrobuMeldunku | Numeracje wyrobów meldunków | `ProNrWyrobowM` |  | child: WyrobMeldunku→ProWyrobMeldunku |  |  | [ProdukcjaPro/ProNumeracjaWyrobuMeldunku.md](ProdukcjaPro/ProNumeracjaWyrobuMeldunku.md) |
| ProNumeracjaZlecenia | Numeracje zleceń | `ProNumeracjeZlec` | konfig | child: Wydzial→ProWydzial |  |  | [ProdukcjaPro/ProNumeracjaZlecenia.md](ProdukcjaPro/ProNumeracjaZlecenia.md) |
| ProOdpadMeldunku | Odpady meldunków | `ProOdpadyM` |  | child: Meldunek→ProMeldunek |  |  | [ProdukcjaPro/ProOdpadMeldunku.md](ProdukcjaPro/ProOdpadMeldunku.md) |
| ProOdpadOperacjiTechnologii | Odpady operacji technologii | `ProOdpadyOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  | [ProdukcjaPro/ProOdpadOperacjiTechnologii.md](ProdukcjaPro/ProOdpadOperacjiTechnologii.md) |
| ProOdpadOperacjiZlecenia | Odpady operacji zleceń | `ProOdpadyOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProOdpadOperacjiZlecenia.md](ProdukcjaPro/ProOdpadOperacjiZlecenia.md) |
| ProOperacjaTechnologii | Operacje technologii | `ProOperacjeTech` |  | child: Technologia→ProTechnologia |  |  | [ProdukcjaPro/ProOperacjaTechnologii.md](ProdukcjaPro/ProOperacjaTechnologii.md) |
| ProOperacjaTechnologiiPoprzedzajaca | Operacje technologii poprzedzające | `ProOperacjeTechP` |  | child: Operacja→ProOperacjaTechnologii |  |  | [ProdukcjaPro/ProOperacjaTechnologiiPoprzedzajaca.md](ProdukcjaPro/ProOperacjaTechnologiiPoprzedzajaca.md) |
| ProOperacjaZlecenia | Operacje zleceń | `ProOperacjeZlec` |  | child: Zlecenie→ProZlecenie |  |  | [ProdukcjaPro/ProOperacjaZlecenia.md](ProdukcjaPro/ProOperacjaZlecenia.md) |
| ProOperacjaZleceniaPoprzedzajaca | Operacje zleceń poprzedzające | `ProOperacjeZlecP` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProOperacjaZleceniaPoprzedzajaca.md](ProdukcjaPro/ProOperacjaZleceniaPoprzedzajaca.md) |
| ProOsoba | Osoby produkcyjne | `ProOsoby` |  | root |  |  | [ProdukcjaPro/ProOsoba.md](ProdukcjaPro/ProOsoba.md) |
| ProPlanPracy | Plany pracy | `ProPlanyPracy` |  | child: Zasob→ProZasobOperacjiZlecenia |  |  | [ProdukcjaPro/ProPlanPracy.md](ProdukcjaPro/ProPlanPracy.md) |
| ProPozycjaGlownaTechnologii | Główne pozycje technologii | `ProPGlownaT` |  | child: Technologia→ProTechnologia |  |  | [ProdukcjaPro/ProPozycjaGlownaTechnologii.md](ProdukcjaPro/ProPozycjaGlownaTechnologii.md) |
| ProPozycjaKompetencji | Pozycje właściwości | `ProPKompetencji` |  | child: Kompetencja→ProKompetencja |  |  | [ProdukcjaPro/ProPozycjaKompetencji.md](ProdukcjaPro/ProPozycjaKompetencji.md) |
| ProPozycjaZamowienia | Pozycje zamówień | `ProPZamowien` |  | child: Wyrob→ProWyrobOperacjiZlecenia |  |  | [ProdukcjaPro/ProPozycjaZamowienia.md](ProdukcjaPro/ProPozycjaZamowienia.md) |
| ProPozycjaZestawieniaMaterialow | Pozycje zestawień materiałów | `ProPZestawienM` |  | child: Zestawienie→ProZestawienieMaterialow |  |  | [ProdukcjaPro/ProPozycjaZestawieniaMaterialow.md](ProdukcjaPro/ProPozycjaZestawieniaMaterialow.md) |
| ProRelacjaMaterialWyrobOperacjiTechnologii | Relacje materiałów i wyrobów operacji techologii | `ProRMatWyrOT` |  | child: Material→ProMaterialOperacjiTechnologii |  |  | [ProdukcjaPro/ProRelacjaMaterialWyrobOperacjiTechnologii.md](ProdukcjaPro/ProRelacjaMaterialWyrobOperacjiTechnologii.md) |
| ProRelacjaMaterialWyrobOperacjiZlecenia | Relacje materiałów i wyrobów operacji zlecenia | `ProRMatWyrOZ` |  | child: Material→ProMaterialOperacjiZlecenia |  |  | [ProdukcjaPro/ProRelacjaMaterialWyrobOperacjiZlecenia.md](ProdukcjaPro/ProRelacjaMaterialWyrobOperacjiZlecenia.md) |
| ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji | Relacje zasobów operacji technologii i pozycji właściwości | `ProRZasobOTPKomp` |  | child: ZasobOperacjiTechnologii→ProZasobOperacjiTechnologii |  |  | [ProdukcjaPro/ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji.md](ProdukcjaPro/ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji.md) |
| ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji | Relacje zasobów operacji zleceń i pozycji właściwości | `ProRZasobOZPKomp` |  | child: ZasobOperacjiZlecenia→ProZasobOperacjiZlecenia |  |  | [ProdukcjaPro/ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji.md](ProdukcjaPro/ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji.md) |
| ProRelacjaZasobPozycjaKompetencji | Relacje zasobów i pozycji właściwości | `ProRZasobPKomp` |  | child: Zasob→ProZasob |  |  | [ProdukcjaPro/ProRelacjaZasobPozycjaKompetencji.md](ProdukcjaPro/ProRelacjaZasobPozycjaKompetencji.md) |
| ProRelacjaZasobUrzadzenie | Relacje zasobów i urządzeń | `ProRZasobUrz` |  | child: Zasob→ProZasob |  |  | [ProdukcjaPro/ProRelacjaZasobUrzadzenie.md](ProdukcjaPro/ProRelacjaZasobUrzadzenie.md) |
| ProRozliczenieMaterialu | Rozliczenia materiałów | `ProRozMaterialow` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProRozliczenieMaterialu.md](ProdukcjaPro/ProRozliczenieMaterialu.md) |
| ProRozliczenieOdpadu | Rozliczenia odpadów | `ProRozOdpadow` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProRozliczenieOdpadu.md](ProdukcjaPro/ProRozliczenieOdpadu.md) |
| ProRozliczenieWyrobu | Rozliczenia wyrobów | `ProRozWyrobow` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProRozliczenieWyrobu.md](ProdukcjaPro/ProRozliczenieWyrobu.md) |
| ProRozliczenieZapotrzebowania | Rozliczenia zapotrzebowań | `ProRozZapot` |  | child: MaterialOperacjiZlecenia→ProMaterialOperacjiZlecenia |  |  | [ProdukcjaPro/ProRozliczenieZapotrzebowania.md](ProdukcjaPro/ProRozliczenieZapotrzebowania.md) |
| ProStawka | Stawki produkcyjne | `ProStawki` |  | root |  |  | [ProdukcjaPro/ProStawka.md](ProdukcjaPro/ProStawka.md) |
| ProTechnologia | Technologie produkcyjne | `ProTechnologie` |  | root |  |  | [ProdukcjaPro/ProTechnologia.md](ProdukcjaPro/ProTechnologia.md) |
| ProTechnologiaMaterialuOperacjiTechnologii | Technologie materiałów operacji technologii | `ProTechMatOT` |  | child: Material→ProMaterialOperacjiTechnologii |  |  | [ProdukcjaPro/ProTechnologiaMaterialuOperacjiTechnologii.md](ProdukcjaPro/ProTechnologiaMaterialuOperacjiTechnologii.md) |
| ProTechnologiaMaterialuOperacjiZlecenia | Technologie materiałów operacji zleceń | `ProTechMatOZ` |  | child: Material→ProMaterialOperacjiZlecenia |  |  | [ProdukcjaPro/ProTechnologiaMaterialuOperacjiZlecenia.md](ProdukcjaPro/ProTechnologiaMaterialuOperacjiZlecenia.md) |
| ProTowar | Towary produkcyjne | `ProTowary` |  | child: Towar→Towar |  |  | [ProdukcjaPro/ProTowar.md](ProdukcjaPro/ProTowar.md) |
| ProTowarMeldowanyOperacjiTechnologii | Towary meldowane operacji technologii | `ProTowaryMeldOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  | [ProdukcjaPro/ProTowarMeldowanyOperacjiTechnologii.md](ProdukcjaPro/ProTowarMeldowanyOperacjiTechnologii.md) |
| ProTowarMeldowanyOperacjiZlecenia | Towary meldowane operacji zleceń | `ProTowaryMeldOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProTowarMeldowanyOperacjiZlecenia.md](ProdukcjaPro/ProTowarMeldowanyOperacjiZlecenia.md) |
| ProUslugaMeldunku | Usługi meldunków | `ProUslugiM` |  | child: Meldunek→ProMeldunek |  |  | [ProdukcjaPro/ProUslugaMeldunku.md](ProdukcjaPro/ProUslugaMeldunku.md) |
| ProUslugaOperacjiTechnologii | Usługi operacji technologii | `ProUslugiOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  | [ProdukcjaPro/ProUslugaOperacjiTechnologii.md](ProdukcjaPro/ProUslugaOperacjiTechnologii.md) |
| ProUslugaOperacjiZlecenia | Usługi operacji zleceń | `ProUslugiOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProUslugaOperacjiZlecenia.md](ProdukcjaPro/ProUslugaOperacjiZlecenia.md) |
| ProUzytkownikPaneluMeldunkowego | Użytkownicy paneli meldunkowych | `ProUzytkownicyPM` | konfig | root |  | IWebOperator, ITaskUser | [ProdukcjaPro/ProUzytkownikPaneluMeldunkowego.md](ProdukcjaPro/ProUzytkownikPaneluMeldunkowego.md) |
| ProWariantowoscZasobu | Wariantowość zasobów produkcyjnych | `ProWarZasobow` |  | child: Zasob→ProZasob |  |  | [ProdukcjaPro/ProWariantowoscZasobu.md](ProdukcjaPro/ProWariantowoscZasobu.md) |
| ProWariantowoscZasobuOperacjiTechnologii | Wariantowość zasobów operacji technologii | `ProWarZasobowOT` |  | child: ZasobOperacjiTechnologii→ProZasobOperacjiTechnologii |  |  | [ProdukcjaPro/ProWariantowoscZasobuOperacjiTechnologii.md](ProdukcjaPro/ProWariantowoscZasobuOperacjiTechnologii.md) |
| ProWariantowoscZasobuOperacjiZlecenia | Wariantowość zasobów operacji zlecenia | `ProWarZasobowOZ` |  | child: ZasobOperacjiZlecenia→ProZasobOperacjiZlecenia |  |  | [ProdukcjaPro/ProWariantowoscZasobuOperacjiZlecenia.md](ProdukcjaPro/ProWariantowoscZasobuOperacjiZlecenia.md) |
| ProWydzial | Wydziały produkcyjne | `ProWydzialy` | konfig | root |  | IRightsSource, IElementSlownika | [ProdukcjaPro/ProWydzial.md](ProdukcjaPro/ProWydzial.md) |
| ProWyrobMeldunku | Wyroby meldunków | `ProWyrobyM` |  | child: Meldunek→ProMeldunek |  |  | [ProdukcjaPro/ProWyrobMeldunku.md](ProdukcjaPro/ProWyrobMeldunku.md) |
| ProWyrobOperacjiTechnologii | Wyroby operacji technologii | `ProWyrobyOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  | [ProdukcjaPro/ProWyrobOperacjiTechnologii.md](ProdukcjaPro/ProWyrobOperacjiTechnologii.md) |
| ProWyrobOperacjiZlecenia | Wyroby operacji zleceń | `ProWyrobyOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProWyrobOperacjiZlecenia.md](ProdukcjaPro/ProWyrobOperacjiZlecenia.md) |
| ProZasob | Zasoby produkcyjne | `ProZasoby` |  | root |  | IElementSlownika | [ProdukcjaPro/ProZasob.md](ProdukcjaPro/ProZasob.md) |
| ProZasobMeldunku | Zasoby meldunków | `ProZasobyM` |  | child: Meldunek→ProMeldunek |  |  | [ProdukcjaPro/ProZasobMeldunku.md](ProdukcjaPro/ProZasobMeldunku.md) |
| ProZasobOperacjiTechnologii | Zasoby operacji technologii | `ProZasobyOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  | [ProdukcjaPro/ProZasobOperacjiTechnologii.md](ProdukcjaPro/ProZasobOperacjiTechnologii.md) |
| ProZasobOperacjiZlecenia | Zasoby operacji zleceń | `ProZasobyOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  | [ProdukcjaPro/ProZasobOperacjiZlecenia.md](ProdukcjaPro/ProZasobOperacjiZlecenia.md) |
| ProZestawienieMaterialow | Zestawienia materiałów | `ProZestawieniaM` |  | root |  |  | [ProdukcjaPro/ProZestawienieMaterialow.md](ProdukcjaPro/ProZestawienieMaterialow.md) |
| ProZlecenie | Zlecenia produkcyjne | `ProZlecenia` |  | root |  | IElementSlownika | [ProdukcjaPro/ProZlecenie.md](ProdukcjaPro/ProZlecenie.md) |

## Przeszeregowania

- Opis: Moduł obsługujący przeszeregowania pracowników. Zawiera mechanizmy masowych zmian warunków zatrudnienia, wynagrodzeń i stanowisk.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| ElementPrzeszeregowania | Elementy przeszeregowań | `ElementyPrzeszer` |  | child: Przeszeregowanie→Przeszeregowanie |  |  | [Przeszeregowania/ElementPrzeszeregowania.md](Przeszeregowania/ElementPrzeszeregowania.md) |
| Przeszeregowanie | Przeszeregowania pracowników | `Przeszeregowania` |  | root |  |  | [Przeszeregowania/Przeszeregowanie.md](Przeszeregowania/Przeszeregowanie.md) |

## RMK

- Opis: Moduł rozliczeń międzyokresowych kosztów (RMK). Zawiera definicje harmonogramów rozliczania kosztów w czasie, pozycje rozliczeń oraz automatyczne generowanie dekretów.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| DokumentRMK | Dokumenty RMK | `DokumentyRMK` |  | root |  | IDokumentKsiegowalny | [RMK/DokumentRMK.md](RMK/DokumentRMK.md) |
| KosztRMK | Koszty RMK | `KosztyRMK` |  | root |  | IElementSlownika, IZrodloPodzielnikaKosztow | [RMK/KosztRMK.md](RMK/KosztRMK.md) |
| ObrotRMK | Obroty RMK | `ObrotyRMK` |  |  |  | IZrodloOpisuAnalitycznego | [RMK/ObrotRMK.md](RMK/ObrotRMK.md) |

## RealEstate

- Opis: Moduł zarządzania nieruchomościami. Zawiera kartotekę nieruchomości, lokali, najemców, umowy najmu, rozliczenia mediów oraz mechanizmy fakturowania opłat.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| CelRezerwacji | Cele rezerwacji | `CeleRezerwacji` | konfig | root |  |  | [RealEstate/CelRezerwacji.md](RealEstate/CelRezerwacji.md) |
| DefinicjaAlgorytmuUslugi | Definicje algorytmów usług nieruchomości | `DefAlgUslug` | konfig | root |  |  | [RealEstate/DefinicjaAlgorytmuUslugi.md](RealEstate/DefinicjaAlgorytmuUslugi.md) |
| DefinicjaRozliczeniaMediow | Definicje rozliczeń mediów nieruchomości | `DefRozMediow` | konfig | root |  | IRightsSource | [RealEstate/DefinicjaRozliczeniaMediow.md](RealEstate/DefinicjaRozliczeniaMediow.md) |
| NieruSrTrwalyRel | Relacje nieruchomości do środków trwałych | `NieruSrTrwaleRel` |  |  |  |  | [RealEstate/NieruSrTrwalyRel.md](RealEstate/NieruSrTrwalyRel.md) |
| NieruWydzialRel | Relacje urządzeń do jednostek organizacyjnych | `NieruWydzialyRel` |  |  |  |  | [RealEstate/NieruWydzialRel.md](RealEstate/NieruWydzialRel.md) |
| Nieruchomosc | Nieruchomości | `Nieruchomosci` |  | root | historyczna → NieruchomoscHis | IZasobCRM, IDocumentHostCRM, IObiektDoPlanowania | [RealEstate/Nieruchomosc.md](RealEstate/Nieruchomosc.md) |
| NieruchomoscHis | Historia nieruchomości | `NieruchomosciHis` |  | root | historia | IDocumentHostCRM | [RealEstate/NieruchomoscHis.md](RealEstate/NieruchomoscHis.md) |
| NieruchomoscRef | Struktura nieruchomości | `NieruchomosciRef` |  | child: Nieruchomosc→Nieruchomosc |  |  | [RealEstate/NieruchomoscRef.md](RealEstate/NieruchomoscRef.md) |
| NieruchomoscRel | Relacje nieruchomości | `NieruchomosciRel` |  |  |  |  | [RealEstate/NieruchomoscRel.md](RealEstate/NieruchomoscRel.md) |
| NieruchomoscUzyta | Nieruchomości wykorzystane | `NieruchomUzyte` |  |  |  |  | [RealEstate/NieruchomoscUzyta.md](RealEstate/NieruchomoscUzyta.md) |
| NieruchomoscZdarzenie | Zdarzenia nieruchmości | `NieruZdarzenia` |  | root |  |  | [RealEstate/NieruchomoscZdarzenie.md](RealEstate/NieruchomoscZdarzenie.md) |
| RezerwacjaStanowiskaPracy | Rezerwacja stanowiska pracy | `RezerStanowPracy` |  | root |  |  | [RealEstate/RezerwacjaStanowiskaPracy.md](RealEstate/RezerwacjaStanowiskaPracy.md) |
| RozliczenieMediow | Rozliczenia mediów | `RozMediow` |  | root |  | IDocumentHostCRM | [RealEstate/RozliczenieMediow.md](RealEstate/RozliczenieMediow.md) |
| StanNieruchomosci | Stany nieruchomości | `StanyNieruchom` | konfig | root |  |  | [RealEstate/StanNieruchomosci.md](RealEstate/StanNieruchomosci.md) |
| StanowiskoPracy | Stanowisko pracy | `StanowiskaPracy` |  | root |  |  | [RealEstate/StanowiskoPracy.md](RealEstate/StanowiskoPracy.md) |
| StnPracSrTrwalyRel | Relacje stanowisk do środków trwałych | `StnPracSrTrwRel` |  | root |  |  | [RealEstate/StnPracSrTrwalyRel.md](RealEstate/StnPracSrTrwalyRel.md) |
| TypNieruchomosc | Typy nieruchomości | `TypyNieruchom` | konfig | root |  | IRightsSource | [RealEstate/TypNieruchomosc.md](RealEstate/TypNieruchomosc.md) |
| UslugaNieruch | Usługa nieruchomości | `UslugiNieruch` |  | root |  |  | [RealEstate/UslugaNieruch.md](RealEstate/UslugaNieruch.md) |
| UslugaZdarzenia | Usługi zdarzenia | `UslugiZdarzenia` |  |  |  |  | [RealEstate/UslugaZdarzenia.md](RealEstate/UslugaZdarzenia.md) |

## Samochodowka

- Opis: Moduł ewidencji przebiegu pojazdów (kilometrówka). Zawiera rejestr pojazdów, trasy, stawki za kilometry oraz rozliczenia kosztów przejazdów służbowych.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| DefinicjaTrasy | Definicje tras | `DefinicjeTras` |  | root |  |  | [Samochodowka/DefinicjaTrasy.md](Samochodowka/DefinicjaTrasy.md) |
| EkoPaliwoSilnika | Paliwa silnika | `EkoPaliwaSilnika` | konfig |  | historyczna → EkoPaliwoStawka | IRowWithHistory | [Samochodowka/EkoPaliwoSilnika.md](Samochodowka/EkoPaliwoSilnika.md) |
| EkoPaliwoStawka | Stawki opłat za emisję | `EkoPaliwaStawki` | konfig | child: PaliwoSilnika→EkoPaliwoSilnika | historia → EkoPaliwoSilnika |  | [Samochodowka/EkoPaliwoStawka.md](Samochodowka/EkoPaliwoStawka.md) |
| EkoRodzajPaliwa | Rodzaje paliw (środowisko) | `EkoRodzajePaliw` | konfig | root |  |  | [Samochodowka/EkoRodzajPaliwa.md](Samochodowka/EkoRodzajPaliwa.md) |
| EkoRodzajSilnika | Rodzaje silników | `EkoRodzSilnikow` | konfig | root |  |  | [Samochodowka/EkoRodzajSilnika.md](Samochodowka/EkoRodzajSilnika.md) |
| KosztEP | KosztyEP | `KosztyEP` |  | root |  |  | [Samochodowka/KosztEP.md](Samochodowka/KosztEP.md) |
| PaliwoPojazdu | Paliwa pojazdu | `PaliwaPojazdu` |  |  |  |  | [Samochodowka/PaliwoPojazdu.md](Samochodowka/PaliwoPojazdu.md) |
| Pojazd |  | `Pojazdy` |  | root |  | IElementSlownika, IZasobCRM | [Samochodowka/Pojazd.md](Samochodowka/Pojazd.md) |
| Przejazd |  | `Przejazdy` |  | root |  |  | [Samochodowka/Przejazd.md](Samochodowka/Przejazd.md) |
| RozliczenieEP | Rozliczenia | `RozliczeniaEP` |  | root |  | IDokumentKsiegowalny | [Samochodowka/RozliczenieEP.md](Samochodowka/RozliczenieEP.md) |

## SrodkiTrwale

- Opis: Moduł obsługujący środki trwałe i wartości niematerialne. Zawiera kartotekę środków trwałych, dokumenty OT/LT/MT, amortyzację, inwentaryzację oraz plan amortyzacji.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| DokumentPowiazanyUL | Dokumenty powiązane UL | `DokumentyPowiazaneUL` |  |  |  |  | [SrodkiTrwale/DokumentPowiazanyUL.md](SrodkiTrwale/DokumentPowiazanyUL.md) |
| DokumentST | Dokumenty ŚT | `DokumentyST` |  | root |  | IDokumentKsiegowalny | [SrodkiTrwale/DokumentST.md](SrodkiTrwale/DokumentST.md) |
| DokumentUL | Dokumenty UL | `DokumentyUL` |  | root |  | IDokument | [SrodkiTrwale/DokumentUL.md](SrodkiTrwale/DokumentUL.md) |
| ElemPlanuAmortyzacji | Plan amortyzacji | `PlanAmortyzacji` |  | child: Srodek→SrodekTrwalyBase |  |  | [SrodkiTrwale/ElemPlanuAmortyzacji.md](SrodkiTrwale/ElemPlanuAmortyzacji.md) |
| ElementPodatkuOdNieruch | Elementy podatku od nieruchomości | `ElemPodOdNieruch` |  | child: Historia→SrodekTrwalyBaseHistoria |  |  | [SrodkiTrwale/ElementPodatkuOdNieruch.md](SrodkiTrwale/ElementPodatkuOdNieruch.md) |
| KategoriaST | Kategorie środka trwałego | `KategorieST` | konfig | root |  | IRightsSource | [SrodkiTrwale/KategoriaST.md](SrodkiTrwale/KategoriaST.md) |
| KategoriaZapotrzebowania | Kategorie zapotrzebowania | `KategorieZap` | konfig | root |  | IRightsSource | [SrodkiTrwale/KategoriaZapotrzebowania.md](SrodkiTrwale/KategoriaZapotrzebowania.md) |
| LokalizacjaNier | Lokalizacja nieruchomości | `LokalizacjeNier` |  | root | historyczna → LokalizacjaNierHistoria |  | [SrodkiTrwale/LokalizacjaNier.md](SrodkiTrwale/LokalizacjaNier.md) |
| LokalizacjaNierHistoria | Historia lokalizacji nieruchomości | `LokalizacjeNierH` |  | child: Lokalizacja→LokalizacjaNier | historia → LokalizacjaNier |  | [SrodkiTrwale/LokalizacjaNierHistoria.md](SrodkiTrwale/LokalizacjaNierHistoria.md) |
| MiejsceUzytkowania | Miejsca użytkowania | `MiejscaUzytk` | konfig | root |  | IRightsSource | [SrodkiTrwale/MiejsceUzytkowania.md](SrodkiTrwale/MiejsceUzytkowania.md) |
| ObrotST | Obroty środków trwałych | `ObrotyST` |  | child: Dokument→DokumentST |  | IZrodloOpisuAnalitycznego | [SrodkiTrwale/ObrotST.md](SrodkiTrwale/ObrotST.md) |
| ParametrOdpisu | Parametry odpisów | `ParametryOdpisow` |  | child: Amortyzacja→ObrotST |  |  | [SrodkiTrwale/ParametrOdpisu.md](SrodkiTrwale/ParametrOdpisu.md) |
| PozycjaTerminarzaInw | Terminarz inwentarza | `TerminarzInw` |  |  |  |  | [SrodkiTrwale/PozycjaTerminarzaInw.md](SrodkiTrwale/PozycjaTerminarzaInw.md) |
| ProporcjaAmortyzacji | Proporcja amortyzacji | `ProporcjeAmortyzacji` |  | child: Srodek→SrodekTrwalyBase |  |  | [SrodkiTrwale/ProporcjaAmortyzacji.md](SrodkiTrwale/ProporcjaAmortyzacji.md) |
| PrzedmiotOp | Przedmiot opodatkowania | `PrzedmiotyOp` |  | child: Historia→LokalizacjaNierHistoria |  |  | [SrodkiTrwale/PrzedmiotOp.md](SrodkiTrwale/PrzedmiotOp.md) |
| RataLeasingST | Rata | `RatyLeasingST` |  | child: Srodek→SrodekTrwalyBase |  |  | [SrodkiTrwale/RataLeasingST.md](SrodkiTrwale/RataLeasingST.md) |
| RodzajPO | Rodzaje przedmiotów opodatkowania | `RodzajePO` |  | root |  |  | [SrodkiTrwale/RodzajPO.md](SrodkiTrwale/RodzajPO.md) |
| RodzajST | Klasyfikacja Rodzajowa Środków Trwałych | `KRST` | konfig | root |  |  | [SrodkiTrwale/RodzajST.md](SrodkiTrwale/RodzajST.md) |
| SrodekTrwalyBase | Ewidencja środków trwałych oraz wartości niematerialnych i prawnych | `SrodkiTrwale` |  | root | historyczna → SrodekTrwalyBaseHistoria | IInwentarz, IElementSlownika, IZasobCRM, IKodowany, IZrodloPodzielnikaKosztow | [SrodkiTrwale/SrodekTrwalyBase.md](SrodkiTrwale/SrodekTrwalyBase.md) |
| SrodekTrwalyBaseHistoria | Ewidencja środków trwałych oraz wartości niematerialnych i prawnych - historia | `SrodkiTrwaleHist` |  | child: Srodek→SrodekTrwalyBase | historia → SrodekTrwalyBase |  | [SrodkiTrwale/SrodekTrwalyBaseHistoria.md](SrodkiTrwale/SrodekTrwalyBaseHistoria.md) |
| SrodekTrwalyLeasing | Leasing | `SrodkiTrwaleLeas` |  | child: Srodek→SrodekTrwalyBase |  |  | [SrodkiTrwale/SrodekTrwalyLeasing.md](SrodkiTrwale/SrodekTrwalyLeasing.md) |
| TypOplatyLeasing | Typ opłaty | `TypyOplLeasingi` |  | child: Leasing→SrodekTrwalyLeasing |  |  | [SrodkiTrwale/TypOplatyLeasing.md](SrodkiTrwale/TypOplatyLeasing.md) |
| TypOplatyMSR | Typy opłaty MSR | `TypyOplatMSR` | konfig | root |  |  | [SrodkiTrwale/TypOplatyMSR.md](SrodkiTrwale/TypOplatyMSR.md) |
| TytulDokumentuST | Tytuły dokumentów | `TytulyDokST` | konfig | root |  |  | [SrodkiTrwale/TytulDokumentuST.md](SrodkiTrwale/TytulDokumentuST.md) |
| Wyposazenie | Ewidencja wyposażenia | `EwidWyposazenia` |  | root | historyczna → WyposazenieHistoria | IInwentarz, IKodowany, IZasobCRM | [SrodkiTrwale/Wyposazenie.md](SrodkiTrwale/Wyposazenie.md) |
| WyposazenieHistoria | Ewidencja wyposażenia - historia | `EwidWyposazeniaH` |  | child: Wyposazenie→Wyposazenie | historia → Wyposazenie |  | [SrodkiTrwale/WyposazenieHistoria.md](SrodkiTrwale/WyposazenieHistoria.md) |
| ZestawST | Zestawy środków trwałych | `ZestawyST` |  | root |  |  | [SrodkiTrwale/ZestawST.md](SrodkiTrwale/ZestawST.md) |

## Support

- Opis: Moduł wsparcia technicznego i helpdesk. Zawiera zgłoszenia serwisowe, kolejki obsługi, umowy SLA, bazę wiedzy oraz mechanizmy śledzenia i eskalacji problemów.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| Evaluation | Ocena | `Evaluations` |  |  |  |  | [Support/Evaluation.md](Support/Evaluation.md) |
| HistoricalState | Statusy historyczne | `HistoricalStates` |  |  |  |  | [Support/HistoricalState.md](Support/HistoricalState.md) |
| NotificationConfiguration | Powiadomienia | `NotificationConf` |  |  |  |  | [Support/NotificationConfiguration.md](Support/NotificationConfiguration.md) |
| OperatorConfiguration | Operator | `OperatorsConfig` |  |  |  |  | [Support/OperatorConfiguration.md](Support/OperatorConfiguration.md) |
| OperatorToTeam | Operator Moduł | `OperatorsToTeam` | konfig | root |  |  | [Support/OperatorToTeam.md](Support/OperatorToTeam.md) |
| Priority | Priorytety | `TicketPriorities` | konfig | root |  |  | [Support/Priority.md](Support/Priority.md) |
| Product | Produkty | `ProductsSupport` | konfig | root |  |  | [Support/Product.md](Support/Product.md) |
| ProductVersion | Wersje | `ProductVersions` | konfig | root |  |  | [Support/ProductVersion.md](Support/ProductVersion.md) |
| RelationToDoc |  | `RelationsToDoc` |  | root |  |  | [Support/RelationToDoc.md](Support/RelationToDoc.md) |
| SLACalendar | Kalendarz | `SLACalendars` | konfig | root |  |  | [Support/SLACalendar.md](Support/SLACalendar.md) |
| SLADocument | Parametry SLA dla dokumentu | `SLADocuments` |  | root |  | ISLADocument | [Support/SLADocument.md](Support/SLADocument.md) |
| State | Stany | `TicketStates` | konfig | root |  |  | [Support/State.md](Support/State.md) |
| SupportOperator | Operatorzy wsparcia | `SupportOperators` |  | child: Operator→Operator |  | IDaneKontaktoweHost | [Support/SupportOperator.md](Support/SupportOperator.md) |
| Team | Zespół | `Teams` |  | root |  | IDaneKontaktoweHost | [Support/Team.md](Support/Team.md) |
| Ticket | ServiceDesk | `Tickets` |  | root |  | IDokument | [Support/Ticket.md](Support/Ticket.md) |
| TicketDefinition | Definicje Zgłoszeń | `TicketsDefs` | konfig | root |  | IRightsSource | [Support/TicketDefinition.md](Support/TicketDefinition.md) |
| TicketFollower | Obserwowane zgłoszenia | `TicketFollowers` |  | root |  |  | [Support/TicketFollower.md](Support/TicketFollower.md) |

## Towary

- Opis: Moduł kartoteki towarów i usług obsługujący ewidencję asortymentu, jednostek miar z przelicznikami, cenników (w tym cen indywidualnych, grupowych, progowych i promocji okresowych) oraz kodów kreskowych. Definiuje schematy opakowań, zamienniki towarowe, komplety produkcyjne, klasyfikacje CN/CPV/BDO/SUP oraz mechanizmy rabatowania i wyceny.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| Cena | Ceny | `Ceny` |  | child: Towar→Towar |  |  | [Towary/Cena.md](Towary/Cena.md) |
| CenaGrupowa |  | `CenyGrupowe` |  | root |  |  | [Towary/CenaGrupowa.md](Towary/CenaGrupowa.md) |
| CenaIndywidualna |  | `CenyIndywidualne` |  | child: Towar→Towar |  |  | [Towary/CenaIndywidualna.md](Towary/CenaIndywidualna.md) |
| CenaProgowa | Ceny progowe | `CenyProgowe` |  | child: Towar→Towar |  |  | [Towary/CenaProgowa.md](Towary/CenaProgowa.md) |
| DefinicjaCeny | Definicje cen | `DefinicjeCen` | konfig | root |  | IRightsSource | [Towary/DefinicjaCeny.md](Towary/DefinicjaCeny.md) |
| DostawcaTowaru | Dostawcy towaru | `DostawcyTowaru` |  | child: Towar→Towar |  |  | [Towary/DostawcaTowaru.md](Towary/DostawcaTowaru.md) |
| ElemOpakowan | Elementy schematów opakowań/gratisów | `ElemyOpakowan` |  | child: Schemat→SchemOpakowan |  |  | [Towary/ElemOpakowan.md](Towary/ElemOpakowan.md) |
| ElementKompletu | Elementy kompletów | `ElemKompletow` |  | root |  |  | [Towary/ElementKompletu.md](Towary/ElementKompletu.md) |
| Jednostka | Jednostki | `Jednostki` | konfig | root |  |  | [Towary/Jednostka.md](Towary/Jednostka.md) |
| KodBDO |  | `KodyBDO` |  | root |  |  | [Towary/KodBDO.md](Towary/KodBDO.md) |
| KodCN |  | `KodyCN` |  | root |  |  | [Towary/KodCN.md](Towary/KodCN.md) |
| KodCPV |  | `KodyCPV` |  | root |  |  | [Towary/KodCPV.md](Towary/KodCPV.md) |
| KodSUP |  | `KodySUP` |  | root |  |  | [Towary/KodSUP.md](Towary/KodSUP.md) |
| KodTwrKontrahent | Kod towaru | `KodyTwrKontrah` |  |  |  |  | [Towary/KodTwrKontrahent.md](Towary/KodTwrKontrahent.md) |
| PrzecenaOkresowa |  | `PrzecenyOkres` |  | root |  |  | [Towary/PrzecenaOkresowa.md](Towary/PrzecenaOkresowa.md) |
| PrzecenaOkresowaTowaru |  | `PrzecenyOkresTwr` |  |  |  |  | [Towary/PrzecenaOkresowaTowaru.md](Towary/PrzecenaOkresowaTowaru.md) |
| PrzecenaOkresowaTowaruSchematGratisow |  | `PrzOkresTwrSchGr` |  |  |  |  | [Towary/PrzecenaOkresowaTowaruSchematGratisow.md](Towary/PrzecenaOkresowaTowaruSchematGratisow.md) |
| Przelicznik |  | `Przeliczniki` | konfig | child: Wyliczana→Jednostka |  |  | [Towary/Przelicznik.md](Towary/Przelicznik.md) |
| PrzelicznikTowaru |  | `PrzelTow` |  | child: Towar→Towar |  |  | [Towary/PrzelicznikTowaru.md](Towary/PrzelicznikTowaru.md) |
| SchemOpakowan | Schematy opakowań/gratisów | `SchemyOpakowan` |  | root |  |  | [Towary/SchemOpakowan.md](Towary/SchemOpakowan.md) |
| SchematTowar | Schematy opakowań/gratisów towarów | `SchematyTowary` |  | child: SchematOpakowan→SchemOpakowan |  |  | [Towary/SchematTowar.md](Towary/SchematTowar.md) |
| Towar |  | `Towary` |  | root |  | IElementSlownika, IElementSlownikZewnRel, IKodowany, IAdresyWWWHost | [Towary/Towar.md](Towary/Towar.md) |
| TowarEcommerce | Dane Ecommerce | `TowaryEcommerce` |  |  |  |  | [Towary/TowarEcommerce.md](Towary/TowarEcommerce.md) |
| TowarMagazynInfo |  | `TowarMagazyn` |  | child: Towar→Towar |  |  | [Towary/TowarMagazynInfo.md](Towary/TowarMagazynInfo.md) |
| TowarUlubiony | Ulubione towary | `TowaryUlubione` |  | child: Zapis→ITowaryUlubioneHost |  |  | [Towary/TowarUlubiony.md](Towary/TowarUlubiony.md) |
| WariantTowaru | Warianty towaru | `WariantyTowaru` |  |  |  |  | [Towary/WariantTowaru.md](Towary/WariantTowaru.md) |
| ZamiennikTowaru |  | `ZamiennikiTowaru` |  | child: Towar→Towar |  |  | [Towary/ZamiennikTowaru.md](Towary/ZamiennikTowaru.md) |

## Vehicles

- Opis: Moduł zarządzania flotą pojazdów. Zawiera kartotekę pojazdów, przeglądy, ubezpieczenia, tankowania, koszty eksploatacji oraz przypisania kierowców.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| DamageEvent | Szkody komunikacyjne | `DamageEvents` |  | root |  | IEmailElement | [Vehicles/DamageEvent.md](Vehicles/DamageEvent.md) |
| Fine | Mandaty | `Fines` |  | root |  |  | [Vehicles/Fine.md](Vehicles/Fine.md) |
| Insurance | Ubezpieczenia pojazdów | `Insurances` |  | root |  | IEmailElement | [Vehicles/Insurance.md](Vehicles/Insurance.md) |
| Reservation | Rezerwacje | `Reservations` |  | root |  | IDocumentHostCRM, IEmailElement | [Vehicles/Reservation.md](Vehicles/Reservation.md) |
| ReservationDef | Definicje rezerwacji pojazdu | `ReservationDefs` | konfig | root |  | IRightsSource | [Vehicles/ReservationDef.md](Vehicles/ReservationDef.md) |
| ReservationState | Stany rezerwacji | `ReservStates` | konfig | root |  |  | [Vehicles/ReservationState.md](Vehicles/ReservationState.md) |
| TechInspection | Bdania techniczne pojazdów | `TechInspections` |  | root |  |  | [Vehicles/TechInspection.md](Vehicles/TechInspection.md) |
| UsedVehicle | Pojazdy wykorzystane | `UsedVehicles` |  |  |  |  | [Vehicles/UsedVehicle.md](Vehicles/UsedVehicle.md) |
| VehicleAssetRel | Relacje pojazdów do środków trwałych | `VehicleAssetsRel` |  |  |  |  | [Vehicles/VehicleAssetRel.md](Vehicles/VehicleAssetRel.md) |
| VehicleDetails | Szczegóły Pojazdu | `VehiclesDetails` |  | root |  | IDocumentHostCRM | [Vehicles/VehicleDetails.md](Vehicles/VehicleDetails.md) |
| VehicleEvent | Zdarzenia pojazdów | `VehicleEvents` |  | root |  |  | [Vehicles/VehicleEvent.md](Vehicles/VehicleEvent.md) |
| VehicleHis | Historia pojazdów | `VehiclesHis` |  | root | historia |  | [Vehicles/VehicleHis.md](Vehicles/VehicleHis.md) |
| VehicleReading | Odczyty liczników pojazdów | `VehicleReadings` |  | root |  |  | [Vehicles/VehicleReading.md](Vehicles/VehicleReading.md) |
| VehicleService | Usługa pojazdu | `VehicleServices` |  |  |  |  | [Vehicles/VehicleService.md](Vehicles/VehicleService.md) |
| VehicleState | Stany pojazdów | `VehicleStates` | konfig | root |  |  | [Vehicles/VehicleState.md](Vehicles/VehicleState.md) |
| VehicleType | Typy pojazdów | `VehicleTypes` | konfig | root |  |  | [Vehicles/VehicleType.md](Vehicles/VehicleType.md) |

## Waluty

- Opis: Moduł obsługujący kursy walut i tabele kursowe. Zawiera definicje walut, tabele kursowe z NBP i ECB oraz mechanizmy przeliczania wartości walutowych.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| KursWaluty |  | `KursyWalut` | konfig | child: Tabela→TabelaKursowa |  |  | [Waluty/KursWaluty.md](Waluty/KursWaluty.md) |
| TabelaKursowa | Tabele kursowe | `TabeleKursowe` | konfig | root |  |  | [Waluty/TabelaKursowa.md](Waluty/TabelaKursowa.md) |
| Waluta |  | `Waluty` | konfig | root |  |  | [Waluty/Waluta.md](Waluty/Waluta.md) |

## WebAuthorization

- Opis: Moduł autoryzacji webowej. Zawiera definicje uprawnień, tokenów dostępu oraz mechanizmy uwierzytelniania użytkowników aplikacji webowych enova365.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| WebProfile |  | `WebProfiles` |  | root |  |  | [WebAuthorization/WebProfile.md](WebAuthorization/WebProfile.md) |
| WebReport |  | `WebReports` |  | root |  |  | [WebAuthorization/WebReport.md](WebAuthorization/WebReport.md) |
| WebReportRole | Role raportu | `WebReportRoles` |  | child: Report→WebReport |  |  | [WebAuthorization/WebReportRole.md](WebAuthorization/WebReportRole.md) |
| WebUser |  | `WebUsers` |  | root |  | INoticeRecipient, IMfaOperator | [WebAuthorization/WebUser.md](WebAuthorization/WebUser.md) |

## Windykacja

- Opis: Moduł obsługujący procesy windykacji należności. Zawiera definicje schematów windykacyjnych, akcje windykacyjne, monity oraz śledzenie statusów windykacji kontrahentów.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| DefinicjaSprawyWindykacyjnej | Definicje spraw windykacyjnych | `DefSprawWind` | konfig | root |  | IRightsSource | [Windykacja/DefinicjaSprawyWindykacyjnej.md](Windykacja/DefinicjaSprawyWindykacyjnej.md) |
| EtapDefinicjiWindykacji | Etapy definicji windykacji | `EtapyDefWind` | konfig | root |  |  | [Windykacja/EtapDefinicjiWindykacji.md](Windykacja/EtapDefinicjiWindykacji.md) |
| PozycjaSprawyWindykacyjnej | Pozycje spraw windykacyjnych | `PozSprawWind` |  | child: Sprawa→SprawaWindykacyjna |  |  | [Windykacja/PozycjaSprawyWindykacyjnej.md](Windykacja/PozycjaSprawyWindykacyjnej.md) |
| SprawaWindykacyjna | Sprawy windykacyjne | `SprawyWindyk` |  | root |  | IEmailElement, IDokumentCRM | [Windykacja/SprawaWindykacyjna.md](Windykacja/SprawaWindykacyjna.md) |
| StanWindykacji | Definicje etapu sprawy | `StanyWindykacji` | konfig | root |  |  | [Windykacja/StanWindykacji.md](Windykacja/StanWindykacji.md) |
| Windykacja |  | `Windykacje` |  | child: Dokument→IRozliczalny |  |  | [Windykacja/Windykacja.md](Windykacja/Windykacja.md) |

## Workflow

- Opis: Moduł automatyzacji procesów biznesowych (workflow). Zawiera definicje procesów, kroki, warunki, akcje automatyczne oraz mechanizmy sterowania obiegiem dokumentów.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| OGSchema | Schematy generatora obiektów workflow | `OGSchemas` | konfig | root |  | IOGSchema, IWorkflowItemDescriptionHost | [Workflow/OGSchema.md](Workflow/OGSchema.md) |
| PreviewPage | Okna podglądu | `PreviewPages` | konfig | root |  |  | [Workflow/PreviewPage.md](Workflow/PreviewPage.md) |
| WFDefItem | Wzorce definicji zadań | `WFDefItems` | konfig | root |  | IWFDefItem, IWfPlugInItemReferenceHost | [Workflow/WFDefItem.md](Workflow/WFDefItem.md) |
| WFDefinition | Definicja procesów | `WFDefs` | konfig | root |  | IRightsSource, IWFDefinition, ICodeFileHost, IWfPlugInReferenceHost, ISysNotificationReference, IWizardReferenceHost | [Workflow/WFDefinition.md](Workflow/WFDefinition.md) |
| WFItemDescription | Komentarze do elementów workflow | `WFItemDescs` | konfig | root |  |  | [Workflow/WFItemDescription.md](Workflow/WFItemDescription.md) |
| WFItemDescriptionRel | Komentarze do elementów workflow | `WFItemDescRels` | konfig | child: Description→IWFItemDescription |  |  | [Workflow/WFItemDescriptionRel.md](Workflow/WFItemDescriptionRel.md) |
| WFProcessRole | Role procesowe | `WFProcessRoles` | konfig | root |  | IWfPlugInItemReferenceHost, IWFRecipientHost | [Workflow/WFProcessRole.md](Workflow/WFProcessRole.md) |
| WFRecipient | Odbiorcy kroku workflow | `WFRecipients` | konfig | child: Host→IWFRecipientHost |  |  | [Workflow/WFRecipient.md](Workflow/WFRecipient.md) |
| WFTransition | Tranzycje | `WFTransitions` | konfig | root |  | IWFTransition, IWfPlugInItemReferenceHost | [Workflow/WFTransition.md](Workflow/WFTransition.md) |
| WFTransitionDefinition | Wzorce tranzycji | `WFTransitionDefs` | konfig | root |  | IWfPlugInItemReferenceHost | [Workflow/WFTransitionDefinition.md](Workflow/WFTransitionDefinition.md) |
| WFWorkflow | Procesy | `WFWorkflows` |  | root |  | IWFWorkflow, IWFFeatureDefs, IDokument | [Workflow/WFWorkflow.md](Workflow/WFWorkflow.md) |
| WfPlugIn | Wtyczki definicji procesów | `WfPlugIns` | konfig | root |  | IWfPlugInItemHost, ICodeFileHost | [Workflow/WfPlugIn.md](Workflow/WfPlugIn.md) |
| WfPlugInItem | Wtyczki elementów procesu | `WfPlugInItems` | konfig | root |  | IWfPlugInItemHost | [Workflow/WfPlugInItem.md](Workflow/WfPlugInItem.md) |
| WfPlugInItemReference | Powiązania wtyczek elementów procesów | `WfPlugInItemsRef` | konfig | child: Host→IWfPlugInItemReferenceHost |  | IWFRecipientHost | [Workflow/WfPlugInItemReference.md](Workflow/WfPlugInItemReference.md) |
| WfPlugInReference | Powiązania wtyczek definicji procesów | `WfPlugInsRef` | konfig | child: Definition→IWfPlugInReferenceHost |  |  | [Workflow/WfPlugInReference.md](Workflow/WfPlugInReference.md) |
| WfTaskFlowError | Błędy przeliczania zadań | `WfTaskFlowErrors` |  | child: Task→Task |  |  | [Workflow/WfTaskFlowError.md](Workflow/WfTaskFlowError.md) |
| WfTaskSource | Źródła zadań | `WfTaskSources` | konfig | child: TaskDefinition→TaskDefinition |  | IWfPlugInItemReferenceHost | [Workflow/WfTaskSource.md](Workflow/WfTaskSource.md) |

## Zadania

- Opis: Moduł zarządzania zadaniami i projektami. Zawiera definicje zadań, harmonogramy, przypisania, śledzenie czasu pracy (TimeTrack) oraz rozliczanie realizacji.

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Plik |
|---------|-------|--------|--------|--------|----------|------------|------|
| AvaliableCorrespondenceState | Dostepne stany korespondencji | `AvalCorreStates` | konfig |  |  |  | [Zadania/AvaliableCorrespondenceState.md](Zadania/AvaliableCorrespondenceState.md) |
| AvaliableProjectState | Dostepne stany projektów | `AvalProjStates` | konfig |  |  |  | [Zadania/AvaliableProjectState.md](Zadania/AvaliableProjectState.md) |
| AvaliableState | Dostepne stany | `AvaliableStates` | konfig |  |  |  | [Zadania/AvaliableState.md](Zadania/AvaliableState.md) |
| BudgetPeriod | Okresy budżetowe | `BudgetPeriods` | konfig | root |  |  | [Zadania/BudgetPeriod.md](Zadania/BudgetPeriod.md) |
| BudzetObrot | Plany i realizacje na pozycjach budżetu. | `BudzetObroty` |  | child: Pozycja→PozycjaBudzProj |  |  | [Zadania/BudzetObrot.md](Zadania/BudzetObrot.md) |
| BudzetProjektu | Budzety projektu | `BudzetyProjektu` |  | root |  |  | [Zadania/BudzetProjektu.md](Zadania/BudzetProjektu.md) |
| BudzetUprawnienie | Uprawnienia budżetów | `BudzetUprawn` |  |  |  |  | [Zadania/BudzetUprawnienie.md](Zadania/BudzetUprawnienie.md) |
| CtiAccount |  | `CtiAccounts` |  | root |  |  | [Zadania/CtiAccount.md](Zadania/CtiAccount.md) |
| CtiCallTransferLog |  | `CallTransferLogs` |  | root |  |  | [Zadania/CtiCallTransferLog.md](Zadania/CtiCallTransferLog.md) |
| DefBudget | Definicje budżetów | `DefBudgets` | konfig | root |  |  | [Zadania/DefBudget.md](Zadania/DefBudget.md) |
| DefBudgetAspect | Perspektywa realizacji | `DefBudgetAspects` | konfig | root |  |  | [Zadania/DefBudgetAspect.md](Zadania/DefBudgetAspect.md) |
| DefBudgetCategory | Kategoria budżetu | `DefBudgetCateg` | konfig | root |  |  | [Zadania/DefBudgetCategory.md](Zadania/DefBudgetCategory.md) |
| DefBudgetCategoryRelation | Relacje kategorii budżetu | `DefBudgetCatRel` | konfig | root |  |  | [Zadania/DefBudgetCategoryRelation.md](Zadania/DefBudgetCategoryRelation.md) |
| DefKampania | Definicje kampanii CRM | `DefKampanii` | konfig | root |  | IRightsSource | [Zadania/DefKampania.md](Zadania/DefKampania.md) |
| DefKoresp | Definicje korespondencji | `DefsKoresp` | konfig | root |  | IRightsSource, IWFDefinitionHost | [Zadania/DefKoresp.md](Zadania/DefKoresp.md) |
| DefPlanVersion | Definicje planów wersji | `DefPlanVersions` | konfig | root |  |  | [Zadania/DefPlanVersion.md](Zadania/DefPlanVersion.md) |
| DefPlanuSprzedazy | Definicje planów sprzedażowych | `DefPlanSprzed` | konfig | root |  | IRightsSource | [Zadania/DefPlanuSprzedazy.md](Zadania/DefPlanuSprzedazy.md) |
| DefProjektu | Definicje projektów CRM | `DefProjektow` | konfig | root |  | IRightsSource, ISysNotificationHost, IWizardReferenceHost, IWfPlugInReferenceHost, IWFDefinitionHost | [Zadania/DefProjektu.md](Zadania/DefProjektu.md) |
| DefRealizacjiPlanu | Definicje realizacji planów sprzedażowych | `DefRealPlanow` | konfig | root |  |  | [Zadania/DefRealizacjiPlanu.md](Zadania/DefRealizacjiPlanu.md) |
| DefZadanDbTupleDefinitionExt | Rozszerzenia definicji krotek dla tabeli Definicje Zadania | `DefZadanTDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition |  |  | [Zadania/DefZadanDbTupleDefinitionExt.md](Zadania/DefZadanDbTupleDefinitionExt.md) |
| DefZadania | Definicje zadań CRM | `DefZadan` | konfig | root |  | IRightsSource, IManagedRowDefinion, ISysNotificationHost, IWizardReferenceHost, IWfPlugInReferenceHost, IWFDefinitionHost, IPreviewPageHost | [Zadania/DefZadania.md](Zadania/DefZadania.md) |
| DefZadaniaRelacja | Relacje definicji zadań | `DefZadanRelacje` | konfig | root |  |  | [Zadania/DefZadaniaRelacja.md](Zadania/DefZadaniaRelacja.md) |
| DokumentCRM | Dokumenty powiązane | `DokumentyCRM` |  | child: Host→IDocumentHostCRM |  |  | [Zadania/DokumentCRM.md](Zadania/DokumentCRM.md) |
| EtapDefProjektu | Etapy definicji projektu CRM | `EtapyDefProjektu` | konfig | child: Definicja→DefProjektu |  |  | [Zadania/EtapDefProjektu.md](Zadania/EtapDefProjektu.md) |
| EtapProjektu | Etapy projektu CRM | `EtapyProjektu` |  | child: Projekt→Projekt |  |  | [Zadania/EtapProjektu.md](Zadania/EtapProjektu.md) |
| EtapWykonujacy | Operatorzy przypisani do etapów projektów | `EtapyWykonujacy` |  |  |  |  | [Zadania/EtapWykonujacy.md](Zadania/EtapWykonujacy.md) |
| EventDetail | Szczegóły zdarzeń | `EventDetails` |  | root |  |  | [Zadania/EventDetail.md](Zadania/EventDetail.md) |
| EventParticipant |  | `EventPartic` |  |  |  |  | [Zadania/EventParticipant.md](Zadania/EventParticipant.md) |
| GoogleCalendar | Kalendarze Google | `GoogleCalendars` |  | root |  |  | [Zadania/GoogleCalendar.md](Zadania/GoogleCalendar.md) |
| HistZadania | Historia zadań | `HistZadan` |  | child: Zadanie→Zadanie |  |  | [Zadania/HistZadania.md](Zadania/HistZadania.md) |
| Kampania | Kampanie CRM | `Kampanie` |  | root |  |  | [Zadania/Kampania.md](Zadania/Kampania.md) |
| KategoriaAkt | Kategoria aktywności | `KategorieAkt` | konfig | root |  |  | [Zadania/KategoriaAkt.md](Zadania/KategoriaAkt.md) |
| KontrahentRealizacji |  | `KntRealizacji` | konfig |  |  |  | [Zadania/KontrahentRealizacji.md](Zadania/KontrahentRealizacji.md) |
| Korespondencja | Tabela korespondencji | `Korespondencje` |  | root |  | IEmailElement | [Zadania/Korespondencja.md](Zadania/Korespondencja.md) |
| KwotaBudzProj | Kwoty budzetu projektu | `KwotyBudzProj` |  | root |  |  | [Zadania/KwotaBudzProj.md](Zadania/KwotaBudzProj.md) |
| ModelUrz | Model urządzeń | `ModeleUrz` |  | root |  |  | [Zadania/ModelUrz.md](Zadania/ModelUrz.md) |
| PlanSprzedazowy | Plany sprzedażowe | `PlanySprzedazowe` |  | root |  |  | [Zadania/PlanSprzedazowy.md](Zadania/PlanSprzedazowy.md) |
| PlanVariant | Warianty planów | `PlanVariants` | konfig | child: DefBudget→DefBudget |  |  | [Zadania/PlanVariant.md](Zadania/PlanVariant.md) |
| PlanVariantRel | Definicje wersji planów dla Wariantu planów | `PlanVariantsRel` | konfig | root |  |  | [Zadania/PlanVariantRel.md](Zadania/PlanVariantRel.md) |
| PlanowanyPrzeglad | Planowany przegląd urządzenia | `PlanPrzeglady` |  | root |  |  | [Zadania/PlanowanyPrzeglad.md](Zadania/PlanowanyPrzeglad.md) |
| PodmiotZadanie | Podmioty powiązane z zadaniami. | `PodmiotyZadania` |  | child: Zadanie→Zadanie |  |  | [Zadania/PodmiotZadanie.md](Zadania/PodmiotZadanie.md) |
| PozycjaBudzProj | Pozycje budżetu projektu | `PozycjeBudzProj` |  | root |  |  | [Zadania/PozycjaBudzProj.md](Zadania/PozycjaBudzProj.md) |
| PriorytetZadania | Priorytety zadań CRM | `PriorytetyZadan` | konfig | root |  |  | [Zadania/PriorytetZadania.md](Zadania/PriorytetZadania.md) |
| Projekt | Projekty CRM | `Projekty` |  | root |  | IBudzetowany, IEmailElement, IElementSlownika, IProjekt, IDocumentHostCRM | [Zadania/Projekt.md](Zadania/Projekt.md) |
| ProjektWykonujacy | Wykonujący projekty | `ProjektyWyk` |  |  |  |  | [Zadania/ProjektWykonujacy.md](Zadania/ProjektWykonujacy.md) |
| RecordEvent |  | `RecordEvents` |  | root |  |  | [Zadania/RecordEvent.md](Zadania/RecordEvent.md) |
| StanKoresp | Stany korespondencji | `StanyKoresp` | konfig | root |  |  | [Zadania/StanKoresp.md](Zadania/StanKoresp.md) |
| StanPlanu | Stany planów sprzedażowych | `StanyPlanu` | konfig | root |  |  | [Zadania/StanPlanu.md](Zadania/StanPlanu.md) |
| StanProjektu | Stany realizacji projektu CRM | `StanyProjektu` | konfig | root |  |  | [Zadania/StanProjektu.md](Zadania/StanProjektu.md) |
| StanZadania | Stany realizacji zadań CRM | `StanyZadania` | konfig | root |  |  | [Zadania/StanZadania.md](Zadania/StanZadania.md) |
| TowarRealizacji |  | `TowaryRealizacji` | konfig |  |  |  | [Zadania/TowarRealizacji.md](Zadania/TowarRealizacji.md) |
| TypUrzadzenia | Typy urządzeń | `TypyUrzadzen` | konfig | root |  | IRightsSource | [Zadania/TypUrzadzenia.md](Zadania/TypUrzadzenia.md) |
| TypZadania | Typy zadan | `TypyZadan` | konfig | child: Definicja→DefZadania |  |  | [Zadania/TypZadania.md](Zadania/TypZadania.md) |
| Urzadzenie | Urządzenia | `Urzadzenia` |  | root |  | IKodowany, IZasobCRM, IElementSlownika, IDocumentHostCRM | [Zadania/Urzadzenie.md](Zadania/Urzadzenie.md) |
| UrzadzenieUzyte | Urządzenia wykorzystane | `UrzadzeniaUzyte` |  |  |  |  | [Zadania/UrzadzenieUzyte.md](Zadania/UrzadzenieUzyte.md) |
| WersjaPlanu | Wersje planu dla budżetu projektu | `WersjePlanu` |  | root |  | IDokument | [Zadania/WersjaPlanu.md](Zadania/WersjaPlanu.md) |
| ZadaniaDbTupleDefinitionExt | Rozszerzenia definicji krotek dla tabeli Zadania | `ZadaniaTDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition |  |  | [Zadania/ZadaniaDbTupleDefinitionExt.md](Zadania/ZadaniaDbTupleDefinitionExt.md) |
| Zadanie | Zadania i zdarzenia CRM | `Zadania` |  | root |  | ITimeTrack, IElementSlownika, IEmailElement, IDocumentHostCRM, IManagedRowInfoHost, IToDoItemHost | [Zadania/Zadanie.md](Zadania/Zadanie.md) |
| ZadanieDnia |  | `ZadaniaDnia` |  | root |  |  | [Zadania/ZadanieDnia.md](Zadania/ZadanieDnia.md) |
| ZasobCRM | Zasoby powiązane z zadaniem | `ZasobyCRM` |  | child: Zadanie→Zadanie |  |  | [Zadania/ZasobCRM.md](Zadania/ZasobCRM.md) |
| Zespol | Role które są widoczne w aktywnościach OPZ jako zespoły | `Zespoly` | konfig | root |  |  | [Zadania/Zespol.md](Zadania/Zespol.md) |

