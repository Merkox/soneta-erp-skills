# Pola i właściwości klasy biznesowej: `Soneta.Core.ImportExportXml`
Nazwa tabeli: `ImpExpXml`
Tytuł: Importy, eksporty XML
Opis: Rejestr operacji importu i eksportu XML. Przechowuje informację o wykonanej operacji: obiekt źródłowy, wykorzystaną definicję XML, ścieżkę pliku, rodzaj operacji (import/eksport), przetworzony dokument XML oraz wynik walidacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaXmlNag | `Soneta.Core.DefXmlNag` | bazodanowe | Definicja wykorzystana do importu/eksportu. |  |
| FormattedXml | `string` |  |  |  |
| Host | `Soneta.Core.IImportExportXmlHost` | bazodanowe | Obiekt, którego dotyczy import/eksport |  |
| Parent | `Soneta.Core.IImportExportHost` | bazodanowe | Obiekt, którego dotyczy import/eksport |  |
| Plik | `string` | bazodanowe | Plik importu/eksportu |  |
| Rodzaj | `Soneta.Core.RodzajOperacji` | bazodanowe, enum | Rodzaj operacji | Rodzaj operacji. |
| Selektor | `Soneta.Core.SelektorDefXml` | bazodanowe, enum | Selektor | Selektor definicji. |
| Xml | `Soneta.Business.MemoText` | bazodanowe | Przetworzony dokument XML |  |
| XmlValidated | `Soneta.Business.ThreeStateBoolean` | bazodanowe, enum |  |  |
| ZgodnyPlikXML | `string` |  | Zgodny plik XML |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ThreeStateBoolean (`Soneta.Business.ThreeStateBoolean`)
- `Default` = 0
- `True` = 1
- `False` = 2

### RodzajOperacji (`Soneta.Core.RodzajOperacji`)
- `None` = 0
- `Export` = 1 — Eksport
- `Import` = 2

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
