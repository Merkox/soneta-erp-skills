# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProKalkulacjaOperacjiTechnologii`
Nazwa tabeli: `ProKalkulacjeOT`
Tytuł: Kalkulacje operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Zawiera szczegółową kalkulację kosztów operacji technologicznej w podziale na kategorie: surowce, prefabrykaty, półprodukty, odpady, usługi, gniazda, robocizna, narzędzia i kooperacje, z wartościami bazowymi, narzutami i sumami.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GniazdaNarzut | `Percent` | bazodanowe | Narzut gniazd | Narzut gniazd dla kalkulacji operacji technologii. |
| GniazdaPomin | `bool` | bazodanowe | Pomiń gniazda | Pomijanie gniazd dla kalkulacji operacji technologii. |
| GniazdaRazem | `Currency` | bazodanowe | Gniazda razem | Gniazda razem dla kalkulacji operacji technologii. |
| GniazdaWartosc | `Currency` | bazodanowe | Wartość gniazd | Wartość gniazd dla kalkulacji operacji technologii. |
| KalkulacjaWartosc | `Currency` | tylko-odczyt | Wartość kalkulacji | Wartość kalkulacji operacji technologii. |
| KooperacjeNarzut | `Percent` | bazodanowe | Narzut kooperacji | Narzut kooperacji dla kalkulacji operacji technologii. |
| KooperacjePomin | `bool` | bazodanowe | Pomiń kooperacje | Pomijanie kooperacji dla kalkulacji operacji technologii. |
| KooperacjeRazem | `Currency` | bazodanowe | Kooperacja razem | Kooperacja razem dla kalkulacji operacji technologii. |
| KooperacjeWartosc | `Currency` | bazodanowe | Wartość kooperacji | Wartość kooperacji dla kalkulacji operacji technologii. |
| NarzedziaNarzut | `Percent` | bazodanowe | Narzut narzędzi | Narzut narzędzi dla kalkulacji operacji technologii. |
| NarzedziaPomin | `bool` | bazodanowe | Pomiń narzędzia | Pomijanie narzędzi dla kalkulacji operacji technologii. |
| NarzedziaRazem | `Currency` | bazodanowe | Narzędzia razem | Narzędzia razem dla kalkulacji operacji technologii. |
| NarzedziaWartosc | `Currency` | bazodanowe | Wartość narzędzi | Wartość narzędzi dla kalkulacji operacji technologii. |
| OdpadyNarzut | `Percent` | bazodanowe | Narzut odpadów | Narzut odpadów dla kalkulacji operacji technologii. |
| OdpadyPomin | `bool` | bazodanowe | Pomiń odpady | Pomijanie odpadów dla kalkulacji operacji technologii. |
| OdpadyRazem | `Currency` | bazodanowe | Odpady razem | Odpady razem dla kalkulacji operacji technologii. |
| OdpadyWartosc | `Currency` | bazodanowe | Wartość odpadów | Wartość odpadów dla kalkulacji operacji technologii. |
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla kalkulacji operacji technologii. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | tylko-odczyt | Operacja technologii | Operacja technologii dla kalkulacji operacji technologii. |
| PolproduktyNarzut | `Percent` | bazodanowe | Narzut półproduktów | Narzut półproduktów dla kalkulacji operacji technologii. |
| PolproduktyPomin | `bool` | bazodanowe | Pomiń półprodukty | Pomijanie półproduktów dla kalkulacji operacji technologii. |
| PolproduktyRazem | `Currency` | bazodanowe | Półprodukty razem | Półprodukty razem dla kalkulacji operacji technologii. |
| PolproduktyWartosc | `Currency` | bazodanowe | Wartość półproduktów | Wartość półproduktów dla kalkulacji operacji technologii. |
| PrefabrykatyNarzut | `Percent` | bazodanowe | Narzut prefabrykatów | Narzut prefabrykatów dla kalkulacji operacji technologii. |
| PrefabrykatyPomin | `bool` | bazodanowe | Pomiń prefabrykaty | Pomijanie prefabrykatów dla kalkulacji operacji technologii. |
| PrefabrykatyRazem | `Currency` | bazodanowe | Prefabrykaty razem | Prefabrykaty razem dla kalkulacji operacji technologii. |
| PrefabrykatyWartosc | `Currency` | bazodanowe | Wartość prefabrykatów | Wartość prefabrykatów dla kalkulacji operacji technologii. |
| RobociznaNarzut | `Percent` | bazodanowe | Narzut robocizny | Narzut robocizny dla kalkulacji operacji technologii. |
| RobociznaPomin | `bool` | bazodanowe | Pomiń robocizne | Pomijanie robocizny dla kalkulacji operacji technologii. |
| RobociznaRazem | `Currency` | bazodanowe | Robocizna razem | Robocizna razem dla kalkulacji operacji technologii. |
| RobociznaWartosc | `Currency` | bazodanowe | Wartość robocizny | Wartość robocizny dla kalkulacji operacji technologii. |
| SumaNarzut | `Percent` | bazodanowe | Narzut sumy | Narzut sumy dla kalkulacji operacji technologii. |
| SumaRazem | `Currency` | bazodanowe | Suma razem | Suma razem dla kalkulacji operacji technologii. |
| SumaWartosc | `Currency` | bazodanowe | Wartość sumy | Wartość sumy dla kalkulacji operacji technologii. |
| SurowceNarzut | `Percent` | bazodanowe | Narzut surowców | Narzut surowców dla kalkulacji operacji technologii. |
| SurowcePomin | `bool` | bazodanowe | Pomiń surowce | Pomijanie surowców dla kalkulacji operacji technologii. |
| SurowceRazem | `Currency` | bazodanowe | Surowce razem | Surowce razem dla kalkulacji operacji technologii. |
| SurowceWartosc | `Currency` | bazodanowe | Wartość surowców | Wartość surowców dla kalkulacji operacji technologii. |
| UslugiNarzut | `Percent` | bazodanowe | Narzut usług | Narzut usług dla kalkulacji operacji technologii. |
| UslugiPomin | `bool` | bazodanowe | Pomiń usługi | Pomijanie usług dla kalkulacji operacji technologii. |
| UslugiRazem | `Currency` | bazodanowe | Usługi razem | Usługi razem dla kalkulacji operacji technologii. |
| UslugiWartosc | `Currency` | bazodanowe | Wartość usług | Wartość usług dla kalkulacji operacji technologii. |
