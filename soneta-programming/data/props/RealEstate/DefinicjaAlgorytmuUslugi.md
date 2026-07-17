# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.Config.DefinicjaAlgorytmuUslugi`
Nazwa tabeli: `DefAlgUslug`
Tytuł: Definicje algorytmów usług nieruchomości
Opis: Słownik algorytmów naliczania opłat za usługi nieruchomości. Definiuje reguły obliczeniowe (w postaci kodu) stosowane przy wyliczaniu wartości usług, np. algorytmy proporcjonalnego podziału kosztów mediów między lokale.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytm | `bool` |  |  |  |
| AlgorytmUslugi | `Soneta.RealEstate.AlgorytmUslugi` | bazodanowe |  | Algorytm dla definicji algorytmu usługi nieruchomości |
| AlgorytmUslugi.Aktywny | `bool` | bazodanowe |  |  |
| AlgorytmUslugi.Kod | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje algorytmu usługi nieruchomości nie będą wyświetlane w liście wyboru. |
| ClassName | `string` |  |  |  |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| KodAlgorytmu | `Soneta.Business.MemoText` |  |  |  |
| Namespace | `object` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa algorytmu usługi nieruchomości |
| Opis | `string` | bazodanowe | Opis | Opis definicji algorytmu usługi nieruchomości |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
