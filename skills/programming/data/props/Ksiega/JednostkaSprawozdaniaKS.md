# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.JednostkaSprawozdaniaKS`
Nazwa tabeli: `JednostkiSprawKS`
Tytuł: Jednostki sprawozdania
Opis: Element szczegółowy sprawozdania księgowego (SprawozdanieKS). Reprezentuje jednostkę powiązaną w skonsolidowanym sprawozdaniu finansowym, przechowując dane identyfikacyjne (nazwa, siedziba, adres), udział w kapitale, powiązania kapitałowe, przedmiot działalności oraz parametry konsolidacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Sprawozdanie` → `SprawozdanieKS`
Implementuje interfejsy: `IPozycjaSprawozdaniaRoot`, `IAdresHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| CzasOgrDataDo | `Date` | bazodanowe |  | Czas trwania jednostki powiązanej do |
| CzasOgrDataDoOpis | `MemoText` | bazodanowe, podlista |  | Czas trwania jednostki powiązanej do (opis) |
| CzasOgrDataOd | `Date` | bazodanowe |  | Czas trwania jednostki powiązanej od |
| CzasOgrTak | `bool` | bazodanowe |  | Ograniczony czas trwania jednostki powiązanej |
| JednostkiZaangazWKapitaleOpis | `string` | bazodanowe |  | Nazwy (firmy) i siedziby jednostek podporządkowananych posiadających zaangażowanie w kapitale jednostki |
| JednostkiZaangazWKapitaleWartoscKapitalow | `string` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa (firma) jednostki |
| OkresSpraw | `FromTo` | bazodanowe, podlista |  | Okres sprawozdania objętego konsolidacją jeśli jest różny od okresu całego sprawozdania |
| OkresSprawRozny | `bool` | bazodanowe |  | Okres sprawozdania objętego konsolidacją jest różny od okresu całego sprawozdania |
| OpcjaDodatkoweObjasnienia | `bool` | bazodanowe |  | Będą podawane dodatkowe informacje i objaśnienia |
| OpcjaRozliczenieRoznic | `bool` | bazodanowe |  | Będzie podawane rozliczenie różnic pomiędzy podatkiem dochodowym a wynikiem finansowym |
| PodstawaPrawnaWylaczeniaZKonsolidacji | `string` | bazodanowe |  | Podstawa prawna oraz uzasadnienie dokonania wyłączenia |
| PolaczenieSpl | `bool` | bazodanowe |  | Sprawozdanie finansowe jednostki jest sporządzone po połączeniu spółek |
| PolaczenieSplOpis | `MemoText` | bazodanowe, podlista |  | Zastosowana metoda rozliczenia połączenia |
| PolaczenieSplPo | `bool` | bazodanowe |  | Sprawozdanie jednostki za okres po połączeniu spółek |
| PowiazaniaKapitalowe | `string` | bazodanowe |  | Wzajemne powiązania kapitałowe pomiędzy jednostkami objętymi konsolidacją |
| Pozycje | `SubTable<Soneta.Ksiega.PozycjaSprawozdaniaKS>` | podlista |  |  |
| PrzedmiotDzialalnosci | `string` | bazodanowe |  | Przedmiot działalności |
| Rola | `Soneta.Ksiega.RolaJednostkiSprawozdania` (enum) | bazodanowe |  |  |
| Siedziba | `string` | bazodanowe |  | Siedziba jednostki |
| Sprawozdanie | `Soneta.Ksiega.SprawozdanieKS` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| UdzialWKapitale | `Percent` | bazodanowe |  | Udział w kapitale (funduszu) podstawowym |
| UdzialWLiczbieGlosow | `bool` | bazodanowe |  | Inny udział w liczbie głosów |
| UdzialWLiczbieGlosowProcent | `Percent` | bazodanowe |  | Udział w całkowitej liczbie głosów, jeżeli jest różny od udziału w kapitale (funduszu) podstawowym |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RolaJednostkiSprawozdania (`Soneta.Ksiega.RolaJednostkiSprawozdania`)
- `Podporzadkowana` = 0 — Podporządkowana
- `InnaNizPodporzadkowana` = 1 — Inna niż podporządkowana
- `WylaczonaZKonsolidacji` = 2 — Wyłączona z konsolidacji
