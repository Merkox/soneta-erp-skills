# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Wypadek`
Nazwa tabeli: `Wypadki`
Tytuł: Karty wypadków
Opis: Karta rejestracji wypadku przy pracy. Zawiera dane o dacie, miejscu, rodzaju wypadku, okolicznościach, skutkach zdrowotnych, protokole powypadkowym, numerze sprawy ZUS, uszczerbku na zdrowiu oraz decyzji o odszkodowaniu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 22
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 3
- podlisty: 5
- subrowy: 1
- razem: 32

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ciezki | `bool` | bazodanowe | Ciężki |  |
| Data | `Date` | bazodanowe | Data wypadku |  |
| DataZgloszenia | `Date` | bazodanowe |  |  |
| DecyzjaData | `Date` | bazodanowe |  |  |
| DecyzjaNumer | `string` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Godzina | `Time` | bazodanowe |  |  |
| Kwota | `decimal` | bazodanowe |  |  |
| Miejsce | `string` | bazodanowe |  |  |
| Niezdolnosc | `bool` | bazodanowe | Niezdolność do pracy |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Odmowa | `MemoText` | bazodanowe, podlista |  |  |
| Okolicznosci | `MemoText` | bazodanowe, podlista | Okoliczności |  |
| PismoData | `Date` | bazodanowe |  |  |
| PismoNumer | `string` | bazodanowe |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| ProtokolData | `Date` | bazodanowe | Data |  |
| ProtokolNumer | `string` | bazodanowe | Dodatkjowy numer protokołu |  |
| PrzyPracy | `bool` | bazodanowe | Przy pracy |  |
| Rodzaj | `Soneta.Kadry.RodzajWypadku` (enum) | bazodanowe |  |  |
| SKW | `string` | bazodanowe |  |  |
| Skutki | `MemoText` | bazodanowe, podlista |  |  |
| Smiertelny | `bool` | bazodanowe | Śmiertelny |  |
| Stan | `Soneta.Kadry.StanyKartyRejestracjiWypadku` (enum) | bazodanowe |  |  |
| Uszczerbek | `Percent` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWypadku (`Soneta.Kadry.RodzajWypadku`)
- `Indywidualny` = 0 — Indywidualny
- `Zbiorowy` = 1

### StanyKartyRejestracjiWypadku (`Soneta.Kadry.StanyKartyRejestracjiWypadku`)
- `Wprowadzana` = 1
- `Zatwierdzona` = 10
- `Anulowana` = 11
