# Pola i właściwości klasy biznesowej: `Soneta.Windykacja.EtapDefinicjiWindykacji`
Nazwa tabeli: `EtapyDefWind`
Tytuł: Etapy definicji windykacji
Opis: Element szczegółowy definicji sprawy windykacyjnej (DefinicjaSprawyWindykacyjnej). Definiuje pojedynczy krok w schemacie windykacji, określając jego typ, kolejność, czas trwania oraz powiązaną definicję etapu (StanWindykacji).
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasTrwania | `int` | bazodanowe | Czas trwania |  |
| Definicja | `Soneta.Windykacja.DefinicjaSprawyWindykacyjnej` | bazodanowe |  |  |
| DefinicjaEtapu | `Soneta.Windykacja.StanWindykacji` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypEtapu` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypEtapu (`Soneta.Kasa.TypEtapu`)
- `Inne` = 0 — Inne
- `Wezwanie` = 1
- `NotaOdsetkowa` = 2
- `Wizyta` = 3
- `Sąd` = 4
- `Email` = 5
- `Sms` = 6
- `Telefon` = 7
- `Komornik` = 8
