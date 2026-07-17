# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.PivotViewDefaultStyle`
Nazwa tabeli: `PivotDftStyles`
Tytuł: Domyślne układy tabel przestawnych
Opis: Domyślny układ tabeli przestawnej dla operatora i lokalizacji. Wskazuje, który z zapisanych układów ma być automatycznie stosowany.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `PivotView` → `PivotView`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IndividualGuid | `System.Guid` | bazodanowe | Identyfikator użytkownika |  |
| Location | `string` | bazodanowe | Lokalizacja tabeli przestawnej |  |
| PivotView | `Soneta.Business.Db.PivotView` | bazodanowe, guided-parent |  |  |
| Style | `Soneta.Business.Db.PivotViewStyle` | bazodanowe | Układ | Układ tabeli przestawnej |
