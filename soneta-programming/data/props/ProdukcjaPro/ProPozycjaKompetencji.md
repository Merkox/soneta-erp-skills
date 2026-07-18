# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProPozycjaKompetencji`
Nazwa tabeli: `ProPKompetencji`
Tytuł: Pozycje właściwości
Opis: Element szczegółowy właściwości produkcyjnej (ProKompetencja). Definiuje konkretne wartości liczbowe i opisowe danej właściwości, stanowiące katalog dopuszczalnych poziomów kompetencji lub parametrów technicznych przypisywanych do zasobów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Kompetencja` → `ProKompetencja`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kompetencja | `Soneta.ProdukcjaPro.ProKompetencja` | bazodanowe, guided-parent | Właściwość | Właściwość dla pozycji właściwości. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa pozycji właściwości. |
| Opis | `string` | bazodanowe |  | Opis pozycji właściwości. |
| Wartosc | `double` | bazodanowe | Wartość | Wartość pozycji właściwości. |
