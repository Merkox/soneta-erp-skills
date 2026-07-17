# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.StanLeada`
Nazwa tabeli: `StanyLeada`
Tytuł: Stany leadów
Opis: Element szczegółowy definicji leada CRM (StanLeada). Definiuje etap w procesie kwalifikacji leada (np. nowy, w trakcie, skonwertowany) z określonym stopniem realizacji, klasyfikacją i kolejnością.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy lead w tym stanie jest aktywny. |
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany nie będą wyświetlane w liście wyboru. |
| Definicja | `Soneta.CRM.Config.DefLeada` | bazodanowe |  | Definicja leada, do której jest przypisany ten stan |
| Klasyfikacja | `Soneta.CRM.Klasyfikacja` | bazodanowe, enum | Klasyfikacja | Klasyfikacja stanu leada. |
| Kod | `string` |  |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu realizacji w ramach leada. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa stanu leada. |
| Opis | `string` | bazodanowe |  | Opis stanu leada. |
| OpisCaption | `string` |  |  |  |
| Realizacja | `Soneta.Types.Percent` | bazodanowe | Realizacja | Stopień realizacji leada na wskazanym etapie. |
| Stany | `Soneta.Business.SubTable<Soneta.CRM.Config.AvaliableLeadState>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Klasyfikacja (`Soneta.CRM.Klasyfikacja`)
- `Pozytywna` = 0 — Pozytywna
- `Negatywna` = 1
- `Neutralna` = 2
