# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.PivotViewStyle`
Nazwa tabeli: `PivotViewStyles`
Tytuł: Układy tabel przestawnych
Opis: Zapisany układ tabeli przestawnej. Przechowuje konfigurację wierszy, kolumn i wartości raportu przestawnego z możliwością udostępnienia innym operatorom.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IndividualGuid | `System.Guid` | bazodanowe | Identyfikator użytkownika |  |
| Layout | `Soneta.Business.MemoText` | bazodanowe | Zapis układu tabeli przestawnej |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa układu tabeli przestawnej |
| PivotView | `Soneta.Business.Db.PivotView` | bazodanowe |  |  |
| Shared | `bool` | bazodanowe | Udostępniony |  |
