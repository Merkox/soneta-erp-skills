# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProKalkulacjaMeldunku`
Nazwa tabeli: `ProKalkulacjeM`
Tytuł: Kalkulacje meldunku
Opis: Element szczegółowy kalkulacji meldunku (ProMeldunek). Zawiera szczegółową kalkulację kosztów meldunku produkcyjnego z podziałem na surowce, prefabrykaty, półprodukty, odpady, usługi, gniazda, robociznę, narzędzia i kooperacje. Dla każdej kategorii przechowuje wartości planowane, rzeczywiste oraz narzuty.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GniazdaNarzut | `Percent` | bazodanowe | Narzut gniazd | Narzut gniazd dla kalkulacji meldunku. |
| GniazdaPlanowane | `Currency` | bazodanowe | Gniazda planowane | Gniazda planowane dla kalkulacji meldunku. |
| GniazdaPomin | `bool` | bazodanowe | Pomiń gniazda | Pomijanie gniazd dla kalkulacji meldunku. |
| GniazdaRazem | `Currency` | bazodanowe | Gniazda razem | Gniazda razem dla kalkulacji meldunku. |
| GniazdaWartosc | `Currency` | bazodanowe | Wartość gniazd | Wartość gniazd dla kalkulacji meldunku. |
| KalkulacjaWartosc | `Currency` | tylko-odczyt | Wartość kalkulacji | Wartość kalkulacji meldunku. |
| KooperacjeNarzut | `Percent` | bazodanowe | Narzut kooperacji | Narzut kooperacji dla kalkulacji meldunku. |
| KooperacjePlanowane | `Currency` | bazodanowe | Kooperacje planowane | Kooperacje planowane dla kalkulacji meldunku. |
| KooperacjePomin | `bool` | bazodanowe | Pomiń kooperacje | Pomijanie kooperacji dla kalkulacji meldunku. |
| KooperacjeRazem | `Currency` | bazodanowe | Kooperacja razem | Kooperacja razem dla kalkulacji meldunku. |
| KooperacjeWartosc | `Currency` | bazodanowe | Wartość kooperacji | Wartość kooperacji dla kalkulacji meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla kalkulacji meldunku. |
| NarzedziaNarzut | `Percent` | bazodanowe | Narzut narzędzi | Narzut narzędzi dla kalkulacji meldunku. |
| NarzedziaPlanowane | `Currency` | bazodanowe | Narzedzia planowane | Narzedzia planowane dla kalkulacji meldunku. |
| NarzedziaPomin | `bool` | bazodanowe | Pomiń narzędzia | Pomijanie narzędzi dla kalkulacji meldunku. |
| NarzedziaRazem | `Currency` | bazodanowe | Narzędzia razem | Narzędzia razem dla kalkulacji meldunku. |
| NarzedziaWartosc | `Currency` | bazodanowe | Wartość narzędzi | Wartość narzędzi dla kalkulacji meldunku. |
| OdpadyNarzut | `Percent` | bazodanowe | Narzut odpadów | Narzut odpadów dla kalkulacji meldunku. |
| OdpadyPlanowane | `Currency` | bazodanowe | Odpady planowane | Odpady planowane dla kalkulacji meldunku. |
| OdpadyPomin | `bool` | bazodanowe | Pomiń odpady | Pomijanie odpadów dla kalkulacji meldunku. |
| OdpadyRazem | `Currency` | bazodanowe | Odpady razem | Odpady razem dla kalkulacji meldunku. |
| OdpadyWartosc | `Currency` | bazodanowe | Wartość odpadów | Wartość odpadów dla kalkulacji meldunku. |
| PolproduktyNarzut | `Percent` | bazodanowe | Narzut półproduktów | Narzut półproduktów dla kalkulacji meldunku. |
| PolproduktyPlanowane | `Currency` | bazodanowe | Półprodukty planowane | Półprodukty planowane dla kalkulacji meldunku. |
| PolproduktyPomin | `bool` | bazodanowe | Pomiń półprodukty | Pomijanie półproduktów dla kalkulacji meldunku. |
| PolproduktyRazem | `Currency` | bazodanowe | Półprodukty razem | Półprodukty razem dla kalkulacji meldunku. |
| PolproduktyWartosc | `Currency` | bazodanowe | Wartość półproduktów | Wartość półproduktów dla kalkulacji meldunku. |
| PrefabrykatyNarzut | `Percent` | bazodanowe | Narzut prefabrykatów | Narzut prefabrykatów dla kalkulacji meldunku. |
| PrefabrykatyPlanowane | `Currency` | bazodanowe | Prefabrykaty planowane | Prefabrykaty planowane dla kalkulacji meldunku. |
| PrefabrykatyPomin | `bool` | bazodanowe | Pomiń prefabrykaty | Pomijanie prefabrykatów dla kalkulacji meldunku. |
| PrefabrykatyRazem | `Currency` | bazodanowe | Prefabrykaty razem | Prefabrykaty razem dla kalkulacji meldunku. |
| PrefabrykatyWartosc | `Currency` | bazodanowe | Wartość prefabrykatów | Wartość prefabrykatów dla kalkulacji meldunku. |
| RobociznaNarzut | `Percent` | bazodanowe | Narzut robocizny | Narzut robocizny dla kalkulacji meldunku. |
| RobociznaPlanowana | `Currency` | bazodanowe | Robocizna planowana | Robocizna planowana dla kalkulacji meldunku. |
| RobociznaPomin | `bool` | bazodanowe | Pomiń robocizne | Pomijanie robocizny dla kalkulacji meldunku. |
| RobociznaRazem | `Currency` | bazodanowe | Robocizna razem | Robocizna razem dla kalkulacji meldunku. |
| RobociznaWartosc | `Currency` | bazodanowe | Wartość robocizny | Wartość robocizny dla kalkulacji meldunku. |
| SumaNarzut | `Percent` | bazodanowe | Narzut sumy | Narzut sumy dla kalkulacji meldunku. |
| SumaPlanowana | `Currency` | bazodanowe | Suma planowana | Suma planowana dla kalkulacji meldunku. |
| SumaRazem | `Currency` | bazodanowe | Suma razem | Suma razem dla kalkulacji meldunku. |
| SumaWartosc | `Currency` | bazodanowe | Wartość sumy | Wartość sumy dla kalkulacji meldunku. |
| SurowceNarzut | `Percent` | bazodanowe | Narzut surowców | Narzut surowców dla kalkulacji meldunku. |
| SurowcePlanowane | `Currency` | bazodanowe | Surowce planowane | Surowce planowane dla kalkulacji meldunku. |
| SurowcePomin | `bool` | bazodanowe | Pomiń surowce | Pomijanie surowców dla kalkulacji meldunku. |
| SurowceRazem | `Currency` | bazodanowe | Surowce razem | Surowce razem dla kalkulacji meldunku. |
| SurowceWartosc | `Currency` | bazodanowe | Wartość surowców | Wartość surowców dla kalkulacji meldunku. |
| UslugiNarzut | `Percent` | bazodanowe | Narzut usług | Narzut usług dla kalkulacji meldunku. |
| UslugiPlanowane | `Currency` | bazodanowe | Usługi planowane | Usługi planowane dla kalkulacji meldunku. |
| UslugiPomin | `bool` | bazodanowe | Pomiń usługi | Pomijanie usług dla kalkulacji meldunku. |
| UslugiRazem | `Currency` | bazodanowe | Usługi razem | Usługi razem dla kalkulacji meldunku. |
| UslugiWartosc | `Currency` | bazodanowe | Wartość usług | Wartość usług dla kalkulacji meldunku. |
