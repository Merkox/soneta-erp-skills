# Pola i właściwości klasy biznesowej: `Soneta.Core.NoticeReceipt`
Nazwa tabeli: `NoticeReceipts`
Tytuł: Potwierdzenia odbioru
Opis: Potwierdzenie odbioru komunikatu przez adresata. ŝączy komunikat z odbiorcą, przechowując status odbioru, czas potwierdzenia i status potwierdzenia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfirmationStatus | `Soneta.Core.ConfirmationStatus` | bazodanowe, enum | Status potwierdzenia | Status potwierdzenia. |
| ConfirmationTime | `System.DateTime` | bazodanowe | Czas potwierdzenia | Czas potwierdzenia otrzymanego powiadomienia |
| ConfirmedTime | `string` |  |  |  |
| Notice | `Soneta.Core.Notice` | bazodanowe | Wiadomość |  |
| ReceiptStatus | `Soneta.Core.NoticeReceiptStatus` | bazodanowe, enum |  |  |
| Recipient | `Soneta.Business.INoticeRecipient` | bazodanowe, iface-ref | Adresat |  |
| ResponseTime | `string` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Recipient | `INoticeRecipient` | `Operator`, `WebUser` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ConfirmationStatus (`Soneta.Core.ConfirmationStatus`)
- `InProgress` = 0 — W realizacji
- `ConfirmedOnTime` = 1 — Potwierdzono na czas
- `ConfirmedAfterTime` = 2 — Potwierdzono po czasie
- `NoConfirmation` = 3 — Brak potwierdzenia
- `All` = 4 — Wszystkie

### NoticeReceiptStatus (`Soneta.Core.NoticeReceiptStatus`)
- `Available` = 0 — Wiadomość nieodczytana
- `Received` = 1 — Wiadomość odczytana
- `WithLike` = 2 — Wiadomość polubiona
