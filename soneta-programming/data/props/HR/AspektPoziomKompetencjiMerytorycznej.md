# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.AspektPoziomKompetencjiMerytorycznej`
Nazwa tabeli: `ZklAspPozMery`
Opis: Przechowuje informacje o poziomach zaawansowania dla aspektów kompetencji merytorycznych. Umożliwia przypisanie wymagań jakościowych i ilościowych.
Tabela konfiguracyjna: Tak

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aspekt | `Soneta.HR.ZKL.Slowniki.Kompetencje.AspektKompetencjiMerytorycznej` | bazodanowe, tylko-odczyt | Aspekt |  |
| Opis | `string` | bazodanowe |  |  |
| Poziom | `Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiMerytorycznych` | bazodanowe, tylko-odczyt |  |  |
