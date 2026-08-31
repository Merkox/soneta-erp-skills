# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.LockInfo`
Nazwa tabeli: `LockInfos`
Tytuł: Edytowane zapisy
Opis: Informacja o blokadzie zapisu edytowanego przez operatora. Służy do zarządzania współbieżnym dostępem do rekordów w systemie wieloużytkownikowym.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Action | `Db.LockInfoAction` (enum) | bazodanowe, tylko-odczyt |  |  |
| Instance | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
| ModificationTime | `System.DateTime` | bazodanowe, tylko-odczyt |  |  |
| OperatorID | `int` | bazodanowe, tylko-odczyt |  |  |
| RecordID | `int` | bazodanowe, tylko-odczyt |  |  |
| RecordTable | `string` | bazodanowe, tylko-odczyt |  |  |
| SessionID | `int` | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### LockInfoAction (`Db.LockInfoAction`)
- `RecordEditing` = 0
- `RecordUndone` = 1
- `SessionCommitted` = 2
- `SessionCancelled` = 3
