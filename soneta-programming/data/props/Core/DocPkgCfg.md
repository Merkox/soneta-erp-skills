# Pola i właściwości klasy biznesowej: `Soneta.Core.DocPkgCfg`
Nazwa tabeli: `DocPkgCfgs`
Tytuł: Kategoria elementu paczki dokumentów
Opis: Tabela konfiguracyjna przechowująca kategorie elementów paczek dokumentów. Definiuje dostępne kategorie z ich nazwami, klasami obiektów docelowych oraz wskazaniem kategorii domyślnej dla danego typu konfiguracji.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blocked | `bool` | bazodanowe | Blokada kategorii |  |
| CfgType | `Soneta.Core.PkgCfgType` | bazodanowe, enum | Typ kategorii |  |
| Default | `bool` | bazodanowe | Domyślna | Określa czy kategoria jest kategorią domyślną |
| Flags | `Soneta.Business.Db.DocPkgCfgFlags` | bazodanowe, enum | Flagi |  |
| KBOnly | `bool` | bazodanowe | Przeznaczona dla pulpitu KB |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa wyświetlana kategorii |
| TableName | `string` | bazodanowe | Klasa | Klasa obiektu docelowego |
| XmlSource | `Soneta.Business.MemoText` | bazodanowe | Dane kategorii | Zapis konfiguracji danych kategorii określonych przez użytkownika systemu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DocPkgCfgFlags (`Soneta.Business.Db.DocPkgCfgFlags`)

### PkgCfgType (`Soneta.Core.PkgCfgType`)
- `Attachment` = 0 — Załącznik
- `KSeF` = 1 — Plik KSeF
- `RegistDocument` = 2 — Ewidencja
