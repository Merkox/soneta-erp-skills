# Pola i właściwości klasy biznesowej: `Soneta.Zadania.EventParticipant`
Nazwa tabeli: `EventPartic`
Opis: Uczestnik zdarzenia komunikacyjnego CRM. Łączy osobę lub kontrahenta ze szczegółami zdarzenia (EventDetail), określając czy uczestnik jest aktywnym odbiorcą komunikacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| EventDetail | `Soneta.Zadania.EventDetail` | bazodanowe |  |  |
| IsIncluded | `bool` | bazodanowe |  |  |
| Participant | `IOwner` | bazodanowe |  |  |
| ParticipantContractor | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
