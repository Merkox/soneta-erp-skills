# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZajecieSala`
Nazwa tabeli: `ZajeciaSale`
Opis: Przypisanie sal szkoleniowych do zajęć. Łączy konkretne zajęcie z salą, w której się odbywa, umożliwiając kontrolę dostępności i unikanie konfliktów rezerwacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Sala | `Soneta.CzlonkowieSzkolenia.SalaSzkol` | bazodanowe |  |  |
| Zajecie | `Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase` | bazodanowe |  |  |
