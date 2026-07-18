# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProNumeracjaWyrobuMeldunku`
Nazwa tabeli: `ProNrWyrobowM`
Tytuł: Numeracje wyrobów meldunków
Opis: Element szczegółowy numeracji wyrobu meldunku (ProWyrobMeldunku). Przechowuje numer seryjny lub partyjny dostawy przypisany do wyrobu meldunku. Umożliwia identyfikację i śledzenie poszczególnych sztuk lub partii wyrobów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `WyrobMeldunku` → `ProWyrobMeldunku`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość numeracji wyrobu meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa numeracji wyrobu meldunku. |
| Numer | `string` | bazodanowe | Numer | Numer dostawy numeracji wyrobu meldunku. |
| WyrobMeldunku | `Soneta.ProdukcjaPro.ProWyrobMeldunku` | bazodanowe, guided-parent |  | Wyrób meldunku dla numeracji wyrobu meldunku. |
