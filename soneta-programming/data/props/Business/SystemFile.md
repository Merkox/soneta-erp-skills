# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.SystemFile`
Nazwa tabeli: `SystemFiles`
Tytuł: Systemowe pliki dodatkowe
Opis: Plik systemowy przechowywany w bazie danych, taki jak szablon wydruku, skrypt lub definicja UI. Obsługuje dziedziczenie z pliku bazowego i wersjonowanie.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `FileType` (`Db.SystemFileTypes`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseFile | `Db.SystemFile` | bazodanowe |  |  |
| Code | `MemoText` | bazodanowe, podlista |  |  |
| CodeEditorSource | `Compiler.ICodeEditorSource` |  |  |  |
| FileType | `Db.SystemFileTypes` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| ImplementationType | `System.Type` | tylko-odczyt |  |  |
| Locked | `bool` | bazodanowe | Zablokowane |  |
| Name | `string` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `FileType`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `DxSnippet` | 1 | `Db.DxSnippetFile` |  |
| `Snippet` | 2 | `Db.SnippetFile` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SystemFileTypes (`Db.SystemFileTypes`)
- `DxSnippet` = 1
- `Snippet` = 2
