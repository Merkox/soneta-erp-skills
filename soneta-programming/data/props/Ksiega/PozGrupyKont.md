# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.PozGrupyKont`
Nazwa tabeli: `PozGrupyKontT`
Tytuł: Pozycje grup kont
Opis: Element szczegółowy grupy kont (GrupaKont). Wskazuje konkretne konto księgowe należące do grupy, umożliwiając budowanie zestawów kont wykorzystywanych w zestawieniach i raportach księgowych.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Grupa` → `GrupaKont`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Grupa | `Soneta.Ksiega.GrupaKont` | bazodanowe, tylko-odczyt, guided-parent |  | Grupa kont |
| Konto | `Soneta.Ksiega.KontoBase` | bazodanowe |  | Konto |
| Lp | `int` | bazodanowe |  |  |
| Rozszerzenie | `MemoText` | bazodanowe, podlista |  |  |
| Typ | `Soneta.Ksiega.TypGrupyKont` (enum) | tylko-odczyt |  |  |
| TypPozycjiBudzetujacej | `Soneta.Ksiega.TypPozycjiBudzetujacej` (enum) |  |  | Typ pozycji budżetującej |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypGrupyKont (`Soneta.Ksiega.TypGrupyKont`)
- `Brak` = 0 — Brak
- `Synchronizująca` = 1 — Synchronizująca
- `Budżetująca` = 2 — Budżetująca

### TypPozycjiBudzetujacej (`Soneta.Ksiega.TypPozycjiBudzetujacej`)
- `Wykonanie` = 0 — Wykonanie
- `Plan` = 1 — Plan
