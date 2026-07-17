# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.FolderPocztowy`
Nazwa tabeli: `FolderyPocztowe`
Tytuł: Folder pocztowy skrzynki
Opis: Folder na skrzynce pocztowej IMAP powiązany z kontem pocztowym. Śledzi stan synchronizacji (najwyższy UID, UIDValidity) poszczególnych folderów, umożliwiając przyrostowe pobieranie wiadomości i rozróżnienie poczty wychodzącej.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FolderPocztyWychodzacej | `bool` | bazodanowe | Poczta wychodząca | Folder poczty wychodzącej |
| KontoPocztowe | `Soneta.CRM.Config.KontoPocztowe` | bazodanowe | Konto | Konto pocztowe |
| LargestUID | `decimal` | bazodanowe |  | Najwyższy identyfikator pobranej wiadomości. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa folderu. |
| UIDValidity | `decimal` | bazodanowe |  | Wartość umożliwiająca wykrycie zmian identyfikatorów UID wiadomości. |
