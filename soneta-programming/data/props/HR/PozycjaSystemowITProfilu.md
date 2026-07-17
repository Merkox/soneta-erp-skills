# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemowITProfilu`
Nazwa tabeli: `ZklPozKwalIT`
Tytuł: Pozycje systemów IT profilu
Opis: Opisuje wymagane systemy IT na danym stanowisku pracy. Służy do określenia wymagań dotyczących wykorzystania systemów IT na tym stanowisku.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.SystemITJezykProgramowania` | bazodanowe | Nazwa |  |
| Poziom | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomUmiejetnosci` | bazodanowe | Poziom |  |
| PozycjeTypPotwier | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemuITProfiluTypPotwier>` |  |  |  |
| Profil | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny` | bazodanowe |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` | bazodanowe, enum | Rodzaj wymagania |  |
| TypyPotwierdzenia | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia[]` |  | Typy potwierdzenia |  |
| TypyPotwierdzeniaOpis | `string` |  |  |  |
| WymaganePotwierdzenie | `bool` | bazodanowe | Wymagane potwierdzenie |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
