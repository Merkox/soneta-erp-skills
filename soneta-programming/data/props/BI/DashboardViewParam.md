# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardViewParam`
Nazwa tabeli: `DashViewParams`
Tytuł: Parametry paneli BI
Opis: Pojedynczy parametr w zestawie parametrów panelu BI. Przechowuje nazwę, typ danych oraz wartość domyślną parametru filtrującego wizualizację. Parametry mogą być przypisane do konkretnego kafelka na dashboardzie.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataType | `string` | bazodanowe | Typ danych |  |
| DefaultValueText | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Set | `Soneta.BI.DashboardViewParamSet` | bazodanowe | Definicja zestawu |  |
| TileGuid | `System.Guid` | bazodanowe | Identyfikator kafelka |  |
| Type | `System.Type` |  |  |  |
