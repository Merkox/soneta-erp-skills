# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.TicketDefinition`
Nazwa tabeli: `TicketsDefs`
Tytuł: Definicje Zgłoszeń
Opis: Słownik definicji zgłoszeń serwisowych określający zasady obsługi w module ServiceDesk. Konfiguruje formularze operatora i klienta, numerację, dostępność załączników i komentarzy, notyfikacje email, domyślny zespół oraz reguły blokady edycji po zamknięciu zgłoszenia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 35
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AttachmentInRightPanel | `bool` | bazodanowe | Załączniki w prawym panelu |  |
| AttachmentMaxSizeKB | `int` | bazodanowe | Maksymalny rozmiar załącznika [KB] |  |
| AttachmentPageVisible | `bool` | bazodanowe | Załączniki dostępne |  |
| CommentAreaHeight | `int` | bazodanowe | Wysokość obszaru komentarzy |  |
| CommentAvailable | `bool` | bazodanowe | Komentarze dostępne |  |
| CreteNewFolderForClient | `bool` | bazodanowe | Nowy folder dla klienta |  |
| CreteNewFolderForOperator | `bool` | bazodanowe | Nowy folder dla operatora |  |
| DefaultTeam | `Soneta.Support.Support.Team` | bazodanowe | Domyślny zespół |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| DescriptionRequired | `bool` | bazodanowe | Wymagaj opisu |  |
| DomyślnaNumeracja | `string` |  |  |  |
| EditLockIfClosed | `Soneta.Support.Support.EditLockIfClosedMode` | bazodanowe, enum | Blokada edycji pól, gdy zgłoszenie zamknięte |  |
| EmailFields | `Soneta.Business.MemoText` | bazodanowe | Email pola |  |
| EmailImage | `string` | bazodanowe | Obrazek email |  |
| EmailImageUrl | `string` | bazodanowe | Url obrazka email |  |
| EmailNotification | `bool` | bazodanowe | Notyfikacja email aktywna |  |
| EvaluationAvailable | `bool` | bazodanowe | Ocena dostępna |  |
| HostName | `string` |  |  |  |
| IsPublicDefinition | `bool` | bazodanowe | Definicja publiczna |  |
| LastCommentOnTop | `bool` | bazodanowe | Ostatni komentarz na górze |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe | Numeracja | Ustawienia określające sposób numeracji zadań |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| Priorities | `Soneta.Business.SubTable<Soneta.Support.Support.Priority>` |  |  |  |
| ShowDescription | `bool` | bazodanowe | Wyświetlaj opis |  |
| ShowTitle | `bool` | bazodanowe | Wyświetlaj tytuł |  |
| StateAfterResponseFromClient | `Soneta.Support.Support.State` | bazodanowe | Status po dodaniu odpowiedzi przez klieta |  |
| States | `Soneta.Business.SubTable<Soneta.Support.Support.State>` |  |  |  |
| StopWatchMode | `Soneta.Support.Support.StopWatchMode` | bazodanowe, enum | Tryb stopera |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji zgłoszenia wykorzystywana do wyszukiwania definicji oraz numeracji zadań. |
| TitleRequired | `bool` | bazodanowe | Wymagaj tytułu |  |
| XmlForms | `Soneta.Support.Support.TicketDefinition.XMLForms` |  |  |  |
| XmlLeftPanelClient | `Soneta.Business.MemoText` | bazodanowe | Formularz operatora |  |
| XmlLeftPanelOperator | `Soneta.Business.MemoText` | bazodanowe | Formularz operatora |  |
| XmlRightPanelClient | `Soneta.Business.MemoText` | bazodanowe | Formularz operatora |  |
| XmlRightPanelOperator | `Soneta.Business.MemoText` | bazodanowe | Formularz operatora |  |
| XmlTopPanelClient | `Soneta.Business.MemoText` | bazodanowe | Formularz operatora |  |
| XmlTopPanelOperator | `Soneta.Business.MemoText` | bazodanowe | Formularz operatora |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### EditLockIfClosedMode (`Soneta.Support.Support.EditLockIfClosedMode`)
- `None` = 0 — Brak
- `ClientForm` = 1 — Formularz klienta
- `OperatorForm` = 2 — Formularz operatora
- `OperatorAndClientForm` = 3 — Formularz klienta i operatora

### StopWatchMode (`Soneta.Support.Support.StopWatchMode`)
- `Off` = 0 — Wyłączony
- `Automatic` = 1 — Automatyczny
- `Manual` = 2 — Ręczny
