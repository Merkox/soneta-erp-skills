# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.ElementPodatkuOdNieruch`
Nazwa tabeli: `ElemPodOdNieruch`
Tytuł: Elementy podatku od nieruchomości
Opis: Element szczegółowy historii środka trwałego (SrodekTrwalyBaseHistoria). Rejestruje dane dotyczące podatku od nieruchomości dla środka trwałego, w tym przedmiot opodatkowania, powierzchnię całkowitą i cząstkową, wartość oraz informację o podleganiu opodatkowaniu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Historia` → `SrodekTrwalyBaseHistoria`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Date` |  |  |  |
| Historia | `Soneta.SrodkiTrwale.SrodekTrwalyBaseHistoria` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Lp | `int` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| PodlegaOpodatkowaniu | `bool` | bazodanowe |  |  |
| Powierzchnia1 | `double` | bazodanowe |  |  |
| Powierzchnia2 | `double` | bazodanowe |  |  |
| PowierzchniaCalkowita | `double` | bazodanowe |  |  |
| PrzedmiotOpodatkowania | `Soneta.SrodkiTrwale.PrzedmiotOp` | bazodanowe |  |  |
| Wartosc | `Currency` | bazodanowe |  |  |
