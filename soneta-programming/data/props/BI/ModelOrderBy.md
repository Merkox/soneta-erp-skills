# Pola i właściwości klasy biznesowej: `Soneta.BI.ModelOrderBy`
Nazwa tabeli: `ModelOrderBys`
Tytuł: Sortowania modelu
Opis: Element szczegółowy modelu danych (DataModel). Definiuje regułę sortowania wyników zapytania analitycznego, wskazując pole oraz kierunek porządkowania danych (rosnąco lub malejąco).
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 8
- podlisty: 1
- subrowy: 1
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Direction | `Soneta.Data.QueryDefinition.OrderByDirection` (enum) | bazodanowe | Kierunek sortowania |  |
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

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OrderByDirection (`Soneta.Data.QueryDefinition.OrderByDirection`)
- `Asc` = 0 — Rosnąco
- `Desc` = 1 — Malejąco
