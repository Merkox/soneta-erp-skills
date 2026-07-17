# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProKalkulacjaOperacjiZlecenia`
Nazwa tabeli: `ProKalkulacjeOZ`
Tytuł: Kalkulacje operacji zleceń
Opis: Element szczegółowy kalkulacji operacji zlecenia (ProOperacjaZlecenia). Zawiera szczegółową kalkulację kosztów operacji produkcyjnej z podziałem na surowce, prefabrykaty, półprodukty, odpady, usługi, gniazda, robociznę, narzędzia i kooperacje. Dla każdej kategorii przechowuje wartość, narzut, sumę oraz wartość rzeczywistą.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe: 50
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GniazdaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut gniazd | Narzut gniazd dla kalkulacji operacji zlecenia. |
| GniazdaPomin | `bool` | bazodanowe | Pomiń gniazda | Pomijanie gniazd dla kalkulacji operacji zlecenia. |
| GniazdaRazem | `Soneta.Types.Currency` | bazodanowe | Gniazda razem | Gniazda razem dla kalkulacji operacji zlecenia. |
| GniazdaRzeczywiste | `Soneta.Types.Currency` | bazodanowe | Gniazda rzeczywiste | Gniazda rzeczywiste dla kalkulacji operacji zlecenia. |
| GniazdaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość gniazd | Wartość gniazd dla kalkulacji operacji zlecenia. |
| KalkulacjaRzeczywista | `Soneta.Types.Currency` |  | Rzeczywista kalkulacja | Rzeczywista kalkulacja operacji zlecenia. |
| KalkulacjaWartosc | `Soneta.Types.Currency` |  | Wartość kalkulacji | Wartość kalkulacji operacji zlecenia. |
| KooperacjeNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut kooperacji | Narzut kooperacji dla kalkulacji operacji zlecenia. |
| KooperacjePomin | `bool` | bazodanowe | Pomiń kooperacje | Pomijanie kooperacji dla kalkulacji operacji zlecenia. |
| KooperacjeRazem | `Soneta.Types.Currency` | bazodanowe | Kooperacja razem | Kooperacja razem dla kalkulacji operacji zlecenia. |
| KooperacjeRzeczywiste | `Soneta.Types.Currency` | bazodanowe | Kooperacje rzeczywiste | Kooperacje rzeczywiste dla kalkulacji operacji zlecenia. |
| KooperacjeWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość kooperacji | Wartość kooperacji dla kalkulacji operacji zlecenia. |
| NarzedziaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut narzędzi | Narzut narzędzi dla kalkulacji operacji zlecenia. |
| NarzedziaPomin | `bool` | bazodanowe | Pomiń narzędzia | Pomijanie narzędzi dla kalkulacji operacji zlecenia. |
| NarzedziaRazem | `Soneta.Types.Currency` | bazodanowe | Narzędzia razem | Narzędzia razem dla kalkulacji operacji zlecenia. |
| NarzedziaRzeczywiste | `Soneta.Types.Currency` | bazodanowe | Narzedzia rzeczywiste | Narzedzia rzeczywiste dla kalkulacji operacji zlecenia. |
| NarzedziaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość narzędzi | Wartość narzędzi dla kalkulacji operacji zlecenia. |
| OdpadyNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut odpadów | Narzut odpadów dla kalkulacji operacji zlecenia. |
| OdpadyPomin | `bool` | bazodanowe | Pomiń odpady | Pomijanie odpadów dla kalkulacji operacji zlecenia. |
| OdpadyRazem | `Soneta.Types.Currency` | bazodanowe | Odpady razem | Odpady razem dla kalkulacji operacji zlecenia. |
| OdpadyRzeczywiste | `Soneta.Types.Currency` | bazodanowe | Odpady rzeczywiste | Odpady rzeczywiste dla kalkulacji operacji zlecenia. |
| OdpadyWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość odpadów | Wartość odpadów dla kalkulacji operacji zlecenia. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla kalkulacji operacji zlecenia. |
| PolproduktyNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut półproduktów | Narzut półproduktów dla kalkulacji operacji zlecenia. |
| PolproduktyPomin | `bool` | bazodanowe | Pomiń półprodukty | Pomijanie półproduktów dla kalkulacji operacji zlecenia. |
| PolproduktyRazem | `Soneta.Types.Currency` | bazodanowe | Półprodukty razem | Półprodukty razem dla kalkulacji operacji zlecenia. |
| PolproduktyRzeczywiste | `Soneta.Types.Currency` | bazodanowe | Półprodukty rzeczywiste | Półprodukty rzeczywiste dla kalkulacji operacji zlecenia. |
| PolproduktyWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość półproduktów | Wartość półproduktów dla kalkulacji operacji zlecenia. |
| PrefabrykatyNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut prefabrykatów | Narzut prefabrykatów dla kalkulacji operacji zlecenia. |
| PrefabrykatyPomin | `bool` | bazodanowe | Pomiń prefabrykaty | Pomijanie prefabrykatów dla kalkulacji operacji zlecenia. |
| PrefabrykatyRazem | `Soneta.Types.Currency` | bazodanowe | Prefabrykaty razem | Prefabrykaty razem dla kalkulacji operacji zlecenia. |
| PrefabrykatyRzeczywiste | `Soneta.Types.Currency` | bazodanowe | Prefabrykaty rzeczywiste | Prefabrykaty rzeczywiste dla kalkulacji operacji zlecenia. |
| PrefabrykatyWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość prefabrykatów | Wartość prefabrykatów dla kalkulacji operacji zlecenia. |
| RobociznaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut robocizny | Narzut robocizny dla kalkulacji operacji zlecenia. |
| RobociznaPomin | `bool` | bazodanowe | Pomiń robocizne | Pomijanie robocizny dla kalkulacji operacji zlecenia. |
| RobociznaRazem | `Soneta.Types.Currency` | bazodanowe | Robocizna razem | Robocizna razem dla kalkulacji operacji zlecenia. |
| RobociznaRzeczywista | `Soneta.Types.Currency` | bazodanowe | Robocizna rzeczywista | Robocizna rzeczywista dla kalkulacji operacji zlecenia. |
| RobociznaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość robocizny | Wartość robocizny dla kalkulacji operacji zlecenia. |
| SumaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut sumy | Narzut sumy dla kalkulacji operacji zlecenia. |
| SumaRazem | `Soneta.Types.Currency` | bazodanowe | Suma razem | Suma razem dla kalkulacji operacji zlecenia. |
| SumaRzeczywista | `Soneta.Types.Currency` | bazodanowe | Suma rzeczywista | Suma rzeczywista dla kalkulacji operacji zlecenia. |
| SumaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość sumy | Wartość sumy dla kalkulacji operacji zlecenia. |
| SurowceNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut surowców | Narzut surowców dla kalkulacji operacji zlecenia. |
| SurowcePomin | `bool` | bazodanowe | Pomiń surowce | Pomijanie surowców dla kalkulacji operacji zlecenia. |
| SurowceRazem | `Soneta.Types.Currency` | bazodanowe | Surowce razem | Surowce razem dla kalkulacji operacji zlecenia. |
| SurowceRzeczywiste | `Soneta.Types.Currency` | bazodanowe | Surowce rzeczywiste | Surowce rzeczywiste dla kalkulacji operacji zlecenia. |
| SurowceWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość surowców | Wartość surowców dla kalkulacji operacji zlecenia. |
| UslugiNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut usług | Narzut usług dla kalkulacji operacji zlecenia. |
| UslugiPomin | `bool` | bazodanowe | Pomiń usługi | Pomijanie usług dla kalkulacji operacji zlecenia. |
| UslugiRazem | `Soneta.Types.Currency` | bazodanowe | Usługi razem | Usługi razem dla kalkulacji operacji zlecenia. |
| UslugiRzeczywiste | `Soneta.Types.Currency` | bazodanowe | Usługi rzeczywiste | Usługi rzeczywiste dla kalkulacji operacji zlecenia. |
| UslugiWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość usług | Wartość usług dla kalkulacji operacji zlecenia. |
