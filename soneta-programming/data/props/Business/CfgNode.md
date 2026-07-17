# Pola i właściwości klasy biznesowej: `Soneta.Config.CfgNode`
Nazwa tabeli: `CfgNodes`
Tytuł: Konfiguracja
Opis: Węzeł drzewa konfiguracji systemu. Przechowuje hierarchiczną strukturę ustawień programu, modułów i dodatków.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Attribute | `object` |  |  |  |
| Attributes | `Soneta.Business.SubTable<Soneta.Config.CfgAttribute>` |  |  |  |
| FullName | `string` |  |  |  |
| Name | `string` | bazodanowe |  |  |
| Parent | `Soneta.Config.CfgNode` | bazodanowe |  |  |
| Subkeys | `Soneta.Business.SubTable<Soneta.Config.CfgNode>` |  |  |  |
| Type | `Soneta.Config.CfgNodeType` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CfgNodeType (`Soneta.Config.CfgNodeType`)
- `Node` = 0
- `Leaf` = 1
- `HistoryNode` = 2
- `HistoryLeaf` = 3
