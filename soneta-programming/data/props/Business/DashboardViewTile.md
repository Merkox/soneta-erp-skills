# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DashboardViewTile`
Nazwa tabeli: `DashbrdViewTiles`
Tytuł: Kafelki pulpitów
Opis: Kafelek na pulpicie wyświetlający dane z folderu, wskaźnika lub innego źródła. Konfiguruje tytuł, ikonę, kolor, położenie na siatce i parametry prezentacji.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Dashboard` → `DashboardView`

- pola bazodanowe: 23
- pola kalkulowane (z klas biznesowych): 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adjustments | `Soneta.Business.SubTable<Soneta.Business.Db.DashboardViewAdjustment>` |  |  |  |
| Arg0 | `string` | bazodanowe | Argument 0 |  |
| Arg1 | `string` | bazodanowe | Argument 1 |  |
| Arg2 | `string` | bazodanowe | Argument 2 |  |
| Arg3 | `string` | bazodanowe | Argument 3 |  |
| Arg4 | `string` | bazodanowe | Argument 4 |  |
| ArgGuid0 | `System.Guid` |  |  |  |
| AutoLayout | `bool` |  |  |  |
| BackColor | `string` | bazodanowe | Kolor | Kolor tła kafelka. |
| Children | `System.Collections.Generic.IEnumerable<Soneta.Business.Db.DashboardViewTile>` |  |  |  |
| ClassName | `string` |  |  |  |
| Column | `int` | bazodanowe | Kolumna | Położenie X w jednostkach siatki na pulpicie (-1 brak). |
| ContextKey | `string` |  |  |  |
| ContextName | `string` | bazodanowe | Kontekst danych | Określa kontekst danych na pulpicie |
| Dashboard | `Soneta.Business.Db.DashboardView` | bazodanowe, guided-parent | Pulpit |  |
| Definition | `string` | bazodanowe | Definicja | Nazwa definicji danego kafelka pulpitu |
| Description | `string` | bazodanowe | Opis | Szczegółowy opis działania kafelka. |
| FolderPath | `string` | bazodanowe | Ścieżka folderu | Folder, do którego odnosi się kafelek. |
| FolderSourceName | `string` |  |  |  |
| FolderView | `Soneta.Business.UI.FolderView` |  |  |  |
| FormInfo | `Soneta.Business.UI.DataFormInfo` |  |  |  |
| FullClassName | `string` |  |  |  |
| Height | `int` | bazodanowe | Wysokość | Wysokość w jednostkach siatki elementu pulpitu jeżeli definiowalna. |
| IconName | `string` | bazodanowe | Ikona | Nazwa ikony wyświetlanej w kafelku. |
| Information | `string` |  |  |  |
| IsChild | `bool` |  |  |  |
| IsContextBinder | `bool` |  |  |  |
| IsSingleton | `bool` |  |  |  |
| Memo0 | `Soneta.Business.MemoText` | bazodanowe | Argument tekstowy 0 |  |
| Memo1 | `Soneta.Business.MemoText` | bazodanowe | Argument tekstowy 1 |  |
| Name | `string` | bazodanowe | Tytuł | Tytuł wyświetlany w nagłówku kafelka. |
| OpenInNewTab | `bool` | bazodanowe | W nowej zakładce | Określa, czy otwarcie formularza ma odbywać się w nowej zakładce programu. |
| Parent | `Soneta.Business.Db.DashboardViewTile` |  |  |  |
| ParentGuid | `System.Guid` | bazodanowe | Identyfikator nadrzędny | Identyfikator nadrzędnego kafelka. |
| Priority | `int` | bazodanowe | Priorytet | Kolejność, wg której układane są klocki na siatce. |
| Row | `int` | bazodanowe | Wiersz | Położenie Y w jednostkach siatki na pulpicie (-1 brak). |
| TileGuid | `System.Guid` | bazodanowe | Identyfikator | Unikalny identyfikator kafelka na pulpicie. |
| TypeName | `string` |  |  |  |
| Width | `int` | bazodanowe | Szerokość | Szerokość w jednostkach siatki elementu pulpitu jeżeli definiowalna. |
