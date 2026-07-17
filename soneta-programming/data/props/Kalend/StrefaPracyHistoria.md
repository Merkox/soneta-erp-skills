# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaPracyHistoria`
Nazwa tabeli: `StrefyPracyHist`
Tytuł: Historie strefy dnia pracy
Opis: Element szczegółowy historii dnia pracy (DzienPracyHistoria). Historyczny zapis strefy czasowej dnia ewidencji czasu pracy, przechowujący definicję strefy, godziny, czas rozliczany, rozliczenie nadgodzin oraz czynność sprzed aktualizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienPracyHistoria`
Implementuje interfejsy: `IRozliczenieNadgodzinHost`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| CzasRozliczany | `Soneta.Types.Time` | bazodanowe | Czas rozliczany |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Dzien | `Soneta.Kalend.DzienPracyHistoria` | bazodanowe, guided-parent |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kalend.ElementRozliczeniaCzasuPracy` | bazodanowe | Rozliczenie |  |
