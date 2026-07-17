# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.SzkoleniaIUprawnienia.PozycjaSzkolenIUprawnienProfilu`
Nazwa tabeli: `ZklPozSzkUpr`
Tytuł: Pozycje szkoleń i uprawnień profilu
Opis: Zawiera szkolenia i uprawnienia wykorzystane na  profilu szkoleń. Wspiera zarządzanie rozwojem szkoleń i uprawnień.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CelOpis | `Soneta.Business.MemoText` | bazodanowe | Cel/Opis |  |
| Definicja | `Soneta.Business.Row` |  |  |  |
| Grupa | `string` |  |  |  |
| Kategoria | `string` |  |  |  |
| Nazwa | `string` |  |  |  |
| PozycjaKsuGuid | `System.Guid` | bazodanowe | Identyfikator pozycji KSU |  |
| PozycjaKsuTyp | `Soneta.HR.ZKL.Enums.KsuPozycjaTyp` | bazodanowe, enum | Typ pozycji KSU |  |
| Profil | `Soneta.HR.ZKL.Profile.SzkoleniaIUprawnienia.ProfilSzkolenIUprawnien` | bazodanowe |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` | bazodanowe, enum | Rodzaj wymagania |  |
| Symbol | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KsuPozycjaTyp (`Soneta.HR.ZKL.Enums.KsuPozycjaTyp`)
- `None` = 0 — Brak
- `Szkolenie` = 10 — Szkolenie
- `Uprawnienie` = 20 — Uprawnienie
- `SzkolenieBhp` = 30 — Szkolenie BHP

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
