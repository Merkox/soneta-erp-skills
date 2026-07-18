# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.Podzielniki.SchematPodz`
Nazwa tabeli: `SchematyPodz`
Tytuł: Schemat podziałowy
Opis: Schemat podziałowy (podzielnik kosztów) definiuje reguły automatycznego podziału kwot opisu analitycznego na wiele wymiarów. Określa klasę obiektu, nazwę projektu podziału oraz zawiera kod kalkulatora realizującego logikę rozdzielania kosztów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `ISchematPodziałowy`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 5
- podlisty: 4
- subrowy: 1
- razem: 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa projektu | Krótka nazwa definicji podzielnika. |
| Opis | `string` | bazodanowe | Opis | Dokładny opis definicji podzielnika. |
| PlacementKind | `Soneta.Ksiega.Podzielniki.SchematPodz.ActionPlacement` (enum) |  |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SchematClassName | `string` | tylko-odczyt |  |  |
| SchematCode | `MemoText` | bazodanowe, podlista | Kod kalkulatora dla schematu | Kod klasy kalkulatora dla schematu. |
| SchematPodzElems | `SubTable<Soneta.Ksiega.Podzielniki.SchematPodzElem>` | podlista |  |  |
| TableName | `string` | bazodanowe, tylko-odczyt | Klasa | Klasa obiektu. |
| _IsVisible | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ActionPlacement (`Soneta.Ksiega.Podzielniki.SchematPodz.ActionPlacement`)
- `Menu` = 1 — Menu
- `ToolbarWithText` = 4 — Pasek narzędzi
- `MenuAndToolbarWithText` = 5 — Menu i pasek narzędzi
