# Pola i właściwości klasy biznesowej: `Soneta.Business.ExternalDatabases.ExternalDatabase`
Nazwa tabeli: `ExtDatabases`
Tytuł: Zewnętrzne bazy danych
Opis: Konfiguracja połączenia z zewnętrzną bazą danych SQL. Przechowuje parametry serwera, nazwę bazy, dane logowania i przeznaczenie połączenia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`
Selektor: pole `Area` (`ExternalDatabases.ExternalDatabaseArea`) — wiele typów w jednej tabeli, podtypów: 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Area | `ExternalDatabases.ExternalDatabaseArea` (enum) | bazodanowe, tylko-odczyt, selektor | Przeznaczenie |  |
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

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Area`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `BI` | 1 | `ExternalDatabases.ExternalBIDatabase` | Baza danych BI |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ExternalDatabaseArea (`ExternalDatabases.ExternalDatabaseArea`)
- `BI` = 1 — BI

### ExternalDatabaseType (`Soneta.Data.ExternalDatabaseType`)
- `MsSql` = 1 — Baza MS SQL
