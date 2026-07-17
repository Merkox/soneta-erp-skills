# Pola i właściwości klasy biznesowej: `Soneta.BI.ModelGroupBy`
Nazwa tabeli: `ModelGroupBys`
Tytuł: Grupowania modelu
Opis: Element szczegółowy modelu danych (DataModel). Definiuje pole, po którym grupowane są dane w zapytaniu analitycznym. Kolejność grupowań wpływa na hierarchię agregacji wyników.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Field | `Soneta.BI.FieldProxy` | bazodanowe | Pole |  |
| Field.Definition | `Soneta.BI.FieldDefinition` | bazodanowe | Definicja pola |  |
| Field.FieldDefinition | `Soneta.BI.Interfaces.IFieldDefinition` |  |  |  |
| Field.GroupBy | `Soneta.BI.ModelGroupBy` |  |  |  |
| Field.Join | `Soneta.BI.ModelJoin` |  |  |  |
| Field.Name | `string` | bazodanowe | Nazwa pola |  |
| Field.OrderBy | `Soneta.BI.ModelOrderBy` |  |  |  |
| Field.Param | `Soneta.BI.ReportParam` |  |  |  |
| Field.WgDefinition | `Soneta.Business.Key` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| Model | `Soneta.BI.DataModel` | bazodanowe | Model danych |  |
