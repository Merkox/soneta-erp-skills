# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii`
Nazwa tabeli: `ProMaterialyOT`
Tytuł: Materiały operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Definiuje surowiec lub komponent wymagany w operacji technologicznej z normą ilościową, ceną, magazynem źródłowym, narzutem oraz parametrami automatycznego generowania zleceń i zapotrzebowań.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

- pola bazodanowe: 23
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CechaDostepnosci | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha dostępności | Cecha dostępności materiału operacji technologii. |
| CechaIlosci | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha ilości | Cecha ilości materiału operacji technologii. |
| CechaTowaru | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha towaru | Cecha towaru materiału operacji technologii. |
| Cena | `Soneta.Types.DoubleCy` | bazodanowe |  | Cena materiału operacji technologii. |
| GenerujZapotrzebowanie | `bool` | bazodanowe | Generuj zapotrzebowanie | Generowanie zapotrzebowania dla materiału operacji technologii. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość materiału operacji technologii. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa materiału operacji technologii. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla materiału operacji technologii. |
| IloscStala | `bool` | bazodanowe | Ilość stała | Ilość stała materiału operacji technologii. |
| IloscWyrobow | `Soneta.Types.Amount` |  | Ilość wyrobów | Powiązana ilość wyrobów dla materiału operacji tecnologii. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność ilości stałej materiału operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa materiału operacji technologii. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn materiału operacji technologii. |
| MaterialyOperacjiZlecen | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia>` |  |  |  |
| Narzut | `Soneta.Types.Percent` | bazodanowe |  | Narzut materiału operacji technologii. |
| Odpady | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiTechnologii>` |  |  |  |
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla materiału operacji technologii. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` |  | Operacja technologii | Operacja technologii dla materiału operacji technologii. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis materiału operacji technologii. |
| Polprodukt | `Soneta.ProdukcjaPro.ProWyrobOperacjiTechnologii` |  | Półprodukt | Pierwszy powiązany półprodukt materiału operacji technologii. |
| PominAutomatyczneZlecenie | `bool` | bazodanowe | Pomiń automatyczne zlecenie | Pomijanie w algorytmie automatycznego generowania zlecenia powiązanego dla materiału operacji technologii. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji materiału operacji technologii. |
| PozycjaZestawieniaMaterialow | `Soneta.ProdukcjaPro.ProPozycjaZestawieniaMaterialow` | bazodanowe | Pozycja zestawienia | Pozycja zestawienia materiałów dla materiału operacji technologii. |
| RelacjeMaterialWyrob | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiTechnologii>` |  |  |  |
| RodzajCeny | `Soneta.ProdukcjaPro.ProRodzajCeny` | bazodanowe, enum | Rodzaj ceny | Rodzaj ceny materiału operacji technologii. |
| RozliczFantomowo | `bool` | bazodanowe | Rozlicz fantomowo | Rozlicz fantomowo materiał operacji technologii. |
| TechnologiaMaterialu | `Soneta.ProdukcjaPro.ProTechnologia` |  | Technologia materiału | Powiązana technologia materiału. |
| TechnologieMaterialu | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProTechnologiaMaterialuOperacjiTechnologii>` |  |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar materiału operacji technologii. |
| Typ | `Soneta.ProdukcjaPro.ProTypMaterialu` | bazodanowe, enum | Typ materiału | Typ materiału operacji technologii. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość materiału operacji technologii. |

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

### ProTypMaterialu (`Soneta.ProdukcjaPro.ProTypMaterialu`)
- `None` = 0
- `Surowiec` = 1
- `Prefabrykat` = 2
- `Polprodukt` = 4 — Półprodukt (z operacji poprzedzającej)
- `All` = 7 — Wszystkie
