# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.NotificationConfiguration`
Nazwa tabeli: `NotificationConf`
Tytuł: Powiadomienia
Opis: Konfiguracja powiadomień powiązanych ze zgłoszeniami serwisowymi. Określa rodzaj powiadomienia (email, zadanie), akcję wyzwalającą, szablon wiadomości oraz warunki wysyłki, np. weryfikację operatora lub ograniczenie do obserwowanych zgłoszeń.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Action | `Soneta.Support.Support.NotificationActions` (enum) | bazodanowe | Akcja |  |
| ActionParams | `string` | bazodanowe |  |  |
| Host | `Soneta.Core.IDaneKontaktoweHost` | bazodanowe, iface-ref |  |  |
| MessageTemplate | `Soneta.CRM.SzablonEmail` | bazodanowe | Szablon wiadomości | Szablon wiadomości |
| NotificationType | `Soneta.Support.Support.NotificationTypes` (enum) | bazodanowe | Rodzaj powiadomienia |  |
| OnlyForFollowedTickets | `bool` | bazodanowe | Tylko dla obserwowanych zgłoszeń | Powiadomienie tylko dla obserwowanych zgłoszeń. |
| TaskDefinition | `Db.TaskDefinition` | bazodanowe | Definicja zadania | Definicja zadania |
| TicketDefinition | `Soneta.Support.Support.TicketDefinition` | bazodanowe | Definicja zadania |  |
| VerifyOperator | `bool` | bazodanowe | Weryfikacja operatora zmieniającego dane | Wyślij powiadomienie, gdy operator zmieniający dane różni się od operatora prowadzącego. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IDaneKontaktoweHost` | `Bank`, `DaneKontrahenta`, `InstytucjaFinansowaPPK`, `KontaktOsoba`, `Kontrahent`, `Lokalizacja`, `OddzialFirmy`, `PracHistoria`, `SupportOperator`, `Team`, `UrzadCelny`, `UrzadSkarbowy`, `WizytowkaFirmy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### NotificationActions (`Soneta.Support.Support.NotificationActions`)
- `Brak` = 0
- `CommendAdded` = 1 — Dodanie komentarza
- `StateModification` = 2 — Zmiana stanu zgłoszenia
- `TaskAdded` = 3 — Dodanie zgłoszenia

### NotificationTypes (`Soneta.Support.Support.NotificationTypes`)
- `Email` = 1
- `Systemowe` = 2
