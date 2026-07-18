# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProUslugaMeldunku`
Nazwa tabeli: `ProUslugiM`
Tytuł: Usługi meldunków
Opis: Element szczegółowy usługi meldunku (ProMeldunek). Rejestruje usługę zewnętrzną wykorzystaną w ramach meldunku produkcyjnego. Przechowuje informacje o towarze, ilościach planowanych i rzeczywistych, cenach, narzutach oraz wartościach usługi.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `DoubleCy` | bazodanowe |  | Cena usługi meldunku. |
| CenaPlanowana | `DoubleCy` | bazodanowe | Cena planowana | Cena planowana usługi meldunku. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość usługi meldunku. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa usługi meldunku. |
| IloscJednostkowaPlanowana | `double` | bazodanowe | Ilość jednostkowa planowana | Ilość jednostkowa planowana usługi meldunku. |
| IloscPlanowana | `Amount` | bazodanowe | Ilość planowana | Ilość planowana usługi meldunku. |
| IloscPlanowanaPrzeliczona | `Amount` | bazodanowe | Ilość planowana przeliczona | Ilość planowana przeliczona na podstawową jednostkę miary dla usługi meldunku. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla usługi meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa usługi meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla usługi meldunku. |
| NarzutPlanowany | `Percent` | bazodanowe | Narzut planowany | Narzut planowany usługi meldunku |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis usługi meldunku. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji usługi meldunku. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar usługi meldunku. |
| UslugaOperacjiZlecenia | `Soneta.ProdukcjaPro.ProUslugaOperacjiZlecenia` | bazodanowe | Usługa operacji zlecenia | Usługa operacji zlecenia dla usługi meldunku. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość usługi meldunku. |
| WartoscPlanowana | `Currency` | bazodanowe | Wartość planowana | Wartość planowana usługi meldunku. |
