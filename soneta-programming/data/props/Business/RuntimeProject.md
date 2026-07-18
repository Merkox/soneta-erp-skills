# Pola i właściwości klasy biznesowej: `Soneta.Business.Compiler.RuntimeProject`
Nazwa tabeli: `RuntimeProjects`
Tytuł: Projekty
Opis: Projekt w środowisku runtime zawierający kod kompilowany dynamicznie. Należy do rozwiązania i posiada własną przestrzeń nazw oraz zależności.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Description | `string` | bazodanowe | Opis |  |
| ModuleName | `string` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Namespace | `string` | tylko-odczyt |  |  |
| ProjectNamespace | `string` | bazodanowe, tylko-odczyt | Przestrzeń nazw |  |
| References | `SubTable<Compiler.RuntimeProjectReference>` | podlista |  |  |
| Solution | `Compiler.RuntimeSolution` | bazodanowe, tylko-odczyt | Rozwiązanie |  |
| VersionNumber | `int` | tylko-odczyt |  |  |
