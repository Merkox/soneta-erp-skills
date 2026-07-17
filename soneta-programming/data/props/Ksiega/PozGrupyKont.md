# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.PozGrupyKont`
Nazwa tabeli: `PozGrupyKontT`
Tytuł: Pozycje grup kont
Opis: Element szczegółowy grupy kont (GrupaKont). Wskazuje konkretne konto księgowe należące do grupy, umożliwiając budowanie zestawów kont wykorzystywanych w zestawieniach i raportach księgowych.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Grupa` → `GrupaKont`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Grupa | `Soneta.Ksiega.GrupaKont` | bazodanowe, guided-parent |  | Grupa kont |
| Konto | `Soneta.Ksiega.KontoBase` | bazodanowe |  | Konto |
| Lp | `int` | bazodanowe |  |  |
| Rozszerzenie | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Typ | `Soneta.Ksiega.TypGrupyKont` | enum |  |  |
| TypPozycjiBudzetujacej | `Soneta.Ksiega.TypPozycjiBudzetujacej` | enum |  | Typ pozycji budżetującej |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypGrupyKont (`Soneta.Ksiega.TypGrupyKont`)
- `Brak` = 0 — Brak
- `Synchronizująca` = 1 — Synchronizująca
- `Budżetująca` = 2 — Budżetująca

### TypPozycjiBudzetujacej (`Soneta.Ksiega.TypPozycjiBudzetujacej`)
- `Wykonanie` = 0 — Wykonanie
- `Plan` = 1 — Plan
