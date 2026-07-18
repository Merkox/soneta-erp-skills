# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionTopic`
Nazwa tabeli: `DiscussionTopics`
Tytuł: Tematy dyskusji
Opis: Element szczegółowy dyskusji (Discussion). Temat (wątek) w ramach dyskusji z autorem, statusem, datą utworzenia, treścią, kategorią, przypisanym użytkownikiem i flagą usunięcia. Tematy grupują komentarze.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDiscussionItem`, `ICommentDataHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AssignedUser | `ITaskUser` | bazodanowe, tylko-odczyt, iface-ref | Powiązany użytkownik |  |
| Author | `IOwner` | bazodanowe | Autor |  |
| CalcTopicHeight | `double` | tylko-odczyt |  |  |
| Category | `Soneta.Core.Conversation.ThreadCategory` | bazodanowe | Kategoria |  |
| CommentHost | `Soneta.Core.Conversation.ICommentHostParams` | tylko-odczyt |  |  |
| CommentHostParams | `Soneta.Core.Conversation.CommentHostParams` | tylko-odczyt |  |  |
| Comments | `System.Collections.Generic.ICollection<Soneta.Core.Conversation.Comment>` | podlista |  |  |
| CreationDate | `System.DateTime` | bazodanowe | Data utworzenia |  |
| Deleted | `bool` | bazodanowe, tylko-odczyt |  |  |
| Discussion | `Soneta.Core.Conversation.Discussion` | bazodanowe, tylko-odczyt |  |  |
| Edited | `bool` | tylko-odczyt |  |  |
| HostAttachements | `System.Collections.Generic.ICollection<Db.Attachment>` | podlista |  |  |
| IsActive | `bool` | tylko-odczyt |  |  |
| ItemUpdates | `SubTable<Soneta.Core.Conversation.DiscussionUpdate>` | podlista |  |  |
| LastItemUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| LastPendingUpdates | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionUpdate>` | podlista |  |  |
| Likes | `SubTable<Soneta.Core.Conversation.DiscussionReaction>` | podlista |  |  |
| LikesCount | `int` | tylko-odczyt |  |  |
| ModificationDate | `System.DateTime` | tylko-odczyt |  |  |
| MyArchive | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| MyFavourite | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| MyLike | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| NotificationMessage | `Notifications.Models.NotificationMessage` |  |  |  |
| Original | `Row` | tylko-odczyt |  |  |
| PendingUpdate | `bool` | tylko-odczyt |  |  |
| Source | `string` | tylko-odczyt |  |  |
| Text | `Soneta.Core.Conversation.DiscussionText` (subrow) | bazodanowe | Treść |  |
| Text.Text | `MemoText` | podlista |  |  |
| Text.TextSafe | `MemoText` | podlista |  |  |
| Text.Value | `MemoText` | bazodanowe, podlista | Treść |  |
| TextValue | `string` | tylko-odczyt |  |  |
| TopicState | `Soneta.Core.Conversation.DiscussionTopicState` (enum) | bazodanowe | Satus | Status tematu dyskusji |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| AssignedUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DiscussionTopicState (`Soneta.Core.Conversation.DiscussionTopicState`)
- `Active` = 0 — Aktywny
- `Pending` = 1 — Oczekujący
- `Close` = 2 — Zamknięty
