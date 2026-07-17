# Pola i właściwości klasy biznesowej: `Soneta.Core.ManagedRowCreator`
Nazwa tabeli: `ManagedRowCrts`
Tytuł: Kreatory wierszy
Opis: Element szczegółowy definicji zarządzanego wiersza (IManagedRowDefinion). Powiązuje definicję z kreatorem dokumentu dodatkowego, określając uprawnienia do tworzenia (kreator, kreator seryjny) i modyfikacji (modyfikator, modyfikator seryjny).
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `IManagedRowDefinion`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Core.IManagedRowDefinion` | bazodanowe, guided-parent, iface-ref | Wymaganie |  |
| DefinicjaDokumentu | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja dokumentu |  |
| Enabled | `bool` |  |  |  |
| Kreator | `bool` | bazodanowe |  |  |
| KreatorSeryjny | `bool` | bazodanowe |  |  |
| Modyfikator | `bool` | bazodanowe |  |  |
| ModyfikatorSeryjny | `bool` | bazodanowe |  |  |
| ParentType | `System.Type` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definicja | `IManagedRowDefinion` | `DbTupleDefinition`, `DefZadania`, `DefinicjaBadaniaLekarskiego`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia` |
