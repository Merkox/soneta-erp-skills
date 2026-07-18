# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ElemDefinicjiSlownika`
Nazwa tabeli: `ElemDefSlownikow`
Tytuł: Elementy definicji słowników
Opis: Element szczegółowy definicji słownika (DefinicjaSlownika). Definiuje poszczególne segmenty struktury słownika analitycznego, określając ich kolejność, wzorzec segmentu oraz nazwy wyświetlane. Służy do konfiguracji wielopoziomowej analityki kont.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefinicjaSlownika`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Ksiega.DefinicjaSlownika` | bazodanowe, tylko-odczyt, guided-parent |  | Definicja słownika |
| Lp | `int` | bazodanowe |  |  |
| Nazwa1 | `string` | bazodanowe |  |  |
| Nazwa2 | `string` | bazodanowe, tylko-odczyt |  |  |
| Segment | `string` | bazodanowe, tylko-odczyt |  |  |
