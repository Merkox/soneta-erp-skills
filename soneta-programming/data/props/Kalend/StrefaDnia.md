# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaDnia`
Nazwa tabeli: `StrefyDni`
Tytuł: Strefy dni
Opis: Element szczegółowy definicji dnia (DefinicjaDnia). Strefa czasowa przypisana do definicji dnia roboczego, określająca godziny rozpoczęcia i czas trwania danej strefy w ramach wzorca dnia.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Dzien` → `DefinicjaDnia`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Dzien | `Soneta.Kalend.DefinicjaDnia` | bazodanowe, guided-parent |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
