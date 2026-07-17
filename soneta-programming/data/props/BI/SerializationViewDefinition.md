# Pola i właściwości klasy biznesowej: `Soneta.BI.SerializationViewDefinition`
Nazwa tabeli: `SerialViewDefs`
Tytuł: Definicje utrwalania list
Opis: Definicja utrwalania widoku listy do tabeli BI. Określa tabelę źródłową, folder, typ widoku oraz tabelę docelową, do której zapisywane są dane z listy. Służy do okresowego eksportowania danych z widoków aplikacji do struktury analitycznej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Description | `string` | bazodanowe | Opis | Opis objaśniający zawartość definicji utrwalania listy |
| FolderPath | `string` | bazodanowe | Ścieżka | Ścieżka do folderu źródłowego |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji utrwalania listy |
| Ranges | `Soneta.Business.SubTable<Soneta.BI.SerializationViewRange>` |  |  |  |
| SortOrder | `string` | bazodanowe | Sortowanie |  |
| TableDefinition | `Soneta.BI.TableDefinition` | bazodanowe | Definicja tabeli | Definicja tabeli docelowej |
| TableSource | `string` | bazodanowe | Tabela źródłowa | Nazwa tabeli źródłowej |
| ViewInfoTypeName | `string` | bazodanowe | Typ widoku | Typ widoku definiującego listę |
