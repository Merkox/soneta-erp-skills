# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProDostawaMaterialuMeldunku`
Nazwa tabeli: `ProDostawyMM`
Tytuł: Dostawy materiałów meldunków
Opis: Element szczegółowy dostawy materiału meldunku (ProMaterialMeldunku). Określa konkretną dostawę powiązaną z materiałem meldunku produkcyjnego. Przechowuje ilość oraz wskazanie na pozycję dokumentu handlowego dostawy bieżącej i pierwotnej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `MaterialMeldunku` → `ProMaterialMeldunku`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dostawa | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Wskazana dostawa dla dostawy materiału meldunku. |
| DostawaPierwotna | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe | Dostawa pierwotna | Wskazana dostawa pierwotna dla dostawy materiału meldunku. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość dostawy materiału meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa dostawy materiału meldunku. |
| MaterialMeldunku | `Soneta.ProdukcjaPro.ProMaterialMeldunku` | bazodanowe, guided-parent |  | Materiał meldunku dla dostawy materiału meldunku. |
