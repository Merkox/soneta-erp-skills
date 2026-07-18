# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProWariantowoscZasobuOperacjiZlecenia`
Nazwa tabeli: `ProWarZasobowOZ`
Tytuł: Wariantowość zasobów operacji zlecenia
Opis: Element szczegółowy zasobu operacji zlecenia (ProZasobOperacjiZlecenia). Definiuje alternatywne zasoby z indywidualnymi stawkami i normami czasu jednostkowego oraz przygotowawczo-zakończeniowego, umożliwiając elastyczny dobór zamienników zasobów w operacji zlecenia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ZasobOperacjiZlecenia` → `ProZasobOperacjiZlecenia`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasTj | `TimeSec` | bazodanowe | Czas tj | Czas jednostkowy wariantowości zasobu operacji zlecenia. |
| CzasTpz | `TimeSec` | bazodanowe | Czas tpz | Czas przygotowawczo-zakończeniowy wariantowości zasobu operacji zlecenia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wariantowości zasobu operacji zlecenia. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka wariantowości zasobu operacji zlecenia. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Zasób | Zasób dla zasobu operacji zlecenia. |
| ZasobOperacjiZlecenia | `Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia` | bazodanowe, guided-parent | Zasób operacji zlecenia | Zasób operacji zlecenia dla wariantowości zasobu operacji zlecenia. |
