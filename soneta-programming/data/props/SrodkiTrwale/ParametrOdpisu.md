# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.ParametrOdpisu`
Nazwa tabeli: `ParametryOdpisow`
Tytuł: Parametry odpisów
Opis: Element szczegółowy obrotu środka trwałego (ObrotST). Przechowuje parametry amortyzacji bilansowej i podatkowej wraz z dodatkowymi metodami amortyzacji, stanowiąc podstawę do naliczania odpisów amortyzacyjnych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Amortyzacja` → `ObrotST`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 2
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Amortyzacja | `Soneta.SrodkiTrwale.ObrotST` | bazodanowe, tylko-odczyt, guided-parent |  | Odpis amortyzacyjny |
| MetodaDodatkowaBilansowa | `Soneta.SrodkiTrwale.MetodaAmortyzacji` (enum) | bazodanowe |  | Dodatkowa metoda amortyzacji bilansowej |
| MetodaDodatkowaPodatkowa | `Soneta.SrodkiTrwale.MetodaAmortyzacji` (enum) | bazodanowe |  | Dodatkowa metoda amortyzacji podatkowej |
| ParametryBilansowe | `Soneta.SrodkiTrwale.ParametryAmortyzacji` (subrow) | bazodanowe |  | Parametry amortyzacji bilansowej |
| ParametryBilansowe.Metoda | `Soneta.SrodkiTrwale.MetodaAmortyzacji` (enum) | bazodanowe |  | Metoda amortyzacji środka trwałego |
| ParametryBilansowe.Proporcja | `double` | tylko-odczyt |  |  |
| ParametryBilansowe.Stawka | `Percent` | bazodanowe |  | Stawka amortyzacji środka trwałego |
| ParametryBilansowe.WgProporcji | `bool` | bazodanowe | Wg proporcji | Amortyzacja Liniowa liczona wg proporcji |
| ParametryBilansowe.Wspolczynnik | `decimal` | bazodanowe | Współczynnik | Współczynnik amortyzacji środka trwałego |
| ParametryBilansowe.ZmianaOkresuUzytecznosci | `bool` | bazodanowe | Zmiana okresu użyteczności | Zmiana okresu użyteczności |
| ParametryPodatkowe | `Soneta.SrodkiTrwale.ParametryAmortyzacji` (subrow) | bazodanowe |  | Parametry amortyzacji podatkowej |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### MetodaAmortyzacji (`Soneta.SrodkiTrwale.MetodaAmortyzacji`)
- `NieAmortyzować` = 0 — Nie amortyzować
- `Jednorazowa` = 1
- `Liniowa` = 2
- `Degresywna` = 3
