# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.Subscription`
Nazwa tabeli: `Subscriptions`
Tytuł: Subskrypcje
Opis: Subskrypcja powiadomień o zmianach w obiekcie. ŝączy subskrybenta (identyfikowanego GUID-em i tabelą) z obserwowanym zasobem (również GUID i tabela), umożliwiając automatyczne powiadamianie o aktualizacjach.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ResourceGuid | `System.Guid` | bazodanowe | Guid elementu | Unikalny identyfikator danego elementu. |
| ResourceTable | `string` | bazodanowe | Tabela elementu | Nazwa tabeli danego elementu. |
| SubscriberGuid | `System.Guid` | bazodanowe | Guid subskrybenta | Unikalny identyfikator subskrybenta danego elementu. |
| SubscriberTable | `string` | bazodanowe | Tabela subskrybenta | Nazwa tabeli subskrybenta danego elementu. |
