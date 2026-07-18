# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.OcrBusinessMappingOutput`
Nazwa tabeli: `OcrBusMapOutputs`
Tytuł: Wyniki mapowania OCR
Opis: Wynik przetworzenia załącznika przez silnik OCR z zastosowaniem formatu mapowania. Przechowuje rezultat mapowania w postaci XML dla konkretnego załącznika, umożliwiając późniejsze wykorzystanie rozpoznanych danych w procesach biznesowych.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Attachment | `Db.Attachment` | bazodanowe, tylko-odczyt | Załącznik | Załącznik powiązany z wynikiem mapowania OCR |
| OcrBusinessMapping | `Soneta.Workflow.Dms.Config.OcrBusinessMapping` | bazodanowe, tylko-odczyt | Format mapowania OCR | Format mapowania OCR powiązany z wynikiem mapowania OCR |
| XmlOcrOutput | `MemoText` | bazodanowe, podlista | Wynik | Wynik mapowania OCR |
