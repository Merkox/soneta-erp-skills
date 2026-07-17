# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.SLADocument`
Nazwa tabeli: `SLADocuments`
Tytuł: Parametry SLA dla dokumentu
Opis: Parametry umów SLA przypisane do dokumentów handlowych (umów z klientami). Definiuje wymagane czasy reakcji i naprawy dla danej definicji zgłoszenia i priorytetu, z powiązaniem z kalendarzem roboczym określającym godziny obsługi.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `ISLADocument`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Podrzędny | Podrzędny |
| Priority | `Soneta.Support.Support.Priority` | bazodanowe | Priorytet | Priorytet |
| ResolutionTime | `double` | bazodanowe | Czas naprawy | Czas naprawy |
| ResolutionTimeUnit | `Soneta.Core.ServiceDesk.SLATimeUnit` | bazodanowe, enum | Jednostka czasu naprawy | Jednostka czasu naprawy |
| ResponseTime | `double` | bazodanowe | Czas reakcji | Czas reakcji |
| ResponseTimeUnit | `Soneta.Core.ServiceDesk.SLATimeUnit` | bazodanowe, enum | Jednostka czasu reakcji | Jednostka czasu reakcji |
| SLACalendar | `Soneta.Support.Support.SLACalendar` | bazodanowe | Kalendarz | Kalendarz |
| TicketDefinition | `Soneta.Support.Support.TicketDefinition` | bazodanowe | Definicja zgłoszenia | Definicja zgłoszenia |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SLATimeUnit (`Soneta.Core.ServiceDesk.SLATimeUnit`)
- `Hour` = 1 — Godzina
- `WorkingDay` = 2 — Dzień roboczy
- `NextWorkingDay` = 3 — Następny dzień roboczy
