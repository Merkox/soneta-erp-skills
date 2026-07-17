# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.AttachmentFile`
Nazwa tabeli: `AttachmentFiles`
Tytuł: Dane binarne załączników
Opis: Dane binarne pliku załącznika. Przechowuje zawartość pliku, typ MIME, dane OCR oraz informacje o blokadzie edycji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Business.MemoBin` | bazodanowe | Dane | Binarna wartość przechowywanego pliku. |
| Description | `string` | bazodanowe | Opis | Opis zawartości załącznika. |
| Icon | `System.Drawing.Icon` |  |  |  |
| LockOperator | `Soneta.Business.App.Operator` | bazodanowe | Operator blokujący załącznik | Operator blokujący załącznik. |
| LockTime | `System.DateTime` | bazodanowe | Czas zablokowania załącznika | Czas zablokowania załącznika. |
| MainAttachment | `Soneta.Business.Db.Attachment` |  |  |  |
| MimeIcon | `Soneta.Drawing.Img` |  |  |  |
| MimeType | `string` | bazodanowe | Typ MIME | Identyfikator formatu pliku publikowanego w internecie (Content-Type). |
| Name | `string` | bazodanowe | Nazwa | Nazwa załącznika. |
| OcrData | `Soneta.Business.MemoText` | bazodanowe | Dane pochądzące z silnika OCR | Kolumna zawiera opcjonalne dane pochądzące z silnika OCR. |
| OcrDataWithLayout | `Soneta.Business.MemoText` | bazodanowe | Dane pochądzące z silnika OCR | Kolumna zawiera opcjonalne dane pochądzące z silnika OCR (dane te powinny zawierać opis szczegółowy położenia tekstu na obrazku/PDF). |
