# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.SystemFile`
Nazwa tabeli: `SystemFiles`
Tytuł: Systemowe pliki dodatkowe
Opis: Plik systemowy przechowywany w bazie danych, taki jak szablon wydruku, skrypt lub definicja UI. Obsługuje dziedziczenie z pliku bazowego i wersjonowanie.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 1
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseFile | `Db.SystemFile` | bazodanowe |  |  |
| Code | `MemoText` | bazodanowe, podlista |  |  |
| CodeEditorSource | `Compiler.ICodeEditorSource` |  |  |  |
| FileType | `Db.SystemFileTypes` (enum) | bazodanowe, tylko-odczyt |  |  |
| ImplementationType | `System.Type` | tylko-odczyt |  |  |
| Locked | `bool` | bazodanowe | Zablokowane |  |
| Name | `string` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SystemFileTypes (`Db.SystemFileTypes`)
- `DxSnippet` = 1
- `Snippet` = 2
