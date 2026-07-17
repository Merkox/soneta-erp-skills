# Pola i właściwości klasy biznesowej: `Soneta.BI.ReportParam`
Nazwa tabeli: `ReportParams`
Tytuł: Parametry raportu
Opis: Element szczegółowy modelu danych (DataModel). Definiuje parametr filtrujący raport analityczny, np. zakres dat, pole filtrujące czy algorytm obliczeniowy. Parametry mogą być opcjonalne i służą do zawężania zakresu prezentowanych danych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Code | `Soneta.BI.ReportParamCode` | bazodanowe | Algorytm |  |
| DateSlicerType | `Soneta.BI.DateSlicerType` | bazodanowe, enum | Typ filtru daty |  |
| Field | `Soneta.BI.FieldProxy` | bazodanowe |  |  |
| Field.Definition | `Soneta.BI.FieldDefinition` | bazodanowe | Definicja pola |  |
| Field.FieldDefinition | `Soneta.BI.Interfaces.IFieldDefinition` |  |  |  |
| Field.GroupBy | `Soneta.BI.ModelGroupBy` |  |  |  |
| Field.Join | `Soneta.BI.ModelJoin` |  |  |  |
| Field.Name | `string` | bazodanowe | Nazwa pola |  |
| Field.OrderBy | `Soneta.BI.ModelOrderBy` |  |  |  |
| Field.Param | `Soneta.BI.ReportParam` |  |  |  |
| Field.WgDefinition | `Soneta.Business.Key` |  |  |  |
| IsDateSlicer | `bool` | bazodanowe | Filtr daty |  |
| IsOptional | `bool` | bazodanowe | Parametr opcjonalny |  |
| Lp | `int` | bazodanowe |  |  |
| Model | `Soneta.BI.DataModel` | bazodanowe | Model danych |  |
| Name | `string` | bazodanowe | Nazwa |  |
| RelatedField | `Soneta.BI.FieldProxy` | bazodanowe |  |  |
| Type | `Soneta.BI.ReportParamType` | bazodanowe, enum | Rodzaj parametru raportu |  |

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
