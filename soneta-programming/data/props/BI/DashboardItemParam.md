# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardItemParam`
Nazwa tabeli: `DashItemParams`
Tytuł: Parametry elementów wizualizacji
Opis: Element szczegółowy definicji wizualizacji (DashboardItemDefinition). Przechowuje dodatkowe parametry prezentacji kafelka, takie jak wyświetlanie pełnej wartości, informacji o parametrach raportu czy stanu danych.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `ItemDefinition` → `DashboardItemDefinition`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdditionalInfo | `string` | bazodanowe | Informacje dodatkowe | Dodatkowe informacje elementu wizualizacji |
| DataStatus | `bool` | bazodanowe | Stan danych |  |
| FullValue | `bool` | bazodanowe | Wyświetlanie pełnej wartości |  |
| ItemDefinition | `Soneta.BI.DashboardItemDefinition` | bazodanowe, guided-parent |  |  |
| ReportParamInfo | `bool` | bazodanowe | Informacje o parametrach wizualizacji |  |
