# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaPracyAktualizacja`
Nazwa tabeli: `StrefyPracyAkt`
Tytuł: Aktualizacje strefy dnia pracy
Opis: Element szczegółowy aktualizacji dnia pracy (DzienPracyAktualizacja). Strefa czasowa w ramach aktualizowanego dnia ewidencji czasu pracy, zawierająca definicję strefy, godziny pracy, czas rozliczany oraz przypisaną czynność.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienPracyAktualizacja`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| CzasRozliczany | `Time` | bazodanowe | Czas rozliczany |  |
| CzasRozliczanyWyliczony | `Time` |  | Czas rozliczany |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| DefinicjaNet | `Soneta.Kalend.DefinicjaStrefy` |  |  |  |
| Dzien | `Soneta.Kalend.DzienPracyAktualizacja` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
