# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluGrupa`
Nazwa tabeli: `ZklPozKwalDosGr`
Tytuł: Pozycje doświadczenia w grupie stanowisk profilu
Opis: Zawiera pozycje doświadczenia pogrupowane w profilu. Wspiera analizę wymagań dotyczących stażu pracy.
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
| GrupaStanowisk | `Soneta.HR.GrupaStanowisk` | bazodanowe | Grupa stanowisk |  |
| Profil | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny` | bazodanowe, tylko-odczyt |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` (enum) | bazodanowe | Rodzaj wymagania |  |
| StazPracy | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.OkresDoswiadczeniaZawodowego` | bazodanowe | Staż pracy |  |
| Uwagi | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
