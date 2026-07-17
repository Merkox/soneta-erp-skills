# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.ObrotST`
Nazwa tabeli: `ObrotyST`
Tytuł: Obroty środków trwałych
Opis: Element szczegółowy dokumentu środka trwałego (DokumentST). Rejestruje pojedynczy obrót (zmianę wartości) środka trwałego z informacjami o typie i kierunku operacji, wartościach bilansowych i podatkowych, ilości inwentarzowej oraz danych dotyczących podatku od nieruchomości.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentST`
Implementuje interfejsy: `IZrodloOpisuAnalitycznego`

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  | Data obrotu |
| DataKsiegowania | `Soneta.Types.Date` | bazodanowe | Data księgowania | Data księgowania obrotu |
| Dokument | `Soneta.SrodkiTrwale.DokumentST` | bazodanowe, guided-parent |  | Dokument obrotu środka trwałego |
| ElementPodatku | `Soneta.SrodkiTrwale.ElementPodatkuOdNieruch` | bazodanowe |  | Element obrotu podatku od nieruchomości |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| Ilosc | `double` | bazodanowe | Ilość | Ilość inwentarzowa |
| IloscRoznica | `double` |  |  |  |
| IloscWgKartoteki | `double` |  |  |  |
| JednostkaMiary | `Soneta.Towary.Jednostka` |  |  |  |
| Kierunek | `Soneta.SrodkiTrwale.KierunekObrotuST` | bazodanowe, enum |  | Kierunek obrotu środka trwałego |
| KwotaNKUP | `Soneta.Types.Currency` |  |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa obrotu w dokumencie |
| Opis | `string` |  |  |  |
| OpisAnalityczny | `Soneta.Business.SubTable` |  |  |  |
| OpisAnalitycznyBufor | `bool` |  |  |  |
| PageVisible | `bool` |  |  |  |
| Parametr | `Soneta.SrodkiTrwale.ParametrOdpisu` |  |  |  |
| Powierzchnia | `double` | bazodanowe |  | Powierzchnia elementu podatku od nieruchomości |
| ReadOnlyKierunek | `bool` |  |  |  |
| SrodekTrwaly | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe | Środek trwały | Środek trwały |
| Stawka | `decimal` | bazodanowe |  | Stawka obrotu opodatkowania podatku od nieruchomości |
| SymbolBilansowy | `string` |  |  | Symbol metody amortyzacji z uwzględnieniem metody dodatkowej |
| SymbolPodatkowy | `string` |  |  | Symbol metody amortyzacji z uwzględnieniem metody dodatkowej |
| Typ | `Soneta.SrodkiTrwale.TypObrotuST` | bazodanowe, enum |  | Typ obrotu środka trwałego |
| Uwagi | `string` | bazodanowe |  | Uwagi |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  | Wartość obrotu elementu podatku od nieruchomości |
| WartoscBilansowa | `Soneta.Types.Currency` | bazodanowe | Wartość bilansowa | Wartość bilansowa obrotu |
| WartoscOplaty | `Soneta.Types.Currency` |  |  |  |
| WartoscPodatkowa | `Soneta.Types.Currency` | bazodanowe | Wartość podatkowa | Wartość podatkowa obrotu |
| ZrodloFinansowania | `Soneta.Core.ZrodloFinansowania` | bazodanowe | Źródło finansowania |  |

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
