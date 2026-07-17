# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.AspektKompetencjiMerytorycznej`
Nazwa tabeli: `ZklAspKmpMery`
Tytuł: Aspekty kompetencji merytorycznych
Opis: Tabela opisuje szczegółowe aspekty kompetencji merytorycznych wymaganych na stanowiskach pracy. Umożliwia szczegółowy opis kompetencji specjalistycznej wiedzy i umiejętności w kontekście profili kompetencyjnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kompetencja | `Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaMerytoryczna` | bazodanowe | Kompetencja |  |
| Nazwa | `string` | bazodanowe |  |  |
| Poziomy | `System.Collections.Generic.IEnumerable<Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomAspektuMerytorycznego>` |  |  |  |
