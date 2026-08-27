# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdOsobaWzorcowa`
Nazwa tabeli: `ProdOsobyWz`
Tytuł: Wzorce osób wykonujących operacje produkcyjne
Opis: Wzorcowe (abstrakcyjne) osoby produkcyjne definiujące role i stanowiska w procesie produkcji. Służą do planowania zapotrzebowania kadrowego w technologiach bez wskazywania konkretnych pracowników.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IProdOsoba`, `IProdZasob`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kompetencje | `SubTable<Soneta.Produkcja.ProdOsobaKompetencja>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa osoby wzorcowej. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis osoby wzorcowej. |
| Symbol | `string` | bazodanowe |  | Symbol, skrócona nazwa osoby. |
