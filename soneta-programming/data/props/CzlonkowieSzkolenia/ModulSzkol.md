# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ModulSzkol`
Nazwa tabeli: `ModulySzkol`
Tytuł: Moduły szkoleniowe.
Opis: Moduły szkoleniowe stanowiące logiczne bloki tematyczne w ramach rodzaju szkolenia. Umożliwiają podział programu kursu na etapy lub semestry, do których przypisywane są przedmioty i grupy.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe |  |  |
| RodzajSzkol | `Soneta.CzlonkowieSzkolenia.RodzajSzkol` | bazodanowe |  |  |
