# Pola i właściwości klasy biznesowej: `Soneta.BI.SerializationViewFilterSet`
Nazwa tabeli: `SerialFilterSets`
Tytuł: Zestawy filtrów dla utrwalania list
Opis: Reużywalny zestaw filtrów stosowany przy utrwalaniu list BI. Definiuje nazwane warunki filtrowania dla wskazanej tabeli źródłowej i folderu, umożliwiając wielokrotne stosowanie tych samych kryteriów w różnych definicjach utrwalania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FilterText | `MemoText` | bazodanowe, podlista |  |  |
| Filters | `Soneta.BI.SerializationViewFilter[]` | podlista |  |  |
| FolderPath | `string` | bazodanowe, tylko-odczyt | Ścieżka | Ścieżka do folderu źródłowego |
| Name | `string` | bazodanowe | Nazwa zestawu filtrów | Nazwa zestawu filtrów dla utrwalania listy |
| TableSource | `string` | bazodanowe, tylko-odczyt | Tabela źródłowa | Nazwa tabeli źródłowej |
