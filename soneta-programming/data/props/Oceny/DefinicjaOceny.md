# Pola i właściwości klasy biznesowej: `Soneta.Oceny.DefinicjaOceny`
Nazwa tabeli: `DefinicjeOcen`
Tytuł: Definicje ocen
Opis: Definicja procesu oceny okresowej określająca jego parametry organizacyjne. Konfiguruje typ oceny, okres, strukturę organizacyjną, algorytm kalkulacji i procesy workflow, stanowiąc wzorzec dla realizacji ocen pracowniczych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 12
- pola kalkulowane (zapisywalne): 5
- pola tylko-odczyt: 1
- podlisty: 6
- subrowy: 1
- razem: 25

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Arkusze | `SubTable<Soneta.Oceny.ArkuszDefinicjiOceny>` | podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| CalcCode | `string` |  |  |  |
| ClassCode | `string` |  |  |  |
| Code | `MemoText` | bazodanowe, podlista |  |  |
| DefinicjaProcesu | `System.Guid` | bazodanowe |  |  |
| DependentWfDefinition | `IDependentWfDefinition` |  |  |  |
| Konsolidacyjne | `System.Collections.Generic.IEnumerable<Soneta.Oceny.DefinicjaArkuszaOceny>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Oceny | `SubTable<Soneta.Oceny.OcenaRealizacja>` | podlista |  |  |
| Okres | `Soneta.Oceny.RodzajeOkresówOceny` (enum) | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| PokazPunktacje | `bool` | bazodanowe |  |  |
| PrzeznaczonaDla | `Soneta.Oceny.TableRef` |  |  |  |
| RodzajStruktury | `string` | bazodanowe |  |  |
| RodzajZrodla | `string` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| StrukturaFirmy | `Soneta.Oceny.TableRef` |  |  |  |
| StrukturaOrganizacyjna | `Soneta.Core.StrukturaOrganizacyjna` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt |  |  |
| UkrywajOceniajacych | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeOkresówOceny (`Soneta.Oceny.RodzajeOkresówOceny`)
- `Dowolny` = 0
- `Miesięczna` = 1
- `Kwartalna` = 2
- `Roczna` = 4

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
