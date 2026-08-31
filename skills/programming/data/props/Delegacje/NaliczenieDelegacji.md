# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.NaliczenieDelegacji`
Nazwa tabeli: `NalDelegacji`
Tytuł: Naliczenia pośrednie delegacji
Opis: Element szczegółowy Delegacja (Delegacja). Przechowuje pośrednie wyniki rozliczenia delegacji dla danego kraju, obejmujące naliczenia diet, ryczałtów za komunikację miejską i dojazdy oraz kosztów noclegów. Grupuje etapy delegacji do tego samego kraju i umożliwia korektę automatycznie wyliczonych kwot.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Delegacja` → `Delegacja`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasTrwania | `Time` | bazodanowe, tylko-odczyt |  | Sumaryczny czas trwania |
| CzasTrwaniaDni | `int` | tylko-odczyt |  |  |
| CzyKrajowa | `bool` | bazodanowe, tylko-odczyt |  | Czy delegacja rozliczana jest wg wzorca krajowego. |
| Delegacja | `Soneta.Delegacje.Delegacja` | bazodanowe, tylko-odczyt, guided-parent |  | Delegacja, do której należy to naliczenie. |
| DietaEkwiwalent | `Currency` | bazodanowe, tylko-odczyt |  | Ekwiwalent wypłacony. |
| DietaIloscNalezna | `double` | bazodanowe, tylko-odczyt |  | Nalezna ilość diet wynikająca z czasu trwania delegacji. |
| DietaIloscRozliczenie | `double` | tylko-odczyt |  |  |
| DietaIloscRozliczenieKor | `double` | bazodanowe |  | Ilość diet do rozliczenia (korekta). |
| DietaIloscZapewniona | `double` | bazodanowe, tylko-odczyt |  | Ilość diet zapewniona w postaci posiłków lub pobytu w szpitalu. |
| DietaKwota | `Currency` | bazodanowe, tylko-odczyt |  | Kwota diety dla wskaznego kraju delegacji. |
| DietaKwotaKor | `Currency` | bazodanowe |  | Kwota diety dla wskaznego kraju delegacji (korekta). |
| DietaRozliczenie | `Currency` | bazodanowe, tylko-odczyt |  | Rozliczenie diety. |
| DietaRozliczenieKor | `Currency` | bazodanowe |  | Rozliczenie diety (korekta). |
| DietaRozliczenieKorPLN | `Currency` | tylko-odczyt |  |  |
| DojazdIloscRyczaltow | `decimal` | bazodanowe, tylko-odczyt |  | Ilość ryczałtów na dojazd z dworca do miejsca zakwaterowania. |
| DojazdRozliczenie | `Currency` | bazodanowe, tylko-odczyt |  | Ryczałtowy zwrot za dojazd z dworca do miejsca zakwaterowania. |
| DojazdRozliczeniePLN | `Currency` | tylko-odczyt |  |  |
| IloscNoclegowCaption | `string` | tylko-odczyt |  |  |
| KomunikacjaRozliczenie | `Currency` | bazodanowe, tylko-odczyt |  | Ryczałtowy zwrot za komunikację miejską. |
| KomunikacjaRozliczenieKor | `Currency` | bazodanowe |  | Ryczałtowy zwrot za komunikację miejską (korygowany). |
| KomunikacjaRozliczenieKorPLN | `Currency` | tylko-odczyt |  |  |
| KomunikacjaRyczalt | `bool` | bazodanowe |  | Czy delegowanemu należą się ryczałtkowe koszty komunikacji miejskiej. |
| Kraj | `Soneta.Delegacje.KrajDelegacji` | bazodanowe, tylko-odczyt |  | Kraj rozliczenia etapu delegacji. |
| Kwoty | `SubTable<Soneta.Delegacje.KwotaNaliczeniaDelegacji>` | podlista |  |  |
| ListaEtapow | `string` | bazodanowe, tylko-odczyt |  | Lista etapów wchodząca w skład rozliczenia |
| Lp | `int` | bazodanowe, tylko-odczyt |  | Numer kolejny rozliczenia |
| NoclegAlgorytm | `Soneta.Delegacje.AlgorytmRozliczeniaNoclegu` (enum) | bazodanowe |  | Algorytm rozliczenia noclegu. |
| NoclegBezRachunkow | `Currency` | tylko-odczyt |  |  |
| NoclegBezRachunkowPLN | `Currency` | tylko-odczyt |  |  |
| NoclegIlosc | `int` | bazodanowe, tylko-odczyt |  | Ilość noclegów. |
| NoclegIloscKor | `int` | bazodanowe |  | Ilość noclegów (korekta). |
| NoclegLimit | `Currency` | bazodanowe, tylko-odczyt |  | Limit na nocleg. |
| NoclegLimitKor | `Currency` | bazodanowe |  | Limit na nocleg (korekta). |
| NoclegLimitTotal | `Currency` | tylko-odczyt |  |  |
| NoclegPowyzejLimitu | `Currency` | tylko-odczyt |  |  |
| NoclegPowyzejLimituPLN | `Currency` | tylko-odczyt |  |  |
| NoclegRachunki | `Currency` | bazodanowe, tylko-odczyt |  | Wydatki na nocleg wg załączonych rachunków. |
| NoclegRozliczenie | `Currency` | bazodanowe, tylko-odczyt |  | Rozliczenie noclegu. |
| NoclegRozliczenieExt | `Currency` | tylko-odczyt |  |  |
| NoclegRozliczeniePLN | `Currency` | tylko-odczyt |  |  |
| NoclegRyczalt | `Currency` | tylko-odczyt |  |  |
| NoclegRyczaltPLN | `Currency` | tylko-odczyt |  |  |
| RyczaltyRazem | `Currency` | tylko-odczyt |  |  |
| RyczaltyRazemPLN | `Currency` | tylko-odczyt |  |  |
| WydatkiInne | `Currency` | bazodanowe, tylko-odczyt |  | Suma wydatków na inne wydatki. |
| WydatkiInneBezRachunkow | `Currency` | tylko-odczyt |  |  |
| WydatkiInneBezRachunkowPLN | `Currency` | tylko-odczyt |  |  |
| WydatkiInneWgRachunkow | `Currency` | tylko-odczyt |  |  |
| WydatkiInneWgRachunkowPLN | `Currency` | tylko-odczyt |  |  |
| WydatkiSamochod | `Currency` | bazodanowe, tylko-odczyt |  | Suma wydatków na transport własnym samochodem. |
| WydatkiSamochodBezRachunkow | `Currency` | tylko-odczyt |  |  |
| WydatkiSamochodBezRachunkowPLN | `Currency` | tylko-odczyt |  |  |
| WydatkiSamochodWgRachunkow | `Currency` | tylko-odczyt |  |  |
| WydatkiSamochodWgRachunkowPLN | `Currency` | tylko-odczyt |  |  |
| WydatkiTransport | `Currency` | bazodanowe, tylko-odczyt |  | Suma wydatków na środki publiczne transportu. |
| WydatkiTransportBezRachunkow | `Currency` | tylko-odczyt |  |  |
| WydatkiTransportBezRachunkowPLN | `Currency` | tylko-odczyt |  |  |
| WydatkiTransportWgRachunkow | `Currency` | tylko-odczyt |  |  |
| WydatkiTransportWgRachunkowPLN | `Currency` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AlgorytmRozliczeniaNoclegu (`Soneta.Delegacje.AlgorytmRozliczeniaNoclegu`)
- `NieRozliczaj` = 0 — Nie rozliczaj noclegu
- `WgRachunkowDoLimitu` = 1 — Wg rachunków do limitu
- `WgRachunkowBezLimitu` = 2 — Wg rachunków bez limitu
- `Ryczałt` = 3 — Ryczałtowo bez rachunków
- `RyczaltBezLimitu` = 4 — Ryczałtowo + rachunki bez limitu
