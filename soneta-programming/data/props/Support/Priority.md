# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.Priority`
Nazwa tabeli: `TicketPriorities`
Tytuł: Priorytety
Opis: Słownik priorytetów zgłoszeń serwisowych przypisanych do definicji zgłoszenia. Określa wagę zgłoszenia liczbowo, co wpływa na kolejność obsługi oraz parametry SLA takie jak czas reakcji i naprawy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Description | `string` | bazodanowe | Opis |  |
| Name | `string` | bazodanowe | Nazwa |  |
| TicketDefinition | `Soneta.Support.Support.TicketDefinition` | bazodanowe | RodzajZgłoszenia |  |
| Value | `int` | bazodanowe | Wartość |  |
