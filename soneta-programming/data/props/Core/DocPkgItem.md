# Pola i właściwości klasy biznesowej: `Soneta.Core.DocPkgItem`
Nazwa tabeli: `DocPkgItems`
Tytuł: Pozycje paczki dokumentów
Opis: Tabela przechowuje pozycje paczek dokumentów. Każda pozycja powiązana jest z paczką, określa typ rekordu, stan przetworzenia algorytmem zewnętrznym oraz etap procesu analizowania dokumentu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 11
- podlisty: 1
- subrowy: 0
- razem: 27

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AnalysingState | `Db.DocPkgItemAnalysingState` (enum) | bazodanowe | Etap analizy | Etap procesu analizowania dokumentu |
| Attachment | `Db.Attachment` | tylko-odczyt |  |  |
| Attribute | `Row` |  |  |  |
| BackColor | `System.Drawing.Color` | tylko-odczyt |  |  |
| Category | `Soneta.Core.DocPkgCfg` | bazodanowe | Kategoria | Kategoria elementu |
| DateTime | `System.DateTime` | tylko-odczyt |  |  |
| Description | `string` | bazodanowe | Opis | Opis |
| DestItemGuid | `System.Guid` | bazodanowe | Identyfikator obiektu docelowego | Identyfikator obiektu docelowego |
| DestItemTable | `string` | bazodanowe | Tabela obiektu docelowego | Tabela obiektu docelowego |
| DocPkg | `Soneta.Core.DocPkg` | bazodanowe, tylko-odczyt |  | Paczka dokumentów, do którego należy ta pozycja |
| Flags | `Db.DocPkgItemFlags` (enum) | bazodanowe | Flagi |  |
| ForeColor | `System.Drawing.Color` | tylko-odczyt |  |  |
| GetRequestCounter | `int` | bazodanowe | Licznik odbioru | Licznik prób odbioru przetworzonych danych z systemu zewnętrznego |
| IsAttachmentItemSource | `bool` | tylko-odczyt |  |  |
| ItemAttribute | `Soneta.Core.DocPkgItemProp` | bazodanowe |  | Atrybut |
| ItemSource | `Db.IDocPkgItemSource` | bazodanowe | Referencja do obiektu źródła danych |  |
| ItemSourceName | `string` | tylko-odczyt |  |  |
| ItemType | `Soneta.Core.PkgItemType` (enum) | bazodanowe | Typ rekordu |  |
| ItemTypeMobileString | `string` | tylko-odczyt |  |  |
| LastError | `MemoText` | bazodanowe, podlista | Błąd | Ostatni błąd przetwarzania elementu paczki |
| LastValidationError | `string` | tylko-odczyt |  |  |
| OrderId | `string` | bazodanowe | Identyfikator przetwarzania | Identyfikator przetwarzania |
| Parent | `IRow` | tylko-odczyt |  |  |
| ParentCreateDate | `Date` | tylko-odczyt |  |  |
| ProcessingState | `Db.DocPkgItemProcessingState` (enum) | bazodanowe | Stan przetworzenia | Stan przetworzenia algorytmem zewnętrznym |
| SendRequestCounter | `int` | bazodanowe | Licznik wysyłki | Licznik prób wysyłki dokumentu do systemu zewnętrznego |
| ValidationState | `Soneta.Core.PkgItemValidationState` (enum) |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DocPkgItemAnalysingState (`Db.DocPkgItemAnalysingState`)
- `Unknown` = 0 — Oczekuje
- `Sent` = 100 — Wysłany
- `Received` = 200 — Odebrany

### DocPkgItemFlags (`Db.DocPkgItemFlags`)
- `Manual` = 1 — Obsługa manualna
- `RunOuterSystemOCR` = 2 — Uruchom proces OCR w systemie zew.

### DocPkgItemProcessingState (`Db.DocPkgItemProcessingState`)
- `Unprocessed` = 0 — Nieprzetworzony
- `ToBeProcessed` = 100 — Do przetworzenia
- `Processing` = 200 — Przetwarzanie
- `Processed` = 300 — Przetworzony
- `Generating` = 350 — Generowanie dokumentu
- `Generated` = 400 — Wygenerowano dokument
- `GeneratedWithError` = 900 — Wygenerowano pomimo błędu
- `Error` = 1000 — Błąd
- `Canceled` = 1100 — Anulowano

### PkgItemType (`Soneta.Core.PkgItemType`)
- `Unknown` = 0 — Nieznany
- `Attachment` = 1 — Załącznik
- `KSeF` = 2 — Plik KSeF
- `RegisterDocument` = 3 — Dokument ewidencji

### PkgItemValidationState (`Soneta.Core.PkgItemValidationState`)
- `Success` = 0
- `Warning` = 10
