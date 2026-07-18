# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionReadStatus`
Nazwa tabeli: `DisReadStatuses`
Opis: Status przeczytania dyskusji przez użytkownika. Przechowuje datę ostatniego odczytu dyskusji przez daną osobę, umożliwiając oznaczanie nowych/nieprzeczytanych wpisów.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Discussion | `Soneta.Core.Conversation.Discussion` | bazodanowe, tylko-odczyt |  |  |
| Person | `IOwner` | bazodanowe, tylko-odczyt |  |  |
| ReadDate | `System.DateTime` | bazodanowe |  |  |
