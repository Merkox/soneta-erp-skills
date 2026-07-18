# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.ObrotST`
Nazwa tabeli: `ObrotyST`
Tytuł: Obroty środków trwałych
Opis: Element szczegółowy dokumentu środka trwałego (DokumentST). Rejestruje pojedynczy obrót (zmianę wartości) środka trwałego z informacjami o typie i kierunku operacji, wartościach bilansowych i podatkowych, ilości inwentarzowej oraz danych dotyczących podatku od nieruchomości.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentST`
Implementuje interfejsy: `IZrodloOpisuAnalitycznego`
Selektor: pole `Typ` (`Soneta.SrodkiTrwale.TypObrotuST`) — wiele typów w jednej tabeli, podtypów: 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  | Data obrotu |
| DataKsiegowania | `Date` | bazodanowe | Data księgowania | Data księgowania obrotu |
| Dokument | `Soneta.SrodkiTrwale.DokumentST` | bazodanowe, tylko-odczyt, guided-parent |  | Dokument obrotu środka trwałego |
| ElementPodatku | `Soneta.SrodkiTrwale.ElementPodatkuOdNieruch` | bazodanowe |  | Element obrotu podatku od nieruchomości |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| Ilosc | `double` | bazodanowe | Ilość | Ilość inwentarzowa |
| IloscRoznica | `double` | tylko-odczyt |  |  |
| IloscWgKartoteki | `double` | tylko-odczyt |  |  |
| JednostkaMiary | `Soneta.Towary.Jednostka` | tylko-odczyt |  |  |
| Kierunek | `Soneta.SrodkiTrwale.KierunekObrotuST` (enum) | bazodanowe |  | Kierunek obrotu środka trwałego |
| KwotaNKUP | `Currency` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa obrotu w dokumencie |
| Opis | `string` | tylko-odczyt |  |  |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| OpisAnalitycznyBufor | `bool` | tylko-odczyt |  |  |
| PageVisible | `bool` | tylko-odczyt |  |  |
| Parametr | `Soneta.SrodkiTrwale.ParametrOdpisu` | tylko-odczyt |  |  |
| Powierzchnia | `double` | bazodanowe |  | Powierzchnia elementu podatku od nieruchomości |
| ReadOnlyKierunek | `bool` | tylko-odczyt |  |  |
| SrodekTrwaly | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe | Środek trwały | Środek trwały |
| Stawka | `decimal` | bazodanowe |  | Stawka obrotu opodatkowania podatku od nieruchomości |
| SymbolBilansowy | `string` | tylko-odczyt |  | Symbol metody amortyzacji z uwzględnieniem metody dodatkowej |
| SymbolPodatkowy | `string` | tylko-odczyt |  | Symbol metody amortyzacji z uwzględnieniem metody dodatkowej |
| Typ | `Soneta.SrodkiTrwale.TypObrotuST` (enum) | bazodanowe, tylko-odczyt, selektor |  | Typ obrotu środka trwałego |
| Uwagi | `string` | bazodanowe |  | Uwagi |
| Wartosc | `Currency` | bazodanowe |  | Wartość obrotu elementu podatku od nieruchomości |
| WartoscBilansowa | `Currency` | bazodanowe | Wartość bilansowa | Wartość bilansowa obrotu |
| WartoscOplaty | `Currency` | tylko-odczyt |  |  |
| WartoscPodatkowa | `Currency` | bazodanowe | Wartość podatkowa | Wartość podatkowa obrotu |
| ZrodloFinansowania | `Soneta.Core.ZrodloFinansowania` | bazodanowe | Źródło finansowania |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `OT` | 1 | `Soneta.SrodkiTrwale.ObrotOT` | Obrót 'OT' |
| `LT` | 2 | `Soneta.SrodkiTrwale.ObrotLT` | Obrót 'LT' |
| `Amortyzacja` | 3 | `Soneta.SrodkiTrwale.ObrotAmortyzacja` | Obrót 'Amortyzacja' |
| `Przeszacowanie` | 4 | `Soneta.SrodkiTrwale.ObrotPrzeszacowanie` | Obrót 'Przeszacowanie' |
| `ZmianaWartości` | 5 | `Soneta.SrodkiTrwale.ObrotZmianaWartosci` | Obrót 'Zmiana wartości' |
| `AmortyzacjaLT` | 6 | `Soneta.SrodkiTrwale.ObrotAmortyzacjaLT` | Obrót 'Amortyzacja LT' |
| `AmortyzacjaZW` | 7 | `Soneta.SrodkiTrwale.ObrotAmortyzacjaZW` | Obrót 'Amortyzacja ZW' |
| `Inwentaryzacja` | 8 | `Soneta.SrodkiTrwale.PozycjaInwentaryzacji` | Pozycja inwentaryzacji |
| `OdpisAktualizujący` | 9 | `Soneta.SrodkiTrwale.ObrotOdpisAktualizujacy` | Obrót 'Odpis aktualizujacy' |
| `OdpisAktualizującyLT` | 10 | `Soneta.SrodkiTrwale.ObrotOdpisAktualizujacyLT` | Obrót 'Odpis aktualizujący LT' |
| `PodatekOdNieruchomosci` | 11 | `Soneta.SrodkiTrwale.ObrotPON` | Obrót 'Podatek od nieruchomości' |
| `InwentaryzacjaCzastkowa` | 12 | `Soneta.SrodkiTrwale.PozycjaInwentaryzacjiCzastkowej` | Pozycja spisowa |
| `OplataWstepna` | 20 | `Soneta.SrodkiTrwale.ObrotOplataWstepna` | Obrót Opłata wstępna |
| `Kapital` | 21 | `Soneta.SrodkiTrwale.ObrotKapital` | Obrót Kapitał |
| `Odsetki` | 22 | `Soneta.SrodkiTrwale.ObrotOdsetki` | Obrót Odsetki |
| `Wykup` | 23 | `Soneta.SrodkiTrwale.ObrotWykup` | Obrót Wykup |
| `PozostaleKoszty` | 24 | `Soneta.SrodkiTrwale.ObrotPozostaleKoszty` | Obrót Pozostałe koszty |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekObrotuST (`Soneta.SrodkiTrwale.KierunekObrotuST`)
- `ZmniejszenieWartości` = 0 — Zmniejszenie wartości
- `ZwiększenieWartości` = 1

### TypObrotuST (`Soneta.SrodkiTrwale.TypObrotuST`)
- `Brak` = 0
- `OT` = 1
- `LT` = 2
- `Amortyzacja` = 3
- `Przeszacowanie` = 4
- `ZmianaWartości` = 5
- `AmortyzacjaLT` = 6 — Amortyzacja LT
- `AmortyzacjaZW` = 7 — Amortyzacja ZW
- `Inwentaryzacja` = 8
- `OdpisAktualizujący` = 9
- `OdpisAktualizującyLT` = 10
- `PodatekOdNieruchomosci` = 11
- `InwentaryzacjaCzastkowa` = 12
- `OplataWstepna` = 20 — Opłata wstępna
- `Kapital` = 21 — Kapitał
- `Odsetki` = 22 — Odsetki
- `Wykup` = 23 — Wykup
- `PozostaleKoszty` = 24 — Pozostałe koszty
