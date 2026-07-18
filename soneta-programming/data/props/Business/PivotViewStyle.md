# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.PivotViewStyle`
Nazwa tabeli: `PivotViewStyles`
Tytuł: Układy tabel przestawnych
Opis: Zapisany układ tabeli przestawnej. Przechowuje konfigurację wierszy, kolumn i wartości raportu przestawnego z możliwością udostępnienia innym operatorom.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IndividualGuid | `System.Guid` | bazodanowe | Identyfikator użytkownika |  |
| Layout | `MemoText` | bazodanowe, podlista | Zapis układu tabeli przestawnej |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa układu tabeli przestawnej |
| PivotView | `Db.PivotView` | bazodanowe, tylko-odczyt |  |  |
| Shared | `bool` | bazodanowe | Udostępniony |  |
