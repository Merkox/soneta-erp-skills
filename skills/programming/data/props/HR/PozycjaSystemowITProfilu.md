# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemowITProfilu`
Nazwa tabeli: `ZklPozKwalIT`
Tytuł: Pozycje systemów IT profilu
Opis: Opisuje wymagane systemy IT na danym stanowisku pracy. Służy do określenia wymagań dotyczących wykorzystania systemów IT na tym stanowisku.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Rodzaj` (`Soneta.HR.ZKL.Enums.RodzajWymagania`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.SystemITJezykProgramowania` | bazodanowe | Nazwa |  |
| Poziom | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomUmiejetnosci` | bazodanowe | Poziom |  |
| PozycjeTypPotwier | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemuITProfiluTypPotwier>` | podlista |  |  |
| Profil | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny` | bazodanowe, tylko-odczyt |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` (enum) | bazodanowe, tylko-odczyt, selektor | Rodzaj wymagania |  |
| TypyPotwierdzenia | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia[]` | podlista | Typy potwierdzenia |  |
| TypyPotwierdzeniaOpis | `string` | tylko-odczyt |  |  |
| WymaganePotwierdzenie | `bool` | bazodanowe | Wymagane potwierdzenie |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Niezbedne` | 10 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemowITProfiluNiezbedne` | Systemy IT |
| `Pozadane` | 20 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemowITProfiluPozadane` | Systemy IT |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
