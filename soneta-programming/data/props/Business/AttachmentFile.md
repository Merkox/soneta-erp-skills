# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.AttachmentFile`
Nazwa tabeli: `AttachmentFiles`
Tytuł: Dane binarne załączników
Opis: Dane binarne pliku załącznika. Przechowuje zawartość pliku, typ MIME, dane OCR oraz informacje o blokadzie edycji.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 2
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `MemoBin` | bazodanowe | Dane | Binarna wartość przechowywanego pliku. |
| Description | `string` | bazodanowe | Opis | Opis zawartości załącznika. |
| LockOperator | `App.Operator` | bazodanowe, tylko-odczyt | Operator blokujący załącznik | Operator blokujący załącznik. |
| LockTime | `System.DateTime` | bazodanowe, tylko-odczyt | Czas zablokowania załącznika | Czas zablokowania załącznika. |
| MainAttachment | `Db.Attachment` | tylko-odczyt |  |  |
| MimeIcon | `Soneta.Drawing.Img` | tylko-odczyt |  |  |
| MimeType | `string` | bazodanowe | Typ MIME | Identyfikator formatu pliku publikowanego w internecie (Content-Type). |
| Name | `string` | bazodanowe | Nazwa | Nazwa załącznika. |
| OcrData | `MemoText` | bazodanowe, podlista | Dane pochądzące z silnika OCR | Kolumna zawiera opcjonalne dane pochądzące z silnika OCR. |
| OcrDataWithLayout | `MemoText` | bazodanowe, podlista | Dane pochądzące z silnika OCR | Kolumna zawiera opcjonalne dane pochądzące z silnika OCR (dane te powinny zawierać opis szczegółowy położenia tekstu na obrazku/PDF). |
