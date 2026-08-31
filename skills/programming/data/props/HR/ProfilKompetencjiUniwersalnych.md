# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kompetencje.ProfilKompetencjiUniwersalnych`
Nazwa tabeli: `ZklProfilKKU`
Tytuł: Profile kompetencji uniwersalnych
Opis: Tabela umożliwia ewidencjonowanie w profilu kompetencji uniwersalnych zarówno kompetencji niezbędnych, jak i pożądanych dla danego stanowiska. Umożliwia także określenie poziomu wymagań dla każdej z nich.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt |  |  |
| Kompetencje | `SubTable<Soneta.HR.ZKL.Profile.Kompetencje.PozycjaProfiluKompetencjiUniwersalnych>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa profilu |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres obowiązywania |  |
| StatusProfilu | `Soneta.HR.ZKL.Enums.StatusProfilu` (enum) | bazodanowe, tylko-odczyt |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusProfilu (`Soneta.HR.ZKL.Enums.StatusProfilu`)
- `None` = 0 — Brak
- `Roboczy` = 10 — Roboczy
- `Zatwierdzony` = 20 — Zatwierdzony
- `WRealizacji` = 30 — W realizacji
