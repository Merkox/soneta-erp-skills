# Moduł `Workflow` — tabele biznesowe

- Opis: Moduł automatyzacji procesów biznesowych (workflow). Zawiera definicje procesów, kroki, warunki, akcje automatyczne oraz mechanizmy sterowania obiegiem dokumentów.
- Tabel: **17**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| OGSchema | Schematy generatora obiektów workflow | `OGSchemas` | konfig | root |  | IOGSchema, IWorkflowItemDescriptionHost |  | [OGSchema.md](OGSchema.md) |
| PreviewPage | Okna podglądu | `PreviewPages` | konfig | root |  |  |  | [PreviewPage.md](PreviewPage.md) |
| WFDefItem | Wzorce definicji zadań | `WFDefItems` | konfig | root |  | IWFDefItem, IWfPlugInItemReferenceHost | DefinitionTypeEnum (2) | [WFDefItem.md](WFDefItem.md) |
| WFDefinition | Definicja procesów | `WFDefs` | konfig | root |  | IRightsSource, IWFDefinition, ICodeFileHost, IWfPlugInReferenceHost, ISysNotificationReference, IWizardReferenceHost | DefinitionTypeEnum (2) | [WFDefinition.md](WFDefinition.md) |
| WFItemDescription | Komentarze do elementów workflow | `WFItemDescs` | konfig | root |  |  |  | [WFItemDescription.md](WFItemDescription.md) |
| WFItemDescriptionRel | Komentarze do elementów workflow | `WFItemDescRels` | konfig | child: Description→IWFItemDescription |  |  |  | [WFItemDescriptionRel.md](WFItemDescriptionRel.md) |
| WFProcessRole | Role procesowe | `WFProcessRoles` | konfig | root |  | IWfPlugInItemReferenceHost, IWFRecipientHost | DefinitionTypeEnum (2) | [WFProcessRole.md](WFProcessRole.md) |
| WFRecipient | Odbiorcy kroku workflow | `WFRecipients` | konfig | child: Host→IWFRecipientHost |  |  |  | [WFRecipient.md](WFRecipient.md) |
| WFTransition | Tranzycje | `WFTransitions` | konfig | root |  | IWFTransition, IWfPlugInItemReferenceHost | DefinitionTypeEnum (2) | [WFTransition.md](WFTransition.md) |
| WFTransitionDefinition | Wzorce tranzycji | `WFTransitionDefs` | konfig | root |  | IWfPlugInItemReferenceHost | DefinitionTypeEnum (2) | [WFTransitionDefinition.md](WFTransitionDefinition.md) |
| WFWorkflow | Procesy | `WFWorkflows` |  | root |  | IWFWorkflow, IWFFeatureDefs, IDokument | DefinitionTypeEnum (2) | [WFWorkflow.md](WFWorkflow.md) |
| WfPlugIn | Wtyczki definicji procesów | `WfPlugIns` | konfig | root |  | IWfPlugInItemHost, ICodeFileHost |  | [WfPlugIn.md](WfPlugIn.md) |
| WfPlugInItem | Wtyczki elementów procesu | `WfPlugInItems` | konfig | root |  | IWfPlugInItemHost | WfPlugInItemType (6) | [WfPlugInItem.md](WfPlugInItem.md) |
| WfPlugInItemReference | Powiązania wtyczek elementów procesów | `WfPlugInItemsRef` | konfig | child: Host→IWfPlugInItemReferenceHost |  | IWFRecipientHost |  | [WfPlugInItemReference.md](WfPlugInItemReference.md) |
| WfPlugInReference | Powiązania wtyczek definicji procesów | `WfPlugInsRef` | konfig | child: Definition→IWfPlugInReferenceHost |  |  |  | [WfPlugInReference.md](WfPlugInReference.md) |
| WfTaskFlowError | Błędy przeliczania zadań | `WfTaskFlowErrors` |  | child: Task→Task |  |  |  | [WfTaskFlowError.md](WfTaskFlowError.md) |
| WfTaskSource | Źródła zadań | `WfTaskSources` | konfig | child: TaskDefinition→TaskDefinition |  | IWfPlugInItemReferenceHost | DefinitionTypeEnum (1) | [WfTaskSource.md](WfTaskSource.md) |

