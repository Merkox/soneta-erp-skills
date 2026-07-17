# Pola i właściwości klasy biznesowej: `Soneta.BI.TimeSpanDefinition`
Nazwa tabeli: `TimeSpanDefs`
Tytuł: Definicje przedziałów czasowych
Opis: Definicja przedziału czasowego wykorzystywanego w analizach BI. Określa nazwany zakres czasu (np. bieżący miesiąc, poprzedni kwartał) wraz z formułami obliczania granic przedziału. Przedziały są grupowane w zestawy i przypisywane do pól modeli danych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FromText | `Soneta.Business.MemoText` | bazodanowe |  |  |
| FromTo | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| ToText | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Type | `Soneta.BI.TimeSpanType` | bazodanowe, enum | Typ | Typ przedziału czasowego |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TimeSpanType (`Soneta.BI.TimeSpanType`)
- `Static` = 1 — Statyczny
- `Dynamic` = 2 — Dynamiczny
