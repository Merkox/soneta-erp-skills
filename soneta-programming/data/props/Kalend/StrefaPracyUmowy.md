# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaPracyUmowy`
Nazwa tabeli: `StrefyPracyUmowy`
Tytuł: Strefy dni umowy
Opis: Element szczegółowy dnia pracy umowy (DzienPracyUmowy). Strefa czasowa zarejestrowana w dniu pracy w ramach umowy zewnętrznej, zawierająca definicję strefy, godziny pracy, czas rozliczany oraz przypisaną czynność.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienPracyUmowy`
Implementuje interfejsy: `IRozliczenieNadgodzinHost`

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
| Dzien | `Soneta.Kalend.DzienPracyUmowy` | bazodanowe, guided-parent |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
