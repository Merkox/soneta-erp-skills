# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.SprawozdanieKS`
Nazwa tabeli: `SprawozdaniaKS`
Tytuł: Sprawozdania księgowe
Opis: Sprawozdanie finansowe firmy za dany okres obrachunkowy (bilans, rachunek zysków i strat, rachunek przepływów, zestawienie zmian w kapitale). Przechowuje dane wprowadzenia (zasady rachunkowości, forma prawna, kontynuacja działalności), powiązania z wynikami zestawień księgowych oraz wygenerowany XML do wysyłki elektronicznej.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPozycjaSprawozdaniaRoot`

- pola bazodanowe: 51
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DefinicjaXML | `Soneta.Ksiega.DefXmlNagSprawozdanie` | bazodanowe |  | Definicja komunikatu EDI do generowania XML |
| Jednostki | `Soneta.Business.LpSubTable<Soneta.Ksiega.JednostkaSprawozdaniaKS>` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresKS | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe |  | Okres obrachunkowy sprawozdania |
| Pozycje | `Soneta.Business.SubTable<Soneta.Ksiega.PozycjaSprawozdaniaKS>` |  |  |  |
| Rodzaj | `Soneta.Ksiega.RodzajSprawozdaniaKS` | bazodanowe, enum |  |  |
| Signatures | `Soneta.Ksiega.SprawozdanieKS.SignatureManager` |  |  |  |
| Stan | `Soneta.Ksiega.StanSprawozdaniaKS` | bazodanowe, enum |  |  |
| TypJednostki | `Soneta.Ksiega.TypJednostkiKsiegowy` | bazodanowe, enum |  |  |
| WariantBilans | `Soneta.Ksiega.TypJednostkiKsiegowy` | bazodanowe, enum |  |  |
| WariantPodDochodowy | `Soneta.Ksiega.WariantDanychPodDochodowego` | bazodanowe, enum |  |  |
| WariantRachZyskStrat | `Soneta.Ksiega.TypJednostkiKsiegowy` | bazodanowe, enum |  |  |
| WariantRachunekPrzeplywow | `Soneta.Ksiega.TypJednostkiKsiegowy` | enum |  |  |
| WariantWprowadzenie | `Soneta.Ksiega.TypJednostkiKsiegowy` | bazodanowe, enum |  |  |
| WariantZestZmian | `Soneta.Ksiega.TypJednostkiKsiegowy` | enum |  |  |
| WersjaSchemy | `Soneta.Ksiega.WersjaSchemySprawozdaniaKS` | bazodanowe, enum |  |  |
| WprCzasOgrDataDo | `Soneta.Types.Date` | bazodanowe |  | Data działalności jednostki (do) |
| WprCzasOgrDataDoOpis | `Soneta.Business.MemoText` | bazodanowe |  | Czas trwania działalności jednostki (do) opisowo |
| WprCzasOgrDataOd | `Soneta.Types.Date` | bazodanowe |  | Czas trwania działalności jednostki (od) |
| WprCzasOgrTak | `bool` | bazodanowe |  | Czas trwania działalności jednostki jest ograniczony |
| WprDaneLaczne | `bool` | bazodanowe |  | Sprawozdanie zawiera dane łączne z jednostkami wewnętrznymi |
| WprFormaPrawna | `Soneta.Core.IFormaPrawna` | bazodanowe |  | Forma prawna jednostki |
| WprFormaPrawnaInna | `string` | bazodanowe |  | Nazwa innej formy prawnej |
| WprKryteriaSkonsolidowaniaOpis | `Soneta.Business.MemoText` | bazodanowe |  | Kryteria skonsolidowania |
| WprKryteriaWylaczenieJednostekOpis | `Soneta.Business.MemoText` | bazodanowe |  | Kryteria wyłączeń jednostek podporządkowanych ze skonsolidowanego sprawozdania finansowego |
| WprOkresSpraw | `Soneta.Types.FromTo` | bazodanowe |  | Okres sprawozdania objętego konsolidacją jeśli jest różny od okresu całego sprawozdania |
| WprOkresSprawRozny | `bool` | bazodanowe |  | Okres sprawozdania objętego konsolidacją jest różny od okresu całego sprawozdania |
| WprPKD2007 | `bool` | bazodanowe |  | Klasyfikacja zgodna z PKD2007 |
| WprPodstPrzedmiotDzialJednDominujacej | `Soneta.Business.MemoText` | bazodanowe |  | Podstawowy przedmiot działalności jednostki dominującej |
| WprPolaczenieSpl | `bool` | bazodanowe |  | Sprawozdanie finansowe jest sporządzone po połączeniu spółek |
| WprPolaczenieSplOpis | `Soneta.Business.MemoText` | bazodanowe |  | Wskazanie zastosowanej metody rozliczenia połączenia |
| WprPolaczenieSplPo | `bool` | bazodanowe |  | Sprawozdanie finansowe jest sporządzone za okres po połączeniu spółek |
| WprPowodZmianyZasadOpis | `Soneta.Business.MemoText` | bazodanowe |  | Powod zmiany zasad (polityki) rachunkowości |
| WprRewident | `bool` | bazodanowe |  | Sprawozdanie podlega wynikającemu z przepisów prawa obowiązkowi badania przez biegłego rewidenta |
| WprSrednioroczneZatrudnienie | `decimal` | bazodanowe |  | Średnioroczne zatrudnienie w przeliczeniu na pełne etaty |
| WprZagrKontynuacji | `bool` | bazodanowe |  | Wskazanie, że istnieją okoliczności wskazujące na zagrożenie kontynuowania działalności |
| WprZagrKontynuacjiOpis | `Soneta.Business.MemoText` | bazodanowe |  | Opis okoliczności wskazujących na zagrożenie kontynuowania działalności |
| WprZalKontynuacji | `bool` | bazodanowe |  | Sprawozdanie zostało sporządzone przy założeniu kontynuowania działalności gospodarczej |
| WprZasadyAmortyzacja | `Soneta.Business.MemoText` | bazodanowe |  | Zasady amortyzacji |
| WprZasadyGrupowanie | `Soneta.Business.MemoText` | bazodanowe |  | Zasady grupowania operacji gospodarczych |
| WprZasadyOmowienie | `Soneta.Business.MemoText` | bazodanowe |  | Omówienie przyjętych zasad rachunkowości |
| WprZasadyPozostale | `Soneta.Business.MemoText` | bazodanowe |  | Pozostałe |
| WprZasadySprFinansowe | `Soneta.Business.MemoText` | bazodanowe |  | Ustalenie sposobu sporządzenia sprawozdania finansowego |
| WprZasadyWycenaAP | `Soneta.Business.MemoText` | bazodanowe |  | Metody wyceny aktywów i pasywów |
| WprZasadyWynikFinansowy | `Soneta.Business.MemoText` | bazodanowe |  | Ustalenie wyniku finansowego |
| WprZastUproszczenia | `Soneta.Business.MemoText` | bazodanowe |  | Zastosowane uproszczenia dla jednostek małych |
| WynikZestBilans | `Soneta.Ksiega.WynikZestKS` | bazodanowe |  | Wynik zestawienia księgowego - Bilans |
| WynikZestRachPrzep | `Soneta.Ksiega.WynikZestKS` | bazodanowe |  | Wynik zestawienia księgowego - Rachunek przepływów |
| WynikZestRachPrzepWariant | `Soneta.Ksiega.WariantRachunkuPrzeplywow` | bazodanowe, enum |  | Wariant użytego zestawienia księgowego - Rachunek przepływow |
| WynikZestRachZysk | `Soneta.Ksiega.WynikZestKS` | bazodanowe |  | Wynik zestawienia księgowego - RZiS |
| WynikZestRachZyskWariant | `Soneta.Ksiega.WariantRachunkuZyskow` | bazodanowe, enum |  | Wariant użytego zestawienia księgowego - RZiS |
| WynikZestZmianyKapital | `Soneta.Ksiega.WynikZestKS` | bazodanowe |  | Wynik zestawienia księgowego - ZZWK |
| Xml | `Soneta.Business.MemoText` | bazodanowe |  | Wygenerowany XML |
| XmlSignatures | `Soneta.Business.MemoText` | bazodanowe |  | Sygnatury XML |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajSprawozdaniaKS (`Soneta.Ksiega.RodzajSprawozdaniaKS`)
- `MikroPln` = 1 — Jednostka mikro (zł)
- `MikroTys` = 2 — Jednostka mikro (tys.)
- `MalaPln` = 3 — Jednostka mała (zł)
- `MalaTys` = 4 — Jednostka mała (tys.)
- `InnaPln` = 5 — Jednostka inna (zł)
- `InnaTys` = 6 — Jednostka inna (tys.)
- `OpPln` = 7 — Jednostka OP (zł)
- `OpTys` = 8 — Jednostka OP (tys.)
- `SkonsolidowanaPln` = 9 — Jednostka skonsolidowana (zł)
- `SkonsolidowanaTys` = 10 — Jednostka skonsolidowana (tys.)
- `ASIPln` = 11 — Jednostka ASI (zł)
- `ASITys` = 12 — Jednostka ASI (tys.)

### StanSprawozdaniaKS (`Soneta.Ksiega.StanSprawozdaniaKS`)
- `Bufor` = 0
- `Zatwierdzone` = 1
- `DoPodpisania` = 2
- `Podpisane` = 3

### TypJednostkiKsiegowy (`Soneta.Ksiega.TypJednostkiKsiegowy`)
- `Nieokreslona` = 0 — Nieokreślony
- `Inna` = 1
- `Mala` = 2 — Mała
- `Mikro` = 3
- `OP` = 4 — OP
- `Skonsolidowana` = 5
- `ASI` = 6

### WariantDanychPodDochodowego (`Soneta.Ksiega.WariantDanychPodDochodowego`)
- `InnaPln` = 0 — Inna (zł)
- `InnaTys` = 1 — Inna (tys.)
- `InnaBrak` = 2 — Inna brak
- `MalaPln` = 3 — Mała (zł)
- `MalaTys` = 4 — Mała (tys.)
- `MalaBrak` = 5 — Mała brak
- `MikroPln` = 6 — Mikro (zł)
- `MikroTys` = 7 — Mikro (tys.)
- `MikroBrak` = 8 — Mikro brak
- `OpPln` = 9 — OP (zł)
- `OpTys` = 10 — OP (tys.)
- `OpBrak` = 11 — OP brak
- `SkonsolidowanaPln` = 12 — Skonsolidowana (zł)
- `SkonsolidowanaTys` = 13 — Skonsolidowana (tys)
- `SkonsolidowanaBrak` = 14 — Skonsolidowana brak
- `ASIPln` = 15 — ASI (zł)
- `ASItys` = 16 — ASI (tys)
- `ASIBrak` = 17 — ASI brak

### WariantRachunkuPrzeplywow (`Soneta.Ksiega.WariantRachunkuPrzeplywow`)
- `Bezposredni` = 0 — Bezpośredni
- `Posredni` = 1 — Pośredni

### WariantRachunkuZyskow (`Soneta.Ksiega.WariantRachunkuZyskow`)
- `Kalkulacyjny` = 0
- `Porownawczy` = 1 — Porównawczy
- `BezWariantu` = 2 — -

### WersjaSchemySprawozdaniaKS (`Soneta.Ksiega.WersjaSchemySprawozdaniaKS`)
- `Wersja_1_0` = 1 — Wersja 1-0
- `Wersja_1_2` = 2 — Wersja 1-2
- `Wersja_1_3` = 3 — Wersja 1-3
- `Wersja_2_1` = 4 — Wersja 2-1
- `Wersja_2_2` = 5 — Wersja 2-2
