# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdOsobaWzorcowa`
Nazwa tabeli: `ProdOsobyWz`
Tytuł: Wzorce osób wykonujących operacje produkcyjne
Opis: Wzorcowe (abstrakcyjne) osoby produkcyjne definiujące role i stanowiska w procesie produkcji. Służą do planowania zapotrzebowania kadrowego w technologiach bez wskazywania konkretnych pracowników.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IProdOsoba`, `IProdZasob`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kompetencje | `Soneta.Business.SubTable<Soneta.Produkcja.ProdOsobaKompetencja>` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa osoby wzorcowej. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis osoby wzorcowej. |
| Symbol | `string` | bazodanowe |  | Symbol, skrócona nazwa osoby. |
