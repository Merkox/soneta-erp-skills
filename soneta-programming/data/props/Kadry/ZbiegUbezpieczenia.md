# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZbiegUbezpieczenia`
Nazwa tabeli: `ZbiegiUbezpiecz`
Tytuł: Zbiegi ubezpieczeń
Opis: Element szczegółowy pracownika (Pracownik). Ewidencja zbiegów tytułów do ubezpieczeń społecznych i zdrowotnych w danym okresie, wynikających z jednoczesnego posiadania kilku tytułów ubezpieczeniowych (np. etat + działalność gospodarcza).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Spoleczne | `bool` | bazodanowe | Społeczne |  |
| Zdrowotne | `bool` | bazodanowe | Zdrowotne |  |
