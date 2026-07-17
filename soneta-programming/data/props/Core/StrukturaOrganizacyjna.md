# Pola i właściwości klasy biznesowej: `Soneta.Core.StrukturaOrganizacyjna`
Nazwa tabeli: `StrukturyOrg`
Tytuł: Struktury organizacyjne
Opis: Definicja struktury organizacyjnej firmy (np. dział, zespół, projekt). Określa nazwę, historyczność, ekskluzywność powiązań, algorytm, kontrolę praw dostępu oraz konfigurację zakładek użytkownika i elementów struktury.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IStrukturaOrganizacyjna`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjeElementów | `Soneta.Business.SubTable<Soneta.Core.DefinicjaElementuStrukturyOrganizacyjnej>` |  |  |  |
| Ekskluzywnosc | `bool` | bazodanowe | Ekskluzywność powiązań | Określa czy powiązania struktury organizacyjnej mogą wystąpić kilka razy dla tej struktury |
| ElementCode | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ElementConfigType | `System.Type` |  |  |  |
| ElementXml | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable` |  |  |  |
| HistoriaPodleglosci | `bool` | bazodanowe | Historia podległości | Określa czy definicja ma przechowywać historię struktury |
| Historycznosc | `bool` | bazodanowe | Historyczność | Określa czy definicja ma przechowywać historię struktury |
| KontrolaPraw | `Soneta.Oceny.TableRef` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| OkresPowiazania | `bool` | bazodanowe | Okres powiązania | Określa czy powiązanie ma obsługiwać okres ważności. |
| PublikujWDrzewie | `bool` | bazodanowe | Publikuj w drzewie | Określa czy definicja ma zostać opublikowana w folderze Struktury |
| Root | `Soneta.Core.ElementStrukturyOrganizacyjnej` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Systemowa | `bool` | bazodanowe | Struktura systemowa | Struktura jest w całości zarządzana z poziomu kodu i niedostępna na oknach. |
| WszystkieElementy | `Soneta.Business.SubTable` |  |  |  |
| Xml | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika. |  |
