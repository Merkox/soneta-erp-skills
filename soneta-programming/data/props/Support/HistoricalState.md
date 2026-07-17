# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.HistoricalState`
Nazwa tabeli: `HistoricalStates`
Tytuł: Statusy historyczne
Opis: Historia zmian stanów zgłoszenia serwisowego. Rejestruje każdą zmianę statusu z datą rozpoczęcia, zakończenia, czasem trwania oraz informacją o operatorze, który dokonał zmiany. Służy do analizy czasu obsługi i zgodności z SLA.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Duration | `Soneta.Types.TimeSec` | bazodanowe | Czas trwania | Czas trwania. |
| SetBy | `Soneta.Business.IOwner` | bazodanowe |  |  |
| StartTime | `System.DateTime` | bazodanowe |  |  |
| StopTime | `System.DateTime` | bazodanowe |  |  |
| Ticket | `Soneta.Support.Support.Ticket` | bazodanowe |  |  |
| TicketState | `Soneta.Support.Support.State` | bazodanowe |  |  |
