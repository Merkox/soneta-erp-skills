# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawienieUmowy`
Nazwa tabeli: `ZestawieniaUmow`
Tytuł: Zestawienia umów
Opis: Element szczegółowy umowy (Umowa). Okresowe zestawienie czasu pracy i wartości dla umowy zlecenia, agregujące dane w ramach okresu rozliczeniowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Umowa` → `Umowa`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Ilość | `double` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Poprzednie | `Soneta.Kalend.ZestawienieUmowy` |  |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaZestawieniaUmowy>` |  |  |  |
| Umowa | `Soneta.Kadry.Umowa` | bazodanowe, guided-parent |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  |  |
