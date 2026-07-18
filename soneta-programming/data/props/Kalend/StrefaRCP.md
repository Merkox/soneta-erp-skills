# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaRCP`
Nazwa tabeli: `StrefyRCP`
Tytuł: Strefy RCP
Opis: Element szczegółowy dnia RCP (DzienRCP). Strefa czasowa zarejestrowana przez czytnik RCP w danym dniu, zawierająca definicję strefy, godziny pracy, czas rozliczany, rozliczenie nadgodzin oraz liczbę porządkową.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienRCP`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| CzasRozliczany | `Time` | bazodanowe | Czas rozliczany |  |
| CzasRozliczanyWyliczony | `Time` |  | Czas rozliczany |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| DefinicjaNet | `Soneta.Kalend.DefinicjaStrefy` |  |  |  |
| Dzien | `Soneta.Kalend.DzienRCP` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Lp | `int` | bazodanowe |  |  |
| Modyfikacja | `bool` | tylko-odczyt |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kalend.ElementRozliczeniaCzasuPracy` | bazodanowe, tylko-odczyt | Rozliczenie |  |
