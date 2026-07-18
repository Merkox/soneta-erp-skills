# Pola i właściwości klasy biznesowej: `Soneta.Core.StrukturaOrganizacyjna`
Nazwa tabeli: `StrukturyOrg`
Tytuł: Struktury organizacyjne
Opis: Definicja struktury organizacyjnej firmy (np. dział, zespół, projekt). Określa nazwę, historyczność, ekskluzywność powiązań, algorytm, kontrolę praw dostępu oraz konfigurację zakładek użytkownika i elementów struktury.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IStrukturaOrganizacyjna`

- pola bazodanowe (zapisywalne): 11
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 8
- subrowy: 1
- razem: 23

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `MemoText` | bazodanowe, podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjeElementów | `SubTable<Soneta.Core.DefinicjaElementuStrukturyOrganizacyjnej>` | podlista |  |  |
| Ekskluzywnosc | `bool` | bazodanowe | Ekskluzywność powiązań | Określa czy powiązania struktury organizacyjnej mogą wystąpić kilka razy dla tej struktury |
| ElementCode | `MemoText` | bazodanowe, podlista |  |  |
| ElementConfigType | `System.Type` | tylko-odczyt |  |  |
| ElementXml | `MemoText` | bazodanowe, podlista |  |  |
| Elementy | `SubTable` | podlista |  |  |
| HistoriaPodleglosci | `bool` | bazodanowe | Historia podległości | Określa czy definicja ma przechowywać historię struktury |
| Historycznosc | `bool` | bazodanowe | Historyczność | Określa czy definicja ma przechowywać historię struktury |
| KontrolaPraw | `Soneta.Oceny.TableRef` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| OkresPowiazania | `bool` | bazodanowe | Okres powiązania | Określa czy powiązanie ma obsługiwać okres ważności. |
| PublikujWDrzewie | `bool` | bazodanowe | Publikuj w drzewie | Określa czy definicja ma zostać opublikowana w folderze Struktury |
| Root | `Soneta.Core.ElementStrukturyOrganizacyjnej` | tylko-odczyt |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Systemowa | `bool` | bazodanowe, tylko-odczyt | Struktura systemowa | Struktura jest w całości zarządzana z poziomu kodu i niedostępna na oknach. |
| WszystkieElementy | `SubTable` | podlista |  |  |
| Xml | `MemoText` | bazodanowe, podlista | Definicja zakładki użytkownika. |  |
