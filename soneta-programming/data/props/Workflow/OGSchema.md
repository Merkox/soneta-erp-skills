# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.OGSchema`
Nazwa tabeli: `OGSchemas`
Tytuł: Schematy generatora obiektów workflow
Opis: Schemat generatora obiektów definiujący mapowanie danych między obiektem źródłowym a docelowym w procesie workflow. Umożliwia automatyczne tworzenie dokumentów lub rekordów na podstawie zdefiniowanego mapowania pól, z opcją kopiowania załączników i notatek.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IOGSchema`, `IWorkflowItemDescriptionHost`

- pola bazodanowe (zapisywalne): 11
- pola kalkulowane (zapisywalne): 5
- pola tylko-odczyt: 13
- podlisty: 7
- subrowy: 1
- razem: 37

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ClassName | `string` | tylko-odczyt |  |  |
| ConstructorInfo | `Soneta.Workflow.Config.OGSchemaConstructorInfo` |  | Typ konstruktora obiektu docelowego | Określa opcjonalny typ konstruktora obiektu docelowego |
| CopyAttachments | `bool` | bazodanowe | Kopiuj załączniki | Określa czy załączniki mają być kopiowane |
| CopyNotes | `bool` | bazodanowe | Kopiuj notatki | Określa czy notatki mają być kopiowane |
| CtorDesc | `string` | bazodanowe, tylko-odczyt | Typ konstruktora obiektu docelowego | Określa opcjonalny typ konstruktora obiektu docelowego |
| Description | `string` | bazodanowe | Opis | Opis schematu generatora |
| Getters | `System.Collections.Generic.List<Soneta.Workflow.Config.OGSchemaInfo>` | podlista |  |  |
| Info | `string` | tylko-odczyt |  |  |
| InitTargetRowCode | `string` |  | Kod algorytmu inicjującego | Kod algorytmu kalkulatora generatora schematu inicjujący instancję wiersza docelowego |
| InvokeConstructorCode | `string` |  | Kod algorytmu kreatora | Kod algorytmu kalkulatora generatora schematu inicjujący instancję wiersza docelowego (w sytuacji wielu konstruktorów) |
| IsPageVisible | `bool` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa schematu generatora |
| ObjTargetTable | `Table` | podlista |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SourceBusinessType | `BusinessTypeItem` |  | Typ szczegółowy |  |
| SourceBusinessTypeName | `string` | bazodanowe, tylko-odczyt | Typ biznesowy dokumentu źródłowego | Typ biznesowy dokumentu źródłowego. |
| SourceDataType | `System.Type` | tylko-odczyt | Typ obiektu źródłowego | Określa typ obiektu źródłowego |
| SourceDataTypeEx | `System.Type` | tylko-odczyt |  |  |
| SourceDataTypeFullName | `string` | tylko-odczyt |  |  |
| SourceDbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja źródłowego dokumentu dodatkowego | Definicja źródłowego dokumentu dodatkowego. |
| SourceType | `string` | bazodanowe | Typ obiektu źródłowego | Określa typ obiektu źródłowego |
| Statement | `MemoText` | bazodanowe, podlista | Kod algorytmu | Kod algorytmu kalkulatora inicjacji obiektu docelowego |
| TargetBusinessType | `BusinessTypeItem` |  | Typ szczegółowy |  |
| TargetBusinessTypeName | `string` | bazodanowe, tylko-odczyt | Typ biznesowy dokumentu docelowego | Typ biznesowy dokumentu docelowego. |
| TargetDataType | `System.Type` | tylko-odczyt | Typ obiektu docelowego | Określa typ obiektu docelowego |
| TargetDataTypeBase | `System.Type` | tylko-odczyt |  |  |
| TargetDataTypeEx | `System.Type` | tylko-odczyt |  |  |
| TargetDataTypeFullName | `string` | tylko-odczyt |  |  |
| TargetDbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja docelowego dokumentu dodatkowego | Definicja docelowego dokumentu dodatkowego. |
| TargetType | `string` | bazodanowe | Typ obiektu docelowego | Określa typ obiektu docelowego |
| TaskDefs | `SubTable` | podlista |  |  |
| WFItemDescRels | `SubTable<Soneta.Workflow.Config.WFItemDescriptionRel>` | podlista |  |  |
| XML | `MemoText` | bazodanowe, podlista | Definicja mapowania | Określa definicję mapowania pól obiektu źródłowego na obiekt docelowy (XML) |
