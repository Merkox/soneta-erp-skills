# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSetDefinition`
Nazwa tabeli: `DataSetDefs`
Tytuł: Definicja danych biznesowych
Opis: Definicja zestawu danych biznesowych wykorzystywanego w procesach BI. Zawiera nazwę, algorytm generowania danych oraz informacje o typach uruchomieniowych. Zestawy danych służą jako źródło dla generatorów i serializatorów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CalculateCode | `Soneta.Business.Compiler.ICodeEditorSource` |  | Kod algorytmu metody Calculate | Kod algorytmu kalkulacji kalkulatora rekordu |
| Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Columns | `Soneta.Business.SubTable<Soneta.BI.ColumnDefinition>` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Generators | `Soneta.Business.SubTable<Soneta.BI.DataSetGeneratorDefinition>` |  |  |  |
| Info | `string` |  |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Serializer | `Soneta.Business.SubTable<Soneta.BI.SerializationDefinition>` |  |  |  |
