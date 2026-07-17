# Indeks pól tabel biznesowych (dane wygenerowane z DLL)

Pliki w tym katalogu zostały wygenerowane wsadowo przez
`scripts/export-props-all.csx` (ta sama logika co `scan-props.csx`).
Każdy plik `<Moduł>/<RowType>.md` zawiera pełną tabelę pól jednej tabeli.
Instrukcja odczytu i regeneracji: [../references/scan-props.md](../../references/scan-props.md).

- Modułów z tabelami: 37
- Tabel (plików): 1188

Aby znaleźć tabelę: wyszukaj `RowType` w tabeli poniżej i otwórz plik z kolumny `Plik`.

## BI

- Opis: Moduł Business Intelligence. Zawiera definicje kostek analitycznych, miar, wymiarów, raportów oraz mechanizmy agregacji i wizualizacji danych biznesowych.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| AnalysisArea | `AnalysisAreas` | konfig | root | [BI/AnalysisArea.md](BI/AnalysisArea.md) |
| AnalysisAreaAppearance | `AnalysisAreaApps` | konfig | child: AreaDefinition→AnalysisAreaDefinition | [BI/AnalysisAreaAppearance.md](BI/AnalysisAreaAppearance.md) |
| AnalysisAreaDefinition | `AnalysisAreaDefs` | konfig | root | [BI/AnalysisAreaDefinition.md](BI/AnalysisAreaDefinition.md) |
| AppearanceItemDefinition | `AppItemDefs` | konfig | child: Definition→AppearanceSetDefinition | [BI/AppearanceItemDefinition.md](BI/AppearanceItemDefinition.md) |
| AppearanceSetDefinition | `AppSetDefs` | konfig | root | [BI/AppearanceSetDefinition.md](BI/AppearanceSetDefinition.md) |
| BICode | `BICodes` | konfig | root | [BI/BICode.md](BI/BICode.md) |
| ChartParam | `ChartParams` | konfig | root | [BI/ChartParam.md](BI/ChartParam.md) |
| ColumnDefinition | `ColumnDefs` | konfig | root | [BI/ColumnDefinition.md](BI/ColumnDefinition.md) |
| DashboardItemDefinition | `DashBrdItemDefs` | konfig | root | [BI/DashboardItemDefinition.md](BI/DashboardItemDefinition.md) |
| DashboardItemField | `DashBrdItemFlds` | konfig | root | [BI/DashboardItemField.md](BI/DashboardItemField.md) |
| DashboardItemFieldAppearance | `DashBrdItemFApps` | konfig | child: DashboardItem→DashboardItemDefinition | [BI/DashboardItemFieldAppearance.md](BI/DashboardItemFieldAppearance.md) |
| DashboardItemLocation | `DashItemLocs` | konfig | root | [BI/DashboardItemLocation.md](BI/DashboardItemLocation.md) |
| DashboardItemParam | `DashItemParams` | konfig | child: ItemDefinition→DashboardItemDefinition | [BI/DashboardItemParam.md](BI/DashboardItemParam.md) |
| DashboardViewLocation | `DashbrdViewLocs` | konfig | root | [BI/DashboardViewLocation.md](BI/DashboardViewLocation.md) |
| DashboardViewParam | `DashViewParams` | konfig |  | [BI/DashboardViewParam.md](BI/DashboardViewParam.md) |
| DashboardViewParamSet | `DashParamSets` | konfig |  | [BI/DashboardViewParamSet.md](BI/DashboardViewParamSet.md) |
| DataModel | `DataModels` | konfig | root | [BI/DataModel.md](BI/DataModel.md) |
| DataModelSerializationDefinition | `SerialModelDefs` | konfig | root | [BI/DataModelSerializationDefinition.md](BI/DataModelSerializationDefinition.md) |
| DataSetDefinition | `DataSetDefs` | konfig | root | [BI/DataSetDefinition.md](BI/DataSetDefinition.md) |
| DataSetGeneratorDefinition | `DataSetGenDefs` | konfig | root | [BI/DataSetGeneratorDefinition.md](BI/DataSetGeneratorDefinition.md) |
| DataSource | `DataSources` | konfig | root | [BI/DataSource.md](BI/DataSource.md) |
| DataSourceDatabase | `DataSourceDbs` | konfig | root | [BI/DataSourceDatabase.md](BI/DataSourceDatabase.md) |
| DataSpanItemAppearance | `DataSpanItemApps` | konfig | child: DashboardItem→DashboardItemDefinition | [BI/DataSpanItemAppearance.md](BI/DataSpanItemAppearance.md) |
| DataSpanItemDefinition | `DataSpanItemDefs` | konfig | child: DataSpanSet→DataSpanSetDefinition | [BI/DataSpanItemDefinition.md](BI/DataSpanItemDefinition.md) |
| DataSpanSetDefinition | `DataSpanSetDefs` | konfig | root | [BI/DataSpanSetDefinition.md](BI/DataSpanSetDefinition.md) |
| FieldDefinition | `FieldDefs` | konfig | root | [BI/FieldDefinition.md](BI/FieldDefinition.md) |
| ModelGroupBy | `ModelGroupBys` | konfig | root | [BI/ModelGroupBy.md](BI/ModelGroupBy.md) |
| ModelJoin | `ModelJoins` | konfig | root | [BI/ModelJoin.md](BI/ModelJoin.md) |
| ModelOrderBy | `ModelOrderBys` | konfig | root | [BI/ModelOrderBy.md](BI/ModelOrderBy.md) |
| ModelTable | `ModelTables` | konfig | root | [BI/ModelTable.md](BI/ModelTable.md) |
| ReportParam | `ReportParams` | konfig | root | [BI/ReportParam.md](BI/ReportParam.md) |
| SerializationDefinition | `SerializeDefs` | konfig | root | [BI/SerializationDefinition.md](BI/SerializationDefinition.md) |
| SerializationParam | `SerializeParams` | konfig | root | [BI/SerializationParam.md](BI/SerializationParam.md) |
| SerializationViewDefinition | `SerialViewDefs` | konfig | root | [BI/SerializationViewDefinition.md](BI/SerializationViewDefinition.md) |
| SerializationViewFilterSet | `SerialFilterSets` | konfig | root | [BI/SerializationViewFilterSet.md](BI/SerializationViewFilterSet.md) |
| SerializationViewRange | `SerialViewRanges` | konfig | root | [BI/SerializationViewRange.md](BI/SerializationViewRange.md) |
| TimeSpanDefinition | `TimeSpanDefs` | konfig | root | [BI/TimeSpanDefinition.md](BI/TimeSpanDefinition.md) |
| TimeSpanItem | `TimeSpanItems` | konfig | root | [BI/TimeSpanItem.md](BI/TimeSpanItem.md) |
| TimeSpanSet | `TimeSpanSets` | konfig | root | [BI/TimeSpanSet.md](BI/TimeSpanSet.md) |

## Business

- Opis: Moduł systemowy zawierający podstawowe definicje typów danych, struktur tabel oraz obiektów bazodanowych platformy enova365. Definiuje typy proste (string, int, decimal, date itp.), konfigurację systemu, uprawnienia, powiadomienia i mechanizmy wersjonowania.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| AppToken | `AppTokens` | konfig | root | [Business/AppToken.md](Business/AppToken.md) |
| AppTokenItem | `AppTokenItems` | konfig | root | [Business/AppTokenItem.md](Business/AppTokenItem.md) |
| AppTokenRight | `AppTokenRights` | konfig | root | [Business/AppTokenRight.md](Business/AppTokenRight.md) |
| Attachment | `Attachments` |  |  | [Business/Attachment.md](Business/Attachment.md) |
| AttachmentFile | `AttachmentFiles` |  |  | [Business/AttachmentFile.md](Business/AttachmentFile.md) |
| CatRolRelation | `CatRolRelations` |  |  | [Business/CatRolRelation.md](Business/CatRolRelation.md) |
| CfgAttribute | `CfgAttributes` | konfig | child: Node→CfgNode | [Business/CfgAttribute.md](Business/CfgAttribute.md) |
| CfgNode | `CfgNodes` | konfig | root | [Business/CfgNode.md](Business/CfgNode.md) |
| ChangeInfo | `ChangeInfos` |  |  | [Business/ChangeInfo.md](Business/ChangeInfo.md) |
| CredentialKey | `CredentialKeys` |  | root | [Business/CredentialKey.md](Business/CredentialKey.md) |
| DBGroup | `DBGroups` | konfig | root | [Business/DBGroup.md](Business/DBGroup.md) |
| DBGroupItem | `DBGroupItems` | konfig |  | [Business/DBGroupItem.md](Business/DBGroupItem.md) |
| DBItem | `DBItems` | konfig | root | [Business/DBItem.md](Business/DBItem.md) |
| DashboardArea | `DashbrdAreas` | konfig | root | [Business/DashboardArea.md](Business/DashboardArea.md) |
| DashboardView | `DashbrdViews` | konfig | root | [Business/DashboardView.md](Business/DashboardView.md) |
| DashboardViewAdjustment | `DashbrdViewAdjs` | konfig | child: Tile→DashboardViewTile | [Business/DashboardViewAdjustment.md](Business/DashboardViewAdjustment.md) |
| DashboardViewTile | `DashbrdViewTiles` | konfig | child: Dashboard→DashboardView | [Business/DashboardViewTile.md](Business/DashboardViewTile.md) |
| DictionaryItem | `Dictionary` |  | root | [Business/DictionaryItem.md](Business/DictionaryItem.md) |
| Entitle | `Entitles` | konfig | root | [Business/Entitle.md](Business/Entitle.md) |
| EntitleRef | `EntitleRefs` |  | child: Entitle→Entitle | [Business/EntitleRef.md](Business/EntitleRef.md) |
| EntitleRole | `EntitleRoles` |  | child: Entitle→Entitle | [Business/EntitleRole.md](Business/EntitleRole.md) |
| ExternalDatabase | `ExtDatabases` | konfig | root | [Business/ExternalDatabase.md](Business/ExternalDatabase.md) |
| FeatureDefinition | `FeatureDefs` | konfig | root | [Business/FeatureDefinition.md](Business/FeatureDefinition.md) |
| FeatureSetDefinition | `FSDefs` | konfig | root | [Business/FeatureSetDefinition.md](Business/FeatureSetDefinition.md) |
| FeatureSetDefinitionItem | `FSDefItems` | konfig | root | [Business/FeatureSetDefinitionItem.md](Business/FeatureSetDefinitionItem.md) |
| FeatureSetRelation | `FSRels` |  | child: FeatureSetDefinition→FeatureSetDefinition | [Business/FeatureSetRelation.md](Business/FeatureSetRelation.md) |
| FeatureTransferDefinition | `FeatureTrDefs` | konfig | root | [Business/FeatureTransferDefinition.md](Business/FeatureTransferDefinition.md) |
| GuidMap | `GuidMaps` |  |  | [Business/GuidMap.md](Business/GuidMap.md) |
| HistAktualizacja | `HistAktualizacje` | konfig | root | [Business/HistAktualizacja.md](Business/HistAktualizacja.md) |
| LockInfo | `LockInfos` |  |  | [Business/LockInfo.md](Business/LockInfo.md) |
| NotifRead | `NotifsRead` |  |  | [Business/NotifRead.md](Business/NotifRead.md) |
| NotificationCategory | `NotifiCategories` | konfig | root | [Business/NotificationCategory.md](Business/NotificationCategory.md) |
| Operator | `Operators` | konfig | root | [Business/Operator.md](Business/Operator.md) |
| OperatorEntitle | `OperatorEntitles` | konfig | child: Operator→Operator | [Business/OperatorEntitle.md](Business/OperatorEntitle.md) |
| OperatorEx | `OperatorsEx` |  | child: Operator→Operator | [Business/OperatorEx.md](Business/OperatorEx.md) |
| PivotView | `PivotViews` | konfig | root | [Business/PivotView.md](Business/PivotView.md) |
| PivotViewDefaultStyle | `PivotDftStyles` | konfig | child: PivotView→PivotView | [Business/PivotViewDefaultStyle.md](Business/PivotViewDefaultStyle.md) |
| PivotViewStyle | `PivotViewStyles` | konfig | root | [Business/PivotViewStyle.md](Business/PivotViewStyle.md) |
| RecordPermission | `RecordPerms` |  |  | [Business/RecordPermission.md](Business/RecordPermission.md) |
| RemoteFile | `RemoteFiles` |  |  | [Business/RemoteFile.md](Business/RemoteFile.md) |
| Right | `Rights` |  | child: Entitle→IEntitle | [Business/Right.md](Business/Right.md) |
| RoleCategory | `RolesCategory` | konfig | root | [Business/RoleCategory.md](Business/RoleCategory.md) |
| RozlDBWlascPIT | `RozlDBWlascPITy` |  |  | [Business/RozlDBWlascPIT.md](Business/RozlDBWlascPIT.md) |
| RozlDBWlascRycz | `RozlDBWlascRyczy` |  |  | [Business/RozlDBWlascRycz.md](Business/RozlDBWlascRycz.md) |
| RozlDBWlascZUS | `RozlDBWlascZUSy` |  |  | [Business/RozlDBWlascZUS.md](Business/RozlDBWlascZUS.md) |
| RozliczenieDB | `RozliczeniaDB` |  |  | [Business/RozliczenieDB.md](Business/RozliczenieDB.md) |
| RuntimeEnum | `RuntimeEnums` |  | child: Definition→RuntimeFieldDefinition | [Business/RuntimeEnum.md](Business/RuntimeEnum.md) |
| RuntimeFieldDefinition | `RuntimeFieldDefs` | konfig | root | [Business/RuntimeFieldDefinition.md](Business/RuntimeFieldDefinition.md) |
| RuntimeProject | `RuntimeProjects` | konfig | root | [Business/RuntimeProject.md](Business/RuntimeProject.md) |
| RuntimeProjectReference | `RuntimeProjRef` | konfig | child: RuntimeProject→RuntimeProject | [Business/RuntimeProjectReference.md](Business/RuntimeProjectReference.md) |
| RuntimeRowRelation | `RuntimeRowRels` |  |  | [Business/RuntimeRowRelation.md](Business/RuntimeRowRelation.md) |
| RuntimeSolution | `RuntimeSolutions` | konfig | root | [Business/RuntimeSolution.md](Business/RuntimeSolution.md) |
| SingleUseToken | `SingleUseTokens` |  | root | [Business/SingleUseToken.md](Business/SingleUseToken.md) |
| SysNotification | `SysNotifications` | konfig | root | [Business/SysNotification.md](Business/SysNotification.md) |
| SysNotificationRef | `SysNotRefs` |  | child: Notification→SysNotification | [Business/SysNotificationRef.md](Business/SysNotificationRef.md) |
| SystemFile | `SystemFiles` | konfig | root | [Business/SystemFile.md](Business/SystemFile.md) |
| SystemInfo | `SystemInfos` |  |  | [Business/SystemInfo.md](Business/SystemInfo.md) |
| SystemRole | `SystemRoles` | konfig | root | [Business/SystemRole.md](Business/SystemRole.md) |
| SystemRoleRef | `SystemRoleRefs` |  | child: Role→SystemRole | [Business/SystemRoleRef.md](Business/SystemRoleRef.md) |
| Task | `Tasks` |  | root | [Business/Task.md](Business/Task.md) |
| TaskDefinition | `TaskDefs` | konfig | root | [Business/TaskDefinition.md](Business/TaskDefinition.md) |
| TaskHistoryRel | `TaskHistoryRels` |  |  | [Business/TaskHistoryRel.md](Business/TaskHistoryRel.md) |
| TaskLinkedObj | `TaskLinkedObjs` |  |  | [Business/TaskLinkedObj.md](Business/TaskLinkedObj.md) |
| TaskTrigger | `TaskTriggers` | konfig | child: TaskDefinition→TaskDefinition | [Business/TaskTrigger.md](Business/TaskTrigger.md) |
| UserGroup | `UserGroups` | konfig | root | [Business/UserGroup.md](Business/UserGroup.md) |
| UserGroupMember | `UserGroupMembers` | konfig | child: UserGroup→UserGroup | [Business/UserGroupMember.md](Business/UserGroupMember.md) |
| WizardDefinition | `WizardDefs` | konfig | root | [Business/WizardDefinition.md](Business/WizardDefinition.md) |
| WizardReference | `WizardReferences` | konfig | child: Host→IWizardReferenceHost | [Business/WizardReference.md](Business/WizardReference.md) |
| WizardStepDefinition | `WizardStepDefs` | konfig | root | [Business/WizardStepDefinition.md](Business/WizardStepDefinition.md) |

## CRM

- Opis: Moduł zarządzania relacjami z klientami (CRM). Obsługuje ewidencję kontrahentów, osób kontaktowych, banków, urzędów oraz lokalizacji wraz z ich danymi adresowymi i kontaktowymi. Zawiera mechanizmy transakcji i leadów sprzedażowych, zdarzenia CRM, obsługę poczty elektronicznej, szablony korespondencji oraz zarządzanie opiekunami i kategoriami kontrahentów.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| AuthAzureConfig | `AuthAzureConfigs` | konfig | root | [CRM/AuthAzureConfig.md](CRM/AuthAzureConfig.md) |
| AuthProvider | `AuthProviders` | konfig | root | [CRM/AuthProvider.md](CRM/AuthProvider.md) |
| AuthToken | `AuthTokens` |  |  | [CRM/AuthToken.md](CRM/AuthToken.md) |
| AvaliableLeadState | `AvalLeadStates` | konfig |  | [CRM/AvaliableLeadState.md](CRM/AvaliableLeadState.md) |
| AvaliableTransactionState | `AvalTranStates` | konfig |  | [CRM/AvaliableTransactionState.md](CRM/AvaliableTransactionState.md) |
| Bank | `Banki` |  | root | [CRM/Bank.md](CRM/Bank.md) |
| Branza | `Branze` | konfig | root | [CRM/Branza.md](CRM/Branza.md) |
| BranzaKth | `BranzeKth` |  | child: Kontrahent→Kontrahent | [CRM/BranzaKth.md](CRM/BranzaKth.md) |
| DefKategKth | `DefKategoriiKth` | konfig | root | [CRM/DefKategKth.md](CRM/DefKategKth.md) |
| DefLeada | `DefLeadow` | konfig | root | [CRM/DefLeada.md](CRM/DefLeada.md) |
| DefTransakcja | `DefTransakcji` | konfig | root | [CRM/DefTransakcja.md](CRM/DefTransakcja.md) |
| DokumentZdarzenia | `DokumentyZdarzen` |  | root | [CRM/DokumentZdarzenia.md](CRM/DokumentZdarzenia.md) |
| DzialalnoscKod | `DzialalnoscKody` |  |  | [CRM/DzialalnoscKod.md](CRM/DzialalnoscKod.md) |
| ElementEmail | `ElementyEmail` |  |  | [CRM/ElementEmail.md](CRM/ElementEmail.md) |
| EmailConfirmation | `EmailConfs` |  |  | [CRM/EmailConfirmation.md](CRM/EmailConfirmation.md) |
| FolderPocztowy | `FolderyPocztowe` |  |  | [CRM/FolderPocztowy.md](CRM/FolderPocztowy.md) |
| FormaPrawna | `FormyPrawne` | konfig | root | [CRM/FormaPrawna.md](CRM/FormaPrawna.md) |
| InstytucjaFinansowaPPK | `InstFinansowePPK` |  | root | [CRM/InstytucjaFinansowaPPK.md](CRM/InstytucjaFinansowaPPK.md) |
| KategoriaKth | `KategorieKth` |  | child: Kontrahent→Kontrahent | [CRM/KategoriaKth.md](CRM/KategoriaKth.md) |
| KontaktOsoba | `KontaktyOsoby` |  | root | [CRM/KontaktOsoba.md](CRM/KontaktOsoba.md) |
| KontaktWazneDaty | `KntktyWazneDaty` |  | root | [CRM/KontaktWazneDaty.md](CRM/KontaktWazneDaty.md) |
| KontoPocztowe | `KontaPocztowe` |  | root | [CRM/KontoPocztowe.md](CRM/KontoPocztowe.md) |
| Kontrahent | `Kontrahenci` |  | root | [CRM/Kontrahent.md](CRM/Kontrahent.md) |
| KontrahentOddzialInfo | `KontrahOddzial` |  |  | [CRM/KontrahentOddzialInfo.md](CRM/KontrahentOddzialInfo.md) |
| KthDzialalnKod | `KthDzialalnKody` |  |  | [CRM/KthDzialalnKod.md](CRM/KthDzialalnKod.md) |
| Lead | `Leady` |  | root | [CRM/Lead.md](CRM/Lead.md) |
| Lokalizacja | `Lokalizacje` |  | root | [CRM/Lokalizacja.md](CRM/Lokalizacja.md) |
| OddziałZUS | `OddzialyZUS` |  | root | [CRM/OddziałZUS.md](CRM/OddziałZUS.md) |
| OperatorSprzedazy | `OperatSprzedazy` |  |  | [CRM/OperatorSprzedazy.md](CRM/OperatorSprzedazy.md) |
| Opiekun | `Opiekunowie` |  | root | [CRM/Opiekun.md](CRM/Opiekun.md) |
| OsobaKontrahent | `OsobyKontrahenci` |  | root | [CRM/OsobaKontrahent.md](CRM/OsobaKontrahent.md) |
| PodmiotPowiazany | `PodmiotyPow` |  |  | [CRM/PodmiotPowiazany.md](CRM/PodmiotPowiazany.md) |
| PodmiotTransakcja | `PodmiotyTran` |  | child: Transakcja→Transakcja | [CRM/PodmiotTransakcja.md](CRM/PodmiotTransakcja.md) |
| PodpisOperatora | `PodpisyOper` | konfig | root | [CRM/PodpisOperatora.md](CRM/PodpisOperatora.md) |
| PozycjaZdarzenia | `PozycjeZdarzen` |  | child: Dokument→DokumentZdarzenia | [CRM/PozycjaZdarzenia.md](CRM/PozycjaZdarzenia.md) |
| PriorytetLeada | `PriorytetyLeadow` | konfig | root | [CRM/PriorytetLeada.md](CRM/PriorytetLeada.md) |
| PriorytetTransakcja | `PriorytetyTran` | konfig | root | [CRM/PriorytetTransakcja.md](CRM/PriorytetTransakcja.md) |
| Region | `Regiony` | konfig | root | [CRM/Region.md](CRM/Region.md) |
| RegionObszar | `RegionObszary` | konfig | root | [CRM/RegionObszar.md](CRM/RegionObszar.md) |
| RelacjaPodmiotu | `RelacjePodmiotow` |  |  | [CRM/RelacjaPodmiotu.md](CRM/RelacjaPodmiotu.md) |
| RodzajLokalizacji | `RodzajeLok` |  |  | [CRM/RodzajLokalizacji.md](CRM/RodzajLokalizacji.md) |
| RolaOpiekun | `RoleOpiekun` | konfig | root | [CRM/RolaOpiekun.md](CRM/RolaOpiekun.md) |
| StanLeada | `StanyLeada` | konfig | root | [CRM/StanLeada.md](CRM/StanLeada.md) |
| StanTransakcji | `StanyTransakcji` | konfig | root | [CRM/StanTransakcji.md](CRM/StanTransakcji.md) |
| StatusVAT | `StatusyVAT` |  |  | [CRM/StatusVAT.md](CRM/StatusVAT.md) |
| SzablonEmail | `SzablonyEmail` |  | root | [CRM/SzablonEmail.md](CRM/SzablonEmail.md) |
| SzablonSms | `SzablonySms` | konfig | root | [CRM/SzablonSms.md](CRM/SzablonSms.md) |
| TemperaturaLeada | `TempLeadow` | konfig | root | [CRM/TemperaturaLeada.md](CRM/TemperaturaLeada.md) |
| TemperaturaTransakcji | `TempTran` | konfig | root | [CRM/TemperaturaTransakcji.md](CRM/TemperaturaTransakcji.md) |
| Transakcja | `Transakcje` |  | root | [CRM/Transakcja.md](CRM/Transakcja.md) |
| UrzadCelny | `UrzedyCelne` |  | root | [CRM/UrzadCelny.md](CRM/UrzadCelny.md) |
| UrzadSkarbowy | `UrzedySkarbowe` |  | root | [CRM/UrzadSkarbowy.md](CRM/UrzadSkarbowy.md) |
| WiadomoscEmail | `WiadomosciEmail` |  | root | [CRM/WiadomoscEmail.md](CRM/WiadomoscEmail.md) |
| WizytowkaFirmy | `WizytowkiFirm` |  | root | [CRM/WizytowkaFirmy.md](CRM/WizytowkaFirmy.md) |
| ZUS | `ZUSY` |  | root | [CRM/ZUS.md](CRM/ZUS.md) |
| ZrodloKontaktu | `ZrodlaKontaktu` | konfig | root | [CRM/ZrodloKontaktu.md](CRM/ZrodloKontaktu.md) |

## Core

- Opis: Moduł podstawowy platformy enova365 zawierający wspólne obiekty biznesowe. Obejmuje kontrahentów, adresy, lokalizacje, banki, słowniki, szablony, definicje dokumentów, powiadomienia, załączniki oraz mechanizmy konfiguracji systemu.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| AdditionRowDesc | `AdditionRowDescs` |  | root | [Core/AdditionRowDesc.md](Core/AdditionRowDesc.md) |
| AdresExt | `Adresy` |  | child: Host→IAdresHost | [Core/AdresExt.md](Core/AdresExt.md) |
| AdresRozszerzonyExt | `AdresyRozszerzon` |  | child: Host→AdresExt | [Core/AdresRozszerzonyExt.md](Core/AdresRozszerzonyExt.md) |
| AdresWWW | `AdresyWWW` |  | child: Zapis→IAdresyWWWHost | [Core/AdresWWW.md](Core/AdresWWW.md) |
| Aktualnosc | `Aktualnosci` |  | root | [Core/Aktualnosc.md](Core/Aktualnosc.md) |
| CRUApiKey | `CRUApiKeys` |  | root | [Core/CRUApiKey.md](Core/CRUApiKey.md) |
| CRUContract | `CRUContracts` |  | root | [Core/CRUContract.md](Core/CRUContract.md) |
| CelKontaktu | `CeleKontaktow` |  |  | [Core/CelKontaktu.md](Core/CelKontaktu.md) |
| CentrumKosztow | `CentraKosztow` | konfig | root | [Core/CentrumKosztow.md](Core/CentrumKosztow.md) |
| CodeFile | `CodeFiles` | konfig | root | [Core/CodeFile.md](Core/CodeFile.md) |
| Comment | `Comments` |  | root | [Core/Comment.md](Core/Comment.md) |
| DaneKontaktowe | `DaneKnt` |  | child: Host→IDaneKontaktoweHost | [Core/DaneKontaktowe.md](Core/DaneKontaktowe.md) |
| DaneKontrahenta | `DaneKontrahentow` |  | child: Host→IDaneKontrahentaHost | [Core/DaneKontrahenta.md](Core/DaneKontrahenta.md) |
| DaneZewn | `DaneZ` |  |  | [Core/DaneZewn.md](Core/DaneZewn.md) |
| DbTuple | `Tuples` |  | root | [Core/DbTuple.md](Core/DbTuple.md) |
| DbTupleDefinition | `TuplesDefs` | konfig | root | [Core/DbTupleDefinition.md](Core/DbTupleDefinition.md) |
| DbTupleRel | `TuplesRelations` |  | child: DbTuple→DbTuple | [Core/DbTupleRel.md](Core/DbTupleRel.md) |
| DefDiscussion | `DefDiscussions` | konfig | root | [Core/DefDiscussion.md](Core/DefDiscussion.md) |
| DefTeczki | `DefsTeczek` | konfig | root | [Core/DefTeczki.md](Core/DefTeczki.md) |
| DefXmlElem | `DefsXmlElem` | konfig | root | [Core/DefXmlElem.md](Core/DefXmlElem.md) |
| DefXmlFiltr | `DefXmlFiltry` |  |  | [Core/DefXmlFiltr.md](Core/DefXmlFiltr.md) |
| DefXmlNag | `DefsXmlNag` | konfig | root | [Core/DefXmlNag.md](Core/DefXmlNag.md) |
| DefinicjaDokumentu | `DefDokumentow` | konfig | root | [Core/DefinicjaDokumentu.md](Core/DefinicjaDokumentu.md) |
| DefinicjaDokumentuOA | `DefDokumentowOA` | konfig | root | [Core/DefinicjaDokumentuOA.md](Core/DefinicjaDokumentuOA.md) |
| DefinicjaElementuStrukturyOrganizacyjnej | `DefElStrukturOrg` | konfig | root | [Core/DefinicjaElementuStrukturyOrganizacyjnej.md](Core/DefinicjaElementuStrukturyOrganizacyjnej.md) |
| DefinicjaPodzielnikaKosztow | `DefPodzKosztow` | konfig | root | [Core/DefinicjaPodzielnikaKosztow.md](Core/DefinicjaPodzielnikaKosztow.md) |
| DefinicjaPoświadczeniaOdbioru | `DefPoswOdbioru` | konfig | root | [Core/DefinicjaPoświadczeniaOdbioru.md](Core/DefinicjaPoświadczeniaOdbioru.md) |
| DefinicjaStawkiAkcyzy | `DefStawekAkcyzy` | konfig | root | [Core/DefinicjaStawkiAkcyzy.md](Core/DefinicjaStawkiAkcyzy.md) |
| DefinicjaStawkiVat | `DefStawekVat` | konfig | root | [Core/DefinicjaStawkiVat.md](Core/DefinicjaStawkiVat.md) |
| Discussion | `Discussions` |  | root | [Core/Discussion.md](Core/Discussion.md) |
| DiscussionPlugIn | `DiscPlugIns` | konfig | root | [Core/DiscussionPlugIn.md](Core/DiscussionPlugIn.md) |
| DiscussionPlugInRef | `DiscPlugInRefs` |  | child: Definition→IDiscussionPlugInHost | [Core/DiscussionPlugInRef.md](Core/DiscussionPlugInRef.md) |
| DiscussionPlugInsSet | `DiscPlugInsSets` | konfig | root | [Core/DiscussionPlugInsSet.md](Core/DiscussionPlugInsSet.md) |
| DiscussionReaction | `DiscusReactions` |  |  | [Core/DiscussionReaction.md](Core/DiscussionReaction.md) |
| DiscussionReadStatus | `DisReadStatuses` |  |  | [Core/DiscussionReadStatus.md](Core/DiscussionReadStatus.md) |
| DiscussionRel | `DiscussionRels` |  | root | [Core/DiscussionRel.md](Core/DiscussionRel.md) |
| DiscussionTopic | `DiscussionTopics` |  | root | [Core/DiscussionTopic.md](Core/DiscussionTopic.md) |
| DiscussionUpdate | `DiscussUpdates` |  | root | [Core/DiscussionUpdate.md](Core/DiscussionUpdate.md) |
| DiscussionUser | `DiscussionUsers` |  | root | [Core/DiscussionUser.md](Core/DiscussionUser.md) |
| DocEwidencjaDbTupleDefExt | `DEDbTupleDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition | [Core/DocEwidencjaDbTupleDefExt.md](Core/DocEwidencjaDbTupleDefExt.md) |
| DocPkg | `DocPkgs` |  | root | [Core/DocPkg.md](Core/DocPkg.md) |
| DocPkgCfg | `DocPkgCfgs` | konfig | root | [Core/DocPkgCfg.md](Core/DocPkgCfg.md) |
| DocPkgDef | `DocPkgDefs` | konfig | root | [Core/DocPkgDef.md](Core/DocPkgDef.md) |
| DocPkgItem | `DocPkgItems` |  | root | [Core/DocPkgItem.md](Core/DocPkgItem.md) |
| DocPkgItemProp | `DocPkgItemProps` |  | root | [Core/DocPkgItemProp.md](Core/DocPkgItemProp.md) |
| DokEwidencji | `DokEwidencja` |  | root | [Core/DokEwidencji.md](Core/DokEwidencji.md) |
| DokumentPowiazanyDokEwid | `DokumentyPowiazaneDokEwid` |  |  | [Core/DokumentPowiazanyDokEwid.md](Core/DokumentPowiazanyDokEwid.md) |
| DomyslnyCel | `DomyslneCele` | konfig | root | [Core/DomyslnyCel.md](Core/DomyslnyCel.md) |
| ElemSysWartosc | `ElemSysWartosci` |  |  | [Core/ElemSysWartosc.md](Core/ElemSysWartosc.md) |
| ElemSysZewn | `ElementySysZewn` |  |  | [Core/ElemSysZewn.md](Core/ElemSysZewn.md) |
| ElemSysZewnRelacje | `ElemSysZewnRel` |  |  | [Core/ElemSysZewnRelacje.md](Core/ElemSysZewnRelacje.md) |
| ElemTeczki | `ElemTeczek` |  | child: Teczka→Teczka | [Core/ElemTeczki.md](Core/ElemTeczki.md) |
| ElementPodzielnika | `ElemPodzielnikow` |  | child: Historia→HistoriaPodzielnika | [Core/ElementPodzielnika.md](Core/ElementPodzielnika.md) |
| ElementStrukturyOrganizacyjnej | `ElementyStrOrg` |  | root | [Core/ElementStrukturyOrganizacyjnej.md](Core/ElementStrukturyOrganizacyjnej.md) |
| ElementStrukturyOrganizacyjnejRef | `ElementyStOrgRef` |  | child: Element→ElementStrukturyOrganizacyjnej | [Core/ElementStrukturyOrganizacyjnejRef.md](Core/ElementStrukturyOrganizacyjnejRef.md) |
| GIODOCelPrzetwarzania | `GIODOCelePrzetw` | konfig | root | [Core/GIODOCelPrzetwarzania.md](Core/GIODOCelPrzetwarzania.md) |
| GIODODefinicjaOświadczenia | `GIODODefOswiadcz` | konfig | root | [Core/GIODODefinicjaOświadczenia.md](Core/GIODODefinicjaOświadczenia.md) |
| GIODODefinicjaUprawnienia | `GIODODefUprawn` | konfig | root | [Core/GIODODefinicjaUprawnienia.md](Core/GIODODefinicjaUprawnienia.md) |
| GIODOKategoriaDanychOsobowych | `GIODOKategDnOsob` | konfig | root | [Core/GIODOKategoriaDanychOsobowych.md](Core/GIODOKategoriaDanychOsobowych.md) |
| GIODOKategoriaOdbiorcow | `GIODOKategOdb` | konfig | root | [Core/GIODOKategoriaOdbiorcow.md](Core/GIODOKategoriaOdbiorcow.md) |
| GIODOKategoriaOsob | `GIODOKategOsob` | konfig | root | [Core/GIODOKategoriaOsob.md](Core/GIODOKategoriaOsob.md) |
| GIODONaruszenie | `GIODONaruszenia` |  |  | [Core/GIODONaruszenie.md](Core/GIODONaruszenie.md) |
| GIODOOświadczenie | `GIODOOswiadcz` |  | root | [Core/GIODOOświadczenie.md](Core/GIODOOświadczenie.md) |
| GIODOPrzetwarzanie | `GIODOPrzetwarz` |  | root | [Core/GIODOPrzetwarzanie.md](Core/GIODOPrzetwarzanie.md) |
| GIODOUprawnienie | `GIODOUprawnienia` |  | root | [Core/GIODOUprawnienie.md](Core/GIODOUprawnienie.md) |
| GIODOWycofanieOświadczenia | `GIODOWycofOsw` | konfig | child: Definicja→GIODODefinicjaOświadczenia | [Core/GIODOWycofanieOświadczenia.md](Core/GIODOWycofanieOświadczenia.md) |
| GIODOWymianaDanych | `GIODOWymDanych` |  | root | [Core/GIODOWymianaDanych.md](Core/GIODOWymianaDanych.md) |
| GIODOZbiorDanych | `GIODOZbiory` |  | root | [Core/GIODOZbiorDanych.md](Core/GIODOZbiorDanych.md) |
| GIODOZbiorKategoria | `GIODOZbioryKateg` |  |  | [Core/GIODOZbiorKategoria.md](Core/GIODOZbiorKategoria.md) |
| GIODOZgodny | `GIODOZgodne` |  | child: Host→IGIODOZgodnyHost | [Core/GIODOZgodny.md](Core/GIODOZgodny.md) |
| HTTPLinkInfo | `HTTPLinkInfos` |  | root | [Core/HTTPLinkInfo.md](Core/HTTPLinkInfo.md) |
| HistoriaDanychFirmyBase | `HstDanychFirmy` | konfig | root | [Core/HistoriaDanychFirmyBase.md](Core/HistoriaDanychFirmyBase.md) |
| HistoriaDanychOddziału | `HstDanychOddzial` | konfig | root | [Core/HistoriaDanychOddziału.md](Core/HistoriaDanychOddziału.md) |
| HistoriaPodzielnika | `HistPodzielnikow` |  | child: Podzielnik→PodzielnikKosztow | [Core/HistoriaPodzielnika.md](Core/HistoriaPodzielnika.md) |
| ImportExportXml | `ImpExpXml` |  |  | [Core/ImportExportXml.md](Core/ImportExportXml.md) |
| IsoNumerProcedury | `IsoNumeryProc` | konfig | child: Procedura→IsoProcedura | [Core/IsoNumerProcedury.md](Core/IsoNumerProcedury.md) |
| IsoProcedura | `IsoProcedury` | konfig | root | [Core/IsoProcedura.md](Core/IsoProcedura.md) |
| JednolityPK | `JednolitePK` |  | root | [Core/JednolityPK.md](Core/JednolityPK.md) |
| JednolityPKRel | `JednolitePKRels` |  |  | [Core/JednolityPKRel.md](Core/JednolityPKRel.md) |
| JobInvokeLog | `JobInvokeLogs` |  |  | [Core/JobInvokeLog.md](Core/JobInvokeLog.md) |
| JobInvokeLogDetail | `JobInvokeLogDets` |  |  | [Core/JobInvokeLogDetail.md](Core/JobInvokeLogDetail.md) |
| KDokDodatkowego | `KDokDodatkowych` | konfig | root | [Core/KDokDodatkowego.md](Core/KDokDodatkowego.md) |
| KSeFAwaria | `KSeFAwarie` |  | root | [Core/KSeFAwaria.md](Core/KSeFAwaria.md) |
| KSeFAwariaKomunikatLatarni | `KSeFAwarieKomLat` |  |  | [Core/KSeFAwariaKomunikatLatarni.md](Core/KSeFAwariaKomunikatLatarni.md) |
| KSeFIdentWewn | `KSeFIdentyWewn` | konfig | root | [Core/KSeFIdentWewn.md](Core/KSeFIdentWewn.md) |
| KSeFIdentWewnRola | `KSeFIdentWewnRole` | konfig |  | [Core/KSeFIdentWewnRola.md](Core/KSeFIdentWewnRola.md) |
| KSeFIdentWewnSprzedazMagazyn | `KSeFIdentWewnSpMg` | konfig |  | [Core/KSeFIdentWewnSprzedazMagazyn.md](Core/KSeFIdentWewnSprzedazMagazyn.md) |
| KSeFIdentWewnSprzedazOddzial | `KSeFIdentWewnSpOd` | konfig |  | [Core/KSeFIdentWewnSprzedazOddzial.md](Core/KSeFIdentWewnSprzedazOddzial.md) |
| KSeFIdentWewnSprzedazOperator | `KSeFIdentWewnSpOp` | konfig |  | [Core/KSeFIdentWewnSprzedazOperator.md](Core/KSeFIdentWewnSprzedazOperator.md) |
| KSeFKomunikat | `KSeFKomunikaty` |  | root | [Core/KSeFKomunikat.md](Core/KSeFKomunikat.md) |
| KSeFPackage | `KSeFPackages` |  | root | [Core/KSeFPackage.md](Core/KSeFPackage.md) |
| KSeFPackageElem | `KSeFPackageElems` |  |  | [Core/KSeFPackageElem.md](Core/KSeFPackageElem.md) |
| KSeFPartList | `KSeFPartLists` |  |  | [Core/KSeFPartList.md](Core/KSeFPartList.md) |
| KSeFPlik | `KSeFPliki` |  | root | [Core/KSeFPlik.md](Core/KSeFPlik.md) |
| KSeFPodmiot3 | `KSeFPodmioty3` |  |  | [Core/KSeFPodmiot3.md](Core/KSeFPodmiot3.md) |
| KSeFSzablonPolOpcjonalnych | `KSeFSzblPolOp` | konfig | root | [Core/KSeFSzablonPolOpcjonalnych.md](Core/KSeFSzablonPolOpcjonalnych.md) |
| KSeFSzablonPolOpcjonalnychDefXmlNagStatus | `KSeFSzblPolOpDef` | konfig | root | [Core/KSeFSzablonPolOpcjonalnychDefXmlNagStatus.md](Core/KSeFSzablonPolOpcjonalnychDefXmlNagStatus.md) |
| KSeFSzablonPolOpcjonalnychPozycja | `KSeFSzblPolOpPoz` | konfig | root | [Core/KSeFSzablonPolOpcjonalnychPozycja.md](Core/KSeFSzablonPolOpcjonalnychPozycja.md) |
| KSeFSzablonZalacznika | `KSeFSzblZal` | konfig | root | [Core/KSeFSzablonZalacznika.md](Core/KSeFSzablonZalacznika.md) |
| KSeFSzablonZalacznikaDefXmlNagRelation | `KSeFSzblZalDefs` | konfig | root | [Core/KSeFSzablonZalacznikaDefXmlNagRelation.md](Core/KSeFSzablonZalacznikaDefXmlNagRelation.md) |
| KSeFSzablonZalacznikaElement | `KSeFSzblZalElem` | konfig | root | [Core/KSeFSzablonZalacznikaElement.md](Core/KSeFSzablonZalacznikaElement.md) |
| KSeFTokenIdentWewnRel | `KSeFTokIdWewRels` |  |  | [Core/KSeFTokenIdentWewnRel.md](Core/KSeFTokenIdentWewnRel.md) |
| KSeFUPO | `KSeFUPOs` |  | root | [Core/KSeFUPO.md](Core/KSeFUPO.md) |
| KSeFZapytanieOFa | `KSeFZapytaniaOFa` |  | root | [Core/KSeFZapytanieOFa.md](Core/KSeFZapytanieOFa.md) |
| KodKreskowy | `KodyKreskowe` |  | child: Zapis→IKodowany | [Core/KodKreskowy.md](Core/KodKreskowy.md) |
| KodPocztowy | `KodyPocztowe` |  |  | [Core/KodPocztowy.md](Core/KodPocztowy.md) |
| KodPocztowyAU | `KodyPocztoweAU` |  |  | [Core/KodPocztowyAU.md](Core/KodPocztowyAU.md) |
| KomunikatAPI | `KomunikatyAPI` |  |  | [Core/KomunikatAPI.md](Core/KomunikatAPI.md) |
| Konwersacja | `Konwersacje` |  | root | [Core/Konwersacja.md](Core/Konwersacja.md) |
| KrajSME | `KrajeSME` | konfig | root | [Core/KrajSME.md](Core/KrajSME.md) |
| KrajTbl | `KrajeTbl` | konfig | root | [Core/KrajTbl.md](Core/KrajTbl.md) |
| Licznik | `Liczniki` |  |  | [Core/Licznik.md](Core/Licznik.md) |
| ManagedRowCreator | `ManagedRowCrts` | konfig | child: Definicja→IManagedRowDefinion | [Core/ManagedRowCreator.md](Core/ManagedRowCreator.md) |
| ManagedRowInfo | `ManagedRowsInfo` |  | child: ManagedRow→IManagedRowInfoHost | [Core/ManagedRowInfo.md](Core/ManagedRowInfo.md) |
| ManagedRowMetrics | `ManRowsMetrics` |  | child: ManagedRowInfo→ManagedRowInfo | [Core/ManagedRowMetrics.md](Core/ManagedRowMetrics.md) |
| ManagedRowMetricsDefinition | `ManRowMetricDefs` | konfig | root | [Core/ManagedRowMetricsDefinition.md](Core/ManagedRowMetricsDefinition.md) |
| MetrykaOddziałuFirmy | `MetrykiOddzFirmy` | konfig | child: Oddzial→OddzialFirmy | [Core/MetrykaOddziałuFirmy.md](Core/MetrykaOddziałuFirmy.md) |
| Notice | `Notices` |  | root | [Core/Notice.md](Core/Notice.md) |
| NoticeChannel | `NoticeChannels` |  | root | [Core/NoticeChannel.md](Core/NoticeChannel.md) |
| NoticePermission | `NoticePerms` |  |  | [Core/NoticePermission.md](Core/NoticePermission.md) |
| NoticeReceipt | `NoticeReceipts` |  | root | [Core/NoticeReceipt.md](Core/NoticeReceipt.md) |
| ObfuscateDef | `ObfuscateDefs` | konfig | root | [Core/ObfuscateDef.md](Core/ObfuscateDef.md) |
| ObfuscateField | `ObfuscateFields` | konfig | child: ObfuscateDef→ObfuscateDef | [Core/ObfuscateField.md](Core/ObfuscateField.md) |
| ObfuscatedData | `ObfuscatedDatas` |  | root | [Core/ObfuscatedData.md](Core/ObfuscatedData.md) |
| OddzialFirmy | `OddzialyFirmy` | konfig | root | [Core/OddzialFirmy.md](Core/OddzialFirmy.md) |
| OddzialFirmyRef | `OddzialyFirmyRef` | konfig | child: Oddzial→OddzialFirmy | [Core/OddzialFirmyRef.md](Core/OddzialFirmyRef.md) |
| OpisPIM | `OpisyPIM` |  |  | [Core/OpisPIM.md](Core/OpisPIM.md) |
| ParametrRozlicz | `ParametryRozlicz` | konfig |  | [Core/ParametrRozlicz.md](Core/ParametrRozlicz.md) |
| PodzielnikKosztow | `PodzielKosztow` |  | child: Zrodlo→IZrodloPodzielnikaKosztow | [Core/PodzielnikKosztow.md](Core/PodzielnikKosztow.md) |
| PowiązanieStrukturyOrganizacyjnej | `PowiazaniaStrOrg` |  | child: Zrodlo→IŹródłoPowiązaniaStrukturyOrganizacyjnej | [Core/PowiązanieStrukturyOrganizacyjnej.md](Core/PowiązanieStrukturyOrganizacyjnej.md) |
| PozycjaEwidencjiZbiorczej | `PozEwidZbiorczej` |  | child: Ewidencja→DokEwidencji | [Core/PozycjaEwidencjiZbiorczej.md](Core/PozycjaEwidencjiZbiorczej.md) |
| PoświadczenieOdbioru | `PoswiadczOdbioru` |  | child: Dokument→IPoświadczenieOdbioruHost | [Core/PoświadczenieOdbioru.md](Core/PoświadczenieOdbioru.md) |
| ProceduraSME | `ProcedurySME` | konfig | child: Kraj→KrajSME | [Core/ProceduraSME.md](Core/ProceduraSME.md) |
| ProceduraVAT | `ProceduryVAT` | konfig | root | [Core/ProceduraVAT.md](Core/ProceduraVAT.md) |
| RecordSequence | `RecordSequences` |  |  | [Core/RecordSequence.md](Core/RecordSequence.md) |
| RelProceduraVAT | `RelProceduryVAT` |  | root | [Core/RelProceduraVAT.md](Core/RelProceduraVAT.md) |
| RelacjaDanychZewn | `RelacjeDanychZ` |  |  | [Core/RelacjaDanychZewn.md](Core/RelacjaDanychZewn.md) |
| RelacjaOpisPIM | `RelacjeOpisowPIM` |  |  | [Core/RelacjaOpisPIM.md](Core/RelacjaOpisPIM.md) |
| RelacjaZewn | `RelacjeZewn` |  |  | [Core/RelacjaZewn.md](Core/RelacjaZewn.md) |
| RodzajDokumentuKseF | `RodzajeDokKseF` |  | root | [Core/RodzajDokumentuKseF.md](Core/RodzajDokumentuKseF.md) |
| RodzajKomunikatuHost | `RodzajeKomHost` |  |  | [Core/RodzajKomunikatuHost.md](Core/RodzajKomunikatuHost.md) |
| RodzajKontaktu | `RodzajeKontaktow` | konfig | root | [Core/RodzajKontaktu.md](Core/RodzajKontaktu.md) |
| RodzajPodmiot | `RodzajePodmioty` |  | root | [Core/RodzajPodmiot.md](Core/RodzajPodmiot.md) |
| RodzajZrodla | `RodzajeZrodel` | konfig | root | [Core/RodzajZrodla.md](Core/RodzajZrodla.md) |
| ScheduleDefinition | `ScheduleDefs` | konfig | root | [Core/ScheduleDefinition.md](Core/ScheduleDefinition.md) |
| ScheduleItem | `ScheduleItems` |  |  | [Core/ScheduleItem.md](Core/ScheduleItem.md) |
| SkanerKodow | `SkaneryKodow` |  | root | [Core/SkanerKodow.md](Core/SkanerKodow.md) |
| SlownikElem | `Slowniki` | konfig | root | [Core/SlownikElem.md](Core/SlownikElem.md) |
| SlownikPIM | `SlownikiPIM` |  |  | [Core/SlownikPIM.md](Core/SlownikPIM.md) |
| SlownikZewn | `SlownikiZewn` | konfig | root | [Core/SlownikZewn.md](Core/SlownikZewn.md) |
| SlownikZewnRel | `SlownikiZewnRel` |  |  | [Core/SlownikZewnRel.md](Core/SlownikZewnRel.md) |
| StanTeczki | `StanyTeczek` | konfig | child: Definicja→DefTeczki | [Core/StanTeczki.md](Core/StanTeczki.md) |
| StrukturaOrganizacyjna | `StrukturyOrg` | konfig | root | [Core/StrukturaOrganizacyjna.md](Core/StrukturaOrganizacyjna.md) |
| Subscription | `Subscriptions` |  |  | [Core/Subscription.md](Core/Subscription.md) |
| SubstituteDef | `SubstituteDefs` | konfig | root | [Core/SubstituteDef.md](Core/SubstituteDef.md) |
| SubstituteUser | `SubstituteUsers` |  | root | [Core/SubstituteUser.md](Core/SubstituteUser.md) |
| SysZewToken | `SysZewTokeny` | konfig | root | [Core/SysZewToken.md](Core/SysZewToken.md) |
| SysZewnImpDef | `SysZewnImpDefs` |  |  | [Core/SysZewnImpDef.md](Core/SysZewnImpDef.md) |
| SysZewnStatus | `SysZewnStatusy` |  |  | [Core/SysZewnStatus.md](Core/SysZewnStatus.md) |
| SysZewnUsDodatkowa | `SysZewnUsDod` |  |  | [Core/SysZewnUsDodatkowa.md](Core/SysZewnUsDodatkowa.md) |
| SystemZewn | `SystemyZewn` | konfig | root | [Core/SystemZewn.md](Core/SystemZewn.md) |
| SystemZewnDefXmlNag | `SysZewnDefXmls` | konfig |  | [Core/SystemZewnDefXmlNag.md](Core/SystemZewnDefXmlNag.md) |
| SzablonPIM | `SzablonyPIM` | konfig | root | [Core/SzablonPIM.md](Core/SzablonPIM.md) |
| SzablonSlownikaPIM | `SzablonySlowPIM` | konfig |  | [Core/SzablonSlownikaPIM.md](Core/SzablonSlownikaPIM.md) |
| Teczka | `Teczki` |  | root | [Core/Teczka.md](Core/Teczka.md) |
| TerminalPlatStanowisko | `TerminalPlatStan` | konfig |  | [Core/TerminalPlatStanowisko.md](Core/TerminalPlatStanowisko.md) |
| TerminalPlatniczy | `TerminalePlat` | konfig | root | [Core/TerminalPlatniczy.md](Core/TerminalPlatniczy.md) |
| ThreadCategory | `ThreadCategories` | konfig |  | [Core/ThreadCategory.md](Core/ThreadCategory.md) |
| TimeTrack | `TimeTracks` |  | root | [Core/TimeTrack.md](Core/TimeTrack.md) |
| ToDoItem | `ToDoItems` |  |  | [Core/ToDoItem.md](Core/ToDoItem.md) |
| UIExtension | `UIExtensions` |  | root | [Core/UIExtension.md](Core/UIExtension.md) |
| WarningDef | `WarningDefs` | konfig | root | [Core/WarningDef.md](Core/WarningDef.md) |
| WarningDefRel | `WarningDefRels` | konfig | root | [Core/WarningDefRel.md](Core/WarningDefRel.md) |
| ZadanieZewnSynch | `ZadaniaZewnSynch` |  |  | [Core/ZadanieZewnSynch.md](Core/ZadanieZewnSynch.md) |
| ZestawPodzielnikowKosztow | `ZestPodzKosztow` | konfig | root | [Core/ZestawPodzielnikowKosztow.md](Core/ZestawPodzielnikowKosztow.md) |
| ZrodloFinansowania | `ZrodlaFinansow` | konfig | root | [Core/ZrodloFinansowania.md](Core/ZrodloFinansowania.md) |

## CzlonkowieSzkolenia

- Opis: Moduł zarządzania członkami i szkoleniami organizacji. Zawiera kartotekę członków, kursy szkoleniowe, zapisy, certyfikaty oraz harmonogramy szkoleń.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| DefRodzajSzkol | `DefRodzajeSzkol` | konfig | root | [CzlonkowieSzkolenia/DefRodzajSzkol.md](CzlonkowieSzkolenia/DefRodzajSzkol.md) |
| DefSkladki | `DefSkladek` | konfig | root | [CzlonkowieSzkolenia/DefSkladki.md](CzlonkowieSzkolenia/DefSkladki.md) |
| DefWyroznienia | `DefWyroznien` | konfig | root | [CzlonkowieSzkolenia/DefWyroznienia.md](CzlonkowieSzkolenia/DefWyroznienia.md) |
| DefZgloszenia | `DefZgloszen` | konfig | root | [CzlonkowieSzkolenia/DefZgloszenia.md](CzlonkowieSzkolenia/DefZgloszenia.md) |
| GrupaMaterial | `GrupyMaterialy` |  |  | [CzlonkowieSzkolenia/GrupaMaterial.md](CzlonkowieSzkolenia/GrupaMaterial.md) |
| GrupaSzkol | `GrupySzkol` |  | root | [CzlonkowieSzkolenia/GrupaSzkol.md](CzlonkowieSzkolenia/GrupaSzkol.md) |
| HarmonogramWplat | `HarmWplat` |  |  | [CzlonkowieSzkolenia/HarmonogramWplat.md](CzlonkowieSzkolenia/HarmonogramWplat.md) |
| Klub | `Kluby` | konfig | root | [CzlonkowieSzkolenia/Klub.md](CzlonkowieSzkolenia/Klub.md) |
| KlubUcz | `KlubyUcz` |  | child: UczestnikBase→UczestnikBase | [CzlonkowieSzkolenia/KlubUcz.md](CzlonkowieSzkolenia/KlubUcz.md) |
| KlubUczHist | `KlubyUczHist` |  |  | [CzlonkowieSzkolenia/KlubUczHist.md](CzlonkowieSzkolenia/KlubUczHist.md) |
| ModulSzkol | `ModulySzkol` |  |  | [CzlonkowieSzkolenia/ModulSzkol.md](CzlonkowieSzkolenia/ModulSzkol.md) |
| Odczyt | `Odczyty` |  | root | [CzlonkowieSzkolenia/Odczyt.md](CzlonkowieSzkolenia/Odczyt.md) |
| OdczytCzlonek | `OdczytyCzlonkow` |  |  | [CzlonkowieSzkolenia/OdczytCzlonek.md](CzlonkowieSzkolenia/OdczytCzlonek.md) |
| PrzedmiotSzkol | `PrzedmiotySzkol` |  | root | [CzlonkowieSzkolenia/PrzedmiotSzkol.md](CzlonkowieSzkolenia/PrzedmiotSzkol.md) |
| RejestrUDZ | `RejestryUDZ` |  | root | [CzlonkowieSzkolenia/RejestrUDZ.md](CzlonkowieSzkolenia/RejestrUDZ.md) |
| RodzajSzkol | `RodzajeSzkol` |  | root | [CzlonkowieSzkolenia/RodzajSzkol.md](CzlonkowieSzkolenia/RodzajSzkol.md) |
| RodzajSzkolPrzedmiot | `RdzSzPrzedmioty` |  |  | [CzlonkowieSzkolenia/RodzajSzkolPrzedmiot.md](CzlonkowieSzkolenia/RodzajSzkolPrzedmiot.md) |
| RodzajSzkolUprawnienie | `RdzSzkUpraw` |  | root | [CzlonkowieSzkolenia/RodzajSzkolUprawnienie.md](CzlonkowieSzkolenia/RodzajSzkolUprawnienie.md) |
| RodzajSzkolWyroznienie | `RdzSzkWyroz` |  |  | [CzlonkowieSzkolenia/RodzajSzkolWyroznienie.md](CzlonkowieSzkolenia/RodzajSzkolWyroznienie.md) |
| SalaSzkol | `SaleSzkol` |  | root | [CzlonkowieSzkolenia/SalaSzkol.md](CzlonkowieSzkolenia/SalaSzkol.md) |
| Skladka | `Skladki` |  | root | [CzlonkowieSzkolenia/Skladka.md](CzlonkowieSzkolenia/Skladka.md) |
| SzkOsobaPodpis | `SzkOsobyPodpisy` | konfig | root | [CzlonkowieSzkolenia/SzkOsobaPodpis.md](CzlonkowieSzkolenia/SzkOsobaPodpis.md) |
| TrybZajec | `TrybyZajec` | konfig |  | [CzlonkowieSzkolenia/TrybZajec.md](CzlonkowieSzkolenia/TrybZajec.md) |
| TypDzialalUcz | `TypyDzialalUcz` |  | child: UczestnikBase→UczestnikBase | [CzlonkowieSzkolenia/TypDzialalUcz.md](CzlonkowieSzkolenia/TypDzialalUcz.md) |
| TypDzialalnosci | `TypyDzialalnosci` | konfig | root | [CzlonkowieSzkolenia/TypDzialalnosci.md](CzlonkowieSzkolenia/TypDzialalnosci.md) |
| TytulZawodUcz | `TytulyZawodUcz` |  | child: UczestnikBase→UczestnikBase | [CzlonkowieSzkolenia/TytulZawodUcz.md](CzlonkowieSzkolenia/TytulZawodUcz.md) |
| UczFunkcja | `UczFunkcje` |  | root | [CzlonkowieSzkolenia/UczFunkcja.md](CzlonkowieSzkolenia/UczFunkcja.md) |
| UczTytulZawod | `UczTytulyZawod` | konfig | root | [CzlonkowieSzkolenia/UczTytulZawod.md](CzlonkowieSzkolenia/UczTytulZawod.md) |
| UczestnikBase | `Uczestnicy` |  | root | [CzlonkowieSzkolenia/UczestnikBase.md](CzlonkowieSzkolenia/UczestnikBase.md) |
| UczestnikHist | `UczestnicyHist` |  |  | [CzlonkowieSzkolenia/UczestnikHist.md](CzlonkowieSzkolenia/UczestnikHist.md) |
| UprawnienieZgloszenia | `UprawZglosz` |  |  | [CzlonkowieSzkolenia/UprawnienieZgloszenia.md](CzlonkowieSzkolenia/UprawnienieZgloszenia.md) |
| WykladowcaSzkol | `WykladowcySzkol` |  | root | [CzlonkowieSzkolenia/WykladowcaSzkol.md](CzlonkowieSzkolenia/WykladowcaSzkol.md) |
| Wyroznienie | `Wyroznienia` |  | root | [CzlonkowieSzkolenia/Wyroznienie.md](CzlonkowieSzkolenia/Wyroznienie.md) |
| ZajecieSala | `ZajeciaSale` |  |  | [CzlonkowieSzkolenia/ZajecieSala.md](CzlonkowieSzkolenia/ZajecieSala.md) |
| ZajecieSzkolBase | `ZajeciaSzkol` |  | root | [CzlonkowieSzkolenia/ZajecieSzkolBase.md](CzlonkowieSzkolenia/ZajecieSzkolBase.md) |
| ZajecieUczestnik | `ZajeciaUcz` |  |  | [CzlonkowieSzkolenia/ZajecieUczestnik.md](CzlonkowieSzkolenia/ZajecieUczestnik.md) |
| ZajecieWykladowca | `ZajeciaWykl` |  |  | [CzlonkowieSzkolenia/ZajecieWykladowca.md](CzlonkowieSzkolenia/ZajecieWykladowca.md) |
| ZespolSzkol | `ZespolySzkol` |  |  | [CzlonkowieSzkolenia/ZespolSzkol.md](CzlonkowieSzkolenia/ZespolSzkol.md) |
| Zgloszenie | `Zgloszenia` |  | root | [CzlonkowieSzkolenia/Zgloszenie.md](CzlonkowieSzkolenia/Zgloszenie.md) |
| ZgloszeniePlatnik | `ZgloszeniaPlat` |  |  | [CzlonkowieSzkolenia/ZgloszeniePlatnik.md](CzlonkowieSzkolenia/ZgloszeniePlatnik.md) |
| ZgloszeniePozDok | `ZgloszeniaPozDok` |  |  | [CzlonkowieSzkolenia/ZgloszeniePozDok.md](CzlonkowieSzkolenia/ZgloszeniePozDok.md) |
| ZgloszenieUczGrupa | `ZgloszeniaUczGrp` |  |  | [CzlonkowieSzkolenia/ZgloszenieUczGrupa.md](CzlonkowieSzkolenia/ZgloszenieUczGrupa.md) |
| ZgloszenieUczestnik | `ZgloszeniaUczest` |  |  | [CzlonkowieSzkolenia/ZgloszenieUczestnik.md](CzlonkowieSzkolenia/ZgloszenieUczestnik.md) |

## Deklaracje

- Opis: Moduł obsługujący deklaracje podatkowe i sprawozdawcze. Zawiera szablony deklaracji, formularze XML, mechanizmy generowania i wysyłki deklaracji do urzędów.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| Deklaracja | `Deklaracje` |  | root | [Deklaracje/Deklaracja.md](Deklaracje/Deklaracja.md) |
| EDeklaracja | `EDeklaracje` |  |  | [Deklaracje/EDeklaracja.md](Deklaracje/EDeklaracja.md) |
| ETransmisja | `ETransmisje` |  |  | [Deklaracje/ETransmisja.md](Deklaracje/ETransmisja.md) |

## Delegacje

- Opis: Moduł obsługujący delegacje służbowe. Zawiera definicje delegacji, etapy podróży, diety, koszty przejazdów, noclegi oraz rozliczenia delegacji pracowników.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| Delegacja | `Delegacje` |  | root | [Delegacje/Delegacja.md](Delegacje/Delegacja.md) |
| EtapDelegacji | `EtapyDelegacji` |  | child: Delegacja→Delegacja | [Delegacje/EtapDelegacji.md](Delegacje/EtapDelegacji.md) |
| KosztDelegacji | `KosztyDelegacji` |  | root | [Delegacje/KosztDelegacji.md](Delegacje/KosztDelegacji.md) |
| KrajDelegacji | `KrajeDelegacji` | konfig | root | [Delegacje/KrajDelegacji.md](Delegacje/KrajDelegacji.md) |
| KwotaNaliczeniaDelegacji | `KwotaNalDeleg` |  | child: Naliczenie→NaliczenieDelegacji | [Delegacje/KwotaNaliczeniaDelegacji.md](Delegacje/KwotaNaliczeniaDelegacji.md) |
| NaliczenieDelegacji | `NalDelegacji` |  | child: Delegacja→Delegacja | [Delegacje/NaliczenieDelegacji.md](Delegacje/NaliczenieDelegacji.md) |
| StawkaDelegacji | `StawkiDelegacji` | konfig | child: Kraj→KrajDelegacji | [Delegacje/StawkaDelegacji.md](Delegacje/StawkaDelegacji.md) |
| ZakupWalutDoDelegacji | `ZakupyWalutDeleg` |  | child: Delegacja→Delegacja | [Delegacje/ZakupWalutDoDelegacji.md](Delegacje/ZakupWalutDoDelegacji.md) |
| ZaliczkaDelegacji | `ZaliczkiDeleg` |  | child: Delegacja→Delegacja | [Delegacje/ZaliczkaDelegacji.md](Delegacje/ZaliczkaDelegacji.md) |

## Dms

- Opis: Moduł zarządzania dokumentami (DMS). Zawiera rejestry dokumentów, kategorie, statusy, obiegi oraz mechanizmy archiwizacji i wersjonowania dokumentów.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| BDocBusEnt | `BDocBusEnts` |  |  | [Dms/BDocBusEnt.md](Dms/BDocBusEnt.md) |
| BasicDocKind | `BasicDocKinds` |  | root | [Dms/BasicDocKind.md](Dms/BasicDocKind.md) |
| BasicDocument | `BasicDocs` |  | root | [Dms/BasicDocument.md](Dms/BasicDocument.md) |
| BasicDocumentDefinition | `BasicDocDefs` | konfig | root | [Dms/BasicDocumentDefinition.md](Dms/BasicDocumentDefinition.md) |
| ChronoOrdDefEn | `ChronoOrdDefEns` | konfig | root | [Dms/ChronoOrdDefEn.md](Dms/ChronoOrdDefEn.md) |
| ChronoOrder | `ChronoOrders` |  | root | [Dms/ChronoOrder.md](Dms/ChronoOrder.md) |
| ChronoOrderElem | `ChronoOrderElems` |  | root | [Dms/ChronoOrderElem.md](Dms/ChronoOrderElem.md) |
| ChronoOrderLoc | `ChronoOrderLocs` |  | root | [Dms/ChronoOrderLoc.md](Dms/ChronoOrderLoc.md) |
| DmsArchInfo | `DmsArchInfos` |  |  | [Dms/DmsArchInfo.md](Dms/DmsArchInfo.md) |
| DmsState | `DmsStates` | konfig | root | [Dms/DmsState.md](Dms/DmsState.md) |
| DmsStateDef | `DmsStateDefs` | konfig | root | [Dms/DmsStateDef.md](Dms/DmsStateDef.md) |
| Matter | `Matters` |  | root | [Dms/Matter.md](Dms/Matter.md) |
| MatterDefinition | `MatterDefs` | konfig | root | [Dms/MatterDefinition.md](Dms/MatterDefinition.md) |
| OcrBusinessMapping | `OcrBusMappings` | konfig | root | [Dms/OcrBusinessMapping.md](Dms/OcrBusinessMapping.md) |
| OcrBusinessMappingElement | `OcrBusMapElems` | konfig | root | [Dms/OcrBusinessMappingElement.md](Dms/OcrBusinessMappingElement.md) |
| OcrBusinessMappingOutput | `OcrBusMapOutputs` |  |  | [Dms/OcrBusinessMappingOutput.md](Dms/OcrBusinessMappingOutput.md) |
| Register | `Registers` | konfig | root | [Dms/Register.md](Dms/Register.md) |
| UnifiedRegister | `UnifiedRgs` | konfig | root | [Dms/UnifiedRegister.md](Dms/UnifiedRegister.md) |
| UnifiedRegisterClass | `UnifiedRgClasses` | konfig | root | [Dms/UnifiedRegisterClass.md](Dms/UnifiedRegisterClass.md) |

## EwidencjaVat

- Opis: Moduł ewidencji VAT. Zawiera rejestry VAT zakupu i sprzedaży, deklaracje VAT, pliki JPK oraz mechanizmy kontroli i raportowania podatku VAT.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| DefinicjaPowstaniaObowiazkuVAT | `DefinicjePOVAT` | konfig | root | [EwidencjaVat/DefinicjaPowstaniaObowiazkuVAT.md](EwidencjaVat/DefinicjaPowstaniaObowiazkuVAT.md) |
| ElemEwidencjiVATAkcyzy | `EleEwidencjiVATT` |  | child: Naglowek→NagEwidencjiVATAkcyzy | [EwidencjaVat/ElemEwidencjiVATAkcyzy.md](EwidencjaVat/ElemEwidencjiVATAkcyzy.md) |
| ElemRozliczeniaVATAkcyzy | `EleRozliczenVATT` |  | child: Naglowek→NagRozliczeniaVATAkcyzy | [EwidencjaVat/ElemRozliczeniaVATAkcyzy.md](EwidencjaVat/ElemRozliczeniaVATAkcyzy.md) |
| NagEwidencjiVATAkcyzy | `NagEwidencjiVATT` |  | child: Ewidencja→DokEwidencji | [EwidencjaVat/NagEwidencjiVATAkcyzy.md](EwidencjaVat/NagEwidencjiVATAkcyzy.md) |
| NagRozliczeniaVATAkcyzy | `NagRozliczenVATT` |  | child: Naglowek→NagEwidencjiVATAkcyzy | [EwidencjaVat/NagRozliczeniaVATAkcyzy.md](EwidencjaVat/NagRozliczeniaVATAkcyzy.md) |

## HR

- Opis: Moduł zarządzania zasobami ludzkimi (HR). Zawiera strukturę organizacyjną, stanowiska, kompetencje, oceny pracownicze, szkolenia, rekrutację oraz planowanie kariery.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| AspektKompetencjiMerytorycznej | `ZklAspKmpMery` | konfig | root | [HR/AspektKompetencjiMerytorycznej.md](HR/AspektKompetencjiMerytorycznej.md) |
| AspektKompetencjiUniwersalnej | `ZklAspKmpUniw` | konfig | root | [HR/AspektKompetencjiUniwersalnej.md](HR/AspektKompetencjiUniwersalnej.md) |
| AspektPoziomKompetencjiMerytorycznej | `ZklAspPozMery` | konfig |  | [HR/AspektPoziomKompetencjiMerytorycznej.md](HR/AspektPoziomKompetencjiMerytorycznej.md) |
| AspektPoziomKompetencjiUniwersalnej | `ZklAspPozUniw` | konfig |  | [HR/AspektPoziomKompetencjiUniwersalnej.md](HR/AspektPoziomKompetencjiUniwersalnej.md) |
| BadaniaLekarskieDefinicjiStanowiska | `BadLekDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska | [HR/BadaniaLekarskieDefinicjiStanowiska.md](HR/BadaniaLekarskieDefinicjiStanowiska.md) |
| Benefit | `ZklBenefity` | konfig | root | [HR/Benefit.md](HR/Benefit.md) |
| BudżetSzkoleń | `BudzetySzkolen` |  | root | [HR/BudżetSzkoleń.md](HR/BudżetSzkoleń.md) |
| CzynnikSzkodliwyDefinicjiStanowiska | `CzynSzkodDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska | [HR/CzynnikSzkodliwyDefinicjiStanowiska.md](HR/CzynnikSzkodliwyDefinicjiStanowiska.md) |
| CzynnoscZadania | `ZklCzynnZadan` | konfig | root | [HR/CzynnoscZadania.md](HR/CzynnoscZadania.md) |
| DefElementuOcenyPracownika | `DefElemOcenPrac` | konfig | root | [HR/DefElementuOcenyPracownika.md](HR/DefElementuOcenyPracownika.md) |
| DefinicjaEtapuRekrutacji | `DefEtaRekrutacji` | konfig | root | [HR/DefinicjaEtapuRekrutacji.md](HR/DefinicjaEtapuRekrutacji.md) |
| DefinicjaFunkcji | `DefinicjeFunkcji` | konfig | root | [HR/DefinicjaFunkcji.md](HR/DefinicjaFunkcji.md) |
| DefinicjaPlanowaniaZasobow | `DefPlanZasob` | konfig | root | [HR/DefinicjaPlanowaniaZasobow.md](HR/DefinicjaPlanowaniaZasobow.md) |
| DefinicjaStanowiska | `DefStanowisk` | konfig | root | [HR/DefinicjaStanowiska.md](HR/DefinicjaStanowiska.md) |
| DefinicjaStanowiskaHist | `DefStanowiskHist` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska | [HR/DefinicjaStanowiskaHist.md](HR/DefinicjaStanowiskaHist.md) |
| DefinicjaStanowiskaHistZkl | `ZklDefStanHist` | konfig | child: DefinicjaStanowiskaHist→DefinicjaStanowiskaHist | [HR/DefinicjaStanowiskaHistZkl.md](HR/DefinicjaStanowiskaHistZkl.md) |
| DefinicjaSzkolenia | `DefinicjeSzkolen` |  | root | [HR/DefinicjaSzkolenia.md](HR/DefinicjaSzkolenia.md) |
| DefinicjaUprawnienia | `DefUprawnien` |  | root | [HR/DefinicjaUprawnienia.md](HR/DefinicjaUprawnienia.md) |
| DodatkowaKwalifikacjaZawodowa | `ZklDodKwalZwd` | konfig | root | [HR/DodatkowaKwalifikacjaZawodowa.md](HR/DodatkowaKwalifikacjaZawodowa.md) |
| DokumentDefinicjiStanowiska | `DokumentyDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska | [HR/DokumentDefinicjiStanowiska.md](HR/DokumentDefinicjiStanowiska.md) |
| DokumentPlanowaniaZasobow | `DokPlanZasob` |  | root | [HR/DokumentPlanowaniaZasobow.md](HR/DokumentPlanowaniaZasobow.md) |
| DokumentProcedura | `ZklDokProc` | konfig | root | [HR/DokumentProcedura.md](HR/DokumentProcedura.md) |
| DostawcaSzkoleń | `DostawcySzkolen` |  | root | [HR/DostawcaSzkoleń.md](HR/DostawcaSzkoleń.md) |
| DostepDoSystemow | `ZklDostSys` | konfig | root | [HR/DostepDoSystemow.md](HR/DostepDoSystemow.md) |
| ElementOcenyPracownika | `ElementyOcenPrac` |  | child: Ocena→IOcenaPracownika | [HR/ElementOcenyPracownika.md](HR/ElementOcenyPracownika.md) |
| ElementWzoruOcenyPracownika | `ElemWzorowOcPrac` | konfig | child: Wzor→WzorOcenyPracownika | [HR/ElementWzoruOcenyPracownika.md](HR/ElementWzoruOcenyPracownika.md) |
| EtapRealizacjiSzkolenia | `EtapRealizSzkol` | konfig | root | [HR/EtapRealizacjiSzkolenia.md](HR/EtapRealizacjiSzkolenia.md) |
| EtapRekrutacji | `EtapyRekrutacji` |  | root | [HR/EtapRekrutacji.md](HR/EtapRekrutacji.md) |
| FormularzWartosciowania | `ZklFormularzWart` |  |  | [HR/FormularzWartosciowania.md](HR/FormularzWartosciowania.md) |
| GrupaKompetencjiMerytorycznych | `ZklKtgKmpMery` | konfig | root | [HR/GrupaKompetencjiMerytorycznych.md](HR/GrupaKompetencjiMerytorycznych.md) |
| GrupaKompetencjiUniwersalnych | `ZklKtgKmpUniw` | konfig | root | [HR/GrupaKompetencjiUniwersalnych.md](HR/GrupaKompetencjiUniwersalnych.md) |
| GrupaStanowisk | `GrupaStanow` | konfig | root | [HR/GrupaStanowisk.md](HR/GrupaStanowisk.md) |
| GrupaSzkolenIUprawnien | `ZklGrSzkolUpr` | konfig | root | [HR/GrupaSzkolenIUprawnien.md](HR/GrupaSzkolenIUprawnien.md) |
| GrupaZadan | `ZklKtgZadan` | konfig | root | [HR/GrupaZadan.md](HR/GrupaZadan.md) |
| GrupaZaszeregowaniaDefinicjiStanowiska | `GrupZasDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska | [HR/GrupaZaszeregowaniaDefinicjiStanowiska.md](HR/GrupaZaszeregowaniaDefinicjiStanowiska.md) |
| KategoriaGrupyStanowisk | `KatGrupyStan` | konfig | root | [HR/KategoriaGrupyStanowisk.md](HR/KategoriaGrupyStanowisk.md) |
| KategoriaPracownika | `KatPrac` | konfig | root | [HR/KategoriaPracownika.md](HR/KategoriaPracownika.md) |
| KategoriaSzkolenia | `KategorieSzkolen` | konfig | root | [HR/KategoriaSzkolenia.md](HR/KategoriaSzkolenia.md) |
| KategoriaUprawnienia | `KatUprawnien` | konfig | root | [HR/KategoriaUprawnienia.md](HR/KategoriaUprawnienia.md) |
| KategoriePracownikow | `ZklKatPrac` | konfig | root | [HR/KategoriePracownikow.md](HR/KategoriePracownikow.md) |
| KierunekKsztalceniaSzkolySrednie | `ZklKierKszSre` | konfig | root | [HR/KierunekKsztalceniaSzkolySrednie.md](HR/KierunekKsztalceniaSzkolySrednie.md) |
| KierunekKsztalceniaSzkolyWyzsze | `ZklKierKszWyz` | konfig | root | [HR/KierunekKsztalceniaSzkolyWyzsze.md](HR/KierunekKsztalceniaSzkolyWyzsze.md) |
| KierunekKsztalceniaSzkolyZawodowe | `ZklKierKszZwd` | konfig | root | [HR/KierunekKsztalceniaSzkolyZawodowe.md](HR/KierunekKsztalceniaSzkolyZawodowe.md) |
| KompetencjaMerytoryczna | `ZklKmpMery` | konfig | root | [HR/KompetencjaMerytoryczna.md](HR/KompetencjaMerytoryczna.md) |
| KompetencjaUniwersalna | `ZklKmpUniw` | konfig | root | [HR/KompetencjaUniwersalna.md](HR/KompetencjaUniwersalna.md) |
| KryteriumAnalityczne | `ZklKrytAnality` | konfig | root | [HR/KryteriumAnalityczne.md](HR/KryteriumAnalityczne.md) |
| KryteriumSyntetyczne | `ZklKrytSynt` | konfig | root | [HR/KryteriumSyntetyczne.md](HR/KryteriumSyntetyczne.md) |
| KsuDefinicjaInfo | `ZklKsuDefInfo` | konfig | root | [HR/KsuDefinicjaInfo.md](HR/KsuDefinicjaInfo.md) |
| KsuGrupaStanowisk | `ZklKsuGrStan` | konfig | root | [HR/KsuGrupaStanowisk.md](HR/KsuGrupaStanowisk.md) |
| KsuObszarFunkcjonalny | `ZklKsuObszFun` | konfig | root | [HR/KsuObszarFunkcjonalny.md](HR/KsuObszarFunkcjonalny.md) |
| KsuSzkoleniePoprzedzajace | `ZklKsuSzkPop` | konfig | root | [HR/KsuSzkoleniePoprzedzajace.md](HR/KsuSzkoleniePoprzedzajace.md) |
| KsuUprawnieniePoprzedzajace | `ZklKsuUprPop` | konfig | root | [HR/KsuUprawnieniePoprzedzajace.md](HR/KsuUprawnieniePoprzedzajace.md) |
| KwalifikacjePracownikaZkl | `ZKLKwalPrac` |  | child: Pracownik→Pracownik | [HR/KwalifikacjePracownikaZkl.md](HR/KwalifikacjePracownikaZkl.md) |
| MacierzWartosciowania | `ZklWrtMacierz` |  |  | [HR/MacierzWartosciowania.md](HR/MacierzWartosciowania.md) |
| MnoznikMacierzyWartosciowania | `ZklWrtMxMnozniki` |  |  | [HR/MnoznikMacierzyWartosciowania.md](HR/MnoznikMacierzyWartosciowania.md) |
| ObslugaMaszynIUrzadzen | `ZklObsMaszUrz` | konfig | root | [HR/ObslugaMaszynIUrzadzen.md](HR/ObslugaMaszynIUrzadzen.md) |
| ObszarFunkcjonalny | `ZklObszrFunk` | konfig | root | [HR/ObszarFunkcjonalny.md](HR/ObszarFunkcjonalny.md) |
| ObszarOdpowiedzialnosciPracownikaZkl | `ZklObszOdpPrac` |  | child: Pracownik→Pracownik | [HR/ObszarOdpowiedzialnosciPracownikaZkl.md](HR/ObszarOdpowiedzialnosciPracownikaZkl.md) |
| ObszarOdpowiedzialnosciStanowiska | `ZklObszOdp` | konfig | child: Stanowisko→DefinicjaStanowiska | [HR/ObszarOdpowiedzialnosciStanowiska.md](HR/ObszarOdpowiedzialnosciStanowiska.md) |
| OcenaPracownika | `OcenyPracownikow` |  | root | [HR/OcenaPracownika.md](HR/OcenaPracownika.md) |
| Odpowiedzialnosc | `ZklKtgOdp` | konfig | root | [HR/Odpowiedzialnosc.md](HR/Odpowiedzialnosc.md) |
| OfertaSzkolenia | `OfertySzkolen` |  | root | [HR/OfertaSzkolenia.md](HR/OfertaSzkolenia.md) |
| OkresDoswiadczeniaZawodowego | `ZklOkrDosZwd` | konfig | root | [HR/OkresDoswiadczeniaZawodowego.md](HR/OkresDoswiadczeniaZawodowego.md) |
| PowiazanieDefStanSlownikiZkl | `PowDefStZklSlw` | konfig | root | [HR/PowiazanieDefStanSlownikiZkl.md](HR/PowiazanieDefStanSlownikiZkl.md) |
| PowiazanieDefinicjiStanowisk | `PowDefStan` | konfig | root | [HR/PowiazanieDefinicjiStanowisk.md](HR/PowiazanieDefinicjiStanowisk.md) |
| PoziomRozwojuKompetencjiMerytorycznych | `ZklPozRozKomMer` | konfig | root | [HR/PoziomRozwojuKompetencjiMerytorycznych.md](HR/PoziomRozwojuKompetencjiMerytorycznych.md) |
| PoziomRozwojuKompetencjiUniwersalnych | `ZklPozRozKomUni` | konfig | root | [HR/PoziomRozwojuKompetencjiUniwersalnych.md](HR/PoziomRozwojuKompetencjiUniwersalnych.md) |
| PoziomUmiejetnosci | `ZklPozUmiejet` | konfig | root | [HR/PoziomUmiejetnosci.md](HR/PoziomUmiejetnosci.md) |
| PoziomWyksztalcenia | `ZklPozWykszt` | konfig | root | [HR/PoziomWyksztalcenia.md](HR/PoziomWyksztalcenia.md) |
| PozycjaDokumentuPlanowaniaZasobow | `PozDokPlanZasob` |  | child: Dokument→DokumentPlanowaniaZasobow | [HR/PozycjaDokumentuPlanowaniaZasobow.md](HR/PozycjaDokumentuPlanowaniaZasobow.md) |
| PozycjaDoswiadczeniaProfiluGrupa | `ZklPozKwalDosGr` | konfig | root | [HR/PozycjaDoswiadczeniaProfiluGrupa.md](HR/PozycjaDoswiadczeniaProfiluGrupa.md) |
| PozycjaDoswiadczeniaProfiluObszar | `ZklPozKwalDosOb` | konfig | root | [HR/PozycjaDoswiadczeniaProfiluObszar.md](HR/PozycjaDoswiadczeniaProfiluObszar.md) |
| PozycjaJezykaProfiluTypPotwier | `ZklPozKwalJezTP` | konfig | root | [HR/PozycjaJezykaProfiluTypPotwier.md](HR/PozycjaJezykaProfiluTypPotwier.md) |
| PozycjaJezykowObcychProfilu | `ZklPozKwalJezyki` | konfig | root | [HR/PozycjaJezykowObcychProfilu.md](HR/PozycjaJezykowObcychProfilu.md) |
| PozycjaKwalifikacjiProfiluTypPotwier | `ZklPozKwalKwalTP` | konfig | root | [HR/PozycjaKwalifikacjiProfiluTypPotwier.md](HR/PozycjaKwalifikacjiProfiluTypPotwier.md) |
| PozycjaKwalifikacjiZawodowychProfilu | `ZklPozKwalKwal` | konfig | root | [HR/PozycjaKwalifikacjiZawodowychProfilu.md](HR/PozycjaKwalifikacjiZawodowychProfilu.md) |
| PozycjaMaszynIUrzadzenProfilu | `ZklPozKwalMaszyn` | konfig | root | [HR/PozycjaMaszynIUrzadzenProfilu.md](HR/PozycjaMaszynIUrzadzenProfilu.md) |
| PozycjaMaszynyProfiluTypPotwier | `ZklPozKwalMszTP` | konfig | root | [HR/PozycjaMaszynyProfiluTypPotwier.md](HR/PozycjaMaszynyProfiluTypPotwier.md) |
| PozycjaProfiluKompetencjiMerytorycznych | `ZklPozProfilKKM` | konfig | root | [HR/PozycjaProfiluKompetencjiMerytorycznych.md](HR/PozycjaProfiluKompetencjiMerytorycznych.md) |
| PozycjaProfiluKompetencjiUniwersalnych | `ZklPozProfilKKU` | konfig | root | [HR/PozycjaProfiluKompetencjiUniwersalnych.md](HR/PozycjaProfiluKompetencjiUniwersalnych.md) |
| PozycjaProfiluZadaniowego | `ZklPozProfilZdn` | konfig | root | [HR/PozycjaProfiluZadaniowego.md](HR/PozycjaProfiluZadaniowego.md) |
| PozycjaSystemowITProfilu | `ZklPozKwalIT` | konfig | root | [HR/PozycjaSystemowITProfilu.md](HR/PozycjaSystemowITProfilu.md) |
| PozycjaSystemuITProfiluTypPotwier | `ZklPozKwalITTP` | konfig | root | [HR/PozycjaSystemuITProfiluTypPotwier.md](HR/PozycjaSystemuITProfiluTypPotwier.md) |
| PozycjaSzkolenIUprawnienProfilu | `ZklPozSzkUpr` | konfig | root | [HR/PozycjaSzkolenIUprawnienProfilu.md](HR/PozycjaSzkolenIUprawnienProfilu.md) |
| PozycjaWyksztalceniaProfilu | `ZklPozKwalWykszt` | konfig | root | [HR/PozycjaWyksztalceniaProfilu.md](HR/PozycjaWyksztalceniaProfilu.md) |
| PozycjaWyszukania | `PozycjeWyszukan` |  | child: Wyszukanie→Wyszukanie | [HR/PozycjaWyszukania.md](HR/PozycjaWyszukania.md) |
| ProfilKompetencjiMerytorycznych | `ZklProfilKKM` | konfig | root | [HR/ProfilKompetencjiMerytorycznych.md](HR/ProfilKompetencjiMerytorycznych.md) |
| ProfilKompetencjiUniwersalnych | `ZklProfilKKU` | konfig | root | [HR/ProfilKompetencjiUniwersalnych.md](HR/ProfilKompetencjiUniwersalnych.md) |
| ProfilKwalifikacyjny | `ZklProfilKwal` | konfig | root | [HR/ProfilKwalifikacyjny.md](HR/ProfilKwalifikacyjny.md) |
| ProfilSzkolenIUprawnien | `ZklProfilSzkUpr` | konfig | root | [HR/ProfilSzkolenIUprawnien.md](HR/ProfilSzkolenIUprawnien.md) |
| ProfilZadaniowy | `ZklProfilZdn` | konfig | root | [HR/ProfilZadaniowy.md](HR/ProfilZadaniowy.md) |
| PunktyMacierzyWartosciowania | `ZklWrtMxPunkty` |  |  | [HR/PunktyMacierzyWartosciowania.md](HR/PunktyMacierzyWartosciowania.md) |
| RealizacjaSzkolenia | `RealizSzkolen` |  | root | [HR/RealizacjaSzkolenia.md](HR/RealizacjaSzkolenia.md) |
| Rekrutacja | `Rekrutacje` |  | root | [HR/Rekrutacja.md](HR/Rekrutacja.md) |
| StopienOdpowiedzialnosci | `ZklStopOdp` | konfig | root | [HR/StopienOdpowiedzialnosci.md](HR/StopienOdpowiedzialnosci.md) |
| SystemITJezykProgramowania | `ZklSystITProg` | konfig | root | [HR/SystemITJezykProgramowania.md](HR/SystemITJezykProgramowania.md) |
| SzkolenieBHPDefinicjiStanowiska | `SzkolBHPDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska | [HR/SzkolenieBHPDefinicjiStanowiska.md](HR/SzkolenieBHPDefinicjiStanowiska.md) |
| TypPotwierdzenia | `ZklTypPotwier` | konfig | root | [HR/TypPotwierdzenia.md](HR/TypPotwierdzenia.md) |
| TytulZawodowyStopienNaukowy | `ZklTytZwdStNauk` | konfig | root | [HR/TytulZawodowyStopienNaukowy.md](HR/TytulZawodowyStopienNaukowy.md) |
| UkończoneSzkolenie | `UkonczSzkolenia` |  | root | [HR/UkończoneSzkolenie.md](HR/UkończoneSzkolenie.md) |
| UprawnienieDefinicjiStanowiska | `UprawnDefStan` |  | child: DefinicjaStanowiska→DefinicjaStanowiska | [HR/UprawnienieDefinicjiStanowiska.md](HR/UprawnienieDefinicjiStanowiska.md) |
| UprawnienieDefinicjiSzkolenia | `UprawnDefSzkol` |  | child: DefinicjaSzkolenia→DefinicjaSzkolenia | [HR/UprawnienieDefinicjiSzkolenia.md](HR/UprawnienieDefinicjiSzkolenia.md) |
| UprawnieniePracownika | `UprawnieniaPrac` |  | root | [HR/UprawnieniePracownika.md](HR/UprawnieniePracownika.md) |
| WartosciowanieStanowiska | `ZklWartStanow` |  |  | [HR/WartosciowanieStanowiska.md](HR/WartosciowanieStanowiska.md) |
| WartośćElementuOcenyPracownika | `WartElemOcenPrac` | konfig | child: Definicja→DefElementuOcenyPracownika | [HR/WartośćElementuOcenyPracownika.md](HR/WartośćElementuOcenyPracownika.md) |
| WniosekOSzkolenie | `WnioskiOSzkol` |  | root | [HR/WniosekOSzkolenie.md](HR/WniosekOSzkolenie.md) |
| WspolpracaWewnetrznaJednostkiDefStan | `WspWeJnDefSt` | konfig | root | [HR/WspolpracaWewnetrznaJednostkiDefStan.md](HR/WspolpracaWewnetrznaJednostkiDefStan.md) |
| WydziałDefinicjiStanowiska | `WydzialyDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska | [HR/WydziałDefinicjiStanowiska.md](HR/WydziałDefinicjiStanowiska.md) |
| WynikPozycjiWartosciowania | `ZklWynikPozWart` |  |  | [HR/WynikPozycjiWartosciowania.md](HR/WynikPozycjiWartosciowania.md) |
| WyposazenieStanowiska | `ZklWypStanow` | konfig | root | [HR/WyposazenieStanowiska.md](HR/WyposazenieStanowiska.md) |
| Wysilek | `ZklWysilek` | konfig | root | [HR/Wysilek.md](HR/Wysilek.md) |
| Wyszukanie | `Wyszukania` |  | root | [HR/Wyszukanie.md](HR/Wyszukanie.md) |
| WzorOcenyPracownika | `WzoryOcenPrac` | konfig | root | [HR/WzorOcenyPracownika.md](HR/WzorOcenyPracownika.md) |
| ZadanieZkl | `ZklZadania` | konfig | root | [HR/ZadanieZkl.md](HR/ZadanieZkl.md) |

## HR2

- Opis: Rozszerzenie modułu HR o dodatkowe funkcjonalności. Zawiera zaawansowane mechanizmy zarządzania kompetencjami, celami, ocenami okresowymi i rozwojem pracowników.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| CelOkresowyPracownika | `CeleOkresowePrac` |  | root | [HR2/CelOkresowyPracownika.md](HR2/CelOkresowyPracownika.md) |
| DefinicjaElementuOpisuStanowiska | `DefElOpisuStanow` | konfig | root | [HR2/DefinicjaElementuOpisuStanowiska.md](HR2/DefinicjaElementuOpisuStanowiska.md) |
| ElementKartyOpisuStanowiska | `ElementyKOS` |  | child: Karta→KartaOpisuStanowiskaBase | [HR2/ElementKartyOpisuStanowiska.md](HR2/ElementKartyOpisuStanowiska.md) |
| ElementWynagDod | `ElementyWynagDod` | konfig | child: Stanowisko→DefinicjaStanowiskaHist | [HR2/ElementWynagDod.md](HR2/ElementWynagDod.md) |
| KartaKompetencjiPracownika | `KartyKompPrac` |  | root | [HR2/KartaKompetencjiPracownika.md](HR2/KartaKompetencjiPracownika.md) |
| KartaOpisuStanowiskaBase | `KartyOpStanowisk` |  | root | [HR2/KartaOpisuStanowiskaBase.md](HR2/KartaOpisuStanowiskaBase.md) |
| KartaRealizacjiCelu | `KartyReazCelPrac` |  | root | [HR2/KartaRealizacjiCelu.md](HR2/KartaRealizacjiCelu.md) |
| KategoriaElementuOpisuStanowiska | `KatElOpisuStanow` | konfig | root | [HR2/KategoriaElementuOpisuStanowiska.md](HR2/KategoriaElementuOpisuStanowiska.md) |
| KompetencjaKartyOpisuStanowiska | `KompetencjeKOS` |  | child: Karta→KartaOpisuStanowiskaBase | [HR2/KompetencjaKartyOpisuStanowiska.md](HR2/KompetencjaKartyOpisuStanowiska.md) |
| KompetencjaPracownika | `KompetencjePrac` |  | child: Karta→KartaKompetencjiPracownika | [HR2/KompetencjaPracownika.md](HR2/KompetencjaPracownika.md) |
| OfertaPracy | `OfertyPracy` |  |  | [HR2/OfertaPracy.md](HR2/OfertaPracy.md) |
| RealizacjaCelu | `RealizacjeCelPrc` |  | child: Karta→KartaRealizacjiCelu | [HR2/RealizacjaCelu.md](HR2/RealizacjaCelu.md) |
| RekrutacjaAplikacja | `RekrutAplikacje` |  | root | [HR2/RekrutacjaAplikacja.md](HR2/RekrutacjaAplikacja.md) |
| RekrutacjaWakat | `RekrutWakaty` |  | root | [HR2/RekrutacjaWakat.md](HR2/RekrutacjaWakat.md) |

## Handel

- Opis: Moduł handlowy obsługujący dokumenty sprzedaży, zakupu, zamówień i innych operacji handlowych. Zawiera definicje dokumentów, relacje między dokumentami, pozycje dokumentów, sumy VAT, rozliczenia oraz mechanizmy fiskalizacji i EDI.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| DaneBDO | `DaneDokBDO` |  |  | [Handel/DaneBDO.md](Handel/DaneBDO.md) |
| DaneEParagonu | `DaneEParagony` |  |  | [Handel/DaneEParagonu.md](Handel/DaneEParagonu.md) |
| DaneEUDR | `DanePozEUDR` |  |  | [Handel/DaneEUDR.md](Handel/DaneEUDR.md) |
| DaneTaxFree | `DaneDokTaxFree` |  |  | [Handel/DaneTaxFree.md](Handel/DaneTaxFree.md) |
| DefDokHandlowego | `DefDokHandlowych` | konfig | root | [Handel/DefDokHandlowego.md](Handel/DefDokHandlowego.md) |
| DefDokPodrzednego | `DefDokPodrzedne` | konfig | child: Definicja→DefRelacjiHandlowej | [Handel/DefDokPodrzednego.md](Handel/DefDokPodrzednego.md) |
| DefRelacjiHandlowej | `DefRelHandlowych` | konfig | root | [Handel/DefRelacjiHandlowej.md](Handel/DefRelacjiHandlowej.md) |
| DefUrzadzeniaUz | `DefUrzadzenUz` | konfig | root | [Handel/DefUrzadzeniaUz.md](Handel/DefUrzadzeniaUz.md) |
| DokumentHandlowy | `DokHandlowe` |  | root | [Handel/DokumentHandlowy.md](Handel/DokumentHandlowy.md) |
| DokumentHandlowyKoszt | `DokHandloweKoszt` |  |  | [Handel/DokumentHandlowyKoszt.md](Handel/DokumentHandlowyKoszt.md) |
| DrukarkaFiskalna | `DrukarkiFiskalne` | konfig | root | [Handel/DrukarkaFiskalna.md](Handel/DrukarkaFiskalna.md) |
| DrukarkaFiskalnaStanowisko | `DrukFiskStan` | konfig |  | [Handel/DrukarkaFiskalnaStanowisko.md](Handel/DrukarkaFiskalnaStanowisko.md) |
| ElemRozliczenia | `ElemyRozliczenia` |  | child: Pozycja→PozycjaDokHandlowego | [Handel/ElemRozliczenia.md](Handel/ElemRozliczenia.md) |
| KSeFPozycjaDokHan | `KSeFPozDokHan` |  | child: Pozycja→PozycjaDokHandlowego | [Handel/KSeFPozycjaDokHan.md](Handel/KSeFPozycjaDokHan.md) |
| KontrahentKomunikatEDI | `KontrahKonEDI` |  |  | [Handel/KontrahentKomunikatEDI.md](Handel/KontrahentKomunikatEDI.md) |
| LimitWartosci | `LimityWartosci` |  | child: Definicja→DefDokHandlowego | [Handel/LimitWartosci.md](Handel/LimitWartosci.md) |
| MagDefDokRight | `MagDefDokRights` | konfig | child: Magazyn→Magazyn | [Handel/MagDefDokRight.md](Handel/MagDefDokRight.md) |
| OkresZawieszenia | `OkresyZawiesz` |  | child: Dokument→DokumentHandlowy | [Handel/OkresZawieszenia.md](Handel/OkresZawieszenia.md) |
| Paczka | `Paczki` |  |  | [Handel/Paczka.md](Handel/Paczka.md) |
| PaczkaWzorcowa | `PaczkiWzorcowe` |  | root | [Handel/PaczkaWzorcowa.md](Handel/PaczkaWzorcowa.md) |
| PozHanTimeTrack | `PozHanTimeTracks` |  |  | [Handel/PozHanTimeTrack.md](Handel/PozHanTimeTrack.md) |
| PozycjaDokHanCenaInfo | `PozHanCenaInfo` |  | child: Pozycja→PozycjaDokHandlowego | [Handel/PozycjaDokHanCenaInfo.md](Handel/PozycjaDokHanCenaInfo.md) |
| PozycjaDokHanRabatInfo | `PozHanRabatInfo` |  | child: Pozycja→PozycjaDokHandlowego | [Handel/PozycjaDokHanRabatInfo.md](Handel/PozycjaDokHanRabatInfo.md) |
| PozycjaDokHandlowego | `PozycjeDokHan` |  | child: Dokument→DokumentHandlowy | [Handel/PozycjaDokHandlowego.md](Handel/PozycjaDokHandlowego.md) |
| PozycjaDokHandlowegoLimit | `PozDoHandLimity` |  | root | [Handel/PozycjaDokHandlowegoLimit.md](Handel/PozycjaDokHandlowegoLimit.md) |
| PozycjaDokHandlowegoLimitHost | `PozDoHaLiHosts` |  | child: Host→ILimitHost | [Handel/PozycjaDokHandlowegoLimitHost.md](Handel/PozycjaDokHandlowegoLimitHost.md) |
| PozycjaRelacjiHandlowej | `PozRelHandlowej` |  | child: Relacja→RelacjaHandlowa | [Handel/PozycjaRelacjiHandlowej.md](Handel/PozycjaRelacjiHandlowej.md) |
| ProgRabatowy | `ProgiRabatowe` |  |  | [Handel/ProgRabatowy.md](Handel/ProgRabatowy.md) |
| PrzesylkaDokRel | `PrzesylkiDokRel` |  |  | [Handel/PrzesylkaDokRel.md](Handel/PrzesylkaDokRel.md) |
| PrzesylkaSpedyt | `PrzesylkiSpedyt` |  | root | [Handel/PrzesylkaSpedyt.md](Handel/PrzesylkaSpedyt.md) |
| PulpitHost | `PulpityHost` |  |  | [Handel/PulpitHost.md](Handel/PulpitHost.md) |
| RelacjaGrupyDostaw | `RelacjeGrupDostw` |  |  | [Handel/RelacjaGrupyDostaw.md](Handel/RelacjaGrupyDostaw.md) |
| RelacjaHandlowa | `RelacjeHandlowe` |  | root | [Handel/RelacjaHandlowa.md](Handel/RelacjaHandlowa.md) |
| RelacjaInnaPlat | `RelacjeInnaPlat` |  |  | [Handel/RelacjaInnaPlat.md](Handel/RelacjaInnaPlat.md) |
| RelacjaZaliczki | `RelacjeZaliczek` |  |  | [Handel/RelacjaZaliczki.md](Handel/RelacjaZaliczki.md) |
| SumaVAT | `SumyVAT` |  | child: Dokument→DokumentHandlowy | [Handel/SumaVAT.md](Handel/SumaVAT.md) |
| UrzadzenieUz | `UrzadzeniaUz` |  | root | [Handel/UrzadzenieUz.md](Handel/UrzadzenieUz.md) |
| UslDodPrzesyl | `UslDodPrzesylek` |  |  | [Handel/UslDodPrzesyl.md](Handel/UslDodPrzesyl.md) |

## Import

- Opis: Moduł importu danych do księgowości. Zawiera definicje importu dokumentów z zewnętrznych systemów finansowo-księgowych.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| KwotySad | `KwotySadow` |  | child: Ewidencja→DokEwidencji | [Import/KwotySad.md](Import/KwotySad.md) |

## Kadry

- Opis: Moduł kadrowy obsługujący dane pracowników. Zawiera kartoteki pracowników, umowy o pracę, historię zatrudnienia, nieobecności, badania lekarskie, szkolenia BHP oraz dane ubezpieczeniowe.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| Akord | `Akordy` |  | root | [Kadry/Akord.md](Kadry/Akord.md) |
| AkordHistoria | `AkordHistorie` |  | child: Akord→Akord | [Kadry/AkordHistoria.md](Kadry/AkordHistoria.md) |
| AlgorytmRatyPożyczki | `AlgRatPozyczek` | konfig | root | [Kadry/AlgorytmRatyPożyczki.md](Kadry/AlgorytmRatyPożyczki.md) |
| BadanieLekarskie | `BadaniaLekarskie` |  | root | [Kadry/BadanieLekarskie.md](Kadry/BadanieLekarskie.md) |
| BlokadaPracownika | `BlokadyPrac` |  |  | [Kadry/BlokadaPracownika.md](Kadry/BlokadaPracownika.md) |
| BoRIAOświata | `BosRIAOswiata` |  | root | [Kadry/BoRIAOświata.md](Kadry/BoRIAOświata.md) |
| BoRIAWarunkiSzczególne | `BosRIAWarSzczeg` |  | root | [Kadry/BoRIAWarunkiSzczególne.md](Kadry/BoRIAWarunkiSzczególne.md) |
| BoRIAWynagrodzenia | `BosRIAWynagrodz` |  | root | [Kadry/BoRIAWynagrodzenia.md](Kadry/BoRIAWynagrodzenia.md) |
| CzlonekRodziny | `Rodzina` |  | root | [Kadry/CzlonekRodziny.md](Kadry/CzlonekRodziny.md) |
| CzynnikSzkodliwyPracownika | `CzynnSzkodPrac` |  | root | [Kadry/CzynnikSzkodliwyPracownika.md](Kadry/CzynnikSzkodliwyPracownika.md) |
| DefPodstawyStazu | `DefPodstawStazu` | konfig | root | [Kadry/DefPodstawyStazu.md](Kadry/DefPodstawyStazu.md) |
| DefinicjaAkordu | `DefinicjeAkordow` | konfig | root | [Kadry/DefinicjaAkordu.md](Kadry/DefinicjaAkordu.md) |
| DefinicjaBadaniaLekarskiego | `DefBadanLek` | konfig | root | [Kadry/DefinicjaBadaniaLekarskiego.md](Kadry/DefinicjaBadaniaLekarskiego.md) |
| DefinicjaCzynnikowSzkodliwych | `DefCzynnSzkod` | konfig | root | [Kadry/DefinicjaCzynnikowSzkodliwych.md](Kadry/DefinicjaCzynnikowSzkodliwych.md) |
| DefinicjaFunduszuPozyczkowego | `DefFundPozycz` | konfig | root | [Kadry/DefinicjaFunduszuPozyczkowego.md](Kadry/DefinicjaFunduszuPozyczkowego.md) |
| DefinicjaJęzykaObcego | `DefJezykowObcych` | konfig | root | [Kadry/DefinicjaJęzykaObcego.md](Kadry/DefinicjaJęzykaObcego.md) |
| DefinicjaNagrodyKary | `DefNagrodKar` | konfig | root | [Kadry/DefinicjaNagrodyKary.md](Kadry/DefinicjaNagrodyKary.md) |
| DefinicjaOświadczenia | `DefOswiadczen` | konfig | root | [Kadry/DefinicjaOświadczenia.md](Kadry/DefinicjaOświadczenia.md) |
| DefinicjaStopiaZnajomościJęzykaObcego | `DefStZnJObcych` | konfig | root | [Kadry/DefinicjaStopiaZnajomościJęzykaObcego.md](Kadry/DefinicjaStopiaZnajomościJęzykaObcego.md) |
| DefinicjaSzkoleniaBHP | `DefSzkolenBHP` | konfig | root | [Kadry/DefinicjaSzkoleniaBHP.md](Kadry/DefinicjaSzkoleniaBHP.md) |
| DefinicjaWydziału | `DefWydzialow` | konfig | root | [Kadry/DefinicjaWydziału.md](Kadry/DefinicjaWydziału.md) |
| DefinicjaŚwiadczeniaSocjalnego | `DefSwiadczSocjal` | konfig | root | [Kadry/DefinicjaŚwiadczeniaSocjalnego.md](Kadry/DefinicjaŚwiadczeniaSocjalnego.md) |
| DodHistoria | `DodHistorie` |  | child: Dodatek→Dodatek | [Kadry/DodHistoria.md](Kadry/DodHistoria.md) |
| Dodatek | `Dodatki` |  | root | [Kadry/Dodatek.md](Kadry/Dodatek.md) |
| ElementZestawuDodatków | `ElementyZestDod` | konfig | child: Zestaw→ZestawDodatków | [Kadry/ElementZestawuDodatków.md](Kadry/ElementZestawuDodatków.md) |
| FormaOrganizacjiPracy | `FormyOrgPracy` | konfig | root | [Kadry/FormaOrganizacjiPracy.md](Kadry/FormaOrganizacjiPracy.md) |
| FundPozyczkowy | `FundPozyczkowe` |  | root | [Kadry/FundPozyczkowy.md](Kadry/FundPozyczkowy.md) |
| GrupaZaszeregowania | `GrupyZaszer` | konfig | root | [Kadry/GrupaZaszeregowania.md](Kadry/GrupaZaszeregowania.md) |
| HistoriaDanychWydziału | `HstDanychWydzial` | konfig | child: Wydzial→Wydzial | [Kadry/HistoriaDanychWydziału.md](Kadry/HistoriaDanychWydziału.md) |
| HistoriaZatrudnieniaBase | `HistZatrudnien` |  | root | [Kadry/HistoriaZatrudnieniaBase.md](Kadry/HistoriaZatrudnieniaBase.md) |
| InformacjaDoRozliczenia | `InformacjeDoRozl` |  | root | [Kadry/InformacjaDoRozliczenia.md](Kadry/InformacjaDoRozliczenia.md) |
| InformacjeDoRozliczeniaHistoria | `InfoDoRozliHist` |  | child: InformacjaDoRozliczenia→InformacjaDoRozliczenia | [Kadry/InformacjeDoRozliczeniaHistoria.md](Kadry/InformacjeDoRozliczeniaHistoria.md) |
| InnyDochod | `InneDochody` |  | child: Pracownik→Pracownik | [Kadry/InnyDochod.md](Kadry/InnyDochod.md) |
| KanalZgloszeniaSygnalisty | `KanalyZglSygnal` | konfig | root | [Kadry/KanalZgloszeniaSygnalisty.md](Kadry/KanalZgloszeniaSygnalisty.md) |
| KartaRCP | `KartyRCP` |  | root | [Kadry/KartaRCP.md](Kadry/KartaRCP.md) |
| KategoriaCzynnikowSzkodliwych | `KatCzynnSzkod` | konfig | root | [Kadry/KategoriaCzynnikowSzkodliwych.md](Kadry/KategoriaCzynnikowSzkodliwych.md) |
| KategoriaZgloszeniaSygnalisty | `KatZglSygnal` | konfig | root | [Kadry/KategoriaZgloszeniaSygnalisty.md](Kadry/KategoriaZgloszeniaSygnalisty.md) |
| KodPracyWSzególnychWarunkachCharakterze | `KodyPracySzWaCha` | konfig | root | [Kadry/KodPracyWSzególnychWarunkachCharakterze.md](Kadry/KodPracyWSzególnychWarunkachCharakterze.md) |
| KodWykonywanegoZawodu | `KodyWykZawodow` | konfig | root | [Kadry/KodWykonywanegoZawodu.md](Kadry/KodWykonywanegoZawodu.md) |
| KorektaZajęciaKomorniczego | `KorektyZajKomor` |  | root | [Kadry/KorektaZajęciaKomorniczego.md](Kadry/KorektaZajęciaKomorniczego.md) |
| LokalizacjaPracyZdalnej | `LokPracZdalnej` |  | root | [Kadry/LokalizacjaPracyZdalnej.md](Kadry/LokalizacjaPracyZdalnej.md) |
| MetrykaWydziału | `MetrykiWydzialow` | konfig | child: Wydzial→Wydzial | [Kadry/MetrykaWydziału.md](Kadry/MetrykaWydziału.md) |
| NagrodaKara | `NagrodyKary` |  | root | [Kadry/NagrodaKara.md](Kadry/NagrodaKara.md) |
| OkresNiewliczany | `OkrNiewliczane` |  | child: Zatrudnienie→HistoriaZatrudnieniaBase | [Kadry/OkresNiewliczany.md](Kadry/OkresNiewliczany.md) |
| OkresWakacjiSkladki | `OkresyWakacjiSkladki` |  | child: Pracownik→Pracownik | [Kadry/OkresWakacjiSkladki.md](Kadry/OkresWakacjiSkladki.md) |
| OkresWykonywaniaPracyTymczasowej | `OkresyPracyTymcz` |  | child: Zatrudnienie→HistoriaZatrudnieniaBase | [Kadry/OkresWykonywaniaPracyTymczasowej.md](Kadry/OkresWykonywaniaPracyTymczasowej.md) |
| OświadczeniePracownika | `OswiadczeniaPrac` |  | root | [Kadry/OświadczeniePracownika.md](Kadry/OświadczeniePracownika.md) |
| PodstawaStazu | `PodstawyStazow` |  | root | [Kadry/PodstawaStazu.md](Kadry/PodstawaStazu.md) |
| Pozyczka | `Pozyczki` |  | root | [Kadry/Pozyczka.md](Kadry/Pozyczka.md) |
| PracDbTupleDefinitionExt | `PracTupleDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition | [Kadry/PracDbTupleDefinitionExt.md](Kadry/PracDbTupleDefinitionExt.md) |
| PracHistoria | `PracHistorie` |  | child: Pracownik→Pracownik | [Kadry/PracHistoria.md](Kadry/PracHistoria.md) |
| PracHistoria2 | `PracHistorie2` |  | child: Host→PracHistoria | [Kadry/PracHistoria2.md](Kadry/PracHistoria2.md) |
| Pracownik | `Pracownicy` |  | root | [Kadry/Pracownik.md](Kadry/Pracownik.md) |
| PracownikWArchiwum | `PracWArchiwum` |  | child: Pracownik→Pracownik | [Kadry/PracownikWArchiwum.md](Kadry/PracownikWArchiwum.md) |
| ProgAkordu | `ProgiAkordow` |  | child: Akord→IAkord | [Kadry/ProgAkordu.md](Kadry/ProgAkordu.md) |
| ProgPodatkowy | `ProgiPodatkowe` |  | child: Historia→PracHistoria | [Kadry/ProgPodatkowy.md](Kadry/ProgPodatkowy.md) |
| PrzetwarzanieZgloszeniaSygnalisty | `PrzetwarzZglSyg` |  | root | [Kadry/PrzetwarzanieZgloszeniaSygnalisty.md](Kadry/PrzetwarzanieZgloszeniaSygnalisty.md) |
| PrzychodRyczalt | `PrzychodyRyczalt` |  | child: Pracownik→Pracownik | [Kadry/PrzychodRyczalt.md](Kadry/PrzychodRyczalt.md) |
| PrzychodZDzialnosci | `PrzychodyZDzial` |  | child: Pracownik→Pracownik | [Kadry/PrzychodZDzialnosci.md](Kadry/PrzychodZDzialnosci.md) |
| PrzyczynaRozwUmowy | `PrzyczRozwUmow` | konfig | root | [Kadry/PrzyczynaRozwUmowy.md](Kadry/PrzyczynaRozwUmowy.md) |
| PrzyczynaZawUmowy | `PrzyczZawUmow` | konfig | root | [Kadry/PrzyczynaZawUmowy.md](Kadry/PrzyczynaZawUmowy.md) |
| RataPozyczki | `RatyPozyczek` |  | root | [Kadry/RataPozyczki.md](Kadry/RataPozyczki.md) |
| RelacjaWykonPrac | `RelacjeWykonPrac` |  | child: Pracownik→Pracownik | [Kadry/RelacjaWykonPrac.md](Kadry/RelacjaWykonPrac.md) |
| Schorzenie | `Schorzenia` |  | root | [Kadry/Schorzenie.md](Kadry/Schorzenie.md) |
| SwiadczSocjalne | `SwiadczeniaSoc` |  | root | [Kadry/SwiadczSocjalne.md](Kadry/SwiadczSocjalne.md) |
| SzkolenieBHP | `SzkoleniaBHP` |  | root | [Kadry/SzkolenieBHP.md](Kadry/SzkolenieBHP.md) |
| TreśćOświadczenia | `TresciOswiadczen` | konfig | child: Definicja→DefinicjaOświadczenia | [Kadry/TreśćOświadczenia.md](Kadry/TreśćOświadczenia.md) |
| TytulUbezpieczenia4 | `TytulyUbezpiecz4` | konfig | root | [Kadry/TytulUbezpieczenia4.md](Kadry/TytulUbezpieczenia4.md) |
| UlgaInnowacyjna | `UlgiInnowacyjne` |  | child: Pracownik→Pracownik | [Kadry/UlgaInnowacyjna.md](Kadry/UlgaInnowacyjna.md) |
| Umowa | `Umowy` |  | root | [Kadry/Umowa.md](Kadry/Umowa.md) |
| UmowaHistoria | `UmowaHistorie` |  | child: Umowa→Umowa | [Kadry/UmowaHistoria.md](Kadry/UmowaHistoria.md) |
| UmowaZewnetrzna | `UmowyZewnetrzne` |  | root | [Kadry/UmowaZewnetrzna.md](Kadry/UmowaZewnetrzna.md) |
| UmowaZewnetrznaHistoria | `UmowyZewnHist` |  | child: Umowa→UmowaZewnetrzna | [Kadry/UmowaZewnetrznaHistoria.md](Kadry/UmowaZewnetrznaHistoria.md) |
| WniosekUrlopowy | `WnioskiUrlopowe` |  | root | [Kadry/WniosekUrlopowy.md](Kadry/WniosekUrlopowy.md) |
| WniosekZwrotOplSkl | `WniosZwrotOplSkl` |  | root | [Kadry/WniosekZwrotOplSkl.md](Kadry/WniosekZwrotOplSkl.md) |
| Wydzial | `Wydzialy` | konfig | root | [Kadry/Wydzial.md](Kadry/Wydzial.md) |
| WydzialRef | `WydzialyRef` | konfig | child: Wydzial→Wydzial | [Kadry/WydzialRef.md](Kadry/WydzialRef.md) |
| WydziałDefFundPozy | `WydDefFundPozy` | konfig | child: DefinicjaFunduszuPozyczkowego→DefinicjaFunduszuPozyczkowego | [Kadry/WydziałDefFundPozy.md](Kadry/WydziałDefFundPozy.md) |
| Wypadek | `Wypadki` |  | root | [Kadry/Wypadek.md](Kadry/Wypadek.md) |
| ZajęcieKomornicze | `ZajKomornicze` |  | root | [Kadry/ZajęcieKomornicze.md](Kadry/ZajęcieKomornicze.md) |
| ZajęcieKomorniczeHistoria | `ZajKomorniczeHis` |  | child: Zajecie→ZajęcieKomornicze | [Kadry/ZajęcieKomorniczeHistoria.md](Kadry/ZajęcieKomorniczeHistoria.md) |
| ZbiegUbezpieczenia | `ZbiegiUbezpiecz` |  | child: Pracownik→Pracownik | [Kadry/ZbiegUbezpieczenia.md](Kadry/ZbiegUbezpieczenia.md) |
| ZestawDodatków | `ZestawyDodatkow` | konfig | root | [Kadry/ZestawDodatków.md](Kadry/ZestawDodatków.md) |
| ZgloszenieSygnalisty | `ZgloszSygnalisty` |  | root | [Kadry/ZgloszenieSygnalisty.md](Kadry/ZgloszenieSygnalisty.md) |
| ZgodaNaEdycję | `ZgodyNaEdycje` |  | root | [Kadry/ZgodaNaEdycję.md](Kadry/ZgodaNaEdycję.md) |
| ZmianaWkładuFunduszuPozyczkowego | `ZmianaWklFundPoz` |  | root | [Kadry/ZmianaWkładuFunduszuPozyczkowego.md](Kadry/ZmianaWkładuFunduszuPozyczkowego.md) |
| ZnajomośćJęzykaObcego | `ZnJezykowObcych` |  | child: Pracownik→Pracownik | [Kadry/ZnajomośćJęzykaObcego.md](Kadry/ZnajomośćJęzykaObcego.md) |
| ŻyrantPożyczki | `ZyranciPozyczek` |  | child: Pozyczka→Pozyczka | [Kadry/ŻyrantPożyczki.md](Kadry/ŻyrantPożyczki.md) |

## Kalend

- Opis: Moduł zarządzania czasem pracy. Zawiera kalendarze, definicje dni, strefy czasowe, harmonogramy pracy, reguły rozliczania czasu pracy oraz ewidencję obecności.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| CzynnoscNaObiekcieDoPlanowania | `CzynnObDoPlan` |  | root | [Kalend/CzynnoscNaObiekcieDoPlanowania.md](Kalend/CzynnoscNaObiekcieDoPlanowania.md) |
| CzytnikRCP | `CzytnikiRCP` | konfig | root | [Kalend/CzytnikRCP.md](Kalend/CzytnikRCP.md) |
| DefAlgorytmRCP | `DefAlgorytmyRCP` | konfig | root | [Kalend/DefAlgorytmRCP.md](Kalend/DefAlgorytmRCP.md) |
| DefinicjaAktualizacjiKalendarza | `DefAktKalendarzy` | konfig | root | [Kalend/DefinicjaAktualizacjiKalendarza.md](Kalend/DefinicjaAktualizacjiKalendarza.md) |
| DefinicjaCzynnosciNaObiekcie | `DefCzynnOb` | konfig | root | [Kalend/DefinicjaCzynnosciNaObiekcie.md](Kalend/DefinicjaCzynnosciNaObiekcie.md) |
| DefinicjaDnia | `DefinicjeDni` | konfig | root | [Kalend/DefinicjaDnia.md](Kalend/DefinicjaDnia.md) |
| DefinicjaGrafikaPracy | `DefGrafikowPracy` | konfig | root | [Kalend/DefinicjaGrafikaPracy.md](Kalend/DefinicjaGrafikaPracy.md) |
| DefinicjaLimitu | `DefinicjeLimitow` | konfig | root | [Kalend/DefinicjaLimitu.md](Kalend/DefinicjaLimitu.md) |
| DefinicjaNieobecnosci | `DefNieobecnosci` | konfig | root | [Kalend/DefinicjaNieobecnosci.md](Kalend/DefinicjaNieobecnosci.md) |
| DefinicjaRodzajuPracyZdalnej | `DefRodzPracZdal` | konfig | root | [Kalend/DefinicjaRodzajuPracyZdalnej.md](Kalend/DefinicjaRodzajuPracyZdalnej.md) |
| DefinicjaRozliczeniaCzasuPracy | `DefRozlCzasPracy` | konfig | root | [Kalend/DefinicjaRozliczeniaCzasuPracy.md](Kalend/DefinicjaRozliczeniaCzasuPracy.md) |
| DefinicjaStrefy | `DefinicjeStref` | konfig | root | [Kalend/DefinicjaStrefy.md](Kalend/DefinicjaStrefy.md) |
| DefinicjaWeryfikatoraKalendarza | `DefWeryfKalend` | konfig | root | [Kalend/DefinicjaWeryfikatoraKalendarza.md](Kalend/DefinicjaWeryfikatoraKalendarza.md) |
| DefinicjaWeryfikatoraRozliczeniaCzasuPracy | `DefWerRozCzas` | konfig | root | [Kalend/DefinicjaWeryfikatoraRozliczeniaCzasuPracy.md](Kalend/DefinicjaWeryfikatoraRozliczeniaCzasuPracy.md) |
| DefinicjaZdarzeniaRCP | `DefZdarzenRCP` |  | root | [Kalend/DefinicjaZdarzeniaRCP.md](Kalend/DefinicjaZdarzeniaRCP.md) |
| DefinicjaZestawieniaCzasu | `DefZestawCzasu` | konfig | root | [Kalend/DefinicjaZestawieniaCzasu.md](Kalend/DefinicjaZestawieniaCzasu.md) |
| DokumentAktualizacjiKalendarza | `DokAktKalendarzy` |  | root | [Kalend/DokumentAktualizacjiKalendarza.md](Kalend/DokumentAktualizacjiKalendarza.md) |
| DzienAkorduBase | `DniAkordow` |  | child: Akord→Akord | [Kalend/DzienAkorduBase.md](Kalend/DzienAkorduBase.md) |
| DzienKalendarzaAktualizacja | `DniKalendAkt` |  | child: Pozycja→PozycjaAktualizacjiKalendarza | [Kalend/DzienKalendarzaAktualizacja.md](Kalend/DzienKalendarzaAktualizacja.md) |
| DzienKalendarzaBase | `DniKalendarza` |  | child: Kalendarz→KalendarzBase | [Kalend/DzienKalendarzaBase.md](Kalend/DzienKalendarzaBase.md) |
| DzienKalendarzaHistoria | `DniKalendHist` |  | child: DokumentAktualizacji→IDokumentAktualizacjiKalendarza | [Kalend/DzienKalendarzaHistoria.md](Kalend/DzienKalendarzaHistoria.md) |
| DzienPracy | `DniPracy` |  | child: Pracownik→Pracownik | [Kalend/DzienPracy.md](Kalend/DzienPracy.md) |
| DzienPracyAktualizacja | `DniPracyAkt` |  | child: Pozycja→PozycjaAktualizacjiCzasu | [Kalend/DzienPracyAktualizacja.md](Kalend/DzienPracyAktualizacja.md) |
| DzienPracyHistoria | `DniPracyHist` |  | child: DokumentAktualizacji→IDokumentAktualizacjiKalendarza | [Kalend/DzienPracyHistoria.md](Kalend/DzienPracyHistoria.md) |
| DzienPracyUmowy | `DniPracyUmowy` |  | child: Umowa→IUmowaZKalendarzem | [Kalend/DzienPracyUmowy.md](Kalend/DzienPracyUmowy.md) |
| DzienRCP | `DniRCP` |  | child: Pracownik→Pracownik | [Kalend/DzienRCP.md](Kalend/DzienRCP.md) |
| ElementRozliczeniaCzasuPracy | `ElRozlCzasPracy` |  | root | [Kalend/ElementRozliczeniaCzasuPracy.md](Kalend/ElementRozliczeniaCzasuPracy.md) |
| GrafikPracownika | `GrafPracownikow` |  |  | [Kalend/GrafikPracownika.md](Kalend/GrafikPracownika.md) |
| GrafikPracy | `GrafikiPracy` |  | root | [Kalend/GrafikPracy.md](Kalend/GrafikPracy.md) |
| KalendarzBase | `Kalendarze` |  | root | [Kalend/KalendarzBase.md](Kalend/KalendarzBase.md) |
| KodZdarzeniaRCP | `KodyZdarzenRCP` | konfig | child: CzytnikRCP→CzytnikRCP | [Kalend/KodZdarzeniaRCP.md](Kalend/KodZdarzeniaRCP.md) |
| KolorElementu | `KoloryElementow` | konfig | child: Zrodlo→IŹródłoKoloruElementu | [Kalend/KolorElementu.md](Kalend/KolorElementu.md) |
| LimitNieobecnosci | `LimNieobecnosci` |  | child: Pracownik→Pracownik | [Kalend/LimitNieobecnosci.md](Kalend/LimitNieobecnosci.md) |
| Nieobecnosc | `Nieobecnosci` |  | root | [Kalend/Nieobecnosc.md](Kalend/Nieobecnosc.md) |
| NieobecnośćIdx | `NieobecnosciIdx` |  |  | [Kalend/NieobecnośćIdx.md](Kalend/NieobecnośćIdx.md) |
| ObiektAktualizacjiKalendarza | `ObAktKalend` |  |  | [Kalend/ObiektAktualizacjiKalendarza.md](Kalend/ObiektAktualizacjiKalendarza.md) |
| ObiektDoPlanowania | `ObiektyDoPlan` |  | root | [Kalend/ObiektDoPlanowania.md](Kalend/ObiektDoPlanowania.md) |
| ObrotRN | `ObrotyRN` |  | child: StrefaNadgodziny→StrefaPracy | [Kalend/ObrotRN.md](Kalend/ObrotRN.md) |
| PUEDokumentEZLA | `PUEDokEZLA` |  | child: Raport→PUERaportNieobecnosci | [Kalend/PUEDokumentEZLA.md](Kalend/PUEDokumentEZLA.md) |
| PUERaportNieobecnosci | `PUERptNb` |  | root | [Kalend/PUERaportNieobecnosci.md](Kalend/PUERaportNieobecnosci.md) |
| PlanowanaNieobecność | `PlanNieobecnosci` |  | root | [Kalend/PlanowanaNieobecność.md](Kalend/PlanowanaNieobecność.md) |
| PozycjaAktualizacjiCzasu | `PozAktCzasu` |  |  | [Kalend/PozycjaAktualizacjiCzasu.md](Kalend/PozycjaAktualizacjiCzasu.md) |
| PozycjaAktualizacjiKalendarza | `PozAktKalend` |  |  | [Kalend/PozycjaAktualizacjiKalendarza.md](Kalend/PozycjaAktualizacjiKalendarza.md) |
| PozycjaObiektuAktualizacjiCzasu | `PozObAktCzas` |  |  | [Kalend/PozycjaObiektuAktualizacjiCzasu.md](Kalend/PozycjaObiektuAktualizacjiCzasu.md) |
| PozycjaObiektuAktualizacjiKalendarza | `PozObAktKalend` |  |  | [Kalend/PozycjaObiektuAktualizacjiKalendarza.md](Kalend/PozycjaObiektuAktualizacjiKalendarza.md) |
| RegulaDostepnosci | `RegulyDostep` |  | root | [Kalend/RegulaDostepnosci.md](Kalend/RegulaDostepnosci.md) |
| RozliczenieCzasuPracy | `RozlCzasPracy` |  | root | [Kalend/RozliczenieCzasuPracy.md](Kalend/RozliczenieCzasuPracy.md) |
| StrefaDnia | `StrefyDni` | konfig | child: Dzien→DefinicjaDnia | [Kalend/StrefaDnia.md](Kalend/StrefaDnia.md) |
| StrefaKalendarza | `StrefyKalandarza` |  | child: Dzien→DzienKalendarzaBase | [Kalend/StrefaKalendarza.md](Kalend/StrefaKalendarza.md) |
| StrefaKalendarzaAktualizacja | `StrefyKalendAkt` |  | child: Dzien→DzienKalendarzaAktualizacja | [Kalend/StrefaKalendarzaAktualizacja.md](Kalend/StrefaKalendarzaAktualizacja.md) |
| StrefaKalendarzaHistoria | `StrefyKalendHist` |  | child: Dzien→DzienKalendarzaHistoria | [Kalend/StrefaKalendarzaHistoria.md](Kalend/StrefaKalendarzaHistoria.md) |
| StrefaPracy | `StrefyPracy` |  | child: Dzien→DzienPracy | [Kalend/StrefaPracy.md](Kalend/StrefaPracy.md) |
| StrefaPracyAktualizacja | `StrefyPracyAkt` |  | child: Dzien→DzienPracyAktualizacja | [Kalend/StrefaPracyAktualizacja.md](Kalend/StrefaPracyAktualizacja.md) |
| StrefaPracyHistoria | `StrefyPracyHist` |  | child: Dzien→DzienPracyHistoria | [Kalend/StrefaPracyHistoria.md](Kalend/StrefaPracyHistoria.md) |
| StrefaPracyUmowy | `StrefyPracyUmowy` |  | child: Dzien→DzienPracyUmowy | [Kalend/StrefaPracyUmowy.md](Kalend/StrefaPracyUmowy.md) |
| StrefaRCP | `StrefyRCP` |  | child: Dzien→DzienRCP | [Kalend/StrefaRCP.md](Kalend/StrefaRCP.md) |
| StrefaZestawienia | `StrefyZestawien` |  | child: Zestawienie→ZestawieniePracy | [Kalend/StrefaZestawienia.md](Kalend/StrefaZestawienia.md) |
| StrefaZestawieniaUmowy | `StrefyZestawUmow` |  | child: Zestawienie→ZestawienieUmowy | [Kalend/StrefaZestawieniaUmowy.md](Kalend/StrefaZestawieniaUmowy.md) |
| StrefaZestawieniaUmowyZewnetrznej | `StrefyZestUmZw` |  | child: Zestawienie→ZestawienieUmowyZewnetrznej | [Kalend/StrefaZestawieniaUmowyZewnetrznej.md](Kalend/StrefaZestawieniaUmowyZewnetrznej.md) |
| WejscieWyjscie | `WejsciaWyjscia` |  | child: Dzien→DzienPracy | [Kalend/WejscieWyjscie.md](Kalend/WejscieWyjscie.md) |
| WejscieWyjscieI | `WejsciaWyjsciaI` |  | child: Pracownik→Pracownik | [Kalend/WejscieWyjscieI.md](Kalend/WejscieWyjscieI.md) |
| WejscieWyjscieO | `WejsciaWyjsciaO` |  | child: Pracownik→Pracownik | [Kalend/WejscieWyjscieO.md](Kalend/WejscieWyjscieO.md) |
| WeryfikatorKalendarza | `WeryfKalend` |  | root | [Kalend/WeryfikatorKalendarza.md](Kalend/WeryfikatorKalendarza.md) |
| WeryfikatorRozliczeniaCzasuPracy | `WerRozCzas` |  | root | [Kalend/WeryfikatorRozliczeniaCzasuPracy.md](Kalend/WeryfikatorRozliczeniaCzasuPracy.md) |
| WniosekPracyZdalnej | `WnioskiPracZdal` |  | root | [Kalend/WniosekPracyZdalnej.md](Kalend/WniosekPracyZdalnej.md) |
| WyjatekRegulyDostepnosci | `WyjatkiRegDost` |  | child: Regula→RegulaDostepnosci | [Kalend/WyjatekRegulyDostepnosci.md](Kalend/WyjatekRegulyDostepnosci.md) |
| ZasobRN | `ZasobyRN` |  | child: Strefa→StrefaPracy | [Kalend/ZasobRN.md](Kalend/ZasobRN.md) |
| ZbiegPracyIRodzicielstwa | `ZbiegiPracyIRodz` |  | root | [Kalend/ZbiegPracyIRodzicielstwa.md](Kalend/ZbiegPracyIRodzicielstwa.md) |
| ZestDietPakietMobil | `ZestDietPaMob` |  | child: Host→IZestawienieDietPakietMobilHost | [Kalend/ZestDietPakietMobil.md](Kalend/ZestDietPakietMobil.md) |
| ZestawienieAkorduBase | `ZestawAkordow` |  | child: Akord→Akord | [Kalend/ZestawienieAkorduBase.md](Kalend/ZestawienieAkorduBase.md) |
| ZestawienieAktualizacjiKalendarza | `ZestAktKalend` | konfig | child: DefinicjaDokumentu→DefinicjaAktualizacjiKalendarza | [Kalend/ZestawienieAktualizacjiKalendarza.md](Kalend/ZestawienieAktualizacjiKalendarza.md) |
| ZestawienieDietZagr | `ZestawDietZagr` |  | child: Host→IZestawienieDietZagrHost | [Kalend/ZestawienieDietZagr.md](Kalend/ZestawienieDietZagr.md) |
| ZestawieniePracy | `ZestawieniaPracy` |  | child: Pracownik→Pracownik | [Kalend/ZestawieniePracy.md](Kalend/ZestawieniePracy.md) |
| ZestawienieUmowy | `ZestawieniaUmow` |  | child: Umowa→Umowa | [Kalend/ZestawienieUmowy.md](Kalend/ZestawienieUmowy.md) |
| ZestawienieUmowyZewnetrznej | `ZestawieniaUmZew` |  | child: Umowa→UmowaZewnetrzna | [Kalend/ZestawienieUmowyZewnetrznej.md](Kalend/ZestawienieUmowyZewnetrznej.md) |

## Kasa

- Opis: Moduł gospodarki kasowo-bankowej obsługujący ewidencję środków pieniężnych w kasach i na rachunkach bankowych. Realizuje pełny obieg dokumentów płatniczych — od rejestracji płatności i zapłat, przez przelewy i raporty kasowe, po rozliczenia i rozrachunki z kontrahentami. Wspiera magazyn walut, preliminarz płatności, bankowość elektroniczną oraz mechanizm podzielonej płatności (MPP).

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| DefinicjaPaczkiPrzelewu | `DefPaczekPrze` | konfig | root | [Kasa/DefinicjaPaczkiPrzelewu.md](Kasa/DefinicjaPaczkiPrzelewu.md) |
| DodatkoweDanePrzelewu | `DodDanePrzelewow` |  | child: Przelew→PrzelewBase | [Kasa/DodatkoweDanePrzelewu.md](Kasa/DodatkoweDanePrzelewu.md) |
| DokKasowyBase | `DokumentyKasowe` |  | root | [Kasa/DokKasowyBase.md](Kasa/DokKasowyBase.md) |
| DokRozliczBase | `DokRozliczeniowe` |  | root | [Kasa/DokRozliczBase.md](Kasa/DokRozliczBase.md) |
| EwidencjaSP | `EwidencjeSP` | konfig | root | [Kasa/EwidencjaSP.md](Kasa/EwidencjaSP.md) |
| FormaPlatnosci | `FormyPlatnosci` | konfig | root | [Kasa/FormaPlatnosci.md](Kasa/FormaPlatnosci.md) |
| FormatWymianyElektronicznej | `FormatyWymElektr` | konfig | root | [Kasa/FormatWymianyElektronicznej.md](Kasa/FormatWymianyElektronicznej.md) |
| HistoriaStatusuBL | `StatusBLHist` |  |  | [Kasa/HistoriaStatusuBL.md](Kasa/HistoriaStatusuBL.md) |
| IdentyfikacjaPlatnika | `IdentPlatnikow` |  |  | [Kasa/IdentyfikacjaPlatnika.md](Kasa/IdentyfikacjaPlatnika.md) |
| ObrotMW | `ObrotyMW` |  |  | [Kasa/ObrotMW.md](Kasa/ObrotMW.md) |
| OkresMW | `OkresyMW` | konfig | root | [Kasa/OkresMW.md](Kasa/OkresMW.md) |
| OperacjaBankowa | `OperacjeBankowe` |  | child: WyciagBankowy→RaportESP | [Kasa/OperacjaBankowa.md](Kasa/OperacjaBankowa.md) |
| PaczkaPrzelewow | `PaczkiPrzelewow` |  | root | [Kasa/PaczkaPrzelewow.md](Kasa/PaczkaPrzelewow.md) |
| ParametrySerwisuBankowego | `ParametrySeBnk` | konfig |  | [Kasa/ParametrySerwisuBankowego.md](Kasa/ParametrySerwisuBankowego.md) |
| Platnosc | `Platnosci` |  | root | [Kasa/Platnosc.md](Kasa/Platnosc.md) |
| PozycjaDokRozlicz | `PozDokRozlicz` |  | child: Dokument→DokRozliczBase | [Kasa/PozycjaDokRozlicz.md](Kasa/PozycjaDokRozlicz.md) |
| PozycjaPaczkiPrzelewow | `PozPaczPrz` |  | child: Paczka→PaczkaPrzelewow | [Kasa/PozycjaPaczkiPrzelewow.md](Kasa/PozycjaPaczkiPrzelewow.md) |
| PozycjaPrzelewu | `PozycjePrzelewow` |  | child: Przelew→PrzelewBase | [Kasa/PozycjaPrzelewu.md](Kasa/PozycjaPrzelewu.md) |
| PreliminarzDokument | `PreliminarzDok` |  | root | [Kasa/PreliminarzDokument.md](Kasa/PreliminarzDokument.md) |
| PreliminarzPozycja | `PreliminarzPoz` |  | child: Dokument→IDokumentPreliminarza | [Kasa/PreliminarzPozycja.md](Kasa/PreliminarzPozycja.md) |
| PrzelewBase | `Przelewy` |  | root | [Kasa/PrzelewBase.md](Kasa/PrzelewBase.md) |
| RachunekBankowyPodmiotu | `RachBankPodmiot` |  | root | [Kasa/RachunekBankowyPodmiotu.md](Kasa/RachunekBankowyPodmiotu.md) |
| RachunekWirtualny | `RachWirtualne` |  |  | [Kasa/RachunekWirtualny.md](Kasa/RachunekWirtualny.md) |
| RaportESP | `RaportyESP` |  | root | [Kasa/RaportESP.md](Kasa/RaportESP.md) |
| RozliczenieSP | `RozliczeniaSP` |  | root | [Kasa/RozliczenieSP.md](Kasa/RozliczenieSP.md) |
| RozrachunekIdx | `RozrachunkiIdx` |  |  | [Kasa/RozrachunekIdx.md](Kasa/RozrachunekIdx.md) |
| SerwisBankowy | `SerwisyBankowe` | konfig | root | [Kasa/SerwisBankowy.md](Kasa/SerwisBankowy.md) |
| SposobZaplaty | `SposobyZaplaty` | konfig | root | [Kasa/SposobZaplaty.md](Kasa/SposobZaplaty.md) |
| SubEwidencjaSP | `SubEwidencjeSP` | konfig |  | [Kasa/SubEwidencjaSP.md](Kasa/SubEwidencjaSP.md) |
| TypIdenPodPrzel | `TypyIdenPodPrzel` | konfig | root | [Kasa/TypIdenPodPrzel.md](Kasa/TypIdenPodPrzel.md) |
| Zaplata | `Zaplaty` |  | root | [Kasa/Zaplata.md](Kasa/Zaplata.md) |
| ZasobMW | `ZasobyMW` |  |  | [Kasa/ZasobMW.md](Kasa/ZasobMW.md) |

## Ksiega

- Opis: Moduł księgowości obsługujący pełną rachunkowość firmy: plan kont, zapisy księgowe, dekrety, dzienniki i okresy obrachunkowe. Zapewnia mechanizmy predekretacji za pomocą schematów księgowych, rozliczenia księgowe, opisy analityczne z podzielnikami kosztów, zestawienia księgowe oraz sprawozdania finansowe (bilans, RZiS, rachunek przepływów). Obsługuje również KPiR, kręgi kosztów, słowniki analityczne, matryce dokumentów i rozliczenia złych długów.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| DBIPKBRHist | `DBIPKBRHists` | konfig | child: DBItemPKBROkRoz→DBItemPKBROkRoz | [Ksiega/DBIPKBRHist.md](Ksiega/DBIPKBRHist.md) |
| DBItemPKBROkRoz | `DBItemPKBROkRozs` | konfig | root | [Ksiega/DBItemPKBROkRoz.md](Ksiega/DBItemPKBROkRoz.md) |
| DefinicjaAnalityki | `DefAnalityk` |  | child: Konto→KontoBase | [Ksiega/DefinicjaAnalityki.md](Ksiega/DefinicjaAnalityki.md) |
| DefinicjaKregu | `DefinicjeKregow` | konfig | root | [Ksiega/DefinicjaKregu.md](Ksiega/DefinicjaKregu.md) |
| DefinicjaSlownika | `DefSlownikow` | konfig | root | [Ksiega/DefinicjaSlownika.md](Ksiega/DefinicjaSlownika.md) |
| DekretBase | `Dziennik` |  | root | [Ksiega/DekretBase.md](Ksiega/DekretBase.md) |
| ElemDefinicjiSlownika | `ElemDefSlownikow` | konfig | child: Definicja→DefinicjaSlownika | [Ksiega/ElemDefinicjiSlownika.md](Ksiega/ElemDefinicjiSlownika.md) |
| ElemOpisuAnalZapRel | `OpisAnalZapRel` |  | child: ZapisKsiegowy→ZapisKsiegowy | [Ksiega/ElemOpisuAnalZapRel.md](Ksiega/ElemOpisuAnalZapRel.md) |
| ElemOpisuAnalitycznego | `OpisAnalityczny` |  | child: Ewidencja→DokEwidencji | [Ksiega/ElemOpisuAnalitycznego.md](Ksiega/ElemOpisuAnalitycznego.md) |
| ElemSlownika | `ElemSlownikow` |  | root | [Ksiega/ElemSlownika.md](Ksiega/ElemSlownika.md) |
| GrupaKont | `GrupyKont` | konfig | root | [Ksiega/GrupaKont.md](Ksiega/GrupaKont.md) |
| JednostkaSprawozdaniaKS | `JednostkiSprawKS` |  | child: Sprawozdanie→SprawozdanieKS | [Ksiega/JednostkaSprawozdaniaKS.md](Ksiega/JednostkaSprawozdaniaKS.md) |
| KolumnaWynikuZestKS | `KolumnyWynZestKS` |  | child: Wynik→WynikZestKS | [Ksiega/KolumnaWynikuZestKS.md](Ksiega/KolumnaWynikuZestKS.md) |
| KolumnaZestKS | `KolumnyZestKS` | konfig | child: Zestawienie→ZestawienieKS | [Ksiega/KolumnaZestKS.md](Ksiega/KolumnaZestKS.md) |
| KomorkaWynikuZestKS | `KomorkiWynZestKS` |  | child: Wynik→WynikZestKS | [Ksiega/KomorkaWynikuZestKS.md](Ksiega/KomorkaWynikuZestKS.md) |
| KontoBase | `Konta` |  | root | [Ksiega/KontoBase.md](Ksiega/KontoBase.md) |
| MatrycaBase | `Matryce` | konfig | root | [Ksiega/MatrycaBase.md](Ksiega/MatrycaBase.md) |
| MatrycaPodmiot | `MatrycePodmioty` |  |  | [Ksiega/MatrycaPodmiot.md](Ksiega/MatrycaPodmiot.md) |
| ObrotKsiegowyBase | `ObrotyKsiegowe` |  |  | [Ksiega/ObrotKsiegowyBase.md](Ksiega/ObrotKsiegowyBase.md) |
| OkresObrachunkowy | `OkresyObrach` | konfig | root | [Ksiega/OkresObrachunkowy.md](Ksiega/OkresObrachunkowy.md) |
| PodokresObrachunkowy | `PodokresyObrach` | konfig | child: OkresKs→OkresObrachunkowy | [Ksiega/PodokresObrachunkowy.md](Ksiega/PodokresObrachunkowy.md) |
| PowiazanieKontaBase | `PowiazaniaKont` |  | child: Konto→KontoBase | [Ksiega/PowiazanieKontaBase.md](Ksiega/PowiazanieKontaBase.md) |
| PozGrupyKont | `PozGrupyKontT` | konfig | child: Grupa→GrupaKont | [Ksiega/PozGrupyKont.md](Ksiega/PozGrupyKont.md) |
| PozycjaDefKregu | `PozycjeDefKregow` | konfig | child: Definicja→DefinicjaKregu | [Ksiega/PozycjaDefKregu.md](Ksiega/PozycjaDefKregu.md) |
| PozycjaSchematuKsiegowego | `PozSchemKsiegT` | konfig | child: Schemat→SchematKsiegowy | [Ksiega/PozycjaSchematuKsiegowego.md](Ksiega/PozycjaSchematuKsiegowego.md) |
| PozycjaSprawozdaniaKS | `PozycjeSprawKS` |  | child: RootPoz→IPozycjaSprawozdaniaRoot | [Ksiega/PozycjaSprawozdaniaKS.md](Ksiega/PozycjaSprawozdaniaKS.md) |
| PozycjaWynikuZestKS | `PozycjeWynZestKS` |  | child: Wynik→WynikZestKS | [Ksiega/PozycjaWynikuZestKS.md](Ksiega/PozycjaWynikuZestKS.md) |
| PozycjaZestKS | `PozycjeZestKS` | konfig | child: Zestawienie→ZestawienieKS | [Ksiega/PozycjaZestKS.md](Ksiega/PozycjaZestKS.md) |
| RelacjaOpisAnal | `RelacjeOpisAnal` | konfig | root | [Ksiega/RelacjaOpisAnal.md](Ksiega/RelacjaOpisAnal.md) |
| RozliczenieKS | `RozliczeniaKS` |  |  | [Ksiega/RozliczenieKS.md](Ksiega/RozliczenieKS.md) |
| RozliczenieOA | `RozliczeniaOA` |  |  | [Ksiega/RozliczenieOA.md](Ksiega/RozliczenieOA.md) |
| SchematKsiegowy | `SchematyKsiegowe` | konfig | root | [Ksiega/SchematKsiegowy.md](Ksiega/SchematKsiegowy.md) |
| SchematPodz | `SchematyPodz` | konfig | root | [Ksiega/SchematPodz.md](Ksiega/SchematPodz.md) |
| SchematPodzElem | `SchematPodzElems` | konfig | root | [Ksiega/SchematPodzElem.md](Ksiega/SchematPodzElem.md) |
| SprawozdanieKS | `SprawozdaniaKS` |  | root | [Ksiega/SprawozdanieKS.md](Ksiega/SprawozdanieKS.md) |
| WynikZestKS | `WynikiZestKS` |  | root | [Ksiega/WynikZestKS.md](Ksiega/WynikZestKS.md) |
| ZapisKsiegowy | `ZapisyKsiegowe` |  | child: Dekret→DekretBase | [Ksiega/ZapisKsiegowy.md](Ksiega/ZapisKsiegowy.md) |
| ZestawienieKS | `ZestawieniaKS` | konfig | root | [Ksiega/ZestawienieKS.md](Ksiega/ZestawienieKS.md) |
| ZleDlugiDokument | `ZDDokumenty` |  | root | [Ksiega/ZleDlugiDokument.md](Ksiega/ZleDlugiDokument.md) |
| ZleDlugiPozycja | `ZDPozycje` |  | child: Dokument→ZleDlugiDokument | [Ksiega/ZleDlugiPozycja.md](Ksiega/ZleDlugiPozycja.md) |
| ZleDlugiPozycjaKorekty | `ZDPozycjeKorekty` |  | child: Korekta→ZleDlugiPozycja | [Ksiega/ZleDlugiPozycjaKorekty.md](Ksiega/ZleDlugiPozycjaKorekty.md) |
| ZnacznikKonta | `ZnacznikiKont` | konfig | root | [Ksiega/ZnacznikKonta.md](Ksiega/ZnacznikKonta.md) |

## Magazyny

- Opis: Moduł gospodarki magazynowej obsługujący ewidencję stanów, obrotów i zasobów magazynowych. Definiuje magazyny, okresy magazynowe, partie towarów (grupy dostaw) oraz mechanizmy wyceny rozchodu (FIFO, LIFO, wg cechy).

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| GrupaDostaw | `GrupyDostaw` |  |  | [Magazyny/GrupaDostaw.md](Magazyny/GrupaDostaw.md) |
| Magazyn | `Magazyny` | konfig | root | [Magazyny/Magazyn.md](Magazyny/Magazyn.md) |
| Obrot | `Obroty` |  |  | [Magazyny/Obrot.md](Magazyny/Obrot.md) |
| OkresMagazynowy | `OkresyMag` | konfig | root | [Magazyny/OkresMagazynowy.md](Magazyny/OkresMagazynowy.md) |
| Zasob | `Zasoby` |  |  | [Magazyny/Zasob.md](Magazyny/Zasob.md) |

## ManagementTools

- Opis: Moduł narzędzi zarządzania platformy enova365. Zawiera rejestr konfiguracji systemu umożliwiający przechowywanie i wersjonowanie ustawień w formacie JSON.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| ConfigRegistry | `ConfigRegistries` |  |  | [ManagementTools/ConfigRegistry.md](ManagementTools/ConfigRegistry.md) |

## Oceny

- Opis: Moduł ocen pracowniczych. Zawiera definicje arkuszy ocen, kryteria oceniania, skale oraz mechanizmy przeprowadzania i raportowania ocen okresowych.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| ArkuszDefinicjiOceny | `ArkuszeDefOcen` | konfig | child: DefinicjaOceny→DefinicjaOceny | [Oceny/ArkuszDefinicjiOceny.md](Oceny/ArkuszDefinicjiOceny.md) |
| ArkuszOdpowiedz | `ArkuszeOdp` |  |  | [Oceny/ArkuszOdpowiedz.md](Oceny/ArkuszOdpowiedz.md) |
| DefinicjaArkuszaOceny | `DefArkuszyOcen` | konfig | root | [Oceny/DefinicjaArkuszaOceny.md](Oceny/DefinicjaArkuszaOceny.md) |
| DefinicjaElementuOceny | `DefElementowOcen` | konfig | root | [Oceny/DefinicjaElementuOceny.md](Oceny/DefinicjaElementuOceny.md) |
| DefinicjaOceny | `DefinicjeOcen` | konfig | root | [Oceny/DefinicjaOceny.md](Oceny/DefinicjaOceny.md) |
| DefinicjaSekcjiDokumentu | `DefSekcjiDok` | konfig | root | [Oceny/DefinicjaSekcjiDokumentu.md](Oceny/DefinicjaSekcjiDokumentu.md) |
| ElementSkaliOcen | `ElementySkalOcen` | konfig | root | [Oceny/ElementSkaliOcen.md](Oceny/ElementSkaliOcen.md) |
| KategoriaElementuOceny | `KatElementowOcen` | konfig | root | [Oceny/KategoriaElementuOceny.md](Oceny/KategoriaElementuOceny.md) |
| OcenaArkusz | `OcenyArkusze` |  | root | [Oceny/OcenaArkusz.md](Oceny/OcenaArkusz.md) |
| OcenaKategoriaArkusza | `OcenyKatArkuszy` |  | child: Arkusz→OcenaArkusz | [Oceny/OcenaKategoriaArkusza.md](Oceny/OcenaKategoriaArkusza.md) |
| OcenaOceniający | `OcenyOceniajacy` |  | child: Ocena→OcenaRealizacja | [Oceny/OcenaOceniający.md](Oceny/OcenaOceniający.md) |
| OcenaOceniany | `OcenyOceniani` |  | child: Ocena→OcenaRealizacja | [Oceny/OcenaOceniany.md](Oceny/OcenaOceniany.md) |
| OcenaPowiaz | `OcenyPowiaz` |  | root | [Oceny/OcenaPowiaz.md](Oceny/OcenaPowiaz.md) |
| OcenaPozycjaArkusza | `OcenyPozArkuszy` |  | root | [Oceny/OcenaPozycjaArkusza.md](Oceny/OcenaPozycjaArkusza.md) |
| OcenaRealizacja | `OcenyRealizacje` |  | root | [Oceny/OcenaRealizacja.md](Oceny/OcenaRealizacja.md) |
| PozycjaDefinicjiArkuszaOceny | `PozDefArkuszOcen` | konfig | child: DefinicjaArkusza→DefinicjaArkuszaOceny | [Oceny/PozycjaDefinicjiArkuszaOceny.md](Oceny/PozycjaDefinicjiArkuszaOceny.md) |
| SkalaOcen | `SkaleOcen` | konfig | root | [Oceny/SkalaOcen.md](Oceny/SkalaOcen.md) |
| UzasadnienieOceny | `OcenyUzas` | konfig | root | [Oceny/UzasadnienieOceny.md](Oceny/UzasadnienieOceny.md) |
| ZakresWartości | `ZakresyWartosci` | konfig | root | [Oceny/ZakresWartości.md](Oceny/ZakresWartości.md) |

## Place

- Opis: Moduł płacowy obsługujący naliczanie wynagrodzeń. Zawiera listy płac, składniki wynagrodzenia, elementy wypłat, potrącenia, zasiłki, deklaracje PIT oraz rozliczenia z ZUS i US.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| BilansOtwarciaPIT | `BilansyOtwPIT` |  | root | [Place/BilansOtwarciaPIT.md](Place/BilansOtwarciaPIT.md) |
| DefinicjaElementu | `DefElementow` | konfig | root | [Place/DefinicjaElementu.md](Place/DefinicjaElementu.md) |
| DefinicjaElementuRozliczenia | `DefElementowRozl` | konfig | root | [Place/DefinicjaElementuRozliczenia.md](Place/DefinicjaElementuRozliczenia.md) |
| DefinicjaListyPlac | `DefListPlac` | konfig | root | [Place/DefinicjaListyPlac.md](Place/DefinicjaListyPlac.md) |
| DefinicjaPlanowanejListyPłac | `DefPlanListPlac` | konfig | root | [Place/DefinicjaPlanowanejListyPłac.md](Place/DefinicjaPlanowanejListyPłac.md) |
| DodatekAutomatyczny | `DodAutomatyczne` |  | root | [Place/DodatekAutomatyczny.md](Place/DodatekAutomatyczny.md) |
| DokumentRozliczeniaKontrahenta | `DokumentyRozlKon` |  | root | [Place/DokumentRozliczeniaKontrahenta.md](Place/DokumentRozliczeniaKontrahenta.md) |
| DokumentRozliczeniaPracownika | `DokumentyRozlPra` |  | root | [Place/DokumentRozliczeniaPracownika.md](Place/DokumentRozliczeniaPracownika.md) |
| ElementBilansuOtwarciaPIT | `ElementyBOPIT` |  | child: Dokument→BilansOtwarciaPIT | [Place/ElementBilansuOtwarciaPIT.md](Place/ElementBilansuOtwarciaPIT.md) |
| ElementRozliczeniaPracownika | `ElementyRozlPrac` |  | root | [Place/ElementRozliczeniaPracownika.md](Place/ElementRozliczeniaPracownika.md) |
| KodRSA | `KodyRSA` | konfig | root | [Place/KodRSA.md](Place/KodRSA.md) |
| KosztAutorski | `KosztyAutorskie` |  | root | [Place/KosztAutorski.md](Place/KosztAutorski.md) |
| ListaPlac | `ListyPlac` |  | root | [Place/ListaPlac.md](Place/ListaPlac.md) |
| NieobecnoscERP7 | `NieobecnosciERP7` |  |  | [Place/NieobecnoscERP7.md](Place/NieobecnoscERP7.md) |
| OdbiorcaElementu | `OdbElementow` |  | child: Definicja→DefinicjaElementu | [Place/OdbiorcaElementu.md](Place/OdbiorcaElementu.md) |
| OświadczenieZusOpieka | `OswiadZusOpieka` |  | root | [Place/OświadczenieZusOpieka.md](Place/OświadczenieZusOpieka.md) |
| PlanowanaListaPłac | `PlanListyPlac` |  | root | [Place/PlanowanaListaPłac.md](Place/PlanowanaListaPłac.md) |
| PlanowanaWypłata | `PlanowaneWyplaty` |  | child: ListaPlac→PlanowanaListaPłac | [Place/PlanowanaWypłata.md](Place/PlanowanaWypłata.md) |
| PlanowanyElementWypłaty | `PlanElementyWyp` |  | child: Wyplata→PlanowanaWypłata | [Place/PlanowanyElementWypłaty.md](Place/PlanowanyElementWypłaty.md) |
| PodstawaNieobecnosci | `PodstawyNieobec` |  | child: Pracownik→Pracownik | [Place/PodstawaNieobecnosci.md](Place/PodstawaNieobecnosci.md) |
| PodstawaNieobecnosciOkresowa | `PodstawyNieobOkr` |  | child: Pracownik→Pracownik | [Place/PodstawaNieobecnosciOkresowa.md](Place/PodstawaNieobecnosciOkresowa.md) |
| PozycjaPIT | `PozycjePIT` | konfig | root | [Place/PozycjaPIT.md](Place/PozycjaPIT.md) |
| ProgStazuPracy | `ProgiStazuPracy` | konfig | child: Definicja→DefinicjaElementu | [Place/ProgStazuPracy.md](Place/ProgStazuPracy.md) |
| RozliczenieDokKontrahenta | `RozliDokKontr` |  | child: Dokument→DokumentRozliczeniaKontrahenta | [Place/RozliczenieDokKontrahenta.md](Place/RozliczenieDokKontrahenta.md) |
| RozliczenieWynagrodzenia | `RozliczWynagrodz` |  | child: Host→IRozliczenieWynagrodzeniaHost | [Place/RozliczenieWynagrodzenia.md](Place/RozliczenieWynagrodzenia.md) |
| StornoElementu | `StornaElementow` |  | child: Stornowany→WypElement | [Place/StornoElementu.md](Place/StornoElementu.md) |
| WynagrodzenieERP7 | `WynagrodzeERP7` |  |  | [Place/WynagrodzenieERP7.md](Place/WynagrodzenieERP7.md) |
| WypElement | `WypElementy` |  | root | [Place/WypElement.md](Place/WypElement.md) |
| WypSkladnik | `WypSkladniki` |  | child: Element→WypElement | [Place/WypSkladnik.md](Place/WypSkladnik.md) |
| Wyplata | `Wyplaty` |  | root | [Place/Wyplata.md](Place/Wyplata.md) |
| Zaliczka | `Zaliczki` |  | root | [Place/Zaliczka.md](Place/Zaliczka.md) |
| ZaniechaniePodatkowe | `ZaniechPodatkowe` |  | root | [Place/ZaniechaniePodatkowe.md](Place/ZaniechaniePodatkowe.md) |
| ZasiłekInnyPłatnik | `ZasInnyPlatnik` |  | root | [Place/ZasiłekInnyPłatnik.md](Place/ZasiłekInnyPłatnik.md) |

## PracaHybrydowa

- Opis: Moduł obsługujący pracę zdalną i hybrydową. Zawiera definicje miejsc pracy, harmonogramy pracy zdalnej oraz ewidencję obecności w biurze i poza nim.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| AreaPath | `AreaPaths` |  | root | [PracaHybrydowa/AreaPath.md](PracaHybrydowa/AreaPath.md) |
| AreaPathTaskRel | `AreaTaskRel` |  |  | [PracaHybrydowa/AreaPathTaskRel.md](PracaHybrydowa/AreaPathTaskRel.md) |
| DefinicjaRCP | `DefinicjeRCP` | konfig | root | [PracaHybrydowa/DefinicjaRCP.md](PracaHybrydowa/DefinicjaRCP.md) |
| DefinicjaWerRCP | `DefinicjeWerRCP` | konfig | root | [PracaHybrydowa/DefinicjaWerRCP.md](PracaHybrydowa/DefinicjaWerRCP.md) |
| RelChangeInfo | `RelChangeInfos` |  |  | [PracaHybrydowa/RelChangeInfo.md](PracaHybrydowa/RelChangeInfo.md) |
| ZadaniaRelacja | `ZadRelacje` |  |  | [PracaHybrydowa/ZadaniaRelacja.md](PracaHybrydowa/ZadaniaRelacja.md) |

## Produkcja

- Opis: Moduł produkcyjny obsługujący planowanie i realizację procesów wytwórczych. Definiuje technologie produkcyjne z operacjami, pozycjami surowcowymi i produktowymi, czasami operacji oraz zasobami (maszynami, osobami). Wspiera rejestrację przebiegu produkcji, kalkulację kosztów wytworzenia, rezerwację surowców, raportowanie braków i awarii oraz rozliczenie akordowe.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| CzasTechn | `CzasyTechn` |  | root | [Produkcja/CzasTechn.md](Produkcja/CzasTechn.md) |
| KosztTechn | `KosztyTechn` |  | root | [Produkcja/KosztTechn.md](Produkcja/KosztTechn.md) |
| Operacja | `Operacje` |  | root | [Produkcja/Operacja.md](Produkcja/Operacja.md) |
| OperacjaPoprzedzajaca | `OperacjePoprzed` |  |  | [Produkcja/OperacjaPoprzedzajaca.md](Produkcja/OperacjaPoprzedzajaca.md) |
| PozycjaTechn | `PozycjeTechn` |  | root | [Produkcja/PozycjaTechn.md](Produkcja/PozycjaTechn.md) |
| ProdAwaria | `ProdAwarie` |  | root | [Produkcja/ProdAwaria.md](Produkcja/ProdAwaria.md) |
| ProdHistoria | `ProdHistorie` |  |  | [Produkcja/ProdHistoria.md](Produkcja/ProdHistoria.md) |
| ProdKompetencja | `ProdKompetencje` |  |  | [Produkcja/ProdKompetencja.md](Produkcja/ProdKompetencja.md) |
| ProdMeldunekBraku | `ProdMeldBrakow` |  | root | [Produkcja/ProdMeldunekBraku.md](Produkcja/ProdMeldunekBraku.md) |
| ProdOsoba | `ProdOsobyR` |  | root | [Produkcja/ProdOsoba.md](Produkcja/ProdOsoba.md) |
| ProdOsobaKompetencja | `ProdOsobaKom` |  |  | [Produkcja/ProdOsobaKompetencja.md](Produkcja/ProdOsobaKompetencja.md) |
| ProdOsobaWzorcowa | `ProdOsobyWz` |  |  | [Produkcja/ProdOsobaWzorcowa.md](Produkcja/ProdOsobaWzorcowa.md) |
| ProdPozSlownika | `ProdPozSlownikow` | konfig | child: Slownik→ProdSlownik | [Produkcja/ProdPozSlownika.md](Produkcja/ProdPozSlownika.md) |
| ProdProdukt | `ProdProdukty` | konfig | root | [Produkcja/ProdProdukt.md](Produkcja/ProdProdukt.md) |
| ProdSlownik | `ProdSlowniki` | konfig | root | [Produkcja/ProdSlownik.md](Produkcja/ProdSlownik.md) |
| ProdZasob | `ProdZasobyR` |  | root | [Produkcja/ProdZasob.md](Produkcja/ProdZasob.md) |
| ProdZasobRelacja | `ProdZasobyRel` |  |  | [Produkcja/ProdZasobRelacja.md](Produkcja/ProdZasobRelacja.md) |
| ProdZasobWzorcowy | `ProdZasobyW` |  |  | [Produkcja/ProdZasobWzorcowy.md](Produkcja/ProdZasobWzorcowy.md) |
| RelacjaProdZasobCRM | `RelProdZasobCRM` |  |  | [Produkcja/RelacjaProdZasobCRM.md](Produkcja/RelacjaProdZasobCRM.md) |
| RezerwacjaSurowca | `RezerwacjeSur` |  |  | [Produkcja/RezerwacjaSurowca.md](Produkcja/RezerwacjaSurowca.md) |
| Technologia | `Technologie` |  | root | [Produkcja/Technologia.md](Produkcja/Technologia.md) |
| WzorcowyCzasOper | `WzorcoweCzasOper` | konfig |  | [Produkcja/WzorcowyCzasOper.md](Produkcja/WzorcowyCzasOper.md) |
| ZasobTechn | `ZasobyTechn` |  |  | [Produkcja/ZasobTechn.md](Produkcja/ZasobTechn.md) |

## ProdukcjaPro

- Opis: Zaawansowany moduł produkcji. Zawiera zlecenia produkcyjne, operacje technologiczne, harmonogramowanie, kontrolę jakości, marszruty oraz szczegółowe rozliczanie kosztów produkcji.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| ProAwaria | `ProAwarie` |  | root | [ProdukcjaPro/ProAwaria.md](ProdukcjaPro/ProAwaria.md) |
| ProCzasPracy | `ProCzasyPracy` |  | child: ZasobOperacjiZlecenia→ProZasobOperacjiZlecenia | [ProdukcjaPro/ProCzasPracy.md](ProdukcjaPro/ProCzasPracy.md) |
| ProDefinicjaMeldunku | `ProDMeldunkow` |  | root | [ProdukcjaPro/ProDefinicjaMeldunku.md](ProdukcjaPro/ProDefinicjaMeldunku.md) |
| ProDefinicjaOperacji | `ProDOperacji` |  | root | [ProdukcjaPro/ProDefinicjaOperacji.md](ProdukcjaPro/ProDefinicjaOperacji.md) |
| ProDostawaMaterialuMeldunku | `ProDostawyMM` |  | child: MaterialMeldunku→ProMaterialMeldunku | [ProdukcjaPro/ProDostawaMaterialuMeldunku.md](ProdukcjaPro/ProDostawaMaterialuMeldunku.md) |
| ProFantomMaterialu | `ProFanMaterialow` |  | child: RozliczenieMaterialu→ProRozliczenieMaterialu | [ProdukcjaPro/ProFantomMaterialu.md](ProdukcjaPro/ProFantomMaterialu.md) |
| ProFantomWyrobu | `ProFanWyrobow` |  | child: RozliczenieWyrobu→ProRozliczenieWyrobu | [ProdukcjaPro/ProFantomWyrobu.md](ProdukcjaPro/ProFantomWyrobu.md) |
| ProKalkulacjaMeldunku | `ProKalkulacjeM` |  | child: Meldunek→ProMeldunek | [ProdukcjaPro/ProKalkulacjaMeldunku.md](ProdukcjaPro/ProKalkulacjaMeldunku.md) |
| ProKalkulacjaOperacjiTechnologii | `ProKalkulacjeOT` |  | child: Operacja→IProOperacjaWzorcowa | [ProdukcjaPro/ProKalkulacjaOperacjiTechnologii.md](ProdukcjaPro/ProKalkulacjaOperacjiTechnologii.md) |
| ProKalkulacjaOperacjiZlecenia | `ProKalkulacjeOZ` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProKalkulacjaOperacjiZlecenia.md](ProdukcjaPro/ProKalkulacjaOperacjiZlecenia.md) |
| ProKompetencja | `ProKompetencje` |  | root | [ProdukcjaPro/ProKompetencja.md](ProdukcjaPro/ProKompetencja.md) |
| ProMaterialMeldunku | `ProMaterialyM` |  | child: Meldunek→ProMeldunek | [ProdukcjaPro/ProMaterialMeldunku.md](ProdukcjaPro/ProMaterialMeldunku.md) |
| ProMaterialOperacjiTechnologii | `ProMaterialyOT` |  | child: Operacja→IProOperacjaWzorcowa | [ProdukcjaPro/ProMaterialOperacjiTechnologii.md](ProdukcjaPro/ProMaterialOperacjiTechnologii.md) |
| ProMaterialOperacjiZlecenia | `ProMaterialyOZ` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProMaterialOperacjiZlecenia.md](ProdukcjaPro/ProMaterialOperacjiZlecenia.md) |
| ProMeldunek | `ProMeldunki` |  | root | [ProdukcjaPro/ProMeldunek.md](ProdukcjaPro/ProMeldunek.md) |
| ProNumeracjaMeldunku | `ProNumeracjeMeld` | konfig | child: Wydzial→ProWydzial | [ProdukcjaPro/ProNumeracjaMeldunku.md](ProdukcjaPro/ProNumeracjaMeldunku.md) |
| ProNumeracjaTechnologii | `ProNumeracjeTech` | konfig | child: Wydzial→ProWydzial | [ProdukcjaPro/ProNumeracjaTechnologii.md](ProdukcjaPro/ProNumeracjaTechnologii.md) |
| ProNumeracjaWyrobuMeldunku | `ProNrWyrobowM` |  | child: WyrobMeldunku→ProWyrobMeldunku | [ProdukcjaPro/ProNumeracjaWyrobuMeldunku.md](ProdukcjaPro/ProNumeracjaWyrobuMeldunku.md) |
| ProNumeracjaZlecenia | `ProNumeracjeZlec` | konfig | child: Wydzial→ProWydzial | [ProdukcjaPro/ProNumeracjaZlecenia.md](ProdukcjaPro/ProNumeracjaZlecenia.md) |
| ProOdpadMeldunku | `ProOdpadyM` |  | child: Meldunek→ProMeldunek | [ProdukcjaPro/ProOdpadMeldunku.md](ProdukcjaPro/ProOdpadMeldunku.md) |
| ProOdpadOperacjiTechnologii | `ProOdpadyOT` |  | child: Operacja→IProOperacjaWzorcowa | [ProdukcjaPro/ProOdpadOperacjiTechnologii.md](ProdukcjaPro/ProOdpadOperacjiTechnologii.md) |
| ProOdpadOperacjiZlecenia | `ProOdpadyOZ` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProOdpadOperacjiZlecenia.md](ProdukcjaPro/ProOdpadOperacjiZlecenia.md) |
| ProOperacjaTechnologii | `ProOperacjeTech` |  | child: Technologia→ProTechnologia | [ProdukcjaPro/ProOperacjaTechnologii.md](ProdukcjaPro/ProOperacjaTechnologii.md) |
| ProOperacjaTechnologiiPoprzedzajaca | `ProOperacjeTechP` |  | child: Operacja→ProOperacjaTechnologii | [ProdukcjaPro/ProOperacjaTechnologiiPoprzedzajaca.md](ProdukcjaPro/ProOperacjaTechnologiiPoprzedzajaca.md) |
| ProOperacjaZlecenia | `ProOperacjeZlec` |  | child: Zlecenie→ProZlecenie | [ProdukcjaPro/ProOperacjaZlecenia.md](ProdukcjaPro/ProOperacjaZlecenia.md) |
| ProOperacjaZleceniaPoprzedzajaca | `ProOperacjeZlecP` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProOperacjaZleceniaPoprzedzajaca.md](ProdukcjaPro/ProOperacjaZleceniaPoprzedzajaca.md) |
| ProOsoba | `ProOsoby` |  | root | [ProdukcjaPro/ProOsoba.md](ProdukcjaPro/ProOsoba.md) |
| ProPlanPracy | `ProPlanyPracy` |  | child: Zasob→ProZasobOperacjiZlecenia | [ProdukcjaPro/ProPlanPracy.md](ProdukcjaPro/ProPlanPracy.md) |
| ProPozycjaGlownaTechnologii | `ProPGlownaT` |  | child: Technologia→ProTechnologia | [ProdukcjaPro/ProPozycjaGlownaTechnologii.md](ProdukcjaPro/ProPozycjaGlownaTechnologii.md) |
| ProPozycjaKompetencji | `ProPKompetencji` |  | child: Kompetencja→ProKompetencja | [ProdukcjaPro/ProPozycjaKompetencji.md](ProdukcjaPro/ProPozycjaKompetencji.md) |
| ProPozycjaZamowienia | `ProPZamowien` |  | child: Wyrob→ProWyrobOperacjiZlecenia | [ProdukcjaPro/ProPozycjaZamowienia.md](ProdukcjaPro/ProPozycjaZamowienia.md) |
| ProPozycjaZestawieniaMaterialow | `ProPZestawienM` |  | child: Zestawienie→ProZestawienieMaterialow | [ProdukcjaPro/ProPozycjaZestawieniaMaterialow.md](ProdukcjaPro/ProPozycjaZestawieniaMaterialow.md) |
| ProRelacjaMaterialWyrobOperacjiTechnologii | `ProRMatWyrOT` |  | child: Material→ProMaterialOperacjiTechnologii | [ProdukcjaPro/ProRelacjaMaterialWyrobOperacjiTechnologii.md](ProdukcjaPro/ProRelacjaMaterialWyrobOperacjiTechnologii.md) |
| ProRelacjaMaterialWyrobOperacjiZlecenia | `ProRMatWyrOZ` |  | child: Material→ProMaterialOperacjiZlecenia | [ProdukcjaPro/ProRelacjaMaterialWyrobOperacjiZlecenia.md](ProdukcjaPro/ProRelacjaMaterialWyrobOperacjiZlecenia.md) |
| ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji | `ProRZasobOTPKomp` |  | child: ZasobOperacjiTechnologii→ProZasobOperacjiTechnologii | [ProdukcjaPro/ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji.md](ProdukcjaPro/ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji.md) |
| ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji | `ProRZasobOZPKomp` |  | child: ZasobOperacjiZlecenia→ProZasobOperacjiZlecenia | [ProdukcjaPro/ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji.md](ProdukcjaPro/ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji.md) |
| ProRelacjaZasobPozycjaKompetencji | `ProRZasobPKomp` |  | child: Zasob→ProZasob | [ProdukcjaPro/ProRelacjaZasobPozycjaKompetencji.md](ProdukcjaPro/ProRelacjaZasobPozycjaKompetencji.md) |
| ProRelacjaZasobUrzadzenie | `ProRZasobUrz` |  | child: Zasob→ProZasob | [ProdukcjaPro/ProRelacjaZasobUrzadzenie.md](ProdukcjaPro/ProRelacjaZasobUrzadzenie.md) |
| ProRozliczenieMaterialu | `ProRozMaterialow` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProRozliczenieMaterialu.md](ProdukcjaPro/ProRozliczenieMaterialu.md) |
| ProRozliczenieOdpadu | `ProRozOdpadow` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProRozliczenieOdpadu.md](ProdukcjaPro/ProRozliczenieOdpadu.md) |
| ProRozliczenieWyrobu | `ProRozWyrobow` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProRozliczenieWyrobu.md](ProdukcjaPro/ProRozliczenieWyrobu.md) |
| ProRozliczenieZapotrzebowania | `ProRozZapot` |  | child: MaterialOperacjiZlecenia→ProMaterialOperacjiZlecenia | [ProdukcjaPro/ProRozliczenieZapotrzebowania.md](ProdukcjaPro/ProRozliczenieZapotrzebowania.md) |
| ProStawka | `ProStawki` |  | root | [ProdukcjaPro/ProStawka.md](ProdukcjaPro/ProStawka.md) |
| ProTechnologia | `ProTechnologie` |  | root | [ProdukcjaPro/ProTechnologia.md](ProdukcjaPro/ProTechnologia.md) |
| ProTechnologiaMaterialuOperacjiTechnologii | `ProTechMatOT` |  | child: Material→ProMaterialOperacjiTechnologii | [ProdukcjaPro/ProTechnologiaMaterialuOperacjiTechnologii.md](ProdukcjaPro/ProTechnologiaMaterialuOperacjiTechnologii.md) |
| ProTechnologiaMaterialuOperacjiZlecenia | `ProTechMatOZ` |  | child: Material→ProMaterialOperacjiZlecenia | [ProdukcjaPro/ProTechnologiaMaterialuOperacjiZlecenia.md](ProdukcjaPro/ProTechnologiaMaterialuOperacjiZlecenia.md) |
| ProTowar | `ProTowary` |  | child: Towar→Towar | [ProdukcjaPro/ProTowar.md](ProdukcjaPro/ProTowar.md) |
| ProTowarMeldowanyOperacjiTechnologii | `ProTowaryMeldOT` |  | child: Operacja→IProOperacjaWzorcowa | [ProdukcjaPro/ProTowarMeldowanyOperacjiTechnologii.md](ProdukcjaPro/ProTowarMeldowanyOperacjiTechnologii.md) |
| ProTowarMeldowanyOperacjiZlecenia | `ProTowaryMeldOZ` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProTowarMeldowanyOperacjiZlecenia.md](ProdukcjaPro/ProTowarMeldowanyOperacjiZlecenia.md) |
| ProUslugaMeldunku | `ProUslugiM` |  | child: Meldunek→ProMeldunek | [ProdukcjaPro/ProUslugaMeldunku.md](ProdukcjaPro/ProUslugaMeldunku.md) |
| ProUslugaOperacjiTechnologii | `ProUslugiOT` |  | child: Operacja→IProOperacjaWzorcowa | [ProdukcjaPro/ProUslugaOperacjiTechnologii.md](ProdukcjaPro/ProUslugaOperacjiTechnologii.md) |
| ProUslugaOperacjiZlecenia | `ProUslugiOZ` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProUslugaOperacjiZlecenia.md](ProdukcjaPro/ProUslugaOperacjiZlecenia.md) |
| ProUzytkownikPaneluMeldunkowego | `ProUzytkownicyPM` | konfig | root | [ProdukcjaPro/ProUzytkownikPaneluMeldunkowego.md](ProdukcjaPro/ProUzytkownikPaneluMeldunkowego.md) |
| ProWariantowoscZasobu | `ProWarZasobow` |  | child: Zasob→ProZasob | [ProdukcjaPro/ProWariantowoscZasobu.md](ProdukcjaPro/ProWariantowoscZasobu.md) |
| ProWariantowoscZasobuOperacjiTechnologii | `ProWarZasobowOT` |  | child: ZasobOperacjiTechnologii→ProZasobOperacjiTechnologii | [ProdukcjaPro/ProWariantowoscZasobuOperacjiTechnologii.md](ProdukcjaPro/ProWariantowoscZasobuOperacjiTechnologii.md) |
| ProWariantowoscZasobuOperacjiZlecenia | `ProWarZasobowOZ` |  | child: ZasobOperacjiZlecenia→ProZasobOperacjiZlecenia | [ProdukcjaPro/ProWariantowoscZasobuOperacjiZlecenia.md](ProdukcjaPro/ProWariantowoscZasobuOperacjiZlecenia.md) |
| ProWydzial | `ProWydzialy` | konfig | root | [ProdukcjaPro/ProWydzial.md](ProdukcjaPro/ProWydzial.md) |
| ProWyrobMeldunku | `ProWyrobyM` |  | child: Meldunek→ProMeldunek | [ProdukcjaPro/ProWyrobMeldunku.md](ProdukcjaPro/ProWyrobMeldunku.md) |
| ProWyrobOperacjiTechnologii | `ProWyrobyOT` |  | child: Operacja→IProOperacjaWzorcowa | [ProdukcjaPro/ProWyrobOperacjiTechnologii.md](ProdukcjaPro/ProWyrobOperacjiTechnologii.md) |
| ProWyrobOperacjiZlecenia | `ProWyrobyOZ` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProWyrobOperacjiZlecenia.md](ProdukcjaPro/ProWyrobOperacjiZlecenia.md) |
| ProZasob | `ProZasoby` |  | root | [ProdukcjaPro/ProZasob.md](ProdukcjaPro/ProZasob.md) |
| ProZasobMeldunku | `ProZasobyM` |  | child: Meldunek→ProMeldunek | [ProdukcjaPro/ProZasobMeldunku.md](ProdukcjaPro/ProZasobMeldunku.md) |
| ProZasobOperacjiTechnologii | `ProZasobyOT` |  | child: Operacja→IProOperacjaWzorcowa | [ProdukcjaPro/ProZasobOperacjiTechnologii.md](ProdukcjaPro/ProZasobOperacjiTechnologii.md) |
| ProZasobOperacjiZlecenia | `ProZasobyOZ` |  | child: Operacja→ProOperacjaZlecenia | [ProdukcjaPro/ProZasobOperacjiZlecenia.md](ProdukcjaPro/ProZasobOperacjiZlecenia.md) |
| ProZestawienieMaterialow | `ProZestawieniaM` |  | root | [ProdukcjaPro/ProZestawienieMaterialow.md](ProdukcjaPro/ProZestawienieMaterialow.md) |
| ProZlecenie | `ProZlecenia` |  | root | [ProdukcjaPro/ProZlecenie.md](ProdukcjaPro/ProZlecenie.md) |

## Przeszeregowania

- Opis: Moduł obsługujący przeszeregowania pracowników. Zawiera mechanizmy masowych zmian warunków zatrudnienia, wynagrodzeń i stanowisk.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| ElementPrzeszeregowania | `ElementyPrzeszer` |  | child: Przeszeregowanie→Przeszeregowanie | [Przeszeregowania/ElementPrzeszeregowania.md](Przeszeregowania/ElementPrzeszeregowania.md) |
| Przeszeregowanie | `Przeszeregowania` |  | root | [Przeszeregowania/Przeszeregowanie.md](Przeszeregowania/Przeszeregowanie.md) |

## RMK

- Opis: Moduł rozliczeń międzyokresowych kosztów (RMK). Zawiera definicje harmonogramów rozliczania kosztów w czasie, pozycje rozliczeń oraz automatyczne generowanie dekretów.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| DokumentRMK | `DokumentyRMK` |  | root | [RMK/DokumentRMK.md](RMK/DokumentRMK.md) |
| KosztRMK | `KosztyRMK` |  | root | [RMK/KosztRMK.md](RMK/KosztRMK.md) |
| ObrotRMK | `ObrotyRMK` |  |  | [RMK/ObrotRMK.md](RMK/ObrotRMK.md) |

## RealEstate

- Opis: Moduł zarządzania nieruchomościami. Zawiera kartotekę nieruchomości, lokali, najemców, umowy najmu, rozliczenia mediów oraz mechanizmy fakturowania opłat.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| CelRezerwacji | `CeleRezerwacji` | konfig | root | [RealEstate/CelRezerwacji.md](RealEstate/CelRezerwacji.md) |
| DefinicjaAlgorytmuUslugi | `DefAlgUslug` | konfig | root | [RealEstate/DefinicjaAlgorytmuUslugi.md](RealEstate/DefinicjaAlgorytmuUslugi.md) |
| DefinicjaRozliczeniaMediow | `DefRozMediow` | konfig | root | [RealEstate/DefinicjaRozliczeniaMediow.md](RealEstate/DefinicjaRozliczeniaMediow.md) |
| NieruSrTrwalyRel | `NieruSrTrwaleRel` |  |  | [RealEstate/NieruSrTrwalyRel.md](RealEstate/NieruSrTrwalyRel.md) |
| NieruWydzialRel | `NieruWydzialyRel` |  |  | [RealEstate/NieruWydzialRel.md](RealEstate/NieruWydzialRel.md) |
| Nieruchomosc | `Nieruchomosci` |  | root | [RealEstate/Nieruchomosc.md](RealEstate/Nieruchomosc.md) |
| NieruchomoscHis | `NieruchomosciHis` |  | root | [RealEstate/NieruchomoscHis.md](RealEstate/NieruchomoscHis.md) |
| NieruchomoscRef | `NieruchomosciRef` |  | child: Nieruchomosc→Nieruchomosc | [RealEstate/NieruchomoscRef.md](RealEstate/NieruchomoscRef.md) |
| NieruchomoscRel | `NieruchomosciRel` |  |  | [RealEstate/NieruchomoscRel.md](RealEstate/NieruchomoscRel.md) |
| NieruchomoscUzyta | `NieruchomUzyte` |  |  | [RealEstate/NieruchomoscUzyta.md](RealEstate/NieruchomoscUzyta.md) |
| NieruchomoscZdarzenie | `NieruZdarzenia` |  | root | [RealEstate/NieruchomoscZdarzenie.md](RealEstate/NieruchomoscZdarzenie.md) |
| RezerwacjaStanowiskaPracy | `RezerStanowPracy` |  | root | [RealEstate/RezerwacjaStanowiskaPracy.md](RealEstate/RezerwacjaStanowiskaPracy.md) |
| RozliczenieMediow | `RozMediow` |  | root | [RealEstate/RozliczenieMediow.md](RealEstate/RozliczenieMediow.md) |
| StanNieruchomosci | `StanyNieruchom` | konfig | root | [RealEstate/StanNieruchomosci.md](RealEstate/StanNieruchomosci.md) |
| StanowiskoPracy | `StanowiskaPracy` |  | root | [RealEstate/StanowiskoPracy.md](RealEstate/StanowiskoPracy.md) |
| StnPracSrTrwalyRel | `StnPracSrTrwRel` |  | root | [RealEstate/StnPracSrTrwalyRel.md](RealEstate/StnPracSrTrwalyRel.md) |
| TypNieruchomosc | `TypyNieruchom` | konfig | root | [RealEstate/TypNieruchomosc.md](RealEstate/TypNieruchomosc.md) |
| UslugaNieruch | `UslugiNieruch` |  | root | [RealEstate/UslugaNieruch.md](RealEstate/UslugaNieruch.md) |
| UslugaZdarzenia | `UslugiZdarzenia` |  |  | [RealEstate/UslugaZdarzenia.md](RealEstate/UslugaZdarzenia.md) |

## Samochodowka

- Opis: Moduł ewidencji przebiegu pojazdów (kilometrówka). Zawiera rejestr pojazdów, trasy, stawki za kilometry oraz rozliczenia kosztów przejazdów służbowych.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| DefinicjaTrasy | `DefinicjeTras` |  | root | [Samochodowka/DefinicjaTrasy.md](Samochodowka/DefinicjaTrasy.md) |
| EkoPaliwoSilnika | `EkoPaliwaSilnika` | konfig |  | [Samochodowka/EkoPaliwoSilnika.md](Samochodowka/EkoPaliwoSilnika.md) |
| EkoPaliwoStawka | `EkoPaliwaStawki` | konfig | child: PaliwoSilnika→EkoPaliwoSilnika | [Samochodowka/EkoPaliwoStawka.md](Samochodowka/EkoPaliwoStawka.md) |
| EkoRodzajPaliwa | `EkoRodzajePaliw` | konfig | root | [Samochodowka/EkoRodzajPaliwa.md](Samochodowka/EkoRodzajPaliwa.md) |
| EkoRodzajSilnika | `EkoRodzSilnikow` | konfig | root | [Samochodowka/EkoRodzajSilnika.md](Samochodowka/EkoRodzajSilnika.md) |
| KosztEP | `KosztyEP` |  | root | [Samochodowka/KosztEP.md](Samochodowka/KosztEP.md) |
| PaliwoPojazdu | `PaliwaPojazdu` |  |  | [Samochodowka/PaliwoPojazdu.md](Samochodowka/PaliwoPojazdu.md) |
| Pojazd | `Pojazdy` |  | root | [Samochodowka/Pojazd.md](Samochodowka/Pojazd.md) |
| Przejazd | `Przejazdy` |  | root | [Samochodowka/Przejazd.md](Samochodowka/Przejazd.md) |
| RozliczenieEP | `RozliczeniaEP` |  | root | [Samochodowka/RozliczenieEP.md](Samochodowka/RozliczenieEP.md) |

## SrodkiTrwale

- Opis: Moduł obsługujący środki trwałe i wartości niematerialne. Zawiera kartotekę środków trwałych, dokumenty OT/LT/MT, amortyzację, inwentaryzację oraz plan amortyzacji.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| DokumentPowiazanyUL | `DokumentyPowiazaneUL` |  |  | [SrodkiTrwale/DokumentPowiazanyUL.md](SrodkiTrwale/DokumentPowiazanyUL.md) |
| DokumentST | `DokumentyST` |  | root | [SrodkiTrwale/DokumentST.md](SrodkiTrwale/DokumentST.md) |
| DokumentUL | `DokumentyUL` |  | root | [SrodkiTrwale/DokumentUL.md](SrodkiTrwale/DokumentUL.md) |
| ElemPlanuAmortyzacji | `PlanAmortyzacji` |  | child: Srodek→SrodekTrwalyBase | [SrodkiTrwale/ElemPlanuAmortyzacji.md](SrodkiTrwale/ElemPlanuAmortyzacji.md) |
| ElementPodatkuOdNieruch | `ElemPodOdNieruch` |  | child: Historia→SrodekTrwalyBaseHistoria | [SrodkiTrwale/ElementPodatkuOdNieruch.md](SrodkiTrwale/ElementPodatkuOdNieruch.md) |
| KategoriaST | `KategorieST` | konfig | root | [SrodkiTrwale/KategoriaST.md](SrodkiTrwale/KategoriaST.md) |
| KategoriaZapotrzebowania | `KategorieZap` | konfig | root | [SrodkiTrwale/KategoriaZapotrzebowania.md](SrodkiTrwale/KategoriaZapotrzebowania.md) |
| LokalizacjaNier | `LokalizacjeNier` |  | root | [SrodkiTrwale/LokalizacjaNier.md](SrodkiTrwale/LokalizacjaNier.md) |
| LokalizacjaNierHistoria | `LokalizacjeNierH` |  | child: Lokalizacja→LokalizacjaNier | [SrodkiTrwale/LokalizacjaNierHistoria.md](SrodkiTrwale/LokalizacjaNierHistoria.md) |
| MiejsceUzytkowania | `MiejscaUzytk` | konfig | root | [SrodkiTrwale/MiejsceUzytkowania.md](SrodkiTrwale/MiejsceUzytkowania.md) |
| ObrotST | `ObrotyST` |  | child: Dokument→DokumentST | [SrodkiTrwale/ObrotST.md](SrodkiTrwale/ObrotST.md) |
| ParametrOdpisu | `ParametryOdpisow` |  | child: Amortyzacja→ObrotST | [SrodkiTrwale/ParametrOdpisu.md](SrodkiTrwale/ParametrOdpisu.md) |
| PozycjaTerminarzaInw | `TerminarzInw` |  |  | [SrodkiTrwale/PozycjaTerminarzaInw.md](SrodkiTrwale/PozycjaTerminarzaInw.md) |
| ProporcjaAmortyzacji | `ProporcjeAmortyzacji` |  | child: Srodek→SrodekTrwalyBase | [SrodkiTrwale/ProporcjaAmortyzacji.md](SrodkiTrwale/ProporcjaAmortyzacji.md) |
| PrzedmiotOp | `PrzedmiotyOp` |  | child: Historia→LokalizacjaNierHistoria | [SrodkiTrwale/PrzedmiotOp.md](SrodkiTrwale/PrzedmiotOp.md) |
| RataLeasingST | `RatyLeasingST` |  | child: Srodek→SrodekTrwalyBase | [SrodkiTrwale/RataLeasingST.md](SrodkiTrwale/RataLeasingST.md) |
| RodzajPO | `RodzajePO` |  | root | [SrodkiTrwale/RodzajPO.md](SrodkiTrwale/RodzajPO.md) |
| RodzajST | `KRST` | konfig | root | [SrodkiTrwale/RodzajST.md](SrodkiTrwale/RodzajST.md) |
| SrodekTrwalyBase | `SrodkiTrwale` |  | root | [SrodkiTrwale/SrodekTrwalyBase.md](SrodkiTrwale/SrodekTrwalyBase.md) |
| SrodekTrwalyBaseHistoria | `SrodkiTrwaleHist` |  | child: Srodek→SrodekTrwalyBase | [SrodkiTrwale/SrodekTrwalyBaseHistoria.md](SrodkiTrwale/SrodekTrwalyBaseHistoria.md) |
| SrodekTrwalyLeasing | `SrodkiTrwaleLeas` |  | child: Srodek→SrodekTrwalyBase | [SrodkiTrwale/SrodekTrwalyLeasing.md](SrodkiTrwale/SrodekTrwalyLeasing.md) |
| TypOplatyLeasing | `TypyOplLeasingi` |  | child: Leasing→SrodekTrwalyLeasing | [SrodkiTrwale/TypOplatyLeasing.md](SrodkiTrwale/TypOplatyLeasing.md) |
| TypOplatyMSR | `TypyOplatMSR` | konfig | root | [SrodkiTrwale/TypOplatyMSR.md](SrodkiTrwale/TypOplatyMSR.md) |
| TytulDokumentuST | `TytulyDokST` | konfig | root | [SrodkiTrwale/TytulDokumentuST.md](SrodkiTrwale/TytulDokumentuST.md) |
| Wyposazenie | `EwidWyposazenia` |  | root | [SrodkiTrwale/Wyposazenie.md](SrodkiTrwale/Wyposazenie.md) |
| WyposazenieHistoria | `EwidWyposazeniaH` |  | child: Wyposazenie→Wyposazenie | [SrodkiTrwale/WyposazenieHistoria.md](SrodkiTrwale/WyposazenieHistoria.md) |
| ZestawST | `ZestawyST` |  | root | [SrodkiTrwale/ZestawST.md](SrodkiTrwale/ZestawST.md) |

## Support

- Opis: Moduł wsparcia technicznego i helpdesk. Zawiera zgłoszenia serwisowe, kolejki obsługi, umowy SLA, bazę wiedzy oraz mechanizmy śledzenia i eskalacji problemów.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| Evaluation | `Evaluations` |  |  | [Support/Evaluation.md](Support/Evaluation.md) |
| HistoricalState | `HistoricalStates` |  |  | [Support/HistoricalState.md](Support/HistoricalState.md) |
| NotificationConfiguration | `NotificationConf` |  |  | [Support/NotificationConfiguration.md](Support/NotificationConfiguration.md) |
| OperatorConfiguration | `OperatorsConfig` |  |  | [Support/OperatorConfiguration.md](Support/OperatorConfiguration.md) |
| OperatorToTeam | `OperatorsToTeam` | konfig | root | [Support/OperatorToTeam.md](Support/OperatorToTeam.md) |
| Priority | `TicketPriorities` | konfig | root | [Support/Priority.md](Support/Priority.md) |
| Product | `ProductsSupport` | konfig | root | [Support/Product.md](Support/Product.md) |
| ProductVersion | `ProductVersions` | konfig | root | [Support/ProductVersion.md](Support/ProductVersion.md) |
| RelationToDoc | `RelationsToDoc` |  | root | [Support/RelationToDoc.md](Support/RelationToDoc.md) |
| SLACalendar | `SLACalendars` | konfig | root | [Support/SLACalendar.md](Support/SLACalendar.md) |
| SLADocument | `SLADocuments` |  | root | [Support/SLADocument.md](Support/SLADocument.md) |
| State | `TicketStates` | konfig | root | [Support/State.md](Support/State.md) |
| SupportOperator | `SupportOperators` |  | child: Operator→Operator | [Support/SupportOperator.md](Support/SupportOperator.md) |
| Team | `Teams` |  | root | [Support/Team.md](Support/Team.md) |
| Ticket | `Tickets` |  | root | [Support/Ticket.md](Support/Ticket.md) |
| TicketDefinition | `TicketsDefs` | konfig | root | [Support/TicketDefinition.md](Support/TicketDefinition.md) |
| TicketFollower | `TicketFollowers` |  | root | [Support/TicketFollower.md](Support/TicketFollower.md) |

## Towary

- Opis: Moduł kartoteki towarów i usług obsługujący ewidencję asortymentu, jednostek miar z przelicznikami, cenników (w tym cen indywidualnych, grupowych, progowych i promocji okresowych) oraz kodów kreskowych. Definiuje schematy opakowań, zamienniki towarowe, komplety produkcyjne, klasyfikacje CN/CPV/BDO/SUP oraz mechanizmy rabatowania i wyceny.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| Cena | `Ceny` |  | child: Towar→Towar | [Towary/Cena.md](Towary/Cena.md) |
| CenaGrupowa | `CenyGrupowe` |  | root | [Towary/CenaGrupowa.md](Towary/CenaGrupowa.md) |
| CenaIndywidualna | `CenyIndywidualne` |  | child: Towar→Towar | [Towary/CenaIndywidualna.md](Towary/CenaIndywidualna.md) |
| CenaProgowa | `CenyProgowe` |  | child: Towar→Towar | [Towary/CenaProgowa.md](Towary/CenaProgowa.md) |
| DefinicjaCeny | `DefinicjeCen` | konfig | root | [Towary/DefinicjaCeny.md](Towary/DefinicjaCeny.md) |
| DostawcaTowaru | `DostawcyTowaru` |  | child: Towar→Towar | [Towary/DostawcaTowaru.md](Towary/DostawcaTowaru.md) |
| ElemOpakowan | `ElemyOpakowan` |  | child: Schemat→SchemOpakowan | [Towary/ElemOpakowan.md](Towary/ElemOpakowan.md) |
| ElementKompletu | `ElemKompletow` |  | root | [Towary/ElementKompletu.md](Towary/ElementKompletu.md) |
| Jednostka | `Jednostki` | konfig | root | [Towary/Jednostka.md](Towary/Jednostka.md) |
| KodBDO | `KodyBDO` |  | root | [Towary/KodBDO.md](Towary/KodBDO.md) |
| KodCN | `KodyCN` |  | root | [Towary/KodCN.md](Towary/KodCN.md) |
| KodCPV | `KodyCPV` |  | root | [Towary/KodCPV.md](Towary/KodCPV.md) |
| KodSUP | `KodySUP` |  | root | [Towary/KodSUP.md](Towary/KodSUP.md) |
| KodTwrKontrahent | `KodyTwrKontrah` |  |  | [Towary/KodTwrKontrahent.md](Towary/KodTwrKontrahent.md) |
| PrzecenaOkresowa | `PrzecenyOkres` |  | root | [Towary/PrzecenaOkresowa.md](Towary/PrzecenaOkresowa.md) |
| PrzecenaOkresowaTowaru | `PrzecenyOkresTwr` |  |  | [Towary/PrzecenaOkresowaTowaru.md](Towary/PrzecenaOkresowaTowaru.md) |
| PrzecenaOkresowaTowaruSchematGratisow | `PrzOkresTwrSchGr` |  |  | [Towary/PrzecenaOkresowaTowaruSchematGratisow.md](Towary/PrzecenaOkresowaTowaruSchematGratisow.md) |
| Przelicznik | `Przeliczniki` | konfig | child: Wyliczana→Jednostka | [Towary/Przelicznik.md](Towary/Przelicznik.md) |
| PrzelicznikTowaru | `PrzelTow` |  | child: Towar→Towar | [Towary/PrzelicznikTowaru.md](Towary/PrzelicznikTowaru.md) |
| SchemOpakowan | `SchemyOpakowan` |  | root | [Towary/SchemOpakowan.md](Towary/SchemOpakowan.md) |
| SchematTowar | `SchematyTowary` |  | child: SchematOpakowan→SchemOpakowan | [Towary/SchematTowar.md](Towary/SchematTowar.md) |
| Towar | `Towary` |  | root | [Towary/Towar.md](Towary/Towar.md) |
| TowarEcommerce | `TowaryEcommerce` |  |  | [Towary/TowarEcommerce.md](Towary/TowarEcommerce.md) |
| TowarMagazynInfo | `TowarMagazyn` |  | child: Towar→Towar | [Towary/TowarMagazynInfo.md](Towary/TowarMagazynInfo.md) |
| TowarUlubiony | `TowaryUlubione` |  | child: Zapis→ITowaryUlubioneHost | [Towary/TowarUlubiony.md](Towary/TowarUlubiony.md) |
| WariantTowaru | `WariantyTowaru` |  |  | [Towary/WariantTowaru.md](Towary/WariantTowaru.md) |
| ZamiennikTowaru | `ZamiennikiTowaru` |  | child: Towar→Towar | [Towary/ZamiennikTowaru.md](Towary/ZamiennikTowaru.md) |

## Vehicles

- Opis: Moduł zarządzania flotą pojazdów. Zawiera kartotekę pojazdów, przeglądy, ubezpieczenia, tankowania, koszty eksploatacji oraz przypisania kierowców.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| DamageEvent | `DamageEvents` |  | root | [Vehicles/DamageEvent.md](Vehicles/DamageEvent.md) |
| Fine | `Fines` |  | root | [Vehicles/Fine.md](Vehicles/Fine.md) |
| Insurance | `Insurances` |  | root | [Vehicles/Insurance.md](Vehicles/Insurance.md) |
| Reservation | `Reservations` |  | root | [Vehicles/Reservation.md](Vehicles/Reservation.md) |
| ReservationDef | `ReservationDefs` | konfig | root | [Vehicles/ReservationDef.md](Vehicles/ReservationDef.md) |
| ReservationState | `ReservStates` | konfig | root | [Vehicles/ReservationState.md](Vehicles/ReservationState.md) |
| TechInspection | `TechInspections` |  | root | [Vehicles/TechInspection.md](Vehicles/TechInspection.md) |
| UsedVehicle | `UsedVehicles` |  |  | [Vehicles/UsedVehicle.md](Vehicles/UsedVehicle.md) |
| VehicleAssetRel | `VehicleAssetsRel` |  |  | [Vehicles/VehicleAssetRel.md](Vehicles/VehicleAssetRel.md) |
| VehicleDetails | `VehiclesDetails` |  | root | [Vehicles/VehicleDetails.md](Vehicles/VehicleDetails.md) |
| VehicleEvent | `VehicleEvents` |  | root | [Vehicles/VehicleEvent.md](Vehicles/VehicleEvent.md) |
| VehicleHis | `VehiclesHis` |  | root | [Vehicles/VehicleHis.md](Vehicles/VehicleHis.md) |
| VehicleReading | `VehicleReadings` |  | root | [Vehicles/VehicleReading.md](Vehicles/VehicleReading.md) |
| VehicleService | `VehicleServices` |  |  | [Vehicles/VehicleService.md](Vehicles/VehicleService.md) |
| VehicleState | `VehicleStates` | konfig | root | [Vehicles/VehicleState.md](Vehicles/VehicleState.md) |
| VehicleType | `VehicleTypes` | konfig | root | [Vehicles/VehicleType.md](Vehicles/VehicleType.md) |

## Waluty

- Opis: Moduł obsługujący kursy walut i tabele kursowe. Zawiera definicje walut, tabele kursowe z NBP i ECB oraz mechanizmy przeliczania wartości walutowych.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| KursWaluty | `KursyWalut` | konfig | child: Tabela→TabelaKursowa | [Waluty/KursWaluty.md](Waluty/KursWaluty.md) |
| TabelaKursowa | `TabeleKursowe` | konfig | root | [Waluty/TabelaKursowa.md](Waluty/TabelaKursowa.md) |
| Waluta | `Waluty` | konfig | root | [Waluty/Waluta.md](Waluty/Waluta.md) |

## WebAuthorization

- Opis: Moduł autoryzacji webowej. Zawiera definicje uprawnień, tokenów dostępu oraz mechanizmy uwierzytelniania użytkowników aplikacji webowych enova365.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| WebProfile | `WebProfiles` |  | root | [WebAuthorization/WebProfile.md](WebAuthorization/WebProfile.md) |
| WebReport | `WebReports` |  | root | [WebAuthorization/WebReport.md](WebAuthorization/WebReport.md) |
| WebReportRole | `WebReportRoles` |  | child: Report→WebReport | [WebAuthorization/WebReportRole.md](WebAuthorization/WebReportRole.md) |
| WebUser | `WebUsers` |  | root | [WebAuthorization/WebUser.md](WebAuthorization/WebUser.md) |

## Windykacja

- Opis: Moduł obsługujący procesy windykacji należności. Zawiera definicje schematów windykacyjnych, akcje windykacyjne, monity oraz śledzenie statusów windykacji kontrahentów.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| DefinicjaSprawyWindykacyjnej | `DefSprawWind` | konfig | root | [Windykacja/DefinicjaSprawyWindykacyjnej.md](Windykacja/DefinicjaSprawyWindykacyjnej.md) |
| EtapDefinicjiWindykacji | `EtapyDefWind` | konfig | root | [Windykacja/EtapDefinicjiWindykacji.md](Windykacja/EtapDefinicjiWindykacji.md) |
| PozycjaSprawyWindykacyjnej | `PozSprawWind` |  | child: Sprawa→SprawaWindykacyjna | [Windykacja/PozycjaSprawyWindykacyjnej.md](Windykacja/PozycjaSprawyWindykacyjnej.md) |
| SprawaWindykacyjna | `SprawyWindyk` |  | root | [Windykacja/SprawaWindykacyjna.md](Windykacja/SprawaWindykacyjna.md) |
| StanWindykacji | `StanyWindykacji` | konfig | root | [Windykacja/StanWindykacji.md](Windykacja/StanWindykacji.md) |
| Windykacja | `Windykacje` |  | child: Dokument→IRozliczalny | [Windykacja/Windykacja.md](Windykacja/Windykacja.md) |

## Workflow

- Opis: Moduł automatyzacji procesów biznesowych (workflow). Zawiera definicje procesów, kroki, warunki, akcje automatyczne oraz mechanizmy sterowania obiegiem dokumentów.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| OGSchema | `OGSchemas` | konfig | root | [Workflow/OGSchema.md](Workflow/OGSchema.md) |
| PreviewPage | `PreviewPages` | konfig | root | [Workflow/PreviewPage.md](Workflow/PreviewPage.md) |
| WFDefItem | `WFDefItems` | konfig | root | [Workflow/WFDefItem.md](Workflow/WFDefItem.md) |
| WFDefinition | `WFDefs` | konfig | root | [Workflow/WFDefinition.md](Workflow/WFDefinition.md) |
| WFItemDescription | `WFItemDescs` | konfig | root | [Workflow/WFItemDescription.md](Workflow/WFItemDescription.md) |
| WFItemDescriptionRel | `WFItemDescRels` | konfig | child: Description→IWFItemDescription | [Workflow/WFItemDescriptionRel.md](Workflow/WFItemDescriptionRel.md) |
| WFProcessRole | `WFProcessRoles` | konfig | root | [Workflow/WFProcessRole.md](Workflow/WFProcessRole.md) |
| WFRecipient | `WFRecipients` | konfig | child: Host→IWFRecipientHost | [Workflow/WFRecipient.md](Workflow/WFRecipient.md) |
| WFTransition | `WFTransitions` | konfig | root | [Workflow/WFTransition.md](Workflow/WFTransition.md) |
| WFTransitionDefinition | `WFTransitionDefs` | konfig | root | [Workflow/WFTransitionDefinition.md](Workflow/WFTransitionDefinition.md) |
| WFWorkflow | `WFWorkflows` |  | root | [Workflow/WFWorkflow.md](Workflow/WFWorkflow.md) |
| WfPlugIn | `WfPlugIns` | konfig | root | [Workflow/WfPlugIn.md](Workflow/WfPlugIn.md) |
| WfPlugInItem | `WfPlugInItems` | konfig | root | [Workflow/WfPlugInItem.md](Workflow/WfPlugInItem.md) |
| WfPlugInItemReference | `WfPlugInItemsRef` | konfig | child: Host→IWfPlugInItemReferenceHost | [Workflow/WfPlugInItemReference.md](Workflow/WfPlugInItemReference.md) |
| WfPlugInReference | `WfPlugInsRef` | konfig | child: Definition→IWfPlugInReferenceHost | [Workflow/WfPlugInReference.md](Workflow/WfPlugInReference.md) |
| WfTaskFlowError | `WfTaskFlowErrors` |  | child: Task→Task | [Workflow/WfTaskFlowError.md](Workflow/WfTaskFlowError.md) |
| WfTaskSource | `WfTaskSources` | konfig | child: TaskDefinition→TaskDefinition | [Workflow/WfTaskSource.md](Workflow/WfTaskSource.md) |

## Zadania

- Opis: Moduł zarządzania zadaniami i projektami. Zawiera definicje zadań, harmonogramy, przypisania, śledzenie czasu pracy (TimeTrack) oraz rozliczanie realizacji.

| RowType | Tabela | Konfig | Guided | Plik |
|---------|--------|--------|--------|------|
| AvaliableCorrespondenceState | `AvalCorreStates` | konfig |  | [Zadania/AvaliableCorrespondenceState.md](Zadania/AvaliableCorrespondenceState.md) |
| AvaliableProjectState | `AvalProjStates` | konfig |  | [Zadania/AvaliableProjectState.md](Zadania/AvaliableProjectState.md) |
| AvaliableState | `AvaliableStates` | konfig |  | [Zadania/AvaliableState.md](Zadania/AvaliableState.md) |
| BudgetPeriod | `BudgetPeriods` | konfig | root | [Zadania/BudgetPeriod.md](Zadania/BudgetPeriod.md) |
| BudzetObrot | `BudzetObroty` |  | child: Pozycja→PozycjaBudzProj | [Zadania/BudzetObrot.md](Zadania/BudzetObrot.md) |
| BudzetProjektu | `BudzetyProjektu` |  | root | [Zadania/BudzetProjektu.md](Zadania/BudzetProjektu.md) |
| BudzetUprawnienie | `BudzetUprawn` |  |  | [Zadania/BudzetUprawnienie.md](Zadania/BudzetUprawnienie.md) |
| CtiAccount | `CtiAccounts` |  | root | [Zadania/CtiAccount.md](Zadania/CtiAccount.md) |
| CtiCallTransferLog | `CallTransferLogs` |  | root | [Zadania/CtiCallTransferLog.md](Zadania/CtiCallTransferLog.md) |
| DefBudget | `DefBudgets` | konfig | root | [Zadania/DefBudget.md](Zadania/DefBudget.md) |
| DefBudgetAspect | `DefBudgetAspects` | konfig | root | [Zadania/DefBudgetAspect.md](Zadania/DefBudgetAspect.md) |
| DefBudgetCategory | `DefBudgetCateg` | konfig | root | [Zadania/DefBudgetCategory.md](Zadania/DefBudgetCategory.md) |
| DefBudgetCategoryRelation | `DefBudgetCatRel` | konfig | root | [Zadania/DefBudgetCategoryRelation.md](Zadania/DefBudgetCategoryRelation.md) |
| DefKampania | `DefKampanii` | konfig | root | [Zadania/DefKampania.md](Zadania/DefKampania.md) |
| DefKoresp | `DefsKoresp` | konfig | root | [Zadania/DefKoresp.md](Zadania/DefKoresp.md) |
| DefPlanVersion | `DefPlanVersions` | konfig | root | [Zadania/DefPlanVersion.md](Zadania/DefPlanVersion.md) |
| DefPlanuSprzedazy | `DefPlanSprzed` | konfig | root | [Zadania/DefPlanuSprzedazy.md](Zadania/DefPlanuSprzedazy.md) |
| DefProjektu | `DefProjektow` | konfig | root | [Zadania/DefProjektu.md](Zadania/DefProjektu.md) |
| DefRealizacjiPlanu | `DefRealPlanow` | konfig | root | [Zadania/DefRealizacjiPlanu.md](Zadania/DefRealizacjiPlanu.md) |
| DefZadanDbTupleDefinitionExt | `DefZadanTDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition | [Zadania/DefZadanDbTupleDefinitionExt.md](Zadania/DefZadanDbTupleDefinitionExt.md) |
| DefZadania | `DefZadan` | konfig | root | [Zadania/DefZadania.md](Zadania/DefZadania.md) |
| DefZadaniaRelacja | `DefZadanRelacje` | konfig | root | [Zadania/DefZadaniaRelacja.md](Zadania/DefZadaniaRelacja.md) |
| DokumentCRM | `DokumentyCRM` |  | child: Host→IDocumentHostCRM | [Zadania/DokumentCRM.md](Zadania/DokumentCRM.md) |
| EtapDefProjektu | `EtapyDefProjektu` | konfig | child: Definicja→DefProjektu | [Zadania/EtapDefProjektu.md](Zadania/EtapDefProjektu.md) |
| EtapProjektu | `EtapyProjektu` |  | child: Projekt→Projekt | [Zadania/EtapProjektu.md](Zadania/EtapProjektu.md) |
| EtapWykonujacy | `EtapyWykonujacy` |  |  | [Zadania/EtapWykonujacy.md](Zadania/EtapWykonujacy.md) |
| EventDetail | `EventDetails` |  | root | [Zadania/EventDetail.md](Zadania/EventDetail.md) |
| EventParticipant | `EventPartic` |  |  | [Zadania/EventParticipant.md](Zadania/EventParticipant.md) |
| GoogleCalendar | `GoogleCalendars` |  | root | [Zadania/GoogleCalendar.md](Zadania/GoogleCalendar.md) |
| HistZadania | `HistZadan` |  | child: Zadanie→Zadanie | [Zadania/HistZadania.md](Zadania/HistZadania.md) |
| Kampania | `Kampanie` |  | root | [Zadania/Kampania.md](Zadania/Kampania.md) |
| KategoriaAkt | `KategorieAkt` | konfig | root | [Zadania/KategoriaAkt.md](Zadania/KategoriaAkt.md) |
| KontrahentRealizacji | `KntRealizacji` | konfig |  | [Zadania/KontrahentRealizacji.md](Zadania/KontrahentRealizacji.md) |
| Korespondencja | `Korespondencje` |  | root | [Zadania/Korespondencja.md](Zadania/Korespondencja.md) |
| KwotaBudzProj | `KwotyBudzProj` |  | root | [Zadania/KwotaBudzProj.md](Zadania/KwotaBudzProj.md) |
| ModelUrz | `ModeleUrz` |  | root | [Zadania/ModelUrz.md](Zadania/ModelUrz.md) |
| PlanSprzedazowy | `PlanySprzedazowe` |  | root | [Zadania/PlanSprzedazowy.md](Zadania/PlanSprzedazowy.md) |
| PlanVariant | `PlanVariants` | konfig | child: DefBudget→DefBudget | [Zadania/PlanVariant.md](Zadania/PlanVariant.md) |
| PlanVariantRel | `PlanVariantsRel` | konfig | root | [Zadania/PlanVariantRel.md](Zadania/PlanVariantRel.md) |
| PlanowanyPrzeglad | `PlanPrzeglady` |  | root | [Zadania/PlanowanyPrzeglad.md](Zadania/PlanowanyPrzeglad.md) |
| PodmiotZadanie | `PodmiotyZadania` |  | child: Zadanie→Zadanie | [Zadania/PodmiotZadanie.md](Zadania/PodmiotZadanie.md) |
| PozycjaBudzProj | `PozycjeBudzProj` |  | root | [Zadania/PozycjaBudzProj.md](Zadania/PozycjaBudzProj.md) |
| PriorytetZadania | `PriorytetyZadan` | konfig | root | [Zadania/PriorytetZadania.md](Zadania/PriorytetZadania.md) |
| Projekt | `Projekty` |  | root | [Zadania/Projekt.md](Zadania/Projekt.md) |
| ProjektWykonujacy | `ProjektyWyk` |  |  | [Zadania/ProjektWykonujacy.md](Zadania/ProjektWykonujacy.md) |
| RecordEvent | `RecordEvents` |  | root | [Zadania/RecordEvent.md](Zadania/RecordEvent.md) |
| StanKoresp | `StanyKoresp` | konfig | root | [Zadania/StanKoresp.md](Zadania/StanKoresp.md) |
| StanPlanu | `StanyPlanu` | konfig | root | [Zadania/StanPlanu.md](Zadania/StanPlanu.md) |
| StanProjektu | `StanyProjektu` | konfig | root | [Zadania/StanProjektu.md](Zadania/StanProjektu.md) |
| StanZadania | `StanyZadania` | konfig | root | [Zadania/StanZadania.md](Zadania/StanZadania.md) |
| TowarRealizacji | `TowaryRealizacji` | konfig |  | [Zadania/TowarRealizacji.md](Zadania/TowarRealizacji.md) |
| TypUrzadzenia | `TypyUrzadzen` | konfig | root | [Zadania/TypUrzadzenia.md](Zadania/TypUrzadzenia.md) |
| TypZadania | `TypyZadan` | konfig | child: Definicja→DefZadania | [Zadania/TypZadania.md](Zadania/TypZadania.md) |
| Urzadzenie | `Urzadzenia` |  | root | [Zadania/Urzadzenie.md](Zadania/Urzadzenie.md) |
| UrzadzenieUzyte | `UrzadzeniaUzyte` |  |  | [Zadania/UrzadzenieUzyte.md](Zadania/UrzadzenieUzyte.md) |
| WersjaPlanu | `WersjePlanu` |  | root | [Zadania/WersjaPlanu.md](Zadania/WersjaPlanu.md) |
| ZadaniaDbTupleDefinitionExt | `ZadaniaTDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition | [Zadania/ZadaniaDbTupleDefinitionExt.md](Zadania/ZadaniaDbTupleDefinitionExt.md) |
| Zadanie | `Zadania` |  | root | [Zadania/Zadanie.md](Zadania/Zadanie.md) |
| ZadanieDnia | `ZadaniaDnia` |  | root | [Zadania/ZadanieDnia.md](Zadania/ZadanieDnia.md) |
| ZasobCRM | `ZasobyCRM` |  | child: Zadanie→Zadanie | [Zadania/ZasobCRM.md](Zadania/ZasobCRM.md) |
| Zespol | `Zespoly` | konfig | root | [Zadania/Zespol.md](Zadania/Zespol.md) |

