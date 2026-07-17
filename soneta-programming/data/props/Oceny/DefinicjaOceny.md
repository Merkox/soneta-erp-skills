# Pola i właściwości klasy biznesowej: `Soneta.Oceny.DefinicjaOceny`
Nazwa tabeli: `DefinicjeOcen`
Tytuł: Definicje ocen
Opis: Definicja procesu oceny okresowej określająca jego parametry organizacyjne. Konfiguruje typ oceny, okres, strukturę organizacyjną, algorytm kalkulacji i procesy workflow, stanowiąc wzorzec dla realizacji ocen pracowniczych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Arkusze | `Soneta.Business.SubTable<Soneta.Oceny.ArkuszDefinicjiOceny>` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| CalcCode | `string` |  |  |  |
| ClassCode | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| DefinicjaProcesu | `System.Guid` | bazodanowe |  |  |
| DependentWfDefinition | `Soneta.Business.IDependentWfDefinition` |  |  |  |
| Konsolidacyjne | `System.Collections.Generic.IEnumerable<Soneta.Oceny.DefinicjaArkuszaOceny>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Oceny | `Soneta.Business.SubTable<Soneta.Oceny.OcenaRealizacja>` |  |  |  |
| Okres | `Soneta.Oceny.RodzajeOkresówOceny` | bazodanowe, enum |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| PokazPunktacje | `bool` | bazodanowe |  |  |
| PrzeznaczonaDla | `Soneta.Oceny.TableRef` |  |  |  |
| RodzajStruktury | `string` | bazodanowe |  |  |
| RodzajZrodla | `string` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| StrukturaFirmy | `Soneta.Oceny.TableRef` |  |  |  |
| StrukturaOrganizacyjna | `Soneta.Core.StrukturaOrganizacyjna` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |
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
