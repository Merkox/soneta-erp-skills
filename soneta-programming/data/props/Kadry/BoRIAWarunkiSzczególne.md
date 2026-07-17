# Pola i właściwości klasy biznesowej: `Soneta.Kadry.BoRIAWarunkiSzczególne`
Nazwa tabeli: `BosRIAWarSzczeg`
Tytuł: Okresy pracy w szczególnych warunkach lub w szczególnym charakterze
Opis: Bilans otwarcia rocznej informacji o zatrudnieniu (RIA) w zakresie pracy w szczególnych warunkach lub o szczególnym charakterze. Rejestruje okresy i kody stanowisk wg ustawy z 1998 r. i 2008 r., wymagane przy sporządzaniu ZUS RIA.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 19
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Ustawa1998 | `Soneta.Kadry.BoRIAWarunkiSzczególne1998` | bazodanowe |  |  |
| Ustawa1998.KodCharakter | `string` | bazodanowe |  |  |
| Ustawa1998.KodWarunki | `string` | bazodanowe |  |  |
| Ustawa1998.KodWarunki2 | `string` | bazodanowe |  |  |
| Ustawa1998.KolejDeputat | `bool` | bazodanowe |  |  |
| Ustawa1998.KolejInneStanowisko | `bool` | bazodanowe |  |  |
| Ustawa1998.Nazwa | `string` | bazodanowe |  |  |
| Ustawa1998.Nazwa2 | `string` | bazodanowe |  |  |
| Ustawa1998.PelnyWymiar | `bool` | bazodanowe |  |  |
| Ustawa1998.Wymiar | `Soneta.Types.Fraction` | bazodanowe |  |  |
| Ustawa1998.ZmienionaNazwa | `string` | bazodanowe |  |  |
| Ustawa1998.ZmienionaNazwa2 | `string` | bazodanowe |  |  |
| Ustawa2008 | `Soneta.Kadry.BoRIAWarunkiSzczególne2008` | bazodanowe |  |  |
| Ustawa2008.Kod | `Soneta.Kadry.KodPracyWSzególnychWarunkachCharakterze` | bazodanowe |  |  |
| Ustawa2008.WgKod | `Soneta.Business.Key` |  |  |  |
| Ustawa2008.Wymiar | `Soneta.Types.Fraction` | bazodanowe |  |  |
| Wersja | `Soneta.Kadry.WersjaBoRIAWarunkiSzczególne` | bazodanowe, enum |  |  |
| WersjaTxt | `string` |  |  |  |
| Zatwierdzony | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WersjaBoRIAWarunkiSzczególne (`Soneta.Kadry.WersjaBoRIAWarunkiSzczególne`)
- `Ustawa1998` = 1 — art. 32 ustawy z dnia 17 grudnia 1998 r. o emeryturach i rentach z funduszu ubezpieczeń społecznych (Dz. U. z 2018 r. poz. 1270, z późn. zm.) - od 1.01.1999 r. do 31.12.2008 r.
- `Ustawa2008` = 2 — art. 3 ust. 1 i 3 ustawy z dnia 19 grudnia 2008 r. o emeryturach pomostowych (Dz. U. z 2018 r. poz. 1924) – od 1.01.1999 r. do 31.12.2008 r.
