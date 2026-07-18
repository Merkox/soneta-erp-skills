# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOdpadOperacjiZlecenia`
Nazwa tabeli: `ProOdpadyOZ`
Tytuł: Odpady operacji zleceń
Opis: Element szczegółowy operacji zlecenia (ProOperacjaZlecenia). Definiuje planowany odpad lub produkt uboczny operacji zlecenia z ilościami planowanymi, zameldowanymi, zrealizowanymi i do przyjęcia, współczynnikiem odpadowości, ceną, narzutem i udziałem w kalkulacji kosztów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `DoubleCy` | bazodanowe |  | Cena odpadu operacji zlecenia. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość odpadu operacji zlecenia. |
| IloscDoPrzyjecia | `Amount` | bazodanowe | Ilość do przyjęcia | Ilość do przyjęcia odpadu operacji zlecenia. |
| IloscDoPrzyjeciaPrzeliczona | `Amount` | bazodanowe | Ilość do przyjęcia przeliczona | Ilość do przyjęcia przeliczona na podstawową jednostkę miary dla odpadu operacji zlecenia. |
| IloscDoRealizacji | `Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji odpadu operacji zlecenia. |
| IloscDoRealizacjiPrzeliczona | `Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla odpadu operacji zlecenia. |
| IloscDoZameldowania | `Amount` | bazodanowe | Ilość do zameldowania | Ilość do zameldowania odpadu operacji zlecenia. |
| IloscDoZameldowaniaPrzeliczona | `Amount` | bazodanowe | Ilość do zameldowania przeliczona | Ilość do zameldowania przeliczona na podstawową jednostkę miary dla odpadu operacji zlecenia. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa odpadu operacji zlecenia. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla odpadu operacji zlecenia. |
| IloscZameldowana | `Amount` | bazodanowe | Ilość zameldowana | Ilość zameldowana odpadu operacji zlecenia. |
| IloscZameldowanaPrzeliczona | `Amount` | bazodanowe | Ilość zameldowana przeliczona | Ilość zameldowana przeliczona na podstawową jednostkę miary dla odpadu operacji zlecenia. |
| IloscZrealizowana | `Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana odpadu operacji zlecenia. |
| IloscZrealizowanaPrzeliczona | `Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla odpadu operacji zlecenia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa odpadu operacji zlecenia. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn odpadu operacji zlecenia. |
| Material | `Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia` | bazodanowe | Materiał | Materiał odpadu operacji zlecenia. |
| Narzut | `Percent` | bazodanowe |  | Narzut odpadu operacji zlecenia. |
| OdpadOperacjiTechnologii | `Soneta.ProdukcjaPro.ProOdpadOperacjiTechnologii` | bazodanowe | Odpad operacji technologii | Odpad operacji technologii dla odpadu operacji zlecenia. |
| OdpadyMeldunkow | `SubTable<Soneta.ProdukcjaPro.ProOdpadMeldunku>` | podlista |  |  |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla odpadu operacji zlecenia. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis odpadu operacji zlecenia. |
| PochodziZMeldunku | `bool` | bazodanowe | Pochodzi z meldunku | Odpad operacji zlecenia pochodzi z odpadu meldunku. |
| RodzajCeny | `Soneta.ProdukcjaPro.ProRodzajCeny` (enum) | bazodanowe | Rodzaj ceny | Rodzaj ceny odpadu operacji zlecenia. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar odpadu operacji zlecenia. |
| UdzialWKalkulacji | `Soneta.ProdukcjaPro.ProUdzialWKalkulacji` (enum) | bazodanowe | Udział w kalkulacji | Udział w kalkulacji odpadu operacji zlecenia. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość odpadu operacji zlecenia. |
| WartoscZameldowana | `Currency` | bazodanowe | Wartość zameldowana | Wartość zameldowana odpadu operacji zlecenia. |
| WartoscZrealizowana | `Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana odpadu operacji zlecenia. |
| Wspolczynnik | `Fraction` | bazodanowe | Współczynnik | Współczynnik odpadu operacji zlecenia. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRodzajCeny (`Soneta.ProdukcjaPro.ProRodzajCeny`)
- `None` = 0
- `OstatniaCenaPrzyjecia` = 1 — Ostatnia cena przyjęcia
- `CenaTechnologiczna` = 2 — Cena technologiczna
- `CenaWyrobu` = 4 — Cena wyrobu (z operacji poprzedzającej)
- `CenaMaterialu` = 8 — Cena materiału
- `CenaStala` = 16 — Cena stała
- `CenaReczna` = 32 — Cena podana ręcznie
- `All` = 63 — Wszystkie

### ProUdzialWKalkulacji (`Soneta.ProdukcjaPro.ProUdzialWKalkulacji`)
- `None` = 0
- `Dodaj` = 1
- `Odejmij` = 2
- `Pomin` = 4 — Pomiń
- `All` = 7 — Wszystkie
