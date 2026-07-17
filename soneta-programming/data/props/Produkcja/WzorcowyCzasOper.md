# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.WzorcowyCzasOper`
Nazwa tabeli: `WzorcoweCzasOper`
Tytuł: Wzorcowe czasy operacji
Opis: Konfigurowalna definicja wzorcowego czasu operacji produkcyjnej. Stanowi szablon czasu (np. czas przygotowania, czas maszynowy, czas ręczny) z określonym typem, rodzajem i jednostką miary, który może być automatycznie dodawany do nowych operacji w technologii.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DodawanyDomyslnie | `bool` | bazodanowe | Dodawany domyślnie | Czas dodawany domyślnie. |
| Jednostka | `Soneta.Towary.Jednostka` | bazodanowe |  | Jednostka wzorcowego czasu. |
| Nazwa | `string` | bazodanowe |  | Nazwa wzorcowego czasu. |
| Rodzaj | `Soneta.Produkcja.RodzajCzasuOperacji` | bazodanowe, enum |  | Rodzaj wzorcowego czasu operacji. |
| Typ | `Soneta.Produkcja.TypCzasuOperacji` | bazodanowe, enum |  | Typ wzorcowego czasu operacji. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajCzasuOperacji (`Soneta.Produkcja.RodzajCzasuOperacji`)
- `Jednostkowy` = 0 — Jednostkowy
- `Stały` = 1
- `Wyliczany` = 2

### TypCzasuOperacji (`Soneta.Produkcja.TypCzasuOperacji`)
- `Przygotowawczy` = 0 — Przygotowawczy
- `Wykonania` = 1
- `Zakończeniowy` = 2
- `Międzyoperacyjny` = 3
