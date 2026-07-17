# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZajecieWykladowca`
Nazwa tabeli: `ZajeciaWykl`
Tytuł: Wykładowcy
Opis: Przypisanie wykładowców do zajęć szkoleniowych. Określa, który wykładowca prowadzi dane zajęcie wraz z jego rolą (np. prowadzący, asystent), umożliwiając planowanie obciążenia kadry dydaktycznej.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Typ | `Soneta.CzlonkowieSzkolenia.TypZajeciaWykladowcy` | bazodanowe, enum |  | Rola wykładowcy na zajęciu. |
| Wykladowca | `Soneta.CzlonkowieSzkolenia.WykladowcaSzkol` | bazodanowe |  |  |
| Zajecie | `Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypZajeciaWykladowcy (`Soneta.CzlonkowieSzkolenia.TypZajeciaWykladowcy`)
- `Lekcja` = 0 — Lekcja
- `Wizytacja` = 1
- `Komisja` = 2
