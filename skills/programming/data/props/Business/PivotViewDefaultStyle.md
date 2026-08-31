# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.PivotViewDefaultStyle`
Nazwa tabeli: `PivotDftStyles`
Tytuł: Domyślne układy tabel przestawnych
Opis: Domyślny układ tabeli przestawnej dla operatora i lokalizacji. Wskazuje, który z zapisanych układów ma być automatycznie stosowany.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `PivotView` → `PivotView`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IndividualGuid | `System.Guid` | bazodanowe | Identyfikator użytkownika |  |
| Location | `string` | bazodanowe | Lokalizacja tabeli przestawnej |  |
| PivotView | `Db.PivotView` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Style | `Db.PivotViewStyle` | bazodanowe | Układ | Układ tabeli przestawnej |
