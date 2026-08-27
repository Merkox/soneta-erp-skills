# Pola i właściwości klasy biznesowej: `Soneta.Place.WypSkladnik`
Nazwa tabeli: `WypSkladniki`
Tytuł: Składniki wypłaty
Opis: Element szczegółowy elementu wypłaty (WypElement). Przechowuje szczegółowe parametry obliczeniowe składnika: podstawy, ułamki, czas, dni i okres, rozbijając naliczenie na atomowe części składowe.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Element` → `WypElement`
Selektor: pole `Rodzaj` (`Soneta.Place.RodzajSkładnikaWypłaty`) — wiele typów w jednej tabeli, podtypów: 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | bazodanowe | Czas |  |
| DataKursu | `Date` | tylko-odczyt |  |  |
| Dni | `int` | bazodanowe | Dni |  |
| Element | `Soneta.Place.WypElement` | bazodanowe, guided-parent |  |  |
| Ilosc | `double` | bazodanowe | Ilość |  |
| KodRSA | `Soneta.Place.KodRSA` | tylko-odczyt |  |  |
| Nieobecnosc | `Soneta.Kalend.Nieobecnosc` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Podstawa1 | `DoubleCy` | bazodanowe | Podstawa 1 |  |
| Podstawa2 | `DoubleCy` | bazodanowe | Podstawa 2 |  |
| Podstawa3 | `DoubleCy` | bazodanowe | Podstawa 3 |  |
| Podstawa4 | `DoubleCy` | bazodanowe | Podstawa 4 |  |
| Podstawa5 | `DoubleCy` | bazodanowe | Podstawa 5 |  |
| PodstawaOkres | `FromTo` | bazodanowe, podlista | PodstawaOkres |  |
| Procent | `Percent` |  | Procent |  |
| Rodzaj | `Soneta.Place.RodzajSkładnikaWypłaty` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| RozliczenieStorna | `bool` | tylko-odczyt |  |  |
| SkładnikiPowiązane | `System.Collections.IList` | podlista |  | Składniki tego samego źródła wypłaty, z przecinającym się okresem |
| SkładnikiPowiązane2 | `System.Collections.IList` | podlista |  | Składniki tego samego źródła wypłaty, z przecinającym się okresem |
| SkładnikiPowiązaneMiesięcznie | `System.Collections.ArrayList` | podlista |  | Składniki tego samego źródła wypłaty, z przecinającym się okresem co do miesiąca |
| StanStorna | `Soneta.Place.StanStornaElementu` (enum) | bazodanowe, tylko-odczyt |  |  |
| Ulamek | `Fraction` | bazodanowe | Współczynnik |  |
| Wartosc | `decimal` | bazodanowe | Wartość w PLN |  |
| WartoscCy | `Currency` | bazodanowe | Wartość w walucie |  |
| WartośćAgregowana | `decimal` | tylko-odczyt |  | Zagregowana wartość składnika |
| WartośćDopełniona | `decimal` | tylko-odczyt |  | Wartość składnika dopełniona do pełnego miesiąca |
| WartośćGodzinyKorygowana | `double` | tylko-odczyt |  | Suma wszystkich składników głównych i korygowanych zawierających danych składnik przeliczona na wartość 1 godziny |
| WartośćKorygowana | `decimal` | tylko-odczyt |  | Suma wszystkich składników głównych i korygowanych zawierających danych składnik |
| WartośćKorygowanaCy | `Currency` | tylko-odczyt |  | Suma w walucie wszystkich składników głównych i korygowanych zawierających danych składnik |
| Wspolczynnik | `decimal` |  | Współczynnik |  |
| Zatwierdzony | `bool` | tylko-odczyt |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Główny` | 1 | `Soneta.Place.WypSkladnikGłówny` |  |
| `Korekta` | 2 | `Soneta.Place.WypSkladnikKorekta` |  |
| `PomniejszenieProp` | 101 | `Soneta.Place.WypSkladnikPomniejszenie.Proporcjonalne` |  |
| `Pomniejszenie130` | 102 | `Soneta.Place.WypSkladnikPomniejszenie.Pomn130` |  |
| `PomniejszenieZaDzień` | 103 | `Soneta.Place.WypSkladnikPomniejszenie.PomnZaDzień` |  |
| `PomniejszeniePropZero` | 104 | `Soneta.Place.WypSkladnikPomniejszenie.ProporcjonalneZero` |  |
| `PomniejszenieStorno` | 150 | `Soneta.Place.WypSkladnikStorno` |  |
| `OdchyłkaPlus` | 200 | `Soneta.Place.WypSkladnikOdchyłka.Plus` |  |
| `OdchyłkaMinus` | 201 | `Soneta.Place.WypSkladnikOdchyłka.Minus` |  |
| `OdchyłkaAkordMinus` | 202 | `Soneta.Place.WypSkladnikOdchyłka.AkordMinus` |  |
| `OdchyłkaRozliczanePlus` | 203 | `Soneta.Place.WypSkladnikOdchyłka.RozliczanePlus` |  |
| `OdchyłkaRozliczaneMinus` | 204 | `Soneta.Place.WypSkladnikOdchyłka.RozliczaneMinus` |  |
| `OdchyłkaPostojoweMinus` | 205 | `Soneta.Place.WypSkladnikOdchyłka.PostojoweMinus` |  |
| `Algorytm` | 300 | `Soneta.Place.WypSkladnikPomniejszenie.Algorytm` |  |

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
