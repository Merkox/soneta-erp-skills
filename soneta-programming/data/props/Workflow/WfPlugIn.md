# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WfPlugIn`
Nazwa tabeli: `WfPlugIns`
Tytuł: Wtyczki definicji procesów
Opis: Wtyczka rozszerzająca funkcjonalność definicji procesu workflow. Zawiera kod silnika, konfigurację statyczną oraz powiązanie z dokumentem dodatkowym. Wtyczki umożliwiają modularną budowę logiki procesów bez modyfikacji głównej definicji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWfPlugInItemHost`, `ICodeFileHost`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfigClass | `string` | bazodanowe | Klasa do zapisu konfiguracji | Klasa z definicją obiektu przechowującego statyczną konfigrację. |
| ConfigTypeFullName | `string` |  |  |  |
| DbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja zarządcy | Definicja rekordu zarządzającego procesem. |
| DbTupleInterface | `string` | bazodanowe | Definicja interfejsu zarządcy | Interfejs rekordu zarządzającego procesem. |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| EngineCode | `Soneta.Business.MemoText` | bazodanowe | Kod wtyczki | Kod silnika wtyczki workflow |
| Files | `Soneta.Business.SubTable<Soneta.Core.CodeFile>` |  |  |  |
| Items | `Soneta.Business.SubTable<Soneta.Workflow.Config.WfPlugInItem>` |  |  |  |
| Locked | `bool` | bazodanowe | Definicja zablokowana | Określa czy wtyczka jest zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa wtyczki |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
