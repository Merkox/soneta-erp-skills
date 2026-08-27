# Pola i właściwości klasy biznesowej: `Soneta.Business.Compiler.RuntimeSolution`
Nazwa tabeli: `RuntimeSolutions`
Tytuł: Rozwiązania
Opis: Rozwiązanie (solution) w środowisku runtime. Grupuje projekty kompilowane dynamicznie w ramach jednej przestrzeni nazw.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Branch | `string` |  |  |  |
| CredentialAddress | `string` |  |  |  |
| Description | `string` | bazodanowe | Opis |  |
| LocalPath | `string` |  |  |  |
| Namespace | `string` | tylko-odczyt |  |  |
| Projects | `SubTable<Compiler.RuntimeProject>` | podlista |  |  |
| RepositoryLocation | `string` |  |  |  |
| SolutionNamespace | `string` | bazodanowe | Przestrzeń nazw |  |
