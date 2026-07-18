# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionRel`
Nazwa tabeli: `DiscussionRels`
Tytuł: Relacje dyskusji
Opis: Element szczegółowy dyskusji (Discussion). Powiązanie dyskusji z dowolnym obiektem biznesowym w systemie poprzez słabą referencję (GUID i nazwa tabeli).
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Discussion | `Soneta.Core.Conversation.Discussion` | bazodanowe |  |  |
| LastItemUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| MyArchive | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| MyFavourite | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| MyLike | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| NotificationMessage | `Notifications.Models.NotificationMessage` |  |  |  |
| Original | `Row` | tylko-odczyt |  |  |
| PendingUpdate | `bool` | tylko-odczyt |  |  |
| Reference | `Soneta.Core.Conversation.WeakTableReference` (subrow) | bazodanowe |  |  |
| Reference.ByReference | `Key` | podlista |  |  |
| Reference.Description | `string` | bazodanowe, tylko-odczyt | Opis | Opis host dyskusji. |
| Reference.RefGuid | `System.Guid` | bazodanowe, tylko-odczyt | Identyfikator | Identyfikator rekordu |
| Reference.RefTable | `string` | bazodanowe, tylko-odczyt | Nazwa | Nazwa tabeli |
| Reference.Row | `GuidedRow` | tylko-odczyt |  |  |
| TextValue | `string` | tylko-odczyt |  |  |
