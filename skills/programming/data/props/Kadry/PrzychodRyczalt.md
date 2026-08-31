# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PrzychodRyczalt`
Nazwa tabeli: `PrzychodyRyczalt`
Tytuł: Przychody dla zryczałtowanych form opodatkowania
Opis: Element szczegółowy pracownika (Pracownik). Miesięczna ewidencja przychodów właściciela dla zryczałtowanych form opodatkowania, z rozbiciem na miesiące roku oraz roczne dochody wg skali, liniowe i ryczałtowe do obliczenia składki zdrowotnej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czerwiec | `decimal` | bazodanowe |  |  |
| CzerwiecKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| CzerwiecOrg | `decimal` | tylko-odczyt | Czerwiec Org |  |
| Grudzien | `decimal` | bazodanowe |  |  |
| GrudzienKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| GrudzienOrg | `decimal` | tylko-odczyt | Grudzień Org |  |
| KorektaRecznaDochod | `bool` | bazodanowe |  |  |
| Kwiecien | `decimal` | bazodanowe |  |  |
| KwiecienKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| KwiecienOrg | `decimal` | tylko-odczyt | Kwiecień Org |  |
| KwotaNalPodSkala | `decimal` | bazodanowe |  |  |
| LiniowySumaDochod | `decimal` | tylko-odczyt |  |  |
| Lipiec | `decimal` | bazodanowe |  |  |
| LipiecKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| LipiecOrg | `decimal` | tylko-odczyt | Lipiec Org |  |
| Listopad | `decimal` | bazodanowe |  |  |
| ListopadKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| ListopadOrg | `decimal` | tylko-odczyt | Listopad Org |  |
| Luty | `decimal` | bazodanowe |  |  |
| LutyKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| LutyOrg | `decimal` | tylko-odczyt | Luty Org |  |
| Maj | `decimal` | bazodanowe |  |  |
| MajKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| MajOrg | `decimal` | tylko-odczyt | Maj Org |  |
| Marzec | `decimal` | bazodanowe |  |  |
| MarzecKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| MarzecOrg | `decimal` | tylko-odczyt | Marzec Org |  |
| Oryginal | `string` | bazodanowe, tylko-odczyt |  |  |
| Pazdziernik | `decimal` | bazodanowe |  |  |
| PazdziernikKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| PazdziernikOrg | `decimal` | tylko-odczyt | Październik Org |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| RoczDochLiniowy | `decimal` | bazodanowe |  |  |
| RoczDochRyczalt | `decimal` | bazodanowe |  |  |
| RoczDochSkala | `decimal` | bazodanowe |  |  |
| Rok | `int` | bazodanowe |  |  |
| RyczaltSumaDochod | `decimal` | tylko-odczyt |  |  |
| Sierpien | `decimal` | bazodanowe |  |  |
| SierpienKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| SierpienOrg | `decimal` | tylko-odczyt | Sierpień Org |  |
| SkalaSumaDochod | `decimal` | tylko-odczyt |  |  |
| Styczen | `decimal` | bazodanowe |  |  |
| StyczenKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| StyczenOrg | `decimal` | tylko-odczyt | Styczeń Org |  |
| Wrzesien | `decimal` | bazodanowe |  |  |
| WrzesienKolor | `System.Drawing.Color` | tylko-odczyt |  |  |
| WrzesienOrg | `decimal` | tylko-odczyt | Wrzesień Org |  |
| ZbycieStWnip | `bool` | bazodanowe |  |  |
| ZbycieStWnipLinia | `bool` | bazodanowe |  |  |
