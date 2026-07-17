# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia`
Nazwa tabeli: `ProMaterialyOZ`
Tytuł: Materiały operacji zleceń
Opis: Element szczegółowy operacji zlecenia (ProOperacjaZlecenia). Definiuje zapotrzebowanie materiałowe operacji zlecenia z ilościami planowanymi, zameldowanymi, zrealizowanymi i do rozchodowania, ceną, narzutem oraz powiązaniem z technologią i zestawieniem materiałowym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe: 38
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `Soneta.Types.DoubleCy` | bazodanowe |  | Cena materiału operacji zlecenia. |
| GenerujZapotrzebowanie | `bool` | bazodanowe | Generuj zapotrzebowanie | Generowanie zapotrzebowania dla materiału operacji zlecenia. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość materiału operacji zlecenia. |
| IloscDoRealizacji | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji materiału operacji zlecenia. |
| IloscDoRealizacjiPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscDoRozchodowania | `Soneta.Types.Amount` | bazodanowe | Ilość do rozchodowania | Ilość do rozchodowania materiału operacji zlecenia. |
| IloscDoRozchodowaniaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do rozchodowania przeliczona | Ilość do rozchodowania przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscDoUruchomienia | `Soneta.Types.Amount` |  | Ilość do uruchomienia | Ilość zleceń powiązanych do uruchomienia. |
| IloscDoZameldowania | `Soneta.Types.Amount` | bazodanowe | Ilość do zameldowania | Ilość do zameldowania materiału operacji zlecenia. |
| IloscDoZameldowaniaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do zameldowania przeliczona | Ilość do zameldowania przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscDoZaopatrzenia | `Soneta.Types.Amount` | bazodanowe | Ilość do zaopatrzenia | Ilość do zaopatrzenia materiału operacji zlecenia. |
| IloscDoZaopatrzeniaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do zaopatrzenia przeliczona | Ilość do zaopatrzenia przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa materiału operacji zlecenia. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscStala | `bool` | bazodanowe | Ilość stała | Ilość stała materiału operacji zlecenia. |
| IloscUruchomiona | `Soneta.Types.Amount` |  | Ilość uruchomiona | Ilość uruchomiona na zleceniach powiązanych. |
| IloscWyrobow | `Soneta.Types.Amount` |  | Ilość wyrobów | Powiązana ilość wyrobów dla materiału operacji zlecenia. |
| IloscZameldowana | `Soneta.Types.Amount` | bazodanowe | Ilość zameldowana | Ilość zameldowana materiału operacji zlecenia. |
| IloscZameldowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość zameldowana przeliczona | Ilość zameldowana przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscZapotrzebowan | `Soneta.Types.Amount` | bazodanowe | Ilość zapotrzebowań | Ilość zapotrzebowań materiału operacji zlecenia. |
| IloscZapotrzebowanPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość zapotrzebowań przeliczona | Ilość zapotrzebowań przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscZrealizowana | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana materiału operacji zlecenia. |
| IloscZrealizowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność ilości stałej materiału operacji zlecenia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa materiału operacji zlecenia. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn materiału operacji zlecenia. |
| MaterialOperacjiTechnologii | `Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii` | bazodanowe | Materiał operacji technologii | Materiał operacji technologii dla materiału operacji zlecenia. |
| MaterialyMeldunkow | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProMaterialMeldunku>` |  |  |  |
| Narzut | `Soneta.Types.Percent` | bazodanowe |  | Narzut materiału operacji zlecenia. |
| Odpady | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiZlecenia>` |  |  |  |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla materiału operacji zlecenia. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis materiału operacji zlecenia. |
| PochodziZMeldunku | `bool` | bazodanowe | Pochodzi z meldunku | Materiał operacji zlecenia pochodzi z materiału meldunku. |
| Polprodukt | `Soneta.ProdukcjaPro.ProWyrobOperacjiZlecenia` |  | Półprodukt | Pierwszy powiązany półprodukt materiału operacji zlecenia. |
| PominAutomatyczneZlecenie | `bool` | bazodanowe | Pomiń automatyczne zlecenie | Pomijanie w algorytmie automatycznego generowania zlecenia powiązanego dla materiału operacji zlecenia. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji materiału operacji zlecenia. |
| PozycjaZestawieniaMaterialow | `Soneta.ProdukcjaPro.ProPozycjaZestawieniaMaterialow` | bazodanowe | Pozycja zestawienia | Pozycja zestawienia materiałów dla materiału operacji zlecenia. |
| RelacjeMaterialWyrob | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiZlecenia>` |  |  |  |
| RodzajCeny | `Soneta.ProdukcjaPro.ProRodzajCeny` | bazodanowe, enum | Rodzaj ceny | Rodzaj ceny materiału operacji zlecenia. |
| RozliczFantomowo | `bool` | bazodanowe | Rozlicz fantomowo | Rozlicz fantomowo materiał operacji zlecenia. |
| RozliczeniaZapotrzebowan | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProRozliczenieZapotrzebowania>` |  |  |  |
| TechnologiaMaterialu | `Soneta.ProdukcjaPro.ProTechnologia` |  | Technologia materiału | Powiązana technologia materiału. |
| TechnologieMaterialu | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProTechnologiaMaterialuOperacjiZlecenia>` |  |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar materiału operacji zlecenia. |
| Typ | `Soneta.ProdukcjaPro.ProTypMaterialu` | bazodanowe, enum | Typ materiału | Typ materiału operacji zlecenia. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość materiału operacji zlecenia. |
| WartoscZameldowana | `Soneta.Types.Currency` | bazodanowe | Wartość zameldowana | Wartość zameldowana materiału operacji zlecenia. |
| WartoscZrealizowana | `Soneta.Types.Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana materiału operacji zlecenia. |

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
