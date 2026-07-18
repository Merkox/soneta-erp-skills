# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSourceDatabase`
Nazwa tabeli: `DataSourceDbs`
Tytuł: Zewnętrzne źródła danych
Opis: Element szczegółowy źródła danych (DataSource). Przechowuje konfigurację połączenia z zewnętrzną bazą danych, w tym referencję do bazy oraz nazwę serwera połączonego (Linked Server) umożliwiającego zapytania międzybazowe.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSource | `Soneta.BI.DataSource` | bazodanowe, tylko-odczyt | Źródło danych |  |
| Database | `ExternalDatabases.ExternalDatabase` | bazodanowe, tylko-odczyt | Zewnętrzna baza danych |  |
| LinkedServerName | `string` | bazodanowe |  | Nazwa serwera w innych bazach (Linked Server) |
