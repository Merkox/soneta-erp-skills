# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.OcrBusinessMapping`
Nazwa tabeli: `OcrBusMappings`
Tytuł: Formaty mapowania OCR
Opis: Format mapowania danych z rozpoznawania OCR na strukturę komunikatu XML. Definiuje powiązanie między wynikiem skanowania dokumentu a definicją komunikatu, umożliwiając automatyczne przenoszenie danych z zeskanowanych dokumentów do systemu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Name | `string` | bazodanowe | Nazwa | Nazwa formatu mapowania OCR |
| OcrBusinessMappingElements | `Soneta.Business.SubTable<Soneta.Workflow.Dms.Config.OcrBusinessMappingElement>` |  |  |  |
| OcrBusinessMappingOutputs | `Soneta.Business.SubTable<Soneta.Workflow.Dms.OcrBusinessMappingOutput>` |  |  |  |
| OcrPagesRegions | `System.Collections.Generic.IEnumerable<Soneta.Core.Ocr.IOcrPageRegion>` |  |  |  |
| XmlDefinition | `Soneta.Core.DefXmlNag` | bazodanowe | Definicja komunikatu | Definicja komunikatu powiązana z formatem mapowania OCR |
