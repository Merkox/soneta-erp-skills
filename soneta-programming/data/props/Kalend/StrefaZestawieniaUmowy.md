# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaZestawieniaUmowy`
Nazwa tabeli: `StrefyZestawUmow`
Tytuł: Strefy zestawień umów
Opis: Element szczegółowy zestawienia umowy (ZestawienieUmowy). Pozycja zestawienia okresowego umowy zlecenia, zawierająca czas pracy, ilość, stawkę oraz wartość dla danej strefy w okresie rozliczeniowym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zestawienie` → `ZestawienieUmowy`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Stawka | `Soneta.Types.Currency` | bazodanowe |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  |  |
| Zestawienie | `Soneta.Kalend.ZestawienieUmowy` | bazodanowe, guided-parent |  |  |
