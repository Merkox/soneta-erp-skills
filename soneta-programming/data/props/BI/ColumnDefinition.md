# Pola i właściwości klasy biznesowej: `DevExpress.XtraLayout.ColumnDefinition`
Nazwa tabeli: `ColumnDefs`
Tytuł: Definicja kolumn danych biznesowych
Opis: Element szczegółowy definicji zestawu danych (DataSetDefinition). Definiuje pojedynczą kolumnę zestawu danych — jej nazwę, typ bazodanowy, typ BI oraz powiązanie z typem i ścieżką biznesową. Kolumny określają strukturę danych generowanych przez zestaw.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BIFieldType | `Soneta.BI.BIFieldType` (enum) | bazodanowe | Typ(BI) |  |
| BusinessPath | `string` | bazodanowe | Ścieżka biznesowa |  |
| BusinessTypeName | `string` | bazodanowe | Typ biznesowy |  |
| DataSet | `IRow` | bazodanowe | Definicja zestawu danych |  |
| FieldType | `Soneta.Data.Schema.FieldType` (enum) | bazodanowe | Typ(DB) |  |
| Name | `string` | bazodanowe | Nazwa |  |
| SizeType | `System.Windows.Forms.SizeType` |  |  |  |
| Visible | `bool` |  |  |  |
| Width | `double` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### BIFieldType (`Soneta.BI.BIFieldType`)
- `None` = 0 — Brak
- `Dimension` = 1 — Wymiar
- `Measure` = 2 — Miara

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
