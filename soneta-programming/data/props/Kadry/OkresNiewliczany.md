# Pola i właściwości klasy biznesowej: `Soneta.Kadry.OkresNiewliczany`
Nazwa tabeli: `OkrNiewliczane`
Tytuł: Okresy niewliczane do stażu pracy
Opis: Element szczegółowy historii zatrudnienia (HistoriaZatrudnieniaBase). Okres przerwy w zatrudnieniu niewliczany do stażu pracy, z podaniem zakresu dat, długości przerwy i przyczyny wyłączenia z naliczania stażu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zatrudnienie` → `HistoriaZatrudnieniaBase`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Naliczony | `bool` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Przyczyna | `string` | bazodanowe |  |  |
| Staz | `Soneta.Kadry.StazPracy` | bazodanowe |  |  |
| Zatrudnienie | `Soneta.Kadry.HistoriaZatrudnieniaBase` | bazodanowe, guided-parent |  |  |
