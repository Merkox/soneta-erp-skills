# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaMerytoryczna`
Nazwa tabeli: `ZklKmpMery`
Tytuł: Kompetencje merytoryczne
Opis: Tabela opisuje pojedyncze kompetencje merytoryczne. Stanowi podstawowy słownik wiedzy specjalistycznej wykorzystywanej w profilach stanowisk.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aspekty | `Soneta.Business.SubTable<Soneta.HR.ZKL.Slowniki.Kompetencje.AspektKompetencjiMerytorycznej>` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `string` | bazodanowe |  |  |
| Grupa | `Soneta.HR.ZKL.Slowniki.Kompetencje.GrupaKompetencjiMerytorycznych` | bazodanowe | Grupa kompetencji merytorycznych |  |
| Nazwa | `string` | bazodanowe |  |  |
| Poziomy | `System.Collections.Generic.IEnumerable<Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiMerytorycznych>` |  |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
