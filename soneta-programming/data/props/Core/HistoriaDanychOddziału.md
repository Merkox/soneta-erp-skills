# Pola i właściwości klasy biznesowej: `Soneta.Core.HistoriaDanychOddziału`
Nazwa tabeli: `HstDanychOddzial`
Tytuł: Historia danych oddziałów firmy
Opis: Element szczegółowy oddziału firmy (OddzialFirmy). Przechowuje historyczne wersje danych oddziału (nazwa, NIP, EU VAT, REGON, adres, numer licencji) z datą obowiązywania, umożliwiając śledzenie zmian w czasie.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 25
- pola kalkulowane (z klas biznesowych): 14

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
| BDO | `string` |  |  |  |
| EORI | `string` |  |  |  |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| NIP | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` |  |  |  |
| NazwaSkrocona | `string` | bazodanowe |  |  |
| NumerLicencji | `string` | bazodanowe | Numer licencji oddziału | Numer licencji do weryfikacji danych oddziału. |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| PKD | `string` |  |  |  |
| REGON | `string` | bazodanowe |  |  |
| StatusLicencji | `string` |  |  |  |
| SufiksNazwy | `string` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |

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
