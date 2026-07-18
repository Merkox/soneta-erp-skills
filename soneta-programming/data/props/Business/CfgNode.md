# Pola i właściwości klasy biznesowej: `Soneta.Config.CfgNode`
Nazwa tabeli: `CfgNodes`
Tytuł: Konfiguracja
Opis: Węzeł drzewa konfiguracji systemu. Przechowuje hierarchiczną strukturę ustawień programu, modułów i dodatków.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Attribute | `object` |  |  |  |
| Attributes | `SubTable<Soneta.Config.CfgAttribute>` | podlista |  |  |
| FullName | `string` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe |  |  |
| Parent | `Soneta.Config.CfgNode` | bazodanowe |  |  |
| Subkeys | `SubTable<Soneta.Config.CfgNode>` | podlista |  |  |
| Type | `Soneta.Config.CfgNodeType` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CfgNodeType (`Soneta.Config.CfgNodeType`)
- `Node` = 0
- `Leaf` = 1
- `HistoryNode` = 2
- `HistoryLeaf` = 3
