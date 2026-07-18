# Pola i właściwości klasy biznesowej: `Soneta.HR.EtapRealizacjiSzkolenia`
Nazwa tabeli: `EtapRealizSzkol`
Tytuł: Etapy realizacji szkoleń
Opis: Słownik etapów procesu realizacji szkolenia (np. zaplanowane, w trakcie, zakończone). Definiuje kolejność kroków i powiązane stany, sterujące przepływem procesu szkoleniowego.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Stan | `Soneta.HR.StanyRealizacjiSzkolenia` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanyRealizacjiSzkolenia (`Soneta.HR.StanyRealizacjiSzkolenia`)
- `WniosekZgłoszony` = 1 — Wniosek zgłoszony
- `WniosekZatwierdzony` = 2
- `WniosekAnulowany` = 3
- `SzkoleniePrzygotowywane` = 4
- `SzkolenieZrealizowane` = 5
- `SzkolenieRozliczone` = 6
- `SzkolenieAnulowane` = 7
