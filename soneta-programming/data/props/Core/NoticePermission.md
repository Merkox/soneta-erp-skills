# Pola i właściwości klasy biznesowej: `Soneta.Core.NoticePermission`
Nazwa tabeli: `NoticePerms`
Tytuł: Zgody na odbiór powiadomienia
Opis: Zgoda odbiorcy na otrzymywanie powiadomień z danego kanału. ŝączy kanał komunikatów z odbiorcą, przechowując status zgody i datę udzielenia lub wycofania.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `System.DateTime` | bazodanowe |  |  |
| NoticeChannel | `Soneta.Core.NoticeChannel` | bazodanowe |  |  |
| NoticeRecipient | `Soneta.Business.INoticeRecipient` | bazodanowe, iface-ref |  |  |
| PermissionStatus | `Soneta.Core.NoticePermissionStatus` | bazodanowe, enum |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| NoticeRecipient | `INoticeRecipient` | `Operator`, `WebUser` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### NoticePermissionStatus (`Soneta.Core.NoticePermissionStatus`)
- `None` = 0 — Brak decyzji
- `Approval` = 1 — Zgoda
- `Refusal` = 2 — Odmowa
