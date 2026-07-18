# Pola i właściwości klasy biznesowej: `Soneta.Core.SystemZewnDefXmlNag`
Nazwa tabeli: `SysZewnDefXmls`
Tytuł: Powiązanie systemu zewnętrznego z defnicją XML
Opis: Powiązanie systemu zewnętrznego z definicją XML określające, które definicje komunikatów są dostępne dla danego systemu. Zawiera referencję do definicji XML oraz ustawienia pobierania i aktualizacji danych.
Tabela konfiguracyjna: Tak

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefXmlNag | `Soneta.Core.DefXmlNag` | bazodanowe | Definicja |  |
| Get | `Soneta.Core.GetRestriction` (enum) | bazodanowe | Pobieranie |  |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe |  |  |
| Update | `bool` | bazodanowe | Aktualizacja |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### GetRestriction (`Soneta.Core.GetRestriction`)
- `Never` = 0 — Nigdy
- `Always` = 1 — Zawsze
- `SyncTask` = 2 — Wg zadań
