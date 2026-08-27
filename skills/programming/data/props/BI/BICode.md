# Pola i właściwości klasy biznesowej: `Soneta.BI.BICode`
Nazwa tabeli: `BICodes`
Tytuł: Algorytmy BI
Opis: Algorytm (fragment kodu) wykorzystywany w procesach BI, np. w parametrach raportów. Przechowuje nazwany kod źródłowy wraz z typem algorytmu i informacjami uruchomieniowymi. Algorytmy umożliwiają rozszerzanie logiki modeli analitycznych.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Type` (`Soneta.BI.BICodeType`) — wiele typów w jednej tabeli, podtypów: 1

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
| Type | `Soneta.BI.BICodeType` (enum) | bazodanowe, tylko-odczyt, selektor | Typ algorytmu BI |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Type`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `ReportParamCode` | 1 | `Soneta.BI.ReportParamCode` | Algorytm parametru |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### BICodeType (`Soneta.BI.BICodeType`)
- `ReportParamCode` = 1 — Algorytm parametru
