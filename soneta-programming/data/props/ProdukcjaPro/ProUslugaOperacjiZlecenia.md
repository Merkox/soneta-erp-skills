# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProUslugaOperacjiZlecenia`
Nazwa tabeli: `ProUslugiOZ`
Tytuł: Usługi operacji zleceń
Opis: Element szczegółowy operacji zlecenia (ProOperacjaZlecenia). Definiuje usługę obcą (kooperację) wymaganą w operacji zlecenia z ilościami planowanymi, zameldowanymi i do zameldowania, ceną, narzutem, wartością zameldowaną oraz parametrami kalkulacji kosztów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `Soneta.Types.DoubleCy` | bazodanowe |  | Cena usługi operacji zlecenia. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość usługi operacji zlecenia. |
| IloscDoZameldowania | `Soneta.Types.Amount` | bazodanowe | Ilość do zameldowania | Ilość do zameldowania usługi operacji zlecenia. |
| IloscDoZameldowaniaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do zameldowania przeliczona | Ilość do zameldowania przeliczona na podstawową jednostkę miary dla usługi operacji zlecenia. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa usługi operacji zlecenia. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla usługi operacji zlecenia. |
| IloscZameldowana | `Soneta.Types.Amount` | bazodanowe | Ilość zameldowana | Ilość zameldowana usługi operacji zlecenia. |
| IloscZameldowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość zameldowana przeliczona | Ilość zameldowana przeliczona na podstawową jednostkę miary dla usługi operacji zlecenia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa usługi operacji zlecenia. |
| Narzut | `Soneta.Types.Percent` | bazodanowe |  | Narzut usługi operacji zlecenia. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla usługi operacji zlecenia. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis usługi operacji zlecenia. |
| PochodziZMeldunku | `bool` | bazodanowe | Pochodzi z meldunku | Usługa operacji zlecenia pochodzi z usługi meldunku. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji usługi operacji zlecenia. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar usługi operacji zlecenia. |
| UslugaOperacjiTechnologii | `Soneta.ProdukcjaPro.ProUslugaOperacjiTechnologii` | bazodanowe | Usługa operacji technologii | Usługa operacji technologii dla usługi operacji zlecenia. |
| UslugiMeldunkow | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProUslugaMeldunku>` |  |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość usługi operacji zlecenia. |
| WartoscZameldowana | `Soneta.Types.Currency` | bazodanowe | Wartość zameldowana | Wartość zameldowana usługi operacji zlecenia. |
