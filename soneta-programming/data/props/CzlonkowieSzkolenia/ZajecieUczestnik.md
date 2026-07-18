# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZajecieUczestnik`
Nazwa tabeli: `ZajeciaUcz`
Tytuł: Zgłoszenia na zajęcia
Opis: Ewidencja obecności uczestników na poszczególnych zajęciach. Rejestruje, który zgłoszony uczestnik był zapisany na dane zajęcie, umożliwiając kontrolę frekwencji i rozliczenie obecności.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GrupaSzkol | `Soneta.CzlonkowieSzkolenia.GrupaSzkol` | bazodanowe | Grupa szkoleniowa |  |
| Uczestnik | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | bazodanowe | Uczestnik |  |
| Zajecie | `Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase` | bazodanowe | Zajęcie |  |
