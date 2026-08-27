# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawienieUmowy`
Nazwa tabeli: `ZestawieniaUmow`
Tytuł: Zestawienia umów
Opis: Element szczegółowy umowy (Umowa). Okresowe zestawienie czasu pracy i wartości dla umowy zlecenia, agregujące dane w ramach okresu rozliczeniowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Umowa` → `Umowa`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` |  |  |  |
| Ilość | `double` |  |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Poprzednie | `Soneta.Kalend.ZestawienieUmowy` | tylko-odczyt |  |  |
| Strefy | `SubTable<Soneta.Kalend.StrefaZestawieniaUmowy>` | podlista |  |  |
| Umowa | `Soneta.Kadry.Umowa` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Wartosc | `Currency` | bazodanowe, tylko-odczyt |  |  |
