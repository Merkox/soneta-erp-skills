# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaZestawieniaUmowyZewnetrznej`
Nazwa tabeli: `StrefyZestUmZw`
Tytuł: Strefy zestawień umów zewnętrznych
Opis: Element szczegółowy zestawienia umowy zewnętrznej (ZestawienieUmowyZewnetrznej). Pozycja zestawienia okresowego umowy zewnętrznej, zawierająca czas pracy, ilość, stawkę oraz wartość dla danej strefy w okresie rozliczeniowym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zestawienie` → `ZestawienieUmowyZewnetrznej`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Stawka | `Soneta.Types.Currency` | bazodanowe |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  |  |
| Zestawienie | `Soneta.Kalend.ZestawienieUmowyZewnetrznej` | bazodanowe, guided-parent |  |  |
