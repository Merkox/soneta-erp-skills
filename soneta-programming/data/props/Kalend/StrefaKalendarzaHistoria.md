# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaKalendarzaHistoria`
Nazwa tabeli: `StrefyKalendHist`
Tytuł: Historie strefy dnia
Opis: Element szczegółowy historii dnia kalendarza (DzienKalendarzaHistoria). Historyczny zapis strefy czasowej dnia planu pracy, przechowujący definicję strefy, godziny pracy, lokalizację RCP oraz czynność sprzed aktualizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienKalendarzaHistoria`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 1
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Dzien | `Soneta.Kalend.DzienKalendarzaHistoria` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Lokalizacja | `Soneta.Core.IRcpAddress` | bazodanowe |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
