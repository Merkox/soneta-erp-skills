# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawienieUmowyZewnetrznej`
Nazwa tabeli: `ZestawieniaUmZew`
Tytuł: Zestawienia umów zewnętrznych
Opis: Element szczegółowy umowy zewnętrznej (UmowaZewnetrzna). Okresowe zestawienie czasu pracy i wartości dla umowy zewnętrznej, agregujące dane w ramach okresu rozliczeniowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Umowa` → `UmowaZewnetrzna`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Ilość | `double` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Poprzednie | `Soneta.Kalend.ZestawienieUmowyZewnetrznej` |  |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaZestawieniaUmowyZewnetrznej>` |  |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe, guided-parent |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  |  |
