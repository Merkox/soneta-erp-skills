# Pola i właściwości klasy biznesowej: `Soneta.Kadry.OkresNiewliczany`
Nazwa tabeli: `OkrNiewliczane`
Tytuł: Okresy niewliczane do stażu pracy
Opis: Element szczegółowy historii zatrudnienia (HistoriaZatrudnieniaBase). Okres przerwy w zatrudnieniu niewliczany do stażu pracy, z podaniem zakresu dat, długości przerwy i przyczyny wyłączenia z naliczania stażu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zatrudnienie` → `HistoriaZatrudnieniaBase`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Naliczony | `bool` | bazodanowe, tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Przyczyna | `string` | bazodanowe |  |  |
| Staz | `Soneta.Kadry.StazPracy` | bazodanowe |  |  |
| Zatrudnienie | `Soneta.Kadry.HistoriaZatrudnieniaBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
