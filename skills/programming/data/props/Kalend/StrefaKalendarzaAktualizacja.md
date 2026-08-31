# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaKalendarzaAktualizacja`
Nazwa tabeli: `StrefyKalendAkt`
Tytuł: Aktualizacje strefy dna
Opis: Element szczegółowy aktualizacji dnia kalendarza (DzienKalendarzaAktualizacja). Strefa czasowa w ramach aktualizowanego dnia planu pracy, uwzględniająca definicję strefy, godziny pracy, lokalizację RCP oraz przypisaną czynność.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienKalendarzaAktualizacja`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| DefinicjaNet | `Soneta.Kalend.DefinicjaStrefy` |  |  |  |
| Dzien | `Soneta.Kalend.DzienKalendarzaAktualizacja` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Lokalizacja | `Soneta.Core.IRcpAddress` | bazodanowe |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
