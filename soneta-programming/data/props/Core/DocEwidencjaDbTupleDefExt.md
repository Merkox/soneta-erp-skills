# Pola i właściwości klasy biznesowej: `Soneta.Core.DbTuples.Processes.DocEwidencjaDbTupleDefExt`
Nazwa tabeli: `DEDbTupleDefExts`
Tytuł: Rozszerzenia definicji tupli dla tabeli DokEwidencja
Opis: Element szczegółowy definicji dokumentu dodatkowego (DbTupleDefinition). Rozszerzenie konfiguracji specyficzne dla dokumentów ewidencji, zawierające powiązanie z definicją procesu workflow.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DbTupleDefinition` → `DbTupleDefinition`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseClassWarning | `string` | tylko-odczyt |  |  |
| DbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DefinicjaProcesu | `IDependentWfDefinition` | bazodanowe |  |  |
| DodawanyNaDokumentach | `bool` |  |  |  |
