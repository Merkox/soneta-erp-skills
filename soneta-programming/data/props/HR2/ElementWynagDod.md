# Pola i właściwości klasy biznesowej: `Soneta.HR2.ElementWynagDod`
Nazwa tabeli: `ElementyWynagDod`
Tytuł: Elementy wynagrodzenia
Opis: Element szczegółowy historycznej definicji stanowiska (DefinicjaStanowiskaHist). Przypisuje składniki wynagrodzenia do stanowiska, określając jakie elementy płacowe są przewidziane dla danej roli.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Stanowisko` → `DefinicjaStanowiskaHist`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiskaHist` | bazodanowe, guided-parent |  |  |
