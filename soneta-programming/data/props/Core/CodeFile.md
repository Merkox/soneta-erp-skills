# Pola i właściwości klasy biznesowej: `Soneta.Core.CodeFile`
Nazwa tabeli: `CodeFiles`
Tytuł: Dodatkowy kod do kompilacji
Opis: Dodatkowy plik kodu źródłowego do kompilacji dynamicznej. Przechowuje nazwę, treść kodu, flagę blokady i powiązanie z hostem (np. definicją dokumentu dodatkowego). Wykorzystywany do rozszerzeń logiki biznesowej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Core.ICodeFileHost` | bazodanowe, iface-ref |  |  |
| Identifier | `string` |  |  |  |
| Locked | `bool` | bazodanowe | Zablokowane |  |
| Name | `string` | bazodanowe |  |  |
| Namespace | `string` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Text | `Soneta.Business.MemoText` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `ICodeFileHost` | `DbTupleDefinition`, `DiscussionPlugInsSet`, `WFDefinition`, `WfPlugIn` |
