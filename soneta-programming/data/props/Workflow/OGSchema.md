# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.OGSchema`
Nazwa tabeli: `OGSchemas`
Tytuł: Schematy generatora obiektów workflow
Opis: Schemat generatora obiektów definiujący mapowanie danych między obiektem źródłowym a docelowym w procesie workflow. Umożliwia automatyczne tworzenie dokumentów lub rekordów na podstawie zdefiniowanego mapowania pól, z opcją kopiowania załączników i notatek.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IOGSchema`, `IWorkflowItemDescriptionHost`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ClassName | `string` |  |  |  |
| ConstructorInfo | `Soneta.Workflow.Config.OGSchemaConstructorInfo` |  | Typ konstruktora obiektu docelowego | Określa opcjonalny typ konstruktora obiektu docelowego |
| CopyAttachments | `bool` | bazodanowe | Kopiuj załączniki | Określa czy załączniki mają być kopiowane |
| CopyNotes | `bool` | bazodanowe | Kopiuj notatki | Określa czy notatki mają być kopiowane |
| CtorDesc | `string` | bazodanowe | Typ konstruktora obiektu docelowego | Określa opcjonalny typ konstruktora obiektu docelowego |
| Description | `string` | bazodanowe | Opis | Opis schematu generatora |
| Getters | `System.Collections.Generic.List<Soneta.Workflow.Config.OGSchemaInfo>` |  |  |  |
| Info | `string` |  |  |  |
| InitTargetRowCode | `string` |  | Kod algorytmu inicjującego | Kod algorytmu kalkulatora generatora schematu inicjujący instancję wiersza docelowego |
| InvokeConstructorCode | `string` |  | Kod algorytmu kreatora | Kod algorytmu kalkulatora generatora schematu inicjujący instancję wiersza docelowego (w sytuacji wielu konstruktorów) |
| IsPageVisible | `bool` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa schematu generatora |
| ObjTargetTable | `Soneta.Business.Table` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SourceBusinessType | `Soneta.Business.BusinessTypeItem` |  | Typ szczegółowy |  |
| SourceBusinessTypeName | `string` | bazodanowe | Typ biznesowy dokumentu źródłowego | Typ biznesowy dokumentu źródłowego. |
| SourceDataType | `System.Type` |  | Typ obiektu źródłowego | Określa typ obiektu źródłowego |
| SourceDataTypeEx | `System.Type` |  |  |  |
| SourceDataTypeFullName | `string` |  |  |  |
| SourceDbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja źródłowego dokumentu dodatkowego | Definicja źródłowego dokumentu dodatkowego. |
| SourceType | `string` | bazodanowe | Typ obiektu źródłowego | Określa typ obiektu źródłowego |
| Statement | `Soneta.Business.MemoText` | bazodanowe | Kod algorytmu | Kod algorytmu kalkulatora inicjacji obiektu docelowego |
| TargetBusinessType | `Soneta.Business.BusinessTypeItem` |  | Typ szczegółowy |  |
| TargetBusinessTypeName | `string` | bazodanowe | Typ biznesowy dokumentu docelowego | Typ biznesowy dokumentu docelowego. |
| TargetDataType | `System.Type` |  | Typ obiektu docelowego | Określa typ obiektu docelowego |
| TargetDataTypeBase | `System.Type` |  |  |  |
| TargetDataTypeEx | `System.Type` |  |  |  |
| TargetDataTypeFullName | `string` |  |  |  |
| TargetDbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja docelowego dokumentu dodatkowego | Definicja docelowego dokumentu dodatkowego. |
| TargetType | `string` | bazodanowe | Typ obiektu docelowego | Określa typ obiektu docelowego |
| TaskDefs | `Soneta.Business.SubTable` |  |  |  |
| WFItemDescRels | `Soneta.Business.SubTable<Soneta.Workflow.Config.WFItemDescriptionRel>` |  |  |  |
| XML | `Soneta.Business.MemoText` | bazodanowe | Definicja mapowania | Określa definicję mapowania pól obiektu źródłowego na obiekt docelowy (XML) |
