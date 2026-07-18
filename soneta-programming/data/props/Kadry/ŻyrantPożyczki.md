# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ŻyrantPożyczki`
Nazwa tabeli: `ZyranciPozyczek`
Tytuł: Żyranci
Opis: Element szczegółowy pożyczki (Pozyczka). Żyrant pożyczki pracowniczej – pracownik poręczający spłatę z podaniem priorytetu, warunków spłaty (od kiedy, kwota, procent) i elementu płacowego do potrąceń.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozyczka` → `Pozyczka`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ElementRaty | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `System.Collections.Generic.IEnumerable<Soneta.Place.WypElement>` | podlista |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| Pozyczka | `Soneta.Kadry.Pozyczka` | bazodanowe, tylko-odczyt, guided-parent | Pożyczka |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Procent | `Percent` | bazodanowe |  |  |
| Raty | `System.Collections.Generic.IEnumerable<Soneta.Kadry.RataPozyczki>` | podlista |  |  |
| SplatyOd | `YearMonth` | bazodanowe |  |  |
