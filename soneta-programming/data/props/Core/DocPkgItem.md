# Pola i właściwości klasy biznesowej: `Soneta.Core.DocPkgItem`
Nazwa tabeli: `DocPkgItems`
Tytuł: Pozycje paczki dokumentów
Opis: Tabela przechowuje pozycje paczek dokumentów. Każda pozycja powiązana jest z paczką, określa typ rekordu, stan przetworzenia algorytmem zewnętrznym oraz etap procesu analizowania dokumentu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AnalysingState | `Soneta.Business.Db.DocPkgItemAnalysingState` | bazodanowe, enum | Etap analizy | Etap procesu analizowania dokumentu |
| Attachment | `Soneta.Business.Db.Attachment` |  |  |  |
| Attribute | `Soneta.Business.Row` |  |  |  |
| BackColor | `System.Drawing.Color` |  |  |  |
| Category | `Soneta.Core.DocPkgCfg` | bazodanowe | Kategoria | Kategoria elementu |
| DateTime | `System.DateTime` |  |  |  |
| Description | `string` | bazodanowe | Opis | Opis |
| DestItemGuid | `System.Guid` | bazodanowe | Identyfikator obiektu docelowego | Identyfikator obiektu docelowego |
| DestItemTable | `string` | bazodanowe | Tabela obiektu docelowego | Tabela obiektu docelowego |
| DocPkg | `Soneta.Core.DocPkg` | bazodanowe |  | Paczka dokumentów, do którego należy ta pozycja |
| Flags | `Soneta.Business.Db.DocPkgItemFlags` | bazodanowe, enum | Flagi |  |
| ForeColor | `System.Drawing.Color` |  |  |  |
| GetRequestCounter | `int` | bazodanowe | Licznik odbioru | Licznik prób odbioru przetworzonych danych z systemu zewnętrznego |
| IsAttachmentItemSource | `bool` |  |  |  |
| ItemAttribute | `Soneta.Core.DocPkgItemProp` | bazodanowe |  | Atrybut |
| ItemSource | `Soneta.Business.Db.IDocPkgItemSource` | bazodanowe | Referencja do obiektu źródła danych |  |
| ItemSourceName | `string` |  |  |  |
| ItemType | `Soneta.Core.PkgItemType` | bazodanowe, enum | Typ rekordu |  |
| ItemTypeMobileString | `string` |  |  |  |
| LastError | `Soneta.Business.MemoText` | bazodanowe | Błąd | Ostatni błąd przetwarzania elementu paczki |
| LastValidationError | `string` |  |  |  |
| OrderId | `string` | bazodanowe | Identyfikator przetwarzania | Identyfikator przetwarzania |
| Parent | `Soneta.Business.IRow` |  |  |  |
| ParentCreateDate | `Soneta.Types.Date` |  |  |  |
| ProcessingState | `Soneta.Business.Db.DocPkgItemProcessingState` | bazodanowe, enum | Stan przetworzenia | Stan przetworzenia algorytmem zewnętrznym |
| SendRequestCounter | `int` | bazodanowe | Licznik wysyłki | Licznik prób wysyłki dokumentu do systemu zewnętrznego |
| ValidationState | `Soneta.Core.PkgItemValidationState` | enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DocPkgItemAnalysingState (`Soneta.Business.Db.DocPkgItemAnalysingState`)
- `Unknown` = 0 — Oczekuje
- `Sent` = 100 — Wysłany
- `Received` = 200 — Odebrany

### DocPkgItemFlags (`Soneta.Business.Db.DocPkgItemFlags`)
- `Manual` = 1 — Obsługa manualna
- `RunOuterSystemOCR` = 2 — Uruchom proces OCR w systemie zew.

### DocPkgItemProcessingState (`Soneta.Business.Db.DocPkgItemProcessingState`)
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
