# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionTopic`
Nazwa tabeli: `DiscussionTopics`
Tytuł: Tematy dyskusji
Opis: Element szczegółowy dyskusji (Discussion). Temat (wątek) w ramach dyskusji z autorem, statusem, datą utworzenia, treścią, kategorią, przypisanym użytkownikiem i flagą usunięcia. Tematy grupują komentarze.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDiscussionItem`, `ICommentDataHost`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 25

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AssignedUser | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Powiązany użytkownik |  |
| Author | `Soneta.Business.IOwner` | bazodanowe | Autor |  |
| CalcTopicHeight | `double` |  |  |  |
| Category | `Soneta.Core.Conversation.ThreadCategory` | bazodanowe | Kategoria |  |
| CommentHost | `Soneta.Core.Conversation.ICommentHostParams` |  |  |  |
| CommentHostParams | `Soneta.Core.Conversation.CommentHostParams` |  |  |  |
| Comments | `System.Collections.Generic.ICollection<Soneta.Core.Conversation.Comment>` |  |  |  |
| CreationDate | `System.DateTime` | bazodanowe | Data utworzenia |  |
| Deleted | `bool` | bazodanowe |  |  |
| Discussion | `Soneta.Core.Conversation.Discussion` | bazodanowe |  |  |
| Edited | `bool` |  |  |  |
| HostAttachements | `System.Collections.Generic.ICollection<Soneta.Business.Db.Attachment>` |  |  |  |
| IsActive | `bool` |  |  |  |
| ItemUpdates | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionUpdate>` |  |  |  |
| LastItemUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| LastPendingUpdates | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionUpdate>` |  |  |  |
| Likes | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionReaction>` |  |  |  |
| LikesCount | `int` |  |  |  |
| ModificationDate | `System.DateTime` |  |  |  |
| MyArchive | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| MyFavourite | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| MyLike | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| NotificationMessage | `Soneta.Business.Notifications.Models.NotificationMessage` |  |  |  |
| Original | `Soneta.Business.Row` |  |  |  |
| PendingUpdate | `bool` |  |  |  |
| Source | `string` |  |  |  |
| Text | `Soneta.Core.Conversation.DiscussionText` | bazodanowe | Treść |  |
| Text.Text | `Soneta.Business.MemoText` |  |  |  |
| Text.TextSafe | `Soneta.Business.MemoText` |  |  |  |
| Text.Value | `Soneta.Business.MemoText` | bazodanowe | Treść |  |
| TextValue | `string` |  |  |  |
| TopicState | `Soneta.Core.Conversation.DiscussionTopicState` | bazodanowe, enum | Satus | Status tematu dyskusji |
| Value | `Soneta.Business.MemoText` |  |  |  |

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
