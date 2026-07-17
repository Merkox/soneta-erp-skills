# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienPracy`
Nazwa tabeli: `DniPracy`
Tytuł: Dni pracy
Opis: Element szczegółowy pracownika (Pracownik). Ewidencja pojedynczego dnia pracy pracownika, zawierająca datę, godziny pracy (od–czas) oraz status zgodności z danymi RCP.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| RcpOK | `bool` | bazodanowe |  | Informacja o stanie rekordu po imporcie z RCP |
| RównoważnyCzasPracy | `bool` |  |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaPracy>` |  |  |  |
| WeWy | `Soneta.Business.LpSubTable<Soneta.Kalend.WejscieWyjscie>` |  |  |  |
