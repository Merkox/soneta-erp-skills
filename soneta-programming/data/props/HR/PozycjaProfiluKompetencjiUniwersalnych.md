# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kompetencje.PozycjaProfiluKompetencjiUniwersalnych`
Nazwa tabeli: `ZklPozProfilKKU`
Tytuł: Pozycje profilu kompetencji uniwersalnych
Opis: Przechowuje powiązania profilu z kompetencjami uniwersalnymi. Jest kluczowa dla określenia wymagań w zakresie kompetencji uniwersalnych dla stanowiska.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kompetencja | `Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaUniwersalna` | bazodanowe | Kompetencja |  |
| Poziom | `Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiUniwersalnych` | bazodanowe | Poziom rozwoju |  |
| Profil | `Soneta.HR.ZKL.Profile.Kompetencje.ProfilKompetencjiUniwersalnych` | bazodanowe, tylko-odczyt |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` (enum) | bazodanowe | Rodzaj wymagania |  |
| Uwagi | `string` | bazodanowe | Uwagi |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
