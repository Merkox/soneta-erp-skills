# Pola i właściwości klasy biznesowej: `Soneta.Place.ElementBilansuOtwarciaPIT`
Nazwa tabeli: `ElementyBOPIT`
Tytuł: Elementy bilansów otwarcia PIT
Opis: Element szczegółowy bilansu otwarcia PIT (BilansOtwarciaPIT). Przechowuje przychody, koszty i zaliczki z podziałem na pozycje deklaracji PIT, importowane z poprzedniego systemu lub pracodawcy.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `BilansOtwarciaPIT`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 0
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dochód | `decimal` | tylko-odczyt |  |  |
| Dokument | `Soneta.Place.BilansOtwarciaPIT` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Koszty | `decimal` | bazodanowe | Koszty |  |
| Koszty50 | `decimal` | bazodanowe | Koszty 50% |  |
| Pit26 | `bool` | bazodanowe, tylko-odczyt | Przychód do 26 lat |  |
| PozycjaPIT | `Soneta.Place.PozycjaPIT` | bazodanowe, tylko-odczyt |  |  |
| Przychod | `decimal` | bazodanowe | Przychód |  |
| Przychod50 | `decimal` | bazodanowe | Przychód 50% |  |
| Zaliczka | `decimal` | bazodanowe | Zaliczka PIT |  |
| Zwolniony | `decimal` | bazodanowe | Dochód zwolniony od podatku |  |
