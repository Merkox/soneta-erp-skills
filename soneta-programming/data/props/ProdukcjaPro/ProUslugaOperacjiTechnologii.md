# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProUslugaOperacjiTechnologii`
Nazwa tabeli: `ProUslugiOT`
Tytuł: Usługi operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Definiuje usługę obcą (kooperację) wymaganą w operacji technologicznej z normą ilościową, ceną jednostkową, narzutem oraz parametrami dostępności i kalkulacji kosztów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CechaDostepnosci | `FeatureDefinition` | bazodanowe | Cecha dostępności | Cecha dostępności usługi operacji technologii. |
| CechaIlosci | `FeatureDefinition` | bazodanowe | Cecha ilości | Cecha ilości usługi operacji technologii. |
| CechaTowaru | `FeatureDefinition` | bazodanowe | Cecha towaru | Cecha towaru usługi operacji technologii. |
| Cena | `DoubleCy` | bazodanowe |  | Cena usługi operacji technologii. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość usługi operacji technologii. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa usługi operacji technologii. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla usługi operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa usługi operacji technologii. |
| Narzut | `Percent` | bazodanowe |  | Narzut usługi operacji technologii. |
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla usługi operacji technologii. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | tylko-odczyt | Operacja technologii | Operacja technologii dla usługi operacji technologii. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis usługi operacji technologii. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji usługi operacji technologii. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar usługi operacji technologii. |
| UslugiOperacjiZlecen | `SubTable<Soneta.ProdukcjaPro.ProUslugaOperacjiZlecenia>` | podlista |  |  |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość usługi operacji technologii. |
