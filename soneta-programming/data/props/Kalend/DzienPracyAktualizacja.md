# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienPracyAktualizacja`
Nazwa tabeli: `DniPracyAkt`
Tytuł: Aktualizacje dni pracy
Opis: Element szczegółowy pozycji aktualizacji czasu (PozycjaAktualizacjiCzasu). Aktualizowany dzień ewidencji czasu pracy na dokumencie aktualizacji kalendarza, zawierający datę, godziny pracy oraz status RCP.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaAktualizacjiCzasu`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Pozycja | `Soneta.Kalend.PozycjaAktualizacjiCzasu` | bazodanowe, guided-parent |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| RcpOK | `bool` | bazodanowe |  | Informacja o stanie rekordu po imporcie z RCP |
| RównoważnyCzasPracy | `bool` |  |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaPracyAktualizacja>` |  |  |  |
