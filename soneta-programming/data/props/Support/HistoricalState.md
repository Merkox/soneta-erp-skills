# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.HistoricalState`
Nazwa tabeli: `HistoricalStates`
Tytuł: Statusy historyczne
Opis: Historia zmian stanów zgłoszenia serwisowego. Rejestruje każdą zmianę statusu z datą rozpoczęcia, zakończenia, czasem trwania oraz informacją o operatorze, który dokonał zmiany. Służy do analizy czasu obsługi i zgodności z SLA.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Duration | `TimeSec` | bazodanowe | Czas trwania | Czas trwania. |
| SetBy | `IOwner` | bazodanowe |  |  |
| StartTime | `System.DateTime` | bazodanowe |  |  |
| StopTime | `System.DateTime` | bazodanowe |  |  |
| Ticket | `Soneta.Support.Support.Ticket` | bazodanowe |  |  |
| TicketState | `Soneta.Support.Support.State` | bazodanowe |  |  |
