# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaPracyAktualizacja`
Nazwa tabeli: `StrefyPracyAkt`
Tytuł: Aktualizacje strefy dnia pracy
Opis: Element szczegółowy aktualizacji dnia pracy (DzienPracyAktualizacja). Strefa czasowa w ramach aktualizowanego dnia ewidencji czasu pracy, zawierająca definicję strefy, godziny pracy, czas rozliczany oraz przypisaną czynność.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienPracyAktualizacja`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| CzasRozliczany | `Soneta.Types.Time` | bazodanowe | Czas rozliczany |  |
| CzasRozliczanyWyliczony | `Soneta.Types.Time` |  | Czas rozliczany |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| DefinicjaNet | `Soneta.Kalend.DefinicjaStrefy` |  |  |  |
| Dzien | `Soneta.Kalend.DzienPracyAktualizacja` | bazodanowe, guided-parent |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
