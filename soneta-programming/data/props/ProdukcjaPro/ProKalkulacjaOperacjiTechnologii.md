# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProKalkulacjaOperacjiTechnologii`
Nazwa tabeli: `ProKalkulacjeOT`
Tytuł: Kalkulacje operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Zawiera szczegółową kalkulację kosztów operacji technologicznej w podziale na kategorie: surowce, prefabrykaty, półprodukty, odpady, usługi, gniazda, robocizna, narzędzia i kooperacje, z wartościami bazowymi, narzutami i sumami.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

- pola bazodanowe: 40
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GniazdaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut gniazd | Narzut gniazd dla kalkulacji operacji technologii. |
| GniazdaPomin | `bool` | bazodanowe | Pomiń gniazda | Pomijanie gniazd dla kalkulacji operacji technologii. |
| GniazdaRazem | `Soneta.Types.Currency` | bazodanowe | Gniazda razem | Gniazda razem dla kalkulacji operacji technologii. |
| GniazdaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość gniazd | Wartość gniazd dla kalkulacji operacji technologii. |
| KalkulacjaWartosc | `Soneta.Types.Currency` |  | Wartość kalkulacji | Wartość kalkulacji operacji technologii. |
| KooperacjeNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut kooperacji | Narzut kooperacji dla kalkulacji operacji technologii. |
| KooperacjePomin | `bool` | bazodanowe | Pomiń kooperacje | Pomijanie kooperacji dla kalkulacji operacji technologii. |
| KooperacjeRazem | `Soneta.Types.Currency` | bazodanowe | Kooperacja razem | Kooperacja razem dla kalkulacji operacji technologii. |
| KooperacjeWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość kooperacji | Wartość kooperacji dla kalkulacji operacji technologii. |
| NarzedziaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut narzędzi | Narzut narzędzi dla kalkulacji operacji technologii. |
| NarzedziaPomin | `bool` | bazodanowe | Pomiń narzędzia | Pomijanie narzędzi dla kalkulacji operacji technologii. |
| NarzedziaRazem | `Soneta.Types.Currency` | bazodanowe | Narzędzia razem | Narzędzia razem dla kalkulacji operacji technologii. |
| NarzedziaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość narzędzi | Wartość narzędzi dla kalkulacji operacji technologii. |
| OdpadyNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut odpadów | Narzut odpadów dla kalkulacji operacji technologii. |
| OdpadyPomin | `bool` | bazodanowe | Pomiń odpady | Pomijanie odpadów dla kalkulacji operacji technologii. |
| OdpadyRazem | `Soneta.Types.Currency` | bazodanowe | Odpady razem | Odpady razem dla kalkulacji operacji technologii. |
| OdpadyWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość odpadów | Wartość odpadów dla kalkulacji operacji technologii. |
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla kalkulacji operacji technologii. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` |  | Operacja technologii | Operacja technologii dla kalkulacji operacji technologii. |
| PolproduktyNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut półproduktów | Narzut półproduktów dla kalkulacji operacji technologii. |
| PolproduktyPomin | `bool` | bazodanowe | Pomiń półprodukty | Pomijanie półproduktów dla kalkulacji operacji technologii. |
| PolproduktyRazem | `Soneta.Types.Currency` | bazodanowe | Półprodukty razem | Półprodukty razem dla kalkulacji operacji technologii. |
| PolproduktyWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość półproduktów | Wartość półproduktów dla kalkulacji operacji technologii. |
| PrefabrykatyNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut prefabrykatów | Narzut prefabrykatów dla kalkulacji operacji technologii. |
| PrefabrykatyPomin | `bool` | bazodanowe | Pomiń prefabrykaty | Pomijanie prefabrykatów dla kalkulacji operacji technologii. |
| PrefabrykatyRazem | `Soneta.Types.Currency` | bazodanowe | Prefabrykaty razem | Prefabrykaty razem dla kalkulacji operacji technologii. |
| PrefabrykatyWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość prefabrykatów | Wartość prefabrykatów dla kalkulacji operacji technologii. |
| RobociznaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut robocizny | Narzut robocizny dla kalkulacji operacji technologii. |
| RobociznaPomin | `bool` | bazodanowe | Pomiń robocizne | Pomijanie robocizny dla kalkulacji operacji technologii. |
| RobociznaRazem | `Soneta.Types.Currency` | bazodanowe | Robocizna razem | Robocizna razem dla kalkulacji operacji technologii. |
| RobociznaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość robocizny | Wartość robocizny dla kalkulacji operacji technologii. |
| SumaNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut sumy | Narzut sumy dla kalkulacji operacji technologii. |
| SumaRazem | `Soneta.Types.Currency` | bazodanowe | Suma razem | Suma razem dla kalkulacji operacji technologii. |
| SumaWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość sumy | Wartość sumy dla kalkulacji operacji technologii. |
| SurowceNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut surowców | Narzut surowców dla kalkulacji operacji technologii. |
| SurowcePomin | `bool` | bazodanowe | Pomiń surowce | Pomijanie surowców dla kalkulacji operacji technologii. |
| SurowceRazem | `Soneta.Types.Currency` | bazodanowe | Surowce razem | Surowce razem dla kalkulacji operacji technologii. |
| SurowceWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość surowców | Wartość surowców dla kalkulacji operacji technologii. |
| UslugiNarzut | `Soneta.Types.Percent` | bazodanowe | Narzut usług | Narzut usług dla kalkulacji operacji technologii. |
| UslugiPomin | `bool` | bazodanowe | Pomiń usługi | Pomijanie usług dla kalkulacji operacji technologii. |
| UslugiRazem | `Soneta.Types.Currency` | bazodanowe | Usługi razem | Usługi razem dla kalkulacji operacji technologii. |
| UslugiWartosc | `Soneta.Types.Currency` | bazodanowe | Wartość usług | Wartość usług dla kalkulacji operacji technologii. |
