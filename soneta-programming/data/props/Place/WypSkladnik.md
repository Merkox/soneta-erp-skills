# Pola i właściwości klasy biznesowej: `Soneta.Place.WypSkladnik`
Nazwa tabeli: `WypSkladniki`
Tytuł: Składniki wypłaty
Opis: Element szczegółowy elementu wypłaty (WypElement). Przechowuje szczegółowe parametry obliczeniowe składnika: podstawy, ułamki, czas, dni i okres, rozbijając naliczenie na atomowe części składowe.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Element` → `WypElement`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` | bazodanowe | Czas |  |
| DataKursu | `Soneta.Types.Date` |  |  |  |
| Dni | `int` | bazodanowe | Dni |  |
| Element | `Soneta.Place.WypElement` | bazodanowe, guided-parent |  |  |
| Ilosc | `double` | bazodanowe | Ilość |  |
| KodRSA | `Soneta.Place.KodRSA` |  |  |  |
| Nieobecnosc | `Soneta.Kalend.Nieobecnosc` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Podstawa1 | `Soneta.Types.DoubleCy` | bazodanowe | Podstawa 1 |  |
| Podstawa2 | `Soneta.Types.DoubleCy` | bazodanowe | Podstawa 2 |  |
| Podstawa3 | `Soneta.Types.DoubleCy` | bazodanowe | Podstawa 3 |  |
| Podstawa4 | `Soneta.Types.DoubleCy` | bazodanowe | Podstawa 4 |  |
| Podstawa5 | `Soneta.Types.DoubleCy` | bazodanowe | Podstawa 5 |  |
| PodstawaOkres | `Soneta.Types.FromTo` | bazodanowe | PodstawaOkres |  |
| Procent | `Soneta.Types.Percent` |  | Procent |  |
| Rodzaj | `Soneta.Place.RodzajSkładnikaWypłaty` | bazodanowe, enum |  |  |
| RozliczenieStorna | `bool` |  |  |  |
| SkładnikiPowiązane | `System.Collections.IList` |  |  | Składniki tego samego źródła wypłaty, z przecinającym się okresem |
| SkładnikiPowiązane2 | `System.Collections.IList` |  |  | Składniki tego samego źródła wypłaty, z przecinającym się okresem |
| SkładnikiPowiązaneMiesięcznie | `System.Collections.ArrayList` |  |  | Składniki tego samego źródła wypłaty, z przecinającym się okresem co do miesiąca |
| StanStorna | `Soneta.Place.StanStornaElementu` | bazodanowe, enum |  |  |
| Ulamek | `Soneta.Types.Fraction` | bazodanowe | Współczynnik |  |
| Wartosc | `decimal` | bazodanowe | Wartość w PLN |  |
| WartoscCy | `Soneta.Types.Currency` | bazodanowe | Wartość w walucie |  |
| WartośćAgregowana | `decimal` |  |  | Zagregowana wartość składnika |
| WartośćDopełniona | `decimal` |  |  | Wartość składnika dopełniona do pełnego miesiąca |
| WartośćGodzinyKorygowana | `double` |  |  | Suma wszystkich składników głównych i korygowanych zawierających danych składnik przeliczona na wartość 1 godziny |
| WartośćKorygowana | `decimal` |  |  | Suma wszystkich składników głównych i korygowanych zawierających danych składnik |
| WartośćKorygowanaCy | `Soneta.Types.Currency` |  |  | Suma w walucie wszystkich składników głównych i korygowanych zawierających danych składnik |
| Wspolczynnik | `decimal` |  | Współczynnik |  |
| Zatwierdzony | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajSkładnikaWypłaty (`Soneta.Place.RodzajSkładnikaWypłaty`)
- `Główny` = 1 — Główny
- `Korekta` = 2
- `PomniejszenieProp` = 101
- `Pomniejszenie130` = 102
- `PomniejszenieZaDzień` = 103
- `PomniejszeniePropZero` = 104
- `PomniejszenieStorno` = 150
- `OdchyłkaPlus` = 200
- `OdchyłkaMinus` = 201
- `OdchyłkaAkordMinus` = 202
- `OdchyłkaRozliczanePlus` = 203
- `OdchyłkaRozliczaneMinus` = 204
- `OdchyłkaPostojoweMinus` = 205
- `Algorytm` = 300

### StanStornaElementu (`Soneta.Place.StanStornaElementu`)
- `NieDotyczy` = 0 — Nie dotyczy
- `DoStornowania` = 1
- `Wystornowany` = 2
- `Stornujący` = 3
- `WycofaneStorno` = 10
