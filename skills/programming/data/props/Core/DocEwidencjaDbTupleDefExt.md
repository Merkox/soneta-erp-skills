# Pola i właściwości klasy biznesowej: `Soneta.Core.DbTuples.Processes.DocEwidencjaDbTupleDefExt`
Nazwa tabeli: `DEDbTupleDefExts`
Tytuł: Rozszerzenia definicji tupli dla tabeli DokEwidencja
Opis: Element szczegółowy definicji dokumentu dodatkowego (DbTupleDefinition). Rozszerzenie konfiguracji specyficzne dla dokumentów ewidencji, zawierające powiązanie z definicją procesu workflow.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DbTupleDefinition` → `DbTupleDefinition`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseClassWarning | `string` | tylko-odczyt |  |  |
| DbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DefinicjaProcesu | `IDependentWfDefinition` | bazodanowe |  |  |
| DodawanyNaDokumentach | `bool` |  |  |  |
