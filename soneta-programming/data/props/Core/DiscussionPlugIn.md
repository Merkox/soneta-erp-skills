# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionPlugIn`
Nazwa tabeli: `DiscPlugIns`
Tytuł: Rozszerzenia do dyskusji
Opis: Rozszerzenie (plug-in) dyskusji przypisane do zestawu. Określa klasę obiektu nadrzędnego, wymagany interfejs, nazwę, opis oraz konfigurację. Definiuje, dla jakich typów obiektów biznesowych rozszerzenie jest dostępne.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfigCode | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ConfigXml | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ContentInfo | `string` |  |  |  |
| DataType | `System.Type` |  |  |  |
| DataTypeFullName | `string` |  |  |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| FullName | `string` |  |  |  |
| IconName | `string` |  |  |  |
| Interface | `string` | bazodanowe | Interfejs | Interfejs wymagane od klasy obiektu zarządzanego |
| Items | `System.Collections.Generic.IEnumerable<Soneta.Core.Conversation.DiscussionPlugIn>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa wtyczki |
| PlugIn | `Soneta.Core.Conversation.DiscussionPlugInsSet` | bazodanowe |  |  |
| TableName | `string` | bazodanowe | Klasa | Klasa obiektu nadrzędanego. |
