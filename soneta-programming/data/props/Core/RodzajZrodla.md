# Pola i właściwości klasy biznesowej: `Soneta.Core.RodzajZrodla`
Nazwa tabeli: `RodzajeZrodel`
Tytuł: Rodzaje źródeł finansowania
Opis: Słownik rodzajów (kategorii) źródeł finansowania. Pozwala klasyfikować źródła finansowania wg rodzaju, np. budżetowe, pozabudżetowe. Każdy rodzaj posiada symbol, nazwę i flagę blokady.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IElementSlownika`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa źródła finansowania. |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol źródła finansowania |
| Zablokowane | `bool` | bazodanowe | Zablokowane | Źródło finansowania zablokowane |
