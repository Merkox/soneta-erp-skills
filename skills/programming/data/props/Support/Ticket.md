# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.Ticket`
Nazwa tabeli: `Tickets`
Tytuł: ServiceDesk
Opis: Główna tabela zgłoszeń serwisowych modułu ServiceDesk. Przechowuje pełne dane zgłoszenia: tytuł, opis, stan, priorytet, przypisanych operatorów, klienta, produkt oraz parametry SLA z rzeczywistymi i umownymi czasami reakcji i naprawy.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActivityName | `string` | tylko-odczyt |  |  |
| AttachmentsSupport | `Soneta.Support.AttachmentManager` | tylko-odczyt |  |  |
| ChildRelations | `SubTable<Soneta.Support.Support.RelationToDoc>` | podlista |  |  |
| Client | `Soneta.CRM.Kontrahent` | bazodanowe | Klient |  |
| CommentAvailable | `bool` | tylko-odczyt |  |  |
| CommentDraft | `MemoText` | bazodanowe, podlista | Komentarz roboczy |  |
| CommentHost | `Soneta.Core.Conversation.ICommentHostParams` | tylko-odczyt |  |  |
| CommentHostParams | `Soneta.Core.Conversation.CommentHostParams` | tylko-odczyt |  |  |
| ContactPerson | `Soneta.CRM.KontaktOsoba` | bazodanowe | OsobaKontaktowa |  |
| CzyZadanieOperatora | `bool` | tylko-odczyt |  |  |
| Data | `Date` | tylko-odczyt |  |  |
| DataSourceParent | `int?` | tylko-odczyt |  |  |
| Definicja | `Soneta.Core.IDefinicjaDokumentu` | tylko-odczyt, iface-ref |  |  |
| Definition | `Soneta.Support.Support.TicketDefinition` | bazodanowe | Definicja |  |
| Description | `MemoText` | bazodanowe, podlista | Opis |  |
| DescriptionIsReadOnly | `bool` | tylko-odczyt |  |  |
| DopisanaTresc | `System.Tuple<string, Soneta.Core.Conversation.CommentType>` |  |  |  |
| EndTime | `System.DateTime` | bazodanowe | Data Zakończenia |  |
| EvaluationVisible | `bool` | tylko-odczyt |  |  |
| ExecutionDate | `Date` | bazodanowe | Termin realizacji | Termin realizacji |
| HasAttachmentsForClient | `bool` | bazodanowe | Aktywny |  |
| InternalNotes | `MemoText` | bazodanowe, podlista | Notatki wewnętrzne | Notatki wewnętrzne |
| IsClientView | `bool` | tylko-odczyt |  |  |
| Leader | `App.Operator` | bazodanowe | Prowadzący |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| OverallTime | `Time` | tylko-odczyt |  |  |
| Priority | `Soneta.Support.Support.Priority` | bazodanowe | Priorytet |  |
| Product | `Soneta.Support.Support.Product` | bazodanowe | Produkt |  |
| RecordSequence | `Soneta.Core.RecordSequence` | tylko-odczyt |  |  |
| RenderKey | `string` | tylko-odczyt |  |  |
| ResolutionDate | `System.DateTime` | bazodanowe | Data naprawy rzeczywista | Data naprawy rzeczywista |
| ResolutionDateSLA | `System.DateTime` | bazodanowe | Maksymalny termin naprawy wg umowy | Maksymalny termin naprawy wg umowy |
| ResolutionTime | `TimeSec` | bazodanowe | Czas naprawy rzeczywisty [h] | Czas naprawy rzeczywisty [h] |
| ResolutionTimeSLA | `double` | bazodanowe | Czas naprawy wg umowy | Czas naprawy wg umowy |
| ResolutionTimeSLAUnit | `Soneta.Core.ServiceDesk.SLATimeUnit` (enum) | bazodanowe | Jednostka czasu naprawy wg umowy | Jednostka czasu naprawy wg umowy |
| ResponseDate | `System.DateTime` | bazodanowe | Data reakcji rzeczywista | Data reakcji rzeczywista |
| ResponseDateSLA | `System.DateTime` | bazodanowe | Maksymalny termin reakcji wg umowy | Maksymalny termin reakcji wg umowy |
| ResponseTime | `TimeSec` | bazodanowe | Czas reakcji rzeczywisty [h] | Czas reakcji rzeczywisty [h] |
| ResponseTimeSLA | `double` | bazodanowe | Czas reakcji wg umowy | Czas reakcji wg umowy |
| ResponseTimeSLAUnit | `Soneta.Core.ServiceDesk.SLATimeUnit` (enum) | bazodanowe | Jednostka czasu reakcji wg umowy | Jednostka czasu reakcji wg umowy |
| Sequence | `int` | tylko-odczyt |  |  |
| ShowDescription | `bool` | tylko-odczyt |  |  |
| ShowTitle | `bool` | tylko-odczyt |  |  |
| StartTime | `System.DateTime` | bazodanowe | Data Dodania |  |
| Team | `Soneta.Support.Support.Team` | bazodanowe | Zespół |  |
| TicketFollowersList | `SubTable<Soneta.Support.Support.TicketFollower>` | podlista |  |  |
| TicketState | `Soneta.Support.Support.State` | bazodanowe | Stan |  |
| TimeTrackList | `SubTable<Soneta.Core.TimeTrack>` | podlista |  |  |
| Title | `string` | bazodanowe | Tytuł |  |
| TitleIsReadOnlyForClient | `bool` | tylko-odczyt |  |  |
| Version | `Soneta.Support.Support.ProductVersion` | bazodanowe | Wersja |  |
| Worker | `App.Operator` | bazodanowe | Wykonujacy |  |
| WorkingTime | `TimeSec` | bazodanowe | Czas wykonania | Czas wykonania. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definicja | `IDefinicjaDokumentu` | `ChronoOrder` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SLATimeUnit (`Soneta.Core.ServiceDesk.SLATimeUnit`)
- `Hour` = 1 — Godzina
- `WorkingDay` = 2 — Dzień roboczy
- `NextWorkingDay` = 3 — Następny dzień roboczy
