# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WfTaskSource`
Nazwa tabeli: `WfTaskSources`
Tytuł: Źródła zadań
Opis: Element szczegółowy definicji zadania (TaskDefinition). Określa źródło danych dla zadania workflow, wskazując tabelę źródłową, schemat generatora obiektów oraz opcjonalny typ wielowariantowy. Umożliwia powiązanie zadania z konkretnymi obiektami biznesowymi.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `TaskDefinition` → `TaskDefinition`
Implementuje interfejsy: `IWfPlugInItemReferenceHost`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataType | `System.Type` |  |  |  |
| DefinitionType | `Soneta.Business.Db.DefinitionTypeEnum` | bazodanowe, enum | Tryb edycji | Określa tryb edycji definicji workflow |
| HostTable | `Soneta.Business.Table` |  |  |  |
| OGSchema | `Soneta.Workflow.Config.OGSchema` | bazodanowe | Definicja schematu generatora | Określa definicję schematu generatora obiektów |
| PlugIns | `Soneta.Business.LpSubTable<Soneta.Workflow.Config.WfPlugInItemReference>` |  |  |  |
| TableName | `string` | bazodanowe |  |  |
| TaskDefinition | `Soneta.Business.Db.TaskDefinition` | bazodanowe, guided-parent |  |  |
| VariantTypeName | `string` | bazodanowe | Typ źrodła wielowariantowego | Typ źrodła wielowariantowego |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Soneta.Business.Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak
