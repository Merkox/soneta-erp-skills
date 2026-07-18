# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.Register`
Nazwa tabeli: `Registers`
Tytuł: Rejestry dokumentów podstawowych
Opis: Rejestr grupujący dokumenty podstawowe w module DMS. Umożliwia organizację dokumentów w osobne zbiory z własnym symbolem i numeracją, ograniczenie dozwolonych definicji dokumentów oraz oznaczenie rejestru jako głównego.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowedBasicDocDefs | `Soneta.Workflow.Dms.DmsModule.BasicDocumentDefinitionRow[]` | bazodanowe, podlista | Dozwolone definicje | Dozwolone definicje dokumentów podstawowych |
| BasicDocuments | `SubTable<Soneta.Workflow.Dms.BasicDocument>` | podlista |  |  |
| Flag | `Soneta.Workflow.Dms.Config.RegisterFlags` (enum) | bazodanowe | Flaga zachowania rejestrów |  |
| IsMain | `bool` | bazodanowe | Główny | Czy główny rejestr dokumentów podstawowych |
| Name | `string` | bazodanowe | Nazwa | Nazwa rejestru dokumentu podstawowego |
| Symbol | `string` | bazodanowe | Symbol | Symbol rejestru dokumentu podstawowego |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RegisterFlags (`Soneta.Workflow.Dms.Config.RegisterFlags`)
- `VisibleAndAddNew` = 0 — Widoczny z dodawaniem dokumentów
- `VisibleWithoutAddNew` = 1 — Widoczny bez dodawania dokumentów
- `UnvisibleAndAddNew` = 2 — Niewidoczny z dodawniem dokumentów
- `Locked` = 3 — Zablokowany
