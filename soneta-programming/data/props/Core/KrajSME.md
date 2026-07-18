# Pola i właściwości klasy biznesowej: `Soneta.Core.KrajSME`
Nazwa tabeli: `KrajeSME`
Tytuł: Kraje SME
Opis: Konfiguracja kraju uczestniczącego w procedurze SME (Small and Medium Enterprises) dla celów VAT w UE. Powiązanie z krajem ze słownika krajów.
Tabela konfiguracyjna: Tak
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `ProceduraSME`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Historia | `HistorySubTable<Soneta.Core.ProceduraSME>` | podlista |  |  |
| Kraj | `Soneta.Core.KrajTbl` | bazodanowe | Kraj |  |
