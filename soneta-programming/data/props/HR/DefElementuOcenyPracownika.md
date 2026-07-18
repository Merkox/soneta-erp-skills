# Pola i właściwości klasy biznesowej: `Soneta.HR.DefElementuOcenyPracownika`
Nazwa tabeli: `DefElemOcenPrac`
Tytuł: Definicje kryteriów ocen
Opis: Słownik kryteriów stosowanych w ocenach pracowniczych. Każde kryterium posiada nazwę, kategorię oraz opcjonalny limit punktowy, co pozwala budować spójne wzorce ocen.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kategoria | `string` | bazodanowe |  |  |
| Limit | `decimal` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisLinia | `string` | tylko-odczyt |  |  |
| OpisPierwszaLinia | `string` | tylko-odczyt |  |  |
| Wartości | `SubTable<Soneta.HR.WartośćElementuOcenyPracownika>` | podlista |  |  |
| ZLimitem | `bool` |  |  |  |
