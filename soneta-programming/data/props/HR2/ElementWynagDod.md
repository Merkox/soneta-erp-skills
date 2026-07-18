# Pola i właściwości klasy biznesowej: `Soneta.HR2.ElementWynagDod`
Nazwa tabeli: `ElementyWynagDod`
Tytuł: Elementy wynagrodzenia
Opis: Element szczegółowy historycznej definicji stanowiska (DefinicjaStanowiskaHist). Przypisuje składniki wynagrodzenia do stanowiska, określając jakie elementy płacowe są przewidziane dla danej roli.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Stanowisko` → `DefinicjaStanowiskaHist`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiskaHist` | bazodanowe, tylko-odczyt, guided-parent |  |  |
