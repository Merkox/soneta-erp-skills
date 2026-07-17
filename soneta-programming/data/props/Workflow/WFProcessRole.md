# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFProcessRole`
Nazwa tabeli: `WFProcessRoles`
Tytuł: Role procesowe
Opis: Rola procesowa powiązana do definicji procesu. Rola procesowa jest widoczna na edytorze jako nowy tor procesu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWfPlugInItemReferenceHost`, `IWFRecipientHost`

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinitionType | `Soneta.Business.Db.DefinitionTypeEnum` | bazodanowe, enum | Tryb edycji | Określa tryb edycji definicji workflow |
| ExecutorType | `Soneta.Business.Db.WFProcessRoleExecutorType` | bazodanowe, enum | Rodzaj wykonującego | Rodzaj wykonującego |
| GetTaskUsersByProcessRoleCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Algorytm metody GetTaskUsersByProcessRole | Określa algorytm metody GetTaskUsersByProcessRole |
| Index | `int` |  |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa roli procesowej na definicji procesu |
| Name | `string` | bazodanowe | Nazwa roli procesowej | Nazwa roli procesowej |
| Node | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe | Operator | Operator |
| OrgStructure | `Soneta.Core.StrukturaOrganizacyjna` | bazodanowe |  |  |
| OwningSwimLane | `Soneta.Business.UI.Diagram.ISwimLaneNode` |  |  |  |
| PlugIns | `Soneta.Business.LpSubTable<Soneta.Workflow.Config.WfPlugInItemReference>` |  |  |  |
| RoleGuid | `System.Guid` | bazodanowe | Rola | Rola |
| RoleName | `string` |  |  |  |
| SetExecutorByProcessRoleCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Algorytm metody SetExecutorByProcessRole | Określa algorytm metody SetExecutorByProcessRole |
| SetExecutorByProcessRoleCode.Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| SetExecutorByProcessRoleCode.CodeUi | `string` |  |  |  |
| SetExecutorByProcessRoleCode.CodeUiRoslyn | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| TaskUser | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Użytkownik web | Użytkownik web |
| TaskUsers | `System.Collections.Generic.IEnumerable<Soneta.Business.ITaskUser>` |  |  |  |
| WFRecipients | `Soneta.Business.SubTable<Soneta.Workflow.Config.WFRecipient>` |  |  |  |
| WorkflowDefinition | `Soneta.Workflow.Config.WFDefinition` | bazodanowe | Definicja workflow | Definicja workflow powiązana z elementem workflow |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| TaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Soneta.Business.Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### WFProcessRoleExecutorType (`Soneta.Business.Db.WFProcessRoleExecutorType`)
- `TaskExecutor` = 0 — Wskazany na zadaniu
- `Operator` = 1 — Operator
- `Role` = 2 — Rola
- `TaskUser` = 3 — Użytkownik web
- `Custom` = 4 — Algorytm jednego wykonawcy
- `MultitaskAlgorithm` = 5 — Multitask - algorytm wielu wykonawców
- `MultitaskRecipientsList` = 6 — Multitask - lista wielu odbiorców
