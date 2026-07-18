# Pola i właściwości klasy biznesowej: `Soneta.Zadania.GoogleCalendar`
Nazwa tabeli: `GoogleCalendars`
Tytuł: Kalendarze Google
Opis: Rejestr kalendarzy Google synchronizowanych z zadaniami CRM. Przechowuje identyfikator kalendarza, token synchronizacji oraz token autoryzacyjny do Google API.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CalendarId | `string` | bazodanowe |  |  |
| NextSyncToken | `string` | bazodanowe |  |  |
| Operator | `App.Operator` | tylko-odczyt |  |  |
| Token | `MemoText` | bazodanowe, podlista |  |  |
