# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaDnia`
Nazwa tabeli: `StrefyDni`
Tytuł: Strefy dni
Opis: Element szczegółowy definicji dnia (DefinicjaDnia). Strefa czasowa przypisana do definicji dnia roboczego, określająca godziny rozpoczęcia i czas trwania danej strefy w ramach wzorca dnia.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Dzien` → `DefinicjaDnia`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 1
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Dzien | `Soneta.Kalend.DefinicjaDnia` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
