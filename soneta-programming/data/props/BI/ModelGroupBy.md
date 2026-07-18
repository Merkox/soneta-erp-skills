# Pola i właściwości klasy biznesowej: `Soneta.BI.ModelGroupBy`
Nazwa tabeli: `ModelGroupBys`
Tytuł: Grupowania modelu
Opis: Element szczegółowy modelu danych (DataModel). Definiuje pole, po którym grupowane są dane w zapytaniu analitycznym. Kolejność grupowań wpływa na hierarchię agregacji wyników.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 8
- podlisty: 1
- subrowy: 1
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Field | `Soneta.BI.FieldProxy` (subrow) | bazodanowe | Pole |  |
| Field.Definition | `Soneta.BI.FieldDefinition` | bazodanowe, tylko-odczyt | Definicja pola |  |
| Field.FieldDefinition | `Soneta.BI.Interfaces.IFieldDefinition` | tylko-odczyt |  |  |
| Field.GroupBy | `Soneta.BI.ModelGroupBy` | tylko-odczyt |  |  |
| Field.Join | `Soneta.BI.ModelJoin` | tylko-odczyt |  |  |
| Field.Name | `string` | bazodanowe, tylko-odczyt | Nazwa pola |  |
| Field.OrderBy | `Soneta.BI.ModelOrderBy` | tylko-odczyt |  |  |
| Field.Param | `Soneta.BI.ReportParam` | tylko-odczyt |  |  |
| Field.WgDefinition | `Key` | podlista |  |  |
| Lp | `int` | bazodanowe |  |  |
| Model | `Soneta.BI.DataModel` | bazodanowe, tylko-odczyt | Model danych |  |
