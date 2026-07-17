# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaKalendarza`
Nazwa tabeli: `StrefyKalandarza`
Tytuł: Strefy dni
Opis: Element szczegółowy dnia kalendarza (DzienKalendarzaBase). Strefa czasowa przypisana do konkretnego dnia w kalendarzu pracy, określająca godziny pracy, lokalizację RCP oraz przypisaną czynność.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienKalendarzaBase`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| DefinicjaNet | `Soneta.Kalend.DefinicjaStrefy` |  |  |  |
| Dzien | `Soneta.Kalend.DzienKalendarzaBase` | bazodanowe, guided-parent |  |  |
| Lokalizacja | `Soneta.Core.IRcpAddress` | bazodanowe |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
