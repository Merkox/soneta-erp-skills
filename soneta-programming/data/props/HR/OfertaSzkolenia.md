# Pola i właściwości klasy biznesowej: `Soneta.HR.OfertaSzkolenia`
Nazwa tabeli: `OfertySzkolen`
Tytuł: Oferty szkoleń
Opis: Oferta szkoleniowa od dostawcy. Zawiera szczegóły organizacyjne: czas trwania, liczbę uczestników, cenę, lokalizację i typ szkolenia, stanowiąc podstawę do planowania realizacji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IAdresHost`

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| AdresSzkolenia | `Soneta.Core.Adres` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Cena | `Soneta.Types.Currency` | bazodanowe |  |  |
| CenaOdOsoby | `Soneta.Types.Currency` | bazodanowe |  |  |
| CzasTrwaniaDni | `int` | bazodanowe |  |  |
| CzasTrwaniaGodz | `Soneta.Types.Time` | bazodanowe |  |  |
| Definicja | `Soneta.HR.DefinicjaSzkolenia` | bazodanowe |  |  |
| Dostawca | `Soneta.HR.DostawcaSzkoleń` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| KodUDostawcy | `string` | bazodanowe |  |  |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Lokalizacja | `Soneta.HR.TypLokalizacjiSzkolenia` | bazodanowe, enum |  |  |
| MaxOsob | `int` | bazodanowe | Max. ilość uczestników |  |
| MinOsob | `int` | bazodanowe | Min. ilość uczestników |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Osoba | `Soneta.CRM.KontaktOsoba` | bazodanowe |  |  |
| Typ | `Soneta.HR.TypOfertySzkolenia` | bazodanowe, enum |  |  |

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
