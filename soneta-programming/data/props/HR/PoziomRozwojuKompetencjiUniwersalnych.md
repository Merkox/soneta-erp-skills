# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiUniwersalnych`
Nazwa tabeli: `ZklPozRozKomUni`
Tytuł: Poziomy rozwoju kompetencji uniwersalnych
Opis: Definiuje poziomy dojrzałości kompetencji miękkich. Używany w profilu kompetencji pozwala określić kompetencje porządne i wymagane dla stanowiska.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| PozPierwEfekt | `bool` | bazodanowe | Poziom pierwszy efektywny |  |
| Priorytet | `int` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
