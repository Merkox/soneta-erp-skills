# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZajecieSala`
Nazwa tabeli: `ZajeciaSale`
Opis: Przypisanie sal szkoleniowych do zajęć. Łączy konkretne zajęcie z salą, w której się odbywa, umożliwiając kontrolę dostępności i unikanie konfliktów rezerwacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Sala | `Soneta.CzlonkowieSzkolenia.SalaSzkol` | bazodanowe |  |  |
| Zajecie | `Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase` | bazodanowe |  |  |
