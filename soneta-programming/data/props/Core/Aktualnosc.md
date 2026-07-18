# Pola i właściwości klasy biznesowej: `Soneta.Core.Aktualnosc`
Nazwa tabeli: `Aktualnosci`
Tytuł: Aktualności
Opis: Aktualność (ogłoszenie, news) publikowana w systemie. Zawiera temat, opis (HTML), datę utworzenia i obowiązywania, powiązaną dyskusję, kategorię, źródło oraz flagi: dozwolony komentarz, dozwolone polubienie, wymagane przeczytanie.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 7
- podlisty: 2
- subrowy: 0
- razem: 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CanAddAttachments | `bool` | tylko-odczyt |  |  |
| Category | `Soneta.Core.Conversation.ThreadCategory` | bazodanowe | Kategoria |  |
| CreationDate | `Date` |  |  |  |
| CreationTime | `Time` |  |  |  |
| DataEdycji | `System.DateTime` | bazodanowe | Data edycji | Data edycji aktualności |
| DataObowiazywania | `System.DateTime` | bazodanowe | Data obiawiązywania | Data obiawiązywania aktualności |
| DataUtworzenia | `System.DateTime` | bazodanowe | Data utworzenia | Data utworzenia aktualności |
| DiscussionUsersSelector | `object` | tylko-odczyt |  |  |
| DozwolonePolubienie | `bool` | bazodanowe | Dozwolone polubienie | Zazwala na polubienie aktualności |
| DozwolonyKomentarz | `bool` | bazodanowe | Dozwolony komentarz | Zazwala na komentowanie aktualności |
| Dyskusja | `Soneta.Core.Conversation.Discussion` | bazodanowe | Dyskusja |  |
| EffectiveDate | `Date` |  |  |  |
| Host | `INewsHost` | bazodanowe, tylko-odczyt | Żródło |  |
| IsParamPageVisible | `bool` | tylko-odczyt |  |  |
| IsVisibleChangeImage | `bool` | tylko-odczyt |  |  |
| IsVisibleSetImage | `bool` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis |  |
| Temat | `string` | bazodanowe | Temat |  |
| Users | `System.Collections.Generic.IEnumerable<IOwner>` | podlista |  |  |
| WymaganePrzeczytanie | `bool` | bazodanowe | Wymagane przeczytanie | Wymaga przeczytania aktualności |
| ZrodloLink | `string` | bazodanowe, tylko-odczyt | Żródło link |  |
