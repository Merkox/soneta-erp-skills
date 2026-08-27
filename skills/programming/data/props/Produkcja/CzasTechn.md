# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.CzasTechn`
Nazwa tabeli: `CzasyTechn`
Tytuł: Czasy operacji
Opis: Element szczegółowy operacji produkcyjnej (Operacja). Definiuje czas trwania operacji z podziałem na rodzaje (np. przygotowawczy, maszynowy) i typy, wraz z kosztem jednostkowym i jednostką czasu. Służy do planowania harmonogramu produkcji oraz kalkulacji kosztów robocizny i maszynogodzin.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CechaCzas | `FeatureDefinition` | bazodanowe | Cecha czasu | Definicja cechy algorytmicznej, służąca do wyliczenia czasu. |
| Czas | `Amount` | bazodanowe |  | Czas operacji. |
| JednostkaCzasuDlaKosztu | `Soneta.Towary.Jednostka` | bazodanowe | Jednostka czasu dla kosztu | Jednostka czasu dla kosztu jednostkowego. |
| Koszt | `Currency` | tylko-odczyt |  | Koszt operacji. |
| KosztJednostkowy | `Currency` | bazodanowe | Koszt jednostkowy | Koszt jednostkowy czasu. |
| Operacja | `Soneta.Produkcja.Operacja` | bazodanowe |  | Określa operację dla danego czasu. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis czasu. |
| Rodzaj | `Soneta.Produkcja.RodzajCzasuOperacji` (enum) | bazodanowe |  | Rodzaj czasu operacji. |
| Typ | `Soneta.Produkcja.TypCzasuOperacji` (enum) | bazodanowe |  | Typ czasu operacji. |

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
