# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.EtapDelegacji`
Nazwa tabeli: `EtapyDelegacji`
Tytuł: Etapy delegacji
Opis: Element szczegółowy Delegacja (Delegacja). Reprezentuje pojedynczy odcinek podróży służbowej z określonym krajem docelowym, datami rozpoczęcia i zakończenia oraz środkiem transportu. Zawiera dane o wyżywieniu, noclegach i ryczałtach niezbędne do prawidłowego rozliczenia diet i kosztów delegacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Delegacja` → `Delegacja`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasTrwania | `Soneta.Types.Time` |  |  |  |
| Delegacja | `Soneta.Delegacje.Delegacja` | bazodanowe, guided-parent |  | Delegacja, do której należy ten etap |
| DniSzpital | `int` | bazodanowe |  | Liczba dni spędzona na leczeniu szpitalnym (tylko zagraniczna). |
| DojazdIloscRyczaltow | `decimal` | bazodanowe |  | Ilość ryczałtów na dojazd z dworca do miejsca zakwaterowania (tylko zagraniczna). |
| EkwiwalentWyzywienie | `Soneta.Types.Currency` | bazodanowe |  | Zbiorcza kwota jaką pracownik otrzymał na wyżywienie (tylko zagraniczna). |
| EtapKrajowy | `bool` |  |  |  |
| GrupujWgKrajow | `bool` | bazodanowe |  | Etap zostanie rozliczony łącznie z innymi etapami do tego samego kraju. |
| Koszty | `Soneta.Business.LpSubTable<Soneta.Delegacje.KosztDelegacji>` |  |  |  |
| Kraj | `Soneta.Delegacje.KrajDelegacji` | bazodanowe |  | Kraj docelowy etapu delegacji. |
| KrajAsText | `string` |  |  |  |
| LP | `int` | bazodanowe |  | Liczba porządkowa etapu delegacji. |
| LiczbaKolacji | `int` | bazodanowe |  | Liczba kolacji zapewniona przez pracowdawcę (tylko zagraniczna). |
| LiczbaObiadow | `int` | bazodanowe |  | Liczba obiadów zapewniona przez pracowdawcę (tylko zagraniczna). |
| LiczbaSniadan | `int` | bazodanowe |  | Liczba śniadań zapewniona przez pracowdawcę (tylko zagraniczna). |
| MiejscowoscRozpoczecia | `string` | bazodanowe |  | Miejscowość rozpoczęcia etapu delegacji. |
| MiejscowoscZakonczenia | `string` | bazodanowe |  | Miejscowość zakończenia etapu delegacji. |
| NaliczenieLP | `int` | bazodanowe |  | Liczba porządkowa naliczenia dla tego etapu delegacji. |
| PelneWyzywienie | `bool` | bazodanowe |  | Czy delegowany miał zapewnione pełne wyżywienie. |
| Rozpoczecie | `Soneta.Types.DateShortTime` | bazodanowe |  | Rozpoczęcie etapu delegacji. |
| RozpoczecieDate | `Soneta.Types.Date` |  |  |  |
| RozpoczecieTime | `Soneta.Types.Time` |  |  |  |
| RyczaltKosztDojazdu | `Soneta.Delegacje.RyczaltDojazdDworzec` | enum |  |  |
| SrodekTransportu | `string` | bazodanowe |  | Domyślny środek transportu. |
| Zakonczenie | `Soneta.Types.DateShortTime` | bazodanowe |  | Zakończenie etapu delegacji. |
| ZakonczenieDate | `Soneta.Types.Date` |  |  |  |
| ZakonczenieTime | `Soneta.Types.Time` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RyczaltDojazdDworzec (`Soneta.Delegacje.RyczaltDojazdDworzec`)
- `Nie` = 0
- `Polowa` = 1 — W jedną stronę
- `Tak` = 2
