# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdZasobWzorcowy`
Nazwa tabeli: `ProdZasobyW`
Tytuł: Produkcyjne zasoby wzorcowe
Opis: Wzorcowe (abstrakcyjne) zasoby produkcyjne definiujące kategorie maszyn, stanowisk i narzędzi wykorzystywanych w technologiach produkcyjnych. Służą do planowania operacji na poziomie typów zasobów, bez wskazywania konkretnych urządzeń fizycznych.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IProdZasob`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 3
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie zasobu. Zablokowane zasoby nie będą wyświetlane na listach wyboru. |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa zasobu wzorcowego. |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Opis zasobu wzorcowego. |
| RelacjeZasobu | `SubTable<Soneta.Produkcja.ProdZasobRelacja>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol, skrócona nazwa zasobu. |
| Wzorcowy | `bool` | tylko-odczyt |  | Określa czy zasób jest wzorcowy. |
| ZasobyProdukcyjne | `SubTable<Soneta.Produkcja.ProdZasobRelacja>` | podlista |  |  |
