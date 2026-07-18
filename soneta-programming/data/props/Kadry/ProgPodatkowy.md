# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ProgPodatkowy`
Nazwa tabeli: `ProgiPodatkowe`
Opis: Element szczegółowy historii pracownika (PracHistoria). Indywidualny próg podatkowy pracownika z wartością progową i procentem zaliczki, umożliwiający ręczne ustawienie skali podatkowej odbiegającej od standardowej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Historia` → `PracHistoria`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Historia | `Soneta.Kadry.PracHistoria` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Prog | `decimal` | bazodanowe |  |  |
| Wartosc | `Percent` | bazodanowe |  |  |
| Zerowy | `bool` | bazodanowe, tylko-odczyt |  |  |
