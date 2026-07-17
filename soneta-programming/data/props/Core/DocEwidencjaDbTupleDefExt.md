# Pola i właściwości klasy biznesowej: `Soneta.Core.DbTuples.Processes.DocEwidencjaDbTupleDefExt`
Nazwa tabeli: `DEDbTupleDefExts`
Tytuł: Rozszerzenia definicji tupli dla tabeli DokEwidencja
Opis: Element szczegółowy definicji dokumentu dodatkowego (DbTupleDefinition). Rozszerzenie konfiguracji specyficzne dla dokumentów ewidencji, zawierające powiązanie z definicją procesu workflow.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DbTupleDefinition` → `DbTupleDefinition`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseClassWarning | `string` |  |  |  |
| DbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe, guided-parent |  |  |
| DefinicjaProcesu | `Soneta.Business.IDependentWfDefinition` | bazodanowe |  |  |
| DodawanyNaDokumentach | `bool` |  |  |  |
