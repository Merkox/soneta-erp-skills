# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.MatterDefinition`
Nazwa tabeli: `MatterDefs`
Tytuł: Definicje spraw
Opis: Definicja typu sprawy w module DMS. Określa reguły numeracji, seryjność oraz wymagalność metryk dla spraw tworzonych na jej podstawie. Stanowi szablon konfiguracyjny kontrolujący właściwości nowo zakładanych spraw.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IsAdditionalPageLocked | `bool` | bazodanowe | Blokuj zakładkę 'Pozostałe' | Blokuje zakładkę 'Pozostałe' |
| IsGeneralPageLocked | `bool` | bazodanowe | Blokuj zakładkę 'Ogólne' | Blokuje zakładkę 'Pozostałe' |
| IsMetricsRequired | `bool` | bazodanowe | Metryki wymagane | Metryki wymagane |
| Locked | `bool` | bazodanowe | Zablokowana | Definicja zablokowana |
| Matters | `Soneta.Business.SubTable<Soneta.Workflow.Dms.Matter>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji |
| Numerator | `Soneta.Core.DefinicjaNumeracji` | bazodanowe | Numeracja | Określa sposób numerowania definicji |
| Numerator.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numerator.PodczasZapisu | `bool` |  |  |  |
| Numerator.Separator | `string` | bazodanowe |  |  |
| Numerator.Wzor | `string` | bazodanowe |  |  |
| Series | `bool` | bazodanowe | Seria | Seria definicji |
| Symbol | `string` | bazodanowe | Symbol | Symbol definicji |
