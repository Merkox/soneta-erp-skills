# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOdpadMeldunku`
Nazwa tabeli: `ProOdpadyM`
Tytuł: Odpady meldunków
Opis: Element szczegółowy odpadu meldunku (ProMeldunek). Rejestruje odpad powstały w ramach meldunku produkcyjnego z informacjami o towarze, magazynie, ilościach planowanych i rzeczywistych oraz wartościach. Pozwala na śledzenie współczynnika odpadu i jego udziału w kalkulacji kosztów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

- pola bazodanowe: 26
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CenaPlanowana | `Soneta.Types.DoubleCy` | bazodanowe | Cena planowana | Cena planowana odpadu meldunku. |
| CenaPrzyjecia | `Soneta.Types.DoubleCy` | bazodanowe | Cena przyjęcia | Cena przyjęcia odpadu meldunku. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość odpadu meldunku. |
| IloscDoRealizacji | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji odpadu meldunku. |
| IloscDoRealizacjiPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla odpadu meldunku. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa odpadu meldunku. |
| IloscJednostkowaPlanowana | `double` | bazodanowe | Ilość jednostkowa planowana | Ilość jednostkowa planowana odpadu meldunku. |
| IloscPlanowana | `Soneta.Types.Amount` | bazodanowe | Ilość planowana | Ilość planowana odpadu meldunku. |
| IloscPlanowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość planowana przeliczona | Ilość przeliczona planowana na podstawową jednostkę miary dla odpadu meldunku. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla odpadu meldunku. |
| IloscZrealizowana | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana odpadu meldunku. |
| IloscZrealizowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla odpadu meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa odpadu meldunku. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn odpadu meldunku. |
| Material | `Soneta.ProdukcjaPro.ProMaterialMeldunku` | bazodanowe | Materiał | Materiał odpadu meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla odpadu meldunku. |
| NarzutPlanowany | `Soneta.Types.Percent` | bazodanowe | Narzut planowany | Narzut planowany odpadu meldunku |
| OdpadOperacjiZlecenia | `Soneta.ProdukcjaPro.ProOdpadOperacjiZlecenia` | bazodanowe | Odpad operacji zlecenia | Odpad operacji zlecenia dla odpadu meldunku. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis odpadu meldunku. |
| Rozliczenia | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProRozliczenieOdpadu>` |  |  |  |
| RozliczenieIlosciowe | `Soneta.ProdukcjaPro.ProRozliczenieIlosciowe` | enum | Rozliczenie ilościowe | Rozliczenie ilościowe odpadu meldunku. |
| RozliczenieWartosciowe | `bool` |  | Rozliczenie wartościowe | Rozliczenie wartościowe odpadu meldunku. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar odpadu meldunku. |
| UdzialWKalkulacji | `Soneta.ProdukcjaPro.ProUdzialWKalkulacji` | bazodanowe, enum | Udział w kalkulacji | Udział w kalkulacji odpadu meldunku. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość odpadu meldunku. |
| WartoscPlanowana | `Soneta.Types.Currency` | bazodanowe | Wartość planowana | Wartość planowana odpadu meldunku. |
| WartoscPrzyjecia | `Soneta.Types.Currency` | bazodanowe | Wartość przyjęcia | Wartość przyjęcia odpadu meldunku. |
| WartoscZrealizowana | `Soneta.Types.Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana odpadu meldunku. |
| Wspolczynnik | `Soneta.Types.Fraction` | bazodanowe | Współczynnik | Współczynnik odpadu meldunku. |

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
