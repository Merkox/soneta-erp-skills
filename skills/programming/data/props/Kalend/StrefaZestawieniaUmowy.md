# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaZestawieniaUmowy`
Nazwa tabeli: `StrefyZestawUmow`
Tytuł: Strefy zestawień umów
Opis: Element szczegółowy zestawienia umowy (ZestawienieUmowy). Pozycja zestawienia okresowego umowy zlecenia, zawierająca czas pracy, ilość, stawkę oraz wartość dla danej strefy w okresie rozliczeniowym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zestawienie` → `ZestawienieUmowy`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Stawka | `Currency` | bazodanowe |  |  |
| Wartosc | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Zestawienie | `Soneta.Kalend.ZestawienieUmowy` | bazodanowe, tylko-odczyt, guided-parent |  |  |
