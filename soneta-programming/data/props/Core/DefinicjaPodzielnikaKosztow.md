# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaPodzielnikaKosztow`
Nazwa tabeli: `DefPodzKosztow`
Tytuł: Definicje podzielników kosztów
Opis: Definicja algorytmu podzielnika kosztów. Określa nazwę, typ informacji o podziale, algorytm kalkulacji, flagę blokady i domyślności oraz wymaganie unikalności elementów podziałowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 4
- subrowy: 1
- razem: 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `MemoText` | bazodanowe, podlista |  |  |
| ClassName | `string` | tylko-odczyt |  |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Domyslna | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| TabelaPodzielnika | `Table` | podlista |  | Tabela danych, której obiekty biorą udział w podziale. |
| TabelaPodzielnikaItem | `Db.TableContext.TableItem` |  | Tabela podzielnika | Tabela danych, której obiekty biorą udział w podziale. |
| TypeInformation | `string` | bazodanowe |  |  |
| UnikalnoscElementowPodzialowych | `bool` | bazodanowe |  |  |
| Zablokowane | `bool` | bazodanowe |  |  |
