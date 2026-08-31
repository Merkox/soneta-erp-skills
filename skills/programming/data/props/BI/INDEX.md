# Moduł `BI` — tabele biznesowe

- Opis: Moduł Business Intelligence. Zawiera definicje kostek analitycznych, miar, wymiarów, raportów oraz mechanizmy agregacji i wizualizacji danych biznesowych.
- Tabel: **39**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| AnalysisArea | Obszary | `AnalysisAreas` | konfig | root |  |  |  | [AnalysisArea.md](AnalysisArea.md) |
| AnalysisAreaAppearance | Wyglądy obszarów | `AnalysisAreaApps` | konfig | child: AreaDefinition→AnalysisAreaDefinition |  |  |  | [AnalysisAreaAppearance.md](AnalysisAreaAppearance.md) |
| AnalysisAreaDefinition | Definicje obszarów | `AnalysisAreaDefs` | konfig | root |  |  |  | [AnalysisAreaDefinition.md](AnalysisAreaDefinition.md) |
| AppearanceItemDefinition | Definicje barw | `AppItemDefs` | konfig | child: Definition→AppearanceSetDefinition |  |  |  | [AppearanceItemDefinition.md](AppearanceItemDefinition.md) |
| AppearanceSetDefinition | Zestawy barw | `AppSetDefs` | konfig | root |  |  |  | [AppearanceSetDefinition.md](AppearanceSetDefinition.md) |
| BICode | Algorytmy BI | `BICodes` | konfig | root |  |  | BICodeType (1) | [BICode.md](BICode.md) |
| ChartParam | Parametry wykresów | `ChartParams` | konfig | root |  |  |  | [ChartParam.md](ChartParam.md) |
| ColumnDefinition | Definicja kolumn danych biznesowych | `ColumnDefs` | konfig | root |  |  |  | [ColumnDefinition.md](ColumnDefinition.md) |
| DashboardItemDefinition | Definicje elementów wizualizacji | `DashBrdItemDefs` | konfig | root |  |  | DashboardItemType (3) | [DashboardItemDefinition.md](DashboardItemDefinition.md) |
| DashboardItemField | Pola elementu wizualizacji | `DashBrdItemFlds` | konfig | root |  |  |  | [DashboardItemField.md](DashboardItemField.md) |
| DashboardItemFieldAppearance | Wyglądy pól elementów wizualizacji | `DashBrdItemFApps` | konfig | child: DashboardItem→DashboardItemDefinition |  |  |  | [DashboardItemFieldAppearance.md](DashboardItemFieldAppearance.md) |
| DashboardItemLocation | Lokalizacje wizualizacji | `DashItemLocs` | konfig | root |  |  |  | [DashboardItemLocation.md](DashboardItemLocation.md) |
| DashboardItemParam | Parametry elementów wizualizacji | `DashItemParams` | konfig | child: ItemDefinition→DashboardItemDefinition |  |  |  | [DashboardItemParam.md](DashboardItemParam.md) |
| DashboardViewLocation | Lokalizacje paneli BI formularzy | `DashbrdViewLocs` | konfig | root |  |  |  | [DashboardViewLocation.md](DashboardViewLocation.md) |
| DashboardViewParam | Parametry paneli BI | `DashViewParams` | konfig |  |  |  |  | [DashboardViewParam.md](DashboardViewParam.md) |
| DashboardViewParamSet | Zestawy parametrów paneli BI | `DashParamSets` | konfig |  |  |  |  | [DashboardViewParamSet.md](DashboardViewParamSet.md) |
| DataModel | Modele danych | `DataModels` | konfig | root |  | IRightsSource, IAreaHost | DataModelType (7) | [DataModel.md](DataModel.md) |
| DataModelSerializationDefinition | Definicja serializatora modeli danych | `SerialModelDefs` | konfig | root |  |  |  | [DataModelSerializationDefinition.md](DataModelSerializationDefinition.md) |
| DataSetDefinition | Definicja danych biznesowych | `DataSetDefs` | konfig | root |  |  |  | [DataSetDefinition.md](DataSetDefinition.md) |
| DataSetGeneratorDefinition | Definicja generatora danych biznesowych | `DataSetGenDefs` | konfig | root |  |  |  | [DataSetGeneratorDefinition.md](DataSetGeneratorDefinition.md) |
| DataSource | Źródła danych | `DataSources` | konfig | root |  |  | DataSourceType (3) | [DataSource.md](DataSource.md) |
| DataSourceDatabase | Zewnętrzne źródła danych | `DataSourceDbs` | konfig | root |  |  |  | [DataSourceDatabase.md](DataSourceDatabase.md) |
| DataSpanItemAppearance | Wyglądy przedziałów danych | `DataSpanItemApps` | konfig | child: DashboardItem→DashboardItemDefinition |  |  |  | [DataSpanItemAppearance.md](DataSpanItemAppearance.md) |
| DataSpanItemDefinition | Definicje elementów przedziałów danych | `DataSpanItemDefs` | konfig | child: DataSpanSet→DataSpanSetDefinition |  |  | FieldType (5) | [DataSpanItemDefinition.md](DataSpanItemDefinition.md) |
| DataSpanSetDefinition | Zestawy przedziałów danych | `DataSpanSetDefs` | konfig | root |  |  | FieldType (5) | [DataSpanSetDefinition.md](DataSpanSetDefinition.md) |
| FieldDefinition | Definicje pól | `FieldDefs` | konfig | root |  |  |  | [FieldDefinition.md](FieldDefinition.md) |
| ModelGroupBy | Grupowania modelu | `ModelGroupBys` | konfig | root |  |  |  | [ModelGroupBy.md](ModelGroupBy.md) |
| ModelJoin | Złączenia modelu | `ModelJoins` | konfig | root |  |  |  | [ModelJoin.md](ModelJoin.md) |
| ModelOrderBy | Sortowania modelu | `ModelOrderBys` | konfig | root |  |  |  | [ModelOrderBy.md](ModelOrderBy.md) |
| ModelTable | Tabele modelu | `ModelTables` | konfig | root |  |  |  | [ModelTable.md](ModelTable.md) |
| ReportParam | Parametry raportu | `ReportParams` | konfig | root |  |  |  | [ReportParam.md](ReportParam.md) |
| SerializationDefinition | Definicja serializatora danych biznesowych | `SerializeDefs` | konfig | root |  |  |  | [SerializationDefinition.md](SerializationDefinition.md) |
| SerializationParam | Parametry utrwalania danych biznesowych | `SerializeParams` | konfig | root |  |  |  | [SerializationParam.md](SerializationParam.md) |
| SerializationViewDefinition | Definicje utrwalania list | `SerialViewDefs` | konfig | root |  |  |  | [SerializationViewDefinition.md](SerializationViewDefinition.md) |
| SerializationViewFilterSet | Zestawy filtrów dla utrwalania list | `SerialFilterSets` | konfig | root |  |  |  | [SerializationViewFilterSet.md](SerializationViewFilterSet.md) |
| SerializationViewRange | Zakresy utrwalania list | `SerialViewRanges` | konfig | root |  |  |  | [SerializationViewRange.md](SerializationViewRange.md) |
| TimeSpanDefinition | Definicje przedziałów czasowych | `TimeSpanDefs` | konfig | root |  |  | TimeSpanType (2) | [TimeSpanDefinition.md](TimeSpanDefinition.md) |
| TimeSpanItem | Elementy zestawu przedziałów czasowych | `TimeSpanItems` | konfig | root |  |  |  | [TimeSpanItem.md](TimeSpanItem.md) |
| TimeSpanSet | Zestawy przedziałów czasowych | `TimeSpanSets` | konfig | root |  |  |  | [TimeSpanSet.md](TimeSpanSet.md) |

