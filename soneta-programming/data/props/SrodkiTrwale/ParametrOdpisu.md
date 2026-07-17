# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.ParametrOdpisu`
Nazwa tabeli: `ParametryOdpisow`
Tytuł: Parametry odpisów
Opis: Element szczegółowy obrotu środka trwałego (ObrotST). Przechowuje parametry amortyzacji bilansowej i podatkowej wraz z dodatkowymi metodami amortyzacji, stanowiąc podstawę do naliczania odpisów amortyzacyjnych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Amortyzacja` → `ObrotST`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Amortyzacja | `Soneta.SrodkiTrwale.ObrotST` | bazodanowe, guided-parent |  | Odpis amortyzacyjny |
| MetodaDodatkowaBilansowa | `Soneta.SrodkiTrwale.MetodaAmortyzacji` | bazodanowe, enum |  | Dodatkowa metoda amortyzacji bilansowej |
| MetodaDodatkowaPodatkowa | `Soneta.SrodkiTrwale.MetodaAmortyzacji` | bazodanowe, enum |  | Dodatkowa metoda amortyzacji podatkowej |
| ParametryBilansowe | `Soneta.SrodkiTrwale.ParametryAmortyzacji` | bazodanowe |  | Parametry amortyzacji bilansowej |
| ParametryBilansowe.Metoda | `Soneta.SrodkiTrwale.MetodaAmortyzacji` | bazodanowe, enum |  | Metoda amortyzacji środka trwałego |
| ParametryBilansowe.Proporcja | `double` |  |  |  |
| ParametryBilansowe.Stawka | `Soneta.Types.Percent` | bazodanowe |  | Stawka amortyzacji środka trwałego |
| ParametryBilansowe.WgProporcji | `bool` | bazodanowe | Wg proporcji | Amortyzacja Liniowa liczona wg proporcji |
| ParametryBilansowe.Wspolczynnik | `decimal` | bazodanowe | Współczynnik | Współczynnik amortyzacji środka trwałego |
| ParametryBilansowe.ZmianaOkresuUzytecznosci | `bool` | bazodanowe | Zmiana okresu użyteczności | Zmiana okresu użyteczności |
| ParametryPodatkowe | `Soneta.SrodkiTrwale.ParametryAmortyzacji` | bazodanowe |  | Parametry amortyzacji podatkowej |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### MetodaAmortyzacji (`Soneta.SrodkiTrwale.MetodaAmortyzacji`)
- `NieAmortyzować` = 0 — Nie amortyzować
- `Jednorazowa` = 1
- `Liniowa` = 2
- `Degresywna` = 3
