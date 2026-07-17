# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.SystemFile`
Nazwa tabeli: `SystemFiles`
Tytuł: Systemowe pliki dodatkowe
Opis: Plik systemowy przechowywany w bazie danych, taki jak szablon wydruku, skrypt lub definicja UI. Obsługuje dziedziczenie z pliku bazowego i wersjonowanie.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseFile | `Soneta.Business.Db.SystemFile` | bazodanowe |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| CodeEditorSource | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| FileType | `Soneta.Business.Db.SystemFileTypes` | bazodanowe, enum |  |  |
| ImplementationType | `System.Type` |  |  |  |
| Locked | `bool` | bazodanowe | Zablokowane |  |
| Name | `string` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SystemFileTypes (`Soneta.Business.Db.SystemFileTypes`)
- `DxSnippet` = 1
- `Snippet` = 2
