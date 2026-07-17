# Pola i właściwości klasy biznesowej: `Soneta.Handel.PulpitHost`
Nazwa tabeli: `PulpityHost`
Tytuł: Obiekty wykorzystywane w pulpitach
Opis: Powiązanie obiektów biznesowych (hostów) z pulpitami. Określa typ i przeznaczenie obiektu wyświetlanego na pulpicie użytkownika.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dla | `Soneta.Handel.PulpitHostDla` | bazodanowe, enum |  |  |
| Host | `Soneta.Handel.IPulpitHost` | bazodanowe |  |  |
| Typ | `Soneta.Handel.PulpitHostTyp` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PulpitHostDla (`Soneta.Handel.PulpitHostDla`)
- `PulpitKontrahenta` = 0

### PulpitHostTyp (`Soneta.Handel.PulpitHostTyp`)
- `DefinicjaDokHan` = 0
- `Magazyn` = 1
