# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdKompetencja`
Nazwa tabeli: `ProdKompetencje`
Tytuł: Słownik kompetencji osob produkcyjnych
Opis: Słownik kompetencji i kwalifikacji osób produkcyjnych. Definiuje umiejętności (np. obsługa CNC, spawanie, kontrola jakości) wymagane przy operacjach produkcyjnych i przypisywane pracownikom w celu weryfikacji uprawnień do wykonywania zadań.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie kompetencji. Zablokowane kompetencje nie będą wyświetlane na listach wyboru. |
| Nazwa | `string` | bazodanowe |  | Pełna nazwa kompetencji. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis kompetencji. |
| Symbol | `string` | bazodanowe |  | Symbol, skrócona nazwa kompetencji. |
