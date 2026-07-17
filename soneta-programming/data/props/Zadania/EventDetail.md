# Pola i właściwości klasy biznesowej: `Soneta.Zadania.EventDetail`
Nazwa tabeli: `EventDetails`
Tytuł: Szczegóły zdarzeń
Opis: Szczegóły zdarzenia komunikacyjnego (e-mail, SMS) powiązanego z zadaniem CRM. Przechowuje typ zdarzenia, adresy nadawcy i odbiorców, szablony wiadomości oraz status wysyłki.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DW | `Soneta.Business.MemoText` | bazodanowe |  |  |
| EventType | `Soneta.Zadania.EventType` | bazodanowe, enum |  |  |
| From | `Soneta.Business.MemoText` | bazodanowe |  |  |
| IsSent | `bool` | bazodanowe |  |  |
| Kontrahenci | `Soneta.CRM.Kontrahent[]` |  |  |  |
| MailAccount | `Soneta.CRM.Config.KontoPocztowe` | bazodanowe |  |  |
| Participants | `Soneta.Business.SubTable<Soneta.Zadania.EventParticipant>` |  |  |  |
| PhoneNo | `string` | bazodanowe |  |  |
| ReadConfirmation | `bool` | bazodanowe |  |  |
| SmsRecipientsDisplay | `string` |  |  |  |
| SmsTemplate | `Soneta.CRM.SzablonSms` | bazodanowe |  |  |
| TaskEvent | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
| To | `Soneta.Business.MemoText` | bazodanowe |  |  |
| UDW | `Soneta.Business.MemoText` | bazodanowe |  |  |
| UczestnicyOsoby | `Soneta.CRM.KontaktOsoba[]` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### EventType (`Soneta.Zadania.EventType`)
- `Phone` = 0 — Telefon
- `Meeting` = 1 — Spotkanie
- `Email` = 2 — E-mail
- `SMS` = 3
- `Communicator` = 4 — Komunikator
- `RemoteMeeting` = 5 — Zdalne spotkanie
