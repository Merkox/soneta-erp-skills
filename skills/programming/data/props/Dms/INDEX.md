# Moduł `Dms` — tabele biznesowe

- Opis: Moduł zarządzania dokumentami (DMS). Zawiera rejestry dokumentów, kategorie, statusy, obiegi oraz mechanizmy archiwizacji i wersjonowania dokumentów.
- Tabel: **19**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| BDocBusEnt | Podmioty związane z dokumentem | `BDocBusEnts` |  |  |  |  |  | [BDocBusEnt.md](BDocBusEnt.md) |
| BasicDocKind | Rodzaje dokumentów podstawowych | `BasicDocKinds` |  | root |  |  |  | [BasicDocKind.md](BasicDocKind.md) |
| BasicDocument | Dokumenty podstawowe | `BasicDocs` |  | root |  | IPermissionClient, IEmailElement, IDaneKontrahentaHost, IDokument, IChronoOrderHost, IDmsArchInfoHost |  | [BasicDocument.md](BasicDocument.md) |
| BasicDocumentDefinition | Definicje dokumentów podstawowych | `BasicDocDefs` | konfig | root |  | IRightsSource, IChronoOrderHostDefinition |  | [BasicDocumentDefinition.md](BasicDocumentDefinition.md) |
| ChronoOrdDefEn | Dostępność składu chronologicznego | `ChronoOrdDefEns` | konfig | root |  |  |  | [ChronoOrdDefEn.md](ChronoOrdDefEn.md) |
| ChronoOrder | Składy chronologiczne | `ChronoOrders` |  | root |  | IDefinicjaDokumentu, IPermissionClient |  | [ChronoOrder.md](ChronoOrder.md) |
| ChronoOrderElem | Elementy składu chronologicznego | `ChronoOrderElems` |  | root |  | IDokument, IDmsArchInfoHost |  | [ChronoOrderElem.md](ChronoOrderElem.md) |
| ChronoOrderLoc | Lokalizacje składów | `ChronoOrderLocs` |  | root |  | IPermissionClient |  | [ChronoOrderLoc.md](ChronoOrderLoc.md) |
| DmsArchInfo | Informacje o archiwum dokumentów | `DmsArchInfos` |  |  |  |  |  | [DmsArchInfo.md](DmsArchInfo.md) |
| DmsState | Status DMS | `DmsStates` | konfig | root |  |  |  | [DmsState.md](DmsState.md) |
| DmsStateDef | Definicje statusów DMS | `DmsStateDefs` | konfig | root |  |  |  | [DmsStateDef.md](DmsStateDef.md) |
| Matter | Sprawy | `Matters` |  | root |  | IPermissionClient, IEmailAttachmentsHolder, IEmailElement, IDokument, IDmsArchInfoHost |  | [Matter.md](Matter.md) |
| MatterDefinition | Definicje spraw | `MatterDefs` | konfig | root |  | IRightsSource |  | [MatterDefinition.md](MatterDefinition.md) |
| OcrBusinessMapping | Formaty mapowania OCR | `OcrBusMappings` | konfig | root |  |  |  | [OcrBusinessMapping.md](OcrBusinessMapping.md) |
| OcrBusinessMappingElement | Pozycje formatu mapowania OCR | `OcrBusMapElems` | konfig | root |  |  |  | [OcrBusinessMappingElement.md](OcrBusinessMappingElement.md) |
| OcrBusinessMappingOutput | Wyniki mapowania OCR | `OcrBusMapOutputs` |  |  |  |  |  | [OcrBusinessMappingOutput.md](OcrBusinessMappingOutput.md) |
| Register | Rejestry dokumentów podstawowych | `Registers` | konfig | root |  |  |  | [Register.md](Register.md) |
| UnifiedRegister | Wykazy akt | `UnifiedRgs` | konfig | root |  |  |  | [UnifiedRegister.md](UnifiedRegister.md) |
| UnifiedRegisterClass | Klasy wykazów akt | `UnifiedRgClasses` | konfig | root |  |  |  | [UnifiedRegisterClass.md](UnifiedRegisterClass.md) |

