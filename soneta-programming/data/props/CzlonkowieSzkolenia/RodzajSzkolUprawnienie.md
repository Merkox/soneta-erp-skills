# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.RodzajSzkolUprawnienie`
Nazwa tabeli: `RdzSzkUpraw`
Tytuł: Uprawnienie wydawane w ramach szkolenia.
Opis: Konfiguracja uprawnień zawodowych przyznawanych w ramach danego rodzaju szkolenia. Określa, jakie uprawnienia pracownicze mogą być nadane uczestnikowi po pozytywnym ukończeniu kursu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaUprawnienia | `Soneta.HR.DefinicjaUprawnienia` | bazodanowe |  |  |
| RodzajSzkol | `Soneta.CzlonkowieSzkolenia.RodzajSzkol` | bazodanowe |  |  |
