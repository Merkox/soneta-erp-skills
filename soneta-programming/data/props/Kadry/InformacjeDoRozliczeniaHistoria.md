# Pola i właściwości klasy biznesowej: `Soneta.Kadry.InformacjeDoRozliczeniaHistoria`
Nazwa tabeli: `InfoDoRozliHist`
Tytuł: Historie elementów rozliczenia
Opis: Element szczegółowy informacji do rozliczenia (InformacjaDoRozliczenia). Wersja historyczna parametrów rozliczenia umowy zewnętrznej – rejestruje zmiany podstawy, czasu, dni, ułamka, procentu i współczynnika w kolejnych okresach aktualności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `InformacjaDoRozliczenia` → `InformacjaDoRozliczenia`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Dni | `int` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| InformacjaDoRozliczenia | `Soneta.Kadry.InformacjaDoRozliczenia` | bazodanowe, guided-parent |  |  |
| Parent | `Soneta.Business.Row` |  |  |  |
| Podstawa | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Ulamek | `Soneta.Types.Fraction` | bazodanowe |  |  |
| Wspolczynnik | `double` | bazodanowe |  |  |
