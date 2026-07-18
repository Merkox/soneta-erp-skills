# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardItemField`
Nazwa tabeli: `DashBrdItemFlds`
Tytuł: Pola elementu wizualizacji
Opis: Element szczegółowy definicji wizualizacji (DashboardItemDefinition). Wskazuje pole modelu danych wyświetlane w kafelku, określając jego kolejność, szerokość kolumny oraz przypisanie do osi wykresu (wymiar/miara).
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BIFieldType | `Soneta.BI.BIFieldType` (enum) | tylko-odczyt |  |  |
| Dimension | `UI.AxisDimension` (enum) | bazodanowe | Kolejność |  |
| Field | `Soneta.BI.FieldDefinition` | bazodanowe | Pole |  |
| FieldType | `Soneta.Data.Schema.FieldType` (enum) | tylko-odczyt |  |  |
| ItemDefinition | `Soneta.BI.DashboardItemDefinition` | bazodanowe, tylko-odczyt | Element wizualizacji |  |
| Lp | `int` | bazodanowe |  |  |
| Width | `int` | bazodanowe | Szerokość pola |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### BIFieldType (`Soneta.BI.BIFieldType`)
- `None` = 0 — Brak
- `Dimension` = 1 — Wymiar
- `Measure` = 2 — Miara

### AxisDimension (`UI.AxisDimension`)
- `Enum` = 0 — Wartościowo
- `AZ` = 1 — Alfabetycznie
- `Hash3` = 2 — Testowy hash 3
- `Hash10` = 3 — Testowy hash 10
- `DayByDays` = 4 — Dzienny
- `WeekByDays` = 5 — Tygodniowy
- `MonthByDays` = 6 — Miesięczny
- `ByNumbers` = 7 — Wg liczb
- `ByDays` = 8 — Wg dni
- `ByWeeks` = 9 — Wg tygodni
- `ByMonths` = 10 — Wg miesięcy
- `ByYears` = 11 — Wg lat
- `ByOrderEnum` = 12 — Rosnąco
- `ByOrderDescEnum` = 13 — Malejąco

### FieldType (`Soneta.Data.Schema.FieldType`)
- `None` = 0 — Brak
- `String` = 1 — Tekst
- `Int32` = 2 — Liczba całkowita (32)
- `Int64` = 3 — Liczba całkowita (64)
- `Enum` = 4 — Wyliczenie (enum)
- `Date` = 5 — Data
- `Time` = 6 — Czas
- `DateTime` = 7 — Data-czas
- `Boolean` = 8 — Wartość logiczna
- `Double` = 9 — Liczba zmiennoprzecinkowa
- `Percent` = 10 — Procent
- `Decimal` = 11 — Liczba dziesiętna
- `Guid` = 12 — Guid
- `MemoText` = 13 — Tekst (duży)
- `MemoBin` = 14 — Wartość binarna
- `TimeSec` = 15 — Czas sekund
