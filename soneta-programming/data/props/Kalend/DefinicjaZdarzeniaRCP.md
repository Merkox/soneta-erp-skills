# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaZdarzeniaRCP`
Nazwa tabeli: `DefZdarzenRCP`
Tytuł: Definicje zdarzeń RCP
Opis: Definicja zdarzenia rejestrowanego przez czytnik RCP. Określa kod, nazwę i rodzaj zdarzenia (np. wejście służbowe, wyjście prywatne), które może być przypisywane do rejestracji wejść i wyjść pracowników.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaRodzaj | `string` |  |  |  |
| Rodzaj | `Soneta.Kalend.RodzajZdarzeniaRCP` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajZdarzeniaRCP (`Soneta.Kalend.RodzajZdarzeniaRCP`)
- `Rozpoczecie` = 1 — Rozpoczęcie
- `Zakonczenie` = 2 — Zakończenie
