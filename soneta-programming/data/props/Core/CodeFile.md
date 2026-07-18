# Pola i właściwości klasy biznesowej: `Soneta.Core.CodeFile`
Nazwa tabeli: `CodeFiles`
Tytuł: Dodatkowy kod do kompilacji
Opis: Dodatkowy plik kodu źródłowego do kompilacji dynamicznej. Przechowuje nazwę, treść kodu, flagę blokady i powiązanie z hostem (np. definicją dokumentu dodatkowego). Wykorzystywany do rozszerzeń logiki biznesowej.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Core.ICodeFileHost` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Identifier | `string` | tylko-odczyt |  |  |
| Locked | `bool` | bazodanowe | Zablokowane |  |
| Name | `string` | bazodanowe |  |  |
| Namespace | `string` | tylko-odczyt |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Text | `MemoText` | bazodanowe, podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `ICodeFileHost` | `DbTupleDefinition`, `DiscussionPlugInsSet`, `WFDefinition`, `WfPlugIn` |
