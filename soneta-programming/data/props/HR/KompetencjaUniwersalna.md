# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaUniwersalna`
Nazwa tabeli: `ZklKmpUniw`
Tytuł: Kompetencje uniwersalne
Opis: Przechowuje definicje kompetencji uniwersalnych. Jest wykorzystywana do jednolitej prezentacji kompetencji miękkich w całej organizacji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aspekty | `Soneta.Business.SubTable<Soneta.HR.ZKL.Slowniki.Kompetencje.AspektKompetencjiUniwersalnej>` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `string` | bazodanowe |  |  |
| Grupa | `Soneta.HR.ZKL.Slowniki.Kompetencje.GrupaKompetencjiUniwersalnych` | bazodanowe | Grupa kompetencji uniwersalnych |  |
| Nazwa | `string` | bazodanowe |  |  |
| Poziomy | `System.Collections.Generic.IEnumerable<Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiUniwersalnych>` |  |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
