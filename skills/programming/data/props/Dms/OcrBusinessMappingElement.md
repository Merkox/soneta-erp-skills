# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.OcrBusinessMappingElement`
Nazwa tabeli: `OcrBusMapElems`
Tytuł: Pozycje formatu mapowania OCR
Opis: Pojedyncza pozycja (pole) w formacie mapowania OCR definiująca region na dokumencie do rozpoznania. Określa współrzędne obszaru, stronę, wyrażenia regularne i tekstowe do ekstrakcji danych oraz algorytm przetwarzania wyniku rozpoznawania.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ClassName | `string` | tylko-odczyt |  |  |
| Code | `MemoText` | bazodanowe, podlista | Kod algorytmu | Kod algorytmu kalkulatora pozycji formato mapowania OCR |
| Height | `int` | bazodanowe | Wysokość | Wysokość regionu |
| Info | `string` | tylko-odczyt |  |  |
| IsEmptyRegion | `bool` | tylko-odczyt | Określono region | Czy określono region (różny od regionu z wartościami X=0, Y=0, Width=0, Height=0) |
| IsFormatMatchExpression | `bool` | bazodanowe | Pole specjalne | Pole specjalne |
| IsMatchCode | `string` |  | Kod algorytmu metody IsMatch | Kod algorytmu kalkulatora weryfikacji formatu mapowania OCR |
| Kod | `string` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa pozycji |
| Nazwa | `string` | tylko-odczyt |  |  |
| OcrBusinessMapping | `Soneta.Workflow.Dms.Config.OcrBusinessMapping` | bazodanowe, tylko-odczyt | Format mapowania OCR | Format mapowania OCR powiązany z pozycją formatu mapowania OCR |
| OcrPage | `Soneta.Core.Ocr.OcrPage` (enum) | tylko-odczyt |  |  |
| Page | `Soneta.Core.Ocr.OcrPage` (enum) | bazodanowe | Strona | Strona na której należy weryfikować region |
| Path | `string` | tylko-odczyt |  |  |
| RegexExpression | `string` | bazodanowe | Wyrażenie regularne | Wyrażenie regularne pozwalające mapować |
| Region | `System.Drawing.Rectangle` | tylko-odczyt | Region | Region określający gdzie należy szukać danych |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| StringExpression | `string` | bazodanowe | Wyrażenie tekstowe | Wyrażenie tekstowe pozwalające mapować |
| Width | `int` | bazodanowe | Szerokość | Szerokość regionu |
| X | `int` | bazodanowe | Współrzędna X | Współrzędna X lewego górnego narożnika regionu |
| XmlElementDefinition | `Soneta.Core.DefXmlElem` | bazodanowe | Definicja elementu komunikatu | Definicja elementu komunikatu powiązana z pozycją formatu mapowania OCR |
| Y | `int` | bazodanowe | Współrzędna Y | Współrzędna Y lewego górnego narożnika regionu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OcrPage (`Soneta.Core.Ocr.OcrPage`)
- `FirstMatch` = 0 — Pierwsze wystąpienie
- `First` = 1 — Pierwsza
- `Last` = 2 — Ostatnia
