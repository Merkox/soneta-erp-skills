# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.SzkoleniaIUprawnienia.ProfilSzkolenIUprawnien`
Nazwa tabeli: `ZklProfilSzkUpr`
Tytuł: Profile szkoleń i uprawnień
Opis: Tabela grupuje szkolenia i uprawnienia w jednym profilu. Pomaga planować rozwój i szkoleń i uprawnień.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa profilu |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres obowiązywania |  |
| StatusProfilu | `Soneta.HR.ZKL.Enums.StatusProfilu` (enum) | bazodanowe, tylko-odczyt |  |  |
| SzkoleniaIUprawnienia | `SubTable<Soneta.HR.ZKL.Profile.SzkoleniaIUprawnienia.PozycjaSzkolenIUprawnienProfilu>` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusProfilu (`Soneta.HR.ZKL.Enums.StatusProfilu`)
- `None` = 0 — Brak
- `Roboczy` = 10 — Roboczy
- `Zatwierdzony` = 20 — Zatwierdzony
- `WRealizacji` = 30 — W realizacji
