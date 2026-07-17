# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji`
Nazwa tabeli: `ProRZasobOZPKomp`
Tytuł: Relacje zasobów operacji zleceń i pozycji właściwości
Opis: Element szczegółowy zasobu operacji zlecenia (ProZasobOperacjiZlecenia). Wiąże zasób operacji zlecenia z wymaganą pozycją właściwości (kompetencji), określając operator porównania dla weryfikacji spełnienia wymagań kwalifikacyjnych przy doborze zasobów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ZasobOperacjiZlecenia` → `ProZasobOperacjiZlecenia`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe |  | Liczba porządkowa relacji zasób operacji zlecenia pozycja właściwości. |
| Operator | `Soneta.ProdukcjaPro.ProOperatorPorownan` | bazodanowe, enum |  | Operator dla relacji zasób operacji zlecenia pozycja właściwości. |
| PozycjaKompetencji | `Soneta.ProdukcjaPro.ProPozycjaKompetencji` | bazodanowe | Pozycja właściwości | Pozycja właściwości dla relacji zasób operacji zlecenia pozycja właściwości. |
| ZasobOperacjiZlecenia | `Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia` | bazodanowe, guided-parent | Zasób operacji zlecenia | Zasób operacji zlecenia dla relacji zasób operacji zlecenia pozycja właściwości. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProOperatorPorownan (`Soneta.ProdukcjaPro.ProOperatorPorownan`)
- `None` = 0
- `Rowny` = 1 — =
- `Nierowny` = 2 — ≠
- `Wiekszy` = 4 — >
- `WiekszyRowny` = 8 — ≥
- `Mniejszy` = 16 — <
- `MniejszyRowny` = 32 — ≤
- `All` = 63 — Wszystkie
