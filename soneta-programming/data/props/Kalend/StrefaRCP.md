# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaRCP`
Nazwa tabeli: `StrefyRCP`
Tytuł: Strefy RCP
Opis: Element szczegółowy dnia RCP (DzienRCP). Strefa czasowa zarejestrowana przez czytnik RCP w danym dniu, zawierająca definicję strefy, godziny pracy, czas rozliczany, rozliczenie nadgodzin oraz liczbę porządkową.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienRCP`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| CzasRozliczany | `Soneta.Types.Time` | bazodanowe | Czas rozliczany |  |
| CzasRozliczanyWyliczony | `Soneta.Types.Time` |  | Czas rozliczany |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| DefinicjaNet | `Soneta.Kalend.DefinicjaStrefy` |  |  |  |
| Dzien | `Soneta.Kalend.DzienRCP` | bazodanowe, guided-parent |  |  |
| Lp | `int` | bazodanowe |  |  |
| Modyfikacja | `bool` |  |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kalend.ElementRozliczeniaCzasuPracy` | bazodanowe | Rozliczenie |  |
