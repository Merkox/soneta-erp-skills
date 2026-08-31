# Moduł `Business` — tabele biznesowe

- Opis: Moduł systemowy zawierający podstawowe definicje typów danych, struktur tabel oraz obiektów bazodanowych platformy enova365. Definiuje typy proste (string, int, decimal, date itp.), konfigurację systemu, uprawnienia, powiadomienia i mechanizmy wersjonowania.
- Tabel: **69**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| AppToken | Tokeny aplikacyjne | `AppTokens` | konfig | root |  |  |  | [AppToken.md](AppToken.md) |
| AppTokenItem | Instancje tokena aplikacyjnego | `AppTokenItems` | konfig | root |  |  |  | [AppTokenItem.md](AppTokenItem.md) |
| AppTokenRight | Uprawnienia tokena aplikacyjnego | `AppTokenRights` | konfig | root |  |  |  | [AppTokenRight.md](AppTokenRight.md) |
| Attachment | Załączniki | `Attachments` |  |  |  | IPermissionClient |  | [Attachment.md](Attachment.md) |
| AttachmentFile | Dane binarne załączników | `AttachmentFiles` |  |  |  |  |  | [AttachmentFile.md](AttachmentFile.md) |
| CatRolRelation | Rola powiązana z kategorią. | `CatRolRelations` |  |  |  |  |  | [CatRolRelation.md](CatRolRelation.md) |
| CfgAttribute | Dane konfiguracji | `CfgAttributes` | konfig | child: Node→CfgNode |  |  |  | [CfgAttribute.md](CfgAttribute.md) |
| CfgNode | Konfiguracja | `CfgNodes` | konfig | root |  |  |  | [CfgNode.md](CfgNode.md) |
| ChangeInfo | Historia zmian | `ChangeInfos` |  |  |  |  |  | [ChangeInfo.md](ChangeInfo.md) |
| CredentialKey | Klucze Mfa | `CredentialKeys` |  | root |  |  |  | [CredentialKey.md](CredentialKey.md) |
| DBGroup | Grupy baz danych | `DBGroups` | konfig | root |  |  |  | [DBGroup.md](DBGroup.md) |
| DBGroupItem | Pozycje grupy bazy danych | `DBGroupItems` | konfig |  |  |  |  | [DBGroupItem.md](DBGroupItem.md) |
| DBItem | Bazy danych | `DBItems` | konfig | root |  | IRightsSource |  | [DBItem.md](DBItem.md) |
| DashboardArea | Obszary | `DashbrdAreas` | konfig | root |  |  |  | [DashboardArea.md](DashboardArea.md) |
| DashboardView | Panele | `DashbrdViews` | konfig | root |  | IRightsSource | DashboardViewType (5) | [DashboardView.md](DashboardView.md) |
| DashboardViewAdjustment | Modyfikacje kafelków | `DashbrdViewAdjs` | konfig | child: Tile→DashboardViewTile |  |  |  | [DashboardViewAdjustment.md](DashboardViewAdjustment.md) |
| DashboardViewTile | Kafelki pulpitów | `DashbrdViewTiles` | konfig | child: Dashboard→DashboardView |  |  |  | [DashboardViewTile.md](DashboardViewTile.md) |
| DictionaryItem | Słownik | `Dictionary` |  | root |  |  |  | [DictionaryItem.md](DictionaryItem.md) |
| Entitle | Uprawnienia | `Entitles` | konfig | root |  | IEntitle |  | [Entitle.md](Entitle.md) |
| EntitleRef | Referencje uprawnień | `EntitleRefs` |  | child: Entitle→Entitle |  |  |  | [EntitleRef.md](EntitleRef.md) |
| EntitleRole | Role uprawnienia | `EntitleRoles` |  | child: Entitle→Entitle |  |  |  | [EntitleRole.md](EntitleRole.md) |
| ExternalDatabase | Zewnętrzne bazy danych | `ExtDatabases` | konfig | root |  | IRightsSource | ExternalDatabaseArea (1) | [ExternalDatabase.md](ExternalDatabase.md) |
| FeatureDefinition | Definicje cechy | `FeatureDefs` | konfig | root |  |  |  | [FeatureDefinition.md](FeatureDefinition.md) |
| FeatureSetDefinition | Definicje zestawu pól | `FSDefs` | konfig | root |  |  |  | [FeatureSetDefinition.md](FeatureSetDefinition.md) |
| FeatureSetDefinitionItem | Pola danych zestawów pól | `FSDefItems` | konfig | root |  |  |  | [FeatureSetDefinitionItem.md](FeatureSetDefinitionItem.md) |
| FeatureSetRelation | Powiązania obiektów z definicjami zestawów pól | `FSRels` |  | child: FeatureSetDefinition→FeatureSetDefinition |  |  |  | [FeatureSetRelation.md](FeatureSetRelation.md) |
| FeatureTransferDefinition | Definicje transferu cechy | `FeatureTrDefs` | konfig | root |  |  |  | [FeatureTransferDefinition.md](FeatureTransferDefinition.md) |
| GuidMap |  | `GuidMaps` |  |  |  |  |  | [GuidMap.md](GuidMap.md) |
| HistAktualizacja | AktualizacjaHists | `HistAktualizacje` | konfig | root |  |  |  | [HistAktualizacja.md](HistAktualizacja.md) |
| LockInfo | Edytowane zapisy | `LockInfos` |  |  |  |  |  | [LockInfo.md](LockInfo.md) |
| NotifRead | Powiadomienia odczytane | `NotifsRead` |  |  |  |  |  | [NotifRead.md](NotifRead.md) |
| NotificationCategory | NotificationCategory | `NotifiCategories` | konfig | root |  |  |  | [NotificationCategory.md](NotificationCategory.md) |
| Operator | Operator | `Operators` | konfig | root |  | IŹródłoPowiązaniaStrukturyOrganizacyjnej, ITaskUser, IAuthorised, INoticeRecipient, IMfaOperator |  | [Operator.md](Operator.md) |
| OperatorEntitle | Uprawnienia operatora | `OperatorEntitles` | konfig | child: Operator→Operator |  |  |  | [OperatorEntitle.md](OperatorEntitle.md) |
| OperatorEx | Dodatkowe ustawienia operatora | `OperatorsEx` |  | child: Operator→Operator |  |  |  | [OperatorEx.md](OperatorEx.md) |
| PivotView | Raporty przestawne | `PivotViews` | konfig | root |  | IRightsSource | PivotViewType (2) | [PivotView.md](PivotView.md) |
| PivotViewDefaultStyle | Domyślne układy tabel przestawnych | `PivotDftStyles` | konfig | child: PivotView→PivotView |  |  |  | [PivotViewDefaultStyle.md](PivotViewDefaultStyle.md) |
| PivotViewStyle | Układy tabel przestawnych | `PivotViewStyles` | konfig | root |  |  |  | [PivotViewStyle.md](PivotViewStyle.md) |
| RecordPermission | Prawa rekordów | `RecordPerms` |  |  |  |  |  | [RecordPermission.md](RecordPermission.md) |
| RemoteFile | Informacje o plikach zdalnych | `RemoteFiles` |  |  |  |  |  | [RemoteFile.md](RemoteFile.md) |
| Right | Prawo dostępu | `Rights` |  | child: Entitle→IEntitle |  |  |  | [Right.md](Right.md) |
| RoleCategory | Kategorie roli | `RolesCategory` | konfig | root |  |  |  | [RoleCategory.md](RoleCategory.md) |
| RozlDBWlascPIT | Rozliczenia podatkowe bazy danych - PIT Właściciela | `RozlDBWlascPITy` |  |  |  |  |  | [RozlDBWlascPIT.md](RozlDBWlascPIT.md) |
| RozlDBWlascRycz | Rozliczenia podatkowe bazy danych - Ryczałt Właściciela | `RozlDBWlascRyczy` |  |  |  |  |  | [RozlDBWlascRycz.md](RozlDBWlascRycz.md) |
| RozlDBWlascZUS | Rozliczenia podatkowe bazy danych - ZUS Właściciela | `RozlDBWlascZUSy` |  |  |  |  |  | [RozlDBWlascZUS.md](RozlDBWlascZUS.md) |
| RozliczenieDB | Rozliczenia podatkowe bazy danych | `RozliczeniaDB` |  |  |  |  |  | [RozliczenieDB.md](RozliczenieDB.md) |
| RuntimeEnum | Enumy dla runtime | `RuntimeEnums` |  | child: Definition→RuntimeFieldDefinition |  |  |  | [RuntimeEnum.md](RuntimeEnum.md) |
| RuntimeFieldDefinition | Definicje pól dynamicznych | `RuntimeFieldDefs` | konfig | root |  |  | RuntimeRowType (1) | [RuntimeFieldDefinition.md](RuntimeFieldDefinition.md) |
| RuntimeProject | Projekty | `RuntimeProjects` | konfig | root |  |  |  | [RuntimeProject.md](RuntimeProject.md) |
| RuntimeProjectReference | Zależności projektów | `RuntimeProjRef` | konfig | child: RuntimeProject→RuntimeProject |  |  |  | [RuntimeProjectReference.md](RuntimeProjectReference.md) |
| RuntimeRowRelation | Relacje wierszy runtime | `RuntimeRowRels` |  |  |  |  |  | [RuntimeRowRelation.md](RuntimeRowRelation.md) |
| RuntimeSolution | Rozwiązania | `RuntimeSolutions` | konfig | root |  |  |  | [RuntimeSolution.md](RuntimeSolution.md) |
| SingleUseToken | Tokeny jednorazowe | `SingleUseTokens` |  | root |  |  |  | [SingleUseToken.md](SingleUseToken.md) |
| SysNotification | Powiadomienia | `SysNotifications` | konfig | root |  | IWfPlugInItemReferenceHost, IWFRecipientHost | DefinitionTypeEnum (3) | [SysNotification.md](SysNotification.md) |
| SysNotificationRef | Referencje do powiadomień | `SysNotRefs` |  | child: Notification→SysNotification |  |  |  | [SysNotificationRef.md](SysNotificationRef.md) |
| SystemFile | Systemowe pliki dodatkowe | `SystemFiles` | konfig | root |  |  | SystemFileTypes (2) | [SystemFile.md](SystemFile.md) |
| SystemInfo | Informacja systemowa | `SystemInfos` |  |  |  |  |  | [SystemInfo.md](SystemInfo.md) |
| SystemRole | Role systemowe | `SystemRoles` | konfig | root |  | IEntitle |  | [SystemRole.md](SystemRole.md) |
| SystemRoleRef | Referencje roli | `SystemRoleRefs` |  | child: Role→SystemRole |  |  |  | [SystemRoleRef.md](SystemRoleRef.md) |
| Task | Zadania | `Tasks` |  | root |  |  |  | [Task.md](Task.md) |
| TaskDefinition | Definicje zadań | `TaskDefs` | konfig | root |  | IWizardReferenceHost, IWfPlugInItemReferenceHost, IWorkflowItemDescriptionHost, IWFRecipientHost, ISysNotificationHost, IPreviewPageHost, ISysNotificationReference |  | [TaskDefinition.md](TaskDefinition.md) |
| TaskHistoryRel | Historie zadań | `TaskHistoryRels` |  |  |  |  |  | [TaskHistoryRel.md](TaskHistoryRel.md) |
| TaskLinkedObj | Kolekcja obiektów do których task będzie podpięty. | `TaskLinkedObjs` |  |  |  |  |  | [TaskLinkedObj.md](TaskLinkedObj.md) |
| TaskTrigger | Kolekcja klas mających wpływ na przetworzenie taska | `TaskTriggers` | konfig | child: TaskDefinition→TaskDefinition |  | IWfPlugInItemReferenceHost |  | [TaskTrigger.md](TaskTrigger.md) |
| UserGroup | Grupy użytkowników | `UserGroups` | konfig | root |  | IAuthorised |  | [UserGroup.md](UserGroup.md) |
| UserGroupMember | Członkowie grupy użytkowników | `UserGroupMembers` | konfig | child: UserGroup→UserGroup |  |  |  | [UserGroupMember.md](UserGroupMember.md) |
| WizardDefinition | Definicje kreatorów | `WizardDefs` | konfig | root |  |  |  | [WizardDefinition.md](WizardDefinition.md) |
| WizardReference | Powiązania kreatorów | `WizardReferences` | konfig | child: Host→IWizardReferenceHost |  |  |  | [WizardReference.md](WizardReference.md) |
| WizardStepDefinition | Definicje kroków kreatorów | `WizardStepDefs` | konfig | root |  |  |  | [WizardStepDefinition.md](WizardStepDefinition.md) |

