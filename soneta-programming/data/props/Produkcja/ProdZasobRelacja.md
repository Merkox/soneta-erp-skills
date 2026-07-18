# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdZasobRelacja`
Nazwa tabeli: `ProdZasobyRel`
Tytuł: Relacje zasobów produkcyjnych
Opis: Relacja łącząca zasób rzeczywisty (ProdZasob) z zasobem wzorcowym (ProdZasobWzorcowy). Umożliwia mapowanie konkretnych maszyn lub stanowisk na abstrakcyjne kategorie zasobów, dzięki czemu planowanie produkcji może operować na wzorcach, a realizacja przypisuje konkretne zasoby fizyczne.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ProdZasob | `Soneta.Produkcja.ProdZasob` | bazodanowe | Zasób rzeczywisty | Produkcyjny zasób rzeczywisty. |
| ProdZasobWzorcowy | `Soneta.Produkcja.ProdZasobWzorcowy` | bazodanowe | Zasób wzorcowy | Produkcyjny zasób wzorcowy. |
