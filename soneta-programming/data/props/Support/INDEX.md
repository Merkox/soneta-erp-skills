# Moduł `Support` — tabele biznesowe

- Opis: Moduł wsparcia technicznego i helpdesk. Zawiera zgłoszenia serwisowe, kolejki obsługi, umowy SLA, bazę wiedzy oraz mechanizmy śledzenia i eskalacji problemów.
- Tabel: **17**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| Evaluation | Ocena | `Evaluations` |  |  |  |  |  | [Evaluation.md](Evaluation.md) |
| HistoricalState | Statusy historyczne | `HistoricalStates` |  |  |  |  |  | [HistoricalState.md](HistoricalState.md) |
| NotificationConfiguration | Powiadomienia | `NotificationConf` |  |  |  |  |  | [NotificationConfiguration.md](NotificationConfiguration.md) |
| OperatorConfiguration | Operator | `OperatorsConfig` |  |  |  |  |  | [OperatorConfiguration.md](OperatorConfiguration.md) |
| OperatorToTeam | Operator Moduł | `OperatorsToTeam` | konfig | root |  |  |  | [OperatorToTeam.md](OperatorToTeam.md) |
| Priority | Priorytety | `TicketPriorities` | konfig | root |  |  |  | [Priority.md](Priority.md) |
| Product | Produkty | `ProductsSupport` | konfig | root |  |  |  | [Product.md](Product.md) |
| ProductVersion | Wersje | `ProductVersions` | konfig | root |  |  |  | [ProductVersion.md](ProductVersion.md) |
| RelationToDoc |  | `RelationsToDoc` |  | root |  |  |  | [RelationToDoc.md](RelationToDoc.md) |
| SLACalendar | Kalendarz | `SLACalendars` | konfig | root |  |  |  | [SLACalendar.md](SLACalendar.md) |
| SLADocument | Parametry SLA dla dokumentu | `SLADocuments` |  | root |  | ISLADocument |  | [SLADocument.md](SLADocument.md) |
| State | Stany | `TicketStates` | konfig | root |  |  |  | [State.md](State.md) |
| SupportOperator | Operatorzy wsparcia | `SupportOperators` |  | child: Operator→Operator |  | IDaneKontaktoweHost |  | [SupportOperator.md](SupportOperator.md) |
| Team | Zespół | `Teams` |  | root |  | IDaneKontaktoweHost |  | [Team.md](Team.md) |
| Ticket | ServiceDesk | `Tickets` |  | root |  | IDokument |  | [Ticket.md](Ticket.md) |
| TicketDefinition | Definicje Zgłoszeń | `TicketsDefs` | konfig | root |  | IRightsSource |  | [TicketDefinition.md](TicketDefinition.md) |
| TicketFollower | Obserwowane zgłoszenia | `TicketFollowers` |  | root |  |  |  | [TicketFollower.md](TicketFollower.md) |

