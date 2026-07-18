# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.AspektPoziomKompetencjiUniwersalnej`
Nazwa tabeli: `ZklAspPozUniw`
Opis: Tabela definiuje poziomy dla aspektów kompetencji uniwersalnych. Umożliwia przypisanie wymagań kompetencji w obszarach miękkich.
Tabela konfiguracyjna: Tak

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aspekt | `Soneta.HR.ZKL.Slowniki.Kompetencje.AspektKompetencjiUniwersalnej` | bazodanowe, tylko-odczyt | Aspekt |  |
| Opis | `string` | bazodanowe |  |  |
| Poziom | `Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiUniwersalnych` | bazodanowe, tylko-odczyt |  |  |
