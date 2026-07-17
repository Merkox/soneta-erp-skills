# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSourceDatabase`
Nazwa tabeli: `DataSourceDbs`
Tytuł: Zewnętrzne źródła danych
Opis: Element szczegółowy źródła danych (DataSource). Przechowuje konfigurację połączenia z zewnętrzną bazą danych, w tym referencję do bazy oraz nazwę serwera połączonego (Linked Server) umożliwiającego zapytania międzybazowe.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSource | `Soneta.BI.DataSource` | bazodanowe | Źródło danych |  |
| Database | `Soneta.Business.ExternalDatabases.ExternalDatabase` | bazodanowe | Zewnętrzna baza danych |  |
| LinkedServerName | `string` | bazodanowe |  | Nazwa serwera w innych bazach (Linked Server) |
