# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DashboardArea`
Nazwa tabeli: `DashbrdAreas`
Tytuł: Obszary
Opis: Obszar lub kategoria w hierarchii folderów pulpitów. Organizuje panele w drzewo tematyczne z ikoną i kolejnością wyświetlania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AreaParent | `Soneta.Business.Db.DashboardArea` |  |  |  |
| AreaType | `string` |  |  |  |
| Children | `Soneta.Business.SubTable<Soneta.Business.Db.DashboardArea>` |  |  |  |
| Description | `string` | bazodanowe | Opis | Opisuje zawartość i zastosowanie. |
| IconName | `string` | bazodanowe | Ikona | Nazwa ikony wyświetlanej w folderze. |
| IsArea | `bool` |  |  |  |
| IsCategory | `bool` |  |  |  |
| IsStartCategory | `bool` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa obszaru/kategorii wyświetlana w drzewie folderów. |
| NormalizedOrder | `int` |  |  |  |
| Order | `int` | bazodanowe | Kolejność | Kolejność wyświetlania obszaru/kategorii |
| Parent | `Soneta.Business.Db.DashboardArea` | bazodanowe | Nazwa | Obszar nadrzędny do kategorii. |
| Path | `string` |  |  |  |
| Siblings | `System.Collections.Generic.IEnumerable<Soneta.Business.Db.DashboardArea>` |  |  |  |
| TranslatedPath | `string` |  |  |  |
| Views | `Soneta.Business.SubTable<Soneta.Business.Db.DashboardView>` |  |  |  |
