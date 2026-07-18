# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DashboardArea`
Nazwa tabeli: `DashbrdAreas`
Tytuł: Obszary
Opis: Obszar lub kategoria w hierarchii folderów pulpitów. Organizuje panele w drzewo tematyczne z ikoną i kolejnością wyświetlania.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AreaParent | `Db.DashboardArea` |  |  |  |
| AreaType | `string` | tylko-odczyt |  |  |
| Children | `SubTable<Db.DashboardArea>` | podlista |  |  |
| Description | `string` | bazodanowe | Opis | Opisuje zawartość i zastosowanie. |
| IconName | `string` | bazodanowe | Ikona | Nazwa ikony wyświetlanej w folderze. |
| IsArea | `bool` | tylko-odczyt |  |  |
| IsCategory | `bool` | tylko-odczyt |  |  |
| IsStartCategory | `bool` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa obszaru/kategorii wyświetlana w drzewie folderów. |
| NormalizedOrder | `int` | tylko-odczyt |  |  |
| Order | `int` | bazodanowe | Kolejność | Kolejność wyświetlania obszaru/kategorii |
| Parent | `Db.DashboardArea` | bazodanowe | Nazwa | Obszar nadrzędny do kategorii. |
| Path | `string` | tylko-odczyt |  |  |
| Siblings | `System.Collections.Generic.IEnumerable<Db.DashboardArea>` | podlista |  |  |
| TranslatedPath | `string` | tylko-odczyt |  |  |
| Views | `SubTable<Db.DashboardView>` | podlista |  |  |
