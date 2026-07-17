# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Wypadek`
Nazwa tabeli: `Wypadki`
Tytuł: Karty wypadków
Opis: Karta rejestracji wypadku przy pracy. Zawiera dane o dacie, miejscu, rodzaju wypadku, okolicznościach, skutkach zdrowotnych, protokole powypadkowym, numerze sprawy ZUS, uszczerbku na zdrowiu oraz decyzji o odszkodowaniu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 28
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ciezki | `bool` | bazodanowe | Ciężki |  |
| Data | `Soneta.Types.Date` | bazodanowe | Data wypadku |  |
| DataZgloszenia | `Soneta.Types.Date` | bazodanowe |  |  |
| DecyzjaData | `Soneta.Types.Date` | bazodanowe |  |  |
| DecyzjaNumer | `string` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Godzina | `Soneta.Types.Time` | bazodanowe |  |  |
| Kwota | `decimal` | bazodanowe |  |  |
| Miejsce | `string` | bazodanowe |  |  |
| Niezdolnosc | `bool` | bazodanowe | Niezdolność do pracy |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Odmowa | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Okolicznosci | `Soneta.Business.MemoText` | bazodanowe | Okoliczności |  |
| PismoData | `Soneta.Types.Date` | bazodanowe |  |  |
| PismoNumer | `string` | bazodanowe |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| ProtokolData | `Soneta.Types.Date` | bazodanowe | Data |  |
| ProtokolNumer | `string` | bazodanowe | Dodatkjowy numer protokołu |  |
| PrzyPracy | `bool` | bazodanowe | Przy pracy |  |
| Rodzaj | `Soneta.Kadry.RodzajWypadku` | bazodanowe, enum |  |  |
| SKW | `string` | bazodanowe |  |  |
| Skutki | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Smiertelny | `bool` | bazodanowe | Śmiertelny |  |
| Stan | `Soneta.Kadry.StanyKartyRejestracjiWypadku` | bazodanowe, enum |  |  |
| Uszczerbek | `Soneta.Types.Percent` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWypadku (`Soneta.Kadry.RodzajWypadku`)
- `Indywidualny` = 0 — Indywidualny
- `Zbiorowy` = 1

### StanyKartyRejestracjiWypadku (`Soneta.Kadry.StanyKartyRejestracjiWypadku`)
- `Wprowadzana` = 1
- `Zatwierdzona` = 10
- `Anulowana` = 11
