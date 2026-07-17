# Pola i właściwości klasy biznesowej: `Soneta.BI.SerializationViewFilterSet`
Nazwa tabeli: `SerialFilterSets`
Tytuł: Zestawy filtrów dla utrwalania list
Opis: Reużywalny zestaw filtrów stosowany przy utrwalaniu list BI. Definiuje nazwane warunki filtrowania dla wskazanej tabeli źródłowej i folderu, umożliwiając wielokrotne stosowanie tych samych kryteriów w różnych definicjach utrwalania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FilterText | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Filters | `Soneta.BI.SerializationViewFilter[]` |  |  |  |
| FolderPath | `string` | bazodanowe | Ścieżka | Ścieżka do folderu źródłowego |
| Name | `string` | bazodanowe | Nazwa zestawu filtrów | Nazwa zestawu filtrów dla utrwalania listy |
| TableSource | `string` | bazodanowe | Tabela źródłowa | Nazwa tabeli źródłowej |
