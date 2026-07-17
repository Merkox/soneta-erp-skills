# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.DefinicjaSlownika`
Nazwa tabeli: `DefSlownikow`
Tytuł: Definicje słowników
Opis: Definicja słownika analitycznego używanego w planie kont do automatycznego tworzenia kont analitycznych. Określa nazwę słownika, powiązane tabele źródłowe oraz algorytm generowania symboli kont. Słowniki mogą być kontrolne i służą do klasyfikacji elementów księgowalnych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Business.MemoText` | bazodanowe |  |  |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| DictionaryWithAlgorithm | `bool` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| DostepneTabele | `System.Collections.Generic.IList<Soneta.Business.Table>` |  |  |  |
| Elementy | `Soneta.Business.LpSubTable<Soneta.Ksiega.ElemDefinicjiSlownika>` |  |  |  |
| ElementySlownika | `Soneta.Business.SubTable<Soneta.Ksiega.ElemSlownika>` |  |  |  |
| Kod | `string` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SlownikKontrolny | `bool` | bazodanowe |  |  |
| Tabele | `System.Collections.Generic.IList<Soneta.Business.Table>` |  |  |  |
| tabele | `string` | bazodanowe |  |  |
