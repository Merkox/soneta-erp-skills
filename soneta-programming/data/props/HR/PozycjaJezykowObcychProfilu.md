# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfilu`
Nazwa tabeli: `ZklPozKwalJezyki`
Tytuł: Pozycje języków obcych profilu
Opis: Tabela przechowuje wymagania językowe profilu. Służy do określenia wymagań lingwistycznych stanowiska.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Rodzaj` (`Soneta.HR.ZKL.Enums.RodzajWymagania`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Jezyk | `Soneta.Kadry.DefinicjaJęzykaObcego` | bazodanowe | Język |  |
| PoziomWMowie | `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego` | bazodanowe | Poziom w mowie |  |
| PoziomWPismie | `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego` | bazodanowe | Poziom w piśmie |  |
| PozycjeTypPotwier | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykaProfiluTypPotwier>` | podlista |  |  |
| Profil | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny` | bazodanowe, tylko-odczyt |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` (enum) | bazodanowe, tylko-odczyt, selektor | Rodzaj wymagania |  |
| TypyPotwierdzenia | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia[]` | podlista | Typy potwierdzenia |  |
| TypyPotwierdzeniaOpis | `string` | tylko-odczyt |  |  |
| Uwagi | `string` | bazodanowe |  |  |
| WymaganePotwierdzenie | `bool` | bazodanowe | Wymagane potwierdzenie |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Niezbedne` | 10 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfiluNiezbedne` | Język |
| `Pozadane` | 20 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfiluPozadane` | Język |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
