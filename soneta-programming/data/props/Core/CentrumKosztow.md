# Pola i właściwości klasy biznesowej: `Soneta.Core.CentrumKosztow`
Nazwa tabeli: `CentraKosztow`
Opis: Słownik centrów kosztów używanych do klasyfikacji kosztów w opisie analitycznym. Każde centrum posiada unikalną nazwę, opis oraz flagę blokady.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IElementSlownika`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe | Opis | Opis centrum kosztów. |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Symbol | `string` | tylko-odczyt |  |  |
| Zablokowane | `bool` | bazodanowe |  |  |
