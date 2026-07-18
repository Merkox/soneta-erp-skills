# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionUser`
Nazwa tabeli: `DiscussionUsers`
Tytuł: Użytkownicy dyskusji
Opis: Element szczegółowy dyskusji (Discussion). Uczestnik dyskusji z określoną osobą, rodzajem (np. prowadzący, uczestnik, obserwator), statusem i powiązaniem z dyskusją.
Tabela konfiguracyjna: Nie
Guided: root
Selektor: pole `PersonKind` (`Soneta.Core.Conversation.PersonKind`) — wiele typów w jednej tabeli, podtypów: 3

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
| PersonKind | `Soneta.Core.Conversation.PersonKind` (enum) | bazodanowe, tylko-odczyt, selektor | Rodzaj użytkownika | Rodzaj użytkownika dyskusji |
| PersonState | `Soneta.Core.Conversation.DiscussionUserState` (enum) | bazodanowe | Satus | Status użytkownika dyskusji |
| PersonStateIcon | `string` | tylko-odczyt |  |  |
| Rejected | `bool` | tylko-odczyt |  |  |
| TextValue | `string` | tylko-odczyt |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `PersonKind`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `RequiredReviewer` | 0 | `Soneta.Core.Conversation.Models.DiscussionRequiredReviewer` |  |
| `OptionalReviewer` | 1 | `Soneta.Core.Conversation.Models.DiscussionOptionalReviewer` |  |
| `Participant` | 2 | `Soneta.Core.Conversation.Models.DiscussionParticipant` |  |

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
