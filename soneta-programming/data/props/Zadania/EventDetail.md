# Pola i właściwości klasy biznesowej: `Soneta.Zadania.EventDetail`
Nazwa tabeli: `EventDetails`
Tytuł: Szczegóły zdarzeń
Opis: Szczegóły zdarzenia komunikacyjnego (e-mail, SMS) powiązanego z zadaniem CRM. Przechowuje typ zdarzenia, adresy nadawcy i odbiorców, szablony wiadomości oraz status wysyłki.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DW | `MemoText` | bazodanowe, podlista |  |  |
| EventType | `Soneta.Zadania.EventType` (enum) | bazodanowe |  |  |
| From | `MemoText` | bazodanowe, podlista |  |  |
| IsSent | `bool` | bazodanowe |  |  |
| Kontrahenci | `Soneta.CRM.Kontrahent[]` | podlista |  |  |
| MailAccount | `Soneta.CRM.Config.KontoPocztowe` | bazodanowe |  |  |
| Participants | `SubTable<Soneta.Zadania.EventParticipant>` | podlista |  |  |
| PhoneNo | `string` | bazodanowe |  |  |
| ReadConfirmation | `bool` | bazodanowe |  |  |
| SmsRecipientsDisplay | `string` | tylko-odczyt |  |  |
| SmsTemplate | `Soneta.CRM.SzablonSms` | bazodanowe |  |  |
| TaskEvent | `Soneta.Zadania.Zadanie` | bazodanowe, tylko-odczyt |  |  |
| To | `MemoText` | bazodanowe, podlista |  |  |
| UDW | `MemoText` | bazodanowe, podlista |  |  |
| UczestnicyOsoby | `Soneta.CRM.KontaktOsoba[]` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### EventType (`Soneta.Zadania.EventType`)
- `Phone` = 0 — Telefon
- `Meeting` = 1 — Spotkanie
- `Email` = 2 — E-mail
- `SMS` = 3
- `Communicator` = 4 — Komunikator
- `RemoteMeeting` = 5 — Zdalne spotkanie
