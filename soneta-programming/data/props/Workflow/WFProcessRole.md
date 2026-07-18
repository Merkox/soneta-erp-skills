# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFProcessRole`
Nazwa tabeli: `WFProcessRoles`
Tytuł: Role procesowe
Opis: Rola procesowa powiązana do definicji procesu. Rola procesowa jest widoczna na edytorze jako nowy tor procesu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWfPlugInItemReferenceHost`, `IWFRecipientHost`
Selektor: pole `DefinitionType` (`Db.DefinitionTypeEnum`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt, selektor | Tryb edycji | Określa tryb edycji definicji workflow |
| ExecutorType | `Db.WFProcessRoleExecutorType` (enum) | bazodanowe | Rodzaj wykonującego | Rodzaj wykonującego |
| GetTaskUsersByProcessRoleCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Algorytm metody GetTaskUsersByProcessRole | Określa algorytm metody GetTaskUsersByProcessRole |
| Index | `int` |  |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa roli procesowej na definicji procesu |
| Name | `string` | bazodanowe | Nazwa roli procesowej | Nazwa roli procesowej |
| Node | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
| Operator | `App.Operator` | bazodanowe | Operator | Operator |
| OrgStructure | `Soneta.Core.StrukturaOrganizacyjna` | bazodanowe |  |  |
| OwningSwimLane | `UI.Diagram.ISwimLaneNode` |  |  |  |
| PlugIns | `LpSubTable<Soneta.Workflow.Config.WfPlugInItemReference>` | podlista |  |  |
| RoleGuid | `System.Guid` | bazodanowe | Rola | Rola |
| RoleName | `string` |  |  |  |
| SetExecutorByProcessRoleCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Algorytm metody SetExecutorByProcessRole | Określa algorytm metody SetExecutorByProcessRole |
| SetExecutorByProcessRoleCode.Code | `MemoText` | bazodanowe, podlista |  |  |
| SetExecutorByProcessRoleCode.CodeUiRoslyn | `Compiler.ICodeEditorSource` |  |  |  |
| TaskUser | `ITaskUser` | bazodanowe, iface-ref | Użytkownik web | Użytkownik web |
| TaskUsers | `System.Collections.Generic.IEnumerable<ITaskUser>` | podlista |  |  |
| WFRecipients | `SubTable<Soneta.Workflow.Config.WFRecipient>` | podlista |  |  |
| WorkflowDefinition | `Soneta.Workflow.Config.WFDefinition` | bazodanowe, tylko-odczyt | Definicja workflow | Definicja workflow powiązana z elementem workflow |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `DefinitionType`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Standard` | 0 | `Soneta.Workflow.Config.WFProcessRole` |  |
| `Engine` | 1 | `Soneta.Workflow.Config.WFProcessRoleExtend` |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| TaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### WFProcessRoleExecutorType (`Db.WFProcessRoleExecutorType`)
- `TaskExecutor` = 0 — Wskazany na zadaniu
- `Operator` = 1 — Operator
- `Role` = 2 — Rola
- `TaskUser` = 3 — Użytkownik web
- `Custom` = 4 — Algorytm jednego wykonawcy
- `MultitaskAlgorithm` = 5 — Multitask - algorytm wielu wykonawców
- `MultitaskRecipientsList` = 6 — Multitask - lista wielu odbiorców
