# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza`
Nazwa tabeli: `DefWeryfKalend`
Tytuł: Definicje weryfikatorów dla kalendarzy
Opis: Konfigurowalna definicja weryfikatora kalendarza pracy. Określa rodzaj weryfikacji, priorytet, opis reguły oraz kod algorytmu sprawdzającego poprawność danych w kalendarzu (np. zgodność z przepisami o czasie pracy).
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza.AlgorytmBase` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Kalendarze | `Soneta.Business.SubTable<Soneta.Kalend.WeryfikatorKalendarza>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Rodzaj | `Soneta.Kalend.RodzajWeryfikacjiKalendarza` | bazodanowe, enum |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |

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
