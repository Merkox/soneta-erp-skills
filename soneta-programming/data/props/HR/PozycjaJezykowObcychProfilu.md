# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfilu`
Nazwa tabeli: `ZklPozKwalJezyki`
Tytuł: Pozycje języków obcych profilu
Opis: Tabela przechowuje wymagania językowe profilu. Służy do określenia wymagań lingwistycznych stanowiska.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Jezyk | `Soneta.Kadry.DefinicjaJęzykaObcego` | bazodanowe | Język |  |
| PoziomWMowie | `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego` | bazodanowe | Poziom w mowie |  |
| PoziomWPismie | `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego` | bazodanowe | Poziom w piśmie |  |
| PozycjeTypPotwier | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykaProfiluTypPotwier>` | podlista |  |  |
| Profil | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny` | bazodanowe, tylko-odczyt |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` (enum) | bazodanowe, tylko-odczyt | Rodzaj wymagania |  |
| TypyPotwierdzenia | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia[]` | podlista | Typy potwierdzenia |  |
| TypyPotwierdzeniaOpis | `string` | tylko-odczyt |  |  |
| Uwagi | `string` | bazodanowe |  |  |
| WymaganePotwierdzenie | `bool` | bazodanowe | Wymagane potwierdzenie |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
