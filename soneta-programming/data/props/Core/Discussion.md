# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.Discussion`
Nazwa tabeli: `Discussions`
Tytuł: Dyskusje
Opis: Instancja dyskusji (procesu komunikacji). Zawiera numer, nazwę, autora, definicję, host (obiekt biznesowy), status, datę utworzenia, konfigurację wyświetlania segmentów i flagę prywatności. Dyskusja grupuje tematy, użytkowników i relacje.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDiscussionItem`, `IDiscussionPlugInHost`

- pola bazodanowe (zapisywalne): 18
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 30
- podlisty: 14
- subrowy: 3
- razem: 67

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActiveUsers | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionUser>` | podlista |  |  |
| Author | `IOwner` | bazodanowe | Autor |  |
| CalcHeight | `double` | tylko-odczyt |  |  |
| CreationDate | `System.DateTime` | bazodanowe | Data utworzenia |  |
| Data | `Date` | tylko-odczyt |  |  |
| Definicja | `Soneta.Core.IDefinicjaDokumentu` | tylko-odczyt, iface-ref |  |  |
| Definition | `Soneta.Core.Conversation.DefDiscussion` | bazodanowe, tylko-odczyt | Definicja dyskusji |  |
| DiscussionHost | `Soneta.Core.Conversation.WeakTableReference` (subrow) | bazodanowe | Host |  |
| DiscussionHost.ByReference | `Key` | podlista |  |  |
| DiscussionHost.Description | `string` | bazodanowe, tylko-odczyt | Opis | Opis host dyskusji. |
| DiscussionHost.RefGuid | `System.Guid` | bazodanowe, tylko-odczyt | Identyfikator | Identyfikator rekordu |
| DiscussionHost.RefTable | `string` | bazodanowe, tylko-odczyt | Nazwa | Nazwa tabeli |
| DiscussionHost.Row | `GuidedRow` | tylko-odczyt |  |  |
| DiscussionState | `Soneta.Core.Conversation.DiscussionState` (enum) | bazodanowe | Status | Status dyskusji |
| Display | `Soneta.Core.Conversation.Display` (subrow) | bazodanowe | Wyświetlanie segmentów formularza | Wyświetlanie segmentów formularza |
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
| Display.UserRightType | `Soneta.Core.Conversation.DiscussionRightType` (enum) | bazodanowe | Typ prawa przypisanego użytkownika |  |
| Display.Users | `bool` | bazodanowe | Segment użytkowników | Segment użytkowników |
| EditDate | `Date` | tylko-odczyt |  |  |
| Edited | `bool` | tylko-odczyt |  |  |
| HasUnreadComments | `bool` | tylko-odczyt |  |  |
| Host | `IGuidedRow` | tylko-odczyt |  |  |
| IsActive | `bool` | tylko-odczyt |  |  |
| ItemUpdates | `SubTable<Soneta.Core.Conversation.DiscussionUpdate>` | podlista |  |  |
| LastItemUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| LastPendingUpdates | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionUpdate>` | podlista |  |  |
| Likes | `SubTable<Soneta.Core.Conversation.DiscussionReaction>` | podlista |  |  |
| ModificationDate | `System.DateTime` | tylko-odczyt |  |  |
| MyArchive | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| MyFavourite | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| MyLike | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa dyskusji | Nazwa dyskusji |
| NotificationMessage | `Notifications.Models.NotificationMessage` |  |  |  |
| Number | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe | Numer dyskusji | Numer dyskusji |
| Number.Numer | `int` | bazodanowe |  |  |
| Number.NumerPelny | `string` |  |  |  |
| Number.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Number.Symbol | `string` | bazodanowe |  |  |
| Number.WgNumeruDokumentu | `Key` | podlista |  |  |
| Number.WgSymboluDokumentu | `Key` | podlista |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | tylko-odczyt |  |  |
| Options | `Soneta.Core.Conversation.StandardEngine.DiscussionOptionsConfig` | tylko-odczyt |  |  |
| Original | `Row` | tylko-odczyt |  |  |
| PendingUpdate | `bool` | tylko-odczyt |  |  |
| PlugIns | `LpSubTable<Soneta.Core.Conversation.DiscussionPlugInRef>` | podlista |  |  |
| Private | `bool` | bazodanowe, tylko-odczyt | Prywatna |  |
| ReadStatus | `Soneta.Core.Conversation.DiscussionReadStatus` | tylko-odczyt |  |  |
| Relations | `SubTable<Soneta.Core.Conversation.DiscussionRel>` | podlista |  |  |
| RequiredReviewers | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionUser>` | podlista |  |  |
| Reviewers | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionUser>` | podlista |  |  |
| TableName | `string` | tylko-odczyt |  |  |
| TextValue | `string` | tylko-odczyt |  |  |
| Topics | `SubTable<Soneta.Core.Conversation.DiscussionTopic>` | podlista |  |  |
| UnReadCommentsCount | `int` | tylko-odczyt | Nieprzeczytane wiadomości |  |
| UnReadTopicsCount | `int` | tylko-odczyt | Nieprzeczytane tematy |  |
| Updates | `SubTable<Soneta.Core.Conversation.DiscussionUpdate>` | podlista |  |  |
| Users | `SubTable<Soneta.Core.Conversation.DiscussionUser>` | podlista |  |  |

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
