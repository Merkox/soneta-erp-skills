# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kompetencje.ProfilKompetencjiMerytorycznych`
Nazwa tabeli: `ZklProfilKKM`
Tytuł: Profile kompetencji merytorycznych
Opis: Tabela umożliwia ewidencjonowanie w profilu kompetencji merytorycznych zarówno kompetencji niezbędnych, jak i pożądanych dla danego stanowiska. Umożliwia także określenie poziomu wymagań dla każdej z nich.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt |  |  |
| Kompetencje | `SubTable<Soneta.HR.ZKL.Profile.Kompetencje.PozycjaProfiluKompetencjiMerytorycznych>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa profilu |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres obowiązywania |  |
| StatusProfilu | `Soneta.HR.ZKL.Enums.StatusProfilu` (enum) | bazodanowe, tylko-odczyt |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista | Uwagi |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusProfilu (`Soneta.HR.ZKL.Enums.StatusProfilu`)
- `None` = 0 — Brak
- `Roboczy` = 10 — Roboczy
- `Zatwierdzony` = 20 — Zatwierdzony
- `WRealizacji` = 30 — W realizacji
