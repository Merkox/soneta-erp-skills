# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.DefinicjaSlownika`
Nazwa tabeli: `DefSlownikow`
Tytuł: Definicje słowników
Opis: Definicja słownika analitycznego używanego w planie kont do automatycznego tworzenia kont analitycznych. Określa nazwę słownika, powiązane tabele źródłowe oraz algorytm generowania symboli kont. Słowniki mogą być kontrolne i służą do klasyfikacji elementów księgowalnych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `MemoText` | bazodanowe, podlista |  |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| DictionaryWithAlgorithm | `bool` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| DostepneTabele | `System.Collections.Generic.IList<Table>` | podlista |  |  |
| Elementy | `LpSubTable<Soneta.Ksiega.ElemDefinicjiSlownika>` | podlista |  |  |
| ElementySlownika | `SubTable<Soneta.Ksiega.ElemSlownika>` | podlista |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SlownikKontrolny | `bool` | bazodanowe |  |  |
| Tabele | `System.Collections.Generic.IList<Table>` | podlista |  |  |
| tabele | `string` | bazodanowe |  |  |
