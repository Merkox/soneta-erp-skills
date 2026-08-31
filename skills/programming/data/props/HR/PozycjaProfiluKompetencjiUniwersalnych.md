# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kompetencje.PozycjaProfiluKompetencjiUniwersalnych`
Nazwa tabeli: `ZklPozProfilKKU`
Tytuł: Pozycje profilu kompetencji uniwersalnych
Opis: Przechowuje powiązania profilu z kompetencjami uniwersalnymi. Jest kluczowa dla określenia wymagań w zakresie kompetencji uniwersalnych dla stanowiska.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Rodzaj` (`Soneta.HR.ZKL.Enums.RodzajWymagania`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kompetencja | `Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaUniwersalna` | bazodanowe | Kompetencja |  |
| Poziom | `Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiUniwersalnych` | bazodanowe | Poziom rozwoju |  |
| Profil | `Soneta.HR.ZKL.Profile.Kompetencje.ProfilKompetencjiUniwersalnych` | bazodanowe, tylko-odczyt |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` (enum) | bazodanowe, selektor | Rodzaj wymagania |  |
| Uwagi | `string` | bazodanowe | Uwagi |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Niezbedne` | 10 | `Soneta.HR.ZKL.Profile.Kompetencje.PozycjaProfiluKKUNiezbedne` | Kompetencje uniwersalne - niezbędne |
| `Pozadane` | 20 | `Soneta.HR.ZKL.Profile.Kompetencje.PozycjaProfiluKKUPozadane` | Kompetencje uniwersalne - pożądane |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
