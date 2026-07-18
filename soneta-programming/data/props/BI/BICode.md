# Pola i właściwości klasy biznesowej: `Soneta.BI.BICode`
Nazwa tabeli: `BICodes`
Tytuł: Algorytmy BI
Opis: Algorytm (fragment kodu) wykorzystywany w procesach BI, np. w parametrach raportów. Przechowuje nazwany kod źródłowy wraz z typem algorytmu i informacjami uruchomieniowymi. Algorytmy umożliwiają rozszerzanie logiki modeli analitycznych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 3
- subrowy: 1
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Code | `MemoText` | bazodanowe, podlista |  |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa algorytmu |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Type | `Soneta.BI.BICodeType` (enum) | bazodanowe, tylko-odczyt | Typ algorytmu BI |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### BICodeType (`Soneta.BI.BICodeType`)
- `ReportParamCode` = 1 — Algorytm parametru
