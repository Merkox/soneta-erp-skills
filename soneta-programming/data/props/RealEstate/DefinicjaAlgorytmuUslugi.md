# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.Config.DefinicjaAlgorytmuUslugi`
Nazwa tabeli: `DefAlgUslug`
Tytuł: Definicje algorytmów usług nieruchomości
Opis: Słownik algorytmów naliczania opłat za usługi nieruchomości. Definiuje reguły obliczeniowe (w postaci kodu) stosowane przy wyliczaniu wartości usług, np. algorytmy proporcjonalnego podziału kosztów mediów między lokale.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 5
- podlisty: 4
- subrowy: 2
- razem: 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytm | `bool` |  |  |  |
| AlgorytmUslugi | `Soneta.RealEstate.AlgorytmUslugi` (subrow) | bazodanowe |  | Algorytm dla definicji algorytmu usługi nieruchomości |
| AlgorytmUslugi.Aktywny | `bool` | bazodanowe |  |  |
| AlgorytmUslugi.Kod | `MemoText` | bazodanowe, podlista |  |  |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje algorytmu usługi nieruchomości nie będą wyświetlane w liście wyboru. |
| ClassName | `string` | tylko-odczyt |  |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| KodAlgorytmu | `MemoText` | podlista |  |  |
| Namespace | `object` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa algorytmu usługi nieruchomości |
| Opis | `string` | bazodanowe | Opis | Opis definicji algorytmu usługi nieruchomości |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
