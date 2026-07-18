# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji`
Nazwa tabeli: `ProRZasobOTPKomp`
Tytuł: Relacje zasobów operacji technologii i pozycji właściwości
Opis: Element szczegółowy zasobu operacji technologii (ProZasobOperacjiTechnologii). Wiąże zasób operacji technologicznej z wymaganą pozycją właściwości (kompetencji), określając operator porównania dla weryfikacji spełnienia wymagań kwalifikacyjnych lub parametrów technicznych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ZasobOperacjiTechnologii` → `ProZasobOperacjiTechnologii`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe |  | Liczba porządkowa relacji zasób operacji technologii pozycja właściwości. |
| Operator | `Soneta.ProdukcjaPro.ProOperatorPorownan` (enum) | bazodanowe |  | Operator dla relacji zasób operacji technologii pozycja właściwości. |
| PozycjaKompetencji | `Soneta.ProdukcjaPro.ProPozycjaKompetencji` | bazodanowe | Pozycja właściwości | Pozycja właściwości dla relacji zasób operacji technologii pozycja właściwości. |
| ZasobOperacjiTechnologii | `Soneta.ProdukcjaPro.ProZasobOperacjiTechnologii` | bazodanowe, guided-parent | Zasób operacji technologii | Zasób operacji technologii dla relacji zasób operacji technologii pozycja właściwości. |

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
