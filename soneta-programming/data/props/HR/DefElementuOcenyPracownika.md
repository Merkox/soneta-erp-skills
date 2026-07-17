# Pola i właściwości klasy biznesowej: `Soneta.HR.DefElementuOcenyPracownika`
Nazwa tabeli: `DefElemOcenPrac`
Tytuł: Definicje kryteriów ocen
Opis: Słownik kryteriów stosowanych w ocenach pracowniczych. Każde kryterium posiada nazwę, kategorię oraz opcjonalny limit punktowy, co pozwala budować spójne wzorce ocen.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kategoria | `string` | bazodanowe |  |  |
| Limit | `decimal` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisLinia | `string` |  |  |  |
| OpisPierwszaLinia | `string` |  |  |  |
| Wartości | `Soneta.Business.SubTable<Soneta.HR.WartośćElementuOcenyPracownika>` |  |  |  |
| ZLimitem | `bool` |  |  |  |
