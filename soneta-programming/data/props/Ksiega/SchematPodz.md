# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.Podzielniki.SchematPodz`
Nazwa tabeli: `SchematyPodz`
Tytuł: Schemat podziałowy
Opis: Schemat podziałowy (podzielnik kosztów) definiuje reguły automatycznego podziału kwot opisu analitycznego na wiele wymiarów. Określa klasę obiektu, nazwę projektu podziału oraz zawiera kod kalkulatora realizującego logikę rozdzielania kosztów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `ISchematPodziałowy`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa projektu | Krótka nazwa definicji podzielnika. |
| Opis | `string` | bazodanowe | Opis | Dokładny opis definicji podzielnika. |
| PlacementKind | `Soneta.Ksiega.Podzielniki.SchematPodz.ActionPlacement` | enum |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SchematClassName | `string` |  |  |  |
| SchematCode | `Soneta.Business.MemoText` | bazodanowe | Kod kalkulatora dla schematu | Kod klasy kalkulatora dla schematu. |
| SchematPodzElems | `Soneta.Business.SubTable<Soneta.Ksiega.Podzielniki.SchematPodzElem>` |  |  |  |
| TableName | `string` | bazodanowe | Klasa | Klasa obiektu. |
| _IsVisible | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ActionPlacement (`Soneta.Ksiega.Podzielniki.SchematPodz.ActionPlacement`)
- `Menu` = 1 — Menu
- `ToolbarWithText` = 4 — Pasek narzędzi
- `MenuAndToolbarWithText` = 5 — Menu i pasek narzędzi
