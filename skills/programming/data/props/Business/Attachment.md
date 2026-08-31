# Pola i właściwości klasy biznesowej: `Ical.Net.DataTypes.Attachment`
Nazwa tabeli: `Attachments`
Tytuł: Załączniki
Opis: Załącznik przypisany do obiektu biznesowego. Przechowuje pliki, obrazy, odnośniki i dane OCR. Wspiera różne lokalizacje przechowywania (baza danych, dysk, chmura).
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IPermissionClient`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AssociatedObject | `Ical.Net.ICalendarObject?` |  |  |  |
| AttachmentFile | `IRow` | bazodanowe | Dane binarne załącznika | Kolumna zawiera dane binarne załącznika |
| AttachmentStorage | `Db.AttachmentStorage` (enum) | bazodanowe | Lokalizacja załącznika | Miejsce przechowywania załącznika |
| Calendar | `Ical.Net.Calendar?` | tylko-odczyt |  |  |
| Data | `byte[]?` | bazodanowe, podlista |  |  |
| Description | `string` | bazodanowe | Opis | Opis zawartości załącznika. |
| Encoding | `string?` |  |  |  |
| Folder | `IRow` | bazodanowe | Folder | Kolumna zawiera opcjonalny element określający folder |
| FormatType | `string?` |  |  |  |
| IconX | `int` | bazodanowe | X | Współrzędna X ikonki |
| IconY | `int` | bazodanowe | Y | Współrzędna Y ikonki |
| IsDataCompressed | `bool` | bazodanowe | Dane skompresowane | Określa, czy przechowywane dane są w wersji skompresowanej. |
| IsDefault | `bool` | bazodanowe | Standardowy obrazek | Określa, czy obrazek ma być standardowo użyty do reprezentacji obiektu. |
| IsFilePathSource | `bool` | bazodanowe | Źródło ścieżki | Kolumna zawiera informację czy ścieżka do plików znajdujących się na dysku jest budowana z użyciem pola Folder |
| Language | `string?` |  |  |  |
| Link | `string` | bazodanowe | Odnośnik | Ścieżka dostępu do wskazywanego pliku. |
| LockOperator | `IRow` | bazodanowe | Operator blokujący załącznik | Operator blokujący załącznik. |
| LockTime | `System.DateTime` | bazodanowe | Czas zablokowania załącznika | Czas zablokowania załącznika. |
| Lp | `int` | bazodanowe | Lp. | Kolejność wyświetlania załącznika na liście. |
| MimeType | `string` | bazodanowe | Typ MIME | Identyfikator formatu pliku publikowanego w internecie (Content-Type). |
| Modified | `System.DateTime` | bazodanowe | Data modyfikacji | Data ostatniej modyfikacji załącznika |
| Name | `string` | bazodanowe | Nazwa | Nazwa załącznika. |
| OcrData | `MemoText` | bazodanowe, podlista | Dane pochądzące z silnika OCR | Kolumna zawiera opcjonalne dane pochądzące z silnika OCR. |
| OcrDataWithLayout | `MemoText` | bazodanowe, podlista | Dane pochądzące z silnika OCR | Kolumna zawiera opcjonalne dane pochądzące z silnika OCR (dane te powinny zawierać opis szczegółowy położenia tekstu na obrazku/PDF). |
| Parameters | `Ical.Net.IParameterCollection` | podlista |  |  |
| Parent | `IRow` | bazodanowe | Nadrzędny | Zapis, do którego przypisany jest załącznik. |
| Send | `bool` | bazodanowe | Wysyłaj w mailu | Określa, czy załącznik powinien być dołączany do wysyłanego maila. |
| SubType | `Db.SubTypeType` (enum) | bazodanowe | Podtyp załącznika | Określa typ danego załącznika. |
| Type | `Db.AttachmentType` (enum) | bazodanowe | Typ | Określa zastosowanie danego załącznika. |
| Uri | `System.Uri?` |  |  |  |
| ValueEncoding | `System.Text.Encoding` |  |  |  |
| VisibleInNet | `bool` | bazodanowe | Widoczny w Net | Czy załącznik jest widoczny z poziomu Net |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AttachmentStorage (`Db.AttachmentStorage`)
- `MainDb` = 1 — Operacyjna baza danych
- `Folder` = 2 — Folder
- `FolderZabezpieczony` = 3

### AttachmentType (`Db.AttachmentType`)
- `Attachments` = 1 — Załącznik
- `Note` = 2 — Notatka

### SubTypeType (`Db.SubTypeType`)
- `None` = 0 — Brak
- `Picture` = 1 — Obraz
- `Text` = 2 — Tekst
- `Document` = 3 — Dokument
- `Audio` = 4 — Muzyka
- `Video` = 5 — Film
- `Binary` = 6 — Binarny
- `Compressed` = 7 — Archiwum
- `Http` = 8 — Strona WWW
- `Https` = 9 — Bezpieczna strona WWW
