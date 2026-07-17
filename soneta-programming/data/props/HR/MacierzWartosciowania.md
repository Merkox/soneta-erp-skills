# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Macierze.MacierzWartosciowania`
Nazwa tabeli: `ZklWrtMacierz`
Tytuł: Macierze kryteriów wartościowania
Opis: Definiuje macierz służącą do wartościowania stanowisk. Umożliwia obiektywne wartościowania stanowisk.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataZatwierdzenia | `Soneta.Types.Date` | bazodanowe | Data zatwierdzenia |  |
| Mnozniki | `Soneta.Business.SubTable<Soneta.HR.ZKL.Wartosciowanie.Macierze.MnoznikMacierzyWartosciowania>` |  |  |  |
| NaDzien | `Soneta.Types.Date` | bazodanowe | Na dzień |  |
| Nazwa | `string` | bazodanowe |  |  |
| OstaniaEdycja | `Soneta.Types.DateShortTime` | bazodanowe | Ostatnia edycja |  |
| Punkty | `Soneta.Business.SubTable<Soneta.HR.ZKL.Wartosciowanie.Macierze.PunktyMacierzyWartosciowania>` |  |  |  |
| Zatwierdzona | `bool` | bazodanowe | Zatwierdzona |  |
