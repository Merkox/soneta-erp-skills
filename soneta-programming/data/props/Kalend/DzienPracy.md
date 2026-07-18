# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienPracy`
Nazwa tabeli: `DniPracy`
Tytuł: Dni pracy
Opis: Element szczegółowy pracownika (Pracownik). Ewidencja pojedynczego dnia pracy pracownika, zawierająca datę, godziny pracy (od–czas) oraz status zgodności z danymi RCP.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 5
- podlisty: 2
- subrowy: 1
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| RcpOK | `bool` | bazodanowe |  | Informacja o stanie rekordu po imporcie z RCP |
| RównoważnyCzasPracy | `bool` | tylko-odczyt |  |  |
| Strefy | `SubTable<Soneta.Kalend.StrefaPracy>` | podlista |  |  |
| WeWy | `LpSubTable<Soneta.Kalend.WejscieWyjscie>` | podlista |  |  |
