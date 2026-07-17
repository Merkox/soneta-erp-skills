# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.ProporcjaAmortyzacji`
Nazwa tabeli: `ProporcjeAmortyzacji`
Tytuł: Proporcja amortyzacji
Opis: Element szczegółowy środka trwałego (SrodekTrwalyBase). Definiuje historyczne proporcje podziału amortyzacji bilansowej i podatkowej według źródeł finansowania środka trwałego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Srodek` → `SrodekTrwalyBase`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| ProporcjaBilansowa | `double` | bazodanowe | Proporcja Bilansowa | Proporcja amortyzacji Bilansowa |
| ProporcjaPodatkowa | `double` | bazodanowe | Proporcja Podatkowa | Proporcja amortyzacji Podatkowa |
| Srodek | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe, guided-parent |  |  |
| ZrodloFinansowania | `Soneta.Core.ZrodloFinansowania` | bazodanowe | Źródło finansowania |  |
