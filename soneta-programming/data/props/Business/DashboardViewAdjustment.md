# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DashboardViewAdjustment`
Nazwa tabeli: `DashbrdViewAdjs`
Tytuł: Modyfikacje kafelków
Opis: Indywidualne modyfikacje położenia i rozmiaru kafelka na pulpicie dla konkretnego operatora. Umożliwia personalizację układu pulpitu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Tile` → `DashboardViewTile`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Column | `int` | bazodanowe | Kolumna | Położenie X w jednostkach siatki na pulpicie (-1 brak). |
| Height | `int` | bazodanowe | Wysokość | Wysokość w jednostkach siatki elementu pulpitu jeżeli definiowalna. |
| Identity | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
| IdentityType | `string` | bazodanowe, tylko-odczyt |  |  |
| IsStashed | `bool` | bazodanowe | W schowku | Określa czy kafelek znajduje się w schowku. |
| Priority | `int` | bazodanowe | Priorytet | Kolejność, wg której układane są klocki na siatce. |
| Row | `int` | bazodanowe | Wiersz | Położenie Y w jednostkach siatki na pulpicie (-1 brak). |
| Tile | `Db.DashboardViewTile` | bazodanowe, tylko-odczyt, guided-parent | Kafelek |  |
| Width | `int` | bazodanowe | Szerokość | Szerokość w jednostkach siatki elementu pulpitu jeżeli definiowalna. |
