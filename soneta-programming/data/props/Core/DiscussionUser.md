# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionUser`
Nazwa tabeli: `DiscussionUsers`
Tytuł: Użytkownicy dyskusji
Opis: Element szczegółowy dyskusji (Discussion). Uczestnik dyskusji z określoną osobą, rodzajem (np. prowadzący, uczestnik, obserwator), statusem i powiązaniem z dyskusją.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Approved | `bool` |  |  |  |
| Avatar | `Soneta.Business.NamedStream` |  |  |  |
| DeletionDate | `System.DateTime` | bazodanowe | Data usunięcia |  |
| Discussion | `Soneta.Core.Conversation.Discussion` | bazodanowe |  |  |
| HasReview | `bool` |  |  |  |
| IsNotRemoved | `bool` |  |  |  |
| LastItemUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` |  |  |  |
| MyArchive | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| MyFavourite | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| MyLike | `Soneta.Core.Conversation.DiscussionReaction` |  |  |  |
| NotificationMessage | `Soneta.Business.Notifications.Models.NotificationMessage` |  |  |  |
| Original | `Soneta.Business.Row` |  |  |  |
| PendingUpdate | `bool` |  |  |  |
| Person | `Soneta.Business.IOwner` | bazodanowe | Użytkownik | Użytkownik dyskusji |
| PersonKind | `Soneta.Core.Conversation.PersonKind` | bazodanowe, enum | Rodzaj użytkownika | Rodzaj użytkownika dyskusji |
| PersonState | `Soneta.Core.Conversation.DiscussionUserState` | bazodanowe, enum | Satus | Status użytkownika dyskusji |
| PersonStateIcon | `string` |  |  |  |
| Rejected | `bool` |  |  |  |
| TextValue | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DiscussionUserState (`Soneta.Core.Conversation.DiscussionUserState`)
- `None` = 0
- `Approved` = 1 — Zatwierdzony
- `Pending` = 2 — Oczekujący
- `Rejected` = 3 — Odrzucony

### PersonKind (`Soneta.Core.Conversation.PersonKind`)
- `RequiredReviewer` = 0 — Wymagany recenzent
- `OptionalReviewer` = 1 — Opcjonalny recenzent
- `Participant` = 2 — Uczestnik
