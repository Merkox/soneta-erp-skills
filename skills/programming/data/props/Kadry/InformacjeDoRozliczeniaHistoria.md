# Pola i właściwości klasy biznesowej: `Soneta.Kadry.InformacjeDoRozliczeniaHistoria`
Nazwa tabeli: `InfoDoRozliHist`
Tytuł: Historie elementów rozliczenia
Opis: Element szczegółowy informacji do rozliczenia (InformacjaDoRozliczenia). Wersja historyczna parametrów rozliczenia umowy zewnętrznej – rejestruje zmiany podstawy, czasu, dni, ułamka, procentu i współczynnika w kolejnych okresach aktualności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `InformacjaDoRozliczenia` → `InformacjaDoRozliczenia`
Historia: Tak — zapis historyczny tabeli `InformacjaDoRozliczenia`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| Czas | `Time` | bazodanowe |  |  |
| Dni | `int` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| InformacjaDoRozliczenia | `Soneta.Kadry.InformacjaDoRozliczenia` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Parent | `Row` | tylko-odczyt |  |  |
| Podstawa | `DoubleCy` | bazodanowe |  |  |
| Procent | `Percent` | bazodanowe |  |  |
| Ulamek | `Fraction` | bazodanowe |  |  |
| Wspolczynnik | `double` | bazodanowe |  |  |
