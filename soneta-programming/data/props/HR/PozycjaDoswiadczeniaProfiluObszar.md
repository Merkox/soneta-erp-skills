# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluObszar`
Nazwa tabeli: `ZklPozKwalDosOb`
Tytuł: Pozycje doświadczenia w obszarze funkcjonalnym profilu
Opis: Opisuje doświadczenie w podziale na obszary działalności. Wspiera analizę wymagań dotyczących stażu pracy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ObszarFunkcjonalny | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObszarFunkcjonalny` | bazodanowe | Obszar funkcjonalny |  |
| Profil | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny` | bazodanowe |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` | bazodanowe, enum | Rodzaj wymagania |  |
| StazWMiesiacach | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.OkresDoswiadczeniaZawodowego` | bazodanowe | Staż w miesiącach |  |
| Uwagi | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
