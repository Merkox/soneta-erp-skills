# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.OcrBusinessMappingOutput`
Nazwa tabeli: `OcrBusMapOutputs`
Tytuł: Wyniki mapowania OCR
Opis: Wynik przetworzenia załącznika przez silnik OCR z zastosowaniem formatu mapowania. Przechowuje rezultat mapowania w postaci XML dla konkretnego załącznika, umożliwiając późniejsze wykorzystanie rozpoznanych danych w procesach biznesowych.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Attachment | `Soneta.Business.Db.Attachment` | bazodanowe | Załącznik | Załącznik powiązany z wynikiem mapowania OCR |
| OcrBusinessMapping | `Soneta.Workflow.Dms.Config.OcrBusinessMapping` | bazodanowe | Format mapowania OCR | Format mapowania OCR powiązany z wynikiem mapowania OCR |
| XmlOcrOutput | `Soneta.Business.MemoText` | bazodanowe | Wynik | Wynik mapowania OCR |
