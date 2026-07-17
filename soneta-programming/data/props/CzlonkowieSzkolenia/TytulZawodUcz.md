# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.TytulZawodUcz`
Nazwa tabeli: `TytulyZawodUcz`
Tytuł: Tytuły zawodowe uczestników
Opis: Element szczegółowy uczestnika (TytulZawodUcz). Przypisuje tytuł zawodowy do konkretnego uczestnika, umożliwiając ewidencję wielu tytułów zawodowych posiadanych przez jednego członka.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `UczestnikBase` → `UczestnikBase`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| TytulZawodowy | `Soneta.CzlonkowieSzkolenia.Config.UczTytulZawod` | bazodanowe |  |  |
| UczestnikBase | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe, guided-parent |  |  |
