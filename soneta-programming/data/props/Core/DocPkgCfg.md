# Pola i właściwości klasy biznesowej: `Soneta.Core.DocPkgCfg`
Nazwa tabeli: `DocPkgCfgs`
Tytuł: Kategoria elementu paczki dokumentów
Opis: Tabela konfiguracyjna przechowująca kategorie elementów paczek dokumentów. Definiuje dostępne kategorie z ich nazwami, klasami obiektów docelowych oraz wskazaniem kategorii domyślnej dla danego typu konfiguracji.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blocked | `bool` | bazodanowe | Blokada kategorii |  |
| CfgType | `Soneta.Core.PkgCfgType` (enum) | bazodanowe | Typ kategorii |  |
| Default | `bool` | bazodanowe | Domyślna | Określa czy kategoria jest kategorią domyślną |
| Flags | `Db.DocPkgCfgFlags` (enum) | bazodanowe | Flagi |  |
| KBOnly | `bool` | bazodanowe | Przeznaczona dla pulpitu KB |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa wyświetlana kategorii |
| TableName | `string` | bazodanowe | Klasa | Klasa obiektu docelowego |
| XmlSource | `MemoText` | bazodanowe, podlista | Dane kategorii | Zapis konfiguracji danych kategorii określonych przez użytkownika systemu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DocPkgCfgFlags (`Db.DocPkgCfgFlags`)

### PkgCfgType (`Soneta.Core.PkgCfgType`)
- `Attachment` = 0 — Załącznik
- `KSeF` = 1 — Plik KSeF
- `RegistDocument` = 2 — Ewidencja
