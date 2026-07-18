# Pola i właściwości klasy biznesowej: `Soneta.Core.ZrodloFinansowania`
Nazwa tabeli: `ZrodlaFinansow`
Tytuł: Źródła finansowania
Opis: Słownik źródeł finansowania używanych w opisie analitycznym dokumentów. Każde źródło posiada symbol, nazwę, rodzaj źródła oraz flagę blokady.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IElementSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa źródła finansowania. |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| RodzajZrodla | `Soneta.Core.RodzajZrodla` | bazodanowe | Rodzaj źródła | Rodzaj źródła finansowania |
| Symbol | `string` | bazodanowe | Symbol | Symbol źródła finansowania |
| Zablokowane | `bool` | bazodanowe | Zablokowane | Źródło finansowania zablokowane |
