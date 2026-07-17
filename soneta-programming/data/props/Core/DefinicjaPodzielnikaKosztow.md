# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaPodzielnikaKosztow`
Nazwa tabeli: `DefPodzKosztow`
Tytuł: Definicje podzielników kosztów
Opis: Definicja algorytmu podzielnika kosztów. Określa nazwę, typ informacji o podziale, algorytm kalkulacji, flagę blokady i domyślności oraz wymaganie unikalności elementów podziałowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ClassName | `string` |  |  |  |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Domyslna | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| TabelaPodzielnika | `Soneta.Business.Table` |  |  | Tabela danych, której obiekty biorą udział w podziale. |
| TabelaPodzielnikaItem | `Soneta.Business.Db.TableContext.TableItem` |  | Tabela podzielnika | Tabela danych, której obiekty biorą udział w podziale. |
| TypeInformation | `string` | bazodanowe |  |  |
| UnikalnoscElementowPodzialowych | `bool` | bazodanowe |  |  |
| Zablokowane | `bool` | bazodanowe |  |  |
