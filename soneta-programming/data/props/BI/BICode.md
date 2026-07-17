# Pola i właściwości klasy biznesowej: `Soneta.BI.BICode`
Nazwa tabeli: `BICodes`
Tytuł: Algorytmy BI
Opis: Algorytm (fragment kodu) wykorzystywany w procesach BI, np. w parametrach raportów. Przechowuje nazwany kod źródłowy wraz z typem algorytmu i informacjami uruchomieniowymi. Algorytmy umożliwiają rozszerzanie logiki modeli analitycznych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa algorytmu |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Type | `Soneta.BI.BICodeType` | bazodanowe, enum | Typ algorytmu BI |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### BICodeType (`Soneta.BI.BICodeType`)
- `ReportParamCode` = 1 — Algorytm parametru
