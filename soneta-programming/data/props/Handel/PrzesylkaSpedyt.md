# Pola i właściwości klasy biznesowej: `Soneta.Handel.PrzesylkaSpedyt`
Nazwa tabeli: `PrzesylkiSpedyt`
Tytuł: Przesyłki spedytora
Opis: Przesyłka kurierska powiązana z dokumentem handlowym. Zawiera dane adresowe dostawy i informacje o spedytorze.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 37
- pola kalkulowane (zapisywalne): 4
- pola tylko-odczyt: 7
- podlisty: 7
- subrowy: 4
- razem: 59

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument handlowy |  |
| EdytowanoAdres | `bool` | bazodanowe | Edytowano adres przesyłki |  |
| PaczkiKurierskie | `SubTable<Soneta.Handel.Paczka>` | podlista |  |  |
| Przesylka | `Soneta.Handel.Przesylka` (subrow) | bazodanowe | Przesylka |  |
| Przesylka.AdresDostawy | `Soneta.Core.Adres` (subrow) | bazodanowe | Adres dostawy |  |
| Przesylka.AdresDostawy.AdresExt | `Soneta.Core.AdresExt` | tylko-odczyt |  |  |
| Przesylka.AdresDostawy.AdresRozszerzony | `Soneta.Core.AdresRozszerzony` | tylko-odczyt |  |  |
| Przesylka.AdresDostawy.Faks | `string` | bazodanowe |  | Numer faksu |
| Przesylka.AdresDostawy.GLN | `string` |  |  |  |
| Przesylka.AdresDostawy.Gmina | `string` | bazodanowe |  | Gmina |
| Przesylka.AdresDostawy.IsRozszerzonyAdres | `bool` |  |  |  |
| Przesylka.AdresDostawy.KodKraju | `string` | bazodanowe |  | Kod kraju |
| Przesylka.AdresDostawy.KodPocztowy | `int` | bazodanowe |  | Kod pocztowy |
| Przesylka.AdresDostawy.KodPocztowyS | `string` |  |  |  |
| Przesylka.AdresDostawy.Kraj | `string` | bazodanowe |  | Kraj |
| Przesylka.AdresDostawy.Linia1 | `string` | tylko-odczyt |  |  |
| Przesylka.AdresDostawy.Linia2 | `string` | tylko-odczyt |  |  |
| Przesylka.AdresDostawy.Miejscowosc | `string` | bazodanowe | Miejscowość | Miejscowość |
| Przesylka.AdresDostawy.NietypowaLokalizacja | `string` | bazodanowe |  | Nietypowe miejsce lokalizacji |
| Przesylka.AdresDostawy.NrDomu | `string` | bazodanowe |  | Numer domu (bloku) |
| Przesylka.AdresDostawy.NrLokalu | `string` | bazodanowe |  | Numer lokalu w domu (bloku) |
| Przesylka.AdresDostawy.Pełny | `string` |  |  |  |
| Przesylka.AdresDostawy.Poczta | `string` | bazodanowe |  | Poczta |
| Przesylka.AdresDostawy.Powiat | `string` | bazodanowe |  | Powiat |
| Przesylka.AdresDostawy.Telefon | `string` | bazodanowe |  | Numer telefonu |
| Przesylka.AdresDostawy.Ulica | `string` | bazodanowe |  | Nazwa ulicy (alei, osiedla) |
| Przesylka.AdresDostawy.Wojewodztwo | `Soneta.Core.Wojewodztwa` (enum) | bazodanowe |  | Województwo |
| Przesylka.AdresDostawy.ZagranicznyKodPocztowy | `string` | bazodanowe |  | Zagraniczny kod pocztowy |
| Przesylka.AdresDostawyNazwa | `string` | bazodanowe | Nazwa adresu nadania |  |
| Przesylka.AdresNadania | `Soneta.CRM.Lokalizacja` | bazodanowe | Adres nadania |  |
| Przesylka.DataListu | `Date` | bazodanowe | Data listu przewozowego |  |
| Przesylka.DokumentHandlowy | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  |  |
| Przesylka.Email | `string` | bazodanowe |  |  |
| Przesylka.IdPrzesylki | `string` | bazodanowe | Id przesyłki w systemie kuriera |  |
| Przesylka.IdentyfikacjaAdresuDostawy | `Soneta.Core.IdentyfikacjaAdresu` (subrow) | bazodanowe |  |  |
| Przesylka.IdentyfikacjaAdresuDostawy.GLN | `string` | bazodanowe | GLN (ILN) | Globalny numer lakalizacji. |
| Przesylka.NumerListu | `string` | bazodanowe | Numer listu przewozowego |  |
| Przesylka.NumerProtokoluOdbioru | `string` | bazodanowe | Numer protokołu odbioru |  |
| Przesylka.OsobaKontaktowa | `string` | bazodanowe |  |  |
| Przesylka.Paczki | `View` | podlista |  |  |
| Przesylka.PrzesylkaSpedytor | `Soneta.Handel.PrzesylkaSpedyt` | tylko-odczyt |  |  |
| Przesylka.PunktOdbioru | `Soneta.Handel.PunktOdbioru` (subrow) | bazodanowe |  |  |
| Przesylka.PunktOdbioru.Kod | `string` | bazodanowe | Kod |  |
| Przesylka.PunktOdbioru.Nazwa | `string` | bazodanowe | Nazwa |  |
| Przesylka.PunktOdbioru.Opis | `string` | bazodanowe | Opis |  |
| Przesylka.PunktOdbioru.Rodzaj | `Soneta.Handel.RodzajPunktuOdbioru` (enum) | bazodanowe | Rodzaj |  |
| Przesylka.PunktOdbioru.System | `Soneta.Handel.TypPunktuOdbioru` (enum) | bazodanowe | System |  |
| Przesylka.RodzajMiejscaDostawy | `Soneta.Handel.RodzajMiejscaDostawy` (enum) | bazodanowe | Rodzaj miejsca dostawy |  |
| Przesylka.RodzajPrzesylki | `Soneta.Core.SlownikElem` | bazodanowe | Rodzaj przesyłki | Rodzaj nadawanej przesyłki |
| Przesylka.Spedytor | `Soneta.Core.SystemZewn` | bazodanowe | Spedytor |  |
| Przesylka.Status | `string` | bazodanowe | Status przesyłki |  |
| Przesylka.TelefonKomorkowy | `string` | bazodanowe |  |  |
| Przesylka.TelefonStacjonarny | `string` | bazodanowe |  |  |
| Przesylka.URLPrzesylki | `string` | bazodanowe | URL śledzenia przesyłki |  |
| Przesylka.WgAdresNadania | `Key` | podlista |  |  |
| Przesylka.WgRodzajPrzesylki | `Key` | podlista |  |  |
| Przesylka.WgSpedytor | `Key` | podlista |  |  |
| PrzesylkiDokRelacje | `SubTable<Soneta.Handel.PrzesylkaDokRel>` | podlista |  |  |
| UslugiDodatkowe | `SubTable<Soneta.Handel.UslDodPrzesyl>` | podlista |  |  |

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

### RodzajMiejscaDostawy (`Soneta.Handel.RodzajMiejscaDostawy`)
- `AdresOdbiorcy` = 0 — Adres odbiorcy
- `PunktOdbioru` = 1 — Punkt odbioru

### RodzajPunktuOdbioru (`Soneta.Handel.RodzajPunktuOdbioru`)
- `Standard` = 0
- `Allegro` = 1

### TypPunktuOdbioru (`Soneta.Handel.TypPunktuOdbioru`)
- `Inpost` = 0
