# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaPracyHistoria`
Nazwa tabeli: `StrefyPracyHist`
Tytuł: Historie strefy dnia pracy
Opis: Element szczegółowy historii dnia pracy (DzienPracyHistoria). Historyczny zapis strefy czasowej dnia ewidencji czasu pracy, przechowujący definicję strefy, godziny, czas rozliczany, rozliczenie nadgodzin oraz czynność sprzed aktualizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienPracyHistoria`
Implementuje interfejsy: `IRozliczenieNadgodzinHost`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 0
- subrowy: 1
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| CzasRozliczany | `Time` | bazodanowe | Czas rozliczany |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Dzien | `Soneta.Kalend.DzienPracyHistoria` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kalend.ElementRozliczeniaCzasuPracy` | bazodanowe, tylko-odczyt | Rozliczenie |  |
