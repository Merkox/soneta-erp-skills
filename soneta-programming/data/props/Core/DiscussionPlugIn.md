# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionPlugIn`
Nazwa tabeli: `DiscPlugIns`
Tytuł: Rozszerzenia do dyskusji
Opis: Rozszerzenie (plug-in) dyskusji przypisane do zestawu. Określa klasę obiektu nadrzędnego, wymagany interfejs, nazwę, opis oraz konfigurację. Definiuje, dla jakich typów obiektów biznesowych rozszerzenie jest dostępne.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 7
- podlisty: 4
- subrowy: 0
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfigCode | `MemoText` | bazodanowe, podlista |  |  |
| ConfigXml | `MemoText` | bazodanowe, podlista |  |  |
| ContentInfo | `string` | tylko-odczyt |  |  |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DataTypeFullName | `string` | tylko-odczyt |  |  |
| Description | `MemoText` | bazodanowe, podlista | Opis |  |
| FullName | `string` | tylko-odczyt |  |  |
| IconName | `string` | tylko-odczyt |  |  |
| Interface | `string` | bazodanowe | Interfejs | Interfejs wymagane od klasy obiektu zarządzanego |
| Items | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionPlugIn>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa wtyczki |
| PlugIn | `Soneta.Core.Conversation.DiscussionPlugInsSet` | bazodanowe, tylko-odczyt |  |  |
| TableName | `string` | bazodanowe, tylko-odczyt | Klasa | Klasa obiektu nadrzędanego. |
