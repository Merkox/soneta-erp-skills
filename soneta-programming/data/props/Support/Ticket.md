# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.Ticket`
Nazwa tabeli: `Tickets`
Tytuł: ServiceDesk
Opis: Główna tabela zgłoszeń serwisowych modułu ServiceDesk. Przechowuje pełne dane zgłoszenia: tytuł, opis, stan, priorytet, przypisanych operatorów, klienta, produkt oraz parametry SLA z rzeczywistymi i umownymi czasami reakcji i naprawy.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

- pola bazodanowe: 33
- pola kalkulowane (z klas biznesowych): 27

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActivityName | `string` |  |  |  |
| AttachmentsSupport | `Soneta.Support.AttachmentManager` |  |  |  |
| ChildRelations | `Soneta.Business.SubTable<Soneta.Support.Support.RelationToDoc>` |  |  |  |
| Client | `Soneta.CRM.Kontrahent` | bazodanowe | Klient |  |
| CommentAvailable | `bool` |  |  |  |
| CommentDraft | `Soneta.Business.MemoText` | bazodanowe | Komentarz roboczy |  |
| CommentHost | `Soneta.Core.Conversation.ICommentHostParams` |  |  |  |
| CommentHostParams | `Soneta.Core.Conversation.CommentHostParams` |  |  |  |
| ContactPerson | `Soneta.CRM.KontaktOsoba` | bazodanowe | OsobaKontaktowa |  |
| CzyZadanieOperatora | `bool` |  |  |  |
| Data | `Soneta.Types.Date` |  |  |  |
| DataSourceParent | `int?` |  |  |  |
| Definicja | `Soneta.Core.IDefinicjaDokumentu` | iface-ref |  |  |
| Definition | `Soneta.Support.Support.TicketDefinition` | bazodanowe | Definicja |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| DescriptionIsReadOnly | `bool` |  |  |  |
| DopisanaTresc | `System.Tuple<string, Soneta.Core.Conversation.CommentType>` |  |  |  |
| EndTime | `System.DateTime` | bazodanowe | Data Zakończenia |  |
| EvaluationVisible | `bool` |  |  |  |
| ExecutionDate | `Soneta.Types.Date` | bazodanowe | Termin realizacji | Termin realizacji |
| HasAttachmentsForClient | `bool` | bazodanowe | Aktywny |  |
| InternalNotes | `Soneta.Business.MemoText` | bazodanowe | Notatki wewnętrzne | Notatki wewnętrzne |
| IsClientView | `bool` |  |  |  |
| LastCommentOnTop | `bool` |  |  |  |
| Leader | `Soneta.Business.App.Operator` | bazodanowe | Prowadzący |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| OverallTime | `Soneta.Types.Time` |  |  |  |
| Priority | `Soneta.Support.Support.Priority` | bazodanowe | Priorytet |  |
| Product | `Soneta.Support.Support.Product` | bazodanowe | Produkt |  |
| RecordSequence | `Soneta.Core.RecordSequence` |  |  |  |
| RenderKey | `string` |  |  |  |
| ResolutionDate | `System.DateTime` | bazodanowe | Data naprawy rzeczywista | Data naprawy rzeczywista |
| ResolutionDateSLA | `System.DateTime` | bazodanowe | Maksymalny termin naprawy wg umowy | Maksymalny termin naprawy wg umowy |
| ResolutionTime | `Soneta.Types.TimeSec` | bazodanowe | Czas naprawy rzeczywisty [h] | Czas naprawy rzeczywisty [h] |
| ResolutionTimeSLA | `double` | bazodanowe | Czas naprawy wg umowy | Czas naprawy wg umowy |
| ResolutionTimeSLAUnit | `Soneta.Core.ServiceDesk.SLATimeUnit` | bazodanowe, enum | Jednostka czasu naprawy wg umowy | Jednostka czasu naprawy wg umowy |
| ResponseDate | `System.DateTime` | bazodanowe | Data reakcji rzeczywista | Data reakcji rzeczywista |
| ResponseDateSLA | `System.DateTime` | bazodanowe | Maksymalny termin reakcji wg umowy | Maksymalny termin reakcji wg umowy |
| ResponseTime | `Soneta.Types.TimeSec` | bazodanowe | Czas reakcji rzeczywisty [h] | Czas reakcji rzeczywisty [h] |
| ResponseTimeSLA | `double` | bazodanowe | Czas reakcji wg umowy | Czas reakcji wg umowy |
| ResponseTimeSLAUnit | `Soneta.Core.ServiceDesk.SLATimeUnit` | bazodanowe, enum | Jednostka czasu reakcji wg umowy | Jednostka czasu reakcji wg umowy |
| Sequence | `int` |  |  |  |
| ShowDescription | `bool` |  |  |  |
| ShowTitle | `bool` |  |  |  |
| StartTime | `System.DateTime` | bazodanowe | Data Dodania |  |
| Team | `Soneta.Support.Support.Team` | bazodanowe | Zespół |  |
| TicketFollowersList | `Soneta.Business.SubTable<Soneta.Support.Support.TicketFollower>` |  |  |  |
| TicketState | `Soneta.Support.Support.State` | bazodanowe | Stan |  |
| TimeTrackList | `Soneta.Business.SubTable<Soneta.Core.TimeTrack>` |  |  |  |
| Title | `string` | bazodanowe | Tytuł |  |
| TitleIsReadOnlyForClient | `bool` |  |  |  |
| Version | `Soneta.Support.Support.ProductVersion` | bazodanowe | Wersja |  |
| Worker | `Soneta.Business.App.Operator` | bazodanowe | Wykonujacy |  |
| WorkingTime | `Soneta.Types.TimeSec` | bazodanowe | Czas wykonania | Czas wykonania. |

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
