# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawienieUmowyZewnetrznej`
Nazwa tabeli: `ZestawieniaUmZew`
Tytuł: Zestawienia umów zewnętrznych
Opis: Element szczegółowy umowy zewnętrznej (UmowaZewnetrzna). Okresowe zestawienie czasu pracy i wartości dla umowy zewnętrznej, agregujące dane w ramach okresu rozliczeniowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Umowa` → `UmowaZewnetrzna`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` |  |  |  |
| Ilość | `double` |  |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Poprzednie | `Soneta.Kalend.ZestawienieUmowyZewnetrznej` | tylko-odczyt |  |  |
| Strefy | `SubTable<Soneta.Kalend.StrefaZestawieniaUmowyZewnetrznej>` | podlista |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Wartosc | `Currency` | bazodanowe, tylko-odczyt |  |  |
