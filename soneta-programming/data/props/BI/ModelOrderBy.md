# Pola i właściwości klasy biznesowej: `Soneta.BI.ModelOrderBy`
Nazwa tabeli: `ModelOrderBys`
Tytuł: Sortowania modelu
Opis: Element szczegółowy modelu danych (DataModel). Definiuje regułę sortowania wyników zapytania analitycznego, wskazując pole oraz kierunek porządkowania danych (rosnąco lub malejąco).
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Direction | `Soneta.Data.QueryDefinition.OrderByDirection` | bazodanowe, enum | Kierunek sortowania |  |
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

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OrderByDirection (`Soneta.Data.QueryDefinition.OrderByDirection`)
- `Asc` = 0 — Rosnąco
- `Desc` = 1 — Malejąco
