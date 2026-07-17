# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionPlugInsSet`
Nazwa tabeli: `DiscPlugInsSets`
Tytuł: Zestawy rozszerzeń do dyskusji
Opis: Zestaw rozszerzeń (plug-inów) do mechanizmu dyskusji i workflow. Zawiera nazwę, opis, kod silnika wtyczki, klasę konfiguracji, flagę blokady oraz powiązanie z plikami kodu. Rozszerzenia modyfikują zachowanie procesów dyskusji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `ICodeFileHost`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfigClass | `string` | bazodanowe | Klasa do zapisu konfiguracji | Klasa z definicją obiektu przechowującego statyczną konfigrację. |
| ConfigTypeFullName | `string` |  |  |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| EngineCode | `Soneta.Business.MemoText` | bazodanowe | Kod wtyczki | Kod silnika wtyczki dyskusji |
| Files | `Soneta.Business.SubTable<Soneta.Core.CodeFile>` |  |  |  |
| Items | `Soneta.Business.SubTable<Soneta.Core.Conversation.DiscussionPlugIn>` |  |  |  |
| Locked | `bool` | bazodanowe | Definicja zablokowana | Określa czy wtyczka jest zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa wtyczki |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
