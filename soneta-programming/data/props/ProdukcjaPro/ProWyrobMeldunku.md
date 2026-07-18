# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProWyrobMeldunku`
Nazwa tabeli: `ProWyrobyM`
Tytuł: Wyroby meldunków
Opis: Element szczegółowy wyrobu meldunku (ProMeldunek). Opisuje wyrób powstały w ramach meldunku produkcyjnego z informacjami o towarze, typie wyrobu, magazynie, ilościach planowanych i rzeczywistych oraz cenach i wartościach. Umożliwia śledzenie realizacji produkcji wyrobów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

- pola bazodanowe (zapisywalne): 25
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 3
- subrowy: 0
- razem: 32

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `DoubleCy` | bazodanowe |  | Cena wyrobu meldunku. |
| CenaPlanowana | `DoubleCy` | bazodanowe | Cena planowana | Cena planowana wyrobu meldunku. |
| CenaPrzyjecia | `DoubleCy` | bazodanowe | Cena przyjęcia | Cena przyjęcia wyrobu meldunku. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość wyrobu meldunku. |
| IloscDoRealizacji | `Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji wyrobu meldunku. |
| IloscDoRealizacjiPrzeliczona | `Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla wyrobu meldunku. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa wyrobu meldunku. |
| IloscJednostkowaPlanowana | `double` | bazodanowe | Ilość jednostkowa planowana | Ilość jednostkowa planowana wyrobu meldunku. |
| IloscPlanowana | `Amount` | bazodanowe | Ilość planowana | Ilość planowana wyrobu meldunku. |
| IloscPlanowanaPrzeliczona | `Amount` | bazodanowe | Ilość planowana przeliczona | Ilość planowana przeliczona na podstawową jednostkę miary dla wyrobu meldunku. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla wyrobu meldunku. |
| IloscZrealizowana | `Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana wyrobu meldunku. |
| IloscZrealizowanaPrzeliczona | `Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla wyrobu meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wyrobu meldunku. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn wyrobu meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla wyrobu meldunku. |
| Numeracja | `Soneta.ProdukcjaPro.ProNumeracjaWyrobuMeldunku` | tylko-odczyt |  | Kalkulacja meldunku. |
| Numeracje | `LpSubTable<Soneta.ProdukcjaPro.ProNumeracjaWyrobuMeldunku>` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis wyrobu meldunku. |
| RozliczFantomowo | `bool` | tylko-odczyt | Rozlicz fantomowo | Rozlicz fantomowo wyrób meldunku. |
| Rozliczenia | `SubTable<Soneta.ProdukcjaPro.ProRozliczenieWyrobu>` | podlista |  |  |
| RozliczenieIlosciowe | `Soneta.ProdukcjaPro.ProRozliczenieIlosciowe` (enum) | tylko-odczyt | Rozliczenie ilościowe | Rozliczenie ilościowe wyrobu meldunku. |
| RozliczenieWartosciowe | `bool` | tylko-odczyt | Rozliczenie wartościowe | Rozliczenie wartościowe wyrobu meldunku. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar wyrobu meldunku. |
| Typ | `Soneta.ProdukcjaPro.ProTypWyrobu` (enum) | bazodanowe | Typ wyrobu | Typ wyrobu meldunku. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość wyrobu meldunku. |
| WartoscPlanowana | `Currency` | bazodanowe | Wartość planowana | Wartość planowana wyrobu meldunku. |
| WartoscPrzyjecia | `Currency` | bazodanowe | Wartość przyjęcia | Wartość przyjęcia wyrobu meldunku. |
| WartoscZrealizowana | `Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana wyrobu meldunku. |
| Wspolczynnik | `double` | bazodanowe | Współczynnik | Współczynnik wyrobu meldunku. |
| WspolczynnikPlanowany | `double` | bazodanowe | Współczynnik planowany | Współczynnik planowany wyrobu meldunku. |
| WyrobOperacjiZlecenia | `Soneta.ProdukcjaPro.ProWyrobOperacjiZlecenia` | bazodanowe | Wyrób operacji zlecenia | Wyrób operacji zlecenia dla wyrobu meldunku. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRozliczenieIlosciowe (`Soneta.ProdukcjaPro.ProRozliczenieIlosciowe`)
- `None` = 0
- `Brak` = 1
- `Czesciowe` = 2 — Częściowe
- `Pelne` = 4 — Pełne
- `Nadmiarowe` = 8
- `All` = 15 — Wszystkie

### ProTypWyrobu (`Soneta.ProdukcjaPro.ProTypWyrobu`)
- `None` = 0
- `Polprodukt` = 1 — Półprodukt
- `Produkt` = 2
- `All` = 3 — Wszystkie
