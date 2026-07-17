# Pola i właściwości klasy biznesowej: `Soneta.Core.KodPocztowyAU`
Nazwa tabeli: `KodyPocztoweAU`
Tytuł: Tabela z kodami pocztowymi oraz odpowiadającymi im województwami
Opis: Rozszerzony słownik kodów pocztowych z pełną strukturą administracyjną (województwo, powiat, gmina, miejscowość, ulica) oraz identyfikatorami terytorium TERYT. Wykorzystywany do walidacji i automatycznego uzupełniania adresów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Gmina | `string` | bazodanowe |  |  |
| IdMiejscowosci | `string` | bazodanowe | ID miejscowości | Identyfikator miejscowości |
| IdTerytorium | `string` | bazodanowe | ID terytorium | Identyfikator terytorium |
| IdUlicy | `string` | bazodanowe | ID ulicy | Identyfikator ulicy |
| KodPocztowy | `string` | bazodanowe | Kod pocztowy |  |
| Miejscowosc | `string` | bazodanowe | Miejscowość |  |
| Powiat | `string` | bazodanowe |  |  |
| StanNa | `Soneta.Types.Date` | bazodanowe | Stan na | Data dodania lub modyfikacji rekordu |
| Ulica | `string` | bazodanowe |  |  |
| Wojewodztwo | `Soneta.Core.Wojewodztwa` | bazodanowe, enum | Województwo |  |

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
