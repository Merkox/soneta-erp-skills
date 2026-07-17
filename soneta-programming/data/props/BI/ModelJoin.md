# Pola i właściwości klasy biznesowej: `Soneta.BI.ModelJoin`
Nazwa tabeli: `ModelJoins`
Tytuł: Złączenia modelu
Opis: Element szczegółowy modelu danych (DataModel). Definiuje złączenie (JOIN) między tabelami źródłowymi modelu, określając pola łączące, typ złączenia i aliasy tabel. Umożliwia budowanie złożonych zapytań analitycznych łączących dane z wielu tabel.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BuildMode | `Soneta.BI.JoinBuildMode` | bazodanowe, enum | Tryb tworzenia |  |
| ConditionText | `Soneta.Business.MemoText` | bazodanowe |  |  |
| LeftAlias | `string` | bazodanowe | Alias lewej tabeli |  |
| LeftField | `Soneta.BI.FieldProxy` | bazodanowe | Lewe pole złączenia |  |
| LeftField.Definition | `Soneta.BI.FieldDefinition` | bazodanowe | Definicja pola |  |
| LeftField.FieldDefinition | `Soneta.BI.Interfaces.IFieldDefinition` |  |  |  |
| LeftField.GroupBy | `Soneta.BI.ModelGroupBy` |  |  |  |
| LeftField.Join | `Soneta.BI.ModelJoin` |  |  |  |
| LeftField.Name | `string` | bazodanowe | Nazwa pola |  |
| LeftField.OrderBy | `Soneta.BI.ModelOrderBy` |  |  |  |
| LeftField.Param | `Soneta.BI.ReportParam` |  |  |  |
| LeftField.WgDefinition | `Soneta.Business.Key` |  |  |  |
| LeftTable | `Soneta.BI.Interfaces.ITableSource` |  |  |  |
| Model | `Soneta.BI.DataModel` | bazodanowe | Model danych |  |
| RightAlias | `string` | bazodanowe | Alias prawej tabeli |  |
| RightField | `Soneta.BI.FieldProxy` | bazodanowe | Prawe pole złączenia |  |
| RightTable | `Soneta.BI.Interfaces.ITableSource` |  |  |  |
| Type | `Soneta.BI.JoinType` | bazodanowe, enum | Typ złączenia |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### JoinBuildMode (`Soneta.BI.JoinBuildMode`)
- `Standard` = 0 — Podstawowy
- `Expert` = 1 — Zaawansowany
- `Features` = 2 — Cecha

### JoinType (`Soneta.BI.JoinType`)
- `None` = 0 — Brak
- `Inner` = 1 — Wewnętrzne
- `LeftOuter` = 2 — Lewe zewnętrzne
- `RightOuter` = 3 — Prawe zewnętrzne
