# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.IK.ChronoOrderElem`
Nazwa tabeli: `ChronoOrderElems`
Tytuł: Elementy składu chronologicznego
Opis: Przechowuje informacje o zarejestrowanych elementach składu chronologicznego w systemie. Elementy składu chronologicznego mają powiązanie z dokumentami podstawowymi, jeżeli na danej definicji dokumentu podstawowego włączono obsługę składów chronologicznych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`, `IDmsArchInfoHost`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 3
- podlisty: 4
- subrowy: 1
- razem: 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ArchInfos | `SubTable<Soneta.Workflow.Dms.IK.DmsArchInfo>` | podlista |  |  |
| Attachment | `Db.Attachment` | bazodanowe | Załącznik | Załącznik |
| ChronoOrder | `Soneta.Workflow.Dms.IK.ChronoOrder` | bazodanowe | Skład | Skład |
| DataType | `Soneta.Workflow.Dms.IK.DataTypeEnum` (enum) | bazodanowe | Typ przechowywanych danych | Typ przechowywanych danych w składzie |
| Description | `MemoText` | bazodanowe, podlista | Opis | Opis |
| Document | `Soneta.Workflow.Dms.IK.Interfaces.IChronoOrderHost` | bazodanowe, tylko-odczyt, iface-ref | Host | Host |
| Name | `string` | bazodanowe, tylko-odczyt | Nazwa | Nazwa składu |
| Number | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe | Numer | Numer dokumentu |
| Number.Numer | `int` | bazodanowe |  |  |
| Number.NumerPelny | `string` |  |  |  |
| Number.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Number.Symbol | `string` | bazodanowe |  |  |
| Number.WgNumeruDokumentu | `Key` | podlista |  |  |
| Number.WgSymboluDokumentu | `Key` | podlista |  |  |
| StateType | `Soneta.Workflow.Dms.IK.ChronoOrderElemState` (enum) | bazodanowe | Status | Status dokumentu |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Document | `IChronoOrderHost` | `BasicDocument` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ChronoOrderElemState (`Soneta.Workflow.Dms.IK.ChronoOrderElemState`)
- `Available` = 0 — Dostępny
- `Rented` = 100 — Wypożyczony
- `Deregistered` = 200 — Wyrejestrowany
- `Disposed` = 300 — Zbrakowany
- `Archived` = 400 — Zarchiwizowany

### DataTypeEnum (`Soneta.Workflow.Dms.IK.DataTypeEnum`)
- `Attachment` = 0 — Załącznik
- `Data` = 100 — Nośnik danych
