# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.ElementPodatkuOdNieruch`
Nazwa tabeli: `ElemPodOdNieruch`
Tytuł: Elementy podatku od nieruchomości
Opis: Element szczegółowy historii środka trwałego (SrodekTrwalyBaseHistoria). Rejestruje dane dotyczące podatku od nieruchomości dla środka trwałego, w tym przedmiot opodatkowania, powierzchnię całkowitą i cząstkową, wartość oraz informację o podleganiu opodatkowaniu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Historia` → `SrodekTrwalyBaseHistoria`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.Date` |  |  |  |
| Historia | `Soneta.SrodkiTrwale.SrodekTrwalyBaseHistoria` | bazodanowe, guided-parent |  |  |
| Lp | `int` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| PodlegaOpodatkowaniu | `bool` | bazodanowe |  |  |
| Powierzchnia1 | `double` | bazodanowe |  |  |
| Powierzchnia2 | `double` | bazodanowe |  |  |
| PowierzchniaCalkowita | `double` | bazodanowe |  |  |
| PrzedmiotOpodatkowania | `Soneta.SrodkiTrwale.PrzedmiotOp` | bazodanowe |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  |  |
