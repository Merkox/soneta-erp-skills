# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProRozliczenieWyrobu`
Nazwa tabeli: `ProRozWyrobow`
Tytuł: Rozliczenia wyrobów
Opis: Element szczegółowy rozliczenia wyrobu (ProOperacjaZlecenia). Powiązuje wyrób meldunku z pozycją dokumentu handlowego w celu rozliczenia produkcji. Przechowuje informacje o towarze, ilości, ilości przeliczonej oraz wartości rozliczenia wyrobu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FantomyWyrobow | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProFantomWyrobu>` |  |  |  |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość rozliczenia wyrobu. |
| IloscPrzeliczona | `double` | bazodanowe | Ilość przeliczona | Ilość przeliczona rozliczenia wyrobu. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent | Operacja | Operacja rozliczenia wyrobu. |
| PozycjaDokumentuHandlowego | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe | Pozycja dokumentu handlowego | Pozycja dokumentu handlowego rozliczenia wyrobu. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar rozliczenia wyrobu. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość rozliczenia wyrobu. |
| Wsteczne | `bool` | bazodanowe | Wsteczne | Rozliczenie wsteczne wyrobu. |
| WyrobMeldunku | `Soneta.ProdukcjaPro.ProWyrobMeldunku` | bazodanowe | Wyrób meldunku | Wyrób meldunku dla rozliczenia wyrobu. |
