# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOdpadOperacjiTechnologii`
Nazwa tabeli: `ProOdpadyOT`
Tytuł: Odpady operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Definiuje planowany odpad lub produkt uboczny powstający w operacji technologicznej z normą ilościową, współczynnikiem odpadowości względem materiału, magazynem docelowym, ceną i udziałem w kalkulacji kosztów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CechaDostepnosci | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha dostępności | Cecha dostępności odpadu operacji technologii. |
| CechaIlosci | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha ilości | Cecha ilości odpadu operacji technologii. |
| CechaTowaru | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha towaru | Cecha towaru odpadu operacji technologii. |
| Cena | `Soneta.Types.DoubleCy` | bazodanowe |  | Cena odpadu operacji technologii. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość odpadu operacji technologii. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa odpadu operacji technologii. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla odpadu operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa odpadu operacji technologii. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn odpadu operacji technologii. |
| Material | `Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii` | bazodanowe | Materiał | Materiał odpadu operacji technologii. |
| Narzut | `Soneta.Types.Percent` | bazodanowe |  | Narzut odpadu operacji technologii. |
| OdpadyOperacjiZlecen | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiZlecenia>` |  |  |  |
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla odpadu operacji technologii. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` |  | Operacja technologii | Operacja technologii dla odpadu operacji technologii. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis odpadu operacji technologii. |
| RodzajCeny | `Soneta.ProdukcjaPro.ProRodzajCeny` | bazodanowe, enum | Rodzaj ceny | Rodzaj ceny odpadu operacji technologii. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar odpadu operacji technologii. |
| UdzialWKalkulacji | `Soneta.ProdukcjaPro.ProUdzialWKalkulacji` | bazodanowe, enum | Udział w kalkulacji | Udział w kalkulacji odpadu operacji technologii. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość odpadu operacji technologii. |
| Wspolczynnik | `Soneta.Types.Fraction` | bazodanowe | Współczynnik | Współczynnik odpadu operacji technologii. |

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
