# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.ZasobyINarzedzia.Wysilek`
Nazwa tabeli: `ZklWysilek`
Tytuł: Wysiłek
Opis: Słownik definiuje rodzaje i poziomy wysiłku fizycznego lub psychicznego. Jest używany w opisie ogólnym stanowiska do oceny obciążenia pracą i warunków zatrudnienia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
