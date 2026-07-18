# Pola i właściwości klasy biznesowej: `Soneta.BI.TimeSpanDefinition`
Nazwa tabeli: `TimeSpanDefs`
Tytuł: Definicje przedziałów czasowych
Opis: Definicja przedziału czasowego wykorzystywanego w analizach BI. Określa nazwany zakres czasu (np. bieżący miesiąc, poprzedni kwartał) wraz z formułami obliczania granic przedziału. Przedziały są grupowane w zestawy i przypisywane do pól modeli danych.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Type` (`Soneta.BI.TimeSpanType`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FromText | `MemoText` | bazodanowe, podlista |  |  |
| FromTo | `FromTo` | bazodanowe, podlista |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| ToText | `MemoText` | bazodanowe, podlista |  |  |
| Type | `Soneta.BI.TimeSpanType` (enum) | bazodanowe, tylko-odczyt, selektor | Typ | Typ przedziału czasowego |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Type`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Static` | 1 | `Soneta.BI.StaticTimeSpanDefinition` | Definicja statyczna |
| `Dynamic` | 2 | `Soneta.BI.DynamicTimeSpanDefinition` | Definicja dynamiczna |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TimeSpanType (`Soneta.BI.TimeSpanType`)
- `Static` = 1 — Statyczny
- `Dynamic` = 2 — Dynamiczny
