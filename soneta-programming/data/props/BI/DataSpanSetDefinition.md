# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSpanSetDefinition`
Nazwa tabeli: `DataSpanSetDefs`
Tytuł: Zestawy przedziałów danych
Opis: Definicja zestawu przedziałów danych używanego do klasyfikacji wartości pól w wizualizacjach BI. Określa typ zestawu, typ bazodanowy pola oraz sposób podziału wartości na zakresy (np. przedziały kwotowe, procentowe).
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 1
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSpanSetType | `Soneta.BI.DataSpanSetType` (enum) | bazodanowe | Typ zestawu |  |
| FieldType | `Soneta.Data.Schema.FieldType` (enum) | bazodanowe, tylko-odczyt | Typ(DB) |  |
| IsAbsoluteSpan | `bool` | tylko-odczyt |  |  |
| IsReferenceSpan | `bool` | tylko-odczyt |  |  |
| IsRelativeSpan | `bool` | tylko-odczyt |  |  |
| Items | `LpSubTable<Soneta.BI.DataSpanItemDefinition>` | podlista |  |  |
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
