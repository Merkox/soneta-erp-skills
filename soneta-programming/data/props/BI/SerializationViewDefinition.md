# Pola i właściwości klasy biznesowej: `Soneta.BI.SerializationViewDefinition`
Nazwa tabeli: `SerialViewDefs`
Tytuł: Definicje utrwalania list
Opis: Definicja utrwalania widoku listy do tabeli BI. Określa tabelę źródłową, folder, typ widoku oraz tabelę docelową, do której zapisywane są dane z listy. Służy do okresowego eksportowania danych z widoków aplikacji do struktury analitycznej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 1
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Description | `string` | bazodanowe | Opis | Opis objaśniający zawartość definicji utrwalania listy |
| FolderPath | `string` | bazodanowe, tylko-odczyt | Ścieżka | Ścieżka do folderu źródłowego |
| Name | `string` | bazodanowe, tylko-odczyt | Nazwa | Nazwa definicji utrwalania listy |
| Ranges | `SubTable<Soneta.BI.SerializationViewRange>` | podlista |  |  |
| SortOrder | `string` | bazodanowe, tylko-odczyt | Sortowanie |  |
| TableDefinition | `Soneta.BI.TableDefinition` | bazodanowe, tylko-odczyt | Definicja tabeli | Definicja tabeli docelowej |
| TableSource | `string` | bazodanowe, tylko-odczyt | Tabela źródłowa | Nazwa tabeli źródłowej |
| ViewInfoTypeName | `string` | bazodanowe, tylko-odczyt | Typ widoku | Typ widoku definiującego listę |
