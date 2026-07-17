# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ŻyrantPożyczki`
Nazwa tabeli: `ZyranciPozyczek`
Tytuł: Żyranci
Opis: Element szczegółowy pożyczki (Pozyczka). Żyrant pożyczki pracowniczej – pracownik poręczający spłatę z podaniem priorytetu, warunków spłaty (od kiedy, kwota, procent) i elementu płacowego do potrąceń.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozyczka` → `Pozyczka`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ElementRaty | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `System.Collections.Generic.IEnumerable<Soneta.Place.WypElement>` |  |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| Pozyczka | `Soneta.Kadry.Pozyczka` | bazodanowe, guided-parent | Pożyczka |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Raty | `System.Collections.Generic.IEnumerable<Soneta.Kadry.RataPozyczki>` |  |  |  |
| SplatyOd | `Soneta.Types.YearMonth` | bazodanowe |  |  |
