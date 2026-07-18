# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.SzkoleniaIUprawnienia.PozycjaSzkolenIUprawnienProfilu`
Nazwa tabeli: `ZklPozSzkUpr`
Tytuł: Pozycje szkoleń i uprawnień profilu
Opis: Zawiera szkolenia i uprawnienia wykorzystane na  profilu szkoleń. Wspiera zarządzanie rozwojem szkoleń i uprawnień.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 1
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CelOpis | `MemoText` | bazodanowe, podlista | Cel/Opis |  |
| Definicja | `Row` | tylko-odczyt |  |  |
| Grupa | `string` | tylko-odczyt |  |  |
| Kategoria | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| PozycjaKsuGuid | `System.Guid` | bazodanowe | Identyfikator pozycji KSU |  |
| PozycjaKsuTyp | `Soneta.HR.ZKL.Enums.KsuPozycjaTyp` (enum) | bazodanowe | Typ pozycji KSU |  |
| Profil | `Soneta.HR.ZKL.Profile.SzkoleniaIUprawnienia.ProfilSzkolenIUprawnien` | bazodanowe, tylko-odczyt |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` (enum) | bazodanowe | Rodzaj wymagania |  |
| Symbol | `string` | tylko-odczyt |  |  |

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
