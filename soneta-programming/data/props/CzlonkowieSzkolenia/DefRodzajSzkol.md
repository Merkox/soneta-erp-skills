# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.DefRodzajSzkol`
Nazwa tabeli: `DefRodzajeSzkol`
Tytuł: Definicje rodzajów szkoleń
Opis: Słownik definicji rodzajów szkoleń określający parametry konfiguracyjne kursów. Definiuje typ szkolenia, formularz, możliwość wydawania wyróżnień i uprawnień oraz powiązanie z wnioskami.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowane | Określa zablokowanie definicji. |
| DefWniosku | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja wniosku | Definicja wniosku. |
| Formularz | `Soneta.CzlonkowieSzkolenia.FormKind` | bazodanowe, enum | Formularz | Rodzaj formularza. |
| IsFullForm | `bool` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa definicji | Nazwa definicji. |
| Przedmioty | `bool` | bazodanowe | Przedmioty | Zezwala na dodanie przedmiotów szkolenia. |
| Symbol | `string` | bazodanowe | Symbol definicji | Symbol definicji. |
| Typ | `Soneta.CzlonkowieSzkolenia.RodzajSzkolenia` | bazodanowe, enum |  |  |
| Uprawnienia | `bool` | bazodanowe | Uprawnienia | Zezwala na wygenerowanie uprawnień po szkoleniu. |
| Wyroznienia | `bool` | bazodanowe | Wyrożnienia | Zezwala na wygenerowanie wyróżnień po szkoleniu. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FormKind (`Soneta.CzlonkowieSzkolenia.FormKind`)
- `Full` = 0 — Pełny
- `Simple` = 1 — Prosty

### RodzajSzkolenia (`Soneta.CzlonkowieSzkolenia.RodzajSzkolenia`)
- `Standardowe` = 1
- `Rozszerzone` = 2
- `Wydarzenie` = 3
