# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Macierze.MacierzWartosciowania`
Nazwa tabeli: `ZklWrtMacierz`
Tytuł: Macierze kryteriów wartościowania
Opis: Definiuje macierz służącą do wartościowania stanowisk. Umożliwia obiektywne wartościowania stanowisk.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataZatwierdzenia | `Date` | bazodanowe, tylko-odczyt | Data zatwierdzenia |  |
| Mnozniki | `SubTable<Soneta.HR.ZKL.Wartosciowanie.Macierze.MnoznikMacierzyWartosciowania>` | podlista |  |  |
| NaDzien | `Date` | bazodanowe | Na dzień |  |
| Nazwa | `string` | bazodanowe |  |  |
| OstaniaEdycja | `DateShortTime` | bazodanowe, tylko-odczyt | Ostatnia edycja |  |
| Punkty | `SubTable<Soneta.HR.ZKL.Wartosciowanie.Macierze.PunktyMacierzyWartosciowania>` | podlista |  |  |
| Zatwierdzona | `bool` | bazodanowe, tylko-odczyt | Zatwierdzona |  |
