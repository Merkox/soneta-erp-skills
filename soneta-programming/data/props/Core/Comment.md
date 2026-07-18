# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.Comment`
Nazwa tabeli: `Comments`
Tytuł: Komentarze
Opis: Komentarz w dyskusji lub wątku. Zawiera właściciela, treść, datę dodania i edycji, typ, hosta (temat dyskusji), przypisanego użytkownika oraz flagi (draft, publiczny, usunięty, prosty).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDiscussionItem`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 12
- podlisty: 5
- subrowy: 1
- razem: 27

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AssignedUser | `ITaskUser` | bazodanowe, tylko-odczyt, iface-ref | Powiązany użytkownik |  |
| CalcCommentHeight | `double` | tylko-odczyt |  |  |
| Created | `System.DateTime` | bazodanowe | Data dodania |  |
| Deleted | `bool` | bazodanowe, tylko-odczyt |  |  |
| Draft | `bool` | bazodanowe |  |  |
| Edited | `bool` | tylko-odczyt |  |  |
| Host | `Soneta.Core.Conversation.ICommentDataHost` | bazodanowe, iface-ref | Host |  |
| ItemUpdates | `SubTable<Soneta.Core.Conversation.DiscussionUpdate>` | podlista |  |  |
| LastItemUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| LikeCounter | `int` | tylko-odczyt |  |  |
| Likes | `SubTable<Soneta.Core.Conversation.DiscussionReaction>` | podlista |  |  |
| Modified | `System.DateTime` | bazodanowe | Data edycji |  |
| MyArchive | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| MyFavourite | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| MyLike | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| NotificationMessage | `Notifications.Models.NotificationMessage` |  |  |  |
| Original | `Row` | tylko-odczyt |  |  |
| Owner | `IOwner` | bazodanowe | Właściciel |  |
| PendingUpdate | `bool` | tylko-odczyt |  |  |
| Public | `bool` | bazodanowe |  |  |
| Simple | `bool` | bazodanowe |  |  |
| Text | `Soneta.Core.Conversation.DiscussionText` (subrow) | bazodanowe | Treść |  |
| Text.Text | `MemoText` | podlista |  |  |
| Text.TextSafe | `MemoText` | podlista |  |  |
| Text.Value | `MemoText` | bazodanowe, podlista | Treść |  |
| Type | `Soneta.Core.Conversation.CommentType` (enum) | bazodanowe |  |  |

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
