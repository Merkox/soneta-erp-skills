# Pola i właściwości klasy biznesowej: `Soneta.Core.KrajSME`
Nazwa tabeli: `KrajeSME`
Tytuł: Kraje SME
Opis: Konfiguracja kraju uczestniczącego w procedurze SME (Small and Medium Enterprises) dla celów VAT w UE. Powiązanie z krajem ze słownika krajów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 1
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Historia | `Soneta.Business.HistorySubTable<Soneta.Core.ProceduraSME>` |  |  |  |
| Kraj | `Soneta.Core.KrajTbl` | bazodanowe | Kraj |  |
