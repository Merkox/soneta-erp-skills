# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.TicketDefinition`
Nazwa tabeli: `TicketsDefs`
Tytuł: Definicje Zgłoszeń
Opis: Słownik definicji zgłoszeń serwisowych określający zasady obsługi w module ServiceDesk. Konfiguruje formularze operatora i klienta, numerację, dostępność załączników i komentarzy, notyfikacje email, domyślny zespół oraz reguły blokady edycji po zamknięciu zgłoszenia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 26
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 3
- podlisty: 10
- subrowy: 1
- razem: 41

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
| Description | `MemoText` | bazodanowe, podlista | Opis |  |
| DescriptionRequired | `bool` | bazodanowe | Wymagaj opisu |  |
| DomyślnaNumeracja | `string` | tylko-odczyt |  |  |
| EditLockIfClosed | `Soneta.Support.Support.EditLockIfClosedMode` (enum) | bazodanowe | Blokada edycji pól, gdy zgłoszenie zamknięte |  |
| EmailFields | `MemoText` | bazodanowe, podlista | Email pola |  |
| EmailImage | `string` | bazodanowe | Obrazek email |  |
| EmailImageUrl | `string` | bazodanowe | Url obrazka email |  |
| EmailNotification | `bool` | bazodanowe | Notyfikacja email aktywna |  |
| EvaluationAvailable | `bool` | bazodanowe | Ocena dostępna |  |
| HostName | `string` | tylko-odczyt |  |  |
| IsPublicDefinition | `bool` | bazodanowe | Definicja publiczna |  |
| LastCommentOnTop | `bool` | bazodanowe | Ostatni komentarz na górze |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe | Numeracja | Ustawienia określające sposób numeracji zadań |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| Priorities | `SubTable<Soneta.Support.Support.Priority>` | podlista |  |  |
| ShowDescription | `bool` | bazodanowe | Wyświetlaj opis |  |
| ShowTitle | `bool` | bazodanowe | Wyświetlaj tytuł |  |
| StateAfterResponseFromClient | `Soneta.Support.Support.State` | bazodanowe | Status po dodaniu odpowiedzi przez klieta |  |
| States | `SubTable<Soneta.Support.Support.State>` | podlista |  |  |
| StopWatchMode | `Soneta.Support.Support.StopWatchMode` (enum) | bazodanowe | Tryb stopera |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji zgłoszenia wykorzystywana do wyszukiwania definicji oraz numeracji zadań. |
| TitleRequired | `bool` | bazodanowe | Wymagaj tytułu |  |
| XmlForms | `Soneta.Support.Support.TicketDefinition.XMLForms` | tylko-odczyt |  |  |
| XmlLeftPanelClient | `MemoText` | bazodanowe, podlista | Formularz operatora |  |
| XmlLeftPanelOperator | `MemoText` | bazodanowe, podlista | Formularz operatora |  |
| XmlRightPanelClient | `MemoText` | bazodanowe, podlista | Formularz operatora |  |
| XmlRightPanelOperator | `MemoText` | bazodanowe, podlista | Formularz operatora |  |
| XmlTopPanelClient | `MemoText` | bazodanowe, podlista | Formularz operatora |  |
| XmlTopPanelOperator | `MemoText` | bazodanowe, podlista | Formularz operatora |  |

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
