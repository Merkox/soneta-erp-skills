# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.LockInfo`
Nazwa tabeli: `LockInfos`
Tytuł: Edytowane zapisy
Opis: Informacja o blokadzie zapisu edytowanego przez operatora. Służy do zarządzania współbieżnym dostępem do rekordów w systemie wieloużytkownikowym.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Action | `Soneta.Business.Db.LockInfoAction` | bazodanowe, enum |  |  |
| Instance | `System.Guid` | bazodanowe |  |  |
| ModificationTime | `System.DateTime` | bazodanowe |  |  |
| OperatorID | `int` | bazodanowe |  |  |
| RecordID | `int` | bazodanowe |  |  |
| RecordTable | `string` | bazodanowe |  |  |
| SessionID | `int` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### LockInfoAction (`Soneta.Business.Db.LockInfoAction`)
- `RecordEditing` = 0
- `RecordUndone` = 1
- `SessionCommitted` = 2
- `SessionCancelled` = 3
