# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaKalendarzaAktualizacja`
Nazwa tabeli: `StrefyKalendAkt`
Tytuł: Aktualizacje strefy dna
Opis: Element szczegółowy aktualizacji dnia kalendarza (DzienKalendarzaAktualizacja). Strefa czasowa w ramach aktualizowanego dnia planu pracy, uwzględniająca definicję strefy, godziny pracy, lokalizację RCP oraz przypisaną czynność.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienKalendarzaAktualizacja`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| DefinicjaNet | `Soneta.Kalend.DefinicjaStrefy` |  |  |  |
| Dzien | `Soneta.Kalend.DzienKalendarzaAktualizacja` | bazodanowe, guided-parent |  |  |
| Lokalizacja | `Soneta.Core.IRcpAddress` | bazodanowe |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
