# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.SzkoleniaIUprawnienia.ProfilSzkolenIUprawnien`
Nazwa tabeli: `ZklProfilSzkUpr`
Tytuł: Profile szkoleń i uprawnień
Opis: Tabela grupuje szkolenia i uprawnienia w jednym profilu. Pomaga planować rozwój i szkoleń i uprawnień.
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
| SzkoleniaIUprawnienia | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.SzkoleniaIUprawnienia.PozycjaSzkolenIUprawnienProfilu>` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusProfilu (`Soneta.HR.ZKL.Enums.StatusProfilu`)
- `None` = 0 — Brak
- `Roboczy` = 10 — Roboczy
- `Zatwierdzony` = 20 — Zatwierdzony
- `WRealizacji` = 30 — W realizacji
