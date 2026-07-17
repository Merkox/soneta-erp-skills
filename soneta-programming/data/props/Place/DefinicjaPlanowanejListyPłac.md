# Pola i właściwości klasy biznesowej: `Soneta.Place.DefinicjaPlanowanejListyPłac`
Nazwa tabeli: `DefPlanListPlac`
Tytuł: Definicje planowanych list płac
Opis: Szablon planowanej listy płac służącej do naliczania rezerw urlopowych i innych zobowiązań. Definiuje powiązanie z elementem wynagrodzenia, algorytm naliczania oraz numerację dokumentów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IDefinicjaDokumentuOA`, `IRightsSource`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaED | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja planowanej listy płac w ewidencji dokumentów |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| KonfiguracjaOpisuAnalitycznego | `Soneta.Core.KonfiguracjaOpisuAnalitycznego` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Symbol | `string` | bazodanowe |  |  |
