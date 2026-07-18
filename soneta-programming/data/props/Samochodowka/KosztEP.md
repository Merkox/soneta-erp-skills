# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.KosztEP`
Nazwa tabeli: `KosztyEP`
Tytuł: KosztyEP
Opis: Rejestr kosztów eksploatacyjnych pojazdów (paliwo, serwis, ubezpieczenie itp.). Powiązany z dokumentem ewidencji i pojazdem, umożliwia rejestrację wartości, ilości i rodzaju paliwa. Służy do rozliczania kosztów utrzymania floty oraz naliczania opłat za emisję spalin.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  | Data kosztu |
| Dokument | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt |  | Dokument kosztowy |
| IloscPaliwa | `decimal` | bazodanowe |  | Ilość paliwa |
| IloscPaliwaKg | `decimal` |  |  |  |
| Opis | `string` | bazodanowe |  |  |
| Pojazd | `Soneta.Samochodowka.Pojazd` | bazodanowe |  | Pojazd, dla którego rejestrujemy koszty |
| RodzajPaliwa | `Soneta.Samochodowka.EkoRodzajPaliwa` | bazodanowe |  | Rodzaj paliwa |
| Rozliczenie | `Soneta.Samochodowka.RozliczenieEP` | bazodanowe, tylko-odczyt |  | Rozliczenie związane z danym kosztem |
| TypPaliwa | `Soneta.Samochodowka.TypPaliwa` (enum) | bazodanowe |  | Typ paliwa (historyczny) |
| Wartosc | `decimal` | bazodanowe |  | Wartość kosztu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypPaliwa (`Soneta.Samochodowka.TypPaliwa`)
- `Brak` = 0
- `E95` = 1
- `E98` = 2
- `ON` = 3
- `LPG` = 4
