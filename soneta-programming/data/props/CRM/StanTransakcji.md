# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.StanTransakcji`
Nazwa tabeli: `StanyTransakcji`
Tytuł: Stany transakcji
Opis: Element szczegółowy definicji transakcji CRM (StanTransakcji). Definiuje etap w procesie sprzedażowym (np. kwalifikacja, negocjacje, zamknięcie) z określonym stopniem realizacji, klasyfikacją i kolejnością.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy transakcja w tym stanie jest aktywna. |
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie etapu. Zablokowane etapy nie będą wyświetlane w liście wyboru. |
| Definicja | `Soneta.CRM.Config.DefTransakcja` | bazodanowe |  | Definicja transakcji, do której jest przypisany ten stan |
| Klasyfikacja | `Soneta.CRM.Klasyfikacja` | bazodanowe, enum | Klasyfikacja | Klasyfikacja etapu transakcji. |
| Kod | `string` |  |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa etapu w ramach transakcji. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa etapu transakcji. |
| Opis | `string` | bazodanowe |  | Opis etapu transakcji. |
| OpisCaption | `string` |  |  |  |
| Realizacja | `Soneta.Types.Percent` | bazodanowe | Realizacja | Stopień realizacji transakcji na wskazanym etapie. |
| Stany | `Soneta.Business.SubTable<Soneta.CRM.Config.AvaliableTransactionState>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Klasyfikacja (`Soneta.CRM.Klasyfikacja`)
- `Pozytywna` = 0 — Pozytywna
- `Negatywna` = 1
- `Neutralna` = 2
