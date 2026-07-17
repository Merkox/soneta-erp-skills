# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.State`
Nazwa tabeli: `TicketStates`
Tytuł: Stany
Opis: Słownik stanów zgłoszeń serwisowych w ramach definicji zgłoszenia. Określa możliwe etapy obsługi zgłoszenia, wskazując które stany wpływają na pomiar czasu reakcji i naprawy w ramach umów SLA.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` | bazodanowe | Aktywny |  |
| Default | `bool` | bazodanowe | Domyślny |  |
| Name | `string` | bazodanowe | Nazwa |  |
| RepairSLA | `bool` | bazodanowe | Wpływa na czas naprawy | Wpływa na czas naprawy |
| ResponseSLA | `bool` | bazodanowe | Wpływa na czas reakcji | Wpływa na czas reakcji |
| TicketDefinition | `Soneta.Support.Support.TicketDefinition` | bazodanowe | Definicja |  |
