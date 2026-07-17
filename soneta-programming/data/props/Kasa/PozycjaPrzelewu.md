# Pola i właściwości klasy biznesowej: `Soneta.Kasa.PozycjaPrzelewu`
Nazwa tabeli: `PozycjePrzelewow`
Tytuł: Pozycje przelewów
Opis: Element szczegółowy przelewu (PrzelewBase) wiążący przelew z konkretnymi płatnościami lub zapłatami. Każda pozycja reprezentuje jedno zobowiązanie pokrywane danym przelewem, przechowując kwotę częściową i datę przelewu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Przelew` → `PrzelewBase`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataPrzelewu | `Soneta.Types.Date` | bazodanowe |  |  |
| DokPrzelew | `Soneta.Kasa.IDokPrzelewowy` | bazodanowe |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  |  |
| Lpx | `int` |  |  |  |
| Przelew | `Soneta.Kasa.PrzelewBase` | bazodanowe, guided-parent |  |  |
| Termin | `Soneta.Types.Date` |  |  |  |
| WeryfikacjaTransakcji | `Soneta.Kasa.IWeryfikacjaTransakcji` |  |  |  |
