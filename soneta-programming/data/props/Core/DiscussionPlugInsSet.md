# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionPlugInsSet`
Nazwa tabeli: `DiscPlugInsSets`
Tytuł: Zestawy rozszerzeń do dyskusji
Opis: Zestaw rozszerzeń (plug-inów) do mechanizmu dyskusji i workflow. Zawiera nazwę, opis, kod silnika wtyczki, klasę konfiguracji, flagę blokady oraz powiązanie z plikami kodu. Rozszerzenia modyfikują zachowanie procesów dyskusji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `ICodeFileHost`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 5
- subrowy: 1
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfigClass | `string` | bazodanowe | Klasa do zapisu konfiguracji | Klasa z definicją obiektu przechowującego statyczną konfigrację. |
| ConfigTypeFullName | `string` | tylko-odczyt |  |  |
| Description | `MemoText` | bazodanowe, podlista | Opis |  |
| EngineCode | `MemoText` | bazodanowe, podlista | Kod wtyczki | Kod silnika wtyczki dyskusji |
| Files | `SubTable<Soneta.Core.CodeFile>` | podlista |  |  |
| Items | `SubTable<Soneta.Core.Conversation.DiscussionPlugIn>` | podlista |  |  |
| Locked | `bool` | bazodanowe | Definicja zablokowana | Określa czy wtyczka jest zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa wtyczki |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
