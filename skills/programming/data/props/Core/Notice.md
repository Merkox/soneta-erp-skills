# Pola i właściwości klasy biznesowej: `Soneta.Core.Notice`
Nazwa tabeli: `Notices`
Tytuł: Komunikaty
Opis: Komunikat (powiadomienie) wysłany kanałem dystrybucji. Zawiera temat, treść, streszczenie, kanał, nadawcę, kategorię, grupę odbiorców, okres ważności, identyfikator źródłowy, czas utworzenia i flagę blokady.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Category | `Soneta.Core.Conversation.ThreadCategory` | bazodanowe | Kategoria |  |
| Channel | `Soneta.Core.NoticeChannel` | bazodanowe, tylko-odczyt |  |  |
| Chips | `string` | tylko-odczyt |  |  |
| CreationTime | `System.DateTime` | bazodanowe | Czas utworzenia | Czas utworzenia powiadomienia. |
| Info | `string` | tylko-odczyt |  |  |
| IsLocked | `bool` | bazodanowe |  |  |
| LackOfSpecifiedNonServiceChannel | `bool` | tylko-odczyt |  |  |
| Msg | `MemoText` | bazodanowe, podlista |  |  |
| NumberOfLikes | `int` | tylko-odczyt |  |  |
| Receipts | `SubTable<Soneta.Core.NoticeReceipt>` | podlista |  |  |
| RecipientGroup | `NoticeRecipientGroup` (enum) | bazodanowe |  |  |
| Sender | `INoticeRecipient` | bazodanowe, iface-ref | Wysyłający | Wysyłający powiadomienie. |
| SourceId | `string` | bazodanowe |  |  |
| Subject | `string` | bazodanowe |  |  |
| Summary | `string` | bazodanowe |  |  |
| ValidFrom | `System.DateTime` | bazodanowe |  |  |
| ValidFromDate | `Date` |  |  |  |
| ValidFromTime | `Time` |  |  |  |
| ValidTo | `System.DateTime` | bazodanowe |  |  |
| ValidToDate | `Date` |  |  |  |
| ValidToTime | `Time` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Sender | `INoticeRecipient` | `Operator`, `WebUser` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### NoticeRecipientGroup (`NoticeRecipientGroup`)
- `AllGroups` = 0 — Wszyscy
- `Operators` = 1 — Operatorzy
- `Employees` = 2 — Pracownicy
- `ContactPersons` = 4 — Osoby kontaktowe
- `Chosen` = 8 — Wybrani
- `PanelUsers` = 16 — Użytkownicy panelu
