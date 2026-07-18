# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardItemDefinition`
Nazwa tabeli: `DashBrdItemDefs`
Tytuł: Definicje elementów wizualizacji
Opis: Definicja elementu wizualizacji (kafelka) na dashboardzie BI. Określa typ wizualizacji (tabela, wykres, wartość), powiązany model danych, opis, limit wyświetlanych rekordów oraz symbol jednostki. Stanowi podstawowy budulec paneli analitycznych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 8
- podlisty: 5
- subrowy: 0
- razem: 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Appearance | `Soneta.BI.DashboardItemFieldAppearance` | tylko-odczyt |  |  |
| Appearances | `SubTable<Soneta.BI.DashboardItemFieldAppearance>` | podlista |  |  |
| ChartParam | `Soneta.BI.ChartParam` | tylko-odczyt |  |  |
| ChartParams | `SubTable<Soneta.BI.ChartParam>` | podlista |  |  |
| Comment | `string` | bazodanowe | Objaśnienia producenta | Dodatkowe objaśnienia wizualizacji |
| DataSpanItemAppearances | `LpSubTable<Soneta.BI.DataSpanItemAppearance>` | podlista |  |  |
| Description | `string` | bazodanowe | Opis | Opis elementu wizualizacji |
| Fields | `LpSubTable<Soneta.BI.DashboardItemField>` | podlista |  |  |
| ImageName | `string` | bazodanowe, tylko-odczyt |  | Nazwa grafiki |
| Limit | `int` | bazodanowe, tylko-odczyt | Limit | Określa limit wyświetlanych danych |
| Model | `Soneta.BI.DataModel` | bazodanowe, tylko-odczyt | Model danych |  |
| Name | `string` | tylko-odczyt |  |  |
| Obsolete | `bool` | bazodanowe | Przestarzały |  |
| Params | `SubTable<Soneta.BI.DashboardItemParam>` | podlista |  |  |
| Type | `Soneta.BI.DashboardItemType` (enum) | bazodanowe, tylko-odczyt | Typ | Typ elementu wizualizacji |
| UnitSymbol | `string` | bazodanowe | Symbol jednostki | Symbol jednostki |
| Visualization | `Soneta.BI.VisualizationType` (enum) | bazodanowe, tylko-odczyt | Wizualizacja | Wizualizacja elementu |

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
