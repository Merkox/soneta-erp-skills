# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdZasobWzorcowy`
Nazwa tabeli: `ProdZasobyW`
Tytuł: Produkcyjne zasoby wzorcowe
Opis: Wzorcowe (abstrakcyjne) zasoby produkcyjne definiujące kategorie maszyn, stanowisk i narzędzi wykorzystywanych w technologiach produkcyjnych. Służą do planowania operacji na poziomie typów zasobów, bez wskazywania konkretnych urządzeń fizycznych.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IProdZasob`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie zasobu. Zablokowane zasoby nie będą wyświetlane na listach wyboru. |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa zasobu wzorcowego. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis zasobu wzorcowego. |
| RelacjeZasobu | `Soneta.Business.SubTable<Soneta.Produkcja.ProdZasobRelacja>` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol, skrócona nazwa zasobu. |
| Wzorcowy | `bool` |  |  | Określa czy zasób jest wzorcowy. |
| ZasobyProdukcyjne | `Soneta.Business.SubTable<Soneta.Produkcja.ProdZasobRelacja>` |  |  |  |
