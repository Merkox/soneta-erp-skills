# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardItemDefinition`
Nazwa tabeli: `DashBrdItemDefs`
Tytuł: Definicje elementów wizualizacji
Opis: Definicja elementu wizualizacji (kafelka) na dashboardzie BI. Określa typ wizualizacji (tabela, wykres, wartość), powiązany model danych, opis, limit wyświetlanych rekordów oraz symbol jednostki. Stanowi podstawowy budulec paneli analitycznych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Appearance | `Soneta.BI.DashboardItemFieldAppearance` |  |  |  |
| Appearances | `Soneta.Business.SubTable<Soneta.BI.DashboardItemFieldAppearance>` |  |  |  |
| ChartParam | `Soneta.BI.ChartParam` |  |  |  |
| ChartParams | `Soneta.Business.SubTable<Soneta.BI.ChartParam>` |  |  |  |
| Comment | `string` | bazodanowe | Objaśnienia producenta | Dodatkowe objaśnienia wizualizacji |
| DataSpanItemAppearances | `Soneta.Business.LpSubTable<Soneta.BI.DataSpanItemAppearance>` |  |  |  |
| Description | `string` | bazodanowe | Opis | Opis elementu wizualizacji |
| Fields | `Soneta.Business.LpSubTable<Soneta.BI.DashboardItemField>` |  |  |  |
| ImageName | `string` | bazodanowe |  | Nazwa grafiki |
| Limit | `int` | bazodanowe | Limit | Określa limit wyświetlanych danych |
| Model | `Soneta.BI.DataModel` | bazodanowe | Model danych |  |
| Name | `string` |  |  |  |
| Obsolete | `bool` | bazodanowe | Przestarzały |  |
| Params | `Soneta.Business.SubTable<Soneta.BI.DashboardItemParam>` |  |  |  |
| Type | `Soneta.BI.DashboardItemType` | bazodanowe, enum | Typ | Typ elementu wizualizacji |
| UnitSymbol | `string` | bazodanowe | Symbol jednostki | Symbol jednostki |
| Visualization | `Soneta.BI.VisualizationType` | bazodanowe, enum | Wizualizacja | Wizualizacja elementu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DashboardItemType (`Soneta.BI.DashboardItemType`)
- `None` = 0 — Brak
- `List` = 1 — Raport
- `Indicator` = 2 — Wskaźnik
- `PivotReport` = 3 — Raport przestawny

### VisualizationType (`Soneta.BI.VisualizationType`)
- `All` = 0 — Wszystkie
- `Table` = 1 — Tabela
- `Chart` = 2 — Wykres
- `Indicator` = 3 — Wskaźnik
- `PivotTable` = 4 — Tabela przestawna
- `None` = 99 — Brak
