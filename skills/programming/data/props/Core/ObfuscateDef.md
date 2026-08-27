# Pola i właściwości klasy biznesowej: `Soneta.Core.ObfuscateDef`
Nazwa tabeli: `ObfuscateDefs`
Tytuł: Definicje zakresów zaciemniania
Opis: Definicja zakresu zaciemniania (anonimizacji) danych osobowych. Określa nazwę, tabelę docelową, rodzaj anonimizacji, opis, warunek stosowania oraz flagę domyślności. Służy do realizacji prawa do bycia zapomnianym wg RODO.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConditionText | `string` | bazodanowe |  |  |
| Default | `bool` | bazodanowe |  |  |
| Description | `string` | bazodanowe | Opis |  |
| Fields | `SubTable<Soneta.Core.ObfuscateField>` | podlista |  |  |
| IsAnalyze | `bool` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| ObfuscateType | `Soneta.Core.ObfuscateType` (enum) | bazodanowe, tylko-odczyt | Rodzaj anonimizacji |  |
| TableName | `string` | bazodanowe, tylko-odczyt | Nazwa tabeli |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ObfuscateType (`Soneta.Core.ObfuscateType`)
- `Anonimizacja` = 1
- `Pseudonimizacja` = 2
- `AnalizaSerwisowa` = 3
- `Wszystkie` = 0 — (Wszystkie)
