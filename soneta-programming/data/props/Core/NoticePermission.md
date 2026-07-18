# Pola i właściwości klasy biznesowej: `Soneta.Core.NoticePermission`
Nazwa tabeli: `NoticePerms`
Tytuł: Zgody na odbiór powiadomienia
Opis: Zgoda odbiorcy na otrzymywanie powiadomień z danego kanału. ŝączy kanał komunikatów z odbiorcą, przechowując status zgody i datę udzielenia lub wycofania.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `System.DateTime` | bazodanowe |  |  |
| NoticeChannel | `Soneta.Core.NoticeChannel` | bazodanowe |  |  |
| NoticeRecipient | `INoticeRecipient` | bazodanowe, iface-ref |  |  |
| PermissionStatus | `Soneta.Core.NoticePermissionStatus` (enum) | bazodanowe |  |  |

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
