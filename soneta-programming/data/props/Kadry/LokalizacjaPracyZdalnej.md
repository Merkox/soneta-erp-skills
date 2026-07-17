# Pola i właściwości klasy biznesowej: `Soneta.Kadry.LokalizacjaPracyZdalnej`
Nazwa tabeli: `LokPracZdalnej`
Tytuł: Lokalizacja pracy zdalnej
Opis: Element szczegółowy pracownika (Pracownik). Adres lokalizacji, z której pracownik wykonuje pracę zdalną, z oznaczeniem okresu obowiązywania i możliwością blokady.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 19
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | bazodanowe |  |  |
| Adres.AdresExt | `Soneta.Core.AdresExt` |  |  |  |
| Adres.AdresRozszerzony | `Soneta.Core.AdresRozszerzony` |  |  |  |
| Adres.Faks | `string` | bazodanowe |  | Numer faksu |
| Adres.GLN | `string` |  |  |  |
| Adres.Gmina | `string` | bazodanowe |  | Gmina |
| Adres.IsRozszerzonyAdres | `bool` |  |  |  |
| Adres.KodKraju | `string` | bazodanowe |  | Kod kraju |
| Adres.KodPocztowy | `int` | bazodanowe |  | Kod pocztowy |
| Adres.KodPocztowyS | `string` |  |  |  |
| Adres.Kraj | `string` | bazodanowe |  | Kraj |
| Adres.Linia1 | `string` |  |  |  |
| Adres.Linia2 | `string` |  |  |  |
| Adres.Miejscowosc | `string` | bazodanowe | Miejscowość | Miejscowość |
| Adres.NietypowaLokalizacja | `string` | bazodanowe |  | Nietypowe miejsce lokalizacji |
| Adres.NrDomu | `string` | bazodanowe |  | Numer domu (bloku) |
| Adres.NrLokalu | `string` | bazodanowe |  | Numer lokalu w domu (bloku) |
| Adres.Pełny | `string` |  |  |  |
| Adres.Poczta | `string` | bazodanowe |  | Poczta |
| Adres.Powiat | `string` | bazodanowe |  | Powiat |
| Adres.Telefon | `string` | bazodanowe |  | Numer telefonu |
| Adres.Ulica | `string` | bazodanowe |  | Nazwa ulicy (alei, osiedla) |
| Adres.Wojewodztwo | `Soneta.Core.Wojewodztwa` | bazodanowe, enum |  | Województwo |
| Adres.ZagranicznyKodPocztowy | `string` | bazodanowe |  | Zagraniczny kod pocztowy |
| Blokada | `bool` | bazodanowe |  |  |
| Kod | `string` |  |  |  |
| Nazwa | `string` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| RcpWorkMode | `Soneta.Core.Enums.RcpWorkMode` | enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RcpWorkMode (`Soneta.Core.Enums.RcpWorkMode`)
- `Stationary` = 0 — Stacjonarna
- `Remote` = 1 — Zdalna
- `All` = 2 — Wszystkie

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
