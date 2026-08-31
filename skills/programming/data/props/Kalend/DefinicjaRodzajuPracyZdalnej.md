# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaRodzajuPracyZdalnej`
Nazwa tabeli: `DefRodzPracZdal`
Tytuł: Definicje rodzaju pracy zdalnej
Opis: Konfigurowalna definicja rodzaju pracy zdalnej. Określa, czy praca zdalna wymaga wniosku, czy obowiązuje limit dni (dzienny/miesięczny/roczny) oraz jaką strefę czasu pracy przypisać do pracy zdalnej.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaStrefy | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| JestLimit | `bool` | bazodanowe |  |  |
| Limit | `int` | bazodanowe |  |  |
| NaWniosek | `Soneta.Kalend.PracaZdalnaNaWniosek` (enum) | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| TypLimitu | `Soneta.Kalend.TypLimituPracyZdalnej` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PracaZdalnaNaWniosek (`Soneta.Kalend.PracaZdalnaNaWniosek`)
- `NieDotyczy` = 0
- `Pracownika` = 1
- `Pracodawcy` = 2

### TypLimituPracyZdalnej (`Soneta.Kalend.TypLimituPracyZdalnej`)
- `Roczny` = 0
- `Miesieczny` = 1 — Miesięczny
- `Tygodniowy` = 2
- `Kwartalny` = 3
- `Półroczny` = 4
