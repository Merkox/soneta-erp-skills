# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.MatterDefinition`
Nazwa tabeli: `MatterDefs`
Tytuł: Definicje spraw
Opis: Definicja typu sprawy w module DMS. Określa reguły numeracji, seryjność oraz wymagalność metryk dla spraw tworzonych na jej podstawie. Stanowi szablon konfiguracyjny kontrolujący właściwości nowo zakładanych spraw.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 10
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 1
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IsAdditionalPageLocked | `bool` | bazodanowe | Blokuj zakładkę 'Pozostałe' | Blokuje zakładkę 'Pozostałe' |
| IsGeneralPageLocked | `bool` | bazodanowe | Blokuj zakładkę 'Ogólne' | Blokuje zakładkę 'Pozostałe' |
| IsMetricsRequired | `bool` | bazodanowe | Metryki wymagane | Metryki wymagane |
| Locked | `bool` | bazodanowe | Zablokowana | Definicja zablokowana |
| Matters | `SubTable<Soneta.Workflow.Dms.Matter>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji |
| Numerator | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe | Numeracja | Określa sposób numerowania definicji |
| Numerator.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numerator.PodczasZapisu | `bool` |  |  |  |
| Numerator.Separator | `string` | bazodanowe |  |  |
| Numerator.Wzor | `string` | bazodanowe |  |  |
| Series | `bool` | bazodanowe | Seria | Seria definicji |
| Symbol | `string` | bazodanowe | Symbol | Symbol definicji |
