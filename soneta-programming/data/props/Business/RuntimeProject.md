# Pola i właściwości klasy biznesowej: `Soneta.Business.Compiler.RuntimeProject`
Nazwa tabeli: `RuntimeProjects`
Tytuł: Projekty
Opis: Projekt w środowisku runtime zawierający kod kompilowany dynamicznie. Należy do rozwiązania i posiada własną przestrzeń nazw oraz zależności.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Description | `string` | bazodanowe | Opis |  |
| ModuleName | `string` |  |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Namespace | `string` |  |  |  |
| ProjectNamespace | `string` | bazodanowe | Przestrzeń nazw |  |
| References | `Soneta.Business.SubTable<Soneta.Business.Compiler.RuntimeProjectReference>` |  |  |  |
| Solution | `Soneta.Business.Compiler.RuntimeSolution` | bazodanowe | Rozwiązanie |  |
| VersionNumber | `int` |  |  |  |
