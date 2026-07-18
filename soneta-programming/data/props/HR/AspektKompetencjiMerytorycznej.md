# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.AspektKompetencjiMerytorycznej`
Nazwa tabeli: `ZklAspKmpMery`
Tytuł: Aspekty kompetencji merytorycznych
Opis: Tabela opisuje szczegółowe aspekty kompetencji merytorycznych wymaganych na stanowiskach pracy. Umożliwia szczegółowy opis kompetencji specjalistycznej wiedzy i umiejętności w kontekście profili kompetencyjnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kompetencja | `Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaMerytoryczna` | bazodanowe, tylko-odczyt | Kompetencja |  |
| Nazwa | `string` | bazodanowe |  |  |
| Poziomy | `System.Collections.Generic.IEnumerable<Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomAspektuMerytorycznego>` | podlista |  |  |
