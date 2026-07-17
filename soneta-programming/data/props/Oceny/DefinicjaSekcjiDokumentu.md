# Pola i właściwości klasy biznesowej: `Soneta.Oceny.DefinicjaSekcjiDokumentu`
Nazwa tabeli: `DefSekcjiDok`
Tytuł: Definicja sekcji dokumentów
Opis: Definicja sekcji grupującej pozycje w dokumentach oceny. Umożliwia organizowanie elementów arkusza oceny w logiczne bloki tematyczne z określonym priorytetem wyświetlania i nazwą prezentowaną użytkownikowi.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaUI | `string` |  | Nazwa |  |
| NazwaWyswietlana | `string` | bazodanowe | Nazwa wyświetlana |  |
| Priorytet | `int` | bazodanowe |  |  |
