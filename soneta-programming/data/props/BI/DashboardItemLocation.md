# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardItemLocation`
Nazwa tabeli: `DashItemLocs`
Tytuł: Lokalizacje wizualizacji
Opis: Przypisanie elementu wizualizacji (kafelka) do konkretnej lokalizacji na dashboardzie. Przechowuje pozycję, wymiary oraz identyfikator kafelka, umożliwiając odtworzenie układu panelu BI dla danego użytkownika lub typu danych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DashboardItem | `System.Guid` | bazodanowe |  |  |
| DataType | `string` | bazodanowe |  |  |
| Height | `int` | bazodanowe |  |  |
| Identity | `System.Guid` | bazodanowe |  |  |
| Index | `int` | bazodanowe |  |  |
| Location | `string` | bazodanowe |  |  |
| Width | `int` | bazodanowe |  |  |
