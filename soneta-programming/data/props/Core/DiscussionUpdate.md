# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionUpdate`
Nazwa tabeli: `DiscussUpdates`
Tytuł: Aktualizacja dyskusji
Opis: Element szczegółowy elementu dyskusji (IDiscussionItem). Rejestruje pojedynczą zmianę w dyskusji - pole, rodzaj aktualizacji, autora, powiązanego użytkownika, datę i wartość. Tworzy historię zmian dyskusji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDiscussionItem`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 8
- podlisty: 3
- subrowy: 0
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Action | `Soneta.Core.Conversation.DiscussionUpdateFieldAction` (enum) | bazodanowe, tylko-odczyt | Rodzaj aktualizacji |  |
| AssignedUser | `ITaskUser` | bazodanowe, tylko-odczyt, iface-ref | Powiązany użytkownik |  |
| Author | `ITaskUser` | bazodanowe, tylko-odczyt, iface-ref | Autor |  |
| Date | `System.DateTime` | bazodanowe, tylko-odczyt | Data aktualizacji |  |
| Discussion | `Soneta.Core.Conversation.Discussion` | bazodanowe, tylko-odczyt |  |  |
| DiscussionItem | `Soneta.Core.Conversation.IDiscussionItem` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Field | `Soneta.Core.Conversation.DiscussionUpdateField` (enum) | bazodanowe, tylko-odczyt | Pole |  |
| ItemUpdates | `SubTable<Soneta.Core.Conversation.DiscussionUpdate>` | podlista |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| Likes | `SubTable<Soneta.Core.Conversation.DiscussionReaction>` | podlista |  |  |
| NotificationMessage | `Notifications.Models.NotificationMessage` |  |  |  |
| Value | `MemoText` | bazodanowe, podlista | Treść |  |

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
