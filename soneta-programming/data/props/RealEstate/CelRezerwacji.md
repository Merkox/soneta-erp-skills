# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.CelRezerwacji`
Nazwa tabeli: `CeleRezerwacji`
Tytuł: Cele rezerwacji
Opis: Słownik celów rezerwacji stanowisk pracy, np. praca stacjonarna, spotkanie, szkolenie. Pozwala klasyfikować rezerwacje oraz konfigurować ostrzeżenia przy wielokrotnych rezerwacjach tego samego dnia.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa celu rezerwacji |
| Symbol | `string` | bazodanowe | Symbol | Symbol celu rezerwacji |
| Weryfikacja | `bool` | bazodanowe | Weryfikacja | Czy wymaga ostrzeżenia przy kolejnych rezerwacjach tego dnia |
