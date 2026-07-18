# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaZestawieniaUmowyZewnetrznej`
Nazwa tabeli: `StrefyZestUmZw`
Tytuł: Strefy zestawień umów zewnętrznych
Opis: Element szczegółowy zestawienia umowy zewnętrznej (ZestawienieUmowyZewnetrznej). Pozycja zestawienia okresowego umowy zewnętrznej, zawierająca czas pracy, ilość, stawkę oraz wartość dla danej strefy w okresie rozliczeniowym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zestawienie` → `ZestawienieUmowyZewnetrznej`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Stawka | `Currency` | bazodanowe |  |  |
| Wartosc | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Zestawienie | `Soneta.Kalend.ZestawienieUmowyZewnetrznej` | bazodanowe, tylko-odczyt, guided-parent |  |  |
