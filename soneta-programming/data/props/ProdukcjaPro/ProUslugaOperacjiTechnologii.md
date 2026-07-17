# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProUslugaOperacjiTechnologii`
Nazwa tabeli: `ProUslugiOT`
Tytuł: Usługi operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Definiuje usługę obcą (kooperację) wymaganą w operacji technologicznej z normą ilościową, ceną jednostkową, narzutem oraz parametrami dostępności i kalkulacji kosztów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CechaDostepnosci | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha dostępności | Cecha dostępności usługi operacji technologii. |
| CechaIlosci | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha ilości | Cecha ilości usługi operacji technologii. |
| CechaTowaru | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha towaru | Cecha towaru usługi operacji technologii. |
| Cena | `Soneta.Types.DoubleCy` | bazodanowe |  | Cena usługi operacji technologii. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość usługi operacji technologii. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa usługi operacji technologii. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla usługi operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa usługi operacji technologii. |
| Narzut | `Soneta.Types.Percent` | bazodanowe |  | Narzut usługi operacji technologii. |
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla usługi operacji technologii. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` |  | Operacja technologii | Operacja technologii dla usługi operacji technologii. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis usługi operacji technologii. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji usługi operacji technologii. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar usługi operacji technologii. |
| UslugiOperacjiZlecen | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProUslugaOperacjiZlecenia>` |  |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość usługi operacji technologii. |
