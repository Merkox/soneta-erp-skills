# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZbiegUbezpieczenia`
Nazwa tabeli: `ZbiegiUbezpiecz`
Tytuł: Zbiegi ubezpieczeń
Opis: Element szczegółowy pracownika (Pracownik). Ewidencja zbiegów tytułów do ubezpieczeń społecznych i zdrowotnych w danym okresie, wynikających z jednoczesnego posiadania kilku tytułów ubezpieczeniowych (np. etat + działalność gospodarcza).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| Spoleczne | `bool` | bazodanowe | Społeczne |  |
| Zdrowotne | `bool` | bazodanowe | Zdrowotne |  |
