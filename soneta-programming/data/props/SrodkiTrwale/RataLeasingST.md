# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.RataLeasingST`
Nazwa tabeli: `RatyLeasingST`
Tytuł: Rata
Opis: Element szczegółowy środka trwałego (SrodekTrwalyBase). Reprezentuje pojedynczą ratę harmonogramu leasingowego z kwotami opłat w walucie i PLN, wartościami bilansowymi, podatkowymi, VAT oraz informacją o statusie zapłaty.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Srodek` → `SrodekTrwalyBase`

- pola bazodanowe (zapisywalne): 27
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 1
- subrowy: 0
- razem: 31

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| AmortyzacjaMc | `Currency` | bazodanowe |  | Amortyzacja miesięczna |
| AmortyzacjaNar | `Currency` | bazodanowe |  | Amortyzacja narastająco |
| Data | `Date` | bazodanowe |  | Data raty |
| Kierunek | `Soneta.SrodkiTrwale.KierunekRaty` (enum) | bazodanowe |  | Kierunek raty |
| Lp | `int` | bazodanowe |  | Liczba porządkowa raty |
| Miesiac | `int` | bazodanowe |  | Miesiąc raty |
| NumerRaty | `int` | bazodanowe |  | Numer raty |
| Obrot | `Soneta.SrodkiTrwale.ObrotST` | bazodanowe |  | Obrót |
| PrawoDoUzytkowaniaBoP | `Currency` | bazodanowe |  | Prawo do użytkowania BoP |
| PrawoDoUzytkowaniaEoP | `Currency` | bazodanowe |  | Prawo do użytkowania EoP |
| RecznaEdycja | `bool` | bazodanowe |  | Czy edytowana ręcznie |
| Srodek | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| SrodekTrwalyLeasing | `Soneta.SrodkiTrwale.SrodekTrwalyLeasing` | bazodanowe |  | Środek trwały Leasing |
| SzacowanaWartoscOplatyPLN | `Currency` | bazodanowe |  | Szacowana wartość opłaty w PLN |
| WartoscBilansowa | `Currency` | bazodanowe |  | Wartość bilansowa |
| WartoscNKUP | `Currency` | bazodanowe | Wartość Nkup | Wartość NKUP |
| WartoscOplaty | `Currency` | bazodanowe |  | Wartość opłaty |
| WartoscOplatyPLN | `Currency` | bazodanowe |  | Wartość opłaty w PLN |
| WartoscPodatkowa | `Currency` | bazodanowe |  | Wartość podatkowa |
| WartoscRazem | `Currency` | bazodanowe |  | Wartość razem |
| WartoscVAT | `Currency` | bazodanowe |  | Wartość VAT |
| WartoscVATKUP | `Currency` | bazodanowe | VAT KUP | Wartość VAT KUP |
| WartoscVATNKUP | `Currency` | bazodanowe | VAT NKUP | Wartość VAT NKUP |
| WspolczynnikDyskonta | `double` | bazodanowe | Współczynnik dyskonta | Współczynnik dyskonta |
| WspolczynnikDyskontaStr | `string` | tylko-odczyt |  |  |
| WygenerowaneObroty | `bool` | tylko-odczyt |  |  |
| Zaplacona | `bool` | bazodanowe |  | Czy rata została zapłacona |
| ZdyskontowanaOplata | `Currency` | bazodanowe |  | Zdyskontowana opłata |
| ZobowiazanieBoP | `Currency` | bazodanowe |  | Zobowiazanie BoP |
| ZobowiazanieEoP | `Currency` | bazodanowe |  | Zobowiazanie EoP |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekRaty (`Soneta.SrodkiTrwale.KierunekRaty`)
- `NieDotyczy` = -10 — Nie dotyczy
- `Wszystkie` = -1
- `OplataWstepna` = 0 — Opłata wstępna
- `OplataLeasingowa` = 5 — Opłata leasingowa
- `Kapital` = 10 — Kapitał
- `Odsetki` = 20
- `Wykup` = 30
- `PozostaleKoszty` = 50 — Pozostałe koszty
- `KapitalOdsetki` = 110 — Kapitał+Odsetki
- `OplataWstepnaWykup` = 120 — Opłata wstępna+Wykup
- `KapitalOplataWstepnaWykup` = 130 — Kapitał+Opłata wstępna+Wykup
