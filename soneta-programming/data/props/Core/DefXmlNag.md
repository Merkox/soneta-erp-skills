# Pola i właściwości klasy biznesowej: `Soneta.Core.DefXmlNag`
Nazwa tabeli: `DefsXmlNag`
Tytuł: Definicje XML
Opis: Definicja szablonu importu/eksportu XML (komunikatów, e-deklaracji, plików JPK itp.). Określa nazwę, klasę obiektu, standard, rodzaj, format pliku, kodowanie znaków, źródło danych oraz plik szablonu i schematu XSD.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 19
- pola kalkulowane (z klas biznesowych): 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BOM | `bool` | bazodanowe | Znacznik BOM | Określa czy dodawać znacznik BOM w eksportowanym pliku. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. |
| ClassName | `string` |  |  |  |
| DefXmlElemRoot | `Soneta.Core.DefXmlElem` |  |  |  |
| DefXmlNagCode | `string` |  |  |  |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefsXmlElem | `Soneta.Business.SubTable<Soneta.Core.DefXmlElem>` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| ExpandInteger | `int` | bazodanowe |  | Pole liczbowe do wykorzystania per rodzaj definicji. |
| ExpandInteger2 | `int` | bazodanowe |  | Pole liczbowe do wykorzystania per rodzaj definicji. |
| Format | `Soneta.Core.FormatDefXml` | bazodanowe, enum | Formatowanie pliku | Określa sposób formatowania pliku. |
| Info | `Soneta.Core.ImportExportInfo` |  |  |  |
| KodowanieZnakow | `int` | bazodanowe | Kodowanie znaków | Określa sposób kodowania znaków (strona kodowa). |
| KodowanieZnakowName | `string` |  |  |  |
| LocalXSD | `string` | bazodanowe | Scieżka do pliku XSD |  |
| Nazwa | `string` | bazodanowe | Nazwa definicji | Krótka nazwa definicji XML. |
| OcrBusMappings | `Soneta.Business.SubTable` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis definicji. |
| PlikSzablonu | `string` | bazodanowe | Plik szabolnu |  |
| Rodzaj | `Soneta.Core.RodzajDefXml` | bazodanowe, enum |  |  |
| RodzajZrodlaDanych | `Soneta.Core.RodzajZrodlaDanychDefXml` | bazodanowe, enum | Rodzaj źródła danych | Określa rodzaj źródła danych. |
| RootRowCount | `int` |  |  |  |
| Row | `Soneta.Core.DefXmlNag` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Selektor | `Soneta.Core.SelektorDefXml` | bazodanowe, enum | Selektor definicji | Selektor definicji. |
| SprawozdzaniaKS | `Soneta.Business.SubTable` |  |  |  |
| Standard | `Soneta.Core.StandardDefXml` | bazodanowe, enum |  |  |
| TableName | `string` | bazodanowe | Tabela danych | Klasa obiektu. |
| UseStandardForm | `bool` |  |  |  |
| XMLTempate | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FormatDefXml (`Soneta.Core.FormatDefXml`)
- `ZWcieciami` = 0 — Z wcięciami
- `BezWciec` = 1 — Bez wcięć

### RodzajDefXml (`Soneta.Core.RodzajDefXml`)
- `None` = 0
- `ORDER` = 1
- `ORDRSP` = 2
- `DESADV` = 3
- `RECADV` = 4
- `INVOICE` = 5
- `ANYDOC` = 8
- `INVRPT` = 9
- `PRICAT` = 10
- `METADATA` = 6
- `GM24` = 7
- `ANYDATA` = 11

### RodzajZrodlaDanychDefXml (`Soneta.Core.RodzajZrodlaDanychDefXml`)
- `Xml` = 0 — XML (EDI)
- `DaneNieustrukturyzowane` = 1 — Dane nieustrukturyzowane (OCR)
- `All` = 2147483647 — Wszystkie

### SelektorDefXml (`Soneta.Core.SelektorDefXml`)
- `None` = 0
- `EDI` = 1
- `KIR` = 2
- `GM24` = 4
- `Standard` = 256
- `Integrator` = 8
- `JPK` = 16
- `Przelewy` = 32
- `Sprawozdanie` = 64
- `DMS` = 128
- `PPK` = 512
- `Intrastat` = 1024
- `PUESC` = 2048
- `KSeF` = 4096 — KSeF
- `ZUSZ3` = 8192
- `ZUSZ3a` = 16384

### StandardDefXml (`Soneta.Core.StandardDefXml`)
- `None` = 0
- `ECOD` = 1
- `EDInet` = 2 — EDInet
- `KIR` = 3
- `GM24` = 4
- `Optima` = 5
- `Symfonia` = 6
- `enovaEDI` = 7 — Soneta
- `UBL` = 8
- `KSeF` = 9 — KSeF
- `PUESC` = 10
