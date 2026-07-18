# Pola i właściwości klasy biznesowej: `Soneta.Oceny.DefinicjaSekcjiDokumentu`
Nazwa tabeli: `DefSekcjiDok`
Tytuł: Definicja sekcji dokumentów
Opis: Definicja sekcji grupującej pozycje w dokumentach oceny. Umożliwia organizowanie elementów arkusza oceny w logiczne bloki tematyczne z określonym priorytetem wyświetlania i nazwą prezentowaną użytkownikowi.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaUI | `string` |  | Nazwa |  |
| NazwaWyswietlana | `string` | bazodanowe, tylko-odczyt | Nazwa wyświetlana |  |
| Priorytet | `int` | bazodanowe |  |  |
