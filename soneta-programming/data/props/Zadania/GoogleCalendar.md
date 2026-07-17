# Pola i właściwości klasy biznesowej: `Soneta.Zadania.GoogleCalendar`
Nazwa tabeli: `GoogleCalendars`
Tytuł: Kalendarze Google
Opis: Rejestr kalendarzy Google synchronizowanych z zadaniami CRM. Przechowuje identyfikator kalendarza, token synchronizacji oraz token autoryzacyjny do Google API.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CalendarId | `string` | bazodanowe |  |  |
| NextSyncToken | `string` | bazodanowe |  |  |
| Operator | `Soneta.Business.App.Operator` |  |  |  |
| Token | `Soneta.Business.MemoText` | bazodanowe |  |  |
