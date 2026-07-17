# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSpanItemDefinition`
Nazwa tabeli: `DataSpanItemDefs`
Tytuł: Definicje elementów przedziałów danych
Opis: Element szczegółowy zestawu przedziałów danych (DataSpanSetDefinition). Definiuje pojedynczy przedział w zestawie — jego nazwę, wartość graniczną i współczynnik. Przedziały służą do mapowania wartości liczbowych na nazwane zakresy w wizualizacjach.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DataSpanSet` → `DataSpanSetDefinition`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSpanSet | `Soneta.BI.DataSpanSetDefinition` | bazodanowe, guided-parent | Definicja zestawu |  |
| Factor | `decimal` | bazodanowe | Współczynnik |  |
| FieldType | `Soneta.Data.Schema.FieldType` | bazodanowe, enum | Typ(DB) |  |
| Lp | `int` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Result | `string` |  |  |  |
| SpanValue | `object` |  |  |  |
| Value | `string` | bazodanowe | Wartość |  |

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
