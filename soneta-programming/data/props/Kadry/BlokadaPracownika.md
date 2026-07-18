# Pola i właściwości klasy biznesowej: `Soneta.Kadry.BlokadaPracownika`
Nazwa tabeli: `BlokadyPrac`
Tytuł: Blokady pracowników
Opis: Blokada edycji danych pracownika dla określonej tabeli. Pozwala zablokować możliwość modyfikacji wybranych danych kadrowo-płacowych konkretnego pracownika.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| TableName | `string` | bazodanowe, tylko-odczyt |  |  |
