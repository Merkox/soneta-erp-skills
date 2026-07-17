# Pola i właściwości klasy biznesowej: `Soneta.Core.Aktualnosc`
Nazwa tabeli: `Aktualnosci`
Tytuł: Aktualności
Opis: Aktualność (ogłoszenie, news) publikowana w systemie. Zawiera temat, opis (HTML), datę utworzenia i obowiązywania, powiązaną dyskusję, kategorię, źródło oraz flagi: dozwolony komentarz, dozwolone polubienie, wymagane przeczytanie.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CanAddAttachments | `bool` |  |  |  |
| Category | `Soneta.Core.Conversation.ThreadCategory` | bazodanowe | Kategoria |  |
| CreationDate | `Soneta.Types.Date` |  |  |  |
| CreationTime | `Soneta.Types.Time` |  |  |  |
| DataEdycji | `System.DateTime` | bazodanowe | Data edycji | Data edycji aktualności |
| DataObowiazywania | `System.DateTime` | bazodanowe | Data obiawiązywania | Data obiawiązywania aktualności |
| DataUtworzenia | `System.DateTime` | bazodanowe | Data utworzenia | Data utworzenia aktualności |
| DiscussionUsersSelector | `object` |  |  |  |
| DozwolonePolubienie | `bool` | bazodanowe | Dozwolone polubienie | Zazwala na polubienie aktualności |
| DozwolonyKomentarz | `bool` | bazodanowe | Dozwolony komentarz | Zazwala na komentowanie aktualności |
| Dyskusja | `Soneta.Core.Conversation.Discussion` | bazodanowe | Dyskusja |  |
| EffectiveDate | `Soneta.Types.Date` |  |  |  |
| Host | `Soneta.Business.INewsHost` | bazodanowe | Żródło |  |
| IsParamPageVisible | `bool` |  |  |  |
| IsVisibleChangeImage | `bool` |  |  |  |
| IsVisibleSetImage | `bool` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| Temat | `string` | bazodanowe | Temat |  |
| Users | `System.Collections.Generic.IEnumerable<Soneta.Business.IOwner>` |  |  |  |
| WymaganePrzeczytanie | `bool` | bazodanowe | Wymagane przeczytanie | Wymaga przeczytania aktualności |
| ZrodloLink | `string` | bazodanowe | Żródło link |  |
