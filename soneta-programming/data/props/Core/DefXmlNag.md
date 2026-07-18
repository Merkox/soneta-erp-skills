# Pola i właściwości klasy biznesowej: `Soneta.Core.DefXmlNag`
Nazwa tabeli: `DefsXmlNag`
Tytuł: Definicje XML
Opis: Definicja szablonu importu/eksportu XML (komunikatów, e-deklaracji, plików JPK itp.). Określa nazwę, klasę obiektu, standard, rodzaj, format pliku, kodowanie znaków, źródło danych oraz plik szablonu i schematu XSD.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 16
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 12
- podlisty: 6
- subrowy: 1
- razem: 35

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BOM | `bool` | bazodanowe | Znacznik BOM | Określa czy dodawać znacznik BOM w eksportowanym pliku. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. |
| ClassName | `string` | tylko-odczyt |  |  |
| DefXmlElemRoot | `Soneta.Core.DefXmlElem` | tylko-odczyt |  |  |
| DefXmlNagCode | `string` | tylko-odczyt |  |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefsXmlElem | `SubTable<Soneta.Core.DefXmlElem>` | podlista |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| ExpandInteger | `int` | bazodanowe |  | Pole liczbowe do wykorzystania per rodzaj definicji. |
| ExpandInteger2 | `int` | bazodanowe |  | Pole liczbowe do wykorzystania per rodzaj definicji. |
| Format | `Soneta.Core.FormatDefXml` (enum) | bazodanowe | Formatowanie pliku | Określa sposób formatowania pliku. |
| Info | `Soneta.Core.ImportExportInfo` | tylko-odczyt |  |  |
| KodowanieZnakow | `int` | bazodanowe | Kodowanie znaków | Określa sposób kodowania znaków (strona kodowa). |
| KodowanieZnakowName | `string` | tylko-odczyt |  |  |
| LocalXSD | `string` | bazodanowe | Scieżka do pliku XSD |  |
| Nazwa | `string` | bazodanowe | Nazwa definicji | Krótka nazwa definicji XML. |
| OcrBusMappings | `SubTable` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Opis definicji. |
| PlikSzablonu | `string` | bazodanowe | Plik szabolnu |  |
| Rodzaj | `Soneta.Core.RodzajDefXml` (enum) | bazodanowe |  |  |
| RodzajZrodlaDanych | `Soneta.Core.RodzajZrodlaDanychDefXml` (enum) | bazodanowe | Rodzaj źródła danych | Określa rodzaj źródła danych. |
| RootRowCount | `int` | tylko-odczyt |  |  |
| Row | `Soneta.Core.DefXmlNag` | tylko-odczyt |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Selektor | `Soneta.Core.SelektorDefXml` (enum) | bazodanowe, tylko-odczyt | Selektor definicji | Selektor definicji. |
| SprawozdzaniaKS | `SubTable` | podlista |  |  |
| Standard | `Soneta.Core.StandardDefXml` (enum) | bazodanowe |  |  |
| TableName | `string` | bazodanowe | Tabela danych | Klasa obiektu. |
| UseStandardForm | `bool` | tylko-odczyt |  |  |
| XMLTempate | `string` | tylko-odczyt |  |  |

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
