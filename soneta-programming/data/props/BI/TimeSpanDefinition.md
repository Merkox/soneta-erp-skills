# Pola i właściwości klasy biznesowej: `Soneta.BI.TimeSpanDefinition`
Nazwa tabeli: `TimeSpanDefs`
Tytuł: Definicje przedziałów czasowych
Opis: Definicja przedziału czasowego wykorzystywanego w analizach BI. Określa nazwany zakres czasu (np. bieżący miesiąc, poprzedni kwartał) wraz z formułami obliczania granic przedziału. Przedziały są grupowane w zestawy i przypisywane do pól modeli danych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 3
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FromText | `MemoText` | bazodanowe, podlista |  |  |
| FromTo | `FromTo` | bazodanowe, podlista |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| ToText | `MemoText` | bazodanowe, podlista |  |  |
| Type | `Soneta.BI.TimeSpanType` (enum) | bazodanowe, tylko-odczyt | Typ | Typ przedziału czasowego |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TimeSpanType (`Soneta.BI.TimeSpanType`)
- `Static` = 1 — Statyczny
- `Dynamic` = 2 — Dynamiczny
