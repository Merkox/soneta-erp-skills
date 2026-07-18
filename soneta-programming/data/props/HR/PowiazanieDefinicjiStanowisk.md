# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieDefinicjiStanowisk`
Nazwa tabeli: `PowDefStan`
Tytuł: Powiązania definicji stanowisk
Opis: Opisuje relacje pomiędzy definicjami stanowisk. Umożliwia modelowanie zależności hierarchicznych i funkcjonalnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt | Definicja stanowiska |  |
| DefinicjaStanowiskaPowiazana | `Soneta.HR.DefinicjaStanowiska` | bazodanowe | Powiązane stanowisko |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| TypPowiazania | `Soneta.HR.ZKL.Enums.TypPowiazaniaStanowisk` (enum) | bazodanowe, tylko-odczyt | Typ powiązania |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypPowiazaniaStanowisk (`Soneta.HR.ZKL.Enums.TypPowiazaniaStanowisk`)
- `Wszystkie` = 0 — Wszystkie
- `RaportujeDo` = 10 — Raportuje do
- `ZastepstwoAktywne` = 20 — Zastępstwo aktywne
- `WspolpracaWewnetrzna` = 30 — Współpraca wewnętrzna
