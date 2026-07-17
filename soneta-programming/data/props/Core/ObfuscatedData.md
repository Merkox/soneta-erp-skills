# Pola i właściwości klasy biznesowej: `Soneta.Core.ObfuscatedData`
Nazwa tabeli: `ObfuscatedDatas`
Tytuł: Zaciemnione dane
Opis: Rekord zaciemnionych (zanonimizowanych) danych osobowych. Przechowuje informację o zaciemnionym obiekcie (tabela, GUID), zakodowane oryginalne dane, sumę kontrolną, daty i operatorów delegowania i wykonania anonimizacji oraz status procesu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CheckSum | `string` | bazodanowe |  |  |
| CodedData | `Soneta.Business.MemoBin` | bazodanowe |  |  |
| DelegatingDateTime | `System.DateTime` | bazodanowe |  |  |
| DelegatingOperator | `System.Guid` | bazodanowe |  |  |
| IsRangeDefined | `bool` |  |  |  |
| ObfuscateStatus | `Soneta.Core.ObfuscateStatus` | bazodanowe, enum |  |  |
| ObfuscateType | `Soneta.Core.ObfuscateType` | bazodanowe, enum |  |  |
| ObfuscatingDateTime | `System.DateTime` | bazodanowe |  |  |
| ObfuscatingOperator | `System.Guid` | bazodanowe |  |  |
| Range | `System.Guid` | bazodanowe | Guid szablonu |  |
| RangeDefinition | `Soneta.Core.ObfuscateDef` |  |  |  |
| SubjectGuid | `System.Guid` | bazodanowe | Klucz obcy tabeli obfuskowanej |  |
| SubjectTable | `string` | bazodanowe | Tabela obiektu obfuskowanego |  |

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
