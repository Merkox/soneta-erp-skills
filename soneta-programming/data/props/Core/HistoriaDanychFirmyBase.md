# Pola i właściwości klasy biznesowej: `Soneta.Core.HistoriaDanychFirmyBase`
Nazwa tabeli: `HstDanychFirmy`
Tytuł: Historia danych firmy
Opis: Historia danych firmy (głównego podmiotu). Przechowuje historyczne wersje danych firmy (nazwa, NIP, EU VAT, REGON, adres, numer licencji) z datą obowiązywania, z podziałem na rodzaje zmian.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 21
- pola kalkulowane (zapisywalne): 5
- pola tylko-odczyt: 11
- podlisty: 0
- subrowy: 1
- razem: 38

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` (subrow) | bazodanowe |  |  |
| Adres.AdresExt | `Soneta.Core.AdresExt` | tylko-odczyt |  |  |
| Adres.AdresRozszerzony | `Soneta.Core.AdresRozszerzony` | tylko-odczyt |  |  |
| Adres.Faks | `string` | bazodanowe |  | Numer faksu |
| Adres.GLN | `string` |  |  |  |
| Adres.Gmina | `string` | bazodanowe |  | Gmina |
| Adres.IsRozszerzonyAdres | `bool` |  |  |  |
| Adres.KodKraju | `string` | bazodanowe |  | Kod kraju |
| Adres.KodPocztowy | `int` | bazodanowe |  | Kod pocztowy |
| Adres.KodPocztowyS | `string` |  |  |  |
| Adres.Kraj | `string` | bazodanowe |  | Kraj |
| Adres.Linia1 | `string` | tylko-odczyt |  |  |
| Adres.Linia2 | `string` | tylko-odczyt |  |  |
| Adres.Miejscowosc | `string` | bazodanowe | Miejscowość | Miejscowość |
| Adres.NietypowaLokalizacja | `string` | bazodanowe |  | Nietypowe miejsce lokalizacji |
| Adres.NrDomu | `string` | bazodanowe |  | Numer domu (bloku) |
| Adres.NrLokalu | `string` | bazodanowe |  | Numer lokalu w domu (bloku) |
| Adres.Pełny | `string` |  |  |  |
| Adres.Poczta | `string` | bazodanowe |  | Poczta |
| Adres.Powiat | `string` | bazodanowe |  | Powiat |
| Adres.Telefon | `string` | bazodanowe |  | Numer telefonu |
| Adres.Ulica | `string` | bazodanowe |  | Nazwa ulicy (alei, osiedla) |
| Adres.Wojewodztwo | `Soneta.Core.Wojewodztwa` (enum) | bazodanowe |  | Województwo |
| Adres.ZagranicznyKodPocztowy | `string` | bazodanowe |  | Zagraniczny kod pocztowy |
| BDO | `string` | tylko-odczyt |  |  |
| EORI | `string` | tylko-odczyt |  |  |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| NIP | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
| NazwaSkrocona | `string` | bazodanowe |  |  |
| NumerLicencji | `string` | bazodanowe | Numer licencji oddziału | Numer licencji do weryfikacji danych oddziału. |
| PKD | `string` | tylko-odczyt |  |  |
| REGON | `string` | bazodanowe |  |  |
| Rodzaj | `Soneta.Core.RodzajHistoriiFirmy` (enum) | bazodanowe, tylko-odczyt |  |  |
| StatusLicencji | `string` | tylko-odczyt |  |  |
| Termin | `Date` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajHistoriiFirmy (`Soneta.Core.RodzajHistoriiFirmy`)
- `HistoriaDanychFirmy` = 1
- `HistoriaDanychBiuraRachunkowego` = 2

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
