# Pola i właściwości klasy biznesowej: `Soneta.HR.OfertaSzkolenia`
Nazwa tabeli: `OfertySzkolen`
Tytuł: Oferty szkoleń
Opis: Oferta szkoleniowa od dostawcy. Zawiera szczegóły organizacyjne: czas trwania, liczbę uczestników, cenę, lokalizację i typ szkolenia, stanowiąc podstawę do planowania realizacji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IAdresHost`
Selektor: pole `Typ` (`Soneta.HR.TypOfertySzkolenia`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresSzkolenia | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Cena | `Currency` | bazodanowe |  |  |
| CenaOdOsoby | `Currency` | bazodanowe |  |  |
| CzasTrwaniaDni | `int` | bazodanowe |  |  |
| CzasTrwaniaGodz | `Time` | bazodanowe |  |  |
| Definicja | `Soneta.HR.DefinicjaSzkolenia` | bazodanowe |  |  |
| Dostawca | `Soneta.HR.DostawcaSzkoleń` | bazodanowe, tylko-odczyt |  |  |
| Kod | `string` | bazodanowe |  |  |
| KodUDostawcy | `string` | bazodanowe |  |  |
| Kontakt | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Lokalizacja | `Soneta.HR.TypLokalizacjiSzkolenia` (enum) | bazodanowe |  |  |
| MaxOsob | `int` | bazodanowe | Max. ilość uczestników |  |
| MinOsob | `int` | bazodanowe | Min. ilość uczestników |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Osoba | `Soneta.CRM.KontaktOsoba` | bazodanowe |  |  |
| Typ | `Soneta.HR.TypOfertySzkolenia` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Wewnętrzne` | 1 | `Soneta.HR.OfertaSzkoleniaWewnętrznego` | Oferta szkolenia wewnętrznego |
| `Zewnętrzne` | 2 | `Soneta.HR.OfertaSzkoleniaZewnętrznego` | Oferta szkolenia |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypLokalizacjiSzkolenia (`Soneta.HR.TypLokalizacjiSzkolenia`)
- `DoUstalenia` = 0
- `WSiedzibieDostawcy` = 1 — W siedzibie dostawcy
- `UOdbiorcy` = 2 — U odbiorcy
- `InnyAdres` = 3

### TypOfertySzkolenia (`Soneta.HR.TypOfertySzkolenia`)
- `Wewnętrzne` = 1
- `Zewnętrzne` = 2
