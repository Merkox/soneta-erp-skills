# Pola i właściwości klasy biznesowej: `Soneta.HR.RealizacjaSzkolenia`
Nazwa tabeli: `RealizSzkolen`
Tytuł: Szkolenia
Opis: Konkretna realizacja szkolenia z określonym terminem, dostawcą i kosztami. Grupuje uczestników (wnioski o szkolenie) i pozwala śledzić przebieg od planowania przez realizację do oceny.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IAdresHost`, `IOceniany`, `IŹródłoOceny`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| AdresSzkolenia | `Soneta.Core.Adres` |  |  |  |
| Budzet | `Soneta.HR.BudżetSzkoleń` | bazodanowe |  |  |
| Cena | `Soneta.Types.Currency` | bazodanowe |  |  |
| CenaOdOsoby | `Soneta.Types.Currency` | bazodanowe |  |  |
| Definicja | `Soneta.HR.DefinicjaSzkolenia` | bazodanowe |  |  |
| Dostawca | `Soneta.HR.DostawcaSzkoleń` | bazodanowe |  |  |
| Etap | `Soneta.HR.EtapRealizacjiSzkolenia` | bazodanowe |  |  |
| KorektaKosztu | `bool` | bazodanowe |  |  |
| Koszt | `Soneta.Types.Currency` | bazodanowe |  |  |
| Lokalizacja | `Soneta.HR.TypLokalizacjiSzkolenia` | bazodanowe, enum |  |  |
| Nazwa | `string` |  |  |  |
| Oceniani | `Soneta.Business.SubTable<Soneta.Oceny.OcenaOceniany>` |  |  |  |
| Oferta | `Soneta.HR.OfertaSzkolenia` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Osoba | `Soneta.CRM.KontaktOsoba` | bazodanowe |  |  |
| PowiązaneOceny | `Soneta.Business.SubTable<Soneta.Oceny.OcenaRealizacja>` |  |  |  |
| Tytul | `string` | bazodanowe | Tytuł |  |
| Uczestnicy | `Soneta.Business.SubTable<Soneta.HR.WniosekOSzkolenie>` |  |  |  |
| Wewnetrzne | `bool` | bazodanowe | Szkolenie wewnętrzne |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypLokalizacjiSzkolenia (`Soneta.HR.TypLokalizacjiSzkolenia`)
- `DoUstalenia` = 0
- `WSiedzibieDostawcy` = 1 — W siedzibie dostawcy
- `UOdbiorcy` = 2 — U odbiorcy
- `InnyAdres` = 3
