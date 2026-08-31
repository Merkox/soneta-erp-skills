# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza`
Nazwa tabeli: `DefWeryfKalend`
Tytuł: Definicje weryfikatorów dla kalendarzy
Opis: Konfigurowalna definicja weryfikatora kalendarza pracy. Określa rodzaj weryfikacji, priorytet, opis reguły oraz kod algorytmu sprawdzającego poprawność danych w kalendarzu (np. zgodność z przepisami o czasie pracy).
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Rodzaj` (`Soneta.Kalend.RodzajWeryfikacjiKalendarza`) — wiele typów w jednej tabeli, podtypów: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.AlgorytmBase` | tylko-odczyt |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| ClassName | `string` | tylko-odczyt |  |  |
| Code | `MemoText` | bazodanowe, podlista |  |  |
| Kalendarze | `SubTable<Soneta.Kalend.WeryfikatorKalendarza>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Rodzaj | `Soneta.Kalend.RodzajWeryfikacjiKalendarza` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `DzienKalendarza` | 10 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.DzienKalendarza` | Weryfikator dnia kalendarza |
| `Kalendarz` | 20 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.Kalendarz` | Weryfikator definicji kalendarza |
| `DzienPlanu` | 30 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.DzienPlanu` | Weryfikator dnia planu |
| `Plan` | 40 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.Plan` | Weryfikator planu pracy |
| `DzienPracy` | 50 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.DzienPracy` | Weryfikator dnia pracy |
| `Praca` | 60 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.Praca` | Weryfikator czasu pracy |
| `DzienPlanuAktualizacja` | 70 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.DzienPlanuAktualizacja` | Weryfikator aktualizacji dnia planu |
| `PlanAktualizacja` | 80 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.PlanAktualizacja` | Weryfikator aktualizacji planu pracy |
| `DzienPracyAktualizacja` | 90 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.DzienPracyAktualizacja` | Weryfikator aktualizacji dnia pracy |
| `PracaAktualizacja` | 100 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.PracaAktualizacja` | Weryfikator aktualizacji czasu pracy |
| `ZestawieniePracy` | 110 | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.ZestawieniePracy` | Weryfikator zestawienia pracy |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajWeryfikacjiKalendarza (`Soneta.Kalend.RodzajWeryfikacjiKalendarza`)
- `DzienKalendarza` = 10 — Dzień kalendarza
- `Kalendarz` = 20 — Kalendarz
- `DzienPlanu` = 30 — Dzień planu
- `Plan` = 40 — Plan pracy
- `DzienPracy` = 50 — Dzień pracy
- `Praca` = 60 — Czas pracy
- `DzienPlanuAktualizacja` = 70 — Dzień planu aktualizacja
- `PlanAktualizacja` = 80 — Plan pracy aktualizacja
- `DzienPracyAktualizacja` = 90 — Dzień pracy aktualizacja
- `PracaAktualizacja` = 100 — Czas pracy aktualizacja
- `ZestawieniePracy` = 110 — Zestawienie czasu pracy
