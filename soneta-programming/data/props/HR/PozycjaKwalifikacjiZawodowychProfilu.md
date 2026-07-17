# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaKwalifikacjiZawodowychProfilu`
Nazwa tabeli: `ZklPozKwalKwal`
Tytuł: Pozycje kwalifikacji zawodowych profilu
Opis: Zawiera kwalifikacje zawodowe wymagane w profilu. Służy do określenia wymagań w zakresie kwalifikacji zawodowych stanowiska.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kwalifikacja | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.DodatkowaKwalifikacjaZawodowa` | bazodanowe | Kwalifikacja |  |
| PozycjeTypPotwier | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaKwalifikacjiProfiluTypPotwier>` |  |  |  |
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
