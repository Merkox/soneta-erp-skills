# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSpanItemDefinition`
Nazwa tabeli: `DataSpanItemDefs`
Tytuł: Definicje elementów przedziałów danych
Opis: Element szczegółowy zestawu przedziałów danych (DataSpanSetDefinition). Definiuje pojedynczy przedział w zestawie — jego nazwę, wartość graniczną i współczynnik. Przedziały służą do mapowania wartości liczbowych na nazwane zakresy w wizualizacjach.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DataSpanSet` → `DataSpanSetDefinition`
Selektor: pole `FieldType` (`Soneta.Data.Schema.FieldType`) — wiele typów w jednej tabeli, podtypów: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSpanSet | `Soneta.BI.DataSpanSetDefinition` | bazodanowe, tylko-odczyt, guided-parent | Definicja zestawu |  |
| Factor | `decimal` | bazodanowe | Współczynnik |  |
| FieldType | `Soneta.Data.Schema.FieldType` (enum) | bazodanowe, tylko-odczyt, selektor | Typ(DB) |  |
| Lp | `int` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Result | `string` | tylko-odczyt |  |  |
| SpanValue | `object` |  |  |  |
| Value | `string` | bazodanowe | Wartość |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `FieldType`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `String` | 1 | `Soneta.BI.StringDataSpanItemDefinition` |  |
| `Int32` | 2 | `Soneta.BI.IntegerDataSpanItemDefinition` |  |
| `Date` | 5 | `Soneta.BI.DateDataSpanItemDefinition` |  |
| `Percent` | 10 | `Soneta.BI.PercentDataSpanItemDefinition` |  |
| `Decimal` | 11 | `Soneta.BI.DecimalDataSpanItemDefinition` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

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
