# Pola i właściwości klasy biznesowej: `Soneta.Core.Substitute.SubstituteDef`
Nazwa tabeli: `SubstituteDefs`
Tytuł: Definicje zastępstw
Opis: Definicja zasad zastępstwa użytkowników. Określa nazwę, algorytmy wyszukiwania zastępujących i zastępowanych, flagę blokady i domyślności, ustawienia powiadomień e-mail oraz widoczność pól wyboru uprawnień i poziomu przejmowanych obowiązków.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 3
- subrowy: 4
- razem: 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefaultSubstituteDef | `bool` | bazodanowe | Domyślna definicja zastępstwa | Określa czy definicja zastępstwa jest domyślna |
| GetListReplacedCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Algorytm metody GetListReplaced | Określa algorytm metody GetListReplaced |
| GetListReplacementCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Algorytm metody GetListReplacement | Określa algorytm metody GetListReplacement |
| GetListReplacementCode.Code | `MemoText` | bazodanowe, podlista |  |  |
| GetListReplacementCode.CodeUiRoslyn | `Compiler.ICodeEditorSource` |  |  |  |
| GetListSubstituteAuthorityCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Algorytm metody GetListSubstituteAuthority | Określa algorytm metody GetListSubstituteAuthority |
| IsLevelOfReplacementVisible | `bool` | bazodanowe | Widoczność pola Przejmowane obowiązki | Określa czy na formularzu zastępstwa będzie widoczne pole Przejmowane obowiązki |
| IsSelectedEntitlesVisible | `bool` | bazodanowe | Widoczność pola Wybrane uprawnienia | Określa czy na formularzu zastępstwa będzie widoczne pole Wybrane uprawnienia |
| LockedSubstituteDef | `bool` | bazodanowe | Zablokowana definicja zastępstwa | Określa czy definicja zastępstwa jest zablokowana |
| Name | `string` | bazodanowe | Nazwa definicji | Nazwa definicji zastępstwa |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SendEmailInSubstituteProcess | `bool` | bazodanowe | Wyślij email | Określa czy w trakcie procesu zastępstw mają być wysyłane powiadomienia mailowe |
| SourceCode | `string` | tylko-odczyt |  |  |
| SubstituteUsers | `SubTable<Soneta.Core.Substitute.SubstituteUser>` | podlista |  |  |
