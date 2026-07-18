# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardViewParam`
Nazwa tabeli: `DashViewParams`
Tytuł: Parametry paneli BI
Opis: Pojedynczy parametr w zestawie parametrów panelu BI. Przechowuje nazwę, typ danych oraz wartość domyślną parametru filtrującego wizualizację. Parametry mogą być przypisane do konkretnego kafelka na dashboardzie.
Tabela konfiguracyjna: Tak

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 5
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataType | `string` | bazodanowe, tylko-odczyt | Typ danych |  |
| DefaultValueText | `MemoText` | bazodanowe, podlista |  |  |
| Name | `string` | bazodanowe, tylko-odczyt | Nazwa |  |
| Set | `Soneta.BI.DashboardViewParamSet` | bazodanowe, tylko-odczyt | Definicja zestawu |  |
| TileGuid | `System.Guid` | bazodanowe, tylko-odczyt | Identyfikator kafelka |  |
| Type | `System.Type` | tylko-odczyt |  |  |
