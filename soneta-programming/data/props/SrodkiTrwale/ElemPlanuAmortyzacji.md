# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.ElemPlanuAmortyzacji`
Nazwa tabeli: `PlanAmortyzacji`
Tytuł: Plan amortyzacji
Opis: Element szczegółowy środka trwałego (SrodekTrwalyBase). Zawiera harmonogram planowanej amortyzacji z podziałem na wartości bilansowe i podatkowe w rozbiciu na daty i źródła finansowania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Srodek` → `SrodekTrwalyBase`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  | Data planowanej amortyzacji |
| Miesiac | `Soneta.Types.YearMonth` |  | Miesiąc planowanej amortyzacji |  |
| Srodek | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe, guided-parent |  |  |
| WartoscBilansowa | `Soneta.Types.Currency` | bazodanowe | Wartość bilansowa | Wartość bilansowa |
| WartoscPodatkowa | `Soneta.Types.Currency` | bazodanowe | Wartość podatkowa | Wartość podatkowa |
| ZrodloFinansowania | `Soneta.Core.ZrodloFinansowania` | bazodanowe | Źródło finansowania |  |
