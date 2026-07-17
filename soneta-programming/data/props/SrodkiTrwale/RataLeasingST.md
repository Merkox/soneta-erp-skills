# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.RataLeasingST`
Nazwa tabeli: `RatyLeasingST`
Tytuł: Rata
Opis: Element szczegółowy środka trwałego (SrodekTrwalyBase). Reprezentuje pojedynczą ratę harmonogramu leasingowego z kwotami opłat w walucie i PLN, wartościami bilansowymi, podatkowymi, VAT oraz informacją o statusie zapłaty.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Srodek` → `SrodekTrwalyBase`

- pola bazodanowe: 29
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| AmortyzacjaMc | `Soneta.Types.Currency` | bazodanowe |  | Amortyzacja miesięczna |
| AmortyzacjaNar | `Soneta.Types.Currency` | bazodanowe |  | Amortyzacja narastająco |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data raty |
| Kierunek | `Soneta.SrodkiTrwale.KierunekRaty` | bazodanowe, enum |  | Kierunek raty |
| Lp | `int` | bazodanowe |  | Liczba porządkowa raty |
| Miesiac | `int` | bazodanowe |  | Miesiąc raty |
| NumerRaty | `int` | bazodanowe |  | Numer raty |
| Obrot | `Soneta.SrodkiTrwale.ObrotST` | bazodanowe |  | Obrót |
| PrawoDoUzytkowaniaBoP | `Soneta.Types.Currency` | bazodanowe |  | Prawo do użytkowania BoP |
| PrawoDoUzytkowaniaEoP | `Soneta.Types.Currency` | bazodanowe |  | Prawo do użytkowania EoP |
| RecznaEdycja | `bool` | bazodanowe |  | Czy edytowana ręcznie |
| Srodek | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe, guided-parent |  |  |
| SrodekTrwalyLeasing | `Soneta.SrodkiTrwale.SrodekTrwalyLeasing` | bazodanowe |  | Środek trwały Leasing |
| SzacowanaWartoscOplatyPLN | `Soneta.Types.Currency` | bazodanowe |  | Szacowana wartość opłaty w PLN |
| WartoscBilansowa | `Soneta.Types.Currency` | bazodanowe |  | Wartość bilansowa |
| WartoscNKUP | `Soneta.Types.Currency` | bazodanowe | Wartość Nkup | Wartość NKUP |
| WartoscOplaty | `Soneta.Types.Currency` | bazodanowe |  | Wartość opłaty |
| WartoscOplatyPLN | `Soneta.Types.Currency` | bazodanowe |  | Wartość opłaty w PLN |
| WartoscPodatkowa | `Soneta.Types.Currency` | bazodanowe |  | Wartość podatkowa |
| WartoscRazem | `Soneta.Types.Currency` | bazodanowe |  | Wartość razem |
| WartoscVAT | `Soneta.Types.Currency` | bazodanowe |  | Wartość VAT |
| WartoscVATKUP | `Soneta.Types.Currency` | bazodanowe | VAT KUP | Wartość VAT KUP |
| WartoscVATNKUP | `Soneta.Types.Currency` | bazodanowe | VAT NKUP | Wartość VAT NKUP |
| WspolczynnikDyskonta | `double` | bazodanowe | Współczynnik dyskonta | Współczynnik dyskonta |
| WspolczynnikDyskontaStr | `string` |  |  |  |
| WygenerowaneObroty | `bool` |  |  |  |
| Zaplacona | `bool` | bazodanowe |  | Czy rata została zapłacona |
| ZdyskontowanaOplata | `Soneta.Types.Currency` | bazodanowe |  | Zdyskontowana opłata |
| ZobowiazanieBoP | `Soneta.Types.Currency` | bazodanowe |  | Zobowiazanie BoP |
| ZobowiazanieEoP | `Soneta.Types.Currency` | bazodanowe |  | Zobowiazanie EoP |

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
