# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ModulSzkol`
Nazwa tabeli: `ModulySzkol`
Tytuł: Moduły szkoleniowe.
Opis: Moduły szkoleniowe stanowiące logiczne bloki tematyczne w ramach rodzaju szkolenia. Umożliwiają podział programu kursu na etapy lub semestry, do których przypisywane są przedmioty i grupy.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe |  |  |
| RodzajSzkol | `Soneta.CzlonkowieSzkolenia.RodzajSzkol` | bazodanowe |  |  |
