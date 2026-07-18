# Pola i właściwości klasy biznesowej: `Soneta.BI.ReportParam`
Nazwa tabeli: `ReportParams`
Tytuł: Parametry raportu
Opis: Element szczegółowy modelu danych (DataModel). Definiuje parametr filtrujący raport analityczny, np. zakres dat, pole filtrujące czy algorytm obliczeniowy. Parametry mogą być opcjonalne i służą do zawężania zakresu prezentowanych danych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 8
- podlisty: 1
- subrowy: 2
- razem: 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Code | `Soneta.BI.ReportParamCode` | bazodanowe | Algorytm |  |
| DateSlicerType | `Soneta.BI.DateSlicerType` (enum) | bazodanowe | Typ filtru daty |  |
| Field | `Soneta.BI.FieldProxy` (subrow) | bazodanowe |  |  |
| Field.Definition | `Soneta.BI.FieldDefinition` | bazodanowe, tylko-odczyt | Definicja pola |  |
| Field.FieldDefinition | `Soneta.BI.Interfaces.IFieldDefinition` | tylko-odczyt |  |  |
| Field.GroupBy | `Soneta.BI.ModelGroupBy` | tylko-odczyt |  |  |
| Field.Join | `Soneta.BI.ModelJoin` | tylko-odczyt |  |  |
| Field.Name | `string` | bazodanowe, tylko-odczyt | Nazwa pola |  |
| Field.OrderBy | `Soneta.BI.ModelOrderBy` | tylko-odczyt |  |  |
| Field.Param | `Soneta.BI.ReportParam` | tylko-odczyt |  |  |
| Field.WgDefinition | `Key` | podlista |  |  |
| IsDateSlicer | `bool` | bazodanowe | Filtr daty |  |
| IsOptional | `bool` | bazodanowe | Parametr opcjonalny |  |
| Lp | `int` | bazodanowe |  |  |
| Model | `Soneta.BI.DataModel` | bazodanowe, tylko-odczyt | Model danych |  |
| Name | `string` | bazodanowe | Nazwa |  |
| RelatedField | `Soneta.BI.FieldProxy` (subrow) | bazodanowe |  |  |
| Type | `Soneta.BI.ReportParamType` (enum) | bazodanowe | Rodzaj parametru raportu |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DateSlicerType (`Soneta.BI.DateSlicerType`)
- `ByFromTo` = 0 — Według okresu
- `ByDate` = 1 — Według daty
- `ByTimeSpan` = 2 — Według przedziału czasu

### ReportParamType (`Soneta.BI.ReportParamType`)
- `Business` = 0 — Biznesowy
- `Valuable` = 1 — Wartościowy
- `Reference` = 2 — Referencyjny
- `ValuableWithTable` = 3 — Wartościowy z tabelą bazy danych
- `All` = 99 — Wszystkie
