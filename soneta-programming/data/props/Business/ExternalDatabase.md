# Pola i właściwości klasy biznesowej: `Soneta.Business.ExternalDatabases.ExternalDatabase`
Nazwa tabeli: `ExtDatabases`
Tytuł: Zewnętrzne bazy danych
Opis: Konfiguracja połączenia z zewnętrzną bazą danych SQL. Przechowuje parametry serwera, nazwę bazy, dane logowania i przeznaczenie połączenia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Area | `Soneta.Business.ExternalDatabases.ExternalDatabaseArea` | bazodanowe, enum | Przeznaczenie |  |
| DatabaseName | `string` | bazodanowe |  |  |
| Locked | `bool` | bazodanowe | Zablokowana |  |
| MultiSubnetFailover | `bool` | bazodanowe |  |  |
| Name | `string` | bazodanowe |  |  |
| Password | `string` | bazodanowe |  |  |
| Server | `string` | bazodanowe |  |  |
| Timeout | `int` | bazodanowe |  |  |
| TrustServerCertificate | `bool` | bazodanowe |  |  |
| Trusted | `bool` | bazodanowe |  |  |
| Type | `Soneta.Data.ExternalDatabaseType` | bazodanowe, enum |  |  |
| User | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ExternalDatabaseArea (`Soneta.Business.ExternalDatabases.ExternalDatabaseArea`)
- `BI` = 1 — BI

### ExternalDatabaseType (`Soneta.Data.ExternalDatabaseType`)
- `MsSql` = 1 — Baza MS SQL
