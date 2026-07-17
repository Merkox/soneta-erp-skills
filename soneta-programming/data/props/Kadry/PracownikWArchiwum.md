# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PracownikWArchiwum`
Nazwa tabeli: `PracWArchiwum`
Tytuł: Pracownicy w archiwum
Opis: Element szczegółowy pracownika (Pracownik). Okres przebywania pracownika w archiwum, rejestrujący zakres dat, w których kartoteka pracownika była oznaczona jako archiwalna (nieaktywna).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
