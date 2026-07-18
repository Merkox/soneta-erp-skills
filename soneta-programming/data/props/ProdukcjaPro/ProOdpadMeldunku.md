# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOdpadMeldunku`
Nazwa tabeli: `ProOdpadyM`
Tytuł: Odpady meldunków
Opis: Element szczegółowy odpadu meldunku (ProMeldunek). Rejestruje odpad powstały w ramach meldunku produkcyjnego z informacjami o towarze, magazynie, ilościach planowanych i rzeczywistych oraz wartościach. Pozwala na śledzenie współczynnika odpadu i jego udziału w kalkulacji kosztów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CenaPlanowana | `DoubleCy` | bazodanowe | Cena planowana | Cena planowana odpadu meldunku. |
| CenaPrzyjecia | `DoubleCy` | bazodanowe | Cena przyjęcia | Cena przyjęcia odpadu meldunku. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość odpadu meldunku. |
| IloscDoRealizacji | `Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji odpadu meldunku. |
| IloscDoRealizacjiPrzeliczona | `Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla odpadu meldunku. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa odpadu meldunku. |
| IloscJednostkowaPlanowana | `double` | bazodanowe | Ilość jednostkowa planowana | Ilość jednostkowa planowana odpadu meldunku. |
| IloscPlanowana | `Amount` | bazodanowe | Ilość planowana | Ilość planowana odpadu meldunku. |
| IloscPlanowanaPrzeliczona | `Amount` | bazodanowe | Ilość planowana przeliczona | Ilość przeliczona planowana na podstawową jednostkę miary dla odpadu meldunku. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla odpadu meldunku. |
| IloscZrealizowana | `Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana odpadu meldunku. |
| IloscZrealizowanaPrzeliczona | `Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla odpadu meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa odpadu meldunku. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn odpadu meldunku. |
| Material | `Soneta.ProdukcjaPro.ProMaterialMeldunku` | bazodanowe | Materiał | Materiał odpadu meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla odpadu meldunku. |
| NarzutPlanowany | `Percent` | bazodanowe | Narzut planowany | Narzut planowany odpadu meldunku |
| OdpadOperacjiZlecenia | `Soneta.ProdukcjaPro.ProOdpadOperacjiZlecenia` | bazodanowe | Odpad operacji zlecenia | Odpad operacji zlecenia dla odpadu meldunku. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis odpadu meldunku. |
| Rozliczenia | `SubTable<Soneta.ProdukcjaPro.ProRozliczenieOdpadu>` | podlista |  |  |
| RozliczenieIlosciowe | `Soneta.ProdukcjaPro.ProRozliczenieIlosciowe` (enum) | tylko-odczyt | Rozliczenie ilościowe | Rozliczenie ilościowe odpadu meldunku. |
| RozliczenieWartosciowe | `bool` | tylko-odczyt | Rozliczenie wartościowe | Rozliczenie wartościowe odpadu meldunku. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar odpadu meldunku. |
| UdzialWKalkulacji | `Soneta.ProdukcjaPro.ProUdzialWKalkulacji` (enum) | bazodanowe | Udział w kalkulacji | Udział w kalkulacji odpadu meldunku. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość odpadu meldunku. |
| WartoscPlanowana | `Currency` | bazodanowe | Wartość planowana | Wartość planowana odpadu meldunku. |
| WartoscPrzyjecia | `Currency` | bazodanowe | Wartość przyjęcia | Wartość przyjęcia odpadu meldunku. |
| WartoscZrealizowana | `Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana odpadu meldunku. |
| Wspolczynnik | `Fraction` | bazodanowe | Współczynnik | Współczynnik odpadu meldunku. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRozliczenieIlosciowe (`Soneta.ProdukcjaPro.ProRozliczenieIlosciowe`)
- `None` = 0
- `Brak` = 1
- `Czesciowe` = 2 — Częściowe
- `Pelne` = 4 — Pełne
- `Nadmiarowe` = 8
- `All` = 15 — Wszystkie

### ProUdzialWKalkulacji (`Soneta.ProdukcjaPro.ProUdzialWKalkulacji`)
- `None` = 0
- `Dodaj` = 1
- `Odejmij` = 2
- `Pomin` = 4 — Pomiń
- `All` = 7 — Wszystkie
