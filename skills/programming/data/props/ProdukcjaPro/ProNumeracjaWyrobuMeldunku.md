# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProNumeracjaWyrobuMeldunku`
Nazwa tabeli: `ProNrWyrobowM`
Tytuł: Numeracje wyrobów meldunków
Opis: Element szczegółowy numeracji wyrobu meldunku (ProWyrobMeldunku). Przechowuje numer seryjny lub partyjny dostawy przypisany do wyrobu meldunku. Umożliwia identyfikację i śledzenie poszczególnych sztuk lub partii wyrobów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `WyrobMeldunku` → `ProWyrobMeldunku`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość numeracji wyrobu meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa numeracji wyrobu meldunku. |
| Numer | `string` | bazodanowe | Numer | Numer dostawy numeracji wyrobu meldunku. |
| WyrobMeldunku | `Soneta.ProdukcjaPro.ProWyrobMeldunku` | bazodanowe, guided-parent |  | Wyrób meldunku dla numeracji wyrobu meldunku. |
