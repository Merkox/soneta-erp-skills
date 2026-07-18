# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSource`
Nazwa tabeli: `DataSources`
Tytuł: Źródła danych
Opis: Rejestr źródeł danych wykorzystywanych przez moduł BI do pobierania informacji na potrzeby analiz. Umożliwia konfigurację połączeń z wewnętrznymi i zewnętrznymi bazami danych, z których zasilane są modele analityczne.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Name | `string` | bazodanowe | Nazwa |  |
| TableSources | `System.Collections.Generic.IEnumerable<Soneta.BI.Interfaces.ITableSource>` | podlista |  |  |
| Type | `Soneta.BI.DataSourceType` (enum) | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DataSourceType (`Soneta.BI.DataSourceType`)
- `None` = 0
- `Enova` = 1 — Baza operacyjna
- `EnovaReplicated` = 2
- `External` = 3 — Zewnętrzne źródło danych
