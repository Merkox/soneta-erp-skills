# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.DefinicjaTrasy`
Nazwa tabeli: `DefinicjeTras`
Tytuł: Definicje tras
Opis: Słownik predefiniowanych tras wykorzystywanych w ewidencji przebiegu pojazdów. Zawiera symbol, parametry trasy (typ, opis, cel, długość) oraz oznaczenie widoczności w pulpicie HR. Przyspiesza rejestrację przejazdów na powtarzalnych trasach służbowych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 1
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| PulpitHR | `bool` | bazodanowe | Pulpit HR | Definicja trasy widoczna w pulpicie HR |
| Symbol | `string` | bazodanowe |  | Symbol definicji trasy |
| Trasa | `Soneta.Samochodowka.Trasa` (subrow) | bazodanowe |  | Parametry trasy trasy |
| Trasa.Cel | `string` | bazodanowe |  | Opis trasy |
| Trasa.Dlugosc | `decimal` | bazodanowe |  | Długość trasy |
| Trasa.Opis | `string` | bazodanowe |  | Opis trasy |
| Trasa.Typ | `Soneta.Samochodowka.TypTrasy` (enum) | bazodanowe |  | Typ trasy |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypTrasy (`Soneta.Samochodowka.TypTrasy`)
- `Brak` = 0
- `Lokalna` = 1
- `Krajowa` = 2
- `Międzynarodowa` = 3
