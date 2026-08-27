# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.RejestrUDZ`
Nazwa tabeli: `RejestryUDZ`
Tytuł: Rejestr ustawicznego doskonalenia zawodowego
Opis: Rejestr ustawicznego doskonalenia zawodowego (UDZ) członków organizacji. Dokumentuje punkty i aktywności edukacyjne wymagane do utrzymania uprawnień zawodowych, zgodnie z obowiązującymi regulacjami branżowymi.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe | Data | Data. |
| DataDo | `Date` | bazodanowe | Data końcowa | Data końcowa. |
| DataOd | `Date` | bazodanowe | Data początkowa | Data początkowa. |
| LGodzin | `int` | bazodanowe | Liczba godzin | Liczba godzin. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa. |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Opis. |
| Organizator | `string` | bazodanowe | Organizator | Organizator. |
| Rodzaj | `Soneta.CzlonkowieSzkolenia.RodzajDoskonalenia` (enum) | bazodanowe | Rodzaj doskonalenia | Rodzaj doskonalenia |
| Rok | `int` | bazodanowe | Rok | Rok. |
| Typ | `Soneta.CzlonkowieSzkolenia.TypCertyfikatu` (enum) | bazodanowe | Typ certyfikatu | Typ certyfikatu. |
| Uczestnik | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajDoskonalenia (`Soneta.CzlonkowieSzkolenia.RodzajDoskonalenia`)
- `Szkolenie` = 0
- `Doskonalenie` = 1

### TypCertyfikatu (`Soneta.CzlonkowieSzkolenia.TypCertyfikatu`)
- `DyplKsiegowy` = 1 — Dyplomowany Księgowy
- `CertEUK` = 2 — Certyfikat EUK
- `CertSUPKRiP` = 3 — Certyfikat SUPKRiP
