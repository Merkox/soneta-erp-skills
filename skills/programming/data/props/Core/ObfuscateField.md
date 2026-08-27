# Pola i właściwości klasy biznesowej: `Soneta.Core.ObfuscateField`
Nazwa tabeli: `ObfuscateFields`
Tytuł: Elementy zakresów zaciemniania
Opis: Element szczegółowy definicji zaciemniania (ObfuscateDef). Określa konkretną właściwość (pole) obiektu, która podlega anonimizacji, wraz z dodatkową opcją sposobu zaciemniania.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `ObfuscateDef` → `ObfuscateDef`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ObfuscateDef | `Soneta.Core.ObfuscateDef` | bazodanowe, guided-parent | Zakres |  |
| Option | `Soneta.Core.ObfuscateOption` (enum) | bazodanowe | Dodatkowa opcja |  |
| Path | `string` | bazodanowe | Właściwość |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ObfuscateOption (`Soneta.Core.ObfuscateOption`)
- `ObfuscateField` = 0 — Właściwość
- `ObfuscateAttachments` = 1 — Załącznik
- `ObfuscateChangeInfos` = 2 — Historia zmian
- `ObfuscateNote` = 3 — Notatka
