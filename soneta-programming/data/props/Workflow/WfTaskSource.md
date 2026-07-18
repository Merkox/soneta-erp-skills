# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WfTaskSource`
Nazwa tabeli: `WfTaskSources`
Tytuł: Źródła zadań
Opis: Element szczegółowy definicji zadania (TaskDefinition). Określa źródło danych dla zadania workflow, wskazując tabelę źródłową, schemat generatora obiektów oraz opcjonalny typ wielowariantowy. Umożliwia powiązanie zadania z konkretnymi obiektami biznesowymi.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `TaskDefinition` → `TaskDefinition`
Implementuje interfejsy: `IWfPlugInItemReferenceHost`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 2
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataType | `System.Type` | tylko-odczyt |  |  |
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt | Tryb edycji | Określa tryb edycji definicji workflow |
| HostTable | `Table` | podlista |  |  |
| OGSchema | `Soneta.Workflow.Config.OGSchema` | bazodanowe | Definicja schematu generatora | Określa definicję schematu generatora obiektów |
| PlugIns | `LpSubTable<Soneta.Workflow.Config.WfPlugInItemReference>` | podlista |  |  |
| TableName | `string` | bazodanowe, tylko-odczyt |  |  |
| TaskDefinition | `Db.TaskDefinition` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| VariantTypeName | `string` | bazodanowe | Typ źrodła wielowariantowego | Typ źrodła wielowariantowego |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak
