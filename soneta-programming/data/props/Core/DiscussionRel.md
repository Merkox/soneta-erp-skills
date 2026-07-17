# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionRel`
Nazwa tabeli: `DiscussionRels`
Tytuł: Relacje dyskusji
Opis: Element szczegółowy dyskusji (Discussion). Powiązanie dyskusji z dowolnym obiektem biznesowym w systemie poprzez słabą referencję (GUID i nazwa tabeli).
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DeletionDate | `System.DateTime` | bazodanowe | Data usunięcia |  |
| Discussion | `Soneta.Core.Conversation.Discussion` | bazodanowe |  |  |
| IsRemoved | `bool` |  |  |  |
| LastItemUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| MyArchive | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| MyFavourite | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| MyLike | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| NotificationMessage | `Soneta.Business.Notifications.Models.NotificationMessage` |  |  |  |
| Original | `Soneta.Business.Row` |  |  |  |
| PendingUpdate | `bool` |  |  |  |
| Reference | `Soneta.Core.Conversation.WeakTableReference` | bazodanowe |  |  |
| Reference.ByReference | `Soneta.Business.Key` |  |  |  |
| Reference.Description | `string` | bazodanowe | Opis | Opis host dyskusji. |
| Reference.RefGuid | `System.Guid` | bazodanowe | Identyfikator | Identyfikator rekordu |
| Reference.RefTable | `string` | bazodanowe | Nazwa | Nazwa tabeli |
| Reference.Row | `Soneta.Business.GuidedRow` |  |  |  |
| TextValue | `string` |  |  |  |
