# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardItemLocation`
Nazwa tabeli: `DashItemLocs`
Tytuł: Lokalizacje wizualizacji
Opis: Przypisanie elementu wizualizacji (kafelka) do konkretnej lokalizacji na dashboardzie. Przechowuje pozycję, wymiary oraz identyfikator kafelka, umożliwiając odtworzenie układu panelu BI dla danego użytkownika lub typu danych.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DashboardItem | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
| DataType | `string` | bazodanowe, tylko-odczyt |  |  |
| Height | `int` | bazodanowe, tylko-odczyt |  |  |
| Identity | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
| Index | `int` | bazodanowe, tylko-odczyt |  |  |
| Location | `string` | bazodanowe, tylko-odczyt |  |  |
| Width | `int` | bazodanowe, tylko-odczyt |  |  |
