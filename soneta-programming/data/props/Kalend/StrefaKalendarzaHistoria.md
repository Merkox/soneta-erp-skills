# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaKalendarzaHistoria`
Nazwa tabeli: `StrefyKalendHist`
Tytuł: Historie strefy dnia
Opis: Element szczegółowy historii dnia kalendarza (DzienKalendarzaHistoria). Historyczny zapis strefy czasowej dnia planu pracy, przechowujący definicję strefy, godziny pracy, lokalizację RCP oraz czynność sprzed aktualizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienKalendarzaHistoria`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Dzien | `Soneta.Kalend.DzienKalendarzaHistoria` | bazodanowe, guided-parent |  |  |
| Lokalizacja | `Soneta.Core.IRcpAddress` | bazodanowe |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
