# Pola i właściwości klasy biznesowej: `Soneta.Business.ExternalDatabases.ExternalDatabase`
Nazwa tabeli: `ExtDatabases`
Tytuł: Zewnętrzne bazy danych
Opis: Konfiguracja połączenia z zewnętrzną bazą danych SQL. Przechowuje parametry serwera, nazwę bazy, dane logowania i przeznaczenie połączenia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 10
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Area | `ExternalDatabases.ExternalDatabaseArea` (enum) | bazodanowe, tylko-odczyt | Przeznaczenie |  |
| DatabaseName | `string` | bazodanowe |  |  |
| Locked | `bool` | bazodanowe | Zablokowana |  |
| MultiSubnetFailover | `bool` | bazodanowe |  |  |
| Name | `string` | bazodanowe |  |  |
| Password | `string` | bazodanowe |  |  |
| Server | `string` | bazodanowe |  |  |
| Timeout | `int` | bazodanowe |  |  |
| TrustServerCertificate | `bool` | bazodanowe |  |  |
| Trusted | `bool` | bazodanowe |  |  |
| Type | `Soneta.Data.ExternalDatabaseType` (enum) | bazodanowe, tylko-odczyt |  |  |
| User | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ExternalDatabaseArea (`ExternalDatabases.ExternalDatabaseArea`)
- `BI` = 1 — BI

### ExternalDatabaseType (`Soneta.Data.ExternalDatabaseType`)
- `MsSql` = 1 — Baza MS SQL
