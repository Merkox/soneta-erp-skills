# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSource`
Nazwa tabeli: `DataSources`
Tytuł: Źródła danych
Opis: Rejestr źródeł danych wykorzystywanych przez moduł BI do pobierania informacji na potrzeby analiz. Umożliwia konfigurację połączeń z wewnętrznymi i zewnętrznymi bazami danych, z których zasilane są modele analityczne.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Type` (`Soneta.BI.DataSourceType`) — wiele typów w jednej tabeli, podtypów: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Name | `string` | bazodanowe | Nazwa |  |
| TableSources | `System.Collections.Generic.IEnumerable<Soneta.BI.Interfaces.ITableSource>` | podlista |  |  |
| Type | `Soneta.BI.DataSourceType` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Type`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Enova` | 1 | `Soneta.BI.EnovaDatabase` |  |
| `EnovaReplicated` | 2 | `Soneta.BI.EnovaReplicatedDatabase` |  |
| `External` | 3 | `Soneta.BI.ExternalDataSource` | Zewnętrzne źródło danych |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DataSourceType (`Soneta.BI.DataSourceType`)
- `None` = 0
- `Enova` = 1 — Baza operacyjna
- `EnovaReplicated` = 2
- `External` = 3 — Zewnętrzne źródło danych
