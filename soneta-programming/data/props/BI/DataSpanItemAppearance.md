# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSpanItemAppearance`
Nazwa tabeli: `DataSpanItemApps`
Tytuł: Wyglądy przedziałów danych
Opis: Element szczegółowy definicji wizualizacji (DashboardItemDefinition). Mapuje konkretny przedział danych na kolor z palety barw, tworząc reguły warunkowego formatowania wartości wyświetlanych na kafelku BI.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DashboardItem` → `DashboardItemDefinition`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AppearanceItem | `Soneta.BI.AppearanceItemDefinition` | bazodanowe | Kolor |  |
| DashboardItem | `Soneta.BI.DashboardItemDefinition` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DataSpanItem | `Soneta.BI.DataSpanItemDefinition` | bazodanowe | Przedział danych |  |
| DataSpanValue | `object` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  |  |
