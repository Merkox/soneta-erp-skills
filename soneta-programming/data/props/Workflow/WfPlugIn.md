# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WfPlugIn`
Nazwa tabeli: `WfPlugIns`
Tytuł: Wtyczki definicji procesów
Opis: Wtyczka rozszerzająca funkcjonalność definicji procesu workflow. Zawiera kod silnika, konfigurację statyczną oraz powiązanie z dokumentem dodatkowym. Wtyczki umożliwiają modularną budowę logiki procesów bez modyfikacji głównej definicji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWfPlugInItemHost`, `ICodeFileHost`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 5
- subrowy: 1
- razem: 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfigClass | `string` | bazodanowe | Klasa do zapisu konfiguracji | Klasa z definicją obiektu przechowującego statyczną konfigrację. |
| ConfigTypeFullName | `string` | tylko-odczyt |  |  |
| DbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja zarządcy | Definicja rekordu zarządzającego procesem. |
| DbTupleInterface | `string` | bazodanowe | Definicja interfejsu zarządcy | Interfejs rekordu zarządzającego procesem. |
| Description | `MemoText` | bazodanowe, podlista | Opis |  |
| EngineCode | `MemoText` | bazodanowe, podlista | Kod wtyczki | Kod silnika wtyczki workflow |
| Files | `SubTable<Soneta.Core.CodeFile>` | podlista |  |  |
| Items | `SubTable<Soneta.Workflow.Config.WfPlugInItem>` | podlista |  |  |
| Locked | `bool` | bazodanowe | Definicja zablokowana | Określa czy wtyczka jest zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa wtyczki |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
