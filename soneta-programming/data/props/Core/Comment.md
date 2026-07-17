# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.Comment`
Nazwa tabeli: `Comments`
Tytuł: Komentarze
Opis: Komentarz w dyskusji lub wątku. Zawiera właściciela, treść, datę dodania i edycji, typ, hosta (temat dyskusji), przypisanego użytkownika oraz flagi (draft, publiczny, usunięty, prosty).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDiscussionItem`

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AssignedUser | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Powiązany użytkownik |  |
| CalcCommentHeight | `double` |  |  |  |
| Created | `System.DateTime` | bazodanowe | Data dodania |  |
| Deleted | `bool` | bazodanowe |  |  |
| Draft | `bool` | bazodanowe |  |  |
| Edited | `bool` |  |  |  |
| EstimatedHeightInHtml | `int` |  |  |  |
| EstimatedHeightInWin | `int` |  |  |  |
| Host | `Soneta.Core.Conversation.ICommentDataHost` | bazodanowe, iface-ref | Host |  |
| ItemUpdates | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionUpdate>` |  |  |  |
| LastItemUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| LikeCounter | `int` |  |  |  |
| Likes | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionReaction>` |  |  |  |
| Modified | `System.DateTime` | bazodanowe | Data edycji |  |
| MyArchive | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| MyFavourite | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| MyLike | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| NotificationMessage | `Soneta.Business.Notifications.Models.NotificationMessage` |  |  |  |
| Original | `Soneta.Business.Row` |  |  |  |
| Owner | `Soneta.Business.IOwner` | bazodanowe | Właściciel |  |
| PendingUpdate | `bool` |  |  |  |
| Public | `bool` | bazodanowe |  |  |
| Simple | `bool` | bazodanowe |  |  |
| Text | `Soneta.Core.Conversation.DiscussionText` | bazodanowe | Treść |  |
| Text.Text | `Soneta.Business.MemoText` |  |  |  |
| Text.TextSafe | `Soneta.Business.MemoText` |  |  |  |
| Text.Value | `Soneta.Business.MemoText` | bazodanowe | Treść |  |
| Type | `Soneta.Core.Conversation.CommentType` | bazodanowe, enum |  |  |
| Value | `Soneta.Business.MemoText` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| AssignedUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
| Host | `ICommentDataHost` | `DiscussionTopic` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CommentType (`Soneta.Core.Conversation.CommentType`)
- `RichText` = 0
- `Xml` = 1
- `CSharp` = 2
