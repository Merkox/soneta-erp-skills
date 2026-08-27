# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.AspektKompetencjiUniwersalnej`
Nazwa tabeli: `ZklAspKmpUniw`
Tytuł: Aspekty kompetencji uniwersalnych
Opis: Tabela zawiera aspekty kompetencji uniwersalnych, takich jak komunikacja czy współpraca. Służy do opisu miękkich zdolności w sposób strukturalny i porównywalny pomiędzy stanowiskami.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kompetencja | `Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaUniwersalna` | bazodanowe, tylko-odczyt | Kompetencja |  |
| Nazwa | `string` | bazodanowe |  |  |
| Poziomy | `System.Collections.Generic.IEnumerable<Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomAspektuUniwersalnego>` | podlista |  |  |
