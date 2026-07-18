# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProKalkulacjaOperacjiZlecenia`
Nazwa tabeli: `ProKalkulacjeOZ`
Tytuł: Kalkulacje operacji zleceń
Opis: Element szczegółowy kalkulacji operacji zlecenia (ProOperacjaZlecenia). Zawiera szczegółową kalkulację kosztów operacji produkcyjnej z podziałem na surowce, prefabrykaty, półprodukty, odpady, usługi, gniazda, robociznę, narzędzia i kooperacje. Dla każdej kategorii przechowuje wartość, narzut, sumę oraz wartość rzeczywistą.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe (zapisywalne): 50
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 52

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GniazdaNarzut | `Percent` | bazodanowe | Narzut gniazd | Narzut gniazd dla kalkulacji operacji zlecenia. |
| GniazdaPomin | `bool` | bazodanowe | Pomiń gniazda | Pomijanie gniazd dla kalkulacji operacji zlecenia. |
| GniazdaRazem | `Currency` | bazodanowe | Gniazda razem | Gniazda razem dla kalkulacji operacji zlecenia. |
| GniazdaRzeczywiste | `Currency` | bazodanowe | Gniazda rzeczywiste | Gniazda rzeczywiste dla kalkulacji operacji zlecenia. |
| GniazdaWartosc | `Currency` | bazodanowe | Wartość gniazd | Wartość gniazd dla kalkulacji operacji zlecenia. |
| KalkulacjaRzeczywista | `Currency` | tylko-odczyt | Rzeczywista kalkulacja | Rzeczywista kalkulacja operacji zlecenia. |
| KalkulacjaWartosc | `Currency` | tylko-odczyt | Wartość kalkulacji | Wartość kalkulacji operacji zlecenia. |
| KooperacjeNarzut | `Percent` | bazodanowe | Narzut kooperacji | Narzut kooperacji dla kalkulacji operacji zlecenia. |
| KooperacjePomin | `bool` | bazodanowe | Pomiń kooperacje | Pomijanie kooperacji dla kalkulacji operacji zlecenia. |
| KooperacjeRazem | `Currency` | bazodanowe | Kooperacja razem | Kooperacja razem dla kalkulacji operacji zlecenia. |
| KooperacjeRzeczywiste | `Currency` | bazodanowe | Kooperacje rzeczywiste | Kooperacje rzeczywiste dla kalkulacji operacji zlecenia. |
| KooperacjeWartosc | `Currency` | bazodanowe | Wartość kooperacji | Wartość kooperacji dla kalkulacji operacji zlecenia. |
| NarzedziaNarzut | `Percent` | bazodanowe | Narzut narzędzi | Narzut narzędzi dla kalkulacji operacji zlecenia. |
| NarzedziaPomin | `bool` | bazodanowe | Pomiń narzędzia | Pomijanie narzędzi dla kalkulacji operacji zlecenia. |
| NarzedziaRazem | `Currency` | bazodanowe | Narzędzia razem | Narzędzia razem dla kalkulacji operacji zlecenia. |
| NarzedziaRzeczywiste | `Currency` | bazodanowe | Narzedzia rzeczywiste | Narzedzia rzeczywiste dla kalkulacji operacji zlecenia. |
| NarzedziaWartosc | `Currency` | bazodanowe | Wartość narzędzi | Wartość narzędzi dla kalkulacji operacji zlecenia. |
| OdpadyNarzut | `Percent` | bazodanowe | Narzut odpadów | Narzut odpadów dla kalkulacji operacji zlecenia. |
| OdpadyPomin | `bool` | bazodanowe | Pomiń odpady | Pomijanie odpadów dla kalkulacji operacji zlecenia. |
| OdpadyRazem | `Currency` | bazodanowe | Odpady razem | Odpady razem dla kalkulacji operacji zlecenia. |
| OdpadyRzeczywiste | `Currency` | bazodanowe | Odpady rzeczywiste | Odpady rzeczywiste dla kalkulacji operacji zlecenia. |
| OdpadyWartosc | `Currency` | bazodanowe | Wartość odpadów | Wartość odpadów dla kalkulacji operacji zlecenia. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla kalkulacji operacji zlecenia. |
| PolproduktyNarzut | `Percent` | bazodanowe | Narzut półproduktów | Narzut półproduktów dla kalkulacji operacji zlecenia. |
| PolproduktyPomin | `bool` | bazodanowe | Pomiń półprodukty | Pomijanie półproduktów dla kalkulacji operacji zlecenia. |
| PolproduktyRazem | `Currency` | bazodanowe | Półprodukty razem | Półprodukty razem dla kalkulacji operacji zlecenia. |
| PolproduktyRzeczywiste | `Currency` | bazodanowe | Półprodukty rzeczywiste | Półprodukty rzeczywiste dla kalkulacji operacji zlecenia. |
| PolproduktyWartosc | `Currency` | bazodanowe | Wartość półproduktów | Wartość półproduktów dla kalkulacji operacji zlecenia. |
| PrefabrykatyNarzut | `Percent` | bazodanowe | Narzut prefabrykatów | Narzut prefabrykatów dla kalkulacji operacji zlecenia. |
| PrefabrykatyPomin | `bool` | bazodanowe | Pomiń prefabrykaty | Pomijanie prefabrykatów dla kalkulacji operacji zlecenia. |
| PrefabrykatyRazem | `Currency` | bazodanowe | Prefabrykaty razem | Prefabrykaty razem dla kalkulacji operacji zlecenia. |
| PrefabrykatyRzeczywiste | `Currency` | bazodanowe | Prefabrykaty rzeczywiste | Prefabrykaty rzeczywiste dla kalkulacji operacji zlecenia. |
| PrefabrykatyWartosc | `Currency` | bazodanowe | Wartość prefabrykatów | Wartość prefabrykatów dla kalkulacji operacji zlecenia. |
| RobociznaNarzut | `Percent` | bazodanowe | Narzut robocizny | Narzut robocizny dla kalkulacji operacji zlecenia. |
| RobociznaPomin | `bool` | bazodanowe | Pomiń robocizne | Pomijanie robocizny dla kalkulacji operacji zlecenia. |
| RobociznaRazem | `Currency` | bazodanowe | Robocizna razem | Robocizna razem dla kalkulacji operacji zlecenia. |
| RobociznaRzeczywista | `Currency` | bazodanowe | Robocizna rzeczywista | Robocizna rzeczywista dla kalkulacji operacji zlecenia. |
| RobociznaWartosc | `Currency` | bazodanowe | Wartość robocizny | Wartość robocizny dla kalkulacji operacji zlecenia. |
| SumaNarzut | `Percent` | bazodanowe | Narzut sumy | Narzut sumy dla kalkulacji operacji zlecenia. |
| SumaRazem | `Currency` | bazodanowe | Suma razem | Suma razem dla kalkulacji operacji zlecenia. |
| SumaRzeczywista | `Currency` | bazodanowe | Suma rzeczywista | Suma rzeczywista dla kalkulacji operacji zlecenia. |
| SumaWartosc | `Currency` | bazodanowe | Wartość sumy | Wartość sumy dla kalkulacji operacji zlecenia. |
| SurowceNarzut | `Percent` | bazodanowe | Narzut surowców | Narzut surowców dla kalkulacji operacji zlecenia. |
| SurowcePomin | `bool` | bazodanowe | Pomiń surowce | Pomijanie surowców dla kalkulacji operacji zlecenia. |
| SurowceRazem | `Currency` | bazodanowe | Surowce razem | Surowce razem dla kalkulacji operacji zlecenia. |
| SurowceRzeczywiste | `Currency` | bazodanowe | Surowce rzeczywiste | Surowce rzeczywiste dla kalkulacji operacji zlecenia. |
| SurowceWartosc | `Currency` | bazodanowe | Wartość surowców | Wartość surowców dla kalkulacji operacji zlecenia. |
| UslugiNarzut | `Percent` | bazodanowe | Narzut usług | Narzut usług dla kalkulacji operacji zlecenia. |
| UslugiPomin | `bool` | bazodanowe | Pomiń usługi | Pomijanie usług dla kalkulacji operacji zlecenia. |
| UslugiRazem | `Currency` | bazodanowe | Usługi razem | Usługi razem dla kalkulacji operacji zlecenia. |
| UslugiRzeczywiste | `Currency` | bazodanowe | Usługi rzeczywiste | Usługi rzeczywiste dla kalkulacji operacji zlecenia. |
| UslugiWartosc | `Currency` | bazodanowe | Wartość usług | Wartość usług dla kalkulacji operacji zlecenia. |
