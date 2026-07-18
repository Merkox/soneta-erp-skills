# Pola i właściwości klasy biznesowej: `Soneta.Core.Konwersacja`
Nazwa tabeli: `Konwersacje`
Opis: Konwersacja (czat) między użytkownikami systemu. Przechowuje powiązaną dyskusję, datę ostatniego wpisu, nazwę, opis oraz flagi konwersacji grupowej i zmiany nazwy.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Avatar | `object` | tylko-odczyt |  |  |
| Dyskusja | `Soneta.Core.Conversation.Discussion` | bazodanowe | Dyskusja |  |
| Grupowa | `bool` | bazodanowe, tylko-odczyt | Konwersacja grupowa |  |
| Last | `Date` |  |  |  |
| Name | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis |  |
| OstatniWpis | `System.DateTime` | bazodanowe | Data ostatniego wpisu | Data ostatniego wpisu konwersacji |
| Person | `GuidedRow` | tylko-odczyt |  |  |
| Recipients | `IOwner[]` | podlista |  |  |
| Since | `string` | tylko-odczyt |  |  |
| ZmienionaNazwa | `bool` | bazodanowe | Zmieniona nazwa |  |
