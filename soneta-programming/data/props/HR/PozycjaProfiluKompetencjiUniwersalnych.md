# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kompetencje.PozycjaProfiluKompetencjiUniwersalnych`
Nazwa tabeli: `ZklPozProfilKKU`
Tytuł: Pozycje profilu kompetencji uniwersalnych
Opis: Przechowuje powiązania profilu z kompetencjami uniwersalnymi. Jest kluczowa dla określenia wymagań w zakresie kompetencji uniwersalnych dla stanowiska.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kompetencja | `Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaUniwersalna` | bazodanowe | Kompetencja |  |
| Poziom | `Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiUniwersalnych` | bazodanowe | Poziom rozwoju |  |
| Profil | `Soneta.HR.ZKL.Profile.Kompetencje.ProfilKompetencjiUniwersalnych` | bazodanowe |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` | bazodanowe, enum | Rodzaj wymagania |  |
| Uwagi | `string` | bazodanowe | Uwagi |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
