# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaMaszynIUrzadzenProfilu`
Nazwa tabeli: `ZklPozKwalMaszyn`
Tytuł: Pozycje maszyn i urządzeń profilu
Opis: Opisuje wymagane maszyny i urządzenia. Służy do określenia wymagań w zakresie stanowiska pracy w zakresie obsługi maszyn i urządzeń.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Rodzaj` (`Soneta.HR.ZKL.Enums.RodzajWymagania`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObslugaMaszynIUrzadzen` | bazodanowe | Nazwa |  |
| Poziom | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomUmiejetnosci` | bazodanowe | Poziom |  |
| PozycjeTypPotwier | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaMaszynyProfiluTypPotwier>` | podlista |  |  |
| Profil | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny` | bazodanowe, tylko-odczyt |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` (enum) | bazodanowe, tylko-odczyt, selektor | Rodzaj wymagania |  |
| TypyPotwierdzenia | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia[]` | podlista | Typy potwierdzenia |  |
| TypyPotwierdzeniaOpis | `string` | tylko-odczyt |  |  |
| WymaganePotwierdzenie | `bool` | bazodanowe | Wymagane potwierdzenie |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Niezbedne` | 10 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaMaszynIUrzadzenProfiluNiezbedne` | Maszyny i urządzenia |
| `Pozadane` | 20 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaMaszynIUrzadzenProfiluPozadane` | Maszyny i urządzenia |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
