# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdKompetencja`
Nazwa tabeli: `ProdKompetencje`
Tytuł: Słownik kompetencji osob produkcyjnych
Opis: Słownik kompetencji i kwalifikacji osób produkcyjnych. Definiuje umiejętności (np. obsługa CNC, spawanie, kontrola jakości) wymagane przy operacjach produkcyjnych i przypisywane pracownikom w celu weryfikacji uprawnień do wykonywania zadań.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie kompetencji. Zablokowane kompetencje nie będą wyświetlane na listach wyboru. |
| Nazwa | `string` | bazodanowe |  | Pełna nazwa kompetencji. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis kompetencji. |
| Symbol | `string` | bazodanowe |  | Symbol, skrócona nazwa kompetencji. |
