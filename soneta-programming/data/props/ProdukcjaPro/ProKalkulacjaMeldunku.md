# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProKalkulacjaMeldunku`
Nazwa tabeli: `ProKalkulacjeM`
Tytuł: Kalkulacje meldunku
Opis: Element szczegółowy kalkulacji meldunku (ProMeldunek). Zawiera szczegółową kalkulację kosztów meldunku produkcyjnego z podziałem na surowce, prefabrykaty, półprodukty, odpady, usługi, gniazda, robociznę, narzędzia i kooperacje. Dla każdej kategorii przechowuje wartości planowane, rzeczywiste oraz narzuty.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

- pola bazodanowe: 50
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GniazdaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut gniazd | Narzut gniazd dla kalkulacji meldunku. |
| GniazdaPlanowane | `Soneta.Types.Currency` | bazodanowe | Gniazda planowane | Gniazda planowane dla kalkulacji meldunku. |
| GniazdaPomin | `bool` | bazodanowe | Pomiń gniazda | Pomijanie gniazd dla kalkulacji meldunku. |
| GniazdaRazem | `Soneta.Types.Currency` | bazodanowe | Gniazda razem | Gniazda razem dla kalkulacji meldunku. |
| GniazdaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość gniazd | Wartość gniazd dla kalkulacji meldunku. |
| KalkulacjaWartosc | `Soneta.Types.Currency` |  | Wartość kalkulacji | Wartość kalkulacji meldunku. |
| KooperacjeNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut kooperacji | Narzut kooperacji dla kalkulacji meldunku. |
| KooperacjePlanowane | `Soneta.Types.Currency` | bazodanowe | Kooperacje planowane | Kooperacje planowane dla kalkulacji meldunku. |
| KooperacjePomin | `bool` | bazodanowe | Pomiń kooperacje | Pomijanie kooperacji dla kalkulacji meldunku. |
| KooperacjeRazem | `Soneta.Types.Currency` | bazodanowe | Kooperacja razem | Kooperacja razem dla kalkulacji meldunku. |
| KooperacjeWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość kooperacji | Wartość kooperacji dla kalkulacji meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla kalkulacji meldunku. |
| NarzedziaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut narzędzi | Narzut narzędzi dla kalkulacji meldunku. |
| NarzedziaPlanowane | `Soneta.Types.Currency` | bazodanowe | Narzedzia planowane | Narzedzia planowane dla kalkulacji meldunku. |
| NarzedziaPomin | `bool` | bazodanowe | Pomiń narzędzia | Pomijanie narzędzi dla kalkulacji meldunku. |
| NarzedziaRazem | `Soneta.Types.Currency` | bazodanowe | Narzędzia razem | Narzędzia razem dla kalkulacji meldunku. |
| NarzedziaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość narzędzi | Wartość narzędzi dla kalkulacji meldunku. |
| OdpadyNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut odpadów | Narzut odpadów dla kalkulacji meldunku. |
| OdpadyPlanowane | `Soneta.Types.Currency` | bazodanowe | Odpady planowane | Odpady planowane dla kalkulacji meldunku. |
| OdpadyPomin | `bool` | bazodanowe | Pomiń odpady | Pomijanie odpadów dla kalkulacji meldunku. |
| OdpadyRazem | `Soneta.Types.Currency` | bazodanowe | Odpady razem | Odpady razem dla kalkulacji meldunku. |
| OdpadyWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość odpadów | Wartość odpadów dla kalkulacji meldunku. |
| PolproduktyNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut półproduktów | Narzut półproduktów dla kalkulacji meldunku. |
| PolproduktyPlanowane | `Soneta.Types.Currency` | bazodanowe | Półprodukty planowane | Półprodukty planowane dla kalkulacji meldunku. |
| PolproduktyPomin | `bool` | bazodanowe | Pomiń półprodukty | Pomijanie półproduktów dla kalkulacji meldunku. |
| PolproduktyRazem | `Soneta.Types.Currency` | bazodanowe | Półprodukty razem | Półprodukty razem dla kalkulacji meldunku. |
| PolproduktyWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość półproduktów | Wartość półproduktów dla kalkulacji meldunku. |
| PrefabrykatyNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut prefabrykatów | Narzut prefabrykatów dla kalkulacji meldunku. |
| PrefabrykatyPlanowane | `Soneta.Types.Currency` | bazodanowe | Prefabrykaty planowane | Prefabrykaty planowane dla kalkulacji meldunku. |
| PrefabrykatyPomin | `bool` | bazodanowe | Pomiń prefabrykaty | Pomijanie prefabrykatów dla kalkulacji meldunku. |
| PrefabrykatyRazem | `Soneta.Types.Currency` | bazodanowe | Prefabrykaty razem | Prefabrykaty razem dla kalkulacji meldunku. |
| PrefabrykatyWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość prefabrykatów | Wartość prefabrykatów dla kalkulacji meldunku. |
| RobociznaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut robocizny | Narzut robocizny dla kalkulacji meldunku. |
| RobociznaPlanowana | `Soneta.Types.Currency` | bazodanowe | Robocizna planowana | Robocizna planowana dla kalkulacji meldunku. |
| RobociznaPomin | `bool` | bazodanowe | Pomiń robocizne | Pomijanie robocizny dla kalkulacji meldunku. |
| RobociznaRazem | `Soneta.Types.Currency` | bazodanowe | Robocizna razem | Robocizna razem dla kalkulacji meldunku. |
| RobociznaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość robocizny | Wartość robocizny dla kalkulacji meldunku. |
| SumaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut sumy | Narzut sumy dla kalkulacji meldunku. |
| SumaPlanowana | `Soneta.Types.Currency` | bazodanowe | Suma planowana | Suma planowana dla kalkulacji meldunku. |
| SumaRazem | `Soneta.Types.Currency` | bazodanowe | Suma razem | Suma razem dla kalkulacji meldunku. |
| SumaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość sumy | Wartość sumy dla kalkulacji meldunku. |
| SurowceNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut surowców | Narzut surowców dla kalkulacji meldunku. |
| SurowcePlanowane | `Soneta.Types.Currency` | bazodanowe | Surowce planowane | Surowce planowane dla kalkulacji meldunku. |
| SurowcePomin | `bool` | bazodanowe | Pomiń surowce | Pomijanie surowców dla kalkulacji meldunku. |
| SurowceRazem | `Soneta.Types.Currency` | bazodanowe | Surowce razem | Surowce razem dla kalkulacji meldunku. |
| SurowceWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość surowców | Wartość surowców dla kalkulacji meldunku. |
| UslugiNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut usług | Narzut usług dla kalkulacji meldunku. |
| UslugiPlanowane | `Soneta.Types.Currency` | bazodanowe | Usługi planowane | Usługi planowane dla kalkulacji meldunku. |
| UslugiPomin | `bool` | bazodanowe | Pomiń usługi | Pomijanie usług dla kalkulacji meldunku. |
| UslugiRazem | `Soneta.Types.Currency` | bazodanowe | Usługi razem | Usługi razem dla kalkulacji meldunku. |
| UslugiWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość usług | Wartość usług dla kalkulacji meldunku. |
