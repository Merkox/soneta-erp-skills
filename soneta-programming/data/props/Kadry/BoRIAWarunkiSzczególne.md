# Pola i właściwości klasy biznesowej: `Soneta.Kadry.BoRIAWarunkiSzczególne`
Nazwa tabeli: `BosRIAWarSzczeg`
Tytuł: Okresy pracy w szczególnych warunkach lub w szczególnym charakterze
Opis: Bilans otwarcia rocznej informacji o zatrudnieniu (RIA) w zakresie pracy w szczególnych warunkach lub o szczególnym charakterze. Rejestruje okresy i kody stanowisk wg ustawy z 1998 r. i 2008 r., wymagane przy sporządzaniu ZUS RIA.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Ustawa1998 | `Soneta.Kadry.BoRIAWarunkiSzczególne1998` (subrow) | bazodanowe |  |  |
| Ustawa1998.KodCharakter | `string` | bazodanowe |  |  |
| Ustawa1998.KodWarunki | `string` | bazodanowe |  |  |
| Ustawa1998.KodWarunki2 | `string` | bazodanowe |  |  |
| Ustawa1998.KolejDeputat | `bool` | bazodanowe |  |  |
| Ustawa1998.KolejInneStanowisko | `bool` | bazodanowe |  |  |
| Ustawa1998.Nazwa | `string` | bazodanowe |  |  |
| Ustawa1998.Nazwa2 | `string` | bazodanowe |  |  |
| Ustawa1998.PelnyWymiar | `bool` | bazodanowe |  |  |
| Ustawa1998.Wymiar | `Fraction` | bazodanowe |  |  |
| Ustawa1998.ZmienionaNazwa | `string` | bazodanowe |  |  |
| Ustawa1998.ZmienionaNazwa2 | `string` | bazodanowe |  |  |
| Ustawa2008 | `Soneta.Kadry.BoRIAWarunkiSzczególne2008` (subrow) | bazodanowe |  |  |
| Ustawa2008.Kod | `Soneta.Kadry.KodPracyWSzególnychWarunkachCharakterze` | bazodanowe |  |  |
| Ustawa2008.WgKod | `Key` | podlista |  |  |
| Ustawa2008.Wymiar | `Fraction` | bazodanowe |  |  |
| Wersja | `Soneta.Kadry.WersjaBoRIAWarunkiSzczególne` (enum) | bazodanowe |  |  |
| WersjaTxt | `string` | tylko-odczyt |  |  |
| Zatwierdzony | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WersjaBoRIAWarunkiSzczególne (`Soneta.Kadry.WersjaBoRIAWarunkiSzczególne`)
- `Ustawa1998` = 1 — art. 32 ustawy z dnia 17 grudnia 1998 r. o emeryturach i rentach z funduszu ubezpieczeń społecznych (Dz. U. z 2018 r. poz. 1270, z późn. zm.) - od 1.01.1999 r. do 31.12.2008 r.
- `Ustawa2008` = 2 — art. 3 ust. 1 i 3 ustawy z dnia 19 grudnia 2008 r. o emeryturach pomostowych (Dz. U. z 2018 r. poz. 1924) – od 1.01.1999 r. do 31.12.2008 r.
