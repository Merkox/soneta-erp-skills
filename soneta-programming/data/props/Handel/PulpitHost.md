# Pola i właściwości klasy biznesowej: `Soneta.Handel.PulpitHost`
Nazwa tabeli: `PulpityHost`
Tytuł: Obiekty wykorzystywane w pulpitach
Opis: Powiązanie obiektów biznesowych (hostów) z pulpitami. Określa typ i przeznaczenie obiektu wyświetlanego na pulpicie użytkownika.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dla | `Soneta.Handel.PulpitHostDla` (enum) | bazodanowe |  |  |
| Host | `Soneta.Handel.IPulpitHost` | bazodanowe |  |  |
| Typ | `Soneta.Handel.PulpitHostTyp` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PulpitHostDla (`Soneta.Handel.PulpitHostDla`)
- `PulpitKontrahenta` = 0

### PulpitHostTyp (`Soneta.Handel.PulpitHostTyp`)
- `DefinicjaDokHan` = 0
- `Magazyn` = 1
