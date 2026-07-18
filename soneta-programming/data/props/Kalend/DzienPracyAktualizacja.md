# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienPracyAktualizacja`
Nazwa tabeli: `DniPracyAkt`
Tytuł: Aktualizacje dni pracy
Opis: Element szczegółowy pozycji aktualizacji czasu (PozycjaAktualizacjiCzasu). Aktualizowany dzień ewidencji czasu pracy na dokumencie aktualizacji kalendarza, zawierający datę, godziny pracy oraz status RCP.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaAktualizacjiCzasu`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 5
- podlisty: 1
- subrowy: 1
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Pozycja | `Soneta.Kalend.PozycjaAktualizacjiCzasu` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| RcpOK | `bool` | bazodanowe |  | Informacja o stanie rekordu po imporcie z RCP |
| RównoważnyCzasPracy | `bool` | tylko-odczyt |  |  |
| Strefy | `SubTable<Soneta.Kalend.StrefaPracyAktualizacja>` | podlista |  |  |
