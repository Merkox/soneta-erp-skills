# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProUslugaMeldunku`
Nazwa tabeli: `ProUslugiM`
Tytuł: Usługi meldunków
Opis: Element szczegółowy usługi meldunku (ProMeldunek). Rejestruje usługę zewnętrzną wykorzystaną w ramach meldunku produkcyjnego. Przechowuje informacje o towarze, ilościach planowanych i rzeczywistych, cenach, narzutach oraz wartościach usługi.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `Soneta.Types.DoubleCy` | bazodanowe |  | Cena usługi meldunku. |
| CenaPlanowana | `Soneta.Types.DoubleCy` | bazodanowe | Cena planowana | Cena planowana usługi meldunku. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość usługi meldunku. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa usługi meldunku. |
| IloscJednostkowaPlanowana | `double` | bazodanowe | Ilość jednostkowa planowana | Ilość jednostkowa planowana usługi meldunku. |
| IloscPlanowana | `Soneta.Types.Amount` | bazodanowe | Ilość planowana | Ilość planowana usługi meldunku. |
| IloscPlanowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość planowana przeliczona | Ilość planowana przeliczona na podstawową jednostkę miary dla usługi meldunku. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla usługi meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa usługi meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla usługi meldunku. |
| NarzutPlanowany | `Soneta.Types.Percent` | bazodanowe | Narzut planowany | Narzut planowany usługi meldunku |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis usługi meldunku. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji usługi meldunku. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar usługi meldunku. |
| UslugaOperacjiZlecenia | `Soneta.ProdukcjaPro.ProUslugaOperacjiZlecenia` | bazodanowe | Usługa operacji zlecenia | Usługa operacji zlecenia dla usługi meldunku. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość usługi meldunku. |
| WartoscPlanowana | `Soneta.Types.Currency` | bazodanowe | Wartość planowana | Wartość planowana usługi meldunku. |
