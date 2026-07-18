# Pola i właściwości klasy biznesowej: `Soneta.Kasa.PozycjaPrzelewu`
Nazwa tabeli: `PozycjePrzelewow`
Tytuł: Pozycje przelewów
Opis: Element szczegółowy przelewu (PrzelewBase) wiążący przelew z konkretnymi płatnościami lub zapłatami. Każda pozycja reprezentuje jedno zobowiązanie pokrywane danym przelewem, przechowując kwotę częściową i datę przelewu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Przelew` → `PrzelewBase`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataPrzelewu | `Date` | bazodanowe |  |  |
| DokPrzelew | `Soneta.Kasa.IDokPrzelewowy` | bazodanowe, tylko-odczyt |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  |  |
| Lpx | `int` |  |  |  |
| Przelew | `Soneta.Kasa.PrzelewBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Termin | `Date` | tylko-odczyt |  |  |
| WeryfikacjaTransakcji | `Soneta.Kasa.IWeryfikacjaTransakcji` | tylko-odczyt |  |  |
