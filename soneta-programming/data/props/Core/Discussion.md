# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.Discussion`
Nazwa tabeli: `Discussions`
Tytuł: Dyskusje
Opis: Instancja dyskusji (procesu komunikacji). Zawiera numer, nazwę, autora, definicję, host (obiekt biznesowy), status, datę utworzenia, konfigurację wyświetlania segmentów i flagę prywatności. Dyskusja grupuje tematy, użytkowników i relacje.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDiscussionItem`, `IDiscussionPlugInHost`

- pola bazodanowe: 27
- pola kalkulowane (z klas biznesowych): 40

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActiveUsers | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionUser>` |  |  |  |
| Author | `Soneta.Business.IOwner` | bazodanowe | Autor |  |
| CalcHeight | `double` |  |  |  |
| CreationDate | `System.DateTime` | bazodanowe | Data utworzenia |  |
| Data | `Soneta.Types.Date` |  |  |  |
| Definicja | `Soneta.Core.IDefinicjaDokumentu` | iface-ref |  |  |
| Definition | `Soneta.Core.Conversation.DefDiscussion` | bazodanowe | Definicja dyskusji |  |
| DiscussionHost | `Soneta.Core.Conversation.WeakTableReference` | bazodanowe | Host |  |
| DiscussionHost.ByReference | `Soneta.Business.Key` |  |  |  |
| DiscussionHost.Description | `string` | bazodanowe | Opis | Opis host dyskusji. |
| DiscussionHost.RefGuid | `System.Guid` | bazodanowe | Identyfikator | Identyfikator rekordu |
| DiscussionHost.RefTable | `string` | bazodanowe | Nazwa | Nazwa tabeli |
| DiscussionHost.Row | `Soneta.Business.GuidedRow` |  |  |  |
| DiscussionState | `Soneta.Core.Conversation.DiscussionState` | bazodanowe, enum | Status | Status dyskusji |
| Display | `Soneta.Core.Conversation.Display` | bazodanowe | Wyświetlanie segmentów formularza | Wyświetlanie segmentów formularza |
| Display.Attachments | `bool` | bazodanowe | Segment załączników | Segment załączników |
| Display.ExtendedUserRight | `bool` | bazodanowe | Rozszerzone prawo przypisanego użytkownika |  |
| Display.History | `bool` | bazodanowe | Segment zmian | Segment zmian |
| Display.IsSingleThreadMode | `bool` | bazodanowe | Tryb jednowątkowy | Określa tryb dyskusji. |
| Display.ManyDiscussions | `bool` | bazodanowe | Host może posiadać wiele dyskusji | Host może posiadać wiele dyskusji |
| Display.Relations | `bool` | bazodanowe | Segment powiązań | Segment powiązań |
| Display.ShowDeleteAttachmentButton | `bool` | bazodanowe | Przycisk usuń segmentu załączników | Przycisk usuń segmentu załączników |
| Display.ShowEditAttachmentButton | `bool` | bazodanowe | Przycisk edytuj segmentu załączników | Przycisk edytuj segmentu załączników |
| Display.ShowOpenAttachmentButton | `bool` | bazodanowe | Przycisk otwórz segmentu załączników | Przycisk otwórz segmentu załączników |
| Display.ShowSaveAttachmentButton | `bool` | bazodanowe | Przycisk zapisu segmentu załączników | Przycisk zapisu segmentu załączników |
| Display.UserRightType | `Soneta.Core.Conversation.DiscussionRightType` | bazodanowe, enum | Typ prawa przypisanego użytkownika |  |
| Display.Users | `bool` | bazodanowe | Segment użytkowników | Segment użytkowników |
| EditDate | `Soneta.Types.Date` |  |  |  |
| Edited | `bool` |  |  |  |
| HasUnreadComments | `bool` |  |  |  |
| Host | `Soneta.Business.IGuidedRow` |  |  |  |
| IsActive | `bool` |  |  |  |
| ItemUpdates | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionUpdate>` |  |  |  |
| LastItemUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| LastPendingUpdates | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionUpdate>` |  |  |  |
| Likes | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionReaction>` |  |  |  |
| ModificationDate | `System.DateTime` |  |  |  |
| MyArchive | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| MyFavourite | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| MyLike | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| Name | `string` | bazodanowe | Nazwa dyskusji | Nazwa dyskusji |
| NotificationMessage | `Soneta.Business.Notifications.Models.NotificationMessage` |  |  |  |
| Number | `Soneta.Core.NumerDokumentu` | bazodanowe | Numer dyskusji | Numer dyskusji |
| Number.Numer | `int` | bazodanowe |  |  |
| Number.NumerPelny | `string` |  |  |  |
| Number.Pelny | `string` | bazodanowe | Numer pełny |  |
| Number.Symbol | `string` | bazodanowe |  |  |
| Number.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Number.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` |  |  |  |
| Options | `Soneta.Core.Conversation.StandardEngine.DiscussionOptionsConfig` |  |  |  |
| Original | `Soneta.Business.Row` |  |  |  |
| PendingUpdate | `bool` |  |  |  |
| PlugIns | `Soneta.Business.LpSubTable<Soneta.Core.Conversation.DiscussionPlugInRef>` |  |  |  |
| Private | `bool` | bazodanowe | Prywatna |  |
| ReadStatus | `Soneta.Core.Conversation.DiscussionReadStatus` |  |  |  |
| Relations | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionRel>` |  |  |  |
| RequiredReviewers | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionUser>` |  |  |  |
| Reviewers | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionUser>` |  |  |  |
| TableName | `string` |  |  |  |
| TextValue | `string` |  |  |  |
| Topics | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionTopic>` |  |  |  |
| UnReadCommentsCount | `int` |  | Nieprzeczytane wiadomości |  |
| UnReadTopicsCount | `int` |  | Nieprzeczytane tematy |  |
| Updates | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionUpdate>` |  |  |  |
| Users | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionUser>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definicja | `IDefinicjaDokumentu` | `ChronoOrder` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DiscussionRightType (`Soneta.Core.Conversation.DiscussionRightType`)
- `Full` = 0 — Pełne prawo
- `ReadOnly` = 1 — Tylko do odczytu
- `CommentOnly` = 2 — Dodawanie wątków i komentowanie

### DiscussionState (`Soneta.Core.Conversation.DiscussionState`)
- `All` = 0 — Wszystkie
- `Approved` = 1 — Zatwierdzony
- `Pending` = 2 — Oczekujący
- `Rejected` = 3 — Odrzucony
