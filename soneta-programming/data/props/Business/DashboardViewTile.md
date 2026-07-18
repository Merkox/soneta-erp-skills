# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DashboardViewTile`
Nazwa tabeli: `DashbrdViewTiles`
Tytuł: Kafelki pulpitów
Opis: Kafelek na pulpicie wyświetlający dane z folderu, wskaźnika lub innego źródła. Konfiguruje tytuł, ikonę, kolor, położenie na siatce i parametry prezentacji.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Dashboard` → `DashboardView`

- pola bazodanowe (zapisywalne): 19
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 13
- podlisty: 4
- subrowy: 0
- razem: 39

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adjustments | `SubTable<Db.DashboardViewAdjustment>` | podlista |  |  |
| Arg0 | `string` | bazodanowe | Argument 0 |  |
| Arg1 | `string` | bazodanowe | Argument 1 |  |
| Arg2 | `string` | bazodanowe | Argument 2 |  |
| Arg3 | `string` | bazodanowe | Argument 3 |  |
| Arg4 | `string` | bazodanowe | Argument 4 |  |
| ArgGuid0 | `System.Guid` |  |  |  |
| AutoLayout | `bool` |  |  |  |
| BackColor | `string` | bazodanowe | Kolor | Kolor tła kafelka. |
| Children | `System.Collections.Generic.IEnumerable<Db.DashboardViewTile>` | podlista |  |  |
| ClassName | `string` | tylko-odczyt |  |  |
| Column | `int` | bazodanowe | Kolumna | Położenie X w jednostkach siatki na pulpicie (-1 brak). |
| ContextKey | `string` | tylko-odczyt |  |  |
| ContextName | `string` | bazodanowe | Kontekst danych | Określa kontekst danych na pulpicie |
| Dashboard | `Db.DashboardView` | bazodanowe, tylko-odczyt, guided-parent | Pulpit |  |
| Definition | `string` | bazodanowe, tylko-odczyt | Definicja | Nazwa definicji danego kafelka pulpitu |
| Description | `string` | bazodanowe | Opis | Szczegółowy opis działania kafelka. |
| FolderPath | `string` | bazodanowe | Ścieżka folderu | Folder, do którego odnosi się kafelek. |
| FolderSourceName | `string` | tylko-odczyt |  |  |
| FolderView | `UI.FolderView` |  |  |  |
| FormInfo | `UI.DataFormInfo` | tylko-odczyt |  |  |
| FullClassName | `string` | tylko-odczyt |  |  |
| Height | `int` | bazodanowe | Wysokość | Wysokość w jednostkach siatki elementu pulpitu jeżeli definiowalna. |
| IconName | `string` | bazodanowe | Ikona | Nazwa ikony wyświetlanej w kafelku. |
| Information | `string` | tylko-odczyt |  |  |
| IsChild | `bool` | tylko-odczyt |  |  |
| IsContextBinder | `bool` | tylko-odczyt |  |  |
| IsSingleton | `bool` | tylko-odczyt |  |  |
| Memo0 | `MemoText` | bazodanowe, podlista | Argument tekstowy 0 |  |
| Memo1 | `MemoText` | bazodanowe, podlista | Argument tekstowy 1 |  |
| Name | `string` | bazodanowe | Tytuł | Tytuł wyświetlany w nagłówku kafelka. |
| OpenInNewTab | `bool` | bazodanowe | W nowej zakładce | Określa, czy otwarcie formularza ma odbywać się w nowej zakładce programu. |
| Parent | `Db.DashboardViewTile` | tylko-odczyt |  |  |
| ParentGuid | `System.Guid` | bazodanowe | Identyfikator nadrzędny | Identyfikator nadrzędnego kafelka. |
| Priority | `int` | bazodanowe | Priorytet | Kolejność, wg której układane są klocki na siatce. |
| Row | `int` | bazodanowe | Wiersz | Położenie Y w jednostkach siatki na pulpicie (-1 brak). |
| TileGuid | `System.Guid` | bazodanowe | Identyfikator | Unikalny identyfikator kafelka na pulpicie. |
| TypeName | `string` | tylko-odczyt |  |  |
| Width | `int` | bazodanowe | Szerokość | Szerokość w jednostkach siatki elementu pulpitu jeżeli definiowalna. |
