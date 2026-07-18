# Pola i właściwości klasy biznesowej: `Soneta.Kadry.BlokadaPracownika`
Nazwa tabeli: `BlokadyPrac`
Tytuł: Blokady pracowników
Opis: Blokada edycji danych pracownika dla określonej tabeli. Pozwala zablokować możliwość modyfikacji wybranych danych kadrowo-płacowych konkretnego pracownika.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| TableName | `string` | bazodanowe, tylko-odczyt |  |  |
