# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.NaliczenieDelegacji`
Nazwa tabeli: `NalDelegacji`
Tytuł: Naliczenia pośrednie delegacji
Opis: Element szczegółowy Delegacja (Delegacja). Przechowuje pośrednie wyniki rozliczenia delegacji dla danego kraju, obejmujące naliczenia diet, ryczałtów za komunikację miejską i dojazdy oraz kosztów noclegów. Grupuje etapy delegacji do tego samego kraju i umożliwia korektę automatycznie wyliczonych kwot.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Delegacja` → `Delegacja`

- pola bazodanowe: 29
- pola kalkulowane (z klas biznesowych): 30

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasTrwania | `Soneta.Types.Time` | bazodanowe |  | Sumaryczny czas trwania |
| CzasTrwaniaDni | `int` |  |  |  |
| CzyKrajowa | `bool` | bazodanowe |  | Czy delegacja rozliczana jest wg wzorca krajowego. |
| Delegacja | `Soneta.Delegacje.Delegacja` | bazodanowe, guided-parent |  | Delegacja, do której należy to naliczenie. |
| DietaEkwiwalent | `Soneta.Types.Currency` | bazodanowe |  | Ekwiwalent wypłacony. |
| DietaIloscNalezna | `double` | bazodanowe |  | Nalezna ilość diet wynikająca z czasu trwania delegacji. |
| DietaIloscRozliczenie | `double` |  |  |  |
| DietaIloscRozliczenieKor | `double` | bazodanowe |  | Ilość diet do rozliczenia (korekta). |
| DietaIloscZapewniona | `double` | bazodanowe |  | Ilość diet zapewniona w postaci posiłków lub pobytu w szpitalu. |
| DietaKwota | `Soneta.Types.Currency` | bazodanowe |  | Kwota diety dla wskaznego kraju delegacji. |
| DietaKwotaKor | `Soneta.Types.Currency` | bazodanowe |  | Kwota diety dla wskaznego kraju delegacji (korekta). |
| DietaRozliczenie | `Soneta.Types.Currency` | bazodanowe |  | Rozliczenie diety. |
| DietaRozliczenieKor | `Soneta.Types.Currency` | bazodanowe |  | Rozliczenie diety (korekta). |
| DietaRozliczenieKorPLN | `Soneta.Types.Currency` |  |  |  |
| DojazdIloscRyczaltow | `decimal` | bazodanowe |  | Ilość ryczałtów na dojazd z dworca do miejsca zakwaterowania. |
| DojazdRozliczenie | `Soneta.Types.Currency` | bazodanowe |  | Ryczałtowy zwrot za dojazd z dworca do miejsca zakwaterowania. |
| DojazdRozliczeniePLN | `Soneta.Types.Currency` |  |  |  |
| IloscNoclegowCaption | `string` |  |  |  |
| KomunikacjaRozliczenie | `Soneta.Types.Currency` | bazodanowe |  | Ryczałtowy zwrot za komunikację miejską. |
| KomunikacjaRozliczenieKor | `Soneta.Types.Currency` | bazodanowe |  | Ryczałtowy zwrot za komunikację miejską (korygowany). |
| KomunikacjaRozliczenieKorPLN | `Soneta.Types.Currency` |  |  |  |
| KomunikacjaRyczalt | `bool` | bazodanowe |  | Czy delegowanemu należą się ryczałtkowe koszty komunikacji miejskiej. |
| Kraj | `Soneta.Delegacje.KrajDelegacji` | bazodanowe |  | Kraj rozliczenia etapu delegacji. |
| Kwoty | `Soneta.Business.SubTable<Soneta.Delegacje.KwotaNaliczeniaDelegacji>` |  |  |  |
| ListaEtapow | `string` | bazodanowe |  | Lista etapów wchodząca w skład rozliczenia |
| Lp | `int` | bazodanowe |  | Numer kolejny rozliczenia |
| NoclegAlgorytm | `Soneta.Delegacje.AlgorytmRozliczeniaNoclegu` | bazodanowe, enum |  | Algorytm rozliczenia noclegu. |
| NoclegBezRachunkow | `Soneta.Types.Currency` |  |  |  |
| NoclegBezRachunkowPLN | `Soneta.Types.Currency` |  |  |  |
| NoclegIlosc | `int` | bazodanowe |  | Ilość noclegów. |
| NoclegIloscKor | `int` | bazodanowe |  | Ilość noclegów (korekta). |
| NoclegLimit | `Soneta.Types.Currency` | bazodanowe |  | Limit na nocleg. |
| NoclegLimitKor | `Soneta.Types.Currency` | bazodanowe |  | Limit na nocleg (korekta). |
| NoclegLimitTotal | `Soneta.Types.Currency` |  |  |  |
| NoclegPowyzejLimitu | `Soneta.Types.Currency` |  |  |  |
| NoclegPowyzejLimituPLN | `Soneta.Types.Currency` |  |  |  |
| NoclegRachunki | `Soneta.Types.Currency` | bazodanowe |  | Wydatki na nocleg wg załączonych rachunków. |
| NoclegRozliczenie | `Soneta.Types.Currency` | bazodanowe |  | Rozliczenie noclegu. |
| NoclegRozliczenieExt | `Soneta.Types.Currency` |  |  |  |
| NoclegRozliczeniePLN | `Soneta.Types.Currency` |  |  |  |
| NoclegRyczalt | `Soneta.Types.Currency` |  |  |  |
| NoclegRyczaltPLN | `Soneta.Types.Currency` |  |  |  |
| RyczaltyRazem | `Soneta.Types.Currency` |  |  |  |
| RyczaltyRazemPLN | `Soneta.Types.Currency` |  |  |  |
| WydatkiInne | `Soneta.Types.Currency` | bazodanowe |  | Suma wydatków na inne wydatki. |
| WydatkiInneBezRachunkow | `Soneta.Types.Currency` |  |  |  |
| WydatkiInneBezRachunkowPLN | `Soneta.Types.Currency` |  |  |  |
| WydatkiInneWgRachunkow | `Soneta.Types.Currency` |  |  |  |
| WydatkiInneWgRachunkowPLN | `Soneta.Types.Currency` |  |  |  |
| WydatkiSamochod | `Soneta.Types.Currency` | bazodanowe |  | Suma wydatków na transport własnym samochodem. |
| WydatkiSamochodBezRachunkow | `Soneta.Types.Currency` |  |  |  |
| WydatkiSamochodBezRachunkowPLN | `Soneta.Types.Currency` |  |  |  |
| WydatkiSamochodWgRachunkow | `Soneta.Types.Currency` |  |  |  |
| WydatkiSamochodWgRachunkowPLN | `Soneta.Types.Currency` |  |  |  |
| WydatkiTransport | `Soneta.Types.Currency` | bazodanowe |  | Suma wydatków na środki publiczne transportu. |
| WydatkiTransportBezRachunkow | `Soneta.Types.Currency` |  |  |  |
| WydatkiTransportBezRachunkowPLN | `Soneta.Types.Currency` |  |  |  |
| WydatkiTransportWgRachunkow | `Soneta.Types.Currency` |  |  |  |
| WydatkiTransportWgRachunkowPLN | `Soneta.Types.Currency` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AlgorytmRozliczeniaNoclegu (`Soneta.Delegacje.AlgorytmRozliczeniaNoclegu`)
- `NieRozliczaj` = 0 — Nie rozliczaj noclegu
- `WgRachunkowDoLimitu` = 1 — Wg rachunków do limitu
- `WgRachunkowBezLimitu` = 2 — Wg rachunków bez limitu
- `Ryczałt` = 3 — Ryczałtowo bez rachunków
- `RyczaltBezLimitu` = 4 — Ryczałtowo + rachunki bez limitu
