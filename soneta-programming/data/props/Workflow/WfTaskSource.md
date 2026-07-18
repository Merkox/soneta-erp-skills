# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WfTaskSource`
Nazwa tabeli: `WfTaskSources`
Tytuł: Źródła zadań
Opis: Element szczegółowy definicji zadania (TaskDefinition). Określa źródło danych dla zadania workflow, wskazując tabelę źródłową, schemat generatora obiektów oraz opcjonalny typ wielowariantowy. Umożliwia powiązanie zadania z konkretnymi obiektami biznesowymi.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `TaskDefinition` → `TaskDefinition`
Implementuje interfejsy: `IWfPlugInItemReferenceHost`
Selektor: pole `DefinitionType` (`Db.DefinitionTypeEnum`) — wiele typów w jednej tabeli, podtypów: 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataType | `System.Type` | tylko-odczyt |  |  |
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt, selektor | Tryb edycji | Określa tryb edycji definicji workflow |
| HostTable | `Table` | podlista |  |  |
| OGSchema | `Soneta.Workflow.Config.OGSchema` | bazodanowe | Definicja schematu generatora | Określa definicję schematu generatora obiektów |
| PlugIns | `LpSubTable<Soneta.Workflow.Config.WfPlugInItemReference>` | podlista |  |  |
| TableName | `string` | bazodanowe, tylko-odczyt |  |  |
| TaskDefinition | `Db.TaskDefinition` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| VariantTypeName | `string` | bazodanowe | Typ źrodła wielowariantowego | Typ źrodła wielowariantowego |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `DefinitionType`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Engine` | 1 | `Soneta.Workflow.Config.WfAdvTaskSource` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak
