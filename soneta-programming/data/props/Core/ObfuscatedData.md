# Pola i właściwości klasy biznesowej: `Soneta.Core.ObfuscatedData`
Nazwa tabeli: `ObfuscatedDatas`
Tytuł: Zaciemnione dane
Opis: Rekord zaciemnionych (zanonimizowanych) danych osobowych. Przechowuje informację o zaciemnionym obiekcie (tabela, GUID), zakodowane oryginalne dane, sumę kontrolną, daty i operatorów delegowania i wykonania anonimizacji oraz status procesu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 0
- subrowy: 0
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CheckSum | `string` | bazodanowe |  |  |
| CodedData | `MemoBin` | bazodanowe |  |  |
| DelegatingDateTime | `System.DateTime` | bazodanowe |  |  |
| DelegatingOperator | `System.Guid` | bazodanowe |  |  |
| IsRangeDefined | `bool` | tylko-odczyt |  |  |
| ObfuscateStatus | `Soneta.Core.ObfuscateStatus` (enum) | bazodanowe |  |  |
| ObfuscateType | `Soneta.Core.ObfuscateType` (enum) | bazodanowe, tylko-odczyt |  |  |
| ObfuscatingDateTime | `System.DateTime` | bazodanowe |  |  |
| ObfuscatingOperator | `System.Guid` | bazodanowe |  |  |
| Range | `System.Guid` | bazodanowe | Guid szablonu |  |
| RangeDefinition | `Soneta.Core.ObfuscateDef` |  |  |  |
| SubjectGuid | `System.Guid` | bazodanowe, tylko-odczyt | Klucz obcy tabeli obfuskowanej |  |
| SubjectTable | `string` | bazodanowe, tylko-odczyt | Tabela obiektu obfuskowanego |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ObfuscateStatus (`Soneta.Core.ObfuscateStatus`)
- `Anonimised` = 0 — Zanonimizowany
- `Pseudonimised` = 1 — Spseudonimizowany
- `ToAnonimise` = 2 — Do anonimizacji
- `ToPseudonimise` = 3 — Do pseudonimizacji
- `Depseudonimised` = 4 — Odpseudonimizowany
- `Rejected` = 5 — Odrzucony
- `All` = 6 — Razem
- `NotRelated` = 7 — Nie dotyczy

### ObfuscateType (`Soneta.Core.ObfuscateType`)
- `Anonimizacja` = 1
- `Pseudonimizacja` = 2
- `AnalizaSerwisowa` = 3
- `Wszystkie` = 0 — (Wszystkie)
