# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.IK.ChronoOrder`
Nazwa tabeli: `ChronoOrders`
Tytuł: Składy chronologiczne
Opis: Przechowuje informacje o obiektach składów chronologicznych w module DMS. Umożliwia wskazanie konkretnego rodzaju składu na dany rok oraz pozwala na sterowanie aktywnością składu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDefinicjaDokumentu`, `IPermissionClient`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Access | `Soneta.Workflow.Enums.AccessEnum` (enum) | bazodanowe | Dostęp | Dostęp do składu |
| Active | `bool` | bazodanowe | Aktywny | Aktywny skład |
| ChronoOrderLoc | `Soneta.Workflow.Dms.IK.ChronoOrderLoc` | bazodanowe | Lokalizacja składu | Lokalizacja składu |
| Creator | `App.Operator` | bazodanowe, tylko-odczyt | Założył | Operator, który założył skład |
| DataType | `Soneta.Workflow.Dms.IK.DataTypeEnum` (enum) | bazodanowe | Typ przechowywanych danych | Typ przechowywanych danych w składzie |
| IsVisibleNumerator | `bool` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa składu |
| Numerator | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe | Numeracja | Określa sposób numerowania definicji |
| Numerator.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numerator.PodczasZapisu | `bool` |  |  |  |
| Numerator.Separator | `string` | bazodanowe |  |  |
| Numerator.Wzor | `string` | bazodanowe |  |  |
| Permissions | `SubTable<Db.Permissions.RecordPermission>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol składu |
| Type | `Soneta.Workflow.Dms.IK.ChronoOrderTypeEnum` (enum) | bazodanowe | Rodzaj składu | Rodzaj składu |
| Year | `int` | bazodanowe | Na rok | Dedykowany dla roku |
| YearToString | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ChronoOrderTypeEnum (`Soneta.Workflow.Dms.IK.ChronoOrderTypeEnum`)
- `SCP` = 0 — Skład chronologiczny przesyłek w pełni odwzorowanych (SCP)
- `SCN` = 100 — Skład chronologiczny przesyłek nie w pełni odwzorowanych (SCN)
- `SCW` = 200 — Skład chronologiczny pism wytworzonych wewnątrz (SCW)
- `SIND` = 300 — Skład informatycznych nośników danych

### DataTypeEnum (`Soneta.Workflow.Dms.IK.DataTypeEnum`)
- `Attachment` = 0 — Załącznik
- `Data` = 100 — Nośnik danych

### AccessEnum (`Soneta.Workflow.Enums.AccessEnum`)
- `Public` = 0 — Publiczny - dostępny w całości
- `PartialPublic` = 1 — Publiczny - dostępny częściowo
- `Private` = 2 — Niepubliczny
