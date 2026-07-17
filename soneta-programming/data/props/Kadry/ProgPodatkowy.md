# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ProgPodatkowy`
Nazwa tabeli: `ProgiPodatkowe`
Opis: Element szczegółowy historii pracownika (PracHistoria). Indywidualny próg podatkowy pracownika z wartością progową i procentem zaliczki, umożliwiający ręczne ustawienie skali podatkowej odbiegającej od standardowej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Historia` → `PracHistoria`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Historia | `Soneta.Kadry.PracHistoria` | bazodanowe, guided-parent |  |  |
| Prog | `decimal` | bazodanowe |  |  |
| Wartosc | `Soneta.Types.Percent` | bazodanowe |  |  |
| Zerowy | `bool` | bazodanowe |  |  |
