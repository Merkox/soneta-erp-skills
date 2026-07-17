# Pola i właściwości klasy biznesowej: `Soneta.Core.Konwersacja`
Nazwa tabeli: `Konwersacje`
Opis: Konwersacja (czat) między użytkownikami systemu. Przechowuje powiązaną dyskusję, datę ostatniego wpisu, nazwę, opis oraz flagi konwersacji grupowej i zmiany nazwy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Avatar | `object` |  |  |  |
| Dyskusja | `Soneta.Core.Conversation.Discussion` | bazodanowe | Dyskusja |  |
| Grupowa | `bool` | bazodanowe | Konwersacja grupowa |  |
| Last | `Soneta.Types.Date` |  |  |  |
| Name | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| OstatniWpis | `System.DateTime` | bazodanowe | Data ostatniego wpisu | Data ostatniego wpisu konwersacji |
| Person | `Soneta.Business.GuidedRow` |  |  |  |
| Recipients | `Soneta.Business.IOwner[]` |  |  |  |
| Since | `string` |  |  |  |
| ZmienionaNazwa | `bool` | bazodanowe | Zmieniona nazwa |  |
