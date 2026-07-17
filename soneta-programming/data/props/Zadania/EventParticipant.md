# Pola i właściwości klasy biznesowej: `Soneta.Zadania.EventParticipant`
Nazwa tabeli: `EventPartic`
Opis: Uczestnik zdarzenia komunikacyjnego CRM. Łączy osobę lub kontrahenta ze szczegółami zdarzenia (EventDetail), określając czy uczestnik jest aktywnym odbiorcą komunikacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| EventDetail | `Soneta.Zadania.EventDetail` | bazodanowe |  |  |
| IsIncluded | `bool` | bazodanowe |  |  |
| Participant | `Soneta.Business.IOwner` | bazodanowe |  |  |
| ParticipantContractor | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
