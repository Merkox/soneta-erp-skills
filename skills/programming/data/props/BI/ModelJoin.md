# Pola i właściwości klasy biznesowej: `Soneta.BI.ModelJoin`
Nazwa tabeli: `ModelJoins`
Tytuł: Złączenia modelu
Opis: Element szczegółowy modelu danych (DataModel). Definiuje złączenie (JOIN) między tabelami źródłowymi modelu, określając pola łączące, typ złączenia i aliasy tabel. Umożliwia budowanie złożonych zapytań analitycznych łączących dane z wielu tabel.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BuildMode | `Soneta.BI.JoinBuildMode` (enum) | bazodanowe | Tryb tworzenia |  |
| ConditionText | `MemoText` | bazodanowe, podlista |  |  |
| LeftAlias | `string` | bazodanowe | Alias lewej tabeli |  |
| LeftField | `Soneta.BI.FieldProxy` (subrow) | bazodanowe | Lewe pole złączenia |  |
| LeftField.Definition | `Soneta.BI.FieldDefinition` | bazodanowe, tylko-odczyt | Definicja pola |  |
| LeftField.FieldDefinition | `Soneta.BI.Interfaces.IFieldDefinition` | tylko-odczyt |  |  |
| LeftField.GroupBy | `Soneta.BI.ModelGroupBy` | tylko-odczyt |  |  |
| LeftField.Join | `Soneta.BI.ModelJoin` | tylko-odczyt |  |  |
| LeftField.Name | `string` | bazodanowe, tylko-odczyt | Nazwa pola |  |
| LeftField.OrderBy | `Soneta.BI.ModelOrderBy` | tylko-odczyt |  |  |
| LeftField.Param | `Soneta.BI.ReportParam` | tylko-odczyt |  |  |
| LeftField.WgDefinition | `Key` | podlista |  |  |
| LeftTable | `Soneta.BI.Interfaces.ITableSource` | tylko-odczyt |  |  |
| Model | `Soneta.BI.DataModel` | bazodanowe, tylko-odczyt | Model danych |  |
| RightAlias | `string` | bazodanowe | Alias prawej tabeli |  |
| RightField | `Soneta.BI.FieldProxy` (subrow) | bazodanowe | Prawe pole złączenia |  |
| RightTable | `Soneta.BI.Interfaces.ITableSource` | tylko-odczyt |  |  |
| Type | `Soneta.BI.JoinType` (enum) | bazodanowe | Typ złączenia |  |

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
