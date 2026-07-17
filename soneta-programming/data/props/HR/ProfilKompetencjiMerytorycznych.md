# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kompetencje.ProfilKompetencjiMerytorycznych`
Nazwa tabeli: `ZklProfilKKM`
Tytuł: Profile kompetencji merytorycznych
Opis: Tabela umożliwia ewidencjonowanie w profilu kompetencji merytorycznych zarówno kompetencji niezbędnych, jak i pożądanych dla danego stanowiska. Umożliwia także określenie poziomu wymagań dla każdej z nich.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| Kompetencje | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kompetencje.PozycjaProfiluKompetencjiMerytorycznych>` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa profilu |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres obowiązywania |  |
| StatusProfilu | `Soneta.HR.ZKL.Enums.StatusProfilu` | bazodanowe, enum |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusProfilu (`Soneta.HR.ZKL.Enums.StatusProfilu`)
- `None` = 0 — Brak
- `Roboczy` = 10 — Roboczy
- `Zatwierdzony` = 20 — Zatwierdzony
- `WRealizacji` = 30 — W realizacji
