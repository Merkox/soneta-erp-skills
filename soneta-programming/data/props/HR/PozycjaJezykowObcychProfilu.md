# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfilu`
Nazwa tabeli: `ZklPozKwalJezyki`
Tytuł: Pozycje języków obcych profilu
Opis: Tabela przechowuje wymagania językowe profilu. Służy do określenia wymagań lingwistycznych stanowiska.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Jezyk | `Soneta.Kadry.DefinicjaJęzykaObcego` | bazodanowe | Język |  |
| PoziomWMowie | `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego` | bazodanowe | Poziom w mowie |  |
| PoziomWPismie | `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego` | bazodanowe | Poziom w piśmie |  |
| PozycjeTypPotwier | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykaProfiluTypPotwier>` |  |  |  |
| Profil | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny` | bazodanowe |  |  |
| Rodzaj | `Soneta.HR.ZKL.Enums.RodzajWymagania` | bazodanowe, enum | Rodzaj wymagania |  |
| TypyPotwierdzenia | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia[]` |  | Typy potwierdzenia |  |
| TypyPotwierdzeniaOpis | `string` |  |  |  |
| Uwagi | `string` | bazodanowe |  |  |
| WymaganePotwierdzenie | `bool` | bazodanowe | Wymagane potwierdzenie |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWymagania (`Soneta.HR.ZKL.Enums.RodzajWymagania`)
- `None` = 0 — Brak
- `Niezbedne` = 10 — Wymagania niezbędne
- `Pozadane` = 20 — Wymagania pożądane
