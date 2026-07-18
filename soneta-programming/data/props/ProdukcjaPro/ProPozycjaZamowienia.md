# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProPozycjaZamowienia`
Nazwa tabeli: `ProPZamowien`
Tytuł: Pozycje zamówień
Opis: Element szczegółowy pozycji zamówienia (ProWyrobOperacjiZlecenia). Wiąże wyrób operacji zlecenia z pozycją dokumentu handlowego zamówienia. Umożliwia śledzenie ilości zamówionych w powiązaniu z produkcją.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wyrob` → `ProWyrobOperacjiZlecenia`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość pozycji zamówienia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa pozycji zamówienia. |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja dokumentu handlowego dla pozycji zamówienia. |
| Wyrob | `Soneta.ProdukcjaPro.ProWyrobOperacjiZlecenia` | bazodanowe, guided-parent | Wyrób | Wyrób operacji zlecenia dla pozycji zamówienia. |
