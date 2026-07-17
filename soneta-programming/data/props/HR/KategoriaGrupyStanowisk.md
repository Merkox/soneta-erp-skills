# Pola i właściwości klasy biznesowej: `Soneta.HR.KategoriaGrupyStanowisk`
Nazwa tabeli: `KatGrupyStan`
Tytuł: Kategorie grup stanowisk
Opis: Słownik kategorii służących do klasyfikacji grup stanowisk. Pozwala na hierarchiczne porządkowanie struktury stanowisk w organizacji według dowolnych kryteriów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe | Nazwa kategorii |  |
| Opis | `string` | bazodanowe | opis kategorii |  |
| Priorytet | `int` |  |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
