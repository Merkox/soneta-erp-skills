# Pola i właściwości klasy biznesowej: `Soneta.HR.RealizacjaSzkolenia`
Nazwa tabeli: `RealizSzkolen`
Tytuł: Szkolenia
Opis: Konkretna realizacja szkolenia z określonym terminem, dostawcą i kosztami. Grupuje uczestników (wnioski o szkolenie) i pozwala śledzić przebieg od planowania przez realizację do oceny.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IAdresHost`, `IOceniany`, `IŹródłoOceny`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresSzkolenia | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| Budzet | `Soneta.HR.BudżetSzkoleń` | bazodanowe |  |  |
| Cena | `Currency` | bazodanowe |  |  |
| CenaOdOsoby | `Currency` | bazodanowe |  |  |
| Definicja | `Soneta.HR.DefinicjaSzkolenia` | bazodanowe |  |  |
| Dostawca | `Soneta.HR.DostawcaSzkoleń` | bazodanowe |  |  |
| Etap | `Soneta.HR.EtapRealizacjiSzkolenia` | bazodanowe |  |  |
| KorektaKosztu | `bool` | bazodanowe |  |  |
| Koszt | `Currency` | bazodanowe |  |  |
| Lokalizacja | `Soneta.HR.TypLokalizacjiSzkolenia` (enum) | bazodanowe |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Oceniani | `SubTable<Soneta.Oceny.OcenaOceniany>` | podlista |  |  |
| Oferta | `Soneta.HR.OfertaSzkolenia` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Osoba | `Soneta.CRM.KontaktOsoba` | bazodanowe |  |  |
| PowiązaneOceny | `SubTable<Soneta.Oceny.OcenaRealizacja>` | podlista |  |  |
| Tytul | `string` | bazodanowe | Tytuł |  |
| Uczestnicy | `SubTable<Soneta.HR.WniosekOSzkolenie>` | podlista |  |  |
| Wewnetrzne | `bool` | bazodanowe | Szkolenie wewnętrzne |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypLokalizacjiSzkolenia (`Soneta.HR.TypLokalizacjiSzkolenia`)
- `DoUstalenia` = 0
- `WSiedzibieDostawcy` = 1 — W siedzibie dostawcy
- `UOdbiorcy` = 2 — U odbiorcy
- `InnyAdres` = 3
