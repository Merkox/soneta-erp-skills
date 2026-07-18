# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionUser`
Nazwa tabeli: `DiscussionUsers`
Tytuł: Użytkownicy dyskusji
Opis: Element szczegółowy dyskusji (Discussion). Uczestnik dyskusji z określoną osobą, rodzajem (np. prowadzący, uczestnik, obserwator), statusem i powiązaniem z dyskusją.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 15
- podlisty: 0
- subrowy: 0
- razem: 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Approved | `bool` | tylko-odczyt |  |  |
| Avatar | `NamedStream` |  |  |  |
| Discussion | `Soneta.Core.Conversation.Discussion` | bazodanowe |  |  |
| HasReview | `bool` | tylko-odczyt |  |  |
| IsNotRemoved | `bool` | tylko-odczyt |  |  |
| LastItemUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| LastPendingUpdate | `Soneta.Core.Conversation.DiscussionUpdate` | tylko-odczyt |  |  |
| MyArchive | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| MyFavourite | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| MyLike | `Soneta.Core.Conversation.DiscussionReaction` | tylko-odczyt |  |  |
| NotificationMessage | `Notifications.Models.NotificationMessage` |  |  |  |
| Original | `Row` | tylko-odczyt |  |  |
| PendingUpdate | `bool` | tylko-odczyt |  |  |
| Person | `IOwner` | bazodanowe, tylko-odczyt | Użytkownik | Użytkownik dyskusji |
| PersonKind | `Soneta.Core.Conversation.PersonKind` (enum) | bazodanowe, tylko-odczyt | Rodzaj użytkownika | Rodzaj użytkownika dyskusji |
| PersonState | `Soneta.Core.Conversation.DiscussionUserState` (enum) | bazodanowe | Satus | Status użytkownika dyskusji |
| PersonStateIcon | `string` | tylko-odczyt |  |  |
| Rejected | `bool` | tylko-odczyt |  |  |
| TextValue | `string` | tylko-odczyt |  |  |

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
