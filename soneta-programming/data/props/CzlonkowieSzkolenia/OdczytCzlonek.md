# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.OdczytCzlonek`
Nazwa tabeli: `OdczytyCzlonkow`
Tytuł: Odczyty członków
Opis: Ewidencja obecności członków na odczytach i wykładach. Łączy uczestnika z konkretnym odczytem, umożliwiając rejestrację frekwencji na wydarzeniach pozaszkoleniowych.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czlonek | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe | Członek |  |
| Odczyt | `Soneta.CzlonkowieSzkolenia.Odczyt` | bazodanowe | Odczyt |  |
