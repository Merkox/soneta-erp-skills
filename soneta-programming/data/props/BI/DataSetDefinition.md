# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSetDefinition`
Nazwa tabeli: `DataSetDefs`
Tytuł: Definicja danych biznesowych
Opis: Definicja zestawu danych biznesowych wykorzystywanego w procesach BI. Zawiera nazwę, algorytm generowania danych oraz informacje o typach uruchomieniowych. Zestawy danych służą jako źródło dla generatorów i serializatorów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 6
- subrowy: 1
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CalculateCode | `Compiler.ICodeEditorSource` |  | Kod algorytmu metody Calculate | Kod algorytmu kalkulacji kalkulatora rekordu |
| Code | `MemoText` | bazodanowe, podlista |  |  |
| Columns | `SubTable<Soneta.BI.ColumnDefinition>` | podlista |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Generators | `SubTable<Soneta.BI.DataSetGeneratorDefinition>` | podlista |  |  |
| Info | `string` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Serializer | `SubTable<Soneta.BI.SerializationDefinition>` | podlista |  |  |
