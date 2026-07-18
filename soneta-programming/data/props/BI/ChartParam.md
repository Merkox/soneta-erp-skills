# Pola i właściwości klasy biznesowej: `Soneta.BI.ChartParam`
Nazwa tabeli: `ChartParams`
Tytuł: Parametry wykresów
Opis: Element szczegółowy definicji wizualizacji (DashboardItemDefinition). Zawiera pełną konfigurację wykresu — typ, wariant, kolorystykę, legendę, układ osi, etykiety oraz parametry drugiej osi Y. Umożliwia szczegółowe dostosowanie wyglądu wizualizacji graficznej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 25
- podlisty: 0
- subrowy: 0
- razem: 25

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AxesSwap | `bool` | bazodanowe, tylko-odczyt | Odwrócenie osi | Zamienia miejscami osie X i Y |
| ChartColor | `UI.ColorPaletteBase` (enum) | bazodanowe, tylko-odczyt | Kolor wykresu | Określa kolorystykę wykresu |
| ChartLabelBackground | `bool` | bazodanowe, tylko-odczyt | Tło etykiet | Włączenie tła etykiet |
| ChartLabelPosition | `UI.ChartLabelPosition` (enum) | bazodanowe, tylko-odczyt | Położenie etykiet | Określa położenie etykiet wykresu |
| ChartLabelRotate | `int` | bazodanowe, tylko-odczyt | Pochylenie etykiety danych | Określa kąt pochylenia etykiety danych |
| ChartLabelValueRounding | `bool` | bazodanowe, tylko-odczyt | Zokrąglenie wartości etykiet | Określa czy wartość etykiety powinna być zaokrąglona z jednostką |
| ChartType | `UI.ChartType` (enum) | bazodanowe, tylko-odczyt | Typ wykresu | Typ wykresu elementu wizualizacji |
| ChartVariant | `Soneta.BI.ChartVariant` (enum) | bazodanowe, tylko-odczyt | Wariant wykresu | Określa wariant wykresu |
| ColorGradientOff | `bool` | bazodanowe, tylko-odczyt | Wyłącz gradient | Określa czy na wykresie ma być wyłączony gradient koloru |
| ColorShading | `bool` | bazodanowe, tylko-odczyt | Cieniowanie | Określa czy kolejne serie danych mają być cieniowane |
| ItemDefinition | `Soneta.BI.DashboardItemDefinition` | bazodanowe, tylko-odczyt |  |  |
| Legend | `bool` | bazodanowe, tylko-odczyt | Legenda | Wyświetla legendę na wykresach |
| PieChartLabelPosition | `UI.PieChartLabelPosition` (enum) | bazodanowe, tylko-odczyt | Położenie etykiet | Określa położenie etykiet wykresu typu Pie, Donut |
| SecondAxisGrouping | `bool` | bazodanowe, tylko-odczyt | Grupowanie drugiej serii danych na osi X | Określa czy druga seria danych na osi X ma być pogrupowana |
| SecondChartColor | `UI.ColorPaletteBase` (enum) | bazodanowe, tylko-odczyt | Kolor wykresu drugiej osi Y | Określa kolorystykę wykresu związanego z drugą osią Y |
| SecondChartLabelPosition | `UI.ChartLabelPosition` (enum) | bazodanowe, tylko-odczyt | Położenie etykiet drugiej osi Y | Określa położenie etykiet wykresu związanego z drugą osią Y |
| SecondChartLabelRotate | `int` | bazodanowe, tylko-odczyt | Pochylenie etykiety danych drugiej osi | Określa kąt pochylenia etykiety danych drugiej osi Y |
| SecondChartLabelValueRounding | `bool` | bazodanowe, tylko-odczyt | Zokrąglenie wartości etykiet drugiej osi | Określa czy wartość etykiety związanej z drugą osią Y powinna być zaokrąglona z jednostką |
| SecondChartType | `UI.ChartType` (enum) | bazodanowe, tylko-odczyt | Typ wykresu drugiej osi Y | Typ wykresu związanego z drugą osią Y |
| SecondYAxisTitle | `string` | bazodanowe, tylko-odczyt | Tytuł drugiej osi Y | Tytuł drugiej osi Y |
| SegmentChartLabelFormat | `UI.SegmentChartLabelFormat` (enum) | bazodanowe, tylko-odczyt | Format etykiet | Określa format etykiet wykresów typu: Pie, Donut, Pyramid, Funnel |
| StackType | `UI.StackType` (enum) | bazodanowe, tylko-odczyt | Układ danych | Określa w jaki sposób dane mają być przedstawiane na wykresie kolumnowym |
| TrendLine | `UI.ChartTrendLine` (enum) | bazodanowe, tylko-odczyt | Linia trendu | Włącza i pozwala wybrać linię trendu |
| XAxisTitle | `string` | bazodanowe, tylko-odczyt | Tytuł osi X | Tytuł osi X |
| YAxisTitle | `string` | bazodanowe, tylko-odczyt | Tytuł osi Y | Tytuł osi Y |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ChartVariant (`Soneta.BI.ChartVariant`)
- `Standard` = 0 — Podstawowy (1 wymiar, 1 miara)
- `MultiSeries` = 1 — Wieloseryjny (1 wymiar, wiele miar)
- `Grouped` = 2 — Grupowany (2 wymiary, 1 miara)
- `StackGrouped` = 3 — Skumulowano-grupowany (2 wymiary, wiele miar)
- `SecondYAxis` = 4 — Z drugą osią Y (1 wymiar, 2 miary)
- `Bubble` = 5 — Podstawowy (1 wymiar, 3 miary)
- `Scatter` = 6 — Podstawowy (1 wymiar i 2 miary)

### ChartLabelPosition (`UI.ChartLabelPosition`)
- `Center` = 0 — Wewnątrz
- `Left` = 1 — Na zewnątrz po lewej
- `Right` = 2 — Na zewnątrz po prawej
- `DataLabelEnable` = 11 — Włączone
- `AggregateEnable` = 12 — Podsumowanie
- `AreaSeries` = 21 — Serie
- `AreaSeriesAggregate` = 22 — Podsumowanie + serie
- `BarEnabled` = 31 — Na zewnątrz
- `BarInnerTop` = 32 — Wewnątrz do góry
- `BarSeriesTop` = 33 — Serie do góry
- `BarInnerCenter` = 34 — Wewnątrz do środka
- `BarSeriesCenter` = 35 — Serie do środka
- `BarInnerBottom` = 36 — Wewnątrz do dołu
- `BarSeriesBottom` = 37 — Serie do dołu
- `BarSeriesAggregateTop` = 40 — Podsumowanie + serie do góry
- `BarSeriesAggregateCenter` = 41 — Podsumowanie + serie do środka
- `BarSeriesAggregateBottom` = 42 — Podsumowanie + serie do dołu
- `None` = 99 — Brak

### ChartTrendLine (`UI.ChartTrendLine`)
- `None` = 0 — Brak
- `LinearSingleLine` = 1 — Regresja liniowa (1 linia)
- `LinearMultiline` = 2 — Regresja liniowa (wiele linii)
- `MovingAverageSingleLine` = 3 — Średnia krocząca (1 linia)
- `MovingAverageMultiline` = 4 — Średnia krocząca (wiele linii)

### ChartType (`UI.ChartType`)
- `Bar` = 0 — Kolumnowy (Bar)
- `Line` = 1 — Liniowy (Line)
- `Pie` = 2 — Kołowy (Pie)
- `Donut` = 3 — Pierścieniowy (Donut)
- `Spider` = 4 — Radarowy (Spider)
- `Polar` = 5 — Biegunowy (Polar)
- `Area` = 6 — Warstwowy (Area)
- `Pyramid` = 7 — Piramidowy (Pyramid)
- `Funnel` = 8 — Lejkowy (Funnel)
- `Bubble` = 9 — Bąbelkowy (Bubble)
- `Scatter` = 10 — Punktowy (Scatter)
- `Gauge` = 11

### ColorPaletteBase (`UI.ColorPaletteBase`)
- `None` = -1 — Brak
- `Default` = 0 — Automatyczny
- `Red` = 1 — Czerwony
- `Orange` = 2 — Pomarańczowy
- `Yellow` = 3 — Żółty
- `Blue` = 4 — Niebieski
- `Grey` = 5 — Szary
- `Green` = 6 — Zielony
- `Turquise` = 7 — Turkusowy

### PieChartLabelPosition (`UI.PieChartLabelPosition`)
- `Circle` = 0 — Wewnątrz
- `Side` = 1 — Na zewnątrz

### SegmentChartLabelFormat (`UI.SegmentChartLabelFormat`)
- `Percent` = 0 — Procent
- `Value` = 1 — Wartość
- `PercentAndValue` = 2 — Procent i wartość
- `ValueAndPercent` = 3 — Wartośc i procent

### StackType (`UI.StackType`)
- `Stack` = 0 — Skumulowany
- `Side` = 1 — Grupowany
- `Overlay` = 2 — Nakładany
- `Percentage` = 3 — Procentowy
