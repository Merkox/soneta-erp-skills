# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.GrupaKont`
Nazwa tabeli: `GrupyKont`
Tytuł: Grupy kont
Opis: Grupa kont definiuje nazwany zbiór kont księgowych w ramach okresu obrachunkowego. Służy do logicznego grupowania kont na potrzeby zestawień, schematów księgowych i raportów, z możliwością rozszerzenia o dodatkową logikę.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FunkcjaGrupyBudzetujacej | `Soneta.Ksiega.FunkcjaGrupyBudzetujacej` | enum |  | Funkcja grupy budżetującej |
| Nieaktywna | `bool` | bazodanowe |  |  |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe |  |  |
| OkresGrupyBudzetujacej | `Soneta.Ksiega.OkresGrupyBudzetujacej` | enum |  | Okres grupy budżetującej |
| Opis | `string` | bazodanowe |  |  |
| Pozycje | `Soneta.Business.LpSubTable<Soneta.Ksiega.PozGrupyKont>` |  |  |  |
| Rozszerzenie | `Soneta.Business.MemoText` | bazodanowe |  |  |
| StronaGrupyBudzetujacejPlan | `Soneta.Ksiega.StronaGrupyBudzetujacej` | enum |  | Strona pozycji budżetującej - plan |
| StronaGrupyBudzetujacejWykonanie | `Soneta.Ksiega.StronaGrupyBudzetujacej` | enum |  | Strona pozycji budżetującej - Wykonanie |
| Symbol | `string` | bazodanowe |  |  |
| Typ | `Soneta.Ksiega.TypGrupyKont` | bazodanowe, enum |  | Typ grupy kont |
| WeryfikacjaGrupyBudzetujacej | `Soneta.Types.VerifierType` | enum |  | Weryfikacja grupy budżetującej |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FunkcjaGrupyBudzetujacej (`Soneta.Ksiega.FunkcjaGrupyBudzetujacej`)
- `Obroty` = 0 — Obroty
- `Saldo` = 1 — Saldo

### OkresGrupyBudzetujacej (`Soneta.Ksiega.OkresGrupyBudzetujacej`)
- `Narastająco` = 0 — Narastająco
- `Miesięcznie` = 1 — Miesięcznie
- `Kwartalnie` = 2 — Kwartalnie

### StronaGrupyBudzetujacej (`Soneta.Ksiega.StronaGrupyBudzetujacej`)
- `Winien` = 0 — Winien
- `Ma` = 1 — Ma

### TypGrupyKont (`Soneta.Ksiega.TypGrupyKont`)
- `Brak` = 0 — Brak
- `Synchronizująca` = 1 — Synchronizująca
- `Budżetująca` = 2 — Budżetująca

### VerifierType (`Soneta.Types.VerifierType`)
- `Error` = 0 — Błąd
- `Warning` = 1 — Ostrzeżenie
- `Information` = 2 — Informacja
