# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.GrupaKont`
Nazwa tabeli: `GrupyKont`
Tytuł: Grupy kont
Opis: Grupa kont definiuje nazwany zbiór kont księgowych w ramach okresu obrachunkowego. Służy do logicznego grupowania kont na potrzeby zestawień, schematów księgowych i raportów, z możliwością rozszerzenia o dodatkową logikę.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 5
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FunkcjaGrupyBudzetujacej | `Soneta.Ksiega.FunkcjaGrupyBudzetujacej` (enum) |  |  | Funkcja grupy budżetującej |
| Nieaktywna | `bool` | bazodanowe |  |  |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe, tylko-odczyt |  |  |
| OkresGrupyBudzetujacej | `Soneta.Ksiega.OkresGrupyBudzetujacej` (enum) |  |  | Okres grupy budżetującej |
| Opis | `string` | bazodanowe |  |  |
| Pozycje | `LpSubTable<Soneta.Ksiega.PozGrupyKont>` | podlista |  |  |
| Rozszerzenie | `MemoText` | bazodanowe, podlista |  |  |
| StronaGrupyBudzetujacejPlan | `Soneta.Ksiega.StronaGrupyBudzetujacej` (enum) |  |  | Strona pozycji budżetującej - plan |
| StronaGrupyBudzetujacejWykonanie | `Soneta.Ksiega.StronaGrupyBudzetujacej` (enum) |  |  | Strona pozycji budżetującej - Wykonanie |
| Symbol | `string` | bazodanowe |  |  |
| Typ | `Soneta.Ksiega.TypGrupyKont` (enum) | bazodanowe, tylko-odczyt |  | Typ grupy kont |
| WeryfikacjaGrupyBudzetujacej | `VerifierType` (enum) |  |  | Weryfikacja grupy budżetującej |

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

### VerifierType (`VerifierType`)
- `Error` = 0 — Błąd
- `Warning` = 1 — Ostrzeżenie
- `Information` = 2 — Informacja
