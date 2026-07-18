# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.TytulZawodUcz`
Nazwa tabeli: `TytulyZawodUcz`
Tytuł: Tytuły zawodowe uczestników
Opis: Element szczegółowy uczestnika (TytulZawodUcz). Przypisuje tytuł zawodowy do konkretnego uczestnika, umożliwiając ewidencję wielu tytułów zawodowych posiadanych przez jednego członka.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `UczestnikBase` → `UczestnikBase`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| TytulZawodowy | `Soneta.CzlonkowieSzkolenia.Config.UczTytulZawod` | bazodanowe, tylko-odczyt |  |  |
| UczestnikBase | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
