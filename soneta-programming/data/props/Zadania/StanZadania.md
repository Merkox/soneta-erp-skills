# Pola i właściwości klasy biznesowej: `Soneta.Zadania.StanZadania`
Nazwa tabeli: `StanyZadania`
Tytuł: Stany realizacji zadań CRM
Opis: Element szczegółowy definicji zadania (DefZadania). Definiuje możliwy stan realizacji zadania CRM (np. nowe, w toku, zakończone) wraz z flagą aktywności i typem stanu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy zadanie w tym stanie jest aktywne (otwarte). |
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany dokumentów nie będą wyświetlane w liście wyboru. |
| Definicja | `Soneta.Zadania.DefZadania` | bazodanowe |  | Definicja zadania, do której jest przypisany ten stan |
| Ident | `int` | bazodanowe | Identyfikator | Identyfikator stanu na definicji zadania. Wykorzystywany w relacji do zadania. |
| Kod | `string` |  |  |  |
| Kolor | `string` | bazodanowe | Kolor | Kolor dla stanu |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu realizacji w ramach zadania. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa stanu realizacji zadania |
| Stany | `Soneta.Business.SubTable<Soneta.Zadania.AvaliableState>` |  |  |  |
| Typ | `Soneta.Zadania.TaskStateType` | bazodanowe, enum | Typ stanu zadania |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TaskStateType (`Soneta.Zadania.TaskStateType`)
- `Open` = 0 — Otwarte
- `Completed` = 1 — Zakończone
- `Rejected` = 2 — Odrzucone
