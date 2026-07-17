# Pola i właściwości klasy biznesowej: `Soneta.Core.Substitute.SubstituteDef`
Nazwa tabeli: `SubstituteDefs`
Tytuł: Definicje zastępstw
Opis: Definicja zasad zastępstwa użytkowników. Określa nazwę, algorytmy wyszukiwania zastępujących i zastępowanych, flagę blokady i domyślności, ustawienia powiadomień e-mail oraz widoczność pól wyboru uprawnień i poziomu przejmowanych obowiązków.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefaultSubstituteDef | `bool` | bazodanowe | Domyślna definicja zastępstwa | Określa czy definicja zastępstwa jest domyślna |
| GetListReplacedCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Algorytm metody GetListReplaced | Określa algorytm metody GetListReplaced |
| GetListReplacementCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Algorytm metody GetListReplacement | Określa algorytm metody GetListReplacement |
| GetListReplacementCode.Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| GetListReplacementCode.CodeUi | `string` |  |  |  |
| GetListReplacementCode.CodeUiRoslyn | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| GetListSubstituteAuthorityCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Algorytm metody GetListSubstituteAuthority | Określa algorytm metody GetListSubstituteAuthority |
| IsLevelOfReplacementVisible | `bool` | bazodanowe | Widoczność pola Przejmowane obowiązki | Określa czy na formularzu zastępstwa będzie widoczne pole Przejmowane obowiązki |
| IsSelectedEntitlesVisible | `bool` | bazodanowe | Widoczność pola Wybrane uprawnienia | Określa czy na formularzu zastępstwa będzie widoczne pole Wybrane uprawnienia |
| LockedSubstituteDef | `bool` | bazodanowe | Zablokowana definicja zastępstwa | Określa czy definicja zastępstwa jest zablokowana |
| Name | `string` | bazodanowe | Nazwa definicji | Nazwa definicji zastępstwa |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SendEmailInSubstituteProcess | `bool` | bazodanowe | Wyślij email | Określa czy w trakcie procesu zastępstw mają być wysyłane powiadomienia mailowe |
| SourceCode | `string` |  |  |  |
| SubstituteUsers | `Soneta.Business.SubTable<Soneta.Core.Substitute.SubstituteUser>` |  |  |  |
