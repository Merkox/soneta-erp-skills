# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieDefinicjiStanowisk`
Nazwa tabeli: `PowDefStan`
Tytuł: Powiązania definicji stanowisk
Opis: Opisuje relacje pomiędzy definicjami stanowisk. Umożliwia modelowanie zależności hierarchicznych i funkcjonalnych.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `TypPowiazania` (`Soneta.HR.ZKL.Enums.TypPowiazaniaStanowisk`) — wiele typów w jednej tabeli, podtypów: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt | Definicja stanowiska |  |
| DefinicjaStanowiskaPowiazana | `Soneta.HR.DefinicjaStanowiska` | bazodanowe | Powiązane stanowisko |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| TypPowiazania | `Soneta.HR.ZKL.Enums.TypPowiazaniaStanowisk` (enum) | bazodanowe, tylko-odczyt, selektor | Typ powiązania |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `TypPowiazania`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `RaportujeDo` | 10 | `Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieRaportujeDo` | Raportuje do |
| `ZastepstwoAktywne` | 20 | `Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieZastepstwoAktywne` | Raportuje do |
| `WspolpracaWewnetrzna` | 30 | `Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieWspolpracaWewnetrzna` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypPowiazaniaStanowisk (`Soneta.HR.ZKL.Enums.TypPowiazaniaStanowisk`)
- `Wszystkie` = 0 — Wszystkie
- `RaportujeDo` = 10 — Raportuje do
- `ZastepstwoAktywne` = 20 — Zastępstwo aktywne
- `WspolpracaWewnetrzna` = 30 — Współpraca wewnętrzna
