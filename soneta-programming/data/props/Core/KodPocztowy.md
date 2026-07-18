# Pola i właściwości klasy biznesowej: `Soneta.Core.KodPocztowy`
Nazwa tabeli: `KodyPocztowe`
Tytuł: Tabela z kodami pocztowymi oraz odpowiadającymi im miejscowościami
Opis: Słownik kodów pocztowych z przypisanymi miejscowościami, powiatami i województwami. Służy do automatycznego uzupełniania danych adresowych na podstawie kodu pocztowego.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KodPocztowy | `string` | bazodanowe | Kod pocztowy |  |
| Miejscowosc | `Db.DictionaryItem` | bazodanowe | Miejscowość |  |
| Powiat | `Db.DictionaryItem` | bazodanowe |  |  |
| Wojewodztwo | `Soneta.Core.Wojewodztwa` (enum) | bazodanowe | Województwo |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Wojewodztwa (`Soneta.Core.Wojewodztwa`)
- `nieokreślone` = 0
- `dolnośląskie` = 1
- `kujawsko_pomorskie` = 2 — kujawsko-pomorskie
- `lubelskie` = 3
- `lubuskie` = 4
- `łódzkie` = 5
- `małopolskie` = 6
- `mazowieckie` = 7
- `opolskie` = 8
- `podkarpackie` = 9
- `podlaskie` = 10
- `pomorskie` = 11
- `śląskie` = 12
- `świętokrzyskie` = 13
- `warmińsko_mazurskie` = 14 — warmińsko-mazurskie
- `wielkopolskie` = 15
- `zachodniopomorskie` = 16
