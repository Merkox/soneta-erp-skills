# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Zadaniowy.ProfilZadaniowy`
Nazwa tabeli: `ZklProfilZdn`
Tytuł: Profile zadań
Opis: Tabela zawiera kompletny i szczegółowy zestaw zadań stanowiska. Jest podstawą opisu operacyjnego pracy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe | Nazwa profilu |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres obowiązywania |  |
| StatusProfilu | `Soneta.HR.ZKL.Enums.StatusProfilu` | bazodanowe, enum |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Zadania | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Core.PozycjaProfiluZadaniowego>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusProfilu (`Soneta.HR.ZKL.Enums.StatusProfilu`)
- `None` = 0 — Brak
- `Roboczy` = 10 — Roboczy
- `Zatwierdzony` = 20 — Zatwierdzony
- `WRealizacji` = 30 — W realizacji
