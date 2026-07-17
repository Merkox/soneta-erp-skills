# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieDefinicjiStanowisk`
Nazwa tabeli: `PowDefStan`
Tytuł: Powiązania definicji stanowisk
Opis: Opisuje relacje pomiędzy definicjami stanowisk. Umożliwia modelowanie zależności hierarchicznych i funkcjonalnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe | Definicja stanowiska |  |
| DefinicjaStanowiskaPowiazana | `Soneta.HR.DefinicjaStanowiska` | bazodanowe | Powiązane stanowisko |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| TypPowiazania | `Soneta.HR.ZKL.Enums.TypPowiazaniaStanowisk` | bazodanowe, enum | Typ powiązania |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypPowiazaniaStanowisk (`Soneta.HR.ZKL.Enums.TypPowiazaniaStanowisk`)
- `Wszystkie` = 0 — Wszystkie
- `RaportujeDo` = 10 — Raportuje do
- `ZastepstwoAktywne` = 20 — Zastępstwo aktywne
- `WspolpracaWewnetrzna` = 30 — Współpraca wewnętrzna
