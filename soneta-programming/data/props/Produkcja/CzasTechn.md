# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.CzasTechn`
Nazwa tabeli: `CzasyTechn`
Tytuł: Czasy operacji
Opis: Element szczegółowy operacji produkcyjnej (Operacja). Definiuje czas trwania operacji z podziałem na rodzaje (np. przygotowawczy, maszynowy) i typy, wraz z kosztem jednostkowym i jednostką czasu. Służy do planowania harmonogramu produkcji oraz kalkulacji kosztów robocizny i maszynogodzin.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CechaCzas | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha czasu | Definicja cechy algorytmicznej, służąca do wyliczenia czasu. |
| Czas | `Soneta.Types.Amount` | bazodanowe |  | Czas operacji. |
| JednostkaCzasuDlaKosztu | `Soneta.Towary.Jednostka` | bazodanowe | Jednostka czasu dla kosztu | Jednostka czasu dla kosztu jednostkowego. |
| Koszt | `Soneta.Types.Currency` |  |  | Koszt operacji. |
| KosztJednostkowy | `Soneta.Types.Currency` | bazodanowe | Koszt jednostkowy | Koszt jednostkowy czasu. |
| Operacja | `Soneta.Produkcja.Operacja` | bazodanowe |  | Określa operację dla danego czasu. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis czasu. |
| Rodzaj | `Soneta.Produkcja.RodzajCzasuOperacji` | bazodanowe, enum |  | Rodzaj czasu operacji. |
| Typ | `Soneta.Produkcja.TypCzasuOperacji` | bazodanowe, enum |  | Typ czasu operacji. |

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
