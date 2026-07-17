# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PrzychodRyczalt`
Nazwa tabeli: `PrzychodyRyczalt`
Tytuł: Przychody dla zryczałtowanych form opodatkowania
Opis: Element szczegółowy pracownika (Pracownik). Miesięczna ewidencja przychodów właściciela dla zryczałtowanych form opodatkowania, z rozbiciem na miesiące roku oraz roczne dochody wg skali, liniowe i ryczałtowe do obliczenia składki zdrowotnej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 22
- pola kalkulowane (z klas biznesowych): 27

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czerwiec | `decimal` | bazodanowe |  |  |
| CzerwiecKolor | `System.Drawing.Color` |  |  |  |
| CzerwiecOrg | `decimal` |  | Czerwiec Org |  |
| Grudzien | `decimal` | bazodanowe |  |  |
| GrudzienKolor | `System.Drawing.Color` |  |  |  |
| GrudzienOrg | `decimal` |  | Grudzień Org |  |
| KorektaRecznaDochod | `bool` | bazodanowe |  |  |
| Kwiecien | `decimal` | bazodanowe |  |  |
| KwiecienKolor | `System.Drawing.Color` |  |  |  |
| KwiecienOrg | `decimal` |  | Kwiecień Org |  |
| KwotaNalPodSkala | `decimal` | bazodanowe |  |  |
| LiniowySumaDochod | `decimal` |  |  |  |
| Lipiec | `decimal` | bazodanowe |  |  |
| LipiecKolor | `System.Drawing.Color` |  |  |  |
| LipiecOrg | `decimal` |  | Lipiec Org |  |
| Listopad | `decimal` | bazodanowe |  |  |
| ListopadKolor | `System.Drawing.Color` |  |  |  |
| ListopadOrg | `decimal` |  | Listopad Org |  |
| Luty | `decimal` | bazodanowe |  |  |
| LutyKolor | `System.Drawing.Color` |  |  |  |
| LutyOrg | `decimal` |  | Luty Org |  |
| Maj | `decimal` | bazodanowe |  |  |
| MajKolor | `System.Drawing.Color` |  |  |  |
| MajOrg | `decimal` |  | Maj Org |  |
| Marzec | `decimal` | bazodanowe |  |  |
| MarzecKolor | `System.Drawing.Color` |  |  |  |
| MarzecOrg | `decimal` |  | Marzec Org |  |
| Oryginal | `string` | bazodanowe |  |  |
| Pazdziernik | `decimal` | bazodanowe |  |  |
| PazdziernikKolor | `System.Drawing.Color` |  |  |  |
| PazdziernikOrg | `decimal` |  | Październik Org |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| RoczDochLiniowy | `decimal` | bazodanowe |  |  |
| RoczDochRyczalt | `decimal` | bazodanowe |  |  |
| RoczDochSkala | `decimal` | bazodanowe |  |  |
| Rok | `int` | bazodanowe |  |  |
| RyczaltSumaDochod | `decimal` |  |  |  |
| Sierpien | `decimal` | bazodanowe |  |  |
| SierpienKolor | `System.Drawing.Color` |  |  |  |
| SierpienOrg | `decimal` |  | Sierpień Org |  |
| SkalaSumaDochod | `decimal` |  |  |  |
| Styczen | `decimal` | bazodanowe |  |  |
| StyczenKolor | `System.Drawing.Color` |  |  |  |
| StyczenOrg | `decimal` |  | Styczeń Org |  |
| Wrzesien | `decimal` | bazodanowe |  |  |
| WrzesienKolor | `System.Drawing.Color` |  |  |  |
| WrzesienOrg | `decimal` |  | Wrzesień Org |  |
| ZbycieStWnip | `bool` | bazodanowe |  |  |
| ZbycieStWnipLinia | `bool` | bazodanowe |  |  |
