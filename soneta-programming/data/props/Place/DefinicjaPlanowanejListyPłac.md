# Pola i właściwości klasy biznesowej: `Soneta.Place.DefinicjaPlanowanejListyPłac`
Nazwa tabeli: `DefPlanListPlac`
Tytuł: Definicje planowanych list płac
Opis: Szablon planowanej listy płac służącej do naliczania rezerw urlopowych i innych zobowiązań. Definiuje powiązanie z elementem wynagrodzenia, algorytm naliczania oraz numerację dokumentów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IDefinicjaDokumentuOA`, `IRightsSource`

- pola bazodanowe (zapisywalne): 11
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 2
- razem: 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `MemoText` | bazodanowe, podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaED | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja planowanej listy płac w ewidencji dokumentów |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| KonfiguracjaOpisuAnalitycznego | `Soneta.Core.KonfiguracjaOpisuAnalitycznego` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Symbol | `string` | bazodanowe |  |  |
