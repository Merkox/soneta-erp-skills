# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaUniwersalna`
Nazwa tabeli: `ZklKmpUniw`
Tytuł: Kompetencje uniwersalne
Opis: Przechowuje definicje kompetencji uniwersalnych. Jest wykorzystywana do jednolitej prezentacji kompetencji miękkich w całej organizacji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aspekty | `SubTable<Soneta.HR.ZKL.Slowniki.Kompetencje.AspektKompetencjiUniwersalnej>` | podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `string` | bazodanowe |  |  |
| Grupa | `Soneta.HR.ZKL.Slowniki.Kompetencje.GrupaKompetencjiUniwersalnych` | bazodanowe, tylko-odczyt | Grupa kompetencji uniwersalnych |  |
| Nazwa | `string` | bazodanowe |  |  |
| Poziomy | `System.Collections.Generic.IEnumerable<Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiUniwersalnych>` | podlista |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
