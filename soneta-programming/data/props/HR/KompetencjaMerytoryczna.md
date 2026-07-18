# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaMerytoryczna`
Nazwa tabeli: `ZklKmpMery`
Tytuł: Kompetencje merytoryczne
Opis: Tabela opisuje pojedyncze kompetencje merytoryczne. Stanowi podstawowy słownik wiedzy specjalistycznej wykorzystywanej w profilach stanowisk.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aspekty | `SubTable<Soneta.HR.ZKL.Slowniki.Kompetencje.AspektKompetencjiMerytorycznej>` | podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `string` | bazodanowe |  |  |
| Grupa | `Soneta.HR.ZKL.Slowniki.Kompetencje.GrupaKompetencjiMerytorycznych` | bazodanowe, tylko-odczyt | Grupa kompetencji merytorycznych |  |
| Nazwa | `string` | bazodanowe |  |  |
| Poziomy | `System.Collections.Generic.IEnumerable<Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiMerytorycznych>` | podlista |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
