# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionReadStatus`
Nazwa tabeli: `DisReadStatuses`
Opis: Status przeczytania dyskusji przez użytkownika. Przechowuje datę ostatniego odczytu dyskusji przez daną osobę, umożliwiając oznaczanie nowych/nieprzeczytanych wpisów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Discussion | `Soneta.Core.Conversation.Discussion` | bazodanowe |  |  |
| Person | `Soneta.Business.IOwner` | bazodanowe |  |  |
| ReadDate | `System.DateTime` | bazodanowe |  |  |
