# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.ElemPlanuAmortyzacji`
Nazwa tabeli: `PlanAmortyzacji`
Tytuł: Plan amortyzacji
Opis: Element szczegółowy środka trwałego (SrodekTrwalyBase). Zawiera harmonogram planowanej amortyzacji z podziałem na wartości bilansowe i podatkowe w rozbiciu na daty i źródła finansowania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Srodek` → `SrodekTrwalyBase`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt |  | Data planowanej amortyzacji |
| Miesiac | `YearMonth` |  | Miesiąc planowanej amortyzacji |  |
| Srodek | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| WartoscBilansowa | `Currency` | bazodanowe | Wartość bilansowa | Wartość bilansowa |
| WartoscPodatkowa | `Currency` | bazodanowe | Wartość podatkowa | Wartość podatkowa |
| ZrodloFinansowania | `Soneta.Core.ZrodloFinansowania` | bazodanowe | Źródło finansowania |  |
