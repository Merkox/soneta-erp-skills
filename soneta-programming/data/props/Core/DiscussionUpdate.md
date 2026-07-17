# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionUpdate`
Nazwa tabeli: `DiscussUpdates`
Tytuł: Aktualizacja dyskusji
Opis: Element szczegółowy elementu dyskusji (IDiscussionItem). Rejestruje pojedynczą zmianę w dyskusji - pole, rodzaj aktualizacji, autora, powiązanego użytkownika, datę i wartość. Tworzy historię zmian dyskusji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDiscussionItem`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Action | `Soneta.Core.Conversation.DiscussionUpdateFieldAction` | bazodanowe, enum | Rodzaj aktualizacji |  |
| AssignedUser | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Powiązany użytkownik |  |
| Author | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Autor |  |
| Date | `System.DateTime` | bazodanowe | Data aktualizacji |  |
| Discussion | `Soneta.Core.Conversation.Discussion` | bazodanowe |  |  |
| DiscussionItem | `Soneta.Core.Conversation.IDiscussionItem` | bazodanowe, iface-ref |  |  |
| Field | `Soneta.Core.Conversation.DiscussionUpdateField` | bazodanowe, enum | Pole |  |
| ItemUpdates | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionUpdate>` |  |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| Likes | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionReaction>` |  |  |  |
| NotificationMessage | `Soneta.Business.Notifications.Models.NotificationMessage` |  |  |  |
| Value | `Soneta.Business.MemoText` | bazodanowe | Treść |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| AssignedUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
| Author | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
| DiscussionItem | `IDiscussionItem` | `Comment`, `Discussion`, `DiscussionTopic`, `DiscussionUpdate` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DiscussionUpdateField (`Soneta.Core.Conversation.DiscussionUpdateField`)
- `Name` = 1 — Nazwa
- `Value` = 2 — Wartość
- `RequiredReviewer` = 3 — Wymagany recenzent
- `OptionalReviewer` = 4 — Opcjonalny recenzent
- `Participant` = 5 — Uczestnik
- `RelatedObject` = 6 — Obiekt powiązany
- `Status` = 7 — Status
- `Attachment` = 8 — Załącznik
- `Aprove` = 9 — Akceptacja
- `ChildTopic` = 10 — Nowy wpis
- `Self` = 20 — Obiekt
- `Parent` = 30 — Obiekt nadrzędny

### DiscussionUpdateFieldAction (`Soneta.Core.Conversation.DiscussionUpdateFieldAction`)
- `Add` = 1 — Nowy
- `Update` = 2 — Aktualizacja
- `Remove` = 3 — Usunięcie
- `Other` = 10 — Inne
