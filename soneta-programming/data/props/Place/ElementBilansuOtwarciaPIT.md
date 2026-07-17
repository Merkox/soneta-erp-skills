# Pola i właściwości klasy biznesowej: `Soneta.Place.ElementBilansuOtwarciaPIT`
Nazwa tabeli: `ElementyBOPIT`
Tytuł: Elementy bilansów otwarcia PIT
Opis: Element szczegółowy bilansu otwarcia PIT (BilansOtwarciaPIT). Przechowuje przychody, koszty i zaliczki z podziałem na pozycje deklaracji PIT, importowane z poprzedniego systemu lub pracodawcy.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `BilansOtwarciaPIT`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dochód | `decimal` |  |  |  |
| Dokument | `Soneta.Place.BilansOtwarciaPIT` | bazodanowe, guided-parent |  |  |
| Koszty | `decimal` | bazodanowe | Koszty |  |
| Koszty50 | `decimal` | bazodanowe | Koszty 50% |  |
| Pit26 | `bool` | bazodanowe | Przychód do 26 lat |  |
| PozycjaPIT | `Soneta.Place.PozycjaPIT` | bazodanowe |  |  |
| Przychod | `decimal` | bazodanowe | Przychód |  |
| Przychod50 | `decimal` | bazodanowe | Przychód 50% |  |
| Zaliczka | `decimal` | bazodanowe | Zaliczka PIT |  |
| Zwolniony | `decimal` | bazodanowe | Dochód zwolniony od podatku |  |
