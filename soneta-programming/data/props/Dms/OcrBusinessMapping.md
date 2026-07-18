# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.OcrBusinessMapping`
Nazwa tabeli: `OcrBusMappings`
Tytuł: Formaty mapowania OCR
Opis: Format mapowania danych z rozpoznawania OCR na strukturę komunikatu XML. Definiuje powiązanie między wynikiem skanowania dokumentu a definicją komunikatu, umożliwiając automatyczne przenoszenie danych z zeskanowanych dokumentów do systemu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 3
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Name | `string` | bazodanowe | Nazwa | Nazwa formatu mapowania OCR |
| OcrBusinessMappingElements | `SubTable<Soneta.Workflow.Dms.Config.OcrBusinessMappingElement>` | podlista |  |  |
| OcrBusinessMappingOutputs | `SubTable<Soneta.Workflow.Dms.OcrBusinessMappingOutput>` | podlista |  |  |
| OcrPagesRegions | `System.Collections.Generic.IEnumerable<Soneta.Core.Ocr.IOcrPageRegion>` | podlista |  |  |
| XmlDefinition | `Soneta.Core.DefXmlNag` | bazodanowe, tylko-odczyt | Definicja komunikatu | Definicja komunikatu powiązana z formatem mapowania OCR |
