# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSpanSetDefinition`
Nazwa tabeli: `DataSpanSetDefs`
Tytuł: Zestawy przedziałów danych
Opis: Definicja zestawu przedziałów danych używanego do klasyfikacji wartości pól w wizualizacjach BI. Określa typ zestawu, typ bazodanowy pola oraz sposób podziału wartości na zakresy (np. przedziały kwotowe, procentowe).
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSpanSetType | `Soneta.BI.DataSpanSetType` | bazodanowe, enum | Typ zestawu |  |
| FieldType | `Soneta.Data.Schema.FieldType` | bazodanowe, enum | Typ(DB) |  |
| IsAbsoluteSpan | `bool` |  |  |  |
| IsReferenceSpan | `bool` |  |  |  |
| IsRelativeSpan | `bool` |  |  |  |
| Items | `Soneta.Business.LpSubTable<Soneta.BI.DataSpanItemDefinition>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Value | `string` | bazodanowe | Wartość |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DataSpanSetType (`Soneta.BI.DataSpanSetType`)
- `AbsoluteSpan` = 1 — Bezwzględny
- `RelativeSpan` = 2 — Względny
- `ReferenceSpan` = 3 — Referencyjny

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
