# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProWyrobMeldunku`
Nazwa tabeli: `ProWyrobyM`
Tytuł: Wyroby meldunków
Opis: Element szczegółowy wyrobu meldunku (ProMeldunek). Opisuje wyrób powstały w ramach meldunku produkcyjnego z informacjami o towarze, typie wyrobu, magazynie, ilościach planowanych i rzeczywistych oraz cenach i wartościach. Umożliwia śledzenie realizacji produkcji wyrobów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

- pola bazodanowe: 26
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `Soneta.Types.DoubleCy` | bazodanowe |  | Cena wyrobu meldunku. |
| CenaPlanowana | `Soneta.Types.DoubleCy` | bazodanowe | Cena planowana | Cena planowana wyrobu meldunku. |
| CenaPrzyjecia | `Soneta.Types.DoubleCy` | bazodanowe | Cena przyjęcia | Cena przyjęcia wyrobu meldunku. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość wyrobu meldunku. |
| IloscDoRealizacji | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji wyrobu meldunku. |
| IloscDoRealizacjiPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla wyrobu meldunku. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa wyrobu meldunku. |
| IloscJednostkowaPlanowana | `double` | bazodanowe | Ilość jednostkowa planowana | Ilość jednostkowa planowana wyrobu meldunku. |
| IloscPlanowana | `Soneta.Types.Amount` | bazodanowe | Ilość planowana | Ilość planowana wyrobu meldunku. |
| IloscPlanowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość planowana przeliczona | Ilość planowana przeliczona na podstawową jednostkę miary dla wyrobu meldunku. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla wyrobu meldunku. |
| IloscZrealizowana | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana wyrobu meldunku. |
| IloscZrealizowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla wyrobu meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wyrobu meldunku. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn wyrobu meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla wyrobu meldunku. |
| Numeracja | `Soneta.ProdukcjaPro.ProNumeracjaWyrobuMeldunku` |  |  | Kalkulacja meldunku. |
| Numeracje | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProNumeracjaWyrobuMeldunku>` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis wyrobu meldunku. |
| RozliczFantomowo | `bool` |  | Rozlicz fantomowo | Rozlicz fantomowo wyrób meldunku. |
| Rozliczenia | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProRozliczenieWyrobu>` |  |  |  |
| RozliczenieIlosciowe | `Soneta.ProdukcjaPro.ProRozliczenieIlosciowe` | enum | Rozliczenie ilościowe | Rozliczenie ilościowe wyrobu meldunku. |
| RozliczenieWartosciowe | `bool` |  | Rozliczenie wartościowe | Rozliczenie wartościowe wyrobu meldunku. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar wyrobu meldunku. |
| Typ | `Soneta.ProdukcjaPro.ProTypWyrobu` | bazodanowe, enum | Typ wyrobu | Typ wyrobu meldunku. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość wyrobu meldunku. |
| WartoscPlanowana | `Soneta.Types.Currency` | bazodanowe | Wartość planowana | Wartość planowana wyrobu meldunku. |
| WartoscPrzyjecia | `Soneta.Types.Currency` | bazodanowe | Wartość przyjęcia | Wartość przyjęcia wyrobu meldunku. |
| WartoscZrealizowana | `Soneta.Types.Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana wyrobu meldunku. |
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
