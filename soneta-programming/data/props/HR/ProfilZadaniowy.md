# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Zadaniowy.ProfilZadaniowy`
Nazwa tabeli: `ZklProfilZdn`
Tytuł: Profile zadań
Opis: Tabela zawiera kompletny i szczegółowy zestaw zadań stanowiska. Jest podstawą opisu operacyjnego pracy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 3
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa profilu |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres obowiązywania |  |
| StatusProfilu | `Soneta.HR.ZKL.Enums.StatusProfilu` (enum) | bazodanowe, tylko-odczyt |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| Zadania | `SubTable<Soneta.HR.ZKL.Profile.Core.PozycjaProfiluZadaniowego>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusProfilu (`Soneta.HR.ZKL.Enums.StatusProfilu`)
- `None` = 0 — Brak
- `Roboczy` = 10 — Roboczy
- `Zatwierdzony` = 20 — Zatwierdzony
- `WRealizacji` = 30 — W realizacji
