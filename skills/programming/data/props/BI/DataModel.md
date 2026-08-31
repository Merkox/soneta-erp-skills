# Pola i właściwości klasy biznesowej: `DevExpress.XtraSpreadsheet.Model.DataModel`
Nazwa tabeli: `DataModels`
Tytuł: Modele danych
Opis: Model danych stanowiący podstawę analiz BI. Definiuje strukturę zapytania analitycznego — wskazuje źródło danych, powiązania z innymi modelami, przedziały czasowe oraz sposób utrwalania wyników. Modele mogą być serwerowe, wielobazowe i hierarchicznie powiązane.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IAreaHost`
Selektor: pole `Type` (`Soneta.BI.DataModelType`) — wiele typów w jednej tabeli, podtypów: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Area | `Soneta.BI.AreaOfDataModels` (enum) | bazodanowe | Obszar |  |
| Combine | `Soneta.BI.CombineTableSources` (enum) | bazodanowe | Łączenie źródeł |  |
| ConditionText | `MemoText` | bazodanowe, podlista |  |  |
| Data | `byte[]` | podlista |  |  |
| DataModelBinaryContent | `byte[]` | podlista |  |  |
| DataSource | `IRow` | bazodanowe | Źródło danych |  |
| DimHash | `bool` | bazodanowe |  |  |
| Distinct | `bool` | bazodanowe | Unikalność danych | Określa, czy dane zwracane przez model mają być unikalne |
| Model | `IRow` | bazodanowe | Powiązany model danych |  |
| ModelRelationType | `Soneta.BI.RelationType` (enum) | bazodanowe | Typ powiązania modelu |  |
| MultiDatabase | `bool` | bazodanowe | Analiza wielobazowa | Określa, czy model jest przeznaczony do analiz wielobazowych |
| Name | `string` | bazodanowe | Nazwa |  |
| Obsolete | `bool` | bazodanowe | Przestarzały |  |
| Relationships | `DevExpress.XtraSpreadsheet.Model.DataModelRelationshipsCollection` | podlista |  |  |
| SerializationType | `Soneta.BI.SerializationType` (enum) | bazodanowe | Sposób utrwalania danych |  |
| ServerModel | `bool` | bazodanowe | Model serwerowy | Określa, czy zarządzanie modelem odbywa się po stronie serwera |
| Tables | `DevExpress.XtraSpreadsheet.Model.DataModelTableCollection` | podlista |  |  |
| TechnicalModel | `bool` | bazodanowe | Model techniczny |  |
| TimeSpanItem | `IRow` | bazodanowe |  |  |
| Type | `Soneta.BI.DataModelType` (enum) | bazodanowe, selektor | Typ modelu |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Type`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Domain` | 1 | `Soneta.BI.DomainDefinition` | Definicja domeny |
| `Report` | 2 | `Soneta.BI.ReportDefinition` | Definicja raportu |
| `Indicator` | 3 | `Soneta.BI.IndicatorDefinition` | Definicja wskaźnika |
| `DomainExtender` | 4 | `Soneta.BI.DomainExtenderDefinition` | Rozszerzenie domeny |
| `Table` | 5 | `Soneta.BI.TableDefinition` | Definicja tabeli |
| `ReportExtender` | 6 | `Soneta.BI.ReportExtenderDefinition` | Rozszerzenie raportu |
| `IndicatorExtender` | 7 | `Soneta.BI.IndicatorExtenderDefinition` | Rozszerzenie wskaźnika |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AreaOfDataModels (`Soneta.BI.AreaOfDataModels`)
- `All` = 0 — Wszystkie
- `Trade` = 1 — Handel
- `HrAndPayroll` = 2 — Kadry i płace
- `Financial` = 3 — Finansowy
- `CRM` = 4 — CRM
- `Users` = 5 — Użytkownika
- `Vault` = 6 — Vault
- `WithoutArea` = 7 — Bez obszaru
- `MultiArea` = 8 — Wiele obszarów

### CombineTableSources (`Soneta.BI.CombineTableSources`)
- `Join` = 0 — Join - złączenia
- `Union` = 1 — Union - łączenie z usuwaniem duplikatów
- `UnionAll` = 2 — Union all - łączenie bez usuwania duplikatów
- `Except` = 3 — Except - odejmowanie elementów wspólnych
- `Intersect` = 4 — Intersect - część wspólna zbiorów

### DataModelType (`Soneta.BI.DataModelType`)
- `All` = 0 — Wszystkie
- `Domain` = 1 — Domena
- `Report` = 2 — Raport
- `Indicator` = 3 — Wskaźnik
- `DomainExtender` = 4 — Rozszerzenie domeny
- `Table` = 5 — Tabela
- `ReportExtender` = 6 — Rozszerzenie raportu
- `IndicatorExtender` = 7 — Rozszerzenie wskaźnika
- `None` = 99 — Brak

### RelationType (`Soneta.BI.RelationType`)
- `None` = 0 — Brak
- `Extension` = 1 — Rozszerzenie
- `Serialization` = 2 — Utrwalanie

### SerializationType (`Soneta.BI.SerializationType`)
- `Standard` = 0 — Standardowy
- `Differential` = 1 — Różnicowy
- `Incremental` = 2 — Przyrostowy
